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
    public partial class Staff_Details : Form
    {
        public Staff_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        private void butnstaffDexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnstaffDreset_Click(object sender, EventArgs e)
        {
            cmbsid.Text = "Select Id";
            textBstaffname.Text = "";
            comboBstaffgender.Text="Select Gender";
            textBstaffadd.Text = "";
            comboBQualification.Text = "Select";
            comboBExperience.Text = "Select";
            txtsal.Text = "";
        }

        private void butnstaffDAdd_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select S_Id from tbl_Staff", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    int value = Int32.Parse(reader[0].ToString()) + 1;
                    cmbsid.Text = "E" + String.Format("{0:0000}", value); ;
                }
                conn.Close();
            }
        }

        private void butnstaffDSave_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("insert into tbl_Staff values('" + textBstaffname.Text.Trim() + "','" + comboBstaffgender.Text.Trim() + "','" + textBstaffadd.Text.Trim() + "','" + comboBQualification.Text.Trim() + "','" + comboBExperience.Text.Trim() + "',"+txtsal.Text.Trim()+")", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("All the records has been submitted successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbsid.Text = "Select Id";
            textBstaffname.Text = "";
            comboBstaffgender.Text = "Select Gender";
            textBstaffadd.Text = "";
            comboBQualification.Text = "Select";
            comboBExperience.Text = "Select";
            txtsal.Text = "";
        }

        private void Staff_Details_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Staff", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbsid.Items.Add(reader[0].ToString());
                reader.Close();
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
                query = new SqlCommand("Select * from tbl_Staff where S_Id=" + cmbsid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    textBstaffname.Text = reader[1].ToString();
                    comboBstaffgender.Text = reader[2].ToString();
                    textBstaffadd.Text = reader[3].ToString();
                    comboBQualification.Text = reader[4].ToString();
                    comboBExperience.Text = reader[5].ToString();
                    txtsal.Text = reader[6].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }

        private void butnstaffDupdate_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("update tbl_Staff set S_Name='" + textBstaffname.Text.Trim() + "',Gender='" + comboBstaffgender.Text.Trim() + "',Address='" + textBstaffadd.Text.Trim() + "',Qualification='" + comboBQualification.Text.Trim() + "',Experience='" + comboBExperience.Text.Trim() + "',Salary="+txtsal.Text.Trim()+" Where S_Id=" + cmbsid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Your records has been updated successfully into the database...");
                reader.Close();
                conn.Close();
            }
            cmbsid.Text = "Select Id";
            textBstaffname.Text = "";
            comboBstaffgender.Text = "Select Gender";
            textBstaffadd.Text = "";
            comboBQualification.Text = "Select";
            comboBExperience.Text = "Select";
            txtsal.Text = "";
        }

        private void butnstaffDdelete_Click(object sender, EventArgs e)
        {
              if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("delete from tbl_Course where C_Id=" + cmbsid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("Records Deleted from Database...");
                conn.Close();
            }
            cmbsid.Text = "Select Id";
            textBstaffname.Text = "";
            comboBstaffgender.Text = "Select Gender";
            textBstaffadd.Text = "";
            comboBQualification.Text = "Select";
            comboBExperience.Text = "Select";
            txtsal.Text = "";
        }
    }
}
