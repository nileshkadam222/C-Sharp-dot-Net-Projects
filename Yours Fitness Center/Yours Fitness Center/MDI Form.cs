using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yours_Fitness_Center
{
    public partial class MDI_Form : Form
    {
        public MDI_Form()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void courseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course_Details ob = new Course_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void staffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_Details ob = new Staff_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machin_Details ob = new Machin_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void vendorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendor_Details ob = new Vendor_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Details ob = new Customer_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void purchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Details ob = new Purchase_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void attendanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance_Details ob = new Attendance_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void salaryDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Details ob = new Salary_Details();
            ob.MdiParent = this;
            ob.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course ob = new Course();
            ob.MdiParent = this;
            ob.Show();
            
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Staff ob = new Search_Staff();
            ob.MdiParent = this;
            ob.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Customer ob = new Search_Customer();
            ob.MdiParent = this;
            ob.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machine ob = new Machine();
            ob.MdiParent = this;
            ob.Show();
        }

        private void courseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepCOurse ob = new RepCOurse();
            ob.MdiParent = this;
            ob.Show();
        }

        private void staffDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepoStaff ob = new RepoStaff();
            ob.MdiParent = this;
            ob.Show();
        }
    }
} 
