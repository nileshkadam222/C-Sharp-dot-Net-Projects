using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementCSharp
{
    public partial class NewEnquiry : Form
    {
        public NewEnquiry()
        {
            InitializeComponent();
        }

        private void NewEnquiry_Load(object sender, EventArgs e)
        {
            TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        RadioButton1.Enabled = false;
        RadioButton2.Enabled = false;
        CheckBox2.Enabled = false;
        Button1.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
        RadioButton1.Enabled = true;
        RadioButton2.Enabled = true;
        CheckBox2.Enabled = true;
        Button3.Enabled = true;
        Button1.Enabled = true;
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button3.Enabled = true;
        Button1.Enabled = false;

        DataConnection dc = new DataConnection ();
        String pi;
        if(RadioButton1.Checked == true)
            pi = "Gym";
        else
            pi = "GymCardio";
        
        String pt;
        if(CheckBox2.Checked == true)
            pt = "Yes";
        else
            pt = "No";
       
        dc.cmd.CommandText = "Insert into new_enquiry values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTimePicker1.Value + "','" + pi + "','" + pt + "')";
        //MessageBox.Show(dc.cmd.CommandText);
        int i = dc.cmd.ExecuteNonQuery();
        MessageBox.Show("Record inserted");
   
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        if((( (int)(e.KeyChar) <= 122) && (int)(e.KeyChar) >= 65) || ((int)(e.KeyChar) == 8))
            e.Handled = false;
        else
            e.Handled = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        if ((((int)(e.KeyChar) >= 45) && (int)(e.KeyChar) <= 57) || ((int)e.KeyChar == 8))
            e.Handled = false;
        else
            e.Handled = true;
       

        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
         int a = TextBox2.Text.Length;
         if (a < 10)
         {
             MessageBox.Show("10 digits");
             TextBox2.Focus();
         }
         }
    }
}
