namespace LIC
{
    partial class AcknowledgementSlip3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcknowledgementSlip3));
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_polno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sa = new System.Windows.Forms.TextBox();
            this.txt_paidprem = new System.Windows.Forms.TextBox();
            this.txt_install = new System.Windows.Forms.TextBox();
            this.txt_refamt = new System.Windows.Forms.TextBox();
            this.txt_disvalue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_totamt = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(447, 497);
            this.btn_print.Margin = new System.Windows.Forms.Padding(5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(132, 39);
            this.btn_print.TabIndex = 30;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(214, 497);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 39);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1208, 874);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 29);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // txt_polno
            // 
            this.txt_polno.Enabled = false;
            this.txt_polno.Location = new System.Drawing.Point(229, 143);
            this.txt_polno.Margin = new System.Windows.Forms.Padding(5);
            this.txt_polno.Name = "txt_polno";
            this.txt_polno.Size = new System.Drawing.Size(164, 29);
            this.txt_polno.TabIndex = 27;
            this.txt_polno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(930, 876);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Policy No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "This is to acknowledge the receipt of application\r\n                        for Cl" +
                "aim surrender.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Acknowledge Slip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sum Assured";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Paid Premium";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Installments Left";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(368, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "Surrender/Discounted Value(inclusive of Bonus)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Refunded Amount";
            // 
            // txt_sa
            // 
            this.txt_sa.Enabled = false;
            this.txt_sa.Location = new System.Drawing.Point(229, 187);
            this.txt_sa.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sa.Name = "txt_sa";
            this.txt_sa.Size = new System.Drawing.Size(164, 29);
            this.txt_sa.TabIndex = 36;
            // 
            // txt_paidprem
            // 
            this.txt_paidprem.Enabled = false;
            this.txt_paidprem.Location = new System.Drawing.Point(229, 228);
            this.txt_paidprem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_paidprem.Name = "txt_paidprem";
            this.txt_paidprem.Size = new System.Drawing.Size(164, 29);
            this.txt_paidprem.TabIndex = 37;
            // 
            // txt_install
            // 
            this.txt_install.Enabled = false;
            this.txt_install.Location = new System.Drawing.Point(229, 270);
            this.txt_install.Margin = new System.Windows.Forms.Padding(5);
            this.txt_install.Name = "txt_install";
            this.txt_install.Size = new System.Drawing.Size(164, 29);
            this.txt_install.TabIndex = 38;
            // 
            // txt_refamt
            // 
            this.txt_refamt.Enabled = false;
            this.txt_refamt.Location = new System.Drawing.Point(512, 321);
            this.txt_refamt.Margin = new System.Windows.Forms.Padding(5);
            this.txt_refamt.Name = "txt_refamt";
            this.txt_refamt.Size = new System.Drawing.Size(164, 29);
            this.txt_refamt.TabIndex = 39;
            this.txt_refamt.TextChanged += new System.EventHandler(this.txt_refamt_TextChanged);
            // 
            // txt_disvalue
            // 
            this.txt_disvalue.Enabled = false;
            this.txt_disvalue.Location = new System.Drawing.Point(512, 372);
            this.txt_disvalue.Margin = new System.Windows.Forms.Padding(5);
            this.txt_disvalue.Name = "txt_disvalue";
            this.txt_disvalue.Size = new System.Drawing.Size(164, 29);
            this.txt_disvalue.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 419);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 41;
            this.label10.Text = "Total Amount";
            // 
            // txt_totamt
            // 
            this.txt_totamt.Enabled = false;
            this.txt_totamt.Location = new System.Drawing.Point(512, 411);
            this.txt_totamt.Margin = new System.Windows.Forms.Padding(5);
            this.txt_totamt.Name = "txt_totamt";
            this.txt_totamt.Size = new System.Drawing.Size(164, 29);
            this.txt_totamt.TabIndex = 42;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(271, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 43;
            // 
            // AcknowledgementSlip3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 568);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_totamt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_disvalue);
            this.Controls.Add(this.txt_refamt);
            this.Controls.Add(this.txt_install);
            this.Controls.Add(this.txt_paidprem);
            this.Controls.Add(this.txt_sa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_polno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AcknowledgementSlip3";
            this.Text = "AcknowledgementSlip3";
            this.Load += new System.EventHandler(this.AcknowledgementSlip2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sa;
        private System.Windows.Forms.TextBox txt_paidprem;
        private System.Windows.Forms.TextBox txt_install;
        private System.Windows.Forms.TextBox txt_refamt;
        private System.Windows.Forms.TextBox txt_disvalue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_totamt;
        public System.Windows.Forms.TextBox txt_polno;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label11;
    }
}