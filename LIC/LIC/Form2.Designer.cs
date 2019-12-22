namespace LIC
{
    partial class Form2
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
            this.T_PaymentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LICDataSet2 = new LIC.LICDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.T_PaymentDetailsTableAdapter = new LIC.LICDataSet2TableAdapters.T_PaymentDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.T_PaymentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LICDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // T_PaymentDetailsBindingSource
            // 
            this.T_PaymentDetailsBindingSource.DataMember = "T_PaymentDetails";
            this.T_PaymentDetailsBindingSource.DataSource = this.LICDataSet2;
            // 
            // LICDataSet2
            // 
            this.LICDataSet2.DataSetName = "LICDataSet2";
            this.LICDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.T_PaymentDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LIC.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(821, 512);
            this.reportViewer1.TabIndex = 0;
            // 
            // T_PaymentDetailsTableAdapter
            // 
            this.T_PaymentDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 512);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_PaymentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LICDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource T_PaymentDetailsBindingSource;
        private LICDataSet2 LICDataSet2;
        private LICDataSet2TableAdapters.T_PaymentDetailsTableAdapter T_PaymentDetailsTableAdapter;
    }
}