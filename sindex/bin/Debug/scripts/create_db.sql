IF OBJECT_ID('[dbo].[st_GetServers]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetServers];
IF OBJECT_ID('[dbo].[st_GetDatabases]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetDatabases];
IF OBJECT_ID('[dbo].[st_GetFilegroups]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetFilegroups];
IF OBJECT_ID('[dbo].[st_GetFiles]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetFiles];
IF OBJECT_ID('[dbo].[st_GetTables]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetTables];
IF OBJECT_ID('[dbo].[st_GetStats]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetStats];
IF OBJECT_ID('[dbo].[st_GetConstraints]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetConstraints];
IF OBJECT_ID('[dbo].[st_GetIndexes]') IS NOT NULL DROP PROCEDURE [dbo].[st_GetIndexes];
IF OBJECT_ID('[dbo].[server]') IS NOT NULL DROP TABLE [dbo].[server];
IF OBJECT_ID('[dbo].[configuration]') IS NOT NULL DROP TABLE [dbo].[configuration];
IF OBJECT_ID('[dbo].[server_configurations]') IS NOT NULL DROP TABLE [dbo].[server_configurations];
IF OBJECT_ID('[dbo].[database]') IS NOT NULL DROP TABLE [dbo].[database];
IF OBJECT_ID('[dbo].[database_configurations]') IS NOT NULL DROP TABLE [dbo].[database_configurations];
IF OBJECT_ID('[dbo].[filegroup]') IS NOT NULL DROP TABLE [dbo].[filegroup];
IF OBJECT_ID('[dbo].[file]') IS NOT NULL DROP TABLE [dbo].[file];
IF OBJECT_ID('[dbo].[table]') IS NOT NULL DROP TABLE [dbo].[table];
IF OBJECT_ID('[dbo].[stat]') IS NOT NULL DROP TABLE [dbo].[stat];
IF OBJECT_ID('[dbo].[constraint]') IS NOT NULL DROP TABLE [dbo].[constraint];
IF OBJECT_ID('[dbo].[index]') IS NOT NULL DROP TABLE [dbo].[index];
IF OBJECT_ID('[dbo].[fn_GetServerId]') IS NOT NULL DROP FUNCTION [dbo].[fn_GetServerId];
GO
/****** Object:  Table [dbo].[server]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[server](
	[server_id] [int] IDENTITY(1,1) NOT NULL,
	[server_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[server_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetServerId]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_GetServerId]()
RETURNS TABLE
AS RETURN(
  SELECT [server].server_id
  FROM sys.servers
       INNER JOIN dbo.[server]
	   ON [server].server_name = servers.name
);
GO
/****** Object:  Table [dbo].[configuration]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[configuration](
	[configuration_id] [int] IDENTITY(1,1) NOT NULL,
	[configuration_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[configuration_description] [varchar](512) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[configuration_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[constraint]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[constraint](
	[constraint_uid] [int] IDENTITY(1,1) NOT NULL,
	[object_id] [int] NULL,
	[constraint_name] [varchar](255) COLLATE Latin1_General_CI_AS NULL,
	[update_date] [datetime] NULL,
	[create_date] [datetime] NOT NULL,
	[type] [varchar](10) COLLATE Latin1_General_CI_AS NULL,
	[parent_table_uid] [int] NOT NULL,
	[referenced_table_uid] [int] NOT NULL,
	[default_value] [varchar](255) COLLATE Latin1_General_CI_AS NULL,
	[check_condition] [varchar](4000) COLLATE Latin1_General_CI_AS NULL,
	[referenced_columns] [varchar](4000) COLLATE Latin1_General_CI_AS NULL,
	[parent_columns] [varchar](4000) COLLATE Latin1_General_CI_AS NULL,
	[is_disabled] [bit] NOT NULL,
	[is_not_trusted] [bit] NOT NULL,
	[database_uid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[constraint_uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[database]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[database](
	[database_uid] [int] IDENTITY(1,1) NOT NULL,
	[server_id] [int] NOT NULL,
	[database_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[database_uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[database_configurations]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[database_configurations](
	[configuration_id] [int] NOT NULL,
	[database_uid] [int] NOT NULL,
	[configuration_value] [varchar](255) COLLATE Latin1_General_CI_AS NULL,
	[update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[configuration_id] ASC,
	[database_uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[file]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[file](
	[file_uid] [int] IDENTITY(1,1) NOT NULL,
	[file_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[file_size_kb] [numeric](18, 6) NOT NULL,
	[filegroup_uid] [int] NOT NULL,
	[file_path] [varchar](500) COLLATE Latin1_General_CI_AS NULL,
	[file_growth_size_kb] [numeric](18, 6) NOT NULL,
	[update_date] [datetime] NULL,
	[database_uid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[file_uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[filegroup]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filegroup](
	[filegroup_uid] [int] IDENTITY(1,1) NOT NULL,
	[database_uid] [int] NOT NULL,
	[filegroup_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[filegroup_type] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[filegroup_uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[index]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[index](
	[index_uid] [int] IDENTITY(1,1) NOT NULL,
	[table_uid] [int] NOT NULL,
	[index_id] [int] NOT NULL,
	[update_date] [datetime] NULL,
	[create_date] [datetime] NULL,
	[index_name] [varchar](100) COLLATE Latin1_General_CI_AS NULL,
	[type] [varchar](50) COLLATE Latin1_General_CI_AS NULL,
	[key_columns] [varchar](max) COLLATE Latin1_General_CI_AS NULL,
	[include_columns] [varchar](max) COLLATE Latin1_General_CI_AS NULL,
	[fill_factor] [int] NULL,
	[is_primary_key] [bit] NULL,
	[is_unique_constraint] [bit] NULL,
	[is_disabled] [bit] NULL,
	[filter_condition] [varchar](1000) COLLATE Latin1_General_CI_AS NULL,
	[script_create] [varchar](max) COLLATE Latin1_General_CI_AS NULL,
	[script_drop] [varchar](max) COLLATE Latin1_General_CI_AS NULL,
	[database_uid] [int] NOT NULL,
	[filegroup_uid] [int] NOT NULL
);
GO
/****** Object:  Table [dbo].[server_configurations]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[server_configurations](
	[configuration_id] [int] NOT NULL,
	[server_id] [int] NOT NULL,
	[configuration_value] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[configuration_id] ASC,
	[server_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[stat]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stat](
	[stat_uid] [int] IDENTITY(1,1) NOT NULL,
	[stat_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
	[create_date] [datetime] NOT NULL,
	[type] [varchar](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[table_uid] [int] NOT NULL,
	[filter] [varchar](4000) COLLATE Latin1_General_CI_AS NULL,
	[is_autocreated] [bit] NOT NULL,
	[database_uid] [int] NOT NULL,
	[columns] [varchar](5000) COLLATE Latin1_General_CI_AS NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stat_uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
/****** Object:  Table [dbo].[table]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table](
	[table_uid] [int] IDENTITY(1,1) NOT NULL,
	[object_id] [int] NULL,
	[filegroup_uid] [int] NOT NULL,
	[table_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
	[create_date] [datetime] NULL,
	[type] [varchar](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[database_uid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[table_uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetConstraints]
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
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
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
    object_id
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

  SELECT object_id            = foreign_keys.object_id
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
       ON [ref_table].object_id    = foreign_keys.referenced_object_id AND
          [ref_table].database_uid = @db_uid
       INNER JOIN sindex.dbo.[table] AS [par_table]
       ON [par_table].object_id    = foreign_keys.parent_object_id AND
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
     SET object_id            = foreign_keys.object_id
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
       ON [ref_table].object_id    = foreign_keys.referenced_object_id AND
          [ref_table].database_uid = @db_uid
       INNER JOIN sindex.dbo.[table] AS [par_table]
       ON [par_table].object_id    = foreign_keys.parent_object_id AND
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
    AND EXISTS(SELECT 1  WHERE [constraint].object_id            <> foreign_keys.object_id        UNION ALL
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
GO
/****** Object:  StoredProcedure [dbo].[st_GetDatabases]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetDatabases]
AS
BEGIN
  SET NOCOUNT ON;

  INSERT INTO dbo.[database](
    server_id
   ,database_name
   ,update_date
  )
  SELECT server_id     = fn.server_id
        ,database_name = databases.name
        ,update_date   = GETDATE()
  FROM sys.databases
       CROSS APPLY dbo.fn_GetServerId() fn
  WHERE NOT EXISTS(SELECT 1
                   FROM dbo.[database] as dat
				   WHERE dat.database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
				     AND dat.server_id   = fn.server_id);

  DELETE [database]
  FROM dbo.[database]
  WHERE NOT EXISTS(SELECT 1
                   FROM sys.databases 
                   WHERE databases.name COLLATE Latin1_General_CI_AS = [database].database_name COLLATE Latin1_General_CI_AS);

  UPDATE [database]
     SET update_date = GETDATE()
  FROM dbo.[database]
       INNER JOIN sys.databases
       ON databases.name COLLATE Latin1_General_CI_AS = [database].database_name COLLATE Latin1_General_CI_AS;
END
GO
/****** Object:  StoredProcedure [dbo].[st_GetFilegroups]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetFilegroups]
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
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
      WHERE EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN

    SELECT @cmd = '
    INSERT INTO sindex.dbo.[filegroup](
      database_uid
     ,filegroup_name
     ,filegroup_type
     ,update_date
    )
    SELECT database_uid = @db_uid
          ,filegroup_name = filegroups.name
          ,filegroup_type = filegroups.type
          ,update_date    = GETDATE()
    FROM [db].sys.filegroups
    WHERE NOT EXISTS(SELECT 1
                     FROM sindex.dbo.[filegroup]
                     WHERE [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS
                       AND [filegroup].database_uid   = @db_uid);

    DELETE FROM sindex.dbo.[filegroup]
    WHERE [filegroup].database_uid = @db_uid
      AND NOT EXISTS(SELECT 1
                     FROM [db].sys.filegroups
                     WHERE filegroups.name COLLATE Latin1_General_CI_AS = [filegroup].filegroup_name COLLATE Latin1_General_CI_AS)

    UPDATE [filegroup]
       SET filegroup_type = filegroups.type
          ,update_date = GETDATE()
    FROM sindex.dbo.[filegroup]
         INNER JOIN [db].sys.filegroups
         ON filegroups.name COLLATE Latin1_General_CI_AS = [filegroup].filegroup_name COLLATE Latin1_General_CI_AS
    WHERE [filegroup].database_uid = @db_uid
      AND filegroups.type COLLATE Latin1_General_CI_AS <> [filegroup].filegroup_type COLLATE Latin1_General_CI_AS;';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END
  
  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END
GO
/****** Object:  StoredProcedure [dbo].[st_GetFiles]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetFiles]
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
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
      WHERE EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN
    SELECT @cmd = '
    INSERT INTO sindex.dbo.[file](
      file_name
     ,file_size_kb
     ,filegroup_uid
     ,update_date
     ,file_path
     ,file_growth_size_kb
     ,database_uid
    )
    SELECT file_name = database_files.name
          ,file_size_kb = (database_files.size * 8.)
          ,filegroup_uid = [filegroup].filegroup_uid
          ,update_date = GETDATE()
          ,file_path = database_files.physical_name
          ,file_growth_size_kb = (database_files.growth * 8.)
          ,database_uid = @db_uid
    FROM [db].sys.database_files
         INNER JOIN [db].sys.filegroups
         ON filegroups.data_space_id = database_files.data_space_id
         INNER JOIN sindex.dbo.[filegroup]
         ON [filegroup].database_uid   = @db_uid AND
            [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS
    WHERE NOT EXISTS (SELECT 1
                      FROM sindex.dbo.[file]
                      WHERE [file].file_name COLLATE Latin1_General_CI_AS = database_files.name COLLATE Latin1_General_CI_AS
                        AND [file].filegroup_uid = [filegroup].filegroup_uid);

    DELETE [file] 
    FROM sindex.dbo.[file]
    WHERE [file].database_uid = @db_uid
      AND NOT EXISTS(SELECT 1
                     FROM [db].sys.database_files
                          INNER JOIN [db].sys.filegroups
                          ON filegroups.data_space_id = database_files.data_space_id
                          INNER JOIN sindex.dbo.[filegroup]
                          ON [filegroup].database_uid   = @db_uid AND
                             [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS
                     WHERE database_files.name COLLATE Latin1_General_CI_AS = [file].file_name COLLATE Latin1_General_CI_AS
                       AND [filegroup].filegroup_uid                        = [file].filegroup_uid);

    UPDATE [file]
       SET file_name           = database_files.name
          ,file_size_kb        = (database_files.size * 8.)
          ,update_date         = GETDATE()
          ,file_path           = database_files.physical_name
          ,file_growth_size_kb = (database_files.growth * 8.)
    FROM sindex.dbo.[file]
         INNER JOIN [db].sys.database_files
         ON database_files.name COLLATE Latin1_General_CI_AS = [file].file_name COLLATE Latin1_General_CI_AS
         INNER JOIN [db].sys.filegroups
         ON filegroups.data_space_id = database_files.data_space_id
         INNER JOIN sindex.dbo.[filegroup]
         ON [filegroup].database_uid   = @db_uid AND
            [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
            [filegroup].filegroup_uid = [file].filegroup_uid
    WHERE [file].database_uid = @db_uid
      AND([file].file_name COLLATE Latin1_General_CI_AS <> database_files.name COLLATE Latin1_General_CI_AS
       OR [file].file_size_kb <> (database_files.size * 8.)
       OR [file].file_path COLLATE Latin1_General_CI_AS <> database_files.physical_name COLLATE Latin1_General_CI_AS
       OR [file].file_growth_size_kb <> (database_files.growth * 8.));';
       
    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END
  
  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END
GO
/****** Object:  StoredProcedure [dbo].[st_GetIndexes]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetIndexes]
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
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
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
         ON [table].object_id = objects.object_id AND
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
                        ON [table].object_id = objects.object_id AND
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
       ON [table].object_id = objects.object_id AND
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
GO
/****** Object:  StoredProcedure [dbo].[st_GetServers]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetServers]
AS
BEGIN
  SET NOCOUNT ON;

  INSERT INTO dbo.[server](
    server_name
   ,update_date
  )
  SELECT servers.name
        ,update_date = GETDATE()
  FROM sys.servers
  WHERE NOT EXISTS(SELECT 1
                   FROM dbo.[server] 
				   WHERE [server].server_name COLLATE Latin1_General_CI_AS = servers.name COLLATE Latin1_General_CI_AS);

  DELETE FROM dbo.[server]
  WHERE NOT EXISTS(SELECT 1
                   FROM sys.servers
                   WHERE servers.name COLLATE Latin1_General_CI_AS = [server].server_name COLLATE Latin1_General_CI_AS);
END
GO
/****** Object:  StoredProcedure [dbo].[st_GetStats]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetStats]
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
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
      WHERE EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN
    SELECT @cmd = '
  INSERT INTO sindex.dbo.[stat](
    stat_name
   ,update_date
   ,create_date
   ,type
   ,table_uid
   ,filter
   ,is_autocreated
   ,database_uid
   ,columns
  )
  SELECT stat_name      = stats.name
        ,update_date    = GETDATE()
        ,create_date    = GETDATE()
        ,type           = ''''
        ,table_uid      = [table].table_uid
        ,filter         = ISNULL(stats.filter_definition,'''')
        ,is_autocreated = stats.auto_created
        ,database_uid   = @db_uid
        ,ISNULL(STUFF(_columns.col,1,1,''''),'''')
  FROM [db].sys.stats 
       CROSS APPLY (SELECT '',''+columns.name
                    FROM [db].sys.stats_columns
                         INNER JOIN [db].sys.columns
                         ON columns.object_id = stats_columns.object_id AND 
                            columns.column_id = stats_columns.column_id
                    WHERE stats_columns.stats_id = stats.stats_id
                    ORDER BY stats_columns.stats_column_id
                    FOR XML PATH ('''')) _columns (col)
       INNER JOIN sindex.dbo.[table]
       ON [table].object_id    = stats.object_id AND
          [table].database_uid = @db_uid
  WHERE NOT EXISTS(SELECT 1
                   FROM sindex.dbo.[stat]
                   WHERE [stat].stat_name COLLATE Latin1_General_CI_AS = stats.name COLLATE Latin1_General_CI_AS
                     AND [stat].database_uid = @db_uid);

  DELETE FROM sindex.dbo.[stat]
  WHERE NOT EXISTS(SELECT 1
                   FROM [db].sys.stats
                   WHERE stats.name COLLATE Latin1_General_CI_AS = [stat].stat_name COLLATE Latin1_General_CI_AS)
    AND [stat].database_uid = @db_uid;

  UPDATE [stat]
     SET update_date    = GETDATE()
        ,type           = ''''
        ,table_uid      = [table].table_uid
        ,filter         = stats.filter_definition
        ,is_autocreated = stats.auto_created
        ,[columns]      = ISNULL(STUFF(_columns.col,1,1,''''),'''')
  FROM sindex.dbo.[stat]
       INNER JOIN [db].sys.stats 
       ON stats.name COLLATE Latin1_General_CI_AS = [stat].stat_name COLLATE Latin1_General_CI_AS
       CROSS APPLY (SELECT '',''+columns.name
                    FROM [db].sys.stats_columns
                         INNER JOIN [db].sys.columns
                         ON columns.object_id = stats_columns.object_id AND 
                            columns.column_id = stats_columns.column_id
                    WHERE stats_columns.stats_id = stats.stats_id
                    ORDER BY stats_columns.stats_column_id
                    FOR XML PATH ('''')) _columns (col)
       INNER JOIN sindex.dbo.[table]
       ON [table].object_id    = stats.object_id AND
          [table].database_uid = @db_uid
  WHERE [table].database_uid = @db_uid
    AND EXISTS(SELECT 1 WHERE [stat].table_uid <> [table].table_uid
               UNION ALL
               SELECT 1 WHERE [stat].filter COLLATE Latin1_General_CI_AS <> stats.filter_definition COLLATE Latin1_General_CI_AS
               UNION ALL
               SELECT 1 WHERE [stat].is_autocreated <> stats.auto_created
               UNION ALL
               SELECT 1 WHERE [stat].[columns] <> ISNULL(STUFF(_columns.col,1,1,''''),''''));
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
GO
/****** Object:  StoredProcedure [dbo].[st_GetTables]    Script Date: 26/08/2020 22:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_GetTables]
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
           ON [database].database_name COLLATE Latin1_General_CI_AS = databases.name COLLATE Latin1_General_CI_AS
      WHERE EXISTS(SELECT *
                   FROM dbo.fn_GetServerId() fn
                   WHERE fn.server_id = [database].server_id);

  OPEN curDatabases;

  FETCH NEXT FROM curDatabases
  INTO @db_name, @db_uid;

  WHILE(@@FETCH_STATUS = 0)
  BEGIN
    SELECT @cmd = '
  INSERT INTO sindex.dbo.[table](
    object_id
   ,filegroup_uid
   ,table_name
   ,update_date
   ,create_date
   ,type
   ,database_uid
  )
  SELECT object_id = tables.object_id
        ,filegroup_uid =  [filegroup].filegroup_uid
        ,table_name = tables.name
        ,update_date = GETDATE()
        ,create_date = tables.create_date
        ,type = tables.type
        ,db_uid = @db_uid
  FROM [db].sys.tables 
       INNER JOIN [db].sys.indexes
       ON indexes.object_id = tables.object_id AND
          indexes.type IN (0,1)
       INNER JOIN [db].sys.filegroups
       ON filegroups.data_space_id = indexes.data_space_id
       INNER JOIN sindex.dbo.[filegroup]
       ON [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
          [filegroup].database_uid = @db_uid
  WHERE NOT EXISTS(SELECT 1
                   FROM sindex.dbo.[table]
                   WHERE [table].table_name COLLATE Latin1_General_CI_AS = tables.name COLLATE Latin1_General_CI_AS
                     AND [table].database_uid = @db_uid);

  DELETE FROM sindex.dbo.[table]
  WHERE NOT EXISTS(SELECT 1
                   FROM [db].sys.tables
                   WHERE tables.name COLLATE Latin1_General_CI_AS = [table].table_name COLLATE Latin1_General_CI_AS)
    AND [table].database_uid = @db_uid;

  UPDATE [table]
     SET object_id     = tables.object_id
        ,filegroup_uid = [filegroup].database_uid
        ,table_name    = tables.name
        ,update_date   = GETDATE()
        ,create_date   = tables.create_date
        ,type          = tables.type
        ,database_uid  = @db_uid
  FROM sindex.dbo.[table]
       INNER JOIN [db].sys.tables 
       ON tables.name COLLATE Latin1_General_CI_AS = [table].table_name COLLATE Latin1_General_CI_AS
       INNER JOIN [db].sys.indexes
       ON indexes.object_id = tables.object_id AND
          indexes.type IN (0,1)
       INNER JOIN [db].sys.filegroups
       ON filegroups.data_space_id = indexes.data_space_id
       INNER JOIN sindex.dbo.[filegroup]
       ON [filegroup].filegroup_name COLLATE Latin1_General_CI_AS = filegroups.name COLLATE Latin1_General_CI_AS AND
          [filegroup].database_uid = @db_uid
  WHERE [table].database_uid = @db_uid
    AND EXISTS(SELECT 1 WHERE [table].object_id <> tables.object_id
               UNION ALL
               SELECT 1 WHERE [table].filegroup_uid <> [filegroup].database_uid
               UNION ALL
               SELECT 1 WHERE [table].table_name COLLATE Latin1_General_CI_AS <> tables.name COLLATE Latin1_General_CI_AS
               UNION ALL
               SELECT 1 WHERE [table].create_date <> tables.create_date
               UNION ALL
               SELECT 1 WHERE [table].type COLLATE Latin1_General_CI_AS <> tables.type COLLATE Latin1_General_CI_AS);';

    SELECT @cmd = REPLACE(@cmd,'[db]',QUOTENAME(@db_name))
          ,@cmd = REPLACE(@cmd,'@db_uid',CAST(@db_uid AS varchar(10)));

    EXEC(@cmd);

    FETCH NEXT FROM curDatabases
    INTO @db_name, @db_uid;
  END
  
  CLOSE curDatabases;
  DEALLOCATE curDatabases;
END
GO
