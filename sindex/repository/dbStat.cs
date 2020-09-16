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
    public static class dbStat
    {
        public static void ExecuteScript(Credentials cred, string database, string cmd)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new DynamicParameters();

            string errMsg = "";
            int returnCode = 0;

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0) throw new Exception(errMsg);
        }

        public static DataTable GetUpdateStatistics(Credentials cred, string database, bool fullScan = true, bool sample = false, bool resample = false, int percent = 0, int rows = 0, string dbName = "", string objName = "", string stat = "", int days = 0)
        {
            dbConnect db = new dbConnect(cred);
            DynamicParameters param = new DynamicParameters();
            string errMsg = "";
            string cmd = "";
            int returnCode = 0;

            param.Add("@p_fullscan", fullScan, DbType.Boolean, ParameterDirection.Input);
            param.Add("@p_sample", sample, DbType.Boolean, ParameterDirection.Input);
            param.Add("@p_resample", resample, DbType.Boolean, ParameterDirection.Input);
            param.Add("@p_percent", percent, DbType.Int32, ParameterDirection.Input);
            param.Add("@p_rows", rows, DbType.Int32, ParameterDirection.Input);
            param.Add("@p_database", dbName, DbType.String, ParameterDirection.Input);
            param.Add("@p_object", objName, DbType.String, ParameterDirection.Input);
            param.Add("@p_stat", stat, DbType.String, ParameterDirection.Input);
            param.Add("@p_minDays", days, DbType.Int32, ParameterDirection.Input);

            cmd = @"EXEC dbo.st_GetUpdateStatistics @fullscan = @p_fullscan, @sample = @p_sample, @resample = @p_resample, @percent = @p_percent, @rows = @p_rows, @database = @p_database, @object = @p_object, @stat = @p_stat, @minDays = @p_minDays";

            DataTable res = db.executeDataTable(cmd, param, database, out errMsg, out returnCode);

            if (returnCode != 0)
            {
                throw new Exception(errMsg);
            }

            return res;
        }
    }
}
