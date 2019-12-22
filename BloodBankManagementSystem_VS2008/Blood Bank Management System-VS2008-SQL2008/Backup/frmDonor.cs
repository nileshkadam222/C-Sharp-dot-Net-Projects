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



namespace Blood_Bank_Management_System
{
	public partial class frmDonor
	{
		public frmDonor()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmDonor defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmDonor Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmDonor();
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
		
		public void Panel1_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
		
		public void frmDonor_Load(System.Object sender, System.EventArgs e)
		{
			btnSaveUpdate.Visible = false;
			btnDelete.Visible = false;
			
			pnlSearch.Visible = false;
			
			increment();
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [Donor ID]=Donor_ID,[Donor Name]=Donor_Name from tbl_DonorDetails", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			
			
			
		}
		
		public void increment()
		{
			int id1 = 0;
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Donor_ID from tbl_DonorDetails", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				//id1 =  (int) (rd[0]);
                id1 = int.Parse((rd[0].ToString()));
			}
			con.Close();
			id1++;
			txtDonorID.Text = id1.ToString();
			con.Close();
			
		}
		public void clear()
		{
			
			txtName.Clear();
			txtAge.Clear();
			txtContact.Clear();
			txtDonorType.Clear();
			txtHemoglobin.Clear();
			txtHIV.Clear();
			txtPhysicalTest.Clear();
			cboGender.ResetText();
			cboBloodGroup.ResetText();
			dtpDate.ResetText();
			rtbAddress.Clear();
			
			
		}
		
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			
			if (txtDonorID.Text == "" || txtName.Text == "" || cboBloodGroup.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_DonorDetails(Donor_ID,Donor_Name,Donor_Gender,Donor_Address,Donor_Contact,Donor_Group,Donor_Type,Donor_HemoglobinEST,Donor_HIVStatus,Donor_PhysicalExam,Donor_Age) values(\'" + txtDonorID.Text + "\',\'" + txtName.Text + "\',\'" + cboGender.Text + "\',\'" + rtbAddress.Text + "\',\'" + txtContact.Text + "\',\'" + cboBloodGroup.Text + "\',\'" + txtDonorType.Text + "\', \'" + txtHemoglobin.Text + "\',\'" + txtHIV.Text + "\',\'" + txtPhysicalTest.Text + "\',\'" + txtAge.Text + "\')";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				clear();
				
				increment();
				
				
			}
			
			
			
			
			
			
			
		}
		
		private void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			
			clear();
			
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void dgvSearch_MouseDoubleClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			con.Open();
			
			string str = dgvSearch.CurrentRow.Cells["Donor ID"].Value.ToString();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_DonorDetails where Donor_ID=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboGender.SelectedText = rd["Donor_Gender"].ToString();
				rtbAddress.Text = rd["Donor_Address"].ToString();
				txtContact.Text = rd["Donor_Contact"].ToString();
				txtDonorID.Text = rd["Donor_ID"].ToString();
				txtAge.Text = rd["Donor_Age"].ToString();
				txtDonorType.Text = rd["Donor_Type"].ToString();
				txtHemoglobin.Text = rd["Donor_HemoglobinEST"].ToString();
				txtHIV.Text = rd["Donor_HIVStatus"].ToString();
				txtName.Text = rd["Donor_Name"].ToString();
				txtPhysicalTest.Text = rd["Donor_PhysicalExam"].ToString();
				cboBloodGroup.Text = rd["Donor_Group"].ToString();
				
				
				
			}
			rd.Close();
			con.Close();
			
			
			pnlSearch.Visible = false;
			Panel1.Visible = true;
			
			
			
		}
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = true;
			Panel1.Visible = false;
			btnSave.Visible = false;
			btnDelete.Visible = false;
			btnSaveUpdate.Visible = true;
			btnDelete.Visible = true;
			
			
		}
		
		public void btnSaveUpdate_Click(System.Object sender, System.EventArgs e)
		{
			
			con.Close();
			con.Open();
			
			string s = "update tbl_DonorDetails set Donor_Name=\'" + txtName.Text + "\',Donor_Gender=\'" + cboGender.Text + "\',Donor_Address=\'" + rtbAddress.Text + "\',Donor_Contact=\'" + txtContact.Text + "\',Donor_Group=\'" + cboBloodGroup.Text + "\',Donor_Type=\'" + txtDonorType.Text + "\',Donor_HemoglobinEST=\'" + txtHemoglobin.Text + "\',Donor_HIVStatus=\'" + txtHIV.Text + "\',Donor_PhysicalExam=\'" + txtPhysicalTest.Text + "\',Donor_Age=\'" + txtAge.Text + "\' where Donor_ID=\'" + txtDonorID.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Updated");
			con.Close();
			
			this.Dispose();
			
			this.Close();
			
			
			
		}
		
		public void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			string s = "delete from tbl_DonorDetails where Donor_ID=\'" + txtDonorID.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s, con);
			cmd2.ExecuteNonQuery();
			//Else
			con.Close();
			
			
			this.Dispose();
			
			this.Close();
			
			
		}
		
		public void txtAge_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtContact_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtContact_TextChanged(System.Object sender, System.EventArgs e)
		{
			
		}
	}
}
