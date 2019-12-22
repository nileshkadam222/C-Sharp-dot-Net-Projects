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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmPurchases : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmPurchases_Load);
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSR = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.txtAmount);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.Controls.Add(this.txtSR);
			this.GroupBox1.Controls.Add(this.btnExit);
			this.GroupBox1.Controls.Add(this.btnClear);
			this.GroupBox1.Controls.Add(this.btnSave);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(13, 31);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(267, 246);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Purchase Details";
			//
			//txtAmount
			//
			this.txtAmount.Location = new System.Drawing.Point(80, 122);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(152, 20);
			this.txtAmount.TabIndex = 11;
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(80, 74);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(152, 20);
			this.txtName.TabIndex = 10;
			//
			//txtSR
			//
			this.txtSR.Location = new System.Drawing.Point(80, 30);
			this.txtSR.Name = "txtSR";
			this.txtSR.ReadOnly = true;
			this.txtSR.Size = new System.Drawing.Size(152, 20);
			this.txtSR.TabIndex = 9;
			//
			//btnExit
			//
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.Location = new System.Drawing.Point(173, 180);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(67, 27);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = false;
			//
			//btnClear
			//
			this.btnClear.BackColor = System.Drawing.Color.Transparent;
			this.btnClear.Location = new System.Drawing.Point(100, 180);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(67, 27);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = false;
			//
			//btnSave
			//
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.Location = new System.Drawing.Point(27, 180);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(67, 27);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(7, 122);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(43, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Amount";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(7, 74);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(35, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Name";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(7, 30);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(50, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Serial No";
			//
			//frmPurchases
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 289);
			this.Controls.Add(this.GroupBox1);
			this.Name = "frmPurchases";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Purchases";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.TextBox txtAmount;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.TextBox txtSR;
	}
	
}
