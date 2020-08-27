IF OBJECT_ID('dbo.st_GetDatabases') IS NOT NULL
  DROP PROCEDURE dbo.st_GetDatabases;
GO
CREATE PROCEDURE dbo.st_GetDatabases
AS
BEGIN
  SET NOCOUNT ON;

  INSERT INTO dbo.[database](
    server_id
   ,database_name
   ,update_date
  )
  SELECT server_id     = fn.server_id
        ,database_name = databases.name
        ,update_date   = GETDATE()
  FROM sys.databases
       CROSS APPLY dbo.fn_GetServerId() fn
  WHERE NOT EXISTS(SELECT 1
                   FROM dbo.[database] as dat
				   WHERE dat.database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
				     AND dat.server_id   = fn.server_id);

  DELETE [database]
  FROM dbo.[database]
  WHERE NOT EXISTS(SELECT 1
                   FROM sys.databases 
                   WHERE databases.name COLLATE Latin1_General_CI_AS = [database].database_name COLLATE Latin1_General_CI_AS);

  UPDATE [database]
     SET update_date = GETDATE()
  FROM dbo.[database]
       INNER JOIN sys.databases
       ON databases.name COLLATE Latin1_General_CI_AS = [database].database_name COLLATE Latin1_General_CI_AS;
END