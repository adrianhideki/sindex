CREATE PROCEDURE dbo.st_GetConStatus
AS 
BEGIN
  ;WITH CTA
  AS (
    SELECT spid
    FROM sys.sysprocesses
    GROUP BY spid
  )
  SELECT TotalConnections      = COUNT(1)
        ,SystemConnections     = SUM(CASE WHEN _proc.system_con    > 0 THEN 1 ELSE 0 END)
        ,UserConnections       = SUM(CASE WHEN _proc.system_con    = 0 THEN 1 ELSE 0 END)
        ,BlockedConnections    = SUM(CASE WHEN _proc.blocked       > 0 THEN 1 ELSE 0 END)
        ,ParallelConnections   = SUM(CASE WHEN _proc.ecid          > 0 THEN 1 ELSE 0 END)
        ,TranOpenConnections   = SUM(CASE WHEN _proc.tran_count    > 0 THEN 1 ELSE 0 END)
        ,BackgroundConnections = SUM(CASE WHEN _proc.is_background > 0 THEN 1 ELSE 0 END)
        ,SleepingConnections   = SUM(CASE WHEN _proc.is_sleeping   > 0 THEN 1 ELSE 0 END)
        ,RunnableConnections   = SUM(CASE WHEN _proc.is_runnable   > 0 THEN 1 ELSE 0 END)
  FROM CTA
       CROSS APPLY (
         SELECT system_con    = SUM(CASE WHEN sysprocesses.spid      <= 50 THEN 1 ELSE 0 END)
               ,blocked       = SUM(CASE WHEN sysprocesses.blocked   <> 0  THEN 1 ELSE 0 END)
               ,ecid          = SUM(CASE WHEN sysprocesses.ecid      <> 0  THEN 1 ELSE 0 END)
               ,tran_count    = SUM(CASE WHEN sysprocesses.open_tran <> 0  THEN 1 ELSE 0 END)
               ,is_background = SUM(CASE WHEN sysprocesses.status = 'background'  THEN 1 ELSE 0 END)
               ,is_sleeping   = SUM(CASE WHEN sysprocesses.status = 'sleeping'    THEN 1 ELSE 0 END)
               ,is_runnable   = SUM(CASE WHEN sysprocesses.status = 'runnable'    THEN 1 ELSE 0 END)
         FROM sys.sysprocesses
         WHERE sysprocesses.spid = CTA.spid
         GROUP BY spid
       ) _proc
END