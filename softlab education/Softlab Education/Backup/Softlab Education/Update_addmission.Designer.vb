﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_addmission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_addmission))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbstud_id = New System.Windows.Forms.ComboBox
        Me.txtstud_age = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cbo_gen = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbofee_detail = New System.Windows.Forms.ComboBox
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtstud_mname = New System.Windows.Forms.TextBox
        Me.txtstud_lname = New System.Windows.Forms.TextBox
        Me.txtadvance = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttotal_fee = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtstud_fname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.cmbb_id = New System.Windows.Forms.ComboBox
        Me.txtb_name = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmbc_id = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtc_name = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.batch_delete = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cmbstud_id)
        Me.GroupBox1.Controls.Add(Me.txtstud_age)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cbo_gen)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbofee_detail)
        Me.GroupBox1.Controls.Add(Me.txtbalance)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtstud_mname)
        Me.GroupBox1.Controls.Add(Me.txtstud_lname)
        Me.GroupBox1.Controls.Add(Me.txtadvance)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txttotal_fee)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtstud_fname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(97, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 449)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stud_details"
        '
        'cmbstud_id
        '
        Me.cmbstud_id.FormattingEnabled = True
        Me.cmbstud_id.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbstud_id.Location = New System.Drawing.Point(141, 42)
        Me.cmbstud_id.Name = "cmbstud_id"
        Me.cmbstud_id.Size = New System.Drawing.Size(169, 30)
        Me.cmbstud_id.TabIndex = 1
        '
        'txtstud_age
        '
        Me.txtstud_age.Location = New System.Drawing.Point(141, 157)
        Me.txtstud_age.MaxLength = 2
        Me.txtstud_age.Multiline = True
        Me.txtstud_age.Name = "txtstud_age"
        Me.txtstud_age.Size = New System.Drawing.Size(184, 31)
        Me.txtstud_age.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 157)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 22)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Age :-"
        '
        'cbo_gen
        '
        Me.cbo_gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_gen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_gen.FormattingEnabled = True
        Me.cbo_gen.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbo_gen.Location = New System.Drawing.Point(141, 210)
        Me.cbo_gen.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_gen.Name = "cbo_gen"
        Me.cbo_gen.Size = New System.Drawing.Size(138, 27)
        Me.cbo_gen.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 201)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 22)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Gender  :-"
        '
        'cbofee_detail
        '
        Me.cbofee_detail.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofee_detail.FormattingEnabled = True
        Me.cbofee_detail.Items.AddRange(New Object() {"Installment", "Full"})
        Me.cbofee_detail.Location = New System.Drawing.Point(142, 303)
        Me.cbofee_detail.Name = "cbofee_detail"
        Me.cbofee_detail.Size = New System.Drawing.Size(192, 30)
        Me.cbofee_detail.TabIndex = 8
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(142, 386)
        Me.txtbalance.Multiline = True
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(193, 34)
        Me.txtbalance.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 22)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Balance :-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(536, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 22)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Last Name "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(338, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 22)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Middle Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(161, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 22)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "First Name"
        '
        'txtstud_mname
        '
        Me.txtstud_mname.Location = New System.Drawing.Point(323, 95)
        Me.txtstud_mname.Multiline = True
        Me.txtstud_mname.Name = "txtstud_mname"
        Me.txtstud_mname.Size = New System.Drawing.Size(165, 31)
        Me.txtstud_mname.TabIndex = 3
        '
        'txtstud_lname
        '
        Me.txtstud_lname.Location = New System.Drawing.Point(504, 95)
        Me.txtstud_lname.Multiline = True
        Me.txtstud_lname.Name = "txtstud_lname"
        Me.txtstud_lname.Size = New System.Drawing.Size(165, 31)
        Me.txtstud_lname.TabIndex = 4
        '
        'txtadvance
        '
        Me.txtadvance.Location = New System.Drawing.Point(141, 343)
        Me.txtadvance.Multiline = True
        Me.txtadvance.Name = "txtadvance"
        Me.txtadvance.Size = New System.Drawing.Size(193, 34)
        Me.txtadvance.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Advance :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fee Pay :-"
        '
        'txttotal_fee
        '
        Me.txttotal_fee.Location = New System.Drawing.Point(141, 255)
        Me.txttotal_fee.Multiline = True
        Me.txttotal_fee.Name = "txttotal_fee"
        Me.txttotal_fee.Size = New System.Drawing.Size(193, 34)
        Me.txttotal_fee.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Fee :-"
        '
        'txtstud_fname
        '
        Me.txtstud_fname.Location = New System.Drawing.Point(141, 95)
        Me.txtstud_fname.Multiline = True
        Me.txtstud_fname.Name = "txtstud_fname"
        Me.txtstud_fname.Size = New System.Drawing.Size(165, 31)
        Me.txtstud_fname.TabIndex = 2
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
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(172, 150)
        Me.dtp.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(177, 26)
        Me.dtp.TabIndex = 13
        '
        'cmbb_id
        '
        Me.cmbb_id.FormattingEnabled = True
        Me.cmbb_id.Items.AddRange(New Object() {"1", "2", "4", "5"})
        Me.cmbb_id.Location = New System.Drawing.Point(155, 42)
        Me.cmbb_id.Name = "cmbb_id"
        Me.cmbb_id.Size = New System.Drawing.Size(169, 30)
        Me.cmbb_id.TabIndex = 11
        '
        'txtb_name
        '
        Me.txtb_name.Location = New System.Drawing.Point(172, 89)
        Me.txtb_name.Multiline = True
        Me.txtb_name.Name = "txtb_name"
        Me.txtb_name.Size = New System.Drawing.Size(177, 31)
        Me.txtb_name.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(52, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 22)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Batch Time :-"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.cmbb_id)
        Me.GroupBox3.Controls.Add(Me.dtp)
        Me.GroupBox3.Controls.Add(Me.txtb_name)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(853, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 207)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Batch_details"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(52, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 22)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Batch Name :-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(52, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 22)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Batch Id :-"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.cmbc_id)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtc_name)
        Me.GroupBox4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(853, 348)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 207)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Course_details"
        '
        'cmbc_id
        '
        Me.cmbc_id.FormattingEnabled = True
        Me.cmbc_id.Items.AddRange(New Object() {"1", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbc_id.Location = New System.Drawing.Point(155, 46)
        Me.cmbc_id.Name = "cmbc_id"
        Me.cmbc_id.Size = New System.Drawing.Size(169, 30)
        Me.cmbc_id.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course Id :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course Name :-"
        '
        'txtc_name
        '
        Me.txtc_name.Location = New System.Drawing.Point(156, 104)
        Me.txtc_name.Multiline = True
        Me.txtc_name.Name = "txtc_name"
        Me.txtc_name.Size = New System.Drawing.Size(193, 34)
        Me.txtc_name.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(565, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(359, 59)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Addmission Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.batch_delete)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(491, 582)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 114)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operations"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(431, 42)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'batch_delete
        '
        Me.batch_delete.Location = New System.Drawing.Point(255, 42)
        Me.batch_delete.Name = "batch_delete"
        Me.batch_delete.Size = New System.Drawing.Size(98, 41)
        Me.batch_delete.TabIndex = 2
        Me.batch_delete.Text = "Delete"
        Me.batch_delete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(76, 42)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(98, 41)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "&Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Update_addmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Softlab_Education.My.Resources.Resources.images__9_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 722)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Update_addmission"
        Me.Text = "Update_addmission"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbstud_id As System.Windows.Forms.ComboBox
    Friend WithEvents txtstud_age As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbo_gen As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbofee_detail As System.Windows.Forms.ComboBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtstud_mname As System.Windows.Forms.TextBox
    Friend WithEvents txtstud_lname As System.Windows.Forms.TextBox
    Friend WithEvents txtadvance As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttotal_fee As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtstud_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbb_id As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_name As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbc_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtc_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents batch_delete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
End Class
