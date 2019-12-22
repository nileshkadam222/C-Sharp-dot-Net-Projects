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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmProductSales : System.Windows.Forms.Form
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
			this.Panel1 = new System.Windows.Forms.Panel();
			base.Load += new System.EventHandler(frmProductSales_Load);
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.cboProduct = new System.Windows.Forms.ComboBox();
			this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.txtSR = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.txtAmount);
			this.Panel1.Controls.Add(this.txtQuantity);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.cboProduct);
			this.Panel1.Controls.Add(this.txtRate);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.txtName);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.dtpDate);
			this.Panel1.Controls.Add(this.btnExit);
			this.Panel1.Controls.Add(this.btnClear);
			this.Panel1.Controls.Add(this.btnSave);
			this.Panel1.Controls.Add(this.txtSR);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(12, 40);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(309, 334);
			this.Panel1.TabIndex = 4;
			//
			//txtAmount
			//
			this.txtAmount.Location = new System.Drawing.Point(114, 250);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(180, 20);
			this.txtAmount.TabIndex = 5;
			//
			//txtQuantity
			//
			this.txtQuantity.Location = new System.Drawing.Point(114, 204);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(180, 20);
			this.txtQuantity.TabIndex = 4;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(7, 250);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(43, 13);
			this.Label8.TabIndex = 25;
			this.Label8.Text = "Amount";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(7, 204);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(46, 13);
			this.Label7.TabIndex = 24;
			this.Label7.Text = "Quantity";
			//
			//cboProduct
			//
			this.cboProduct.FormattingEnabled = true;
			this.cboProduct.Location = new System.Drawing.Point(114, 125);
			this.cboProduct.Name = "cboProduct";
			this.cboProduct.Size = new System.Drawing.Size(180, 21);
			this.cboProduct.TabIndex = 2;
			//
			//txtRate
			//
			this.txtRate.Location = new System.Drawing.Point(114, 162);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(180, 20);
			this.txtRate.TabIndex = 3;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(7, 162);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(30, 13);
			this.Label5.TabIndex = 21;
			this.Label5.Text = "Rate";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(7, 125);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(75, 13);
			this.Label6.TabIndex = 20;
			this.Label6.Text = "Product Name";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(114, 86);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(180, 20);
			this.txtName.TabIndex = 1;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(7, 86);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(71, 13);
			this.Label4.TabIndex = 19;
			this.Label4.Text = "Patient Name";
			//
			//dtpDate
			//
			this.dtpDate.CustomFormat = "dd/MM/yyyy";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(114, 48);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(180, 20);
			this.dtpDate.TabIndex = 0;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(219, 287);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 33);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(114, 287);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 33);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(10, 287);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 33);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//txtSR
			//
			this.txtSR.Location = new System.Drawing.Point(114, 13);
			this.txtSR.Name = "txtSR";
			this.txtSR.ReadOnly = true;
			this.txtSR.Size = new System.Drawing.Size(180, 20);
			this.txtSR.TabIndex = 0;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(7, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(30, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Date";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(7, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(53, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Serial No.";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label3.Location = new System.Drawing.Point(139, 9);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(54, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Sales";
			//
			//frmProductSales
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 388);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Panel1);
			this.Name = "frmProductSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product Sales";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.TextBox txtSR;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox cboProduct;
		internal System.Windows.Forms.TextBox txtRate;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtAmount;
		internal System.Windows.Forms.TextBox txtQuantity;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label3;
	}
	
}
