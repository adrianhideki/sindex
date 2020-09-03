CREATE FUNCTION dbo.fn_GetServerId()
RETURNS TABLE
AS RETURN(
  SELECT [server].server_id
  FROM sys.servers
       INNER JOIN dbo.[server]
	   ON [server].server_name = servers.name
);