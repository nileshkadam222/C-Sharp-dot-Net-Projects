<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEARCH1
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cbcoursesearch = New System.Windows.Forms.ComboBox
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet9 = New WindowsApplication1.karate1DataSet9
        Me.cbbatchsearch = New System.Windows.Forms.ComboBox
        Me.BatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet10 = New WindowsApplication1.karate1DataSet10
        Me.CourseTableAdapter = New WindowsApplication1.karate1DataSet9TableAdapters.courseTableAdapter
        Me.BatchTableAdapter = New WindowsApplication1.karate1DataSet10TableAdapters.batchTableAdapter
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(718, 603)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(179, 476)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(450, 150)
        Me.DataGridView2.TabIndex = 18
        Me.DataGridView2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(563, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 29)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Search Batch:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search Course:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SEARCH RECORDS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(563, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(179, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(450, 150)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.Visible = False
        '
        'cbcoursesearch
        '
        Me.cbcoursesearch.DataSource = Me.CourseBindingSource
        Me.cbcoursesearch.DisplayMember = "cr_crsname"
        Me.cbcoursesearch.FormattingEnabled = True
        Me.cbcoursesearch.Location = New System.Drawing.Point(337, 114)
        Me.cbcoursesearch.Name = "cbcoursesearch"
        Me.cbcoursesearch.Size = New System.Drawing.Size(176, 21)
        Me.cbcoursesearch.TabIndex = 20
        Me.cbcoursesearch.ValueMember = "cr_crsname"
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "course"
        Me.CourseBindingSource.DataSource = Me.Karate1DataSet9
        '
        'Karate1DataSet9
        '
        Me.Karate1DataSet9.DataSetName = "karate1DataSet9"
        Me.Karate1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbbatchsearch
        '
        Me.cbbatchsearch.DataSource = Me.BatchBindingSource
        Me.cbbatchsearch.DisplayMember = "bt_btchname"
        Me.cbbatchsearch.FormattingEnabled = True
        Me.cbbatchsearch.Location = New System.Drawing.Point(337, 398)
        Me.cbbatchsearch.Name = "cbbatchsearch"
        Me.cbbatchsearch.Size = New System.Drawing.Size(176, 21)
        Me.cbbatchsearch.TabIndex = 21
        Me.cbbatchsearch.ValueMember = "bt_btchname"
        '
        'BatchBindingSource
        '
        Me.BatchBindingSource.DataMember = "batch"
        Me.BatchBindingSource.DataSource = Me.Karate1DataSet10
        '
        'Karate1DataSet10
        '
        Me.Karate1DataSet10.DataSetName = "karate1DataSet10"
        Me.Karate1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'BatchTableAdapter
        '
        Me.BatchTableAdapter.ClearBeforeFill = True
        '
        'SEARCH1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(807, 644)
        Me.Controls.Add(Me.cbbatchsearch)
        Me.Controls.Add(Me.cbcoursesearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SEARCH1"
        Me.Text = "SEARCH1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbcoursesearch As System.Windows.Forms.ComboBox
    Friend WithEvents cbbatchsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Karate1DataSet9 As WindowsApplication1.karate1DataSet9
    Friend WithEvents CourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseTableAdapter As WindowsApplication1.karate1DataSet9TableAdapters.courseTableAdapter
    Friend WithEvents Karate1DataSet10 As WindowsApplication1.karate1DataSet10
    Friend WithEvents BatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchTableAdapter As WindowsApplication1.karate1DataSet10TableAdapters.batchTableAdapter
End Class
