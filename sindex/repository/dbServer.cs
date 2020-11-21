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
    public static class dbServer
    {
        #region Load Data Tables
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
        #endregion

        #region Connections
        public static void KillSession(Credentials cred, string database, int spid)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            int returnCode = 0;

            string cmd = String.Format("KILL {0};", spid);
            db.executeQuery(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }

        public static void SetNotifications(Credentials cred, string database)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            int returnCode = 0;

            string cmd = String.Format("EXEC dbo.st_SetNotification");
            db.executeQuery(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }

        public static DataTable GetNotifications(Credentials cred, string database, DateTime startDate, DateTime endDate)
        {
            dbConnect db = new dbConnect(cred);

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            DynamicParameters param = new DynamicParameters();

            param.Add("@p_Initial_Date", startDate, DbType.DateTime, ParameterDirection.Input);
            param.Add("@p_Finish_Date", endDate, DbType.DateTime, ParameterDirection.Input);

            cmd = @"EXEC dbo.st_GetNotifications @Initial_Date = @p_Initial_Date
                                                ,@Finish_Date  = @p_Finish_Date";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static DataTable GetSessionInfo(Credentials cred, string database, DynamicParameters param)
        {
            dbConnect db = new dbConnect(cred);

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"EXEC dbo.st_GetSessionsInfo @userConnections = @puserConnections
                           ,@db_name = @pdb_name
                           ,@host_name = @phost_name
                           ,@status = @pstatus
                           ,@only_blocked = @ponly_blocked
                           ,@reads = @preads
                           ,@writes = @pwrites
                           ,@cpu = @pcpu
                           ,@spid = @pspid";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static DataTable GetSpidInfo(Credentials cred, string database, int spid)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new DynamicParameters();

            param.Add("@pspid", spid, DbType.Int32, ParameterDirection.Input);

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"EXEC dbo.st_GetSessionsInfo @spid = @pspid";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
        #endregion

        #region dashboard methods
        public static DataTable GetMemoryInfo(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"EXEC dbo.st_GetMemoryInfo";

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

            cmd = @"EXEC dbo.st_GetCPUInfo";

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
        public static DataTable GetConnectionsInfo(Credentials cred, string database)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"EXEC dbo.st_GetConStatus";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
        #endregion

        #region database methods
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
        #endregion
    }
}
