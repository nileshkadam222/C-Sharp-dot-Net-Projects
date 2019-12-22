<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWestern_Ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWestern_Ticket))
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblroute = New System.Windows.Forms.Label
        Me.lbladultprice = New System.Windows.Forms.Label
        Me.txtchildprice = New System.Windows.Forms.TextBox
        Me.Child = New System.Windows.Forms.Label
        Me.lbltotalprice = New System.Windows.Forms.Label
        Me.chkreturn = New System.Windows.Forms.CheckBox
        Me.lblchild = New System.Windows.Forms.Label
        Me.lblprice = New System.Windows.Forms.Label
        Me.lblclass = New System.Windows.Forms.Label
        Me.lbladult = New System.Windows.Forms.Label
        Me.temp = New System.Windows.Forms.TextBox
        Me.txtadultprice = New System.Windows.Forms.TextBox
        Me.txtchild = New System.Windows.Forms.TextBox
        Me.txtadult = New System.Windows.Forms.TextBox
        Me.txttotalprice = New System.Windows.Forms.TextBox
        Me.cbclass = New System.Windows.Forms.ComboBox
        Me.lblticketnumber = New System.Windows.Forms.Label
        Me.lblwesternup = New System.Windows.Forms.Label
        Me.txtticketnum = New System.Windows.Forms.TextBox
        Me.lbldistance = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblfrom = New System.Windows.Forms.Label
        Me.lblduration = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.lblto = New System.Windows.Forms.Label
        Me.cbdestination = New System.Windows.Forms.ComboBox
        Me.cbsource = New System.Windows.Forms.ComboBox
        Me.txttime = New System.Windows.Forms.TextBox
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
        Me.cmdticket = New System.Windows.Forms.Button
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblroute)
        Me.Panel1.Controls.Add(Me.lbladultprice)
        Me.Panel1.Controls.Add(Me.txtchildprice)
        Me.Panel1.Controls.Add(Me.Child)
        Me.Panel1.Controls.Add(Me.lbltotalprice)
        Me.Panel1.Controls.Add(Me.chkreturn)
        Me.Panel1.Controls.Add(Me.lblchild)
        Me.Panel1.Controls.Add(Me.lblprice)
        Me.Panel1.Controls.Add(Me.lblclass)
        Me.Panel1.Controls.Add(Me.lbladult)
        Me.Panel1.Controls.Add(Me.temp)
        Me.Panel1.Controls.Add(Me.txtadultprice)
        Me.Panel1.Controls.Add(Me.txtchild)
        Me.Panel1.Controls.Add(Me.txtadult)
        Me.Panel1.Controls.Add(Me.txttotalprice)
        Me.Panel1.Controls.Add(Me.cbclass)
        Me.Panel1.Controls.Add(Me.lblticketnumber)
        Me.Panel1.Controls.Add(Me.lblwesternup)
        Me.Panel1.Controls.Add(Me.txtticketnum)
        Me.Panel1.Controls.Add(Me.lbldistance)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblfrom)
        Me.Panel1.Controls.Add(Me.lblduration)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lblto)
        Me.Panel1.Controls.Add(Me.cbdestination)
        Me.Panel1.Controls.Add(Me.cbsource)
        Me.Panel1.Controls.Add(Me.txttime)
        Me.Panel1.Controls.Add(Me.cbroutes)
        Me.Panel1.Controls.Add(Me.txtduration)
        Me.Panel1.Controls.Add(Me.txtdistance)
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 455)
        Me.Panel1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Panel1, "Fast OR Slow")
        '
        'lblroute
        '
        Me.lblroute.AutoSize = True
        Me.lblroute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroute.ForeColor = System.Drawing.Color.White
        Me.lblroute.Location = New System.Drawing.Point(50, 164)
        Me.lblroute.Name = "lblroute"
        Me.lblroute.Size = New System.Drawing.Size(266, 16)
        Me.lblroute.TabIndex = 332
        Me.lblroute.Text = "STATION BETWEEN SOURCE-DEST"
        Me.ToolTip1.SetToolTip(Me.lblroute, "Route")
        '
        'lbladultprice
        '
        Me.lbladultprice.AutoSize = True
        Me.lbladultprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladultprice.ForeColor = System.Drawing.Color.White
        Me.lbladultprice.Location = New System.Drawing.Point(120, 381)
        Me.lbladultprice.Name = "lbladultprice"
        Me.lbladultprice.Size = New System.Drawing.Size(43, 16)
        Me.lbladultprice.TabIndex = 235
        Me.lbladultprice.Text = "Adult"
        '
        'txtchildprice
        '
        Me.txtchildprice.Location = New System.Drawing.Point(496, 380)
        Me.txtchildprice.Name = "txtchildprice"
        Me.txtchildprice.Size = New System.Drawing.Size(100, 20)
        Me.txtchildprice.TabIndex = 234
        '
        'Child
        '
        Me.Child.AutoSize = True
        Me.Child.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Child.ForeColor = System.Drawing.Color.White
        Me.Child.Location = New System.Drawing.Point(375, 384)
        Me.Child.Name = "Child"
        Me.Child.Size = New System.Drawing.Size(43, 16)
        Me.Child.TabIndex = 233
        Me.Child.Text = "Child"
        '
        'lbltotalprice
        '
        Me.lbltotalprice.AutoSize = True
        Me.lbltotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalprice.ForeColor = System.Drawing.Color.White
        Me.lbltotalprice.Location = New System.Drawing.Point(57, 426)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(106, 16)
        Me.lbltotalprice.TabIndex = 232
        Me.lbltotalprice.Text = "TOTAL PRICE"
        Me.ToolTip1.SetToolTip(Me.lbltotalprice, "Total Price")
        '
        'chkreturn
        '
        Me.chkreturn.AutoSize = True
        Me.chkreturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkreturn.ForeColor = System.Drawing.Color.White
        Me.chkreturn.Location = New System.Drawing.Point(374, 336)
        Me.chkreturn.Name = "chkreturn"
        Me.chkreturn.Size = New System.Drawing.Size(91, 20)
        Me.chkreturn.TabIndex = 231
        Me.chkreturn.Text = "RETURN"
        Me.ToolTip1.SetToolTip(Me.chkreturn, "Return")
        Me.chkreturn.UseVisualStyleBackColor = True
        '
        'lblchild
        '
        Me.lblchild.AutoSize = True
        Me.lblchild.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchild.ForeColor = System.Drawing.Color.White
        Me.lblchild.Location = New System.Drawing.Point(372, 295)
        Me.lblchild.Name = "lblchild"
        Me.lblchild.Size = New System.Drawing.Size(52, 16)
        Me.lblchild.TabIndex = 230
        Me.lblchild.Text = "CHILD"
        Me.ToolTip1.SetToolTip(Me.lblchild, "Child")
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.White
        Me.lblprice.Location = New System.Drawing.Point(54, 380)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(53, 16)
        Me.lblprice.TabIndex = 229
        Me.lblprice.Text = "PRICE"
        Me.ToolTip1.SetToolTip(Me.lblprice, "Price")
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclass.ForeColor = System.Drawing.Color.White
        Me.lblclass.Location = New System.Drawing.Point(52, 340)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(56, 16)
        Me.lblclass.TabIndex = 228
        Me.lblclass.Text = "CLASS"
        Me.ToolTip1.SetToolTip(Me.lblclass, "Class")
        '
        'lbladult
        '
        Me.lbladult.AutoSize = True
        Me.lbladult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladult.ForeColor = System.Drawing.Color.White
        Me.lbladult.Location = New System.Drawing.Point(54, 295)
        Me.lbladult.Name = "lbladult"
        Me.lbladult.Size = New System.Drawing.Size(58, 16)
        Me.lbladult.TabIndex = 227
        Me.lbladult.Text = "ADULT"
        Me.ToolTip1.SetToolTip(Me.lbladult, "Adult")
        '
        'temp
        '
        Me.temp.Enabled = False
        Me.temp.Location = New System.Drawing.Point(496, 335)
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(100, 20)
        Me.temp.TabIndex = 226
        Me.ToolTip1.SetToolTip(Me.temp, "Return")
        '
        'txtadultprice
        '
        Me.txtadultprice.Location = New System.Drawing.Point(185, 381)
        Me.txtadultprice.Name = "txtadultprice"
        Me.txtadultprice.Size = New System.Drawing.Size(100, 20)
        Me.txtadultprice.TabIndex = 224
        Me.ToolTip1.SetToolTip(Me.txtadultprice, "Price")
        '
        'txtchild
        '
        Me.txtchild.Location = New System.Drawing.Point(496, 291)
        Me.txtchild.Name = "txtchild"
        Me.txtchild.Size = New System.Drawing.Size(100, 20)
        Me.txtchild.TabIndex = 223
        Me.ToolTip1.SetToolTip(Me.txtchild, "Enter a quantity of Child")
        '
        'txtadult
        '
        Me.txtadult.Location = New System.Drawing.Point(185, 291)
        Me.txtadult.Name = "txtadult"
        Me.txtadult.Size = New System.Drawing.Size(100, 20)
        Me.txtadult.TabIndex = 222
        Me.ToolTip1.SetToolTip(Me.txtadult, "Enter a quantity of Adult")
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(188, 424)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(100, 20)
        Me.txttotalprice.TabIndex = 225
        Me.ToolTip1.SetToolTip(Me.txttotalprice, "Total Price")
        '
        'cbclass
        '
        Me.cbclass.FormattingEnabled = True
        Me.cbclass.Location = New System.Drawing.Point(185, 335)
        Me.cbclass.Name = "cbclass"
        Me.cbclass.Size = New System.Drawing.Size(102, 21)
        Me.cbclass.TabIndex = 221
        Me.ToolTip1.SetToolTip(Me.cbclass, "Select First class OR Second class")
        '
        'lblticketnumber
        '
        Me.lblticketnumber.AutoSize = True
        Me.lblticketnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblticketnumber.ForeColor = System.Drawing.Color.White
        Me.lblticketnumber.Location = New System.Drawing.Point(49, 80)
        Me.lblticketnumber.Name = "lblticketnumber"
        Me.lblticketnumber.Size = New System.Drawing.Size(130, 16)
        Me.lblticketnumber.TabIndex = 217
        Me.lblticketnumber.Text = "TICKET NUMBER"
        Me.ToolTip1.SetToolTip(Me.lblticketnumber, "Ticket Number")
        '
        'lblwesternup
        '
        Me.lblwesternup.AutoSize = True
        Me.lblwesternup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblwesternup.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwesternup.ForeColor = System.Drawing.Color.Yellow
        Me.lblwesternup.Location = New System.Drawing.Point(100, 6)
        Me.lblwesternup.Name = "lblwesternup"
        Me.lblwesternup.Size = New System.Drawing.Size(476, 36)
        Me.lblwesternup.TabIndex = 216
        Me.lblwesternup.Text = "WELCOME TO WESTERN RAILWAY"
        Me.ToolTip1.SetToolTip(Me.lblwesternup, "Welcome to Western up")
        '
        'txtticketnum
        '
        Me.txtticketnum.Location = New System.Drawing.Point(185, 79)
        Me.txtticketnum.Name = "txtticketnum"
        Me.txtticketnum.Size = New System.Drawing.Size(175, 20)
        Me.txtticketnum.TabIndex = 214
        Me.ToolTip1.SetToolTip(Me.txtticketnum, "Ticket NUmber")
        '
        'lbldistance
        '
        Me.lbldistance.AutoSize = True
        Me.lbldistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldistance.ForeColor = System.Drawing.Color.White
        Me.lbldistance.Location = New System.Drawing.Point(49, 253)
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
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(52, 207)
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
        Me.lblfrom.ForeColor = System.Drawing.Color.White
        Me.lblfrom.Location = New System.Drawing.Point(50, 120)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(51, 16)
        Me.lblfrom.TabIndex = 206
        Me.lblfrom.Text = "FROM"
        Me.ToolTip1.SetToolTip(Me.lblfrom, "From")
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduration.ForeColor = System.Drawing.Color.White
        Me.lblduration.Location = New System.Drawing.Point(370, 249)
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
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(374, 206)
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
        Me.lblto.ForeColor = System.Drawing.Color.White
        Me.lblto.Location = New System.Drawing.Point(372, 123)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(29, 16)
        Me.lblto.TabIndex = 199
        Me.lblto.Text = "TO"
        Me.ToolTip1.SetToolTip(Me.lblto, "To")
        '
        'cbdestination
        '
        Me.cbdestination.DropDownHeight = 150
        Me.cbdestination.DropDownWidth = 100
        Me.cbdestination.FormattingEnabled = True
        Me.cbdestination.IntegralHeight = False
        Me.cbdestination.Location = New System.Drawing.Point(421, 118)
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
        Me.cbsource.Location = New System.Drawing.Point(185, 118)
        Me.cbsource.Name = "cbsource"
        Me.cbsource.Size = New System.Drawing.Size(175, 21)
        Me.cbsource.TabIndex = 184
        Me.ToolTip1.SetToolTip(Me.cbsource, "From")
        '
        'txttime
        '
        Me.txttime.Enabled = False
        Me.txttime.Location = New System.Drawing.Point(496, 206)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 20)
        Me.txttime.TabIndex = 166
        Me.ToolTip1.SetToolTip(Me.txttime, "Time")
        '
        'cbroutes
        '
        Me.cbroutes.DropDownHeight = 150
        Me.cbroutes.FormattingEnabled = True
        Me.cbroutes.IntegralHeight = False
        Me.cbroutes.Location = New System.Drawing.Point(420, 159)
        Me.cbroutes.Name = "cbroutes"
        Me.cbroutes.Size = New System.Drawing.Size(175, 21)
        Me.cbroutes.TabIndex = 187
        Me.ToolTip1.SetToolTip(Me.cbroutes, "Routes")
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(495, 248)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(100, 20)
        Me.txtduration.TabIndex = 175
        Me.ToolTip1.SetToolTip(Me.txtduration, "Duration")
        '
        'txtdistance
        '
        Me.txtdistance.Location = New System.Drawing.Point(185, 248)
        Me.txtdistance.Name = "txtdistance"
        Me.txtdistance.Size = New System.Drawing.Size(100, 20)
        Me.txtdistance.TabIndex = 174
        Me.ToolTip1.SetToolTip(Me.txtdistance, "Distance")
        '
        'txtdate
        '
        Me.txtdate.Enabled = False
        Me.txtdate.Location = New System.Drawing.Point(185, 206)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 20)
        Me.txtdate.TabIndex = 167
        Me.ToolTip1.SetToolTip(Me.txtdate, "Date")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdprint)
        Me.Panel2.Controls.Add(Me.cmdback)
        Me.Panel2.Controls.Add(Me.cmdcancel)
        Me.Panel2.Controls.Add(Me.cmdsearch)
        Me.Panel2.Controls.Add(Me.cmdnew)
        Me.Panel2.Controls.Add(Me.cmdticket)
        Me.Panel2.Location = New System.Drawing.Point(3, 464)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 119)
        Me.Panel2.TabIndex = 214
        '
        'cmdprint
        '
        Me.cmdprint.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(188, 56)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(102, 42)
        Me.cmdprint.TabIndex = 236
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(344, 59)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(102, 42)
        Me.cmdback.TabIndex = 70
        Me.cmdback.Text = "BACK"
        Me.ToolTip1.SetToolTip(Me.cmdback, "Back to the Main Menu")
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(494, 59)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(102, 42)
        Me.cmdcancel.TabIndex = 65
        Me.cmdcancel.Text = "&CANCEL"
        Me.ToolTip1.SetToolTip(Me.cmdcancel, "Exit")
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(496, 3)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(102, 42)
        Me.cmdsearch.TabIndex = 62
        Me.cmdsearch.Text = "&SEARCH"
        Me.ToolTip1.SetToolTip(Me.cmdsearch, "Search a Ticket")
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmdnew
        '
        Me.cmdnew.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(344, 3)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(102, 42)
        Me.cmdnew.TabIndex = 61
        Me.cmdnew.Text = "&NEW"
        Me.ToolTip1.SetToolTip(Me.cmdnew, "Create a new Ticket")
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'cmdticket
        '
        Me.cmdticket.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdticket.Location = New System.Drawing.Point(188, 3)
        Me.cmdticket.Name = "cmdticket"
        Me.cmdticket.Size = New System.Drawing.Size(102, 42)
        Me.cmdticket.TabIndex = 60
        Me.cmdticket.Text = "&TICKET"
        Me.ToolTip1.SetToolTip(Me.cmdticket, "Save the Ticket")
        Me.cmdticket.UseVisualStyleBackColor = True
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
        'frmWestern_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 586)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmWestern_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Western Ticket"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbdestination As System.Windows.Forms.ComboBox
    Friend WithEvents cbsource As System.Windows.Forms.ComboBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents cbroutes As System.Windows.Forms.ComboBox
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents txtdistance As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbldistance As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbltotalprice As System.Windows.Forms.Label
    Friend WithEvents chkreturn As System.Windows.Forms.CheckBox
    Friend WithEvents lblchild As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents lbladult As System.Windows.Forms.Label
    Friend WithEvents temp As System.Windows.Forms.TextBox
    Friend WithEvents txtadultprice As System.Windows.Forms.TextBox
    Friend WithEvents txtchild As System.Windows.Forms.TextBox
    Friend WithEvents txtadult As System.Windows.Forms.TextBox
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents cbclass As System.Windows.Forms.ComboBox
    Friend WithEvents lblticketnumber As System.Windows.Forms.Label
    Friend WithEvents lblwesternup As System.Windows.Forms.Label
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
