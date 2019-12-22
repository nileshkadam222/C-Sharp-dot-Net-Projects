
Namespace Shared_Market_System
	Partial Class frmbroker_shares
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
			Me.lblbroker_name = New System.Windows.Forms.Label()
			Me.drv_broker1 = New System.Windows.Forms.DataGridView()
			Me.drv_broker2 = New System.Windows.Forms.DataGridView()
			Me.lblshare_info = New System.Windows.Forms.Label()
			Me.btnsave = New System.Windows.Forms.Button()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.cbobroker = New System.Windows.Forms.ComboBox()
			Me.lblclient_shares = New System.Windows.Forms.Label()
			Me.btnviewall = New System.Windows.Forms.Button()
			Me.dtpdate1 = New System.Windows.Forms.DateTimePicker()
			Me.lblDate = New System.Windows.Forms.Label()
			Me.dtpDate = New System.Windows.Forms.DateTimePicker()
			Me.cbocompany_name = New System.Windows.Forms.ComboBox()
			Me.lblCompany_name = New System.Windows.Forms.Label()
			DirectCast(Me.drv_broker1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.drv_broker2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblbroker_name
			' 
			Me.lblbroker_name.AutoSize = True
			Me.lblbroker_name.Location = New System.Drawing.Point(352, 23)
			Me.lblbroker_name.Name = "lblbroker_name"
			Me.lblbroker_name.Size = New System.Drawing.Size(72, 13)
			Me.lblbroker_name.TabIndex = 0
			Me.lblbroker_name.Text = "Broker Name:"
			' 
			' drv_broker1
			' 
			Me.drv_broker1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.drv_broker1.Location = New System.Drawing.Point(12, 105)
			Me.drv_broker1.Name = "drv_broker1"
			Me.drv_broker1.[ReadOnly] = True
			Me.drv_broker1.Size = New System.Drawing.Size(917, 149)
			Me.drv_broker1.TabIndex = 3
			Me.drv_broker1.CellBeginEdit += New System.Windows.Forms.DataGridViewCellCancelEventHandler(Me.drv_broker1_CellBeginEdit)
			Me.drv_broker1.CellMouseClick += New System.Windows.Forms.DataGridViewCellMouseEventHandler(Me.drv_broker1_CellMouseClick)
			Me.drv_broker1.CellContentClick += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drv_broker1_CellContentClick)
			' 
			' drv_broker2
			' 
			Me.drv_broker2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.drv_broker2.Location = New System.Drawing.Point(12, 394)
			Me.drv_broker2.Name = "drv_broker2"
			Me.drv_broker2.Size = New System.Drawing.Size(917, 153)
			Me.drv_broker2.TabIndex = 5
			Me.drv_broker2.CellBeginEdit += New System.Windows.Forms.DataGridViewCellCancelEventHandler(Me.drv_broker2_CellBeginEdit)
			Me.drv_broker2.CellLeave += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drv_broker2_CellLeave)
			Me.drv_broker2.CellClick += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drv_broker2_CellClick)
			Me.drv_broker2.CellEndEdit += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drv_broker2_CellEndEdit)
			Me.drv_broker2.CellMouseClick += New System.Windows.Forms.DataGridViewCellMouseEventHandler(Me.drv_broker2_CellMouseClick)
			Me.drv_broker2.SelectionChanged += New System.EventHandler(Me.drv_broker2_SelectionChanged)
			Me.drv_broker2.CellContentClick += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drv_broker2_CellContentClick)
			' 
			' lblshare_info
			' 
			Me.lblshare_info.AutoSize = True
			Me.lblshare_info.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lblshare_info.Location = New System.Drawing.Point(404, 77)
			Me.lblshare_info.Name = "lblshare_info"
			Me.lblshare_info.Size = New System.Drawing.Size(172, 15)
			Me.lblshare_info.TabIndex = 6
			Me.lblshare_info.Text = "Shares Information of Broker"
			' 
			' btnsave
			' 
			Me.btnsave.Location = New System.Drawing.Point(212, 553)
			Me.btnsave.Name = "btnsave"
			Me.btnsave.Size = New System.Drawing.Size(75, 34)
			Me.btnsave.TabIndex = 6
			Me.btnsave.Text = "SAVE"
			Me.btnsave.UseVisualStyleBackColor = True
			Me.btnsave.Visible = False
			Me.btnsave.Click += New System.EventHandler(Me.btnsave_Click)
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(428, 553)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(105, 34)
			Me.btnexit.TabIndex = 7
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' cbobroker
			' 
			Me.cbobroker.FormattingEnabled = True
			Me.cbobroker.Location = New System.Drawing.Point(455, 20)
			Me.cbobroker.Name = "cbobroker"
			Me.cbobroker.Size = New System.Drawing.Size(200, 21)
			Me.cbobroker.TabIndex = 1
			Me.cbobroker.SelectedIndexChanged += New System.EventHandler(Me.cbobroker_SelectedIndexChanged)
			' 
			' lblclient_shares
			' 
			Me.lblclient_shares.AutoSize = True
			Me.lblclient_shares.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lblclient_shares.Location = New System.Drawing.Point(404, 307)
			Me.lblclient_shares.Name = "lblclient_shares"
			Me.lblclient_shares.Size = New System.Drawing.Size(156, 15)
			Me.lblclient_shares.TabIndex = 10
			Me.lblclient_shares.Text = "Selling shares Information"
			' 
			' btnviewall
			' 
			Me.btnviewall.Location = New System.Drawing.Point(428, 260)
			Me.btnviewall.Name = "btnviewall"
			Me.btnviewall.Size = New System.Drawing.Size(105, 33)
			Me.btnviewall.TabIndex = 2
			Me.btnviewall.Text = "VIEW ALL"
			Me.btnviewall.UseVisualStyleBackColor = True
			Me.btnviewall.Click += New System.EventHandler(Me.btnviewall_Click)
			' 
			' dtpdate1
			' 
			Me.dtpdate1.CustomFormat = "dd/MM/yyyy"
			Me.dtpdate1.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
			Me.dtpdate1.Location = New System.Drawing.Point(555, 105)
			Me.dtpdate1.Name = "dtpdate1"
			Me.dtpdate1.Size = New System.Drawing.Size(100, 20)
			Me.dtpdate1.TabIndex = 14
			Me.dtpdate1.Visible = False
			Me.dtpdate1.ValueChanged += New System.EventHandler(Me.dtpdate1_ValueChanged)
			' 
			' lblDate
			' 
			Me.lblDate.AutoSize = True
			Me.lblDate.Location = New System.Drawing.Point(725, 351)
			Me.lblDate.Name = "lblDate"
			Me.lblDate.Size = New System.Drawing.Size(30, 13)
			Me.lblDate.TabIndex = 15
			Me.lblDate.Text = "Date"
			' 
			' dtpDate
			' 
			Me.dtpDate.CustomFormat = "dd/MM/yyyy"
			Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
			Me.dtpDate.Location = New System.Drawing.Point(790, 347)
			Me.dtpDate.Name = "dtpDate"
			Me.dtpDate.Size = New System.Drawing.Size(106, 20)
			Me.dtpDate.TabIndex = 4
			' 
			' cbocompany_name
			' 
			Me.cbocompany_name.FormattingEnabled = True
			Me.cbocompany_name.Location = New System.Drawing.Point(455, 351)
			Me.cbocompany_name.Name = "cbocompany_name"
			Me.cbocompany_name.Size = New System.Drawing.Size(200, 21)
			Me.cbocompany_name.TabIndex = 3
			Me.cbocompany_name.SelectedIndexChanged += New System.EventHandler(Me.cbocompany_name_SelectedIndexChanged)
			' 
			' lblCompany_name
			' 
			Me.lblCompany_name.AutoSize = True
			Me.lblCompany_name.Location = New System.Drawing.Point(352, 354)
			Me.lblCompany_name.Name = "lblCompany_name"
			Me.lblCompany_name.Size = New System.Drawing.Size(82, 13)
			Me.lblCompany_name.TabIndex = 18
			Me.lblCompany_name.Text = "Company Name"
			' 
			' frmbroker_shares
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(946, 609)
			Me.Controls.Add(Me.lblCompany_name)
			Me.Controls.Add(Me.cbocompany_name)
			Me.Controls.Add(Me.dtpDate)
			Me.Controls.Add(Me.lblDate)
			Me.Controls.Add(Me.dtpdate1)
			Me.Controls.Add(Me.btnviewall)
			Me.Controls.Add(Me.lblclient_shares)
			Me.Controls.Add(Me.cbobroker)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnsave)
			Me.Controls.Add(Me.lblshare_info)
			Me.Controls.Add(Me.drv_broker2)
			Me.Controls.Add(Me.drv_broker1)
			Me.Controls.Add(Me.lblbroker_name)
			Me.Name = "frmbroker_shares"
			Me.Text = "Broker Shares"
			Me.Load += New System.EventHandler(Me.frmbroker_Load)
			DirectCast(Me.drv_broker1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.drv_broker2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblbroker_name As System.Windows.Forms.Label
		Private drv_broker1 As System.Windows.Forms.DataGridView
		Private drv_broker2 As System.Windows.Forms.DataGridView
		Private lblshare_info As System.Windows.Forms.Label
		Private btnsave As System.Windows.Forms.Button
		Private btnexit As System.Windows.Forms.Button
		Private cbobroker As System.Windows.Forms.ComboBox
		Private lblclient_shares As System.Windows.Forms.Label
		Private btnviewall As System.Windows.Forms.Button
		Private dtpdate1 As System.Windows.Forms.DateTimePicker
		Private lblDate As System.Windows.Forms.Label
		Private dtpDate As System.Windows.Forms.DateTimePicker
		Private cbocompany_name As System.Windows.Forms.ComboBox
		Private lblCompany_name As System.Windows.Forms.Label
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
