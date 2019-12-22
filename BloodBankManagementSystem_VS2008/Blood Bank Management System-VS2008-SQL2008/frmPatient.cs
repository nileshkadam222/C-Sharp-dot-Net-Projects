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
	public partial class frmPatient
	{
		public frmPatient()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
            //if (defaultInstance == null)
            //    defaultInstance = this;
		}
		
//#region Default Instance
		
//        private static frmPatient defaultInstance;
		
//        /// <summary>
//        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
//        /// </summary>
//        public static frmPatient Default
//        {
//            get
//            {
//                if (defaultInstance == null)
//                {
//                    defaultInstance = new frmPatient();
//                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
//                }
				
//                return defaultInstance;
//            }
//        }
		
//        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            defaultInstance = null;
//        }
		
//#endregion
		SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=True;database=db_BloodBank");
		public void clear()
		{
			
			
			txtName.Clear();
			txtAge.Clear();
			txtContact.Clear();
			cboBloodGroup.ResetText();
			cboGender.ResetText();
			rtbAddress.Clear();
			
			
			
			
		}
		public void increment()
		{
			int id1 = 0;
			con.Close();
			
			con.Open();
            
			SqlCommand cmd = new SqlCommand("select Recipient_ID from tbl_RecipientDetails", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
                
				id1 =  int.Parse((rd[0].ToString()));
                
			}
			con.Close();
			id1++;
            
			txtPatientID.Text = id1.ToString();
			con.Close();
		}
		
		
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			if (txtPatientID.Text == "" || txtName.Text == "" || cboBloodGroup.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_RecipientDetails(Recipient_ID,Recipient_Name,Recipient_Gender,Recipient_Age,Recipient_Address,Recipient_Contact,Recipient_BloodGroup) values(\'" + txtPatientID.Text + "\',\'" + txtName.Text + "\',\'" + cboGender.Text + "\',\'" + txtAge.Text + "\',\'" + rtbAddress.Text + "\',\'" + txtContact.Text + "\',\'" + cboBloodGroup.Text + "\')";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				//clear()
				clear();
				increment();
				
				
				
			}
		}
		
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void frmPatient_Load(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = false;
			
			btnSaveUpdate.Visible = false;
			btnDelete.Visible = false;
			
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [Recipient ID]=Recipient_ID,[Recipient Name]=Recipient_Name from tbl_RecipientDetails", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			
			
			increment();
			
		}
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			
			btnSave.Visible = false;
			btnClear.Visible = false;
			btnSaveUpdate.Visible = true;
			btnDelete.Visible = true;
			
			pnlSearch.Visible = true;
			Panel1.Visible = false;
			
		}
		
		public void dgvSearch_CellMouseDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{


            con.Close();
			con.Open();
			
			string str = dgvSearch.CurrentRow.Cells["Recipient ID"].Value.ToString();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_RecipientDetails where Recipient_ID=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				
				txtPatientID.Text = rd["Recipient_ID"].ToString();
				txtName.Text = rd["Recipient_Name"].ToString();
				txtAge.Text = rd["Recipient_Age"].ToString();
				txtContact.Text = rd["Recipient_Contact"].ToString();
				cboBloodGroup.SelectedText = rd["Recipient_BloodGroup"].ToString();
				cboGender.SelectedText = rd["Recipient_Gender"].ToString();
				rtbAddress.Text = rd["Recipient_Address"].ToString();
				
				
			}
			rd.Close();
			con.Close();
			
			
			pnlSearch.Visible = false;
			Panel1.Visible = true;
			
			
			
		}
		
		public void btnSaveUpdate_Click(System.Object sender, System.EventArgs e)
		{
			
			con.Close();
			con.Open();
			
			string s = "update tbl_RecipientDetails set Recipient_Name=\'" + txtName.Text + "\',Recipient_Gender=\'" + cboGender.Text + "\',Recipient_Age=\'" + txtAge.Text + "\',Recipient_Address=\'" + rtbAddress.Text + "\',Recipient_Contact=\'" + txtContact.Text + "\',Recipient_BloodGroup=\'" + cboBloodGroup.Text + "\' where Recipient_ID=\'" + txtPatientID.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Updated");
			con.Close();
			clear();
			
			Close();
			this.Dispose();
			
			this.Close();
			
		}
		
		public void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			
			string s = "delete from tbl_RecipientDetails where Recipient_ID=\'" + txtPatientID.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s, con);
			cmd2.ExecuteNonQuery();
			//Else
			MessageBox.Show("Record Deleted");
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
	}
}
