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
	public partial class frmAddProduct
	{
		public frmAddProduct()
		{
			InitializeComponent();
			
            ////Added to support default instance behavour in C#
            //if (defaultInstance == null)
            //    defaultInstance = this;
		}
		
//#region Default Instance
		
//        private static frmAddProduct defaultInstance;
		
//        /// <summary>
//        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
//        /// </summary>
//        public static frmAddProduct Default
//        {
//            get
//            {
//                if (defaultInstance == null)
//                {
//                    defaultInstance = new frmAddProduct();
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
		
		
		public void loadSR()
		{
			
			int id1 = 0;
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Product_SR from tbl_Product", con);
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
			txtName.Clear();
			txtRate.Clear();
			
		}
		
		public void frmAddProduct_Load(System.Object sender, System.EventArgs e)
		{
			
			loadSR();
			
			
			
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
				string s = "Insert into tbl_Product(Product_SR,Product_Name,Product_Rate) values(\'" + txtSR.Text + "\',\'" + txtName.Text + "\',\'" + txtRate.Text + "\')";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				clear();
				
				loadSR();
				
				
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
		
		public void txtRate_TextChanged(System.Object sender, System.EventArgs e)
		{
			
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
	}
}
