using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace shubhafinal
{
    public class DBConnection
    {
        SqlConnection connection;
        public SqlConnection GetConnectionInfo()
        {
            string connectionStr = ConfigurationSettings.AppSettings["ConnectionInfo"];
            connection = new SqlConnection(connectionStr);
            return connection;
        }

        public void ConnectionClose()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Dispose();
            }
        }
    }
}
