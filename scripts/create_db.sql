IF NOT EXISTS(SELECT 1
              FROM sys.databases
              WHERE name = 'sindex')
BEGIN
  CREATE DATABASE sindex;
END
GO
DROP TABLE IF EXISTS dbo.[index];
DROP TABLE IF EXISTS dbo.[constraint];
DROP TABLE IF EXISTS dbo.[stat];
DROP TABLE IF EXISTS dbo.[table];
DROP TABLE IF EXISTS dbo.[file];
DROP TABLE IF EXISTS dbo.[filegroup];
DROP TABLE IF EXISTS dbo.[server_configurations];
DROP TABLE IF EXISTS dbo.[database_configurations];
DROP TABLE IF EXISTS dbo.[database];
DROP TABLE IF EXISTS dbo.[server];
DROP TABLE IF EXISTS dbo.[configuration];
GO
CREATE TABLE dbo.[server](
  server_id   int PRIMARY KEY NOT NULL
 ,server_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
);
GO
CREATE TABLE dbo.[configuration](
  configuration_id int PRIMARY KEY NOT NULL
 ,configuration_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
);
GO
CREATE TABLE dbo.[server_configurations](
  configuration_id int PRIMARY KEY NOT NULL
 ,server_id int NOT NULL
 ,configuration_value varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
);
GO
CREATE TABLE dbo.[database](
  database_id int PRIMARY KEY NOT NULL
 ,server_id int NOT NULL
 ,database_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
);
GO
CREATE TABLE dbo.[database_configurations](
  configuration_id int NOT NULL
 ,database_id int NOT NULL
 ,configuration_value varchar(255) COLLATE Latin1_General_CI_AS
 ,update_date datetime
);
GO
CREATE TABLE dbo.[filegroup](
  filegroup_id int PRIMARY KEY NOT NULL
 ,database_id int NOT NULL
 ,filegroup_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,filegroup_type varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
);
GO
CREATE TABLE dbo.[file](
  file_id int PRIMARY KEY NOT NULL
 ,file_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,file_size_kb numeric(18,6) NOT NULL
 ,filegroup_id int NOT NULL
 ,update_date datetime
)
GO
CREATE TABLE dbo.[table](
  table_id int PRIMARY KEY NOT NULL
 ,filegroup_id int NOT NULL
 ,table_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime
 ,create_date datetime
 ,type varchar(10) COLLATE Latin1_General_CI_AS NOT NULL
);
GO
CREATE TABLE dbo.[stat](
  stat_id int PRIMARY KEY
 ,stat_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime
 ,create_date datetime NOT NULL
 ,type varchar(10) COLLATE Latin1_General_CI_AS NOT NULL
 ,table_id int NOT NULL
 ,filter varchar(4000) COLLATE Latin1_General_CI_AS
 ,is_autocreated bit NOT NULL
);
GO
CREATE TABLE dbo.[constraint](
  constraint_id int PRIMARY KEY
 ,constraint_name varchar(255) COLLATE Latin1_General_CI_AS
 ,update_date datetime
 ,create_date datetime NOT NULL
 ,type varchar(10) COLLATE Latin1_General_CI_AS
 ,parent_table_id int NOT NULL
 ,referenced_table_id int NOT NULL
 ,default_value varchar(255) NULL
 ,check_condition varchar(4000) NULL
 ,referenced_columns varchar(4000) NULL
 ,parent_columns varchar(4000) NULL
 ,is_disabled bit NOT NULL
 ,is_not_trusted bit NOT NULL
);
GO
CREATE TABLE dbo.[index](
  table_id int NOT NULL
 ,filegroup_id int NOT NULL
 ,index_id int NOT NULL
 ,update_date datetime
 ,create_date datetime
 ,index_name datetime
 ,type varchar(10) COLLATE Latin1_General_CI_AS
 ,key_columns varchar(max) COLLATE Latin1_General_CI_AS
 ,include_columns varchar(MAX) COLLATE Latin1_General_CI_AS
 ,fill_factor int
 ,is_primary_key bit
 ,is_unique_constraint bit
 ,is_disabled bit
 ,filter_condition varchar(1000) COLLATE Latin1_General_CI_AS
 ,script_create varchar(8000)
 ,script_drop varchar(1000)
)