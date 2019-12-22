<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentral_Ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentral_Ticket))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblroute = New System.Windows.Forms.Label
        Me.lbladultprice = New System.Windows.Forms.Label
        Me.txtchildprice = New System.Windows.Forms.TextBox
        Me.Child = New System.Windows.Forms.Label
        Me.temp = New System.Windows.Forms.TextBox
        Me.chkreturn = New System.Windows.Forms.CheckBox
        Me.lblprice = New System.Windows.Forms.Label
        Me.lbladult = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.txtadultprice = New System.Windows.Forms.TextBox
        Me.txtchild = New System.Windows.Forms.TextBox
        Me.txtadult = New System.Windows.Forms.TextBox
        Me.cbclass = New System.Windows.Forms.ComboBox
        Me.lblticketnumber = New System.Windows.Forms.Label
        Me.txtticketnum = New System.Windows.Forms.TextBox
        Me.lblduration = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.lblto = New System.Windows.Forms.Label
        Me.lbldistance = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblfrom = New System.Windows.Forms.Label
        Me.lblsourcetodestination = New System.Windows.Forms.Label
        Me.cbsource_destination = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbsource = New System.Windows.Forms.ComboBox
        Me.cbdestination = New System.Windows.Forms.ComboBox
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txttime = New System.Windows.Forms.TextBox
        Me.txtduration = New System.Windows.Forms.TextBox
        Me.txtdistance = New System.Windows.Forms.TextBox
        Me.cbroutes = New System.Windows.Forms.ComboBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdticket = New System.Windows.Forms.Button
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
        Me.Panel1.Controls.Add(Me.lblroute)
        Me.Panel1.Controls.Add(Me.lbladultprice)
        Me.Panel1.Controls.Add(Me.txtchildprice)
        Me.Panel1.Controls.Add(Me.Child)
        Me.Panel1.Controls.Add(Me.temp)
        Me.Panel1.Controls.Add(Me.chkreturn)
        Me.Panel1.Controls.Add(Me.lblprice)
        Me.Panel1.Controls.Add(Me.lbladult)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txttotalprice)
        Me.Panel1.Controls.Add(Me.txtadultprice)
        Me.Panel1.Controls.Add(Me.txtchild)
        Me.Panel1.Controls.Add(Me.txtadult)
        Me.Panel1.Controls.Add(Me.cbclass)
        Me.Panel1.Controls.Add(Me.lblticketnumber)
        Me.Panel1.Controls.Add(Me.txtticketnum)
        Me.Panel1.Controls.Add(Me.lblduration)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lblto)
        Me.Panel1.Controls.Add(Me.lbldistance)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblfrom)
        Me.Panel1.Controls.Add(Me.lblsourcetodestination)
        Me.Panel1.Controls.Add(Me.cbsource_destination)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbsource)
        Me.Panel1.Controls.Add(Me.cbdestination)
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.Controls.Add(Me.txttime)
        Me.Panel1.Controls.Add(Me.txtduration)
        Me.Panel1.Controls.Add(Me.txtdistance)
        Me.Panel1.Controls.Add(Me.cbroutes)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 497)
        Me.Panel1.TabIndex = 0
        '
        'lblroute
        '
        Me.lblroute.AutoSize = True
        Me.lblroute.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroute.ForeColor = System.Drawing.Color.White
        Me.lblroute.Location = New System.Drawing.Point(61, 197)
        Me.lblroute.Name = "lblroute"
        Me.lblroute.Size = New System.Drawing.Size(270, 17)
        Me.lblroute.TabIndex = 360
        Me.lblroute.Text = "STATION BETWEEN SOURCE-DEST"
        Me.ToolTip1.SetToolTip(Me.lblroute, "Route")
        '
        'lbladultprice
        '
        Me.lbladultprice.AutoSize = True
        Me.lbladultprice.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbladultprice.ForeColor = System.Drawing.Color.White
        Me.lbladultprice.Location = New System.Drawing.Point(133, 419)
        Me.lbladultprice.Name = "lbladultprice"
        Me.lbladultprice.Size = New System.Drawing.Size(62, 17)
        Me.lbladultprice.TabIndex = 359
        Me.lbladultprice.Text = "ADULT"
        '
        'txtchildprice
        '
        Me.txtchildprice.Location = New System.Drawing.Point(500, 418)
        Me.txtchildprice.Name = "txtchildprice"
        Me.txtchildprice.Size = New System.Drawing.Size(100, 20)
        Me.txtchildprice.TabIndex = 358
        '
        'Child
        '
        Me.Child.AutoSize = True
        Me.Child.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Child.ForeColor = System.Drawing.Color.White
        Me.Child.Location = New System.Drawing.Point(391, 422)
        Me.Child.Name = "Child"
        Me.Child.Size = New System.Drawing.Size(59, 17)
        Me.Child.TabIndex = 357
        Me.Child.Text = "CHILD"
        '
        'temp
        '
        Me.temp.Enabled = False
        Me.temp.Location = New System.Drawing.Point(500, 375)
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(100, 20)
        Me.temp.TabIndex = 356
        '
        'chkreturn
        '
        Me.chkreturn.AutoSize = True
        Me.chkreturn.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkreturn.ForeColor = System.Drawing.Color.White
        Me.chkreturn.Location = New System.Drawing.Point(392, 374)
        Me.chkreturn.Name = "chkreturn"
        Me.chkreturn.Size = New System.Drawing.Size(92, 21)
        Me.chkreturn.TabIndex = 355
        Me.chkreturn.Text = "RETURN"
        Me.ToolTip1.SetToolTip(Me.chkreturn, "Return")
        Me.chkreturn.UseVisualStyleBackColor = True
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblprice.ForeColor = System.Drawing.Color.White
        Me.lblprice.Location = New System.Drawing.Point(67, 419)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(56, 17)
        Me.lblprice.TabIndex = 354
        Me.lblprice.Text = "PRICE"
        Me.ToolTip1.SetToolTip(Me.lblprice, "Price")
        '
        'lbladult
        '
        Me.lbladult.AutoSize = True
        Me.lbladult.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbladult.ForeColor = System.Drawing.Color.White
        Me.lbladult.Location = New System.Drawing.Point(61, 327)
        Me.lbladult.Name = "lbladult"
        Me.lbladult.Size = New System.Drawing.Size(62, 17)
        Me.lbladult.TabIndex = 353
        Me.lbladult.Text = "ADULT"
        Me.ToolTip1.SetToolTip(Me.lbladult, "Adult")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(67, 464)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 17)
        Me.Label14.TabIndex = 350
        Me.Label14.Text = "TOTAL PRICE"
        Me.ToolTip1.SetToolTip(Me.Label14, "Total Price")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(65, 374)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 17)
        Me.Label13.TabIndex = 349
        Me.Label13.Text = "CLASS"
        Me.ToolTip1.SetToolTip(Me.Label13, "Class")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(384, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 17)
        Me.Label12.TabIndex = 345
        Me.Label12.Text = "CHILD"
        Me.ToolTip1.SetToolTip(Me.Label12, "Child")
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(200, 460)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(100, 20)
        Me.txttotalprice.TabIndex = 352
        Me.ToolTip1.SetToolTip(Me.txttotalprice, "Total Price")
        '
        'txtadultprice
        '
        Me.txtadultprice.Location = New System.Drawing.Point(200, 415)
        Me.txtadultprice.Name = "txtadultprice"
        Me.txtadultprice.Size = New System.Drawing.Size(100, 20)
        Me.txtadultprice.TabIndex = 351
        Me.ToolTip1.SetToolTip(Me.txtadultprice, "Price")
        '
        'txtchild
        '
        Me.txtchild.Location = New System.Drawing.Point(502, 330)
        Me.txtchild.Name = "txtchild"
        Me.txtchild.Size = New System.Drawing.Size(100, 20)
        Me.txtchild.TabIndex = 348
        Me.ToolTip1.SetToolTip(Me.txtchild, "Enter a quantity of Child")
        '
        'txtadult
        '
        Me.txtadult.Location = New System.Drawing.Point(200, 327)
        Me.txtadult.Name = "txtadult"
        Me.txtadult.Size = New System.Drawing.Size(100, 20)
        Me.txtadult.TabIndex = 347
        Me.ToolTip1.SetToolTip(Me.txtadult, "Enter a quantity of Adult")
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(200, 373)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(102, 21)
        Me.cbclass.TabIndex = 346
        Me.ToolTip1.SetToolTip(Me.cbclass, "Select First class OR Second class")
        '
        'lblticketnumber
        '
        Me.lblticketnumber.AutoSize = True
        Me.lblticketnumber.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblticketnumber.ForeColor = System.Drawing.Color.White
        Me.lblticketnumber.Location = New System.Drawing.Point(59, 72)
        Me.lblticketnumber.Name = "lblticketnumber"
        Me.lblticketnumber.Size = New System.Drawing.Size(139, 17)
        Me.lblticketnumber.TabIndex = 343
        Me.lblticketnumber.Text = "TICKET NUMBER"
        Me.ToolTip1.SetToolTip(Me.lblticketnumber, "Ticket Number")
        '
        'txtticketnum
        '
        Me.txtticketnum.Location = New System.Drawing.Point(198, 68)
        Me.txtticketnum.Name = "txtticketnum"
        Me.txtticketnum.Size = New System.Drawing.Size(173, 20)
        Me.txtticketnum.TabIndex = 341
        Me.ToolTip1.SetToolTip(Me.txtticketnum, "Ticket NUmber")
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblduration.ForeColor = System.Drawing.Color.White
        Me.lblduration.Location = New System.Drawing.Point(384, 288)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(96, 17)
        Me.lblduration.TabIndex = 336
        Me.lblduration.Text = "DURATION"
        Me.ToolTip1.SetToolTip(Me.lblduration, "Duration")
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(384, 243)
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
        Me.lblto.Location = New System.Drawing.Point(384, 157)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(30, 17)
        Me.lblto.TabIndex = 333
        Me.lblto.Text = "TO"
        Me.ToolTip1.SetToolTip(Me.lblto, "To")
        '
        'lbldistance
        '
        Me.lbldistance.AutoSize = True
        Me.lbldistance.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbldistance.ForeColor = System.Drawing.Color.White
        Me.lbldistance.Location = New System.Drawing.Point(63, 284)
        Me.lbldistance.Name = "lbldistance"
        Me.lbldistance.Size = New System.Drawing.Size(88, 17)
        Me.lbldistance.TabIndex = 328
        Me.lbldistance.Text = "DISTANCE"
        Me.ToolTip1.SetToolTip(Me.lbldistance, "Distance")
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(65, 239)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(43, 15)
        Me.lbldate.TabIndex = 326
        Me.lbldate.Text = "DATE"
        Me.ToolTip1.SetToolTip(Me.lbldate, "Date")
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.ForeColor = System.Drawing.Color.White
        Me.lblfrom.Location = New System.Drawing.Point(59, 156)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(53, 17)
        Me.lblfrom.TabIndex = 325
        Me.lblfrom.Text = "FROM"
        Me.ToolTip1.SetToolTip(Me.lblfrom, "From")
        '
        'lblsourcetodestination
        '
        Me.lblsourcetodestination.AutoSize = True
        Me.lblsourcetodestination.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsourcetodestination.ForeColor = System.Drawing.Color.White
        Me.lblsourcetodestination.Location = New System.Drawing.Point(59, 111)
        Me.lblsourcetodestination.Name = "lblsourcetodestination"
        Me.lblsourcetodestination.Size = New System.Drawing.Size(116, 17)
        Me.lblsourcetodestination.TabIndex = 322
        Me.lblsourcetodestination.Text = "SOURCE-DEST"
        Me.ToolTip1.SetToolTip(Me.lblsourcetodestination, "Source to Destination")
        '
        'cbsource_destination
        '
        Me.cbsource_destination.FormattingEnabled = True
        Me.cbsource_destination.Location = New System.Drawing.Point(198, 110)
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
        Me.Label1.Location = New System.Drawing.Point(56, 6)
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
        Me.cbsource.Location = New System.Drawing.Point(198, 151)
        Me.cbsource.Name = "cbsource"
        Me.cbsource.Size = New System.Drawing.Size(175, 21)
        Me.cbsource.TabIndex = 305
        Me.ToolTip1.SetToolTip(Me.cbsource, "From")
        '
        'cbdestination
        '
        Me.cbdestination.DropDownHeight = 150
        Me.cbdestination.DropDownWidth = 100
        Me.cbdestination.FormattingEnabled = True
        Me.cbdestination.IntegralHeight = False
        Me.cbdestination.Location = New System.Drawing.Point(427, 151)
        Me.cbdestination.Name = "cbdestination"
        Me.cbdestination.Size = New System.Drawing.Size(175, 21)
        Me.cbdestination.TabIndex = 306
        Me.ToolTip1.SetToolTip(Me.cbdestination, "Destinaion")
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(198, 238)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 20)
        Me.txtdate.TabIndex = 288
        Me.ToolTip1.SetToolTip(Me.txtdate, "Date")
        '
        'txttime
        '
        Me.txttime.Enabled = False
        Me.txttime.Location = New System.Drawing.Point(500, 239)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 20)
        Me.txttime.TabIndex = 287
        Me.ToolTip1.SetToolTip(Me.txttime, "Time")
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(500, 284)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(100, 20)
        Me.txtduration.TabIndex = 296
        Me.ToolTip1.SetToolTip(Me.txtduration, "Duration")
        '
        'txtdistance
        '
        Me.txtdistance.Location = New System.Drawing.Point(198, 283)
        Me.txtdistance.Name = "txtdistance"
        Me.txtdistance.Size = New System.Drawing.Size(100, 20)
        Me.txtdistance.TabIndex = 295
        Me.ToolTip1.SetToolTip(Me.txtdistance, "Distance")
        '
        'cbroutes
        '
        Me.cbroutes.DropDownHeight = 150
        Me.cbroutes.FormattingEnabled = True
        Me.cbroutes.IntegralHeight = False
        Me.cbroutes.Location = New System.Drawing.Point(425, 192)
        Me.cbroutes.Name = "cbroutes"
        Me.cbroutes.Size = New System.Drawing.Size(175, 21)
        Me.cbroutes.TabIndex = 308
        Me.ToolTip1.SetToolTip(Me.cbroutes, "Routes")
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(260, 55)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(102, 42)
        Me.cmdback.TabIndex = 81
        Me.cmdback.Text = "BACK"
        Me.ToolTip1.SetToolTip(Me.cmdback, "Back to the Main Menu")
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(437, 55)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(102, 42)
        Me.cmdcancel.TabIndex = 76
        Me.cmdcancel.Text = "&CANCEL"
        Me.ToolTip1.SetToolTip(Me.cmdcancel, "Exit")
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(437, 3)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(102, 42)
        Me.cmdsearch.TabIndex = 73
        Me.cmdsearch.Text = "&SEARCH"
        Me.ToolTip1.SetToolTip(Me.cmdsearch, "Search a Ticket")
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmdnew
        '
        Me.cmdnew.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(260, 0)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(102, 42)
        Me.cmdnew.TabIndex = 72
        Me.cmdnew.Text = "&NEW"
        Me.ToolTip1.SetToolTip(Me.cmdnew, "Create a new Ticket")
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdticket
        '
        Me.cmdticket.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdticket.Location = New System.Drawing.Point(78, 0)
        Me.cmdticket.Name = "cmdticket"
        Me.cmdticket.Size = New System.Drawing.Size(102, 42)
        Me.cmdticket.TabIndex = 71
        Me.cmdticket.Text = "&TICKET"
        Me.ToolTip1.SetToolTip(Me.cmdticket, "Save the Ticket")
        Me.cmdticket.UseVisualStyleBackColor = True
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
        Me.Panel2.Controls.Add(Me.cmdticket)
        Me.Panel2.Location = New System.Drawing.Point(3, 504)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 100)
        Me.Panel2.TabIndex = 1
        '
        'cmdprint
        '
        Me.cmdprint.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(78, 55)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(102, 42)
        Me.cmdprint.TabIndex = 112
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
        'frmCentral_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(672, 609)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCentral_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Central Ticket"
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
    Friend WithEvents cbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents txtdistance As System.Windows.Forms.TextBox
    Friend WithEvents cbroutes As System.Windows.Forms.ComboBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbldistance As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents temp As System.Windows.Forms.TextBox
    Friend WithEvents chkreturn As System.Windows.Forms.CheckBox
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lbladult As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents txtadultprice As System.Windows.Forms.TextBox
    Friend WithEvents txtchild As System.Windows.Forms.TextBox
    Friend WithEvents txtadult As System.Windows.Forms.TextBox
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents lblticketnumber As System.Windows.Forms.Label
    Friend WithEvents txtticketnum As System.Windows.Forms.TextBox
    Friend WithEvents cmdback As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdticket As System.Windows.Forms.Button
    Friend WithEvents txtchildprice As System.Windows.Forms.TextBox
    Friend WithEvents Child As System.Windows.Forms.Label
    Friend WithEvents lbladultprice As System.Windows.Forms.Label
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents lblroute As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
