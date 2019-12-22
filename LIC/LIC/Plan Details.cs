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
    public partial class Plan_Details : Form
    {
        public Plan_Details()
        {
            InitializeComponent();
        }

        private void Plan_Details_Load(object sender, EventArgs e)
        {

        }

      

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Jeevan_Anand ja = new Jeevan_Anand();
            ja.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            JeevanSaral js = new JeevanSaral();
            js.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Jeevan_Anand ja = new Jeevan_Anand();
            ja.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JeevanSaral js = new JeevanSaral();
            js.Show();

        }
    }
}
