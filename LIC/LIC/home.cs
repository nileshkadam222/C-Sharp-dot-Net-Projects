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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void PlanDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

       

        private void nameChangeCorrectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Service1 s1 = new Service1();
            s1.Show();
            this.Hide();
        }

        private void addressChangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Service2 s2 = new Service2();
            s2.Show();
            this.Hide();
        }

        private void maturityClaimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Claim1 c1 = new Claim1();
            c1.Show();
            this.Hide();
        }

        private void claimSurrenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Claim3 c3 = new Claim3();
            c3.Show();
            //this.Hide();
        }

        private void deathClaimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Claim2 c2 = new Claim2();
            c2.Show();
            this.Hide();
        }

     

        private void customerServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client1 c = new Client1();
            c.Show();

        }

      
        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nameChangeCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service1 s1 = new Service1();
            s1.Show();
            //this.Hide();
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addressChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service2 s2 = new Service2();
            s2.Show();
            //this.Hide();
        }

        private void maturityClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Claim1 c1 = new Claim1();
            c1.Show();
            //this.Hide();
        }

        private void deathClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Claim2 c2 = new Claim2();
            c2.Show();
            //this.Hide();
        }

        private void claimSurrenderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Claim3 c3 = new Claim3();
            c3.Show();
            //this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void policyPaymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaction1 t1 = new transaction1();
            t1.Show();

        }
        
        //private void modeOfPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Queries2 q = new Queries2();
        //    q.Show();
        //}

        private void informationThroughPolicyNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queries3 q = new Queries3();
            q.Show();
        }

        private void customerPolicyHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queries1 q = new Queries1();
            q.Show();
        }

      
       

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void policyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client2 c = new Client2();
            c.Show();

        }

       

        private void clientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client1 c = new Client1();
            c.Show();
            //c.textBox1.Text += c.textBox1.Text+1;
        }

        private void planDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Plan_Details pd = new Plan_Details();
            pd.Show();

        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "MMM ddd d HH:mm yyyy";
            label1.Text = time.ToString(format);
        }

        private void commissionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction2 t = new Transaction2();
            t.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            r.Show();
        }

        private void paymentTermwiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
               f.Show();
        }

        private void commissionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

       
       
    }
}
