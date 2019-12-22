namespace SangliTradingCompany
{
    partial class ModifiedEmployeeDetail
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
            this.mobno_txt = new System.Windows.Forms.TextBox();
            this.empfirstname_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.Fathername_txt = new System.Windows.Forms.TextBox();
            this.Dob_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Femaleradio_btn = new System.Windows.Forms.RadioButton();
            this.maleradio_btn = new System.Windows.Forms.RadioButton();
            this.Add_txt = new System.Windows.Forms.TextBox();
            this.empid_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Groupno_txt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Regno_txt = new System.Windows.Forms.TextBox();
            this.DojdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Designationcombo_box = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofJoiningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new SangliTradingCompany.Database1DataSet();
            this.employee_TableTableAdapter = new SangliTradingCompany.Database1DataSetTableAdapters.Employee_TableTableAdapter();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobno_txt
            // 
            this.mobno_txt.Location = new System.Drawing.Point(168, 347);
            this.mobno_txt.Name = "mobno_txt";
            this.mobno_txt.Size = new System.Drawing.Size(100, 20);
            this.mobno_txt.TabIndex = 10;
            this.mobno_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serno_txt_KeyPress);
            // 
            // empfirstname_txt
            // 
            this.empfirstname_txt.Location = new System.Drawing.Point(168, 59);
            this.empfirstname_txt.Name = "empfirstname_txt";
            this.empfirstname_txt.Size = new System.Drawing.Size(114, 20);
            this.empfirstname_txt.TabIndex = 7;
            this.empfirstname_txt.TextChanged += new System.EventHandler(this.validTextChar);
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(168, 135);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(114, 20);
            this.lastname_txt.TabIndex = 9;
            this.lastname_txt.TextChanged += new System.EventHandler(this.validTextChar);
            // 
            // Fathername_txt
            // 
            this.Fathername_txt.Location = new System.Drawing.Point(168, 98);
            this.Fathername_txt.Name = "Fathername_txt";
            this.Fathername_txt.Size = new System.Drawing.Size(114, 20);
            this.Fathername_txt.TabIndex = 8;
            this.Fathername_txt.TextChanged += new System.EventHandler(this.validTextChar);
            // 
            // Dob_datetimepicker
            // 
            this.Dob_datetimepicker.Location = new System.Drawing.Point(168, 222);
            this.Dob_datetimepicker.Name = "Dob_datetimepicker";
            this.Dob_datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.Dob_datetimepicker.TabIndex = 12;
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(168, 260);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(100, 20);
            this.age_txt.TabIndex = 11;
            this.age_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serno_txt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Designation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Femaleradio_btn);
            this.groupBox2.Controls.Add(this.maleradio_btn);
            this.groupBox2.Location = new System.Drawing.Point(168, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 47);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // Femaleradio_btn
            // 
            this.Femaleradio_btn.AutoSize = true;
            this.Femaleradio_btn.Location = new System.Drawing.Point(116, 19);
            this.Femaleradio_btn.Name = "Femaleradio_btn";
            this.Femaleradio_btn.Size = new System.Drawing.Size(59, 17);
            this.Femaleradio_btn.TabIndex = 13;
            this.Femaleradio_btn.TabStop = true;
            this.Femaleradio_btn.Text = "Female";
            this.Femaleradio_btn.UseVisualStyleBackColor = true;
            // 
            // maleradio_btn
            // 
            this.maleradio_btn.AutoSize = true;
            this.maleradio_btn.Location = new System.Drawing.Point(6, 19);
            this.maleradio_btn.Name = "maleradio_btn";
            this.maleradio_btn.Size = new System.Drawing.Size(48, 17);
            this.maleradio_btn.TabIndex = 12;
            this.maleradio_btn.TabStop = true;
            this.maleradio_btn.Text = "Male";
            this.maleradio_btn.UseVisualStyleBackColor = true;
            // 
            // Add_txt
            // 
            this.Add_txt.Location = new System.Drawing.Point(174, 297);
            this.Add_txt.Multiline = true;
            this.Add_txt.Name = "Add_txt";
            this.Add_txt.Size = new System.Drawing.Size(176, 35);
            this.Add_txt.TabIndex = 7;
            // 
            // empid_txt
            // 
            this.empid_txt.Location = new System.Drawing.Point(168, 26);
            this.empid_txt.Name = "empid_txt";
            this.empid_txt.Size = new System.Drawing.Size(114, 20);
            this.empid_txt.TabIndex = 6;
            this.empid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serno_txt_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Mobile Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Age";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Date Of Joining";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Father\'s Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dob_datetimepicker);
            this.groupBox1.Controls.Add(this.age_txt);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.mobno_txt);
            this.groupBox1.Controls.Add(this.lastname_txt);
            this.groupBox1.Controls.Add(this.Fathername_txt);
            this.groupBox1.Controls.Add(this.empfirstname_txt);
            this.groupBox1.Controls.Add(this.Add_txt);
            this.groupBox1.Controls.Add(this.empid_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(240, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 378);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emloyee First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Registration Number";
            // 
            // Groupno_txt
            // 
            this.Groupno_txt.Location = new System.Drawing.Point(133, 208);
            this.Groupno_txt.Name = "Groupno_txt";
            this.Groupno_txt.Size = new System.Drawing.Size(100, 20);
            this.Groupno_txt.TabIndex = 20;
            this.Groupno_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serno_txt_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Groupno_txt);
            this.groupBox4.Controls.Add(this.Regno_txt);
            this.groupBox4.Controls.Add(this.DojdateTimePicker);
            this.groupBox4.Controls.Add(this.Designationcombo_box);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(750, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 271);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Department Detail";
            // 
            // Regno_txt
            // 
            this.Regno_txt.Location = new System.Drawing.Point(133, 155);
            this.Regno_txt.Name = "Regno_txt";
            this.Regno_txt.Size = new System.Drawing.Size(100, 20);
            this.Regno_txt.TabIndex = 19;
            this.Regno_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serno_txt_KeyPress);
            // 
            // DojdateTimePicker
            // 
            this.DojdateTimePicker.Location = new System.Drawing.Point(133, 98);
            this.DojdateTimePicker.Name = "DojdateTimePicker";
            this.DojdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DojdateTimePicker.TabIndex = 18;
            // 
            // Designationcombo_box
            // 
            this.Designationcombo_box.FormattingEnabled = true;
            this.Designationcombo_box.Items.AddRange(new object[] {
            "Manager",
            "Accountant",
            "Worker"});
            this.Designationcombo_box.Location = new System.Drawing.Point(133, 41);
            this.Designationcombo_box.Name = "Designationcombo_box";
            this.Designationcombo_box.Size = new System.Drawing.Size(121, 21);
            this.Designationcombo_box.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Group Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(-3, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1325, 158);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.fathersNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobilenoDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.dateofJoiningDataGridViewTextBoxColumn,
            this.registrationnoDataGridViewTextBoxColumn,
            this.groupnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1316, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // fathersNameDataGridViewTextBoxColumn
            // 
            this.fathersNameDataGridViewTextBoxColumn.DataPropertyName = "Fathers_Name";
            this.fathersNameDataGridViewTextBoxColumn.HeaderText = "Fathers_Name";
            this.fathersNameDataGridViewTextBoxColumn.Name = "fathersNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            this.mobilenoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.HeaderText = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // dateofJoiningDataGridViewTextBoxColumn
            // 
            this.dateofJoiningDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Joining";
            this.dateofJoiningDataGridViewTextBoxColumn.HeaderText = "Date_of_Joining";
            this.dateofJoiningDataGridViewTextBoxColumn.Name = "dateofJoiningDataGridViewTextBoxColumn";
            // 
            // registrationnoDataGridViewTextBoxColumn
            // 
            this.registrationnoDataGridViewTextBoxColumn.DataPropertyName = "Registration_no";
            this.registrationnoDataGridViewTextBoxColumn.HeaderText = "Registration_no";
            this.registrationnoDataGridViewTextBoxColumn.Name = "registrationnoDataGridViewTextBoxColumn";
            // 
            // groupnoDataGridViewTextBoxColumn
            // 
            this.groupnoDataGridViewTextBoxColumn.DataPropertyName = "Group_no";
            this.groupnoDataGridViewTextBoxColumn.HeaderText = "Group_no";
            this.groupnoDataGridViewTextBoxColumn.Name = "groupnoDataGridViewTextBoxColumn";
            // 
            // employeeTableBindingSource
            // 
            this.employeeTableBindingSource.DataMember = "Employee_Table";
            this.employeeTableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_TableTableAdapter
            // 
            this.employee_TableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Edit_btn);
            this.groupBox6.Location = new System.Drawing.Point(129, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 67);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "You Want to Modify then Click On Edit Button";
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(88, 30);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_btn.TabIndex = 0;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Cancel_btn);
            this.groupBox5.Controls.Add(this.Del_btn);
            this.groupBox5.Controls.Add(this.Update_btn);
            this.groupBox5.Location = new System.Drawing.Point(552, 398);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(739, 67);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(447, 30);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 2;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.Location = new System.Drawing.Point(259, 30);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(75, 23);
            this.Del_btn.TabIndex = 1;
            this.Del_btn.Text = "Delete";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(75, 30);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 0;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // ModifiedEmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1317, 662);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "ModifiedEmployeeDetail";
            this.Text = "ModifiedEmployeeDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModifiedEmployeeDetail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox mobno_txt;
        private System.Windows.Forms.TextBox empfirstname_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox Fathername_txt;
        private System.Windows.Forms.DateTimePicker Dob_datetimepicker;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Femaleradio_btn;
        private System.Windows.Forms.RadioButton maleradio_btn;
        private System.Windows.Forms.TextBox Add_txt;
        private System.Windows.Forms.TextBox empid_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Groupno_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Regno_txt;
        private System.Windows.Forms.DateTimePicker DojdateTimePicker;
        private System.Windows.Forms.ComboBox Designationcombo_box;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource employeeTableBindingSource;
        private Database1DataSetTableAdapters.Employee_TableTableAdapter employee_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofJoiningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Button Update_btn;
    }
}