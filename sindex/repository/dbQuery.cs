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
    public class dbQuery
    {
        public static DataTable GetTopQueries(Credentials cred, string database, int top, string dbName)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new DynamicParameters();
            param.Add("@pTop", top, DbType.Int32, ParameterDirection.Input);
            param.Add("@pdb_name", dbName, DbType.String, ParameterDirection.Input);

            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            cmd = @"EXEC dbo.st_GetTopQueries @Top = @pTop, @db_name = @pdb_name";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
    }
}
