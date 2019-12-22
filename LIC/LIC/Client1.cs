using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIC
{
    public partial class Client1 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;

        public Client1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (relatntxt.Text == "")
                {
                    errorProvider1.SetError(relatntxt, "Please fill proper value");
                }
                else
                {
                    errorProvider1.Clear();
                }

                if (cidtxt.Text == "" || cnametxt.Text == "" || caddresstxt.Text == "" || cgencmbx.Text == "" || cdob.Text == "" || cagetxt.Text == "" || coccptxt.Text == "" || txt_income.Text == "" || nnametxt.Text == "" || ngencmb.Text == "" || ndob.Text == "" || nagetxt.Text == "" || relatntxt.Text == "")
                {
                    MessageBox.Show("Please enter required fields");
                    errorProvider1.Clear();
                }
                else
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into C_PersonalDetails(Cust_id,C_Name,Address,C_Gender,C_Age,C_Dob,C_Occp,N_Name,C_Income,N_Gender,N_Age,N_Dob,N_Relationship) Values('" + cidtxt.Text + "','" + cnametxt.Text + "','" + caddresstxt.Text + "','" + cgencmbx.Text + "','" + cagetxt.Text + "','" + cdob.Text + "','" + coccptxt.Text + "','" + nnametxt.Text + "','" + txt_income.Text + "','" + ngencmb.Text + "','" + nagetxt.Text + "','" + ndob.Text + "','" + relatntxt.Text + "')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Completed. Enter Policy Details!!!");
                    Client2 c = new Client2();
                    c.Show();
                    this.Hide();
                    con.Close();
                    c.cidtxt.Text = cidtxt.Text;
                    c.cbo_polno.Focus();
                }
            }
            catch (Exception) { }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void openConnection()
        {
            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cnametxt.Text == "")
            {
                errorProvider1.SetError(cnametxt, "Please enter proposer's name");
            }
            else
            {
                errorProvider1.Clear();
            }
            }

        private void Client1_Load(object sender, EventArgs e)
        {
            openConnection();
            int max;
            string str = "select * from C_PersonalDetails";
            cmd = new OleDbCommand(str, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            max = ds.Tables[0].Rows.Count;
            cidtxt.Text = (max + 1).ToString();
            cidtxt.Enabled = false;
            ndob.MaxDate = DateTime.Now;
            cdob.MaxDate = DateTime.Now;
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            int age = DateTime.Today.Year - ndob.Value.Year;
            nagetxt.Text = age.ToString();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

       
            
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void occp_TextChanged(object sender, EventArgs e)
        {
            if (cnametxt.Text == "")
            {
                errorProvider1.SetError(cnametxt, "Please enter proposers name");

            }
            else
            {
                errorProvider1.Clear();
            }
            if (caddresstxt.Text == "")
            {
                errorProvider1.SetError(caddresstxt, "Please enter proposers address");

                return;
            }
            errorProvider1.Clear();
            //cdob.MaxDate = DateTime.Now;
          
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ngencmb.Text == "")
            {

                errorProvider1.SetError(ngencmb, "Please select the gender of nominee");
            }
            else
            {
                errorProvider1.Clear();
            }
            int age = DateTime.Today.Year - ndob.Value.Year;
            nagetxt.Text = age.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nnametxt.Text == "")
            {
                errorProvider1.SetError(nnametxt, "Please fill Nominee name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        
        

        private void nagetxt_TextChanged(object sender, EventArgs e)
        {
            if (ngencmb.Text == "")
            {

                errorProvider1.SetError(ngencmb, "Please select the gender of nominee");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void relatntxt_TextChanged(object sender, EventArgs e)
        {
            if (nagetxt.Text == "")
            {
                
                errorProvider1.SetError(nagetxt, "Select DOB from The Given Calendar");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cagetxt_TextChanged(object sender, EventArgs e)
        {

            if (cgencmbx.Text == "")
            {

                errorProvider1.SetError(cgencmbx, "Please select gender of proposer");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void txt_income_TextChanged(object sender, EventArgs e)
        {
            if(coccptxt.Text== "")
            {

                errorProvider1.SetError(coccptxt, "Please enter occupation of proposer");
            }
            else
           {
                errorProvider1.Clear();
            }

            try
            {
                long income = Convert.ToInt64(txt_income.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("PLEASE ENTER THE NUMERIC VALUE FOR ANNUAL INCOME");
                txt_income.SelectAll();
 
            }
        
        }

        private void cnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Invalid Input");
                e.Handled = true;
            }
        }

        private void nnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Numeric not allowed for Nominee name");
                e.Handled = true;
            }
        }

   

        private void coccptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Invalid Input");
                e.Handled = true;
            }
        }

        private void relatntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Invalid Input");
                e.Handled = true;
            }
        }

        private void nnametxt_TextChanged(object sender, EventArgs e)
        {
            if (txt_income.Text == "")
            {

                errorProvider1.SetError(txt_income, "Please enter income of proposer");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cgencmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cnametxt.Text == "")
            {
                errorProvider1.SetError(cnametxt, "Please enter proposers name");

            }
            else
            {
                errorProvider1.Clear();
            }
            if (caddresstxt.Text == "")
            {
                errorProvider1.SetError(caddresstxt, "Please enter proposers address");

                return;
            }
            errorProvider1.Clear();
        

        }

        private void cdob_ValueChanged(object sender, EventArgs e)
        {
            
           
            if(cgencmbx.Text == "")
            {

                errorProvider1.SetError(cgencmbx, "Please select gender of proposer");
            }
            else
            {
                errorProvider1.Clear();
            }
         int age = DateTime.Today.Year - cdob.Value.Year;
         cagetxt.Text = age.ToString();
        

        }

         }
}

     
       

   
