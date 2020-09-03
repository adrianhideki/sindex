CREATE TABLE [dbo].[server](
	[server_id] [int] IDENTITY(1,1) NOT NULL,
	[server_name] [varchar](255) COLLATE Latin1_General_CI_AS NOT NULL,
	[update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[server_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
) 

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