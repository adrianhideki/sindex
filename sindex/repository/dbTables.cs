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

            db.executeQuery("EXEC dbo.st_GetIndexes", param, database, out errMsg, out returnCode);

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
        public static DataTable SetDatabaseEnabled(Credentials cred, string database,  bool enabled)
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
