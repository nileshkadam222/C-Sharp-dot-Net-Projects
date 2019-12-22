<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change_Details))
        Me.GroupBox_Default = New System.Windows.Forms.GroupBox()
        Me.Employee_Photo = New System.Windows.Forms.PictureBox()
        Me.Button_Remove = New System.Windows.Forms.Button()
        Me.Button_Browse = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.Label_Date_of_Birth = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.TextBox_Email_Address = New System.Windows.Forms.TextBox()
        Me.Label_Email_Address = New System.Windows.Forms.Label()
        Me.dtp_Date_of_Birth = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox_Default.SuspendLayout()
        CType(Me.Employee_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox_Default
        '
        Me.GroupBox_Default.Controls.Add(Me.Employee_Photo)
        Me.GroupBox_Default.Location = New System.Drawing.Point(317, 1)
        Me.GroupBox_Default.Name = "GroupBox_Default"
        Me.GroupBox_Default.Size = New System.Drawing.Size(189, 202)
        Me.GroupBox_Default.TabIndex = 133
        Me.GroupBox_Default.TabStop = False
        '
        'Employee_Photo
        '
        Me.Employee_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Employee_Photo.Image = CType(resources.GetObject("Employee_Photo.Image"), System.Drawing.Image)
        Me.Employee_Photo.Location = New System.Drawing.Point(6, 13)
        Me.Employee_Photo.Name = "Employee_Photo"
        Me.Employee_Photo.Size = New System.Drawing.Size(177, 181)
        Me.Employee_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Employee_Photo.TabIndex = 12
        Me.Employee_Photo.TabStop = False
        '
        'Button_Remove
        '
        Me.Button_Remove.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Remove.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Remove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Remove.Location = New System.Drawing.Point(420, 211)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(80, 30)
        Me.Button_Remove.TabIndex = 126
        Me.Button_Remove.Text = "Remove"
        Me.Button_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Remove.UseVisualStyleBackColor = True
        '
        'Button_Browse
        '
        Me.Button_Browse.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Browse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Browse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Browse.Location = New System.Drawing.Point(334, 211)
        Me.Button_Browse.Name = "Button_Browse"
        Me.Button_Browse.Size = New System.Drawing.Size(80, 30)
        Me.Button_Browse.TabIndex = 125
        Me.Button_Browse.Text = "Browse"
        Me.Button_Browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Browse.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Close.Location = New System.Drawing.Point(203, 211)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(80, 30)
        Me.Button_Close.TabIndex = 129
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Clear.Location = New System.Drawing.Point(111, 211)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(80, 30)
        Me.Button_Clear.TabIndex = 128
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Update
        '
        Me.Button_Update.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Update.Location = New System.Drawing.Point(18, 211)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(80, 30)
        Me.Button_Update.TabIndex = 127
        Me.Button_Update.Text = "Update"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'TextBox_Address
        '
        Me.TextBox_Address.BackColor = System.Drawing.Color.White
        Me.TextBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Address.Location = New System.Drawing.Point(137, 111)
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Address.TabIndex = 123
        '
        'TextBox_Name
        '
        Me.TextBox_Name.BackColor = System.Drawing.Color.White
        Me.TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.Location = New System.Drawing.Point(137, 51)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Name.TabIndex = 121
        '
        'Label_Address
        '
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Address.Location = New System.Drawing.Point(52, 116)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(62, 18)
        Me.Label_Address.TabIndex = 132
        Me.Label_Address.Text = "Address:"
        '
        'Label_Date_of_Birth
        '
        Me.Label_Date_of_Birth.AutoSize = True
        Me.Label_Date_of_Birth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Date_of_Birth.Location = New System.Drawing.Point(24, 87)
        Me.Label_Date_of_Birth.Name = "Label_Date_of_Birth"
        Me.Label_Date_of_Birth.Size = New System.Drawing.Size(90, 18)
        Me.Label_Date_of_Birth.TabIndex = 131
        Me.Label_Date_of_Birth.Text = "Date of Birth:"
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(65, 56)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(49, 18)
        Me.Label_Name.TabIndex = 130
        Me.Label_Name.Text = "Name:"
        '
        'TextBox_Email_Address
        '
        Me.TextBox_Email_Address.BackColor = System.Drawing.Color.White
        Me.TextBox_Email_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Email_Address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email_Address.Location = New System.Drawing.Point(137, 143)
        Me.TextBox_Email_Address.Name = "TextBox_Email_Address"
        Me.TextBox_Email_Address.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Email_Address.TabIndex = 124
        '
        'Label_Email_Address
        '
        Me.Label_Email_Address.AutoSize = True
        Me.Label_Email_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Email_Address.Location = New System.Drawing.Point(15, 148)
        Me.Label_Email_Address.Name = "Label_Email_Address"
        Me.Label_Email_Address.Size = New System.Drawing.Size(99, 18)
        Me.Label_Email_Address.TabIndex = 134
        Me.Label_Email_Address.Text = "Email Address:"
        '
        'dtp_Date_of_Birth
        '
        Me.dtp_Date_of_Birth.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_Date_of_Birth.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date_of_Birth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date_of_Birth.Location = New System.Drawing.Point(137, 81)
        Me.dtp_Date_of_Birth.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtp_Date_of_Birth.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtp_Date_of_Birth.Name = "dtp_Date_of_Birth"
        Me.dtp_Date_of_Birth.Size = New System.Drawing.Size(121, 23)
        Me.dtp_Date_of_Birth.TabIndex = 135
        Me.dtp_Date_of_Birth.Value = New Date(2014, 2, 20, 0, 0, 0, 0)
        '
        'Change_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(516, 258)
        Me.Controls.Add(Me.dtp_Date_of_Birth)
        Me.Controls.Add(Me.GroupBox_Default)
        Me.Controls.Add(Me.Button_Remove)
        Me.Controls.Add(Me.Button_Browse)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Update)
        Me.Controls.Add(Me.TextBox_Address)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label_Address)
        Me.Controls.Add(Me.Label_Date_of_Birth)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.TextBox_Email_Address)
        Me.Controls.Add(Me.Label_Email_Address)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Change_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Manager+ | change details"
        Me.GroupBox_Default.ResumeLayout(False)
        CType(Me.Employee_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox_Default As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Remove As System.Windows.Forms.Button
    Friend WithEvents Button_Browse As System.Windows.Forms.Button
    Private WithEvents Button_Close As System.Windows.Forms.Button
    Private WithEvents Button_Clear As System.Windows.Forms.Button
    Private WithEvents Button_Update As System.Windows.Forms.Button
    Private WithEvents TextBox_Address As System.Windows.Forms.TextBox
    Private WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Private WithEvents Label_Address As System.Windows.Forms.Label
    Private WithEvents Label_Date_of_Birth As System.Windows.Forms.Label
    Private WithEvents Label_Name As System.Windows.Forms.Label
    Private WithEvents TextBox_Email_Address As System.Windows.Forms.TextBox
    Private WithEvents Label_Email_Address As System.Windows.Forms.Label
    Friend WithEvents dtp_Date_of_Birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Employee_Photo As System.Windows.Forms.PictureBox
End Class
