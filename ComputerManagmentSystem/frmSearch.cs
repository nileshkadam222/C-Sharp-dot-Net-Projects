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
using System.Data.SqlClient;
using excel = Microsoft.Office.Interop.Excel;



namespace ComputerManagmentSystem
{
	public partial class frmSearch
	{
		public frmSearch()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSearch defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSearch Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSearch();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion

        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=D:\\READY PROJECTS\\COMPUTERMANAGMENTSYSTEM\\DB_CIMS.MDF;Integrated Security=True");
		
		public void frmSearch_Load(System.Object sender, System.EventArgs e)
		{
			
			dtpFromDate.Enabled = false;
			dtpToDate.Enabled = false;
			cboValue.Enabled = false;
			
			
			
			
		}
		
		public void cboSearchBy_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			
			if (cboSearchBy.SelectedIndex == 0)
			{
				cboValue.Items.Clear();
				cboValue.Enabled = true;
				dtpFromDate.Enabled = false;
				dtpToDate.Enabled = false;
				dtpFromDate.Checked = false;
				dtpToDate.Checked = false;
				con.Close();
				
				con.Open();
				SqlCommand cmd = new SqlCommand("select Student_NAME from tbl_Student", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				cboValue.Items.Add("All");
				while (rd.Read())
				{
					cboValue.Items.Add(rd["Student_NAME"]);
				}
				rd.Close();
				
			}
			
			
			if (cboSearchBy.SelectedIndex == 1)
			{
				cboValue.Items.Clear();
				cboValue.Enabled = true;
				dtpFromDate.Enabled = false;
				dtpToDate.Enabled = false;
				dtpFromDate.Checked = false;
				dtpToDate.Checked = false;
				con.Close();
				
				con.Open();
				SqlCommand cmd = new SqlCommand("select COURSE_NAME from tbl_Course", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				cboValue.Items.Add("All");
				while (rd.Read())
				{
					cboValue.Items.Add(rd["COURSE_NAME"]);
				}
				rd.Close();
				
			}
			
			
			if (cboSearchBy.SelectedIndex == 2)
			{
				cboValue.Items.Clear();
				cboValue.Enabled = true;
				dtpFromDate.Enabled = false;
				dtpToDate.Enabled = false;
				dtpFromDate.Checked = false;
				dtpToDate.Checked = false;
				con.Close();
				
				con.Open();
				SqlCommand cmd = new SqlCommand("select Staff_NAME from tbl_Staff", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				cboValue.Items.Add("All");
				while (rd.Read())
				{
					cboValue.Items.Add(rd["Staff_NAME"]);
				}
				rd.Close();
				
			}
			
			
			
		}
		
		public void btnViewReport_Click(System.Object sender, System.EventArgs e)
		{
			
			dgvSearch.Columns.Clear();
			
			if (cboSearchBy.SelectedIndex == 0)
			{
				
				
				dgvSearch.Columns.Clear();
				
				
				DataGridViewButtonColumn btnReport = new DataGridViewButtonColumn();
				btnReport.Name = "Report";
				btnReport.HeaderText = "Report";
				btnReport.Text = "View";
				btnReport.Width = 50;
				btnReport.UseColumnTextForButtonValue = true;
				dgvSearch.Columns.Add(btnReport);
				
				
			}
			
			
			
			if (cboSearchBy.SelectedIndex == 0)
			{
				
				if (cboValue.SelectedIndex == 0)
				{
					
					
					var adapter = new SqlDataAdapter("select [Roll No]=Student_ROLLNO,[Name]=Student_NAME,[Father\'s Name]=Student_FNAME,[Mother\'s Name]=Student_MNAME,[Husband\'s Name]=Student_HNAME,[Address]=Student_ADDRESS,[Contact No]=Student_PHONE,[Qualification]=Student_QUALIFICATION,[Gender]=Student_GENDER,[DOB]=Student_DOB,[E-Mail]=Student_EMAIL,[Occupation]=Student_OCCUPATION,[Course Name]=Student_CNAME,[Extra Knowledge]=Student_KNOWLEDGE,[Fees]=Student_TOTALFEES from tbl_Student", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				else
				{
					
					var adapter = new SqlDataAdapter("select [Roll No]=Student_ROLLNO,[Name]=Student_NAME,[Father\'s Name]=Student_FNAME,[Mother\'s Name]=Student_MNAME,[Husband\'s Name]=Student_HNAME,[Address]=Student_ADDRESS,[Contact No]=Student_PHONE,[Qualification]=Student_QUALIFICATION,[Gender]=Student_GENDER,[DOB]=Student_DOB,[E-Mail]=Student_EMAIL,[Occupation]=Student_OCCUPATION,[Course Name]=Student_CNAME,[Extra Knowledge]=Student_KNOWLEDGE,[Fees]=Student_TOTALFEES from tbl_Student where Student_NAME=\'" + cboValue.Text + "\'", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
					
				}
				
				
			}
			
			
			
			if (cboSearchBy.SelectedIndex == 1)
			{
				
				if (cboValue.SelectedIndex == 0)
				{
					
					var adapter = new SqlDataAdapter("select [Course No]=COURSE_No,[Course Name]=COURSE_NAME,[Duration]=COURSE_DURATION,[Fees]=COURSE_FEES,[Batchtiming]=COURSE_BATCHTIMING,[Faculty Name]=COURSE_FACULTY from tbl_Course", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				else
				{
					
					var adapter = new SqlDataAdapter("select [Course No]=COURSE_No,[Course Name]=COURSE_NAME,[Duration]=COURSE_DURATION,[Fees]=COURSE_FEES,[Batchtiming]=COURSE_BATCHTIMING,[Faculty Name]=COURSE_FACULTY from tbl_Course where COURSE_NAME=\'" + cboValue.Text + "\'", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				
				
				
			}
			
			if (cboSearchBy.SelectedIndex == 2)
			{
				
				if (cboValue.SelectedIndex == 0)
				{
					
					var adapter = new SqlDataAdapter("select [ID]=Staff_No,[Name]=Staff_NAME,[DOB]=Staff_DOB,[Qualification]=Staff_QUALIFICATION,[Experience]=Staff_EXPERIENCE,[Email ID]=Staff_EMAILID,[Contact No]=Staff_PHONE,[Address]=Staff_ADDRESS from tbl_Staff", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				else
				{
					
					var adapter = new SqlDataAdapter("select [ID]=Staff_No,[Name]=Staff_NAME,[DOB]=Staff_DOB,[Qualification]=Staff_QUALIFICATION,[Experience]=Staff_EXPERIENCE,[Email ID]=Staff_EMAILID,[Contact No]=Staff_PHONE,[Address]=Staff_ADDRESS from tbl_Staff where Staff_NAME=\'" + cboValue.Text + "\'", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				
				
				
			}
			
			
			
			
		}
		
		public void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		private void releaseObject(object obj)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
				obj = null;
			}
			catch (Exception)
			{
				obj = null;
			}
			finally
			{
				GC.Collect();
			}
		}
		
		public void btnExport_Click(System.Object sender, System.EventArgs e)
		{
			
			
			excel.Application xlApp;
			excel.Workbook xlWorkBook;
			excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;
			int i;
			int j;
			
			xlApp = new excel.ApplicationClass();
			xlWorkBook = xlApp.Workbooks.Add(misValue);
			xlWorkSheet =  (Microsoft.Office.Interop.Excel.Worksheet) (xlWorkBook.Sheets["sheet1"]);
			
			
			//foreach (DataGridViewColumn column in dgvSearch.Columns)
			
			//        xlworksheet.Cells[3, ColumnIndex + 1] = column.HeaderText
			//        ColumnIndex++
			//For Each DataGridViewColumn In dgvSearch.Columns
			
			
			//Next
			
			
			for (i = 0; i <= dgvSearch.RowCount - 2; i++)
			{
				for (j = 0; j <= dgvSearch.ColumnCount - 1; j++)
				{
					xlWorkSheet.Cells[i + 1, j + 1] = dgvSearch[j, i].Value.ToString();
				}
			}
			
			//xlWorkSheet.SaveAs("C:\vbexcel.xlsx")
			//xlWorkBook.Close()
			//xlApp.Quit()
			
			//xlWorkSheet.get_Range("A3", "EA3").Font.Bold = True
			xlWorkSheet.Cells.EntireColumn.ColumnWidth = 20;
			xlWorkSheet.Columns.AutoFit();
			xlWorkSheet.Columns.VerticalAlignment = excel.XlVAlign.xlVAlignCenter;
			xlApp.Visible = true;
			xlApp.UserControl = true;
			
			
			releaseObject(xlApp);
			releaseObject(xlWorkBook);
			releaseObject(xlWorkSheet);
			
			
			
			
			
			
		}
		
		public void dgvSearch_CellContentClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
			string str;
			str = "";
			str = dgvSearch.Columns[e.ColumnIndex].Name.ToString();
			
			if (str == "Report")
			{
				
				if (cboSearchBy.SelectedIndex == 0)
				{
					
					string str2;
					str2 = "";
					str2 = dgvSearch.CurrentRow.Cells["Roll No"].Value.ToString();
					
					
					frmViewReport obj = new frmViewReport();
					obj.View_Report("select * from tbl_Fee where Fee_ROLLNO=\'" + str2 + "\'", "Bill");
					obj.ShowDialog();
					
					
				}
				
				
			}
			else
			{
				
				MessageBox.Show("Please Click on View Button");
			}
		}
	}
}
