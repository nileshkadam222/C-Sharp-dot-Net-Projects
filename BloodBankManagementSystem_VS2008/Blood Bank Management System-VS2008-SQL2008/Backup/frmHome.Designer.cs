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
			this.DonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.DonorDetailsToolStripMenuItem_Click);
			this.AddDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddDonorToolStripMenuItem.Click += new System.EventHandler(this.AddDonorToolStripMenuItem_Click);
			this.RecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RecToolStripMenuItem.Click += new System.EventHandler(this.RecToolStripMenuItem_Click);
			this.AddRecipientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddRecipientToolStripMenuItem.Click += new System.EventHandler(this.AddRecipientToolStripMenuItem_Click);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
			this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
			this.UpdateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateProductToolStripMenuItem.Click += new System.EventHandler(this.UpdateProductToolStripMenuItem_Click);
			this.PurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PurchasesToolStripMenuItem.Click += new System.EventHandler(this.PurchasesToolStripMenuItem_Click);
			this.AddPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddPurchasesToolStripMenuItem.Click += new System.EventHandler(this.AddPurchasesToolStripMenuItem_Click);
			this.SalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SalesToolStripMenuItem.Click += new System.EventHandler(this.SalesToolStripMenuItem_Click);
			this.AddSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddSalesToolStripMenuItem.Click += new System.EventHandler(this.AddSalesToolStripMenuItem_Click);
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.AddSalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.AddSalesToolStripMenuItem1.Click += new System.EventHandler(this.AddSalesToolStripMenuItem1_Click);
			this.UpdateSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItem_Click);
			this.ReportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SalesToolStripMenuItem1.Click += new System.EventHandler(this.SalesToolStripMenuItem1_Click);
			this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
			this.PurchasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.PurchasesToolStripMenuItem1.Click += new System.EventHandler(this.PurchasesToolStripMenuItem1_Click);
			this.DonorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DonorsToolStripMenuItem.Click += new System.EventHandler(this.DonorsToolStripMenuItem_Click);
			this.RecipientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RecipientsToolStripMenuItem.Click += new System.EventHandler(this.RecipientsToolStripMenuItem_Click);
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
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.DonorDetailsToolStripMenuItem, this.RecToolStripMenuItem, this.ToolStripMenuItem1, this.PurchasesToolStripMenuItem, this.SalesToolStripMenuItem, this.ToolStripMenuItem2, this.ReportsToolStripMenuItem, this.ReportsToolStripMenuItem1, this.LogoutToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(899, 24);
			this.MenuStrip.TabIndex = 5;
			this.MenuStrip.Text = "MenuStrip";
			//
			//DonorDetailsToolStripMenuItem
			//
			this.DonorDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddDonorToolStripMenuItem});
			this.DonorDetailsToolStripMenuItem.Name = "DonorDetailsToolStripMenuItem";
			this.DonorDetailsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
			this.DonorDetailsToolStripMenuItem.Text = "Donor Details";
			//
			//AddDonorToolStripMenuItem
			//
			this.AddDonorToolStripMenuItem.Name = "AddDonorToolStripMenuItem";
			this.AddDonorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.AddDonorToolStripMenuItem.Text = "Add Donor";
			//
			//RecToolStripMenuItem
			//
			this.RecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddRecipientToolStripMenuItem});
			this.RecToolStripMenuItem.Name = "RecToolStripMenuItem";
			this.RecToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.RecToolStripMenuItem.Text = "Recipient Details";
			//
			//AddRecipientToolStripMenuItem
			//
			this.AddRecipientToolStripMenuItem.Name = "AddRecipientToolStripMenuItem";
			this.AddRecipientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.AddRecipientToolStripMenuItem.Text = "Add Recipient";
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddProductToolStripMenuItem, this.UpdateProductToolStripMenuItem});
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(107, 20);
			this.ToolStripMenuItem1.Text = "Product Inventory";
			//
			//AddProductToolStripMenuItem
			//
			this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
			this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.AddProductToolStripMenuItem.Text = "Add Product";
			//
			//UpdateProductToolStripMenuItem
			//
			this.UpdateProductToolStripMenuItem.Name = "UpdateProductToolStripMenuItem";
			this.UpdateProductToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.UpdateProductToolStripMenuItem.Text = "Update Product";
			//
			//PurchasesToolStripMenuItem
			//
			this.PurchasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddPurchasesToolStripMenuItem});
			this.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem";
			this.PurchasesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.PurchasesToolStripMenuItem.Text = "Blood Donation";
			//
			//AddPurchasesToolStripMenuItem
			//
			this.AddPurchasesToolStripMenuItem.Name = "AddPurchasesToolStripMenuItem";
			this.AddPurchasesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.AddPurchasesToolStripMenuItem.Text = "Add Purchases ";
			//
			//SalesToolStripMenuItem
			//
			this.SalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddSalesToolStripMenuItem});
			this.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem";
			this.SalesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.SalesToolStripMenuItem.Text = "Blood Bag Sales";
			//
			//AddSalesToolStripMenuItem
			//
			this.AddSalesToolStripMenuItem.Name = "AddSalesToolStripMenuItem";
			this.AddSalesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.AddSalesToolStripMenuItem.Text = "Blood Sales";
			//
			//ToolStripMenuItem2
			//
			this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddSalesToolStripMenuItem1, this.UpdateSalesToolStripMenuItem});
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new System.Drawing.Size(84, 20);
			this.ToolStripMenuItem2.Text = "Product Sales";
			//
			//AddSalesToolStripMenuItem1
			//
			this.AddSalesToolStripMenuItem1.Name = "AddSalesToolStripMenuItem1";
			this.AddSalesToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
			this.AddSalesToolStripMenuItem1.Text = "Add Sales";
			//
			//UpdateSalesToolStripMenuItem
			//
			this.UpdateSalesToolStripMenuItem.Name = "UpdateSalesToolStripMenuItem";
			this.UpdateSalesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.UpdateSalesToolStripMenuItem.Text = "Update Sales";
			//
			//ReportsToolStripMenuItem
			//
			this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
			this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.ReportsToolStripMenuItem.Text = "Search";
			//
			//ReportsToolStripMenuItem1
			//
			this.ReportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.SalesToolStripMenuItem1, this.ToolStripMenuItem3, this.PurchasesToolStripMenuItem1, this.DonorsToolStripMenuItem, this.RecipientsToolStripMenuItem});
			this.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1";
			this.ReportsToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
			this.ReportsToolStripMenuItem1.Text = "Reports";
			//
			//SalesToolStripMenuItem1
			//
			this.SalesToolStripMenuItem1.Name = "SalesToolStripMenuItem1";
			this.SalesToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
			this.SalesToolStripMenuItem1.Text = "Blood Bag Sales";
			//
			//ToolStripMenuItem3
			//
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			this.ToolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
			this.ToolStripMenuItem3.Text = "Product Sales";
			//
			//PurchasesToolStripMenuItem1
			//
			this.PurchasesToolStripMenuItem1.Name = "PurchasesToolStripMenuItem1";
			this.PurchasesToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
			this.PurchasesToolStripMenuItem1.Text = "Purchases";
			//
			//DonorsToolStripMenuItem
			//
			this.DonorsToolStripMenuItem.Name = "DonorsToolStripMenuItem";
			this.DonorsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.DonorsToolStripMenuItem.Text = "Donors";
			//
			//RecipientsToolStripMenuItem
			//
			this.RecipientsToolStripMenuItem.Name = "RecipientsToolStripMenuItem";
			this.RecipientsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.RecipientsToolStripMenuItem.Text = "Recipients";
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
			this.StatusStrip.Size = new System.Drawing.Size(899, 22);
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
			this.ClientSize = new System.Drawing.Size(899, 453);
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
		internal System.Windows.Forms.ToolStripMenuItem DonorDetailsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RecToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem PurchasesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SalesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddDonorToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddRecipientToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddPurchasesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddSalesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SalesToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem PurchasesToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem DonorsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RecipientsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem UpdateProductToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
		internal System.Windows.Forms.ToolStripMenuItem AddSalesToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem UpdateSalesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
		
	}
	
}
