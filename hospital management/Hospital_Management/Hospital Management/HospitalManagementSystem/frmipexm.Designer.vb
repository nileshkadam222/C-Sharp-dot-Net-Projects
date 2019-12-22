<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmipexm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmipexm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboPCode = New System.Windows.Forms.ComboBox
        Me.txtPName = New System.Windows.Forms.TextBox
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.txtAdDate = New System.Windows.Forms.TextBox
        Me.txtTreateDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DTPBillDt = New System.Windows.Forms.DateTimePicker
        Me.cboTerms = New System.Windows.Forms.ComboBox
        Me.txtbill = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpTstDate = New System.Windows.Forms.DateTimePicker
        Me.txttotamt = New System.Windows.Forms.TextBox
        Me.txtdis = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.cboTestCond = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtgrndtot = New System.Windows.Forms.TextBox
        Me.txtdisgvn = New System.Windows.Forms.TextBox
        Me.txtpayable = New System.Windows.Forms.TextBox
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.Command4 = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IN PATIENTS EXAM DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(24, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(24, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name of Patient"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(24, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Doctor Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(24, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Admission"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(24, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Treatment Date"
        '
        'cboPCode
        '
        Me.cboPCode.FormattingEnabled = True
        Me.cboPCode.Location = New System.Drawing.Point(143, 170)
        Me.cboPCode.Name = "cboPCode"
        Me.cboPCode.Size = New System.Drawing.Size(198, 21)
        Me.cboPCode.TabIndex = 1
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(143, 209)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.ReadOnly = True
        Me.txtPName.Size = New System.Drawing.Size(198, 20)
        Me.txtPName.TabIndex = 7
        Me.txtPName.TabStop = False
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(143, 248)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.ReadOnly = True
        Me.txtDName.Size = New System.Drawing.Size(198, 20)
        Me.txtDName.TabIndex = 8
        Me.txtDName.TabStop = False
        '
        'txtAdDate
        '
        Me.txtAdDate.Location = New System.Drawing.Point(143, 287)
        Me.txtAdDate.Name = "txtAdDate"
        Me.txtAdDate.ReadOnly = True
        Me.txtAdDate.Size = New System.Drawing.Size(198, 20)
        Me.txtAdDate.TabIndex = 9
        Me.txtAdDate.TabStop = False
        '
        'txtTreateDate
        '
        Me.txtTreateDate.Location = New System.Drawing.Point(143, 326)
        Me.txtTreateDate.Name = "txtTreateDate"
        Me.txtTreateDate.ReadOnly = True
        Me.txtTreateDate.Size = New System.Drawing.Size(198, 20)
        Me.txtTreateDate.TabIndex = 10
        Me.txtTreateDate.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(371, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Bill No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(548, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Bill Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(737, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Terms"
        '
        'DTPBillDt
        '
        Me.DTPBillDt.CustomFormat = "dd/MM/yyyy"
        Me.DTPBillDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBillDt.Location = New System.Drawing.Point(610, 167)
        Me.DTPBillDt.Name = "DTPBillDt"
        Me.DTPBillDt.Size = New System.Drawing.Size(120, 20)
        Me.DTPBillDt.TabIndex = 3
        '
        'cboTerms
        '
        Me.cboTerms.FormattingEnabled = True
        Me.cboTerms.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.cboTerms.Location = New System.Drawing.Point(777, 166)
        Me.cboTerms.Name = "cboTerms"
        Me.cboTerms.Size = New System.Drawing.Size(120, 21)
        Me.cboTerms.TabIndex = 4
        '
        'txtbill
        '
        Me.txtbill.Location = New System.Drawing.Point(416, 168)
        Me.txtbill.Name = "txtbill"
        Me.txtbill.ReadOnly = True
        Me.txtbill.Size = New System.Drawing.Size(120, 20)
        Me.txtbill.TabIndex = 2
        Me.txtbill.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpTstDate)
        Me.GroupBox1.Controls.Add(Me.txttotamt)
        Me.GroupBox1.Controls.Add(Me.txtdis)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txtResult)
        Me.GroupBox1.Controls.Add(Me.txtamt)
        Me.GroupBox1.Controls.Add(Me.cboTestCond)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 102)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Details"
        '
        'dtpTstDate
        '
        Me.dtpTstDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTstDate.Location = New System.Drawing.Point(334, 31)
        Me.dtpTstDate.Name = "dtpTstDate"
        Me.dtpTstDate.Size = New System.Drawing.Size(83, 20)
        Me.dtpTstDate.TabIndex = 7
        '
        'txttotamt
        '
        Me.txttotamt.Location = New System.Drawing.Point(511, 68)
        Me.txttotamt.Name = "txttotamt"
        Me.txttotamt.ReadOnly = True
        Me.txttotamt.Size = New System.Drawing.Size(131, 20)
        Me.txttotamt.TabIndex = 11
        Me.txttotamt.TabStop = False
        '
        'txtdis
        '
        Me.txtdis.Location = New System.Drawing.Point(334, 67)
        Me.txtdis.Name = "txtdis"
        Me.txtdis.Size = New System.Drawing.Size(83, 20)
        Me.txtdis.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(97, 158)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 8
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(511, 31)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(131, 20)
        Me.txtResult.TabIndex = 8
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(103, 66)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(160, 20)
        Me.txtamt.TabIndex = 9
        '
        'cboTestCond
        '
        Me.cboTestCond.FormattingEnabled = True
        Me.cboTestCond.Location = New System.Drawing.Point(103, 31)
        Me.cboTestCond.Name = "cboTestCond"
        Me.cboTestCond.Size = New System.Drawing.Size(160, 21)
        Me.cboTestCond.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(424, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Total Amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(270, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Discount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(269, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Test Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(423, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Test Result"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(45, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Amount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(7, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Test Conducted"
        '
        'Image1
        '
        Me.Image1.Location = New System.Drawing.Point(27, 387)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(378, 206)
        Me.Image1.TabIndex = 18
        Me.Image1.TabStop = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.Navy
        Me.cmdAdd.Location = New System.Drawing.Point(554, 302)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(121, 23)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Text = "&SAVE"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Command2
        '
        Me.Command2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.Color.Navy
        Me.Command2.Location = New System.Drawing.Point(691, 302)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(121, 23)
        Me.Command2.TabIndex = 13
        Me.Command2.Text = "&CLEAR"
        Me.Command2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(557, 366)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 15)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Grand Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(557, 400)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 15)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Discount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(557, 438)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 15)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Net Payable"
        '
        'txtgrndtot
        '
        Me.txtgrndtot.Location = New System.Drawing.Point(660, 363)
        Me.txtgrndtot.Name = "txtgrndtot"
        Me.txtgrndtot.Size = New System.Drawing.Size(152, 20)
        Me.txtgrndtot.TabIndex = 14
        '
        'txtdisgvn
        '
        Me.txtdisgvn.Location = New System.Drawing.Point(660, 400)
        Me.txtdisgvn.Name = "txtdisgvn"
        Me.txtdisgvn.Size = New System.Drawing.Size(152, 20)
        Me.txtdisgvn.TabIndex = 15
        '
        'txtpayable
        '
        Me.txtpayable.Location = New System.Drawing.Point(660, 438)
        Me.txtpayable.Name = "txtpayable"
        Me.txtpayable.ReadOnly = True
        Me.txtpayable.Size = New System.Drawing.Size(152, 20)
        Me.txtpayable.TabIndex = 16
        Me.txtpayable.TabStop = False
        '
        'cmdCreate
        '
        Me.cmdCreate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreate.ForeColor = System.Drawing.Color.Navy
        Me.cmdCreate.Location = New System.Drawing.Point(554, 484)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(121, 23)
        Me.cmdCreate.TabIndex = 17
        Me.cmdCreate.Text = "Create Bill"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'Command4
        '
        Me.Command4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.Color.Navy
        Me.Command4.Location = New System.Drawing.Point(691, 484)
        Me.Command4.Name = "Command4"
        Me.Command4.Size = New System.Drawing.Size(121, 23)
        Me.Command4.TabIndex = 18
        Me.Command4.Text = "CLOSE"
        Me.Command4.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(424, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(239, 26)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(851, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'frmipexm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.txtpayable)
        Me.Controls.Add(Me.txtdisgvn)
        Me.Controls.Add(Me.txtgrndtot)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbill)
        Me.Controls.Add(Me.cboTerms)
        Me.Controls.Add(Me.DTPBillDt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTreateDate)
        Me.Controls.Add(Me.txtAdDate)
        Me.Controls.Add(Me.txtDName)
        Me.Controls.Add(Me.txtPName)
        Me.Controls.Add(Me.cboPCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "frmipexm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In Patient Exams"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboPCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtPName As System.Windows.Forms.TextBox
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents txtAdDate As System.Windows.Forms.TextBox
    Friend WithEvents txtTreateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DTPBillDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTerms As System.Windows.Forms.ComboBox
    Friend WithEvents txtbill As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttotamt As System.Windows.Forms.TextBox
    Friend WithEvents txtdis As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents cboTestCond As System.Windows.Forms.ComboBox
    Friend WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Command2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtgrndtot As System.Windows.Forms.TextBox
    Friend WithEvents txtdisgvn As System.Windows.Forms.TextBox
    Friend WithEvents txtpayable As System.Windows.Forms.TextBox
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents Command4 As System.Windows.Forms.Button
    Friend WithEvents dtpTstDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
