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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmHome : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmHome_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.AddStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddStudentToolStripMenuItem.Click += new System.EventHandler(this.AddStudentToolStripMenuItem_Click);
			this.AddStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.AddStudentToolStripMenuItem1.Click += new System.EventHandler(this.AddStudentToolStripMenuItem1_Click);
			this.AddFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFacultyToolStripMenuItem.Click += new System.EventHandler(this.AddFacultyToolStripMenuItem_Click);
			this.AddFacultyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFacultyToolStripMenuItem1.Click += new System.EventHandler(this.AddFacultyToolStripMenuItem1_Click);
			this.FeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FeesToolStripMenuItem.Click += new System.EventHandler(this.FeesToolStripMenuItem_Click);
			this.AddFeesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFeesDetailsToolStripMenuItem.Click += new System.EventHandler(this.AddFeesDetailsToolStripMenuItem_Click);
			this.AddCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddCourseToolStripMenuItem.Click += new System.EventHandler(this.AddCourseToolStripMenuItem_Click);
			this.AddCourseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.AddCourseToolStripMenuItem1.Click += new System.EventHandler(this.AddCourseToolStripMenuItem1_Click);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
			this.PurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PurchasesToolStripMenuItem.Click += new System.EventHandler(this.PurchasesToolStripMenuItem_Click);
			this.UpdatePurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdatePurchasesToolStripMenuItem.Click += new System.EventHandler(this.UpdatePurchasesToolStripMenuItem_Click);
			this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItem_Click);
			this.ReportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.FessDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FessDetailsToolStripMenuItem.Click += new System.EventHandler(this.FessDetailsToolStripMenuItem_Click);
			this.StudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.StudentDetailsToolStripMenuItem_Click);
			this.FacultyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FacultyDetailsToolStripMenuItem.Click += new System.EventHandler(this.FacultyDetailsToolStripMenuItem_Click);
			this.CourseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CourseDetailsToolStripMenuItem.Click += new System.EventHandler(this.CourseDetailsToolStripMenuItem_Click);
			this.PurchaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PurchaseDetailsToolStripMenuItem.Click += new System.EventHandler(this.PurchaseDetailsToolStripMenuItem_Click);
			this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.MenuStrip.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip
			//
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddStudentToolStripMenuItem, this.AddFacultyToolStripMenuItem, this.FeesToolStripMenuItem, this.AddCourseToolStripMenuItem, this.ToolStripMenuItem1, this.ReportsToolStripMenuItem, this.ReportsToolStripMenuItem1, this.LogoutToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(889, 24);
			this.MenuStrip.TabIndex = 5;
			this.MenuStrip.Text = "MenuStrip";
			//
			//AddStudentToolStripMenuItem
			//
			this.AddStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddStudentToolStripMenuItem1});
			this.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem";
			this.AddStudentToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.AddStudentToolStripMenuItem.Text = "Student";
			//
			//AddStudentToolStripMenuItem1
			//
			this.AddStudentToolStripMenuItem1.Name = "AddStudentToolStripMenuItem1";
			this.AddStudentToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
			this.AddStudentToolStripMenuItem1.Text = "Add Student";
			//
			//AddFacultyToolStripMenuItem
			//
			this.AddFacultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddFacultyToolStripMenuItem1});
			this.AddFacultyToolStripMenuItem.Name = "AddFacultyToolStripMenuItem";
			this.AddFacultyToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.AddFacultyToolStripMenuItem.Text = "Faculty";
			//
			//AddFacultyToolStripMenuItem1
			//
			this.AddFacultyToolStripMenuItem1.Name = "AddFacultyToolStripMenuItem1";
			this.AddFacultyToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
			this.AddFacultyToolStripMenuItem1.Text = "Add Faculty";
			//
			//FeesToolStripMenuItem
			//
			this.FeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddFeesDetailsToolStripMenuItem});
			this.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem";
			this.FeesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
			this.FeesToolStripMenuItem.Text = "Fees";
			//
			//AddFeesDetailsToolStripMenuItem
			//
			this.AddFeesDetailsToolStripMenuItem.Name = "AddFeesDetailsToolStripMenuItem";
			this.AddFeesDetailsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.AddFeesDetailsToolStripMenuItem.Text = "Add Fees Details";
			//
			//AddCourseToolStripMenuItem
			//
			this.AddCourseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddCourseToolStripMenuItem1});
			this.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem";
			this.AddCourseToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.AddCourseToolStripMenuItem.Text = "Course";
			//
			//AddCourseToolStripMenuItem1
			//
			this.AddCourseToolStripMenuItem1.Name = "AddCourseToolStripMenuItem1";
			this.AddCourseToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
			this.AddCourseToolStripMenuItem1.Text = "Add Course";
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.PurchasesToolStripMenuItem, this.UpdatePurchasesToolStripMenuItem});
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
			this.ToolStripMenuItem1.Text = "Inventory";
			//
			//PurchasesToolStripMenuItem
			//
			this.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem";
			this.PurchasesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.PurchasesToolStripMenuItem.Text = "Purchases";
			//
			//UpdatePurchasesToolStripMenuItem
			//
			this.UpdatePurchasesToolStripMenuItem.Name = "UpdatePurchasesToolStripMenuItem";
			this.UpdatePurchasesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.UpdatePurchasesToolStripMenuItem.Text = "Update Purchases";
			//
			//ReportsToolStripMenuItem
			//
			this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
			this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.ReportsToolStripMenuItem.Text = "Search";
			//
			//ReportsToolStripMenuItem1
			//
			this.ReportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FessDetailsToolStripMenuItem, this.StudentDetailsToolStripMenuItem, this.FacultyDetailsToolStripMenuItem, this.CourseDetailsToolStripMenuItem, this.PurchaseDetailsToolStripMenuItem});
			this.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1";
			this.ReportsToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
			this.ReportsToolStripMenuItem1.Text = "Reports";
			//
			//FessDetailsToolStripMenuItem
			//
			this.FessDetailsToolStripMenuItem.Name = "FessDetailsToolStripMenuItem";
			this.FessDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.FessDetailsToolStripMenuItem.Text = "Fess Details";
			//
			//StudentDetailsToolStripMenuItem
			//
			this.StudentDetailsToolStripMenuItem.Name = "StudentDetailsToolStripMenuItem";
			this.StudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.StudentDetailsToolStripMenuItem.Text = "Student Details";
			//
			//FacultyDetailsToolStripMenuItem
			//
			this.FacultyDetailsToolStripMenuItem.Name = "FacultyDetailsToolStripMenuItem";
			this.FacultyDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.FacultyDetailsToolStripMenuItem.Text = "Faculty Details";
			//
			//CourseDetailsToolStripMenuItem
			//
			this.CourseDetailsToolStripMenuItem.Name = "CourseDetailsToolStripMenuItem";
			this.CourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.CourseDetailsToolStripMenuItem.Text = "Course Details";
			//
			//PurchaseDetailsToolStripMenuItem
			//
			this.PurchaseDetailsToolStripMenuItem.Name = "PurchaseDetailsToolStripMenuItem";
			this.PurchaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.PurchaseDetailsToolStripMenuItem.Text = "Purchase Details";
			//
			//LogoutToolStripMenuItem
			//
			this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
			this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.LogoutToolStripMenuItem.Text = "Logout";
			//
			//StatusStrip
			//
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripStatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 431);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(889, 22);
			this.StatusStrip.TabIndex = 7;
			this.StatusStrip.Text = "StatusStrip";
			//
			//ToolStripStatusLabel
			//
			this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
			this.ToolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
			this.ToolStripStatusLabel.Text = "Status";
			//
			//frmHome
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (System.Drawing.Image) (resources.GetObject("$this.BackgroundImage"));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(889, 453);
			this.Controls.Add(this.MenuStrip);
			this.Controls.Add(this.StatusStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "frmHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmHome";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.ToolTip ToolTip;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
		internal System.Windows.Forms.StatusStrip StatusStrip;
		internal System.Windows.Forms.MenuStrip MenuStrip;
		internal System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddFacultyToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FeesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddCourseToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FessDetailsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StudentDetailsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FacultyDetailsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CourseDetailsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem PurchasesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem UpdatePurchasesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddCourseToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem AddFeesDetailsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem AddFacultyToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem PurchaseDetailsToolStripMenuItem;
		
	}
	
}
