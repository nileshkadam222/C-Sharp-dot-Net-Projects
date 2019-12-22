namespace LIC
{
    partial class Claim3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Claim3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ackslip = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_maturity = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbo_polno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Claim Surrender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application for Surrender/Discounted Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Policy No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(462, 84);
            this.label4.TabIndex = 4;
            this.label4.Text = "                 I intend to surrender my above policy.\r\n Kindly pay me the same." +
                "\r\n                                .\r\nI intend to have it discounted value. Kindl" +
                "y pay me the same.";
            // 
            // btn_ackslip
            // 
            this.btn_ackslip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ackslip.Location = new System.Drawing.Point(173, 432);
            this.btn_ackslip.Name = "btn_ackslip";
            this.btn_ackslip.Size = new System.Drawing.Size(211, 37);
            this.btn_ackslip.TabIndex = 5;
            this.btn_ackslip.Text = "Acknowledgement Slip";
            this.btn_ackslip.UseVisualStyleBackColor = true;
            this.btn_ackslip.Click += new System.EventHandler(this.btn_ackslip_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maturity Date";
            // 
            // dtp_maturity
            // 
            this.dtp_maturity.Enabled = false;
            this.dtp_maturity.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_maturity.Location = new System.Drawing.Point(173, 212);
            this.dtp_maturity.Name = "dtp_maturity";
            this.dtp_maturity.Size = new System.Drawing.Size(100, 29);
            this.dtp_maturity.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1262, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 31);
            this.linkLabel1.TabIndex = 60;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbo_polno
            // 
            this.cbo_polno.DropDownHeight = 120;
            this.cbo_polno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_polno.FormattingEnabled = true;
            this.cbo_polno.IntegralHeight = false;
            this.cbo_polno.Location = new System.Drawing.Point(173, 150);
            this.cbo_polno.Name = "cbo_polno";
            this.cbo_polno.Size = new System.Drawing.Size(99, 29);
            this.cbo_polno.TabIndex = 84;
            this.cbo_polno.SelectedIndexChanged += new System.EventHandler(this.cbo_polno_SelectedIndexChanged);
            this.cbo_polno.SelectedValueChanged += new System.EventHandler(this.cbo_polno_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 85;
            // 
            // Claim3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_polno);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dtp_maturity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ackslip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Claim3";
            this.Text = "LIC Surrender Form";
            this.Load += new System.EventHandler(this.Claim3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ackslip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_maturity;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ComboBox cbo_polno;
        private System.Windows.Forms.Label label6;
    }
}