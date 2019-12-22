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
    public partial class Service2 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr;

        public Service2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "")
            {

                MessageBox.Show("Please enter requested new address");
            }

            else if (richTextBox2.Text != "" && comboBox1.Text != "")
            {
                openConnection();
                String s = "insert into S_AddressChange(Policy_No,C_Name,Old_Address,New_Address,S2_Date) Values('" + comboBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + dateTimePicker1.Text + "')";
                cmd = new OleDbCommand(s, con);
                da = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                String stmt = "update C_PersonalDetails set Address=@u1 where C_Name=@u2";
                cmd = new OleDbCommand(stmt, con);
                cmd.Parameters.Add("@u1", OleDbType.VarChar, 30);
                cmd.Parameters.Add("@u2", OleDbType.VarChar, 30);


                cmd.Parameters["@u1"].Value = richTextBox2.Text;
                cmd.Parameters["@u2"].Value = textBox2.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Updated Successfully.");

                con.Close();

            }
        }
        public void openConnection()
        {

            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }
        private void Service2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (comboBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "" && richTextBox2.Text != "")
            {
                button1.Enabled = true;
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "Select C_Name,Address from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = comboBox1.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
                richTextBox1.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           

                printDialog1.Document = printDocument1;
                try
                {
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                catch (Exception)
                { }
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (richTextBox2.Text == "")
            {
                button1.Enabled = false;
            }
        }
    }
}

    


