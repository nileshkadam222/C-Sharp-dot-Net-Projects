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
    public partial class Queries1 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd,cmd1;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr,dr1;

        public Queries1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox11.Text="";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openConnection();
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please enter Policy number");
                }
                else
                {

                    string st = "insert into Q_CustPolicyHistory(C_Name,Policy_No,Policy_Name,P_DtofComm,P_Term,P_SumAssured,Premium_Paid,Installment_No,Installment_Left,P_DtofMaturity) Values('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox11.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox10.Text + "')";
                    cmd = new OleDbCommand(st, con);
                    da = new OleDbDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("RECORDS ADDED SUCCESSFULLY");
                     con.Close();

                  //  clear();
                    btn_print.Enabled = true;
                    btn_save.Enabled = false;
                }

               


            }
            catch (Exception) { }
        }
       

        private void Queries1_Load(object sender, EventArgs e)
        {
            btn_print.Enabled = false;
            btn_save.Enabled = false;
            openConnection();


            String str = "Select C_Name from C_PersonalDetails order by C_Name";
            cmd = new OleDbCommand(str, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                  
                    printDialog1.Document = printDocument1;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    btn_print.Enabled = false;
                    clear();
                   
            }
            catch (Exception) { }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "Select Policy_No,Policy_Name,P_DtofComm,P_Term,P_SumAssured,Total_Installment,P_DtofMaturity from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND C_Name=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.VarChar);
            cmd.Parameters["@s1"].Value = comboBox1.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
                textBox3.Text = dr[1].ToString();
                textBox4.Text = dr[2].ToString();
                textBox5.Text = dr[3].ToString();
                textBox11.Text = dr[4].ToString();
                textBox7.Text = dr[5].ToString(); 
                textBox10.Text = dr[6].ToString();
            }
            else
            {
                MessageBox.Show("Error");

            }
            btn_save.Enabled = true;
           // btn_print.Enabled = true;

            //----------------------------------------------------------------------------------------------

            try
            {
                String st = "Select P_Premium from C_PolicyDetails c1,C_PersonalDetails c2 where c2.Cust_id=c1.Cust_id AND c2.C_Name=@s1";
                String str1 = "Select SUM(P_Premium) from T_PaymentDetails where C_Name=@s2";
                cmd = new OleDbCommand(st, con);
                cmd1 = new OleDbCommand(str1, con);
                String p1 = "";
                String p2 = "";
                int p3 = 0;
                cmd.Parameters.Add("@s1", OleDbType.Char);
                cmd.Parameters["@s1"].Value = comboBox1.Text;
                cmd1.Parameters.Add("@s2", OleDbType.Char);
                cmd1.Parameters["@s2"].Value = comboBox1.Text;
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
                    textBox6.Text = Convert.ToString(p3);
                    con.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("User has paid only one installment");
                openConnection();
                String ins = "Select P_Premium from C_PolicyDetails c1,C_PersonalDetails c2 where c2.Cust_id=c1.Cust_id AND c2.C_Name=@s2";
                cmd = new OleDbCommand(ins, con);
                cmd.Parameters.Add("@i1", OleDbType.Char);
                cmd.Parameters["@i1"].Value = comboBox1.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox6.Text = dr[0].ToString();

                }
                else
                {
                    MessageBox.Show("Error");

                }

            }



            //--------------------------------------------------------------------------------------------
            try
            {
                openConnection();
                String st1 = "Select MAX(InstallmentNo) from T_PaymentDetails where C_Name=@s1";
                String st2 = "Select Total_Installment from C_PolicyDetails c1,C_PersonalDetails c2 where c2.Cust_id=c1.Cust_id AND c2.C_Name=@s2";
                cmd = new OleDbCommand(st1, con);
                cmd1 = new OleDbCommand(st2, con);
                String sp1 = "";
                String sp2 = "";
                int sp3 = 0;
                cmd.Parameters.Add("@s1", OleDbType.Char);
                cmd.Parameters["@s1"].Value = comboBox1.Text;
                cmd1.Parameters.Add("@s2", OleDbType.Char);
                cmd1.Parameters["@s2"].Value = comboBox1.Text;
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
                textBox8.Text = Convert.ToString(sp3);
                textBox8.Enabled = false;
                con.Close();

            }
            catch (FormatException)
            {
                openConnection();
                String st2 = "Select Total_Installment from C_PolicyDetails c1,c_PersonalDetails c2 where c2.Cust_id=c1.Cust_id AND c2.C_Name=@s1";
                cmd = new OleDbCommand(st2, con);
                String sp = "";
                cmd.Parameters.Add("@s1", OleDbType.Char);
                cmd.Parameters["@s1"].Value = comboBox1.Text;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    sp = dr[0].ToString();
                    int s = Convert.ToInt32(sp);
                    textBox8.Text = Convert.ToString(s - 1);

                }
            }
        

        }

       

       
        }

    }
