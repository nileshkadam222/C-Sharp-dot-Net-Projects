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
    public partial class Login : Form
    {
        bool allow;
        DataConnection dc = new DataConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dc.conn.Close ();
            DateTime tday = DateTime.Today;
            dc.cmd.CommandText = " select * from login where username = '" + txtUser.Text + "' and password ='" + txtPass.Text + "'";
            dc.conn.Open();
            dc.reader = dc.cmd.ExecuteReader();
            
            if (dc.reader.Read() == true)
            {
                MessageBox.Show("Welcome to Gym management System ", "Gym Management System");

                String user = "Current User:" + txtUser.Text;
                String userid = txtUser.Text;
                String pass = txtPass .Text ;
                this.Hide();
                dc.reader.Close();
                dc.conn.Close();
                MDI  m = new MDI();
                m.Show();
                if (userid != "rohit" && pass != "rohit123")
                {
                    m.StaffToolStripMenuItem.Enabled = false;
                    m.MasterToolStripMenuItem.Enabled = false;
                    m.AdminToolStripMenuItem1.Enabled = false;
 allow = false;
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password ", "Book Shop Management System");
                txtUser.Focus();
                dc.conn.Close();
                dc.reader.Close();
                return;
            }
            txtUser.Clear();
            txtPass.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
