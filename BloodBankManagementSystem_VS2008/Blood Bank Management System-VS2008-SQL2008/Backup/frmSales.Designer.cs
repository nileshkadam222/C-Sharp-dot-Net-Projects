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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmSales : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSales_Load);
			this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			this.btnSaveUpdate = new System.Windows.Forms.Button();
			this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
			this.Label7 = new System.Windows.Forms.Label();
			this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			this.Label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.cboBloodGroup = new System.Windows.Forms.ComboBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.txtSR = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.dgvSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseDoubleClick);
			this.Panel1.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.btnSaveUpdate);
			this.Panel1.Controls.Add(this.btnDelete);
			this.Panel1.Controls.Add(this.txtAmount);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.dtpExpiryDate);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.txtQuantity);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.txtName);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.dtpDate);
			this.Panel1.Controls.Add(this.cboBloodGroup);
			this.Panel1.Controls.Add(this.btnExit);
			this.Panel1.Controls.Add(this.btnClear);
			this.Panel1.Controls.Add(this.btnSave);
			this.Panel1.Controls.Add(this.txtSR);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(12, 50);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(373, 326);
			this.Panel1.TabIndex = 3;
			//
			//btnSaveUpdate
			//
			this.btnSaveUpdate.Location = new System.Drawing.Point(44, 277);
			this.btnSaveUpdate.Name = "btnSaveUpdate";
			this.btnSaveUpdate.Size = new System.Drawing.Size(75, 33);
			this.btnSaveUpdate.TabIndex = 6;
			this.btnSaveUpdate.Text = "Update";
			this.btnSaveUpdate.UseVisualStyleBackColor = true;
			//
			//btnDelete
			//
			this.btnDelete.Location = new System.Drawing.Point(148, 277);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 33);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//txtAmount
			//
			this.txtAmount.Location = new System.Drawing.Point(148, 200);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(180, 20);
			this.txtAmount.TabIndex = 4;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(41, 200);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(43, 13);
			this.Label7.TabIndex = 27;
			this.Label7.Text = "Amount";
			//
			//dtpExpiryDate
			//
			this.dtpExpiryDate.CustomFormat = "dd/MM/yyyy";
			this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpExpiryDate.Location = new System.Drawing.Point(148, 238);
			this.dtpExpiryDate.Name = "dtpExpiryDate";
			this.dtpExpiryDate.Size = new System.Drawing.Size(180, 20);
			this.dtpExpiryDate.TabIndex = 5;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(41, 238);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(61, 13);
			this.Label6.TabIndex = 25;
			this.Label6.Text = "Expiry Date";
			//
			//txtQuantity
			//
			this.txtQuantity.Location = new System.Drawing.Point(148, 163);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(180, 20);
			this.txtQuantity.TabIndex = 3;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(41, 163);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(46, 13);
			this.Label5.TabIndex = 21;
			this.Label5.Text = "Quantity";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(148, 122);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(180, 20);
			this.txtName.TabIndex = 2;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(41, 122);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(71, 13);
			this.Label4.TabIndex = 19;
			this.Label4.Text = "Patient Name";
			//
			//dtpDate
			//
			this.dtpDate.CustomFormat = "dd/MM/yyyy";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(148, 48);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(180, 20);
			this.dtpDate.TabIndex = 0;
			//
			//cboBloodGroup
			//
			this.cboBloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboBloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboBloodGroup.FormattingEnabled = true;
			this.cboBloodGroup.Items.AddRange(new object[] {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"});
			this.cboBloodGroup.Location = new System.Drawing.Point(148, 85);
			this.cboBloodGroup.Name = "cboBloodGroup";
			this.cboBloodGroup.Size = new System.Drawing.Size(180, 21);
			this.cboBloodGroup.TabIndex = 1;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(253, 277);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 33);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(148, 277);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 33);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(44, 277);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 33);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//txtSR
			//
			this.txtSR.Location = new System.Drawing.Point(148, 13);
			this.txtSR.Name = "txtSR";
			this.txtSR.ReadOnly = true;
			this.txtSR.Size = new System.Drawing.Size(180, 20);
			this.txtSR.TabIndex = 0;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(41, 85);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(66, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Blood Group";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(41, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(30, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Date";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(41, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(53, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Serial No.";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label8.Location = new System.Drawing.Point(170, 9);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(61, 24);
			this.Label8.TabIndex = 4;
			this.Label8.Text = "Sales";
			//
			//btnUpdate
			//
			this.btnUpdate.Location = new System.Drawing.Point(310, 12);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 33);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			//
			//pnlSearch
			//
			this.pnlSearch.Controls.Add(this.dgvSearch);
			this.pnlSearch.Location = new System.Drawing.Point(12, 50);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(345, 306);
			this.pnlSearch.TabIndex = 18;
			//
			//dgvSearch
			//
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Location = new System.Drawing.Point(14, 12);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(316, 259);
			this.dgvSearch.TabIndex = 0;
			//
			//frmSales
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 387);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.pnlSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSales";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.pnlSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.TextBox txtQuantity;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.ComboBox cboBloodGroup;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.TextBox txtSR;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DateTimePicker dtpExpiryDate;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtAmount;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Button btnUpdate;
		internal System.Windows.Forms.Button btnSaveUpdate;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Panel pnlSearch;
		internal System.Windows.Forms.DataGridView dgvSearch;
	}
	
}
