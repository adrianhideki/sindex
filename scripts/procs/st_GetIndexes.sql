--EXEC dbo.st_GetIndexes
CREATE PROCEDURE dbo.st_GetIndexes
AS
BEGIN
  SET NOCOUNT ON;

  DECLARE @db_name varchar(255) = ''
         ,@db_uid  int = 0
         ,@cmd     varchar(MAX) = '';

  DECLARE curDatabases CURSOR LOCAL FAST_FORWARD
  FOR SELECT databases.name
            ,[database].database_uid
      FROM sys.databases
           INNER JOIN dbo.[database]
           ON [database].database_id = databases.database_id
      WHERE EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN

    SELECT @cmd = '
    INSERT INTO [sindex].[dbo].[index](
     table_uid
    ,filegroup_uid
    ,index_id
    ,update_date
    ,create_date
    ,index_name
    ,type
    ,key_columns
    ,include_columns
    ,fill_factor
    ,is_primary_key
    ,is_unique_constraint
    ,is_disabled
    ,filter_condition
    ,script_create
    ,script_drop
    ,database_uid
    )
    SELECT table_uid            = [table].table_uid
          ,filegroup_uid        = [filegroup].filegroup_uid
          ,index_id             = indexes.index_id
          ,update_date          = GETDATE()
          ,create_date          = STATS_DATE(indexes.object_id, indexes.index_id)
          ,index_name           = indexes.name
          ,type                 = indexes.type_desc
          ,key_columns          = _colunas.key_cols
          ,include_columns      = _colunas.inc_cols
          ,fill_factor          = indexes.fill_factor
          ,is_primary_key       = indexes.is_primary_key
          ,is_unique_constraint = indexes.is_unique_constraint
          ,is_disabled          = indexes.is_disabled
          ,filter_condition     = indexes.filter_definition
          ,script_create        = CASE WHEN indexes.is_primary_key = 1 THEN ''/*PRIMARY KEY*/''
                                       WHEN indexes.is_unique_constraint = 1 THEN ''/*UNIQUE CONSTRAINT*/''
                                       WHEN indexes.type = 3 THEN ''/*XML INDEX NOT IMPLEMENTED*/''
                                       WHEN indexes.type = 4 THEN ''/*SPACIAL INDEX NOT IMPLEMENTED*/''
                                       WHEN indexes.type = 5 THEN ''/*CLUSTERED COLUMN STORE INDEX NOT IMPLEMENTED*/''
                                       WHEN indexes.type = 6 THEN ''/*NONCLUSTERED COLUMN STORE INDEX NOT IMPLEMENTED*/''
                                       WHEN indexes.type = 7 THEN ''/*HASH INDEX NOT IMPLEMENTED*/''
                                       WHEN indexes.type = 0 THEN ''/*HEAP INDEX*/''
                                       ELSE ''CREATE '' +
                                            CASE WHEN indexes.is_unique = 1 THEN ''UNIQUE '' ELSE '''' END + 
                                            CASE WHEN indexes.type = 1 THEN ''CLUSTERED ''
                                                 WHEN indexes.type = 2 THEN ''NONCLUSTERED ''
                                                 ELSE ''''
                                            END + ''INDEX '' + QUOTENAME(indexes.name) + '' ON '' + QUOTENAME(schemas.name) + ''.'' + QUOTENAME(objects.name) + '' ('' + 
                                              _colunas.key_cols
                                            + '') '' + 
                                            CASE WHEN LEN(_colunas.inc_cols) > 0 THEN ''INCLUDE('' + _colunas.inc_cols + '') '' ELSE '''' END + 
                                            CASE WHEN LEN(ISNULL(indexes.filter_definition,'''')) > 0 THEN ''WHERE '' + indexes.filter_definition + '' '' ELSE '''' END +
                                            CASE WHEN indexes.fill_factor <> 0 OR indexes.is_padded = 1 OR indexes.ignore_dup_key = 1 OR indexes.allow_row_locks = 0 OR indexes.allow_page_locks = 0
                                                   OR indexes.ignore_dup_key = 1
                                                 THEN '' WITH ('' +
                                                       CASE WHEN indexes.is_padded = 1 THEN '' PAD_INDEX = ON ''  ELSE '' PAD_INDEX = OFF '' END + 
                                                       CASE WHEN indexes.fill_factor <> 0 THEN '',FILLFACTOR = '' +  CAST(indexes.fill_factor AS varchar(10)) ELSE '''' END + 
                                                       CASE WHEN indexes.ignore_dup_key <> 0 THEN '',IGNORE_DUP_KEY  = ON'' ELSE '''' END + 
                                                       CASE WHEN indexes.allow_row_locks = 0 THEN '',ALLOW_ROW_LOCKS = OFF'' ELSE '''' END + 
                                                       CASE WHEN indexes.allow_page_locks = 0 THEN '',ALLOW_PAGE_LOCKS = OFF'' ELSE '''' END + 
                              
                                                    + '')'' 
                                                 ELSE '''' 
                                            END + 
                                            CASE WHEN filegroups.is_default = 1 THEN '''' ELSE '' ON '' + QUOTENAME(filegroups.name) END + '';''
                                  END
          ,script_drop          = ''DROP INDEX '' + QUOTENAME(indexes.name) + '' ON '' + QUOTENAME(schemas.name) + ''.'' + QUOTENAME(objects.name) + '';''
          ,database_uid         = @db_uid
    FROM [db].sys.indexes
         INNER JOIN [db].sys.filegroups
         ON filegroups.data_space_id = indexes.data_space_id
         INNER JOIN [db].sys.objects
         ON objects.object_id = indexes.object_id
         INNER JOIN [db].sys.schemas
         ON schemas.schema_id = objects.schema_id
         CROSS APPLY (SELECT '',''+QUOTENAME(columns.name) + CASE WHEN index_columns.is_descending_key = 1 THEN '' DESC'' ELSE '''' END
                      FROM [db].sys.index_columns
                           INNER JOIN [db].sys.columns
                           ON columns.object_id = index_columns.object_id AND
                              columns.column_id = index_columns.column_id
                      WHERE index_columns.object_id = indexes.object_id
                        AND index_columns.index_id  = indexes.index_id
                        AND index_columns.is_included_column = 0
                      ORDER BY index_columns.index_column_id
                      FOR XML PATH('''')) fn_key (cols)
         CROSS APPLY (SELECT '',''+QUOTENAME(columns.name) + CASE WHEN index_columns.is_descending_key = 1 THEN '' DESC'' ELSE '''' END
                      FROM [db].sys.index_columns
                           INNER JOIN [db].sys.columns
                           ON columns.object_id = index_columns.object_id AND
                              columns.column_id = index_columns.column_id
                      WHERE index_columns.object_id = indexes.object_id
                        AND index_columns.index_id  = indexes.index_id
                        AND index_columns.is_included_column = 1
                      ORDER BY index_columns.index_column_id
                      FOR XML PATH('''')) fn_inc (cols)
         CROSS APPLY (SELECT key_cols = ISNULL(STUFF(fn_key.cols,1,1,''''),'''')
                            ,inc_cols = ISNULL(STUFF(fn_inc.cols,1,1,''''),'''')
                      ) _colunas
         INNER JOIN [sindex].[dbo].[table]
         ON [table].table_id = objects.object_id AND
            [table].database_uid = @db_uid
         INNER JOIN [sindex].[dbo].[filegroup]
         ON [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
            [filegroup].database_uid = @db_uid
    WHERE NOT EXISTS(SELECT 1
                     FROM [sindex].[dbo].[index]
                     WHERE [index].index_name   = indexes.name COLLATE Latin1_General_CI_AS
                       AND [index].table_uid    = [table].table_uid 
                       AND [index].database_uid = @db_uid)


  DELETE FROM sindex.dbo.[index]
  WHERE NOT EXISTS(SELECT 1
                   FROM [db].sys.indexes
                        INNER JOIN [db].sys.objects
                        ON objects.object_id = indexes.object_id
                        INNER JOIN [sindex].[dbo].[table]
                        ON [table].table_id = objects.object_id AND
                           [table].database_uid = @db_uid
                   WHERE indexes.name COLLATE Latin1_General_CI_AS = [index].index_name COLLATE Latin1_General_CI_AS
                     AND [table].table_uid = [index].table_uid)
    AND [index].database_uid = @db_uid

  UPDATE [index]
     SET filegroup_uid         = [filegroup].filegroup_uid
        ,index_id              = indexes.index_id
        ,update_date           = GETDATE()
        ,create_date           = STATS_DATE(indexes.object_id, indexes.index_id)
        ,index_name            = indexes.name
        ,type                  = indexes.type_desc
        ,key_columns           = _colunas.key_cols
        ,include_columns       = _colunas.inc_cols
        ,fill_factor           = indexes.fill_factor
        ,is_primary_key        = indexes.is_primary_key
        ,is_unique_constraint  = indexes.is_unique_constraint
        ,is_disabled           = indexes.is_disabled
        ,filter_condition      = indexes.filter_definition
        ,script_create         = scrp.script_create
        ,script_drop           = ''DROP INDEX '' + QUOTENAME(indexes.name) + '' ON '' + QUOTENAME(schemas.name) + ''.'' + QUOTENAME(objects.name) + '';''
  FROM [db].sys.indexes
       INNER JOIN [db].sys.filegroups
       ON filegroups.data_space_id = indexes.data_space_id
       INNER JOIN [db].sys.objects
       ON objects.object_id = indexes.object_id
       INNER JOIN [db].sys.schemas
       ON schemas.schema_id = objects.schema_id
       CROSS APPLY (SELECT '',''+QUOTENAME(columns.name) + CASE WHEN index_columns.is_descending_key = 1 THEN '' DESC'' ELSE '''' END
                    FROM [db].sys.index_columns
                         INNER JOIN [db].sys.columns
                         ON columns.object_id = index_columns.object_id AND
                            columns.column_id = index_columns.column_id
                    WHERE index_columns.object_id = indexes.object_id
                      AND index_columns.index_id  = indexes.index_id
                      AND index_columns.is_included_column = 0
                    ORDER BY index_columns.index_column_id
                    FOR XML PATH('''')) fn_key (cols)
       CROSS APPLY (SELECT '',''+QUOTENAME(columns.name) + CASE WHEN index_columns.is_descending_key = 1 THEN '' DESC'' ELSE '''' END
                    FROM [db].sys.index_columns
                         INNER JOIN [db].sys.columns
                         ON columns.object_id = index_columns.object_id AND
                            columns.column_id = index_columns.column_id
                    WHERE index_columns.object_id = indexes.object_id
                      AND index_columns.index_id  = indexes.index_id
                      AND index_columns.is_included_column = 1
                    ORDER BY index_columns.index_column_id
                    FOR XML PATH('''')) fn_inc (cols)
       CROSS APPLY (SELECT key_cols = ISNULL(STUFF(fn_key.cols,1,1,''''),'''')
                          ,inc_cols = ISNULL(STUFF(fn_inc.cols,1,1,''''),'''')
                    ) _colunas
       INNER JOIN [sindex].[dbo].[table]
       ON [table].table_id = objects.object_id AND
          [table].database_uid = @db_uid
       INNER JOIN [sindex].[dbo].[filegroup]
       ON [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
          [filegroup].database_uid = @db_uid
       INNER JOIN [sindex].[dbo].[index]
       ON [index].index_name   = indexes.name COLLATE Latin1_General_CI_AS AND 
          [index].table_uid    = [table].table_uid AND
          [index].database_uid = @db_uid
       CROSS APPLY (SELECT script_create = CASE WHEN indexes.is_primary_key = 1 THEN ''/*PRIMARY KEY*/''
                                                WHEN indexes.is_unique_constraint = 1 THEN ''/*UNIQUE CONSTRAINT*/''
                                                WHEN indexes.type = 3 THEN ''/*XML INDEX NOT IMPLEMENTED*/''
                                                WHEN indexes.type = 4 THEN ''/*SPACIAL INDEX NOT IMPLEMENTED*/''
                                                WHEN indexes.type = 5 THEN ''/*CLUSTERED COLUMN STORE INDEX NOT IMPLEMENTED*/''
                                                WHEN indexes.type = 6 THEN ''/*NONCLUSTERED COLUMN STORE INDEX NOT IMPLEMENTED*/''
                                                WHEN indexes.type = 7 THEN ''/*HASH INDEX NOT IMPLEMENTED*/''
                                                WHEN indexes.type = 0 THEN ''/*HEAP INDEX*/''
                                                ELSE ''CREATE '' +
                                                     CASE WHEN indexes.is_unique = 1 THEN ''UNIQUE '' ELSE '''' END + 
                                                     CASE WHEN indexes.type = 1 THEN ''CLUSTERED ''
                                                          WHEN indexes.type = 2 THEN ''NONCLUSTERED ''
                                                          ELSE ''''
                                                     END + ''INDEX '' + QUOTENAME(indexes.name) + '' ON '' + QUOTENAME(schemas.name) + ''.'' + QUOTENAME(objects.name) + '' ('' + 
                                                       _colunas.key_cols
                                                     + '') '' + 
                                                     CASE WHEN LEN(_colunas.inc_cols) > 0 THEN ''INCLUDE('' + _colunas.inc_cols + '') '' ELSE '''' END + 
                                                     CASE WHEN LEN(ISNULL(indexes.filter_definition,'''')) > 0 THEN ''WHERE '' + indexes.filter_definition + '' '' ELSE '''' END +
                                                     CASE WHEN indexes.fill_factor <> 0 OR indexes.is_padded = 1 OR indexes.ignore_dup_key = 1 OR indexes.allow_row_locks = 0 OR indexes.allow_page_locks = 0
                                                            OR indexes.ignore_dup_key = 1
                                                          THEN '' WITH ('' +
                                                                CASE WHEN indexes.is_padded = 1 THEN '' PAD_INDEX = ON ''  ELSE '' PAD_INDEX = OFF '' END + 
                                                                CASE WHEN indexes.fill_factor <> 0 THEN '',FILLFACTOR = '' +  CAST(indexes.fill_factor AS varchar(10)) ELSE '''' END + 
                                                                CASE WHEN indexes.ignore_dup_key <> 0 THEN '',IGNORE_DUP_KEY  = ON'' ELSE '''' END + 
                                                                CASE WHEN indexes.allow_row_locks = 0 THEN '',ALLOW_ROW_LOCKS = OFF'' ELSE '''' END + 
                                                                CASE WHEN indexes.allow_page_locks = 0 THEN '',ALLOW_PAGE_LOCKS = OFF'' ELSE '''' END + 
                                           
                                                             + '')'' 
                                                          ELSE '''' 
                                                     END + 
                                                     CASE WHEN filegroups.is_default = 1 THEN '''' ELSE '' ON '' + QUOTENAME(filegroups.name) END + '';''
                                           END) AS scrp
  WHERE [index].database_uid = @db_uid
    AND EXISTS(SELECT 1  WHERE [index].filegroup_uid                                    <> [filegroup].filegroup_uid UNION ALL
               SELECT 1  WHERE [index].index_id                                         <> indexes.index_id UNION ALL
               SELECT 1  WHERE [index].create_date                                      <> STATS_DATE(indexes.object_id, indexes.index_id) UNION ALL
               SELECT 1  WHERE [index].index_name COLLATE Latin1_General_CI_AS          <> indexes.name COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [index].type COLLATE Latin1_General_CI_AS                <> indexes.type_desc COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [index].key_columns COLLATE Latin1_General_CI_AS         <> _colunas.key_cols COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [index].include_columns COLLATE Latin1_General_CI_AS     <> _colunas.inc_cols COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [index].fill_factor                                      <> indexes.fill_factor UNION ALL
               SELECT 1  WHERE [index].is_primary_key                                   <> indexes.is_primary_key UNION ALL
               SELECT 1  WHERE [index].is_unique_constraint                             <> indexes.is_unique_constraint UNION ALL
               SELECT 1  WHERE [index].is_disabled                                      <> indexes.is_disabled UNION ALL
               SELECT 1  WHERE [index].filter_condition COLLATE Latin1_General_CI_AS    <> indexes.filter_definition COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [index].script_create COLLATE Latin1_General_CI_AS       <> scrp.script_create COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [index].script_drop COLLATE Latin1_General_CI_AS         <> ''DROP INDEX '' + QUOTENAME(indexes.name) + '' ON '' + QUOTENAME(schemas.name) + ''.'' + QUOTENAME(objects.name) + '';'' COLLATE Latin1_General_CI_AS
               );';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END

  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END