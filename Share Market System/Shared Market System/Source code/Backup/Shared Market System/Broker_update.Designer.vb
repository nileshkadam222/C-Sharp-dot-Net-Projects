
Namespace Shared_Market_System
	Partial Class frmbroker_update
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
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.txtcurrent_rate = New System.Windows.Forms.TextBox()
			Me.txtopening_rate = New System.Windows.Forms.TextBox()
			Me.lblcurrent_rate = New System.Windows.Forms.Label()
			Me.lblopening_rate = New System.Windows.Forms.Label()
			Me.lblshares = New System.Windows.Forms.Label()
			Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
			Me.txtshares = New System.Windows.Forms.TextBox()
			Me.lbldate = New System.Windows.Forms.Label()
			Me.btnadd = New System.Windows.Forms.Button()
			Me.btnexit = New System.Windows.Forms.Button()
			Me.btnupdate = New System.Windows.Forms.Button()
			Me.btnleft = New System.Windows.Forms.Button()
			Me.btnright = New System.Windows.Forms.Button()
			Me.lstclient_select = New System.Windows.Forms.ListBox()
			Me.lstclient_all = New System.Windows.Forms.ListBox()
			Me.cboclient_name = New System.Windows.Forms.ComboBox()
			Me.txtadd = New System.Windows.Forms.TextBox()
			Me.txtpan_no = New System.Windows.Forms.TextBox()
			Me.txtbroker_code = New System.Windows.Forms.TextBox()
			Me.lblclient_name = New System.Windows.Forms.Label()
			Me.lbladd = New System.Windows.Forms.Label()
			Me.lblpan_no = New System.Windows.Forms.Label()
			Me.lblbroker_code = New System.Windows.Forms.Label()
			Me.txtbroker_name = New System.Windows.Forms.TextBox()
			Me.lblbroker_name = New System.Windows.Forms.Label()
			Me.cbobroker = New System.Windows.Forms.ComboBox()
			Me.lblbroker = New System.Windows.Forms.Label()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
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
			Me.panel1.Location = New System.Drawing.Point(13, 180)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(203, 122)
			Me.panel1.TabIndex = 35
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
			' lblshares
			' 
			Me.lblshares.AutoSize = True
			Me.lblshares.Location = New System.Drawing.Point(6, 11)
			Me.lblshares.Name = "lblshares"
			Me.lblshares.Size = New System.Drawing.Size(78, 13)
			Me.lblshares.TabIndex = 13
			Me.lblshares.Text = "No. of Shares :"
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
			' txtshares
			' 
			Me.txtshares.Location = New System.Drawing.Point(90, 8)
			Me.txtshares.Name = "txtshares"
			Me.txtshares.Size = New System.Drawing.Size(102, 20)
			Me.txtshares.TabIndex = 14
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
			' btnadd
			' 
			Me.btnadd.Location = New System.Drawing.Point(572, 44)
			Me.btnadd.Name = "btnadd"
			Me.btnadd.Size = New System.Drawing.Size(89, 23)
			Me.btnadd.TabIndex = 28
			Me.btnadd.Text = "ADD"
			Me.btnadd.UseVisualStyleBackColor = True
			Me.btnadd.Click += New System.EventHandler(Me.btnadd_Click)
			' 
			' btnexit
			' 
			Me.btnexit.Location = New System.Drawing.Point(342, 269)
			Me.btnexit.Name = "btnexit"
			Me.btnexit.Size = New System.Drawing.Size(75, 31)
			Me.btnexit.TabIndex = 34
			Me.btnexit.Text = "EXIT"
			Me.btnexit.UseVisualStyleBackColor = True
			Me.btnexit.Click += New System.EventHandler(Me.btnexit_Click)
			' 
			' btnupdate
			' 
			Me.btnupdate.Location = New System.Drawing.Point(239, 269)
			Me.btnupdate.Name = "btnupdate"
			Me.btnupdate.Size = New System.Drawing.Size(75, 31)
			Me.btnupdate.TabIndex = 33
			Me.btnupdate.Text = "UPDATE"
			Me.btnupdate.UseVisualStyleBackColor = True
			Me.btnupdate.Click += New System.EventHandler(Me.btnupdate_Click)
			' 
			' btnleft
			' 
			Me.btnleft.Location = New System.Drawing.Point(480, 202)
			Me.btnleft.Name = "btnleft"
			Me.btnleft.Size = New System.Drawing.Size(42, 23)
			Me.btnleft.TabIndex = 31
			Me.btnleft.Text = "<--"
			Me.btnleft.UseVisualStyleBackColor = True
			Me.btnleft.Click += New System.EventHandler(Me.btnleft_Click)
			' 
			' btnright
			' 
			Me.btnright.Location = New System.Drawing.Point(480, 131)
			Me.btnright.Name = "btnright"
			Me.btnright.Size = New System.Drawing.Size(42, 23)
			Me.btnright.TabIndex = 30
			Me.btnright.Text = "-->"
			Me.btnright.UseVisualStyleBackColor = True
			Me.btnright.Click += New System.EventHandler(Me.btnright_Click)
			' 
			' lstclient_select
			' 
			Me.lstclient_select.FormattingEnabled = True
			Me.lstclient_select.Location = New System.Drawing.Point(549, 83)
			Me.lstclient_select.Name = "lstclient_select"
			Me.lstclient_select.Size = New System.Drawing.Size(125, 160)
			Me.lstclient_select.TabIndex = 32
			' 
			' lstclient_all
			' 
			Me.lstclient_all.FormattingEnabled = True
			Me.lstclient_all.Location = New System.Drawing.Point(329, 76)
			Me.lstclient_all.Name = "lstclient_all"
			Me.lstclient_all.Size = New System.Drawing.Size(125, 160)
			Me.lstclient_all.TabIndex = 29
			' 
			' cboclient_name
			' 
			Me.cboclient_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
			Me.cboclient_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cboclient_name.FormattingEnabled = True
			Me.cboclient_name.Location = New System.Drawing.Point(407, 44)
			Me.cboclient_name.Name = "cboclient_name"
			Me.cboclient_name.Size = New System.Drawing.Size(146, 21)
			Me.cboclient_name.TabIndex = 27
			' 
			' txtadd
			' 
			Me.txtadd.Location = New System.Drawing.Point(134, 119)
			Me.txtadd.Multiline = True
			Me.txtadd.Name = "txtadd"
			Me.txtadd.Size = New System.Drawing.Size(171, 52)
			Me.txtadd.TabIndex = 24
			' 
			' txtpan_no
			' 
			Me.txtpan_no.Location = New System.Drawing.Point(134, 93)
			Me.txtpan_no.Name = "txtpan_no"
			Me.txtpan_no.Size = New System.Drawing.Size(171, 20)
			Me.txtpan_no.TabIndex = 23
			' 
			' txtbroker_code
			' 
			Me.txtbroker_code.Location = New System.Drawing.Point(134, 67)
			Me.txtbroker_code.Name = "txtbroker_code"
			Me.txtbroker_code.[ReadOnly] = True
			Me.txtbroker_code.Size = New System.Drawing.Size(171, 20)
			Me.txtbroker_code.TabIndex = 20
			' 
			' lblclient_name
			' 
			Me.lblclient_name.AutoSize = True
			Me.lblclient_name.Location = New System.Drawing.Point(326, 47)
			Me.lblclient_name.Name = "lblclient_name"
			Me.lblclient_name.Size = New System.Drawing.Size(75, 13)
			Me.lblclient_name.TabIndex = 26
			Me.lblclient_name.Text = "Client Names :"
			' 
			' lbladd
			' 
			Me.lbladd.AutoSize = True
			Me.lbladd.Location = New System.Drawing.Point(21, 122)
			Me.lbladd.Name = "lbladd"
			Me.lbladd.Size = New System.Drawing.Size(45, 13)
			Me.lbladd.TabIndex = 25
			Me.lbladd.Text = "Address"
			' 
			' lblpan_no
			' 
			Me.lblpan_no.AutoSize = True
			Me.lblpan_no.Location = New System.Drawing.Point(21, 96)
			Me.lblpan_no.Name = "lblpan_no"
			Me.lblpan_no.Size = New System.Drawing.Size(52, 13)
			Me.lblpan_no.TabIndex = 22
			Me.lblpan_no.Text = "Pan No. :"
			' 
			' lblbroker_code
			' 
			Me.lblbroker_code.AutoSize = True
			Me.lblbroker_code.Location = New System.Drawing.Point(21, 70)
			Me.lblbroker_code.Name = "lblbroker_code"
			Me.lblbroker_code.Size = New System.Drawing.Size(72, 13)
			Me.lblbroker_code.TabIndex = 21
			Me.lblbroker_code.Text = "Broker Code :"
			' 
			' txtbroker_name
			' 
			Me.txtbroker_name.Location = New System.Drawing.Point(134, 41)
			Me.txtbroker_name.Name = "txtbroker_name"
			Me.txtbroker_name.Size = New System.Drawing.Size(171, 20)
			Me.txtbroker_name.TabIndex = 19
			' 
			' lblbroker_name
			' 
			Me.lblbroker_name.AutoSize = True
			Me.lblbroker_name.Location = New System.Drawing.Point(21, 44)
			Me.lblbroker_name.Name = "lblbroker_name"
			Me.lblbroker_name.Size = New System.Drawing.Size(105, 13)
			Me.lblbroker_name.TabIndex = 18
			Me.lblbroker_name.Text = "Name of the Broker :"
			' 
			' cbobroker
			' 
			Me.cbobroker.FormattingEnabled = True
			Me.cbobroker.Location = New System.Drawing.Point(134, 14)
			Me.cbobroker.Name = "cbobroker"
			Me.cbobroker.Size = New System.Drawing.Size(171, 21)
			Me.cbobroker.TabIndex = 36
			Me.cbobroker.Text = "Select Broker to update details"
			Me.cbobroker.SelectedIndexChanged += New System.EventHandler(Me.cbobroker_SelectedIndexChanged)
			' 
			' lblbroker
			' 
			Me.lblbroker.AutoSize = True
			Me.lblbroker.Location = New System.Drawing.Point(21, 22)
			Me.lblbroker.Name = "lblbroker"
			Me.lblbroker.Size = New System.Drawing.Size(75, 13)
			Me.lblbroker.TabIndex = 37
			Me.lblbroker.Text = "Broker Name :"
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Location = New System.Drawing.Point(433, 259)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(215, 43)
			Me.listBox1.TabIndex = 38
			' 
			' frmbroker_update
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(692, 327)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.lblbroker)
			Me.Controls.Add(Me.cbobroker)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.btnadd)
			Me.Controls.Add(Me.btnexit)
			Me.Controls.Add(Me.btnupdate)
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
			Me.Name = "frmbroker_update"
			Me.Text = "Broker Update"
			Me.Load += New System.EventHandler(Me.frmbroker_update_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private txtcurrent_rate As System.Windows.Forms.TextBox
		Private txtopening_rate As System.Windows.Forms.TextBox
		Private lblcurrent_rate As System.Windows.Forms.Label
		Private lblopening_rate As System.Windows.Forms.Label
		Private lblshares As System.Windows.Forms.Label
		Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
		Private txtshares As System.Windows.Forms.TextBox
		Private lbldate As System.Windows.Forms.Label
		Private btnadd As System.Windows.Forms.Button
		Private btnexit As System.Windows.Forms.Button
		Private btnupdate As System.Windows.Forms.Button
		Private btnleft As System.Windows.Forms.Button
		Private btnright As System.Windows.Forms.Button
		Private lstclient_select As System.Windows.Forms.ListBox
		Private lstclient_all As System.Windows.Forms.ListBox
		Private cboclient_name As System.Windows.Forms.ComboBox
		Private txtadd As System.Windows.Forms.TextBox
		Private txtpan_no As System.Windows.Forms.TextBox
		Private txtbroker_code As System.Windows.Forms.TextBox
		Private lblclient_name As System.Windows.Forms.Label
		Private lbladd As System.Windows.Forms.Label
		Private lblpan_no As System.Windows.Forms.Label
		Private lblbroker_code As System.Windows.Forms.Label
		Private txtbroker_name As System.Windows.Forms.TextBox
		Private lblbroker_name As System.Windows.Forms.Label
		Private cbobroker As System.Windows.Forms.ComboBox
		Private lblbroker As System.Windows.Forms.Label
		Private listBox1 As System.Windows.Forms.ListBox
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
