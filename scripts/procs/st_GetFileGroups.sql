CREATE PROCEDURE dbo.st_GetFilegroups
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
    INSERT INTO sindex.dbo.[filegroup](
      database_uid
     ,filegroup_name
     ,filegroup_type
     ,update_date
    )
    SELECT database_uid = @db_uid
          ,filegroup_name = filegroups.name
          ,filegroup_type = filegroups.type
          ,update_date    = GETDATE()
    FROM [db].sys.filegroups
    WHERE NOT EXISTS(SELECT 1
                     FROM sindex.dbo.[filegroup]
                     WHERE [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS
                       AND [filegroup].database_uid   = @db_uid);

    DELETE FROM sindex.dbo.[filegroup]
    WHERE [filegroup].database_uid = @db_uid
      AND NOT EXISTS(SELECT 1
                     FROM [db].sys.filegroups
                     WHERE filegroups.name COLLATE Latin1_General_CI_AS = [filegroup].filegroup_name COLLATE Latin1_General_CI_AS)

    UPDATE [filegroup]
       SET filegroup_type = filegroups.type
          ,update_date = GETDATE()
    FROM sindex.dbo.[filegroup]
         INNER JOIN [db].sys.filegroups
         ON filegroups.name COLLATE Latin1_General_CI_AS = [filegroup].filegroup_name COLLATE Latin1_General_CI_AS
    WHERE [filegroup].database_uid = @db_uid
      AND filegroups.type COLLATE Latin1_General_CI_AS <> [filegroup].filegroup_type COLLATE Latin1_General_CI_AS;';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END
  
  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END