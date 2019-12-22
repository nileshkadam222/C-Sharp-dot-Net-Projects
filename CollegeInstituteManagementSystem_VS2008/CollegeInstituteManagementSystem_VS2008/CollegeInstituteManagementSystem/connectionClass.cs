using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CollegeInstituteManagementSystem
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

                con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\VRUSHALI\\6th sem\\Project\\Proj with coding\\CollegeInstituteManagementSystem_VS2008\\Database\\2005\\CollegeInstituteManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
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
