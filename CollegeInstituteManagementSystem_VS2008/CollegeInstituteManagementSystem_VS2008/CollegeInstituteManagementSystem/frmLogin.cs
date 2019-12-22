using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeInstituteManagementSystem
{
    public partial class frmLogin : Form
    {
        connectionClass obj = new connectionClass();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select * from tblLogin where Username='"+txtUsername.Text+"' and Password='"+txtPassword.Text+"'";
                obj.dr = obj.com.ExecuteReader();
                if (obj.dr.Read())
                {
                    MessageBox.Show("Welcom to College Institute !!!!");
                    frmHome fh = new frmHome();
                    fh.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login !");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch
            {
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
