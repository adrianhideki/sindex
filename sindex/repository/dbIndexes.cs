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
    public static class dbIndexes
    {
        public static DataTable GetMissingIndexes(Credentials cred, string database, string dbName = "", string tbName = "")
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new DynamicParameters();
            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            param.Add("@p_table", tbName, DbType.String, ParameterDirection.Input);
            param.Add("@p_database", dbName, DbType.String, ParameterDirection.Input);

            cmd = @"EXEC dbo.st_GetMissingIndexes @table = @p_table, @database = @p_database";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static void CreateIndex(Credentials cred, string database, string cmd)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new DynamicParameters();

            string errMsg = "";
            int returnCode = 0;

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0) throw new Exception(errMsg);
        }
    }
}
