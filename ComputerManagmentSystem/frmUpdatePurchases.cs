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
	public partial class frmUpdatePurchases
	{
		public frmUpdatePurchases()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmUpdatePurchases defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmUpdatePurchases Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmUpdatePurchases();
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
		public void loadItem()
		{
			
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select Name from tbl_Purchases", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboName.Items.Add(rd[0]);
				
			}
			con.Close();
			
		}
		public void frmUpdatePurchases_Load(System.Object sender, System.EventArgs e)
		{
			loadItem();
			
		}
		
		public void cboName_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Amount from tbl_Purchases where Name=\'" + cboName.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				txtAmount.Text = rd[0].ToString();
				
				
			}
			con.Close();
		}
		
		public void GroupBox1_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			string s = "update tbl_Purchases set Amount=\'" + txtAmount.Text + "\' where Name=\'" + cboName.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Updated");
			con.Close();
			txtAmount.Clear();
			cboName.ResetText();
			
			
		}
		
		public void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			string s = "delete from tbl_Purchases where Name=\'" + cboName.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			
			con.Close();
			this.Close();
			
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			
			
			this.Close();
			
			
		}
	}
}
