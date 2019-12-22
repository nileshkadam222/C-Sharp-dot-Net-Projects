
Namespace VijayEnggs
	Partial Class frmLogin
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.grbLogin = New System.Windows.Forms.GroupBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.btnLogIn = New System.Windows.Forms.Button()
			Me.txtpassword = New System.Windows.Forms.TextBox()
			Me.txtUserName = New System.Windows.Forms.TextBox()
			Me.lblPassword = New System.Windows.Forms.Label()
			Me.lbluserName = New System.Windows.Forms.Label()
			Me.grbLogin.SuspendLayout()
			Me.SuspendLayout()
			' 
			' grbLogin
			' 
			Me.grbLogin.Controls.Add(Me.label2)
			Me.grbLogin.Controls.Add(Me.label1)
			Me.grbLogin.Controls.Add(Me.btnCancel)
			Me.grbLogin.Controls.Add(Me.btnLogIn)
			Me.grbLogin.Controls.Add(Me.txtpassword)
			Me.grbLogin.Controls.Add(Me.txtUserName)
			Me.grbLogin.Controls.Add(Me.lblPassword)
			Me.grbLogin.Controls.Add(Me.lbluserName)
			Me.grbLogin.Location = New System.Drawing.Point(2, 2)
			Me.grbLogin.Name = "grbLogin"
			Me.grbLogin.Size = New System.Drawing.Size(269, 148)
			Me.grbLogin.TabIndex = 0
			Me.grbLogin.TabStop = False
			Me.grbLogin.Text = "LogIn "
			Me.grbLogin.Enter += New System.EventHandler(Me.grbLogin_Enter)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(0)), CInt(CByte(0)))
			Me.label2.Location = New System.Drawing.Point(92, 59)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(11, 13)
			Me.label2.TabIndex = 7
			Me.label2.Text = "*"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(192)), CInt(CByte(0)), CInt(CByte(0)))
			Me.label1.Location = New System.Drawing.Point(93, 26)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(11, 13)
			Me.label1.TabIndex = 6
			Me.label1.Text = "*"
			' 
			' btnCancel
			' 
			Me.btnCancel.Location = New System.Drawing.Point(201, 85)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(58, 23)
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.Text = "Reset"
			Me.btnCancel.UseVisualStyleBackColor = True
			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click)
			' 
			' btnLogIn
			' 
			Me.btnLogIn.Location = New System.Drawing.Point(125, 85)
			Me.btnLogIn.Name = "btnLogIn"
			Me.btnLogIn.Size = New System.Drawing.Size(57, 23)
			Me.btnLogIn.TabIndex = 3
			Me.btnLogIn.Text = "LogIn"
			Me.btnLogIn.UseVisualStyleBackColor = True
			Me.btnLogIn.Click += New System.EventHandler(Me.btnLogIn_Click)
			' 
			' txtpassword
			' 
			Me.txtpassword.Location = New System.Drawing.Point(109, 52)
			Me.txtpassword.Name = "txtpassword"
			Me.txtpassword.PasswordChar = "*"C
			Me.txtpassword.Size = New System.Drawing.Size(150, 20)
			Me.txtpassword.TabIndex = 2
			Me.txtpassword.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.txtpassword_KeyPress)
			Me.txtpassword.TextChanged += New System.EventHandler(Me.txtpassword_TextChanged)
			Me.txtpassword.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.txtpassword_KeyDown)
			' 
			' txtUserName
			' 
			Me.txtUserName.Location = New System.Drawing.Point(110, 19)
			Me.txtUserName.Name = "txtUserName"
			Me.txtUserName.Size = New System.Drawing.Size(150, 20)
			Me.txtUserName.TabIndex = 1
			Me.txtUserName.TextChanged += New System.EventHandler(Me.txtUserName_TextChanged)
			' 
			' lblPassword
			' 
			Me.lblPassword.AutoSize = True
			Me.lblPassword.Location = New System.Drawing.Point(37, 55)
			Me.lblPassword.Name = "lblPassword"
			Me.lblPassword.Size = New System.Drawing.Size(53, 13)
			Me.lblPassword.TabIndex = 1
			Me.lblPassword.Text = "Password"
			Me.lblPassword.Click += New System.EventHandler(Me.lblPassword_Click)
			' 
			' lbluserName
			' 
			Me.lbluserName.AutoSize = True
			Me.lbluserName.Location = New System.Drawing.Point(37, 22)
			Me.lbluserName.Name = "lbluserName"
			Me.lbluserName.Size = New System.Drawing.Size(60, 13)
			Me.lbluserName.TabIndex = 0
			Me.lbluserName.Text = "User Name"
			' 
			' frmLogin
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(273, 162)
			Me.Controls.Add(Me.grbLogin)
			Me.Name = "frmLogin"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Login"
			Me.TopMost = True
			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.frmLogin_FormClosing)
			Me.Load += New System.EventHandler(Me.frmLogin_Load)
			Me.grbLogin.ResumeLayout(False)
			Me.grbLogin.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private grbLogin As System.Windows.Forms.GroupBox
		Private lblPassword As System.Windows.Forms.Label
		Private lbluserName As System.Windows.Forms.Label
		Private txtpassword As System.Windows.Forms.TextBox
		Private txtUserName As System.Windows.Forms.TextBox
		Private btnCancel As System.Windows.Forms.Button
		Private btnLogIn As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
