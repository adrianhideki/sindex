CREATE PROCEDURE dbo.st_GetFragmentedIndexes @database      varchar(100) = ''
                                            ,@table         varchar(100) = ''
                                            ,@type          varchar(50)  = ''
                                            ,@fragmentation numeric(8,4) = 0
AS
BEGIN
  IF OBJECT_ID('tempdb..#tb_indexes') IS NOT NULL
    DROP TABLE #tb_indexes;

  SELECT tableName                    = dbtables.[name]
        ,databaseName                 = db_name(indexstats.database_id)
        ,indexName                    = ISNULL(dbindexes.[name],'')
        ,avg_fragmentation_in_percent = CAST(indexstats.avg_fragmentation_in_percent AS numeric(8,4))
        ,indexType                    = dbindexes.type_desc
        ,defrag_action                = CASE 
                                          WHEN indexstats.index_type_desc = 'HEAP' THEN 'ALTER TABLE ' + QUOTENAME(DB_NAME(indexstats.database_id)) + '.' + QUOTENAME(dbschemas.name) + '.' + QUOTENAME(dbtables.name) + ' REBUILD;'
                                          WHEN indexstats.avg_fragmentation_in_percent > 30. THEN 'ALTER INDEX ' + QUOTENAME(dbindexes.name) + ' ON ' + QUOTENAME(DB_NAME(indexstats.database_id)) + '.' + QUOTENAME(dbschemas.name) + '.' + QUOTENAME(dbtables.name) + ' REBUILD WITH (ONLINE = OFF);'
                                          WHEN indexstats.avg_fragmentation_in_percent BETWEEN 5 AND 30 THEN 'ALTER INDEX ' + QUOTENAME(dbindexes.name) + ' ON ' + QUOTENAME(DB_NAME(indexstats.database_id)) + '.' + QUOTENAME(dbschemas.name) + '.' + QUOTENAME(dbtables.name) + ' REORGANIZE;'
                                          ELSE 'No Action'
                                        END
        ,selecionado                  = CAST(0 AS bit)
  INTO #tb_indexes
  FROM sys.dm_db_index_physical_stats (DB_ID(), NULL, NULL, NULL, NULL) AS indexstats
        INNER JOIN sys.tables dbtables 
        ON dbtables.[object_id] = indexstats.[object_id]
        INNER JOIN sys.schemas dbschemas 
        ON dbtables.[schema_id] = dbschemas.[schema_id]
        INNER JOIN sys.indexes AS dbindexes 
        ON dbindexes.[object_id] = indexstats.[object_id] AND 
          dbindexes.index_id    = indexstats.index_id
  WHERE indexstats.database_id IN (SELECT db_id([database_name]) FROM [dbo].[database] WHERE [database].ativo = 1)
    AND indexstats.avg_fragmentation_in_percent >= 5
  ORDER BY indexstats.avg_fragmentation_in_percent DESC;

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
