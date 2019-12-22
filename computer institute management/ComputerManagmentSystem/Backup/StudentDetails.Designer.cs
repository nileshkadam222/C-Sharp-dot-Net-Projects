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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class StudentDetails : System.Windows.Forms.Form
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
			this.TabControl1 = new System.Windows.Forms.TabControl();
			base.Load += new System.EventHandler(StudentDetails_Load);
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnNextScreen = new System.Windows.Forms.Button();
			this.btnNextScreen.Click += new System.EventHandler(this.btnNextScreen_Click);
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
			this.Label14 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.txtTotalFees = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtPhoneNo = new System.Windows.Forms.TextBox();
			this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
			this.Label8 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.cboCourseName = new System.Windows.Forms.ComboBox();
			this.cboCourseName.SelectedIndexChanged += new System.EventHandler(this.cboCourseName_SelectedIndexChanged);
			this.dtpDob = new System.Windows.Forms.DateTimePicker();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label3.Click += new System.EventHandler(this.Label3_Click);
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtRollNo = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.btnPreviousScreen = new System.Windows.Forms.Button();
			this.btnPreviousScreen.Click += new System.EventHandler(this.btnPreviousScreen_Click);
			this.btnNextScreen2 = new System.Windows.Forms.Button();
			this.btnNextScreen2.Click += new System.EventHandler(this.btnNextScreen2_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear2 = new System.Windows.Forms.Button();
			this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
			this.Label56 = new System.Windows.Forms.Label();
			this.txtAmountPaid = new System.Windows.Forms.TextBox();
			this.Label55 = new System.Windows.Forms.Label();
			this.txtChequeNo = new System.Windows.Forms.TextBox();
			this.Label54 = new System.Windows.Forms.Label();
			this.txtNameOfBank = new System.Windows.Forms.TextBox();
			this.Label53 = new System.Windows.Forms.Label();
			this.cboPaymentMode = new System.Windows.Forms.ComboBox();
			this.cboPaymentMode.SelectedIndexChanged += new System.EventHandler(this.cboPaymentMode_SelectedIndexChanged);
			this.Label52 = new System.Windows.Forms.Label();
			this.txtReceiptNo = new System.Windows.Forms.TextBox();
			this.Label50 = new System.Windows.Forms.Label();
			this.txtTotalfee = new System.Windows.Forms.TextBox();
			this.txtTotalfee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalfee_KeyPress);
			this.Label48 = new System.Windows.Forms.Label();
			this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
			this.txtDiscountPercentage.Leave += new System.EventHandler(this.txtDiscountPercentage_Leave);
			this.txtDiscountPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountPercentage_KeyPress);
			this.Label47 = new System.Windows.Forms.Label();
			this.txtDicountAmount = new System.Windows.Forms.TextBox();
			this.Label45 = new System.Windows.Forms.Label();
			this.txtFee = new System.Windows.Forms.TextBox();
			this.Label46 = new System.Windows.Forms.Label();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtKnowledge = new System.Windows.Forms.TextBox();
			this.cboOccupation = new System.Windows.Forms.ComboBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.cboQualification = new System.Windows.Forms.ComboBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.btnPreviousScreen3 = new System.Windows.Forms.Button();
			this.btnPreviousScreen3.Click += new System.EventHandler(this.btnPreviousScreen3_Click);
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.BtnClear3 = new System.Windows.Forms.Button();
			this.BtnClear3.Click += new System.EventHandler(this.BtnClear3_Click);
			this.btnSave1 = new System.Windows.Forms.Button();
			this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.txtHusbandName = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtMotherName = new System.Windows.Forms.TextBox();
			this.txtFatherName = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.BtnUpdateSearch = new System.Windows.Forms.Button();
			this.BtnUpdateSearch.Click += new System.EventHandler(this.BtnUpdateSearch_Click);
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.cboStudent = new System.Windows.Forms.ComboBox();
			this.cboStudent.SelectedIndexChanged += new System.EventHandler(this.cboStudent_SelectedIndexChanged);
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
			this.dgvSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseDoubleClick);
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).BeginInit();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Location = new System.Drawing.Point(4, 44);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(751, 582);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.GroupBox3);
			this.TabPage1.Controls.Add(this.GroupBox2);
			this.TabPage1.Controls.Add(this.GroupBox1);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(743, 556);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Personal information";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.btnClear);
			this.GroupBox3.Controls.Add(this.btnNextScreen);
			this.GroupBox3.Location = new System.Drawing.Point(67, 473);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(561, 103);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(306, 34);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnNextScreen
			//
			this.btnNextScreen.Location = new System.Drawing.Point(105, 34);
			this.btnNextScreen.Name = "btnNextScreen";
			this.btnNextScreen.Size = new System.Drawing.Size(122, 23);
			this.btnNextScreen.TabIndex = 11;
			this.btnNextScreen.Text = "NEXT SCREEN";
			this.btnNextScreen.UseVisualStyleBackColor = true;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Label14);
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.txtAddress);
			this.GroupBox2.Location = new System.Drawing.Point(67, 368);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(561, 87);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Address";
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
			this.txtAddress.TabIndex = 9;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.cboGender);
			this.GroupBox1.Controls.Add(this.txtTotalFees);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.txtPhoneNo);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.txtEmail);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboCourseName);
			this.GroupBox1.Controls.Add(this.dtpDob);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.dtpDate);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txtStudentName);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtRollNo);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(67, 45);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(561, 289);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Student Details";
			//
			//cboGender
			//
			this.cboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Items.AddRange(new object[] {"Female", "Male"});
			this.cboGender.Location = new System.Drawing.Point(127, 148);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(159, 21);
			this.cboGender.TabIndex = 5;
			//
			//txtTotalFees
			//
			this.txtTotalFees.Location = new System.Drawing.Point(127, 263);
			this.txtTotalFees.Name = "txtTotalFees";
			this.txtTotalFees.ReadOnly = true;
			this.txtTotalFees.Size = new System.Drawing.Size(127, 20);
			this.txtTotalFees.TabIndex = 8;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(31, 266);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(34, 13);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "FEES";
			//
			//txtPhoneNo
			//
			this.txtPhoneNo.Location = new System.Drawing.Point(127, 230);
			this.txtPhoneNo.Name = "txtPhoneNo";
			this.txtPhoneNo.Size = new System.Drawing.Size(391, 20);
			this.txtPhoneNo.TabIndex = 7;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(34, 233);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(64, 13);
			this.Label8.TabIndex = 15;
			this.Label8.Text = "PHONE NO";
			//
			//txtEmail
			//
			this.txtEmail.Location = new System.Drawing.Point(127, 186);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(391, 20);
			this.txtEmail.TabIndex = 6;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(34, 193);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(39, 13);
			this.Label7.TabIndex = 13;
			this.Label7.Text = "EMAIL";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(29, 151);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(53, 13);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "GENDER";
			//
			//cboCourseName
			//
			this.cboCourseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboCourseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboCourseName.FormattingEnabled = true;
			this.cboCourseName.Location = new System.Drawing.Point(359, 111);
			this.cboCourseName.Name = "cboCourseName";
			this.cboCourseName.Size = new System.Drawing.Size(159, 21);
			this.cboCourseName.TabIndex = 4;
			//
			//dtpDob
			//
			this.dtpDob.Location = new System.Drawing.Point(127, 110);
			this.dtpDob.Name = "dtpDob";
			this.dtpDob.Size = new System.Drawing.Size(127, 20);
			this.dtpDob.TabIndex = 3;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(267, 114);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(86, 13);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "COURSE NAME";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(31, 114);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(30, 13);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "DOB";
			//
			//dtpDate
			//
			this.dtpDate.Location = new System.Drawing.Point(355, 33);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(163, 20);
			this.dtpDate.TabIndex = 1;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(267, 34);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(36, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "DATE";
			//
			//txtStudentName
			//
			this.txtStudentName.Location = new System.Drawing.Point(127, 74);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(391, 20);
			this.txtStudentName.TabIndex = 2;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(28, 77);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(93, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "STUDENT NAME";
			//
			//txtRollNo
			//
			this.txtRollNo.Location = new System.Drawing.Point(127, 34);
			this.txtRollNo.Name = "txtRollNo";
			this.txtRollNo.Size = new System.Drawing.Size(100, 20);
			this.txtRollNo.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(28, 37);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(54, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "ROLL NO";
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.GroupBox4);
			this.TabPage2.Controls.Add(this.Label56);
			this.TabPage2.Controls.Add(this.txtAmountPaid);
			this.TabPage2.Controls.Add(this.Label55);
			this.TabPage2.Controls.Add(this.txtChequeNo);
			this.TabPage2.Controls.Add(this.Label54);
			this.TabPage2.Controls.Add(this.txtNameOfBank);
			this.TabPage2.Controls.Add(this.Label53);
			this.TabPage2.Controls.Add(this.cboPaymentMode);
			this.TabPage2.Controls.Add(this.Label52);
			this.TabPage2.Controls.Add(this.txtReceiptNo);
			this.TabPage2.Controls.Add(this.Label50);
			this.TabPage2.Controls.Add(this.txtTotalfee);
			this.TabPage2.Controls.Add(this.Label48);
			this.TabPage2.Controls.Add(this.txtDiscountPercentage);
			this.TabPage2.Controls.Add(this.Label47);
			this.TabPage2.Controls.Add(this.txtDicountAmount);
			this.TabPage2.Controls.Add(this.Label45);
			this.TabPage2.Controls.Add(this.txtFee);
			this.TabPage2.Controls.Add(this.Label46);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(743, 556);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Fees Detail";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.btnPreviousScreen);
			this.GroupBox4.Controls.Add(this.btnNextScreen2);
			this.GroupBox4.Controls.Add(this.btnSave);
			this.GroupBox4.Controls.Add(this.btnClear2);
			this.GroupBox4.Location = new System.Drawing.Point(94, 400);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(572, 112);
			this.GroupBox4.TabIndex = 116;
			this.GroupBox4.TabStop = false;
			//
			//btnPreviousScreen
			//
			this.btnPreviousScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.btnPreviousScreen.Location = new System.Drawing.Point(397, 43);
			this.btnPreviousScreen.Name = "btnPreviousScreen";
			this.btnPreviousScreen.Size = new System.Drawing.Size(138, 27);
			this.btnPreviousScreen.TabIndex = 12;
			this.btnPreviousScreen.Text = "&Previous Screen";
			this.btnPreviousScreen.UseVisualStyleBackColor = true;
			//
			//btnNextScreen2
			//
			this.btnNextScreen2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.btnNextScreen2.Location = new System.Drawing.Point(269, 43);
			this.btnNextScreen2.Name = "btnNextScreen2";
			this.btnNextScreen2.Size = new System.Drawing.Size(106, 27);
			this.btnNextScreen2.TabIndex = 11;
			this.btnNextScreen2.Text = "&Next Screen";
			this.btnNextScreen2.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.btnSave.Location = new System.Drawing.Point(38, 43);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 27);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//btnClear2
			//
			this.btnClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.btnClear2.Location = new System.Drawing.Point(157, 43);
			this.btnClear2.Name = "btnClear2";
			this.btnClear2.Size = new System.Drawing.Size(100, 27);
			this.btnClear2.TabIndex = 10;
			this.btnClear2.Text = "&Clear";
			this.btnClear2.UseVisualStyleBackColor = true;
			//
			//Label56
			//
			this.Label56.AutoSize = true;
			this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label56.Location = new System.Drawing.Point(474, 173);
			this.Label56.Name = "Label56";
			this.Label56.Size = new System.Drawing.Size(167, 15);
			this.Label56.TabIndex = 114;
			this.Label56.Text = "(Inclusive of Service Tax)";
			//
			//txtAmountPaid
			//
			this.txtAmountPaid.Location = new System.Drawing.Point(494, 146);
			this.txtAmountPaid.Name = "txtAmountPaid";
			this.txtAmountPaid.ReadOnly = true;
			this.txtAmountPaid.Size = new System.Drawing.Size(113, 20);
			this.txtAmountPaid.TabIndex = 4;
			//
			//Label55
			//
			this.Label55.AutoSize = true;
			this.Label55.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label55.Location = new System.Drawing.Point(344, 146);
			this.Label55.Name = "Label55";
			this.Label55.Size = new System.Drawing.Size(140, 16);
			this.Label55.TabIndex = 113;
			this.Label55.Text = "Amount To be Paid";
			//
			//txtChequeNo
			//
			this.txtChequeNo.Location = new System.Drawing.Point(185, 335);
			this.txtChequeNo.Name = "txtChequeNo";
			this.txtChequeNo.Size = new System.Drawing.Size(113, 20);
			this.txtChequeNo.TabIndex = 8;
			//
			//Label54
			//
			this.Label54.AutoSize = true;
			this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label54.Location = new System.Drawing.Point(16, 335);
			this.Label54.Name = "Label54";
			this.Label54.Size = new System.Drawing.Size(112, 16);
			this.Label54.TabIndex = 111;
			this.Label54.Text = "DD/Cheque No";
			//
			//txtNameOfBank
			//
			this.txtNameOfBank.Location = new System.Drawing.Point(185, 288);
			this.txtNameOfBank.Name = "txtNameOfBank";
			this.txtNameOfBank.Size = new System.Drawing.Size(443, 20);
			this.txtNameOfBank.TabIndex = 7;
			//
			//Label53
			//
			this.Label53.AutoSize = true;
			this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label53.Location = new System.Drawing.Point(16, 288);
			this.Label53.Name = "Label53";
			this.Label53.Size = new System.Drawing.Size(130, 16);
			this.Label53.TabIndex = 109;
			this.Label53.Text = "Name of the Bank";
			//
			//cboPaymentMode
			//
			this.cboPaymentMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboPaymentMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboPaymentMode.FormattingEnabled = true;
			this.cboPaymentMode.Items.AddRange(new object[] {"CASH", "CHEQUE", "DEMAND DRAFT"});
			this.cboPaymentMode.Location = new System.Drawing.Point(185, 242);
			this.cboPaymentMode.Name = "cboPaymentMode";
			this.cboPaymentMode.Size = new System.Drawing.Size(164, 21);
			this.cboPaymentMode.TabIndex = 6;
			//
			//Label52
			//
			this.Label52.AutoSize = true;
			this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label52.Location = new System.Drawing.Point(16, 243);
			this.Label52.Name = "Label52";
			this.Label52.Size = new System.Drawing.Size(111, 16);
			this.Label52.TabIndex = 106;
			this.Label52.Text = "Payment Mode";
			//
			//txtReceiptNo
			//
			this.txtReceiptNo.Location = new System.Drawing.Point(185, 196);
			this.txtReceiptNo.Name = "txtReceiptNo";
			this.txtReceiptNo.Size = new System.Drawing.Size(113, 20);
			this.txtReceiptNo.TabIndex = 5;
			//
			//Label50
			//
			this.Label50.AutoSize = true;
			this.Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label50.Location = new System.Drawing.Point(16, 196);
			this.Label50.Name = "Label50";
			this.Label50.Size = new System.Drawing.Size(86, 16);
			this.Label50.TabIndex = 103;
			this.Label50.Text = "Receipt No";
			//
			//txtTotalfee
			//
			this.txtTotalfee.Location = new System.Drawing.Point(185, 146);
			this.txtTotalfee.Name = "txtTotalfee";
			this.txtTotalfee.Size = new System.Drawing.Size(113, 20);
			this.txtTotalfee.TabIndex = 3;
			//
			//Label48
			//
			this.Label48.AutoSize = true;
			this.Label48.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label48.Location = new System.Drawing.Point(16, 150);
			this.Label48.Name = "Label48";
			this.Label48.Size = new System.Drawing.Size(83, 16);
			this.Label48.TabIndex = 99;
			this.Label48.Text = "Total Fees";
			//
			//txtDiscountPercentage
			//
			this.txtDiscountPercentage.Location = new System.Drawing.Point(185, 108);
			this.txtDiscountPercentage.Name = "txtDiscountPercentage";
			this.txtDiscountPercentage.Size = new System.Drawing.Size(113, 20);
			this.txtDiscountPercentage.TabIndex = 1;
			//
			//Label47
			//
			this.Label47.AutoSize = true;
			this.Label47.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label47.Location = new System.Drawing.Point(16, 112);
			this.Label47.Name = "Label47";
			this.Label47.Size = new System.Drawing.Size(152, 16);
			this.Label47.TabIndex = 97;
			this.Label47.Text = "Discount Percentage";
			//
			//txtDicountAmount
			//
			this.txtDicountAmount.Location = new System.Drawing.Point(494, 108);
			this.txtDicountAmount.Name = "txtDicountAmount";
			this.txtDicountAmount.ReadOnly = true;
			this.txtDicountAmount.Size = new System.Drawing.Size(113, 20);
			this.txtDicountAmount.TabIndex = 2;
			//
			//Label45
			//
			this.Label45.AutoSize = true;
			this.Label45.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label45.Location = new System.Drawing.Point(361, 111);
			this.Label45.Name = "Label45";
			this.Label45.Size = new System.Drawing.Size(123, 16);
			this.Label45.TabIndex = 95;
			this.Label45.Text = "Discount Amount";
			//
			//txtFee
			//
			this.txtFee.Location = new System.Drawing.Point(185, 72);
			this.txtFee.Name = "txtFee";
			this.txtFee.ReadOnly = true;
			this.txtFee.Size = new System.Drawing.Size(113, 20);
			this.txtFee.TabIndex = 0;
			//
			//Label46
			//
			this.Label46.AutoSize = true;
			this.Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label46.Location = new System.Drawing.Point(16, 72);
			this.Label46.Name = "Label46";
			this.Label46.Size = new System.Drawing.Size(35, 16);
			this.Label46.TabIndex = 93;
			this.Label46.Text = "Fee";
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.GroupBox9);
			this.TabPage3.Controls.Add(this.GroupBox6);
			this.TabPage3.Controls.Add(this.GroupBox5);
			this.TabPage3.Location = new System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new System.Drawing.Size(743, 556);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Other information";
			this.TabPage3.UseVisualStyleBackColor = true;
			//
			//GroupBox9
			//
			this.GroupBox9.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox9.Controls.Add(this.Label15);
			this.GroupBox9.Controls.Add(this.txtKnowledge);
			this.GroupBox9.Controls.Add(this.cboOccupation);
			this.GroupBox9.Controls.Add(this.Label17);
			this.GroupBox9.Controls.Add(this.cboQualification);
			this.GroupBox9.Controls.Add(this.Label18);
			this.GroupBox9.Location = new System.Drawing.Point(25, 221);
			this.GroupBox9.Name = "GroupBox9";
			this.GroupBox9.Size = new System.Drawing.Size(710, 171);
			this.GroupBox9.TabIndex = 73;
			this.GroupBox9.TabStop = false;
			//
			//Label15
			//
			this.Label15.Location = new System.Drawing.Point(28, 102);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label15.Size = new System.Drawing.Size(112, 61);
			this.Label15.TabIndex = 78;
			this.Label15.Text = "PRIOR COMPUTER KNOWLEDGE";
			//
			//txtKnowledge
			//
			this.txtKnowledge.Location = new System.Drawing.Point(160, 95);
			this.txtKnowledge.Multiline = true;
			this.txtKnowledge.Name = "txtKnowledge";
			this.txtKnowledge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtKnowledge.Size = new System.Drawing.Size(535, 52);
			this.txtKnowledge.TabIndex = 5;
			//
			//cboOccupation
			//
			this.cboOccupation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboOccupation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboOccupation.FormattingEnabled = true;
			this.cboOccupation.Items.AddRange(new object[] {"STUDENT", "SERVICE", "BUSINESS", "HOUSE WIFE"});
			this.cboOccupation.Location = new System.Drawing.Point(488, 37);
			this.cboOccupation.Name = "cboOccupation";
			this.cboOccupation.Size = new System.Drawing.Size(205, 21);
			this.cboOccupation.TabIndex = 4;
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Location = new System.Drawing.Point(385, 43);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(77, 13);
			this.Label17.TabIndex = 76;
			this.Label17.Text = "OCCUPATION";
			//
			//cboQualification
			//
			this.cboQualification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboQualification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboQualification.FormattingEnabled = true;
			this.cboQualification.Items.AddRange(new object[] {"HIGH SCHOOL", "INTERMEDIATE", "UNDER GRADUATE", "GRADUATE", "POST GRADUATE", "DIPLOMA HOLDER"});
			this.cboQualification.Location = new System.Drawing.Point(171, 37);
			this.cboQualification.Name = "cboQualification";
			this.cboQualification.Size = new System.Drawing.Size(197, 21);
			this.cboQualification.TabIndex = 3;
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Location = new System.Drawing.Point(16, 43);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(88, 13);
			this.Label18.TabIndex = 75;
			this.Label18.Text = "QUALIFICATION";
			//
			//GroupBox6
			//
			this.GroupBox6.Controls.Add(this.btnDelete);
			this.GroupBox6.Controls.Add(this.btnUpdate);
			this.GroupBox6.Controls.Add(this.btnPreviousScreen3);
			this.GroupBox6.Controls.Add(this.btnExit);
			this.GroupBox6.Controls.Add(this.BtnClear3);
			this.GroupBox6.Controls.Add(this.btnSave1);
			this.GroupBox6.Location = new System.Drawing.Point(76, 426);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.Size = new System.Drawing.Size(589, 89);
			this.GroupBox6.TabIndex = 72;
			this.GroupBox6.TabStop = false;
			//
			//btnDelete
			//
			this.btnDelete.Location = new System.Drawing.Point(143, 23);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(104, 27);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//btnUpdate
			//
			this.btnUpdate.Location = new System.Drawing.Point(22, 23);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 27);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			//
			//btnPreviousScreen3
			//
			this.btnPreviousScreen3.Location = new System.Drawing.Point(274, 23);
			this.btnPreviousScreen3.Name = "btnPreviousScreen3";
			this.btnPreviousScreen3.Size = new System.Drawing.Size(100, 27);
			this.btnPreviousScreen3.TabIndex = 8;
			this.btnPreviousScreen3.Text = "Previous Screen";
			this.btnPreviousScreen3.UseVisualStyleBackColor = true;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(436, 22);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(106, 27);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "&Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//BtnClear3
			//
			this.BtnClear3.Location = new System.Drawing.Point(143, 22);
			this.BtnClear3.Name = "BtnClear3";
			this.BtnClear3.Size = new System.Drawing.Size(100, 27);
			this.BtnClear3.TabIndex = 7;
			this.BtnClear3.Text = "&Clear";
			this.BtnClear3.UseVisualStyleBackColor = true;
			//
			//btnSave1
			//
			this.btnSave1.Location = new System.Drawing.Point(22, 22);
			this.btnSave1.Name = "btnSave1";
			this.btnSave1.Size = new System.Drawing.Size(104, 27);
			this.btnSave1.TabIndex = 6;
			this.btnSave1.Text = "&Save";
			this.btnSave1.UseVisualStyleBackColor = true;
			//
			//GroupBox5
			//
			this.GroupBox5.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox5.Controls.Add(this.txtHusbandName);
			this.GroupBox5.Controls.Add(this.Label11);
			this.GroupBox5.Controls.Add(this.txtMotherName);
			this.GroupBox5.Controls.Add(this.txtFatherName);
			this.GroupBox5.Controls.Add(this.Label12);
			this.GroupBox5.Controls.Add(this.Label13);
			this.GroupBox5.Location = new System.Drawing.Point(25, 9);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(667, 189);
			this.GroupBox5.TabIndex = 71;
			this.GroupBox5.TabStop = false;
			//
			//txtHusbandName
			//
			this.txtHusbandName.Location = new System.Drawing.Point(194, 138);
			this.txtHusbandName.Name = "txtHusbandName";
			this.txtHusbandName.Size = new System.Drawing.Size(455, 20);
			this.txtHusbandName.TabIndex = 2;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(44, 141);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(103, 13);
			this.Label11.TabIndex = 61;
			this.Label11.Text = "HUSBAND\'S NAME";
			//
			//txtMotherName
			//
			this.txtMotherName.Location = new System.Drawing.Point(194, 91);
			this.txtMotherName.Name = "txtMotherName";
			this.txtMotherName.Size = new System.Drawing.Size(455, 20);
			this.txtMotherName.TabIndex = 1;
			//
			//txtFatherName
			//
			this.txtFatherName.Location = new System.Drawing.Point(194, 40);
			this.txtFatherName.Name = "txtFatherName";
			this.txtFatherName.Size = new System.Drawing.Size(455, 20);
			this.txtFatherName.TabIndex = 0;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(48, 43);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(93, 13);
			this.Label12.TabIndex = 30;
			this.Label12.Text = "FATHER\'S NAME";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(44, 94);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(97, 13);
			this.Label13.TabIndex = 31;
			this.Label13.Text = "MOTHER\'S NAME";
			//
			//BtnUpdateSearch
			//
			this.BtnUpdateSearch.Location = new System.Drawing.Point(682, 25);
			this.BtnUpdateSearch.Name = "BtnUpdateSearch";
			this.BtnUpdateSearch.Size = new System.Drawing.Size(75, 23);
			this.BtnUpdateSearch.TabIndex = 13;
			this.BtnUpdateSearch.Text = "Update";
			this.BtnUpdateSearch.UseVisualStyleBackColor = true;
			//
			//pnlSearch
			//
			this.pnlSearch.Controls.Add(this.btnClose);
			this.pnlSearch.Controls.Add(this.cboStudent);
			this.pnlSearch.Controls.Add(this.dgvSearch);
			this.pnlSearch.Location = new System.Drawing.Point(63, 44);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(520, 523);
			this.pnlSearch.TabIndex = 2;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(223, 483);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//cboStudent
			//
			this.cboStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboStudent.FormattingEnabled = true;
			this.cboStudent.Location = new System.Drawing.Point(162, 31);
			this.cboStudent.Name = "cboStudent";
			this.cboStudent.Size = new System.Drawing.Size(196, 21);
			this.cboStudent.TabIndex = 1;
			//
			//dgvSearch
			//
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Location = new System.Drawing.Point(7, 97);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(504, 368);
			this.dgvSearch.TabIndex = 0;
			//
			//StudentDetails
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 628);
			this.Controls.Add(this.BtnUpdateSearch);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.pnlSearch);
			this.Name = "StudentDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentDetails";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.GroupBox9.ResumeLayout(false);
			this.GroupBox9.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.pnlSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).EndInit();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtStudentName;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtRollNo;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox cboCourseName;
		internal System.Windows.Forms.DateTimePicker dtpDob;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtEmail;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.TextBox txtTotalFees;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtPhoneNo;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnNextScreen;
		internal System.Windows.Forms.Label Label56;
		internal System.Windows.Forms.TextBox txtAmountPaid;
		internal System.Windows.Forms.Label Label55;
		internal System.Windows.Forms.TextBox txtChequeNo;
		internal System.Windows.Forms.Label Label54;
		internal System.Windows.Forms.TextBox txtNameOfBank;
		internal System.Windows.Forms.Label Label53;
		internal System.Windows.Forms.ComboBox cboPaymentMode;
		internal System.Windows.Forms.Label Label52;
		internal System.Windows.Forms.TextBox txtReceiptNo;
		internal System.Windows.Forms.Label Label50;
		internal System.Windows.Forms.TextBox txtTotalfee;
		internal System.Windows.Forms.Label Label48;
		internal System.Windows.Forms.TextBox txtDiscountPercentage;
		internal System.Windows.Forms.Label Label47;
		internal System.Windows.Forms.TextBox txtDicountAmount;
		internal System.Windows.Forms.Label Label45;
		internal System.Windows.Forms.TextBox txtFee;
		internal System.Windows.Forms.Label Label46;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Button btnPreviousScreen;
		internal System.Windows.Forms.Button btnNextScreen2;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Button btnClear2;
		internal System.Windows.Forms.GroupBox GroupBox9;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtKnowledge;
		internal System.Windows.Forms.ComboBox cboOccupation;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.ComboBox cboQualification;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button BtnClear3;
		internal System.Windows.Forms.Button btnSave1;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.TextBox txtHusbandName;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtMotherName;
		internal System.Windows.Forms.TextBox txtFatherName;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtAddress;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Button btnPreviousScreen3;
		internal System.Windows.Forms.ComboBox cboGender;
		internal System.Windows.Forms.Button BtnUpdateSearch;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnUpdate;
		internal System.Windows.Forms.Panel pnlSearch;
		internal System.Windows.Forms.DataGridView dgvSearch;
		internal System.Windows.Forms.ComboBox cboStudent;
		internal System.Windows.Forms.Button btnClose;
	}
	
}
