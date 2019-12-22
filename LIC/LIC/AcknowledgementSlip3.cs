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
    public partial class AcknowledgementSlip3 : Form
    {
        OleDbCommand cmd;
        OleDbCommand cmd1;
        // DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr, dr1;
        OleDbDataAdapter da;

        public AcknowledgementSlip3()
        {
            InitializeComponent();
        }

        private void AcknowledgementSlip2_Load(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void openConnection()
        {

            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }

        public void clear()
        {
            txt_polno.Text = "";
            txt_sa.Text = "";
            txt_paidprem.Text = "";
            txt_install.Text = "";
            txt_disvalue.Text = "";
            txt_refamt.Text = "";
            txt_totamt.Text = "";
            label11.Text = "";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
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
                    label11.Text = dr[1].ToString();

                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(""+ex.Message);
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
                    MessageBox.Show("Error");

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
                txt_paidprem.Text = Convert.ToString(p3);
                con.Close();
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
                txt_install.Text = Convert.ToString(sp3);
                txt_install.Enabled = false;
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
                    txt_install.Text = Convert.ToString(s - 1);
                    
                }
            }

            txt_refamt.Text = txt_paidprem.Text;
            Double a=Double.Parse(txt_paidprem.Text);
            txt_disvalue.Text = Convert.ToString(a*0.3);
            Double tot = a - Double.Parse(txt_disvalue.Text);
            txt_totamt.Text = Convert.ToString(tot);
        }

       

            

       

        private void txt_refamt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                openConnection();

                string st = "insert into Ack_form_for_ClaimSurrender(Policy_No,P_SumAssured,Paid_Premium,Installment_Left,DiscountedValue,RefundedAmount,Total_Amount)Values('" + txt_polno.Text + "','" + txt_sa.Text + "'," + txt_paidprem.Text + ",'" + txt_install.Text + "','" + txt_disvalue.Text + "','" + txt_refamt.Text + "','" + txt_totamt.Text + "')";
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
                //clear();
            }

            catch (Exception)
            {
                MessageBox.Show("This Client have already claimed!!!!");
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if(txt_polno.Text!="")
            {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            }
        }

        }

      
        

}    

        

       
        

