<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Batch
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.btnlst = New System.Windows.Forms.Button
        Me.btnprev = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnfrst = New System.Windows.Forms.Button
        Me.btnnew = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtweek1 = New System.Windows.Forms.DateTimePicker
        Me.txtweek2 = New System.Windows.Forms.DateTimePicker
        Me.txtstartdate = New System.Windows.Forms.DateTimePicker
        Me.txtcapacity = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtbtchname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbcourse = New System.Windows.Forms.ComboBox
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet4 = New WindowsApplication1.karate1DataSet4
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbcid = New System.Windows.Forms.ComboBox
        Me.CourseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet6 = New WindowsApplication1.karate1DataSet6
        Me.Label9 = New System.Windows.Forms.Label
        Me.CourseTableAdapter = New WindowsApplication1.karate1DataSet4TableAdapters.courseTableAdapter
        Me.CourseTableAdapter1 = New WindowsApplication1.karate1DataSet6TableAdapters.courseTableAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.btnlst)
        Me.GroupBox3.Controls.Add(Me.btnprev)
        Me.GroupBox3.Controls.Add(Me.btnnext)
        Me.GroupBox3.Controls.Add(Me.btnfrst)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(39, 572)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(777, 72)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NAVIGATION"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(628, 31)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(90, 27)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "EXIT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btnlst
        '
        Me.btnlst.Location = New System.Drawing.Point(484, 31)
        Me.btnlst.Name = "btnlst"
        Me.btnlst.Size = New System.Drawing.Size(91, 27)
        Me.btnlst.TabIndex = 3
        Me.btnlst.Text = "LAST"
        Me.btnlst.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(334, 31)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(91, 27)
        Me.btnprev.TabIndex = 2
        Me.btnprev.Text = "PREVIOUS"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(188, 31)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(90, 29)
        Me.btnnext.TabIndex = 1
        Me.btnnext.Text = "NEXT"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnfrst
        '
        Me.btnfrst.Location = New System.Drawing.Point(40, 31)
        Me.btnfrst.Name = "btnfrst"
        Me.btnfrst.Size = New System.Drawing.Size(86, 27)
        Me.btnfrst.TabIndex = 0
        Me.btnfrst.Text = "FIRST"
        Me.btnfrst.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(147, 112)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 30)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(33, 112)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 30)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(147, 39)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 33)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(33, 39)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 33)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnnew)
        Me.GroupBox4.Controls.Add(Me.btndelete)
        Me.GroupBox4.Controls.Add(Me.btnupdate)
        Me.GroupBox4.Controls.Add(Me.btnadd)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(614, 258)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 178)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "EDITOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BATCH RECORDS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtweek1)
        Me.GroupBox1.Controls.Add(Me.txtweek2)
        Me.GroupBox1.Controls.Add(Me.txtstartdate)
        Me.GroupBox1.Controls.Add(Me.txtcapacity)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtbtchname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 351)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Batch Details"
        '
        'txtweek1
        '
        Me.txtweek1.Location = New System.Drawing.Point(149, 112)
        Me.txtweek1.Name = "txtweek1"
        Me.txtweek1.Size = New System.Drawing.Size(295, 26)
        Me.txtweek1.TabIndex = 20
        '
        'txtweek2
        '
        Me.txtweek2.Location = New System.Drawing.Point(149, 174)
        Me.txtweek2.Name = "txtweek2"
        Me.txtweek2.Size = New System.Drawing.Size(295, 26)
        Me.txtweek2.TabIndex = 19
        '
        'txtstartdate
        '
        Me.txtstartdate.Location = New System.Drawing.Point(149, 232)
        Me.txtstartdate.Name = "txtstartdate"
        Me.txtstartdate.Size = New System.Drawing.Size(295, 26)
        Me.txtstartdate.TabIndex = 18
        '
        'txtcapacity
        '
        Me.txtcapacity.Location = New System.Drawing.Point(149, 297)
        Me.txtcapacity.Name = "txtcapacity"
        Me.txtcapacity.Size = New System.Drawing.Size(174, 26)
        Me.txtcapacity.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Capacity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Start Date:"
        '
        'txtbtchname
        '
        Me.txtbtchname.Location = New System.Drawing.Point(149, 52)
        Me.txtbtchname.Name = "txtbtchname"
        Me.txtbtchname.Size = New System.Drawing.Size(174, 26)
        Me.txtbtchname.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Weekday2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Batch name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Weekday1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Course:"
        '
        'cbcourse
        '
        Me.cbcourse.DataSource = Me.CourseBindingSource
        Me.cbcourse.DisplayMember = "cr_crsname"
        Me.cbcourse.FormattingEnabled = True
        Me.cbcourse.Location = New System.Drawing.Point(309, 92)
        Me.cbcourse.Name = "cbcourse"
        Me.cbcourse.Size = New System.Drawing.Size(174, 21)
        Me.cbcourse.TabIndex = 13
        Me.cbcourse.ValueMember = "cr_crsname"
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "course"
        Me.CourseBindingSource.DataSource = Me.Karate1DataSet4
        '
        'Karate1DataSet4
        '
        Me.Karate1DataSet4.DataSetName = "karate1DataSet4"
        Me.Karate1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "select course from the above box"
        '
        'cbcid
        '
        Me.cbcid.DataSource = Me.CourseBindingSource1
        Me.cbcid.DisplayMember = "CID"
        Me.cbcid.FormattingEnabled = True
        Me.cbcid.Location = New System.Drawing.Point(618, 92)
        Me.cbcid.Name = "cbcid"
        Me.cbcid.Size = New System.Drawing.Size(149, 21)
        Me.cbcid.TabIndex = 17
        Me.cbcid.ValueMember = "CID"
        '
        'CourseBindingSource1
        '
        Me.CourseBindingSource1.DataMember = "course"
        Me.CourseBindingSource1.DataSource = Me.Karate1DataSet6
        '
        'Karate1DataSet6
        '
        Me.Karate1DataSet6.DataSetName = "karate1DataSet6"
        Me.Karate1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(615, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(284, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Please select the corresponding course id"
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'CourseTableAdapter1
        '
        Me.CourseTableAdapter1.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(667, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Visible = False
        '
        'Batch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(918, 681)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbcid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbcourse)
        Me.Name = "Batch"
        Me.Text = "Batch Details"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlst As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnfrst As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbtchname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtcapacity As System.Windows.Forms.TextBox
    Friend WithEvents cbcid As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtweek1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtweek2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtstartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Karate1DataSet4 As WindowsApplication1.karate1DataSet4
    Friend WithEvents CourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseTableAdapter As WindowsApplication1.karate1DataSet4TableAdapters.courseTableAdapter
    Friend WithEvents Karate1DataSet6 As WindowsApplication1.karate1DataSet6
    Friend WithEvents CourseBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CourseTableAdapter1 As WindowsApplication1.karate1DataSet6TableAdapters.courseTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
