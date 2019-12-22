namespace SangliTradingCompany
{
    partial class EmployeeAttendenceReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AttendenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new SangliTradingCompany.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AttendenceTableAdapter = new SangliTradingCompany.Database1DataSetTableAdapters.AttendenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AttendenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendenceBindingSource
            // 
            this.AttendenceBindingSource.DataMember = "Attendence";
            this.AttendenceBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AttendenceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SangliTradingCompany.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(190, 180);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(687, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // AttendenceTableAdapter
            // 
            this.AttendenceTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeAttendenceReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1332, 635);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmployeeAttendenceReports";
            this.Text = "EmployeeAttendenceReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeAttendenceReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AttendenceBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.AttendenceTableAdapter AttendenceTableAdapter;
    }
}