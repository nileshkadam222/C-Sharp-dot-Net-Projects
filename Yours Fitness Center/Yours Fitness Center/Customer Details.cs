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
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        private void Customer_Details_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Cust", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbsid.Items.Add(reader[0].ToString());
                reader.Close();
                conn.Close();
            }
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Course", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbcourseEn.Items.Add(reader[1].ToString());
                reader.Close();
                conn.Close();
            }
        }

        private void butnstudDexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnstudDreset_Click(object sender, EventArgs e)
        {
            cmbsid.Text = "Select";
            txtBstudname.Text = "";
            txtBstudadd.Text = "";
            cmbgender.Text = "Select";
            cmbcourseEn.Text="Select";
            cmbBatch.Text = "Select";
        }

        private void butnstudDSave_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("insert into tbl_Cust values('" + txtBstudname.Text.Trim() + "','" + txtBstudadd.Text.Trim() + "','" + cmbgender.Text.Trim() + "'," + cmbcourseEn.Text.Trim() + ",'"+cmbBatch.Text.Trim()+"')", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("All the records has been submitted successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbsid.Text = "Select";
            txtBstudname.Text = "";
            txtBstudadd.Text = "";
            cmbgender.Text = "Select";
            cmbcourseEn.Text = "Select";
            cmbBatch.Text = "Select";
        }

        private void butnstudDAdd_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select S_Id from tbl_Cust", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    int value = Int32.Parse(reader[0].ToString()) + 1;
                    cmbsid.Text = "S" + String.Format("{0:0000}", value); ;
                }
                conn.Close();
            }
        }

        private void cmbsid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Cust where S_Id=" + cmbsid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    txtBstudname.Text = reader[1].ToString();
                    txtBstudadd.Text = reader[2].ToString();
                    cmbgender.Text = reader[3].ToString();
                    cmbcourseEn.Text = reader[4].ToString();
                    cmbBatch.Text = reader[5].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }

        private void butnstudDupdate_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("update tbl_Cust set S_Name='" + txtBstudname.Text.Trim() + "',Address='" + txtBstudadd.Text.Trim() + "',Gender='" + cmbgender.Text.Trim() + "',C_Enroll=" +cmbcourseEn.Text.Trim() + ",Batch='"+cmbBatch.Text.Trim()+"'  Where S_Id=" + cmbsid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Your records has been updated successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbsid.Text = "Select";
            txtBstudname.Text = "";
            txtBstudadd.Text = "";
            cmbgender.Text = "Select";
            cmbcourseEn.Text = "Select";
            cmbBatch.Text = "Select";
        }

        private void butnstudDdelete_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("delete from tbl_Cust where S_Id=" + cmbsid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Records Deleted from Database...");
                conn.Close();
            }
            cmbsid.Text = "Select";
            txtBstudname.Text = "";
            txtBstudadd.Text = "";
            cmbgender.Text = "Select";
            cmbcourseEn.Text = "Select";
            cmbBatch.Text = "Select";
        }
    }
}
