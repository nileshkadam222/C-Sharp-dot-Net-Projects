
Namespace Shared_Market_System
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
			Me.lbluserid = New System.Windows.Forms.Label()
			Me.txtuserid = New System.Windows.Forms.TextBox()
			Me.txtpassword = New System.Windows.Forms.TextBox()
			Me.lblpassword = New System.Windows.Forms.Label()
			Me.btnlogin = New System.Windows.Forms.Button()
			Me.btnreset = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' lbluserid
			' 
			Me.lbluserid.AutoSize = True
			Me.lbluserid.Location = New System.Drawing.Point(44, 36)
			Me.lbluserid.Name = "lbluserid"
			Me.lbluserid.Size = New System.Drawing.Size(47, 13)
			Me.lbluserid.TabIndex = 0
			Me.lbluserid.Text = "User Id :"
			' 
			' txtuserid
			' 
			Me.txtuserid.Location = New System.Drawing.Point(124, 33)
			Me.txtuserid.Name = "txtuserid"
			Me.txtuserid.Size = New System.Drawing.Size(115, 20)
			Me.txtuserid.TabIndex = 1
			' 
			' txtpassword
			' 
			Me.txtpassword.Location = New System.Drawing.Point(124, 75)
			Me.txtpassword.Name = "txtpassword"
			Me.txtpassword.Size = New System.Drawing.Size(115, 20)
			Me.txtpassword.TabIndex = 2
			Me.txtpassword.UseSystemPasswordChar = True
			Me.txtpassword.TextChanged += New System.EventHandler(Me.txtpassword_TextChanged)
			Me.txtpassword.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.txtpassword_KeyDown_1)
			' 
			' lblpassword
			' 
			Me.lblpassword.AutoSize = True
			Me.lblpassword.Location = New System.Drawing.Point(44, 78)
			Me.lblpassword.Name = "lblpassword"
			Me.lblpassword.Size = New System.Drawing.Size(59, 13)
			Me.lblpassword.TabIndex = 3
			Me.lblpassword.Text = "Password :"
			' 
			' btnlogin
			' 
			Me.btnlogin.Location = New System.Drawing.Point(47, 139)
			Me.btnlogin.Name = "btnlogin"
			Me.btnlogin.Size = New System.Drawing.Size(78, 30)
			Me.btnlogin.TabIndex = 4
			Me.btnlogin.Text = "LOGIN"
			Me.btnlogin.UseVisualStyleBackColor = True
			Me.btnlogin.Click += New System.EventHandler(Me.btnlogin_Click)
			' 
			' btnreset
			' 
			Me.btnreset.Location = New System.Drawing.Point(161, 139)
			Me.btnreset.Name = "btnreset"
			Me.btnreset.Size = New System.Drawing.Size(78, 30)
			Me.btnreset.TabIndex = 5
			Me.btnreset.Text = "RESET"
			Me.btnreset.UseVisualStyleBackColor = True
			Me.btnreset.Click += New System.EventHandler(Me.btnreset_Click)
			' 
			' frmLogin
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(293, 200)
			Me.Controls.Add(Me.btnreset)
			Me.Controls.Add(Me.btnlogin)
			Me.Controls.Add(Me.lblpassword)
			Me.Controls.Add(Me.txtpassword)
			Me.Controls.Add(Me.txtuserid)
			Me.Controls.Add(Me.lbluserid)
			Me.Name = "frmLogin"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Login"
			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.frmLogin_FormClosing_1)
			Me.Load += New System.EventHandler(Me.frmLogin_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lbluserid As System.Windows.Forms.Label
		Private txtuserid As System.Windows.Forms.TextBox
		Private txtpassword As System.Windows.Forms.TextBox
		Private lblpassword As System.Windows.Forms.Label
		Private btnlogin As System.Windows.Forms.Button
		Private btnreset As System.Windows.Forms.Button
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
