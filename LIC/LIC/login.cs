using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace LIC
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
       
        OleDbConnection con=new OleDbConnection();

        public bool Check()
        {
            con.ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\visual stdio\LIC\database\LIC.mdb";
            con.Open();
            DataTable dt=new DataTable();
            DataSet ds=new DataSet();
            ds.Tables.Add(dt);
            OleDbDataAdapter da=new OleDbDataAdapter("Select * from Login",con);
            da.Fill(dt);
            foreach(DataRow r in dt.Rows)
            {
                if(r[0].ToString()==textBox1.Text && r[1].ToString()==textBox2.Text)
                {
                    return true;
                }
            }
            con.Close();
            return false;
        }
           
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (Check() == true)
            {
               MessageBox.Show("Welcome you are logged in");
             
                
                    home h = new home();
                    h.Show();
                    this.Hide();
                   
                
               
            }
            else
            {
                MessageBox.Show("Sorry, your login information is not correct.Please try again.");
                textBox2.Text = "";
            }
          
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        

       
        }
    }


