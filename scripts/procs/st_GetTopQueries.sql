CREATE PROCEDURE dbo.st_GetTopQueries @Top int              = 50
                                     ,@db_name varchar(100) = ''
AS
BEGIN
  SELECT TOP(@Top)
         creation_time        = qs.creation_time
        ,last_execution_time  = qs.last_execution_time
        ,total_worker_time    = CAST((qs.total_worker_time+0.0)/1000000. AS numeric(18,4))
        ,AvgCPUTime           = CAST((qs.total_worker_time+0.0)/qs.execution_count / 1000000. AS numeric(18,4))
        ,AvgPhysicalReads     = CAST((qs.total_physical_reads + 0.0) / (qs.execution_count) AS bigint)
        ,AvgLogicalWrites     = CAST((qs.total_logical_writes + 0.0) / (qs.execution_count) AS bigint)
        ,AvgElapsedTime       = CAST(qs.total_elapsed_time / qs.execution_count / 1000000. AS numeric(18,4))
        ,execution_count      = qs.execution_count
        ,query                = st.text
        ,query_plan           = qp.query_plan
        ,databaseName         = ISNULL(db_name(st.dbid),'')
        ,avgUsedThreads       = CAST((qs.total_used_threads) / (qs.execution_count) AS bigint)
        ,avgMaxDop            = CAST((qs.total_dop) / (qs.execution_count) AS bigint)
        ,statement_text       = SUBSTRING(ST.text, (QS.statement_start_offset/2) + 1,  
                                ((CASE statement_end_offset   
                                    WHEN -1 THEN DATALENGTH(ST.text)  
                                    ELSE QS.statement_end_offset END   
                                        - QS.statement_start_offset)/2) + 1)
  FROM sys.dm_exec_query_stats qs
       CROSS APPLY sys.dm_exec_sql_text(qs.sql_handle) st
       CROSS APPLY sys.dm_exec_query_plan(qs.plan_handle) qp
  WHERE qs.total_worker_time > 0
    AND EXISTS(SELECT 1
               WHERE @db_name = ''
               UNION ALL
               SELECT 1
               WHERE db_name(st.dbid) LIKE '%' + @db_name + '%')
  ORDER BY total_worker_time DESC;
END