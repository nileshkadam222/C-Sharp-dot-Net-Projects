<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOPBillPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOPBillPayments))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboPCode = New System.Windows.Forms.ComboBox
        Me.cboBillNo = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBillDate = New System.Windows.Forms.TextBox
        Me.txtBillAmt = New System.Windows.Forms.TextBox
        Me.txtBillTerms = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtBillItems = New System.Windows.Forms.TextBox
        Me.txtNetValue = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.MFG = New System.Windows.Forms.DataGridView
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPaidAmt = New System.Windows.Forms.TextBox
        Me.txtBal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtBalAmt = New System.Windows.Forms.TextBox
        Me.txtPayingAmt = New System.Windows.Forms.TextBox
        Me.txtCustomerAdv = New System.Windows.Forms.TextBox
        Me.txtBillStatus = New System.Windows.Forms.TextBox
        Me.txtBalAdv = New System.Windows.Forms.TextBox
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbBank = New System.Windows.Forms.ComboBox
        Me.dtpDDDate = New System.Windows.Forms.DateTimePicker
        Me.txtDDNo = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.optOTHERS = New System.Windows.Forms.RadioButton
        Me.optCHEQUE = New System.Windows.Forms.RadioButton
        Me.optDD = New System.Windows.Forms.RadioButton
        Me.optCASH = New System.Windows.Forms.RadioButton
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.MFG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(537, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OUT PATIENT BILL PAYMENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(216, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Patient Code :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(697, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Select Bill Number :"
        '
        'cboPCode
        '
        Me.cboPCode.FormattingEnabled = True
        Me.cboPCode.Location = New System.Drawing.Point(342, 138)
        Me.cboPCode.Name = "cboPCode"
        Me.cboPCode.Size = New System.Drawing.Size(156, 21)
        Me.cboPCode.TabIndex = 3
        '
        'cboBillNo
        '
        Me.cboBillNo.FormattingEnabled = True
        Me.cboBillNo.Location = New System.Drawing.Point(832, 139)
        Me.cboBillNo.Name = "cboBillNo"
        Me.cboBillNo.Size = New System.Drawing.Size(156, 21)
        Me.cboBillNo.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(216, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "BILL INFORMATION :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(230, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bill Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(230, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Bill Amt :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(506, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Discount :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(506, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Bill Terms :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(754, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Bill Items :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(754, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Net Value :"
        '
        'txtBillDate
        '
        Me.txtBillDate.Location = New System.Drawing.Point(342, 228)
        Me.txtBillDate.Name = "txtBillDate"
        Me.txtBillDate.Size = New System.Drawing.Size(156, 20)
        Me.txtBillDate.TabIndex = 12
        '
        'txtBillAmt
        '
        Me.txtBillAmt.Location = New System.Drawing.Point(342, 260)
        Me.txtBillAmt.Name = "txtBillAmt"
        Me.txtBillAmt.Size = New System.Drawing.Size(156, 20)
        Me.txtBillAmt.TabIndex = 13
        '
        'txtBillTerms
        '
        Me.txtBillTerms.Location = New System.Drawing.Point(591, 225)
        Me.txtBillTerms.Name = "txtBillTerms"
        Me.txtBillTerms.Size = New System.Drawing.Size(156, 20)
        Me.txtBillTerms.TabIndex = 14
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(591, 257)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(156, 20)
        Me.txtDiscount.TabIndex = 15
        '
        'txtBillItems
        '
        Me.txtBillItems.Location = New System.Drawing.Point(832, 223)
        Me.txtBillItems.Name = "txtBillItems"
        Me.txtBillItems.Size = New System.Drawing.Size(156, 20)
        Me.txtBillItems.TabIndex = 16
        '
        'txtNetValue
        '
        Me.txtNetValue.Location = New System.Drawing.Point(832, 255)
        Me.txtNetValue.Name = "txtNetValue"
        Me.txtNetValue.Size = New System.Drawing.Size(156, 20)
        Me.txtNetValue.TabIndex = 17
        Me.txtNetValue.Text = "7"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(230, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "BILL PAYMENT DETAILS :"
        '
        'MFG
        '
        Me.MFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MFG.Location = New System.Drawing.Point(233, 312)
        Me.MFG.Name = "MFG"
        Me.MFG.ReadOnly = True
        Me.MFG.Size = New System.Drawing.Size(755, 150)
        Me.MFG.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(350, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Total Amount Paid :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(613, 471)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Balance :"
        '
        'txtPaidAmt
        '
        Me.txtPaidAmt.Location = New System.Drawing.Point(469, 468)
        Me.txtPaidAmt.Name = "txtPaidAmt"
        Me.txtPaidAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtPaidAmt.TabIndex = 22
        '
        'txtBal
        '
        Me.txtBal.Location = New System.Drawing.Point(674, 468)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(100, 20)
        Me.txtBal.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(230, 508)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Paying Amount :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(230, 542)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 15)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Patient Adv :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(230, 576)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 15)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Bill Status :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(505, 505)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 15)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Payment Date :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(505, 539)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 15)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Balance Amt :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(505, 573)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 15)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Balance Adv :"
        '
        'txtBalAmt
        '
        Me.txtBalAmt.Location = New System.Drawing.Point(591, 536)
        Me.txtBalAmt.Name = "txtBalAmt"
        Me.txtBalAmt.Size = New System.Drawing.Size(156, 20)
        Me.txtBalAmt.TabIndex = 30
        '
        'txtPayingAmt
        '
        Me.txtPayingAmt.Location = New System.Drawing.Point(342, 503)
        Me.txtPayingAmt.Name = "txtPayingAmt"
        Me.txtPayingAmt.Size = New System.Drawing.Size(156, 20)
        Me.txtPayingAmt.TabIndex = 31
        '
        'txtCustomerAdv
        '
        Me.txtCustomerAdv.Location = New System.Drawing.Point(342, 537)
        Me.txtCustomerAdv.Name = "txtCustomerAdv"
        Me.txtCustomerAdv.Size = New System.Drawing.Size(156, 20)
        Me.txtCustomerAdv.TabIndex = 32
        '
        'txtBillStatus
        '
        Me.txtBillStatus.Location = New System.Drawing.Point(342, 571)
        Me.txtBillStatus.Name = "txtBillStatus"
        Me.txtBillStatus.Size = New System.Drawing.Size(156, 20)
        Me.txtBillStatus.TabIndex = 33
        '
        'txtBalAdv
        '
        Me.txtBalAdv.Location = New System.Drawing.Point(591, 570)
        Me.txtBalAdv.Name = "txtBalAdv"
        Me.txtBalAdv.Size = New System.Drawing.Size(156, 20)
        Me.txtBalAdv.TabIndex = 34
        '
        'dtpPayDate
        '
        Me.dtpPayDate.Location = New System.Drawing.Point(591, 502)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(156, 20)
        Me.dtpPayDate.TabIndex = 35
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Navy
        Me.cmdSave.Location = New System.Drawing.Point(342, 609)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(138, 23)
        Me.cmdSave.TabIndex = 36
        Me.cmdSave.Text = "&SAVE"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Navy
        Me.cmdClose.Location = New System.Drawing.Point(591, 609)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(138, 23)
        Me.cmdClose.TabIndex = 37
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbBank)
        Me.GroupBox1.Controls.Add(Me.dtpDDDate)
        Me.GroupBox1.Controls.Add(Me.txtDDNo)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.optOTHERS)
        Me.GroupBox1.Controls.Add(Me.optCHEQUE)
        Me.GroupBox1.Controls.Add(Me.optDD)
        Me.GroupBox1.Controls.Add(Me.optCASH)
        Me.GroupBox1.Location = New System.Drawing.Point(757, 494)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 138)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Info"
        '
        'cmbBank
        '
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Location = New System.Drawing.Point(96, 108)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(172, 21)
        Me.cmbBank.TabIndex = 9
        '
        'dtpDDDate
        '
        Me.dtpDDDate.Location = New System.Drawing.Point(96, 82)
        Me.dtpDDDate.Name = "dtpDDDate"
        Me.dtpDDDate.Size = New System.Drawing.Size(172, 20)
        Me.dtpDDDate.TabIndex = 8
        '
        'txtDDNo
        '
        Me.txtDDNo.Location = New System.Drawing.Point(96, 53)
        Me.txtDDNo.Name = "txtDDNo"
        Me.txtDDNo.Size = New System.Drawing.Size(172, 20)
        Me.txtDDNo.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(12, 111)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 15)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "BANK :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(12, 86)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 15)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "DATE :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(12, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 15)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "DD No :"
        '
        'optOTHERS
        '
        Me.optOTHERS.AutoSize = True
        Me.optOTHERS.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOTHERS.ForeColor = System.Drawing.Color.Navy
        Me.optOTHERS.Location = New System.Drawing.Point(198, 24)
        Me.optOTHERS.Name = "optOTHERS"
        Me.optOTHERS.Size = New System.Drawing.Size(76, 19)
        Me.optOTHERS.TabIndex = 3
        Me.optOTHERS.TabStop = True
        Me.optOTHERS.Text = "OTHERS"
        Me.optOTHERS.UseVisualStyleBackColor = True
        '
        'optCHEQUE
        '
        Me.optCHEQUE.AutoSize = True
        Me.optCHEQUE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCHEQUE.ForeColor = System.Drawing.Color.Navy
        Me.optCHEQUE.Location = New System.Drawing.Point(122, 24)
        Me.optCHEQUE.Name = "optCHEQUE"
        Me.optCHEQUE.Size = New System.Drawing.Size(75, 19)
        Me.optCHEQUE.TabIndex = 2
        Me.optCHEQUE.TabStop = True
        Me.optCHEQUE.Text = "CHEQUE"
        Me.optCHEQUE.UseVisualStyleBackColor = True
        '
        'optDD
        '
        Me.optDD.AutoSize = True
        Me.optDD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDD.ForeColor = System.Drawing.Color.Navy
        Me.optDD.Location = New System.Drawing.Point(75, 24)
        Me.optDD.Name = "optDD"
        Me.optDD.Size = New System.Drawing.Size(43, 19)
        Me.optDD.TabIndex = 1
        Me.optDD.TabStop = True
        Me.optDD.Text = "DD"
        Me.optDD.UseVisualStyleBackColor = True
        '
        'optCASH
        '
        Me.optCASH.AutoSize = True
        Me.optCASH.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCASH.ForeColor = System.Drawing.Color.Navy
        Me.optCASH.Location = New System.Drawing.Point(15, 24)
        Me.optCASH.Name = "optCASH"
        Me.optCASH.Size = New System.Drawing.Size(60, 19)
        Me.optCASH.TabIndex = 0
        Me.optCASH.TabStop = True
        Me.optCASH.Text = "CASH"
        Me.optCASH.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(536, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(239, 26)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(996, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'frmOPBillPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.dtpPayDate)
        Me.Controls.Add(Me.txtBalAdv)
        Me.Controls.Add(Me.txtBillStatus)
        Me.Controls.Add(Me.txtCustomerAdv)
        Me.Controls.Add(Me.txtPayingAmt)
        Me.Controls.Add(Me.txtBalAmt)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBal)
        Me.Controls.Add(Me.txtPaidAmt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.MFG)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNetValue)
        Me.Controls.Add(Me.txtBillItems)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtBillTerms)
        Me.Controls.Add(Me.txtBillAmt)
        Me.Controls.Add(Me.txtBillDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboBillNo)
        Me.Controls.Add(Me.cboPCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOPBillPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Out Patient Bill Payments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MFG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPCode As System.Windows.Forms.ComboBox
    Friend WithEvents cboBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBillDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBillAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBillTerms As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtBillItems As System.Windows.Forms.TextBox
    Friend WithEvents txtNetValue As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MFG As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPaidAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtBalAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtPayingAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerAdv As System.Windows.Forms.TextBox
    Friend WithEvents txtBillStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtBalAdv As System.Windows.Forms.TextBox
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optOTHERS As System.Windows.Forms.RadioButton
    Friend WithEvents optCHEQUE As System.Windows.Forms.RadioButton
    Friend WithEvents optDD As System.Windows.Forms.RadioButton
    Friend WithEvents optCASH As System.Windows.Forms.RadioButton
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDDNo As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
