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
	public partial class frmSales
	{
		public frmSales()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSales defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSales Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSales();
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
		
		public void clear()
		{
			dtpExpiryDate.ResetText();
			dtpDate.ResetText();
			cboBloodGroup.ResetText();
			txtName.Clear();
			txtQuantity.Clear();
			
		}
		public void increment()
		{
			
			int id1 = 0;
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Serial_No from tbl_Sales", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				//id1 =  (int) (rd[0]);
                id1 = int.Parse((rd[0].ToString()));
			}
			con.Close();
			id1++;
			txtSR.Text = id1.ToString();
			con.Close();
			
		}
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			
			
			if ((txtName.Text == "") || (txtAmount.Text == "") || (cboBloodGroup.Text == ""))
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
			}
			else
			{
				
				con.Close();
				
				con.Open();
				
				
				
				string s = "Insert into tbl_Sales(Serial_No,Sales_Date,Patient_Name,Blood_Group,Sales_Quantity,Blood_ExpiryDate,Sales_Amount) values(\'" + txtSR.Text + "\',\'" + dtpDate.Value.ToString() + "\',\'" + txtName.Text + "\',\'" + cboBloodGroup.Text + "\',\'" + txtQuantity.Text + "\',\'" + dtpExpiryDate.Value.ToString() + "\',\'" + txtAmount.Text + "\')";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				
				
				con.Close();
				
				con.Open();
				
				string str = "update tbl_Stock set Blood_Quantity=Blood_Quantity-\'" + txtQuantity.Text + "\' where Blood_Group=\'" + cboBloodGroup.Text + "\'";
				SqlCommand cmd2 = new SqlCommand(str, con);
				cmd2.ExecuteNonQuery();
				
				con.Close();
				
				MessageBox.Show("Record Inserted");
				
				
				
				frmViewReport obj = new frmViewReport();
				obj.View_Report("select * from tbl_Sales where Serial_No=\'" + txtSR.Text + "\'", "Bill");
				obj.ShowDialog();
				
				clear();
				
				increment();
				
				
				
			}
			
			
			
		}
		
		public void frmSales_Load(System.Object sender, System.EventArgs e)
		{
			
			
			pnlSearch.Visible = false;
			
			btnSaveUpdate.Visible = false;
			btnDelete.Visible = false;
			
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Sales_Date from tbl_Sales", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			
			
			
			
			
			increment();
			
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			
			this.Close();
			
		}
		
		public void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			
			clear();
			
		}
		
		public void Panel1_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
		
		public void txtQuantity_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtAmount_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
			con.Open();
			
			string str = dgvSearch.CurrentRow.Cells["Serial No"].Value.ToString();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_Sales where Serial_No=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				
				txtSR.Text = rd["Serial_No"].ToString();
				dtpDate.Text = rd["Sales_Date"].ToString();
				cboBloodGroup.SelectedText = rd["Blood_Group"].ToString();
				txtName.Text = rd["Patient_Name"].ToString();
				txtQuantity.Text = rd["Sales_Quantity"].ToString();
				dtpExpiryDate.Text = rd["Blood_ExpiryDate"].ToString();
				txtAmount.Text = rd["Sales_Amount"].ToString();
				
				
				
				
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
			
			string s = "update tbl_Sales set Sales_Date=\'" + dtpDate.Value.ToString() + "\',Blood_Group=\'" + cboBloodGroup.Text + "\',Patient_Name=\'" + txtName.Text + "\',Sales_Quantity=\'" + txtQuantity.Text + "\',Sales_Amount=\'" + txtAmount.Text + "\',Blood_ExpiryDate=\'" + dtpExpiryDate.Value.ToString() + "\' where Serial_No=\'" + txtSR.Text + "\'";
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
			
			string s = "delete from tbl_Sales where Serial_No=\'" + txtSR.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s, con);
			cmd2.ExecuteNonQuery();
			//Else
			MessageBox.Show("Record Deleted");
			this.Dispose();
			
			this.Close();
			
			
			
			
			
			
			
		}
	}
}
