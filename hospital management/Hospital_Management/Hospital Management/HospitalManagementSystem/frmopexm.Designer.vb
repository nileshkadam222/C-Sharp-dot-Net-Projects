<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOPExm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOPExm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpBilldt = New System.Windows.Forms.DateTimePicker
        Me.cboTerms = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboPCode = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPName = New System.Windows.Forms.TextBox
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.txtTDate = New System.Windows.Forms.TextBox
        Me.txtAddDate = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.txttotamt = New System.Windows.Forms.TextBox
        Me.dtpExmDt = New System.Windows.Forms.DateTimePicker
        Me.txtdis = New System.Windows.Forms.TextBox
        Me.txtTRes = New System.Windows.Forms.TextBox
        Me.cboTstCond = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtGrndTot = New System.Windows.Forms.TextBox
        Me.txtDisgvn = New System.Windows.Forms.TextBox
        Me.txtPayable = New System.Windows.Forms.TextBox
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtbill = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(317, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OUT PATIENTS EXAM DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(608, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bill Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(403, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bill No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(823, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Terms"
        '
        'dtpBilldt
        '
        Me.dtpBilldt.CustomFormat = "dd/MM/yyyy"
        Me.dtpBilldt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBilldt.Location = New System.Drawing.Point(678, 230)
        Me.dtpBilldt.Name = "dtpBilldt"
        Me.dtpBilldt.Size = New System.Drawing.Size(109, 20)
        Me.dtpBilldt.TabIndex = 2
        '
        'cboTerms
        '
        Me.cboTerms.FormattingEnabled = True
        Me.cboTerms.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.cboTerms.Location = New System.Drawing.Point(882, 230)
        Me.cboTerms.Name = "cboTerms"
        Me.cboTerms.Size = New System.Drawing.Size(129, 21)
        Me.cboTerms.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(46, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Patient Code"
        '
        'cboPCode
        '
        Me.cboPCode.FormattingEnabled = True
        Me.cboPCode.Location = New System.Drawing.Point(150, 229)
        Me.cboPCode.Name = "cboPCode"
        Me.cboPCode.Size = New System.Drawing.Size(183, 21)
        Me.cboPCode.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(44, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Name of Patient"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(44, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Doctor Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(43, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Treatment Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(43, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Date of Admission"
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(150, 264)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.ReadOnly = True
        Me.txtPName.Size = New System.Drawing.Size(183, 20)
        Me.txtPName.TabIndex = 13
        Me.txtPName.TabStop = False
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(150, 293)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.ReadOnly = True
        Me.txtDName.Size = New System.Drawing.Size(183, 20)
        Me.txtDName.TabIndex = 14
        Me.txtDName.TabStop = False
        '
        'txtTDate
        '
        Me.txtTDate.Location = New System.Drawing.Point(150, 323)
        Me.txtTDate.Name = "txtTDate"
        Me.txtTDate.ReadOnly = True
        Me.txtTDate.Size = New System.Drawing.Size(183, 20)
        Me.txtTDate.TabIndex = 15
        Me.txtTDate.TabStop = False
        '
        'txtAddDate
        '
        Me.txtAddDate.Location = New System.Drawing.Point(150, 350)
        Me.txtAddDate.Name = "txtAddDate"
        Me.txtAddDate.ReadOnly = True
        Me.txtAddDate.Size = New System.Drawing.Size(183, 20)
        Me.txtAddDate.TabIndex = 16
        Me.txtAddDate.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtamt)
        Me.GroupBox1.Controls.Add(Me.txttotamt)
        Me.GroupBox1.Controls.Add(Me.dtpExmDt)
        Me.GroupBox1.Controls.Add(Me.txtdis)
        Me.GroupBox1.Controls.Add(Me.txtTRes)
        Me.GroupBox1.Controls.Add(Me.cboTstCond)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(356, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 89)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Details"
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(108, 53)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(128, 20)
        Me.txtamt.TabIndex = 8
        '
        'txttotamt
        '
        Me.txttotamt.Location = New System.Drawing.Point(527, 53)
        Me.txttotamt.Name = "txttotamt"
        Me.txttotamt.ReadOnly = True
        Me.txttotamt.Size = New System.Drawing.Size(128, 20)
        Me.txttotamt.TabIndex = 10
        Me.txttotamt.TabStop = False
        '
        'dtpExmDt
        '
        Me.dtpExmDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpExmDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExmDt.Location = New System.Drawing.Point(322, 18)
        Me.dtpExmDt.Name = "dtpExmDt"
        Me.dtpExmDt.Size = New System.Drawing.Size(109, 20)
        Me.dtpExmDt.TabIndex = 6
        '
        'txtdis
        '
        Me.txtdis.Location = New System.Drawing.Point(322, 52)
        Me.txtdis.Name = "txtdis"
        Me.txtdis.Size = New System.Drawing.Size(109, 20)
        Me.txtdis.TabIndex = 9
        '
        'txtTRes
        '
        Me.txtTRes.Location = New System.Drawing.Point(527, 19)
        Me.txtTRes.Name = "txtTRes"
        Me.txtTRes.Size = New System.Drawing.Size(128, 20)
        Me.txtTRes.TabIndex = 7
        '
        'cboTstCond
        '
        Me.cboTstCond.FormattingEnabled = True
        Me.cboTstCond.Location = New System.Drawing.Point(108, 19)
        Me.cboTstCond.Name = "cboTstCond"
        Me.cboTstCond.Size = New System.Drawing.Size(128, 21)
        Me.cboTstCond.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(440, 55)
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
        Me.Label14.Location = New System.Drawing.Point(252, 55)
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
        Me.Label13.Location = New System.Drawing.Point(440, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Test Result"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(17, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(252, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Exam Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(11, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Test Conducted"
        '
        'Image1
        '
        Me.Image1.Location = New System.Drawing.Point(32, 423)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(313, 187)
        Me.Image1.TabIndex = 12
        Me.Image1.TabStop = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.Navy
        Me.cmdAdd.Location = New System.Drawing.Point(497, 353)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(138, 23)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "&ADD TO LIST"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.Navy
        Me.cmdClear.Location = New System.Drawing.Point(707, 353)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(138, 23)
        Me.cmdClear.TabIndex = 12
        Me.cmdClear.Text = "&CLEAR"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(548, 396)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 15)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Grand Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(548, 435)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 15)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Discount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(548, 478)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 15)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Net Payable"
        '
        'txtGrndTot
        '
        Me.txtGrndTot.Location = New System.Drawing.Point(638, 394)
        Me.txtGrndTot.Name = "txtGrndTot"
        Me.txtGrndTot.Size = New System.Drawing.Size(133, 20)
        Me.txtGrndTot.TabIndex = 13
        '
        'txtDisgvn
        '
        Me.txtDisgvn.Location = New System.Drawing.Point(638, 433)
        Me.txtDisgvn.Name = "txtDisgvn"
        Me.txtDisgvn.Size = New System.Drawing.Size(133, 20)
        Me.txtDisgvn.TabIndex = 14
        '
        'txtPayable
        '
        Me.txtPayable.Location = New System.Drawing.Point(638, 473)
        Me.txtPayable.Name = "txtPayable"
        Me.txtPayable.ReadOnly = True
        Me.txtPayable.Size = New System.Drawing.Size(133, 20)
        Me.txtPayable.TabIndex = 15
        Me.txtPayable.TabStop = False
        '
        'cmdCreate
        '
        Me.cmdCreate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreate.ForeColor = System.Drawing.Color.Navy
        Me.cmdCreate.Location = New System.Drawing.Point(624, 570)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(138, 23)
        Me.cmdCreate.TabIndex = 16
        Me.cmdCreate.Text = "Create &Bill"
        Me.cmdCreate.UseVisualStyleBackColor = True
        Me.cmdCreate.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Navy
        Me.cmdClose.Location = New System.Drawing.Point(624, 515)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(138, 23)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(322, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(239, 26)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(823, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'txtbill
        '
        Me.txtbill.Location = New System.Drawing.Point(464, 228)
        Me.txtbill.Name = "txtbill"
        Me.txtbill.ReadOnly = True
        Me.txtbill.Size = New System.Drawing.Size(128, 20)
        Me.txtbill.TabIndex = 55
        Me.txtbill.TabStop = False
        '
        'frmOPExm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.txtbill)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.txtPayable)
        Me.Controls.Add(Me.txtDisgvn)
        Me.Controls.Add(Me.txtGrndTot)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAddDate)
        Me.Controls.Add(Me.txtTDate)
        Me.Controls.Add(Me.txtDName)
        Me.Controls.Add(Me.txtPName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboPCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboTerms)
        Me.Controls.Add(Me.dtpBilldt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOPExm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Out Patient Exam"
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
    Friend WithEvents dtpBilldt As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPName As System.Windows.Forms.TextBox
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents txtTDate As System.Windows.Forms.TextBox
    Friend WithEvents txtAddDate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdis As System.Windows.Forms.TextBox
    Friend WithEvents txtTRes As System.Windows.Forms.TextBox
    Friend WithEvents cboTstCond As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents txttotamt As System.Windows.Forms.TextBox
    Friend WithEvents dtpExmDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtGrndTot As System.Windows.Forms.TextBox
    Friend WithEvents txtDisgvn As System.Windows.Forms.TextBox
    Friend WithEvents txtPayable As System.Windows.Forms.TextBox
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtbill As System.Windows.Forms.TextBox
End Class
