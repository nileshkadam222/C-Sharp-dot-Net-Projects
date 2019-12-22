namespace Yours_Fitness_Center
{
    partial class frmSplash_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash_Screen));
            this.labsplashscreen = new System.Windows.Forms.Label();
            this.labsplash1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labsplashscreen
            // 
            this.labsplashscreen.AutoSize = true;
            this.labsplashscreen.BackColor = System.Drawing.Color.Transparent;
            this.labsplashscreen.Location = new System.Drawing.Point(201, 25);
            this.labsplashscreen.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labsplashscreen.Name = "labsplashscreen";
            this.labsplashscreen.Size = new System.Drawing.Size(239, 33);
            this.labsplashscreen.TabIndex = 0;
            this.labsplashscreen.Text = "Gym Management";
            this.labsplashscreen.UseWaitCursor = true;
            // 
            // labsplash1
            // 
            this.labsplash1.AutoSize = true;
            this.labsplash1.BackColor = System.Drawing.Color.Transparent;
            this.labsplash1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsplash1.Location = new System.Drawing.Point(337, 404);
            this.labsplash1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labsplash1.Name = "labsplash1";
            this.labsplash1.Size = new System.Drawing.Size(375, 22);
            this.labsplash1.TabIndex = 1;
            this.labsplash1.Text = "Developed By : Ashish Chavan & Tejash Mhatre";
            this.labsplash1.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.YellowGreen;
            this.progressBar1.Location = new System.Drawing.Point(12, 440);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(677, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 465);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labsplash1);
            this.Controls.Add(this.labsplashscreen);
            this.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmSplash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labsplashscreen;
        private System.Windows.Forms.Label labsplash1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}