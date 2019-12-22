<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentSlip
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cboemp = New System.Windows.Forms.ComboBox
        Me.txtcheq = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtnetsalary = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtincrement = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtsalary = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txttotal2 = New System.Windows.Forms.TextBox
        Me.txtpt = New System.Windows.Forms.TextBox
        Me.txttax = New System.Windows.Forms.TextBox
        Me.txtdeductedsalary = New System.Windows.Forms.TextBox
        Me.txtpf = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtsalovertime = New System.Windows.Forms.TextBox
        Me.txtta = New System.Windows.Forms.TextBox
        Me.txtda = New System.Windows.Forms.TextBox
        Me.txthra = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtdesignation = New System.Windows.Forms.TextBox
        Me.txtgrossSalary = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtlname = New System.Windows.Forms.TextBox
        Me.txtmname = New System.Windows.Forms.TextBox
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtdept = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(First Name)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(407, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cheque No:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "EMP ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cboemp)
        Me.GroupBox1.Controls.Add(Me.txtcheq)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(824, 45)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(243, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 25)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.Value = New Date(2011, 4, 13, 0, 0, 0, 0)
        '
        'cboemp
        '
        Me.cboemp.FormattingEnabled = True
        Me.cboemp.Location = New System.Drawing.Point(75, 14)
        Me.cboemp.Name = "cboemp"
        Me.cboemp.Size = New System.Drawing.Size(101, 25)
        Me.cboemp.TabIndex = 25
        '
        'txtcheq
        '
        Me.txtcheq.Location = New System.Drawing.Point(507, 14)
        Me.txtcheq.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcheq.Name = "txtcheq"
        Me.txtcheq.Size = New System.Drawing.Size(100, 25)
        Me.txtcheq.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnclose)
        Me.GroupBox2.Controls.Add(Me.btnback)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtdesignation)
        Me.GroupBox2.Controls.Add(Me.txtgrossSalary)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtlname)
        Me.GroupBox2.Controls.Add(Me.txtmname)
        Me.GroupBox2.Controls.Add(Me.txtfname)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 110)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(695, 396)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(240, 358)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(93, 35)
        Me.btnclose.TabIndex = 20
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(380, 361)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(97, 32)
        Me.btnback.TabIndex = 19
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(122, 358)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(92, 35)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtnetsalary)
        Me.GroupBox6.Location = New System.Drawing.Point(426, 279)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(170, 50)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Net Salary"
        '
        'txtnetsalary
        '
        Me.txtnetsalary.Location = New System.Drawing.Point(8, 17)
        Me.txtnetsalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnetsalary.Name = "txtnetsalary"
        Me.txtnetsalary.Size = New System.Drawing.Size(148, 25)
        Me.txtnetsalary.TabIndex = 28
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtincrement)
        Me.GroupBox7.Location = New System.Drawing.Point(222, 279)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(180, 50)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Increment"
        '
        'txtincrement
        '
        Me.txtincrement.Location = New System.Drawing.Point(8, 15)
        Me.txtincrement.Margin = New System.Windows.Forms.Padding(4)
        Me.txtincrement.Name = "txtincrement"
        Me.txtincrement.Size = New System.Drawing.Size(148, 25)
        Me.txtincrement.TabIndex = 27
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtsalary)
        Me.GroupBox5.Location = New System.Drawing.Point(25, 279)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(189, 50)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Salary"
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(21, 17)
        Me.txtsalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(148, 25)
        Me.txtsalary.TabIndex = 26
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txttotal2)
        Me.GroupBox4.Controls.Add(Me.txtpt)
        Me.GroupBox4.Controls.Add(Me.txttax)
        Me.GroupBox4.Controls.Add(Me.txtdeductedsalary)
        Me.GroupBox4.Controls.Add(Me.txtpf)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Location = New System.Drawing.Point(357, 90)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(354, 186)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'txttotal2
        '
        Me.txttotal2.Location = New System.Drawing.Point(173, 156)
        Me.txttotal2.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal2.Name = "txttotal2"
        Me.txttotal2.Size = New System.Drawing.Size(148, 25)
        Me.txttotal2.TabIndex = 26
        '
        'txtpt
        '
        Me.txtpt.Location = New System.Drawing.Point(171, 49)
        Me.txtpt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpt.Name = "txtpt"
        Me.txtpt.Size = New System.Drawing.Size(148, 25)
        Me.txtpt.TabIndex = 25
        '
        'txttax
        '
        Me.txttax.Location = New System.Drawing.Point(172, 116)
        Me.txttax.Margin = New System.Windows.Forms.Padding(4)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(148, 25)
        Me.txttax.TabIndex = 24
        '
        'txtdeductedsalary
        '
        Me.txtdeductedsalary.Location = New System.Drawing.Point(171, 82)
        Me.txtdeductedsalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdeductedsalary.Name = "txtdeductedsalary"
        Me.txtdeductedsalary.Size = New System.Drawing.Size(148, 25)
        Me.txtdeductedsalary.TabIndex = 23
        '
        'txtpf
        '
        Me.txtpf.Location = New System.Drawing.Point(171, 17)
        Me.txtpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpf.Name = "txtpf"
        Me.txtpf.Size = New System.Drawing.Size(148, 25)
        Me.txtpf.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(54, 58)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 17)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "PT"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(20, 82)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(145, 34)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Salary Deducted for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Leave:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(66, 164)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 17)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "TOTAL:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(35, 119)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 17)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Income Tax:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(56, 25)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 17)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "PF"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttotal)
        Me.GroupBox3.Controls.Add(Me.txtsalovertime)
        Me.GroupBox3.Controls.Add(Me.txtta)
        Me.GroupBox3.Controls.Add(Me.txtda)
        Me.GroupBox3.Controls.Add(Me.txthra)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 89)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(313, 182)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(141, 152)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(148, 25)
        Me.txttotal.TabIndex = 19
        '
        'txtsalovertime
        '
        Me.txtsalovertime.Location = New System.Drawing.Point(141, 108)
        Me.txtsalovertime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsalovertime.Name = "txtsalovertime"
        Me.txtsalovertime.Size = New System.Drawing.Size(148, 25)
        Me.txtsalovertime.TabIndex = 20
        '
        'txtta
        '
        Me.txtta.Location = New System.Drawing.Point(141, 75)
        Me.txtta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtta.Name = "txtta"
        Me.txtta.Size = New System.Drawing.Size(148, 25)
        Me.txtta.TabIndex = 21
        '
        'txtda
        '
        Me.txtda.Location = New System.Drawing.Point(141, 45)
        Me.txtda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtda.Name = "txtda"
        Me.txtda.Size = New System.Drawing.Size(148, 25)
        Me.txtda.TabIndex = 22
        '
        'txthra
        '
        Me.txthra.Location = New System.Drawing.Point(141, 17)
        Me.txthra.Margin = New System.Windows.Forms.Padding(4)
        Me.txthra.Name = "txthra"
        Me.txthra.Size = New System.Drawing.Size(148, 25)
        Me.txthra.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 157)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 17)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "TOTAL:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 108)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 34)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Salary During " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Over Time"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(46, 78)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "TA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 25)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "HRA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 48)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "DA"
        '
        'txtdesignation
        '
        Me.txtdesignation.Location = New System.Drawing.Point(144, 62)
        Me.txtdesignation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Size = New System.Drawing.Size(148, 25)
        Me.txtdesignation.TabIndex = 13
        '
        'txtgrossSalary
        '
        Me.txtgrossSalary.Location = New System.Drawing.Point(530, 62)
        Me.txtgrossSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgrossSalary.Name = "txtgrossSalary"
        Me.txtgrossSalary.Size = New System.Drawing.Size(148, 25)
        Me.txtgrossSalary.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(423, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Gross Salary:"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(530, 15)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(148, 25)
        Me.txtlname.TabIndex = 8
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(357, 15)
        Me.txtmname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(148, 25)
        Me.txtmname.TabIndex = 7
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(159, 15)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(148, 25)
        Me.txtfname.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 67)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Designation:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(372, 39)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "(Middle Name)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(557, 39)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "(Last Name)"
        '
        'txtdept
        '
        Me.txtdept.Location = New System.Drawing.Point(112, 44)
        Me.txtdept.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(115, 25)
        Me.txtdept.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(246, 9)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(457, 37)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "PAYMENT SLIP OF  EMPLOYEE"
        '
        'frmPaymentSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(733, 517)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtdept)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPaymentSlip"
        Me.Text = "Payment Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtdesignation As System.Windows.Forms.TextBox
    Friend WithEvents txtgrossSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcheq As System.Windows.Forms.TextBox
    Friend WithEvents txtnetsalary As System.Windows.Forms.TextBox
    Friend WithEvents txtincrement As System.Windows.Forms.TextBox
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents txtpt As System.Windows.Forms.TextBox
    Friend WithEvents txttax As System.Windows.Forms.TextBox
    Friend WithEvents txtdeductedsalary As System.Windows.Forms.TextBox
    Friend WithEvents txtpf As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtsalovertime As System.Windows.Forms.TextBox
    Friend WithEvents txtta As System.Windows.Forms.TextBox
    Friend WithEvents txtda As System.Windows.Forms.TextBox
    Friend WithEvents txthra As System.Windows.Forms.TextBox
    Friend WithEvents cboemp As System.Windows.Forms.ComboBox
    Friend WithEvents txtdept As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txttotal2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
