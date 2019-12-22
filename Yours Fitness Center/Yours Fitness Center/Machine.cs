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
    public partial class Machine : Form
    {
        public Machine()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataAdapter reader;
        SqlDataReader reader1;
        ConnectionState state = new ConnectionState();
        DataSet ds = new DataSet();
        private void Machine_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Prod", conn);
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
                query = new SqlCommand("Select * from tbl_Prod where M_Id=" + comboBox1.Text.Trim() + "", conn);
                reader = new SqlDataAdapter(query);
                reader.Fill(ds, "tbl_Prod");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tbl_Prod";
            }
        }

        private void butnSearchstaffexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
