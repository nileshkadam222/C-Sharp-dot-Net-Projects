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
    public partial class Client2 : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr;
        OleDbCommand cmd;
      //  DataSet ds;
        OleDbConnection con;
    
    public Client2()
        {
            InitializeComponent();
        }

    private void button1_Click(object sender, EventArgs e)
        {
            Client1 c = new Client1();
            c.Show();
            this.Hide();
        }

    private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    private void button2_Click(object sender, EventArgs e)
        {
            if (cbo_polno.Text == "" || termtxt.Text == "" || sumtxt.Text == "" || cbo_termpay.Text == "" || premiumtxt.Text == "" || cbo_termpay.Text == "")
            {
                MessageBox.Show("Please enter all fields");
             }
            else
            {
            openConnection();
            cmd.CommandText = "insert into C_PolicyDetails(Cust_id,Policy_No,Policy_Name,P_DtofComm,P_Term,P_SumAssured,TermWise_Payment,P_Premium,P_ModeofPayment,Total_Installment,P_RiskDt,P_DtofMaturity) Values('" + cidtxt.Text + "','" + polnotxt.Text + "','" + cbo_polno.Text + "','" + dtofcomm.Text + "','" + termtxt.Text + "','" + sumtxt.Text + "','" + cbo_termpay.Text + "','" + premiumtxt.Text + "','" + cbo_mode.Text + "','"+txt_totinstal.Text+"','"+dtp_riskdt.Text+"','" + dtofmaturity.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Completed.");
            clear();
            errorProvider1.Clear();
            transaction1 t = new transaction1();
            t.cbo_polno.Items.Add(polnotxt.Text);      
            }
            
    }
    public void clear()
    {

        cidtxt.Text = "";
        polnotxt.Text = "";
        cbo_polno.Text = "";
        termtxt.Text = "";
        sumtxt.Text = "";
        cbo_termpay.Text = "";
        premiumtxt.Text = "";
        cbo_mode.Text = "";
        txt_totinstal.Text = "";
        
        
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
        String str = cbo_polno.Text;
        if (str == "Jeevan Anand[149]")
        {
            termtxt.Text = Convert.ToString(21);
        }
        else if (str == "Jeevan Saral[165]")
        {
            termtxt.Text = Convert.ToString(25);
        }

        try
        {
            openConnection();
            String s = "Select N_Age from C_PersonalDetails where Cust_id=@s1";
            cmd = new OleDbCommand(s, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = cidtxt.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                String age1 = dr[0].ToString();
                int age = int.Parse(age1);
                String str1 = cbo_polno.Text;
                if (str1 == "Jeevan Anand[149]")
                {
                    if (age<= 35)
                    {
                        MessageBox.Show("Eligible age for Jeevan Anand is 35 Year!!!");
                        
                    }

                }
            }
        }
        catch (Exception)
        { }
    }
        public void openConnection()
        {
            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Client2_Load(object sender, EventArgs e)
        {
            openConnection();
            String max = "select max(Policy_No) from C_PolicyDetails";
            cmd = new OleDbCommand(max, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
             int max1 = int.Parse(dr[0].ToString());
             max1 = max1 + 1;
             polnotxt.Text = (max1).ToString();
             polnotxt.Enabled = false;
            }
            else
            {
             MessageBox.Show("Error");
            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (dtofcomm.Text == "")
            {
                errorProvider1.SetError(dtofcomm, "Please fill proper value");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int res = 0;
                DateTime myDate = new DateTime();
                int year = myDate.Year;
                int month = myDate.Month;
                int day = myDate.Day;
                res = int.Parse(termtxt.Text);
                myDate = DateTime.Now.AddYears(res);
                dtofmaturity.Text = myDate.ToString();
            }
            catch (FormatException)
            {

               // MessageBox.Show(e.Message);
            }
       
      }
       
        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int n = int.Parse(sumtxt.Text);
                if (n < 100000)
                {
                   // e.Cancel = true;
                    MessageBox.Show("Sum Assured should Atleast 100000");
                    sumtxt.Text = "";
                }
            }
            catch (Exception)
            {
               // MessageBox.Show(""+ex.Message);
            }
        }
        private void textBox10_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (cbo_polno.Text == "")
            {
                errorProvider1.SetError(cbo_polno, "Please fill proper value");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sumtxt.Text == "")
                {
                    errorProvider1.SetError(sumtxt, "Please fill proper value");
                }
                else
                {
                    errorProvider1.Clear();
                }
                int term = Convert.ToInt32(termtxt.Text);
                int sa = Convert.ToInt32(sumtxt.Text);
                if (cbo_termpay.Text == "Yearly")
                {
                    int premium = sa / term;
                    double prem = (premium + (0.02 * premium));
                    premiumtxt.Text = Convert.ToString(prem);
                }
                else if (cbo_termpay.Text == "Quarterly")
                {
                    int premium = sa / (term * 4);
                    double prem = (premium + (0.02 * premium));
                    premiumtxt.Text = Convert.ToString(prem);
                }
                else
                {
                    int premium = sa / (term * 12);
                    double prem = (premium + (0.02 * premium));
                    premiumtxt.Text = Convert.ToString(prem);
                }

                //------------------------------------------------------------

                if (cbo_termpay.Text == "Monthly")
                {

                    DateTime dt = DateTime.Parse(dtofcomm.Text);
                    dt = dt.AddMonths(1);
                    dtp_riskdt.Text = dt.ToString();
                }
                else if (cbo_termpay.Text == "Quarterly")
                {
                    DateTime dt = DateTime.Parse(dtofcomm.Text);
                    dt = dt.AddMonths(4);
                    dtp_riskdt.Text = dt.ToString();
                }
                else if (cbo_termpay.Text == "Yearly")
                {
                    DateTime dt = DateTime.Parse(dtofcomm.Text);
                    dt = dt.AddYears(1);
                    dtp_riskdt.Text = dt.ToString();
                }

                if (termtxt.Text == "21")
                {
                    if (cbo_termpay.Text == "Yearly")
                    {
                        txt_totinstal.Text = Convert.ToString(21 * 1);
                    }
                    else if (cbo_termpay.Text == "Quarterly")
                    {
                        txt_totinstal.Text = Convert.ToString(21 * 4);
                    }
                    else if (cbo_termpay.Text == "Monthly")
                    {
                        txt_totinstal.Text = Convert.ToString(21 * 12);
                    }
                }
                else if (termtxt.Text == "25")
                {
                    if (cbo_termpay.Text == "Yearly")
                    {
                        txt_totinstal.Text = Convert.ToString(25 * 1);
                    }
                    else if (cbo_termpay.Text == "Quarterly")
                    {
                        txt_totinstal.Text = Convert.ToString(25 * 4);
                    }
                    else if (cbo_termpay.Text == "Monthly")
                    {
                        txt_totinstal.Text = Convert.ToString(25 * 12);
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        //    if (cbo_termpay.Text == "")
        //    {
        //        errorProvider1.SetError(cbo_termpay, "Please fill proper value");
        //    }
        //    else
        //    {
        //        errorProvider1.Clear();
        //    }
        //
        }

       private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            if (premiumtxt.Text == "")
            {
                errorProvider1.SetError(premiumtxt, "Please fill proper value");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_termpay.Text == "")
            {
                errorProvider1.SetError(cbo_termpay, "Please select the term");
            }
            else
            {
                errorProvider1.Clear();
            }//if (cbo_termpay.Text == "")
            //{
            //    errorProvider1.SetError(cbo_termpay, "Please fill valid data");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}


        }

        private void sumtxt_TextChanged(object sender, EventArgs e)
        {
            if (cbo_polno.Text == "")
            {
                errorProvider1.SetError(cbo_polno, "Please select Policy/Plan Name");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                int sa = Convert.ToInt32(sumtxt.Text);
                
                //if (sumtxt.Text.Length > 10)
                //{
                //    MessageBox.Show("Sum Assured is exceeding defined limit.");
                //    sumtxt.SelectAll();
                //    sumtxt.Focus();
                //}
            }
            catch (Exception ex1)
            {
               // MessageBox.Show("" + ex1.Message);
                sumtxt.SelectAll();
                sumtxt.Focus();
            }
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("" + ex.Message);
            //    sumtxt.SelectAll();
            //    sumtxt.Focus();


            //}
        }

       
        
        }
      }

    

