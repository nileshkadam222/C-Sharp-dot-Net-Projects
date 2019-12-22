using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient ;
using System.Data;

namespace GymManagementCSharp
{
    public class DataConnection
    {
         public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        public SqlConnection conn = new SqlConnection();
        public SqlDataAdapter adapter;
        public int bn;
        public String name1;
        public DataConnection()
        {
            string connstr = "Data Source=localhost;Initial Catalog=Gym Management;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        }
    }
}