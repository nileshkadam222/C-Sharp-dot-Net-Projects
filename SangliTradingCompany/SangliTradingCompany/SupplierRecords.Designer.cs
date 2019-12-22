namespace SangliTradingCompany
{
    partial class SupplierRecords
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
            this.Supplier_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new SangliTradingCompany.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Supplier_TableTableAdapter = new SangliTradingCompany.Database1DataSetTableAdapters.Supplier_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Supplier_TableBindingSource
            // 
            this.Supplier_TableBindingSource.DataMember = "Supplier_Table";
            this.Supplier_TableBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Supplier_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SangliTradingCompany.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(175, 133);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(771, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Supplier_TableTableAdapter
            // 
            this.Supplier_TableTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 513);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SupplierRecords";
            this.Text = "SupplierRecords";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SupplierRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Supplier_TableBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.Supplier_TableTableAdapter Supplier_TableTableAdapter;
    }
}