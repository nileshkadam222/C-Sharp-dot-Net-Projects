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
    public partial class Claim3 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr;

        public Claim3()
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
        private void Claim3_Load(object sender, EventArgs e)
        {
             btn_ackslip.Enabled = false;
             try
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
             catch (Exception) { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            AcknowledgementSlip3 as3 = new AcknowledgementSlip3();
            as3.Show();
            
            
        }

        private void cbo_polno_SelectedValueChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "Select P_DtofMaturity,Policy_Name from C_PolicyDetails where Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = cbo_polno.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dtp_maturity.Text = dr[0].ToString();
                label6.Text = dr[1].ToString();

            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void btn_ackslip_Click(object sender, EventArgs e)
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

                    string st = "insert into ClaimSurrender(Policy_No,P_DtofMaturity) Values('" + cbo_polno.Text + "','" + dtp_maturity.Text + "')";
                    cmd = new OleDbCommand(st, con);
                    da = new OleDbDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    //if (rs > 0)
                    //{
                    //    MessageBox.Show("Records are Added successfully.");
                    //    con.Close();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Records not Added successfully.");
                    //}
                    MessageBox.Show("Please print Acknowledgemnt Slip.");
                    AcknowledgementSlip3 as3 = new AcknowledgementSlip3();
                    as3.Show();
                    this.Hide();
                    as3.txt_polno.Text = cbo_polno.Text;
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This client have already claimed");
                btn_ackslip.Enabled = false;
            }
        }

        private void cbo_polno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                openConnection();
                String s = "Select P_DtofComm from C_PolicyDetails where Policy_No=@s1";
                cmd = new OleDbCommand(s, con);
                cmd.Parameters.Add("@s1", OleDbType.Integer);
                cmd.Parameters["@s1"].Value = cbo_polno.Text;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // string msg = dr[0].ToString();
                    DateTime a = DateTime.Parse(dr[0].ToString());
                    DateTime s1 = DateTime.Now; ;
                    int age = s1.Year - a.Year;
                    if (age < 3)
                    {
                        MessageBox.Show("Claim cannot be surrendered until premium are paid for 3 years.");
                       
                        cbo_polno.Text = "";
                        dtp_maturity.Text = "";
                    }
                    else
                    {
                        btn_ackslip.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

       
    }
}
