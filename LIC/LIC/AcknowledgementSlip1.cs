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
    public partial class AcknowledgementSlip1 : Form
    {
       // OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbCommand cmd1;
       // DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr,dr1;

        public AcknowledgementSlip1()
        {
            InitializeComponent();
        }

        

        private void AcknowledgementSlip1_Load(object sender, EventArgs e)
        {
           // btn_print.Enabled = false;
           // btn_Save.Enabled = false;
        }

        
       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            int num1, num2, res = 0;
            num1 = int.Parse(txt_bonus.Text);
            num2 = int.Parse(txt_refamt.Text);
            res = num1 + num2;
            //int res = Textbox7.Text;

           // int.Parse(textBox6.Text) + int.Parse(textBox5.Text);
            txt_totamt.Text = res.ToString();
        }
        public void clear()
        {
            txt_polno.Text +=" ";
            txt_sa.Text =" ";
            txt_totprem.Text =" ";
            txt_bonus.Text =" ";
            txt_refamt.Text =" ";
            txt_totamt.Text =" ";
            label7.Text = "";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
                con.Open();
                cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Ack_form_for_Maturity(Policy_No,P_SumAssured,Total_Premium,Vested_Bonus,Refunded_Amount,Total_Amount,Dt_ofAck) Values('" + txt_polno.Text + "','" + txt_sa.Text + "','" + txt_totprem.Text + "','" + txt_bonus.Text + "','" + txt_refamt.Text + "','" + txt_totamt.Text + "','" + dateTimePicker1.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records are Added successfully.");
              //  clear();
             //   txt_polno.Text = "";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

       
        public void openConnection()
        {

            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "Select P_SumAssured,Policy_Name from C_PolicyDetails where Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = txt_polno.Text;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_sa.Text = dr[0].ToString();
                label7.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show("Error");

            }
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
                    txt_totprem.Text = Convert.ToString(p3);
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
                    txt_totprem.Text = dr[0].ToString();

                }
                else
                {
                    MessageBox.Show("Error");

                }

            }

            //------------------------------------------------------------------------

           
               openConnection();
               String policy="Select Policy_Name from C_PolicyDetails where Policy_No=@p1";
               cmd = new OleDbCommand(policy, con);
                cmd.Parameters.Add("@p1", OleDbType.Char);
                cmd.Parameters["@p1"].Value = txt_polno.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   String policyname = dr[0].ToString();
                    if(policyname=="Jeevan Anand[149]")
                    {
                         txt_refamt.Text = txt_totprem.Text;
                         Double a = Double.Parse(txt_totprem.Text);
                         Double b = (a * 2.5)-a;
                         txt_bonus.Text = Convert.ToString(b);
                         Double tot = a + Double.Parse(txt_bonus.Text);
                         txt_totamt.Text = Convert.ToString(tot);
                    }
                    else if(policyname=="Jeevan Saral[165]"){
                         txt_refamt.Text = txt_totprem.Text;
                         Double a = Double.Parse(txt_totprem.Text);
                         Double b = (a * 1.5)-a;
                         txt_bonus.Text = Convert.ToString(b);
                         Double tot = a + Double.Parse(txt_bonus.Text);
                         txt_totamt.Text = Convert.ToString(tot);

                    }
                }
                else
                {
                    MessageBox.Show("Error");

                }

           



        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

       

      
    }
    }

