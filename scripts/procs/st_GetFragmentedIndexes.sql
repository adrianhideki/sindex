CREATE PROCEDURE dbo.st_GetFragmentedIndexes @database       varchar(100) = ''
                                            ,@table          varchar(100) = ''
                                            ,@type           varchar(50)  = ''
                                            ,@tablesWithData bit = 0
                                            ,@fragmentation  numeric(8,4) = 0
AS
BEGIN
  DECLARE @db_name varchar(100) = ''
         ,@cmd     varchar(MAX) = ''
         ,@db_uid  integer      = 0;

  IF OBJECT_ID('tempdb..#tb_indexes') IS NOT NULL
    DROP TABLE #tb_indexes;

  CREATE TABLE #tb_indexes (
    tableName                    varchar(300)  COLLATE Latin1_General_CI_AS
   ,databaseName                 varchar(300)  COLLATE Latin1_General_CI_AS
   ,indexName                    varchar(300)  COLLATE Latin1_General_CI_AS
   ,avg_fragmentation_in_percent numeric(8,4)
   ,indexType                    varchar(100)  COLLATE Latin1_General_CI_AS
   ,defrag_action                varchar(3000) COLLATE Latin1_General_CI_AS
   ,selecionado                  bit
  );

  DECLARE curDatabases CURSOR LOCAL FAST_FORWARD
  FOR SELECT databases.name
            ,[database].database_uid
      FROM sys.databases
           INNER JOIN dbo.[database]
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
      WHERE [database].ativo = 1
        AND EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN
    SELECT @cmd = '
  USE [db];

  INSERT INTO #tb_indexes(
    tableName
   ,databaseName
   ,indexName
   ,avg_fragmentation_in_percent
   ,indexType
   ,defrag_action
   ,selecionado
  )
  SELECT tableName                    = objects.name
        ,databaseName                 = db_name(indexstats.database_id)
        ,indexName                    = ISNULL(indexes.name,'''')
        ,avg_fragmentation_in_percent = CAST(indexstats.avg_fragmentation_in_percent AS numeric(8,4))
        ,indexType                    = indexes.type_desc
        ,defrag_action                = CASE 
                                          WHEN indexstats.index_type_desc = ''HEAP'' THEN ''ALTER TABLE '' + QUOTENAME(DB_NAME(indexstats.database_id)) + ''.'' + QUOTENAME(dbschemas.name) + ''.'' + QUOTENAME(objects.name) + '' REBUILD;''
                                          WHEN indexstats.avg_fragmentation_in_percent > 30. THEN ''ALTER INDEX '' + QUOTENAME(indexes.name) + '' ON '' + QUOTENAME(DB_NAME(indexstats.database_id)) + ''.'' + QUOTENAME(dbschemas.name) + ''.'' + QUOTENAME(objects.name) + '' REBUILD WITH (ONLINE = OFF);''
                                          WHEN indexstats.avg_fragmentation_in_percent BETWEEN 5 AND 30 THEN ''ALTER INDEX '' + QUOTENAME(indexes.name) + '' ON '' + QUOTENAME(DB_NAME(indexstats.database_id)) + ''.'' + QUOTENAME(dbschemas.name) + ''.'' + QUOTENAME(objects.name) + '' REORGANIZE;''
                                          ELSE ''No Action''
                                        END
        ,selecionado                  = CAST(0 AS bit)
  FROM [db].sys.dm_db_index_physical_stats (DB_ID(), NULL, NULL, NULL, NULL) AS indexstats
        INNER JOIN [db].sys.objects
        ON objects.object_id = indexstats.object_id
        INNER JOIN [db].sys.schemas dbschemas 
        ON objects.schema_id = dbschemas.schema_id
        INNER JOIN [db].sys.indexes 
        ON indexes.object_id = indexstats.object_id AND 
           indexes.index_id  = indexstats.index_id
  WHERE indexstats.database_id = DB_ID()
    AND indexstats.avg_fragmentation_in_percent >= 5
    AND EXISTS(SELECT 1 WHERE @tablesWithData = 0
               UNION ALL
               SELECT 1 FROM [db].sys.partitions WITH (NOLOCK) WHERE @tablesWithData = 1 AND partitions.object_id = indexstats.object_id AND partitions.rows > 0)
  ORDER BY indexstats.avg_fragmentation_in_percent DESC;';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@tablesWithData', CAST(@tablesWithData AS VarChar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END

  SELECT *
  FROM #tb_indexes AS tb
  WHERE EXISTS(SELECT 1 WHERE ISNULL(@database,'') = ''
               UNION ALL
               SELECT 1 WHERE tb.databaseName LIKE '%' + ISNULL(@database,'') + '%')
    AND EXISTS(SELECT 1 WHERE ISNULL(@table,'') = ''
               UNION ALL
               SELECT 1 WHERE tb.tableName LIKE '%' + ISNULL(@table,'') + '%')
    AND EXISTS(SELECT 1 WHERE ISNULL(@type,'') = ''
               UNION ALL
               SELECT 1 WHERE tb.indexType LIKE '%' + ISNULL(@type,'') + '%')
    AND EXISTS(SELECT 1 WHERE ISNULL(@fragmentation,0) = 0
               UNION ALL
               SELECT 1 WHERE tb.avg_fragmentation_in_percent >= ISNULL(@fragmentation,0));
END
