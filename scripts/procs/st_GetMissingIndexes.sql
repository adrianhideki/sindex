CREATE PROCEDURE dbo.st_GetMissingIndexes @table    varchar(100) = ''
                                         ,@database varchar(100) = ''
AS
BEGIN
  IF OBJECT_ID('tempdb..#tb_indexes') IS NOT NULL
    DROP TABLE #tb_indexes;

  SELECT DatabaseName         = db_name(dm_mid.database_id)
        ,Avg_Estimated_Impact = dm_migs.avg_user_impact*(dm_migs.user_seeks+dm_migs.user_scans)
        ,Last_User_Seek       = dm_migs.last_user_seek
        ,TableName            = OBJECT_NAME(dm_mid.OBJECT_ID,dm_mid.database_id)
        ,Create_Statement     = 'CREATE INDEX [IX_' + OBJECT_NAME(dm_mid.OBJECT_ID,dm_mid.database_id) + '_' + REPLACE(REPLACE(REPLACE(ISNULL(dm_mid.equality_columns,''),', ','_'),'[',''),']','') 
                               + CASE WHEN dm_mid.equality_columns IS NOT NULL AND dm_mid.inequality_columns IS NOT NULL THEN '_'
                                      ELSE ''
                                 END
                               + REPLACE(REPLACE(REPLACE(ISNULL(dm_mid.inequality_columns,''),', ','_'),'[',''),']','')
                               + ']'
                               + ' ON ' + dm_mid.statement
                               + ' (' + ISNULL (dm_mid.equality_columns,'')
                               + CASE WHEN dm_mid.equality_columns IS NOT NULL AND dm_mid.inequality_columns 
                                      IS NOT NULL THEN ',' ELSE '' END
                               + ISNULL (dm_mid.inequality_columns, '')
                               + ')'
                               + ISNULL (' INCLUDE (' + dm_mid.included_columns + ')', '')
        ,Selecionado          = CAST(0 AS bit)
  INTO #tb_indexes
  FROM sys.dm_db_missing_index_groups dm_mig
       INNER JOIN sys.dm_db_missing_index_group_stats dm_migs
       ON dm_migs.group_handle = dm_mig.index_group_handle
       INNER JOIN sys.dm_db_missing_index_details dm_mid
       ON dm_mig.index_handle = dm_mid.index_handle
  ORDER BY Avg_Estimated_Impact DESC;

  SELECT *
  FROM #tb_indexes
  WHERE EXISTS(SELECT 1
               WHERE ISNULL(@table,'') = ''
               UNION ALL
               SELECT 1
               WHERE TableName LIKE '%'+ISNULL(@table,'')+'%')
    AND EXISTS(SELECT 1
               WHERE ISNULL(@database,'') = ''
               UNION ALL
               SELECT 1
               WHERE DatabaseName LIKE '%'+ISNULL(@database,'')+'%')
  OPTION(RECOMPILE);  
END