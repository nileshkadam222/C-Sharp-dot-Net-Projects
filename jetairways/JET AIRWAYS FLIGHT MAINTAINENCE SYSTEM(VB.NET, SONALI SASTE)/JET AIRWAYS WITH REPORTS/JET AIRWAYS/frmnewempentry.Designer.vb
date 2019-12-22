<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnewemployeeentry
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtempid = New System.Windows.Forms.TextBox
        Me.cbodepartment = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboempid = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btndetails = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtDA = New System.Windows.Forms.TextBox
        Me.txtTA = New System.Windows.Forms.TextBox
        Me.txtPF = New System.Windows.Forms.TextBox
        Me.txtPT = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtHRA = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.dtpdate_of_leaving = New System.Windows.Forms.DateTimePicker
        Me.dtpdat_of_joining = New System.Windows.Forms.DateTimePicker
        Me.txtgrosssalary = New System.Windows.Forms.TextBox
        Me.cbostatus = New System.Windows.Forms.ComboBox
        Me.cbodesignation = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtgender = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpbirth_date = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbobloodgroup = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtqualification = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtmobileno = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtemailid = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtresidentalno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbtnmale = New System.Windows.Forms.RadioButton
        Me.rbtnfemale = New System.Windows.Forms.RadioButton
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmiddlename = New System.Windows.Forms.TextBox
        Me.txtfirstname = New System.Windows.Forms.TextBox
        Me.txtlastname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JET_AIRWAYS.My.Resources.Resources.Jet_Airways_Banner_1_3
        Me.PictureBox1.Location = New System.Drawing.Point(-1146, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3026, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtempid)
        Me.GroupBox1.Controls.Add(Me.cbodepartment)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 50)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(297, 19)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Size = New System.Drawing.Size(100, 20)
        Me.txtempid.TabIndex = 3
        '
        'cbodepartment
        '
        Me.cbodepartment.FormattingEnabled = True
        Me.cbodepartment.Items.AddRange(New Object() {"Flight Operation", "Flight Dispatch"})
        Me.cbodepartment.Location = New System.Drawing.Point(92, 19)
        Me.cbodepartment.Name = "cbodepartment"
        Me.cbodepartment.Size = New System.Drawing.Size(121, 21)
        Me.cbodepartment.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EmpID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboempid)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(435, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 49)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'cboempid
        '
        Me.cboempid.FormattingEnabled = True
        Me.cboempid.Location = New System.Drawing.Point(104, 17)
        Me.cboempid.Name = "cboempid"
        Me.cboempid.Size = New System.Drawing.Size(121, 21)
        Me.cboempid.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(873, 630)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnclear)
        Me.GroupBox7.Controls.Add(Me.btnback)
        Me.GroupBox7.Controls.Add(Me.btnexit)
        Me.GroupBox7.Controls.Add(Me.btndetails)
        Me.GroupBox7.Controls.Add(Me.btndelete)
        Me.GroupBox7.Controls.Add(Me.btnupdate)
        Me.GroupBox7.Controls.Add(Me.btnsave)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(27, 540)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(827, 84)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(452, 21)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(104, 43)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(708, 19)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(97, 43)
        Me.btnback.TabIndex = 7
        Me.btnback.Text = "&Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(594, 19)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(93, 43)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndetails
        '
        Me.btndetails.Location = New System.Drawing.Point(333, 23)
        Me.btndetails.Name = "btndetails"
        Me.btndetails.Size = New System.Drawing.Size(93, 39)
        Me.btndetails.TabIndex = 3
        Me.btndetails.Text = "Details"
        Me.btndetails.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(234, 21)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(93, 43)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(123, 21)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(93, 43)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(3, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(93, 43)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtDA)
        Me.GroupBox6.Controls.Add(Me.txtTA)
        Me.GroupBox6.Controls.Add(Me.txtPF)
        Me.GroupBox6.Controls.Add(Me.txtPT)
        Me.GroupBox6.Controls.Add(Me.txtpassword)
        Me.GroupBox6.Controls.Add(Me.txtHRA)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.dtpdate_of_leaving)
        Me.GroupBox6.Controls.Add(Me.dtpdat_of_joining)
        Me.GroupBox6.Controls.Add(Me.txtgrosssalary)
        Me.GroupBox6.Controls.Add(Me.cbostatus)
        Me.GroupBox6.Controls.Add(Me.cbodesignation)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 301)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(848, 206)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = " "
        '
        'txtDA
        '
        Me.txtDA.Location = New System.Drawing.Point(142, 136)
        Me.txtDA.Name = "txtDA"
        Me.txtDA.Size = New System.Drawing.Size(161, 20)
        Me.txtDA.TabIndex = 22
        '
        'txtTA
        '
        Me.txtTA.Location = New System.Drawing.Point(142, 162)
        Me.txtTA.Name = "txtTA"
        Me.txtTA.Size = New System.Drawing.Size(161, 20)
        Me.txtTA.TabIndex = 21
        '
        'txtPF
        '
        Me.txtPF.Location = New System.Drawing.Point(493, 113)
        Me.txtPF.Name = "txtPF"
        Me.txtPF.Size = New System.Drawing.Size(161, 20)
        Me.txtPF.TabIndex = 20
        '
        'txtPT
        '
        Me.txtPT.Location = New System.Drawing.Point(493, 139)
        Me.txtPT.Name = "txtPT"
        Me.txtPT.Size = New System.Drawing.Size(161, 20)
        Me.txtPT.TabIndex = 19
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(493, 166)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(161, 20)
        Me.txtpassword.TabIndex = 18
        '
        'txtHRA
        '
        Me.txtHRA.Location = New System.Drawing.Point(144, 110)
        Me.txtHRA.Name = "txtHRA"
        Me.txtHRA.Size = New System.Drawing.Size(161, 20)
        Me.txtHRA.TabIndex = 17
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(75, 136)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "DA :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(75, 162)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 13)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "TA :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(386, 146)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "PT :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(386, 173)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 13)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Password :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(386, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "PF :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(66, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "HRA :"
        '
        'dtpdate_of_leaving
        '
        Me.dtpdate_of_leaving.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate_of_leaving.Location = New System.Drawing.Point(494, 75)
        Me.dtpdate_of_leaving.Name = "dtpdate_of_leaving"
        Me.dtpdate_of_leaving.Size = New System.Drawing.Size(200, 20)
        Me.dtpdate_of_leaving.TabIndex = 10
        '
        'dtpdat_of_joining
        '
        Me.dtpdat_of_joining.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdat_of_joining.Location = New System.Drawing.Point(494, 24)
        Me.dtpdat_of_joining.Name = "dtpdat_of_joining"
        Me.dtpdat_of_joining.Size = New System.Drawing.Size(200, 20)
        Me.dtpdat_of_joining.TabIndex = 9
        '
        'txtgrosssalary
        '
        Me.txtgrosssalary.Location = New System.Drawing.Point(142, 79)
        Me.txtgrosssalary.Name = "txtgrosssalary"
        Me.txtgrosssalary.Size = New System.Drawing.Size(161, 20)
        Me.txtgrosssalary.TabIndex = 8
        '
        'cbostatus
        '
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Permanant", "Temporary"})
        Me.cbostatus.Location = New System.Drawing.Point(142, 45)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(161, 21)
        Me.cbostatus.TabIndex = 6
        '
        'cbodesignation
        '
        Me.cbodesignation.FormattingEnabled = True
        Me.cbodesignation.Items.AddRange(New Object() {"Senior Manager", "Manager", "Staff"})
        Me.cbodesignation.Location = New System.Drawing.Point(142, 18)
        Me.cbodesignation.Name = "cbodesignation"
        Me.cbodesignation.Size = New System.Drawing.Size(161, 21)
        Me.cbodesignation.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(370, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Date Of Leaving :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(370, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Date Of Joining :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(26, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Gross Salary : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(55, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Status :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Designation :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtgender)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.dtpbirth_date)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cbobloodgroup)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtqualification)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtmobileno)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtemailid)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtresidentalno)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.txtaddress)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtmiddlename)
        Me.GroupBox4.Controls.Add(Me.txtfirstname)
        Me.GroupBox4.Controls.Add(Me.txtlastname)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(848, 221)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Personal Details"
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(690, 83)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(100, 20)
        Me.txtgender.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(438, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Gender :"
        '
        'dtpbirth_date
        '
        Me.dtpbirth_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbirth_date.Location = New System.Drawing.Point(514, 194)
        Me.dtpbirth_date.Name = "dtpbirth_date"
        Me.dtpbirth_date.Size = New System.Drawing.Size(255, 20)
        Me.dtpbirth_date.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(408, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Date Of Birth :"
        '
        'cbobloodgroup
        '
        Me.cbobloodgroup.FormattingEnabled = True
        Me.cbobloodgroup.Items.AddRange(New Object() {"A+", "A-", "O+", "O-", "AB+", "AB-", "B+", "B-"})
        Me.cbobloodgroup.Location = New System.Drawing.Point(157, 186)
        Me.cbobloodgroup.Name = "cbobloodgroup"
        Me.cbobloodgroup.Size = New System.Drawing.Size(211, 21)
        Me.cbobloodgroup.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Blood Group :"
        '
        'txtqualification
        '
        Me.txtqualification.Location = New System.Drawing.Point(514, 159)
        Me.txtqualification.Name = "txtqualification"
        Me.txtqualification.Size = New System.Drawing.Size(255, 20)
        Me.txtqualification.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(408, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Qualification :"
        '
        'txtmobileno
        '
        Me.txtmobileno.Location = New System.Drawing.Point(157, 146)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(211, 20)
        Me.txtmobileno.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Mobile No :"
        '
        'txtemailid
        '
        Me.txtemailid.Location = New System.Drawing.Point(514, 122)
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(270, 20)
        Me.txtemailid.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(429, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Email_ID :"
        '
        'txtresidentalno
        '
        Me.txtresidentalno.Location = New System.Drawing.Point(157, 107)
        Me.txtresidentalno.Name = "txtresidentalno"
        Me.txtresidentalno.Size = New System.Drawing.Size(211, 20)
        Me.txtresidentalno.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Residental No : "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbtnmale)
        Me.GroupBox5.Controls.Add(Me.rbtnfemale)
        Me.GroupBox5.Location = New System.Drawing.Point(514, 65)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(170, 51)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'rbtnmale
        '
        Me.rbtnmale.AutoSize = True
        Me.rbtnmale.Location = New System.Drawing.Point(16, 19)
        Me.rbtnmale.Name = "rbtnmale"
        Me.rbtnmale.Size = New System.Drawing.Size(56, 17)
        Me.rbtnmale.TabIndex = 0
        Me.rbtnmale.TabStop = True
        Me.rbtnmale.Text = "Male "
        Me.rbtnmale.UseVisualStyleBackColor = True
        '
        'rbtnfemale
        '
        Me.rbtnfemale.AutoSize = True
        Me.rbtnfemale.Location = New System.Drawing.Point(87, 17)
        Me.rbtnfemale.Name = "rbtnfemale"
        Me.rbtnfemale.Size = New System.Drawing.Size(69, 17)
        Me.rbtnfemale.TabIndex = 1
        Me.rbtnfemale.TabStop = True
        Me.rbtnfemale.Text = "Female "
        Me.rbtnfemale.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(157, 69)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(211, 20)
        Me.txtaddress.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(638, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "(Middle Name)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(452, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(First Name)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "(Last Name)"
        '
        'txtmiddlename
        '
        Me.txtmiddlename.Location = New System.Drawing.Point(595, 26)
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(195, 20)
        Me.txtmiddlename.TabIndex = 3
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(394, 23)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(192, 20)
        Me.txtfirstname.TabIndex = 2
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(157, 23)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(211, 20)
        Me.txtlastname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Employee Name :"
        '
        'frmnewemployeeentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 578)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmnewemployeeentry"
        Me.Text = "Newempentry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbodepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtempid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnmale As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbtnfemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtresidentalno As System.Windows.Forms.TextBox
    Friend WithEvents cbobloodgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtqualification As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtmobileno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents dtpbirth_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpdate_of_leaving As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdat_of_joining As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtgrosssalary As System.Windows.Forms.TextBox
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbodesignation As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndetails As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents cboempid As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents txtDA As System.Windows.Forms.TextBox
    Friend WithEvents txtTA As System.Windows.Forms.TextBox
    Friend WithEvents txtPF As System.Windows.Forms.TextBox
    Friend WithEvents txtPT As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtHRA As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
