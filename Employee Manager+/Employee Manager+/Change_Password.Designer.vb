<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change_Password))
        Me.GroupBox_Default = New System.Windows.Forms.GroupBox()
        Me.TextBox_newPassword = New System.Windows.Forms.TextBox()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.TextBox_confirmPassword = New System.Windows.Forms.TextBox()
        Me.TextBox_oldPassword = New System.Windows.Forms.TextBox()
        Me.Label_confirmPassword = New System.Windows.Forms.Label()
        Me.Label_newPassword = New System.Windows.Forms.Label()
        Me.Label_oldPassword = New System.Windows.Forms.Label()
        Me.GroupBox_Default.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Default
        '
        Me.GroupBox_Default.Controls.Add(Me.TextBox_newPassword)
        Me.GroupBox_Default.Controls.Add(Me.Button_Close)
        Me.GroupBox_Default.Controls.Add(Me.Button_Clear)
        Me.GroupBox_Default.Controls.Add(Me.Button_Update)
        Me.GroupBox_Default.Controls.Add(Me.TextBox_confirmPassword)
        Me.GroupBox_Default.Controls.Add(Me.TextBox_oldPassword)
        Me.GroupBox_Default.Controls.Add(Me.Label_confirmPassword)
        Me.GroupBox_Default.Controls.Add(Me.Label_newPassword)
        Me.GroupBox_Default.Controls.Add(Me.Label_oldPassword)
        Me.GroupBox_Default.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox_Default.Name = "GroupBox_Default"
        Me.GroupBox_Default.Size = New System.Drawing.Size(316, 193)
        Me.GroupBox_Default.TabIndex = 0
        Me.GroupBox_Default.TabStop = False
        '
        'TextBox_newPassword
        '
        Me.TextBox_newPassword.BackColor = System.Drawing.Color.White
        Me.TextBox_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_newPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_newPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_newPassword.Location = New System.Drawing.Point(158, 56)
        Me.TextBox_newPassword.Name = "TextBox_newPassword"
        Me.TextBox_newPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_newPassword.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_newPassword.TabIndex = 127
        '
        'Button_Close
        '
        Me.Button_Close.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(207, 142)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(80, 30)
        Me.Button_Close.TabIndex = 131
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Clear.Location = New System.Drawing.Point(114, 142)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(80, 30)
        Me.Button_Clear.TabIndex = 130
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Update
        '
        Me.Button_Update.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.Location = New System.Drawing.Point(21, 142)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(80, 30)
        Me.Button_Update.TabIndex = 129
        Me.Button_Update.Text = "Update"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'TextBox_confirmPassword
        '
        Me.TextBox_confirmPassword.BackColor = System.Drawing.Color.White
        Me.TextBox_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_confirmPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_confirmPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_confirmPassword.Location = New System.Drawing.Point(158, 93)
        Me.TextBox_confirmPassword.Name = "TextBox_confirmPassword"
        Me.TextBox_confirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_confirmPassword.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_confirmPassword.TabIndex = 128
        '
        'TextBox_oldPassword
        '
        Me.TextBox_oldPassword.BackColor = System.Drawing.Color.White
        Me.TextBox_oldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_oldPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_oldPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_oldPassword.Location = New System.Drawing.Point(158, 19)
        Me.TextBox_oldPassword.Name = "TextBox_oldPassword"
        Me.TextBox_oldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_oldPassword.Size = New System.Drawing.Size(121, 23)
        Me.TextBox_oldPassword.TabIndex = 126
        '
        'Label_confirmPassword
        '
        Me.Label_confirmPassword.AutoSize = True
        Me.Label_confirmPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_confirmPassword.Location = New System.Drawing.Point(26, 98)
        Me.Label_confirmPassword.Name = "Label_confirmPassword"
        Me.Label_confirmPassword.Size = New System.Drawing.Size(126, 18)
        Me.Label_confirmPassword.TabIndex = 134
        Me.Label_confirmPassword.Text = "Confirm Password :"
        '
        'Label_newPassword
        '
        Me.Label_newPassword.AutoSize = True
        Me.Label_newPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_newPassword.Location = New System.Drawing.Point(46, 61)
        Me.Label_newPassword.Name = "Label_newPassword"
        Me.Label_newPassword.Size = New System.Drawing.Size(106, 18)
        Me.Label_newPassword.TabIndex = 133
        Me.Label_newPassword.Text = "New Password :"
        '
        'Label_oldPassword
        '
        Me.Label_oldPassword.AutoSize = True
        Me.Label_oldPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_oldPassword.Location = New System.Drawing.Point(56, 24)
        Me.Label_oldPassword.Name = "Label_oldPassword"
        Me.Label_oldPassword.Size = New System.Drawing.Size(96, 18)
        Me.Label_oldPassword.TabIndex = 132
        Me.Label_oldPassword.Text = "Old Password:"
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 202)
        Me.Controls.Add(Me.GroupBox_Default)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Change_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Manager+ | change password"
        Me.GroupBox_Default.ResumeLayout(False)
        Me.GroupBox_Default.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_Default As System.Windows.Forms.GroupBox
    Private WithEvents TextBox_newPassword As System.Windows.Forms.TextBox
    Private WithEvents Button_Close As System.Windows.Forms.Button
    Private WithEvents Button_Clear As System.Windows.Forms.Button
    Private WithEvents Button_Update As System.Windows.Forms.Button
    Private WithEvents TextBox_confirmPassword As System.Windows.Forms.TextBox
    Private WithEvents TextBox_oldPassword As System.Windows.Forms.TextBox
    Private WithEvents Label_confirmPassword As System.Windows.Forms.Label
    Private WithEvents Label_newPassword As System.Windows.Forms.Label
    Private WithEvents Label_oldPassword As System.Windows.Forms.Label
End Class
