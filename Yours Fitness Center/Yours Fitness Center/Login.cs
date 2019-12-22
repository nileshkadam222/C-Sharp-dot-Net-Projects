using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Yours_Fitness_Center
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        private void Login_Load(object sender, EventArgs e)
        {
            conn.Open();
            query = new SqlCommand("Select User_Name from tbl_User", conn);
            reader = query.ExecuteReader();
            while (reader.Read())
            {
                cmbLogin.Items.Add(reader["User_Name"].ToString());
                cmbudelete.Items.Add(reader["User_Name"].ToString());
            }

            reader.Close();
            conn.Close();
              
        }

            
        private void cmbEnterYC_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        
        private void butLoginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butnCancelDeleteU_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbenterYchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String choice = cmbenterYchoice.SelectedItem.ToString();
            if (choice.Equals("Login"))
            {
                panAdduser.Visible = false;
                panel1.Visible = false;
                panelLogin.Visible = true;
            }
            else if (choice.Equals("Add New User"))
            {
                panelLogin.Visible = false;
                panel1.Visible = false;
                panAdduser.Visible = true;
            }
            else
            {
                panelLogin.Visible = false;
                panAdduser.Visible = false;
                panel1.Visible = true;
            }
        }

        private void butnLogin_Click(object sender, EventArgs e)
        {
            String user = cmbLogin.Text;
            String pass = textBLoginpass.Text;
            String U = null;
            String P = null;
            conn.Open();
            query = new SqlCommand("Select * from tbl_User where User_Name='" + cmbLogin.Text.Trim() + "'", conn);
            reader = query.ExecuteReader();
            while (reader.Read())
            {
                U = reader[0].ToString();
                P = reader[1].ToString();
            }
            conn.Close();
            if (user.Equals(U) && pass.Equals(P))
            {
                MessageBox.Show("Login successful");
                this.Close();
                MDI_Form m = new MDI_Form();
                m.Show();
            }
            else
            {
                MessageBox.Show("Password Mismatched...");
                textBLoginpass.Text = "";
                textBLoginpass.Focus();
                           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String User = cmbudelete.Text.Trim();
            String Password = null;
            query = new SqlCommand("Select * from tbl_User where User_Name='" + cmbudelete.Text.Trim() + "'", conn);
            reader = query.ExecuteReader();
            while (reader.Read())
            {
                User = reader[0].ToString();
                Password = reader[1].ToString();
            }
            reader.Close();
            if (User.Equals("") || Password.Equals(""))
                MessageBox.Show("FIll the Fields....");
            else
            {
                if (User.Equals(cmbudelete.Text.Trim()) && Password.Equals(txtpass.Text.Trim()))
                {
                    query = new SqlCommand("delete from tbl_User where User_Name='" + cmbudelete.Text.Trim() + "'", conn);
                    reader = query.ExecuteReader();
                    MessageBox.Show("User Remove Successfully..");
                    txtpass.Text = "";
                    cmbudelete.Text = "";
                }
                else
                {
                    MessageBox.Show("Password Mismatch...");
                    txtpass.Text = "";
                    txtpass.Focus();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void butnCancelAddU_Click(object sender, EventArgs e)
        {
            panAdduser.Visible = false;
        }

        private void butnAddUser_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                    conn.Open();
                    query = new SqlCommand("insert into tbl_User values('" + textBoxAddUserN.Text.Trim() + "','" + textBoxAddPassword.Text.Trim() + "')", conn);
                    reader = query.ExecuteReader();
                    MessageBox.Show("The User Is Added Successfully...");
                    textBoxAddUserN.Text = "";
                    textBoxAddPassword.Text = "";
                    reader.Close();
                conn.Close();               
                
            }
        }
    }
}
