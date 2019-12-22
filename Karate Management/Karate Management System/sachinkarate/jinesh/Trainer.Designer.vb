<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trainer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtjoin = New System.Windows.Forms.DateTimePicker
        Me.cbgender = New System.Windows.Forms.ComboBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtexp = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtage = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.RichTextBox
        Me.txtphno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnnew = New System.Windows.Forms.Button
        Me.btndel = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnfrst = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnprev = New System.Windows.Forms.Button
        Me.btnlast = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnexit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbbatch = New System.Windows.Forms.ComboBox
        Me.BatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet3 = New WindowsApplication1.karate1DataSet3
        Me.cbkt = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BatchTableAdapter = New WindowsApplication1.karate1DataSet3TableAdapters.batchTableAdapter
        Me.txttrainid = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.txtjoin)
        Me.GroupBox1.Controls.Add(Me.cbgender)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtexp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtphno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(423, 515)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trainer Personal Details"
        '
        'txtjoin
        '
        Me.txtjoin.Location = New System.Drawing.Point(136, 400)
        Me.txtjoin.Name = "txtjoin"
        Me.txtjoin.Size = New System.Drawing.Size(264, 24)
        Me.txtjoin.TabIndex = 19
        '
        'cbgender
        '
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Items.AddRange(New Object() {"male", "female"})
        Me.cbgender.Location = New System.Drawing.Point(136, 334)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(189, 26)
        Me.cbgender.TabIndex = 18
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(134, 51)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(189, 24)
        Me.txtname.TabIndex = 17
        '
        'txtexp
        '
        Me.txtexp.Location = New System.Drawing.Point(136, 452)
        Me.txtexp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexp.Name = "txtexp"
        Me.txtexp.Size = New System.Drawing.Size(187, 52)
        Me.txtexp.TabIndex = 15
        Me.txtexp.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 456)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "EXPERIENCE:"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(134, 282)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(189, 24)
        Me.txtage.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 400)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "JOIN DATE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 334)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "GENDER:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "AGE:"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(134, 106)
        Me.txtadd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(189, 80)
        Me.txtadd.TabIndex = 6
        Me.txtadd.Text = ""
        '
        'txtphno
        '
        Me.txtphno.Location = New System.Drawing.Point(136, 218)
        Me.txtphno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphno.MaxLength = 10
        Me.txtphno.Name = "txtphno"
        Me.txtphno.Size = New System.Drawing.Size(189, 24)
        Me.txtphno.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PHONE NO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADDRESS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnnew)
        Me.GroupBox4.Controls.Add(Me.btndel)
        Me.GroupBox4.Controls.Add(Me.btnupdate)
        Me.GroupBox4.Controls.Add(Me.btnadd)
        Me.GroupBox4.Location = New System.Drawing.Point(516, 347)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(348, 175)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "EDITOR"
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(196, 109)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(100, 28)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(44, 109)
        Me.btndel.Margin = New System.Windows.Forms.Padding(4)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(100, 28)
        Me.btndel.TabIndex = 2
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(196, 48)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(100, 28)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(44, 48)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 28)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnfrst
        '
        Me.btnfrst.Location = New System.Drawing.Point(59, 23)
        Me.btnfrst.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfrst.Name = "btnfrst"
        Me.btnfrst.Size = New System.Drawing.Size(100, 28)
        Me.btnfrst.TabIndex = 0
        Me.btnfrst.Text = "FIRST"
        Me.btnfrst.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(241, 23)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(100, 28)
        Me.btnnext.TabIndex = 1
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(415, 23)
        Me.btnprev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(100, 28)
        Me.btnprev.TabIndex = 2
        Me.btnprev.Text = "PREVIOUS"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(587, 23)
        Me.btnlast.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(100, 28)
        Me.btnlast.TabIndex = 3
        Me.btnlast.Text = "LAST"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnexit)
        Me.GroupBox3.Controls.Add(Me.btnlast)
        Me.GroupBox3.Controls.Add(Me.btnprev)
        Me.GroupBox3.Controls.Add(Me.btnnext)
        Me.GroupBox3.Controls.Add(Me.btnfrst)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(54, 588)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(884, 77)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NAVIGATION"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(756, 25)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(97, 26)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbbatch)
        Me.GroupBox2.Controls.Add(Me.cbkt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(516, 65)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(348, 249)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trainer Course Details"
        '
        'cbbatch
        '
        Me.cbbatch.DataSource = Me.BatchBindingSource
        Me.cbbatch.DisplayMember = "bt_btchname"
        Me.cbbatch.FormattingEnabled = True
        Me.cbbatch.Location = New System.Drawing.Point(146, 165)
        Me.cbbatch.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbatch.Name = "cbbatch"
        Me.cbbatch.Size = New System.Drawing.Size(160, 28)
        Me.cbbatch.TabIndex = 5
        Me.cbbatch.ValueMember = "bt_btchname"
        '
        'BatchBindingSource
        '
        Me.BatchBindingSource.DataMember = "batch"
        Me.BatchBindingSource.DataSource = Me.Karate1DataSet3
        '
        'Karate1DataSet3
        '
        Me.Karate1DataSet3.DataSetName = "karate1DataSet3"
        Me.Karate1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbkt
        '
        Me.cbkt.FormattingEnabled = True
        Me.cbkt.Items.AddRange(New Object() {"JUDO", "MARSHAL ARTS", "TYCON DO"})
        Me.cbkt.Location = New System.Drawing.Point(152, 77)
        Me.cbkt.Margin = New System.Windows.Forms.Padding(4)
        Me.cbkt.Name = "cbkt"
        Me.cbkt.Size = New System.Drawing.Size(160, 28)
        Me.cbkt.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 169)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "BATCH:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "KARATE TYPE:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(323, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(322, 37)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "TRAINER RECORDS"
        '
        'BatchTableAdapter
        '
        Me.BatchTableAdapter.ClearBeforeFill = True
        '
        'txttrainid
        '
        Me.txttrainid.Location = New System.Drawing.Point(764, 22)
        Me.txttrainid.Name = "txttrainid"
        Me.txttrainid.Size = New System.Drawing.Size(100, 22)
        Me.txttrainid.TabIndex = 8
        Me.txttrainid.Visible = False
        '
        'Trainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(959, 678)
        Me.Controls.Add(Me.txttrainid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Trainer"
        Me.Text = "Trainer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtexp As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.RichTextBox
    Friend WithEvents txtphno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnfrst As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbatch As System.Windows.Forms.ComboBox
    Friend WithEvents cbkt As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents cbgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtjoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Karate1DataSet3 As WindowsApplication1.karate1DataSet3
    Friend WithEvents BatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchTableAdapter As WindowsApplication1.karate1DataSet3TableAdapters.batchTableAdapter
    Friend WithEvents txttrainid As System.Windows.Forms.TextBox
End Class
