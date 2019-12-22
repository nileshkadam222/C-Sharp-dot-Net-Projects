using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace SangliTradingCompany
{
    public partial class Form1 : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
       
       
        public Form1()
        {
            con = new SqlConnection(c);
            Thread t = new Thread(new ThreadStart(ProgressScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void ProgressScreen()
        {
            Application.Run(new ProgressScreen());
        }
        private void validTextChar(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {
                //Not Allowing Numbers
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3', 
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }
        private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
        {
            for (int i = 0; i < UnallowedCharacters.Length; i++)
                if (T.Contains(UnallowedCharacters[i]))
                    return true;

            return false;
        }

 
       

        private void login_btn_Click(object sender, EventArgs e)
        {
          

              if ((username_txt.Text != "") && (passwd_txt.Text != ""))
            {
               
                
                string q = "select * from registerdata where Username = @Username and Password = @Password ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Username", this.username_txt.Text);
                cmd.Parameters.AddWithValue("@Password", this.passwd_txt.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        if (MessageBox.Show("Login Successfully Done", "sucess", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            MDIParent1 c = new MDIParent1();
                            c.Show();
                            this.Hide();
                        }

                    }
                }
                if (dr.HasRows == false)
                { MessageBox.Show("Access Denied, password username mismatched");
                username_txt.Clear();
                passwd_txt.Clear();
                }
            }
            else { MessageBox.Show("Enter username and password"); }
              con.Close();
        }

       

      
        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.ExitThread();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        


        }


         

        

      
    }
