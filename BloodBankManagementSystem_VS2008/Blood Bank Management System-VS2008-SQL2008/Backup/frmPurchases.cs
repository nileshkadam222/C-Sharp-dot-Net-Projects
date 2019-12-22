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
	public partial class frmPurchases
	{
		public frmPurchases()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmPurchases defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmPurchases Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmPurchases();
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
		
		public void frmPurchases_Load(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = false;
			
			btnSaveUpdate.Visible = false;
			btnDelete.Visible = false;
			
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [Serial No]=Serial_No,[Purchase Date]=Purchase_Date from tbl_Purchases", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			
			increment();
			
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select Donor_Name from tbl_DonorDetails", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboDonorName.Items.Add(rd[0]);
				
			}
			con.Close();
			
			
			
		}
		public void increment()
		{
			int id1 = 0;
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Serial_No from tbl_Purchases", con);
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
		public void clear()
		{
			dtpExpiryDate.ResetText();
			dtpDate.ResetText();
			cboBloodGroup.ResetText();
			txtBagNo.Clear();
			txtName.Clear();
			txtQuantity.Clear();
			cboDonorName.ResetText();
			
			
		}
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			
			if ((cboDonorName.Text == "") || (txtBagNo.Text == "") || (cboBloodGroup.Text == ""))
			{
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
			}
			else
			{
				
				con.Close();
				
				con.Open();
				
				
				
				string s = "Insert into tbl_Purchases(Serial_No,Purchase_Date,Blood_Group,Donor_Name,Purchase_Quantity,Blood_BagNo,Blood_ExpiryDate) values(\'" + txtSR.Text + "\',\'" + dtpDate.Value.ToString() + "\',\'" + cboBloodGroup.Text + "\',\'" + cboDonorName.Text + "\',\'" + txtQuantity.Text + "\',\'" + txtBagNo.Text + "\',\'" + dtpExpiryDate.Value.ToString() + "\')";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				
				
				string str;
				str = "";
				con.Close();
				
				con.Open();
				
				SqlCommand cmd = new SqlCommand("select * from tbl_Stock where Blood_Group=\'" + cboBloodGroup.Text + "\'", con);
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				if (rd.HasRows)
				{
					
					str = "true";
				}
				else
				{
					str = "false";
				}
				rd.Close();
				
				
				
				if (str == "true")
				{
					
					//OleDbCommand(cmd2 = New OleDbCommand("update tbl_Stock set Product_Quantity=Product_Quantity+'" + txtQuantity.Text + "' where Product_Name='" + cboProductName.Text + "' and Product_Rate='" + txtRate.Text + "'", clsCon.con))
					//cmd2.ExecuteNonQuery()
					SqlCommand cmd2 = new SqlCommand("update tbl_Stock set Blood_Quantity=Blood_Quantity+\'" + txtQuantity.Text + "\' where Blood_Group=\'" + cboBloodGroup.Text + "\'", con);
					cmd2.ExecuteNonQuery();
					
					
				}
				else
				{
					string stock = "Insert into tbl_Stock(Blood_Group,Blood_Quantity)values(\'" + cboBloodGroup.Text + "\',\'" + txtQuantity.Text + "\')";
					SqlCommand cmdStock = new SqlCommand(stock, con);
					cmdStock.ExecuteNonQuery();
					
				}
				
				
				
				
				
				
				
				MessageBox.Show("Record Inserted");
				
				clear();
				
				increment();
				
				
				
				
				
				
				con.Close();
				
				
				
				
			}
			
			
		}
		
		public void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			clear();
			
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
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
			
			SqlCommand cmd = new SqlCommand("select * from tbl_Purchases where Serial_No=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				
				txtSR.Text = rd["Serial_No"].ToString();
				dtpDate.Text = rd["Purchase_Date"].ToString();
				cboBloodGroup.SelectedText = rd["Blood_Group"].ToString();
				cboDonorName.SelectedText = rd["Donor_Name"].ToString();
				txtBagNo.Text = rd["Blood_BagNo"].ToString();
				txtQuantity.Text = rd["Purchase_Quantity"].ToString();
				dtpExpiryDate.Text = rd["Blood_ExpiryDate"].ToString();
				
				
				
				
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
			
			string s = "update tbl_Purchases set Purchase_Date=\'" + dtpDate.Value.ToString() + "\',Blood_Group=\'" + cboBloodGroup.Text + "\',Donor_Name=\'" + cboDonorName.Text + "\',Blood_BagNo=\'" + txtBagNo.Text + "\',Purchase_Quantity=\'" + txtQuantity.Text + "\',Blood_ExpiryDate=\'" + dtpExpiryDate.Value.ToString() + "\' where Serial_No=\'" + txtSR.Text + "\'";
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
			
			string s = "delete from tbl_Purchases where Serial_No=\'" + txtSR.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s, con);
			cmd2.ExecuteNonQuery();
			//Else
			MessageBox.Show("Record Deleted");
			this.Dispose();
			
			this.Close();
			
			
			
		}
	}
}
