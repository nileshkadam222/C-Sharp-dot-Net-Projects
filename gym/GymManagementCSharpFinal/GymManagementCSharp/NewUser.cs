using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace GymManagementCSharp
{
    public partial class New_User : Form
    {
        DataConnection dc = new DataConnection();
        public New_User()
        {
            InitializeComponent();
        }

        private void New_User_Load(object sender, EventArgs e)
        {
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        Button1.Enabled = false;
    
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button3.Enabled = false;
        Button1.Enabled = true;
        TextBox1.Enabled = true;
        TextBox2.Enabled = true;
   
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button1.Enabled = false;
        Button3.Enabled = true;
        
        dc.cmd.CommandText = "select * from login where username = '" + TextBox1.Text + "'";
        dc.reader = dc.cmd.ExecuteReader();
        if(dc. reader.Read() == true)
        {
            MessageBox.Show("User already exists , Change the User Name");
            TextBox1.Clear();
            TextBox1.Focus();
            Button1.Enabled = true;
            dc.reader.Close();
        }
        else
        {
            dc.reader.Close();
            dc.cmd.CommandText = "insert into login values ('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = dc.cmd.ExecuteNonQuery();
            if (i > 0)
                MessageBox.Show("User Added Successfully");
         
        }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
        int l = TextBox2.Text.Length;
        if (l <= 3)
        {
            MessageBox.Show("Password length should be more than 3 and upto 8 characters");
            TextBox2.Focus();
        }
      Match m = Regex.Match(TextBox2.Text, "[a-z][0-9]");
        
        }
    }
}
