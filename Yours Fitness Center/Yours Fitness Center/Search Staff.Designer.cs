namespace Yours_Fitness_Center
{
    partial class Search_Staff
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
            this.panel2serchstaff = new System.Windows.Forms.Panel();
            this.panlsearchstaffid = new System.Windows.Forms.Panel();
            this.butnSearchstaffexit = new System.Windows.Forms.Button();
            this.butnSearchstaffOK = new System.Windows.Forms.Button();
            this.labstafftid = new System.Windows.Forms.Label();
            this.labsearchstaff = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2serchstaff.SuspendLayout();
            this.panlsearchstaffid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2serchstaff
            // 
            this.panel2serchstaff.Controls.Add(this.dataGridView1);
            this.panel2serchstaff.Location = new System.Drawing.Point(78, 243);
            this.panel2serchstaff.Name = "panel2serchstaff";
            this.panel2serchstaff.Size = new System.Drawing.Size(578, 197);
            this.panel2serchstaff.TabIndex = 30;
            this.panel2serchstaff.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2serchstud_Paint);
            // 
            // panlsearchstaffid
            // 
            this.panlsearchstaffid.Controls.Add(this.comboBox1);
            this.panlsearchstaffid.Controls.Add(this.butnSearchstaffexit);
            this.panlsearchstaffid.Controls.Add(this.butnSearchstaffOK);
            this.panlsearchstaffid.Controls.Add(this.labstafftid);
            this.panlsearchstaffid.Location = new System.Drawing.Point(78, 79);
            this.panlsearchstaffid.Name = "panlsearchstaffid";
            this.panlsearchstaffid.Size = new System.Drawing.Size(578, 143);
            this.panlsearchstaffid.TabIndex = 29;
            this.panlsearchstaffid.Paint += new System.Windows.Forms.PaintEventHandler(this.panlsearchstudid_Paint);
            // 
            // butnSearchstaffexit
            // 
            this.butnSearchstaffexit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnSearchstaffexit.Location = new System.Drawing.Point(273, 86);
            this.butnSearchstaffexit.Name = "butnSearchstaffexit";
            this.butnSearchstaffexit.Size = new System.Drawing.Size(75, 27);
            this.butnSearchstaffexit.TabIndex = 8;
            this.butnSearchstaffexit.Text = "EXIT";
            this.butnSearchstaffexit.UseVisualStyleBackColor = true;
            this.butnSearchstaffexit.Click += new System.EventHandler(this.butnSearchstaffexit_Click);
            // 
            // butnSearchstaffOK
            // 
            this.butnSearchstaffOK.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnSearchstaffOK.Location = new System.Drawing.Point(177, 86);
            this.butnSearchstaffOK.Name = "butnSearchstaffOK";
            this.butnSearchstaffOK.Size = new System.Drawing.Size(75, 27);
            this.butnSearchstaffOK.TabIndex = 7;
            this.butnSearchstaffOK.Text = "OK";
            this.butnSearchstaffOK.UseVisualStyleBackColor = true;
            this.butnSearchstaffOK.Click += new System.EventHandler(this.butnSearchstaffOK_Click);
            // 
            // labstafftid
            // 
            this.labstafftid.AutoSize = true;
            this.labstafftid.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstafftid.ForeColor = System.Drawing.Color.MediumBlue;
            this.labstafftid.Location = new System.Drawing.Point(134, 30);
            this.labstafftid.Name = "labstafftid";
            this.labstafftid.Size = new System.Drawing.Size(75, 18);
            this.labstafftid.TabIndex = 1;
            this.labstafftid.Text = "Staff ID";
            // 
            // labsearchstaff
            // 
            this.labsearchstaff.AutoSize = true;
            this.labsearchstaff.BackColor = System.Drawing.Color.Transparent;
            this.labsearchstaff.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsearchstaff.ForeColor = System.Drawing.Color.Black;
            this.labsearchstaff.Location = new System.Drawing.Point(242, 38);
            this.labsearchstaff.Name = "labsearchstaff";
            this.labsearchstaff.Size = new System.Drawing.Size(163, 24);
            this.labsearchstaff.TabIndex = 28;
            this.labsearchstaff.Text = "SEARCH STAFF";
            this.labsearchstaff.Click += new System.EventHandler(this.labsearchstud_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Search_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 484);
            this.Controls.Add(this.panel2serchstaff);
            this.Controls.Add(this.panlsearchstaffid);
            this.Controls.Add(this.labsearchstaff);
            this.Name = "Search_Staff";
            this.Text = "Search_Staff";
            this.Load += new System.EventHandler(this.Search_Staff_Load);
            this.panel2serchstaff.ResumeLayout(false);
            this.panlsearchstaffid.ResumeLayout(false);
            this.panlsearchstaffid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2serchstaff;
        private System.Windows.Forms.Panel panlsearchstaffid;
        private System.Windows.Forms.Button butnSearchstaffexit;
        private System.Windows.Forms.Button butnSearchstaffOK;
        private System.Windows.Forms.Label labstafftid;
        private System.Windows.Forms.Label labsearchstaff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}