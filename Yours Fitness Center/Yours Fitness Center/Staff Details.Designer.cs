namespace Yours_Fitness_Center
{
    partial class Staff_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Details));
            this.panl1StaffD = new System.Windows.Forms.Panel();
            this.cmbsid = new System.Windows.Forms.ComboBox();
            this.labstaffsalary = new System.Windows.Forms.Label();
            this.comboBExperience = new System.Windows.Forms.ComboBox();
            this.comboBQualification = new System.Windows.Forms.ComboBox();
            this.comboBstaffgender = new System.Windows.Forms.ComboBox();
            this.textBstaffadd = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.textBstaffname = new System.Windows.Forms.TextBox();
            this.labExperience = new System.Windows.Forms.Label();
            this.labQualification = new System.Windows.Forms.Label();
            this.labstaffgender = new System.Windows.Forms.Label();
            this.labstaffadd = new System.Windows.Forms.Label();
            this.labstaffname = new System.Windows.Forms.Label();
            this.labstafftid = new System.Windows.Forms.Label();
            this.labStaffDetail = new System.Windows.Forms.Label();
            this.panel2staffD = new System.Windows.Forms.Panel();
            this.butnstaffDexit = new System.Windows.Forms.Button();
            this.butnstaffDreset = new System.Windows.Forms.Button();
            this.butnstaffDdelete = new System.Windows.Forms.Button();
            this.butnstaffDupdate = new System.Windows.Forms.Button();
            this.butnstaffDSave = new System.Windows.Forms.Button();
            this.butnstaffDAdd = new System.Windows.Forms.Button();
            this.panl1StaffD.SuspendLayout();
            this.panel2staffD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl1StaffD
            // 
            this.panl1StaffD.BackColor = System.Drawing.Color.Transparent;
            this.panl1StaffD.Controls.Add(this.cmbsid);
            this.panl1StaffD.Controls.Add(this.labstaffsalary);
            this.panl1StaffD.Controls.Add(this.comboBExperience);
            this.panl1StaffD.Controls.Add(this.comboBQualification);
            this.panl1StaffD.Controls.Add(this.comboBstaffgender);
            this.panl1StaffD.Controls.Add(this.textBstaffadd);
            this.panl1StaffD.Controls.Add(this.txtsal);
            this.panl1StaffD.Controls.Add(this.textBstaffname);
            this.panl1StaffD.Controls.Add(this.labExperience);
            this.panl1StaffD.Controls.Add(this.labQualification);
            this.panl1StaffD.Controls.Add(this.labstaffgender);
            this.panl1StaffD.Controls.Add(this.labstaffadd);
            this.panl1StaffD.Controls.Add(this.labstaffname);
            this.panl1StaffD.Controls.Add(this.labstafftid);
            this.panl1StaffD.Location = new System.Drawing.Point(79, 77);
            this.panl1StaffD.Name = "panl1StaffD";
            this.panl1StaffD.Size = new System.Drawing.Size(558, 311);
            this.panl1StaffD.TabIndex = 0;
            // 
            // cmbsid
            // 
            this.cmbsid.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsid.FormattingEnabled = true;
            this.cmbsid.Location = new System.Drawing.Point(310, 16);
            this.cmbsid.Name = "cmbsid";
            this.cmbsid.Size = new System.Drawing.Size(154, 29);
            this.cmbsid.TabIndex = 23;
            this.cmbsid.Text = "  ";
            this.cmbsid.SelectedIndexChanged += new System.EventHandler(this.cmbsid_SelectedIndexChanged);
            // 
            // labstaffsalary
            // 
            this.labstaffsalary.AutoSize = true;
            this.labstaffsalary.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstaffsalary.ForeColor = System.Drawing.Color.Violet;
            this.labstaffsalary.Location = new System.Drawing.Point(73, 270);
            this.labstaffsalary.Name = "labstaffsalary";
            this.labstaffsalary.Size = new System.Drawing.Size(83, 21);
            this.labstaffsalary.TabIndex = 22;
            this.labstaffsalary.Text = "Salary";
            // 
            // comboBExperience
            // 
            this.comboBExperience.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBExperience.FormattingEnabled = true;
            this.comboBExperience.Items.AddRange(new object[] {
            "1 Year",
            "2 Year",
            "3 Year",
            "5 Year & above"});
            this.comboBExperience.Location = new System.Drawing.Point(310, 229);
            this.comboBExperience.Name = "comboBExperience";
            this.comboBExperience.Size = new System.Drawing.Size(154, 29);
            this.comboBExperience.TabIndex = 21;
            this.comboBExperience.Text = "  ";
            // 
            // comboBQualification
            // 
            this.comboBQualification.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBQualification.FormattingEnabled = true;
            this.comboBQualification.Items.AddRange(new object[] {
            "10th ",
            "12th",
            "Graduate",
            "Post Graduate",
            "P.H.D."});
            this.comboBQualification.Location = new System.Drawing.Point(310, 191);
            this.comboBQualification.Name = "comboBQualification";
            this.comboBQualification.Size = new System.Drawing.Size(154, 29);
            this.comboBQualification.TabIndex = 20;
            this.comboBQualification.Text = "  ";
            // 
            // comboBstaffgender
            // 
            this.comboBstaffgender.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBstaffgender.FormattingEnabled = true;
            this.comboBstaffgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBstaffgender.Location = new System.Drawing.Point(310, 104);
            this.comboBstaffgender.Name = "comboBstaffgender";
            this.comboBstaffgender.Size = new System.Drawing.Size(154, 29);
            this.comboBstaffgender.TabIndex = 18;
            this.comboBstaffgender.Text = "  ";
            // 
            // textBstaffadd
            // 
            this.textBstaffadd.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBstaffadd.ForeColor = System.Drawing.Color.Black;
            this.textBstaffadd.Location = new System.Drawing.Point(310, 146);
            this.textBstaffadd.Multiline = true;
            this.textBstaffadd.Name = "textBstaffadd";
            this.textBstaffadd.Size = new System.Drawing.Size(154, 36);
            this.textBstaffadd.TabIndex = 17;
            this.textBstaffadd.Text = "  ";
            // 
            // txtsal
            // 
            this.txtsal.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsal.ForeColor = System.Drawing.Color.Black;
            this.txtsal.Location = new System.Drawing.Point(310, 266);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(154, 33);
            this.txtsal.TabIndex = 16;
            this.txtsal.Text = "  ";
            // 
            // textBstaffname
            // 
            this.textBstaffname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBstaffname.ForeColor = System.Drawing.Color.Black;
            this.textBstaffname.Location = new System.Drawing.Point(310, 54);
            this.textBstaffname.Name = "textBstaffname";
            this.textBstaffname.Size = new System.Drawing.Size(154, 33);
            this.textBstaffname.TabIndex = 15;
            this.textBstaffname.Text = "    ";
            // 
            // labExperience
            // 
            this.labExperience.AutoSize = true;
            this.labExperience.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExperience.ForeColor = System.Drawing.Color.Violet;
            this.labExperience.Location = new System.Drawing.Point(72, 229);
            this.labExperience.Name = "labExperience";
            this.labExperience.Size = new System.Drawing.Size(122, 21);
            this.labExperience.TabIndex = 14;
            this.labExperience.Text = "Experience";
            // 
            // labQualification
            // 
            this.labQualification.AutoSize = true;
            this.labQualification.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQualification.ForeColor = System.Drawing.Color.Violet;
            this.labQualification.Location = new System.Drawing.Point(72, 189);
            this.labQualification.Name = "labQualification";
            this.labQualification.Size = new System.Drawing.Size(145, 21);
            this.labQualification.TabIndex = 13;
            this.labQualification.Text = "Qualification";
            // 
            // labstaffgender
            // 
            this.labstaffgender.AutoSize = true;
            this.labstaffgender.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstaffgender.ForeColor = System.Drawing.Color.Violet;
            this.labstaffgender.Location = new System.Drawing.Point(73, 104);
            this.labstaffgender.Name = "labstaffgender";
            this.labstaffgender.Size = new System.Drawing.Size(81, 21);
            this.labstaffgender.TabIndex = 12;
            this.labstaffgender.Text = "Gender";
            // 
            // labstaffadd
            // 
            this.labstaffadd.AutoSize = true;
            this.labstaffadd.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstaffadd.ForeColor = System.Drawing.Color.Violet;
            this.labstaffadd.Location = new System.Drawing.Point(72, 149);
            this.labstaffadd.Name = "labstaffadd";
            this.labstaffadd.Size = new System.Drawing.Size(92, 21);
            this.labstaffadd.TabIndex = 10;
            this.labstaffadd.Text = "Address";
            // 
            // labstaffname
            // 
            this.labstaffname.AutoSize = true;
            this.labstaffname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstaffname.ForeColor = System.Drawing.Color.Violet;
            this.labstaffname.Location = new System.Drawing.Point(60, 58);
            this.labstaffname.Name = "labstaffname";
            this.labstaffname.Size = new System.Drawing.Size(122, 21);
            this.labstaffname.TabIndex = 9;
            this.labstaffname.Text = "Staff Name";
            // 
            // labstafftid
            // 
            this.labstafftid.AutoSize = true;
            this.labstafftid.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstafftid.ForeColor = System.Drawing.Color.Violet;
            this.labstafftid.Location = new System.Drawing.Point(71, 16);
            this.labstafftid.Name = "labstafftid";
            this.labstafftid.Size = new System.Drawing.Size(88, 21);
            this.labstafftid.TabIndex = 8;
            this.labstafftid.Text = "Staff ID";
            // 
            // labStaffDetail
            // 
            this.labStaffDetail.AutoSize = true;
            this.labStaffDetail.BackColor = System.Drawing.Color.Transparent;
            this.labStaffDetail.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStaffDetail.ForeColor = System.Drawing.Color.Violet;
            this.labStaffDetail.Location = new System.Drawing.Point(261, 31);
            this.labStaffDetail.Name = "labStaffDetail";
            this.labStaffDetail.Size = new System.Drawing.Size(167, 24);
            this.labStaffDetail.TabIndex = 1;
            this.labStaffDetail.Text = "STAFF DETAILS";
            // 
            // panel2staffD
            // 
            this.panel2staffD.BackColor = System.Drawing.Color.Transparent;
            this.panel2staffD.Controls.Add(this.butnstaffDexit);
            this.panel2staffD.Controls.Add(this.butnstaffDreset);
            this.panel2staffD.Controls.Add(this.butnstaffDdelete);
            this.panel2staffD.Controls.Add(this.butnstaffDupdate);
            this.panel2staffD.Controls.Add(this.butnstaffDSave);
            this.panel2staffD.Controls.Add(this.butnstaffDAdd);
            this.panel2staffD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2staffD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2staffD.Location = new System.Drawing.Point(79, 394);
            this.panel2staffD.Name = "panel2staffD";
            this.panel2staffD.Size = new System.Drawing.Size(558, 112);
            this.panel2staffD.TabIndex = 8;
            // 
            // butnstaffDexit
            // 
            this.butnstaffDexit.Location = new System.Drawing.Point(329, 65);
            this.butnstaffDexit.Name = "butnstaffDexit";
            this.butnstaffDexit.Size = new System.Drawing.Size(75, 27);
            this.butnstaffDexit.TabIndex = 6;
            this.butnstaffDexit.Text = "EXIT";
            this.butnstaffDexit.UseVisualStyleBackColor = true;
            this.butnstaffDexit.Click += new System.EventHandler(this.butnstaffDexit_Click);
            // 
            // butnstaffDreset
            // 
            this.butnstaffDreset.Location = new System.Drawing.Point(186, 65);
            this.butnstaffDreset.Name = "butnstaffDreset";
            this.butnstaffDreset.Size = new System.Drawing.Size(75, 27);
            this.butnstaffDreset.TabIndex = 4;
            this.butnstaffDreset.Text = "RESET";
            this.butnstaffDreset.UseVisualStyleBackColor = true;
            this.butnstaffDreset.Click += new System.EventHandler(this.butnstaffDreset_Click);
            // 
            // butnstaffDdelete
            // 
            this.butnstaffDdelete.Location = new System.Drawing.Point(411, 13);
            this.butnstaffDdelete.Name = "butnstaffDdelete";
            this.butnstaffDdelete.Size = new System.Drawing.Size(75, 27);
            this.butnstaffDdelete.TabIndex = 3;
            this.butnstaffDdelete.Text = "DELETE";
            this.butnstaffDdelete.UseVisualStyleBackColor = true;
            this.butnstaffDdelete.Click += new System.EventHandler(this.butnstaffDdelete_Click);
            // 
            // butnstaffDupdate
            // 
            this.butnstaffDupdate.Location = new System.Drawing.Point(283, 13);
            this.butnstaffDupdate.Name = "butnstaffDupdate";
            this.butnstaffDupdate.Size = new System.Drawing.Size(75, 27);
            this.butnstaffDupdate.TabIndex = 2;
            this.butnstaffDupdate.Text = "UPDATE";
            this.butnstaffDupdate.UseVisualStyleBackColor = true;
            this.butnstaffDupdate.Click += new System.EventHandler(this.butnstaffDupdate_Click);
            // 
            // butnstaffDSave
            // 
            this.butnstaffDSave.Location = new System.Drawing.Point(139, 13);
            this.butnstaffDSave.Name = "butnstaffDSave";
            this.butnstaffDSave.Size = new System.Drawing.Size(100, 27);
            this.butnstaffDSave.TabIndex = 1;
            this.butnstaffDSave.Text = "SAVE";
            this.butnstaffDSave.UseVisualStyleBackColor = true;
            this.butnstaffDSave.Click += new System.EventHandler(this.butnstaffDSave_Click);
            // 
            // butnstaffDAdd
            // 
            this.butnstaffDAdd.Location = new System.Drawing.Point(22, 13);
            this.butnstaffDAdd.Name = "butnstaffDAdd";
            this.butnstaffDAdd.Size = new System.Drawing.Size(75, 27);
            this.butnstaffDAdd.TabIndex = 0;
            this.butnstaffDAdd.Text = "ADD";
            this.butnstaffDAdd.UseVisualStyleBackColor = true;
            this.butnstaffDAdd.Click += new System.EventHandler(this.butnstaffDAdd_Click);
            // 
            // Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 518);
            this.Controls.Add(this.panel2staffD);
            this.Controls.Add(this.labStaffDetail);
            this.Controls.Add(this.panl1StaffD);
            this.Name = "Staff_Details";
            this.Text = "Staff_Details";
            this.Load += new System.EventHandler(this.Staff_Details_Load);
            this.panl1StaffD.ResumeLayout(false);
            this.panl1StaffD.PerformLayout();
            this.panel2staffD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panl1StaffD;
        private System.Windows.Forms.Label labStaffDetail;
        private System.Windows.Forms.Label labExperience;
        private System.Windows.Forms.Label labQualification;
        private System.Windows.Forms.Label labstaffgender;
        private System.Windows.Forms.Label labstaffadd;
        private System.Windows.Forms.Label labstaffname;
        private System.Windows.Forms.Label labstafftid;
        private System.Windows.Forms.ComboBox comboBExperience;
        private System.Windows.Forms.ComboBox comboBQualification;
        private System.Windows.Forms.ComboBox comboBstaffgender;
        private System.Windows.Forms.TextBox textBstaffadd;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox textBstaffname;
        private System.Windows.Forms.Panel panel2staffD;
        private System.Windows.Forms.Button butnstaffDexit;
        private System.Windows.Forms.Button butnstaffDreset;
        private System.Windows.Forms.Button butnstaffDdelete;
        private System.Windows.Forms.Button butnstaffDupdate;
        private System.Windows.Forms.Button butnstaffDSave;
        private System.Windows.Forms.Button butnstaffDAdd;
        private System.Windows.Forms.ComboBox cmbsid;
        private System.Windows.Forms.Label labstaffsalary;
    }
}