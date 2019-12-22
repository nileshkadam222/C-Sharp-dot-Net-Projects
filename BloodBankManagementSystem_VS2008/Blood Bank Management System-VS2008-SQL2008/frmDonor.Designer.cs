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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmDonor : System.Windows.Forms.Form
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
			this.pnlSearch = new System.Windows.Forms.Panel();
			base.Load += new System.EventHandler(frmDonor_Load);
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.dgvSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSearch_MouseDoubleClick);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtDonorID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
			this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
			this.cboBloodGroup = new System.Windows.Forms.ComboBox();
			this.rtbAddress = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.Label7 = new System.Windows.Forms.Label();
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtDonorType = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtHIV = new System.Windows.Forms.TextBox();
			this.txtHemoglobin = new System.Windows.Forms.TextBox();
			this.txtPhysicalTest = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnSaveUpdate = new System.Windows.Forms.Button();
			this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.Label9 = new System.Windows.Forms.Label();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//pnlSearch
			//
			this.pnlSearch.Controls.Add(this.dgvSearch);
			this.pnlSearch.Location = new System.Drawing.Point(12, 41);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(443, 306);
			this.pnlSearch.TabIndex = 1;
			//
			//dgvSearch
			//
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Location = new System.Drawing.Point(14, 12);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(415, 259);
			this.dgvSearch.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(30, 36);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(50, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Donor ID";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(30, 72);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(35, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Name";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(30, 185);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(66, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Blood Group";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(340, 110);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(45, 13);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Address";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(340, 185);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(64, 13);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Contact No.";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(30, 110);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(26, 13);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "Age";
			//
			//txtDonorID
			//
			this.txtDonorID.Location = new System.Drawing.Point(137, 36);
			this.txtDonorID.Name = "txtDonorID";
			this.txtDonorID.ReadOnly = true;
			this.txtDonorID.Size = new System.Drawing.Size(180, 20);
			this.txtDonorID.TabIndex = 6;
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(137, 72);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(180, 20);
			this.txtName.TabIndex = 1;
			//
			//txtContact
			//
			this.txtContact.Location = new System.Drawing.Point(447, 182);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(180, 20);
			this.txtContact.TabIndex = 10;
			//
			//txtAge
			//
			this.txtAge.Location = new System.Drawing.Point(137, 110);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(180, 20);
			this.txtAge.TabIndex = 2;
			//
			//cboBloodGroup
			//
			this.cboBloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboBloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboBloodGroup.FormattingEnabled = true;
			this.cboBloodGroup.Items.AddRange(new object[] {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"});
			this.cboBloodGroup.Location = new System.Drawing.Point(137, 185);
			this.cboBloodGroup.Name = "cboBloodGroup";
			this.cboBloodGroup.Size = new System.Drawing.Size(180, 21);
			this.cboBloodGroup.TabIndex = 4;
			//
			//rtbAddress
			//
			this.rtbAddress.Location = new System.Drawing.Point(447, 110);
			this.rtbAddress.Name = "rtbAddress";
			this.rtbAddress.Size = new System.Drawing.Size(180, 50);
			this.rtbAddress.TabIndex = 9;
			this.rtbAddress.Text = "";
			//
			//btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(366, 305);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 33);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(459, 305);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 33);
			this.btnClear.TabIndex = 12;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(552, 305);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 33);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(30, 147);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(42, 13);
			this.Label7.TabIndex = 17;
			this.Label7.Text = "Gender";
			//
			//cboGender
			//
			this.cboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Items.AddRange(new object[] {"Male", "Female"});
			this.cboGender.Location = new System.Drawing.Point(137, 147);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(180, 21);
			this.cboGender.TabIndex = 3;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(30, 224);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(63, 13);
			this.Label8.TabIndex = 19;
			this.Label8.Text = "Donor Type";
			//
			//txtDonorType
			//
			this.txtDonorType.Location = new System.Drawing.Point(137, 224);
			this.txtDonorType.Name = "txtDonorType";
			this.txtDonorType.Size = new System.Drawing.Size(180, 20);
			this.txtDonorType.TabIndex = 5;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(30, 3);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(30, 13);
			this.Label10.TabIndex = 23;
			this.Label10.Text = "Date";
			//
			//dtpDate
			//
			this.dtpDate.CustomFormat = "dd/MM/yyyy";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(137, 3);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(180, 20);
			this.dtpDate.TabIndex = 0;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(340, 3);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(58, 13);
			this.Label12.TabIndex = 27;
			this.Label12.Text = "HIV Status";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(340, 36);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(87, 13);
			this.Label13.TabIndex = 28;
			this.Label13.Text = "Hemoglobin EST";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(340, 72);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(75, 13);
			this.Label14.TabIndex = 29;
			this.Label14.Text = "Physical Exam";
			//
			//txtHIV
			//
			this.txtHIV.Location = new System.Drawing.Point(447, 3);
			this.txtHIV.Name = "txtHIV";
			this.txtHIV.Size = new System.Drawing.Size(180, 20);
			this.txtHIV.TabIndex = 6;
			//
			//txtHemoglobin
			//
			this.txtHemoglobin.Location = new System.Drawing.Point(447, 33);
			this.txtHemoglobin.Name = "txtHemoglobin";
			this.txtHemoglobin.Size = new System.Drawing.Size(180, 20);
			this.txtHemoglobin.TabIndex = 7;
			//
			//txtPhysicalTest
			//
			this.txtPhysicalTest.Location = new System.Drawing.Point(447, 72);
			this.txtPhysicalTest.Name = "txtPhysicalTest";
			this.txtPhysicalTest.Size = new System.Drawing.Size(180, 20);
			this.txtPhysicalTest.TabIndex = 8;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.btnDelete);
			this.Panel1.Controls.Add(this.btnSaveUpdate);
			this.Panel1.Controls.Add(this.txtPhysicalTest);
			this.Panel1.Controls.Add(this.txtHemoglobin);
			this.Panel1.Controls.Add(this.txtHIV);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label12);
			this.Panel1.Controls.Add(this.dtpDate);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.txtDonorType);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.cboGender);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.btnExit);
			this.Panel1.Controls.Add(this.btnClear);
			this.Panel1.Controls.Add(this.btnSave);
			this.Panel1.Controls.Add(this.rtbAddress);
			this.Panel1.Controls.Add(this.cboBloodGroup);
			this.Panel1.Controls.Add(this.txtAge);
			this.Panel1.Controls.Add(this.txtContact);
			this.Panel1.Controls.Add(this.txtName);
			this.Panel1.Controls.Add(this.txtDonorID);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(12, 36);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(674, 345);
			this.Panel1.TabIndex = 0;
			//
			//btnDelete
			//
			this.btnDelete.Location = new System.Drawing.Point(459, 305);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 33);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//btnSaveUpdate
			//
			this.btnSaveUpdate.Location = new System.Drawing.Point(366, 305);
			this.btnSaveUpdate.Name = "btnSaveUpdate";
			this.btnSaveUpdate.Size = new System.Drawing.Size(75, 33);
			this.btnSaveUpdate.TabIndex = 11;
			this.btnSaveUpdate.Text = "Update";
			this.btnSaveUpdate.UseVisualStyleBackColor = true;
			//
			//btnUpdate
			//
			this.btnUpdate.Location = new System.Drawing.Point(611, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 33);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label9.Location = new System.Drawing.Point(320, 9);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(58, 20);
			this.Label9.TabIndex = 15;
			this.Label9.Text = "Donor";
			//
			//frmDonor
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 394);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.pnlSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmDonor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Donor";
			this.pnlSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Panel pnlSearch;
		internal System.Windows.Forms.DataGridView dgvSearch;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtDonorID;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.TextBox txtContact;
		internal System.Windows.Forms.TextBox txtAge;
		internal System.Windows.Forms.ComboBox cboBloodGroup;
		internal System.Windows.Forms.RichTextBox rtbAddress;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.ComboBox cboGender;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtDonorType;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtHIV;
		internal System.Windows.Forms.TextBox txtHemoglobin;
		internal System.Windows.Forms.TextBox txtPhysicalTest;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button btnUpdate;
		internal System.Windows.Forms.Button btnSaveUpdate;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Label Label9;
	}
	
}
