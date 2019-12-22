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
    public partial class Search_Staff : Form
    {
        public Search_Staff()
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

        private void panlsearchstudid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2serchstud_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Staff_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Staff", conn);
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
                query = new SqlCommand("Select * from tbl_Staff where S_Id=" + comboBox1.Text.Trim() + "", conn);
                reader = new SqlDataAdapter(query);
                reader.Fill(ds, "tbl_Staff");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tbl_Staff";
            }
        }

        private void butnSearchstaffexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
