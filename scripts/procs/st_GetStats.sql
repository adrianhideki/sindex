CREATE PROCEDURE dbo.st_GetStats
AS
BEGIN
  SET NOCOUNT ON;

  DECLARE @db_name varchar(255) = ''
         ,@db_uid  int = 0
         ,@cmd     varchar(MAX) = '';

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
  INSERT INTO sindex.dbo.[stat](
    stat_name
   ,update_date
   ,create_date
   ,type
   ,table_uid
   ,filter
   ,is_autocreated
   ,database_uid
   ,columns
  )
  SELECT stat_name      = stats.name
        ,update_date    = GETDATE()
        ,create_date    = GETDATE()
        ,type           = ''''
        ,table_uid      = [table].table_uid
        ,filter         = ISNULL(stats.filter_definition,'''')
        ,is_autocreated = stats.auto_created
        ,database_uid   = @db_uid
        ,ISNULL(STUFF(_columns.col,1,1,''''),'''')
  FROM [db].sys.stats 
       CROSS APPLY (SELECT '',''+columns.name
                    FROM [db].sys.stats_columns
                         INNER JOIN [db].sys.columns
                         ON columns.object_id = stats_columns.object_id AND 
                            columns.column_id = stats_columns.column_id
                    WHERE stats_columns.stats_id = stats.stats_id
                    ORDER BY stats_columns.stats_column_id
                    FOR XML PATH ('''')) _columns (col)
       INNER JOIN sindex.dbo.[table]
       ON [table].object_id    = stats.object_id AND
          [table].database_uid = @db_uid
  WHERE NOT EXISTS(SELECT 1
                   FROM sindex.dbo.[stat]
                   WHERE [stat].stat_name COLLATE Latin1_General_CI_AS = stats.name COLLATE Latin1_General_CI_AS
                     AND [stat].database_uid = @db_uid);

  DELETE FROM sindex.dbo.[stat]
  WHERE NOT EXISTS(SELECT 1
                   FROM [db].sys.stats
                   WHERE stats.name COLLATE Latin1_General_CI_AS = [stat].stat_name COLLATE Latin1_General_CI_AS)
    AND [stat].database_uid = @db_uid;

  UPDATE [stat]
     SET update_date    = GETDATE()
        ,type           = ''''
        ,table_uid      = [table].table_uid
        ,filter         = stats.filter_definition
        ,is_autocreated = stats.auto_created
        ,[columns]      = ISNULL(STUFF(_columns.col,1,1,''''),'''')
  FROM sindex.dbo.[stat]
       INNER JOIN [db].sys.stats 
       ON stats.name COLLATE Latin1_General_CI_AS = [stat].stat_name COLLATE Latin1_General_CI_AS
       CROSS APPLY (SELECT '',''+columns.name
                    FROM [db].sys.stats_columns
                         INNER JOIN [db].sys.columns
                         ON columns.object_id = stats_columns.object_id AND 
                            columns.column_id = stats_columns.column_id
                    WHERE stats_columns.stats_id = stats.stats_id
                    ORDER BY stats_columns.stats_column_id
                    FOR XML PATH ('''')) _columns (col)
       INNER JOIN sindex.dbo.[table]
       ON [table].object_id    = stats.object_id AND
          [table].database_uid = @db_uid
  WHERE [table].database_uid = @db_uid
    AND EXISTS(SELECT 1 WHERE [stat].table_uid <> [table].table_uid
               UNION ALL
               SELECT 1 WHERE [stat].filter COLLATE Latin1_General_CI_AS <> stats.filter_definition COLLATE Latin1_General_CI_AS
               UNION ALL
               SELECT 1 WHERE [stat].is_autocreated <> stats.auto_created
               UNION ALL
               SELECT 1 WHERE [stat].[columns] <> ISNULL(STUFF(_columns.col,1,1,''''),''''));
  ';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END

  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END