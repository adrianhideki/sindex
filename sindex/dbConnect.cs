using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace sindex
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

        public string getConnectionString(string dbName)
        {
            return String.Format("Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3};", this.server, dbName, this.user, this.pass);
        }

        public dynamic executeQuery(string query, DynamicParameters parameters, string dbName)
        {
            using (SqlConnection connection = new SqlConnection(this.getConnectionString(dbName)))
            {
                var result = connection.Query(query, parameters);
                return result;
            }
        }
        public int executeCommand(string query, DynamicParameters parameters, string dbName)
        {
            using (SqlConnection connection = new SqlConnection(this.getConnectionString(dbName)))
            {
                var result = connection.Execute(query, parameters);
                return result;
            }
        }

    }
}
