using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeProfileManagement
{
    public partial class frmChangePassword : Form
    {
        connectionClass obj = new connectionClass();
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "")
            {
                MessageBox.Show("Username cannot be blank !");
                txtUname.Focus();
            }
            else if (txtOpass.Text == "")
            {
                MessageBox.Show("Fill the old Password !");
                txtOpass.Focus();
            }
            else if (txtNpass.Text == "")
            {
                MessageBox.Show("Enter New Password !");
                txtNpass.Focus();
            }
            else
            {
            
                    obj.connect();
                    obj.com.CommandText = "select * from tblLogin where Username='"+txtUname.Text+"' and Password='"+txtOpass.Text+"'";
                    obj.dr = obj.com.ExecuteReader();
                    if (obj.dr.Read())
                    {
                        obj.dr.Close();
                        obj.com.CommandText = "update tblLogin set Password='" + txtNpass.Text + "' where Username='" + txtUname.Text + "'";
                        obj.com.ExecuteNonQuery();
                        MessageBox.Show("Password Changed Successfully !!");
                        txtUname.Clear();
                        txtNpass.Clear();
                        txtOpass.Clear();
                        txtUname.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Username/Password is Invalid !!");
                        txtUname.Clear();
                        txtNpass.Clear();
                        txtOpass.Clear();
                        txtUname.Focus();
                    }
                    obj.con.Close();
            
             
            }
        }

        private void txtNpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
