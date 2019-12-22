<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt_details
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt_details))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_clr = New System.Windows.Forms.Button
        Me.btn_add = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbo_studid = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.stud_fname = New System.Windows.Forms.Label
        Me.txtstud_fname = New System.Windows.Forms.TextBox
        Me.txtstud_mname = New System.Windows.Forms.TextBox
        Me.txtamt_pay = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtc_name = New System.Windows.Forms.TextBox
        Me.txtc_id = New System.Windows.Forms.TextBox
        Me.txtstud_lname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtbalence = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttotle = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.btn_close)
        Me.GroupBox2.Controls.Add(Me.btn_clr)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(302, 501)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(752, 114)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operations"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(578, 42)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(98, 41)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(358, 42)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(98, 41)
        Me.btn_clr.TabIndex = 2
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(160, 42)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(98, 41)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "&Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txttotle)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtbalence)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbo_studid)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.stud_fname)
        Me.GroupBox1.Controls.Add(Me.txtstud_fname)
        Me.GroupBox1.Controls.Add(Me.txtstud_mname)
        Me.GroupBox1.Controls.Add(Me.txtamt_pay)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtc_name)
        Me.GroupBox1.Controls.Add(Me.txtc_id)
        Me.GroupBox1.Controls.Add(Me.txtstud_lname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 370)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cbo_studid
        '
        Me.cbo_studid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_studid.FormattingEnabled = True
        Me.cbo_studid.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbo_studid.Location = New System.Drawing.Point(194, 25)
        Me.cbo_studid.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_studid.Name = "cbo_studid"
        Me.cbo_studid.Size = New System.Drawing.Size(138, 27)
        Me.cbo_studid.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(544, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 22)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Last Name "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(387, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 22)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Middle Name"
        '
        'stud_fname
        '
        Me.stud_fname.AutoSize = True
        Me.stud_fname.BackColor = System.Drawing.Color.Transparent
        Me.stud_fname.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stud_fname.Location = New System.Drawing.Point(218, 107)
        Me.stud_fname.Name = "stud_fname"
        Me.stud_fname.Size = New System.Drawing.Size(88, 22)
        Me.stud_fname.TabIndex = 24
        Me.stud_fname.Text = "First Name"
        '
        'txtstud_fname
        '
        Me.txtstud_fname.Location = New System.Drawing.Point(362, 73)
        Me.txtstud_fname.Multiline = True
        Me.txtstud_fname.Name = "txtstud_fname"
        Me.txtstud_fname.Size = New System.Drawing.Size(145, 31)
        Me.txtstud_fname.TabIndex = 11
        '
        'txtstud_mname
        '
        Me.txtstud_mname.Location = New System.Drawing.Point(533, 73)
        Me.txtstud_mname.Multiline = True
        Me.txtstud_mname.Name = "txtstud_mname"
        Me.txtstud_mname.Size = New System.Drawing.Size(138, 31)
        Me.txtstud_mname.TabIndex = 10
        '
        'txtamt_pay
        '
        Me.txtamt_pay.Location = New System.Drawing.Point(194, 222)
        Me.txtamt_pay.Multiline = True
        Me.txtamt_pay.Name = "txtamt_pay"
        Me.txtamt_pay.Size = New System.Drawing.Size(142, 34)
        Me.txtamt_pay.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Amount Pay :-"
        '
        'txtc_name
        '
        Me.txtc_name.Location = New System.Drawing.Point(194, 170)
        Me.txtc_name.Multiline = True
        Me.txtc_name.Name = "txtc_name"
        Me.txtc_name.Size = New System.Drawing.Size(142, 34)
        Me.txtc_name.TabIndex = 7
        '
        'txtc_id
        '
        Me.txtc_id.Location = New System.Drawing.Point(194, 134)
        Me.txtc_id.Multiline = True
        Me.txtc_id.Name = "txtc_id"
        Me.txtc_id.Size = New System.Drawing.Size(142, 30)
        Me.txtc_id.TabIndex = 5
        '
        'txtstud_lname
        '
        Me.txtstud_lname.Location = New System.Drawing.Point(194, 73)
        Me.txtstud_lname.Multiline = True
        Me.txtstud_lname.Name = "txtstud_lname"
        Me.txtstud_lname.Size = New System.Drawing.Size(142, 31)
        Me.txtstud_lname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course Name :-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course Id :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stud Name :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stud Id :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(615, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 59)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Receipt Details"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 22)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Balence :-"
        '
        'txtbalence
        '
        Me.txtbalence.Location = New System.Drawing.Point(194, 268)
        Me.txtbalence.Multiline = True
        Me.txtbalence.Name = "txtbalence"
        Me.txtbalence.Size = New System.Drawing.Size(142, 34)
        Me.txtbalence.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 22)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Totle fee :-"
        '
        'txttotle
        '
        Me.txttotle.Location = New System.Drawing.Point(194, 316)
        Me.txttotle.Multiline = True
        Me.txttotle.Name = "txttotle"
        Me.txttotle.Size = New System.Drawing.Size(142, 34)
        Me.txttotle.TabIndex = 31
        '
        'Receipt_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Softlab_Education.My.Resources.Resources.images__9_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1341, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Receipt_details"
        Me.Text = "Recipt_details"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_clr As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamt_pay As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtc_name As System.Windows.Forms.TextBox
    Friend WithEvents txtc_id As System.Windows.Forms.TextBox
    Friend WithEvents txtstud_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtstud_fname As System.Windows.Forms.TextBox
    Friend WithEvents txtstud_mname As System.Windows.Forms.TextBox
    Friend WithEvents stud_fname As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbo_studid As System.Windows.Forms.ComboBox
    Friend WithEvents txtbalence As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttotle As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
