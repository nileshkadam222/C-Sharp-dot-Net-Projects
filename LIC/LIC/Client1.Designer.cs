namespace LIC
{
    partial class Client1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client1));
            this.label1 = new System.Windows.Forms.Label();
            this.cdob = new System.Windows.Forms.DateTimePicker();
            this.caddresstxt = new System.Windows.Forms.RichTextBox();
            this.cgencmbx = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.coccptxt = new System.Windows.Forms.TextBox();
            this.cagetxt = new System.Windows.Forms.TextBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.cidtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ndob = new System.Windows.Forms.DateTimePicker();
            this.ngencmb = new System.Windows.Forms.ComboBox();
            this.nagetxt = new System.Windows.Forms.TextBox();
            this.nnametxt = new System.Windows.Forms.TextBox();
            this.relatntxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_income = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Personal Details";
            // 
            // cdob
            // 
            this.cdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdob.Location = new System.Drawing.Point(151, 307);
            this.cdob.Margin = new System.Windows.Forms.Padding(5);
            this.cdob.Name = "cdob";
            this.cdob.Size = new System.Drawing.Size(143, 29);
            this.cdob.TabIndex = 60;
            this.cdob.ValueChanged += new System.EventHandler(this.cdob_ValueChanged);
            // 
            // caddresstxt
            // 
            this.caddresstxt.Location = new System.Drawing.Point(148, 158);
            this.caddresstxt.Margin = new System.Windows.Forms.Padding(5);
            this.caddresstxt.Name = "caddresstxt";
            this.caddresstxt.Size = new System.Drawing.Size(396, 99);
            this.caddresstxt.TabIndex = 59;
            this.caddresstxt.Text = "";
            this.caddresstxt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cgencmbx
            // 
            this.cgencmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cgencmbx.FormattingEnabled = true;
            this.cgencmbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cgencmbx.Location = new System.Drawing.Point(173, 264);
            this.cgencmbx.Margin = new System.Windows.Forms.Padding(5);
            this.cgencmbx.Name = "cgencmbx";
            this.cgencmbx.Size = new System.Drawing.Size(111, 29);
            this.cgencmbx.TabIndex = 58;
            this.cgencmbx.SelectedIndexChanged += new System.EventHandler(this.cgencmbx_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(283, 798);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 29);
            this.textBox7.TabIndex = 57;
            // 
            // coccptxt
            // 
            this.coccptxt.Location = new System.Drawing.Point(162, 400);
            this.coccptxt.Margin = new System.Windows.Forms.Padding(5);
            this.coccptxt.Name = "coccptxt";
            this.coccptxt.Size = new System.Drawing.Size(246, 29);
            this.coccptxt.TabIndex = 56;
            this.coccptxt.TextChanged += new System.EventHandler(this.occp_TextChanged);
            this.coccptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coccptxt_KeyPress);
            // 
            // cagetxt
            // 
            this.cagetxt.Enabled = false;
            this.cagetxt.Location = new System.Drawing.Point(217, 358);
            this.cagetxt.Margin = new System.Windows.Forms.Padding(5);
            this.cagetxt.Name = "cagetxt";
            this.cagetxt.Size = new System.Drawing.Size(77, 29);
            this.cagetxt.TabIndex = 61;
            this.cagetxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseClick);
            this.cagetxt.TextChanged += new System.EventHandler(this.cagetxt_TextChanged);
            // 
            // cnametxt
            // 
            this.cnametxt.Location = new System.Drawing.Point(162, 119);
            this.cnametxt.Margin = new System.Windows.Forms.Padding(5);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(382, 29);
            this.cnametxt.TabIndex = 54;
            this.cnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnametxt_KeyPress);
            // 
            // cidtxt
            // 
            this.cidtxt.Location = new System.Drawing.Point(162, 77);
            this.cidtxt.Margin = new System.Windows.Forms.Padding(5);
            this.cidtxt.Name = "cidtxt";
            this.cidtxt.Size = new System.Drawing.Size(164, 29);
            this.cidtxt.TabIndex = 53;
            this.cidtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 814);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "Annual Income";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 406);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 51;
            this.label8.Text = "Occupation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 50;
            this.label7.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 49;
            this.label6.Text = "Age on next B\'day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Proposer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Cust-ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(671, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 23);
            this.label14.TabIndex = 71;
            this.label14.Text = "Nominee Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(599, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 21);
            this.label15.TabIndex = 70;
            this.label15.Text = "Relationship";
            // 
            // ndob
            // 
            this.ndob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndob.Location = new System.Drawing.Point(700, 216);
            this.ndob.Name = "ndob";
            this.ndob.Size = new System.Drawing.Size(121, 29);
            this.ndob.TabIndex = 69;
            this.ndob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ngencmb
            // 
            this.ngencmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ngencmb.FormattingEnabled = true;
            this.ngencmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ngencmb.Location = new System.Drawing.Point(700, 165);
            this.ngencmb.Name = "ngencmb";
            this.ngencmb.Size = new System.Drawing.Size(121, 29);
            this.ngencmb.TabIndex = 68;
            this.ngencmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nagetxt
            // 
            this.nagetxt.Enabled = false;
            this.nagetxt.Location = new System.Drawing.Point(849, 285);
            this.nagetxt.Name = "nagetxt";
            this.nagetxt.Size = new System.Drawing.Size(53, 29);
            this.nagetxt.TabIndex = 67;
            this.nagetxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox8_MouseClick);
            this.nagetxt.TextChanged += new System.EventHandler(this.nagetxt_TextChanged);
            // 
            // nnametxt
            // 
            this.nnametxt.Location = new System.Drawing.Point(736, 103);
            this.nnametxt.Name = "nnametxt";
            this.nnametxt.Size = new System.Drawing.Size(218, 29);
            this.nnametxt.TabIndex = 66;
            this.nnametxt.TextChanged += new System.EventHandler(this.nnametxt_TextChanged);
            this.nnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nnametxt_KeyPress);
            // 
            // relatntxt
            // 
            this.relatntxt.Location = new System.Drawing.Point(713, 359);
            this.relatntxt.Name = "relatntxt";
            this.relatntxt.Size = new System.Drawing.Size(153, 29);
            this.relatntxt.TabIndex = 65;
            this.relatntxt.TextChanged += new System.EventHandler(this.relatntxt_TextChanged);
            this.relatntxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.relatntxt_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(615, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 21);
            this.label13.TabIndex = 64;
            this.label13.Text = "DOB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(599, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 63;
            this.label12.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 21);
            this.label11.TabIndex = 62;
            this.label11.Text = "Nominee Age on next B\'day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nominee Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 72;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_income
            // 
            this.txt_income.Location = new System.Drawing.Point(205, 452);
            this.txt_income.Margin = new System.Windows.Forms.Padding(5);
            this.txt_income.Name = "txt_income";
            this.txt_income.Size = new System.Drawing.Size(142, 29);
            this.txt_income.TabIndex = 74;
            this.txt_income.TextChanged += new System.EventHandler(this.txt_income_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 455);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 21);
            this.label16.TabIndex = 73;
            this.label16.Text = "Annual Income";
            // 
            // Client1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 570);
            this.Controls.Add(this.txt_income);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ndob);
            this.Controls.Add(this.ngencmb);
            this.Controls.Add(this.nagetxt);
            this.Controls.Add(this.nnametxt);
            this.Controls.Add(this.relatntxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cdob);
            this.Controls.Add(this.caddresstxt);
            this.Controls.Add(this.cgencmbx);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.coccptxt);
            this.Controls.Add(this.cagetxt);
            this.Controls.Add(this.cnametxt);
            this.Controls.Add(this.cidtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Client1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client1";
            this.Load += new System.EventHandler(this.Client1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cdob;
        private System.Windows.Forms.RichTextBox caddresstxt;
        private System.Windows.Forms.ComboBox cgencmbx;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox coccptxt;
        private System.Windows.Forms.TextBox cagetxt;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker ndob;
        private System.Windows.Forms.ComboBox ngencmb;
        private System.Windows.Forms.TextBox nagetxt;
        private System.Windows.Forms.TextBox nnametxt;
        private System.Windows.Forms.TextBox relatntxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox cidtxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_income;
        private System.Windows.Forms.Label label16;

    }
}