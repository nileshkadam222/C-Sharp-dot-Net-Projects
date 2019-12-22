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
    public partial class Service1 : Form
    {
        
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr;
       
        public Service1()
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
        private void service1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            catch(Exception)
            {}

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label1.Text,label1.Font,Brushes.Black,100,20);
            e.Graphics.DrawString(comboBox1.Text, comboBox1.Font, Brushes.Black, 350,20);
            e.Graphics.DrawString(label2.Text, label2.Font, Brushes.Black, 100, 50);
            e.Graphics.DrawString(textBox2.Text, textBox2.Font, Brushes.Black, 350, 50);
            e.Graphics.DrawString(label3.Text, label3.Font, Brushes.Black, 100, 80);
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 350, 80);
            e.Graphics.DrawString(label5.Text, label5.Font, Brushes.Black, 100, 110);
            e.Graphics.DrawString(label6.Text, label6.Font, Brushes.Black, 100, 170);
            e.Graphics.DrawString(label8.Text, label8.Font, Brushes.Black, 300, 170);
            e.Graphics.DrawString(label7.Text, label7.Font, Brushes.Black, 500, 170);
            e.Graphics.DrawString(label9.Text, label9.Font, Brushes.Black, 100, 200);
            e.Graphics.DrawString(textBox3.Text, textBox3.Font, Brushes.Black, 300, 200);
            e.Graphics.DrawString(textBox5.Text, textBox5.Font, Brushes.Black, 500, 200);
            e.Graphics.DrawString(label10.Text, label10.Font, Brushes.Black, 100, 230);
            e.Graphics.DrawString(textBox6.Text, textBox6.Font, Brushes.Black, 300, 230);
            e.Graphics.DrawString(textBox4.Text, textBox4.Font, Brushes.Black, 500, 230);

            e.Graphics.PageUnit = GraphicsUnit.Inch;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
       
            if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Please fill proper value");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            //if (textBox5.Text == "")
            //{

            //    MessageBox.Show("Please enter requested name of life assured");
            //}

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox4.Text == "")
            //{
            //    MessageBox.Show("Please enter requested name of policy holder");
               
            //}


            if (textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please enter required fields");
            }
        
            else
            {
                openConnection();
                String s = "insert into S_NameChange(Policy_No,C_Name,Address,N_PresentName,N_NameRequested,C_PresentName,C_NameRequested,S1_Date) Values('" + comboBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "')";
                cmd = new OleDbCommand(s, con);
                da = new OleDbDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                String stmt = "update C_PersonalDetails set C_Name=@u1,N_Name=@u2 where Address=@u3";
                cmd = new OleDbCommand(stmt, con);
                cmd.Parameters.Add("@u1", OleDbType.VarChar, 30);
                cmd.Parameters.Add("@u2", OleDbType.VarChar, 30);
                cmd.Parameters.Add("@u3", OleDbType.VarChar, 30);

                cmd.Parameters["@u1"].Value = textBox5.Text;
                cmd.Parameters["@u2"].Value = textBox4.Text;
                cmd.Parameters["@u3"].Value = richTextBox1.Text;
                cmd.ExecuteNonQuery();

                //Updating in Transaction Table

                String stmt1 = "update T_PaymentDetails set C_Name=@u1 where Policy_No=@u2";
                cmd = new OleDbCommand(stmt1, con);
                cmd.Parameters.Add("@u1", OleDbType.VarChar, 30);
                cmd.Parameters.Add("@u2", OleDbType.VarChar, 30);

                cmd.Parameters["@u1"].Value = textBox5.Text;
                cmd.Parameters["@u2"].Value = comboBox1.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Records Updated Successfully.");
                button2.Enabled = false;
                Clear();
                errorProvider1.Clear();
               
            }
           
        }
        public void Clear()
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            openConnection();
            String str = "Select C_Name,Address,N_Name,C_Name from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = comboBox1.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
                richTextBox1.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox6.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Error");

            }
        }


        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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


       
        }

    }

