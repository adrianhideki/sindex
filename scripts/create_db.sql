CREATE TABLE dbo.[server](
  server_id   int identity(1,1) PRIMARY KEY NOT NULL
 ,server_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
);

CREATE TABLE dbo.[configuration](
  configuration_id int identity(1,1) PRIMARY KEY NOT NULL
 ,configuration_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,configuration_description varchar(512) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
);

CREATE TABLE dbo.[server_configurations](
  configuration_id int NOT NULL
 ,server_id int NOT NULL
 ,configuration_value varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
 PRIMARY KEY(configuration_id, server_id)
);


CREATE TABLE dbo.[database](
  database_uid int identity(1,1) PRIMARY KEY NOT NULL
 ,server_id int NOT NULL
 ,database_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime NULL
 ,ativo bit NULL
);

CREATE TABLE dbo.[database_configurations](
  configuration_id int NOT NULL
 ,database_uid int NOT NULL
 ,configuration_value varchar(255) COLLATE Latin1_General_CI_AS
 ,update_date datetime
 ,PRIMARY KEY(configuration_id, database_uid)
);

CREATE TABLE dbo.[filegroup](
  filegroup_uid int identity(1,1) NOT NULL PRIMARY KEY
 ,database_uid int NOT NULL
 ,filegroup_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,filegroup_type varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime
);

CREATE TABLE dbo.[file](
  file_uid int identity(1,1) PRIMARY KEY NOT NULL
 ,file_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,file_size_kb numeric(18,6) NOT NULL
 ,filegroup_uid int NOT NULL
 ,file_path varchar(500) COLLATE Latin1_General_CI_AS
 ,file_growth_size_kb numeric(18,6) NOT NULL
 ,update_date datetime
 ,database_uid int NOT NULL
)

CREATE TABLE dbo.[table](
  table_uid int identity(1,1) PRIMARY KEY NOT NULL
 ,object_id int
 ,filegroup_uid int NOT NULL
 ,table_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime
 ,create_date datetime
 ,type varchar(10) COLLATE Latin1_General_CI_AS NOT NULL
 ,database_uid int NOT NULL
);


CREATE TABLE dbo.[stat](
  stat_uid int NOT NULL identity(1,1) PRIMARY KEY
 ,stat_name varchar(255) COLLATE Latin1_General_CI_AS NOT NULL
 ,update_date datetime
 ,create_date datetime NOT NULL
 ,type varchar(10) COLLATE Latin1_General_CI_AS NOT NULL
 ,table_uid int NOT NULL
 ,filter varchar(4000) COLLATE Latin1_General_CI_AS
 ,is_autocreated bit NOT NULL
 ,database_uid int NOT NULL
 ,columns varchar(5000) NOT NULL
);

CREATE TABLE dbo.[constraint](
  constraint_uid int identity(1,1) PRIMARY KEY 
 ,object_id int
 ,constraint_name varchar(255) COLLATE Latin1_General_CI_AS
 ,update_date datetime
 ,create_date datetime NOT NULL
 ,type varchar(10) COLLATE Latin1_General_CI_AS
 ,parent_table_uid int NOT NULL
 ,referenced_table_uid int NOT NULL
 ,default_value varchar(255) NULL
 ,check_condition varchar(4000) NULL
 ,referenced_columns varchar(4000) NULL
 ,parent_columns varchar(4000) NULL
 ,is_disabled bit NOT NULL
 ,is_not_trusted bit NOT NULL
 ,database_uid int NOT NULL
);

CREATE TABLE dbo.[index](
  index_uid int identity(1,1)
 ,table_uid int NOT NULL
 ,index_id int NOT NULL
 ,update_date datetime
 ,create_date datetime
 ,index_name varchar(100)
 ,type varchar(50) COLLATE Latin1_General_CI_AS
 ,key_columns varchar(max) COLLATE Latin1_General_CI_AS
 ,include_columns varchar(max) COLLATE Latin1_General_CI_AS
 ,fill_factor int
 ,is_primary_key bit
 ,is_unique_constraint bit
 ,is_disabled bit
 ,filter_condition varchar(1000) COLLATE Latin1_General_CI_AS
 ,script_create varchar(max)
 ,script_drop varchar(max)
 ,database_uid int NOT NULL
 ,filegroup_uid int NOT NULL
);

CREATE INDEX [IX_stat_stat_name] ON [dbo].[stat] ([stat_name]) INCLUDE ([table_uid], [filter], [is_autocreated], [columns]);

/*
ALTER TABLE dbo.[server_configurations]
ADD CONSTRAINT FK_server_server_configurations 
FOREIGN KEY (server_id) REFERENCES dbo.[server] (server_id);

ALTER TABLE dbo.[server_configurations]
ADD CONSTRAINT FK_Configuration_server_configurations 
FOREIGN KEY(configuration_id) REFERENCES dbo.[configuration] (configuration_id);

ALTER TABLE dbo.[database]
ADD CONSTRAINT FK_Server_Database 
FOREIGN KEY(server_id) REFERENCES dbo.[server] (server_id);

ALTER TABLE dbo.[database_configurations]
ADD CONSTRAINT FK_Database_database_configurations
FOREIGN KEY(database_uid) REFERENCES dbo.[database] (database_uid);

ALTER TABLE dbo.[database_configurations]
ADD CONSTRAINT FK_configuration_database_configurations
FOREIGN KEY(configuration_id) REFERENCES dbo.[configuration] (configuration_id);

ALTER TABLE dbo.[filegroup]
ADD CONSTRAINT FK_Database_filegroup
FOREIGN KEY(database_uid) REFERENCES dbo.[database] (database_uid);

ALTER TABLE dbo.[file]
ADD CONSTRAINT FK_filegroup_file
FOREIGN KEY(filegroup_uid) REFERENCES dbo.[filegroup] (filegroup_uid);

ALTER TABLE dbo.[table]
ADD CONSTRAINT FK_Table_filegroup
FOREIGN KEY(filegroup_uid) REFERENCES dbo.[filegroup] (filegroup_uid);

ALTER TABLE dbo.[stat]
ADD CONSTRAINT FK_stat_table
FOREIGN KEY (table_uid) REFERENCES dbo.[table] (table_uid);

ALTER TABLE dbo.[constraint]
ADD CONSTRAINT FK_constraint_parent_table
FOREIGN KEY (parent_table_uid) REFERENCES dbo.[table] (table_uid);

ALTER TABLE dbo.[constraint]
ADD CONSTRAINT FK_constraint_referenced_table
FOREIGN KEY (referenced_table_uid) REFERENCES dbo.[table] (table_uid);

ALTER TABLE dbo.[index]
ADD CONSTRAINT FK_index_table
FOREIGN KEY (table_uid) REFERENCES dbo.[table] (table_uid);

EXEC dbo.st_GetServers;
EXEC dbo.st_GetDatabases;
EXEC dbo.st_GetFilegroups;
EXEC dbo.st_GetFiles;
EXEC dbo.st_GetTables;
EXEC dbo.st_GetStats;
EXEC dbo.st_GetConstraints;
EXEC dbo.st_GetIndexes;
*/