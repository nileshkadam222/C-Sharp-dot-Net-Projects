using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LIC
{

    public partial class transaction1 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr;

        public transaction1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void openConnection()
        {

            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }

        private void transaction1_Load(object sender, EventArgs e)
        {
            openConnection();


            String str = "Select Policy_No from C_PolicyDetails order by Policy_No";
            cmd = new OleDbCommand(str, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo_polno.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
            }

        }

        public void clear()
        {
            cbo_polno.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            txt_termpay.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            dtp_riskdt.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Text = "";
            dateTimePicker4.Text = "";
            textBox2.Text = "";
        }






        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openConnection();
                if (cbo_polno.Text == "")
                {
                    MessageBox.Show("Please enter Policy number");
                }
                else
                {

                    string st = "insert into T_PaymentDetails(Policy_No,C_Name,P_Term,P_Termwise,P_SumAssured,P_ModeofPayment,P_Premium,Risk_Date,Total_Installment,Commission,InstallmentNo,PaymentDate) Values('" + cbo_polno.Text + "','" + textBox8.Text + "'," + textBox9.Text + ",'" + txt_termpay.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + dtp_riskdt.Text + "','" + textBox1.Text + "','" + textBox6.Text + "','" + textBox2.Text + "','" + dateTimePicker4.Text + "')";
                    cmd = new OleDbCommand(st, con);
                    da = new OleDbDataAdapter(cmd);
                    int rs = cmd.ExecuteNonQuery();
                    if (rs > 0)
                    {
                        MessageBox.Show("Records are Added successfully.");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Records not Added successfully.");
                    }
                }
                clear();
            }
            catch (Exception ex)
            { MessageBox.Show(""+ex.Message); }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //    int premium = Convert.ToInt32(textBox5.Text);
            //    double commission = premium*0.02;

            //    textBox6.Text = Convert.ToString(premium);
            //}    
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }






        private void cbo_polno_SelectedIndexChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "select C_Name,P_Term,Termwise_Payment,P_SumAssured,Total_Installment,P_RiskDt from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = cbo_polno.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox8.Text = dr[0].ToString();
                textBox9.Text = dr[1].ToString();
                txt_termpay.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox1.Text = dr[4].ToString();
                dtp_riskdt.Text = dr[5].ToString();
            }
            else
            {
                MessageBox.Show("Error");

            }

            String s = "Select count(Policy_No) from T_PaymentDetails where Policy_No=@s1";
            cmd = new OleDbCommand(s, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = cbo_polno.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                int max1 = int.Parse(dr[0].ToString());
                max1 = max1 + 2;
                textBox2.Text = (max1).ToString();
                textBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error");

            }
           // int i = int.Parse(textBox2.Text);
            
           if (textBox2.Text != "2")
            {
                String st = "Select count(InstallmentNo) from T_PaymentDetails where Policy_No=@s1";
                cmd = new OleDbCommand(st, con);
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = cbo_polno.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Incrementing Risk Date

                    DateTime dt;
                    if (txt_termpay.Text == "Monthly")
                    {
                        //int i = 1;
                        dt = DateTime.Parse(dtp_riskdt.Text);
                        dt = dt.AddMonths(1);
                        dtp_riskdt.Text = dt.ToString();
                    }
                    else if (txt_termpay.Text == "Quarterly")
                    {
                        dt = DateTime.Parse(dtp_riskdt.Text);
                        dt = dt.AddMonths(3);
                        dtp_riskdt.Text = dt.ToString();
                    }
                    else if (txt_termpay.Text == "Yearly")
                    {
                        dt = DateTime.Parse(dtp_riskdt.Text);
                        dt = dt.AddYears(1);
                        dtp_riskdt.Text = dt.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error");

                    }

                }
            }
            try
            {
              //  DateTime LED1 = new DateTime(2013, 7, 7);
                DateTime LED = DateTime.Parse(dtp_riskdt.Text);
               // if (LED.CompareTo(LED1) > 0)
               if (LED.CompareTo(DateTime.Now) > 0)
                {
                   // MessageBox.Show((LED.Subtract(LED1)).Days + " days more to expire");
                    MessageBox.Show((LED.Subtract(DateTime.Now)).Days + " days more to expire");
                    textBox6.Text = "0";
                    textBox6.Enabled = false;
                    String s1 = "Select P_Premium from C_PolicyDetails where Policy_No=@s1";
                    cmd = new OleDbCommand(s1, con);
                    cmd.Parameters.Add("@s1", OleDbType.Integer);
                    cmd.Parameters["@s1"].Value = cbo_polno.Text;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox5.Text = dr[0].ToString();
                        textBox5.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Risk Date has arised");
                    String s1 = "Select P_Premium from C_PolicyDetails where Policy_No=@s1";
                    cmd = new OleDbCommand(s1, con);
                    cmd.Parameters.Add("@s1", OleDbType.Integer);
                    cmd.Parameters["@s1"].Value = cbo_polno.Text;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox5.Text = dr[0].ToString();
                       Double prem = Double.Parse(textBox5.Text);
                        Double prem1 = prem + (prem * 0.02);
                        textBox5.Text = Convert.ToString(prem1);
                        textBox5.Enabled = false;
                        textBox6.Text = Convert.ToString(prem * 0.02);
                        textBox6.Enabled = false;
                    }
                
                   
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }



            }


        }

        




   }

      
    

