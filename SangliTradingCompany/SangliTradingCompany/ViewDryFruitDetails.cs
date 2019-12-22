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
    public partial class ViewDryFruitDetails : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public ViewDryFruitDetails()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void ViewDryFruitDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.DryFruitTable' table. You can move, or remove it, as needed.
          //  this.dryFruitTableTableAdapter.Fill(this.database1DataSet.DryFruitTable);

        }

        private void view_btn_Click(object sender, EventArgs e)
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
