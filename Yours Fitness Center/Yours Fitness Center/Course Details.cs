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
    public partial class Course_Details : Form
    {
        public Course_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        private void Course_Details_Load(object sender, EventArgs e)
        {
           
        }

        private void labCourseDetail_Click(object sender, EventArgs e)
        {

        }

        private void labcourseno_Click(object sender, EventArgs e)
        {

        }

        private void labcourcename_Click(object sender, EventArgs e)
        {

        }

        private void labcourseDuration_Click(object sender, EventArgs e)
        {

        }

        private void labcoursedtotalfees_Click(object sender, EventArgs e)
        {

        }

        private void labcoursefinstallment_Click(object sender, EventArgs e)
        {

        }

        private void butncourseDexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butncourseDreset_Click(object sender, EventArgs e)
        {
            cmbcoursetype.Text = "Select Gender";
            cmbcid.Text = "Select Id";
            txtctype.Text = "";
            txtcd.Text = "";
            txtfees.Text = "";
            cmbcoursDnoOfInstalment.Text = "Select";
        }

        private void butncourseDSave_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("insert into tbl_Course values('" + cmbcoursetype.Text.Trim() + "','" + txtctype.Text.Trim() + "','" + txtcd.Text.Trim() + "'," + txtfees.Text.Trim() + "," + cmbcoursDnoOfInstalment.Text.Trim() + ")", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("All the records has been submitted successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbcoursetype.Text = "Select Gender";
            cmbcid.Text = "Select Id";
            txtctype.Text = "";
            txtcd.Text = "";
            txtfees.Text = "";
            cmbcoursDnoOfInstalment.Text = "Select";
        }

        private void cmbcoursetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Course where Course_Type='" + cmbcoursetype.Text.Trim() + "'", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbcid.Items.Add(reader[1].ToString());
                reader.Close();
                conn.Close();
            }      
            
        }

        private void butncourseDdelete_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("delete from tbl_Course where C_Id=" + cmbcid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Records Deleted from Database...");
                conn.Close();
            }
            cmbcoursetype.Text = "Select Gender";
            cmbcid.Text = "Select Id";
            txtctype.Text = "";
            txtcd.Text = "";
            txtfees.Text = "";
            cmbcoursDnoOfInstalment.Text = "Select";
        }

        private void butncourseDupdate_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("update tbl_Course set Course_Name='" + txtctype.Text.Trim() + "',Course_Duration='" + txtcd.Text.Trim() + "',Fees=" + txtfees.Text.Trim() + ",Install=" + cmbcoursDnoOfInstalment.Text.Trim() + " Where C_Id=" + cmbcid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Your records has been updated successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbcoursetype.Text = "Select Gender";
            cmbcid.Text = "Select Id";
            txtctype.Text = "";
            txtcd.Text = "";
            txtfees.Text = "";
            cmbcoursDnoOfInstalment.Text = "Select";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtctype.Text = "";
            txtcd.Text = "";
            txtfees.Text = "";
            cmbcoursDnoOfInstalment.Text = "Select";
        }

        private void cmbcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Course where C_Id=" + cmbcid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    txtctype.Text = reader[2].ToString();
                    txtcd.Text = reader[3].ToString();
                    txtfees.Text = reader[4].ToString();
                    cmbcoursDnoOfInstalment.Text = reader[5].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }
    }
}
