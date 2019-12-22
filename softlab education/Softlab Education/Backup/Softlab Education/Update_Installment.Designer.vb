<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Installment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Installment))
        Me.txt_bal = New System.Windows.Forms.TextBox
        Me.txttotal_amt = New System.Windows.Forms.TextBox
        Me.txt_install = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_remaning = New System.Windows.Forms.TextBox
        Me.txtamt_pay = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtstud_mname = New System.Windows.Forms.TextBox
        Me.txtstud_fname = New System.Windows.Forms.TextBox
        Me.txttotal_fee = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtc_name = New System.Windows.Forms.TextBox
        Me.txtc_id = New System.Windows.Forms.TextBox
        Me.txtstud_lname = New System.Windows.Forms.TextBox
        Me.txtstud_id = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btndel = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_bal
        '
        Me.txt_bal.Location = New System.Drawing.Point(194, 141)
        Me.txt_bal.Multiline = True
        Me.txt_bal.Name = "txt_bal"
        Me.txt_bal.Size = New System.Drawing.Size(193, 30)
        Me.txt_bal.TabIndex = 5
        '
        'txttotal_amt
        '
        Me.txttotal_amt.Location = New System.Drawing.Point(194, 89)
        Me.txttotal_amt.Multiline = True
        Me.txttotal_amt.Name = "txttotal_amt"
        Me.txttotal_amt.Size = New System.Drawing.Size(193, 31)
        Me.txttotal_amt.TabIndex = 4
        '
        'txt_install
        '
        Me.txt_install.Location = New System.Drawing.Point(194, 32)
        Me.txt_install.Multiline = True
        Me.txt_install.Name = "txt_install"
        Me.txt_install.Size = New System.Drawing.Size(193, 32)
        Me.txt_install.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.txt_bal)
        Me.GroupBox3.Controls.Add(Me.txttotal_amt)
        Me.GroupBox3.Controls.Add(Me.txt_install)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(696, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(511, 180)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Balance :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Total amount pay:-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Installment :-"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(194, 130)
        Me.txt_amount.Multiline = True
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(193, 30)
        Me.txt_amount.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.txt_amount)
        Me.GroupBox2.Controls.Add(Me.txt_remaning)
        Me.GroupBox2.Controls.Add(Me.txtamt_pay)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(696, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 180)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'txt_remaning
        '
        Me.txt_remaning.Location = New System.Drawing.Point(194, 80)
        Me.txt_remaning.Multiline = True
        Me.txt_remaning.Name = "txt_remaning"
        Me.txt_remaning.Size = New System.Drawing.Size(193, 31)
        Me.txt_remaning.TabIndex = 4
        '
        'txtamt_pay
        '
        Me.txtamt_pay.Location = New System.Drawing.Point(194, 32)
        Me.txtamt_pay.Multiline = True
        Me.txtamt_pay.Name = "txtamt_pay"
        Me.txtamt_pay.Size = New System.Drawing.Size(193, 32)
        Me.txtamt_pay.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Amount :-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 22)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Remaning :-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Amount Paid :-"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtstud_mname)
        Me.GroupBox1.Controls.Add(Me.txtstud_fname)
        Me.GroupBox1.Controls.Add(Me.txttotal_fee)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtc_name)
        Me.GroupBox1.Controls.Add(Me.txtc_id)
        Me.GroupBox1.Controls.Add(Me.txtstud_lname)
        Me.GroupBox1.Controls.Add(Me.txtstud_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(144, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 378)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(135, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 22)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Last Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(402, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 22)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Middle Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(266, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 22)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "First Name"
        '
        'txtstud_mname
        '
        Me.txtstud_mname.Location = New System.Drawing.Point(406, 92)
        Me.txtstud_mname.Multiline = True
        Me.txtstud_mname.Name = "txtstud_mname"
        Me.txtstud_mname.Size = New System.Drawing.Size(116, 31)
        Me.txtstud_mname.TabIndex = 11
        '
        'txtstud_fname
        '
        Me.txtstud_fname.Location = New System.Drawing.Point(270, 92)
        Me.txtstud_fname.Multiline = True
        Me.txtstud_fname.Name = "txtstud_fname"
        Me.txtstud_fname.Size = New System.Drawing.Size(116, 31)
        Me.txtstud_fname.TabIndex = 10
        '
        'txttotal_fee
        '
        Me.txttotal_fee.Location = New System.Drawing.Point(139, 298)
        Me.txttotal_fee.Multiline = True
        Me.txttotal_fee.Name = "txttotal_fee"
        Me.txttotal_fee.Size = New System.Drawing.Size(193, 34)
        Me.txttotal_fee.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Fees :-"
        '
        'txtc_name
        '
        Me.txtc_name.Location = New System.Drawing.Point(139, 221)
        Me.txtc_name.Multiline = True
        Me.txtc_name.Name = "txtc_name"
        Me.txtc_name.Size = New System.Drawing.Size(193, 34)
        Me.txtc_name.TabIndex = 7
        '
        'txtc_id
        '
        Me.txtc_id.Location = New System.Drawing.Point(139, 170)
        Me.txtc_id.Multiline = True
        Me.txtc_id.Name = "txtc_id"
        Me.txtc_id.Size = New System.Drawing.Size(193, 30)
        Me.txtc_id.TabIndex = 5
        '
        'txtstud_lname
        '
        Me.txtstud_lname.Location = New System.Drawing.Point(139, 96)
        Me.txtstud_lname.Multiline = True
        Me.txtstud_lname.Name = "txtstud_lname"
        Me.txtstud_lname.Size = New System.Drawing.Size(116, 31)
        Me.txtstud_lname.TabIndex = 4
        '
        'txtstud_id
        '
        Me.txtstud_id.Location = New System.Drawing.Point(139, 42)
        Me.txtstud_id.Multiline = True
        Me.txtstud_id.Name = "txtstud_id"
        Me.txtstud_id.Size = New System.Drawing.Size(193, 32)
        Me.txtstud_id.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 233)
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
        Me.Label3.Location = New System.Drawing.Point(20, 167)
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
        Me.Label2.Location = New System.Drawing.Point(20, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "stud Name :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stud Id :-"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(437, 42)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.btndel)
        Me.GroupBox4.Controls.Add(Me.btnedit)
        Me.GroupBox4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(491, 557)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(612, 114)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Operations"
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(261, 42)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(98, 41)
        Me.btndel.TabIndex = 2
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(77, 42)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(98, 41)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "&Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(491, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(359, 59)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Installment Details"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Update_Installment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 718)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Update_Installment"
        Me.Text = "Update_Installment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_bal As System.Windows.Forms.TextBox
    Friend WithEvents txttotal_amt As System.Windows.Forms.TextBox
    Friend WithEvents txt_install As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_remaning As System.Windows.Forms.TextBox
    Friend WithEvents txtamt_pay As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtstud_mname As System.Windows.Forms.TextBox
    Friend WithEvents txtstud_fname As System.Windows.Forms.TextBox
    Friend WithEvents txttotal_fee As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtc_name As System.Windows.Forms.TextBox
    Friend WithEvents txtc_id As System.Windows.Forms.TextBox
    Friend WithEvents txtstud_lname As System.Windows.Forms.TextBox
    Friend WithEvents txtstud_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
