
Namespace Shared_Market_System
	Partial Class frmclient_details
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
			Me.btnsave = New System.Windows.Forms.Button()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.lblclient_name = New System.Windows.Forms.Label()
			Me.txtclient_name = New System.Windows.Forms.TextBox()
			Me.txtAddress = New System.Windows.Forms.TextBox()
			Me.lblAddress = New System.Windows.Forms.Label()
			Me.lblContact_no = New System.Windows.Forms.Label()
			Me.txtContact_no = New System.Windows.Forms.TextBox()
			Me.lblClient_id = New System.Windows.Forms.Label()
			Me.txtClient_id = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' btnsave
			' 
			Me.btnsave.Location = New System.Drawing.Point(121, 200)
			Me.btnsave.Name = "btnsave"
			Me.btnsave.Size = New System.Drawing.Size(75, 34)
			Me.btnsave.TabIndex = 5
			Me.btnsave.Text = "SAVE"
			Me.btnsave.UseVisualStyleBackColor = True
			Me.btnsave.Click += New System.EventHandler(Me.btnsave_Click)
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(247, 200)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 34)
			Me.btnexit.TabIndex = 6
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' lblclient_name
			' 
			Me.lblclient_name.AutoSize = True
			Me.lblclient_name.Location = New System.Drawing.Point(12, 56)
			Me.lblclient_name.Name = "lblclient_name"
			Me.lblclient_name.Size = New System.Drawing.Size(100, 13)
			Me.lblclient_name.TabIndex = 2
			Me.lblclient_name.Text = "Name of the Client :"
			' 
			' txtclient_name
			' 
			Me.txtclient_name.Location = New System.Drawing.Point(131, 53)
			Me.txtclient_name.Name = "txtclient_name"
			Me.txtclient_name.Size = New System.Drawing.Size(242, 20)
			Me.txtclient_name.TabIndex = 2
			' 
			' txtAddress
			' 
			Me.txtAddress.Location = New System.Drawing.Point(131, 90)
			Me.txtAddress.Multiline = True
			Me.txtAddress.Name = "txtAddress"
			Me.txtAddress.Size = New System.Drawing.Size(242, 39)
			Me.txtAddress.TabIndex = 3
			' 
			' lblAddress
			' 
			Me.lblAddress.AutoSize = True
			Me.lblAddress.Location = New System.Drawing.Point(12, 103)
			Me.lblAddress.Name = "lblAddress"
			Me.lblAddress.Size = New System.Drawing.Size(48, 13)
			Me.lblAddress.TabIndex = 7
			Me.lblAddress.Text = "Address:"
			' 
			' lblContact_no
			' 
			Me.lblContact_no.AutoSize = True
			Me.lblContact_no.Location = New System.Drawing.Point(12, 145)
			Me.lblContact_no.Name = "lblContact_no"
			Me.lblContact_no.Size = New System.Drawing.Size(64, 13)
			Me.lblContact_no.TabIndex = 8
			Me.lblContact_no.Text = "Contact No:"
			' 
			' txtContact_no
			' 
			Me.txtContact_no.Location = New System.Drawing.Point(131, 145)
			Me.txtContact_no.Name = "txtContact_no"
			Me.txtContact_no.Size = New System.Drawing.Size(242, 20)
			Me.txtContact_no.TabIndex = 4
			Me.txtContact_no.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.txtContact_no_KeyPress)
			' 
			' lblClient_id
			' 
			Me.lblClient_id.AutoSize = True
			Me.lblClient_id.Location = New System.Drawing.Point(12, 27)
			Me.lblClient_id.Name = "lblClient_id"
			Me.lblClient_id.Size = New System.Drawing.Size(47, 13)
			Me.lblClient_id.TabIndex = 10
			Me.lblClient_id.Text = "Client ID"
			' 
			' txtClient_id
			' 
			Me.txtClient_id.Location = New System.Drawing.Point(131, 24)
			Me.txtClient_id.Name = "txtClient_id"
			Me.txtClient_id.[ReadOnly] = True
			Me.txtClient_id.Size = New System.Drawing.Size(242, 20)
			Me.txtClient_id.TabIndex = 1
			Me.txtClient_id.TabStop = False
			' 
			' frmclient_details
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(457, 260)
			Me.Controls.Add(Me.txtClient_id)
			Me.Controls.Add(Me.lblClient_id)
			Me.Controls.Add(Me.txtContact_no)
			Me.Controls.Add(Me.lblContact_no)
			Me.Controls.Add(Me.txtAddress)
			Me.Controls.Add(Me.lblAddress)
			Me.Controls.Add(Me.txtclient_name)
			Me.Controls.Add(Me.lblclient_name)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnsave)
			Me.Name = "frmclient_details"
			Me.Text = "Client Details"
			Me.Load += New System.EventHandler(Me.frmclient_details_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private btnsave As System.Windows.Forms.Button
		Private btnexit As System.Windows.Forms.Button
		Private lblclient_name As System.Windows.Forms.Label
		Private txtclient_name As System.Windows.Forms.TextBox
		Private txtAddress As System.Windows.Forms.TextBox
		Private lblAddress As System.Windows.Forms.Label
		Private lblContact_no As System.Windows.Forms.Label
		Private txtContact_no As System.Windows.Forms.TextBox
		Private lblClient_id As System.Windows.Forms.Label
		Private txtClient_id As System.Windows.Forms.TextBox
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
