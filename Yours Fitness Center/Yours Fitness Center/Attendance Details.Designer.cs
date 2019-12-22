namespace Yours_Fitness_Center
{
    partial class Attendance_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance_Details));
            this.panel3AttenD = new System.Windows.Forms.Panel();
            this.txtsid = new System.Windows.Forms.DataGridView();
            this.panel2AttenD = new System.Windows.Forms.Panel();
            this.butnattenDcancel = new System.Windows.Forms.Button();
            this.butnattenDadd = new System.Windows.Forms.Button();
            this.butnattenDLast = new System.Windows.Forms.Button();
            this.butnattenDnext = new System.Windows.Forms.Button();
            this.butnattenDprev = new System.Windows.Forms.Button();
            this.butnattenDfirst = new System.Windows.Forms.Button();
            this.labAttendanceDetail = new System.Windows.Forms.Label();
            this.panl1AttenD = new System.Windows.Forms.Panel();
            this.txtaatt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtatt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBattenstudTotalDays = new System.Windows.Forms.TextBox();
            this.labattenStudstudId = new System.Windows.Forms.Label();
            this.panel3AttenD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsid)).BeginInit();
            this.panel2AttenD.SuspendLayout();
            this.panl1AttenD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3AttenD
            // 
            this.panel3AttenD.BackColor = System.Drawing.Color.Transparent;
            this.panel3AttenD.Controls.Add(this.txtsid);
            this.panel3AttenD.Location = new System.Drawing.Point(72, 71);
            this.panel3AttenD.Name = "panel3AttenD";
            this.panel3AttenD.Size = new System.Drawing.Size(681, 197);
            this.panel3AttenD.TabIndex = 20;
            this.panel3AttenD.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtsid
            // 
            this.txtsid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtsid.Location = new System.Drawing.Point(0, 0);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(678, 194);
            this.txtsid.TabIndex = 0;
            // 
            // panel2AttenD
            // 
            this.panel2AttenD.BackColor = System.Drawing.Color.Transparent;
            this.panel2AttenD.Controls.Add(this.butnattenDcancel);
            this.panel2AttenD.Controls.Add(this.butnattenDadd);
            this.panel2AttenD.Controls.Add(this.butnattenDLast);
            this.panel2AttenD.Controls.Add(this.butnattenDnext);
            this.panel2AttenD.Controls.Add(this.butnattenDprev);
            this.panel2AttenD.Controls.Add(this.butnattenDfirst);
            this.panel2AttenD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2AttenD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2AttenD.Location = new System.Drawing.Point(72, 468);
            this.panel2AttenD.Name = "panel2AttenD";
            this.panel2AttenD.Size = new System.Drawing.Size(681, 102);
            this.panel2AttenD.TabIndex = 19;
            // 
            // butnattenDcancel
            // 
            this.butnattenDcancel.ForeColor = System.Drawing.Color.Black;
            this.butnattenDcancel.Location = new System.Drawing.Point(134, 61);
            this.butnattenDcancel.Name = "butnattenDcancel";
            this.butnattenDcancel.Size = new System.Drawing.Size(100, 27);
            this.butnattenDcancel.TabIndex = 11;
            this.butnattenDcancel.Text = "CANCEL";
            this.butnattenDcancel.UseVisualStyleBackColor = true;
            this.butnattenDcancel.Click += new System.EventHandler(this.butnattenDcancel_Click);
            // 
            // butnattenDadd
            // 
            this.butnattenDadd.ForeColor = System.Drawing.Color.Black;
            this.butnattenDadd.Location = new System.Drawing.Point(35, 61);
            this.butnattenDadd.Name = "butnattenDadd";
            this.butnattenDadd.Size = new System.Drawing.Size(75, 27);
            this.butnattenDadd.TabIndex = 8;
            this.butnattenDadd.Text = "Save";
            this.butnattenDadd.UseVisualStyleBackColor = true;
            this.butnattenDadd.Click += new System.EventHandler(this.butnattenDadd_Click);
            // 
            // butnattenDLast
            // 
            this.butnattenDLast.ForeColor = System.Drawing.Color.Black;
            this.butnattenDLast.Location = new System.Drawing.Point(359, 13);
            this.butnattenDLast.Name = "butnattenDLast";
            this.butnattenDLast.Size = new System.Drawing.Size(75, 27);
            this.butnattenDLast.TabIndex = 3;
            this.butnattenDLast.Text = "LAST";
            this.butnattenDLast.UseVisualStyleBackColor = true;
            this.butnattenDLast.Click += new System.EventHandler(this.butnattenDLast_Click);
            // 
            // butnattenDnext
            // 
            this.butnattenDnext.ForeColor = System.Drawing.Color.Black;
            this.butnattenDnext.Location = new System.Drawing.Point(260, 13);
            this.butnattenDnext.Name = "butnattenDnext";
            this.butnattenDnext.Size = new System.Drawing.Size(75, 27);
            this.butnattenDnext.TabIndex = 2;
            this.butnattenDnext.Text = "NEXT";
            this.butnattenDnext.UseVisualStyleBackColor = true;
            this.butnattenDnext.Click += new System.EventHandler(this.butnattenDnext_Click);
            // 
            // butnattenDprev
            // 
            this.butnattenDprev.ForeColor = System.Drawing.Color.Black;
            this.butnattenDprev.Location = new System.Drawing.Point(134, 13);
            this.butnattenDprev.Name = "butnattenDprev";
            this.butnattenDprev.Size = new System.Drawing.Size(100, 27);
            this.butnattenDprev.TabIndex = 1;
            this.butnattenDprev.Text = "PREVIOUS";
            this.butnattenDprev.UseVisualStyleBackColor = true;
            this.butnattenDprev.Click += new System.EventHandler(this.butnattenDprev_Click);
            // 
            // butnattenDfirst
            // 
            this.butnattenDfirst.ForeColor = System.Drawing.Color.Black;
            this.butnattenDfirst.Location = new System.Drawing.Point(35, 13);
            this.butnattenDfirst.Name = "butnattenDfirst";
            this.butnattenDfirst.Size = new System.Drawing.Size(75, 27);
            this.butnattenDfirst.TabIndex = 0;
            this.butnattenDfirst.Text = "FIRST";
            this.butnattenDfirst.UseVisualStyleBackColor = true;
            this.butnattenDfirst.Click += new System.EventHandler(this.butnattenDfirst_Click);
            // 
            // labAttendanceDetail
            // 
            this.labAttendanceDetail.AutoSize = true;
            this.labAttendanceDetail.BackColor = System.Drawing.Color.Transparent;
            this.labAttendanceDetail.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAttendanceDetail.ForeColor = System.Drawing.Color.Black;
            this.labAttendanceDetail.Location = new System.Drawing.Point(298, 9);
            this.labAttendanceDetail.Name = "labAttendanceDetail";
            this.labAttendanceDetail.Size = new System.Drawing.Size(243, 24);
            this.labAttendanceDetail.TabIndex = 18;
            this.labAttendanceDetail.Text = "ATTENDANCE DETAILS";
            // 
            // panl1AttenD
            // 
            this.panl1AttenD.BackColor = System.Drawing.Color.Transparent;
            this.panl1AttenD.Controls.Add(this.txtaatt);
            this.panl1AttenD.Controls.Add(this.label3);
            this.panl1AttenD.Controls.Add(this.txtatt);
            this.panl1AttenD.Controls.Add(this.label2);
            this.panl1AttenD.Controls.Add(this.label1);
            this.panl1AttenD.Controls.Add(this.dateTimePicker1);
            this.panl1AttenD.Controls.Add(this.txtBattenstudTotalDays);
            this.panl1AttenD.Controls.Add(this.labattenStudstudId);
            this.panl1AttenD.Location = new System.Drawing.Point(72, 283);
            this.panl1AttenD.Name = "panl1AttenD";
            this.panl1AttenD.Size = new System.Drawing.Size(681, 170);
            this.panl1AttenD.TabIndex = 17;
            // 
            // txtaatt
            // 
            this.txtaatt.Location = new System.Drawing.Point(502, 27);
            this.txtaatt.Name = "txtaatt";
            this.txtaatt.Size = new System.Drawing.Size(154, 20);
            this.txtaatt.TabIndex = 29;
            this.txtaatt.TextChanged += new System.EventHandler(this.txtaatt_TextChanged);
            this.txtaatt.Leave += new System.EventHandler(this.txtaatt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(346, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 44);
            this.label3.TabIndex = 28;
            this.label3.Text = "Number of Days\r\nPresent";
            // 
            // txtatt
            // 
            this.txtatt.Enabled = false;
            this.txtatt.Location = new System.Drawing.Point(170, 122);
            this.txtatt.Name = "txtatt";
            this.txtatt.Size = new System.Drawing.Size(154, 20);
            this.txtatt.TabIndex = 27;
            this.txtatt.TextChanged += new System.EventHandler(this.txtatt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Month";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtBattenstudTotalDays
            // 
            this.txtBattenstudTotalDays.Location = new System.Drawing.Point(170, 27);
            this.txtBattenstudTotalDays.Name = "txtBattenstudTotalDays";
            this.txtBattenstudTotalDays.Size = new System.Drawing.Size(154, 20);
            this.txtBattenstudTotalDays.TabIndex = 24;
            // 
            // labattenStudstudId
            // 
            this.labattenStudstudId.AutoSize = true;
            this.labattenStudstudId.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labattenStudstudId.ForeColor = System.Drawing.Color.Black;
            this.labattenStudstudId.Location = new System.Drawing.Point(14, 27);
            this.labattenStudstudId.Name = "labattenStudstudId";
            this.labattenStudstudId.Size = new System.Drawing.Size(113, 22);
            this.labattenStudstudId.TabIndex = 14;
            this.labattenStudstudId.Text = "Employee ID";
            // 
            // Attendance_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 646);
            this.Controls.Add(this.panel3AttenD);
            this.Controls.Add(this.panel2AttenD);
            this.Controls.Add(this.labAttendanceDetail);
            this.Controls.Add(this.panl1AttenD);
            this.Name = "Attendance_Details";
            this.Text = "Attendance_Details";
            this.Load += new System.EventHandler(this.Attendance_Details_Load);
            this.panel3AttenD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtsid)).EndInit();
            this.panel2AttenD.ResumeLayout(false);
            this.panl1AttenD.ResumeLayout(false);
            this.panl1AttenD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3AttenD;
        private System.Windows.Forms.Panel panel2AttenD;
        private System.Windows.Forms.Button butnattenDLast;
        private System.Windows.Forms.Button butnattenDnext;
        private System.Windows.Forms.Button butnattenDprev;
        private System.Windows.Forms.Label labAttendanceDetail;
        private System.Windows.Forms.Panel panl1AttenD;
        private System.Windows.Forms.TextBox txtBattenstudTotalDays;
        private System.Windows.Forms.Label labattenStudstudId;
        private System.Windows.Forms.Button butnattenDcancel;
        private System.Windows.Forms.Button butnattenDadd;
        private System.Windows.Forms.DataGridView txtsid;
        private System.Windows.Forms.Button butnattenDfirst;
        private System.Windows.Forms.TextBox txtatt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtaatt;
        private System.Windows.Forms.Label label3;
    }
}