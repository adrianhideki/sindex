using Dapper;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.repository
{
    public static class dbTables
    {
        public static void LoadServer(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetServers", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadDatabases(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetDatabases", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadFilegroups(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetFileGroups", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadFiles(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetFiles", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadTables(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetTables", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadConstraints(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetConstraints", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadStats(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetStats", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadIndexes(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetIndexes", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void DeleteDataFromDisabledDatabases(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_ExcludeDataFromDisableDatabase", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }

        public static DataTable GetDatabases(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            DataTable res = db.executeDataTable("select * from dbo.[database]", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
        public static DataTable GetDatabases(Credentials cred, string database, string filtro)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            param.Add("@banco", filtro, DbType.String, ParameterDirection.Input);

            string errMsg = "";
            int returnCode = 0;

            DataTable res = db.executeDataTable("select * from dbo.[database] where database_name LIKE '%' + @banco + '%'", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
        public static DataTable GetMemoryInfo(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"SELECT total_physical_memory_kb/1024 AS [Physical Memory (MB)],
                           available_physical_memory_kb / 1024 AS[Available Memory(MB)],
                           total_page_file_kb / 1024 / 1024 AS[Total Page File(GB)],
                           available_page_file_kb / 1024 AS[Available Page File(MB)], 
                           system_cache_kb / 1024 AS[System Cache(MB)],
                           system_memory_state_desc AS[System Memory State]
                    FROM sys.dm_os_sys_memory WITH(NOLOCK) OPTION(RECOMPILE); ";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
        public static DataTable GetCPUInfo(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"DECLARE @ts_now bigint = (SELECT cpu_ticks/(cpu_ticks/ms_ticks)FROM sys.dm_os_sys_info);

                 ;WITH CTA
                  AS (SELECT TOP(10) 
                             [SQL Server Process CPU Utilization] = SQLProcessUtilization, 
                             [System Idle Process]                = SystemIdle, 
                             [Other Process CPU Utilization]      = 100 - SystemIdle - SQLProcessUtilization, 
                             [Event Time]                         = CAST(DATEADD(ms, -1 * (@ts_now - [timestamp]), GETDATE()) AS time)
                      FROM ( 
                            SELECT record_id               = record.value('(./Record/@id)[1]', 'int'), 
                                   [SystemIdle]            = record.value('(./Record/SchedulerMonitorEvent/SystemHealth/SystemIdle)[1]', 'int'), 
                                   [SQLProcessUtilization] = record.value('(./Record/SchedulerMonitorEvent/SystemHealth/ProcessUtilization)[1]','int'),
                                   [timestamp]
                            FROM ( 
                                  SELECT [timestamp], CONVERT(xml, record) AS [record] 
                                  FROM sys.dm_os_ring_buffers 
                                  WHERE ring_buffer_type = N'RING_BUFFER_SCHEDULER_MONITOR' 
                                  AND record LIKE '%<SystemHealth>%') AS x 
                       ) AS y 
                  ORDER BY record_id DESC)
                 SELECT * ,ROWID = ROW_NUMBER() OVER (ORDER BY [Event Time] ASC)
                 FROM CTA;";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static DataTable GetActiveDatabases(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"SELECT * FROM dbo.[database] WHERE ativo = 1";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static DataTable GetDatabasesFileInfo(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"EXEC dbo.st_GetDatabaseFilesInfo";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static int GetMinLastUpdate(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"SELECT * FROM dbo.fn_GetLastUpdate()";

            int res = db.executeScalar<int>(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static DataTable SetDatabaseEnabled(Credentials cred, string database, int databaseId, bool enabled)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            param.Add("@database_uid", databaseId, DbType.Int32, ParameterDirection.Input);
            param.Add("@ativo", enabled, DbType.Boolean, ParameterDirection.Input);

            string errMsg = "";
            int returnCode = 0;

            DataTable res = db.executeDataTable("UPDATE [database] set ativo = @ativo where database_uid = @database_uid", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
        public static DataTable SetDatabaseEnabled(Credentials cred, string database, bool enabled)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            param.Add("@ativo", enabled, DbType.Boolean, ParameterDirection.Input);

            string errMsg = "";
            int returnCode = 0;

            DataTable res = db.executeDataTable("UPDATE [database] set ativo = @ativo", param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
    }
}
