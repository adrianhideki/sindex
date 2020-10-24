CREATE PROCEDURE dbo.st_GetScriptIndexes @database_name varchar(50) = ''
                                        ,@table_name    varchar(50) = ''
                                        ,@index_name    varchar(50) = ''
AS
BEGIN
  SELECT @database_name = ISNULL(@database_name,'')
        ,@table_name = ISNULL(@table_name,'')
        ,@index_name = ISNULL(@index_name,'');

  SELECT database_name = [database].database_name
        ,table_name    = [table].table_name
        ,index_name    = [index].index_name
        ,create_date   = [index].create_date
        ,script_drop   = [index].script_drop
        ,script_create = [index].script_create
  FROM dbo.[index]
       INNER JOIN dbo.[table]
       ON [table].table_uid = [index].table_uid
       INNER JOIN dbo.[database]
       ON [database].database_uid = [index].database_uid
  WHERE [index].is_primary_key = 0
    AND [index].is_unique_constraint = 0
    AND [index].type NOT IN ('XML')
    AND EXISTS(SELECT 1 WHERE @database_name = ''
               UNION ALL
               SELECT 1 WHERE [database].database_name LIKE '%'+@database_name+'%')
    AND EXISTS(SELECT 1 WHERE @table_name = ''
               UNION ALL
               SELECT 1 WHERE [table].table_name LIKE '%'+@table_name+'%')
    AND EXISTS(SELECT 1 WHERE @index_name = ''
               UNION ALL
               SELECT 1 WHERE [index].index_name LIKE '%'+@index_name+'%')
END