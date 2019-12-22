namespace LIC
{
    partial class Form1
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
            this.LICDataSet1 = new LIC.LICDataSet1();
            this.C_PersonalDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.C_PersonalDetailsTableAdapter = new LIC.LICDataSet1TableAdapters.C_PersonalDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LICDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_PersonalDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.C_PersonalDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LIC.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(832, 469);
            this.reportViewer1.TabIndex = 0;
            // 
            // LICDataSet1
            // 
            this.LICDataSet1.DataSetName = "LICDataSet1";
            this.LICDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // C_PersonalDetailsBindingSource
            // 
            this.C_PersonalDetailsBindingSource.DataMember = "C_PersonalDetails";
            this.C_PersonalDetailsBindingSource.DataSource = this.LICDataSet1;
            // 
            // C_PersonalDetailsTableAdapter
            // 
            this.C_PersonalDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 469);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LICDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_PersonalDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource C_PersonalDetailsBindingSource;
        private LICDataSet1 LICDataSet1;
        private LICDataSet1TableAdapters.C_PersonalDetailsTableAdapter C_PersonalDetailsTableAdapter;
    }
}