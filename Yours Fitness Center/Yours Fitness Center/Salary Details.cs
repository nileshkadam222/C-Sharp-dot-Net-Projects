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
    public partial class Salary_Details : Form
    {
        public Salary_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataAdapter reader;
        SqlDataReader reader1;
        ConnectionState state = new ConnectionState();
        DataSet ds = new DataSet();
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Details_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Staff", conn);
                reader1 = query.ExecuteReader();
                while (reader1.Read())
                {
                    cmbsalaryDstafid.Items.Add(reader1[0].ToString());
                    
                }
                reader1.Close();
                conn.Close();
              }
            
        }


        private void butnSalaryDshowRep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            txtBsalaryDtotworkDays.Text = DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month).ToString();
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Staff where S_Id=" + cmbsalaryDstafid.Text.Trim() + "", conn);
                reader1 = query.ExecuteReader();
                while (reader1.Read())
                    txtBsalaryDsalary.Text = reader1[6].ToString();
            }
            DateTimePicker ob = new DateTimePicker();
            String Month = dateTimePicker1.Value.Month.ToString();
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("Select * from tbl_Att where S_Id=" + cmbsalaryDstafid.Text.Trim() + "", conn);
                reader1 = query.ExecuteReader();
                while (reader1.Read())
                    ob.Text = reader1[1].ToString();
                String Mont = ob.Value.Month.ToString();
                reader1.Close();
                if (Month.Equals(Mont))
                {
                    query = new SqlCommand("Select * from tbl_Att where S_Id=" + cmbsalaryDstafid.Text.Trim() + "", conn);
                    reader1 = query.ExecuteReader();
                    while (reader1.Read())
                    txtBsalaryDtotAtten.Text = reader1[3].ToString();
                }
                else
                {
                    MessageBox.Show("Please Update Attendance First....");
                    this.Close();
                }
                conn.Close();
                double Days=0.0, Sal, Res;
                Days = Double.Parse(txtBsalaryDtotAtten.Text);
                Sal = Double.Parse(txtBsalaryDsalary.Text);
                Res = (Days * Sal) / 30;
                txtBsalaryDdatOfPaym.Text = Res.ToString();
            }
        }

        private void butnsalaryDSave_Click(object sender, EventArgs e)
        {
            DateTimePicker ob = new DateTimePicker();
            String Month = dateTimePicker1.Value.Month.ToString();
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("Select * from tbl_Sal where S_Id=" + cmbsalaryDstafid.Text.Trim() + "", conn);
                reader1 = query.ExecuteReader();
                while (reader1.Read())
                    ob.Text = reader1[4].ToString();
                String Mont = ob.Value.Month.ToString();
                conn.Close();
                if (Month.Equals(Mont))
                {
                    MessageBox.Show("Your Salary for this month already credited...");
                    this.Close();
                }

                else
                {
                     if (state == ConnectionState.Open)
                        conn.Close();
                    else
                    {
                        conn.Close();
                        conn.Open();
                        query = new SqlCommand("insert into tbl_Sal values(" + cmbsalaryDstafid.Text.Trim() + ",'" + txtBsalaryDsalary.Text.Trim() + "','" + txtBsalaryDdatOfPaym.Text.Trim() + "'," + txtBsalaryDtotAtten.Text.Trim() + ",'"+dateTimePicker1.Text.Trim()+"')", conn);
                        reader1 = query.ExecuteReader();
                        MessageBox.Show("All the records has been submitted successfully into the database...");
                        reader1.Close();
                        conn.Close();
                    }
                }
            } conn.Close();

        }
    }
}
