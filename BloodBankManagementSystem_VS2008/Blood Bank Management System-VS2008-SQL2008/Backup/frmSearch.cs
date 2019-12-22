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





namespace Blood_Bank_Management_System
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
		
		SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=True;database=db_BloodBank");
		
		
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
				SqlCommand cmd = new SqlCommand("select Donor_Name from tbl_DonorDetails", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				cboValue.Items.Add("All");
				while (rd.Read())
				{
					cboValue.Items.Add(rd["Donor_Name"]);
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
				SqlCommand cmd = new SqlCommand("select Recipient_Name from tbl_RecipientDetails", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				cboValue.Items.Add("All");
				while (rd.Read())
				{
					cboValue.Items.Add(rd["Recipient_Name"]);
				}
				rd.Close();
				
			}
			
			
			if (cboSearchBy.SelectedIndex == 2)
			{
				cboValue.Items.Clear();
				cboValue.Enabled = true;
				dtpFromDate.Enabled = true;
				dtpToDate.Enabled = true;
				dtpFromDate.Checked = false;
				dtpToDate.Checked = false;
				con.Close();
				
				con.Open();
				SqlCommand cmd = new SqlCommand("select Donor_Name from tbl_Purchases", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				cboValue.Items.Add("All");
				while (rd.Read())
				{
					cboValue.Items.Add(rd["Donor_Name"]);
				}
				rd.Close();
				
			}
			
			if (cboSearchBy.SelectedIndex == 3)
			{
				cboValue.Items.Clear();
				cboValue.Enabled = true;
				dtpFromDate.Enabled = true;
				dtpToDate.Enabled = true;
				dtpFromDate.Checked = false;
				dtpToDate.Checked = false;
				con.Close();
				
				con.Open();
				SqlCommand cmd = new SqlCommand("select Patient_Name from tbl_Sales", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				cboValue.Items.Add("All");
				while (rd.Read())
				{
					cboValue.Items.Add(rd["Patient_Name"]);
				}
				rd.Close();
				
			}
			
			if (cboSearchBy.SelectedIndex == 4)
			{
				cboValue.Items.Clear();
				cboValue.Enabled = false;
				dtpFromDate.Enabled = false;
				dtpToDate.Enabled = false;
				dtpFromDate.Checked = false;
				dtpToDate.Checked = false;
				
				
				
				
			}
		}
		
		public void frmSearch_Load(System.Object sender, System.EventArgs e)
		{
			
			dtpFromDate.Enabled = false;
			dtpToDate.Enabled = false;
			cboValue.Enabled = false;
			
		}
		
		public void btnViewReport_Click(System.Object sender, System.EventArgs e)
		{
			
			dgvSearch.Columns.Clear();
			
			if (cboSearchBy.SelectedIndex == 3)
			{
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
					
					var adapter = new SqlDataAdapter("select [Donor ID]=Donor_ID,[Name]=Donor_Name,[Gender]=Donor_Gender,[Address]=Donor_Address,[Contact]=Donor_Contact,[Blood Group]=Donor_Group,[Donor Type]=Donor_Type,[Hemoglobin EST]=Donor_HemoglobinEST,[HIV Status]=Donor_HIVStatus,[Physical Exam]=Donor_PhysicalExam from tbl_DonorDetails", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				else
				{
					
					
					var adapter = new SqlDataAdapter("select [Donor ID]=Donor_ID,[Name]=Donor_Name,[Gender]=Donor_Gender,[Address]=Donor_Address,[Contact]=Donor_Contact,[Blood Group]=Donor_Group,[Donor Type]=Donor_Type,[Hemoglobin EST]=Donor_HemoglobinEST,[HIV Status]=Donor_HIVStatus,[Physical Exam]=Donor_PhysicalExam from tbl_DonorDetails where Donor_Name=\'" + cboValue.Text + "\'", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				
				
			}
			
			
			if (cboSearchBy.SelectedIndex == 1)
			{
				
				if (cboValue.SelectedIndex == 0)
				{
					
					var adapter = new SqlDataAdapter("select [Recipient ID]=Recipient_ID,[Name]=Recipient_Name,[Gender]=Recipient_Gender,[Age]=Recipient_Age,[Address]=Recipient_Address,[Contact No]=Recipient_Contact,[Blood Group]=Recipient_BloodGroup from tbl_RecipientDetails", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				else
				{
					
					
					var adapter = new SqlDataAdapter("select [Recipient ID]=Recipient_ID,[Name]=Recipient_Name,[Gender]=Recipient_Gender,[Age]=Recipient_Age,[Address]=Recipient_Address,[Contact No]=Recipient_Contact,[Blood Group]=Recipient_BloodGroup from tbl_RecipientDetails where Recipient_Name=\'" + cboValue.Text + "\'", con);
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					dgvSearch.DataSource = ds.Tables[0];
					
				}
				
				
			}
			
			
			
			
			if (cboSearchBy.SelectedIndex == 2)
			{
				
				if (dtpFromDate.Checked == true && dtpToDate.Checked == true)
				{
					
					if (dtpFromDate.Value <= dtpToDate.Value)
					{
						
						if (cboValue.SelectedIndex == 0)
						{
							
							var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases where Purchase_Date BETWEEN \'" + dtpFromDate.Value + "\' AND \'" + dtpToDate.Value + "\'", con);
							DataSet ds = new DataSet();
							adapter.Fill(ds);
							dgvSearch.DataSource = ds.Tables[0];
							
						}
						else
						{
							
							var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases where Donor_Name=\'" + cboValue.Text + "\' and Purchase_Date BETWEEN \'" + dtpFromDate.Value + "\' AND \'" + dtpToDate.Value + "\'", con);
							DataSet ds = new DataSet();
							adapter.Fill(ds);
							dgvSearch.DataSource = ds.Tables[0];
							
						}
						
						
					}
					
					
				}
				else
				{
					
					if (cboValue.SelectedIndex == 0)
					{
						
						var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases", con);
						DataSet ds = new DataSet();
						adapter.Fill(ds);
						dgvSearch.DataSource = ds.Tables[0];
						
					}
					else
					{
						
						var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date,[Blood Group]=Blood_Group,[Donor Name]=Donor_Name,[Quantity]=Purchase_Quantity,[Blood Bag No]=Blood_BagNo,[Expiry Date]=Blood_ExpiryDate from tbl_Purchases where Donor_Name=\'" + cboValue.Text + "\'", con);
						DataSet ds = new DataSet();
						adapter.Fill(ds);
						dgvSearch.DataSource = ds.Tables[0];
						
					}
					
					
					
				}
				
			}
			
			
			
			
			if (cboSearchBy.SelectedIndex == 3)
			{
				
				if (dtpFromDate.Checked == true && dtpToDate.Checked == true)
				{
					
					if (dtpFromDate.Value <= dtpToDate.Value)
					{
						
						if (cboValue.SelectedIndex == 0)
						{
							
							var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales where Sales_Date BETWEEN \'" + dtpFromDate.Value + "\' AND \'" + dtpToDate.Value + "\'", con);
							DataSet ds = new DataSet();
							adapter.Fill(ds);
							dgvSearch.DataSource = ds.Tables[0];
							
						}
						else
						{
							
							var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales where Patient_Name=\'" + cboValue.Text + "\' and Sales_Date BETWEEN \'" + dtpFromDate.Value + "\' AND \'" + dtpToDate.Value + "\'", con);
							DataSet ds = new DataSet();
							adapter.Fill(ds);
							dgvSearch.DataSource = ds.Tables[0];
							
						}
						
						
					}
					
					
				}
				else
				{
					
					if (cboValue.SelectedIndex == 0)
					{
						
						var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales", con);
						DataSet ds = new DataSet();
						adapter.Fill(ds);
						dgvSearch.DataSource = ds.Tables[0];
						
					}
					else
					{
						var adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Sales Date]=Sales_Date,[Recipient Name]=Patient_Name,[Blood Group]=Blood_Group,[Quantity]=Sales_Quantity,[Expiry Date]=Blood_ExpiryDate,[Bag No]=Sales_BagNo from tbl_Sales where Patient_Name=\'" + cboValue.Text + "\'", con);
						DataSet ds = new DataSet();
						adapter.Fill(ds);
						dgvSearch.DataSource = ds.Tables[0];
						
						
					}
					
					
					
				}
				
			}
			
			
			
			
			if (cboSearchBy.SelectedIndex == 4)
			{
				
				
				SqlDataAdapter adpter = new SqlDataAdapter("select [Blood Group]=Blood_Group,[Quantity]=Blood_Quantity from tbl_Stock", con);
				DataSet ds1 = new DataSet();
				adpter.Fill(ds1);
				dgvSearch.DataSource = ds1.Tables[0];
				
				
				int i;
				i = 0;
				while (i < dgvSearch.Rows.Count - 1)
				{
					
					if (int.Parse(dgvSearch.Rows[i].Cells[1].Value.ToString()) < 60 )
					{
						
						dgvSearch.Rows[i].DefaultCellStyle.BackColor = Color.Red;
						
					}
					
					
					i++;
					
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
				
				if (cboSearchBy.SelectedIndex == 3)
				{
					
					string str2;
					str2 = "";
					str2 = dgvSearch.CurrentRow.Cells["Serial No"].Value.ToString();
					
					
					frmViewReport obj = new frmViewReport();
					obj.View_Report("select * from tbl_Sales where Serial_No=\'" + str2 + "\'", "Bill");
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
