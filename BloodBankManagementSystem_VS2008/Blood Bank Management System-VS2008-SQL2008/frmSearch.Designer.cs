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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmSearch : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
			this.cboSearchBy = new System.Windows.Forms.ComboBox();
			this.cboSearchBy.SelectedIndexChanged += new System.EventHandler(this.cboSearchBy_SelectedIndexChanged);
			base.Load += new System.EventHandler(frmSearch_Load);
			this.cboValue = new System.Windows.Forms.ComboBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.label1 = new System.Windows.Forms.Label();
			this.lblSales = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			this.lblFlag = new System.Windows.Forms.Label();
			this.btnViewReport = new System.Windows.Forms.Button();
			this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
			this.label3 = new System.Windows.Forms.Label();
			this.lblTo = new System.Windows.Forms.Label();
			this.lblFrom = new System.Windows.Forms.Label();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).BeginInit();
			this.SuspendLayout();
			//
			//cboSearchBy
			//
			this.cboSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboSearchBy.FormattingEnabled = true;
			this.cboSearchBy.Items.AddRange(new object[] {"Donor Details", "Recipient Details", "Purchases", "Sales", "Stock"});
			this.cboSearchBy.Location = new System.Drawing.Point(385, 28);
			this.cboSearchBy.Name = "cboSearchBy";
			this.cboSearchBy.Size = new System.Drawing.Size(210, 21);
			this.cboSearchBy.TabIndex = 36;
			//
			//cboValue
			//
			this.cboValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboValue.FormattingEnabled = true;
			this.cboValue.Location = new System.Drawing.Point(385, 80);
			this.cboValue.Name = "cboValue";
			this.cboValue.Size = new System.Drawing.Size(210, 21);
			this.cboValue.TabIndex = 38;
			//
			//btnClose
			//
			this.btnClose.Image = (System.Drawing.Image) (resources.GetObject("btnClose.Image"));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(507, 428);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(82, 47);
			this.btnClose.TabIndex = 44;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//label1
			//
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(286, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Search By";
			//
			//lblSales
			//
			this.lblSales.AutoSize = true;
			this.lblSales.Location = new System.Drawing.Point(577, 436);
			this.lblSales.Name = "lblSales";
			this.lblSales.Size = new System.Drawing.Size(0, 13);
			this.lblSales.TabIndex = 49;
			//
			//label2
			//
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(286, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 37;
			this.label2.Text = "Select";
			//
			//btnExport
			//
			this.btnExport.Location = new System.Drawing.Point(300, 428);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(140, 47);
			this.btnExport.TabIndex = 43;
			this.btnExport.Text = "Export to Excel";
			this.btnExport.UseVisualStyleBackColor = true;
			//
			//lblFlag
			//
			this.lblFlag.AutoSize = true;
			this.lblFlag.Location = new System.Drawing.Point(304, 63);
			this.lblFlag.Name = "lblFlag";
			this.lblFlag.Size = new System.Drawing.Size(0, 13);
			this.lblFlag.TabIndex = 48;
			this.lblFlag.Visible = false;
			//
			//btnViewReport
			//
			this.btnViewReport.Location = new System.Drawing.Point(559, 115);
			this.btnViewReport.Name = "btnViewReport";
			this.btnViewReport.Size = new System.Drawing.Size(101, 27);
			this.btnViewReport.TabIndex = 41;
			this.btnViewReport.Text = "View Report";
			this.btnViewReport.UseVisualStyleBackColor = true;
			//
			//label3
			//
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(229, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 47;
			this.label3.Text = "Select Date";
			//
			//lblTo
			//
			this.lblTo.AutoSize = true;
			this.lblTo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTo.Location = new System.Drawing.Point(431, 125);
			this.lblTo.Name = "lblTo";
			this.lblTo.Size = new System.Drawing.Size(20, 13);
			this.lblTo.TabIndex = 46;
			this.lblTo.Text = "To";
			//
			//lblFrom
			//
			this.lblFrom.AutoSize = true;
			this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFrom.Location = new System.Drawing.Point(301, 126);
			this.lblFrom.Name = "lblFrom";
			this.lblFrom.Size = new System.Drawing.Size(33, 13);
			this.lblFrom.TabIndex = 45;
			this.lblFrom.Text = "From ";
			//
			//dtpToDate
			//
			this.dtpToDate.CustomFormat = "dd/MM/yyyy";
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpToDate.Location = new System.Drawing.Point(454, 122);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.ShowCheckBox = true;
			this.dtpToDate.Size = new System.Drawing.Size(88, 20);
			this.dtpToDate.TabIndex = 40;
			//
			//dtpFromDate
			//
			this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFromDate.Location = new System.Drawing.Point(338, 122);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.ShowCheckBox = true;
			this.dtpFromDate.Size = new System.Drawing.Size(88, 20);
			this.dtpFromDate.TabIndex = 39;
			//
			//dgvSearch
			//
			this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Location = new System.Drawing.Point(54, 148);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.ReadOnly = true;
			this.dgvSearch.Size = new System.Drawing.Size(781, 274);
			this.dgvSearch.TabIndex = 42;
			//
			//frmSearch
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 511);
			this.Controls.Add(this.cboSearchBy);
			this.Controls.Add(this.cboValue);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblSales);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.lblFlag);
			this.Controls.Add(this.btnViewReport);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTo);
			this.Controls.Add(this.lblFrom);
			this.Controls.Add(this.dtpToDate);
			this.Controls.Add(this.dtpFromDate);
			this.Controls.Add(this.dgvSearch);
			this.Name = "frmSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		private System.Windows.Forms.ComboBox cboSearchBy;
		private System.Windows.Forms.ComboBox cboValue;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSales;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Label lblFlag;
		private System.Windows.Forms.Button btnViewReport;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.Label lblFrom;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.DataGridView dgvSearch;
	}
	
}
