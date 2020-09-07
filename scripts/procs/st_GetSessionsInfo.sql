CREATE PROCEDURE dbo.st_GetSessionsInfo @userConnections bit          = 0
                                       ,@db_name         varchar(100) = ''
                                       ,@host_name       varchar(100) = ''
                                       ,@status          varchar(100) = ''
                                       ,@only_blocked    bit          = 0
                                       ,@reads           int          = 0
                                       ,@writes          int          = 0
                                       ,@cpu             int          = 0
AS
BEGIN
   IF OBJECT_ID('tempdb..#tb_sessions') IS NOT NULL
     DROP TABLE #tb_sessions;

    SELECT session_id             = dm_exec_sessions.session_id
          ,database_name          = ISNULL(databases.name,'unknow')
          ,host_name              = dm_exec_sessions.host_name
          ,program_name           = dm_exec_sessions.program_name
          ,client_interface_name  = dm_exec_sessions.client_interface_name
          ,blocking_session_id    = dm_exec_requests.blocking_session_id
          ,open_transaction_count = dm_exec_requests.open_transaction_count
          ,percent_complete       = NULLIF(dm_exec_requests.percent_complete,0)
          ,cpu_time               = dm_exec_sessions.cpu_time
          ,total_elapsed_time     = dm_exec_sessions.total_elapsed_time
          ,reads                  = dm_exec_sessions.reads
          ,writes                 = dm_exec_sessions.writes
          ,logical_reads          = dm_exec_sessions.logical_reads
          ,start_time             = dm_exec_requests.start_time
          ,status                 = dm_exec_sessions.status
          ,wait_type              = dm_exec_requests.wait_type
          ,wait_time              = dm_exec_requests.wait_time
          ,wait_resource          = dm_exec_requests.wait_resource
          ,command                = dm_exec_requests.command
          ,current_statement      = SUBSTRING(dm_exec_sql_text.text, (dm_exec_requests.statement_start_offset/2)+1,   
                                  ((CASE dm_exec_requests.statement_end_offset  
                                      WHEN -1 THEN DATALENGTH(dm_exec_sql_text.text)  
                                      ELSE dm_exec_requests.statement_end_offset  
                                      END - dm_exec_requests.statement_start_offset)/2) + 1)
          ,cmd_sql                = dm_exec_sql_text.text
          ,qry_plan               = dm_exec_query_plan.query_plan
  INTO #tb_sessions
  FROM sys.dm_exec_sessions WITH (NOLOCK)
          LEFT JOIN sys.dm_exec_requests WITH (NOLOCK)
          ON dm_exec_requests.session_id = dm_exec_sessions.session_id
          LEFT JOIN sys.databases WITH (NOLOCK)
          ON databases.database_id = dm_exec_sessions.database_id
          OUTER APPLY sys.dm_exec_sql_text(dm_exec_requests.sql_handle)
          OUTER APPLY sys.dm_exec_query_plan(dm_exec_requests.plan_handle);

  SELECT *
  FROM #tb_sessions AS tb
  WHERE EXISTS(SELECT 1 WHERE @userConnections = 0
               UNION ALL
               SELECT 1 WHERE @userConnections = 1 AND tb.session_id >= 50)
    AND EXISTS(SELECT 1 WHERE @db_name = ''
               UNION ALL
               SELECT 1 WHERE @db_name <> '' AND ISNULL(tb.database_name,'') LIKE '%'+@db_name+'%')
    AND EXISTS(SELECT 1 WHERE @host_name = ''
               UNION ALL
               SELECT 1 WHERE @host_name <> '' AND ISNULL(tb.host_name,'') LIKE '%'+@host_name+'%')
    AND EXISTS(SELECT 1 WHERE @status = ''
               UNION ALL
               SELECT 1 WHERE @status <> '' AND ISNULL(tb.status,'') LIKE '%'+@status+'%')
    AND EXISTS(SELECT 1 WHERE @only_blocked = 0
               UNION ALL
               SELECT 1 WHERE @only_blocked = 1 AND ISNULL(tb.blocking_session_id,0) > 0)
    AND EXISTS(SELECT 1 WHERE @reads = 0
               UNION ALL
               SELECT 1 WHERE @reads <> 0 AND ISNULL(tb.reads,0) >= @reads)
    AND EXISTS(SELECT 1 WHERE @writes = 0
               UNION ALL
               SELECT 1 WHERE @writes <> 0 AND ISNULL(tb.writes,0) >= @writes)
    AND EXISTS(SELECT 1 WHERE @cpu = 0
               UNION ALL
               SELECT 1 WHERE @cpu <> 0 AND ISNULL(tb.cpu_time,0) >= @cpu)
  ORDER BY tb.session_id
  OPTION(RECOMPILE);
END