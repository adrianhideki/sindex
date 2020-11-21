CREATE PROCEDURE dbo.st_SetNotification
AS
BEGIN
  SET NOCOUNT ON;
  IF OBJECT_ID('tempdb..#MemoryInfo') IS NOT NULL
    DROP TABLE #MemoryInfo;

  CREATE TABLE #MemoryInfo(
    physical_memory_mb     numeric(18,4)
   ,avaliable_memory_mb    numeric(18,4)
   ,total_page_file_gb     numeric(18,4)
   ,avaliable_page_file_mb numeric(18,4)
   ,system_cache_mb        numeric(18,4)
   ,system_memory_state    varchar(500) COLLATE Latin1_General_CI_AS
  );

  IF OBJECT_ID('tempdb..#CPUInfo') IS NOT NULL
    DROP TABLE #CPUInfo;

  CREATE TABLE #CPUInfo(
    SQL_Server_CPU_Utilization int
   ,System_CPU_Utilization     int
   ,System_Idle_Process        int
   ,Event_Time                 DateTime
   ,ROWID                      int
  );

  IF OBJECT_ID('tempdb..#FragmentedIndexes') IS NOT NULL
    DROP TABLE #FragmentedIndexes;

  CREATE TABLE #FragmentedIndexes(
    table_name        varchar(300) COLLATE Latin1_General_CI_AS
   ,database_name     varchar(300) COLLATE Latin1_General_CI_AS
   ,index_name        varchar(300) COLLATE Latin1_General_CI_AS
   ,fragmentation     numeric(18,4)
   ,index_type        varchar(300) COLLATE Latin1_General_CI_AS
   ,defrag_action     varchar(8000) COLLATE Latin1_General_CI_AS
   ,selecionado       bit 
  );

  IF OBJECT_ID('tempdb..#UpdateStatistics') IS NOT NULL
    DROP TABLE #UpdateStatistics;

  CREATE TABLE #UpdateStatistics(
    stat_name       varchar(300) COLLATE Latin1_General_CI_AS
   ,object_name     varchar(300) COLLATE Latin1_General_CI_AS
   ,autoCreated     bit
   ,daysLastUpdate  int
   ,statUpdateDate  datetime
   ,database_name   varchar(300) COLLATE Latin1_General_CI_AS
   ,script_update   varchar(8000) COLLATE Latin1_General_CI_AS
   ,selecionado     bit 
   ,rows            bigint
  );

  IF OBJECT_ID('tempdb..#MissingIndexes') IS NOT NULL
    DROP TABLE #MissingIndexes;

  CREATE TABLE #MissingIndexes(
    database_name        varchar(300) COLLATE Latin1_General_CI_AS
   ,avg_estimated_impact numeric(18,4)
   ,last_user_seek       datetime
   ,table_name           varchar(300) COLLATE Latin1_General_CI_AS
   ,create_statement     varchar(8000) COLLATE Latin1_General_CI_AS
   ,selecionado          bit
  );

  IF OBJECT_ID('tempdb..#DatabaseFilesInfo') IS NOT NULL
    DROP TABLE #DatabaseFilesInfo;

  CREATE TABLE #DatabaseFilesInfo(
    database_name        varchar(300) COLLATE Latin1_General_CI_AS
   ,data_file_size_mb    numeric(18,4)
   ,data_used_space_mb   numeric(18,4)
   ,log_file_size_mb     numeric(18,4)
   ,log_used_space_mb    numeric(18,4)
   ,total_size           numeric(18,4)
  );

  INSERT INTO #MemoryInfo(
    physical_memory_mb
   ,avaliable_memory_mb
   ,total_page_file_gb
   ,avaliable_page_file_mb
   ,system_cache_mb
   ,system_memory_state
  )
  EXEC dbo.st_GetMemoryInfo;

  INSERT INTO #CPUInfo(
    SQL_Server_CPU_Utilization
   ,System_CPU_Utilization
   ,System_Idle_Process
   ,Event_Time
   ,ROWID
   )
  EXEC dbo.st_GetCPUInfo;

  INSERT INTO #FragmentedIndexes(
    table_name
   ,database_name
   ,index_name
   ,fragmentation
   ,index_type
   ,defrag_action
   ,selecionado
  )
  EXEC dbo.st_GetFragmentedIndexes;
  
  INSERT INTO #UpdateStatistics(
    stat_name
   ,object_name
   ,autoCreated
   ,daysLastUpdate
   ,statUpdateDate
   ,database_name
   ,script_update
   ,selecionado
   ,rows
  )
  EXEC dbo.st_GetUpdateStatistics;

  INSERT INTO #MissingIndexes(
    database_name
   ,avg_estimated_impact
   ,last_user_seek
   ,table_name
   ,create_statement
   ,selecionado
  )
  EXEC dbo.st_GetMissingIndexes;

  INSERT INTO #DatabaseFilesInfo(
    database_name
   ,data_file_size_mb
   ,data_used_space_mb
   ,log_file_size_mb
   ,log_used_space_mb
   ,total_size
  )
  EXEC dbo.st_GetDatabaseFilesInfo;

  IF OBJECT_ID('tempdb..#notification') IS NOT NULL
    DROP TABLE #notification;

  SELECT update_date = GETDATE()
        ,notify_type = 'Aviso - Memória'
        ,notify_desc = 'Memória com menos de 10% disponível.'
  INTO #notification
  FROM #MemoryInfo
  WHERE (avaliable_memory_mb*100)/physical_memory_mb < 10
  UNION ALL
  SELECT GETDATE()
        ,'Aviso - CPU'
        ,'CPU com consumo acima de 85%.' 
  FROM #CPUInfo
  WHERE SQL_Server_CPU_Utilization+System_CPU_Utilization > 85
  UNION ALL
  SELECT GETDATE()
        ,'Aviso - Índices'
        ,CAST(COUNT(1) AS varchar(10)) + ' índice(s) com fragmentação acima de 70%.'
  FROM #FragmentedIndexes
  WHERE fragmentation > 70
  HAVING COUNT(1) > 1
  UNION ALL
  SELECT GETDATE()
        ,'Aviso - Estatísticas'
        ,CAST(COUNT(1) AS varchar(10)) + ' estatística(s) desatualizada(s) a mais de 7 dias.'
  FROM #UpdateStatistics
  WHERE daysLastUpdate > 7
    AND rows > 0
  HAVING COUNT(1) > 1
  UNION ALL
  SELECT GETDATE()
        ,'Aviso - Índices'
        ,CAST(COUNT(1) AS varchar(10)) + ' índice(s) ausente(s).'
  FROM #MissingIndexes
  HAVING COUNT(1) > 1
  UNION ALL
  SELECT GETDATE()
        ,'Aviso - Disco'
        ,CAST(COUNT(1) AS varchar(10)) + ' bases necessitam verificar o tamanho do arquivo de log.'
  FROM #DatabaseFilesInfo
  WHERE ((log_file_size_mb - log_used_space_mb)/100.) * total_size < total_size *0.15
  HAVING COUNT(1) > 1
  UNION ALL
  SELECT GETDATE()
        ,'Aviso - Disco'
        ,CAST(COUNT(1) AS varchar(10)) + ' bases necessitam verificar o tamanho do arquivo de dados.'
  FROM #DatabaseFilesInfo
  WHERE ((data_file_size_mb - data_used_space_mb)/100.) * total_size < total_size *0.10
  HAVING COUNT(1) > 1

  CREATE INDEX ix_0 ON #notification (update_date, notify_type, notify_desc);

  UPDATE [notification]
     SET quantity   += 1
        ,update_date = GETDATE()
  FROM #notification AS tb
       INNER JOIN dbo.[notification]
       ON [notification].extract_date = CAST(GETDATE() AS date) AND
          [notification].notify_type = tb.notify_type AND
          [notification].notify_desc = tb.notify_desc;

  INSERT INTO dbo.[notification](
    update_date
   ,extract_date
   ,notify_type
   ,notify_desc
   ,quantity
  )
  SELECT update_date
        ,extract_date = CAST(GETDATE() AS date)
        ,notify_type
        ,notify_desc
        ,quantity = 1
  FROM #notification AS tb
  WHERE NOT EXISTS(SELECT 1
                   FROM dbo.[notification]
                   WHERE [notification].extract_date = CAST(GETDATE() AS date) 
                     AND [notification].notify_type = tb.notify_type 
                     AND [notification].notify_desc = tb.notify_desc);
END