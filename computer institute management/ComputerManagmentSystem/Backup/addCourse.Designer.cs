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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class addCourse : System.Windows.Forms.Form
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
			this.btnSearchUpdate = new System.Windows.Forms.Button();
			this.btnSearchUpdate.Click += new System.EventHandler(this.btnSearchUpdate_Click);
			base.Load += new System.EventHandler(addCourse_Load);
			this.pnlCourse = new System.Windows.Forms.Panel();
			this.grpCourse = new System.Windows.Forms.GroupBox();
			this.cboFaculty = new System.Windows.Forms.ComboBox();
			this.txtCourseNo = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtBatchTiming = new System.Windows.Forms.TextBox();
			this.txtFees = new System.Windows.Forms.TextBox();
			this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
			this.txtDuration = new System.Windows.Forms.TextBox();
			this.txtCourseName = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnExit = new System.Windows.Forms.Button();
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.btnClose1 = new System.Windows.Forms.Button();
			this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
			this.btnClose = new System.Windows.Forms.Button();
			this.cboCourse = new System.Windows.Forms.ComboBox();
			this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.dgvSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseDoubleClick);
			this.pnlCourse.SuspendLayout();
			this.grpCourse.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).BeginInit();
			this.SuspendLayout();
			//
			//btnSearchUpdate
			//
			this.btnSearchUpdate.BackColor = System.Drawing.Color.Transparent;
			this.btnSearchUpdate.Location = new System.Drawing.Point(426, 25);
			this.btnSearchUpdate.Name = "btnSearchUpdate";
			this.btnSearchUpdate.Size = new System.Drawing.Size(104, 27);
			this.btnSearchUpdate.TabIndex = 106;
			this.btnSearchUpdate.Text = "UPDATE";
			this.btnSearchUpdate.UseVisualStyleBackColor = false;
			//
			//pnlCourse
			//
			this.pnlCourse.Controls.Add(this.grpCourse);
			this.pnlCourse.Controls.Add(this.GroupBox3);
			this.pnlCourse.Location = new System.Drawing.Point(17, 69);
			this.pnlCourse.Name = "pnlCourse";
			this.pnlCourse.Size = new System.Drawing.Size(517, 343);
			this.pnlCourse.TabIndex = 107;
			//
			//grpCourse
			//
			this.grpCourse.Controls.Add(this.cboFaculty);
			this.grpCourse.Controls.Add(this.txtCourseNo);
			this.grpCourse.Controls.Add(this.Label6);
			this.grpCourse.Controls.Add(this.txtBatchTiming);
			this.grpCourse.Controls.Add(this.txtFees);
			this.grpCourse.Controls.Add(this.txtDuration);
			this.grpCourse.Controls.Add(this.txtCourseName);
			this.grpCourse.Controls.Add(this.Label5);
			this.grpCourse.Controls.Add(this.Label4);
			this.grpCourse.Controls.Add(this.Label3);
			this.grpCourse.Controls.Add(this.Label2);
			this.grpCourse.Controls.Add(this.Label1);
			this.grpCourse.Location = new System.Drawing.Point(3, 4);
			this.grpCourse.Name = "grpCourse";
			this.grpCourse.Size = new System.Drawing.Size(493, 241);
			this.grpCourse.TabIndex = 0;
			this.grpCourse.TabStop = false;
			this.grpCourse.Text = "Couurse Details";
			//
			//cboFaculty
			//
			this.cboFaculty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboFaculty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboFaculty.FormattingEnabled = true;
			this.cboFaculty.Location = new System.Drawing.Point(141, 209);
			this.cboFaculty.Name = "cboFaculty";
			this.cboFaculty.Size = new System.Drawing.Size(214, 21);
			this.cboFaculty.TabIndex = 4;
			//
			//txtCourseNo
			//
			this.txtCourseNo.Location = new System.Drawing.Point(141, 19);
			this.txtCourseNo.Name = "txtCourseNo";
			this.txtCourseNo.ReadOnly = true;
			this.txtCourseNo.Size = new System.Drawing.Size(214, 20);
			this.txtCourseNo.TabIndex = 11;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(30, 22);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(71, 13);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "COURSE NO";
			//
			//txtBatchTiming
			//
			this.txtBatchTiming.Location = new System.Drawing.Point(141, 173);
			this.txtBatchTiming.Name = "txtBatchTiming";
			this.txtBatchTiming.Size = new System.Drawing.Size(214, 20);
			this.txtBatchTiming.TabIndex = 3;
			//
			//txtFees
			//
			this.txtFees.Location = new System.Drawing.Point(141, 132);
			this.txtFees.Name = "txtFees";
			this.txtFees.Size = new System.Drawing.Size(214, 20);
			this.txtFees.TabIndex = 2;
			//
			//txtDuration
			//
			this.txtDuration.Location = new System.Drawing.Point(141, 100);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(214, 20);
			this.txtDuration.TabIndex = 1;
			//
			//txtCourseName
			//
			this.txtCourseName.Location = new System.Drawing.Point(141, 57);
			this.txtCourseName.Name = "txtCourseName";
			this.txtCourseName.Size = new System.Drawing.Size(214, 20);
			this.txtCourseName.TabIndex = 0;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(32, 209);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(55, 13);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "FACULTY";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(32, 173);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(84, 13);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "BATCH TIMING";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(32, 135);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(34, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "FEES";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(32, 103);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(67, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "DURATION ";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(30, 60);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(86, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "COURSE NAME";
			//
			//GroupBox3
			//
			this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox3.Controls.Add(this.btnUpdate);
			this.GroupBox3.Controls.Add(this.btnDelete);
			this.GroupBox3.Controls.Add(this.btnExit);
			this.GroupBox3.Controls.Add(this.btnClear);
			this.GroupBox3.Controls.Add(this.btnSave);
			this.GroupBox3.Location = new System.Drawing.Point(22, 251);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(473, 73);
			this.GroupBox3.TabIndex = 103;
			this.GroupBox3.TabStop = false;
			//
			//btnUpdate
			//
			this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
			this.btnUpdate.Location = new System.Drawing.Point(32, 22);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(104, 27);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			//
			//btnDelete
			//
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.Location = new System.Drawing.Point(184, 22);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(104, 27);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			//
			//btnExit
			//
			this.btnExit.Location = new System.Drawing.Point(332, 22);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(106, 27);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.Location = new System.Drawing.Point(188, 22);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 27);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.Location = new System.Drawing.Point(32, 22);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 27);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			//
			//pnlSearch
			//
			this.pnlSearch.Controls.Add(this.btnClose1);
			this.pnlSearch.Controls.Add(this.btnClose);
			this.pnlSearch.Controls.Add(this.cboCourse);
			this.pnlSearch.Controls.Add(this.dgvSearch);
			this.pnlSearch.Location = new System.Drawing.Point(12, 58);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(484, 354);
			this.pnlSearch.TabIndex = 108;
			//
			//btnClose1
			//
			this.btnClose1.Location = new System.Drawing.Point(205, 311);
			this.btnClose1.Name = "btnClose1";
			this.btnClose1.Size = new System.Drawing.Size(75, 23);
			this.btnClose1.TabIndex = 13;
			this.btnClose1.Text = "CLOSE";
			this.btnClose1.UseVisualStyleBackColor = true;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(245, 477);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//cboCourse
			//
			this.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboCourse.FormattingEnabled = true;
			this.cboCourse.Location = new System.Drawing.Point(162, 31);
			this.cboCourse.Name = "cboCourse";
			this.cboCourse.Size = new System.Drawing.Size(196, 21);
			this.cboCourse.TabIndex = 1;
			//
			//dgvSearch
			//
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Location = new System.Drawing.Point(7, 97);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(454, 202);
			this.dgvSearch.TabIndex = 0;
			//
			//addCourse
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 429);
			this.Controls.Add(this.btnSearchUpdate);
			this.Controls.Add(this.pnlCourse);
			this.Controls.Add(this.pnlSearch);
			this.Name = "addCourse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Course";
			this.pnlCourse.ResumeLayout(false);
			this.grpCourse.ResumeLayout(false);
			this.grpCourse.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvSearch).EndInit();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Button btnSearchUpdate;
		internal System.Windows.Forms.Panel pnlCourse;
		internal System.Windows.Forms.GroupBox grpCourse;
		internal System.Windows.Forms.ComboBox cboFaculty;
		internal System.Windows.Forms.TextBox txtCourseNo;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtBatchTiming;
		internal System.Windows.Forms.TextBox txtFees;
		internal System.Windows.Forms.TextBox txtDuration;
		internal System.Windows.Forms.TextBox txtCourseName;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Button btnUpdate;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Panel pnlSearch;
		internal System.Windows.Forms.Button btnClose1;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.ComboBox cboCourse;
		internal System.Windows.Forms.DataGridView dgvSearch;
	}
	
}
