IF OBJECT_ID('dbo.st_GetFiles') IS NOT NULL
  DROP PROCEDURE dbo.st_GetFiles;
GO
CREATE PROCEDURE dbo.st_GetFiles
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
      WHERE EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN
    SELECT @cmd = '
    INSERT INTO sindex.dbo.[file](
      file_name
     ,file_size_kb
     ,filegroup_uid
     ,update_date
     ,file_path
     ,file_growth_size_kb
     ,database_uid
    )
    SELECT file_name = database_files.name
          ,file_size_kb = (database_files.size * 8.)
          ,filegroup_uid = [filegroup].filegroup_uid
          ,update_date = GETDATE()
          ,file_path = database_files.physical_name
          ,file_growth_size_kb = (database_files.growth * 8.)
          ,database_uid = @db_uid
    FROM [db].sys.database_files
         INNER JOIN [db].sys.filegroups
         ON filegroups.data_space_id = database_files.data_space_id
         INNER JOIN sindex.dbo.[filegroup]
         ON [filegroup].database_uid   = @db_uid AND
            [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS
    WHERE NOT EXISTS (SELECT 1
                      FROM sindex.dbo.[file]
                      WHERE [file].file_name COLLATE Latin1_General_CI_AS = database_files.name COLLATE Latin1_General_CI_AS
                        AND [file].filegroup_uid = [filegroup].filegroup_uid);

    DELETE [file] 
    FROM sindex.dbo.[file]
    WHERE [file].database_uid = @db_uid
      AND NOT EXISTS(SELECT 1
                     FROM [db].sys.database_files
                          INNER JOIN [db].sys.filegroups
                          ON filegroups.data_space_id = database_files.data_space_id
                          INNER JOIN sindex.dbo.[filegroup]
                          ON [filegroup].database_uid   = @db_uid AND
                             [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS
                     WHERE database_files.name COLLATE Latin1_General_CI_AS = [file].file_name COLLATE Latin1_General_CI_AS
                       AND [filegroup].filegroup_uid                        = [file].filegroup_uid);

    UPDATE [file]
       SET file_name           = database_files.name
          ,file_size_kb        = (database_files.size * 8.)
          ,update_date         = GETDATE()
          ,file_path           = database_files.physical_name
          ,file_growth_size_kb = (database_files.growth * 8.)
    FROM sindex.dbo.[file]
         INNER JOIN [db].sys.database_files
         ON database_files.name COLLATE Latin1_General_CI_AS = [file].file_name COLLATE Latin1_General_CI_AS
         INNER JOIN [db].sys.filegroups
         ON filegroups.data_space_id = database_files.data_space_id
         INNER JOIN sindex.dbo.[filegroup]
         ON [filegroup].database_uid   = @db_uid AND
            [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
            [filegroup].filegroup_uid = [file].filegroup_uid
    WHERE [file].database_uid = @db_uid
      AND([file].file_name COLLATE Latin1_General_CI_AS <> database_files.name COLLATE Latin1_General_CI_AS
       OR [file].file_size_kb <> (database_files.size * 8.)
       OR [file].file_path COLLATE Latin1_General_CI_AS <> database_files.physical_name COLLATE Latin1_General_CI_AS
       OR [file].file_growth_size_kb <> (database_files.growth * 8.));';
       
    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END
  
  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END