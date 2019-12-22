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
    public partial class frmUserMdi : Form
    {
        public frmUserMdi()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure You Want to Logout ?", "Employee Profile Management", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmLogin fl = new frmLogin();
                fl.Show();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEmployee fae = new frmAddEmployee();
            fae.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateEmployee fue = new frmUpdateEmployee();
            fue.ShowDialog();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendence obj = new frmAttendence();
            obj.ShowDialog();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmployeeSearch obj = new frmEmployeeSearch();
            obj.ShowDialog();
        }

        private void departmentWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportDepartmentWise obj = new frmReportDepartmentWise();
            obj.ShowDialog();
        }

        private void designationWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportDesignationWise obj = new frmReportDesignationWise();
            obj.ShowDialog();
        }

        private void salarySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReprintSalarySlip obj = new frmReprintSalarySlip();
            obj.ShowDialog();
        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReportViewer obj = new frmReportViewer();
            obj.selectReport("rptEmployee");
            obj.Show();
        }

        private void salarySlipDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer obj = new frmReportViewer();
            obj.selectReport("rptSalarySlipDetails");
            obj.Show();
        }

       
    }
}
