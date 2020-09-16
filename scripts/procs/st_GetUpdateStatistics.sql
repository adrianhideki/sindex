CREATE PROCEDURE dbo.st_GetUpdateStatistics @fullscan       bit = 0
                                           ,@sample         bit = 0
                                           ,@resample       bit = 0
                                           ,@percent        int = 0
                                           ,@rows           int = 0
                                           ,@tablesWithData bit = 0
                                           ,@database       varchar(100) = ''
                                           ,@object         varchar(100) = ''
                                           ,@stat           varchar(100) = ''
                                           ,@minDays        int = 0
AS
BEGIN
  SET NOCOUNT ON;
  DECLARE @db_name varchar(100) = ''
         ,@cmd     varchar(MAX) = ''
         ,@db_uid  integer      = 0;

  IF OBJECT_ID('tempdb..#tb_main') IS NOT NULL
    DROP TABLE #tb_main;

  CREATE TABLE #tb_main(
    statName       varchar(300) COLLATE Latin1_General_CI_AS
   ,objectName     varchar(300) COLLATE Latin1_General_CI_AS
   ,schemaName     varchar(300) COLLATE Latin1_General_CI_AS
   ,autoCreated    bit
   ,statUpdateDate datetime
   ,databaseName   varchar(300) COLLATE Latin1_General_CI_AS
   ,scriptUpdate   varchar(MAX) COLLATE Latin1_General_CI_AS
  );

  SELECT @minDays = ISNULL(@minDays, 0);

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

      IF OBJECT_ID(''tempdb..#tb_stats'') IS NOT NULL
        DROP TABLE #tb_stats;

      SELECT statName       = stats.name
            ,objectName     = objects.name
            ,schemaName     = schemas.name
            ,autoCreated    = stats.auto_created
            ,statUpdateDate = ISNULL(STATS_DATE(stats.object_id, stats.stats_id),''1900-01-01'')
            ,databaseName   = ''[db]''
      INTO #tb_stats
      FROM [db].sys.stats
           INNER JOIN [db].sys.objects
           ON objects.object_id = stats.object_id
           INNER JOIN [db].sys.schemas
           ON schemas.schema_id = objects.schema_id
      WHERE objects.type NOT IN (''S'',''IT'')
        AND EXISTS(SELECT 1 WHERE @tablesWithData = 0
                   UNION ALL
                   SELECT 1 FROM [db].sys.partitions WHERE @tablesWithData = 1 AND partitions.object_id = stats.object_id AND partitions.rows > 0);

      INSERT INTO #tb_main(statName, objectName, schemaName, autoCreated, statUpdateDate, databaseName)
      SELECT statName, objectName, schemaName, autoCreated, statUpdateDate, databaseName
      FROM #tb_stats AS tb
      WHERE DATEDIFF(DAY,tb.statUpdateDate,GETDATE()) >= @minDays
        AND EXISTS(SELECT 1 WHERE ISNULL(@database,'''') = ''''
                   UNION ALL
                   SELECT 1 WHERE tb.databaseName LIKE ''%'' + ISNULL(@database,'''') + ''%'')
        AND EXISTS(SELECT 1 WHERE ISNULL(@object,'''') = ''''
                   UNION ALL
                   SELECT 1 WHERE tb.objectName LIKE ''%'' + ISNULL(@object,'''') + ''%'')
        AND EXISTS(SELECT 1 WHERE ISNULL(@stat,'''') = ''''
                   UNION ALL
                   SELECT 1 WHERE tb.statName LIKE ''%'' + ISNULL(@stat,'''') + ''%'')
      OPTION(RECOMPILE);'

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@database',   CHAR(39) + CAST(@database       AS varchar(300)) + CHAR(39))
          ,@cmd = REPLACE(@cmd,'@object',     CHAR(39) + CAST(@object         AS varchar(300)) + CHAR(39))
          ,@cmd = REPLACE(@cmd,'@stat',       CHAR(39) + CAST(@stat           AS varchar(300)) + CHAR(39))
          ,@cmd = REPLACE(@cmd,'@minDays',               CAST(@minDays        AS varchar(300)))
          ,@cmd = REPLACE(@cmd,'@tablesWithData',        CAST(@tablesWithData AS varchar(300)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END
  
  UPDATE #tb_main
     SET databaseName = REPLACE(REPLACE(databaseName,'[',''),']','')
  FROM #tb_main;

  UPDATE #tb_main
     SET scriptUpdate = 'UPDATE STATISTICS ' + QUOTENAME(databaseName) + '.' + QUOTENAME(schemaName) + '.' + QUOTENAME(objectName) + '(' + QUOTENAME(statName) + ')' + 
                         CASE WHEN @fullscan = 1 THEN ' WITH FULLSCAN'
                              WHEN @sample   = 1 THEN ' WITH SAMPLE ' + CASE WHEN @percent > 0 THEN CAST(@percent AS varchar(100)) + ' PERCENT'
                                                                             WHEN @rows    > 0 THEN CAST(@rows    AS varchar(100)) + ' ROWS'
                                                                             ELSE ''
                                                                        END
                              WHEN @resample = 1 THEN ' WITH RESAMPLE'
                              ELSE ''
                         END + ';'
  FROM #tb_main;

  SELECT statName
        ,objectName
        ,autoCreated
        ,daysLastUpdate = DATEDIFF(DAY,statUpdateDate,GETDATE())
        ,statUpdateDate
        ,databaseName
        ,scriptUpdate
        ,selecionado = CAST(0 AS bit)
  FROM #tb_main;
END