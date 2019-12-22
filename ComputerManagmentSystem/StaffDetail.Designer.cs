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

namespace ComputerManagmentSystem
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class StaffDetail : System.Windows.Forms.Form
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(StaffDetail_Load);
			this.txtStaffNo = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtEmailId = new System.Windows.Forms.TextBox();
			this.txtPhoneNo = new System.Windows.Forms.TextBox();
			this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtExperience = new System.Windows.Forms.TextBox();
			this.txtQualification = new System.Windows.Forms.TextBox();
			this.dtpDob = new System.Windows.Forms.DateTimePicker();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.cboStaff = new System.Windows.Forms.ComboBox();
			this.cboStaff.SelectedIndexChanged += new System.EventHandler(this.cboStaff_SelectedIndexChanged);
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.dgvSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseDoubleClick);
			this.pnlStaffDetails = new System.Windows.Forms.Panel();
			this.btnSearchUpdate = new System.Windows.Forms.Button();
			this.btnSearchUpdate.Click += new System.EventHandler(this.btnSearchUpdate_Click);
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).BeginInit();
			this.pnlStaffDetails.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.txtStaffNo);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.txtEmailId);
			this.GroupBox1.Controls.Add(this.txtPhoneNo);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.txtExperience);
			this.GroupBox1.Controls.Add(this.txtQualification);
			this.GroupBox1.Controls.Add(this.dtpDob);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(19, 20);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(593, 291);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "GroupBox1";
			//
			//txtStaffNo
			//
			this.txtStaffNo.Location = new System.Drawing.Point(133, 16);
			this.txtStaffNo.Name = "txtStaffNo";
			this.txtStaffNo.Size = new System.Drawing.Size(218, 20);
			this.txtStaffNo.TabIndex = 0;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(37, 16);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(70, 13);
			this.Label8.TabIndex = 14;
			this.Label8.Text = "Employee No";
			//
			//txtEmailId
			//
			this.txtEmailId.Location = new System.Drawing.Point(133, 248);
			this.txtEmailId.Name = "txtEmailId";
			this.txtEmailId.Size = new System.Drawing.Size(355, 20);
			this.txtEmailId.TabIndex = 6;
			//
			//txtPhoneNo
			//
			this.txtPhoneNo.Location = new System.Drawing.Point(133, 206);
			this.txtPhoneNo.Name = "txtPhoneNo";
			this.txtPhoneNo.Size = new System.Drawing.Size(218, 20);
			this.txtPhoneNo.TabIndex = 5;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(40, 250);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(53, 13);
			this.Label7.TabIndex = 11;
			this.Label7.Text = "EMAIL ID";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(40, 213);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(64, 13);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "PHONE NO";
			//
			//txtExperience
			//
			this.txtExperience.Location = new System.Drawing.Point(133, 175);
			this.txtExperience.Name = "txtExperience";
			this.txtExperience.Size = new System.Drawing.Size(218, 20);
			this.txtExperience.TabIndex = 4;
			//
			//txtQualification
			//
			this.txtQualification.Location = new System.Drawing.Point(133, 136);
			this.txtQualification.Name = "txtQualification";
			this.txtQualification.Size = new System.Drawing.Size(218, 20);
			this.txtQualification.TabIndex = 3;
			//
			//dtpDob
			//
			this.dtpDob.Location = new System.Drawing.Point(133, 93);
			this.dtpDob.Name = "dtpDob";
			this.dtpDob.Size = new System.Drawing.Size(166, 20);
			this.dtpDob.TabIndex = 2;
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(133, 53);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(218, 20);
			this.txtName.TabIndex = 1;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(37, 178);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(75, 13);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "EXPERIENCE";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(37, 139);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(88, 13);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "QUALIFICATION";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(37, 97);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(30, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "DOB";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(37, 53);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(38, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "NAME";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Label14);
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.txtAddress);
			this.GroupBox2.Location = new System.Drawing.Point(19, 320);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(593, 70);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "GroupBox2";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(31, 38);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(59, 13);
			this.Label14.TabIndex = 72;
			this.Label14.Text = "ADDRESS";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(-78, 34);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(59, 13);
			this.Label10.TabIndex = 71;
			this.Label10.Text = "ADDRESS";
			//
			//txtAddress
			//
			this.txtAddress.Location = new System.Drawing.Point(159, 19);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAddress.Size = new System.Drawing.Size(359, 41);
			this.txtAddress.TabIndex = 7;
			//
			//GroupBox3
			//
			this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox3.Controls.Add(this.btnDelete);
			this.GroupBox3.Controls.Add(this.btnUpdate);
			this.GroupBox3.Controls.Add(this.btnExit);
			this.GroupBox3.Controls.Add(this.btnClear);
			this.GroupBox3.Controls.Add(this.btnSave);
			this.GroupBox3.Location = new System.Drawing.Point(62, 396);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(473, 73);
			this.GroupBox3.TabIndex = 102;
			this.GroupBox3.TabStop = false;
			//
			//btnDelete
			//
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.Location = new System.Drawing.Point(184, 22);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(104, 27);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			//
			//btnUpdate
			//
			this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
			this.btnUpdate.Location = new System.Drawing.Point(32, 22);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 27);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(332, 22);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(106, 27);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(188, 22);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 27);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.Location = new System.Drawing.Point(32, 22);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 27);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			//
			//pnlSearch
			//
			this.pnlSearch.Controls.Add(this.btnClose);
			this.pnlSearch.Controls.Add(this.cboStaff);
			this.pnlSearch.Controls.Add(this.dgvSearch);
			this.pnlSearch.Location = new System.Drawing.Point(23, 51);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(564, 519);
			this.pnlSearch.TabIndex = 103;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(245, 477);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//cboStaff
			//
			this.cboStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboStaff.FormattingEnabled = true;
			this.cboStaff.Location = new System.Drawing.Point(162, 31);
			this.cboStaff.Name = "cboStaff";
			this.cboStaff.Size = new System.Drawing.Size(196, 21);
			this.cboStaff.TabIndex = 1;
			//
			//dgvSearch
			//
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Location = new System.Drawing.Point(7, 97);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(504, 368);
			this.dgvSearch.TabIndex = 0;
			//
			//pnlStaffDetails
			//
			this.pnlStaffDetails.Controls.Add(this.GroupBox1);
			this.pnlStaffDetails.Controls.Add(this.GroupBox2);
			this.pnlStaffDetails.Controls.Add(this.GroupBox3);
			this.pnlStaffDetails.Location = new System.Drawing.Point(29, 56);
			this.pnlStaffDetails.Name = "pnlStaffDetails";
			this.pnlStaffDetails.Size = new System.Drawing.Size(624, 495);
			this.pnlStaffDetails.TabIndex = 16;
			//
			//btnSearchUpdate
			//
			this.btnSearchUpdate.BackColor = System.Drawing.Color.Transparent;
			this.btnSearchUpdate.Location = new System.Drawing.Point(550, 12);
			this.btnSearchUpdate.Name = "btnSearchUpdate";
			this.btnSearchUpdate.Size = new System.Drawing.Size(104, 27);
			this.btnSearchUpdate.TabIndex = 11;
			this.btnSearchUpdate.Text = "UPDATE";
			this.btnSearchUpdate.UseVisualStyleBackColor = false;
			//
			//StaffDetail
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 582);
			this.Controls.Add(this.btnSearchUpdate);
			this.Controls.Add(this.pnlStaffDetails);
			this.Controls.Add(this.pnlSearch);
			this.Name = "StaffDetail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StaffDetail";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).EndInit();
			this.pnlStaffDetails.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtEmailId;
		internal System.Windows.Forms.TextBox txtPhoneNo;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtExperience;
		internal System.Windows.Forms.TextBox txtQualification;
		internal System.Windows.Forms.DateTimePicker dtpDob;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtAddress;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.TextBox txtStaffNo;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnUpdate;
		internal System.Windows.Forms.Panel pnlSearch;
		internal System.Windows.Forms.ComboBox cboStaff;
		internal System.Windows.Forms.DataGridView dgvSearch;
		internal System.Windows.Forms.Panel pnlStaffDetails;
		internal System.Windows.Forms.Button btnSearchUpdate;
		internal System.Windows.Forms.Button btnClose;
	}
	
}
