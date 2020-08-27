IF OBJECT_ID('dbo.fn_GetServerId') IS NOT NULL
  DROP FUNCTION dbo.fn_GetServerId;
GO
CREATE FUNCTION dbo.fn_GetServerId()
RETURNS TABLE
AS RETURN(
  SELECT [server].server_id
  FROM sys.servers
       INNER JOIN dbo.[server]
	   ON [server].server_name = servers.name
);