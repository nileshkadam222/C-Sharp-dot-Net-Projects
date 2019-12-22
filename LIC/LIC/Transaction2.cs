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
    public partial class Transaction2 : Form
    {
        OleDbDataAdapter da;
        OleDbDataReader dr,dr1,dr2,dr3;
        OleDbCommand cmd,cmd1,cmd2,cmd3;
        DataSet ds;
        OleDbConnection con;

        public Transaction2()
        {
            InitializeComponent();
        }

        public void openConnection()
        {
            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }
        private void Transaction2_Load(object sender, EventArgs e)
        {

            openConnection();


            String str = "Select Policy_No from C_PolicyDetails order by Policy_No ";
            cmd = new OleDbCommand(str, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo_polno.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
            }
               
            }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

       

         public void clear()
        {
            cbo_polno.Text = "";
            txt_cname.Text = "";
            txt_totprem.Text = "";
            txt_tot_comm_on_prem.Text = "";
            txt_tot_comm_on_riskdate.Text = "";
            txt_tot_comm_amt.Text = "";
            
        }

         private void btn_save_Click(object sender, EventArgs e)
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
                     String st = "insert into T_CommissionData(Policy_No,Cust_Name,Tot_Premium,Tot_comm_on_Premium,Tot_comm_on_riskdate,Tot_comm) Values('" + cbo_polno.Text + "','" + txt_cname.Text + "','" + txt_totprem.Text + "','" + txt_tot_comm_on_prem.Text + "','" + txt_tot_comm_on_riskdate.Text + "','" + txt_tot_comm_amt.Text + "')";
                     cmd = new OleDbCommand(st, con);
                     da = new OleDbDataAdapter(cmd);
                     //cmd.Connection = con;
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Registration Completed.");
                 }
                 clear();
             }
             catch (Exception) { }
         }
        
        private void btn_cncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_polno_SelectedValueChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "Select C_Name from C_PolicyDetails c1,C_PersonalDetails c2 WHERE c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = cbo_polno.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_cname.Text = dr[0].ToString();
                
            }
            else
            {
                MessageBox.Show("Error");

            }

            //-Calculating Total Premium

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
                cmd.Parameters["@s1"].Value = cbo_polno.Text;
                cmd1.Parameters.Add("@s2", OleDbType.Integer);
                cmd1.Parameters["@s2"].Value = cbo_polno.Text;
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
                cmd.Parameters["@i1"].Value = cbo_polno.Text;
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

            //-Calculating commission on Premium

            try
            {
                openConnection();
                String st = "Select P_Premium from C_PolicyDetails where Policy_No=@s1";
                String str1 = "Select SUM(P_Premium) from T_PaymentDetails where Commission=0 AND Policy_No=@s2";
                String str2 = "Select SUM(P_Premium) from T_PaymentDetails where Commission<>0 AND Policy_No=@s3";
                String str3 = "Select SUM(Commission) from T_PaymentDetails where Policy_No=@s4";
                cmd = new OleDbCommand(st, con);
                cmd1 = new OleDbCommand(str1, con);
                cmd2 = new OleDbCommand(str2, con);
                cmd3 = new OleDbCommand(str3, con);
                String p1 = "";
                String p2 = "";
                String p3 = "";
                String p4 = "";
                //int p3 = 0;
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = cbo_polno.Text;
                cmd1.Parameters.Add("@s2", OleDbType.Integer);
                cmd1.Parameters["@s2"].Value = cbo_polno.Text;
                cmd2.Parameters.Add("@s3", OleDbType.Integer);
                cmd2.Parameters["@s3"].Value = cbo_polno.Text;
                cmd3.Parameters.Add("@s4", OleDbType.Integer);
                cmd3.Parameters["@s4"].Value = cbo_polno.Text;
                dr = cmd.ExecuteReader();
                dr1 = cmd1.ExecuteReader();
                dr2 = cmd2.ExecuteReader();
                dr3 = cmd3.ExecuteReader();

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
                   // MessageBox.Show("" + p2);

                }
                else
                {
                    MessageBox.Show("Error2");

                }
                if (dr2.Read())
                {
                    p3 = dr2[0].ToString();
                   // MessageBox.Show("" + p3);
                }
                else
                {
                    MessageBox.Show("Error2");

                }
                if (dr3.Read())
                {
                    p4 = dr3[0].ToString();
                   // MessageBox.Show("" + p4);
                }
                else
                {
                    MessageBox.Show("Error2");

                }
                 int s1 = int.Parse(p1);
                 int s2 = int.Parse(p2);
                 int s3 = int.Parse(p3); 
                int s4 = int.Parse(p4);
                Double comm = (s1 + s2+s3) * 0.02;
                //MessageBox.Show(""+comm);
               Double comm1 = (s1 + s2+s3) - comm;
               Double comm2 = comm1 * 0.02;
              // MessageBox.Show("" + comm2);
               txt_tot_comm_on_prem.Text = Convert.ToString(comm2);  
 
                //-Calculating commission on risk date

               txt_tot_comm_on_riskdate.Text = Convert.ToString(s4);
               txt_tot_comm_amt.Text = Convert.ToString(comm2+s4);

                con.Close();
                
            }
            catch (Exception ex) {
                openConnection();
                String st = "Select P_Premium from C_PolicyDetails where Policy_No=@s1";
                String pre = "";
                cmd = new OleDbCommand(st,con);
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = cbo_polno.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                       pre = dr[0].ToString();
                       Double prem = Convert.ToDouble(pre);
                       Double pre1 =Convert.ToDouble(prem * 0.02);
                       Double pre2 = prem - pre1;
                       txt_tot_comm_on_prem.Text = Convert.ToString(pre2*0.02);
                       txt_tot_comm_on_riskdate.Text = "0";
                       txt_tot_comm_amt.Text = txt_tot_comm_on_prem.Text;
                }
                else
                {
                    MessageBox.Show("" + ex.Message);
                }
            }

        }

       

        
            

        }
    }

