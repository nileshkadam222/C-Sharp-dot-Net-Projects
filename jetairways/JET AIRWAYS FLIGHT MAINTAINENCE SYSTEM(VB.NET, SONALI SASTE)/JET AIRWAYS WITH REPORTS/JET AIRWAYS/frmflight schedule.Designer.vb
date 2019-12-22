<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmflightshedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboto1 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cbofrom1 = New System.Windows.Forms.ComboBox
        Me.cboflightnumber = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtsta1 = New System.Windows.Forms.TextBox
        Me.txtsta2 = New System.Windows.Forms.TextBox
        Me.txtstd2 = New System.Windows.Forms.TextBox
        Me.txtstd1 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbodi = New System.Windows.Forms.ComboBox
        Me.cbodeptarr = New System.Windows.Forms.ComboBox
        Me.cboaircrafttype = New System.Windows.Forms.ComboBox
        Me.txtleg = New System.Windows.Forms.TextBox
        Me.cbobayno = New System.Windows.Forms.ComboBox
        Me.cboregno = New System.Windows.Forms.ComboBox
        Me.cboflighttype = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtfirstofficername = New System.Windows.Forms.TextBox
        Me.txtcaptainname = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtairhostessname = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnback = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnview = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 60)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(77, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboto1)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cbofrom1)
        Me.GroupBox2.Controls.Add(Me.cboflightnumber)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtsta1)
        Me.GroupBox2.Controls.Add(Me.txtsta2)
        Me.GroupBox2.Controls.Add(Me.txtstd2)
        Me.GroupBox2.Controls.Add(Me.txtstd1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbodi)
        Me.GroupBox2.Controls.Add(Me.cbodeptarr)
        Me.GroupBox2.Controls.Add(Me.cboaircrafttype)
        Me.GroupBox2.Controls.Add(Me.txtleg)
        Me.GroupBox2.Controls.Add(Me.cbobayno)
        Me.GroupBox2.Controls.Add(Me.cboregno)
        Me.GroupBox2.Controls.Add(Me.cboflighttype)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 224)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flight Data"
        '
        'cboto1
        '
        Me.cboto1.FormattingEnabled = True
        Me.cboto1.Items.AddRange(New Object() {"GOA", "USA", "CCU", "AGR", "PUNE", "AUS"})
        Me.cboto1.Location = New System.Drawing.Point(325, 184)
        Me.cboto1.Name = "cboto1"
        Me.cboto1.Size = New System.Drawing.Size(121, 21)
        Me.cboto1.TabIndex = 34
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 184)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 16)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Sector  "
        '
        'cbofrom1
        '
        Me.cbofrom1.FormattingEnabled = True
        Me.cbofrom1.Items.AddRange(New Object() {"BOM", "BOM", "BOM", "BOM"})
        Me.cbofrom1.Location = New System.Drawing.Point(129, 183)
        Me.cbofrom1.Name = "cbofrom1"
        Me.cbofrom1.Size = New System.Drawing.Size(121, 21)
        Me.cbofrom1.TabIndex = 32
        '
        'cboflightnumber
        '
        Me.cboflightnumber.FormattingEnabled = True
        Me.cboflightnumber.Location = New System.Drawing.Point(109, 40)
        Me.cboflightnumber.Name = "cboflightnumber"
        Me.cboflightnumber.Size = New System.Drawing.Size(107, 21)
        Me.cboflightnumber.TabIndex = 30
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(109, 90)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePicker2.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(276, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "To :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(81, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "From :"
        '
        'txtsta1
        '
        Me.txtsta1.Location = New System.Drawing.Point(686, 114)
        Me.txtsta1.Name = "txtsta1"
        Me.txtsta1.Size = New System.Drawing.Size(48, 20)
        Me.txtsta1.TabIndex = 24
        '
        'txtsta2
        '
        Me.txtsta2.Location = New System.Drawing.Point(740, 114)
        Me.txtsta2.Name = "txtsta2"
        Me.txtsta2.Size = New System.Drawing.Size(48, 20)
        Me.txtsta2.TabIndex = 23
        '
        'txtstd2
        '
        Me.txtstd2.Location = New System.Drawing.Point(740, 41)
        Me.txtstd2.Name = "txtstd2"
        Me.txtstd2.Size = New System.Drawing.Size(48, 20)
        Me.txtstd2.TabIndex = 22
        '
        'txtstd1
        '
        Me.txtstd1.Location = New System.Drawing.Point(686, 41)
        Me.txtstd1.Name = "txtstd1"
        Me.txtstd1.Size = New System.Drawing.Size(48, 20)
        Me.txtstd1.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(640, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "STA :"
        '
        'cbodi
        '
        Me.cbodi.FormattingEnabled = True
        Me.cbodi.Items.AddRange(New Object() {"Domestic", "International"})
        Me.cbodi.Location = New System.Drawing.Point(509, 139)
        Me.cbodi.Name = "cbodi"
        Me.cbodi.Size = New System.Drawing.Size(106, 21)
        Me.cbodi.TabIndex = 19
        Me.cbodi.Text = "Choose"
        '
        'cbodeptarr
        '
        Me.cbodeptarr.FormattingEnabled = True
        Me.cbodeptarr.Items.AddRange(New Object() {"Departure", "Arrival"})
        Me.cbodeptarr.Location = New System.Drawing.Point(513, 90)
        Me.cbodeptarr.Name = "cbodeptarr"
        Me.cbodeptarr.Size = New System.Drawing.Size(106, 21)
        Me.cbodeptarr.TabIndex = 18
        Me.cbodeptarr.Text = "Choose"
        '
        'cboaircrafttype
        '
        Me.cboaircrafttype.FormattingEnabled = True
        Me.cboaircrafttype.Items.AddRange(New Object() {"Airbus 330-200", "Boeing 757-200", "ATR 72-500", "Boeing 737-800", "Boeing 737-400", "Boeing 737-700"})
        Me.cboaircrafttype.Location = New System.Drawing.Point(513, 40)
        Me.cboaircrafttype.Name = "cboaircrafttype"
        Me.cboaircrafttype.Size = New System.Drawing.Size(106, 21)
        Me.cboaircrafttype.TabIndex = 17
        '
        'txtleg
        '
        Me.txtleg.Location = New System.Drawing.Point(292, 141)
        Me.txtleg.Name = "txtleg"
        Me.txtleg.Size = New System.Drawing.Size(101, 20)
        Me.txtleg.TabIndex = 16
        '
        'cbobayno
        '
        Me.cbobayno.FormattingEnabled = True
        Me.cbobayno.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbobayno.Location = New System.Drawing.Point(292, 96)
        Me.cbobayno.Name = "cbobayno"
        Me.cbobayno.Size = New System.Drawing.Size(101, 21)
        Me.cbobayno.TabIndex = 15
        '
        'cboregno
        '
        Me.cboregno.FormattingEnabled = True
        Me.cboregno.Items.AddRange(New Object() {"JBC", "JGT", "JEG", "SIJ"})
        Me.cboregno.Location = New System.Drawing.Point(292, 37)
        Me.cboregno.Name = "cboregno"
        Me.cboregno.Size = New System.Drawing.Size(101, 21)
        Me.cboregno.TabIndex = 14
        '
        'cboflighttype
        '
        Me.cboflighttype.FormattingEnabled = True
        Me.cboflighttype.Items.AddRange(New Object() {"Charter"})
        Me.cboflighttype.Location = New System.Drawing.Point(109, 141)
        Me.cboflighttype.Name = "cboflighttype"
        Me.cboflighttype.Size = New System.Drawing.Size(107, 21)
        Me.cboflighttype.TabIndex = 13
        Me.cboflighttype.Text = "Choose"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(640, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "STD :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(657, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "    "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(469, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "D/I :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Dept/Air :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Aircraft Type :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(237, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Leg :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Bay No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Reg No :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Flight Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Flight Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Flight Number :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtfirstofficername)
        Me.GroupBox3.Controls.Add(Me.txtcaptainname)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Crew Name"
        '
        'txtfirstofficername
        '
        Me.txtfirstofficername.Location = New System.Drawing.Point(119, 68)
        Me.txtfirstofficername.Name = "txtfirstofficername"
        Me.txtfirstofficername.Size = New System.Drawing.Size(114, 20)
        Me.txtfirstofficername.TabIndex = 7
        '
        'txtcaptainname
        '
        Me.txtcaptainname.Location = New System.Drawing.Point(119, 34)
        Me.txtcaptainname.Name = "txtcaptainname"
        Me.txtcaptainname.Size = New System.Drawing.Size(114, 20)
        Me.txtcaptainname.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "First Officer Name :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Captain Name :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtairhostessname)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(258, 370)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 90)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Airhostess Name "
        '
        'txtairhostessname
        '
        Me.txtairhostessname.Location = New System.Drawing.Point(59, 37)
        Me.txtairhostessname.Name = "txtairhostessname"
        Me.txtairhostessname.Size = New System.Drawing.Size(137, 20)
        Me.txtairhostessname.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Name :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnback)
        Me.GroupBox5.Controls.Add(Me.btnclear)
        Me.GroupBox5.Controls.Add(Me.btnexit)
        Me.GroupBox5.Controls.Add(Me.btnsearch)
        Me.GroupBox5.Controls.Add(Me.btndelete)
        Me.GroupBox5.Controls.Add(Me.btnupdate)
        Me.GroupBox5.Controls.Add(Me.btnview)
        Me.GroupBox5.Controls.Add(Me.btnsave)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(5, 466)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(803, 88)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(721, 35)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 40)
        Me.btnback.TabIndex = 8
        Me.btnback.Text = "&Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(522, 35)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 40)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(622, 35)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 40)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(429, 32)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 47)
        Me.btnsearch.TabIndex = 5
        Me.btnsearch.Text = "&Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(322, 32)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 47)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(208, 32)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 47)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(106, 32)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 47)
        Me.btnview.TabIndex = 2
        Me.btnview.Text = "&View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(10, 35)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 47)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.JET_AIRWAYS.My.Resources.Resources.jet1_1_1
        Me.PictureBox3.Location = New System.Drawing.Point(484, 370)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(274, 90)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.JET_AIRWAYS.My.Resources.Resources.Jet_Airways_Banner_1_2
        Me.PictureBox2.Location = New System.Drawing.Point(-145, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(953, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JET_AIRWAYS.My.Resources.Resources.Jet_Airways_Banner_1_
        Me.PictureBox1.Location = New System.Drawing.Point(-4260, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmflightshedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 578)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmflightshedule"
        Me.Text = "Flightshedule"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboflighttype As System.Windows.Forms.ComboBox
    Friend WithEvents cboregno As System.Windows.Forms.ComboBox
    Friend WithEvents txtleg As System.Windows.Forms.TextBox
    Friend WithEvents cbobayno As System.Windows.Forms.ComboBox
    Friend WithEvents cbodi As System.Windows.Forms.ComboBox
    Friend WithEvents cbodeptarr As System.Windows.Forms.ComboBox
    Friend WithEvents cboaircrafttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtsta1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsta2 As System.Windows.Forms.TextBox
    Friend WithEvents txtstd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtstd1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfirstofficername As System.Windows.Forms.TextBox
    Friend WithEvents txtcaptainname As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtairhostessname As System.Windows.Forms.TextBox
    Friend WithEvents cboflightnumber As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents cbofrom1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboto1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
