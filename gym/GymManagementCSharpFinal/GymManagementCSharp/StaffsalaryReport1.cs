using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GymManagementCSharp
{
    public partial class StaffsalaryReport1 : Form
    {
        public StaffsalaryReport1()
        {
            InitializeComponent();
        }

        private void StaffsalaryReport1_Load(object sender, EventArgs e)
        {
            ReportDocument crystalReport = new ReportDocument();
            //crystalReport.Load(Server.MapPath("CrystalReport.rpt"));
            crystalReport.Load("D:/Projects/GymManagementC#/GymManagementCSharpFinal/GymManagementCSharp/Staffsalaryreport.rpt");
            // crystalReport.SetDatabaseLogon
            //    ("amit", "password", @"AMIT\SQLEXPRESS", "TestDB");
            crystalReportViewer1.ReportSource = crystalReport;

        }
    }
}
