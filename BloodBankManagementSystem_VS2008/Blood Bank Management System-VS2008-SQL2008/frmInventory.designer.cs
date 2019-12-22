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

namespace Blood_Bank_Management_System
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmInventory : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
			this.TabControl1 = new System.Windows.Forms.TabControl();
			base.Load += new System.EventHandler(frmInventory_Load);
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Label3 = new System.Windows.Forms.Label();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.txtProductRate = new System.Windows.Forms.TextBox();
			this.txtProductRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductRate_KeyPress);
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.cboBrand = new System.Windows.Forms.ComboBox();
			this.cboDepartment = new System.Windows.Forms.ComboBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtProductSrno = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.btnCloseProduct = new System.Windows.Forms.Button();
			this.btnCloseProduct.Click += new System.EventHandler(this.btnCloseProduct_Click);
			this.btnClearProduct = new System.Windows.Forms.Button();
			this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
			this.btnSaveProduct = new System.Windows.Forms.Button();
			this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.TabPage4.Click += new System.EventHandler(this.TabPage4_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.cboUpdateProduct = new System.Windows.Forms.ComboBox();
			this.cboUpdateProduct.SelectedIndexChanged += new System.EventHandler(this.cboUpdateProduct_SelectedIndexChanged);
			this.txtUpdateRate = new System.Windows.Forms.TextBox();
			this.txtUpdateRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateRate_KeyPress);
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.cboUpdateBrand = new System.Windows.Forms.ComboBox();
			this.cboUpdateBrand.SelectedIndexChanged += new System.EventHandler(this.cboUpdateBrand_SelectedIndexChanged);
			this.cboUpdateDepartment = new System.Windows.Forms.ComboBox();
			this.cboUpdateDepartment.SelectedIndexChanged += new System.EventHandler(this.cboUpdateDepartment_SelectedIndexChanged);
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.btnCloseUpdate = new System.Windows.Forms.Button();
			this.btnCloseUpdate.Click += new System.EventHandler(this.btnCloseUpdate_Click);
			this.btnProductClear = new System.Windows.Forms.Button();
			this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
			this.TabPage5 = new System.Windows.Forms.TabPage();
			this.Label6 = new System.Windows.Forms.Label();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.Panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
			this.btnDeletePurchases = new System.Windows.Forms.Button();
			this.btnDeletePurchases.Click += new System.EventHandler(this.btnDeletePurchases_Click);
			this.btnPurchaseUpdateSave = new System.Windows.Forms.Button();
			this.btnPurchaseUpdateSave.Click += new System.EventHandler(this.btnPurchaseUpdateSave_Click);
			this.btnPurchaseUpdate = new System.Windows.Forms.Button();
			this.btnPurchaseUpdate.Click += new System.EventHandler(this.btnPurchaseUpdate_Click);
			this.txtPurchaseAmount = new System.Windows.Forms.TextBox();
			this.txtPurchaseQuantity = new System.Windows.Forms.TextBox();
			this.txtPurchaseQuantity.Leave += new System.EventHandler(this.txtPurchaseQuantity_Leave);
			this.txtPurchaseQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseQuantity_KeyPress);
			this.cboSupplier = new System.Windows.Forms.ComboBox();
			this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
			this.Label27 = new System.Windows.Forms.Label();
			this.Label26 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.Label24 = new System.Windows.Forms.Label();
			this.cboPurchaseProduct = new System.Windows.Forms.ComboBox();
			this.cboPurchaseProduct.SelectedIndexChanged += new System.EventHandler(this.cboPurchaseProduct_SelectedIndexChanged);
			this.txtPurchaseRate = new System.Windows.Forms.TextBox();
			this.txtPurchaseRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseRate_KeyPress);
			this.Label21 = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.cboPurchaseBrand = new System.Windows.Forms.ComboBox();
			this.cboPurchaseBrand.SelectedIndexChanged += new System.EventHandler(this.cboPurchaseBrand_SelectedIndexChanged);
			this.Label23 = new System.Windows.Forms.Label();
			this.txtPurchaseSrno = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.btnClosePurchases = new System.Windows.Forms.Button();
			this.btnClosePurchases.Click += new System.EventHandler(this.btnClosePurchases_Click);
			this.btnClearPurchases = new System.Windows.Forms.Button();
			this.btnClearPurchases.Click += new System.EventHandler(this.btnClearPurchases_Click);
			this.btnSavePurchases = new System.Windows.Forms.Button();
			this.btnSavePurchases.Click += new System.EventHandler(this.btnSavePurchases_Click);
			this.Label5 = new System.Windows.Forms.Label();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.dgvSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseDoubleClick);
			this.TabControl1.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.TabPage5.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).BeginInit();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Controls.Add(this.TabPage5);
			this.TabControl1.Location = new System.Drawing.Point(10, 37);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(381, 386);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.Label3);
			this.TabPage3.Controls.Add(this.Panel3);
			this.TabPage3.Location = new System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new System.Drawing.Size(373, 360);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Add Product";
			this.TabPage3.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Verdana", (float) (12.0F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(129, 10);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(115, 18);
			this.Label3.TabIndex = 21;
			this.Label3.Text = "Add Product";
			//
			//Panel3
			//
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel3.Controls.Add(this.txtProductRate);
			this.Panel3.Controls.Add(this.txtProductName);
			this.Panel3.Controls.Add(this.Label15);
			this.Panel3.Controls.Add(this.Label14);
			this.Panel3.Controls.Add(this.cboBrand);
			this.Panel3.Controls.Add(this.cboDepartment);
			this.Panel3.Controls.Add(this.Label13);
			this.Panel3.Controls.Add(this.txtProductSrno);
			this.Panel3.Controls.Add(this.Label11);
			this.Panel3.Controls.Add(this.Label12);
			this.Panel3.Controls.Add(this.btnCloseProduct);
			this.Panel3.Controls.Add(this.btnClearProduct);
			this.Panel3.Controls.Add(this.btnSaveProduct);
			this.Panel3.Location = new System.Drawing.Point(6, 31);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(364, 295);
			this.Panel3.TabIndex = 1;
			//
			//txtProductRate
			//
			this.txtProductRate.Location = new System.Drawing.Point(131, 201);
			this.txtProductRate.Name = "txtProductRate";
			this.txtProductRate.Size = new System.Drawing.Size(195, 20);
			this.txtProductRate.TabIndex = 3;
			//
			//txtProductName
			//
			this.txtProductName.Location = new System.Drawing.Point(131, 157);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(195, 20);
			this.txtProductName.TabIndex = 2;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(30, 201);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(70, 13);
			this.Label15.TabIndex = 26;
			this.Label15.Text = "Product Rate";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(30, 157);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(75, 13);
			this.Label14.TabIndex = 25;
			this.Label14.Text = "Product Name";
			//
			//cboBrand
			//
			this.cboBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboBrand.FormattingEnabled = true;
			this.cboBrand.Location = new System.Drawing.Point(131, 114);
			this.cboBrand.Name = "cboBrand";
			this.cboBrand.Size = new System.Drawing.Size(195, 21);
			this.cboBrand.TabIndex = 1;
			//
			//cboDepartment
			//
			this.cboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboDepartment.FormattingEnabled = true;
			this.cboDepartment.Location = new System.Drawing.Point(131, 69);
			this.cboDepartment.Name = "cboDepartment";
			this.cboDepartment.Size = new System.Drawing.Size(195, 21);
			this.cboDepartment.TabIndex = 0;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(30, 114);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(35, 13);
			this.Label13.TabIndex = 22;
			this.Label13.Text = "Brand";
			//
			//txtProductSrno
			//
			this.txtProductSrno.Location = new System.Drawing.Point(131, 26);
			this.txtProductSrno.Name = "txtProductSrno";
			this.txtProductSrno.ReadOnly = true;
			this.txtProductSrno.Size = new System.Drawing.Size(195, 20);
			this.txtProductSrno.TabIndex = 0;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(30, 69);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(62, 13);
			this.Label11.TabIndex = 20;
			this.Label11.Text = "Department";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(30, 26);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(53, 13);
			this.Label12.TabIndex = 19;
			this.Label12.Text = "Serial No.";
			//
			//btnCloseProduct
			//
			this.btnCloseProduct.Image = (System.Drawing.Image) (resources.GetObject("btnCloseProduct.Image"));
			this.btnCloseProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCloseProduct.Location = new System.Drawing.Point(252, 248);
			this.btnCloseProduct.Name = "btnCloseProduct";
			this.btnCloseProduct.Size = new System.Drawing.Size(75, 40);
			this.btnCloseProduct.TabIndex = 6;
			this.btnCloseProduct.Text = "Close";
			this.btnCloseProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCloseProduct.UseVisualStyleBackColor = true;
			//
			//btnClearProduct
			//
			this.btnClearProduct.Image = (System.Drawing.Image) (resources.GetObject("btnClearProduct.Image"));
			this.btnClearProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClearProduct.Location = new System.Drawing.Point(144, 248);
			this.btnClearProduct.Name = "btnClearProduct";
			this.btnClearProduct.Size = new System.Drawing.Size(75, 40);
			this.btnClearProduct.TabIndex = 5;
			this.btnClearProduct.Text = "Clear";
			this.btnClearProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClearProduct.UseVisualStyleBackColor = true;
			//
			//btnSaveProduct
			//
			this.btnSaveProduct.Image = (System.Drawing.Image) (resources.GetObject("btnSaveProduct.Image"));
			this.btnSaveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveProduct.Location = new System.Drawing.Point(33, 248);
			this.btnSaveProduct.Name = "btnSaveProduct";
			this.btnSaveProduct.Size = new System.Drawing.Size(75, 40);
			this.btnSaveProduct.TabIndex = 4;
			this.btnSaveProduct.Text = "Save";
			this.btnSaveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSaveProduct.UseVisualStyleBackColor = true;
			//
			//TabPage4
			//
			this.TabPage4.Controls.Add(this.Label4);
			this.TabPage4.Controls.Add(this.Panel4);
			this.TabPage4.Location = new System.Drawing.Point(4, 22);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Size = new System.Drawing.Size(373, 360);
			this.TabPage4.TabIndex = 3;
			this.TabPage4.Text = "Update Product";
			this.TabPage4.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Verdana", (float) (12.0F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(114, 7);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(145, 18);
			this.Label4.TabIndex = 22;
			this.Label4.Text = "Update Product";
			//
			//Panel4
			//
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel4.Controls.Add(this.cboUpdateProduct);
			this.Panel4.Controls.Add(this.txtUpdateRate);
			this.Panel4.Controls.Add(this.Label16);
			this.Panel4.Controls.Add(this.Label17);
			this.Panel4.Controls.Add(this.cboUpdateBrand);
			this.Panel4.Controls.Add(this.cboUpdateDepartment);
			this.Panel4.Controls.Add(this.Label18);
			this.Panel4.Controls.Add(this.Label19);
			this.Panel4.Controls.Add(this.btnCloseUpdate);
			this.Panel4.Controls.Add(this.btnProductClear);
			this.Panel4.Controls.Add(this.btnUpdateProduct);
			this.Panel4.Location = new System.Drawing.Point(6, 32);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(364, 294);
			this.Panel4.TabIndex = 0;
			//
			//cboUpdateProduct
			//
			this.cboUpdateProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboUpdateProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboUpdateProduct.FormattingEnabled = true;
			this.cboUpdateProduct.Location = new System.Drawing.Point(135, 141);
			this.cboUpdateProduct.Name = "cboUpdateProduct";
			this.cboUpdateProduct.Size = new System.Drawing.Size(195, 21);
			this.cboUpdateProduct.TabIndex = 2;
			//
			//txtUpdateRate
			//
			this.txtUpdateRate.Location = new System.Drawing.Point(135, 188);
			this.txtUpdateRate.Name = "txtUpdateRate";
			this.txtUpdateRate.Size = new System.Drawing.Size(195, 20);
			this.txtUpdateRate.TabIndex = 3;
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(34, 188);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(70, 13);
			this.Label16.TabIndex = 34;
			this.Label16.Text = "Product Rate";
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Location = new System.Drawing.Point(34, 141);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(75, 13);
			this.Label17.TabIndex = 33;
			this.Label17.Text = "Product Name";
			//
			//cboUpdateBrand
			//
			this.cboUpdateBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboUpdateBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboUpdateBrand.FormattingEnabled = true;
			this.cboUpdateBrand.Location = new System.Drawing.Point(135, 89);
			this.cboUpdateBrand.Name = "cboUpdateBrand";
			this.cboUpdateBrand.Size = new System.Drawing.Size(195, 21);
			this.cboUpdateBrand.TabIndex = 1;
			//
			//cboUpdateDepartment
			//
			this.cboUpdateDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboUpdateDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboUpdateDepartment.FormattingEnabled = true;
			this.cboUpdateDepartment.Location = new System.Drawing.Point(135, 38);
			this.cboUpdateDepartment.Name = "cboUpdateDepartment";
			this.cboUpdateDepartment.Size = new System.Drawing.Size(195, 21);
			this.cboUpdateDepartment.TabIndex = 0;
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Location = new System.Drawing.Point(34, 89);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(35, 13);
			this.Label18.TabIndex = 32;
			this.Label18.Text = "Brand";
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.Location = new System.Drawing.Point(34, 38);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(62, 13);
			this.Label19.TabIndex = 31;
			this.Label19.Text = "Department";
			//
			//btnCloseUpdate
			//
			this.btnCloseUpdate.Image = (System.Drawing.Image) (resources.GetObject("btnCloseUpdate.Image"));
			this.btnCloseUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCloseUpdate.Location = new System.Drawing.Point(252, 247);
			this.btnCloseUpdate.Name = "btnCloseUpdate";
			this.btnCloseUpdate.Size = new System.Drawing.Size(75, 40);
			this.btnCloseUpdate.TabIndex = 6;
			this.btnCloseUpdate.Text = "Close";
			this.btnCloseUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCloseUpdate.UseVisualStyleBackColor = true;
			//
			//btnProductClear
			//
			this.btnProductClear.Image = (System.Drawing.Image) (resources.GetObject("btnProductClear.Image"));
			this.btnProductClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProductClear.Location = new System.Drawing.Point(144, 247);
			this.btnProductClear.Name = "btnProductClear";
			this.btnProductClear.Size = new System.Drawing.Size(75, 40);
			this.btnProductClear.TabIndex = 5;
			this.btnProductClear.Text = "Clear";
			this.btnProductClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProductClear.UseVisualStyleBackColor = true;
			//
			//btnUpdateProduct
			//
			this.btnUpdateProduct.Image = (System.Drawing.Image) (resources.GetObject("btnUpdateProduct.Image"));
			this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdateProduct.Location = new System.Drawing.Point(33, 247);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(75, 40);
			this.btnUpdateProduct.TabIndex = 4;
			this.btnUpdateProduct.Text = "Update";
			this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdateProduct.UseVisualStyleBackColor = true;
			//
			//TabPage5
			//
			this.TabPage5.Controls.Add(this.Label6);
			this.TabPage5.Controls.Add(this.Panel5);
			this.TabPage5.Location = new System.Drawing.Point(4, 22);
			this.TabPage5.Name = "TabPage5";
			this.TabPage5.Size = new System.Drawing.Size(373, 360);
			this.TabPage5.TabIndex = 4;
			this.TabPage5.Text = "Purchases";
			this.TabPage5.UseVisualStyleBackColor = true;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Verdana", (float) (12.0F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(137, 5);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(98, 18);
			this.Label6.TabIndex = 23;
			this.Label6.Text = "Purchases";
			//
			//Panel5
			//
			this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel5.Controls.Add(this.btnDeletePurchases);
			this.Panel5.Controls.Add(this.btnPurchaseUpdateSave);
			this.Panel5.Controls.Add(this.btnPurchaseUpdate);
			this.Panel5.Controls.Add(this.txtPurchaseAmount);
			this.Panel5.Controls.Add(this.txtPurchaseQuantity);
			this.Panel5.Controls.Add(this.cboSupplier);
			this.Panel5.Controls.Add(this.dtpPurchaseDate);
			this.Panel5.Controls.Add(this.Label27);
			this.Panel5.Controls.Add(this.Label26);
			this.Panel5.Controls.Add(this.Label25);
			this.Panel5.Controls.Add(this.Label24);
			this.Panel5.Controls.Add(this.cboPurchaseProduct);
			this.Panel5.Controls.Add(this.txtPurchaseRate);
			this.Panel5.Controls.Add(this.Label21);
			this.Panel5.Controls.Add(this.Label22);
			this.Panel5.Controls.Add(this.cboPurchaseBrand);
			this.Panel5.Controls.Add(this.Label23);
			this.Panel5.Controls.Add(this.txtPurchaseSrno);
			this.Panel5.Controls.Add(this.Label20);
			this.Panel5.Controls.Add(this.btnClosePurchases);
			this.Panel5.Controls.Add(this.btnClearPurchases);
			this.Panel5.Controls.Add(this.btnSavePurchases);
			this.Panel5.Location = new System.Drawing.Point(11, 26);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(351, 328);
			this.Panel5.TabIndex = 0;
			//
			//btnDeletePurchases
			//
			this.btnDeletePurchases.Image = (System.Drawing.Image) (resources.GetObject("btnDeletePurchases.Image"));
			this.btnDeletePurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeletePurchases.Location = new System.Drawing.Point(178, 277);
			this.btnDeletePurchases.Name = "btnDeletePurchases";
			this.btnDeletePurchases.Size = new System.Drawing.Size(75, 40);
			this.btnDeletePurchases.TabIndex = 47;
			this.btnDeletePurchases.Text = "Delete";
			this.btnDeletePurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDeletePurchases.UseVisualStyleBackColor = true;
			//
			//btnPurchaseUpdateSave
			//
			this.btnPurchaseUpdateSave.Image = (System.Drawing.Image) (resources.GetObject("btnPurchaseUpdateSave.Image"));
			this.btnPurchaseUpdateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPurchaseUpdateSave.Location = new System.Drawing.Point(90, 277);
			this.btnPurchaseUpdateSave.Name = "btnPurchaseUpdateSave";
			this.btnPurchaseUpdateSave.Size = new System.Drawing.Size(75, 40);
			this.btnPurchaseUpdateSave.TabIndex = 46;
			this.btnPurchaseUpdateSave.Text = "Update";
			this.btnPurchaseUpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPurchaseUpdateSave.UseVisualStyleBackColor = true;
			//
			//btnPurchaseUpdate
			//
			this.btnPurchaseUpdate.Image = (System.Drawing.Image) (resources.GetObject("btnPurchaseUpdate.Image"));
			this.btnPurchaseUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPurchaseUpdate.Location = new System.Drawing.Point(7, 277);
			this.btnPurchaseUpdate.Name = "btnPurchaseUpdate";
			this.btnPurchaseUpdate.Size = new System.Drawing.Size(75, 40);
			this.btnPurchaseUpdate.TabIndex = 45;
			this.btnPurchaseUpdate.Text = "Update";
			this.btnPurchaseUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPurchaseUpdate.UseVisualStyleBackColor = true;
			//
			//txtPurchaseAmount
			//
			this.txtPurchaseAmount.Location = new System.Drawing.Point(127, 240);
			this.txtPurchaseAmount.Name = "txtPurchaseAmount";
			this.txtPurchaseAmount.ReadOnly = true;
			this.txtPurchaseAmount.Size = new System.Drawing.Size(195, 20);
			this.txtPurchaseAmount.TabIndex = 6;
			//
			//txtPurchaseQuantity
			//
			this.txtPurchaseQuantity.Location = new System.Drawing.Point(127, 212);
			this.txtPurchaseQuantity.Name = "txtPurchaseQuantity";
			this.txtPurchaseQuantity.Size = new System.Drawing.Size(195, 20);
			this.txtPurchaseQuantity.TabIndex = 5;
			//
			//cboSupplier
			//
			this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboSupplier.FormattingEnabled = true;
			this.cboSupplier.Location = new System.Drawing.Point(127, 76);
			this.cboSupplier.Name = "cboSupplier";
			this.cboSupplier.Size = new System.Drawing.Size(195, 21);
			this.cboSupplier.TabIndex = 1;
			//
			//dtpPurchaseDate
			//
			this.dtpPurchaseDate.CustomFormat = "dd/MM/yyyy";
			this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPurchaseDate.Location = new System.Drawing.Point(127, 41);
			this.dtpPurchaseDate.Name = "dtpPurchaseDate";
			this.dtpPurchaseDate.Size = new System.Drawing.Size(195, 20);
			this.dtpPurchaseDate.TabIndex = 0;
			//
			//Label27
			//
			this.Label27.AutoSize = true;
			this.Label27.Location = new System.Drawing.Point(26, 41);
			this.Label27.Name = "Label27";
			this.Label27.Size = new System.Drawing.Size(30, 13);
			this.Label27.TabIndex = 44;
			this.Label27.Text = "Date";
			//
			//Label26
			//
			this.Label26.AutoSize = true;
			this.Label26.Location = new System.Drawing.Point(26, 76);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(45, 13);
			this.Label26.TabIndex = 43;
			this.Label26.Text = "Supplier";
			//
			//Label25
			//
			this.Label25.AutoSize = true;
			this.Label25.Location = new System.Drawing.Point(26, 240);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(43, 13);
			this.Label25.TabIndex = 42;
			this.Label25.Text = "Amount";
			//
			//Label24
			//
			this.Label24.AutoSize = true;
			this.Label24.Location = new System.Drawing.Point(26, 212);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(46, 13);
			this.Label24.TabIndex = 41;
			this.Label24.Text = "Quantity";
			//
			//cboPurchaseProduct
			//
			this.cboPurchaseProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboPurchaseProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboPurchaseProduct.FormattingEnabled = true;
			this.cboPurchaseProduct.Location = new System.Drawing.Point(127, 145);
			this.cboPurchaseProduct.Name = "cboPurchaseProduct";
			this.cboPurchaseProduct.Size = new System.Drawing.Size(195, 21);
			this.cboPurchaseProduct.TabIndex = 3;
			//
			//txtPurchaseRate
			//
			this.txtPurchaseRate.Location = new System.Drawing.Point(127, 177);
			this.txtPurchaseRate.Name = "txtPurchaseRate";
			this.txtPurchaseRate.Size = new System.Drawing.Size(195, 20);
			this.txtPurchaseRate.TabIndex = 4;
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.Location = new System.Drawing.Point(26, 177);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(70, 13);
			this.Label21.TabIndex = 40;
			this.Label21.Text = "Product Rate";
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.Location = new System.Drawing.Point(26, 145);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(75, 13);
			this.Label22.TabIndex = 39;
			this.Label22.Text = "Product Name";
			//
			//cboPurchaseBrand
			//
			this.cboPurchaseBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboPurchaseBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboPurchaseBrand.FormattingEnabled = true;
			this.cboPurchaseBrand.Location = new System.Drawing.Point(127, 113);
			this.cboPurchaseBrand.Name = "cboPurchaseBrand";
			this.cboPurchaseBrand.Size = new System.Drawing.Size(195, 21);
			this.cboPurchaseBrand.TabIndex = 2;
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Location = new System.Drawing.Point(26, 113);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(35, 13);
			this.Label23.TabIndex = 38;
			this.Label23.Text = "Brand";
			//
			//txtPurchaseSrno
			//
			this.txtPurchaseSrno.Location = new System.Drawing.Point(127, 13);
			this.txtPurchaseSrno.Name = "txtPurchaseSrno";
			this.txtPurchaseSrno.ReadOnly = true;
			this.txtPurchaseSrno.Size = new System.Drawing.Size(195, 20);
			this.txtPurchaseSrno.TabIndex = 1;
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.Location = new System.Drawing.Point(26, 13);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(53, 13);
			this.Label20.TabIndex = 21;
			this.Label20.Text = "Serial No.";
			//
			//btnClosePurchases
			//
			this.btnClosePurchases.Image = (System.Drawing.Image) (resources.GetObject("btnClosePurchases.Image"));
			this.btnClosePurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClosePurchases.Location = new System.Drawing.Point(267, 277);
			this.btnClosePurchases.Name = "btnClosePurchases";
			this.btnClosePurchases.Size = new System.Drawing.Size(75, 40);
			this.btnClosePurchases.TabIndex = 11;
			this.btnClosePurchases.Text = "Close";
			this.btnClosePurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClosePurchases.UseVisualStyleBackColor = true;
			//
			//btnClearPurchases
			//
			this.btnClearPurchases.Image = (System.Drawing.Image) (resources.GetObject("btnClearPurchases.Image"));
			this.btnClearPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClearPurchases.Location = new System.Drawing.Point(178, 277);
			this.btnClearPurchases.Name = "btnClearPurchases";
			this.btnClearPurchases.Size = new System.Drawing.Size(75, 40);
			this.btnClearPurchases.TabIndex = 10;
			this.btnClearPurchases.Text = "Clear";
			this.btnClearPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClearPurchases.UseVisualStyleBackColor = true;
			//
			//btnSavePurchases
			//
			this.btnSavePurchases.Image = (System.Drawing.Image) (resources.GetObject("btnSavePurchases.Image"));
			this.btnSavePurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSavePurchases.Location = new System.Drawing.Point(90, 277);
			this.btnSavePurchases.Name = "btnSavePurchases";
			this.btnSavePurchases.Size = new System.Drawing.Size(75, 40);
			this.btnSavePurchases.TabIndex = 9;
			this.btnSavePurchases.Text = "Save";
			this.btnSavePurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSavePurchases.UseVisualStyleBackColor = true;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Verdana", (float) (15.75F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(136, 9);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(129, 25);
			this.Label5.TabIndex = 18;
			this.Label5.Text = "Inventory";
			//
			//pnlSearch
			//
			this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlSearch.Controls.Add(this.dgvSearch);
			this.pnlSearch.Location = new System.Drawing.Point(10, 44);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(389, 303);
			this.pnlSearch.TabIndex = 48;
			//
			//dgvSearch
			//
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Location = new System.Drawing.Point(12, 11);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(361, 287);
			this.dgvSearch.TabIndex = 0;
			//
			//frmInventory
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 425);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.pnlSearch);
			this.Controls.Add(this.Label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInventory";
			this.Text = "frmInventory";
			this.TabControl1.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.TabPage4.ResumeLayout(false);
			this.TabPage4.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.TabPage5.ResumeLayout(false);
			this.TabPage5.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			this.pnlSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.TabControl TabControl1;
		private System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.TabPage TabPage5;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Panel Panel5;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Button btnCloseProduct;
		private System.Windows.Forms.Button btnClearProduct;
		private System.Windows.Forms.Button btnSaveProduct;
		private System.Windows.Forms.Button btnCloseUpdate;
		private System.Windows.Forms.Button btnProductClear;
		private System.Windows.Forms.Button btnUpdateProduct;
		private System.Windows.Forms.Button btnClosePurchases;
		private System.Windows.Forms.Button btnClearPurchases;
		private System.Windows.Forms.Button btnSavePurchases;
		internal System.Windows.Forms.TextBox txtProductSrno;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.ComboBox cboBrand;
		internal System.Windows.Forms.ComboBox cboDepartment;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtProductRate;
		internal System.Windows.Forms.TextBox txtProductName;
		internal System.Windows.Forms.TextBox txtUpdateRate;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.ComboBox cboUpdateBrand;
		internal System.Windows.Forms.ComboBox cboUpdateDepartment;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.ComboBox cboUpdateProduct;
		internal System.Windows.Forms.ComboBox cboPurchaseProduct;
		internal System.Windows.Forms.TextBox txtPurchaseRate;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.ComboBox cboPurchaseBrand;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.TextBox txtPurchaseSrno;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.DateTimePicker dtpPurchaseDate;
		internal System.Windows.Forms.ComboBox cboSupplier;
		internal System.Windows.Forms.TextBox txtPurchaseQuantity;
		internal System.Windows.Forms.TextBox txtPurchaseAmount;
		private System.Windows.Forms.Button btnPurchaseUpdate;
		private System.Windows.Forms.Button btnPurchaseUpdateSave;
		private System.Windows.Forms.Button btnDeletePurchases;
		internal System.Windows.Forms.Panel pnlSearch;
		internal System.Windows.Forms.DataGridView dgvSearch;
	}
	
}
