namespace Yours_Fitness_Center
{
    partial class Batch_Detais_Report
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
            this.labbatchDrepo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labbatchDrepo
            // 
            this.labbatchDrepo.AutoSize = true;
            this.labbatchDrepo.BackColor = System.Drawing.Color.Transparent;
            this.labbatchDrepo.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labbatchDrepo.ForeColor = System.Drawing.Color.Black;
            this.labbatchDrepo.Location = new System.Drawing.Point(141, 33);
            this.labbatchDrepo.Name = "labbatchDrepo";
            this.labbatchDrepo.Size = new System.Drawing.Size(261, 24);
            this.labbatchDrepo.TabIndex = 30;
            this.labbatchDrepo.Text = "BATCH DETAILS REPORT";
            // 
            // Batch_Detais_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 446);
            this.Controls.Add(this.labbatchDrepo);
            this.Name = "Batch_Detais_Report";
            this.Text = "Batch_Detais_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labbatchDrepo;
    }
}