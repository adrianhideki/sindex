using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

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

        public SqlDataReader executeDataReader(string query, List<SqlParameter> parameters) {
            using (SqlConnection connection = new SqlConnection(this.getConnectionString("master")))
            {
                SqlCommand command = new SqlCommand(query, connection);

                foreach(SqlParameter p in parameters)
                {
                    command.Parameters.Add(p);
                }
                
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
        }

        public DataSet executeDataSet(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection connection = new SqlConnection(this.getConnectionString("master")))
            {
                var dataAdapter = new SqlDataAdapter(query, connection);


                foreach (SqlParameter p in parameters)
                {
                    dataAdapter.SelectCommand.Parameters.Add(p);
                }

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();

                dataAdapter.Fill(ds);
                return ds;
            }
        }

        public void executeNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(this.getConnectionString("master")))
            {
                SqlCommand command = new SqlCommand("SELECT @@SPID as spid", connection);
                command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}
