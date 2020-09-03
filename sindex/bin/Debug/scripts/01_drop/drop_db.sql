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