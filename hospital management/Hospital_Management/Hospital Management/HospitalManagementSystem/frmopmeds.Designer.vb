<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmopmeds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmopmeds))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCrdt = New System.Windows.Forms.ComboBox
        Me.cboPCode = New System.Windows.Forms.ComboBox
        Me.txtbill = New System.Windows.Forms.TextBox
        Me.dtpbilldt = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPName = New System.Windows.Forms.TextBox
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.txtTDate = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotAmt = New System.Windows.Forms.TextBox
        Me.dtpIssu = New System.Windows.Forms.DateTimePicker
        Me.txtdis = New System.Windows.Forms.TextBox
        Me.cbomedtype = New System.Windows.Forms.ComboBox
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.txtrpu = New System.Windows.Forms.TextBox
        Me.txtmedname = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.cboMedID = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Command2 = New System.Windows.Forms.Button
        Me.Command4 = New System.Windows.Forms.Button
        Me.MFG = New System.Windows.Forms.DataGridView
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtgrndtot = New System.Windows.Forms.TextBox
        Me.txtdisgvn = New System.Windows.Forms.TextBox
        Me.txtpayable = New System.Windows.Forms.TextBox
        Me.cmdBill = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.MFG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(368, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OUT PATIENTS MEDICINE ISSUE "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(35, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(316, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bill No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(481, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bill Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(664, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pay Terms"
        '
        'cboCrdt
        '
        Me.cboCrdt.FormattingEnabled = True
        Me.cboCrdt.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.cboCrdt.Location = New System.Drawing.Point(746, 173)
        Me.cboCrdt.Name = "cboCrdt"
        Me.cboCrdt.Size = New System.Drawing.Size(121, 21)
        Me.cboCrdt.TabIndex = 5
        '
        'cboPCode
        '
        Me.cboPCode.FormattingEnabled = True
        Me.cboPCode.Location = New System.Drawing.Point(151, 175)
        Me.cboPCode.Name = "cboPCode"
        Me.cboPCode.Size = New System.Drawing.Size(158, 21)
        Me.cboPCode.TabIndex = 6
        '
        'txtbill
        '
        Me.txtbill.Location = New System.Drawing.Point(411, 172)
        Me.txtbill.Name = "txtbill"
        Me.txtbill.Size = New System.Drawing.Size(64, 20)
        Me.txtbill.TabIndex = 7
        '
        'dtpbilldt
        '
        Me.dtpbilldt.Location = New System.Drawing.Point(537, 172)
        Me.dtpbilldt.Name = "dtpbilldt"
        Me.dtpbilldt.Size = New System.Drawing.Size(110, 20)
        Me.dtpbilldt.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(35, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Name of Patient"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(582, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Treatment Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(314, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Doctor Name"
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(151, 226)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(158, 20)
        Me.txtPName.TabIndex = 12
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(411, 228)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Size = New System.Drawing.Size(158, 20)
        Me.txtDName.TabIndex = 13
        '
        'txtTDate
        '
        Me.txtTDate.Location = New System.Drawing.Point(709, 228)
        Me.txtTDate.Name = "txtTDate"
        Me.txtTDate.Size = New System.Drawing.Size(158, 20)
        Me.txtTDate.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotAmt)
        Me.GroupBox1.Controls.Add(Me.dtpIssu)
        Me.GroupBox1.Controls.Add(Me.txtdis)
        Me.GroupBox1.Controls.Add(Me.cbomedtype)
        Me.GroupBox1.Controls.Add(Me.txtamt)
        Me.GroupBox1.Controls.Add(Me.txtrpu)
        Me.GroupBox1.Controls.Add(Me.txtmedname)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.cboMedID)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 122)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicine Details"
        '
        'txtTotAmt
        '
        Me.txtTotAmt.Location = New System.Drawing.Point(729, 76)
        Me.txtTotAmt.Name = "txtTotAmt"
        Me.txtTotAmt.Size = New System.Drawing.Size(116, 20)
        Me.txtTotAmt.TabIndex = 17
        '
        'dtpIssu
        '
        Me.dtpIssu.Location = New System.Drawing.Point(729, 37)
        Me.dtpIssu.Name = "dtpIssu"
        Me.dtpIssu.Size = New System.Drawing.Size(113, 20)
        Me.dtpIssu.TabIndex = 16
        '
        'txtdis
        '
        Me.txtdis.Location = New System.Drawing.Point(564, 78)
        Me.txtdis.Name = "txtdis"
        Me.txtdis.Size = New System.Drawing.Size(85, 20)
        Me.txtdis.TabIndex = 15
        '
        'cbomedtype
        '
        Me.cbomedtype.FormattingEnabled = True
        Me.cbomedtype.Location = New System.Drawing.Point(564, 36)
        Me.cbomedtype.Name = "cbomedtype"
        Me.cbomedtype.Size = New System.Drawing.Size(77, 21)
        Me.cbomedtype.TabIndex = 14
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(386, 76)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(87, 20)
        Me.txtamt.TabIndex = 13
        '
        'txtrpu
        '
        Me.txtrpu.Location = New System.Drawing.Point(260, 79)
        Me.txtrpu.Name = "txtrpu"
        Me.txtrpu.Size = New System.Drawing.Size(64, 20)
        Me.txtrpu.TabIndex = 12
        '
        'txtmedname
        '
        Me.txtmedname.Location = New System.Drawing.Point(260, 36)
        Me.txtmedname.Name = "txtmedname"
        Me.txtmedname.Size = New System.Drawing.Size(213, 20)
        Me.txtmedname.TabIndex = 11
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(82, 76)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(65, 20)
        Me.txtQty.TabIndex = 10
        '
        'cboMedID
        '
        Me.cboMedID.FormattingEnabled = True
        Me.cboMedID.Location = New System.Drawing.Point(82, 33)
        Me.cboMedID.Name = "cboMedID"
        Me.cboMedID.Size = New System.Drawing.Size(65, 21)
        Me.cboMedID.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(475, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 15)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Medicine Type"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(650, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 15)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Total Amount"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(476, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 15)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Discount Given"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(650, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Issue Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(330, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(164, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Rate Per Unit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(164, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Medicine Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(8, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(8, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Medicine ID"
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.Navy
        Me.cmdAdd.Location = New System.Drawing.Point(147, 417)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(138, 23)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "&ADD"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Command2
        '
        Me.Command2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.Color.Navy
        Me.Command2.Location = New System.Drawing.Point(317, 417)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(138, 23)
        Me.Command2.TabIndex = 17
        Me.Command2.Text = "&UPDATE"
        Me.Command2.UseVisualStyleBackColor = True
        '
        'Command4
        '
        Me.Command4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.Color.Navy
        Me.Command4.Location = New System.Drawing.Point(504, 417)
        Me.Command4.Name = "Command4"
        Me.Command4.Size = New System.Drawing.Size(138, 23)
        Me.Command4.TabIndex = 18
        Me.Command4.Text = "&CLEAR"
        Me.Command4.UseVisualStyleBackColor = True
        '
        'MFG
        '
        Me.MFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MFG.Location = New System.Drawing.Point(22, 446)
        Me.MFG.Name = "MFG"
        Me.MFG.Size = New System.Drawing.Size(861, 191)
        Me.MFG.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(40, 650)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 15)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Grand Total"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(284, 650)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 15)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Discount Given"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(582, 649)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 15)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Net Amount Payable"
        '
        'txtgrndtot
        '
        Me.txtgrndtot.Location = New System.Drawing.Point(109, 643)
        Me.txtgrndtot.Name = "txtgrndtot"
        Me.txtgrndtot.Size = New System.Drawing.Size(153, 20)
        Me.txtgrndtot.TabIndex = 23
        '
        'txtdisgvn
        '
        Me.txtdisgvn.Location = New System.Drawing.Point(384, 647)
        Me.txtdisgvn.Name = "txtdisgvn"
        Me.txtdisgvn.Size = New System.Drawing.Size(153, 20)
        Me.txtdisgvn.TabIndex = 24
        '
        'txtpayable
        '
        Me.txtpayable.Location = New System.Drawing.Point(730, 647)
        Me.txtpayable.Name = "txtpayable"
        Me.txtpayable.Size = New System.Drawing.Size(153, 20)
        Me.txtpayable.TabIndex = 25
        '
        'cmdBill
        '
        Me.cmdBill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBill.ForeColor = System.Drawing.Color.Navy
        Me.cmdBill.Location = New System.Drawing.Point(561, 688)
        Me.cmdBill.Name = "cmdBill"
        Me.cmdBill.Size = New System.Drawing.Size(138, 23)
        Me.cmdBill.TabIndex = 26
        Me.cmdBill.Text = "&BILL"
        Me.cmdBill.UseVisualStyleBackColor = True
        Me.cmdBill.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Navy
        Me.cmdExit.Location = New System.Drawing.Point(348, 688)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(138, 23)
        Me.cmdExit.TabIndex = 27
        Me.cmdExit.Text = "CLOSE"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(379, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(239, 26)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(846, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'frmopmeds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdBill)
        Me.Controls.Add(Me.txtpayable)
        Me.Controls.Add(Me.txtdisgvn)
        Me.Controls.Add(Me.txtgrndtot)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.MFG)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTDate)
        Me.Controls.Add(Me.txtDName)
        Me.Controls.Add(Me.txtPName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpbilldt)
        Me.Controls.Add(Me.txtbill)
        Me.Controls.Add(Me.cboPCode)
        Me.Controls.Add(Me.cboCrdt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmopmeds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Out Patient Medical bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MFG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCrdt As System.Windows.Forms.ComboBox
    Friend WithEvents cboPCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtbill As System.Windows.Forms.TextBox
    Friend WithEvents dtpbilldt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPName As System.Windows.Forms.TextBox
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents txtTDate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents txtrpu As System.Windows.Forms.TextBox
    Friend WithEvents txtmedname As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents cboMedID As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotAmt As System.Windows.Forms.TextBox
    Friend WithEvents dtpIssu As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdis As System.Windows.Forms.TextBox
    Friend WithEvents cbomedtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Command2 As System.Windows.Forms.Button
    Friend WithEvents Command4 As System.Windows.Forms.Button
    Friend WithEvents MFG As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtgrndtot As System.Windows.Forms.TextBox
    Friend WithEvents txtdisgvn As System.Windows.Forms.TextBox
    Friend WithEvents txtpayable As System.Windows.Forms.TextBox
    Friend WithEvents cmdBill As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
