
Namespace Shared_Market_System
	Partial Class frmUpdateClient_Details
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
			Me.txtContact_no = New System.Windows.Forms.TextBox()
			Me.lblContact_no = New System.Windows.Forms.Label()
			Me.txtAddress = New System.Windows.Forms.TextBox()
			Me.lblAddress = New System.Windows.Forms.Label()
			Me.lblclient_name = New System.Windows.Forms.Label()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.btnUpdate = New System.Windows.Forms.Button()
			Me.cboClient_name = New System.Windows.Forms.ComboBox()
			Me.btnDelete = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' txtContact_no
			' 
			Me.txtContact_no.Location = New System.Drawing.Point(139, 141)
			Me.txtContact_no.Name = "txtContact_no"
			Me.txtContact_no.Size = New System.Drawing.Size(242, 20)
			Me.txtContact_no.TabIndex = 3
			Me.txtContact_no.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.txtContact_no_KeyPress)
			' 
			' lblContact_no
			' 
			Me.lblContact_no.AutoSize = True
			Me.lblContact_no.Location = New System.Drawing.Point(30, 148)
			Me.lblContact_no.Name = "lblContact_no"
			Me.lblContact_no.Size = New System.Drawing.Size(64, 13)
			Me.lblContact_no.TabIndex = 19
			Me.lblContact_no.Text = "Contact No:"
			' 
			' txtAddress
			' 
			Me.txtAddress.Location = New System.Drawing.Point(139, 78)
			Me.txtAddress.Multiline = True
			Me.txtAddress.Name = "txtAddress"
			Me.txtAddress.Size = New System.Drawing.Size(242, 39)
			Me.txtAddress.TabIndex = 2
			' 
			' lblAddress
			' 
			Me.lblAddress.AutoSize = True
			Me.lblAddress.Location = New System.Drawing.Point(30, 81)
			Me.lblAddress.Name = "lblAddress"
			Me.lblAddress.Size = New System.Drawing.Size(48, 13)
			Me.lblAddress.TabIndex = 18
			Me.lblAddress.Text = "Address:"
			' 
			' lblclient_name
			' 
			Me.lblclient_name.AutoSize = True
			Me.lblclient_name.Location = New System.Drawing.Point(30, 45)
			Me.lblclient_name.Name = "lblclient_name"
			Me.lblclient_name.Size = New System.Drawing.Size(64, 13)
			Me.lblclient_name.TabIndex = 13
			Me.lblclient_name.Text = "Client Name"
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(271, 221)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 34)
			Me.btnexit.TabIndex = 6
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' btnUpdate
			' 
			Me.btnUpdate.Location = New System.Drawing.Point(50, 221)
			Me.btnUpdate.Name = "btnUpdate"
			Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
			Me.btnUpdate.TabIndex = 4
			Me.btnUpdate.Text = "UPDATE"
			Me.btnUpdate.UseVisualStyleBackColor = True
			Me.btnUpdate.Click += New System.EventHandler(Me.btnUpdate_Click)
			' 
			' cboClient_name
			' 
			Me.cboClient_name.FormattingEnabled = True
			Me.cboClient_name.Location = New System.Drawing.Point(139, 42)
			Me.cboClient_name.Name = "cboClient_name"
			Me.cboClient_name.Size = New System.Drawing.Size(242, 21)
			Me.cboClient_name.TabIndex = 1
			Me.cboClient_name.SelectedIndexChanged += New System.EventHandler(Me.cboClient_name_SelectedIndexChanged)
			' 
			' btnDelete
			' 
			Me.btnDelete.Location = New System.Drawing.Point(162, 221)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New System.Drawing.Size(75, 34)
			Me.btnDelete.TabIndex = 5
			Me.btnDelete.Text = "DELETE"
			Me.btnDelete.UseVisualStyleBackColor = True
			Me.btnDelete.Click += New System.EventHandler(Me.btnDelete_Click)
			' 
			' frmUpdateClient_Details
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(401, 300)
			Me.Controls.Add(Me.btnDelete)
			Me.Controls.Add(Me.cboClient_name)
			Me.Controls.Add(Me.txtContact_no)
			Me.Controls.Add(Me.lblContact_no)
			Me.Controls.Add(Me.txtAddress)
			Me.Controls.Add(Me.lblAddress)
			Me.Controls.Add(Me.lblclient_name)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnUpdate)
			Me.Name = "frmUpdateClient_Details"
			Me.Text = "Client Details"
			Me.Load += New System.EventHandler(Me.frmUpdateClient_Details_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private txtContact_no As System.Windows.Forms.TextBox
		Private lblContact_no As System.Windows.Forms.Label
		Private txtAddress As System.Windows.Forms.TextBox
		Private lblAddress As System.Windows.Forms.Label
		Private lblclient_name As System.Windows.Forms.Label
		Private btnexit As System.Windows.Forms.Button
		Private btnUpdate As System.Windows.Forms.Button
		Private cboClient_name As System.Windows.Forms.ComboBox
		Private btnDelete As System.Windows.Forms.Button
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
