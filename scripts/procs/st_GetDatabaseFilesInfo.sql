CREATE PROCEDURE dbo.st_GetDatabaseFilesInfo
AS
BEGIN
  SET NOCOUNT ON;

  DECLARE @db_name varchar(255) = ''
         ,@db_uid  int = 0
         ,@cmd     varchar(MAX) = '';

  IF OBJECT_ID('tempdb..#tb_files') IS NOT NULL
    DROP TABLE #tb_files;

  CREATE TABLE #tb_files(
    database_name      varchar(100)
   ,data_file_size_mb  varchar(100)
   ,data_used_space_mb varchar(100)
   ,log_file_size_mb   varchar(100)
   ,log_used_space_mb  varchar(100)
   ,total_size         varchar(100)
  );

  DECLARE curDatabases CURSOR LOCAL FAST_FORWARD
  FOR SELECT databases.name
            ,[database].database_uid
      FROM sys.databases
           INNER JOIN dbo.[database]
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
      WHERE [database].ativo = 1
        AND EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN
 
    SELECT @cmd = '
    USE [db];
    
    ;WITH CTA
     AS (
      SELECT database_name        = DB_NAME()
            ,data_unused_size_mb  = CAST(ISNULL(SUM(CASE WHEN dat.type_desc = ''ROWS'' THEN dat.size*8./1024. ELSE 0 END),0) AS Numeric(8,4))
            ,data_used_space_mb   = CAST(ISNULL(SUM(CASE WHEN dat.type_desc = ''ROWS'' THEN CAST(FILEPROPERTY(name, ''SpaceUsed'') AS INT)/128. ELSE 0 END),0) AS Numeric(8,4))
            ,log_unused_size_mb   = CAST(ISNULL(SUM(CASE WHEN dat.type_desc = ''LOG'' THEN dat.size*8./1024. ELSE 0 END),0) AS Numeric(8,4))
            ,log_used_space_mb    = CAST(ISNULL(SUM(CASE WHEN dat.type_desc = ''LOG'' THEN CAST(FILEPROPERTY(name, ''SpaceUsed'') AS INT)/128. ELSE 0 END),0) AS Numeric(8,4))
            ,total_size           = CAST(ISNULL(SUM(dat.size*8./1024.),0) AS Numeric(8,4))
      FROM sys.database_files AS dat 
    )
    INSERT INTO #tb_files(
      database_name
     ,data_file_size_mb
     ,data_used_space_mb
     ,log_file_size_mb
     ,log_used_space_mb
     ,total_size
    )
    SELECT database_name      
          ,data_unused_size_mb = CAST((data_unused_size_mb - data_used_space_mb) * 100 / total_size AS Numeric(8,2))
          ,data_used_space_mb  = CAST(data_used_space_mb * 100 / total_size AS Numeric(8,2))
          ,log_unused_size_mb  = CAST((log_unused_size_mb - log_used_space_mb) * 100 / total_size AS Numeric(8,2))
          ,log_used_space_mb   = CAST(log_used_space_mb * 100 / total_size AS Numeric(8,2))
          ,total_size          = CAST(total_size AS Numeric(8,2))
    FROM CTA;';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END

  CLOSE curDatabases;
  DEALLOCATE curDatabases;

  SELECT * FROM #tb_files;

  IF OBJECT_ID('tempdb..#tb_files') IS NOT NULL
    DROP TABLE #tb_files;
END