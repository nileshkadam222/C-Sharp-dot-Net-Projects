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


namespace ComputerManagmentSystem
{
	public partial class StaffDetail
	{
		public StaffDetail()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static StaffDetail defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static StaffDetail Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new StaffDetail();
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
		SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=True;database=db_CIMS");
		public void loadStaff()
		{
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select Staff_NAME from tbl_Staff", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboStaff.Items.Add(rd[0]);
				
			}
			con.Close();
			
			
		}
		
		public void StaffDetail_Load(System.Object sender, System.EventArgs e)
		{
			
			
			loadStaff();
			btnUpdate.Visible = false;
			btnDelete.Visible = false;
			pnlSearch.Visible = false;
			
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [ID]=Staff_No,[Name]=Staff_NAME,[Qualification]=Staff_QUALIFICATION,[Contact Number]=Staff_PHONE from tbl_Staff", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			
			
		}
		public void clear()
		{
			
			txtName.Clear();
			txtAddress.Clear();
			txtEmailId.Clear();
			txtExperience.Clear();
			txtPhoneNo.Clear();
			txtQualification.Clear();
			dtpDob.ResetText();
			
			
		}
		public void increment()
		{
			
			
		}
		
		public void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			clear();
			
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			
			if (txtEmailId.Text == "" || txtName.Text == "" || txtAddress.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_Staff(Staff_No,Staff_NAME,Staff_DOB,Staff_QUALIFICATION,Staff_EXPERIENCE,Staff_EMAILID,Staff_PHONE,Staff_ADDRESS) values(\'" + txtStaffNo.Text + "\',\'" + txtName.Text + "\',\'" + dtpDob.Value.ToString() + "\',\'" + txtQualification.Text + "\',\'" + txtExperience.Text + "\',\'" + txtEmailId.Text + "\',\'" + txtPhoneNo.Text + "\',\'" + txtAddress.Text + "\')";
				
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				clear();
				
				
				
				
			}
			
			
		}
		
		public void btnSearchUpdate_Click(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = true;
			btnUpdate.Visible = true;
			btnDelete.Visible = true;
			btnSave.Visible = false;
			btnClear.Visible = false;
			pnlStaffDetails.Visible = false;
		}
		
		public void dgvSearch_CellMouseDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			
			pnlStaffDetails.Visible = true;
			con.Open();
			
			string str = dgvSearch.CurrentRow.Cells["ID"].Value.ToString();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_Staff where Staff_No=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				txtStaffNo.Text = (string) (rd["Staff_No"].ToString());
				txtName.Text = (string) (rd["Staff_NAME"].ToString());
				dtpDob.Text = (string) (rd["Staff_DOB"].ToString());
				txtQualification.Text = (string) (rd["Staff_QUALIFICATION"].ToString());
				txtExperience.Text = (string) (rd["Staff_EXPERIENCE"].ToString());
				txtEmailId.Text = (string) (rd["Staff_EMAILID"].ToString());
				txtPhoneNo.Text = (string) (rd["Staff_PHONE"].ToString());
				txtAddress.Text = (string) (rd["Staff_ADDRESS"].ToString());
				
				
			}
			rd.Close();
			con.Close();
			
			
			
			pnlSearch.Visible = false;
			pnlStaffDetails.Visible = true;
			
			
		}
		
		public void cboStaff_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			
			dgvSearch.Columns.Clear();
			
			con.Open();
			SqlDataAdapter adapter = new SqlDataAdapter("select [ID]=Staff_No,[Name]=Staff_NAME,[Qualification]=Staff_QUALIFICATION,[Contact Number]=Staff_PHONE from tbl_Staff where Staff_NAME=\'" + cboStaff.Text + "\'", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			con.Close();
			
			
			
			
		}
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			
			con.Open();
			
			string s = "update tbl_Staff set Staff_NAME=\'" + txtName.Text + "\',Staff_DOB=\'" + dtpDob.Value.ToString() + "\',Staff_QUALIFICATION=\'" + txtQualification.Text + "\',Staff_EXPERIENCE=\'" + txtExperience.Text + "\',Staff_EMAILID=\'" + txtEmailId.Text + "\',Staff_PHONE=\'" + txtPhoneNo.Text + "\',Staff_ADDRESS=\'" + txtAddress.Text + "\' where Staff_No=\'" + txtStaffNo.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Updated");
			con.Close();
			this.Close();
			
			
			
			
			
		}
		
		public void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			
			
			con.Open();
			
			string s = "delete from tbl_Staff where Staff_No=\'" + txtStaffNo.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s, con);
			cmd2.ExecuteNonQuery();
			//Else
			MessageBox.Show("Record Deleted");
			this.Close();
			
			con.Close();
			
			
			
		}
		
		public void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = false;
			pnlStaffDetails.Visible = true;
			
		}
		
		public void txtPhoneNo_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 48) || (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 57))
			{
				e.Handled = true;
			}
			if (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) == 8)
			{
				e.Handled = false;
			}
		}
	}
}
