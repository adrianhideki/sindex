using Dapper;
using sindex.model;
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
        public static void LoadServer(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetServers", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadDatabases(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetDatabases", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadFilegroups(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetFileGroups", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadFiles(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetFiles", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadTables(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetTables", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadConstraints(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetConstraints", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadStats(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetStats", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }
        public static void LoadIndexes(Credentials cred)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            db.executeQuery("EXEC dbo.st_GetIndexes", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }
        }

        public static DataTable GetDatabases(Credentials cred)
        {

            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new Dapper.DynamicParameters();
            string errMsg = "";
            int returnCode = 0;

            DataTable res = db.executeDataTable("select * from dbo.[database]", param, "sindex", out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
    }
}
