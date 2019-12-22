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
    public partial class Vendor_Details : Form
    {
        public Vendor_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        private void Vendor_Details_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Prod", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbvendormachinid.Items.Add(reader[0].ToString());
                reader.Close();
                conn.Close();
            }
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Vendor", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbvendorid.Items.Add(reader[0].ToString());
                reader.Close();
                conn.Close();
            }
        }

        private void cmbvendormachinid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Prod where M_Id=" + cmbvendormachinid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    txtqty.Text = reader[2].ToString();
                                    }
                reader.Close();
                conn.Close();
            }
        }

        private void butnvendorDexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnvendorDreset_Click(object sender, EventArgs e)
        {
            cmbvendorid.Text = "Select";
            txtvname.Text = "";
            txtmob.Text = "";
            txtadd.Text = "";
            cmbvendormachinid.Text = "Select";
            txtqty.Text = "";
        }

        private void butnvendorDSave_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("insert into tbl_Vendor values('" + txtvname.Text.Trim() + "','" + txtmob.Text.Trim() + "','" + txtadd.Text.Trim() + "'," + cmbvendormachinid.Text.Trim() + "," + txtqty.Text.Trim() + ")", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("All the records has been submitted successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbvendorid.Text = "Select";
            txtvname.Text = "";
            txtmob.Text = "";
            txtadd.Text = "";
            cmbvendormachinid.Text = "Select";
            txtqty.Text = "";
        }

        private void butnvendorDAdd_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select V_Id from tbl_Vendor", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    int value = Int32.Parse(reader[0].ToString()) + 1;
                    cmbvendorid.Text = "V" + String.Format("{0:0000}", value); ;
                }
                conn.Close();
            }
        }

        private void cmbvendorid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Vendor where V_Id=" + cmbvendorid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    txtvname.Text = reader[1].ToString();
                    txtmob.Text = reader[2].ToString();
                    txtadd.Text = reader[3].ToString();
                    txtqty.Text = reader[5].ToString();
                    cmbvendormachinid.Text = reader[4].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }

        private void butnvendorDupdate_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("update tbl_Vendor set V_Name='" + txtvname.Text.Trim() + "',Mob='" + txtmob.Text.Trim() + "',Address='" + txtadd.Text.Trim() + "',M_Id=" + cmbvendormachinid.Text.Trim() + ",Quantity=" + txtqty.Text.Trim() + "  Where V_Id=" + cmbvendorid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Your records has been updated successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbvendorid.Text = "Select";
            txtvname.Text = "";
            txtmob.Text = "";
            txtadd.Text = "";
            cmbvendormachinid.Text = "Select";
            txtqty.Text = "";
        }

        private void butnvendorDdelete_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("delete from tbl_Vendor where V_Id=" + cmbvendorid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Records Deleted from Database...");
                conn.Close();
            }
            cmbvendorid.Text = "Select";
            txtvname.Text = "";
            txtmob.Text = "";
            txtadd.Text = "";
            cmbvendormachinid.Text = "Select";
            txtqty.Text = "";
        }
    }
}
