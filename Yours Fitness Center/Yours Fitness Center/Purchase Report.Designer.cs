namespace Yours_Fitness_Center
{
    partial class Purchase_Report
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
            this.labpurchaseRepo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labpurchaseRepo
            // 
            this.labpurchaseRepo.AutoSize = true;
            this.labpurchaseRepo.BackColor = System.Drawing.Color.Transparent;
            this.labpurchaseRepo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpurchaseRepo.ForeColor = System.Drawing.Color.Black;
            this.labpurchaseRepo.Location = new System.Drawing.Point(240, 29);
            this.labpurchaseRepo.Name = "labpurchaseRepo";
            this.labpurchaseRepo.Size = new System.Drawing.Size(210, 24);
            this.labpurchaseRepo.TabIndex = 29;
            this.labpurchaseRepo.Text = "PURCHASE REPORT";
            // 
            // Purchase_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 530);
            this.Controls.Add(this.labpurchaseRepo);
            this.Name = "Purchase_Report";
            this.Text = "Purchase_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labpurchaseRepo;

    }
}