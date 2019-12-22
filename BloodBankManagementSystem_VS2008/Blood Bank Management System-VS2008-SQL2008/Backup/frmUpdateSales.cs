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
	public partial class frmUpdateSales
	{
		public frmUpdateSales()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=True;database=db_BloodBank");
		public void loadSR()
		{
			
			cboSR.Items.Clear();
			
			con.Close();
			
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Sales_SR from tbl_ProductSales", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			cboSR.Items.Add("select");
			while (rd.Read())
			{
				
				
				cboSR.Items.Add(rd[0]);
				
				
			}
			con.Close();
			
			
			
			
		}
		public void clear()
		{
			txtRate.Clear();
			txtProduct.Clear();
			cboSR.ResetText();
			
			txtName.Clear();
			txtAmount.Clear();
			txtQuantity.Clear();
			dtpDate.ResetText();
			
		}
		public void frmUpdateSales_Load(System.Object sender, System.EventArgs e)
		{
			loadSR();
			
		}
		
		public void cboSR_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_ProductSales where Sales_SR=\'" + cboSR.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			
			while (rd.Read())
			{
				
				
				
				dtpDate.Text = (string) (rd["Sales_Date"].ToString());
				
				txtName.Text = (string) (rd["Sales_Patient"].ToString());
				txtProduct.Text = (string) (rd["Sales_Product"].ToString());
				txtRate.Text = (string) (rd["Sales_Rate"].ToString());
				txtQuantity.Text = (string) (rd["Sales_Quantity"].ToString());
				txtAmount.Text = (string) (rd["Sales_Amount"].ToString());
				
				
				
				
			}
			con.Close();
		}
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			string s = "Update tbl_ProductSales set Sales_Date=\'" + dtpDate.Value.ToString() + "\',Sales_Patient=\'" + txtName.Text + "\',Sales_Product=\'" + txtProduct.Text + "\',Sales_Rate=\'" + txtRate.Text + "\',Sales_Quantity=\'" + txtQuantity.Text + "\',Sales_Amount=\'" + txtAmount.Text + "\' where Sales_SR=\'" + cboSR.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Inserted");
			
			clear();
			
			loadSR();
		}
	}
}
