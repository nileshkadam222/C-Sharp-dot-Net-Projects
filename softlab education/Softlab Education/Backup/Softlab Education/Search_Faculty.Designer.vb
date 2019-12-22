<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Faculty
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
        Me.dgvstud = New System.Windows.Forms.DataGridView
        Me.Emp_search = New System.Windows.Forms.GroupBox
        Me.cmb_faculty_id = New System.Windows.Forms.ComboBox
        Me.lblbat_id = New System.Windows.Forms.Label
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.cmb_faculty_name = New System.Windows.Forms.ComboBox
        Me.cmb_search_by = New System.Windows.Forms.ComboBox
        Me.lblbat_name = New System.Windows.Forms.Label
        Me.lblsearch_Student = New System.Windows.Forms.Label
        Me.Operations = New System.Windows.Forms.GroupBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvstud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Emp_search.SuspendLayout()
        Me.Operations.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgvstud
        '
        Me.dgvstud.AllowUserToAddRows = False
        Me.dgvstud.AllowUserToDeleteRows = False
        Me.dgvstud.BackgroundColor = System.Drawing.Color.White
        Me.dgvstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstud.Location = New System.Drawing.Point(169, 218)
        Me.dgvstud.Name = "dgvstud"
        Me.dgvstud.ReadOnly = True
        Me.dgvstud.Size = New System.Drawing.Size(730, 326)
        Me.dgvstud.TabIndex = 21
        '
        'Emp_search
        '
        Me.Emp_search.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Emp_search.BackgroundImage = Global.Softlab_Education.My.Resources.Resources.images__12_
        Me.Emp_search.Controls.Add(Me.cmb_faculty_id)
        Me.Emp_search.Controls.Add(Me.lblbat_id)
        Me.Emp_search.Controls.Add(Me.btnreset)
        Me.Emp_search.Controls.Add(Me.btnsearch)
        Me.Emp_search.Controls.Add(Me.cmb_faculty_name)
        Me.Emp_search.Controls.Add(Me.cmb_search_by)
        Me.Emp_search.Controls.Add(Me.lblbat_name)
        Me.Emp_search.Controls.Add(Me.lblsearch_Student)
        Me.Emp_search.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_search.Location = New System.Drawing.Point(169, 27)
        Me.Emp_search.Name = "Emp_search"
        Me.Emp_search.Size = New System.Drawing.Size(730, 196)
        Me.Emp_search.TabIndex = 20
        Me.Emp_search.TabStop = False
        Me.Emp_search.Text = "Search_Faculty"
        '
        'cmb_faculty_id
        '
        Me.cmb_faculty_id.FormattingEnabled = True
        Me.cmb_faculty_id.Location = New System.Drawing.Point(278, 81)
        Me.cmb_faculty_id.Name = "cmb_faculty_id"
        Me.cmb_faculty_id.Size = New System.Drawing.Size(144, 29)
        Me.cmb_faculty_id.TabIndex = 2
        '
        'lblbat_id
        '
        Me.lblbat_id.AutoSize = True
        Me.lblbat_id.BackColor = System.Drawing.Color.Transparent
        Me.lblbat_id.Location = New System.Drawing.Point(115, 89)
        Me.lblbat_id.Name = "lblbat_id"
        Me.lblbat_id.Size = New System.Drawing.Size(112, 21)
        Me.lblbat_id.TabIndex = 7
        Me.lblbat_id.Text = "Faculty_Id" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnreset
        '
        Me.btnreset.ForeColor = System.Drawing.Color.Black
        Me.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreset.Location = New System.Drawing.Point(605, 76)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(101, 37)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(481, 76)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(91, 37)
        Me.btnsearch.TabIndex = 5
        Me.btnsearch.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'cmb_faculty_name
        '
        Me.cmb_faculty_name.FormattingEnabled = True
        Me.cmb_faculty_name.Location = New System.Drawing.Point(278, 128)
        Me.cmb_faculty_name.Name = "cmb_faculty_name"
        Me.cmb_faculty_name.Size = New System.Drawing.Size(144, 29)
        Me.cmb_faculty_name.TabIndex = 3
        '
        'cmb_search_by
        '
        Me.cmb_search_by.FormattingEnabled = True
        Me.cmb_search_by.Items.AddRange(New Object() {"Faculty_Name", "Faculty_Id"})
        Me.cmb_search_by.Location = New System.Drawing.Point(278, 40)
        Me.cmb_search_by.Name = "cmb_search_by"
        Me.cmb_search_by.Size = New System.Drawing.Size(144, 29)
        Me.cmb_search_by.TabIndex = 1
        '
        'lblbat_name
        '
        Me.lblbat_name.AutoSize = True
        Me.lblbat_name.BackColor = System.Drawing.Color.Transparent
        Me.lblbat_name.Location = New System.Drawing.Point(79, 136)
        Me.lblbat_name.Name = "lblbat_name"
        Me.lblbat_name.Size = New System.Drawing.Size(148, 21)
        Me.lblbat_name.TabIndex = 1
        Me.lblbat_name.Text = "Faculty_Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblsearch_Student
        '
        Me.lblsearch_Student.AutoSize = True
        Me.lblsearch_Student.BackColor = System.Drawing.Color.Transparent
        Me.lblsearch_Student.Location = New System.Drawing.Point(39, 40)
        Me.lblsearch_Student.Name = "lblsearch_Student"
        Me.lblsearch_Student.Size = New System.Drawing.Size(190, 21)
        Me.lblsearch_Student.TabIndex = 0
        Me.lblsearch_Student.Text = "Search_Student_By"
        '
        'Operations
        '
        Me.Operations.BackColor = System.Drawing.Color.Transparent
        Me.Operations.BackgroundImage = Global.Softlab_Education.My.Resources.Resources.images__12_
        Me.Operations.Controls.Add(Me.btnclose)
        Me.Operations.Controls.Add(Me.btnedit)
        Me.Operations.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operations.Location = New System.Drawing.Point(924, 336)
        Me.Operations.Name = "Operations"
        Me.Operations.Size = New System.Drawing.Size(331, 104)
        Me.Operations.TabIndex = 22
        Me.Operations.TabStop = False
        Me.Operations.Text = "Operation's"
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(192, 45)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(96, 37)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Exit"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(50, 45)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(95, 37)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "&Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Search_Faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Softlab_Education.My.Resources.Resources.images__9_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 718)
        Me.Controls.Add(Me.dgvstud)
        Me.Controls.Add(Me.Emp_search)
        Me.Controls.Add(Me.Operations)
        Me.Name = "Search_Faculty"
        Me.Text = "Search_Faculty"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvstud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Emp_search.ResumeLayout(False)
        Me.Emp_search.PerformLayout()
        Me.Operations.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_faculty_id As System.Windows.Forms.ComboBox
    Friend WithEvents lblbat_id As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgvstud As System.Windows.Forms.DataGridView
    Friend WithEvents Emp_search As System.Windows.Forms.GroupBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents cmb_faculty_name As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_search_by As System.Windows.Forms.ComboBox
    Friend WithEvents lblbat_name As System.Windows.Forms.Label
    Friend WithEvents lblsearch_Student As System.Windows.Forms.Label
    Friend WithEvents Operations As System.Windows.Forms.GroupBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
End Class
