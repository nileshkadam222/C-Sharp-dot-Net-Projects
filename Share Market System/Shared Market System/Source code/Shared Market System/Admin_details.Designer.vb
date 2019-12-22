
Namespace Shared_Market_System
	Partial Class frmadmin_details
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
			Me.lbladmin_name = New System.Windows.Forms.Label()
			Me.txtadmin_name = New System.Windows.Forms.TextBox()
			Me.lbladmin_type = New System.Windows.Forms.Label()
			Me.cboadmin_type = New System.Windows.Forms.ComboBox()
			Me.btnsave = New System.Windows.Forms.Button()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.lblshares = New System.Windows.Forms.Label()
			Me.txtshares = New System.Windows.Forms.TextBox()
			Me.cboCompany_name = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' lbladmin_name
			' 
			Me.lbladmin_name.AutoSize = True
			Me.lbladmin_name.Location = New System.Drawing.Point(28, 26)
			Me.lbladmin_name.Name = "lbladmin_name"
			Me.lbladmin_name.Size = New System.Drawing.Size(67, 13)
			Me.lbladmin_name.TabIndex = 0
			Me.lbladmin_name.Text = "Admin Name"
			' 
			' txtadmin_name
			' 
			Me.txtadmin_name.Location = New System.Drawing.Point(137, 23)
			Me.txtadmin_name.Name = "txtadmin_name"
			Me.txtadmin_name.Size = New System.Drawing.Size(244, 20)
			Me.txtadmin_name.TabIndex = 1
			' 
			' lbladmin_type
			' 
			Me.lbladmin_type.AutoSize = True
			Me.lbladmin_type.Location = New System.Drawing.Point(28, 67)
			Me.lbladmin_type.Name = "lbladmin_type"
			Me.lbladmin_type.Size = New System.Drawing.Size(34, 13)
			Me.lbladmin_type.TabIndex = 2
			Me.lbladmin_type.Text = "Type "
			' 
			' cboadmin_type
			' 
			Me.cboadmin_type.FormattingEnabled = True
			Me.cboadmin_type.Items.AddRange(New Object() {"BSE", "NSE"})
			Me.cboadmin_type.Location = New System.Drawing.Point(137, 59)
			Me.cboadmin_type.Name = "cboadmin_type"
			Me.cboadmin_type.Size = New System.Drawing.Size(244, 21)
			Me.cboadmin_type.TabIndex = 2
			Me.cboadmin_type.SelectedIndexChanged += New System.EventHandler(Me.cboadmin_type_SelectedIndexChanged)
			' 
			' btnsave
			' 
			Me.btnsave.Location = New System.Drawing.Point(137, 204)
			Me.btnsave.Name = "btnsave"
			Me.btnsave.Size = New System.Drawing.Size(75, 31)
			Me.btnsave.TabIndex = 5
			Me.btnsave.Text = "SAVE"
			Me.btnsave.UseVisualStyleBackColor = True
			Me.btnsave.Click += New System.EventHandler(Me.btnsave_Click)
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(254, 204)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 31)
			Me.btnexit.TabIndex = 6
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' lblshares
			' 
			Me.lblshares.AutoSize = True
			Me.lblshares.Location = New System.Drawing.Point(28, 148)
			Me.lblshares.Name = "lblshares"
			Me.lblshares.Size = New System.Drawing.Size(105, 13)
			Me.lblshares.TabIndex = 8
			Me.lblshares.Text = "Total No. of Shares :"
			' 
			' txtshares
			' 
			Me.txtshares.Location = New System.Drawing.Point(137, 145)
			Me.txtshares.Name = "txtshares"
			Me.txtshares.Size = New System.Drawing.Size(244, 20)
			Me.txtshares.TabIndex = 4
			' 
			' cboCompany_name
			' 
			Me.cboCompany_name.FormattingEnabled = True
			Me.cboCompany_name.Location = New System.Drawing.Point(137, 100)
			Me.cboCompany_name.Name = "cboCompany_name"
			Me.cboCompany_name.Size = New System.Drawing.Size(244, 21)
			Me.cboCompany_name.TabIndex = 3
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(28, 103)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(82, 13)
			Me.label1.TabIndex = 11
			Me.label1.Text = "Company Name"
			' 
			' frmadmin_details
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(441, 306)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.cboCompany_name)
			Me.Controls.Add(Me.txtshares)
			Me.Controls.Add(Me.lblshares)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnsave)
			Me.Controls.Add(Me.cboadmin_type)
			Me.Controls.Add(Me.lbladmin_type)
			Me.Controls.Add(Me.txtadmin_name)
			Me.Controls.Add(Me.lbladmin_name)
			Me.Name = "frmadmin_details"
			Me.Text = "Admin Details"
			Me.Load += New System.EventHandler(Me.frmadmin_details_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lbladmin_name As System.Windows.Forms.Label
		Private txtadmin_name As System.Windows.Forms.TextBox
		Private lbladmin_type As System.Windows.Forms.Label
		Private cboadmin_type As System.Windows.Forms.ComboBox
		Private btnsave As System.Windows.Forms.Button
		Private btnexit As System.Windows.Forms.Button
		Private lblshares As System.Windows.Forms.Label
		Private txtshares As System.Windows.Forms.TextBox
		Private cboCompany_name As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
