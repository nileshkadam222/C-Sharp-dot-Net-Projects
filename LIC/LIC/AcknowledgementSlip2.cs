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
    public partial class AcknowledgementSlip2 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd,cmd1;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr,dr1;

        public AcknowledgementSlip2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        public void openConnection()
        {
            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Ack_form_for_Death(Policy_No,P_SumAssured,Paid_Premium,Installment_Left,Inclusive_Bonus,RefundedAmount,Total_Amount) Values('" + txt_polno.Text + "','" + txt_sumass.Text + "','" + txt_paidprem.Text + "','" + txt_leftinstall.Text + "','" + txt_bonus.Text + "','" + txt_refamt.Text + "','" + txt_totamt.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records are Added successfully.");

                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("This Client have already claimed!!!!");
                }
        }

        

        private void txt_totamt_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void AcknowledgementSlip2_Load(object sender, EventArgs e)
        {

        }

        private void txt_polno_TextChanged(object sender, EventArgs e)
        {
            //Retrieving sum assured value from table C_PolicyDetails

            openConnection();
            String stm = "select P_SumAssured from C_PolicyDetails where Policy_No=@s1";
            cmd = new OleDbCommand(stm, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = txt_polno.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_sumass.Text = dr[0].ToString();

            }
            else
            {
                MessageBox.Show("Error");

            }

            //-----------------------------------------------------------------------------------------------
            //Calculating paid premium
            try
            {
                String st = "Select P_Premium from C_PolicyDetails where Policy_No=@s1";
                String str1 = "Select SUM(P_Premium) from T_PaymentDetails where Policy_No=@s2";
                cmd = new OleDbCommand(st, con);
                cmd1 = new OleDbCommand(str1, con);
                String p1 = "";
                String p2 = "";
                int p3 = 0;
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = txt_polno.Text;
                cmd1.Parameters.Add("@s2", OleDbType.Integer);
                cmd1.Parameters["@s2"].Value = txt_polno.Text;
                dr = cmd.ExecuteReader();
                dr1 = cmd1.ExecuteReader();
                // Console.WriteLine("" + dr);
                if (dr.Read())
                {
                    p1 = dr[0].ToString();

                }
                else
                {
                    MessageBox.Show("Error1");

                }
                if (dr1.Read())
                {
                    p2 = dr1[0].ToString();

                }
                else
                {
                    MessageBox.Show("Error2");

                }
                int s1 = int.Parse(p1);
                int s2 = int.Parse(p2);
                p3 = s1 + s2;
                {
                    txt_paidprem.Text = Convert.ToString(p3);
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User has paid only one installment");
                openConnection();
                String ins = "Select P_Premium from C_PolicyDetails where Policy_No=@i1";
                cmd = new OleDbCommand(ins, con);
                cmd.Parameters.Add("@i1", OleDbType.Integer);
                cmd.Parameters["@i1"].Value = txt_polno.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_paidprem.Text = dr[0].ToString();

                }
                else
                {
                    MessageBox.Show("Error");

                }

            }

            //--------------------------------------------------------------

            //--------------------------------------------------------------
            //Calculating Installments Left
            try
            {
                openConnection();
                String st1 = "Select MAX(InstallmentNo) from T_PaymentDetails where Policy_No=@s1";
                String st2 = "Select Total_Installment from C_PolicyDetails where Policy_No=@s2";
                cmd = new OleDbCommand(st1, con);
                cmd1 = new OleDbCommand(st2, con);
                String sp1 = "";
                String sp2 = "";
                int sp3 = 0;
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = txt_polno.Text;
                cmd1.Parameters.Add("@s2", OleDbType.Integer);
                cmd1.Parameters["@s2"].Value = txt_polno.Text;
                dr = cmd.ExecuteReader();
                dr1 = cmd1.ExecuteReader();

                if (dr.Read())
                {
                    sp1 = dr[0].ToString();


                }
                else
                {
                    MessageBox.Show("dr");

                }
                if (dr1.Read())
                {

                    sp2 = dr1[0].ToString();

                }

                else
                {
                    MessageBox.Show("dr1");

                }
                int ps1 = int.Parse(sp1);
                int ps2 = int.Parse(sp2);
                sp3 = ps2 - ps1;
                txt_leftinstall.Text = Convert.ToString(sp3);
                txt_leftinstall.Enabled = false;
                con.Close();

            }
            catch (Exception)
            {
                openConnection();
                String st2 = "Select Total_Installment from C_PolicyDetails where Policy_No=@s1";
                cmd = new OleDbCommand(st2, con);
                String sp = "";
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = txt_polno.Text;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    sp = dr[0].ToString();
                    int s = Convert.ToInt32(sp);
                    txt_leftinstall.Text = Convert.ToString(s - 1);

                }
            }


            //-------------------------------------------------------------------------------------------
            //Calculating total amount for Jeevan Saral and Anand Plan
            //  try
            //  {
            openConnection();
            String cal = "Select P_Premium,P_Term from C_PolicyDetails where Policy_No=@i1";
            cmd = new OleDbCommand(cal, con);
            cmd.Parameters.Add("@i1", OleDbType.Integer);
            cmd.Parameters["@i1"].Value = txt_polno.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                int premium = Convert.ToInt32(dr[0].ToString());
                // MessageBox.Show("Premium= "+premium*250);
                
                 int term = Convert.ToInt32(dr[1].ToString());
               // MessageBox.Show("Term= " + term);
             
                if (term == 25)
                {
                    label4.Text="for Jeevan Saral[165]";
                    int num1, num2, res = 0;
                    txt_refamt.Text = txt_paidprem.Text;
                    num2 = Convert.ToInt32(txt_refamt.Text);
                    txt_totamt.Text = Convert.ToString(premium * 250);
                    num1 = Convert.ToInt32(txt_totamt.Text);
                    res = num1 - num2;
                    txt_bonus.Text = res.ToString();
                    
                }
                else if (term == 21)
                {
                    label4.Text = "for Jeevan Anand[149]";
                    //try
                   // {
                        openConnection();
                        String s = "Select N_Dob from C_PersonalDetails c1,C_PolicyDetails c2 where c1.Cust_id=c2.Cust_id AND c2.Policy_No=@s1";
                        String p1 = "Select D_DateofDeath from DeathClaim where Policy_No=@p1";    
                    String dt="";
                    String dt1="";
                    cmd = new OleDbCommand(s, con);
                    cmd1 = new OleDbCommand(p1, con);
                        cmd.Parameters.Add("@s1", OleDbType.Integer);
                        cmd.Parameters["@s1"].Value = txt_polno.Text;
                        cmd1.Parameters.Add("@p1", OleDbType.Integer);
                        cmd1.Parameters["@p1"].Value = txt_polno.Text;
                        dr = cmd.ExecuteReader();
                        dr1 = cmd1.ExecuteReader();
                        if (dr.Read())
                        {
                           dt = dr[0].ToString();
                          
                        }
                       if(dr1.Read())
                    {
                            dt1 = dr1[0].ToString();
                            
                           
                    }
                             DateTime dob = DateTime.Parse(dt);
                             DateTime dod1 = DateTime.Parse(dt1);
                            int age =Convert.ToInt32 (dod1.Year - dob.Year);
                          //  MessageBox.Show(""+age);
                            if (age >= 70)
                            {
                                txt_refamt.Text = txt_paidprem.Text;
                                txt_bonus.Text = txt_sumass.Text;
                                int num1 = Convert.ToInt32(txt_sumass.Text);
                                int num2 = Convert.ToInt32(txt_refamt.Text);
                                int num = num1 + num2;
                                txt_totamt.Text = num.ToString();

                            }
                            else if (age < 70)
                            {
                                txt_refamt.Text = txt_paidprem.Text;
                                txt_bonus.Text = "0";
                                int num1 = Convert.ToInt32(txt_bonus.Text);
                                int num2 = Convert.ToInt32(txt_refamt.Text);
                                int num = num1 + num2;
                                txt_totamt.Text = num.ToString();
                            }

                        }
                        else
                            MessageBox.Show("Error");
                   // }
                   // catch (Exception ex)
                  //  {
                  //      MessageBox.Show("" + ex.Message);
                  //  }
                }


        }
    }
        }
    
    