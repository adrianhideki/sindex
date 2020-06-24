--EXEC dbo.st_GetConstraints
CREATE PROCEDURE dbo.st_GetConstraints
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
  INSERT INTO sindex.dbo.[constraint](
    constraint_id
   ,constraint_name
   ,update_date
   ,create_date
   ,type
   ,parent_table_uid
   ,referenced_table_uid
   ,default_value
   ,check_condition
   ,referenced_columns
   ,parent_columns
   ,is_disabled
   ,is_not_trusted
   ,database_uid
  )

  SELECT constraint_id        = foreign_keys.object_id
        ,constraint_name      = foreign_keys.name
        ,update_date          = GETDATE()
        ,create_date          = foreign_keys.create_date
        ,type                 = ''FK''
        ,parent_table_uid     = [par_table].table_uid
        ,referenced_table_uid = [ref_table].table_uid
        ,default_value        = NULL
        ,check_condition      = NULL
        ,referenced_columns   = STUFF(ref_columns.col,1,1,'''')
        ,parent_columns       = STUFF(par_columns.col,1,1,'''')
        ,is_disabled          = foreign_keys.is_disabled
        ,is_not_trusted       = foreign_keys.is_not_trusted
        ,database_uid         = @db_uid
  FROM [db].sys.foreign_keys
       INNER JOIN sindex.dbo.[table] AS [ref_table]
       ON [ref_table].table_id     = foreign_keys.referenced_object_id AND
          [ref_table].database_uid = @db_uid
       INNER JOIN sindex.dbo.[table] AS [par_table]
       ON [par_table].table_id     = foreign_keys.parent_object_id AND
          [par_table].database_uid = @db_uid
       CROSS APPLY (
         SELECT '','' + columns.name
         FROM [db].sys.foreign_key_columns
              INNER JOIN [db].sys.columns
              ON columns.object_id = foreign_key_columns.parent_object_id AND
                 columns.column_id = foreign_key_columns.parent_column_id
         WHERE foreign_key_columns.constraint_object_id = foreign_keys.object_id
         ORDER BY foreign_key_columns.constraint_column_id
         FOR XML PATH ('''')
       ) par_columns (col)
       CROSS APPLY (
         SELECT '','' + columns.name
         FROM [db].sys.foreign_key_columns
              INNER JOIN [db].sys.columns
              ON columns.object_id = foreign_key_columns.referenced_object_id AND
                 columns.column_id = foreign_key_columns.referenced_column_id
         WHERE foreign_key_columns.constraint_object_id = foreign_keys.object_id
         ORDER BY foreign_key_columns.constraint_column_id
         FOR XML PATH ('''')
       ) ref_columns (col)
  WHERE NOT EXISTS(SELECT 1
                   FROM sindex.dbo.[constraint]
                   WHERE [constraint].constraint_name COLLATE Latin1_General_CI_AS = foreign_keys.name COLLATE Latin1_General_CI_AS
                     AND [constraint].database_uid = @db_uid);


  DELETE FROM sindex.dbo.[constraint]
  WHERE NOT EXISTS(SELECT 1
                   FROM [db].sys.foreign_keys
                   WHERE foreign_keys.name COLLATE Latin1_General_CI_AS = [constraint].constraint_name COLLATE Latin1_General_CI_AS)
    AND [constraint].database_uid = @db_uid;

  UPDATE [constraint]
     SET constraint_id        = foreign_keys.object_id
        ,constraint_name      = foreign_keys.name
        ,update_date          = GETDATE()
        ,create_date          = foreign_keys.create_date
        ,type                 = ''FK''
        ,parent_table_uid     = [par_table].table_uid
        ,referenced_table_uid = [ref_table].table_uid
        ,default_value        = NULL
        ,check_condition      = NULL
        ,referenced_columns   = STUFF(ref_columns.col,1,1,'''')
        ,parent_columns       = STUFF(par_columns.col,1,1,'''')
        ,is_disabled          = foreign_keys.is_disabled
        ,is_not_trusted       = foreign_keys.is_not_trusted
  FROM sindex.dbo.[constraint]
       INNER JOIN [db].sys.foreign_keys
       ON foreign_keys.name COLLATE Latin1_General_CI_AS = [constraint].constraint_name COLLATE Latin1_General_CI_AS
       INNER JOIN sindex.dbo.[table] AS [ref_table]
       ON [ref_table].table_id     = foreign_keys.referenced_object_id AND
          [ref_table].database_uid = @db_uid
       INNER JOIN sindex.dbo.[table] AS [par_table]
       ON [par_table].table_id     = foreign_keys.parent_object_id AND
          [par_table].database_uid = @db_uid
       CROSS APPLY (
         SELECT '','' + columns.name
         FROM [db].sys.foreign_key_columns
              INNER JOIN [db].sys.columns
              ON columns.object_id = foreign_key_columns.parent_object_id AND
                 columns.column_id = foreign_key_columns.parent_column_id
         WHERE foreign_key_columns.constraint_object_id = foreign_keys.object_id
         ORDER BY foreign_key_columns.constraint_column_id
         FOR XML PATH ('''')
       ) par_columns (col)
       CROSS APPLY (
         SELECT '','' + columns.name
         FROM [db].sys.foreign_key_columns
              INNER JOIN [db].sys.columns
              ON columns.object_id = foreign_key_columns.referenced_object_id AND
                 columns.column_id = foreign_key_columns.referenced_column_id
         WHERE foreign_key_columns.constraint_object_id = foreign_keys.object_id
         ORDER BY foreign_key_columns.constraint_column_id
         FOR XML PATH ('''')
       ) ref_columns (col)
  WHERE [constraint].database_uid = @db_uid
    AND EXISTS(SELECT 1  WHERE [constraint].constraint_id        <> foreign_keys.object_id        UNION ALL
               SELECT 1  WHERE [constraint].constraint_name COLLATE Latin1_General_CI_AS <> foreign_keys.name COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [constraint].create_date          <> foreign_keys.create_date      UNION ALL
               SELECT 1  WHERE [constraint].type                 <> ''FK''                          UNION ALL
               SELECT 1  WHERE [constraint].parent_table_uid     <> [par_table].table_uid         UNION ALL
               SELECT 1  WHERE [constraint].referenced_table_uid <> [ref_table].table_uid         UNION ALL
               SELECT 1  WHERE [constraint].default_value        <> NULL                          UNION ALL
               SELECT 1  WHERE [constraint].check_condition      <> NULL                          UNION ALL
               SELECT 1  WHERE [constraint].referenced_columns COLLATE Latin1_General_CI_AS <> STUFF(ref_columns.col,1,1,'''') COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [constraint].parent_columns     COLLATE Latin1_General_CI_AS <> STUFF(par_columns.col,1,1,'''') COLLATE Latin1_General_CI_AS UNION ALL
               SELECT 1  WHERE [constraint].is_disabled          <> foreign_keys.is_disabled      UNION ALL
               SELECT 1  WHERE [constraint].is_not_trusted       <> foreign_keys.is_not_trusted);
  ';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END

  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END