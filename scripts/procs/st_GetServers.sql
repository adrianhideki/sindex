IF OBJECT_ID('dbo.st_GetServers') IS NOT NULL
  DROP PROCEDURE dbo.st_GetServers;
GO
CREATE PROCEDURE dbo.st_GetServers
AS
BEGIN
  SET NOCOUNT ON;

  INSERT INTO dbo.[server](
    server_name
   ,update_date
  )
  SELECT servers.name
        ,update_date = GETDATE()
  FROM sys.servers
  WHERE NOT EXISTS(SELECT 1
                   FROM dbo.[server] 
				   WHERE [server].server_name COLLATE Latin1_General_CI_AS = servers.name COLLATE Latin1_General_CI_AS);

  DELETE FROM dbo.[server]
  WHERE NOT EXISTS(SELECT 1
                   FROM sys.servers
                   WHERE servers.name COLLATE Latin1_General_CI_AS = [server].server_name COLLATE Latin1_General_CI_AS);
END