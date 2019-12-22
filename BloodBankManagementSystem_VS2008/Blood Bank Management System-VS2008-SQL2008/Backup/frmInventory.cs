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
	public partial class frmInventory
	{
		public frmInventory()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=True;database=db_BloodBank");
		int id;
		
		
		
		public void Panel5_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
		
		public void frmInventory_Load(System.Object sender, System.EventArgs e)
		{
			
			
			var adapter = new SqlDataAdapter("select [Serial No]=Purchase_Srno,[Supplier]=Supplier_Name,[Purchase Date]=Purchase_Date,[Product]=Purchase_Product from tbl_Purchases", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			pnlSearch.Visible = false;
			
			
			
			
			ProductSrno();
			purchaseIncre();
			loadPurchaseBrand();
			loadProductBrand();
			loadProductDepartment();
			updateDepartmentLoad();
			supplierLoad();
			
			btnPurchaseUpdateSave.Visible = false;
			btnDeletePurchases.Visible = false;
			
			
		}
		public void supplierLoad()
		{
			
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select Supplier_Name from tbl_SupplierDetails", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboSupplier.Items.Add(rd[0]);
				
			}
			con.Close();
			
			//Dim adp = New SqlDataAdapter("select Supplier_Name, Supplier_ID from tbl_SupplierDetails", con)
			//Dim ds As New DataSet
			//adp.Fill(ds)
			//Dim dRow As New DataRow
			
			
			//DataSet ds = new DataSet();
			//adp.Fill(ds);
			
			//DataRow dr2 = ds.Tables[0].NewRow();	// create a new row into the dataset
			//dr2[0] = "Select";				// supply values
			//ds.Tables[0].Rows.InsertAt(dr2, 0);	// Insert the row at index 0
			
			//this.cboName.DataSource = ds.Tables[0];
			//this.cboName.DisplayMember = "Client_Name";
			//this.cboName.ValueMember = "Client_ID";
			
		}
		
		public void ProductSrno()
		{
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Product_Srno from tbl_ProductDetails", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				//id =  (int) (rd[0]);
                id = int.Parse((rd[0].ToString()));
			}
			con.Close();
			id++;
			txtProductSrno.Text = id.ToString();
			con.Close();
			
		}
		public void purchaseIncre()
		{
			int id1 = 0;
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select Purchase_Srno from tbl_Purchases", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				id1 =  (int) (rd[0]);
			}
			con.Close();
			id1++;
			txtPurchaseSrno.Text = id1.ToString();
			con.Close();
		}
		public void loadProductDepartment()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Department_Name from tbl_Department", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboDepartment.Items.Add(rd[0]);
				
			}
			con.Close();
			
		}
		public void updateDepartmentLoad()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Department_Name from tbl_Department", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboUpdateDepartment.Items.Add(rd[0]);
				
			}
			con.Close();
		}
		public void loadProductBrand()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Brand_Name from tbl_Brand", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboBrand.Items.Add(rd[0]);
				
			}
			con.Close();
			
		}
		public void loadPurchaseBrand()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Brand_Name from tbl_Brand", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboPurchaseBrand.Items.Add(rd[0]);
				
			}
			con.Close();
			
		}
		
		
		
		private void btnCloseDepartment_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		
		
		private void btnCloseBrand_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		
		
		public void btnCloseProduct_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void btnSaveProduct_Click(System.Object sender, System.EventArgs e)
		{
			
			
			if ((txtProductName.Text == "") || (cboDepartment.Text == "") || (txtProductRate.Text == "") || (cboBrand.Text == ""))
			{
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
			}
			else
			{
				con.Close();
				
				con.Open();
				SqlCommand cmd = new SqlCommand("select Product_Name from tbl_ProductDetails where Product_Name=\'" + txtProductName.Text + "\' ", con);
				
				SqlDataReader rd;
				rd = cmd.ExecuteReader();
				
				if (rd.HasRows)
				{
					MessageBox.Show("Product Name Exist");
					con.Close();
					
					
				}
				else
				{
					con.Close();
					
					con.Open();
					
					
					
					string s = "Insert into tbl_ProductDetails(Product_Srno,Product_Department,Product_Brand,Product_Name,Product_Rate) values(\'" + txtProductSrno.Text + "\',\'" + cboDepartment.Text + "\',\'" + cboBrand.Text + "\',\'" + txtProductName.Text + "\',\'" + txtProductRate.Text + "\')";
					SqlCommand cmd1 = new SqlCommand(s, con);
					cmd1.ExecuteNonQuery();
					MessageBox.Show("Record Inserted");
					
					Product_Clear();
					
					
					ProductSrno();
					
					
					con.Close();
					
				}
				
				
			}
			
			
		}
		public void Product_Clear()
		{
			txtProductName.Clear();
			txtProductRate.Clear();
			cboBrand.ResetText();
			cboDepartment.ResetText();
			
		}
		
		public void btnClearProduct_Click(System.Object sender, System.EventArgs e)
		{
			Product_Clear();
			
		}
		
		public void cboUpdateDepartment_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select distinct Product_Brand from tbl_ProductDetails where Product_Department=\'" + cboUpdateDepartment.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboUpdateBrand.Items.Add(rd[0]);
				
			}
			con.Close();
			
		}
		
		public void cboUpdateBrand_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select distinct Product_Name from tbl_ProductDetails where Product_Brand=\'" + cboUpdateBrand.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboUpdateProduct.Items.Add(rd[0]);
				
			}
			con.Close();
			
			
			
		}
		
		public void cboUpdateProduct_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select  Product_Rate from tbl_ProductDetails where Product_Name=\'" + cboUpdateProduct.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				txtUpdateRate.Text = rd[0].ToString();
				
			}
			con.Close();
			
			
		}
		
		public void btnCloseUpdate_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void btnProductClear_Click(System.Object sender, System.EventArgs e)
		{
			cboUpdateDepartment.ResetText();
			cboUpdateBrand.ResetText();
			cboUpdateProduct.ResetText();
			txtUpdateRate.Clear();
			
		}
		
		public void btnUpdateProduct_Click(System.Object sender, System.EventArgs e)
		{
			if (cboUpdateProduct.Text == "")
			{
				MessageBox.Show("Please Select Product");
			}
			else
			{
				
				con.Close();
				con.Open();
				
				string s = "update tbl_ProductDetails set Product_Rate=\'" + txtUpdateRate.Text + "\' where Product_Name=\'" + cboUpdateProduct.Text + "\'";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Updated");
				con.Close();
				cboUpdateDepartment.ResetText();
				cboUpdateBrand.ResetText();
				cboUpdateProduct.ResetText();
				txtUpdateRate.Clear();
				
				
			}
			
			
			
			
			
		}
		
		public void cboPurchaseBrand_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			con.Close();
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select distinct Product_Name from tbl_ProductDetails where Product_Brand=\'" + cboPurchaseBrand.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				cboPurchaseProduct.Items.Add(rd[0]);
				
			}
			con.Close();
		}
		
		public void cboPurchaseProduct_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select  Product_Rate from tbl_ProductDetails where Product_Name=\'" + cboPurchaseProduct.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				txtPurchaseRate.Text = rd[0].ToString();
				
			}
			con.Close();
			
			
		}
		
		public void txtPurchaseQuantity_Leave(System.Object sender, System.EventArgs e)
		{
			
			decimal rate;
			decimal quantity;
			decimal amount;
			
			rate = decimal.Parse(txtPurchaseRate.Text);
			quantity = decimal.Parse(txtPurchaseQuantity.Text);
			amount = rate * quantity;
			txtPurchaseAmount.Text = amount.ToString();
			
			
		}
		
		public void btnClosePurchases_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void btnClearPurchases_Click(System.Object sender, System.EventArgs e)
		{
			purchaseClear();
			
			
		}
		public void purchaseClear()
		{
			dtpPurchaseDate.ResetText();
			cboSupplier.ResetText();
			cboPurchaseBrand.ResetText();
			cboPurchaseProduct.ResetText();
			txtPurchaseRate.Clear();
			txtPurchaseQuantity.Clear();
			txtPurchaseAmount.Clear();
		}
		
		public void btnSavePurchases_Click(System.Object sender, System.EventArgs e)
		{
			
			
			if ((cboSupplier.Text == "") || (cboPurchaseBrand.Text == "") || (cboPurchaseProduct.Text == "") || (txtPurchaseQuantity.Text == ""))
			{
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
			}
			else
			{
				
				
				
				
				con.Close();
				
				con.Open();
				
				
				
				string s = "Insert into tbl_Purchases(Purchase_Srno,Purchase_Product,Purchase_Rate,Purchase_Quantity,Purchase_Amount,Supplier_Name,Purchase_Date) values(\'" + txtPurchaseSrno.Text + "\',\'" + cboPurchaseProduct.Text + "\',\'" + txtPurchaseRate.Text + "\',\'" + txtPurchaseQuantity.Text + "\',\'" + txtPurchaseAmount.Text + "\',\'" + cboSupplier.Text + "\',\'" + dtpPurchaseDate.Value.ToString() + "\')";
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				
				
				string str;
				str = "";
				con.Close();
				
				con.Open();
				
				SqlCommand cmd = new SqlCommand("select * from tbl_Stock where Stock_Product=\'" + cboPurchaseProduct.Text + "\'", con);
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
					SqlCommand cmd2 = new SqlCommand("update tbl_Stock set Stock_Quantity=\'" + txtPurchaseQuantity.Text + "\' where Stock_Product=\'" + cboPurchaseProduct.Text + "\'", con);
					cmd2.ExecuteNonQuery();
					
					
				}
				else
				{
					string stock = "Insert into tbl_Stock(Stock_Product,Stock_Rate,Stock_Quantity)values(\'" + cboPurchaseProduct.Text + "\',\'" + txtPurchaseRate.Text + "\',\'" + txtPurchaseQuantity.Text + "\')";
					SqlCommand cmdStock = new SqlCommand(stock, con);
					cmdStock.ExecuteNonQuery();
					
				}
				
				
				
				
				
				
				
				MessageBox.Show("Record Inserted");
				
				purchaseClear();
				purchaseIncre();
				
				
				
				
				
				
				con.Close();
				
				
				
				
			}
			
			
			
			
			
		}
		
		public void btnPurchaseUpdate_Click(System.Object sender, System.EventArgs e)
		{
			
			pnlSearch.Visible = true;
			TabControl1.Visible = false;
			
			btnPurchaseUpdateSave.Visible = true;
			btnSavePurchases.Visible = false;
			btnClearPurchases.Visible = false;
			btnDeletePurchases.Visible = true;
			btnPurchaseUpdate.Visible = false;
			
			
		}
		
		public void dgvSearch_CellMouseDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			con.Close();
			
			con.Open();
			
			string str = dgvSearch.CurrentRow.Cells["Serial No"].Value.ToString();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_Purchases where Purchase_Srno=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				txtPurchaseSrno.Text = rd["Purchase_Srno"].ToString();
				dtpPurchaseDate.Text = rd["Purchase_Date"].ToString();
				cboPurchaseBrand.SelectedText = rd["Purchase_Brand"].ToString();
				cboSupplier.SelectedText = rd["Supplier_Name"].ToString();
				cboPurchaseProduct.SelectedText = rd["Purchase_Product"].ToString();
				txtPurchaseRate.Text = rd["Purchase_Rate"].ToString();
				txtPurchaseQuantity.Text = rd["Purchase_Quantity"].ToString();
				txtPurchaseAmount.Text = rd["Purchase_Amount"].ToString();
				
				
			}
			pnlSearch.Visible = false;
			TabControl1.Visible = true;
			//btnPurchaseUpdate.Visible = True
			
			
			
		}
		
		public void btnPurchaseUpdateSave_Click(System.Object sender, System.EventArgs e)
		{
			
			con.Close();
			con.Open();
			
			string s = "update tbl_Purchases set Purchase_Product=\'" + cboPurchaseProduct.Text + "\', Purchase_Rate=\'" + txtPurchaseRate.Text + "\',Purchase_Quantity=\'" + txtPurchaseQuantity.Text + "\',Purchase_Amount=\'" + txtPurchaseAmount.Text + "\',Purchase_Brand=\'" + cboPurchaseBrand.Text + "\',Supplier_Name=\'" + cboSupplier.Text + "\',Purchase_Date=\'" + dtpPurchaseDate.Value.ToString() + "\' where Purchase_Srno=\'" + txtPurchaseSrno.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Updated");
			con.Close();
			
			this.Close();
			
			
			
			
		}
		
		public void btnDeletePurchases_Click(System.Object sender, System.EventArgs e)
		{
			
			
			con.Close();
			con.Open();
			
			string s = "delete from tbl_Purchases where Purchase_Srno=\'" + txtPurchaseSrno.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Deleted");
			con.Close();
			
			this.Close();
			
		}
		
		public void TabPage4_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void txtProductRate_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtUpdateRate_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtPurchaseRate_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtPurchaseQuantity_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
