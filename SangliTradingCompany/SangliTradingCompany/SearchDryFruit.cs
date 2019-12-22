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
    public partial class SearchDryFruit : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public SearchDryFruit()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void SearchDryFruit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.DryFruitTable' table. You can move, or remove it, as needed.
            this.dryFruitTableTableAdapter.Fill(this.database1DataSet.DryFruitTable);

            con.Open();
            proname1_combo.Text = "";
           
            string query = "select ProductName from DryFruitTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);
          proname1_combo.DataSource = ds.Tables[0];
           proname1_combo.DisplayMember = "ProductName";
            

            SqlCommand cmd = new SqlCommand("Select * from DryFruitTable", con);
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

        private void proname_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from  DryFruitTable where ProductName='" + proname1_combo.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DataRow[] datadr = ds.Tables[0].Select("[ProductName]='+proname1_combo.Text+'");

            con.Close();
        }

        

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from DryFruitTable", con);
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
