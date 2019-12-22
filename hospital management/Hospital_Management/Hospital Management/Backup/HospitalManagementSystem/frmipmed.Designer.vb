<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmipmed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmipmed))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPName = New System.Windows.Forms.TextBox
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.txtTDate = New System.Windows.Forms.TextBox
        Me.txtAddDate = New System.Windows.Forms.TextBox
        Me.cboPCode = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtbill = New System.Windows.Forms.TextBox
        Me.cboCrdt = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdADD = New System.Windows.Forms.Button
        Me.dtpIssu = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txttotamt = New System.Windows.Forms.TextBox
        Me.txtdis = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.txtmedname = New System.Windows.Forms.TextBox
        Me.txtrpu = New System.Windows.Forms.TextBox
        Me.cboMedType = New System.Windows.Forms.ComboBox
        Me.cboMedID = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtgrndtot = New System.Windows.Forms.TextBox
        Me.txtdisgvn = New System.Windows.Forms.TextBox
        Me.txtpayable = New System.Windows.Forms.TextBox
        Me.cmdBill = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.dtpBilldt = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnview = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(397, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IN PATIENTS MEDICINE ISSUE "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(15, 187)
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
        Me.Label3.Location = New System.Drawing.Point(15, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name of Patient"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(15, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Doctor Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(15, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Admission"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(15, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Treatment Date"
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(127, 224)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.ReadOnly = True
        Me.txtPName.Size = New System.Drawing.Size(146, 20)
        Me.txtPName.TabIndex = 6
        Me.txtPName.TabStop = False
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(127, 263)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.ReadOnly = True
        Me.txtDName.Size = New System.Drawing.Size(146, 20)
        Me.txtDName.TabIndex = 7
        Me.txtDName.TabStop = False
        '
        'txtTDate
        '
        Me.txtTDate.Location = New System.Drawing.Point(127, 303)
        Me.txtTDate.Name = "txtTDate"
        Me.txtTDate.ReadOnly = True
        Me.txtTDate.Size = New System.Drawing.Size(146, 20)
        Me.txtTDate.TabIndex = 8
        Me.txtTDate.TabStop = False
        '
        'txtAddDate
        '
        Me.txtAddDate.Location = New System.Drawing.Point(127, 344)
        Me.txtAddDate.Name = "txtAddDate"
        Me.txtAddDate.ReadOnly = True
        Me.txtAddDate.Size = New System.Drawing.Size(146, 20)
        Me.txtAddDate.TabIndex = 9
        Me.txtAddDate.TabStop = False
        '
        'cboPCode
        '
        Me.cboPCode.FormattingEnabled = True
        Me.cboPCode.Location = New System.Drawing.Point(127, 185)
        Me.cboPCode.Name = "cboPCode"
        Me.cboPCode.Size = New System.Drawing.Size(146, 21)
        Me.cboPCode.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(297, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Bill No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(457, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Bill Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(688, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Pay Terms"
        '
        'txtbill
        '
        Me.txtbill.Location = New System.Drawing.Point(357, 184)
        Me.txtbill.Name = "txtbill"
        Me.txtbill.ReadOnly = True
        Me.txtbill.Size = New System.Drawing.Size(79, 20)
        Me.txtbill.TabIndex = 2
        Me.txtbill.TabStop = False
        '
        'cboCrdt
        '
        Me.cboCrdt.FormattingEnabled = True
        Me.cboCrdt.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.cboCrdt.Location = New System.Drawing.Point(757, 182)
        Me.cboCrdt.Name = "cboCrdt"
        Me.cboCrdt.Size = New System.Drawing.Size(141, 21)
        Me.cboCrdt.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdADD)
        Me.GroupBox1.Controls.Add(Me.dtpIssu)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txttotamt)
        Me.GroupBox1.Controls.Add(Me.txtdis)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.txtamt)
        Me.GroupBox1.Controls.Add(Me.txtmedname)
        Me.GroupBox1.Controls.Add(Me.txtrpu)
        Me.GroupBox1.Controls.Add(Me.cboMedType)
        Me.GroupBox1.Controls.Add(Me.cboMedID)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 174)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicine Details"
        '
        'cmdADD
        '
        Me.cmdADD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdADD.ForeColor = System.Drawing.Color.Navy
        Me.cmdADD.Location = New System.Drawing.Point(266, 131)
        Me.cmdADD.Name = "cmdADD"
        Me.cmdADD.Size = New System.Drawing.Size(136, 35)
        Me.cmdADD.TabIndex = 18
        Me.cmdADD.Text = "Add to the List"
        Me.cmdADD.UseVisualStyleBackColor = True
        '
        'dtpIssu
        '
        Me.dtpIssu.CustomFormat = "dd/MM/yyyy"
        Me.dtpIssu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssu.Location = New System.Drawing.Point(100, 65)
        Me.dtpIssu.Name = "dtpIssu"
        Me.dtpIssu.Size = New System.Drawing.Size(112, 20)
        Me.dtpIssu.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(445, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 15)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Total Amount"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(218, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 15)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Discount Given"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(248, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 15)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Quantity"
        '
        'txttotamt
        '
        Me.txttotamt.Location = New System.Drawing.Point(534, 97)
        Me.txttotamt.Name = "txttotamt"
        Me.txttotamt.ReadOnly = True
        Me.txttotamt.Size = New System.Drawing.Size(112, 20)
        Me.txttotamt.TabIndex = 14
        Me.txttotamt.TabStop = False
        '
        'txtdis
        '
        Me.txtdis.Location = New System.Drawing.Point(314, 98)
        Me.txtdis.Name = "txtdis"
        Me.txtdis.Size = New System.Drawing.Size(112, 20)
        Me.txtdis.TabIndex = 13
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(314, 63)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(112, 20)
        Me.txtqty.TabIndex = 10
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(100, 99)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.ReadOnly = True
        Me.txtamt.Size = New System.Drawing.Size(112, 20)
        Me.txtamt.TabIndex = 12
        Me.txtamt.TabStop = False
        '
        'txtmedname
        '
        Me.txtmedname.Location = New System.Drawing.Point(314, 27)
        Me.txtmedname.Name = "txtmedname"
        Me.txtmedname.ReadOnly = True
        Me.txtmedname.Size = New System.Drawing.Size(112, 20)
        Me.txtmedname.TabIndex = 7
        Me.txtmedname.TabStop = False
        '
        'txtrpu
        '
        Me.txtrpu.Location = New System.Drawing.Point(533, 63)
        Me.txtrpu.Name = "txtrpu"
        Me.txtrpu.Size = New System.Drawing.Size(112, 20)
        Me.txtrpu.TabIndex = 11
        '
        'cboMedType
        '
        Me.cboMedType.FormattingEnabled = True
        Me.cboMedType.Items.AddRange(New Object() {"OINTMENT", "SYRUP", "TABLET", "INJECTION", "CAPSULE"})
        Me.cboMedType.Location = New System.Drawing.Point(533, 27)
        Me.cboMedType.Name = "cboMedType"
        Me.cboMedType.Size = New System.Drawing.Size(112, 21)
        Me.cboMedType.TabIndex = 8
        '
        'cboMedID
        '
        Me.cboMedID.FormattingEnabled = True
        Me.cboMedID.Location = New System.Drawing.Point(100, 28)
        Me.cboMedID.Name = "cboMedID"
        Me.cboMedID.Size = New System.Drawing.Size(112, 21)
        Me.cboMedID.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(10, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(9, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Issue Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(213, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Medicine Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(445, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Rate Per Unit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(440, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Medicine Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(6, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Medicine ID"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(18, 398)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(948, 171)
        Me.DGV.TabIndex = 21
        Me.DGV.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(15, 647)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 15)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Grand Total"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(297, 648)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 15)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Discount Given"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(571, 651)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 15)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Net Amount Payable"
        '
        'txtgrndtot
        '
        Me.txtgrndtot.Location = New System.Drawing.Point(127, 643)
        Me.txtgrndtot.Name = "txtgrndtot"
        Me.txtgrndtot.Size = New System.Drawing.Size(146, 20)
        Me.txtgrndtot.TabIndex = 17
        '
        'txtdisgvn
        '
        Me.txtdisgvn.Location = New System.Drawing.Point(400, 649)
        Me.txtdisgvn.Name = "txtdisgvn"
        Me.txtdisgvn.Size = New System.Drawing.Size(146, 20)
        Me.txtdisgvn.TabIndex = 18
        '
        'txtpayable
        '
        Me.txtpayable.Location = New System.Drawing.Point(694, 647)
        Me.txtpayable.Name = "txtpayable"
        Me.txtpayable.ReadOnly = True
        Me.txtpayable.Size = New System.Drawing.Size(146, 20)
        Me.txtpayable.TabIndex = 19
        Me.txtpayable.TabStop = False
        '
        'cmdBill
        '
        Me.cmdBill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBill.ForeColor = System.Drawing.Color.Navy
        Me.cmdBill.Location = New System.Drawing.Point(300, 696)
        Me.cmdBill.Name = "cmdBill"
        Me.cmdBill.Size = New System.Drawing.Size(138, 23)
        Me.cmdBill.TabIndex = 20
        Me.cmdBill.Text = "&BILL"
        Me.cmdBill.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Navy
        Me.cmdClose.Location = New System.Drawing.Point(512, 696)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(138, 23)
        Me.cmdClose.TabIndex = 21
        Me.cmdClose.Text = "&CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dtpBilldt
        '
        Me.dtpBilldt.CustomFormat = "dd/MM/yyyy"
        Me.dtpBilldt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBilldt.Location = New System.Drawing.Point(523, 183)
        Me.dtpBilldt.Name = "dtpBilldt"
        Me.dtpBilldt.Size = New System.Drawing.Size(154, 20)
        Me.dtpBilldt.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(360, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(239, 26)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(836, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.Navy
        Me.btnview.Location = New System.Drawing.Point(400, 588)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(146, 36)
        Me.btnview.TabIndex = 16
        Me.btnview.Text = "View Medicine Details"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'frmipmed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dtpBilldt)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdBill)
        Me.Controls.Add(Me.txtpayable)
        Me.Controls.Add(Me.txtdisgvn)
        Me.Controls.Add(Me.txtgrndtot)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboCrdt)
        Me.Controls.Add(Me.txtbill)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboPCode)
        Me.Controls.Add(Me.txtAddDate)
        Me.Controls.Add(Me.txtTDate)
        Me.Controls.Add(Me.txtDName)
        Me.Controls.Add(Me.txtPName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmipmed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In Patient Medicine issue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPName As System.Windows.Forms.TextBox
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents txtTDate As System.Windows.Forms.TextBox
    Friend WithEvents txtAddDate As System.Windows.Forms.TextBox
    Friend WithEvents cboPCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbill As System.Windows.Forms.TextBox
    Friend WithEvents cboCrdt As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMedType As System.Windows.Forms.ComboBox
    Friend WithEvents cboMedID As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txttotamt As System.Windows.Forms.TextBox
    Friend WithEvents txtdis As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents txtmedname As System.Windows.Forms.TextBox
    Friend WithEvents txtrpu As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtgrndtot As System.Windows.Forms.TextBox
    Friend WithEvents txtdisgvn As System.Windows.Forms.TextBox
    Friend WithEvents txtpayable As System.Windows.Forms.TextBox
    Friend WithEvents cmdBill As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dtpIssu As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBilldt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents cmdADD As System.Windows.Forms.Button
End Class
