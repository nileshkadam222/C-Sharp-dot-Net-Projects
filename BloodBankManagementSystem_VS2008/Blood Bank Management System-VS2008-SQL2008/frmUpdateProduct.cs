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
	public partial class frmUpdateProduct
	{
		public frmUpdateProduct()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmUpdateProduct defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmUpdateProduct Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmUpdateProduct();
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
			
		}
		public void frmUpdateProduct_Load(System.Object sender, System.EventArgs e)
		{
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
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			string s = "Update tbl_Product set Product_Rate=\'" + txtRate.Text + "\' where Product_Name=\'" + cboProduct.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Inserted");
			
			clear();
			
			Product();
			
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
	}
}
