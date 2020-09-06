using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using sindex.model;
using Newtonsoft.Json;

namespace sindex.utils
{
    public class dbConnect
    {
        private string user { get; set; }
        private string pass { get; set; }
        private string server { get; set; }

        public dbConnect(string user, string pass, string server)
        {
            this.user = user;
            this.pass = pass;
            this.server = server;
        }
        public dbConnect(Credentials cred)
        {
            this.user = cred.user;
            this.pass = cred.password;
            this.server = cred.server;
        }

        public string getConnectionString(string dbName)
        {
            return String.Format("Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3};", this.server, dbName, this.user, this.pass);
        }

        public dynamic executeQuery(string query, DynamicParameters parameters, string dbName, out string errMsg, out int errCode)
        {
            errMsg = "";
            errCode = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(this.getConnectionString(dbName)))
                {
                    var result = connection.Query(query, parameters);
                    return result;
                }
            } catch (Exception err)
            {
                errCode = 1;
                errMsg = err.Message;
                return null;
            }
        }

        public int executeCommand(string query, DynamicParameters parameters, string dbName, out string errMsg, out int errCode)
        {
            errMsg = "";
            errCode = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.getConnectionString(dbName)))
                {
                    var result = connection.Execute(query, parameters);
                    return result;
                }
            } catch (Exception err)
            {
                errCode = 1;
                errMsg = err.Message;
                return 0;
            }
        }
        public DataTable executeDataTable(string query, DynamicParameters parameters, string dbName, out string errMsg, out int errCode)
        {
            errMsg = "";
            errCode = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(this.getConnectionString(dbName)))
                {

                    var result = connection.Query(query, parameters);

                    var json = JsonConvert.SerializeObject(result);
                    DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                    return dataTable;
                }
            }
            catch (Exception err)
            {
                errCode = 1;
                errMsg = err.Message;
                return null;
            }
        }

        public T executeScalar<T>(string query, DynamicParameters parameters, string dbName, out string errMsg, out int errCode)
        {
            errMsg = "";
            errCode = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(this.getConnectionString(dbName)))
                {

                    var result = connection.ExecuteScalar<T>(query, parameters);
                    return result;
                }
            }
            catch (Exception err)
            {
                errCode = 1;
                errMsg = err.Message;

                return default(T);
            }
        }

    }
}
