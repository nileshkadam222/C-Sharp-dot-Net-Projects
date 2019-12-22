using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SangliTradingCompany
{
    public partial class EmployeeAttendenceReports : Form
    {
        public EmployeeAttendenceReports()
        {
            InitializeComponent();
        }

        private void EmployeeAttendenceReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Attendence' table. You can move, or remove it, as needed.
            this.AttendenceTableAdapter.Fill(this.Database1DataSet.Attendence);

            this.reportViewer1.RefreshReport();
        }
    }
}
