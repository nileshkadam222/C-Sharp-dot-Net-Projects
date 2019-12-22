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
    public partial class Queries3 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr;


        public Queries3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void openConnection()
        {

            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }

        private void Queries3_Load(object sender, EventArgs e)
        {
            btn_print.Enabled = false;
            btn_save.Enabled = false;
            openConnection();


            String str = "Select Policy_No from C_PolicyDetails order by Policy_No";
            cmd = new OleDbCommand(str, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        public void clear()
        {
            comboBox1.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox5.Text = "";
                   
        }


       

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "Select C_Name,C_Occp,C_Income,P_DtofComm,P_Term,P_SumAssured,P_Premium,P_DtofMaturity from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = comboBox1.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox11.Text = dr[0].ToString();
                textBox10.Text = dr[1].ToString();
                textBox12.Text = dr[2].ToString();
                textBox2.Text = dr[3].ToString();
                textBox1.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
                textBox8.Text = dr[6].ToString();
                textBox5.Text = dr[7].ToString();
                
            }
            else
            {
                MessageBox.Show("Error");

            }
            btn_save.Enabled = true;
          //  btn_print.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
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

                    string st = "insert into Q_Info_through(Policy_No,C_Name,C_Occp,C_Income,P_DtofComm,P_Term,P_SumAssured,P_Premium,Maturity_Date) Values('" + comboBox1.Text + "','" + textBox11.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox5.Text + "')";
                    cmd = new OleDbCommand(st, con);
                    da = new OleDbDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("RECORDS ADDED SUCCESSFULLY");
                    btn_save.Enabled = false;
                    btn_print.Enabled = true;
                    
                    

                }
                
                con.Close();
            }
            catch (Exception) { MessageBox.Show("You have already saved data.");
            clear();
            }
            
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                clear();
                btn_print.Enabled = false;
            }
            catch (Exception) { }
        }
    }
}
