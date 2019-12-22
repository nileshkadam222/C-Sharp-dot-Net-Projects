<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Applicant
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
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.txtjoin = New System.Windows.Forms.DateTimePicker
        Me.cbgender = New System.Windows.Forms.ComboBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtphno = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnnew = New System.Windows.Forms.Button
        Me.btndel = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbbatch = New System.Windows.Forms.ComboBox
        Me.BatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet2 = New WindowsApplication1.karate1DataSet2
        Me.cbkt = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BatchTableAdapter = New WindowsApplication1.karate1DataSet2TableAdapters.batchTableAdapter
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnfrst = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.btnprev = New System.Windows.Forms.Button
        Me.btnlst = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.txtappid = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtjoin)
        Me.GroupBox1.Controls.Add(Me.cbgender)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtphno)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(64, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 397)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Applicant Personal Details"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(121, 100)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(177, 57)
        Me.txtadd.TabIndex = 16
        '
        'txtjoin
        '
        Me.txtjoin.Location = New System.Drawing.Point(121, 332)
        Me.txtjoin.Name = "txtjoin"
        Me.txtjoin.Size = New System.Drawing.Size(298, 26)
        Me.txtjoin.TabIndex = 15
        '
        'cbgender
        '
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Items.AddRange(New Object() {"male", "female"})
        Me.cbgender.Location = New System.Drawing.Point(121, 284)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(177, 28)
        Me.cbgender.TabIndex = 14
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(121, 235)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(177, 26)
        Me.txtage.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "JOIN DATE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "GENDER:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "AGE:"
        '
        'txtphno
        '
        Me.txtphno.Location = New System.Drawing.Point(121, 178)
        Me.txtphno.MaxLength = 10
        Me.txtphno.Name = "txtphno"
        Me.txtphno.Size = New System.Drawing.Size(177, 26)
        Me.txtphno.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(121, 45)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(177, 26)
        Me.txtname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PHONE NO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADDRESS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnnew)
        Me.GroupBox4.Controls.Add(Me.btndel)
        Me.GroupBox4.Controls.Add(Me.btnupdate)
        Me.GroupBox4.Controls.Add(Me.btnadd)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(527, 333)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(341, 170)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "EDITOR"
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(193, 97)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(94, 31)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(47, 97)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(91, 31)
        Me.btndel.TabIndex = 2
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(193, 41)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(94, 31)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(47, 41)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(91, 31)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbbatch)
        Me.GroupBox2.Controls.Add(Me.cbkt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(527, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 202)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Applicant Course Details"
        '
        'cbbatch
        '
        Me.cbbatch.DataSource = Me.BatchBindingSource
        Me.cbbatch.DisplayMember = "bt_btchname"
        Me.cbbatch.FormattingEnabled = True
        Me.cbbatch.Location = New System.Drawing.Point(147, 129)
        Me.cbbatch.Name = "cbbatch"
        Me.cbbatch.Size = New System.Drawing.Size(158, 28)
        Me.cbbatch.TabIndex = 4
        Me.cbbatch.ValueMember = "bt_btchname"
        '
        'BatchBindingSource
        '
        Me.BatchBindingSource.DataMember = "batch"
        Me.BatchBindingSource.DataSource = Me.Karate1DataSet2
        '
        'Karate1DataSet2
        '
        Me.Karate1DataSet2.DataSetName = "karate1DataSet2"
        Me.Karate1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbkt
        '
        Me.cbkt.FormattingEnabled = True
        Me.cbkt.Items.AddRange(New Object() {"judo", "marshal arts", "tycon do"})
        Me.cbkt.Location = New System.Drawing.Point(147, 63)
        Me.cbkt.Name = "cbkt"
        Me.cbkt.Size = New System.Drawing.Size(158, 28)
        Me.cbkt.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "BATCH:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "KARATE TYPE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(311, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 37)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Applicant Details"
        '
        'BatchTableAdapter
        '
        Me.BatchTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnfrst)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.btnprev)
        Me.GroupBox3.Controls.Add(Me.btnlst)
        Me.GroupBox3.Controls.Add(Me.btnnext)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(64, 526)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(729, 85)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NAVIGATION"
        '
        'btnfrst
        '
        Me.btnfrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfrst.Location = New System.Drawing.Point(45, 33)
        Me.btnfrst.Name = "btnfrst"
        Me.btnfrst.Size = New System.Drawing.Size(87, 30)
        Me.btnfrst.TabIndex = 0
        Me.btnfrst.Text = "FIRST"
        Me.btnfrst.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(610, 33)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(89, 28)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "EXIT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.Location = New System.Drawing.Point(326, 33)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(93, 30)
        Me.btnprev.TabIndex = 2
        Me.btnprev.Text = "PREVIOUS"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnlst
        '
        Me.btnlst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlst.Location = New System.Drawing.Point(464, 33)
        Me.btnlst.Name = "btnlst"
        Me.btnlst.Size = New System.Drawing.Size(90, 30)
        Me.btnlst.TabIndex = 3
        Me.btnlst.Text = "LAST"
        Me.btnlst.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(196, 33)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(85, 30)
        Me.btnnext.TabIndex = 1
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'txtappid
        '
        Me.txtappid.Location = New System.Drawing.Point(768, 62)
        Me.txtappid.Name = "txtappid"
        Me.txtappid.Size = New System.Drawing.Size(100, 20)
        Me.txtappid.TabIndex = 5
        Me.txtappid.Visible = False
        '
        'Applicant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(946, 622)
        Me.Controls.Add(Me.txtappid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Applicant"
        Me.Text = "Applicant"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtphno As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbkt As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbgender As System.Windows.Forms.ComboBox
    Friend WithEvents cbbatch As System.Windows.Forms.ComboBox
    Friend WithEvents txtjoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Karate1DataSet2 As WindowsApplication1.karate1DataSet2
    Friend WithEvents BatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchTableAdapter As WindowsApplication1.karate1DataSet2TableAdapters.batchTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnfrst As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnlst As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents txtappid As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
End Class
