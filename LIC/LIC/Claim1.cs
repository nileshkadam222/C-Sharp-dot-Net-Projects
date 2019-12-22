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


    public partial class Claim1 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd,cmd1;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr,dr1;
        public Claim1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

            cbo_polno.Text="";
            txt_name.Text ="";
            //dtp_maturity.Text =" ";
            txt_bankname.Text ="";
            txt_bankbr.Text = "";
            txt_acctno.Text ="";
            label1.Text = "";
        
        
        }
        private void Claim1_Load(object sender, EventArgs e)
        {
            btn_ackslip.Enabled = false;
           
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

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openConnection();


                String str = "";
                if (rdb_savings.Checked == true)
                {
                    str = rdb_savings.Text;
                }
                else if (rdb_credit.Checked == true)
                {
                    str = rdb_credit.Text;
                }
                else if (rdb_draft.Checked == true)
                {
                    str = rdb_draft.Text;
                }

               
                    String st = "insert into MaturityClaim(Policy_No,C_Name,P_DtofMaturity,B_Name,B_Branch,AccountNo,AccountType) Values('" + cbo_polno.Text + "','" + txt_name.Text + "','" + dtp_maturity.Text + "','" + txt_bankname.Text + "','" + txt_bankbr.Text + "','" + txt_acctno.Text + "','" + str + "') ";
                    cmd = new OleDbCommand(st, con);
                    da = new OleDbDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Please print Acknowledgement Slip.");
                    AcknowledgementSlip1 as1 = new AcknowledgementSlip1();
                    as1.Show();
                    this.Hide();
                    as1.txt_polno.Text = cbo_polno.Text;
                    con.Close();
                }

               
            
            catch (Exception)
            {
                MessageBox.Show("Client have already claimed");
                clear();
                rdb_credit.Checked = false;
                rdb_draft.Checked = false;
                rdb_savings.Checked = false;
                btn_ackslip.Enabled = false;
            }
        }
        
        private void cbo_polno_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                openConnection();
                String str = "Select C_Name,P_DtofMaturity,Policy_Name from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
                cmd = new OleDbCommand(str, con);
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = cbo_polno.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_name.Text = dr[0].ToString();
                    dtp_maturity.Text = dr[1].ToString();
                    label1.Text = dr[2].ToString();

                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
            catch (Exception) { }

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
               // int sp3 = 0;
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = cbo_polno.Text;
                cmd1.Parameters.Add("@s2", OleDbType.Integer);
                cmd1.Parameters["@s2"].Value = cbo_polno.Text;
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
                if (ps1 == ps2)
                {
                    MessageBox.Show("Policy is  matured");
                    //btn_ackslip.Enabled = true;
                    txt_bankname.Enabled = true;
                    txt_bankbr.Enabled = true;
                    txt_acctno.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Policy is Not Yet matured");
                    //btn_ackslip.Enabled = false;
                    txt_bankname.Enabled = false;
                    txt_bankbr.Enabled = false;
                    txt_acctno.Enabled = false;
                    clear();
                   // btn_ackslip.Enabled = true;
                }
                
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("POLICY IS NOT YET MATURED");
                btn_ackslip.Enabled = false;
                txt_bankname.Enabled = false;
                txt_bankbr.Enabled = false;
                txt_acctno.Enabled = false;
                clear();
                
              //  btn_ackslip.Enabled = true;
            }

        }

        private void txt_bankname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_bankbr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_acctno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long acctno = Convert.ToInt64(txt_acctno.Text);
            }
            catch (FormatException)
            {
                if (txt_acctno.Text.Length != 0)
                {
                    MessageBox.Show("PLEASE ENTER THE NUMERIC VALUE");
                    txt_acctno.SelectAll();
                    //  txt_acctno.Focus();
                }

            }
        }

        private void rdb_savings_CheckedChanged(object sender, EventArgs e)
        {
            String str = rdb_savings.Text;
            if (txt_bankname.Text != "" && txt_bankbr.Text != "" && txt_acctno.Text != "" && str != "")
            {
                btn_ackslip.Enabled = true;
            }
        }

        private void rdb_credit_CheckedChanged(object sender, EventArgs e)
        {
            String str = rdb_credit.Text;
            if (txt_bankname.Text != "" && txt_bankbr.Text != "" && txt_acctno.Text != "" && str != "")
            {
                btn_ackslip.Enabled = true;
            }
        }

        private void rdb_draft_CheckedChanged(object sender, EventArgs e)
        {
            String str = rdb_draft.Text;
            if (txt_bankname.Text != "" && txt_bankbr.Text != "" && txt_acctno.Text != "" && str != "")
            {
                btn_ackslip.Enabled = true;
            }
        }

       

       
    }
}
