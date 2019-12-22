<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Employees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manage_Employees))
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.GroupBox_Photo = New System.Windows.Forms.GroupBox()
        Me.Employee_Photo = New System.Windows.Forms.PictureBox()
        Me.Button_Remove = New System.Windows.Forms.Button()
        Me.Button_Browse = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.TextBox_CPassword = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.Label_CPassword = New System.Windows.Forms.Label()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.Label_DateofBirth = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.dtp_DateofBirth = New System.Windows.Forms.DateTimePicker()
        Me.Button_getDatabase = New System.Windows.Forms.Button()
        Me.GroupBox_Photo.SuspendLayout()
        CType(Me.Employee_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_Email
        '
        Me.TextBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Email.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Email.Location = New System.Drawing.Point(152, 117)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Email.TabIndex = 97
        '
        'Label_Email
        '
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Email.ForeColor = System.Drawing.Color.Black
        Me.Label_Email.Location = New System.Drawing.Point(42, 117)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(102, 18)
        Me.Label_Email.TabIndex = 113
        Me.Label_Email.Text = "Email Address :"
        '
        'GroupBox_Photo
        '
        Me.GroupBox_Photo.Controls.Add(Me.Employee_Photo)
        Me.GroupBox_Photo.Location = New System.Drawing.Point(318, 6)
        Me.GroupBox_Photo.Name = "GroupBox_Photo"
        Me.GroupBox_Photo.Size = New System.Drawing.Size(189, 202)
        Me.GroupBox_Photo.TabIndex = 112
        Me.GroupBox_Photo.TabStop = False
        '
        'Employee_Photo
        '
        Me.Employee_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Employee_Photo.Image = CType(resources.GetObject("Employee_Photo.Image"), System.Drawing.Image)
        Me.Employee_Photo.Location = New System.Drawing.Point(6, 13)
        Me.Employee_Photo.Name = "Employee_Photo"
        Me.Employee_Photo.Size = New System.Drawing.Size(177, 181)
        Me.Employee_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Employee_Photo.TabIndex = 11
        Me.Employee_Photo.TabStop = False
        '
        'Button_Remove
        '
        Me.Button_Remove.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Remove.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Remove.ForeColor = System.Drawing.Color.Black
        Me.Button_Remove.Location = New System.Drawing.Point(419, 216)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(90, 30)
        Me.Button_Remove.TabIndex = 102
        Me.Button_Remove.Text = "Remove"
        Me.Button_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Remove.UseVisualStyleBackColor = True
        '
        'Button_Browse
        '
        Me.Button_Browse.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Browse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Browse.ForeColor = System.Drawing.Color.Black
        Me.Button_Browse.Location = New System.Drawing.Point(319, 216)
        Me.Button_Browse.Name = "Button_Browse"
        Me.Button_Browse.Size = New System.Drawing.Size(90, 30)
        Me.Button_Browse.TabIndex = 101
        Me.Button_Browse.Text = "Browse"
        Me.Button_Browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Browse.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.ForeColor = System.Drawing.Color.Black
        Me.Button_Close.Location = New System.Drawing.Point(202, 254)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(80, 30)
        Me.Button_Close.TabIndex = 105
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Clear.ForeColor = System.Drawing.Color.Black
        Me.Button_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Clear.Location = New System.Drawing.Point(109, 254)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(80, 30)
        Me.Button_Clear.TabIndex = 104
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Add.ForeColor = System.Drawing.Color.Black
        Me.Button_Add.Location = New System.Drawing.Point(16, 254)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(80, 30)
        Me.Button_Add.TabIndex = 103
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'TextBox_CPassword
        '
        Me.TextBox_CPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_CPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CPassword.ForeColor = System.Drawing.Color.Black
        Me.TextBox_CPassword.Location = New System.Drawing.Point(152, 204)
        Me.TextBox_CPassword.Name = "TextBox_CPassword"
        Me.TextBox_CPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_CPassword.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_CPassword.TabIndex = 100
        '
        'TextBox_Password
        '
        Me.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Password.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Password.Location = New System.Drawing.Point(152, 175)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Password.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Password.TabIndex = 99
        '
        'TextBox_Username
        '
        Me.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Username.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Username.Location = New System.Drawing.Point(152, 146)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Username.TabIndex = 98
        '
        'Label_CPassword
        '
        Me.Label_CPassword.AutoSize = True
        Me.Label_CPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CPassword.ForeColor = System.Drawing.Color.Black
        Me.Label_CPassword.Location = New System.Drawing.Point(18, 204)
        Me.Label_CPassword.Name = "Label_CPassword"
        Me.Label_CPassword.Size = New System.Drawing.Size(126, 18)
        Me.Label_CPassword.TabIndex = 111
        Me.Label_CPassword.Text = "Confirm Password :"
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Password.ForeColor = System.Drawing.Color.Black
        Me.Label_Password.Location = New System.Drawing.Point(70, 175)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(74, 18)
        Me.Label_Password.TabIndex = 110
        Me.Label_Password.Text = "Password :"
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.ForeColor = System.Drawing.Color.Black
        Me.Label_Username.Location = New System.Drawing.Point(66, 146)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(78, 18)
        Me.Label_Username.TabIndex = 109
        Me.Label_Username.Text = "Username :"
        '
        'TextBox_Address
        '
        Me.TextBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Address.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Address.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Address.Location = New System.Drawing.Point(152, 88)
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Address.TabIndex = 96
        '
        'TextBox_Name
        '
        Me.TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Name.Location = New System.Drawing.Point(152, 30)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_Name.TabIndex = 94
        '
        'Label_Address
        '
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Address.ForeColor = System.Drawing.Color.Black
        Me.Label_Address.Location = New System.Drawing.Point(79, 88)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(65, 18)
        Me.Label_Address.TabIndex = 108
        Me.Label_Address.Text = "Address :"
        '
        'Label_DateofBirth
        '
        Me.Label_DateofBirth.AutoSize = True
        Me.Label_DateofBirth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DateofBirth.ForeColor = System.Drawing.Color.Black
        Me.Label_DateofBirth.Location = New System.Drawing.Point(51, 62)
        Me.Label_DateofBirth.Name = "Label_DateofBirth"
        Me.Label_DateofBirth.Size = New System.Drawing.Size(93, 18)
        Me.Label_DateofBirth.TabIndex = 107
        Me.Label_DateofBirth.Text = "Date of Birth :"
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.ForeColor = System.Drawing.Color.Black
        Me.Label_Name.Location = New System.Drawing.Point(92, 30)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(52, 18)
        Me.Label_Name.TabIndex = 106
        Me.Label_Name.Text = "Name :"
        '
        'dtp_DateofBirth
        '
        Me.dtp_DateofBirth.CalendarForeColor = System.Drawing.Color.Black
        Me.dtp_DateofBirth.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.dtp_DateofBirth.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtp_DateofBirth.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtp_DateofBirth.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_DateofBirth.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DateofBirth.Location = New System.Drawing.Point(152, 58)
        Me.dtp_DateofBirth.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtp_DateofBirth.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtp_DateofBirth.Name = "dtp_DateofBirth"
        Me.dtp_DateofBirth.Size = New System.Drawing.Size(121, 23)
        Me.dtp_DateofBirth.TabIndex = 136
        Me.dtp_DateofBirth.Value = New Date(2014, 2, 9, 0, 0, 0, 0)
        '
        'Button_getDatabase
        '
        Me.Button_getDatabase.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_getDatabase.ForeColor = System.Drawing.Color.Black
        Me.Button_getDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_getDatabase.Location = New System.Drawing.Point(419, 254)
        Me.Button_getDatabase.Name = "Button_getDatabase"
        Me.Button_getDatabase.Size = New System.Drawing.Size(90, 30)
        Me.Button_getDatabase.TabIndex = 137
        Me.Button_getDatabase.Text = "Get Data"
        Me.Button_getDatabase.UseVisualStyleBackColor = True
        '
        'Manage_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(519, 312)
        Me.Controls.Add(Me.Button_getDatabase)
        Me.Controls.Add(Me.dtp_DateofBirth)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.Label_Email)
        Me.Controls.Add(Me.GroupBox_Photo)
        Me.Controls.Add(Me.Button_Remove)
        Me.Controls.Add(Me.Button_Browse)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.TextBox_CPassword)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBox_Username)
        Me.Controls.Add(Me.Label_CPassword)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.Label_Username)
        Me.Controls.Add(Me.TextBox_Address)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label_Address)
        Me.Controls.Add(Me.Label_DateofBirth)
        Me.Controls.Add(Me.Label_Name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Manage_Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Manager+ | manage"
        Me.GroupBox_Photo.ResumeLayout(False)
        CType(Me.Employee_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TextBox_Email As System.Windows.Forms.TextBox
    Private WithEvents Label_Email As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Photo As System.Windows.Forms.GroupBox
    Friend WithEvents Employee_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Remove As System.Windows.Forms.Button
    Friend WithEvents Button_Browse As System.Windows.Forms.Button
    Private WithEvents Button_Close As System.Windows.Forms.Button
    Private WithEvents Button_Clear As System.Windows.Forms.Button
    Private WithEvents Button_Add As System.Windows.Forms.Button
    Private WithEvents TextBox_CPassword As System.Windows.Forms.TextBox
    Private WithEvents TextBox_Password As System.Windows.Forms.TextBox
    Private WithEvents TextBox_Username As System.Windows.Forms.TextBox
    Private WithEvents Label_CPassword As System.Windows.Forms.Label
    Private WithEvents Label_Password As System.Windows.Forms.Label
    Private WithEvents Label_Username As System.Windows.Forms.Label
    Private WithEvents TextBox_Address As System.Windows.Forms.TextBox
    Private WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Private WithEvents Label_Address As System.Windows.Forms.Label
    Private WithEvents Label_DateofBirth As System.Windows.Forms.Label
    Private WithEvents Label_Name As System.Windows.Forms.Label
    Friend WithEvents dtp_DateofBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button_getDatabase As System.Windows.Forms.Button
End Class
