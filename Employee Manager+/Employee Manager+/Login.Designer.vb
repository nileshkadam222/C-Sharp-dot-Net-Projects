<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Tabs_Login = New System.Windows.Forms.TabControl()
        Me.Tab_Administrator = New System.Windows.Forms.TabPage()
        Me.GroupBox_Administrator = New System.Windows.Forms.GroupBox()
        Me.PictureBox_Admin = New System.Windows.Forms.PictureBox()
        Me.Button_Admin_Cancel = New System.Windows.Forms.Button()
        Me.Label_Admin_Password = New System.Windows.Forms.Label()
        Me.Label_Admin_Username = New System.Windows.Forms.Label()
        Me.Button_Admin_Login = New System.Windows.Forms.Button()
        Me.TextBox_Admin_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Admin_Username = New System.Windows.Forms.TextBox()
        Me.Tab_Employees = New System.Windows.Forms.TabPage()
        Me.GroupBox_Employees = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Login = New System.Windows.Forms.ComboBox()
        Me.PictureBox_Empl = New System.Windows.Forms.PictureBox()
        Me.Button_Empl_Cancel = New System.Windows.Forms.Button()
        Me.Label_Empl_Password = New System.Windows.Forms.Label()
        Me.Label_Empl_Username = New System.Windows.Forms.Label()
        Me.Button_Empl_Login = New System.Windows.Forms.Button()
        Me.TextBox_Empl_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Empl_Username = New System.Windows.Forms.TextBox()
        Me.Tabs_Login.SuspendLayout()
        Me.Tab_Administrator.SuspendLayout()
        Me.GroupBox_Administrator.SuspendLayout()
        CType(Me.PictureBox_Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Employees.SuspendLayout()
        Me.GroupBox_Employees.SuspendLayout()
        CType(Me.PictureBox_Empl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs_Login
        '
        Me.Tabs_Login.Controls.Add(Me.Tab_Administrator)
        Me.Tabs_Login.Controls.Add(Me.Tab_Employees)
        Me.Tabs_Login.ItemSize = New System.Drawing.Size(50, 20)
        Me.Tabs_Login.Location = New System.Drawing.Point(1, 1)
        Me.Tabs_Login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tabs_Login.Multiline = True
        Me.Tabs_Login.Name = "Tabs_Login"
        Me.Tabs_Login.Padding = New System.Drawing.Point(5, 3)
        Me.Tabs_Login.SelectedIndex = 0
        Me.Tabs_Login.Size = New System.Drawing.Size(360, 210)
        Me.Tabs_Login.TabIndex = 1
        '
        'Tab_Administrator
        '
        Me.Tab_Administrator.BackColor = System.Drawing.Color.White
        Me.Tab_Administrator.Controls.Add(Me.GroupBox_Administrator)
        Me.Tab_Administrator.Location = New System.Drawing.Point(4, 24)
        Me.Tab_Administrator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_Administrator.Name = "Tab_Administrator"
        Me.Tab_Administrator.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_Administrator.Size = New System.Drawing.Size(352, 182)
        Me.Tab_Administrator.TabIndex = 0
        Me.Tab_Administrator.Text = "Administrator"
        '
        'GroupBox_Administrator
        '
        Me.GroupBox_Administrator.BackColor = System.Drawing.Color.White
        Me.GroupBox_Administrator.Controls.Add(Me.PictureBox_Admin)
        Me.GroupBox_Administrator.Controls.Add(Me.Button_Admin_Cancel)
        Me.GroupBox_Administrator.Controls.Add(Me.Label_Admin_Password)
        Me.GroupBox_Administrator.Controls.Add(Me.Label_Admin_Username)
        Me.GroupBox_Administrator.Controls.Add(Me.Button_Admin_Login)
        Me.GroupBox_Administrator.Controls.Add(Me.TextBox_Admin_Password)
        Me.GroupBox_Administrator.Controls.Add(Me.TextBox_Admin_Username)
        Me.GroupBox_Administrator.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox_Administrator.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Administrator.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Administrator.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox_Administrator.Name = "GroupBox_Administrator"
        Me.GroupBox_Administrator.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox_Administrator.Size = New System.Drawing.Size(350, 180)
        Me.GroupBox_Administrator.TabIndex = 0
        Me.GroupBox_Administrator.TabStop = False
        '
        'PictureBox_Admin
        '
        Me.PictureBox_Admin.Image = CType(resources.GetObject("PictureBox_Admin.Image"), System.Drawing.Image)
        Me.PictureBox_Admin.Location = New System.Drawing.Point(15, 20)
        Me.PictureBox_Admin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox_Admin.Name = "PictureBox_Admin"
        Me.PictureBox_Admin.Size = New System.Drawing.Size(116, 116)
        Me.PictureBox_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Admin.TabIndex = 18
        Me.PictureBox_Admin.TabStop = False
        '
        'Button_Admin_Cancel
        '
        Me.Button_Admin_Cancel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Admin_Cancel.ForeColor = System.Drawing.Color.Black
        Me.Button_Admin_Cancel.Location = New System.Drawing.Point(250, 130)
        Me.Button_Admin_Cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_Admin_Cancel.Name = "Button_Admin_Cancel"
        Me.Button_Admin_Cancel.Size = New System.Drawing.Size(85, 30)
        Me.Button_Admin_Cancel.TabIndex = 3
        Me.Button_Admin_Cancel.Text = "Cancel"
        Me.Button_Admin_Cancel.UseVisualStyleBackColor = True
        '
        'Label_Admin_Password
        '
        Me.Label_Admin_Password.AutoSize = True
        Me.Label_Admin_Password.BackColor = System.Drawing.Color.Transparent
        Me.Label_Admin_Password.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Admin_Password.ForeColor = System.Drawing.Color.Black
        Me.Label_Admin_Password.Location = New System.Drawing.Point(160, 70)
        Me.Label_Admin_Password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Admin_Password.Name = "Label_Admin_Password"
        Me.Label_Admin_Password.Size = New System.Drawing.Size(71, 19)
        Me.Label_Admin_Password.TabIndex = 16
        Me.Label_Admin_Password.Text = "Password"
        '
        'Label_Admin_Username
        '
        Me.Label_Admin_Username.AutoSize = True
        Me.Label_Admin_Username.BackColor = System.Drawing.Color.Transparent
        Me.Label_Admin_Username.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Admin_Username.ForeColor = System.Drawing.Color.Black
        Me.Label_Admin_Username.Location = New System.Drawing.Point(160, 20)
        Me.Label_Admin_Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Admin_Username.Name = "Label_Admin_Username"
        Me.Label_Admin_Username.Size = New System.Drawing.Size(75, 19)
        Me.Label_Admin_Username.TabIndex = 15
        Me.Label_Admin_Username.Text = "Username"
        '
        'Button_Admin_Login
        '
        Me.Button_Admin_Login.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Admin_Login.ForeColor = System.Drawing.Color.Black
        Me.Button_Admin_Login.Location = New System.Drawing.Point(155, 130)
        Me.Button_Admin_Login.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_Admin_Login.Name = "Button_Admin_Login"
        Me.Button_Admin_Login.Size = New System.Drawing.Size(85, 30)
        Me.Button_Admin_Login.TabIndex = 2
        Me.Button_Admin_Login.Text = "Login"
        Me.Button_Admin_Login.UseVisualStyleBackColor = True
        '
        'TextBox_Admin_Password
        '
        Me.TextBox_Admin_Password.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextBox_Admin_Password.Location = New System.Drawing.Point(160, 90)
        Me.TextBox_Admin_Password.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox_Admin_Password.Name = "TextBox_Admin_Password"
        Me.TextBox_Admin_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Admin_Password.Size = New System.Drawing.Size(180, 24)
        Me.TextBox_Admin_Password.TabIndex = 1
        '
        'TextBox_Admin_Username
        '
        Me.TextBox_Admin_Username.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextBox_Admin_Username.Location = New System.Drawing.Point(160, 40)
        Me.TextBox_Admin_Username.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox_Admin_Username.Name = "TextBox_Admin_Username"
        Me.TextBox_Admin_Username.Size = New System.Drawing.Size(180, 24)
        Me.TextBox_Admin_Username.TabIndex = 0
        '
        'Tab_Employees
        '
        Me.Tab_Employees.BackColor = System.Drawing.Color.White
        Me.Tab_Employees.Controls.Add(Me.GroupBox_Employees)
        Me.Tab_Employees.Location = New System.Drawing.Point(4, 24)
        Me.Tab_Employees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_Employees.Name = "Tab_Employees"
        Me.Tab_Employees.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_Employees.Size = New System.Drawing.Size(352, 182)
        Me.Tab_Employees.TabIndex = 1
        Me.Tab_Employees.Text = "Employees"
        '
        'GroupBox_Employees
        '
        Me.GroupBox_Employees.BackColor = System.Drawing.Color.White
        Me.GroupBox_Employees.Controls.Add(Me.ComboBox_Login)
        Me.GroupBox_Employees.Controls.Add(Me.PictureBox_Empl)
        Me.GroupBox_Employees.Controls.Add(Me.Button_Empl_Cancel)
        Me.GroupBox_Employees.Controls.Add(Me.Label_Empl_Password)
        Me.GroupBox_Employees.Controls.Add(Me.Label_Empl_Username)
        Me.GroupBox_Employees.Controls.Add(Me.Button_Empl_Login)
        Me.GroupBox_Employees.Controls.Add(Me.TextBox_Empl_Password)
        Me.GroupBox_Employees.Controls.Add(Me.TextBox_Empl_Username)
        Me.GroupBox_Employees.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GroupBox_Employees.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Employees.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Employees.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox_Employees.Name = "GroupBox_Employees"
        Me.GroupBox_Employees.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox_Employees.Size = New System.Drawing.Size(350, 180)
        Me.GroupBox_Employees.TabIndex = 0
        Me.GroupBox_Employees.TabStop = False
        '
        'ComboBox_Login
        '
        Me.ComboBox_Login.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ComboBox_Login.FormattingEnabled = True
        Me.ComboBox_Login.Items.AddRange(New Object() {"Administrator", "Employees"})
        Me.ComboBox_Login.Location = New System.Drawing.Point(290, 12)
        Me.ComboBox_Login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_Login.Name = "ComboBox_Login"
        Me.ComboBox_Login.Size = New System.Drawing.Size(50, 23)
        Me.ComboBox_Login.TabIndex = 2
        Me.ComboBox_Login.Visible = False
        '
        'PictureBox_Empl
        '
        Me.PictureBox_Empl.Image = CType(resources.GetObject("PictureBox_Empl.Image"), System.Drawing.Image)
        Me.PictureBox_Empl.Location = New System.Drawing.Point(15, 20)
        Me.PictureBox_Empl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox_Empl.Name = "PictureBox_Empl"
        Me.PictureBox_Empl.Size = New System.Drawing.Size(116, 116)
        Me.PictureBox_Empl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Empl.TabIndex = 18
        Me.PictureBox_Empl.TabStop = False
        '
        'Button_Empl_Cancel
        '
        Me.Button_Empl_Cancel.BackColor = System.Drawing.Color.White
        Me.Button_Empl_Cancel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Empl_Cancel.ForeColor = System.Drawing.Color.Black
        Me.Button_Empl_Cancel.Location = New System.Drawing.Point(250, 130)
        Me.Button_Empl_Cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_Empl_Cancel.Name = "Button_Empl_Cancel"
        Me.Button_Empl_Cancel.Size = New System.Drawing.Size(85, 30)
        Me.Button_Empl_Cancel.TabIndex = 3
        Me.Button_Empl_Cancel.Text = "Cancel"
        Me.Button_Empl_Cancel.UseVisualStyleBackColor = True
        '
        'Label_Empl_Password
        '
        Me.Label_Empl_Password.AutoSize = True
        Me.Label_Empl_Password.BackColor = System.Drawing.Color.Transparent
        Me.Label_Empl_Password.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Empl_Password.ForeColor = System.Drawing.Color.Black
        Me.Label_Empl_Password.Location = New System.Drawing.Point(160, 70)
        Me.Label_Empl_Password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Empl_Password.Name = "Label_Empl_Password"
        Me.Label_Empl_Password.Size = New System.Drawing.Size(71, 19)
        Me.Label_Empl_Password.TabIndex = 16
        Me.Label_Empl_Password.Text = "Password"
        '
        'Label_Empl_Username
        '
        Me.Label_Empl_Username.AutoSize = True
        Me.Label_Empl_Username.BackColor = System.Drawing.Color.Transparent
        Me.Label_Empl_Username.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Empl_Username.ForeColor = System.Drawing.Color.Black
        Me.Label_Empl_Username.Location = New System.Drawing.Point(160, 20)
        Me.Label_Empl_Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Empl_Username.Name = "Label_Empl_Username"
        Me.Label_Empl_Username.Size = New System.Drawing.Size(75, 19)
        Me.Label_Empl_Username.TabIndex = 15
        Me.Label_Empl_Username.Text = "Username"
        '
        'Button_Empl_Login
        '
        Me.Button_Empl_Login.BackColor = System.Drawing.Color.White
        Me.Button_Empl_Login.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Empl_Login.ForeColor = System.Drawing.Color.Black
        Me.Button_Empl_Login.Location = New System.Drawing.Point(155, 130)
        Me.Button_Empl_Login.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button_Empl_Login.Name = "Button_Empl_Login"
        Me.Button_Empl_Login.Size = New System.Drawing.Size(85, 30)
        Me.Button_Empl_Login.TabIndex = 2
        Me.Button_Empl_Login.Text = "Login"
        Me.Button_Empl_Login.UseVisualStyleBackColor = True
        '
        'TextBox_Empl_Password
        '
        Me.TextBox_Empl_Password.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextBox_Empl_Password.Location = New System.Drawing.Point(160, 90)
        Me.TextBox_Empl_Password.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox_Empl_Password.Name = "TextBox_Empl_Password"
        Me.TextBox_Empl_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Empl_Password.Size = New System.Drawing.Size(180, 24)
        Me.TextBox_Empl_Password.TabIndex = 1
        '
        'TextBox_Empl_Username
        '
        Me.TextBox_Empl_Username.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextBox_Empl_Username.Location = New System.Drawing.Point(160, 40)
        Me.TextBox_Empl_Username.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox_Empl_Username.Name = "TextBox_Empl_Username"
        Me.TextBox_Empl_Username.Size = New System.Drawing.Size(180, 24)
        Me.TextBox_Empl_Username.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(359, 211)
        Me.Controls.Add(Me.Tabs_Login)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Employee Manager+ | login"
        Me.Tabs_Login.ResumeLayout(False)
        Me.Tab_Administrator.ResumeLayout(False)
        Me.GroupBox_Administrator.ResumeLayout(False)
        Me.GroupBox_Administrator.PerformLayout()
        CType(Me.PictureBox_Admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Employees.ResumeLayout(False)
        Me.GroupBox_Employees.ResumeLayout(False)
        Me.GroupBox_Employees.PerformLayout()
        CType(Me.PictureBox_Empl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs_Login As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Administrator As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox_Administrator As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_Admin As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Admin_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label_Admin_Password As System.Windows.Forms.Label
    Friend WithEvents Label_Admin_Username As System.Windows.Forms.Label
    Friend WithEvents Button_Admin_Login As System.Windows.Forms.Button
    Friend WithEvents TextBox_Admin_Password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Admin_Username As System.Windows.Forms.TextBox
    Friend WithEvents Tab_Employees As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox_Employees As System.Windows.Forms.GroupBox
    Public WithEvents ComboBox_Login As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox_Empl As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Empl_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label_Empl_Password As System.Windows.Forms.Label
    Friend WithEvents Label_Empl_Username As System.Windows.Forms.Label
    Friend WithEvents Button_Empl_Login As System.Windows.Forms.Button
    Friend WithEvents TextBox_Empl_Password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Empl_Username As System.Windows.Forms.TextBox

End Class
