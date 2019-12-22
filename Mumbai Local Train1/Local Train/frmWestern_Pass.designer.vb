<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWestern_Pass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWestern_Pass))
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblroute = New System.Windows.Forms.Label
        Me.lblpasstype = New System.Windows.Forms.Label
        Me.lbltotalprice = New System.Windows.Forms.Label
        Me.lblclass = New System.Windows.Forms.Label
        Me.lbldistance = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblfrom = New System.Windows.Forms.Label
        Me.lblpassnumber = New System.Windows.Forms.Label
        Me.lblexpirydate = New System.Windows.Forms.Label
        Me.lblmonths = New System.Windows.Forms.Label
        Me.lblduration = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.lblto = New System.Windows.Forms.Label
        Me.txtExpiryDate = New System.Windows.Forms.TextBox
        Me.txtmonths = New System.Windows.Forms.TextBox
        Me.cbpasstype = New System.Windows.Forms.ComboBox
        Me.cbdestination = New System.Windows.Forms.ComboBox
        Me.cbsource = New System.Windows.Forms.ComboBox
        Me.lblwesternup = New System.Windows.Forms.Label
        Me.txtpassnum = New System.Windows.Forms.TextBox
        Me.txttime = New System.Windows.Forms.TextBox
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.cbclass = New System.Windows.Forms.ComboBox
        Me.cbroutes = New System.Windows.Forms.ComboBox
        Me.txtduration = New System.Windows.Forms.TextBox
        Me.txtdistance = New System.Windows.Forms.TextBox
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdprint = New System.Windows.Forms.Button
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdpass = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblroute)
        Me.Panel1.Controls.Add(Me.lblpasstype)
        Me.Panel1.Controls.Add(Me.lbltotalprice)
        Me.Panel1.Controls.Add(Me.lblclass)
        Me.Panel1.Controls.Add(Me.lbldistance)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblfrom)
        Me.Panel1.Controls.Add(Me.lblpassnumber)
        Me.Panel1.Controls.Add(Me.lblexpirydate)
        Me.Panel1.Controls.Add(Me.lblmonths)
        Me.Panel1.Controls.Add(Me.lblduration)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lblto)
        Me.Panel1.Controls.Add(Me.txtExpiryDate)
        Me.Panel1.Controls.Add(Me.txtmonths)
        Me.Panel1.Controls.Add(Me.cbpasstype)
        Me.Panel1.Controls.Add(Me.cbdestination)
        Me.Panel1.Controls.Add(Me.cbsource)
        Me.Panel1.Controls.Add(Me.lblwesternup)
        Me.Panel1.Controls.Add(Me.txtpassnum)
        Me.Panel1.Controls.Add(Me.txttime)
        Me.Panel1.Controls.Add(Me.txttotalprice)
        Me.Panel1.Controls.Add(Me.cbclass)
        Me.Panel1.Controls.Add(Me.cbroutes)
        Me.Panel1.Controls.Add(Me.txtduration)
        Me.Panel1.Controls.Add(Me.txtdistance)
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 400)
        Me.Panel1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Panel1, "Fast OR Slow")
        '
        'lblroute
        '
        Me.lblroute.AutoSize = True
        Me.lblroute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroute.ForeColor = System.Drawing.Color.Yellow
        Me.lblroute.Location = New System.Drawing.Point(55, 166)
        Me.lblroute.Name = "lblroute"
        Me.lblroute.Size = New System.Drawing.Size(266, 16)
        Me.lblroute.TabIndex = 332
        Me.lblroute.Text = "STATION BETWEEN SOURCE-DEST"
        Me.ToolTip1.SetToolTip(Me.lblroute, "Route")
        '
        'lblpasstype
        '
        Me.lblpasstype.AutoSize = True
        Me.lblpasstype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpasstype.ForeColor = System.Drawing.Color.Yellow
        Me.lblpasstype.Location = New System.Drawing.Point(55, 289)
        Me.lblpasstype.Name = "lblpasstype"
        Me.lblpasstype.Size = New System.Drawing.Size(92, 16)
        Me.lblpasstype.TabIndex = 213
        Me.lblpasstype.Text = "PASS TYPE"
        Me.ToolTip1.SetToolTip(Me.lblpasstype, "Pass Type")
        '
        'lbltotalprice
        '
        Me.lbltotalprice.AutoSize = True
        Me.lbltotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalprice.ForeColor = System.Drawing.Color.Yellow
        Me.lbltotalprice.Location = New System.Drawing.Point(55, 370)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(106, 16)
        Me.lbltotalprice.TabIndex = 211
        Me.lbltotalprice.Text = "TOTAL PRICE"
        Me.ToolTip1.SetToolTip(Me.lbltotalprice, "Total Price")
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclass.ForeColor = System.Drawing.Color.Yellow
        Me.lblclass.Location = New System.Drawing.Point(57, 331)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(56, 16)
        Me.lblclass.TabIndex = 210
        Me.lblclass.Text = "CLASS"
        Me.ToolTip1.SetToolTip(Me.lblclass, "Class")
        '
        'lbldistance
        '
        Me.lbldistance.AutoSize = True
        Me.lbldistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldistance.ForeColor = System.Drawing.Color.Yellow
        Me.lbldistance.Location = New System.Drawing.Point(55, 255)
        Me.lbldistance.Name = "lbldistance"
        Me.lbldistance.Size = New System.Drawing.Size(84, 16)
        Me.lbldistance.TabIndex = 209
        Me.lbldistance.Text = "DISTANCE"
        Me.ToolTip1.SetToolTip(Me.lbldistance, "Distance")
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Yellow
        Me.lbldate.Location = New System.Drawing.Point(57, 208)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(49, 16)
        Me.lbldate.TabIndex = 207
        Me.lbldate.Text = "DATE"
        Me.ToolTip1.SetToolTip(Me.lbldate, "Date")
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.ForeColor = System.Drawing.Color.Yellow
        Me.lblfrom.Location = New System.Drawing.Point(57, 117)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(51, 16)
        Me.lblfrom.TabIndex = 206
        Me.lblfrom.Text = "FROM"
        Me.ToolTip1.SetToolTip(Me.lblfrom, "From")
        '
        'lblpassnumber
        '
        Me.lblpassnumber.AutoSize = True
        Me.lblpassnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassnumber.ForeColor = System.Drawing.Color.Yellow
        Me.lblpassnumber.Location = New System.Drawing.Point(55, 82)
        Me.lblpassnumber.Name = "lblpassnumber"
        Me.lblpassnumber.Size = New System.Drawing.Size(117, 16)
        Me.lblpassnumber.TabIndex = 205
        Me.lblpassnumber.Text = "PASS NUMBER"
        Me.ToolTip1.SetToolTip(Me.lblpassnumber, "Pass Number")
        '
        'lblexpirydate
        '
        Me.lblexpirydate.AutoSize = True
        Me.lblexpirydate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpirydate.ForeColor = System.Drawing.Color.Yellow
        Me.lblexpirydate.Location = New System.Drawing.Point(370, 334)
        Me.lblexpirydate.Name = "lblexpirydate"
        Me.lblexpirydate.Size = New System.Drawing.Size(107, 16)
        Me.lblexpirydate.TabIndex = 204
        Me.lblexpirydate.Text = "EXPIRY DATE"
        Me.ToolTip1.SetToolTip(Me.lblexpirydate, "Expiry Date")
        '
        'lblmonths
        '
        Me.lblmonths.AutoSize = True
        Me.lblmonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonths.ForeColor = System.Drawing.Color.Yellow
        Me.lblmonths.Location = New System.Drawing.Point(373, 289)
        Me.lblmonths.Name = "lblmonths"
        Me.lblmonths.Size = New System.Drawing.Size(73, 16)
        Me.lblmonths.TabIndex = 203
        Me.lblmonths.Text = "MONTHS"
        Me.ToolTip1.SetToolTip(Me.lblmonths, "Months")
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduration.ForeColor = System.Drawing.Color.Yellow
        Me.lblduration.Location = New System.Drawing.Point(370, 252)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(87, 16)
        Me.lblduration.TabIndex = 202
        Me.lblduration.Text = "DURATION"
        Me.ToolTip1.SetToolTip(Me.lblduration, "Duration")
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Yellow
        Me.lbltime.Location = New System.Drawing.Point(367, 208)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(44, 16)
        Me.lbltime.TabIndex = 200
        Me.lbltime.Text = "TIME"
        Me.ToolTip1.SetToolTip(Me.lbltime, "Time")
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.ForeColor = System.Drawing.Color.Yellow
        Me.lblto.Location = New System.Drawing.Point(373, 121)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(29, 16)
        Me.lblto.TabIndex = 199
        Me.lblto.Text = "TO"
        Me.ToolTip1.SetToolTip(Me.lblto, "To")
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Location = New System.Drawing.Point(495, 330)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(100, 20)
        Me.txtExpiryDate.TabIndex = 196
        Me.ToolTip1.SetToolTip(Me.txtExpiryDate, "Expiry Date")
        '
        'txtmonths
        '
        Me.txtmonths.Location = New System.Drawing.Point(494, 288)
        Me.txtmonths.Name = "txtmonths"
        Me.txtmonths.Size = New System.Drawing.Size(100, 20)
        Me.txtmonths.TabIndex = 195
        Me.ToolTip1.SetToolTip(Me.txtmonths, "Months")
        '
        'cbpasstype
        '
        Me.cbpasstype.FormattingEnabled = True
        Me.cbpasstype.Location = New System.Drawing.Point(189, 288)
        Me.cbpasstype.Name = "cbpasstype"
        Me.cbpasstype.Size = New System.Drawing.Size(154, 21)
        Me.cbpasstype.TabIndex = 192
        Me.ToolTip1.SetToolTip(Me.cbpasstype, "Pass Type")
        '
        'cbdestination
        '
        Me.cbdestination.DropDownHeight = 150
        Me.cbdestination.DropDownWidth = 100
        Me.cbdestination.FormattingEnabled = True
        Me.cbdestination.IntegralHeight = False
        Me.cbdestination.Location = New System.Drawing.Point(422, 116)
        Me.cbdestination.Name = "cbdestination"
        Me.cbdestination.Size = New System.Drawing.Size(175, 21)
        Me.cbdestination.TabIndex = 185
        Me.ToolTip1.SetToolTip(Me.cbdestination, "Destination")
        '
        'cbsource
        '
        Me.cbsource.DropDownHeight = 150
        Me.cbsource.DropDownWidth = 100
        Me.cbsource.FormattingEnabled = True
        Me.cbsource.IntegralHeight = False
        Me.cbsource.Location = New System.Drawing.Point(189, 121)
        Me.cbsource.Name = "cbsource"
        Me.cbsource.Size = New System.Drawing.Size(175, 21)
        Me.cbsource.TabIndex = 184
        Me.ToolTip1.SetToolTip(Me.cbsource, "From")
        '
        'lblwesternup
        '
        Me.lblwesternup.AutoSize = True
        Me.lblwesternup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblwesternup.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwesternup.ForeColor = System.Drawing.Color.Yellow
        Me.lblwesternup.Location = New System.Drawing.Point(98, 16)
        Me.lblwesternup.Name = "lblwesternup"
        Me.lblwesternup.Size = New System.Drawing.Size(476, 36)
        Me.lblwesternup.TabIndex = 159
        Me.lblwesternup.Text = "WELCOME TO WESTERN RAILWAY"
        Me.ToolTip1.SetToolTip(Me.lblwesternup, "Welcome to Western UP")
        '
        'txtpassnum
        '
        Me.txtpassnum.Location = New System.Drawing.Point(191, 81)
        Me.txtpassnum.Name = "txtpassnum"
        Me.txtpassnum.Size = New System.Drawing.Size(173, 20)
        Me.txtpassnum.TabIndex = 161
        Me.ToolTip1.SetToolTip(Me.txtpassnum, "Pass Number")
        '
        'txttime
        '
        Me.txttime.Enabled = False
        Me.txttime.Location = New System.Drawing.Point(489, 208)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 20)
        Me.txttime.TabIndex = 166
        Me.ToolTip1.SetToolTip(Me.txttime, "Time")
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(189, 366)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(100, 20)
        Me.txttotalprice.TabIndex = 191
        Me.ToolTip1.SetToolTip(Me.txttotalprice, "Total Price")
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(189, 329)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(154, 21)
        Me.cbclass.TabIndex = 188
        Me.ToolTip1.SetToolTip(Me.cbclass, "Class")
        '
        'cbroutes
        '
        Me.cbroutes.DropDownHeight = 150
        Me.cbroutes.FormattingEnabled = True
        Me.cbroutes.IntegralHeight = False
        Me.cbroutes.Location = New System.Drawing.Point(419, 161)
        Me.cbroutes.Name = "cbroutes"
        Me.cbroutes.Size = New System.Drawing.Size(175, 21)
        Me.cbroutes.TabIndex = 187
        Me.ToolTip1.SetToolTip(Me.cbroutes, "Routes")
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(495, 251)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(100, 20)
        Me.txtduration.TabIndex = 175
        Me.ToolTip1.SetToolTip(Me.txtduration, "Duration")
        '
        'txtdistance
        '
        Me.txtdistance.Location = New System.Drawing.Point(189, 251)
        Me.txtdistance.Name = "txtdistance"
        Me.txtdistance.Size = New System.Drawing.Size(100, 20)
        Me.txtdistance.TabIndex = 174
        Me.ToolTip1.SetToolTip(Me.txtdistance, "Distance")
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(189, 208)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 20)
        Me.txtdate.TabIndex = 167
        Me.ToolTip1.SetToolTip(Me.txtdate, "Date")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdprint)
        Me.Panel2.Controls.Add(Me.cmdback)
        Me.Panel2.Controls.Add(Me.cmdcancel)
        Me.Panel2.Controls.Add(Me.cmdsearch)
        Me.Panel2.Controls.Add(Me.cmdnew)
        Me.Panel2.Controls.Add(Me.cmdpass)
        Me.Panel2.Location = New System.Drawing.Point(3, 409)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 105)
        Me.Panel2.TabIndex = 214
        '
        'cmdprint
        '
        Me.cmdprint.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(189, 57)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(102, 42)
        Me.cmdprint.TabIndex = 237
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(349, 60)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(102, 42)
        Me.cmdback.TabIndex = 108
        Me.cmdback.Text = "BACK"
        Me.ToolTip1.SetToolTip(Me.cmdback, "Back")
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(489, 60)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(102, 42)
        Me.cmdcancel.TabIndex = 107
        Me.cmdcancel.Text = "&CANCEL"
        Me.ToolTip1.SetToolTip(Me.cmdcancel, "Exit")
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(497, 3)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(102, 42)
        Me.cmdsearch.TabIndex = 104
        Me.cmdsearch.Text = "&SEARCH"
        Me.ToolTip1.SetToolTip(Me.cmdsearch, "Search Pass")
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmdnew
        '
        Me.cmdnew.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(349, 3)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(102, 42)
        Me.cmdnew.TabIndex = 103
        Me.cmdnew.Text = "&NEW"
        Me.ToolTip1.SetToolTip(Me.cmdnew, "Create New Pass")
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdpass
        '
        Me.cmdpass.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpass.Location = New System.Drawing.Point(189, 0)
        Me.cmdpass.Name = "cmdpass"
        Me.cmdpass.Size = New System.Drawing.Size(102, 42)
        Me.cmdpass.TabIndex = 102
        Me.cmdpass.Text = "&PASS"
        Me.ToolTip1.SetToolTip(Me.cmdpass, "Save Pass ")
        Me.cmdpass.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     passwesternup.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         passwesternup"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Western;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PassNo", System.Data.SqlDbType.Int, 0, "PassNo"), New System.Data.SqlClient.SqlParameter("@Source", System.Data.SqlDbType.Text, 0, "Source"), New System.Data.SqlClient.SqlParameter("@Destination", System.Data.SqlDbType.Text, 0, "Destination"), New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.Text, 0, "Date"), New System.Data.SqlClient.SqlParameter("@time", System.Data.SqlDbType.Text, 0, "time"), New System.Data.SqlClient.SqlParameter("@Coach", System.Data.SqlDbType.Int, 0, "Coach"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.[Char], 0, "Type"), New System.Data.SqlClient.SqlParameter("@Distance", System.Data.SqlDbType.Int, 0, "Distance"), New System.Data.SqlClient.SqlParameter("@Duration", System.Data.SqlDbType.Int, 0, "Duration"), New System.Data.SqlClient.SqlParameter("@PassType", System.Data.SqlDbType.Text, 0, "PassType"), New System.Data.SqlClient.SqlParameter("@Months", System.Data.SqlDbType.Text, 0, "Months"), New System.Data.SqlClient.SqlParameter("@Class", System.Data.SqlDbType.[Char], 0, "Class"), New System.Data.SqlClient.SqlParameter("@ExpiryDate", System.Data.SqlDbType.Text, 0, "ExpiryDate"), New System.Data.SqlClient.SqlParameter("@Price", System.Data.SqlDbType.Float, 0, "Price")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "passwesternup", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PassNo", "PassNo"), New System.Data.Common.DataColumnMapping("Source", "Source"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("time", "time"), New System.Data.Common.DataColumnMapping("Coach", "Coach"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Distance", "Distance"), New System.Data.Common.DataColumnMapping("Duration", "Duration"), New System.Data.Common.DataColumnMapping("PassType", "PassType"), New System.Data.Common.DataColumnMapping("Months", "Months"), New System.Data.Common.DataColumnMapping("Class", "Class"), New System.Data.Common.DataColumnMapping("ExpiryDate", "ExpiryDate"), New System.Data.Common.DataColumnMapping("Price", "Price")})})
        '
        'Timer1
        '
        '
        'frmWestern_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 524)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmWestern_Pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Western Pass"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtExpiryDate As System.Windows.Forms.TextBox
    Friend WithEvents txtmonths As System.Windows.Forms.TextBox
    Friend WithEvents cbpasstype As System.Windows.Forms.ComboBox
    Friend WithEvents cbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents cbsource As System.Windows.Forms.ComboBox
    Friend WithEvents lblwesternup As System.Windows.Forms.Label
    Friend WithEvents txtpassnum As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents cbroutes As System.Windows.Forms.ComboBox
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents txtdistance As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents lblexpirydate As System.Windows.Forms.Label
    Friend WithEvents lblmonths As System.Windows.Forms.Label
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lblpassnumber As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblpasstype As System.Windows.Forms.Label
    Friend WithEvents lbltotalprice As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents lbldistance As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents cmdback As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdpass As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents lblroute As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
