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
    public partial class frmLogin : Form
    {
        connectionClass obj = new connectionClass();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "")
            {
                MessageBox.Show("Username Cannot be blank !!");
                txtUname.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be blank !!");
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblLogin where Username='"+txtUname.Text+"' and Password='"+txtPassword.Text+"'";
                    
                    obj.dr=obj.com.ExecuteReader();
                    if (obj.dr.Read())
                    {

                        string role = obj.dr[2].ToString();
                        if (role == "Administrator")
                        {
                            MessageBox.Show("Welcome, Administrator !!!", "Employee Profile Management");
                            this.Hide();
                            frmAdminMdi fam = new frmAdminMdi();
                            fam.Show();
                        }
                        else
                        {
                            MessageBox.Show("Welcome to Employee Profile Management !!", "Employee Profile Management");
                            this.Hide();
                            frmUserMdi fum = new frmUserMdi();
                            fum.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login !!");
                        txtUname.Clear();
                        txtPassword.Clear();
                        txtUname.Focus();
                    }
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
