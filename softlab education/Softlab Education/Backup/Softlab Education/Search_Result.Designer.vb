<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Result
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Operations = New System.Windows.Forms.GroupBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.Emp_search = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmb_id = New System.Windows.Forms.ComboBox
        Me.lbl_id = New System.Windows.Forms.Label
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.cmb_name = New System.Windows.Forms.ComboBox
        Me.cmb_search_by = New System.Windows.Forms.ComboBox
        Me.lbl_name = New System.Windows.Forms.Label
        Me.lblsearch_Student = New System.Windows.Forms.Label
        Me.dgvstud = New System.Windows.Forms.DataGridView
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Operations.SuspendLayout()
        Me.Emp_search.SuspendLayout()
        CType(Me.dgvstud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Operations
        '
        Me.Operations.BackColor = System.Drawing.Color.Transparent
        Me.Operations.Controls.Add(Me.btnclose)
        Me.Operations.Controls.Add(Me.btnedit)
        Me.Operations.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operations.Location = New System.Drawing.Point(496, 587)
        Me.Operations.Name = "Operations"
        Me.Operations.Size = New System.Drawing.Size(386, 104)
        Me.Operations.TabIndex = 19
        Me.Operations.TabStop = False
        Me.Operations.Text = "Operation's"
        '
        'btnclose
        '
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(247, 45)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(96, 37)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(50, 45)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(95, 37)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Emp_search
        '
        Me.Emp_search.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Emp_search.Controls.Add(Me.Button1)
        Me.Emp_search.Controls.Add(Me.cmb_id)
        Me.Emp_search.Controls.Add(Me.lbl_id)
        Me.Emp_search.Controls.Add(Me.btnreset)
        Me.Emp_search.Controls.Add(Me.btnsearch)
        Me.Emp_search.Controls.Add(Me.cmb_name)
        Me.Emp_search.Controls.Add(Me.cmb_search_by)
        Me.Emp_search.Controls.Add(Me.lbl_name)
        Me.Emp_search.Controls.Add(Me.lblsearch_Student)
        Me.Emp_search.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_search.Location = New System.Drawing.Point(285, 28)
        Me.Emp_search.Name = "Emp_search"
        Me.Emp_search.Size = New System.Drawing.Size(781, 196)
        Me.Emp_search.TabIndex = 17
        Me.Emp_search.TabStop = False
        Me.Emp_search.Text = "Search_Result"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(559, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_id
        '
        Me.cmb_id.FormattingEnabled = True
        Me.cmb_id.Location = New System.Drawing.Point(278, 83)
        Me.cmb_id.Name = "cmb_id"
        Me.cmb_id.Size = New System.Drawing.Size(144, 29)
        Me.cmb_id.TabIndex = 8
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(115, 89)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(77, 21)
        Me.lbl_id.TabIndex = 7
        Me.lbl_id.Text = "Test_Id"
        '
        'btnreset
        '
        Me.btnreset.ForeColor = System.Drawing.Color.Black
        Me.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreset.Location = New System.Drawing.Point(656, 76)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(101, 37)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "Reset"
        Me.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(559, 76)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(91, 37)
        Me.btnsearch.TabIndex = 5
        Me.btnsearch.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'cmb_name
        '
        Me.cmb_name.FormattingEnabled = True
        Me.cmb_name.Location = New System.Drawing.Point(278, 128)
        Me.cmb_name.Name = "cmb_name"
        Me.cmb_name.Size = New System.Drawing.Size(144, 29)
        Me.cmb_name.TabIndex = 3
        '
        'cmb_search_by
        '
        Me.cmb_search_by.FormattingEnabled = True
        Me.cmb_search_by.Items.AddRange(New Object() {"Stream_Name", "Test_Id"})
        Me.cmb_search_by.Location = New System.Drawing.Point(278, 40)
        Me.cmb_search_by.Name = "cmb_search_by"
        Me.cmb_search_by.Size = New System.Drawing.Size(144, 29)
        Me.cmb_search_by.TabIndex = 2
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(79, 136)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(142, 21)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Stream_Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblsearch_Student
        '
        Me.lblsearch_Student.AutoSize = True
        Me.lblsearch_Student.Location = New System.Drawing.Point(39, 40)
        Me.lblsearch_Student.Name = "lblsearch_Student"
        Me.lblsearch_Student.Size = New System.Drawing.Size(177, 21)
        Me.lblsearch_Student.TabIndex = 0
        Me.lblsearch_Student.Text = "Search_Result_By"
        '
        'dgvstud
        '
        Me.dgvstud.AllowUserToAddRows = False
        Me.dgvstud.AllowUserToDeleteRows = False
        Me.dgvstud.BackgroundColor = System.Drawing.Color.White
        Me.dgvstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstud.Location = New System.Drawing.Point(301, 244)
        Me.dgvstud.Name = "dgvstud"
        Me.dgvstud.ReadOnly = True
        Me.dgvstud.Size = New System.Drawing.Size(730, 326)
        Me.dgvstud.TabIndex = 18
        '
        'Search_Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 718)
        Me.Controls.Add(Me.Operations)
        Me.Controls.Add(Me.Emp_search)
        Me.Controls.Add(Me.dgvstud)
        Me.Name = "Search_Result"
        Me.Text = "Search_Result"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Operations.ResumeLayout(False)
        Me.Emp_search.ResumeLayout(False)
        Me.Emp_search.PerformLayout()
        CType(Me.dgvstud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Operations As System.Windows.Forms.GroupBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents Emp_search As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_id As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents cmb_name As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_search_by As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lblsearch_Student As System.Windows.Forms.Label
    Friend WithEvents dgvstud As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
