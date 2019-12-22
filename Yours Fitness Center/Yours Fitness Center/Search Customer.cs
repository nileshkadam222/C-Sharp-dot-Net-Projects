using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Yours_Fitness_Center
{
    public partial class Search_Customer : Form
    {
        public Search_Customer()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataAdapter reader;
        SqlDataReader reader1;
        ConnectionState state = new ConnectionState();
        DataSet ds = new DataSet(); 
        private void labsearchstud_Click(object sender, EventArgs e)
        {

        }

        private void Search_Customer_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Cust", conn);
                reader1 = query.ExecuteReader();
                while (reader1.Read())
                    comboBox1.Items.Add(reader1[0].ToString());
                reader1.Close();
                conn.Close();
            }
        }

        private void butnSearchstaffOK_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Cust where S_Id=" + comboBox1.Text.Trim() + "", conn);
                reader = new SqlDataAdapter(query);
                reader.Fill(ds, "tbl_Cust");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tbl_Cust";
            }
        }

        private void butnSearchstaffexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
