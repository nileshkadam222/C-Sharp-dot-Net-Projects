<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search2
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
        Me.cbsssearch = New System.Windows.Forms.ComboBox
        Me.StageshowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet11 = New WindowsApplication1.karate1DataSet11
        Me.cbabsearch = New System.Windows.Forms.ComboBox
        Me.AssignbatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet12 = New WindowsApplication1.karate1DataSet12
        Me.StageshowTableAdapter = New WindowsApplication1.karate1DataSet11TableAdapters.stageshowTableAdapter
        Me.AssignbatchTableAdapter = New WindowsApplication1.karate1DataSet12TableAdapters.assignbatchTableAdapter
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StageshowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignbatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(721, 588)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(194, 461)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(452, 150)
        Me.DataGridView2.TabIndex = 18
        Me.DataGridView2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(580, 379)
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
        Me.Label3.Location = New System.Drawing.Point(190, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Search AssignedBatch:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search StageShow:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SEARCH RECORDS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(194, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(452, 150)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.Visible = False
        '
        'cbsssearch
        '
        Me.cbsssearch.DataSource = Me.StageshowBindingSource
        Me.cbsssearch.DisplayMember = "ss_name"
        Me.cbsssearch.FormattingEnabled = True
        Me.cbsssearch.Location = New System.Drawing.Point(415, 94)
        Me.cbsssearch.Name = "cbsssearch"
        Me.cbsssearch.Size = New System.Drawing.Size(134, 21)
        Me.cbsssearch.TabIndex = 20
        Me.cbsssearch.ValueMember = "ss_name"
        '
        'StageshowBindingSource
        '
        Me.StageshowBindingSource.DataMember = "stageshow"
        Me.StageshowBindingSource.DataSource = Me.Karate1DataSet11
        '
        'Karate1DataSet11
        '
        Me.Karate1DataSet11.DataSetName = "karate1DataSet11"
        Me.Karate1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbabsearch
        '
        Me.cbabsearch.DataSource = Me.AssignbatchBindingSource
        Me.cbabsearch.DisplayMember = "ab_batch"
        Me.cbabsearch.FormattingEnabled = True
        Me.cbabsearch.Location = New System.Drawing.Point(415, 384)
        Me.cbabsearch.Name = "cbabsearch"
        Me.cbabsearch.Size = New System.Drawing.Size(134, 21)
        Me.cbabsearch.TabIndex = 21
        Me.cbabsearch.ValueMember = "ab_batch"
        '
        'AssignbatchBindingSource
        '
        Me.AssignbatchBindingSource.DataMember = "assignbatch"
        Me.AssignbatchBindingSource.DataSource = Me.Karate1DataSet12
        '
        'Karate1DataSet12
        '
        Me.Karate1DataSet12.DataSetName = "karate1DataSet12"
        Me.Karate1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StageshowTableAdapter
        '
        Me.StageshowTableAdapter.ClearBeforeFill = True
        '
        'AssignbatchTableAdapter
        '
        Me.AssignbatchTableAdapter.ClearBeforeFill = True
        '
        'Search2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(822, 621)
        Me.Controls.Add(Me.cbabsearch)
        Me.Controls.Add(Me.cbsssearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Search2"
        Me.Text = "Search2"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StageshowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignbatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet12, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbsssearch As System.Windows.Forms.ComboBox
    Friend WithEvents cbabsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Karate1DataSet11 As WindowsApplication1.karate1DataSet11
    Friend WithEvents StageshowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StageshowTableAdapter As WindowsApplication1.karate1DataSet11TableAdapters.stageshowTableAdapter
    Friend WithEvents Karate1DataSet12 As WindowsApplication1.karate1DataSet12
    Friend WithEvents AssignbatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssignbatchTableAdapter As WindowsApplication1.karate1DataSet12TableAdapters.assignbatchTableAdapter
End Class
