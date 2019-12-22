<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmopdet
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmopdet))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtAdd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.txtage = New System.Windows.Forms.TextBox
        Me.cmbGndr = New System.Windows.Forms.ComboBox
        Me.cmbMarStat = New System.Windows.Forms.ComboBox
        Me.txtTelNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtbld = New System.Windows.Forms.ComboBox
        Me.cboDCode = New System.Windows.Forms.ComboBox
        Me.cmbdname = New System.Windows.Forms.TextBox
        Me.dttrmnt = New System.Windows.Forms.DateTimePicker
        Me.txtDiag = New System.Windows.Forms.TextBox
        Me.cmddiag = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdEXIT = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmbCaste = New System.Windows.Forms.TextBox
        Me.txtcode = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(221, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient's Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(220, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient's Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(551, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(221, 197)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(321, 22)
        Me.txtName.TabIndex = 2
        Me.txtName.TabStop = False
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(549, 197)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.ReadOnly = True
        Me.txtAdd.Size = New System.Drawing.Size(321, 22)
        Me.txtAdd.TabIndex = 3
        Me.txtAdd.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(754, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telephone No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(657, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Caste"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(557, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Marital Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(463, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sex"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(383, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Age"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(221, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Date of Birth"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MM/yyyy"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(221, 268)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(151, 22)
        Me.dtpDOB.TabIndex = 4
        Me.dtpDOB.TabStop = False
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(381, 269)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(69, 22)
        Me.txtage.TabIndex = 5
        Me.txtage.TabStop = False
        '
        'cmbGndr
        '
        Me.cmbGndr.FormattingEnabled = True
        Me.cmbGndr.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cmbGndr.Location = New System.Drawing.Point(457, 269)
        Me.cmbGndr.Name = "cmbGndr"
        Me.cmbGndr.Size = New System.Drawing.Size(84, 23)
        Me.cmbGndr.TabIndex = 6
        Me.cmbGndr.TabStop = False
        '
        'cmbMarStat
        '
        Me.cmbMarStat.FormattingEnabled = True
        Me.cmbMarStat.Items.AddRange(New Object() {"SINGLE", "MARRIED", "DIVORSED", "WIDOW"})
        Me.cmbMarStat.Location = New System.Drawing.Point(549, 269)
        Me.cmbMarStat.Name = "cmbMarStat"
        Me.cmbMarStat.Size = New System.Drawing.Size(104, 23)
        Me.cmbMarStat.TabIndex = 7
        Me.cmbMarStat.TabStop = False
        '
        'txtTelNo
        '
        Me.txtTelNo.Location = New System.Drawing.Point(755, 269)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.ReadOnly = True
        Me.txtTelNo.Size = New System.Drawing.Size(116, 22)
        Me.txtTelNo.TabIndex = 9
        Me.txtTelNo.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(223, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Blood Group"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(311, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Doctor Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(426, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Doctor Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(590, 321)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Date of Treatment"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(758, 320)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Diagnosis"
        '
        'txtbld
        '
        Me.txtbld.FormattingEnabled = True
        Me.txtbld.Items.AddRange(New Object() {"A", "B+", "B-", "AB", "O"})
        Me.txtbld.Location = New System.Drawing.Point(224, 340)
        Me.txtbld.Name = "txtbld"
        Me.txtbld.Size = New System.Drawing.Size(75, 23)
        Me.txtbld.TabIndex = 10
        Me.txtbld.TabStop = False
        '
        'cboDCode
        '
        Me.cboDCode.FormattingEnabled = True
        Me.cboDCode.Location = New System.Drawing.Point(310, 340)
        Me.cboDCode.Name = "cboDCode"
        Me.cboDCode.Size = New System.Drawing.Size(102, 23)
        Me.cboDCode.TabIndex = 11
        Me.cboDCode.TabStop = False
        '
        'cmbdname
        '
        Me.cmbdname.Location = New System.Drawing.Point(425, 342)
        Me.cmbdname.Name = "cmbdname"
        Me.cmbdname.ReadOnly = True
        Me.cmbdname.Size = New System.Drawing.Size(156, 22)
        Me.cmbdname.TabIndex = 12
        Me.cmbdname.TabStop = False
        '
        'dttrmnt
        '
        Me.dttrmnt.CustomFormat = "dd/MM/yyyy"
        Me.dttrmnt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttrmnt.Location = New System.Drawing.Point(590, 342)
        Me.dttrmnt.Name = "dttrmnt"
        Me.dttrmnt.Size = New System.Drawing.Size(159, 22)
        Me.dttrmnt.TabIndex = 13
        Me.dttrmnt.TabStop = False
        '
        'txtDiag
        '
        Me.txtDiag.Location = New System.Drawing.Point(757, 340)
        Me.txtDiag.Multiline = True
        Me.txtDiag.Name = "txtDiag"
        Me.txtDiag.ReadOnly = True
        Me.txtDiag.Size = New System.Drawing.Size(116, 25)
        Me.txtDiag.TabIndex = 14
        Me.txtDiag.TabStop = False
        '
        'cmddiag
        '
        Me.cmddiag.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddiag.ForeColor = System.Drawing.Color.Navy
        Me.cmddiag.Location = New System.Drawing.Point(220, 629)
        Me.cmddiag.Name = "cmddiag"
        Me.cmddiag.Size = New System.Drawing.Size(138, 23)
        Me.cmddiag.TabIndex = 29
        Me.cmddiag.Text = "&Diagnosis"
        Me.cmddiag.UseVisualStyleBackColor = True
        Me.cmddiag.Visible = False
        '
        'cmdnew
        '
        Me.cmdnew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.ForeColor = System.Drawing.Color.Navy
        Me.cmdnew.Location = New System.Drawing.Point(425, 411)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(138, 23)
        Me.cmdnew.TabIndex = 15
        Me.cmdnew.Text = "&SAVE"
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.Navy
        Me.cmdsave.Location = New System.Drawing.Point(966, 604)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(138, 23)
        Me.cmdsave.TabIndex = 31
        Me.cmdsave.Text = "&Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        Me.cmdsave.Visible = False
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEXIT.ForeColor = System.Drawing.Color.Navy
        Me.cmdEXIT.Location = New System.Drawing.Point(590, 411)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(138, 23)
        Me.cmdEXIT.TabIndex = 16
        Me.cmdEXIT.Text = "&EXIT"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(521, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 22)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Out Patient Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(481, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(239, 26)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(922, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'cmbCaste
        '
        Me.cmbCaste.Location = New System.Drawing.Point(659, 269)
        Me.cmbCaste.Name = "cmbCaste"
        Me.cmbCaste.ReadOnly = True
        Me.cmbCaste.Size = New System.Drawing.Size(90, 22)
        Me.cmbCaste.TabIndex = 8
        Me.cmbCaste.TabStop = False
        '
        'txtcode
        '
        Me.txtcode.FormattingEnabled = True
        Me.txtcode.Location = New System.Drawing.Point(221, 135)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(121, 23)
        Me.txtcode.TabIndex = 1
        '
        'frmopdet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 746)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.cmbCaste)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdnew)
        Me.Controls.Add(Me.cmddiag)
        Me.Controls.Add(Me.txtDiag)
        Me.Controls.Add(Me.dttrmnt)
        Me.Controls.Add(Me.cmbdname)
        Me.Controls.Add(Me.cboDCode)
        Me.Controls.Add(Me.txtbld)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTelNo)
        Me.Controls.Add(Me.cmbMarStat)
        Me.Controls.Add(Me.cmbGndr)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "frmopdet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Out Patients Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents cmbGndr As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarStat As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbld As System.Windows.Forms.ComboBox
    Friend WithEvents cboDCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdname As System.Windows.Forms.TextBox
    Friend WithEvents dttrmnt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiag As System.Windows.Forms.TextBox
    Friend WithEvents cmddiag As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCaste As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.ComboBox
End Class
