
Namespace Shared_Market_System
	Partial Class frmcompany
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
			Me.lblcompany_name = New System.Windows.Forms.Label()
			Me.txtcompany_name = New System.Windows.Forms.TextBox()
			Me.grpstock = New System.Windows.Forms.GroupBox()
			Me.txtno_shares = New System.Windows.Forms.TextBox()
			Me.lblno_shares = New System.Windows.Forms.Label()
			Me.dtpCompany = New System.Windows.Forms.DateTimePicker()
			Me.lbldate = New System.Windows.Forms.Label()
			Me.txtrate = New System.Windows.Forms.TextBox()
			Me.lblrate = New System.Windows.Forms.Label()
			Me.btnsave = New System.Windows.Forms.Button()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.grpstock.SuspendLayout()
			Me.SuspendLayout()
			' 
			' lblcompany_name
			' 
			Me.lblcompany_name.AutoSize = True
			Me.lblcompany_name.Location = New System.Drawing.Point(15, 35)
			Me.lblcompany_name.Name = "lblcompany_name"
			Me.lblcompany_name.Size = New System.Drawing.Size(118, 13)
			Me.lblcompany_name.TabIndex = 0
			Me.lblcompany_name.Text = "Name of the Company :"
			' 
			' txtcompany_name
			' 
			Me.txtcompany_name.Location = New System.Drawing.Point(139, 32)
			Me.txtcompany_name.Name = "txtcompany_name"
			Me.txtcompany_name.Size = New System.Drawing.Size(142, 20)
			Me.txtcompany_name.TabIndex = 1
			Me.txtcompany_name.TextChanged += New System.EventHandler(Me.txtcompany_name_TextChanged)
			' 
			' grpstock
			' 
			Me.grpstock.Controls.Add(Me.txtno_shares)
			Me.grpstock.Controls.Add(Me.lblno_shares)
			Me.grpstock.Controls.Add(Me.dtpCompany)
			Me.grpstock.Controls.Add(Me.lbldate)
			Me.grpstock.Location = New System.Drawing.Point(12, 74)
			Me.grpstock.Name = "grpstock"
			Me.grpstock.Size = New System.Drawing.Size(531, 87)
			Me.grpstock.TabIndex = 2
			Me.grpstock.TabStop = False
			Me.grpstock.Text = "Stock "
			' 
			' txtno_shares
			' 
			Me.txtno_shares.Location = New System.Drawing.Point(124, 39)
			Me.txtno_shares.Name = "txtno_shares"
			Me.txtno_shares.Size = New System.Drawing.Size(155, 20)
			Me.txtno_shares.TabIndex = 3
			' 
			' lblno_shares
			' 
			Me.lblno_shares.AutoSize = True
			Me.lblno_shares.Location = New System.Drawing.Point(15, 42)
			Me.lblno_shares.Name = "lblno_shares"
			Me.lblno_shares.Size = New System.Drawing.Size(81, 13)
			Me.lblno_shares.TabIndex = 3
			Me.lblno_shares.Text = "No. of Shares : "
			' 
			' dtpCompany
			' 
			Me.dtpCompany.CustomFormat = "dd/MM/yyyy"
			Me.dtpCompany.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
			Me.dtpCompany.Location = New System.Drawing.Point(347, 39)
			Me.dtpCompany.Name = "dtpCompany"
			Me.dtpCompany.Size = New System.Drawing.Size(142, 20)
			Me.dtpCompany.TabIndex = 4
			Me.dtpCompany.ValueChanged += New System.EventHandler(Me.dateTimePicker1_ValueChanged)
			' 
			' lbldate
			' 
			Me.lbldate.AutoSize = True
			Me.lbldate.Location = New System.Drawing.Point(305, 43)
			Me.lbldate.Name = "lbldate"
			Me.lbldate.Size = New System.Drawing.Size(36, 13)
			Me.lbldate.TabIndex = 3
			Me.lbldate.Text = "Date :"
			' 
			' txtrate
			' 
			Me.txtrate.Location = New System.Drawing.Point(359, 45)
			Me.txtrate.Name = "txtrate"
			Me.txtrate.Size = New System.Drawing.Size(142, 20)
			Me.txtrate.TabIndex = 4
			Me.txtrate.Visible = False
			' 
			' lblrate
			' 
			Me.lblrate.AutoSize = True
			Me.lblrate.Location = New System.Drawing.Point(317, 48)
			Me.lblrate.Name = "lblrate"
			Me.lblrate.Size = New System.Drawing.Size(36, 13)
			Me.lblrate.TabIndex = 5
			Me.lblrate.Text = "Rate :"
			Me.lblrate.Visible = False
			' 
			' btnsave
			' 
			Me.btnsave.Location = New System.Drawing.Point(170, 185)
			Me.btnsave.Name = "btnsave"
			Me.btnsave.Size = New System.Drawing.Size(75, 29)
			Me.btnsave.TabIndex = 5
			Me.btnsave.Text = "SAVE"
			Me.btnsave.UseVisualStyleBackColor = True
			Me.btnsave.Click += New System.EventHandler(Me.btnsave_Click)
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(289, 185)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 29)
			Me.btnexit.TabIndex = 6
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' frmcompany
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(558, 234)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnsave)
			Me.Controls.Add(Me.grpstock)
			Me.Controls.Add(Me.txtcompany_name)
			Me.Controls.Add(Me.lblrate)
			Me.Controls.Add(Me.txtrate)
			Me.Controls.Add(Me.lblcompany_name)
			Me.Name = "frmcompany"
			Me.Text = "Company Details"
			Me.Load += New System.EventHandler(Me.frmcompany_Load)
			Me.grpstock.ResumeLayout(False)
			Me.grpstock.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblcompany_name As System.Windows.Forms.Label
		Private txtcompany_name As System.Windows.Forms.TextBox
		Private grpstock As System.Windows.Forms.GroupBox
		Private txtno_shares As System.Windows.Forms.TextBox
		Private lblno_shares As System.Windows.Forms.Label
		Private lbldate As System.Windows.Forms.Label
		Private dtpCompany As System.Windows.Forms.DateTimePicker
		Private lblrate As System.Windows.Forms.Label
		Private txtrate As System.Windows.Forms.TextBox
		Private btnsave As System.Windows.Forms.Button
		Private btnexit As System.Windows.Forms.Button
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
