namespace EmployeeProfileManagement
{
    partial class frmUserMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMdi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarySlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salarySlipDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.attendenceToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.attendenceToolStripMenuItem.Text = "Attendence";
            this.attendenceToolStripMenuItem.Click += new System.EventHandler(this.attendenceToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.employeeToolStripMenuItem1.Text = "Employee";
            this.employeeToolStripMenuItem1.Click += new System.EventHandler(this.employeeToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentWiseToolStripMenuItem,
            this.designationWiseToolStripMenuItem,
            this.salarySlipToolStripMenuItem,
            this.employeeToolStripMenuItem2,
            this.salarySlipDetailsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // departmentWiseToolStripMenuItem
            // 
            this.departmentWiseToolStripMenuItem.Name = "departmentWiseToolStripMenuItem";
            this.departmentWiseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.departmentWiseToolStripMenuItem.Text = "Department Wise";
            this.departmentWiseToolStripMenuItem.Click += new System.EventHandler(this.departmentWiseToolStripMenuItem_Click);
            // 
            // designationWiseToolStripMenuItem
            // 
            this.designationWiseToolStripMenuItem.Name = "designationWiseToolStripMenuItem";
            this.designationWiseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.designationWiseToolStripMenuItem.Text = "Designation Wise";
            this.designationWiseToolStripMenuItem.Click += new System.EventHandler(this.designationWiseToolStripMenuItem_Click);
            // 
            // salarySlipToolStripMenuItem
            // 
            this.salarySlipToolStripMenuItem.Name = "salarySlipToolStripMenuItem";
            this.salarySlipToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salarySlipToolStripMenuItem.Text = "Salary Slip";
            this.salarySlipToolStripMenuItem.Click += new System.EventHandler(this.salarySlipToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem2
            // 
            this.employeeToolStripMenuItem2.Name = "employeeToolStripMenuItem2";
            this.employeeToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.employeeToolStripMenuItem2.Text = "Employee";
            this.employeeToolStripMenuItem2.Click += new System.EventHandler(this.employeeToolStripMenuItem2_Click);
            // 
            // salarySlipDetailsToolStripMenuItem
            // 
            this.salarySlipDetailsToolStripMenuItem.Name = "salarySlipDetailsToolStripMenuItem";
            this.salarySlipDetailsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salarySlipDetailsToolStripMenuItem.Text = "Salary Slip Details";
            this.salarySlipDetailsToolStripMenuItem.Click += new System.EventHandler(this.salarySlipDetailsToolStripMenuItem_Click);
            // 
            // frmUserMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 336);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserMdi";
            this.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarySlipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salarySlipDetailsToolStripMenuItem;
    }
}