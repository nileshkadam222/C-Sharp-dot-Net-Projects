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
	public partial class frmProductSales
	{
		public frmProductSales()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmProductSales defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmProductSales Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmProductSales();
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
		public void Product()
		{
			
			cboProduct.Items.Clear();
			
			con.Close();
			
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Product_Name from tbl_Product", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			cboProduct.Items.Add("select");
			while (rd.Read())
			{
				
				
				cboProduct.Items.Add(rd[0]);
				
				
			}
			con.Close();
			
			
			
			
		}
		public void clear()
		{
			txtRate.Clear();
			cboProduct.ResetText();
			txtName.Clear();
			txtAmount.Clear();
			txtQuantity.Clear();
			dtpDate.ResetText();
			
			
		}
		public void increment()
		{
			int id1 = 0;
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Sales_SR from tbl_ProductSales", con);
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
		public void frmProductSales_Load(System.Object sender, System.EventArgs e)
		{
			increment();
			Product();
			
		}
		
		public void cboProduct_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Product_Rate from tbl_Product where Product_Name=\'" + cboProduct.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			
			while (rd.Read())
			{
				
				
				txtRate.Text = rd[0].ToString();
				
				
				
			}
			con.Close();
		}
		
		public void txtQuantity_Leave(System.Object sender, System.EventArgs e)
		{
			double rate;
			double qty;
			double amt;
			
			
			rate = double.Parse(txtRate.Text);
			qty = double.Parse(txtQuantity.Text);
			
			amt = qty * rate;
			
			txtAmount.Text = amt.ToString();
			
		}
		
		public void txtRate_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
			if (txtSR.Text == "" || txtName.Text == "" || txtRate.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_ProductSales(Sales_SR,Sales_Date,Sales_Patient,Sales_Product,Sales_Rate,Sales_Quantity,Sales_Amount) values(\'" + txtSR.Text + "\',\'" + dtpDate.Value.ToString() + "\',\'" + txtName.Text + "\',\'" + cboProduct.Text + "\',\'" + txtRate.Text + "\',\'" + txtQuantity.Text + "\',\'" + txtAmount.Text + "\')";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				
				frmViewReport obj = new frmViewReport();
				obj.View_Report("select * from tbl_ProductSales where Sales_SR=\'" + txtSR.Text + "\'", "ProductBill");
				obj.ShowDialog();
				
				
				clear();
				
				increment();
				Product();
				
				
				
			}
			
		}
	}
}
