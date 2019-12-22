<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentral_Pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentral_Pass))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblexpirydate = New System.Windows.Forms.Label
        Me.lblmonths = New System.Windows.Forms.Label
        Me.lblduration = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.lblto = New System.Windows.Forms.Label
        Me.lblpasstype = New System.Windows.Forms.Label
        Me.lblroute = New System.Windows.Forms.Label
        Me.lbltotalprice = New System.Windows.Forms.Label
        Me.lblclass = New System.Windows.Forms.Label
        Me.lbldistance = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblfrom = New System.Windows.Forms.Label
        Me.lblpassnumber = New System.Windows.Forms.Label
        Me.lblsourcetodestination = New System.Windows.Forms.Label
        Me.cbsource_destination = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbsource = New System.Windows.Forms.ComboBox
        Me.txtExpiryDate = New System.Windows.Forms.TextBox
        Me.txtmonths = New System.Windows.Forms.TextBox
        Me.cbpasstype = New System.Windows.Forms.ComboBox
        Me.cbdestination = New System.Windows.Forms.ComboBox
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txttime = New System.Windows.Forms.TextBox
        Me.txtPassnum = New System.Windows.Forms.TextBox
        Me.txtduration = New System.Windows.Forms.TextBox
        Me.txtdistance = New System.Windows.Forms.TextBox
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.cbclass = New System.Windows.Forms.ComboBox
        Me.cbroutes = New System.Windows.Forms.ComboBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdpass = New System.Windows.Forms.Button
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdprint = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.lblexpirydate)
        Me.Panel1.Controls.Add(Me.lblmonths)
        Me.Panel1.Controls.Add(Me.lblduration)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lblto)
        Me.Panel1.Controls.Add(Me.lblpasstype)
        Me.Panel1.Controls.Add(Me.lblroute)
        Me.Panel1.Controls.Add(Me.lbltotalprice)
        Me.Panel1.Controls.Add(Me.lblclass)
        Me.Panel1.Controls.Add(Me.lbldistance)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblfrom)
        Me.Panel1.Controls.Add(Me.lblpassnumber)
        Me.Panel1.Controls.Add(Me.lblsourcetodestination)
        Me.Panel1.Controls.Add(Me.cbsource_destination)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbsource)
        Me.Panel1.Controls.Add(Me.txtExpiryDate)
        Me.Panel1.Controls.Add(Me.txtmonths)
        Me.Panel1.Controls.Add(Me.cbpasstype)
        Me.Panel1.Controls.Add(Me.cbdestination)
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.Controls.Add(Me.txttime)
        Me.Panel1.Controls.Add(Me.txtPassnum)
        Me.Panel1.Controls.Add(Me.txtduration)
        Me.Panel1.Controls.Add(Me.txtdistance)
        Me.Panel1.Controls.Add(Me.txttotalprice)
        Me.Panel1.Controls.Add(Me.cbclass)
        Me.Panel1.Controls.Add(Me.cbroutes)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 418)
        Me.Panel1.TabIndex = 0
        '
        'lblexpirydate
        '
        Me.lblexpirydate.AutoSize = True
        Me.lblexpirydate.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpirydate.ForeColor = System.Drawing.Color.White
        Me.lblexpirydate.Location = New System.Drawing.Point(381, 340)
        Me.lblexpirydate.Name = "lblexpirydate"
        Me.lblexpirydate.Size = New System.Drawing.Size(112, 17)
        Me.lblexpirydate.TabIndex = 338
        Me.lblexpirydate.Text = "EXPIRY DATE"
        Me.ToolTip1.SetToolTip(Me.lblexpirydate, "Expiry Date")
        '
        'lblmonths
        '
        Me.lblmonths.AutoSize = True
        Me.lblmonths.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonths.ForeColor = System.Drawing.Color.White
        Me.lblmonths.Location = New System.Drawing.Point(381, 303)
        Me.lblmonths.Name = "lblmonths"
        Me.lblmonths.Size = New System.Drawing.Size(75, 17)
        Me.lblmonths.TabIndex = 337
        Me.lblmonths.Text = "MONTHS"
        Me.ToolTip1.SetToolTip(Me.lblmonths, "Months")
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduration.ForeColor = System.Drawing.Color.White
        Me.lblduration.Location = New System.Drawing.Point(381, 265)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(96, 17)
        Me.lblduration.TabIndex = 336
        Me.lblduration.Text = "DURATION"
        Me.ToolTip1.SetToolTip(Me.lblduration, "Duration")
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(381, 224)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(48, 17)
        Me.lbltime.TabIndex = 334
        Me.lbltime.Text = "TIME"
        Me.ToolTip1.SetToolTip(Me.lbltime, "Time")
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.ForeColor = System.Drawing.Color.White
        Me.lblto.Location = New System.Drawing.Point(381, 150)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(30, 17)
        Me.lblto.TabIndex = 333
        Me.lblto.Text = "TO"
        Me.ToolTip1.SetToolTip(Me.lblto, "To")
        '
        'lblpasstype
        '
        Me.lblpasstype.AutoSize = True
        Me.lblpasstype.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpasstype.ForeColor = System.Drawing.Color.White
        Me.lblpasstype.Location = New System.Drawing.Point(60, 301)
        Me.lblpasstype.Name = "lblpasstype"
        Me.lblpasstype.Size = New System.Drawing.Size(88, 17)
        Me.lblpasstype.TabIndex = 332
        Me.lblpasstype.Text = "PASS TYPE"
        Me.ToolTip1.SetToolTip(Me.lblpasstype, "Pass Type")
        '
        'lblroute
        '
        Me.lblroute.AutoSize = True
        Me.lblroute.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroute.ForeColor = System.Drawing.Color.White
        Me.lblroute.Location = New System.Drawing.Point(60, 187)
        Me.lblroute.Name = "lblroute"
        Me.lblroute.Size = New System.Drawing.Size(270, 17)
        Me.lblroute.TabIndex = 331
        Me.lblroute.Text = "STATION BETWEEN SOURCE-DEST"
        Me.ToolTip1.SetToolTip(Me.lblroute, "Route")
        '
        'lbltotalprice
        '
        Me.lbltotalprice.AutoSize = True
        Me.lbltotalprice.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalprice.ForeColor = System.Drawing.Color.White
        Me.lbltotalprice.Location = New System.Drawing.Point(60, 380)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(113, 17)
        Me.lbltotalprice.TabIndex = 330
        Me.lbltotalprice.Text = "TOTAL PRICE"
        Me.ToolTip1.SetToolTip(Me.lbltotalprice, "Total Price")
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclass.ForeColor = System.Drawing.Color.White
        Me.lblclass.Location = New System.Drawing.Point(60, 339)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(54, 17)
        Me.lblclass.TabIndex = 329
        Me.lblclass.Text = "CLASS"
        Me.ToolTip1.SetToolTip(Me.lblclass, "Class")
        '
        'lbldistance
        '
        Me.lbldistance.AutoSize = True
        Me.lbldistance.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldistance.ForeColor = System.Drawing.Color.White
        Me.lbldistance.Location = New System.Drawing.Point(60, 261)
        Me.lbldistance.Name = "lbldistance"
        Me.lbldistance.Size = New System.Drawing.Size(88, 17)
        Me.lbldistance.TabIndex = 328
        Me.lbldistance.Text = "DISTANCE"
        Me.ToolTip1.SetToolTip(Me.lbldistance, "Distance")
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(62, 220)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(50, 17)
        Me.lbldate.TabIndex = 326
        Me.lbldate.Text = "DATE"
        Me.ToolTip1.SetToolTip(Me.lbldate, "Date")
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.ForeColor = System.Drawing.Color.White
        Me.lblfrom.Location = New System.Drawing.Point(62, 154)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(53, 17)
        Me.lblfrom.TabIndex = 325
        Me.lblfrom.Text = "FROM"
        Me.ToolTip1.SetToolTip(Me.lblfrom, "From")
        '
        'lblpassnumber
        '
        Me.lblpassnumber.AutoSize = True
        Me.lblpassnumber.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassnumber.ForeColor = System.Drawing.Color.White
        Me.lblpassnumber.Location = New System.Drawing.Point(59, 68)
        Me.lblpassnumber.Name = "lblpassnumber"
        Me.lblpassnumber.Size = New System.Drawing.Size(118, 17)
        Me.lblpassnumber.TabIndex = 324
        Me.lblpassnumber.Text = "PASS NUMBER"
        Me.ToolTip1.SetToolTip(Me.lblpassnumber, "Pass Numbers")
        '
        'lblsourcetodestination
        '
        Me.lblsourcetodestination.AutoSize = True
        Me.lblsourcetodestination.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsourcetodestination.ForeColor = System.Drawing.Color.White
        Me.lblsourcetodestination.Location = New System.Drawing.Point(59, 108)
        Me.lblsourcetodestination.Name = "lblsourcetodestination"
        Me.lblsourcetodestination.Size = New System.Drawing.Size(116, 17)
        Me.lblsourcetodestination.TabIndex = 322
        Me.lblsourcetodestination.Text = "SOURCE-DEST"
        Me.ToolTip1.SetToolTip(Me.lblsourcetodestination, "Source to Destination")
        '
        'cbsource_destination
        '
        Me.cbsource_destination.FormattingEnabled = True
        Me.cbsource_destination.Location = New System.Drawing.Point(190, 107)
        Me.cbsource_destination.Name = "cbsource_destination"
        Me.cbsource_destination.Size = New System.Drawing.Size(173, 21)
        Me.cbsource_destination.TabIndex = 321
        Me.ToolTip1.SetToolTip(Me.cbsource_destination, "Source to Destination")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Sienna
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(56, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 36)
        Me.Label1.TabIndex = 320
        Me.Label1.Text = "WELCOME TO CENTRAL RAILWAY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbsource
        '
        Me.cbsource.DropDownHeight = 150
        Me.cbsource.DropDownWidth = 100
        Me.cbsource.FormattingEnabled = True
        Me.cbsource.IntegralHeight = False
        Me.cbsource.Location = New System.Drawing.Point(191, 149)
        Me.cbsource.Name = "cbsource"
        Me.cbsource.Size = New System.Drawing.Size(175, 21)
        Me.cbsource.TabIndex = 305
        Me.ToolTip1.SetToolTip(Me.cbsource, "From")
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Location = New System.Drawing.Point(497, 340)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(100, 20)
        Me.txtExpiryDate.TabIndex = 317
        Me.ToolTip1.SetToolTip(Me.txtExpiryDate, "Expiry Date")
        '
        'txtmonths
        '
        Me.txtmonths.Location = New System.Drawing.Point(496, 298)
        Me.txtmonths.Name = "txtmonths"
        Me.txtmonths.Size = New System.Drawing.Size(100, 20)
        Me.txtmonths.TabIndex = 316
        Me.ToolTip1.SetToolTip(Me.txtmonths, "Months")
        '
        'cbpasstype
        '
        Me.cbpasstype.FormattingEnabled = True
        Me.cbpasstype.Location = New System.Drawing.Point(191, 298)
        Me.cbpasstype.Name = "cbpasstype"
        Me.cbpasstype.Size = New System.Drawing.Size(154, 21)
        Me.cbpasstype.TabIndex = 313
        Me.ToolTip1.SetToolTip(Me.cbpasstype, "Pass Type")
        '
        'cbdestination
        '
        Me.cbdestination.DropDownHeight = 150
        Me.cbdestination.DropDownWidth = 100
        Me.cbdestination.FormattingEnabled = True
        Me.cbdestination.IntegralHeight = False
        Me.cbdestination.Location = New System.Drawing.Point(424, 149)
        Me.cbdestination.Name = "cbdestination"
        Me.cbdestination.Size = New System.Drawing.Size(175, 21)
        Me.cbdestination.TabIndex = 306
        Me.ToolTip1.SetToolTip(Me.cbdestination, "Destinaion")
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(191, 220)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 20)
        Me.txtdate.TabIndex = 288
        Me.ToolTip1.SetToolTip(Me.txtdate, "Date")
        '
        'txttime
        '
        Me.txttime.Enabled = False
        Me.txttime.Location = New System.Drawing.Point(497, 220)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 20)
        Me.txttime.TabIndex = 287
        Me.ToolTip1.SetToolTip(Me.txttime, "Time")
        '
        'txtPassnum
        '
        Me.txtPassnum.Location = New System.Drawing.Point(188, 68)
        Me.txtPassnum.Name = "txtPassnum"
        Me.txtPassnum.Size = New System.Drawing.Size(173, 20)
        Me.txtPassnum.TabIndex = 282
        Me.ToolTip1.SetToolTip(Me.txtPassnum, "Pass NUmber")
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(497, 261)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(100, 20)
        Me.txtduration.TabIndex = 296
        Me.ToolTip1.SetToolTip(Me.txtduration, "Duration")
        '
        'txtdistance
        '
        Me.txtdistance.Location = New System.Drawing.Point(191, 261)
        Me.txtdistance.Name = "txtdistance"
        Me.txtdistance.Size = New System.Drawing.Size(100, 20)
        Me.txtdistance.TabIndex = 295
        Me.ToolTip1.SetToolTip(Me.txtdistance, "Distance")
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(191, 376)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(100, 20)
        Me.txttotalprice.TabIndex = 312
        Me.ToolTip1.SetToolTip(Me.txttotalprice, "Total Price")
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(191, 339)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(154, 21)
        Me.cbclass.TabIndex = 309
        Me.ToolTip1.SetToolTip(Me.cbclass, "Select First class OR Second class")
        '
        'cbroutes
        '
        Me.cbroutes.DropDownHeight = 150
        Me.cbroutes.FormattingEnabled = True
        Me.cbroutes.IntegralHeight = False
        Me.cbroutes.Location = New System.Drawing.Point(424, 186)
        Me.cbroutes.Name = "cbroutes"
        Me.cbroutes.Size = New System.Drawing.Size(175, 21)
        Me.cbroutes.TabIndex = 308
        Me.ToolTip1.SetToolTip(Me.cbroutes, "Routes")
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(291, 56)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(102, 42)
        Me.cmdback.TabIndex = 115
        Me.cmdback.Text = "BACK"
        Me.ToolTip1.SetToolTip(Me.cmdback, "Back")
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(468, 60)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(102, 42)
        Me.cmdcancel.TabIndex = 114
        Me.cmdcancel.Text = "&CANCEL"
        Me.ToolTip1.SetToolTip(Me.cmdcancel, "Exit")
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(468, 0)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(102, 42)
        Me.cmdsearch.TabIndex = 111
        Me.cmdsearch.Text = "&SEARCH"
        Me.ToolTip1.SetToolTip(Me.cmdsearch, "Search Pass")
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmdnew
        '
        Me.cmdnew.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(291, 0)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(102, 42)
        Me.cmdnew.TabIndex = 110
        Me.cmdnew.Text = "&NEW"
        Me.ToolTip1.SetToolTip(Me.cmdnew, "Create New Pass")
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdpass
        '
        Me.cmdpass.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpass.Location = New System.Drawing.Point(109, 0)
        Me.cmdpass.Name = "cmdpass"
        Me.cmdpass.Size = New System.Drawing.Size(102, 42)
        Me.cmdpass.TabIndex = 109
        Me.cmdpass.Text = "&PASS"
        Me.ToolTip1.SetToolTip(Me.cmdpass, "Save Pass")
        Me.cmdpass.UseVisualStyleBackColor = True
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdprint)
        Me.Panel2.Controls.Add(Me.cmdback)
        Me.Panel2.Controls.Add(Me.cmdcancel)
        Me.Panel2.Controls.Add(Me.cmdsearch)
        Me.Panel2.Controls.Add(Me.cmdnew)
        Me.Panel2.Controls.Add(Me.cmdpass)
        Me.Panel2.Location = New System.Drawing.Point(3, 426)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 106)
        Me.Panel2.TabIndex = 1
        '
        'cmdprint
        '
        Me.cmdprint.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(109, 53)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(102, 42)
        Me.cmdprint.TabIndex = 116
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     passcentralup.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         passcentralup"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Central;Integrated Security=True"
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
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "passcentralup", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PassNo", "PassNo"), New System.Data.Common.DataColumnMapping("Source", "Source"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("time", "time"), New System.Data.Common.DataColumnMapping("Coach", "Coach"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Distance", "Distance"), New System.Data.Common.DataColumnMapping("Duration", "Duration"), New System.Data.Common.DataColumnMapping("PassType", "PassType"), New System.Data.Common.DataColumnMapping("Months", "Months"), New System.Data.Common.DataColumnMapping("Class", "Class"), New System.Data.Common.DataColumnMapping("ExpiryDate", "ExpiryDate"), New System.Data.Common.DataColumnMapping("Price", "Price")})})
        '
        'Timer1
        '
        '
        'frmCentral_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(674, 540)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCentral_Pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Central Pass"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblsourcetodestination As System.Windows.Forms.Label
    Friend WithEvents cbsource_destination As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbsource As System.Windows.Forms.ComboBox
    Friend WithEvents txtExpiryDate As System.Windows.Forms.TextBox
    Friend WithEvents txtmonths As System.Windows.Forms.TextBox
    Friend WithEvents cbpasstype As System.Windows.Forms.ComboBox
    Friend WithEvents cbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents txtPassnum As System.Windows.Forms.TextBox
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents txtdistance As System.Windows.Forms.TextBox
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents cbroutes As System.Windows.Forms.ComboBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdback As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdpass As System.Windows.Forms.Button
    Friend WithEvents lblpassnumber As System.Windows.Forms.Label
    Friend WithEvents lblpasstype As System.Windows.Forms.Label
    Friend WithEvents lblroute As System.Windows.Forms.Label
    Friend WithEvents lbltotalprice As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents lbldistance As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents lblexpirydate As System.Windows.Forms.Label
    Friend WithEvents lblmonths As System.Windows.Forms.Label
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
