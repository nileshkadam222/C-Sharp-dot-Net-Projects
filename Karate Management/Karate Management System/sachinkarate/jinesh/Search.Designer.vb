<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        Me.cbtrainsearch = New System.Windows.Forms.ComboBox
        Me.TtrainerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet8 = New WindowsApplication1.karate1DataSet8
        Me.cbappsearch = New System.Windows.Forms.ComboBox
        Me.ApplicantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Karate1DataSet7 = New WindowsApplication1.karate1DataSet7
        Me.ApplicantTableAdapter = New WindowsApplication1.karate1DataSet7TableAdapters.applicantTableAdapter
        Me.TtrainerTableAdapter = New WindowsApplication1.karate1DataSet8TableAdapters.TtrainerTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TtrainerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karate1DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(179, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(420, 150)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SEARCH RECORDS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Applicant:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Search Trainer:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(533, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(179, 464)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(420, 150)
        Me.DataGridView2.TabIndex = 8
        Me.DataGridView2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(706, 591)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbtrainsearch
        '
        Me.cbtrainsearch.DataSource = Me.TtrainerBindingSource
        Me.cbtrainsearch.DisplayMember = "tr_name"
        Me.cbtrainsearch.FormattingEnabled = True
        Me.cbtrainsearch.Location = New System.Drawing.Point(353, 393)
        Me.cbtrainsearch.Name = "cbtrainsearch"
        Me.cbtrainsearch.Size = New System.Drawing.Size(154, 21)
        Me.cbtrainsearch.TabIndex = 10
        Me.cbtrainsearch.ValueMember = "tr_name"
        '
        'TtrainerBindingSource
        '
        Me.TtrainerBindingSource.DataMember = "Ttrainer"
        Me.TtrainerBindingSource.DataSource = Me.Karate1DataSet8
        '
        'Karate1DataSet8
        '
        Me.Karate1DataSet8.DataSetName = "karate1DataSet8"
        Me.Karate1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbappsearch
        '
        Me.cbappsearch.DataSource = Me.ApplicantBindingSource
        Me.cbappsearch.DisplayMember = "ap_name"
        Me.cbappsearch.FormattingEnabled = True
        Me.cbappsearch.Location = New System.Drawing.Point(339, 100)
        Me.cbappsearch.Name = "cbappsearch"
        Me.cbappsearch.Size = New System.Drawing.Size(168, 21)
        Me.cbappsearch.TabIndex = 11
        Me.cbappsearch.ValueMember = "ap_name"
        '
        'ApplicantBindingSource
        '
        Me.ApplicantBindingSource.DataMember = "applicant"
        Me.ApplicantBindingSource.DataSource = Me.Karate1DataSet7
        '
        'Karate1DataSet7
        '
        Me.Karate1DataSet7.DataSetName = "karate1DataSet7"
        Me.Karate1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApplicantTableAdapter
        '
        Me.ApplicantTableAdapter.ClearBeforeFill = True
        '
        'TtrainerTableAdapter
        '
        Me.TtrainerTableAdapter.ClearBeforeFill = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(846, 654)
        Me.Controls.Add(Me.cbappsearch)
        Me.Controls.Add(Me.cbtrainsearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Search"
        Me.Text = "Search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TtrainerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karate1DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbtrainsearch As System.Windows.Forms.ComboBox
    Friend WithEvents cbappsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Karate1DataSet7 As WindowsApplication1.karate1DataSet7
    Friend WithEvents ApplicantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicantTableAdapter As WindowsApplication1.karate1DataSet7TableAdapters.applicantTableAdapter
    Friend WithEvents Karate1DataSet8 As WindowsApplication1.karate1DataSet8
    Friend WithEvents TtrainerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TtrainerTableAdapter As WindowsApplication1.karate1DataSet8TableAdapters.TtrainerTableAdapter
End Class
