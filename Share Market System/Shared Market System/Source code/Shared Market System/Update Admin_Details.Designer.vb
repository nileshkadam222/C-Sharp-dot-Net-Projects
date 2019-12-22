
Namespace Shared_Market_System
	Partial Class frmUpdate_Admin_Details
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.txtshares = New System.Windows.Forms.TextBox()
			Me.lblshares = New System.Windows.Forms.Label()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.btnUpdate = New System.Windows.Forms.Button()
			Me.cboadmin_type = New System.Windows.Forms.ComboBox()
			Me.lbladmin_type = New System.Windows.Forms.Label()
			Me.lbladmin_name = New System.Windows.Forms.Label()
			Me.cboAdmin_name = New System.Windows.Forms.ComboBox()
			Me.txtCompany_name = New System.Windows.Forms.TextBox()
			Me.btnDelete = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(92, 105)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(82, 13)
			Me.label1.TabIndex = 21
			Me.label1.Text = "Company Name"
			' 
			' txtshares
			' 
			Me.txtshares.Location = New System.Drawing.Point(201, 147)
			Me.txtshares.Name = "txtshares"
			Me.txtshares.Size = New System.Drawing.Size(244, 20)
			Me.txtshares.TabIndex = 3
			Me.txtshares.TextChanged += New System.EventHandler(Me.txtshares_TextChanged)
			Me.txtshares.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.txtshares_KeyPress)
			' 
			' lblshares
			' 
			Me.lblshares.AutoSize = True
			Me.lblshares.Location = New System.Drawing.Point(92, 150)
			Me.lblshares.Name = "lblshares"
			Me.lblshares.Size = New System.Drawing.Size(105, 13)
			Me.lblshares.TabIndex = 20
			Me.lblshares.Text = "Total No. of Shares :"
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(340, 196)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 31)
			Me.btnexit.TabIndex = 6
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' btnUpdate
			' 
			Me.btnUpdate.Location = New System.Drawing.Point(109, 196)
			Me.btnUpdate.Name = "btnUpdate"
			Me.btnUpdate.Size = New System.Drawing.Size(75, 31)
			Me.btnUpdate.TabIndex = 4
			Me.btnUpdate.Text = "UPDATE"
			Me.btnUpdate.UseVisualStyleBackColor = True
			Me.btnUpdate.Click += New System.EventHandler(Me.btnUpdate_Click)
			' 
			' cboadmin_type
			' 
			Me.cboadmin_type.FormattingEnabled = True
			Me.cboadmin_type.Items.AddRange(New Object() {"BSE", "NSE"})
			Me.cboadmin_type.Location = New System.Drawing.Point(201, 61)
			Me.cboadmin_type.Name = "cboadmin_type"
			Me.cboadmin_type.Size = New System.Drawing.Size(244, 21)
			Me.cboadmin_type.TabIndex = 1
			Me.cboadmin_type.SelectedIndexChanged += New System.EventHandler(Me.cboadmin_type_SelectedIndexChanged)
			' 
			' lbladmin_type
			' 
			Me.lbladmin_type.AutoSize = True
			Me.lbladmin_type.Location = New System.Drawing.Point(92, 69)
			Me.lbladmin_type.Name = "lbladmin_type"
			Me.lbladmin_type.Size = New System.Drawing.Size(34, 13)
			Me.lbladmin_type.TabIndex = 15
			Me.lbladmin_type.Text = "Type "
			' 
			' lbladmin_name
			' 
			Me.lbladmin_name.AutoSize = True
			Me.lbladmin_name.Location = New System.Drawing.Point(92, 28)
			Me.lbladmin_name.Name = "lbladmin_name"
			Me.lbladmin_name.Size = New System.Drawing.Size(67, 13)
			Me.lbladmin_name.TabIndex = 12
			Me.lbladmin_name.Text = "Admin Name"
			' 
			' cboAdmin_name
			' 
			Me.cboAdmin_name.FormattingEnabled = True
			Me.cboAdmin_name.Location = New System.Drawing.Point(201, 25)
			Me.cboAdmin_name.Name = "cboAdmin_name"
			Me.cboAdmin_name.Size = New System.Drawing.Size(244, 21)
			Me.cboAdmin_name.TabIndex = 0
			Me.cboAdmin_name.SelectedIndexChanged += New System.EventHandler(Me.cboAdmin_name_SelectedIndexChanged)
			' 
			' txtCompany_name
			' 
			Me.txtCompany_name.Location = New System.Drawing.Point(201, 105)
			Me.txtCompany_name.Name = "txtCompany_name"
			Me.txtCompany_name.[ReadOnly] = True
			Me.txtCompany_name.Size = New System.Drawing.Size(244, 20)
			Me.txtCompany_name.TabIndex = 2
			Me.txtCompany_name.TabStop = False
			' 
			' btnDelete
			' 
			Me.btnDelete.Location = New System.Drawing.Point(223, 196)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New System.Drawing.Size(75, 31)
			Me.btnDelete.TabIndex = 5
			Me.btnDelete.Text = "DELETE"
			Me.btnDelete.UseVisualStyleBackColor = True
			Me.btnDelete.Click += New System.EventHandler(Me.btnDelete_Click)
			' 
			' frmUpdate_Admin_Details
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(538, 296)
			Me.Controls.Add(Me.btnDelete)
			Me.Controls.Add(Me.txtCompany_name)
			Me.Controls.Add(Me.cboAdmin_name)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.txtshares)
			Me.Controls.Add(Me.lblshares)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnUpdate)
			Me.Controls.Add(Me.cboadmin_type)
			Me.Controls.Add(Me.lbladmin_type)
			Me.Controls.Add(Me.lbladmin_name)
			Me.Name = "frmUpdate_Admin_Details"
			Me.Text = "Update Admin Details"
			Me.Load += New System.EventHandler(Me.Update_Admin_Details_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txtshares As System.Windows.Forms.TextBox
		Private lblshares As System.Windows.Forms.Label
		Private btnexit As System.Windows.Forms.Button
		Private btnUpdate As System.Windows.Forms.Button
		Private cboadmin_type As System.Windows.Forms.ComboBox
		Private lbladmin_type As System.Windows.Forms.Label
		Private lbladmin_name As System.Windows.Forms.Label
		Private cboAdmin_name As System.Windows.Forms.ComboBox
		Private txtCompany_name As System.Windows.Forms.TextBox
		Private btnDelete As System.Windows.Forms.Button
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
