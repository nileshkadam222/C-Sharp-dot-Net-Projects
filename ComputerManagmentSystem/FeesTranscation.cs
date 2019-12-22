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
	public partial class FeesTranscation
	{
		public FeesTranscation()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static FeesTranscation defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static FeesTranscation Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new FeesTranscation();
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
		
		public void DOF_ValueChanged(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void clear()
		{
			
			
			cboRollNo.ResetText();
			txtTotalFees.Clear();
			txtPaidAmount.Clear();
			txtPaidFees.Clear();
			txtBalanceAmount.Clear();
			txtChequeNo.Clear();
			txtFees.Clear();
			txtNameOfBank.Clear();
			txtReceiptNo.Clear();
			cboPaymentMode.ResetText();
			cboRollNo.ResetText();
			dtpDate.ResetText();
			
			
			
		}
		
		
		
		public void FeesTranscation_Load(System.Object sender, System.EventArgs e)
		{
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select Student_ROLLNO from tbl_Student", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboRollNo.Items.Add(rd[0]);
				
			}
			con.Close();
			
			
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
			
			
			if (cboRollNo.Text == "" || cboPaymentMode.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_Fee(Fee_ROLLNO,Fee_RECEIPTNO,Fee_Date,Fee_AMOUNT,Fee_ModeOfPayment,Fee_BANKNAME,Fee_CHEQUENO,Fee_BAMOUNT) values(\'" + cboRollNo.Text + "\',\'" + txtReceiptNo.Text + "\',\'" + dtpDate.Value.ToString() + "\',\'" + txtPaidAmount.Text + "\',\'" + cboPaymentMode.Text + "\',\'" + txtNameOfBank.Text + "\',\'" + txtChequeNo.Text + "\',\'" + txtBalanceAmount.Text + "\')";
				
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				clear();
				
				
				
				
			}
			
			
			
		}
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			
			
			
		}
		
		public void cboRollNo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			
			
			
			
		}
		
		public void GroupBox3_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void txtFees_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtPaidAmount_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
