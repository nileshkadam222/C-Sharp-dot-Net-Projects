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
    public partial class MembersMasterReport : Form
    {
        public MembersMasterReport()
        {
            InitializeComponent();
        }

        private void MembersMasterReport_Load(object sender, EventArgs e)
        {
            ReportDocument crystalReport = new ReportDocument();
            //crystalReport.Load(Server.MapPath("CrystalReport.rpt"));
            crystalReport.Load("D:/Projects/GymManagementC#/GymManagementCSharpFinal/GymManagementCSharp/MembersMasterRpt.rpt");
            // crystalReport.SetDatabaseLogon
            //    ("amit", "password", @"AMIT\SQLEXPRESS", "TestDB");
            crystalReportViewer1.ReportSource = crystalReport;

        }
    }
}
