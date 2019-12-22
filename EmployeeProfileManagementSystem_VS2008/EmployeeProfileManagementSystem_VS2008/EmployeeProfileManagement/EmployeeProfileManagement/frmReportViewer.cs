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
using System.Data.SqlClient;

namespace EmployeeProfileManagement
{
    public partial class frmReportViewer : Form
    {
        connectionClass obj = new connectionClass();
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            
        
        }

        public void selectReport(String reportname)
        {
            string path = Application.StartupPath;

            crystalReportViewer1.ReportSource = path + "\\Reports\\" + reportname + ".rpt";
        }

        public void View_Report(string Query, string CRReportName)
{



	string reppath = null;
	reppath = "";

    obj.connect();
	SqlCommand cmd = new SqlCommand(Query, obj.con);
	SqlDataReader dr = default(SqlDataReader);
	dr = cmd.ExecuteReader();

	DataTable dt = new DataTable();
	dt.Load(dr);
	dr.Close();
	CrystalDecisions.CrystalReports.Engine.ReportDocument rd = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
	string path = Application.StartupPath;

	//Dim substring As String = path.Substring(path.IndexOf("\\") - 2, path.IndexOf("bin") - 1)
	string substring = path;


	if ((CRReportName == "Employee")) {
		reppath = substring + "\\\\Report\\\\" + CRReportName + ".rpt";



	} 




	






	TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
	TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
	ConnectionInfo crConnectionInfo = new ConnectionInfo();


	Tables CrTables = default(Tables);

	rd.Load(reppath);
	crConnectionInfo.ServerName = ".";
	crConnectionInfo.DatabaseName = "EPM";
	crConnectionInfo.IntegratedSecurity = true;

	rd.SetDataSource(dt);
	CrTables = rd.Database.Tables;

	//CrystalDecisions.CrystalReports.Engine.Table CrTable = default(CrystalDecisions.CrystalReports.Engine.Table);




	foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables) {
		crtableLogoninfo = CrTable.LogOnInfo;
		crtableLogoninfo.ConnectionInfo = crConnectionInfo;
		CrTable.ApplyLogOnInfo(crtableLogoninfo);


	}
	crystalReportViewer1.Refresh();
	crystalReportViewer1.ReportSource = rd;
}


        public void reportDepartmentWise(string department)
        {

            ReportDocument cryRpt = new ReportDocument();
            string path = Application.StartupPath;
            cryRpt.Load(path + "\\Reports\\" + "rptDepartmentWise.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = department;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["department"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        public void salarySlip(string slipno)
        {

            ReportDocument cryRpt = new ReportDocument();
            string path = Application.StartupPath;
            cryRpt.Load(path + "\\Reports\\" + "rptSalarySlip.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = slipno;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["slipno"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }


        public void reportDesignationWise(string department)
        {

            ReportDocument cryRpt = new ReportDocument();
            string path = Application.StartupPath;
            cryRpt.Load(path + "\\Reports\\" + "rptDesignationWise.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = department;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["designation"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }
    }
}
