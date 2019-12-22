<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHarbour_Ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHarbour_Ticket))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblroute = New System.Windows.Forms.Label
        Me.txtchildprice = New System.Windows.Forms.TextBox
        Me.Child = New System.Windows.Forms.Label
        Me.lbladultprice = New System.Windows.Forms.Label
        Me.lblwelcomeharbourup = New System.Windows.Forms.Label
        Me.txtticketnum = New System.Windows.Forms.TextBox
        Me.lblticketnumber = New System.Windows.Forms.Label
        Me.temp = New System.Windows.Forms.TextBox
        Me.txtadultprice = New System.Windows.Forms.TextBox
        Me.lblprice = New System.Windows.Forms.Label
        Me.lbltotalprice = New System.Windows.Forms.Label
        Me.chkreturn = New System.Windows.Forms.CheckBox
        Me.lblclass = New System.Windows.Forms.Label
        Me.txtchild = New System.Windows.Forms.TextBox
        Me.txtadult = New System.Windows.Forms.TextBox
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.cbclass = New System.Windows.Forms.ComboBox
        Me.lblchild = New System.Windows.Forms.Label
        Me.lbladult = New System.Windows.Forms.Label
        Me.lblduration = New System.Windows.Forms.Label
        Me.lbldistance = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.lblto = New System.Windows.Forms.Label
        Me.lblfrom = New System.Windows.Forms.Label
        Me.cbsource = New System.Windows.Forms.ComboBox
        Me.cbroutes = New System.Windows.Forms.ComboBox
        Me.txtduration = New System.Windows.Forms.TextBox
        Me.txtdistance = New System.Windows.Forms.TextBox
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txttime = New System.Windows.Forms.TextBox
        Me.cbdestination = New System.Windows.Forms.ComboBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdprint = New System.Windows.Forms.Button
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdticket = New System.Windows.Forms.Button
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
        Me.Panel1.Controls.Add(Me.lblroute)
        Me.Panel1.Controls.Add(Me.txtchildprice)
        Me.Panel1.Controls.Add(Me.Child)
        Me.Panel1.Controls.Add(Me.lbladultprice)
        Me.Panel1.Controls.Add(Me.lblwelcomeharbourup)
        Me.Panel1.Controls.Add(Me.txtticketnum)
        Me.Panel1.Controls.Add(Me.lblticketnumber)
        Me.Panel1.Controls.Add(Me.temp)
        Me.Panel1.Controls.Add(Me.txtadultprice)
        Me.Panel1.Controls.Add(Me.lblprice)
        Me.Panel1.Controls.Add(Me.lbltotalprice)
        Me.Panel1.Controls.Add(Me.chkreturn)
        Me.Panel1.Controls.Add(Me.lblclass)
        Me.Panel1.Controls.Add(Me.txtchild)
        Me.Panel1.Controls.Add(Me.txtadult)
        Me.Panel1.Controls.Add(Me.txttotalprice)
        Me.Panel1.Controls.Add(Me.cbclass)
        Me.Panel1.Controls.Add(Me.lblchild)
        Me.Panel1.Controls.Add(Me.lbladult)
        Me.Panel1.Controls.Add(Me.lblduration)
        Me.Panel1.Controls.Add(Me.lbldistance)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lblto)
        Me.Panel1.Controls.Add(Me.lblfrom)
        Me.Panel1.Controls.Add(Me.cbsource)
        Me.Panel1.Controls.Add(Me.cbroutes)
        Me.Panel1.Controls.Add(Me.txtduration)
        Me.Panel1.Controls.Add(Me.txtdistance)
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.Controls.Add(Me.txttime)
        Me.Panel1.Controls.Add(Me.cbdestination)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 450)
        Me.Panel1.TabIndex = 0
        '
        'lblroute
        '
        Me.lblroute.AutoSize = True
        Me.lblroute.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblroute.ForeColor = System.Drawing.Color.White
        Me.lblroute.Location = New System.Drawing.Point(68, 152)
        Me.lblroute.Name = "lblroute"
        Me.lblroute.Size = New System.Drawing.Size(270, 17)
        Me.lblroute.TabIndex = 332
        Me.lblroute.Text = "STATION BETWEEN SOURCE-DEST"
        Me.ToolTip1.SetToolTip(Me.lblroute, "Route")
        '
        'txtchildprice
        '
        Me.txtchildprice.Location = New System.Drawing.Point(493, 380)
        Me.txtchildprice.Name = "txtchildprice"
        Me.txtchildprice.Size = New System.Drawing.Size(100, 20)
        Me.txtchildprice.TabIndex = 156
        '
        'Child
        '
        Me.Child.AutoSize = True
        Me.Child.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Child.ForeColor = System.Drawing.Color.White
        Me.Child.Location = New System.Drawing.Point(385, 381)
        Me.Child.Name = "Child"
        Me.Child.Size = New System.Drawing.Size(59, 17)
        Me.Child.TabIndex = 155
        Me.Child.Text = "CHILD"
        '
        'lbladultprice
        '
        Me.lbladultprice.AutoSize = True
        Me.lbladultprice.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbladultprice.ForeColor = System.Drawing.Color.White
        Me.lbladultprice.Location = New System.Drawing.Point(154, 377)
        Me.lbladultprice.Name = "lbladultprice"
        Me.lbladultprice.Size = New System.Drawing.Size(62, 17)
        Me.lbladultprice.TabIndex = 154
        Me.lbladultprice.Text = "ADULT"
        '
        'lblwelcomeharbourup
        '
        Me.lblwelcomeharbourup.AutoSize = True
        Me.lblwelcomeharbourup.BackColor = System.Drawing.Color.Sienna
        Me.lblwelcomeharbourup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblwelcomeharbourup.Font = New System.Drawing.Font("Kristen ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcomeharbourup.ForeColor = System.Drawing.Color.Yellow
        Me.lblwelcomeharbourup.Location = New System.Drawing.Point(88, 0)
        Me.lblwelcomeharbourup.Name = "lblwelcomeharbourup"
        Me.lblwelcomeharbourup.Size = New System.Drawing.Size(493, 36)
        Me.lblwelcomeharbourup.TabIndex = 153
        Me.lblwelcomeharbourup.Text = "WELCOME TO HARBOUR LINE"
        '
        'txtticketnum
        '
        Me.txtticketnum.Location = New System.Drawing.Point(212, 64)
        Me.txtticketnum.Name = "txtticketnum"
        Me.txtticketnum.Size = New System.Drawing.Size(155, 20)
        Me.txtticketnum.TabIndex = 152
        '
        'lblticketnumber
        '
        Me.lblticketnumber.AutoSize = True
        Me.lblticketnumber.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblticketnumber.ForeColor = System.Drawing.Color.White
        Me.lblticketnumber.Location = New System.Drawing.Point(67, 64)
        Me.lblticketnumber.Name = "lblticketnumber"
        Me.lblticketnumber.Size = New System.Drawing.Size(139, 17)
        Me.lblticketnumber.TabIndex = 151
        Me.lblticketnumber.Text = "TICKET NUMBER"
        '
        'temp
        '
        Me.temp.Enabled = False
        Me.temp.Location = New System.Drawing.Point(493, 332)
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(100, 20)
        Me.temp.TabIndex = 148
        '
        'txtadultprice
        '
        Me.txtadultprice.Location = New System.Drawing.Point(212, 377)
        Me.txtadultprice.Name = "txtadultprice"
        Me.txtadultprice.Size = New System.Drawing.Size(100, 20)
        Me.txtadultprice.TabIndex = 146
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblprice.ForeColor = System.Drawing.Color.White
        Me.lblprice.Location = New System.Drawing.Point(70, 377)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(56, 17)
        Me.lblprice.TabIndex = 145
        Me.lblprice.Text = "PRICE"
        '
        'lbltotalprice
        '
        Me.lbltotalprice.AutoSize = True
        Me.lbltotalprice.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltotalprice.ForeColor = System.Drawing.Color.White
        Me.lbltotalprice.Location = New System.Drawing.Point(68, 415)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(113, 17)
        Me.lbltotalprice.TabIndex = 144
        Me.lbltotalprice.Text = "TOTAL PRICE"
        '
        'chkreturn
        '
        Me.chkreturn.AutoSize = True
        Me.chkreturn.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkreturn.ForeColor = System.Drawing.Color.White
        Me.chkreturn.Location = New System.Drawing.Point(382, 328)
        Me.chkreturn.Name = "chkreturn"
        Me.chkreturn.Size = New System.Drawing.Size(92, 21)
        Me.chkreturn.TabIndex = 143
        Me.chkreturn.Text = "RETURN"
        Me.chkreturn.UseVisualStyleBackColor = True
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblclass.ForeColor = System.Drawing.Color.White
        Me.lblclass.Location = New System.Drawing.Point(68, 335)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(54, 17)
        Me.lblclass.TabIndex = 142
        Me.lblclass.Text = "CLASS"
        '
        'txtchild
        '
        Me.txtchild.Location = New System.Drawing.Point(493, 288)
        Me.txtchild.Name = "txtchild"
        Me.txtchild.Size = New System.Drawing.Size(100, 20)
        Me.txtchild.TabIndex = 141
        '
        'txtadult
        '
        Me.txtadult.Location = New System.Drawing.Point(210, 284)
        Me.txtadult.Name = "txtadult"
        Me.txtadult.Size = New System.Drawing.Size(100, 20)
        Me.txtadult.TabIndex = 140
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(212, 415)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(100, 20)
        Me.txttotalprice.TabIndex = 147
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(210, 328)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(102, 21)
        Me.cbclass.TabIndex = 139
        '
        'lblchild
        '
        Me.lblchild.AutoSize = True
        Me.lblchild.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblchild.ForeColor = System.Drawing.Color.White
        Me.lblchild.Location = New System.Drawing.Point(379, 288)
        Me.lblchild.Name = "lblchild"
        Me.lblchild.Size = New System.Drawing.Size(59, 17)
        Me.lblchild.TabIndex = 138
        Me.lblchild.Text = "CHILD"
        '
        'lbladult
        '
        Me.lbladult.AutoSize = True
        Me.lbladult.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbladult.ForeColor = System.Drawing.Color.White
        Me.lbladult.Location = New System.Drawing.Point(70, 290)
        Me.lbladult.Name = "lbladult"
        Me.lbladult.Size = New System.Drawing.Size(62, 17)
        Me.lbladult.TabIndex = 137
        Me.lbladult.Text = "ADULT"
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblduration.ForeColor = System.Drawing.Color.White
        Me.lblduration.Location = New System.Drawing.Point(379, 246)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(96, 17)
        Me.lblduration.TabIndex = 121
        Me.lblduration.Text = "DURATION"
        Me.ToolTip1.SetToolTip(Me.lblduration, "Duration")
        '
        'lbldistance
        '
        Me.lbldistance.AutoSize = True
        Me.lbldistance.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbldistance.ForeColor = System.Drawing.Color.White
        Me.lbldistance.Location = New System.Drawing.Point(68, 245)
        Me.lbldistance.Name = "lbldistance"
        Me.lbldistance.Size = New System.Drawing.Size(88, 17)
        Me.lbldistance.TabIndex = 120
        Me.lbldistance.Text = "DISTANCE"
        Me.ToolTip1.SetToolTip(Me.lbldistance, "Distance")
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(68, 199)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(50, 17)
        Me.lbldate.TabIndex = 113
        Me.lbldate.Text = "DATE"
        Me.ToolTip1.SetToolTip(Me.lbldate, "Date")
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(382, 203)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(48, 17)
        Me.lbltime.TabIndex = 112
        Me.lbltime.Text = "TIME"
        Me.ToolTip1.SetToolTip(Me.lbltime, "Time")
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblto.ForeColor = System.Drawing.Color.White
        Me.lblto.Location = New System.Drawing.Point(385, 112)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(30, 17)
        Me.lblto.TabIndex = 111
        Me.lblto.Text = "TO"
        Me.ToolTip1.SetToolTip(Me.lblto, "To")
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblfrom.ForeColor = System.Drawing.Color.White
        Me.lblfrom.Location = New System.Drawing.Point(72, 106)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(53, 17)
        Me.lblfrom.TabIndex = 110
        Me.lblfrom.Text = "FROM"
        Me.ToolTip1.SetToolTip(Me.lblfrom, "From")
        '
        'cbsource
        '
        Me.cbsource.DropDownHeight = 150
        Me.cbsource.FormattingEnabled = True
        Me.cbsource.IntegralHeight = False
        Me.cbsource.Location = New System.Drawing.Point(212, 106)
        Me.cbsource.Name = "cbsource"
        Me.cbsource.Size = New System.Drawing.Size(155, 21)
        Me.cbsource.TabIndex = 108
        Me.ToolTip1.SetToolTip(Me.cbsource, "From")
        '
        'cbroutes
        '
        Me.cbroutes.DropDownHeight = 150
        Me.cbroutes.DropDownWidth = 155
        Me.cbroutes.FormattingEnabled = True
        Me.cbroutes.IntegralHeight = False
        Me.cbroutes.Location = New System.Drawing.Point(454, 152)
        Me.cbroutes.Name = "cbroutes"
        Me.cbroutes.Size = New System.Drawing.Size(154, 21)
        Me.cbroutes.TabIndex = 136
        Me.ToolTip1.SetToolTip(Me.cbroutes, "Routes")
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(493, 245)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(100, 20)
        Me.txtduration.TabIndex = 123
        Me.ToolTip1.SetToolTip(Me.txtduration, "Duration")
        '
        'txtdistance
        '
        Me.txtdistance.Location = New System.Drawing.Point(212, 242)
        Me.txtdistance.Name = "txtdistance"
        Me.txtdistance.Size = New System.Drawing.Size(100, 20)
        Me.txtdistance.TabIndex = 122
        Me.ToolTip1.SetToolTip(Me.txtdistance, "Distance")
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(212, 199)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 20)
        Me.txtdate.TabIndex = 115
        Me.ToolTip1.SetToolTip(Me.txtdate, "Date")
        '
        'txttime
        '
        Me.txttime.Enabled = False
        Me.txttime.Location = New System.Drawing.Point(493, 202)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 20)
        Me.txttime.TabIndex = 114
        Me.ToolTip1.SetToolTip(Me.txttime, "Time")
        '
        'cbdestination
        '
        Me.cbdestination.DropDownHeight = 150
        Me.cbdestination.FormattingEnabled = True
        Me.cbdestination.IntegralHeight = False
        Me.cbdestination.Location = New System.Drawing.Point(458, 107)
        Me.cbdestination.Name = "cbdestination"
        Me.cbdestination.Size = New System.Drawing.Size(155, 21)
        Me.cbdestination.TabIndex = 109
        Me.ToolTip1.SetToolTip(Me.cbdestination, "Destination")
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tomato
        Me.Panel2.Controls.Add(Me.cmdprint)
        Me.Panel2.Controls.Add(Me.cmdback)
        Me.Panel2.Controls.Add(Me.cmdcancel)
        Me.Panel2.Controls.Add(Me.cmdsearch)
        Me.Panel2.Controls.Add(Me.cmdnew)
        Me.Panel2.Controls.Add(Me.cmdticket)
        Me.Panel2.Location = New System.Drawing.Point(3, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 122)
        Me.Panel2.TabIndex = 143
        '
        'cmdprint
        '
        Me.cmdprint.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(79, 51)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(102, 42)
        Me.cmdprint.TabIndex = 111
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(279, 54)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(102, 42)
        Me.cmdback.TabIndex = 110
        Me.cmdback.Text = "&BACK"
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(469, 51)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(102, 42)
        Me.cmdcancel.TabIndex = 105
        Me.cmdcancel.Text = "&CANCEL"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(469, 0)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(102, 42)
        Me.cmdsearch.TabIndex = 102
        Me.cmdsearch.Text = "&SEARCH"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmdnew
        '
        Me.cmdnew.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(279, 0)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(102, 42)
        Me.cmdnew.TabIndex = 101
        Me.cmdnew.Text = "&NEW"
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdticket
        '
        Me.cmdticket.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdticket.Location = New System.Drawing.Point(79, 0)
        Me.cmdticket.Name = "cmdticket"
        Me.cmdticket.Size = New System.Drawing.Size(102, 42)
        Me.cmdticket.TabIndex = 100
        Me.cmdticket.Text = "&TICKET"
        Me.cmdticket.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     passharup.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         passharup"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Harbour;Integrated Security=True"
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
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "passharup", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PassNo", "PassNo"), New System.Data.Common.DataColumnMapping("Source", "Source"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("time", "time"), New System.Data.Common.DataColumnMapping("Coach", "Coach"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Distance", "Distance"), New System.Data.Common.DataColumnMapping("Duration", "Duration"), New System.Data.Common.DataColumnMapping("PassType", "PassType"), New System.Data.Common.DataColumnMapping("Months", "Months"), New System.Data.Common.DataColumnMapping("Class", "Class"), New System.Data.Common.DataColumnMapping("ExpiryDate", "ExpiryDate"), New System.Data.Common.DataColumnMapping("Price", "Price")})})
        '
        'Timer1
        '
        '
        'frmHarbour_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(672, 560)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmHarbour_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harbour Line Ticket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lbldistance As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cbsource As System.Windows.Forms.ComboBox
    Friend WithEvents cbroutes As System.Windows.Forms.ComboBox
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents txtdistance As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents cbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents temp As System.Windows.Forms.TextBox
    Friend WithEvents txtadultprice As System.Windows.Forms.TextBox
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lbltotalprice As System.Windows.Forms.Label
    Friend WithEvents chkreturn As System.Windows.Forms.CheckBox
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents txtchild As System.Windows.Forms.TextBox
    Friend WithEvents txtadult As System.Windows.Forms.TextBox
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents lblchild As System.Windows.Forms.Label
    Friend WithEvents lbladult As System.Windows.Forms.Label
    Friend WithEvents txtticketnum As System.Windows.Forms.TextBox
    Friend WithEvents lblticketnumber As System.Windows.Forms.Label
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents cmdback As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdticket As System.Windows.Forms.Button
    Friend WithEvents lblwelcomeharbourup As System.Windows.Forms.Label
    Friend WithEvents txtchildprice As System.Windows.Forms.TextBox
    Friend WithEvents Child As System.Windows.Forms.Label
    Friend WithEvents lbladultprice As System.Windows.Forms.Label
    Friend WithEvents lblroute As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
