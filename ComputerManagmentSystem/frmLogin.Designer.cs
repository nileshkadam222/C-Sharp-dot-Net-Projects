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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class FrmLogin : System.Windows.Forms.Form
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
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(FrmLogin_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.grpLogin = new System.Windows.Forms.GroupBox();
			this.grpLogin.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(29, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(68, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "USERNAME";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(29, 81);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(70, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "PASSWORD";
			//
			//txtUsername
			//
			this.txtUsername.Location = new System.Drawing.Point(129, 29);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(141, 20);
			this.txtUsername.TabIndex = 0;
			//
			//txtPassword
			//
			this.txtPassword.Location = new System.Drawing.Point(129, 81);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPassword.Size = new System.Drawing.Size(141, 20);
			this.txtPassword.TabIndex = 1;
			//
			//btnLogin
			//
			this.btnLogin.Location = new System.Drawing.Point(61, 137);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.UseVisualStyleBackColor = true;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(163, 137);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//grpLogin
			//
			this.grpLogin.Controls.Add(this.txtUsername);
			this.grpLogin.Controls.Add(this.btnClose);
			this.grpLogin.Controls.Add(this.btnLogin);
			this.grpLogin.Controls.Add(this.Label1);
			this.grpLogin.Controls.Add(this.Label2);
			this.grpLogin.Controls.Add(this.txtPassword);
			this.grpLogin.Location = new System.Drawing.Point(12, 6);
			this.grpLogin.Name = "grpLogin";
			this.grpLogin.Size = new System.Drawing.Size(298, 193);
			this.grpLogin.TabIndex = 6;
			this.grpLogin.TabStop = false;
			this.grpLogin.Text = "Login";
			//
			//FrmLogin
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 211);
			this.Controls.Add(this.grpLogin);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			this.grpLogin.ResumeLayout(false);
			this.grpLogin.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtUsername;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.Button btnLogin;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.GroupBox grpLogin;
		
	}
	
}
