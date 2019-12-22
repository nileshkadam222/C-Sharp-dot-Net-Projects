
Namespace Shared_Market_System
	Partial Class frmbroker_details
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
			Me.txtbroker_name = New System.Windows.Forms.TextBox()
			Me.lblbroker_code = New System.Windows.Forms.Label()
			Me.lblpan_no = New System.Windows.Forms.Label()
			Me.lbladd = New System.Windows.Forms.Label()
			Me.lblclient_name = New System.Windows.Forms.Label()
			Me.txtbroker_code = New System.Windows.Forms.TextBox()
			Me.txtpan_no = New System.Windows.Forms.TextBox()
			Me.txtadd = New System.Windows.Forms.TextBox()
			Me.cboclient_name = New System.Windows.Forms.ComboBox()
			Me.lstclient_all = New System.Windows.Forms.ListBox()
			Me.lstclient_select = New System.Windows.Forms.ListBox()
			Me.btnright = New System.Windows.Forms.Button()
			Me.btnleft = New System.Windows.Forms.Button()
			Me.btnsave = New System.Windows.Forms.Button()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.btnadd = New System.Windows.Forms.Button()
			Me.lblshares = New System.Windows.Forms.Label()
			Me.txtshares = New System.Windows.Forms.TextBox()
			Me.lbldate = New System.Windows.Forms.Label()
			Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.txtcurrent_rate = New System.Windows.Forms.TextBox()
			Me.txtopening_rate = New System.Windows.Forms.TextBox()
			Me.lblcurrent_rate = New System.Windows.Forms.Label()
			Me.lblopening_rate = New System.Windows.Forms.Label()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' lblbroker_name
			' 
			Me.lblbroker_name.AutoSize = True
			Me.lblbroker_name.Location = New System.Drawing.Point(12, 55)
			Me.lblbroker_name.Name = "lblbroker_name"
			Me.lblbroker_name.Size = New System.Drawing.Size(105, 13)
			Me.lblbroker_name.TabIndex = 0
			Me.lblbroker_name.Text = "Name of the Broker :"
			' 
			' txtbroker_name
			' 
			Me.txtbroker_name.Location = New System.Drawing.Point(125, 52)
			Me.txtbroker_name.Name = "txtbroker_name"
			Me.txtbroker_name.Size = New System.Drawing.Size(171, 20)
			Me.txtbroker_name.TabIndex = 2
			' 
			' lblbroker_code
			' 
			Me.lblbroker_code.AutoSize = True
			Me.lblbroker_code.Location = New System.Drawing.Point(12, 29)
			Me.lblbroker_code.Name = "lblbroker_code"
			Me.lblbroker_code.Size = New System.Drawing.Size(72, 13)
			Me.lblbroker_code.TabIndex = 2
			Me.lblbroker_code.Text = "Broker Code :"
			' 
			' lblpan_no
			' 
			Me.lblpan_no.AutoSize = True
			Me.lblpan_no.Location = New System.Drawing.Point(12, 81)
			Me.lblpan_no.Name = "lblpan_no"
			Me.lblpan_no.Size = New System.Drawing.Size(52, 13)
			Me.lblpan_no.TabIndex = 3
			Me.lblpan_no.Text = "Pan No. :"
			' 
			' lbladd
			' 
			Me.lbladd.AutoSize = True
			Me.lbladd.Location = New System.Drawing.Point(12, 107)
			Me.lbladd.Name = "lbladd"
			Me.lbladd.Size = New System.Drawing.Size(45, 13)
			Me.lbladd.TabIndex = 4
			Me.lbladd.Text = "Address"
			' 
			' lblclient_name
			' 
			Me.lblclient_name.AutoSize = True
			Me.lblclient_name.Location = New System.Drawing.Point(317, 32)
			Me.lblclient_name.Name = "lblclient_name"
			Me.lblclient_name.Size = New System.Drawing.Size(75, 13)
			Me.lblclient_name.TabIndex = 5
			Me.lblclient_name.Text = "Client Names :"
			' 
			' txtbroker_code
			' 
			Me.txtbroker_code.Location = New System.Drawing.Point(125, 26)
			Me.txtbroker_code.Name = "txtbroker_code"
			Me.txtbroker_code.[ReadOnly] = True
			Me.txtbroker_code.Size = New System.Drawing.Size(171, 20)
			Me.txtbroker_code.TabIndex = 1
			Me.txtbroker_code.TabStop = False
			' 
			' txtpan_no
			' 
			Me.txtpan_no.Location = New System.Drawing.Point(125, 78)
			Me.txtpan_no.Name = "txtpan_no"
			Me.txtpan_no.Size = New System.Drawing.Size(171, 20)
			Me.txtpan_no.TabIndex = 3
			' 
			' txtadd
			' 
			Me.txtadd.Location = New System.Drawing.Point(125, 104)
			Me.txtadd.Multiline = True
			Me.txtadd.Name = "txtadd"
			Me.txtadd.Size = New System.Drawing.Size(171, 52)
			Me.txtadd.TabIndex = 4
			' 
			' cboclient_name
			' 
			Me.cboclient_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.cboclient_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cboclient_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboclient_name.FormattingEnabled = True
			Me.cboclient_name.Location = New System.Drawing.Point(398, 29)
			Me.cboclient_name.Name = "cboclient_name"
			Me.cboclient_name.Size = New System.Drawing.Size(146, 21)
			Me.cboclient_name.TabIndex = 5
			Me.cboclient_name.SelectedIndexChanged += New System.EventHandler(Me.cboclient_name_SelectedIndexChanged)
			' 
			' lstclient_all
			' 
			Me.lstclient_all.FormattingEnabled = True
			Me.lstclient_all.Location = New System.Drawing.Point(320, 61)
			Me.lstclient_all.Name = "lstclient_all"
			Me.lstclient_all.Size = New System.Drawing.Size(125, 160)
			Me.lstclient_all.TabIndex = 7
			' 
			' lstclient_select
			' 
			Me.lstclient_select.FormattingEnabled = True
			Me.lstclient_select.Location = New System.Drawing.Point(540, 68)
			Me.lstclient_select.Name = "lstclient_select"
			Me.lstclient_select.Size = New System.Drawing.Size(125, 160)
			Me.lstclient_select.TabIndex = 10
			' 
			' btnright
			' 
			Me.btnright.Location = New System.Drawing.Point(471, 97)
			Me.btnright.Name = "btnright"
			Me.btnright.Size = New System.Drawing.Size(42, 23)
			Me.btnright.TabIndex = 8
			Me.btnright.Text = "-->"
			Me.btnright.UseVisualStyleBackColor = True
			Me.btnright.Click += New System.EventHandler(Me.btnright_Click)
			' 
			' btnleft
			' 
			Me.btnleft.Location = New System.Drawing.Point(471, 173)
			Me.btnleft.Name = "btnleft"
			Me.btnleft.Size = New System.Drawing.Size(42, 23)
			Me.btnleft.TabIndex = 9
			Me.btnleft.Text = "<--"
			Me.btnleft.UseVisualStyleBackColor = True
			Me.btnleft.Click += New System.EventHandler(Me.btnleft_Click)
			' 
			' btnsave
			' 
			Me.btnsave.Location = New System.Drawing.Point(252, 256)
			Me.btnsave.Name = "btnsave"
			Me.btnsave.Size = New System.Drawing.Size(75, 30)
			Me.btnsave.TabIndex = 11
			Me.btnsave.Text = "SAVE"
			Me.btnsave.UseVisualStyleBackColor = True
			Me.btnsave.Click += New System.EventHandler(Me.btnsave_Click)
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(370, 256)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 30)
			Me.btnexit.TabIndex = 12
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' btnadd
			' 
			Me.btnadd.Location = New System.Drawing.Point(563, 29)
			Me.btnadd.Name = "btnadd"
			Me.btnadd.Size = New System.Drawing.Size(89, 23)
			Me.btnadd.TabIndex = 6
			Me.btnadd.Text = "ADD"
			Me.btnadd.UseVisualStyleBackColor = True
			Me.btnadd.Click += New System.EventHandler(Me.btnadd_Click)
			' 
			' lblshares
			' 
			Me.lblshares.AutoSize = True
			Me.lblshares.Location = New System.Drawing.Point(6, 11)
			Me.lblshares.Name = "lblshares"
			Me.lblshares.Size = New System.Drawing.Size(78, 13)
			Me.lblshares.TabIndex = 13
			Me.lblshares.Text = "No. of Shares :"
			' 
			' txtshares
			' 
			Me.txtshares.Location = New System.Drawing.Point(90, 8)
			Me.txtshares.Name = "txtshares"
			Me.txtshares.Size = New System.Drawing.Size(102, 20)
			Me.txtshares.TabIndex = 14
			Me.txtshares.Text = "0"
			' 
			' lbldate
			' 
			Me.lbldate.AutoSize = True
			Me.lbldate.Location = New System.Drawing.Point(6, 36)
			Me.lbldate.Name = "lbldate"
			Me.lbldate.Size = New System.Drawing.Size(36, 13)
			Me.lbldate.TabIndex = 15
			Me.lbldate.Text = "Date :"
			' 
			' dateTimePicker1
			' 
			Me.dateTimePicker1.CustomFormat = "dd/MM/yyyy"
			Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Custom]
			Me.dateTimePicker1.Location = New System.Drawing.Point(90, 36)
			Me.dateTimePicker1.Name = "dateTimePicker1"
			Me.dateTimePicker1.Size = New System.Drawing.Size(102, 20)
			Me.dateTimePicker1.TabIndex = 16
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.txtcurrent_rate)
			Me.panel1.Controls.Add(Me.txtopening_rate)
			Me.panel1.Controls.Add(Me.lblcurrent_rate)
			Me.panel1.Controls.Add(Me.lblopening_rate)
			Me.panel1.Controls.Add(Me.lblshares)
			Me.panel1.Controls.Add(Me.dateTimePicker1)
			Me.panel1.Controls.Add(Me.txtshares)
			Me.panel1.Controls.Add(Me.lbldate)
			Me.panel1.Location = New System.Drawing.Point(4, 165)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(203, 122)
			Me.panel1.TabIndex = 17
			Me.panel1.Visible = False
			' 
			' txtcurrent_rate
			' 
			Me.txtcurrent_rate.Location = New System.Drawing.Point(90, 97)
			Me.txtcurrent_rate.Name = "txtcurrent_rate"
			Me.txtcurrent_rate.Size = New System.Drawing.Size(102, 20)
			Me.txtcurrent_rate.TabIndex = 19
			' 
			' txtopening_rate
			' 
			Me.txtopening_rate.Location = New System.Drawing.Point(90, 69)
			Me.txtopening_rate.Name = "txtopening_rate"
			Me.txtopening_rate.Size = New System.Drawing.Size(102, 20)
			Me.txtopening_rate.TabIndex = 18
			' 
			' lblcurrent_rate
			' 
			Me.lblcurrent_rate.AutoSize = True
			Me.lblcurrent_rate.Location = New System.Drawing.Point(6, 100)
			Me.lblcurrent_rate.Name = "lblcurrent_rate"
			Me.lblcurrent_rate.Size = New System.Drawing.Size(73, 13)
			Me.lblcurrent_rate.TabIndex = 18
			Me.lblcurrent_rate.Text = "Current Rate :"
			' 
			' lblopening_rate
			' 
			Me.lblopening_rate.AutoSize = True
			Me.lblopening_rate.Location = New System.Drawing.Point(7, 69)
			Me.lblopening_rate.Name = "lblopening_rate"
			Me.lblopening_rate.Size = New System.Drawing.Size(74, 13)
			Me.lblopening_rate.TabIndex = 17
			Me.lblopening_rate.Text = "Opening rate :"
			' 
			' frmbroker_details
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(682, 301)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.btnadd)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnsave)
			Me.Controls.Add(Me.btnleft)
			Me.Controls.Add(Me.btnright)
			Me.Controls.Add(Me.lstclient_select)
			Me.Controls.Add(Me.lstclient_all)
			Me.Controls.Add(Me.cboclient_name)
			Me.Controls.Add(Me.txtadd)
			Me.Controls.Add(Me.txtpan_no)
			Me.Controls.Add(Me.txtbroker_code)
			Me.Controls.Add(Me.lblclient_name)
			Me.Controls.Add(Me.lbladd)
			Me.Controls.Add(Me.lblpan_no)
			Me.Controls.Add(Me.lblbroker_code)
			Me.Controls.Add(Me.txtbroker_name)
			Me.Controls.Add(Me.lblbroker_name)
			Me.Name = "frmbroker_details"
			Me.Text = "Broker Details"
			Me.DoubleClick += New System.EventHandler(Me.frmbroker_details_DoubleClick)
			Me.Load += New System.EventHandler(Me.Broker_details_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblbroker_name As System.Windows.Forms.Label
		Private txtbroker_name As System.Windows.Forms.TextBox
		Private lblbroker_code As System.Windows.Forms.Label
		Private lblpan_no As System.Windows.Forms.Label
		Private lbladd As System.Windows.Forms.Label
		Private lblclient_name As System.Windows.Forms.Label
		Private txtbroker_code As System.Windows.Forms.TextBox
		Private txtpan_no As System.Windows.Forms.TextBox
		Private txtadd As System.Windows.Forms.TextBox
		Private cboclient_name As System.Windows.Forms.ComboBox
		Private lstclient_all As System.Windows.Forms.ListBox
		Private lstclient_select As System.Windows.Forms.ListBox
		Private btnright As System.Windows.Forms.Button
		Private btnleft As System.Windows.Forms.Button
		Private btnsave As System.Windows.Forms.Button
		Private btnexit As System.Windows.Forms.Button
		Private btnadd As System.Windows.Forms.Button
		Private lblshares As System.Windows.Forms.Label
		Private txtshares As System.Windows.Forms.TextBox
		Private lbldate As System.Windows.Forms.Label
		Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
		Private panel1 As System.Windows.Forms.Panel
		Private txtcurrent_rate As System.Windows.Forms.TextBox
		Private txtopening_rate As System.Windows.Forms.TextBox
		Private lblcurrent_rate As System.Windows.Forms.Label
		Private lblopening_rate As System.Windows.Forms.Label
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
