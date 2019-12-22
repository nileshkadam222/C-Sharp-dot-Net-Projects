namespace SangliTradingCompany
{
    partial class EmployeeSalary
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
            this.group_combo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.reg_combo = new System.Windows.Forms.ComboBox();
            this.desig_combo = new System.Windows.Forms.ComboBox();
            this.Last_combo = new System.Windows.Forms.ComboBox();
            this.Firstname_combo = new System.Windows.Forms.ComboBox();
            this.empID_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalsal_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.preday_txt = new System.Windows.Forms.TextBox();
            this.Tworkday_txt = new System.Windows.Forms.TextBox();
            this.oneday_txt = new System.Windows.Forms.TextBox();
            this.Totalsal_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.paygiven_txt = new System.Windows.Forms.TextBox();
            this.cheqno_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cheqradio_btn = new System.Windows.Forms.RadioButton();
            this.Cashradio_btn = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.group_combo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.reg_combo);
            this.groupBox1.Controls.Add(this.desig_combo);
            this.groupBox1.Controls.Add(this.Last_combo);
            this.groupBox1.Controls.Add(this.Firstname_combo);
            this.groupBox1.Controls.Add(this.empID_combo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Detail";
            // 
            // group_combo
            // 
            this.group_combo.FormattingEnabled = true;
            this.group_combo.Location = new System.Drawing.Point(205, 241);
            this.group_combo.Name = "group_combo";
            this.group_combo.Size = new System.Drawing.Size(121, 24);
            this.group_combo.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Group Number";
            // 
            // reg_combo
            // 
            this.reg_combo.FormattingEnabled = true;
            this.reg_combo.Location = new System.Drawing.Point(205, 201);
            this.reg_combo.Name = "reg_combo";
            this.reg_combo.Size = new System.Drawing.Size(121, 24);
            this.reg_combo.TabIndex = 9;
            // 
            // desig_combo
            // 
            this.desig_combo.FormattingEnabled = true;
            this.desig_combo.Items.AddRange(new object[] {
            "Manager",
            "Accountant",
            "Worker"});
            this.desig_combo.Location = new System.Drawing.Point(205, 161);
            this.desig_combo.Name = "desig_combo";
            this.desig_combo.Size = new System.Drawing.Size(121, 24);
            this.desig_combo.TabIndex = 8;
            this.desig_combo.SelectedIndexChanged += new System.EventHandler(this.desig_combo_SelectedIndexChanged);
            // 
            // Last_combo
            // 
            this.Last_combo.FormattingEnabled = true;
            this.Last_combo.Location = new System.Drawing.Point(205, 120);
            this.Last_combo.Name = "Last_combo";
            this.Last_combo.Size = new System.Drawing.Size(121, 24);
            this.Last_combo.TabIndex = 7;
            // 
            // Firstname_combo
            // 
            this.Firstname_combo.FormattingEnabled = true;
            this.Firstname_combo.Location = new System.Drawing.Point(205, 81);
            this.Firstname_combo.Name = "Firstname_combo";
            this.Firstname_combo.Size = new System.Drawing.Size(121, 24);
            this.Firstname_combo.TabIndex = 6;
            // 
            // empID_combo
            // 
            this.empID_combo.FormattingEnabled = true;
            this.empID_combo.Location = new System.Drawing.Point(205, 31);
            this.empID_combo.Name = "empID_combo";
            this.empID_combo.Size = new System.Drawing.Size(121, 24);
            this.empID_combo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registration Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(540, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Consideration According To Designation";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.totalsal_txt);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(22, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 77);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Salary";
            // 
            // totalsal_txt
            // 
            this.totalsal_txt.Location = new System.Drawing.Point(126, 34);
            this.totalsal_txt.Name = "totalsal_txt";
            this.totalsal_txt.Size = new System.Drawing.Size(100, 23);
            this.totalsal_txt.TabIndex = 1;
            this.totalsal_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Salary";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.preday_txt);
            this.groupBox3.Controls.Add(this.Tworkday_txt);
            this.groupBox3.Controls.Add(this.oneday_txt);
            this.groupBox3.Controls.Add(this.Totalsal_btn);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(22, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 216);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // preday_txt
            // 
            this.preday_txt.Location = new System.Drawing.Point(154, 117);
            this.preday_txt.Name = "preday_txt";
            this.preday_txt.Size = new System.Drawing.Size(100, 23);
            this.preday_txt.TabIndex = 6;
            this.preday_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serno_txt_KeyPress);
            // 
            // Tworkday_txt
            // 
            this.Tworkday_txt.Location = new System.Drawing.Point(154, 69);
            this.Tworkday_txt.Name = "Tworkday_txt";
            this.Tworkday_txt.Size = new System.Drawing.Size(100, 23);
            this.Tworkday_txt.TabIndex = 5;
            this.Tworkday_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serno_txt_KeyPress);
            // 
            // oneday_txt
            // 
            this.oneday_txt.Location = new System.Drawing.Point(154, 27);
            this.oneday_txt.Name = "oneday_txt";
            this.oneday_txt.Size = new System.Drawing.Size(100, 23);
            this.oneday_txt.TabIndex = 4;
            this.oneday_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // Totalsal_btn
            // 
            this.Totalsal_btn.Location = new System.Drawing.Point(78, 176);
            this.Totalsal_btn.Name = "Totalsal_btn";
            this.Totalsal_btn.Size = new System.Drawing.Size(114, 23);
            this.Totalsal_btn.TabIndex = 3;
            this.Totalsal_btn.Text = "Calculate Salary";
            this.Totalsal_btn.UseVisualStyleBackColor = true;
            this.Totalsal_btn.Click += new System.EventHandler(this.Totalsal_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Present Day:-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Work Day:-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "One Day Salary:-";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.paygiven_txt);
            this.groupBox5.Controls.Add(this.cheqno_txt);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.cheqradio_btn);
            this.groupBox5.Controls.Add(this.Cashradio_btn);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(937, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 277);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment Details";
            // 
            // paygiven_txt
            // 
            this.paygiven_txt.Location = new System.Drawing.Point(143, 169);
            this.paygiven_txt.Name = "paygiven_txt";
            this.paygiven_txt.Size = new System.Drawing.Size(200, 23);
            this.paygiven_txt.TabIndex = 8;
            this.paygiven_txt.TextChanged += new System.EventHandler(this.validTextChar);
            // 
            // cheqno_txt
            // 
            this.cheqno_txt.Location = new System.Drawing.Point(214, 121);
            this.cheqno_txt.Name = "cheqno_txt";
            this.cheqno_txt.Size = new System.Drawing.Size(100, 23);
            this.cheqno_txt.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Payment Given By:-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cheque no.:-";
            // 
            // cheqradio_btn
            // 
            this.cheqradio_btn.AutoSize = true;
            this.cheqradio_btn.Location = new System.Drawing.Point(143, 79);
            this.cheqradio_btn.Name = "cheqradio_btn";
            this.cheqradio_btn.Size = new System.Drawing.Size(75, 21);
            this.cheqradio_btn.TabIndex = 3;
            this.cheqradio_btn.TabStop = true;
            this.cheqradio_btn.Text = "Cheque";
            this.cheqradio_btn.UseVisualStyleBackColor = true;
            this.cheqradio_btn.CheckedChanged += new System.EventHandler(this.cheqradio_btn_CheckedChanged);
            // 
            // Cashradio_btn
            // 
            this.Cashradio_btn.AutoSize = true;
            this.Cashradio_btn.Location = new System.Drawing.Point(275, 81);
            this.Cashradio_btn.Name = "Cashradio_btn";
            this.Cashradio_btn.Size = new System.Drawing.Size(58, 21);
            this.Cashradio_btn.TabIndex = 2;
            this.Cashradio_btn.TabStop = true;
            this.Cashradio_btn.Text = "Cash";
            this.Cashradio_btn.UseVisualStyleBackColor = true;
            this.Cashradio_btn.CheckedChanged += new System.EventHandler(this.Cashradio_btn_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Payment Done By:-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date:-";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.Cancel_btn);
            this.groupBox6.Controls.Add(this.Save_btn);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(469, 438);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(494, 80);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(355, 32);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(204, 32);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1332, 640);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeSalary";
            this.Text = "EmployeeSalary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeSalary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox group_combo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox reg_combo;
        private System.Windows.Forms.ComboBox desig_combo;
        private System.Windows.Forms.ComboBox Last_combo;
        private System.Windows.Forms.ComboBox Firstname_combo;
        private System.Windows.Forms.ComboBox empID_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox totalsal_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox preday_txt;
        private System.Windows.Forms.TextBox Tworkday_txt;
        private System.Windows.Forms.TextBox oneday_txt;
        private System.Windows.Forms.Button Totalsal_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox paygiven_txt;
        private System.Windows.Forms.TextBox cheqno_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton cheqradio_btn;
        private System.Windows.Forms.RadioButton Cashradio_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;
    }
}