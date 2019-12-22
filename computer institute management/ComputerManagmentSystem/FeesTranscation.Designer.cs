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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class FeesTranscation : System.Windows.Forms.Form
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
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(FeesTranscation_Load);
			this.GroupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
			this.cboRollNo = new System.Windows.Forms.ComboBox();
			this.cboRollNo.SelectedIndexChanged += new System.EventHandler(this.cboRollNo_SelectedIndexChanged);
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.PRINTFEE = new System.Windows.Forms.Button();
			this.QUIT1 = new System.Windows.Forms.Button();
			this.CLEAR1 = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtReceiptNo = new System.Windows.Forms.TextBox();
			this.Label50 = new System.Windows.Forms.Label();
			this.txtChequeNo = new System.Windows.Forms.TextBox();
			this.Label54 = new System.Windows.Forms.Label();
			this.txtNameOfBank = new System.Windows.Forms.TextBox();
			this.Label53 = new System.Windows.Forms.Label();
			this.cboPaymentMode = new System.Windows.Forms.ComboBox();
			this.Label52 = new System.Windows.Forms.Label();
			this.Label57 = new System.Windows.Forms.Label();
			this.Label56 = new System.Windows.Forms.Label();
			this.txtPaidAmount = new System.Windows.Forms.TextBox();
			this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
			this.Label11 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.dtpDate.ValueChanged += new System.EventHandler(this.DOF_ValueChanged);
			this.Label10 = new System.Windows.Forms.Label();
			this.txtPaidFees = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtFees = new System.Windows.Forms.TextBox();
			this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
			this.Label3 = new System.Windows.Forms.Label();
			this.txtTotalFees = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtBalanceAmount = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.GroupBox3.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox3.Controls.Add(this.cboRollNo);
			this.GroupBox3.Controls.Add(this.GroupBox6);
			this.GroupBox3.Controls.Add(this.Label1);
			this.GroupBox3.Controls.Add(this.txtReceiptNo);
			this.GroupBox3.Controls.Add(this.Label50);
			this.GroupBox3.Controls.Add(this.txtChequeNo);
			this.GroupBox3.Controls.Add(this.Label54);
			this.GroupBox3.Controls.Add(this.txtNameOfBank);
			this.GroupBox3.Controls.Add(this.Label53);
			this.GroupBox3.Controls.Add(this.cboPaymentMode);
			this.GroupBox3.Controls.Add(this.Label52);
			this.GroupBox3.Controls.Add(this.Label57);
			this.GroupBox3.Controls.Add(this.Label56);
			this.GroupBox3.Controls.Add(this.txtPaidAmount);
			this.GroupBox3.Controls.Add(this.Label11);
			this.GroupBox3.Controls.Add(this.dtpDate);
			this.GroupBox3.Controls.Add(this.Label10);
			this.GroupBox3.Controls.Add(this.txtPaidFees);
			this.GroupBox3.Controls.Add(this.Label9);
			this.GroupBox3.Controls.Add(this.txtFees);
			this.GroupBox3.Controls.Add(this.Label3);
			this.GroupBox3.Controls.Add(this.txtTotalFees);
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.txtBalanceAmount);
			this.GroupBox3.Controls.Add(this.Label8);
			this.GroupBox3.Location = new System.Drawing.Point(22, 33);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(581, 339);
			this.GroupBox3.TabIndex = 100;
			this.GroupBox3.TabStop = false;
			//
			//cboRollNo
			//
			this.cboRollNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboRollNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboRollNo.FormattingEnabled = true;
			this.cboRollNo.Location = new System.Drawing.Point(150, 20);
			this.cboRollNo.Name = "cboRollNo";
			this.cboRollNo.Size = new System.Drawing.Size(121, 21);
			this.cboRollNo.TabIndex = 0;
			//
			//GroupBox6
			//
			this.GroupBox6.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.GroupBox6.Controls.Add(this.PRINTFEE);
			this.GroupBox6.Controls.Add(this.QUIT1);
			this.GroupBox6.Controls.Add(this.CLEAR1);
			this.GroupBox6.Controls.Add(this.OK);
			this.GroupBox6.Location = new System.Drawing.Point(26, 369);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.Size = new System.Drawing.Size(529, 68);
			this.GroupBox6.TabIndex = 120;
			this.GroupBox6.TabStop = false;
			//
			//PRINTFEE
			//
			this.PRINTFEE.Location = new System.Drawing.Point(154, 22);
			this.PRINTFEE.Name = "PRINTFEE";
			this.PRINTFEE.Size = new System.Drawing.Size(104, 27);
			this.PRINTFEE.TabIndex = 19;
			this.PRINTFEE.Text = "&Print";
			this.PRINTFEE.UseVisualStyleBackColor = true;
			//
			//QUIT1
			//
			this.QUIT1.Location = new System.Drawing.Point(396, 22);
			this.QUIT1.Name = "QUIT1";
			this.QUIT1.Size = new System.Drawing.Size(106, 27);
			this.QUIT1.TabIndex = 18;
			this.QUIT1.Text = "&Exit";
			this.QUIT1.UseVisualStyleBackColor = true;
			//
			//CLEAR1
			//
			this.CLEAR1.Location = new System.Drawing.Point(277, 22);
			this.CLEAR1.Name = "CLEAR1";
			this.CLEAR1.Size = new System.Drawing.Size(100, 27);
			this.CLEAR1.TabIndex = 17;
			this.CLEAR1.Text = "&Clear";
			this.CLEAR1.UseVisualStyleBackColor = true;
			//
			//OK
			//
			this.OK.Location = new System.Drawing.Point(32, 22);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(104, 27);
			this.OK.TabIndex = 16;
			this.OK.Text = "&Ok";
			this.OK.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AllowDrop = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label1.Location = new System.Drawing.Point(45, 22);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 16);
			this.Label1.TabIndex = 119;
			this.Label1.Text = "ROLL NO";
			//
			//txtReceiptNo
			//
			this.txtReceiptNo.Location = new System.Drawing.Point(429, 269);
			this.txtReceiptNo.Name = "txtReceiptNo";
			this.txtReceiptNo.Size = new System.Drawing.Size(118, 20);
			this.txtReceiptNo.TabIndex = 10;
			//
			//Label50
			//
			this.Label50.AutoSize = true;
			this.Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label50.Location = new System.Drawing.Point(333, 272);
			this.Label50.Name = "Label50";
			this.Label50.Size = new System.Drawing.Size(86, 16);
			this.Label50.TabIndex = 115;
			this.Label50.Text = "Receipt No";
			//
			//txtChequeNo
			//
			this.txtChequeNo.Location = new System.Drawing.Point(151, 269);
			this.txtChequeNo.Name = "txtChequeNo";
			this.txtChequeNo.Size = new System.Drawing.Size(113, 20);
			this.txtChequeNo.TabIndex = 9;
			//
			//Label54
			//
			this.Label54.AutoSize = true;
			this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label54.Location = new System.Drawing.Point(29, 273);
			this.Label54.Name = "Label54";
			this.Label54.Size = new System.Drawing.Size(112, 16);
			this.Label54.TabIndex = 112;
			this.Label54.Text = "DD/Cheque No";
			//
			//txtNameOfBank
			//
			this.txtNameOfBank.Location = new System.Drawing.Point(150, 231);
			this.txtNameOfBank.Name = "txtNameOfBank";
			this.txtNameOfBank.Size = new System.Drawing.Size(397, 20);
			this.txtNameOfBank.TabIndex = 8;
			//
			//Label53
			//
			this.Label53.AutoSize = true;
			this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label53.Location = new System.Drawing.Point(11, 232);
			this.Label53.Name = "Label53";
			this.Label53.Size = new System.Drawing.Size(130, 16);
			this.Label53.TabIndex = 110;
			this.Label53.Text = "Name of the Bank";
			//
			//cboPaymentMode
			//
			this.cboPaymentMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboPaymentMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboPaymentMode.FormattingEnabled = true;
			this.cboPaymentMode.Items.AddRange(new object[] {"CASH", "CHEQUE", "DEMAND DRAFT"});
			this.cboPaymentMode.Location = new System.Drawing.Point(150, 189);
			this.cboPaymentMode.Name = "cboPaymentMode";
			this.cboPaymentMode.Size = new System.Drawing.Size(164, 21);
			this.cboPaymentMode.TabIndex = 7;
			this.cboPaymentMode.Text = "CASH";
			//
			//Label52
			//
			this.Label52.AutoSize = true;
			this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label52.Location = new System.Drawing.Point(30, 190);
			this.Label52.Name = "Label52";
			this.Label52.Size = new System.Drawing.Size(111, 16);
			this.Label52.TabIndex = 107;
			this.Label52.Text = "Payment Mode";
			//
			//Label57
			//
			this.Label57.AutoSize = true;
			this.Label57.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label57.Location = new System.Drawing.Point(397, 196);
			this.Label57.Name = "Label57";
			this.Label57.Size = new System.Drawing.Size(150, 15);
			this.Label57.TabIndex = 106;
			this.Label57.Text = "Service Tax @ 12.24%";
			//
			//Label56
			//
			this.Label56.AutoSize = true;
			this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label56.Location = new System.Drawing.Point(390, 175);
			this.Label56.Name = "Label56";
			this.Label56.Size = new System.Drawing.Size(167, 15);
			this.Label56.TabIndex = 105;
			this.Label56.Text = "(Inclusive of Service Tax)";
			//
			//txtPaidAmount
			//
			this.txtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.txtPaidAmount.Location = new System.Drawing.Point(429, 150);
			this.txtPaidAmount.Name = "txtPaidAmount";
			this.txtPaidAmount.Size = new System.Drawing.Size(118, 22);
			this.txtPaidAmount.TabIndex = 6;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label11.Location = new System.Drawing.Point(311, 153);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(112, 16);
			this.Label11.TabIndex = 104;
			this.Label11.Text = "PAID AMOUNT";
			//
			//dtpDate
			//
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(429, 110);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(118, 20);
			this.dtpDate.TabIndex = 4;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label10.Location = new System.Drawing.Point(337, 110);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(49, 16);
			this.Label10.TabIndex = 102;
			this.Label10.Text = "DATE";
			//
			//txtPaidFees
			//
			this.txtPaidFees.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.txtPaidFees.Location = new System.Drawing.Point(429, 65);
			this.txtPaidFees.Name = "txtPaidFees";
			this.txtPaidFees.ReadOnly = true;
			this.txtPaidFees.Size = new System.Drawing.Size(118, 22);
			this.txtPaidFees.TabIndex = 2;
			//
			//Label9
			//
			this.Label9.AllowDrop = true;
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label9.Location = new System.Drawing.Point(337, 68);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(86, 16);
			this.Label9.TabIndex = 100;
			this.Label9.Text = "PAID FEES";
			//
			//txtFees
			//
			this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.txtFees.Location = new System.Drawing.Point(150, 153);
			this.txtFees.Name = "txtFees";
			this.txtFees.Size = new System.Drawing.Size(118, 22);
			this.txtFees.TabIndex = 5;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label3.Location = new System.Drawing.Point(97, 156);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(47, 16);
			this.Label3.TabIndex = 98;
			this.Label3.Text = "FEES";
			//
			//txtTotalFees
			//
			this.txtTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.txtTotalFees.Location = new System.Drawing.Point(150, 68);
			this.txtTotalFees.Name = "txtTotalFees";
			this.txtTotalFees.ReadOnly = true;
			this.txtTotalFees.Size = new System.Drawing.Size(118, 22);
			this.txtTotalFees.TabIndex = 1;
			//
			//Label5
			//
			this.Label5.AllowDrop = true;
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label5.Location = new System.Drawing.Point(44, 71);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(100, 16);
			this.Label5.TabIndex = 96;
			this.Label5.Text = "TOTAL FEES";
			//
			//txtBalanceAmount
			//
			this.txtBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.txtBalanceAmount.Location = new System.Drawing.Point(150, 111);
			this.txtBalanceAmount.Name = "txtBalanceAmount";
			this.txtBalanceAmount.ReadOnly = true;
			this.txtBalanceAmount.Size = new System.Drawing.Size(118, 22);
			this.txtBalanceAmount.TabIndex = 3;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label8.Location = new System.Drawing.Point(2, 112);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(146, 16);
			this.Label8.TabIndex = 92;
			this.Label8.Text = "BALANCE AMOUNT";
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.btnExit);
			this.GroupBox1.Controls.Add(this.btnClear);
			this.GroupBox1.Controls.Add(this.btnSave);
			this.GroupBox1.Location = new System.Drawing.Point(22, 376);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(581, 73);
			this.GroupBox1.TabIndex = 101;
			this.GroupBox1.TabStop = false;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(387, 22);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(106, 27);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(243, 22);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 27);
			this.btnClear.TabIndex = 12;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.Location = new System.Drawing.Point(87, 22);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 27);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			//
			//btnUpdate
			//
			this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
			this.btnUpdate.Location = new System.Drawing.Point(499, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 27);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			//
			//FeesTranscation
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 461);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.GroupBox3);
			this.Name = "FeesTranscation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FeesTranscation";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.TextBox txtReceiptNo;
		internal System.Windows.Forms.Label Label50;
		internal System.Windows.Forms.TextBox txtChequeNo;
		internal System.Windows.Forms.Label Label54;
		internal System.Windows.Forms.TextBox txtNameOfBank;
		internal System.Windows.Forms.Label Label53;
		internal System.Windows.Forms.ComboBox cboPaymentMode;
		internal System.Windows.Forms.Label Label52;
		internal System.Windows.Forms.Label Label57;
		internal System.Windows.Forms.Label Label56;
		internal System.Windows.Forms.TextBox txtPaidAmount;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.DateTimePicker dtpDate;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtPaidFees;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtFees;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtTotalFees;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtBalanceAmount;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.Button PRINTFEE;
		internal System.Windows.Forms.Button QUIT1;
		internal System.Windows.Forms.Button CLEAR1;
		internal System.Windows.Forms.Button OK;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.ComboBox cboRollNo;
		internal System.Windows.Forms.Button btnUpdate;
	}
	
}
