<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpaymentslip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.txtnetsalary = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtincrement = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtsalary = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtdeductiontotal = New System.Windows.Forms.TextBox
        Me.txtincometax = New System.Windows.Forms.TextBox
        Me.txtsalarydeductedforleaves = New System.Windows.Forms.TextBox
        Me.txtPT = New System.Windows.Forms.TextBox
        Me.txtPF = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtallowancetotal = New System.Windows.Forms.TextBox
        Me.txtsalaryduringOT = New System.Windows.Forms.TextBox
        Me.txtTA = New System.Windows.Forms.TextBox
        Me.txtDA = New System.Windows.Forms.TextBox
        Me.txtHRA = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtgrosssalary = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdesignation = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtmiddlename = New System.Windows.Forms.TextBox
        Me.txtfirstname = New System.Windows.Forms.TextBox
        Me.txtlastname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtchequeno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboempid = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbodepartment = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JET_AIRWAYS.My.Resources.Resources.Jet_Airways_Banner_1_3
        Me.PictureBox1.Location = New System.Drawing.Point(-1145, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3026, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Payment Slip Of Employee"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 466)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.btnprint)
        Me.GroupBox9.Controls.Add(Me.btnback)
        Me.GroupBox9.Controls.Add(Me.btnexit)
        Me.GroupBox9.Controls.Add(Me.btnclear)
        Me.GroupBox9.Controls.Add(Me.btnsave)
        Me.GroupBox9.Location = New System.Drawing.Point(43, 391)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(550, 69)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(12, 19)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(90, 31)
        Me.btnprint.TabIndex = 5
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(326, 19)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(91, 32)
        Me.btnback.TabIndex = 4
        Me.btnback.Text = "&Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(440, 19)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(91, 32)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(210, 19)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(91, 32)
        Me.btnclear.TabIndex = 2
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(108, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(91, 32)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtnetsalary)
        Me.GroupBox8.Location = New System.Drawing.Point(511, 335)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(260, 50)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Net Salary"
        '
        'txtnetsalary
        '
        Me.txtnetsalary.Location = New System.Drawing.Point(36, 19)
        Me.txtnetsalary.Name = "txtnetsalary"
        Me.txtnetsalary.Size = New System.Drawing.Size(203, 20)
        Me.txtnetsalary.TabIndex = 6
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtincrement)
        Me.GroupBox7.Location = New System.Drawing.Point(248, 335)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(239, 50)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Increment"
        '
        'txtincrement
        '
        Me.txtincrement.Location = New System.Drawing.Point(28, 19)
        Me.txtincrement.Name = "txtincrement"
        Me.txtincrement.Size = New System.Drawing.Size(181, 20)
        Me.txtincrement.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtsalary)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 335)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(206, 50)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Salary "
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(9, 19)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(184, 20)
        Me.txtsalary.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtgrosssalary)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtdesignation)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtmiddlename)
        Me.GroupBox3.Controls.Add(Me.txtfirstname)
        Me.GroupBox3.Controls.Add(Me.txtlastname)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(780, 258)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtdeductiontotal)
        Me.GroupBox5.Controls.Add(Me.txtincometax)
        Me.GroupBox5.Controls.Add(Me.txtsalarydeductedforleaves)
        Me.GroupBox5.Controls.Add(Me.txtPT)
        Me.GroupBox5.Controls.Add(Me.txtPF)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Location = New System.Drawing.Point(344, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(409, 159)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Deduction"
        '
        'txtdeductiontotal
        '
        Me.txtdeductiontotal.Location = New System.Drawing.Point(197, 129)
        Me.txtdeductiontotal.Name = "txtdeductiontotal"
        Me.txtdeductiontotal.Size = New System.Drawing.Size(176, 20)
        Me.txtdeductiontotal.TabIndex = 9
        '
        'txtincometax
        '
        Me.txtincometax.Location = New System.Drawing.Point(197, 97)
        Me.txtincometax.Name = "txtincometax"
        Me.txtincometax.Size = New System.Drawing.Size(176, 20)
        Me.txtincometax.TabIndex = 8
        '
        'txtsalarydeductedforleaves
        '
        Me.txtsalarydeductedforleaves.Location = New System.Drawing.Point(197, 71)
        Me.txtsalarydeductedforleaves.Name = "txtsalarydeductedforleaves"
        Me.txtsalarydeductedforleaves.Size = New System.Drawing.Size(176, 20)
        Me.txtsalarydeductedforleaves.TabIndex = 7
        '
        'txtPT
        '
        Me.txtPT.Location = New System.Drawing.Point(197, 45)
        Me.txtPT.Name = "txtPT"
        Me.txtPT.Size = New System.Drawing.Size(176, 20)
        Me.txtPT.TabIndex = 6
        '
        'txtPF
        '
        Me.txtPF.Location = New System.Drawing.Point(197, 16)
        Me.txtPF.Name = "txtPF"
        Me.txtPF.Size = New System.Drawing.Size(176, 20)
        Me.txtPF.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Total :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Income Tax :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(176, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Salary Deducted For Leaves :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "PT :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "PF :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtallowancetotal)
        Me.GroupBox4.Controls.Add(Me.txtsalaryduringOT)
        Me.GroupBox4.Controls.Add(Me.txtTA)
        Me.GroupBox4.Controls.Add(Me.txtDA)
        Me.GroupBox4.Controls.Add(Me.txtHRA)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 83)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(329, 169)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Allowance "
        '
        'txtallowancetotal
        '
        Me.txtallowancetotal.Location = New System.Drawing.Point(127, 139)
        Me.txtallowancetotal.Name = "txtallowancetotal"
        Me.txtallowancetotal.Size = New System.Drawing.Size(153, 20)
        Me.txtallowancetotal.TabIndex = 9
        '
        'txtsalaryduringOT
        '
        Me.txtsalaryduringOT.Location = New System.Drawing.Point(127, 110)
        Me.txtsalaryduringOT.Name = "txtsalaryduringOT"
        Me.txtsalaryduringOT.Size = New System.Drawing.Size(153, 20)
        Me.txtsalaryduringOT.TabIndex = 8
        '
        'txtTA
        '
        Me.txtTA.Location = New System.Drawing.Point(127, 75)
        Me.txtTA.Name = "txtTA"
        Me.txtTA.Size = New System.Drawing.Size(153, 20)
        Me.txtTA.TabIndex = 7
        '
        'txtDA
        '
        Me.txtDA.Location = New System.Drawing.Point(127, 52)
        Me.txtDA.Name = "txtDA"
        Me.txtDA.Size = New System.Drawing.Size(153, 20)
        Me.txtDA.TabIndex = 6
        '
        'txtHRA
        '
        Me.txtHRA.Location = New System.Drawing.Point(127, 23)
        Me.txtHRA.Name = "txtHRA"
        Me.txtHRA.Size = New System.Drawing.Size(153, 20)
        Me.txtHRA.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Total :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Salary During OT :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "TA :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "DA :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "HRA :"
        '
        'txtgrosssalary
        '
        Me.txtgrosssalary.Location = New System.Drawing.Point(450, 57)
        Me.txtgrosssalary.Name = "txtgrosssalary"
        Me.txtgrosssalary.Size = New System.Drawing.Size(191, 20)
        Me.txtgrosssalary.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(339, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Gross Salary :"
        '
        'txtdesignation
        '
        Me.txtdesignation.Location = New System.Drawing.Point(113, 57)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Size = New System.Drawing.Size(200, 20)
        Me.txtdesignation.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Dsignation :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(615, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "(Middle Name)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(379, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "(First Name)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "(Surname)"
        '
        'txtmiddlename
        '
        Me.txtmiddlename.Location = New System.Drawing.Point(553, 15)
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(191, 20)
        Me.txtmiddlename.TabIndex = 3
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(328, 15)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(201, 20)
        Me.txtfirstname.TabIndex = 2
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(113, 18)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(200, 20)
        Me.txtlastname.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Employee Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.txtchequeno)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboempid)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(780, 55)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(270, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 6
        Me.DateTimePicker1.Value = New Date(2007, 6, 4, 0, 0, 0, 0)
        '
        'txtchequeno
        '
        Me.txtchequeno.Location = New System.Drawing.Point(680, 22)
        Me.txtchequeno.Name = "txtchequeno"
        Me.txtchequeno.Size = New System.Drawing.Size(94, 20)
        Me.txtchequeno.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(600, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ChequeNo :"
        '
        'cboempid
        '
        Me.cboempid.FormattingEnabled = True
        Me.cboempid.Location = New System.Drawing.Point(72, 21)
        Me.cboempid.Name = "cboempid"
        Me.cboempid.Size = New System.Drawing.Size(121, 21)
        Me.cboempid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Emp ID :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Depatment :"
        '
        'cbodepartment
        '
        Me.cbodepartment.FormattingEnabled = True
        Me.cbodepartment.Location = New System.Drawing.Point(131, 75)
        Me.cbodepartment.Name = "cbodepartment"
        Me.cbodepartment.Size = New System.Drawing.Size(121, 21)
        Me.cbodepartment.TabIndex = 8
        '
        'frmpaymentslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 578)
        Me.Controls.Add(Me.cbodepartment)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmpaymentslip"
        Me.Text = "PaymentSlip"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtchequeno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboempid As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtgrosssalary As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtallowancetotal As System.Windows.Forms.TextBox
    Friend WithEvents txtsalaryduringOT As System.Windows.Forms.TextBox
    Friend WithEvents txtTA As System.Windows.Forms.TextBox
    Friend WithEvents txtDA As System.Windows.Forms.TextBox
    Friend WithEvents txtHRA As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtdeductiontotal As System.Windows.Forms.TextBox
    Friend WithEvents txtincometax As System.Windows.Forms.TextBox
    Friend WithEvents txtsalarydeductedforleaves As System.Windows.Forms.TextBox
    Friend WithEvents txtPT As System.Windows.Forms.TextBox
    Friend WithEvents txtPF As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnetsalary As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtincrement As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbodepartment As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
