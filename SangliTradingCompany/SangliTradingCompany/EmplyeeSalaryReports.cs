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
    public partial class EmplyeeSalaryReports : Form
    {
        public EmplyeeSalaryReports()
        {
            InitializeComponent();
        }

        private void EmplyeeSalaryReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.EmployeeSalary_Table' table. You can move, or remove it, as needed.
            this.EmployeeSalary_TableTableAdapter.Fill(this.Database1DataSet.EmployeeSalary_Table);

            this.reportViewer1.RefreshReport();
        }
    }
}
