
Namespace Shared_Market_System
	Partial Class frmclient_shares
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
			Me.cboclient_name = New System.Windows.Forms.ComboBox()
			Me.drvclient = New System.Windows.Forms.DataGridView()
			Me.lblclient_name = New System.Windows.Forms.Label()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.btnsave = New System.Windows.Forms.Button()
			Me.cboCompany_name = New System.Windows.Forms.ComboBox()
			Me.lblCompany_name = New System.Windows.Forms.Label()
			Me.dtpdate = New System.Windows.Forms.DateTimePicker()
			DirectCast(Me.drvclient, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cboclient_name
			' 
			Me.cboclient_name.FormattingEnabled = True
			Me.cboclient_name.Location = New System.Drawing.Point(145, 17)
			Me.cboclient_name.Name = "cboclient_name"
			Me.cboclient_name.Size = New System.Drawing.Size(212, 21)
			Me.cboclient_name.TabIndex = 1
			Me.cboclient_name.SelectedIndexChanged += New System.EventHandler(Me.cboclient_name_SelectedIndexChanged)
			' 
			' drvclient
			' 
			Me.drvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.drvclient.Location = New System.Drawing.Point(21, 69)
			Me.drvclient.Name = "drvclient"
			Me.drvclient.Size = New System.Drawing.Size(822, 150)
			Me.drvclient.TabIndex = 2
			Me.drvclient.CellBeginEdit += New System.Windows.Forms.DataGridViewCellCancelEventHandler(Me.drvclient_CellBeginEdit)
			Me.drvclient.CellClick += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drvclient_CellClick)
			Me.drvclient.CellEndEdit += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drvclient_CellEndEdit)
			Me.drvclient.CellMouseClick += New System.Windows.Forms.DataGridViewCellMouseEventHandler(Me.drvclient_CellMouseClick)
			' 
			' lblclient_name
			' 
			Me.lblclient_name.AutoSize = True
			Me.lblclient_name.Location = New System.Drawing.Point(30, 20)
			Me.lblclient_name.Name = "lblclient_name"
			Me.lblclient_name.Size = New System.Drawing.Size(100, 13)
			Me.lblclient_name.TabIndex = 6
			Me.lblclient_name.Text = "Name of the Client :"
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(426, 225)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 34)
			Me.btnexit.TabIndex = 4
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' btnsave
			' 
			Me.btnsave.Location = New System.Drawing.Point(293, 225)
			Me.btnsave.Name = "btnsave"
			Me.btnsave.Size = New System.Drawing.Size(75, 34)
			Me.btnsave.TabIndex = 3
			Me.btnsave.Text = "SAVE"
			Me.btnsave.UseVisualStyleBackColor = True
			Me.btnsave.Click += New System.EventHandler(Me.btnsave_Click)
			' 
			' cboCompany_name
			' 
			Me.cboCompany_name.FormattingEnabled = True
			Me.cboCompany_name.Location = New System.Drawing.Point(485, 17)
			Me.cboCompany_name.Name = "cboCompany_name"
			Me.cboCompany_name.Size = New System.Drawing.Size(212, 21)
			Me.cboCompany_name.TabIndex = 12
			Me.cboCompany_name.SelectedIndexChanged += New System.EventHandler(Me.cboCompany_name_SelectedIndexChanged)
			' 
			' lblCompany_name
			' 
			Me.lblCompany_name.AutoSize = True
			Me.lblCompany_name.Location = New System.Drawing.Point(385, 20)
			Me.lblCompany_name.Name = "lblCompany_name"
			Me.lblCompany_name.Size = New System.Drawing.Size(82, 13)
			Me.lblCompany_name.TabIndex = 13
			Me.lblCompany_name.Text = "Company Name"
			' 
			' dtpdate
			' 
			Me.dtpdate.CustomFormat = "dd/MM/yyyy"
			Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
			Me.dtpdate.Location = New System.Drawing.Point(271, 69)
			Me.dtpdate.Name = "dtpdate"
			Me.dtpdate.Size = New System.Drawing.Size(86, 20)
			Me.dtpdate.TabIndex = 11
			Me.dtpdate.Visible = False
			Me.dtpdate.ValueChanged += New System.EventHandler(Me.dtpdate_ValueChanged)
			' 
			' frmclient_shares
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(855, 271)
			Me.Controls.Add(Me.lblCompany_name)
			Me.Controls.Add(Me.cboCompany_name)
			Me.Controls.Add(Me.dtpdate)
			Me.Controls.Add(Me.cboclient_name)
			Me.Controls.Add(Me.drvclient)
			Me.Controls.Add(Me.lblclient_name)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnsave)
			Me.Name = "frmclient_shares"
			Me.Text = "Client Shares"
			Me.Load += New System.EventHandler(Me.frmclient_shares_Load)
			DirectCast(Me.drvclient, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private cboclient_name As System.Windows.Forms.ComboBox
		Private drvclient As System.Windows.Forms.DataGridView
		Private lblclient_name As System.Windows.Forms.Label
		Private btnexit As System.Windows.Forms.Button
		Private btnsave As System.Windows.Forms.Button
		Private cboCompany_name As System.Windows.Forms.ComboBox
		Private lblCompany_name As System.Windows.Forms.Label
		Private dtpdate As System.Windows.Forms.DateTimePicker
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
