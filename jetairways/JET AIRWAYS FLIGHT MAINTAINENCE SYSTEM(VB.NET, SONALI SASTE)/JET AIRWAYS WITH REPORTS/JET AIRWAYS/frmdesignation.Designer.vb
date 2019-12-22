<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdesignation
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnback = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnview = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbodesignationname = New System.Windows.Forms.ComboBox
        Me.txtTA = New System.Windows.Forms.TextBox
        Me.txtDA = New System.Windows.Forms.TextBox
        Me.txtHRA = New System.Windows.Forms.TextBox
        Me.txtotpershift = New System.Windows.Forms.TextBox
        Me.txtPF = New System.Windows.Forms.TextBox
        Me.txtdeductionperextraleaves = New System.Windows.Forms.TextBox
        Me.txtgrosssalary = New System.Windows.Forms.TextBox
        Me.txtpayleaves = New System.Windows.Forms.TextBox
        Me.txtdepartmentname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JET_AIRWAYS.My.Resources.Resources.Jet_Airways_Banner_1_3
        Me.PictureBox1.Location = New System.Drawing.Point(-1146, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3026, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 500)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnback)
        Me.GroupBox3.Controls.Add(Me.btnexit)
        Me.GroupBox3.Controls.Add(Me.btnclear)
        Me.GroupBox3.Controls.Add(Me.btnview)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(25, 395)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(599, 99)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(478, 19)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 53)
        Me.btnback.TabIndex = 4
        Me.btnback.Text = "&Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(362, 19)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 53)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(249, 19)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 53)
        Me.btnclear.TabIndex = 2
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(127, 19)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 53)
        Me.btnview.TabIndex = 1
        Me.btnview.Text = "&View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(20, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 53)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbodesignationname)
        Me.GroupBox2.Controls.Add(Me.txtTA)
        Me.GroupBox2.Controls.Add(Me.txtDA)
        Me.GroupBox2.Controls.Add(Me.txtHRA)
        Me.GroupBox2.Controls.Add(Me.txtotpershift)
        Me.GroupBox2.Controls.Add(Me.txtPF)
        Me.GroupBox2.Controls.Add(Me.txtdeductionperextraleaves)
        Me.GroupBox2.Controls.Add(Me.txtgrosssalary)
        Me.GroupBox2.Controls.Add(Me.txtpayleaves)
        Me.GroupBox2.Controls.Add(Me.txtdepartmentname)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 357)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Designation Data"
        '
        'cbodesignationname
        '
        Me.cbodesignationname.FormattingEnabled = True
        Me.cbodesignationname.Location = New System.Drawing.Point(271, 59)
        Me.cbodesignationname.Name = "cbodesignationname"
        Me.cbodesignationname.Size = New System.Drawing.Size(153, 21)
        Me.cbodesignationname.TabIndex = 19
        '
        'txtTA
        '
        Me.txtTA.Location = New System.Drawing.Point(271, 313)
        Me.txtTA.Name = "txtTA"
        Me.txtTA.Size = New System.Drawing.Size(153, 20)
        Me.txtTA.TabIndex = 18
        '
        'txtDA
        '
        Me.txtDA.Location = New System.Drawing.Point(271, 272)
        Me.txtDA.Name = "txtDA"
        Me.txtDA.Size = New System.Drawing.Size(153, 20)
        Me.txtDA.TabIndex = 17
        '
        'txtHRA
        '
        Me.txtHRA.Location = New System.Drawing.Point(271, 238)
        Me.txtHRA.Name = "txtHRA"
        Me.txtHRA.Size = New System.Drawing.Size(153, 20)
        Me.txtHRA.TabIndex = 16
        '
        'txtotpershift
        '
        Me.txtotpershift.Location = New System.Drawing.Point(271, 148)
        Me.txtotpershift.Name = "txtotpershift"
        Me.txtotpershift.Size = New System.Drawing.Size(153, 20)
        Me.txtotpershift.TabIndex = 15
        '
        'txtPF
        '
        Me.txtPF.Location = New System.Drawing.Point(271, 206)
        Me.txtPF.Name = "txtPF"
        Me.txtPF.Size = New System.Drawing.Size(153, 20)
        Me.txtPF.TabIndex = 14
        '
        'txtdeductionperextraleaves
        '
        Me.txtdeductionperextraleaves.Location = New System.Drawing.Point(271, 177)
        Me.txtdeductionperextraleaves.Name = "txtdeductionperextraleaves"
        Me.txtdeductionperextraleaves.Size = New System.Drawing.Size(153, 20)
        Me.txtdeductionperextraleaves.TabIndex = 13
        '
        'txtgrosssalary
        '
        Me.txtgrosssalary.Location = New System.Drawing.Point(271, 86)
        Me.txtgrosssalary.Name = "txtgrosssalary"
        Me.txtgrosssalary.Size = New System.Drawing.Size(153, 20)
        Me.txtgrosssalary.TabIndex = 12
        '
        'txtpayleaves
        '
        Me.txtpayleaves.Location = New System.Drawing.Point(271, 112)
        Me.txtpayleaves.Name = "txtpayleaves"
        Me.txtpayleaves.Size = New System.Drawing.Size(153, 20)
        Me.txtpayleaves.TabIndex = 12
        '
        'txtdepartmentname
        '
        Me.txtdepartmentname.Location = New System.Drawing.Point(271, 24)
        Me.txtdepartmentname.Name = "txtdepartmentname"
        Me.txtdepartmentname.Size = New System.Drawing.Size(153, 20)
        Me.txtdepartmentname.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(169, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "TA :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(169, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DA :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(169, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "HRA :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PF :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Deduction per Extra Leaves :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OT Per Shift :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pay Leaves :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gross Salary :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Designation Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department Name :"
        '
        'frmdesignation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 578)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmdesignation"
        Me.Text = "Designation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtotpershift As System.Windows.Forms.TextBox
    Friend WithEvents txtPF As System.Windows.Forms.TextBox
    Friend WithEvents txtdeductionperextraleaves As System.Windows.Forms.TextBox
    Friend WithEvents txtgrosssalary As System.Windows.Forms.TextBox
    Friend WithEvents txtpayleaves As System.Windows.Forms.TextBox
    Friend WithEvents txtdepartmentname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTA As System.Windows.Forms.TextBox
    Friend WithEvents txtDA As System.Windows.Forms.TextBox
    Friend WithEvents txtHRA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbodesignationname As System.Windows.Forms.ComboBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
