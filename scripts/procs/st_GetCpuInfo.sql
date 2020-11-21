CREATE PROCEDURE dbo.st_GetCPUInfo
AS
BEGIN
  DECLARE @ts_now bigint = (SELECT cpu_ticks/(cpu_ticks/ms_ticks)FROM sys.dm_os_sys_info);

  ;WITH CTA
   AS (SELECT TOP(10) 
              [SQL Server Process CPU Utilization] = SQLProcessUtilization, 
              [System Idle Process]                = SystemIdle, 
              [Other Process CPU Utilization]      = 100 - SystemIdle - SQLProcessUtilization, 
              [Event Time]                         = CAST(DATEADD(ms, -1 * (@ts_now - [timestamp]), GETDATE()) AS datetime)
       FROM ( 
             SELECT record_id               = record.value('(./Record/@id)[1]', 'int'), 
                    [SystemIdle]            = record.value('(./Record/SchedulerMonitorEvent/SystemHealth/SystemIdle)[1]', 'int'), 
                    [SQLProcessUtilization] = record.value('(./Record/SchedulerMonitorEvent/SystemHealth/ProcessUtilization)[1]','int'),
                    [timestamp]
             FROM ( 
                   SELECT [timestamp], CONVERT(xml, record) AS [record] 
                   FROM sys.dm_os_ring_buffers 
                   WHERE ring_buffer_type = N'RING_BUFFER_SCHEDULER_MONITOR' 
                   AND record LIKE '%<SystemHealth>%') AS x 
        ) AS y 
   ORDER BY record_id DESC)
  SELECT * ,ROWID = ROW_NUMBER() OVER (ORDER BY [Event Time] ASC)
  FROM CTA;
END