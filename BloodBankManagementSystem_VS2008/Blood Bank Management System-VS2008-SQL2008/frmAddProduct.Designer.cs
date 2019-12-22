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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmAddProduct : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmAddProduct_Load);
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
			this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
			this.Label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtSR = new System.Windows.Forms.TextBox();
			this.lblSr = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.btnExit);
			this.Panel1.Controls.Add(this.btnClear);
			this.Panel1.Controls.Add(this.btnSave);
			this.Panel1.Controls.Add(this.txtRate);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.txtName);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.txtSR);
			this.Panel1.Controls.Add(this.lblSr);
			this.Panel1.Location = new System.Drawing.Point(13, 44);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(267, 207);
			this.Panel1.TabIndex = 0;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(174, 154);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 33);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(93, 154);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 33);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(12, 154);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 33);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//txtRate
			//
			this.txtRate.Location = new System.Drawing.Point(84, 114);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(149, 20);
			this.txtRate.TabIndex = 2;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(3, 114);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(30, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Rate";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(84, 66);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(149, 20);
			this.txtName.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(3, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(75, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Product Name";
			//
			//txtSR
			//
			this.txtSR.Location = new System.Drawing.Point(84, 20);
			this.txtSR.Name = "txtSR";
			this.txtSR.ReadOnly = true;
			this.txtSR.Size = new System.Drawing.Size(149, 20);
			this.txtSR.TabIndex = 0;
			//
			//lblSr
			//
			this.lblSr.AutoSize = true;
			this.lblSr.Location = new System.Drawing.Point(3, 20);
			this.lblSr.Name = "lblSr";
			this.lblSr.Size = new System.Drawing.Size(50, 13);
			this.lblSr.TabIndex = 0;
			this.lblSr.Text = "Serial No";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.Label1.Location = new System.Drawing.Point(92, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(108, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Add Product";
			//
			//frmAddProduct
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 263);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Panel1);
			this.Name = "frmAddProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Product";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.TextBox txtRate;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtSR;
		internal System.Windows.Forms.Label lblSr;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Label Label1;
	}
	
}
