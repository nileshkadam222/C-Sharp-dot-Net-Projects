using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeProfileManagement
{
    class connectionClass
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand com = new SqlCommand();
        public SqlDataReader dr;

        public void connect()
        {
            try
            {

                con.ConnectionString = "Data Source=.;Initial Catalog=EPM;Integrated Security=True";
                con.Open();
                com.Connection = con;
                com.CommandType = CommandType.Text;
            }
            catch
            {

            }


        }



    }
}
