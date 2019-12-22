using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SangliTradingCompany
{
    public partial class SearchSpices : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public SearchSpices()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void SearchSpices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.SpicesTable' table. You can move, or remove it, as needed.
            this.spicesTableTableAdapter.Fill(this.database1DataSet.SpicesTable);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from SpicesTable", con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.SelectCommand = cmd;
            DataTable datatb = new DataTable();
            adpt.Fill(datatb);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatb;
            dataGridView1.DataSource = bind;
            adpt.Update(datatb);
            con.Close();

        }

       

        private void Search_btn_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from  SpicesTable where ProductName='" + proname_combo.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DataRow[] datadr = ds.Tables[0].Select("[ProductName]='+proname_combo.Text+'");
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("data not found");
            }
            con.Close();

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from SpicesTable", con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.SelectCommand = cmd;
            DataTable datatb = new DataTable();
            adpt.Fill(datatb);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatb;
            dataGridView1.DataSource = bind;
            adpt.Update(datatb);
            con.Close();

        }
    }
}
