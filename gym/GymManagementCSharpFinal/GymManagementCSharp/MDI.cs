using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementCSharp
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEnquiry  ch = new NewEnquiry();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void AttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance ch = new Attendance ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void NewEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemberEnroll ch = new MemberEnroll ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void MeasurementToolStripMenuItem_Click(object sender, EventArgs e)
        {
       Measurements      ch = new Measurements ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_User  ch = new New_User ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void NewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffDetails  ch = new StaffDetails  ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void GymFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_us  ch = new About_us ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void staffProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffProfile  ch = new StaffProfile ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void StaffSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffsalaryReport1  ch = new StaffsalaryReport1 ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void AccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MembersMasterReport  ch = new MembersMasterReport ();
            ch.MdiParent = Form.ActiveForm;
            ch.Show();
       
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
