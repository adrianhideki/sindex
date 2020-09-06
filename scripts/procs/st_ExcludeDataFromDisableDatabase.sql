CREATE PROCEDURE dbo.st_ExcludeDataFromDisableDatabase
AS
BEGIN
  DELETE FROM dbo.[database_configurations] 
  WHERE EXISTS(SELECT 1 
               FROM dbo.[database] 
               WHERE [database].database_uid = [database_configurations].database_uid AND [database].ativo = 0);

  DELETE FROM dbo.[filegroup] 
  WHERE EXISTS(SELECT 1 
               FROM dbo.[database] 
               WHERE [database].database_uid = [filegroup].database_uid AND [database].ativo = 0);

  DELETE FROM dbo.[file] 
  WHERE EXISTS(SELECT 1 
               FROM dbo.[database] 
               WHERE [database].database_uid = [file].database_uid AND [database].ativo = 0);

  DELETE FROM dbo.[table] 
  WHERE EXISTS(SELECT 1 
               FROM dbo.[database] 
               WHERE [database].database_uid = [table].database_uid AND [database].ativo = 0);

  DELETE FROM dbo.[stat] 
  WHERE EXISTS(SELECT 1 
               FROM dbo.[database] 
               WHERE [database].database_uid = [stat].database_uid AND [database].ativo = 0);

  DELETE FROM dbo.[constraint] 
  WHERE EXISTS(SELECT 1 
               FROM dbo.[database] 
               WHERE [database].database_uid = [constraint].database_uid AND [database].ativo = 0);

  DELETE FROM dbo.[index] 
  WHERE EXISTS(SELECT 1 
               FROM dbo.[database] 
               WHERE [database].database_uid = [index].database_uid AND [database].ativo = 0);

  UPDATE [database]
     SET update_date = GETDATE();
END