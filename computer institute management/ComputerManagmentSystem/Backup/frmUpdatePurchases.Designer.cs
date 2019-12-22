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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmUpdatePurchases : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmUpdatePurchases_Load);
			this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			this.cboName = new System.Windows.Forms.ComboBox();
			this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.btnExit);
			this.GroupBox1.Controls.Add(this.btnDelete);
			this.GroupBox1.Controls.Add(this.btnUpdate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtAmount);
			this.GroupBox1.Controls.Add(this.cboName);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(268, 242);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Update Purchases";
			//
			//cboName
			//
			this.cboName.FormattingEnabled = true;
			this.cboName.Location = new System.Drawing.Point(99, 51);
			this.cboName.Name = "cboName";
			this.cboName.Size = new System.Drawing.Size(135, 21);
			this.cboName.TabIndex = 0;
			//
			//txtAmount
			//
			this.txtAmount.Location = new System.Drawing.Point(99, 126);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(135, 20);
			this.txtAmount.TabIndex = 1;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(7, 51);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(55, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "ItemName";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(7, 126);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(43, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Amount";
			//
			//btnExit
			//
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.Location = new System.Drawing.Point(174, 184);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(67, 27);
			this.btnExit.TabIndex = 11;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = false;
			//
			//btnDelete
			//
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.Location = new System.Drawing.Point(101, 184);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(67, 27);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			//
			//btnUpdate
			//
			this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
			this.btnUpdate.Location = new System.Drawing.Point(28, 184);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(67, 27);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			//
			//frmUpdatePurchases
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.GroupBox1);
			this.Name = "frmUpdatePurchases";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Purchases";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtAmount;
		internal System.Windows.Forms.ComboBox cboName;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnUpdate;
	}
	
}
