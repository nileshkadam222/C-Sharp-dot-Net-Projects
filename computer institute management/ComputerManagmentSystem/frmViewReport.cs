using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;


namespace ComputerManagmentSystem
{
	public partial class frmViewReport
	{
		public frmViewReport()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=True;database=db_CIMS");
		
		
		public void CrystalReportViewer1_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		public void View_Report(string Query, string CRReportName)
		{
			
			
			//Dim myFile As StreamReader = New System.IO.StreamReader("c:\cont")
			//Dim str1 As String = myFile.ReadToEnd()
			//Dim str As String() = str1.Split(New Char() {";"c})
			
			
			string reppath;
			reppath = "";
			
			con.Open();
			SqlCommand cmd = new SqlCommand(Query, con);
			SqlDataReader dr;
			dr = cmd.ExecuteReader();
			
			DataTable dt = new DataTable();
			dt.Load(dr);
			dr.Close();
			CrystalDecisions.CrystalReports.Engine.ReportDocument rd = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			string path = Application.StartupPath.ToString();
			
			//Dim substring As String = path.Substring(path.IndexOf("\\") - 2, path.IndexOf("bin") - 1)
			string substring = path;
			
			if (CRReportName == "Bill")
			{
				
				reppath = substring + "\\\\Report\\\\" + CRReportName + ".rpt";
				
				
			}
			else if (CRReportName == "Course")
			{
				
				reppath = substring + "\\\\Report\\\\" + CRReportName + ".rpt";
				
				
				
			}
			else if (CRReportName == "Faculty")
			{
				
				reppath = substring + "\\\\Report\\\\" + CRReportName + ".rpt";
				
				
			}
			else if (CRReportName == "Fees")
			{
				
				reppath = substring + "\\\\Report\\\\" + CRReportName + ".rpt";
				
				
			}
			else if (CRReportName == "Student")
			{
				
				reppath = substring + "\\\\Report\\\\" + CRReportName + ".rpt";
				
				
				
			}
			else if (CRReportName == "Purchase")
			{
				
				reppath = substring + "\\\\Report\\\\" + CRReportName + ".rpt";
				
				
				
			}
			else if (! System.IO.File.Exists(reppath))
			{
				
				
				MessageBox.Show("File Does not exist");
				
				
				
				
				
			}
			
			
			
			
			
			
			TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
			TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
			ConnectionInfo crConnectionInfo = new ConnectionInfo();
			
			
			Tables CrTables;
			
			rd.Load(reppath);
			crConnectionInfo.ServerName = ".";
			crConnectionInfo.DatabaseName = "db_CIMS";
			crConnectionInfo.IntegratedSecurity = true;
			
			rd.SetDataSource(dt);
			CrTables = rd.Database.Tables;
			
			
			
			
			
			foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
			{
				
				crtableLogoninfo = CrTable.LogOnInfo;
				crtableLogoninfo.ConnectionInfo = crConnectionInfo;
				CrTable.ApplyLogOnInfo(crtableLogoninfo);
				
				
			}
			
			
			
			
			CrystalReportViewer1.Refresh();
			CrystalReportViewer1.ReportSource = rd;
			
			
			
			
			
			
			
			
			
			
			
		}
	}
}
