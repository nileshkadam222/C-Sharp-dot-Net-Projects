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
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=D:\\READY PROJECTS\\COMPUTERMANAGMENTSYSTEM\\DB_CIMS.MDF;Integrated Security=True");
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
                id1 = (int.Parse(rd[0].ToString()));
			}
			con.Close();
			id1++;
			txtSR.Text = id1.ToString();
			con.Close();
			
			
		}
		public void clear()
		{
			txtName.Clear();
			txtAmount.Clear();
			
		}
		public void frmPurchases_Load(System.Object sender, System.EventArgs e)
		{
			increment();
			
		}
		
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			
			if (txtName.Text == "" || txtAmount.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_Purchases(Serial_No,Name,Amount) values(\'" + txtSR.Text + "\',\'" + txtName.Text + "\',\'" + txtAmount.Text + "\')";
				
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				clear();
				
				increment();
				
				
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
	}
}
