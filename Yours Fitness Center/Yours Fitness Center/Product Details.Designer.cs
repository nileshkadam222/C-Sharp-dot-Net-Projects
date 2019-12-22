namespace Yours_Fitness_Center
{
    partial class Machin_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Machin_Details));
            this.panl1MachinD = new System.Windows.Forms.Panel();
            this.labproprice = new System.Windows.Forms.Label();
            this.labpromfgdate = new System.Windows.Forms.Label();
            this.cmbMachinid = new System.Windows.Forms.ComboBox();
            this.labProname = new System.Windows.Forms.Label();
            this.labmachinid = new System.Windows.Forms.Label();
            this.labproQuantity = new System.Windows.Forms.Label();
            this.labMachinDetail = new System.Windows.Forms.Label();
            this.panel2MachinD = new System.Windows.Forms.Panel();
            this.butnproDexit = new System.Windows.Forms.Button();
            this.butnproDreset = new System.Windows.Forms.Button();
            this.butnproDdelete = new System.Windows.Forms.Button();
            this.butnproDupdate = new System.Windows.Forms.Button();
            this.butnproDSave = new System.Windows.Forms.Button();
            this.butnproDAdd = new System.Windows.Forms.Button();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panl1MachinD.SuspendLayout();
            this.panel2MachinD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl1MachinD
            // 
            this.panl1MachinD.BackColor = System.Drawing.Color.Transparent;
            this.panl1MachinD.Controls.Add(this.dateTimePicker1);
            this.panl1MachinD.Controls.Add(this.txtprice);
            this.panl1MachinD.Controls.Add(this.txtqty);
            this.panl1MachinD.Controls.Add(this.txtmname);
            this.panl1MachinD.Controls.Add(this.labproprice);
            this.panl1MachinD.Controls.Add(this.labpromfgdate);
            this.panl1MachinD.Controls.Add(this.cmbMachinid);
            this.panl1MachinD.Controls.Add(this.labProname);
            this.panl1MachinD.Controls.Add(this.labmachinid);
            this.panl1MachinD.Controls.Add(this.labproQuantity);
            this.panl1MachinD.Location = new System.Drawing.Point(102, 86);
            this.panl1MachinD.Name = "panl1MachinD";
            this.panl1MachinD.Size = new System.Drawing.Size(575, 274);
            this.panl1MachinD.TabIndex = 4;
            // 
            // labproprice
            // 
            this.labproprice.AutoSize = true;
            this.labproprice.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labproprice.ForeColor = System.Drawing.Color.SeaShell;
            this.labproprice.Location = new System.Drawing.Point(72, 205);
            this.labproprice.Name = "labproprice";
            this.labproprice.Size = new System.Drawing.Size(135, 21);
            this.labproprice.TabIndex = 23;
            this.labproprice.Text = "Machin Price";
            // 
            // labpromfgdate
            // 
            this.labpromfgdate.AutoSize = true;
            this.labpromfgdate.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpromfgdate.ForeColor = System.Drawing.Color.SeaShell;
            this.labpromfgdate.Location = new System.Drawing.Point(72, 164);
            this.labpromfgdate.Name = "labpromfgdate";
            this.labpromfgdate.Size = new System.Drawing.Size(105, 21);
            this.labpromfgdate.TabIndex = 22;
            this.labpromfgdate.Text = "Mfg. Date";
            // 
            // cmbMachinid
            // 
            this.cmbMachinid.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMachinid.FormattingEnabled = true;
            this.cmbMachinid.Location = new System.Drawing.Point(293, 30);
            this.cmbMachinid.Name = "cmbMachinid";
            this.cmbMachinid.Size = new System.Drawing.Size(154, 29);
            this.cmbMachinid.TabIndex = 19;
            this.cmbMachinid.Text = "  Select Id";
            this.cmbMachinid.SelectedIndexChanged += new System.EventHandler(this.cmbMachinid_SelectedIndexChanged);
            // 
            // labProname
            // 
            this.labProname.AutoSize = true;
            this.labProname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProname.ForeColor = System.Drawing.Color.SeaShell;
            this.labProname.Location = new System.Drawing.Point(72, 70);
            this.labProname.Name = "labProname";
            this.labProname.Size = new System.Drawing.Size(134, 21);
            this.labProname.TabIndex = 16;
            this.labProname.Text = "Machin Name";
            // 
            // labmachinid
            // 
            this.labmachinid.AutoSize = true;
            this.labmachinid.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmachinid.ForeColor = System.Drawing.Color.SeaShell;
            this.labmachinid.Location = new System.Drawing.Point(72, 29);
            this.labmachinid.Name = "labmachinid";
            this.labmachinid.Size = new System.Drawing.Size(100, 21);
            this.labmachinid.TabIndex = 14;
            this.labmachinid.Text = "Machin ID";
            // 
            // labproQuantity
            // 
            this.labproQuantity.AutoSize = true;
            this.labproQuantity.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labproQuantity.ForeColor = System.Drawing.Color.SeaShell;
            this.labproQuantity.Location = new System.Drawing.Point(72, 116);
            this.labproQuantity.Name = "labproQuantity";
            this.labproQuantity.Size = new System.Drawing.Size(99, 21);
            this.labproQuantity.TabIndex = 13;
            this.labproQuantity.Text = "Quantity";
            // 
            // labMachinDetail
            // 
            this.labMachinDetail.AutoSize = true;
            this.labMachinDetail.BackColor = System.Drawing.Color.Transparent;
            this.labMachinDetail.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMachinDetail.ForeColor = System.Drawing.Color.SeaShell;
            this.labMachinDetail.Location = new System.Drawing.Point(271, 39);
            this.labMachinDetail.Name = "labMachinDetail";
            this.labMachinDetail.Size = new System.Drawing.Size(203, 24);
            this.labMachinDetail.TabIndex = 5;
            this.labMachinDetail.Text = "MACHINE DETAILS";
            // 
            // panel2MachinD
            // 
            this.panel2MachinD.BackColor = System.Drawing.Color.Transparent;
            this.panel2MachinD.Controls.Add(this.butnproDexit);
            this.panel2MachinD.Controls.Add(this.butnproDreset);
            this.panel2MachinD.Controls.Add(this.butnproDdelete);
            this.panel2MachinD.Controls.Add(this.butnproDupdate);
            this.panel2MachinD.Controls.Add(this.butnproDSave);
            this.panel2MachinD.Controls.Add(this.butnproDAdd);
            this.panel2MachinD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2MachinD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2MachinD.Location = new System.Drawing.Point(102, 366);
            this.panel2MachinD.Name = "panel2MachinD";
            this.panel2MachinD.Size = new System.Drawing.Size(575, 112);
            this.panel2MachinD.TabIndex = 7;
            // 
            // butnproDexit
            // 
            this.butnproDexit.BackColor = System.Drawing.Color.Black;
            this.butnproDexit.ForeColor = System.Drawing.Color.SeaShell;
            this.butnproDexit.Location = new System.Drawing.Point(312, 65);
            this.butnproDexit.Name = "butnproDexit";
            this.butnproDexit.Size = new System.Drawing.Size(75, 27);
            this.butnproDexit.TabIndex = 6;
            this.butnproDexit.Text = "EXIT";
            this.butnproDexit.UseVisualStyleBackColor = false;
            this.butnproDexit.Click += new System.EventHandler(this.butnproDexit_Click);
            // 
            // butnproDreset
            // 
            this.butnproDreset.BackColor = System.Drawing.Color.Black;
            this.butnproDreset.ForeColor = System.Drawing.Color.SeaShell;
            this.butnproDreset.Location = new System.Drawing.Point(173, 65);
            this.butnproDreset.Name = "butnproDreset";
            this.butnproDreset.Size = new System.Drawing.Size(75, 27);
            this.butnproDreset.TabIndex = 4;
            this.butnproDreset.Text = "RESET";
            this.butnproDreset.UseVisualStyleBackColor = false;
            this.butnproDreset.Click += new System.EventHandler(this.butnproDreset_Click);
            // 
            // butnproDdelete
            // 
            this.butnproDdelete.BackColor = System.Drawing.Color.Black;
            this.butnproDdelete.ForeColor = System.Drawing.Color.SeaShell;
            this.butnproDdelete.Location = new System.Drawing.Point(411, 13);
            this.butnproDdelete.Name = "butnproDdelete";
            this.butnproDdelete.Size = new System.Drawing.Size(75, 27);
            this.butnproDdelete.TabIndex = 3;
            this.butnproDdelete.Text = "DELETE";
            this.butnproDdelete.UseVisualStyleBackColor = false;
            this.butnproDdelete.Click += new System.EventHandler(this.butnproDdelete_Click);
            // 
            // butnproDupdate
            // 
            this.butnproDupdate.BackColor = System.Drawing.Color.Black;
            this.butnproDupdate.ForeColor = System.Drawing.Color.SeaShell;
            this.butnproDupdate.Location = new System.Drawing.Point(283, 13);
            this.butnproDupdate.Name = "butnproDupdate";
            this.butnproDupdate.Size = new System.Drawing.Size(89, 27);
            this.butnproDupdate.TabIndex = 2;
            this.butnproDupdate.Text = "UPDATE";
            this.butnproDupdate.UseVisualStyleBackColor = false;
            this.butnproDupdate.Click += new System.EventHandler(this.butnproDupdate_Click);
            // 
            // butnproDSave
            // 
            this.butnproDSave.BackColor = System.Drawing.Color.Black;
            this.butnproDSave.ForeColor = System.Drawing.Color.SeaShell;
            this.butnproDSave.Location = new System.Drawing.Point(139, 13);
            this.butnproDSave.Name = "butnproDSave";
            this.butnproDSave.Size = new System.Drawing.Size(100, 27);
            this.butnproDSave.TabIndex = 1;
            this.butnproDSave.Text = "SAVE";
            this.butnproDSave.UseVisualStyleBackColor = false;
            this.butnproDSave.Click += new System.EventHandler(this.butnproDSave_Click);
            // 
            // butnproDAdd
            // 
            this.butnproDAdd.BackColor = System.Drawing.Color.Black;
            this.butnproDAdd.ForeColor = System.Drawing.Color.SeaShell;
            this.butnproDAdd.Location = new System.Drawing.Point(22, 13);
            this.butnproDAdd.Name = "butnproDAdd";
            this.butnproDAdd.Size = new System.Drawing.Size(75, 27);
            this.butnproDAdd.TabIndex = 0;
            this.butnproDAdd.Text = "ADD";
            this.butnproDAdd.UseVisualStyleBackColor = false;
            this.butnproDAdd.Click += new System.EventHandler(this.butnproDAdd_Click);
            // 
            // txtmname
            // 
            this.txtmname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.Location = new System.Drawing.Point(293, 72);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(154, 33);
            this.txtmname.TabIndex = 26;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(293, 118);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(154, 33);
            this.txtqty.TabIndex = 27;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(293, 205);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(154, 33);
            this.txtprice.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 33);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // Machin_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 483);
            this.Controls.Add(this.panel2MachinD);
            this.Controls.Add(this.labMachinDetail);
            this.Controls.Add(this.panl1MachinD);
            this.Name = "Machin_Details";
            this.Text = "MACHINE_Details";
            this.Load += new System.EventHandler(this.Machin_Details_Load);
            this.panl1MachinD.ResumeLayout(false);
            this.panl1MachinD.PerformLayout();
            this.panel2MachinD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panl1MachinD;
        private System.Windows.Forms.ComboBox cmbMachinid;
        private System.Windows.Forms.Label labProname;
        private System.Windows.Forms.Label labmachinid;
        private System.Windows.Forms.Label labproQuantity;
        private System.Windows.Forms.Label labMachinDetail;
        private System.Windows.Forms.Label labproprice;
        private System.Windows.Forms.Label labpromfgdate;
        private System.Windows.Forms.Panel panel2MachinD;
        private System.Windows.Forms.Button butnproDexit;
        private System.Windows.Forms.Button butnproDreset;
        private System.Windows.Forms.Button butnproDdelete;
        private System.Windows.Forms.Button butnproDupdate;
        private System.Windows.Forms.Button butnproDSave;
        private System.Windows.Forms.Button butnproDAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtmname;
    }
}