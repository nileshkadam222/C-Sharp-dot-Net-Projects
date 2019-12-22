namespace LIC
{
    partial class Form3
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LICDataSet3 = new LIC.LICDataSet3();
            this.T_CommissionDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.T_CommissionDataTableAdapter = new LIC.LICDataSet3TableAdapters.T_CommissionDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LICDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_CommissionDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.T_CommissionDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LIC.Report.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(770, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // LICDataSet3
            // 
            this.LICDataSet3.DataSetName = "LICDataSet3";
            this.LICDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T_CommissionDataBindingSource
            // 
            this.T_CommissionDataBindingSource.DataMember = "T_CommissionData";
            this.T_CommissionDataBindingSource.DataSource = this.LICDataSet3;
            // 
            // T_CommissionDataTableAdapter
            // 
            this.T_CommissionDataTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 437);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LICDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_CommissionDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource T_CommissionDataBindingSource;
        private LICDataSet3 LICDataSet3;
        private LICDataSet3TableAdapters.T_CommissionDataTableAdapter T_CommissionDataTableAdapter;
    }
}