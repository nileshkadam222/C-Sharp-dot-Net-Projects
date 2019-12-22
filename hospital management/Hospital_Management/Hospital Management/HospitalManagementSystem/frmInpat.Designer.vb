<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInpat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInpat))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDOA = New System.Windows.Forms.DateTimePicker
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txttel = New System.Windows.Forms.TextBox
        Me.cbobld = New System.Windows.Forms.ComboBox
        Me.cboSex = New System.Windows.Forms.ComboBox
        Me.cboMarSts = New System.Windows.Forms.ComboBox
        Me.cboDCode = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.txtDiag = New System.Windows.Forms.TextBox
        Me.txtBDNo = New System.Windows.Forms.TextBox
        Me.txtRMRent = New System.Windows.Forms.TextBox
        Me.cboWrd = New System.Windows.Forms.ComboBox
        Me.cboRType = New System.Windows.Forms.ComboBox
        Me.lstname = New System.Windows.Forms.ListBox
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdClr = New System.Windows.Forms.Button
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.dtpTrmnt = New System.Windows.Forms.DateTimePicker
        Me.Label25 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cboCast = New System.Windows.Forms.TextBox
        Me.cboAnes = New System.Windows.Forms.TextBox
        Me.cboLBr = New System.Windows.Forms.TextBox
        Me.cbolbrCse = New System.Windows.Forms.TextBox
        Me.cboSrgry = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(542, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IN PATIENT DETAILS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDOA)
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 75)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dtpDOA
        '
        Me.dtpDOA.CustomFormat = "dd/MM/yyyy"
        Me.dtpDOA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOA.Location = New System.Drawing.Point(105, 37)
        Me.dtpDOA.Name = "dtpDOA"
        Me.dtpDOA.Size = New System.Drawing.Size(180, 22)
        Me.dtpDOA.TabIndex = 0
        Me.dtpDOA.Value = New Date(2010, 9, 3, 0, 0, 0, 0)
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(10, 39)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.ReadOnly = True
        Me.txtcode.Size = New System.Drawing.Size(83, 22)
        Me.txtcode.TabIndex = 2
        Me.txtcode.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(101, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date of Admission"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient's Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(239, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Patient's Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(239, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(239, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(239, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Age"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(239, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Caste"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(239, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Blood Group"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(239, 506)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Telephone No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(239, 547)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Sex"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(239, 585)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Marital Status"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(239, 626)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Doctor Code"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(337, 218)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(181, 22)
        Me.txtname.TabIndex = 1
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(337, 258)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(181, 22)
        Me.txtadd.TabIndex = 2
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(337, 378)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(181, 22)
        Me.txtage.TabIndex = 4
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(337, 502)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(181, 22)
        Me.txttel.TabIndex = 7
        '
        'cbobld
        '
        Me.cbobld.FormattingEnabled = True
        Me.cbobld.Items.AddRange(New Object() {"A", "B+", "B-", "AB", "O"})
        Me.cbobld.Location = New System.Drawing.Point(337, 461)
        Me.cbobld.Name = "cbobld"
        Me.cbobld.Size = New System.Drawing.Size(181, 23)
        Me.cbobld.TabIndex = 6
        '
        'cboSex
        '
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cboSex.Location = New System.Drawing.Point(337, 538)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(181, 23)
        Me.cboSex.TabIndex = 8
        '
        'cboMarSts
        '
        Me.cboMarSts.FormattingEnabled = True
        Me.cboMarSts.Items.AddRange(New Object() {"SINGLE", "MARRIED", "DIVORSED", "WIDOW"})
        Me.cboMarSts.Location = New System.Drawing.Point(337, 576)
        Me.cboMarSts.Name = "cboMarSts"
        Me.cboMarSts.Size = New System.Drawing.Size(181, 23)
        Me.cboMarSts.TabIndex = 9
        '
        'cboDCode
        '
        Me.cboDCode.FormattingEnabled = True
        Me.cboDCode.Location = New System.Drawing.Point(336, 622)
        Me.cboDCode.Name = "cboDCode"
        Me.cboDCode.Size = New System.Drawing.Size(181, 23)
        Me.cboDCode.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(582, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Doctor Incharge"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(582, 222)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 15)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Diagnosis Done"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(582, 266)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 15)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Ward Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(582, 330)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 15)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Room Type"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(582, 378)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 15)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Bed No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(582, 421)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Room Rent"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(582, 506)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 15)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Labour Room"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(582, 464)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 15)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Anesthesia Type"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(582, 541)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 15)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Labour Case"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(582, 585)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 15)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Surgery Type"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(582, 626)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(114, 15)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "Treatment Done on "
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(709, 174)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Size = New System.Drawing.Size(180, 22)
        Me.txtDName.TabIndex = 11
        '
        'txtDiag
        '
        Me.txtDiag.Location = New System.Drawing.Point(709, 218)
        Me.txtDiag.Name = "txtDiag"
        Me.txtDiag.Size = New System.Drawing.Size(180, 22)
        Me.txtDiag.TabIndex = 12
        '
        'txtBDNo
        '
        Me.txtBDNo.Location = New System.Drawing.Point(709, 374)
        Me.txtBDNo.Name = "txtBDNo"
        Me.txtBDNo.Size = New System.Drawing.Size(180, 22)
        Me.txtBDNo.TabIndex = 15
        '
        'txtRMRent
        '
        Me.txtRMRent.Location = New System.Drawing.Point(709, 418)
        Me.txtRMRent.Name = "txtRMRent"
        Me.txtRMRent.Size = New System.Drawing.Size(180, 22)
        Me.txtRMRent.TabIndex = 16
        '
        'cboWrd
        '
        Me.cboWrd.FormattingEnabled = True
        Me.cboWrd.Location = New System.Drawing.Point(709, 262)
        Me.cboWrd.Name = "cboWrd"
        Me.cboWrd.Size = New System.Drawing.Size(180, 23)
        Me.cboWrd.TabIndex = 13
        '
        'cboRType
        '
        Me.cboRType.FormattingEnabled = True
        Me.cboRType.Location = New System.Drawing.Point(709, 327)
        Me.cboRType.Name = "cboRType"
        Me.cboRType.Size = New System.Drawing.Size(180, 23)
        Me.cboRType.TabIndex = 14
        '
        'lstname
        '
        Me.lstname.FormattingEnabled = True
        Me.lstname.ItemHeight = 15
        Me.lstname.Location = New System.Drawing.Point(904, 174)
        Me.lstname.Name = "lstname"
        Me.lstname.Size = New System.Drawing.Size(165, 349)
        Me.lstname.TabIndex = 0
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(918, 581)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(151, 23)
        Me.cmdUpdate.TabIndex = 23
        Me.cmdUpdate.Text = "&EDIT"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(1030, 706)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(151, 23)
        Me.cmdSave.TabIndex = 46
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Visible = False
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(918, 544)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(151, 23)
        Me.cmdNew.TabIndex = 22
        Me.cmdNew.Text = "&NEW"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdClr
        '
        Me.cmdClr.Location = New System.Drawing.Point(918, 623)
        Me.cmdClr.Name = "cmdClr"
        Me.cmdClr.Size = New System.Drawing.Size(151, 23)
        Me.cmdClr.TabIndex = 24
        Me.cmdClr.Text = "&Clear All"
        Me.cmdClr.UseVisualStyleBackColor = True
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MM/yyyy"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(334, 326)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(184, 22)
        Me.dtpDOB.TabIndex = 3
        Me.dtpDOB.Value = New Date(2010, 9, 3, 0, 0, 0, 0)
        '
        'dtpTrmnt
        '
        Me.dtpTrmnt.CustomFormat = "dd/MM/yyyy"
        Me.dtpTrmnt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTrmnt.Location = New System.Drawing.Point(708, 620)
        Me.dtpTrmnt.Name = "dtpTrmnt"
        Me.dtpTrmnt.Size = New System.Drawing.Size(180, 22)
        Me.dtpTrmnt.TabIndex = 21
        Me.dtpTrmnt.Value = New Date(2010, 9, 3, 0, 0, 0, 0)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(495, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(239, 26)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(905, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'cboCast
        '
        Me.cboCast.Location = New System.Drawing.Point(336, 419)
        Me.cboCast.Name = "cboCast"
        Me.cboCast.Size = New System.Drawing.Size(181, 22)
        Me.cboCast.TabIndex = 5
        '
        'cboAnes
        '
        Me.cboAnes.Location = New System.Drawing.Point(709, 461)
        Me.cboAnes.Name = "cboAnes"
        Me.cboAnes.Size = New System.Drawing.Size(179, 22)
        Me.cboAnes.TabIndex = 17
        '
        'cboLBr
        '
        Me.cboLBr.Location = New System.Drawing.Point(709, 503)
        Me.cboLBr.Name = "cboLBr"
        Me.cboLBr.Size = New System.Drawing.Size(179, 22)
        Me.cboLBr.TabIndex = 18
        '
        'cbolbrCse
        '
        Me.cbolbrCse.Location = New System.Drawing.Point(709, 540)
        Me.cbolbrCse.Name = "cbolbrCse"
        Me.cbolbrCse.Size = New System.Drawing.Size(180, 22)
        Me.cbolbrCse.TabIndex = 19
        '
        'cboSrgry
        '
        Me.cboSrgry.Location = New System.Drawing.Point(709, 582)
        Me.cboSrgry.Name = "cboSrgry"
        Me.cboSrgry.Size = New System.Drawing.Size(180, 22)
        Me.cboSrgry.TabIndex = 20
        '
        'frmInpat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.cboSrgry)
        Me.Controls.Add(Me.cbolbrCse)
        Me.Controls.Add(Me.cboLBr)
        Me.Controls.Add(Me.cboAnes)
        Me.Controls.Add(Me.cboCast)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.dtpTrmnt)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.cmdClr)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.lstname)
        Me.Controls.Add(Me.cboRType)
        Me.Controls.Add(Me.cboWrd)
        Me.Controls.Add(Me.txtRMRent)
        Me.Controls.Add(Me.txtBDNo)
        Me.Controls.Add(Me.txtDiag)
        Me.Controls.Add(Me.txtDName)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboDCode)
        Me.Controls.Add(Me.cboMarSts)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.cbobld)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "frmInpat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In Patients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents cbobld As System.Windows.Forms.ComboBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents cboMarSts As System.Windows.Forms.ComboBox
    Friend WithEvents cboDCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents txtDiag As System.Windows.Forms.TextBox
    Friend WithEvents txtBDNo As System.Windows.Forms.TextBox
    Friend WithEvents txtRMRent As System.Windows.Forms.TextBox
    Friend WithEvents cboWrd As System.Windows.Forms.ComboBox
    Friend WithEvents cboRType As System.Windows.Forms.ComboBox
    Friend WithEvents lstname As System.Windows.Forms.ListBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdClr As System.Windows.Forms.Button
    Friend WithEvents dtpDOA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTrmnt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboCast As System.Windows.Forms.TextBox
    Friend WithEvents cboAnes As System.Windows.Forms.TextBox
    Friend WithEvents cboLBr As System.Windows.Forms.TextBox
    Friend WithEvents cbolbrCse As System.Windows.Forms.TextBox
    Friend WithEvents cboSrgry As System.Windows.Forms.TextBox
End Class
