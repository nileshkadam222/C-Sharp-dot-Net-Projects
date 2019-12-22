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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmLogin : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmLogin_Load);
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnReset = new System.Windows.Forms.Button();
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.label1);
			this.Panel1.Controls.Add(this.btnClose);
			this.Panel1.Controls.Add(this.btnReset);
			this.Panel1.Controls.Add(this.btnLogin);
			this.Panel1.Controls.Add(this.lblPassword);
			this.Panel1.Controls.Add(this.lblUsername);
			this.Panel1.Controls.Add(this.txtPassword);
			this.Panel1.Controls.Add(this.txtUsername);
			this.Panel1.Location = new System.Drawing.Point(9, 26);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(275, 215);
			this.Panel1.TabIndex = 1;
			//
			//label1
			//
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", (float) (15.75F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, (byte) (0));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(97, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 25);
			this.label1.TabIndex = 25;
			this.label1.Text = "Login";
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(179, 165);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 33);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//btnReset
			//
			this.btnReset.Location = new System.Drawing.Point(98, 165);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 33);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "RESET";
			this.btnReset.UseVisualStyleBackColor = true;
			//
			//btnLogin
			//
			this.btnLogin.Location = new System.Drawing.Point(17, 165);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 33);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "SUBMIT";
			this.btnLogin.UseVisualStyleBackColor = true;
			//
			//lblPassword
			//
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(18, 121);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 23;
			this.lblPassword.Text = "Password";
			//
			//lblUsername
			//
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(18, 74);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(55, 13);
			this.lblUsername.TabIndex = 20;
			this.lblUsername.Text = "Username";
			//
			//txtPassword
			//
			this.txtPassword.Location = new System.Drawing.Point(116, 121);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPassword.Size = new System.Drawing.Size(136, 20);
			this.txtPassword.TabIndex = 1;
			//
			//txtUsername
			//
			this.txtUsername.Location = new System.Drawing.Point(116, 74);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(136, 20);
			this.txtUsername.TabIndex = 0;
			//
			//frmLogin
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
	}
	
}
