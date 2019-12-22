namespace Yours_Fitness_Center
{
    partial class Customer_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Details));
            this.labStudDetail = new System.Windows.Forms.Label();
            this.panl1custdetail = new System.Windows.Forms.Panel();
            this.cmbsid = new System.Windows.Forms.ComboBox();
            this.cmbcourseEn = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtBstudadd = new System.Windows.Forms.TextBox();
            this.txtBstudname = new System.Windows.Forms.TextBox();
            this.labstudbatch = new System.Windows.Forms.Label();
            this.labcourseEnrolled = new System.Windows.Forms.Label();
            this.labgender = new System.Windows.Forms.Label();
            this.labstudadd = new System.Windows.Forms.Label();
            this.labstudname = new System.Windows.Forms.Label();
            this.labstudtid = new System.Windows.Forms.Label();
            this.panel2customerD = new System.Windows.Forms.Panel();
            this.butnstudDexit = new System.Windows.Forms.Button();
            this.butnstudDreset = new System.Windows.Forms.Button();
            this.butnstudDdelete = new System.Windows.Forms.Button();
            this.butnstudDupdate = new System.Windows.Forms.Button();
            this.butnstudDSave = new System.Windows.Forms.Button();
            this.butnstudDAdd = new System.Windows.Forms.Button();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.panl1custdetail.SuspendLayout();
            this.panel2customerD.SuspendLayout();
            this.SuspendLayout();
            // 
            // labStudDetail
            // 
            this.labStudDetail.AutoSize = true;
            this.labStudDetail.BackColor = System.Drawing.Color.Transparent;
            this.labStudDetail.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStudDetail.ForeColor = System.Drawing.Color.MediumBlue;
            this.labStudDetail.Location = new System.Drawing.Point(249, 20);
            this.labStudDetail.Name = "labStudDetail";
            this.labStudDetail.Size = new System.Drawing.Size(200, 24);
            this.labStudDetail.TabIndex = 0;
            this.labStudDetail.Text = "STUDENT DETAILS";
            // 
            // panl1custdetail
            // 
            this.panl1custdetail.BackColor = System.Drawing.Color.Transparent;
            this.panl1custdetail.Controls.Add(this.cmbBatch);
            this.panl1custdetail.Controls.Add(this.cmbsid);
            this.panl1custdetail.Controls.Add(this.cmbcourseEn);
            this.panl1custdetail.Controls.Add(this.cmbgender);
            this.panl1custdetail.Controls.Add(this.txtBstudadd);
            this.panl1custdetail.Controls.Add(this.txtBstudname);
            this.panl1custdetail.Controls.Add(this.labstudbatch);
            this.panl1custdetail.Controls.Add(this.labcourseEnrolled);
            this.panl1custdetail.Controls.Add(this.labgender);
            this.panl1custdetail.Controls.Add(this.labstudadd);
            this.panl1custdetail.Controls.Add(this.labstudname);
            this.panl1custdetail.Controls.Add(this.labstudtid);
            this.panl1custdetail.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panl1custdetail.Location = new System.Drawing.Point(58, 47);
            this.panl1custdetail.Name = "panl1custdetail";
            this.panl1custdetail.Size = new System.Drawing.Size(604, 284);
            this.panl1custdetail.TabIndex = 1;
            // 
            // cmbsid
            // 
            this.cmbsid.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsid.FormattingEnabled = true;
            this.cmbsid.Location = new System.Drawing.Point(390, 7);
            this.cmbsid.Name = "cmbsid";
            this.cmbsid.Size = new System.Drawing.Size(148, 29);
            this.cmbsid.TabIndex = 14;
            this.cmbsid.SelectedIndexChanged += new System.EventHandler(this.cmbsid_SelectedIndexChanged);
            // 
            // cmbcourseEn
            // 
            this.cmbcourseEn.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcourseEn.FormattingEnabled = true;
            this.cmbcourseEn.Location = new System.Drawing.Point(390, 170);
            this.cmbcourseEn.Name = "cmbcourseEn";
            this.cmbcourseEn.Size = new System.Drawing.Size(148, 29);
            this.cmbcourseEn.TabIndex = 13;
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbgender.Location = new System.Drawing.Point(390, 90);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(148, 29);
            this.cmbgender.TabIndex = 11;
            // 
            // txtBstudadd
            // 
            this.txtBstudadd.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBstudadd.ForeColor = System.Drawing.Color.Black;
            this.txtBstudadd.Location = new System.Drawing.Point(390, 126);
            this.txtBstudadd.Name = "txtBstudadd";
            this.txtBstudadd.Size = new System.Drawing.Size(148, 33);
            this.txtBstudadd.TabIndex = 9;
            // 
            // txtBstudname
            // 
            this.txtBstudname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBstudname.ForeColor = System.Drawing.Color.Black;
            this.txtBstudname.Location = new System.Drawing.Point(390, 48);
            this.txtBstudname.Name = "txtBstudname";
            this.txtBstudname.Size = new System.Drawing.Size(148, 33);
            this.txtBstudname.TabIndex = 7;
            // 
            // labstudbatch
            // 
            this.labstudbatch.AutoSize = true;
            this.labstudbatch.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstudbatch.ForeColor = System.Drawing.Color.MediumBlue;
            this.labstudbatch.Location = new System.Drawing.Point(146, 211);
            this.labstudbatch.Name = "labstudbatch";
            this.labstudbatch.Size = new System.Drawing.Size(70, 21);
            this.labstudbatch.TabIndex = 6;
            this.labstudbatch.Text = "Batch";
            // 
            // labcourseEnrolled
            // 
            this.labcourseEnrolled.AutoSize = true;
            this.labcourseEnrolled.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcourseEnrolled.ForeColor = System.Drawing.Color.MediumBlue;
            this.labcourseEnrolled.Location = new System.Drawing.Point(62, 172);
            this.labcourseEnrolled.Name = "labcourseEnrolled";
            this.labcourseEnrolled.Size = new System.Drawing.Size(175, 21);
            this.labcourseEnrolled.TabIndex = 5;
            this.labcourseEnrolled.Text = "Course Enrolled";
            // 
            // labgender
            // 
            this.labgender.AutoSize = true;
            this.labgender.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labgender.ForeColor = System.Drawing.Color.MediumBlue;
            this.labgender.Location = new System.Drawing.Point(134, 92);
            this.labgender.Name = "labgender";
            this.labgender.Size = new System.Drawing.Size(81, 21);
            this.labgender.TabIndex = 4;
            this.labgender.Text = "Gender";
            // 
            // labstudadd
            // 
            this.labstudadd.AutoSize = true;
            this.labstudadd.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstudadd.ForeColor = System.Drawing.Color.MediumBlue;
            this.labstudadd.Location = new System.Drawing.Point(130, 130);
            this.labstudadd.Name = "labstudadd";
            this.labstudadd.Size = new System.Drawing.Size(92, 21);
            this.labstudadd.TabIndex = 2;
            this.labstudadd.Text = "Address";
            // 
            // labstudname
            // 
            this.labstudname.AutoSize = true;
            this.labstudname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstudname.ForeColor = System.Drawing.Color.MediumBlue;
            this.labstudname.Location = new System.Drawing.Point(79, 50);
            this.labstudname.Name = "labstudname";
            this.labstudname.Size = new System.Drawing.Size(145, 21);
            this.labstudname.TabIndex = 1;
            this.labstudname.Text = "Student Name";
            // 
            // labstudtid
            // 
            this.labstudtid.AutoSize = true;
            this.labstudtid.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstudtid.ForeColor = System.Drawing.Color.MediumBlue;
            this.labstudtid.Location = new System.Drawing.Point(106, 7);
            this.labstudtid.Name = "labstudtid";
            this.labstudtid.Size = new System.Drawing.Size(111, 21);
            this.labstudtid.TabIndex = 0;
            this.labstudtid.Text = "Student ID";
            // 
            // panel2customerD
            // 
            this.panel2customerD.BackColor = System.Drawing.Color.Transparent;
            this.panel2customerD.Controls.Add(this.butnstudDexit);
            this.panel2customerD.Controls.Add(this.butnstudDreset);
            this.panel2customerD.Controls.Add(this.butnstudDdelete);
            this.panel2customerD.Controls.Add(this.butnstudDupdate);
            this.panel2customerD.Controls.Add(this.butnstudDSave);
            this.panel2customerD.Controls.Add(this.butnstudDAdd);
            this.panel2customerD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2customerD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2customerD.Location = new System.Drawing.Point(58, 337);
            this.panel2customerD.Name = "panel2customerD";
            this.panel2customerD.Size = new System.Drawing.Size(604, 112);
            this.panel2customerD.TabIndex = 8;
            // 
            // butnstudDexit
            // 
            this.butnstudDexit.Location = new System.Drawing.Point(329, 65);
            this.butnstudDexit.Name = "butnstudDexit";
            this.butnstudDexit.Size = new System.Drawing.Size(75, 27);
            this.butnstudDexit.TabIndex = 6;
            this.butnstudDexit.Text = "EXIT";
            this.butnstudDexit.UseVisualStyleBackColor = true;
            this.butnstudDexit.Click += new System.EventHandler(this.butnstudDexit_Click);
            // 
            // butnstudDreset
            // 
            this.butnstudDreset.Location = new System.Drawing.Point(186, 65);
            this.butnstudDreset.Name = "butnstudDreset";
            this.butnstudDreset.Size = new System.Drawing.Size(75, 27);
            this.butnstudDreset.TabIndex = 4;
            this.butnstudDreset.Text = "RESET";
            this.butnstudDreset.UseVisualStyleBackColor = true;
            this.butnstudDreset.Click += new System.EventHandler(this.butnstudDreset_Click);
            // 
            // butnstudDdelete
            // 
            this.butnstudDdelete.Location = new System.Drawing.Point(411, 13);
            this.butnstudDdelete.Name = "butnstudDdelete";
            this.butnstudDdelete.Size = new System.Drawing.Size(75, 27);
            this.butnstudDdelete.TabIndex = 3;
            this.butnstudDdelete.Text = "DELETE";
            this.butnstudDdelete.UseVisualStyleBackColor = true;
            this.butnstudDdelete.Click += new System.EventHandler(this.butnstudDdelete_Click);
            // 
            // butnstudDupdate
            // 
            this.butnstudDupdate.Location = new System.Drawing.Point(283, 13);
            this.butnstudDupdate.Name = "butnstudDupdate";
            this.butnstudDupdate.Size = new System.Drawing.Size(90, 27);
            this.butnstudDupdate.TabIndex = 2;
            this.butnstudDupdate.Text = "UPDATE";
            this.butnstudDupdate.UseVisualStyleBackColor = true;
            this.butnstudDupdate.Click += new System.EventHandler(this.butnstudDupdate_Click);
            // 
            // butnstudDSave
            // 
            this.butnstudDSave.Location = new System.Drawing.Point(139, 13);
            this.butnstudDSave.Name = "butnstudDSave";
            this.butnstudDSave.Size = new System.Drawing.Size(100, 27);
            this.butnstudDSave.TabIndex = 1;
            this.butnstudDSave.Text = "SAVE";
            this.butnstudDSave.UseVisualStyleBackColor = true;
            this.butnstudDSave.Click += new System.EventHandler(this.butnstudDSave_Click);
            // 
            // butnstudDAdd
            // 
            this.butnstudDAdd.Location = new System.Drawing.Point(22, 13);
            this.butnstudDAdd.Name = "butnstudDAdd";
            this.butnstudDAdd.Size = new System.Drawing.Size(75, 27);
            this.butnstudDAdd.TabIndex = 0;
            this.butnstudDAdd.Text = "ADD";
            this.butnstudDAdd.UseVisualStyleBackColor = true;
            this.butnstudDAdd.Click += new System.EventHandler(this.butnstudDAdd_Click);
            // 
            // cmbBatch
            // 
            this.cmbBatch.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Items.AddRange(new object[] {
            "1-  7 to 8 am",
            "2-  8 to 9 am",
            "3-  9 to 10 am",
            "4-  10 to 11 am",
            "5-  11 to 12 am",
            "6-  12 to 1 pm",
            "7-  1 to 2 pm",
            "8-  2 to 3 pm",
            "9-  3 to 4 pm",
            "10-  4 to 5 pm",
            "11-  5 to 6 pm",
            "12-  6 to 7 pm",
            "13-  7 to 8 pm",
            "14-  8 to 9 pm"});
            this.cmbBatch.Location = new System.Drawing.Point(390, 211);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(148, 29);
            this.cmbBatch.TabIndex = 15;
            // 
            // Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 477);
            this.Controls.Add(this.panel2customerD);
            this.Controls.Add(this.panl1custdetail);
            this.Controls.Add(this.labStudDetail);
            this.Name = "Customer_Details";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Customer_Details_Load);
            this.panl1custdetail.ResumeLayout(false);
            this.panl1custdetail.PerformLayout();
            this.panel2customerD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStudDetail;
        private System.Windows.Forms.Panel panl1custdetail;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtBstudadd;
        private System.Windows.Forms.TextBox txtBstudname;
        private System.Windows.Forms.Label labstudbatch;
        private System.Windows.Forms.Label labcourseEnrolled;
        private System.Windows.Forms.Label labgender;
        private System.Windows.Forms.Label labstudadd;
        private System.Windows.Forms.Label labstudname;
        private System.Windows.Forms.Label labstudtid;
        private System.Windows.Forms.ComboBox cmbsid;
        private System.Windows.Forms.ComboBox cmbcourseEn;
        private System.Windows.Forms.Panel panel2customerD;
        private System.Windows.Forms.Button butnstudDexit;
        private System.Windows.Forms.Button butnstudDreset;
        private System.Windows.Forms.Button butnstudDdelete;
        private System.Windows.Forms.Button butnstudDupdate;
        private System.Windows.Forms.Button butnstudDSave;
        private System.Windows.Forms.Button butnstudDAdd;
        private System.Windows.Forms.ComboBox cmbBatch;
    }
}