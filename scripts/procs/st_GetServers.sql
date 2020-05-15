CREATE PROCEDURE dbo.st_GetServers 
AS
BEGIN
  INSERT INTO dbo.[server](
    server_name
   ,update_date
  )
  SELECT servers.name
        ,update_date = GETDATE()
  FROM sys.servers
  WHERE NOT EXISTS(SELECT 1
                   FROM dbo.[server] 
				   WHERE [server].server_name = servers.name);
END