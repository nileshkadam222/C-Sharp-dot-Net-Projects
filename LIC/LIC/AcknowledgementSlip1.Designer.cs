namespace LIC
{
    partial class AcknowledgementSlip1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcknowledgementSlip1));
            this.btn_Save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_polno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_bonus = new System.Windows.Forms.TextBox();
            this.txt_refamt = new System.Windows.Forms.TextBox();
            this.txt_totprem = new System.Windows.Forms.TextBox();
            this.txt_sa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totamt = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(415, 572);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 33);
            this.btn_Save.TabIndex = 21;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 501);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 29);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // txt_polno
            // 
            this.txt_polno.Enabled = false;
            this.txt_polno.Location = new System.Drawing.Point(243, 217);
            this.txt_polno.Name = "txt_polno";
            this.txt_polno.Size = new System.Drawing.Size(149, 29);
            this.txt_polno.TabIndex = 19;
            this.txt_polno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Policy No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "This is to acknowledge the receipt of application for maturity.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Acknowledge Slip";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 455);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 55;
            this.label10.Text = "Total Amount";
            // 
            // txt_bonus
            // 
            this.txt_bonus.Enabled = false;
            this.txt_bonus.Location = new System.Drawing.Point(459, 394);
            this.txt_bonus.Margin = new System.Windows.Forms.Padding(5);
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(164, 29);
            this.txt_bonus.TabIndex = 54;
            this.txt_bonus.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_refamt
            // 
            this.txt_refamt.Enabled = false;
            this.txt_refamt.Location = new System.Drawing.Point(459, 341);
            this.txt_refamt.Margin = new System.Windows.Forms.Padding(5);
            this.txt_refamt.Name = "txt_refamt";
            this.txt_refamt.Size = new System.Drawing.Size(164, 29);
            this.txt_refamt.TabIndex = 53;
            this.txt_refamt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_totprem
            // 
            this.txt_totprem.Enabled = false;
            this.txt_totprem.Location = new System.Drawing.Point(243, 301);
            this.txt_totprem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_totprem.Name = "txt_totprem";
            this.txt_totprem.Size = new System.Drawing.Size(164, 29);
            this.txt_totprem.TabIndex = 51;
            // 
            // txt_sa
            // 
            this.txt_sa.Enabled = false;
            this.txt_sa.Location = new System.Drawing.Point(243, 260);
            this.txt_sa.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sa.Name = "txt_sa";
            this.txt_sa.Size = new System.Drawing.Size(164, 29);
            this.txt_sa.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 349);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 21);
            this.label9.TabIndex = 49;
            this.label9.Text = "Refunded Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 48;
            this.label8.Text = "Vested Bonus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Total Premium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Sum Assured";
            // 
            // txt_totamt
            // 
            this.txt_totamt.AcceptsReturn = true;
            this.txt_totamt.AcceptsTab = true;
            this.txt_totamt.Enabled = false;
            this.txt_totamt.Location = new System.Drawing.Point(459, 452);
            this.txt_totamt.Margin = new System.Windows.Forms.Padding(5);
            this.txt_totamt.Name = "txt_totamt";
            this.txt_totamt.Size = new System.Drawing.Size(164, 29);
            this.txt_totamt.TabIndex = 56;
            this.txt_totamt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox7_MouseClick);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(528, 572);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(95, 33);
            this.btn_print.TabIndex = 57;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 58;
            // 
            // AcknowledgementSlip1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 639);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txt_totamt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_bonus);
            this.Controls.Add(this.txt_refamt);
            this.Controls.Add(this.txt_totprem);
            this.Controls.Add(this.txt_sa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_polno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AcknowledgementSlip1";
            this.Text = "AcknowledgementSlip1";
            this.Load += new System.EventHandler(this.AcknowledgementSlip1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_bonus;
        private System.Windows.Forms.TextBox txt_refamt;
        private System.Windows.Forms.TextBox txt_totprem;
        private System.Windows.Forms.TextBox txt_sa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totamt;
        public System.Windows.Forms.TextBox txt_polno;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label7;
    }
}