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
	public partial class FrmLogin
	{
		public FrmLogin()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static FrmLogin defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static FrmLogin Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new FrmLogin();
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
		
		public void FrmLogin_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void btnLogin_Click(System.Object sender, System.EventArgs e)
		{
			
			string a;
			string b;
			a = txtUsername.Text;
			b = txtPassword.Text;
			int flag = 0;
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from tbl_Login", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				if (a == rd[0].ToString().Trim() && b == rd[1].ToString().Trim())
				{
					flag = 1;
					break;
				}
				else
				{
					flag = 0;
				}
			}
			
			if (flag == 1)
			{
				//MsgBox("Login Successfull", MsgBoxStyle.OkOnly, "Done")
				this.Hide();
				
				
				frmHome.Default.Show();
				
				
			}
			else
			{
				Interaction.MsgBox("User Name or Password may be wrong.", MsgBoxStyle.Critical, "Error");
			}
			con.Close();
		}
		
		public void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void txtPassword_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Enter)
			{
				
				btnLogin_Click(sender, e);
				
				
			}
			
		}
	}
	
}
