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
    public partial class Machin_Details : Form
    {
        public Machin_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        private void Machin_Details_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Prod", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbMachinid.Items.Add(reader[0].ToString());
                reader.Close();
                conn.Close();
            }
        }

        private void butnproDexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnproDreset_Click(object sender, EventArgs e)
        {
            cmbMachinid.Text = "Select Id";
            txtmname.Text = "";
            txtqty.Text = "";
            dateTimePicker1.Text = System.DateTime.Now.ToShortDateString();
            txtprice.Text = "";
        }

        private void butnproDAdd_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select M_Id from tbl_Prod", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    int value = Int32.Parse(reader[0].ToString()) + 1;
                    cmbMachinid.Text = "M" + String.Format("{0:0000}", value); ;
                }
                conn.Close();
            }
        }

        private void butnproDSave_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("insert into tbl_Prod values('" + txtmname.Text.Trim() + "'," + txtqty.Text.Trim() + ",'" + dateTimePicker1.Text.Trim() + "'," + txtprice.Text.Trim() + ")", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("All the records has been submitted successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbMachinid.Text = "Select Id";
            txtmname.Text = "";
            txtqty.Text = "";
            dateTimePicker1.Text = System.DateTime.Now.ToShortDateString();
            txtprice.Text = "";
        }

        private void cmbMachinid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Prod where M_Id=" + cmbMachinid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    txtmname.Text = reader[1].ToString();
                    txtqty.Text = reader[2].ToString();
                    dateTimePicker1.Text = reader[3].ToString();
                    txtprice.Text = reader[4].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }

        private void butnproDupdate_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("update tbl_Prod set M_Name='" + txtmname.Text.Trim() + "',Quantity=" + txtqty.Text.Trim() + ",Date='" + dateTimePicker1.Text.Trim() + "',Price=" +txtprice.Text.Trim() +"  Where M_Id=" + cmbMachinid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Your records has been updated successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbMachinid.Text = "Select Id";
            txtmname.Text = "";
            txtqty.Text = "";
            dateTimePicker1.Text = System.DateTime.Now.ToShortDateString();
            txtprice.Text = "";
        }

        private void butnproDdelete_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("delete from tbl_Prod where M_Id=" + cmbMachinid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Records Deleted from Database...");
                conn.Close();
            }
            cmbMachinid.Text = "Select Id";
            txtmname.Text = "";
            txtqty.Text = "";
            dateTimePicker1.Text = System.DateTime.Now.ToShortDateString();
            txtprice.Text = "";
        }
    }
}
