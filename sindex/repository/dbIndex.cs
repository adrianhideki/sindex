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
    public static class dbIndex
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
        public static DataTable GetFragmentedIndexes(Credentials cred, string database, string dbName = "", string tbName = "", string tpName = "", double fragmentation = 0, bool tableWithData = false)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new DynamicParameters();
            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            param.Add("@p_table", tbName, DbType.String, ParameterDirection.Input);
            param.Add("@p_database", dbName, DbType.String, ParameterDirection.Input);
            param.Add("@p_type", tpName, DbType.String, ParameterDirection.Input);
            param.Add("@p_fragmentation", fragmentation, DbType.Decimal, ParameterDirection.Input);
            param.Add("@p_tablesWithData", tableWithData, DbType.Boolean, ParameterDirection.Input);

            cmd = @"EXEC dbo.st_GetFragmentedIndexes @table = @p_table, @database = @p_database, @type = @p_type, @fragmentation = @p_fragmentation, @tablesWithData = @p_tablesWithData";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }

        public static void ExecuteScript(Credentials cred, string database, string cmd)
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
