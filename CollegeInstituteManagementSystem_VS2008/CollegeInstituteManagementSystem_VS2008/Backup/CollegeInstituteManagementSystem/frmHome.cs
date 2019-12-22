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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure you want to Logout???","College Institute Management System",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                frmLogin obj = new frmLogin();
                obj.Show();
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudentJunior ads = new frmAddStudentJunior();
            ads.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStudentJunior usj = new frmUpdateStudentJunior();
            usj.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddStudentSenior fas = new frmAddStudentSenior();
            fas.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateStudentSenior uss = new frmUpdateStudentSenior();
            uss.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddFaculty fad = new frmAddFaculty();
            fad.ShowDialog();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUpdateFaculty fuf = new frmUpdateFaculty();
            fuf.ShowDialog();
        }

        private void juniorReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReprintJuniorReceipt rjr = new frmReprintJuniorReceipt();
            rjr.ShowDialog();
        }

        private void seniorReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReprintSeniorReceipt rsr = new frmReprintSeniorReceipt();
            rsr.ShowDialog();
        }

        private void facultyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmFacultyReport ffr = new frmFacultyReport();
            ffr.ShowDialog();
        }

        private void juniorStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJuniorReport fjr = new frmJuniorReport();
            fjr.ShowDialog();
        }

        private void seniorStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeniorStudentReport fsr = new frmSeniorStudentReport();
            fsr.ShowDialog();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAddDepartment fad = new frmAddDepartment();
            fad.ShowDialog();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UpdateDepartment ud = new UpdateDepartment();
            ud.ShowDialog();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmAddClass fac = new frmAddClass();
            fac.ShowDialog();
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UpdateClass uc = new UpdateClass();
            uc.ShowDialog();
        }
    }
}
