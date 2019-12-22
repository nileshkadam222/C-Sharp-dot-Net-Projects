namespace LIC
{
    partial class Transaction2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction2));
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_polno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.lbl_totprem = new System.Windows.Forms.Label();
            this.lbl_commprem = new System.Windows.Forms.Label();
            this.lbl_commrisk = new System.Windows.Forms.Label();
            this.lbl_totcomm = new System.Windows.Forms.Label();
            this.txt_totprem = new System.Windows.Forms.TextBox();
            this.txt_tot_comm_on_prem = new System.Windows.Forms.TextBox();
            this.txt_tot_comm_on_riskdate = new System.Windows.Forms.TextBox();
            this.txt_tot_comm_amt = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cncl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Policy_No";
            // 
            // cbo_polno
            // 
            this.cbo_polno.DropDownHeight = 120;
            this.cbo_polno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_polno.FormattingEnabled = true;
            this.cbo_polno.IntegralHeight = false;
            this.cbo_polno.Location = new System.Drawing.Point(187, 54);
            this.cbo_polno.Name = "cbo_polno";
            this.cbo_polno.Size = new System.Drawing.Size(121, 29);
            this.cbo_polno.TabIndex = 2;
            this.cbo_polno.SelectedValueChanged += new System.EventHandler(this.cbo_polno_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name";
            // 
            // txt_cname
            // 
            this.txt_cname.Enabled = false;
            this.txt_cname.Location = new System.Drawing.Point(494, 52);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(100, 29);
            this.txt_cname.TabIndex = 5;
            // 
            // lbl_totprem
            // 
            this.lbl_totprem.AutoSize = true;
            this.lbl_totprem.Location = new System.Drawing.Point(130, 147);
            this.lbl_totprem.Name = "lbl_totprem";
            this.lbl_totprem.Size = new System.Drawing.Size(119, 21);
            this.lbl_totprem.TabIndex = 6;
            this.lbl_totprem.Text = "Total Premium";
            // 
            // lbl_commprem
            // 
            this.lbl_commprem.AutoSize = true;
            this.lbl_commprem.Location = new System.Drawing.Point(130, 206);
            this.lbl_commprem.Name = "lbl_commprem";
            this.lbl_commprem.Size = new System.Drawing.Size(238, 21);
            this.lbl_commprem.TabIndex = 7;
            this.lbl_commprem.Text = "Total commission on Premium";
            // 
            // lbl_commrisk
            // 
            this.lbl_commrisk.AutoSize = true;
            this.lbl_commrisk.Location = new System.Drawing.Point(130, 271);
            this.lbl_commrisk.Name = "lbl_commrisk";
            this.lbl_commrisk.Size = new System.Drawing.Size(229, 21);
            this.lbl_commrisk.TabIndex = 8;
            this.lbl_commrisk.Text = "total commission on risk date";
            // 
            // lbl_totcomm
            // 
            this.lbl_totcomm.AutoSize = true;
            this.lbl_totcomm.Location = new System.Drawing.Point(131, 338);
            this.lbl_totcomm.Name = "lbl_totcomm";
            this.lbl_totcomm.Size = new System.Drawing.Size(211, 21);
            this.lbl_totcomm.TabIndex = 9;
            this.lbl_totcomm.Text = "Total Commission Amount";
            // 
            // txt_totprem
            // 
            this.txt_totprem.Enabled = false;
            this.txt_totprem.Location = new System.Drawing.Point(429, 139);
            this.txt_totprem.Name = "txt_totprem";
            this.txt_totprem.Size = new System.Drawing.Size(100, 29);
            this.txt_totprem.TabIndex = 10;
            // 
            // txt_tot_comm_on_prem
            // 
            this.txt_tot_comm_on_prem.Enabled = false;
            this.txt_tot_comm_on_prem.Location = new System.Drawing.Point(429, 203);
            this.txt_tot_comm_on_prem.Name = "txt_tot_comm_on_prem";
            this.txt_tot_comm_on_prem.Size = new System.Drawing.Size(100, 29);
            this.txt_tot_comm_on_prem.TabIndex = 11;
            // 
            // txt_tot_comm_on_riskdate
            // 
            this.txt_tot_comm_on_riskdate.Enabled = false;
            this.txt_tot_comm_on_riskdate.Location = new System.Drawing.Point(429, 268);
            this.txt_tot_comm_on_riskdate.Name = "txt_tot_comm_on_riskdate";
            this.txt_tot_comm_on_riskdate.Size = new System.Drawing.Size(100, 29);
            this.txt_tot_comm_on_riskdate.TabIndex = 12;
            // 
            // txt_tot_comm_amt
            // 
            this.txt_tot_comm_amt.Enabled = false;
            this.txt_tot_comm_amt.Location = new System.Drawing.Point(429, 330);
            this.txt_tot_comm_amt.Name = "txt_tot_comm_amt";
            this.txt_tot_comm_amt.Size = new System.Drawing.Size(100, 29);
            this.txt_tot_comm_amt.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(212, 394);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 37);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cncl
            // 
            this.btn_cncl.Location = new System.Drawing.Point(348, 394);
            this.btn_cncl.Name = "btn_cncl";
            this.btn_cncl.Size = new System.Drawing.Size(97, 37);
            this.btn_cncl.TabIndex = 15;
            this.btn_cncl.Text = "CANCEL";
            this.btn_cncl.UseVisualStyleBackColor = true;
            this.btn_cncl.Click += new System.EventHandler(this.btn_cncl_Click);
            // 
            // Transaction2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 456);
            this.Controls.Add(this.btn_cncl);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_tot_comm_amt);
            this.Controls.Add(this.txt_tot_comm_on_riskdate);
            this.Controls.Add(this.txt_tot_comm_on_prem);
            this.Controls.Add(this.txt_totprem);
            this.Controls.Add(this.lbl_totcomm);
            this.Controls.Add(this.lbl_commrisk);
            this.Controls.Add(this.lbl_commprem);
            this.Controls.Add(this.lbl_totprem);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_polno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Transaction2";
            this.Text = "Transaction2";
            this.Load += new System.EventHandler(this.Transaction2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_polno;
        // private LICDataSet2 lICDataSet2;
        //private LICDataSet2TableAdapters.C_PolicyDetailsTableAdapter c_PolicyDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDtofCommDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSumAssuredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPremiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pModeofPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDtofMaturityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.Label lbl_totprem;
        private System.Windows.Forms.Label lbl_commprem;
        private System.Windows.Forms.Label lbl_commrisk;
        private System.Windows.Forms.Label lbl_totcomm;
        private System.Windows.Forms.TextBox txt_totprem;
        private System.Windows.Forms.TextBox txt_tot_comm_on_prem;
        private System.Windows.Forms.TextBox txt_tot_comm_on_riskdate;
        private System.Windows.Forms.TextBox txt_tot_comm_amt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cncl;



    }
}