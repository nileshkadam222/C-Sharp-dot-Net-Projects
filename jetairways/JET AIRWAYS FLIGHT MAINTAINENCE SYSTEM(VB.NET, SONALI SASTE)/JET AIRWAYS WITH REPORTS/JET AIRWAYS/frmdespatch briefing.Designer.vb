<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdispatchbriefing
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
        Me.cboflightdate = New System.Windows.Forms.ComboBox
        Me.cboflightno = New System.Windows.Forms.ComboBox
        Me.txtaircrafttype = New System.Windows.Forms.TextBox
        Me.txtbayno = New System.Windows.Forms.TextBox
        Me.txtengintype = New System.Windows.Forms.TextBox
        Me.txtregno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtrecomendedfuel = New System.Windows.Forms.TextBox
        Me.txtextra = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtsta11 = New System.Windows.Forms.TextBox
        Me.txtsta1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboto1 = New System.Windows.Forms.ComboBox
        Me.cbofrom1 = New System.Windows.Forms.ComboBox
        Me.txtstd11 = New System.Windows.Forms.TextBox
        Me.txtstd1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtsta22 = New System.Windows.Forms.TextBox
        Me.txtsta2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboto2 = New System.Windows.Forms.ComboBox
        Me.cbofrom2 = New System.Windows.Forms.ComboBox
        Me.txtstd22 = New System.Windows.Forms.TextBox
        Me.txtstd2 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtsta33 = New System.Windows.Forms.TextBox
        Me.txtsta3 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboto3 = New System.Windows.Forms.ComboBox
        Me.cbofrom3 = New System.Windows.Forms.ComboBox
        Me.txtstd33 = New System.Windows.Forms.TextBox
        Me.txtstd3 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtmanagerno = New System.Windows.Forms.TextBox
        Me.txtalternatedestination = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtairhostessname = New System.Windows.Forms.TextBox
        Me.txtadditionalcrew = New System.Windows.Forms.TextBox
        Me.txtfirstofficername = New System.Windows.Forms.TextBox
        Me.txtnameofcaptain = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.btnback = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboflightdate)
        Me.GroupBox1.Controls.Add(Me.cboflightno)
        Me.GroupBox1.Controls.Add(Me.txtaircrafttype)
        Me.GroupBox1.Controls.Add(Me.txtbayno)
        Me.GroupBox1.Controls.Add(Me.txtengintype)
        Me.GroupBox1.Controls.Add(Me.txtregno)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 116)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flight data"
        '
        'cboflightdate
        '
        Me.cboflightdate.FormattingEnabled = True
        Me.cboflightdate.Location = New System.Drawing.Point(102, 30)
        Me.cboflightdate.Margin = New System.Windows.Forms.Padding(2)
        Me.cboflightdate.Name = "cboflightdate"
        Me.cboflightdate.Size = New System.Drawing.Size(98, 21)
        Me.cboflightdate.TabIndex = 15
        '
        'cboflightno
        '
        Me.cboflightno.FormattingEnabled = True
        Me.cboflightno.Location = New System.Drawing.Point(102, 83)
        Me.cboflightno.Name = "cboflightno"
        Me.cboflightno.Size = New System.Drawing.Size(117, 21)
        Me.cboflightno.TabIndex = 14
        '
        'txtaircrafttype
        '
        Me.txtaircrafttype.Location = New System.Drawing.Point(602, 26)
        Me.txtaircrafttype.Name = "txtaircrafttype"
        Me.txtaircrafttype.Size = New System.Drawing.Size(117, 20)
        Me.txtaircrafttype.TabIndex = 10
        '
        'txtbayno
        '
        Me.txtbayno.Location = New System.Drawing.Point(336, 71)
        Me.txtbayno.Name = "txtbayno"
        Me.txtbayno.Size = New System.Drawing.Size(117, 20)
        Me.txtbayno.TabIndex = 9
        '
        'txtengintype
        '
        Me.txtengintype.Location = New System.Drawing.Point(602, 80)
        Me.txtengintype.Name = "txtengintype"
        Me.txtengintype.Size = New System.Drawing.Size(117, 20)
        Me.txtengintype.TabIndex = 13
        '
        'txtregno
        '
        Me.txtregno.Location = New System.Drawing.Point(336, 23)
        Me.txtregno.Name = "txtregno"
        Me.txtregno.Size = New System.Drawing.Size(117, 20)
        Me.txtregno.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Engin Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(512, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Aircraft Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bay No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reg No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Flight No. :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flight Date :"
        '
        'txtrecomendedfuel
        '
        Me.txtrecomendedfuel.Location = New System.Drawing.Point(135, 24)
        Me.txtrecomendedfuel.Name = "txtrecomendedfuel"
        Me.txtrecomendedfuel.Size = New System.Drawing.Size(195, 20)
        Me.txtrecomendedfuel.TabIndex = 11
        '
        'txtextra
        '
        Me.txtextra.Location = New System.Drawing.Point(135, 51)
        Me.txtextra.Name = "txtextra"
        Me.txtextra.Size = New System.Drawing.Size(195, 20)
        Me.txtextra.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtsta11)
        Me.GroupBox2.Controls.Add(Me.txtsta1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboto1)
        Me.GroupBox2.Controls.Add(Me.cbofrom1)
        Me.GroupBox2.Controls.Add(Me.txtstd11)
        Me.GroupBox2.Controls.Add(Me.txtstd1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 120)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sector 1 "
        '
        'txtsta11
        '
        Me.txtsta11.Location = New System.Drawing.Point(135, 87)
        Me.txtsta11.Name = "txtsta11"
        Me.txtsta11.Size = New System.Drawing.Size(65, 20)
        Me.txtsta11.TabIndex = 8
        '
        'txtsta1
        '
        Me.txtsta1.Location = New System.Drawing.Point(56, 87)
        Me.txtsta1.Name = "txtsta1"
        Me.txtsta1.Size = New System.Drawing.Size(65, 20)
        Me.txtsta1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "STA :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "STD :"
        '
        'cboto1
        '
        Me.cboto1.FormattingEnabled = True
        Me.cboto1.Items.AddRange(New Object() {"AGR", "USA", "PUNE", "AUS", "BLR", "DEL", "IDR"})
        Me.cboto1.Location = New System.Drawing.Point(135, 23)
        Me.cboto1.Name = "cboto1"
        Me.cboto1.Size = New System.Drawing.Size(65, 21)
        Me.cboto1.TabIndex = 4
        '
        'cbofrom1
        '
        Me.cbofrom1.FormattingEnabled = True
        Me.cbofrom1.Items.AddRange(New Object() {"BOM", "BOM", "BOM", "BOM", "BOM"})
        Me.cbofrom1.Location = New System.Drawing.Point(56, 23)
        Me.cbofrom1.Name = "cbofrom1"
        Me.cbofrom1.Size = New System.Drawing.Size(65, 21)
        Me.cbofrom1.TabIndex = 3
        '
        'txtstd11
        '
        Me.txtstd11.Location = New System.Drawing.Point(135, 57)
        Me.txtstd11.Name = "txtstd11"
        Me.txtstd11.Size = New System.Drawing.Size(65, 20)
        Me.txtstd11.TabIndex = 2
        '
        'txtstd1
        '
        Me.txtstd1.Location = New System.Drawing.Point(56, 57)
        Me.txtstd1.Name = "txtstd1"
        Me.txtstd1.Size = New System.Drawing.Size(65, 20)
        Me.txtstd1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sector :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtsta22)
        Me.GroupBox3.Controls.Add(Me.txtsta2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cboto2)
        Me.GroupBox3.Controls.Add(Me.cbofrom2)
        Me.GroupBox3.Controls.Add(Me.txtstd22)
        Me.GroupBox3.Controls.Add(Me.txtstd2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(254, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 120)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sector 2 "
        '
        'txtsta22
        '
        Me.txtsta22.Location = New System.Drawing.Point(135, 96)
        Me.txtsta22.Name = "txtsta22"
        Me.txtsta22.Size = New System.Drawing.Size(65, 20)
        Me.txtsta22.TabIndex = 8
        '
        'txtsta2
        '
        Me.txtsta2.Location = New System.Drawing.Point(64, 94)
        Me.txtsta2.Name = "txtsta2"
        Me.txtsta2.Size = New System.Drawing.Size(65, 20)
        Me.txtsta2.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "STA :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "STD :"
        '
        'cboto2
        '
        Me.cboto2.FormattingEnabled = True
        Me.cboto2.Items.AddRange(New Object() {"AGR", "USA", "PUNE", "AUS", "BLR", "DEL", "IDR"})
        Me.cboto2.Location = New System.Drawing.Point(135, 15)
        Me.cboto2.Name = "cboto2"
        Me.cboto2.Size = New System.Drawing.Size(65, 21)
        Me.cboto2.TabIndex = 4
        '
        'cbofrom2
        '
        Me.cbofrom2.FormattingEnabled = True
        Me.cbofrom2.Items.AddRange(New Object() {"BOM", "BOM", "BOM", "BOM", "BOM"})
        Me.cbofrom2.Location = New System.Drawing.Point(64, 15)
        Me.cbofrom2.Name = "cbofrom2"
        Me.cbofrom2.Size = New System.Drawing.Size(65, 21)
        Me.cbofrom2.TabIndex = 3
        '
        'txtstd22
        '
        Me.txtstd22.Location = New System.Drawing.Point(135, 54)
        Me.txtstd22.Name = "txtstd22"
        Me.txtstd22.Size = New System.Drawing.Size(65, 20)
        Me.txtstd22.TabIndex = 2
        '
        'txtstd2
        '
        Me.txtstd2.Location = New System.Drawing.Point(64, 54)
        Me.txtstd2.Name = "txtstd2"
        Me.txtstd2.Size = New System.Drawing.Size(65, 20)
        Me.txtstd2.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sector :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtsta33)
        Me.GroupBox4.Controls.Add(Me.txtsta3)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.cboto3)
        Me.GroupBox4.Controls.Add(Me.cbofrom3)
        Me.GroupBox4.Controls.Add(Me.txtstd33)
        Me.GroupBox4.Controls.Add(Me.txtstd3)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(536, 198)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(247, 120)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sector 3 "
        '
        'txtsta33
        '
        Me.txtsta33.Location = New System.Drawing.Point(135, 96)
        Me.txtsta33.Name = "txtsta33"
        Me.txtsta33.Size = New System.Drawing.Size(65, 20)
        Me.txtsta33.TabIndex = 8
        '
        'txtsta3
        '
        Me.txtsta3.Location = New System.Drawing.Point(64, 94)
        Me.txtsta3.Name = "txtsta3"
        Me.txtsta3.Size = New System.Drawing.Size(65, 20)
        Me.txtsta3.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "STA :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "STD :"
        '
        'cboto3
        '
        Me.cboto3.FormattingEnabled = True
        Me.cboto3.Items.AddRange(New Object() {"AGR", "USA", "PUNE", "AUS", "BLR", "DEL", "IDR"})
        Me.cboto3.Location = New System.Drawing.Point(135, 26)
        Me.cboto3.Name = "cboto3"
        Me.cboto3.Size = New System.Drawing.Size(65, 21)
        Me.cboto3.TabIndex = 4
        '
        'cbofrom3
        '
        Me.cbofrom3.FormattingEnabled = True
        Me.cbofrom3.Items.AddRange(New Object() {"BOM", "BOM", "BOM", "BOM", "BOM"})
        Me.cbofrom3.Location = New System.Drawing.Point(64, 26)
        Me.cbofrom3.Name = "cbofrom3"
        Me.cbofrom3.Size = New System.Drawing.Size(65, 21)
        Me.cbofrom3.TabIndex = 3
        '
        'txtstd33
        '
        Me.txtstd33.Location = New System.Drawing.Point(135, 64)
        Me.txtstd33.Name = "txtstd33"
        Me.txtstd33.Size = New System.Drawing.Size(65, 20)
        Me.txtstd33.TabIndex = 2
        '
        'txtstd3
        '
        Me.txtstd3.Location = New System.Drawing.Point(64, 64)
        Me.txtstd3.Name = "txtstd3"
        Me.txtstd3.Size = New System.Drawing.Size(65, 20)
        Me.txtstd3.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Sector :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtrecomendedfuel)
        Me.GroupBox5.Controls.Add(Me.txtextra)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 324)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(349, 80)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fuel Data "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Captain Extra :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Recomended Fuel :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtmanagerno)
        Me.GroupBox6.Controls.Add(Me.txtalternatedestination)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(394, 324)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(398, 80)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Alternet Route"
        '
        'txtmanagerno
        '
        Me.txtmanagerno.Location = New System.Drawing.Point(133, 55)
        Me.txtmanagerno.Name = "txtmanagerno"
        Me.txtmanagerno.Size = New System.Drawing.Size(195, 20)
        Me.txtmanagerno.TabIndex = 13
        '
        'txtalternatedestination
        '
        Me.txtalternatedestination.Location = New System.Drawing.Point(133, 27)
        Me.txtalternatedestination.Name = "txtalternatedestination"
        Me.txtalternatedestination.Size = New System.Drawing.Size(195, 20)
        Me.txtalternatedestination.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Manager Number :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Alternate Destination :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtairhostessname)
        Me.GroupBox7.Controls.Add(Me.txtadditionalcrew)
        Me.GroupBox7.Controls.Add(Me.txtfirstofficername)
        Me.GroupBox7.Controls.Add(Me.txtnameofcaptain)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(12, 410)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(442, 134)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Crew Data "
        '
        'txtairhostessname
        '
        Me.txtairhostessname.Location = New System.Drawing.Point(135, 87)
        Me.txtairhostessname.Name = "txtairhostessname"
        Me.txtairhostessname.Size = New System.Drawing.Size(264, 20)
        Me.txtairhostessname.TabIndex = 7
        '
        'txtadditionalcrew
        '
        Me.txtadditionalcrew.Location = New System.Drawing.Point(135, 60)
        Me.txtadditionalcrew.Name = "txtadditionalcrew"
        Me.txtadditionalcrew.Size = New System.Drawing.Size(264, 20)
        Me.txtadditionalcrew.TabIndex = 6
        '
        'txtfirstofficername
        '
        Me.txtfirstofficername.Location = New System.Drawing.Point(135, 35)
        Me.txtfirstofficername.Name = "txtfirstofficername"
        Me.txtfirstofficername.Size = New System.Drawing.Size(264, 20)
        Me.txtfirstofficername.TabIndex = 5
        '
        'txtnameofcaptain
        '
        Me.txtnameofcaptain.Location = New System.Drawing.Point(135, 14)
        Me.txtnameofcaptain.Name = "txtnameofcaptain"
        Me.txtnameofcaptain.Size = New System.Drawing.Size(264, 20)
        Me.txtnameofcaptain.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(24, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(109, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Airhostess Name :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(30, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Additional Crew :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(19, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "First Officer Name :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(38, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Captain Name : "
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnback)
        Me.GroupBox8.Controls.Add(Me.btnexit)
        Me.GroupBox8.Controls.Add(Me.btnprint)
        Me.GroupBox8.Controls.Add(Me.btnsave)
        Me.GroupBox8.Controls.Add(Me.btnadd)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(485, 410)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(262, 127)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(95, 47)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 44)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "&Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(176, 68)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 50)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(9, 71)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 50)
        Me.btnprint.TabIndex = 3
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(176, 14)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 46)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(9, 14)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 51)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "&Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JET_AIRWAYS.My.Resources.Resources.Jet_Airways_Banner_1_3
        Me.PictureBox1.Location = New System.Drawing.Point(-1146, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3026, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmdispatchbriefing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 578)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmdispatchbriefing"
        Me.Text = "Dispatchbriefing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtaircrafttype As System.Windows.Forms.TextBox
    Friend WithEvents txtbayno As System.Windows.Forms.TextBox
    Friend WithEvents txtengintype As System.Windows.Forms.TextBox
    Friend WithEvents txtregno As System.Windows.Forms.TextBox
    Friend WithEvents txtrecomendedfuel As System.Windows.Forms.TextBox
    Friend WithEvents txtextra As System.Windows.Forms.TextBox
    Friend WithEvents cboflightno As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboto1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbofrom1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtstd11 As System.Windows.Forms.TextBox
    Friend WithEvents txtstd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsta1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtsta11 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsta22 As System.Windows.Forms.TextBox
    Friend WithEvents txtsta2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboto2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbofrom2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtstd22 As System.Windows.Forms.TextBox
    Friend WithEvents txtstd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsta33 As System.Windows.Forms.TextBox
    Friend WithEvents txtsta3 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboto3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbofrom3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtstd33 As System.Windows.Forms.TextBox
    Friend WithEvents txtstd3 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtmanagerno As System.Windows.Forms.TextBox
    Friend WithEvents txtalternatedestination As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtairhostessname As System.Windows.Forms.TextBox
    Friend WithEvents txtadditionalcrew As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstofficername As System.Windows.Forms.TextBox
    Friend WithEvents txtnameofcaptain As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cboflightdate As System.Windows.Forms.ComboBox
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
