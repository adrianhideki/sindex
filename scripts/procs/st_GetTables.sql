CREATE PROCEDURE dbo.st_GetTables
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
           ON [database].database_id = databases.database_id
      WHERE EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN
    SELECT @cmd = '
  INSERT INTO sindex.dbo.[table](
    table_id
   ,filegroup_uid
   ,table_name
   ,update_date
   ,create_date
   ,type
   ,database_uid
  )
  SELECT table_id = tables.object_id
        ,filegroup_uid =  [filegroup].filegroup_uid
        ,table_name = tables.name
        ,update_date = GETDATE()
        ,create_date = tables.create_date
        ,type = tables.type
        ,db_uid = @db_uid
  FROM sys.tables 
       INNER JOIN sys.indexes
       ON indexes.object_id = tables.object_id AND
          indexes.type IN (0,1)
       INNER JOIN sys.filegroups
       ON filegroups.data_space_id = indexes.data_space_id
       INNER JOIN sindex.dbo.[filegroup]
       ON [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
          [filegroup].database_uid = @db_uid
  WHERE NOT EXISTS(SELECT 1
                   FROM sindex.dbo.[table]
                   WHERE [table].table_name COLLATE Latin1_General_CI_AS = tables.name COLLATE Latin1_General_CI_AS
                     AND [table].database_uid = @db_uid);

  DELETE FROM sindex.dbo.[table]
  WHERE NOT EXISTS(SELECT 1
                   FROM sys.tables
                   WHERE tables.name COLLATE Latin1_General_CI_AS = [table].table_name COLLATE Latin1_General_CI_AS)
    AND [table].database_uid = @db_uid;

  UPDATE [table]
     SET table_id      = tables.object_id
        ,filegroup_uid = [filegroup].database_uid
        ,table_name    = tables.name
        ,update_date   = GETDATE()
        ,create_date   = tables.create_date
        ,type          = tables.type
        ,database_uid  = @db_uid
  FROM sindex.dbo.[table]
       INNER JOIN sys.tables 
       ON tables.name COLLATE Latin1_General_CI_AS = [table].table_name COLLATE Latin1_General_CI_AS
       INNER JOIN sys.indexes
       ON indexes.object_id = tables.object_id AND
          indexes.type IN (0,1)
       INNER JOIN sys.filegroups
       ON filegroups.data_space_id = indexes.data_space_id
       INNER JOIN sindex.dbo.[filegroup]
       ON [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
          [filegroup].database_uid = @db_uid
  WHERE [table].database_uid = @db_uid
    AND EXISTS(SELECT 1 WHERE [table].table_id <> tables.object_id
               UNION ALL
               SELECT 1 WHERE [table].filegroup_uid <> [filegroup].database_uid
               UNION ALL
               SELECT 1 WHERE [table].table_name COLLATE Latin1_General_CI_AS <> tables.name COLLATE Latin1_General_CI_AS
               UNION ALL
               SELECT 1 WHERE [table].create_date <> tables.create_date
               UNION ALL
               SELECT 1 WHERE [table].type COLLATE Latin1_General_CI_AS <> tables.type COLLATE Latin1_General_CI_AS);';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END
  
  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END