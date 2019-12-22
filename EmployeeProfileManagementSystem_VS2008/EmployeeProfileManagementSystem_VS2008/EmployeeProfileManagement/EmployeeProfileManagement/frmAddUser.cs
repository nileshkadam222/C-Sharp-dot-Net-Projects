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
    public partial class frmAddUser : Form
    {
        connectionClass obj = new connectionClass();
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username cannot be blank !");
                txtUsername.Focus();
            }
            else if (txtPass1.Text == "") 
            {
                MessageBox.Show("Password Cannot be blank !");
                txtPass1.Focus();
            }
            else if(txtPass2.Text=="")
            {
                MessageBox.Show("Confirm Password !");
                txtPass2.Focus();
            }
            else if (txtPass1.Text != txtPass2.Text)
            {
                MessageBox.Show("Confirm Password Failed !!");
                txtPass2.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText="insert into tblLogin values('"+txtUsername.Text+"','"+txtPass1.Text+"','"+comboBox1.Text+"')";
                    
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("User added !!");
                    txtUsername.Clear();
                    txtPass1.Clear();
                    txtPass2.Clear();
                    txtUsername.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                }
            }
        }
    }
}
