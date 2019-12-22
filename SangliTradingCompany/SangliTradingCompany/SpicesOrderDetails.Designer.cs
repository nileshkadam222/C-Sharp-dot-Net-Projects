﻿namespace SangliTradingCompany
{
    partial class SpicesOrderDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.total_amount = new System.Windows.Forms.Button();
            this.proname_combo = new System.Windows.Forms.ComboBox();
            this.proid_combo = new System.Windows.Forms.ComboBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.boxes_txt = new System.Windows.Forms.TextBox();
            this.weight_txt = new System.Windows.Forms.TextBox();
            this.unitprice_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.suppname_combo = new System.Windows.Forms.ComboBox();
            this.suppid_combo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.total_txt);
            this.groupBox1.Controls.Add(this.total_amount);
            this.groupBox1.Controls.Add(this.proname_combo);
            this.groupBox1.Controls.Add(this.proid_combo);
            this.groupBox1.Controls.Add(this.quantity_txt);
            this.groupBox1.Controls.Add(this.boxes_txt);
            this.groupBox1.Controls.Add(this.weight_txt);
            this.groupBox1.Controls.Add(this.unitprice_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(423, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 286);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(204, 255);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(100, 20);
            this.total_txt.TabIndex = 12;
            this.total_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // total_amount
            // 
            this.total_amount.Location = new System.Drawing.Point(27, 253);
            this.total_amount.Name = "total_amount";
            this.total_amount.Size = new System.Drawing.Size(95, 23);
            this.total_amount.TabIndex = 9;
            this.total_amount.Text = "Total Amount";
            this.total_amount.UseVisualStyleBackColor = true;
            this.total_amount.Click += new System.EventHandler(this.total_amount_Click);
            // 
            // proname_combo
            // 
            this.proname_combo.FormattingEnabled = true;
            this.proname_combo.Location = new System.Drawing.Point(204, 62);
            this.proname_combo.Name = "proname_combo";
            this.proname_combo.Size = new System.Drawing.Size(121, 21);
            this.proname_combo.TabIndex = 18;
            // 
            // proid_combo
            // 
            this.proid_combo.FormattingEnabled = true;
            this.proid_combo.Location = new System.Drawing.Point(204, 28);
            this.proid_combo.Name = "proid_combo";
            this.proid_combo.Size = new System.Drawing.Size(121, 21);
            this.proid_combo.TabIndex = 17;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(204, 99);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(100, 20);
            this.quantity_txt.TabIndex = 16;
            this.quantity_txt.TextChanged += new System.EventHandler(this.validTextInteger);
            // 
            // boxes_txt
            // 
            this.boxes_txt.Location = new System.Drawing.Point(204, 139);
            this.boxes_txt.Name = "boxes_txt";
            this.boxes_txt.Size = new System.Drawing.Size(100, 20);
            this.boxes_txt.TabIndex = 15;
            this.boxes_txt.TextChanged += new System.EventHandler(this.validTextInteger);
            // 
            // weight_txt
            // 
            this.weight_txt.Location = new System.Drawing.Point(204, 177);
            this.weight_txt.Name = "weight_txt";
            this.weight_txt.Size = new System.Drawing.Size(100, 20);
            this.weight_txt.TabIndex = 14;
            this.weight_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // unitprice_txt
            // 
            this.unitprice_txt.Location = new System.Drawing.Point(204, 214);
            this.unitprice_txt.Name = "unitprice_txt";
            this.unitprice_txt.Size = new System.Drawing.Size(100, 20);
            this.unitprice_txt.TabIndex = 13;
            this.unitprice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unit Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Boxes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quntity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID:";
            // 
            // suppname_combo
            // 
            this.suppname_combo.FormattingEnabled = true;
            this.suppname_combo.Location = new System.Drawing.Point(154, 68);
            this.suppname_combo.Name = "suppname_combo";
            this.suppname_combo.Size = new System.Drawing.Size(121, 21);
            this.suppname_combo.TabIndex = 20;
            // 
            // suppid_combo
            // 
            this.suppid_combo.FormattingEnabled = true;
            this.suppid_combo.Location = new System.Drawing.Point(154, 19);
            this.suppid_combo.Name = "suppid_combo";
            this.suppid_combo.Size = new System.Drawing.Size(121, 21);
            this.suppid_combo.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Supplier Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Supplier ID:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(476, 19);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancel_btn);
            this.groupBox2.Controls.Add(this.save_btn);
            this.groupBox2.Location = new System.Drawing.Point(316, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(134, 19);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.suppname_combo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.suppid_combo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(423, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 158);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // SpicesOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1333, 638);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SpicesOrderDetails";
            this.Text = "SpicesOrderDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SpicesOrderDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox suppname_combo;
        private System.Windows.Forms.ComboBox suppid_combo;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Button total_amount;
        private System.Windows.Forms.ComboBox proname_combo;
        private System.Windows.Forms.ComboBox proid_combo;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.TextBox boxes_txt;
        private System.Windows.Forms.TextBox weight_txt;
        private System.Windows.Forms.TextBox unitprice_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}