using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIC
{
    public partial class Jeevan_Anand : Form
    {
        public Jeevan_Anand()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label2.Visible = true;
            label2.Show();
           
            

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client1 c=new Client1();
            c.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //label2.Text = " ";
            //label2.visible = false;
           label2.Hide();
           label4.Hide();
            label3.Visible = true;
            label3.Show();
        }

        
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Hide();
            label3.Hide();
            label4.Visible = true;
            label4.Show();
        }

       
      

      
        

        
    }
}