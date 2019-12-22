namespace LIC
{
    partial class Client2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client2));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtofmaturity = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.cbo_mode = new System.Windows.Forms.ComboBox();
            this.dtofcomm = new System.Windows.Forms.DateTimePicker();
            this.cbo_polno = new System.Windows.Forms.ComboBox();
            this.polnotxt = new System.Windows.Forms.TextBox();
            this.premiumtxt = new System.Windows.Forms.TextBox();
            this.sumtxt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_termpay = new System.Windows.Forms.ComboBox();
            this.termtxt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totinstal = new System.Windows.Forms.TextBox();
            this.dtp_riskdt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(275, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 36);
            this.button3.TabIndex = 86;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(101, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 85;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtofmaturity
            // 
            this.dtofmaturity.Enabled = false;
            this.dtofmaturity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtofmaturity.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtofmaturity.Location = new System.Drawing.Point(310, 470);
            this.dtofmaturity.Name = "dtofmaturity";
            this.dtofmaturity.Size = new System.Drawing.Size(121, 29);
            this.dtofmaturity.TabIndex = 84;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(42, 481);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(132, 21);
            this.label24.TabIndex = 83;
            this.label24.Text = "Date of Maturity";
            // 
            // cbo_mode
            // 
            this.cbo_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_mode.FormattingEnabled = true;
            this.cbo_mode.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Salary Deduction"});
            this.cbo_mode.Location = new System.Drawing.Point(309, 334);
            this.cbo_mode.Name = "cbo_mode";
            this.cbo_mode.Size = new System.Drawing.Size(121, 29);
            this.cbo_mode.TabIndex = 82;
            this.cbo_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // dtofcomm
            // 
            this.dtofcomm.Enabled = false;
            this.dtofcomm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtofcomm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtofcomm.Location = new System.Drawing.Point(309, 152);
            this.dtofcomm.Name = "dtofcomm";
            this.dtofcomm.Size = new System.Drawing.Size(121, 29);
            this.dtofcomm.TabIndex = 80;
            this.dtofcomm.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // cbo_polno
            // 
            this.cbo_polno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_polno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_polno.FormattingEnabled = true;
            this.cbo_polno.Items.AddRange(new object[] {
            "Jeevan Anand[149]",
            "Jeevan Saral[165]"});
            this.cbo_polno.Location = new System.Drawing.Point(282, 106);
            this.cbo_polno.Name = "cbo_polno";
            this.cbo_polno.Size = new System.Drawing.Size(149, 29);
            this.cbo_polno.TabIndex = 79;
            this.cbo_polno.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // polnotxt
            // 
            this.polnotxt.Enabled = false;
            this.polnotxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polnotxt.Location = new System.Drawing.Point(281, 71);
            this.polnotxt.Name = "polnotxt";
            this.polnotxt.Size = new System.Drawing.Size(151, 29);
            this.polnotxt.TabIndex = 78;
            // 
            // premiumtxt
            // 
            this.premiumtxt.Enabled = false;
            this.premiumtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiumtxt.Location = new System.Drawing.Point(282, 295);
            this.premiumtxt.Name = "premiumtxt";
            this.premiumtxt.Size = new System.Drawing.Size(148, 29);
            this.premiumtxt.TabIndex = 77;
            this.premiumtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox10_MouseClick);
            this.premiumtxt.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // sumtxt
            // 
            this.sumtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumtxt.Location = new System.Drawing.Point(282, 226);
            this.sumtxt.Name = "sumtxt";
            this.sumtxt.Size = new System.Drawing.Size(148, 29);
            this.sumtxt.TabIndex = 76;
            this.sumtxt.TextChanged += new System.EventHandler(this.sumtxt_TextChanged);
            this.sumtxt.Validating += new System.ComponentModel.CancelEventHandler(this.textBox9_Validating);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(42, 335);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 21);
            this.label23.TabIndex = 75;
            this.label23.Text = "Mode of Payment";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(42, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 21);
            this.label22.TabIndex = 74;
            this.label22.Text = "Premium";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(42, 240);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 21);
            this.label21.TabIndex = 73;
            this.label21.Text = "Sum Assured";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(39, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 21);
            this.label20.TabIndex = 72;
            this.label20.Text = "Term";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(39, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 21);
            this.label19.TabIndex = 71;
            this.label19.Text = "Date of Commence";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(39, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 21);
            this.label18.TabIndex = 70;
            this.label18.Text = "Policy/Plan Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 21);
            this.label17.TabIndex = 69;
            this.label17.Text = "Policy No.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(156, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 24);
            this.label16.TabIndex = 68;
            this.label16.Text = "Policy Details";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 87;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 88;
            this.label1.Text = "Cust_id";
            // 
            // cidtxt
            // 
            this.cidtxt.Enabled = false;
            this.cidtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidtxt.Location = new System.Drawing.Point(282, 36);
            this.cidtxt.Name = "cidtxt";
            this.cidtxt.Size = new System.Drawing.Size(151, 29);
            this.cidtxt.TabIndex = 89;
            this.cidtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 90;
            this.label2.Text = "Term-Wise Payment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbo_termpay
            // 
            this.cbo_termpay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_termpay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_termpay.FormattingEnabled = true;
            this.cbo_termpay.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly",
            "Yearly"});
            this.cbo_termpay.Location = new System.Drawing.Point(292, 261);
            this.cbo_termpay.Name = "cbo_termpay";
            this.cbo_termpay.Size = new System.Drawing.Size(138, 29);
            this.cbo_termpay.TabIndex = 91;
            this.cbo_termpay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // termtxt
            // 
            this.termtxt.Enabled = false;
            this.termtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termtxt.Location = new System.Drawing.Point(283, 187);
            this.termtxt.Name = "termtxt";
            this.termtxt.Size = new System.Drawing.Size(148, 29);
            this.termtxt.TabIndex = 92;
            this.termtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 93;
            this.label3.Text = "Total Installment";
            // 
            // txt_totinstal
            // 
            this.txt_totinstal.Enabled = false;
            this.txt_totinstal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totinstal.Location = new System.Drawing.Point(309, 379);
            this.txt_totinstal.Name = "txt_totinstal";
            this.txt_totinstal.Size = new System.Drawing.Size(121, 29);
            this.txt_totinstal.TabIndex = 94;
            // 
            // dtp_riskdt
            // 
            this.dtp_riskdt.Enabled = false;
            this.dtp_riskdt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_riskdt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_riskdt.Location = new System.Drawing.Point(308, 422);
            this.dtp_riskdt.Name = "dtp_riskdt";
            this.dtp_riskdt.Size = new System.Drawing.Size(121, 29);
            this.dtp_riskdt.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 95;
            this.label4.Text = "Risk Date";
            // 
            // Client2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 587);
            this.Controls.Add(this.dtp_riskdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_totinstal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.termtxt);
            this.Controls.Add(this.cbo_termpay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cidtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtofmaturity);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbo_mode);
            this.Controls.Add(this.dtofcomm);
            this.Controls.Add(this.cbo_polno);
            this.Controls.Add(this.polnotxt);
            this.Controls.Add(this.premiumtxt);
            this.Controls.Add(this.sumtxt);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Name = "Client2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client2";
            this.Load += new System.EventHandler(this.Client2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtofmaturity;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbo_mode;
        private System.Windows.Forms.DateTimePicker dtofcomm;
        private System.Windows.Forms.TextBox premiumtxt;
        private System.Windows.Forms.TextBox sumtxt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_termpay;
        private System.Windows.Forms.TextBox termtxt;
        public System.Windows.Forms.TextBox cidtxt;
        public System.Windows.Forms.TextBox polnotxt;
        public System.Windows.Forms.ComboBox cbo_polno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_totinstal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_riskdt;
        private System.Windows.Forms.Label label4;

    }
}