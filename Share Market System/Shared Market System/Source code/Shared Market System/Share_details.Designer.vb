
Namespace Shared_Market_System
	Partial Class frmShare_details
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
			Me.drvadmin = New System.Windows.Forms.DataGridView()
			Me.lblshare_details = New System.Windows.Forms.Label()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.btnsave = New System.Windows.Forms.Button()
			Me.lbladmin_name = New System.Windows.Forms.Label()
			Me.cboadmin_name = New System.Windows.Forms.ComboBox()
			Me.cbocompany_name = New System.Windows.Forms.ComboBox()
			Me.lblcompany_name = New System.Windows.Forms.Label()
			Me.lbldate = New System.Windows.Forms.Label()
			Me.dtpdate = New System.Windows.Forms.DateTimePicker()
			DirectCast(Me.drvadmin, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' drvadmin
			' 
			Me.drvadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.drvadmin.Location = New System.Drawing.Point(22, 122)
			Me.drvadmin.Name = "drvadmin"
			Me.drvadmin.Size = New System.Drawing.Size(805, 150)
			Me.drvadmin.TabIndex = 4
			Me.drvadmin.CellBeginEdit += New System.Windows.Forms.DataGridViewCellCancelEventHandler(Me.drvadmin_CellBeginEdit)
			Me.drvadmin.CellClick += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drvadmin_CellClick)
			Me.drvadmin.RowLeave += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drvadmin_RowLeave)
			Me.drvadmin.CellValidating += New System.Windows.Forms.DataGridViewCellValidatingEventHandler(Me.drvadmin_CellValidating)
			Me.drvadmin.CellEndEdit += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drvadmin_CellEndEdit)
			Me.drvadmin.CellMouseDoubleClick += New System.Windows.Forms.DataGridViewCellMouseEventHandler(Me.drvadmin_CellMouseDoubleClick)
			Me.drvadmin.CellMouseClick += New System.Windows.Forms.DataGridViewCellMouseEventHandler(Me.drvadmin_CellMouseClick)
			Me.drvadmin.CellContentClick += New System.Windows.Forms.DataGridViewCellEventHandler(Me.drvadmin_CellContentClick)
			' 
			' lblshare_details
			' 
			Me.lblshare_details.AutoSize = True
			Me.lblshare_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.lblshare_details.Location = New System.Drawing.Point(396, 86)
			Me.lblshare_details.Name = "lblshare_details"
			Me.lblshare_details.Size = New System.Drawing.Size(83, 13)
			Me.lblshare_details.TabIndex = 7
			Me.lblshare_details.Text = "Share Details"
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(367, 290)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 31)
			Me.btnexit.TabIndex = 5
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' btnsave
			' 
			Me.btnsave.Location = New System.Drawing.Point(132, 290)
			Me.btnsave.Name = "btnsave"
			Me.btnsave.Size = New System.Drawing.Size(75, 31)
			Me.btnsave.TabIndex = 3
			Me.btnsave.Text = "UPDATE"
			Me.btnsave.UseVisualStyleBackColor = True
			Me.btnsave.Visible = False
			Me.btnsave.Click += New System.EventHandler(Me.btnsave_Click)
			' 
			' lbladmin_name
			' 
			Me.lbladmin_name.AutoSize = True
			Me.lbladmin_name.Location = New System.Drawing.Point(38, 26)
			Me.lbladmin_name.Name = "lbladmin_name"
			Me.lbladmin_name.Size = New System.Drawing.Size(70, 13)
			Me.lbladmin_name.TabIndex = 10
			Me.lbladmin_name.Text = "Admin Name:"
			' 
			' cboadmin_name
			' 
			Me.cboadmin_name.FormattingEnabled = True
			Me.cboadmin_name.Location = New System.Drawing.Point(123, 26)
			Me.cboadmin_name.Name = "cboadmin_name"
			Me.cboadmin_name.Size = New System.Drawing.Size(206, 21)
			Me.cboadmin_name.TabIndex = 1
			Me.cboadmin_name.SelectedIndexChanged += New System.EventHandler(Me.cboadmin_name_SelectedIndexChanged)
			' 
			' cbocompany_name
			' 
			Me.cbocompany_name.FormattingEnabled = True
			Me.cbocompany_name.Location = New System.Drawing.Point(591, 26)
			Me.cbocompany_name.Name = "cbocompany_name"
			Me.cbocompany_name.Size = New System.Drawing.Size(206, 21)
			Me.cbocompany_name.TabIndex = 2
			Me.cbocompany_name.SelectedIndexChanged += New System.EventHandler(Me.cbocompany_name_SelectedIndexChanged)
			' 
			' lblcompany_name
			' 
			Me.lblcompany_name.AutoSize = True
			Me.lblcompany_name.Location = New System.Drawing.Point(485, 29)
			Me.lblcompany_name.Name = "lblcompany_name"
			Me.lblcompany_name.Size = New System.Drawing.Size(82, 13)
			Me.lblcompany_name.TabIndex = 14
			Me.lblcompany_name.Text = "Company Name"
			' 
			' lbldate
			' 
			Me.lbldate.AutoSize = True
			Me.lbldate.Location = New System.Drawing.Point(641, 100)
			Me.lbldate.Name = "lbldate"
			Me.lbldate.Size = New System.Drawing.Size(30, 13)
			Me.lbldate.TabIndex = 15
			Me.lbldate.Text = "Date"
			' 
			' dtpdate
			' 
			Me.dtpdate.CustomFormat = "dd/MM/yyyy"
			Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
			Me.dtpdate.Location = New System.Drawing.Point(704, 96)
			Me.dtpdate.Name = "dtpdate"
			Me.dtpdate.Size = New System.Drawing.Size(93, 20)
			Me.dtpdate.TabIndex = 3
			' 
			' frmShare_details
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(861, 352)
			Me.Controls.Add(Me.dtpdate)
			Me.Controls.Add(Me.lbldate)
			Me.Controls.Add(Me.lblcompany_name)
			Me.Controls.Add(Me.cbocompany_name)
			Me.Controls.Add(Me.cboadmin_name)
			Me.Controls.Add(Me.lbladmin_name)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnsave)
			Me.Controls.Add(Me.lblshare_details)
			Me.Controls.Add(Me.drvadmin)
			Me.Name = "frmShare_details"
			Me.Text = "Share Details"
			Me.Load += New System.EventHandler(Me.frmShare_details_Load_1)
			DirectCast(Me.drvadmin, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private drvadmin As System.Windows.Forms.DataGridView
		Private lblshare_details As System.Windows.Forms.Label
		Private btnexit As System.Windows.Forms.Button
		Private btnsave As System.Windows.Forms.Button
		Private lbladmin_name As System.Windows.Forms.Label
		Private cboadmin_name As System.Windows.Forms.ComboBox
		Private cbocompany_name As System.Windows.Forms.ComboBox
		Private lblcompany_name As System.Windows.Forms.Label
		Private lbldate As System.Windows.Forms.Label
		Private dtpdate As System.Windows.Forms.DateTimePicker
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
