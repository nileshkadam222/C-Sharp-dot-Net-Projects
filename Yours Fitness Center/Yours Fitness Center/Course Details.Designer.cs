namespace Yours_Fitness_Center
{
    partial class Course_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course_Details));
            this.labCourseDetail = new System.Windows.Forms.Label();
            this.panl1courceD = new System.Windows.Forms.Panel();
            this.txtctype = new System.Windows.Forms.TextBox();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.cmbcoursetype = new System.Windows.Forms.ComboBox();
            this.labcourseDuration = new System.Windows.Forms.Label();
            this.labcourseno = new System.Windows.Forms.Label();
            this.labcourcename = new System.Windows.Forms.Label();
            this.panel2courseD = new System.Windows.Forms.Panel();
            this.txtfees = new System.Windows.Forms.TextBox();
            this.cmbcoursDnoOfInstalment = new System.Windows.Forms.ComboBox();
            this.labcoursefinstallment = new System.Windows.Forms.Label();
            this.labcoursedtotalfees = new System.Windows.Forms.Label();
            this.panel3courseD = new System.Windows.Forms.Panel();
            this.butncourseDexit = new System.Windows.Forms.Button();
            this.butncourseDreset = new System.Windows.Forms.Button();
            this.butncourseDdelete = new System.Windows.Forms.Button();
            this.butncourseDupdate = new System.Windows.Forms.Button();
            this.butncourseDSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcid = new System.Windows.Forms.ComboBox();
            this.panl1courceD.SuspendLayout();
            this.panel2courseD.SuspendLayout();
            this.panel3courseD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labCourseDetail
            // 
            this.labCourseDetail.AutoSize = true;
            this.labCourseDetail.BackColor = System.Drawing.Color.Transparent;
            this.labCourseDetail.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCourseDetail.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labCourseDetail.Location = new System.Drawing.Point(256, 36);
            this.labCourseDetail.Name = "labCourseDetail";
            this.labCourseDetail.Size = new System.Drawing.Size(187, 24);
            this.labCourseDetail.TabIndex = 2;
            this.labCourseDetail.Text = "COURSE DETAILS";
            this.labCourseDetail.Click += new System.EventHandler(this.labCourseDetail_Click);
            // 
            // panl1courceD
            // 
            this.panl1courceD.BackColor = System.Drawing.Color.Transparent;
            this.panl1courceD.Controls.Add(this.cmbcid);
            this.panl1courceD.Controls.Add(this.label1);
            this.panl1courceD.Controls.Add(this.txtctype);
            this.panl1courceD.Controls.Add(this.txtcd);
            this.panl1courceD.Controls.Add(this.cmbcoursetype);
            this.panl1courceD.Controls.Add(this.labcourseDuration);
            this.panl1courceD.Controls.Add(this.labcourseno);
            this.panl1courceD.Controls.Add(this.labcourcename);
            this.panl1courceD.Location = new System.Drawing.Point(217, 73);
            this.panl1courceD.Name = "panl1courceD";
            this.panl1courceD.Size = new System.Drawing.Size(453, 212);
            this.panl1courceD.TabIndex = 3;
            // 
            // txtctype
            // 
            this.txtctype.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtctype.Location = new System.Drawing.Point(256, 120);
            this.txtctype.Name = "txtctype";
            this.txtctype.Size = new System.Drawing.Size(191, 33);
            this.txtctype.TabIndex = 24;
            // 
            // txtcd
            // 
            this.txtcd.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcd.Location = new System.Drawing.Point(256, 170);
            this.txtcd.Name = "txtcd";
            this.txtcd.Size = new System.Drawing.Size(191, 33);
            this.txtcd.TabIndex = 23;
            // 
            // cmbcoursetype
            // 
            this.cmbcoursetype.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcoursetype.FormattingEnabled = true;
            this.cmbcoursetype.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbcoursetype.Location = new System.Drawing.Point(256, 30);
            this.cmbcoursetype.Name = "cmbcoursetype";
            this.cmbcoursetype.Size = new System.Drawing.Size(191, 29);
            this.cmbcoursetype.TabIndex = 19;
            this.cmbcoursetype.Text = "  Select Gender";
            this.cmbcoursetype.SelectedIndexChanged += new System.EventHandler(this.cmbcoursetype_SelectedIndexChanged);
            // 
            // labcourseDuration
            // 
            this.labcourseDuration.AutoSize = true;
            this.labcourseDuration.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcourseDuration.ForeColor = System.Drawing.Color.Violet;
            this.labcourseDuration.Location = new System.Drawing.Point(72, 170);
            this.labcourseDuration.Name = "labcourseDuration";
            this.labcourseDuration.Size = new System.Drawing.Size(174, 21);
            this.labcourseDuration.TabIndex = 16;
            this.labcourseDuration.Text = "Course Duration";
            this.labcourseDuration.Click += new System.EventHandler(this.labcourseDuration_Click);
            // 
            // labcourseno
            // 
            this.labcourseno.AutoSize = true;
            this.labcourseno.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcourseno.ForeColor = System.Drawing.Color.Violet;
            this.labcourseno.Location = new System.Drawing.Point(72, 29);
            this.labcourseno.Name = "labcourseno";
            this.labcourseno.Size = new System.Drawing.Size(131, 21);
            this.labcourseno.TabIndex = 14;
            this.labcourseno.Text = "Course Type";
            this.labcourseno.Click += new System.EventHandler(this.labcourseno_Click);
            // 
            // labcourcename
            // 
            this.labcourcename.AutoSize = true;
            this.labcourcename.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcourcename.ForeColor = System.Drawing.Color.Violet;
            this.labcourcename.Location = new System.Drawing.Point(72, 120);
            this.labcourcename.Name = "labcourcename";
            this.labcourcename.Size = new System.Drawing.Size(136, 21);
            this.labcourcename.TabIndex = 13;
            this.labcourcename.Text = "Course Name";
            this.labcourcename.Click += new System.EventHandler(this.labcourcename_Click);
            // 
            // panel2courseD
            // 
            this.panel2courseD.BackColor = System.Drawing.Color.Transparent;
            this.panel2courseD.Controls.Add(this.txtfees);
            this.panel2courseD.Controls.Add(this.cmbcoursDnoOfInstalment);
            this.panel2courseD.Controls.Add(this.labcoursefinstallment);
            this.panel2courseD.Controls.Add(this.labcoursedtotalfees);
            this.panel2courseD.Location = new System.Drawing.Point(211, 291);
            this.panel2courseD.Name = "panel2courseD";
            this.panel2courseD.Size = new System.Drawing.Size(453, 105);
            this.panel2courseD.TabIndex = 4;
            // 
            // txtfees
            // 
            this.txtfees.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfees.Location = new System.Drawing.Point(58, 47);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(154, 33);
            this.txtfees.TabIndex = 24;
            // 
            // cmbcoursDnoOfInstalment
            // 
            this.cmbcoursDnoOfInstalment.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcoursDnoOfInstalment.FormattingEnabled = true;
            this.cmbcoursDnoOfInstalment.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbcoursDnoOfInstalment.Location = new System.Drawing.Point(240, 47);
            this.cmbcoursDnoOfInstalment.Name = "cmbcoursDnoOfInstalment";
            this.cmbcoursDnoOfInstalment.Size = new System.Drawing.Size(154, 29);
            this.cmbcoursDnoOfInstalment.TabIndex = 22;
            this.cmbcoursDnoOfInstalment.Text = "  Select";
            // 
            // labcoursefinstallment
            // 
            this.labcoursefinstallment.AutoSize = true;
            this.labcoursefinstallment.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcoursefinstallment.ForeColor = System.Drawing.Color.Violet;
            this.labcoursefinstallment.Location = new System.Drawing.Point(225, 9);
            this.labcoursefinstallment.Name = "labcoursefinstallment";
            this.labcoursefinstallment.Size = new System.Drawing.Size(191, 21);
            this.labcoursefinstallment.TabIndex = 21;
            this.labcoursefinstallment.Text = "No. of Installment";
            this.labcoursefinstallment.Click += new System.EventHandler(this.labcoursefinstallment_Click);
            // 
            // labcoursedtotalfees
            // 
            this.labcoursedtotalfees.AutoSize = true;
            this.labcoursedtotalfees.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcoursedtotalfees.ForeColor = System.Drawing.Color.Violet;
            this.labcoursedtotalfees.Location = new System.Drawing.Point(69, 9);
            this.labcoursedtotalfees.Name = "labcoursedtotalfees";
            this.labcoursedtotalfees.Size = new System.Drawing.Size(123, 21);
            this.labcoursedtotalfees.TabIndex = 15;
            this.labcoursedtotalfees.Text = "Total Fees ";
            this.labcoursedtotalfees.Click += new System.EventHandler(this.labcoursedtotalfees_Click);
            // 
            // panel3courseD
            // 
            this.panel3courseD.BackColor = System.Drawing.Color.Transparent;
            this.panel3courseD.Controls.Add(this.button1);
            this.panel3courseD.Controls.Add(this.butncourseDexit);
            this.panel3courseD.Controls.Add(this.butncourseDreset);
            this.panel3courseD.Controls.Add(this.butncourseDdelete);
            this.panel3courseD.Controls.Add(this.butncourseDupdate);
            this.panel3courseD.Controls.Add(this.butncourseDSave);
            this.panel3courseD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3courseD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3courseD.Location = new System.Drawing.Point(120, 402);
            this.panel3courseD.Name = "panel3courseD";
            this.panel3courseD.Size = new System.Drawing.Size(596, 112);
            this.panel3courseD.TabIndex = 8;
            // 
            // butncourseDexit
            // 
            this.butncourseDexit.ForeColor = System.Drawing.Color.Violet;
            this.butncourseDexit.Location = new System.Drawing.Point(265, 55);
            this.butncourseDexit.Name = "butncourseDexit";
            this.butncourseDexit.Size = new System.Drawing.Size(75, 27);
            this.butncourseDexit.TabIndex = 6;
            this.butncourseDexit.Text = "EXIT";
            this.butncourseDexit.UseVisualStyleBackColor = true;
            this.butncourseDexit.Click += new System.EventHandler(this.butncourseDexit_Click);
            // 
            // butncourseDreset
            // 
            this.butncourseDreset.ForeColor = System.Drawing.Color.Violet;
            this.butncourseDreset.Location = new System.Drawing.Point(453, 13);
            this.butncourseDreset.Name = "butncourseDreset";
            this.butncourseDreset.Size = new System.Drawing.Size(106, 27);
            this.butncourseDreset.TabIndex = 4;
            this.butncourseDreset.Text = "RESET";
            this.butncourseDreset.UseVisualStyleBackColor = true;
            this.butncourseDreset.Click += new System.EventHandler(this.butncourseDreset_Click);
            // 
            // butncourseDdelete
            // 
            this.butncourseDdelete.ForeColor = System.Drawing.Color.Violet;
            this.butncourseDdelete.Location = new System.Drawing.Point(341, 13);
            this.butncourseDdelete.Name = "butncourseDdelete";
            this.butncourseDdelete.Size = new System.Drawing.Size(106, 27);
            this.butncourseDdelete.TabIndex = 3;
            this.butncourseDdelete.Text = "DELETE";
            this.butncourseDdelete.UseVisualStyleBackColor = true;
            this.butncourseDdelete.Click += new System.EventHandler(this.butncourseDdelete_Click);
            // 
            // butncourseDupdate
            // 
            this.butncourseDupdate.ForeColor = System.Drawing.Color.Violet;
            this.butncourseDupdate.Location = new System.Drawing.Point(232, 13);
            this.butncourseDupdate.Name = "butncourseDupdate";
            this.butncourseDupdate.Size = new System.Drawing.Size(103, 27);
            this.butncourseDupdate.TabIndex = 2;
            this.butncourseDupdate.Text = "UPDATE";
            this.butncourseDupdate.UseVisualStyleBackColor = true;
            this.butncourseDupdate.Click += new System.EventHandler(this.butncourseDupdate_Click);
            // 
            // butncourseDSave
            // 
            this.butncourseDSave.ForeColor = System.Drawing.Color.Violet;
            this.butncourseDSave.Location = new System.Drawing.Point(126, 13);
            this.butncourseDSave.Name = "butncourseDSave";
            this.butncourseDSave.Size = new System.Drawing.Size(100, 27);
            this.butncourseDSave.TabIndex = 1;
            this.butncourseDSave.Text = "SAVE";
            this.butncourseDSave.UseVisualStyleBackColor = true;
            this.butncourseDSave.Click += new System.EventHandler(this.butncourseDSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 261);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Violet;
            this.button1.Location = new System.Drawing.Point(20, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(72, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Course Id";
            // 
            // cmbcid
            // 
            this.cmbcid.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcid.FormattingEnabled = true;
            this.cmbcid.Location = new System.Drawing.Point(256, 78);
            this.cmbcid.Name = "cmbcid";
            this.cmbcid.Size = new System.Drawing.Size(191, 29);
            this.cmbcid.TabIndex = 26;
            this.cmbcid.Text = "  Select Id";
            this.cmbcid.SelectedIndexChanged += new System.EventHandler(this.cmbcid_SelectedIndexChanged);
            // 
            // Course_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3courseD);
            this.Controls.Add(this.panel2courseD);
            this.Controls.Add(this.panl1courceD);
            this.Controls.Add(this.labCourseDetail);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Name = "Course_Details";
            this.Text = "Course_Details";
            this.Load += new System.EventHandler(this.Course_Details_Load);
            this.panl1courceD.ResumeLayout(false);
            this.panl1courceD.PerformLayout();
            this.panel2courseD.ResumeLayout(false);
            this.panel2courseD.PerformLayout();
            this.panel3courseD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCourseDetail;
        private System.Windows.Forms.Panel panl1courceD;
        private System.Windows.Forms.Label labcourseDuration;
        private System.Windows.Forms.Label labcourseno;
        private System.Windows.Forms.Label labcourcename;
        private System.Windows.Forms.ComboBox cmbcoursetype;
        private System.Windows.Forms.Panel panel2courseD;
        private System.Windows.Forms.ComboBox cmbcoursDnoOfInstalment;
        private System.Windows.Forms.Label labcoursefinstallment;
        private System.Windows.Forms.Label labcoursedtotalfees;
        private System.Windows.Forms.Panel panel3courseD;
        private System.Windows.Forms.Button butncourseDexit;
        private System.Windows.Forms.Button butncourseDreset;
        private System.Windows.Forms.Button butncourseDdelete;
        private System.Windows.Forms.Button butncourseDupdate;
        private System.Windows.Forms.Button butncourseDSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcd;
        private System.Windows.Forms.TextBox txtfees;
        private System.Windows.Forms.TextBox txtctype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbcid;
        private System.Windows.Forms.Label label1;

    }
}