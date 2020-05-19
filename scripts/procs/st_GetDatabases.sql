CREATE PROCEDURE dbo.st_GetDatabases
AS
BEGIN
  SET NOCOUNT ON;

  INSERT INTO dbo.[database](
    database_id
   ,server_id
   ,database_name
   ,update_date
  )
  SELECT database_id   = databases.database_id
        ,server_id     = fn.server_id
        ,database_name = databases.name
        ,update_date   = GETDATE()
  FROM sys.databases
       CROSS APPLY dbo.fn_GetServerId() fn
  WHERE NOT EXISTS(SELECT 1
                   FROM dbo.[database] as dat
				   WHERE dat.database_id = databases.database_id
				     AND dat.server_id   = fn.server_id);

  DELETE [database]
  FROM dbo.[database]
  WHERE NOT EXISTS(SELECT 1
                   FROM sys.databases 
                   WHERE databases.database_id = [database].database_id);

  UPDATE [database]
     SET database_name = databases.name
        ,update_date   = GETDATE()
  FROM dbo.[database]
       INNER JOIN sys.databases
       ON databases.database_id = [database].database_id
  WHERE databases.name <> [database].database_name;
END