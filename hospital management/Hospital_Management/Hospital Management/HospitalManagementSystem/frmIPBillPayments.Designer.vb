<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIPBillPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIPBillPayments))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboCustName = New System.Windows.Forms.ComboBox
        Me.cboBillNo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBillDate = New System.Windows.Forms.TextBox
        Me.txtBillAmt = New System.Windows.Forms.TextBox
        Me.txtBillTerms = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtBillItems = New System.Windows.Forms.TextBox
        Me.txtNetValue = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.DGV1 = New System.Windows.Forms.DataGridView
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
        Me.txtPayingAmt = New System.Windows.Forms.TextBox
        Me.txtCustomerAdv = New System.Windows.Forms.TextBox
        Me.txtBillStatus = New System.Windows.Forms.TextBox
        Me.txtBalAmt = New System.Windows.Forms.TextBox
        Me.txtBalAdv = New System.Windows.Forms.TextBox
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboBank = New System.Windows.Forms.ComboBox
        Me.dtpDDDate = New System.Windows.Forms.DateTimePicker
        Me.txtDDNo = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.optOthers = New System.Windows.Forms.RadioButton
        Me.optCheque = New System.Windows.Forms.RadioButton
        Me.optDD = New System.Windows.Forms.RadioButton
        Me.optCash = New System.Windows.Forms.RadioButton
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(560, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IN PATIENT BILL PAYMENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(175, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Patient Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(463, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Select Bill Number :"
        '
        'cboCustName
        '
        Me.cboCustName.FormattingEnabled = True
        Me.cboCustName.Location = New System.Drawing.Point(315, 140)
        Me.cboCustName.Name = "cboCustName"
        Me.cboCustName.Size = New System.Drawing.Size(140, 23)
        Me.cboCustName.TabIndex = 0
        '
        'cboBillNo
        '
        Me.cboBillNo.FormattingEnabled = True
        Me.cboBillNo.Location = New System.Drawing.Point(586, 140)
        Me.cboBillNo.Name = "cboBillNo"
        Me.cboBillNo.Size = New System.Drawing.Size(140, 23)
        Me.cboBillNo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(175, 202)
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
        Me.Label5.Location = New System.Drawing.Point(175, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Bill Amt :"
        '
        'txtBillDate
        '
        Me.txtBillDate.Location = New System.Drawing.Point(315, 196)
        Me.txtBillDate.Name = "txtBillDate"
        Me.txtBillDate.Size = New System.Drawing.Size(140, 22)
        Me.txtBillDate.TabIndex = 2
        '
        'txtBillAmt
        '
        Me.txtBillAmt.Location = New System.Drawing.Point(315, 238)
        Me.txtBillAmt.Name = "txtBillAmt"
        Me.txtBillAmt.Size = New System.Drawing.Size(140, 22)
        Me.txtBillAmt.TabIndex = 4
        '
        'txtBillTerms
        '
        Me.txtBillTerms.Location = New System.Drawing.Point(586, 191)
        Me.txtBillTerms.Name = "txtBillTerms"
        Me.txtBillTerms.Size = New System.Drawing.Size(140, 22)
        Me.txtBillTerms.TabIndex = 3
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(586, 235)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(140, 22)
        Me.txtDiscount.TabIndex = 5
        '
        'txtBillItems
        '
        Me.txtBillItems.Location = New System.Drawing.Point(819, 191)
        Me.txtBillItems.Name = "txtBillItems"
        Me.txtBillItems.Size = New System.Drawing.Size(116, 22)
        Me.txtBillItems.TabIndex = 4
        '
        'txtNetValue
        '
        Me.txtNetValue.Location = New System.Drawing.Point(819, 234)
        Me.txtNetValue.Name = "txtNetValue"
        Me.txtNetValue.Size = New System.Drawing.Size(116, 22)
        Me.txtNetValue.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(485, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Bill Terms :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(485, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Discount :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(741, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Bill Items :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(741, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Net Value :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(483, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "BILL PAYMENT DETAILS"
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(179, 301)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(756, 145)
        Me.DGV1.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(282, 461)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Total Amount Paid :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(587, 462)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Balance :"
        '
        'txtPaidAmt
        '
        Me.txtPaidAmt.Location = New System.Drawing.Point(408, 458)
        Me.txtPaidAmt.Name = "txtPaidAmt"
        Me.txtPaidAmt.Size = New System.Drawing.Size(140, 22)
        Me.txtPaidAmt.TabIndex = 7
        '
        'txtBal
        '
        Me.txtBal.Location = New System.Drawing.Point(651, 458)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(139, 22)
        Me.txtBal.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(193, 511)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Paying Amount :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(193, 551)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 15)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Advance:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(193, 589)
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
        Me.Label17.Location = New System.Drawing.Point(464, 512)
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
        Me.Label18.Location = New System.Drawing.Point(457, 554)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 15)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Balance Amount:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(464, 590)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 15)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Balance Adv :"
        '
        'txtPayingAmt
        '
        Me.txtPayingAmt.Location = New System.Drawing.Point(315, 507)
        Me.txtPayingAmt.Name = "txtPayingAmt"
        Me.txtPayingAmt.Size = New System.Drawing.Size(140, 22)
        Me.txtPayingAmt.TabIndex = 9
        '
        'txtCustomerAdv
        '
        Me.txtCustomerAdv.Location = New System.Drawing.Point(315, 549)
        Me.txtCustomerAdv.Name = "txtCustomerAdv"
        Me.txtCustomerAdv.Size = New System.Drawing.Size(140, 22)
        Me.txtCustomerAdv.TabIndex = 11
        '
        'txtBillStatus
        '
        Me.txtBillStatus.Location = New System.Drawing.Point(315, 587)
        Me.txtBillStatus.Name = "txtBillStatus"
        Me.txtBillStatus.Size = New System.Drawing.Size(140, 22)
        Me.txtBillStatus.TabIndex = 13
        '
        'txtBalAmt
        '
        Me.txtBalAmt.Location = New System.Drawing.Point(564, 550)
        Me.txtBalAmt.Name = "txtBalAmt"
        Me.txtBalAmt.Size = New System.Drawing.Size(138, 22)
        Me.txtBalAmt.TabIndex = 12
        '
        'txtBalAdv
        '
        Me.txtBalAdv.Location = New System.Drawing.Point(564, 589)
        Me.txtBalAdv.Name = "txtBalAdv"
        Me.txtBalAdv.Size = New System.Drawing.Size(140, 22)
        Me.txtBalAdv.TabIndex = 14
        '
        'dtpPayDate
        '
        Me.dtpPayDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPayDate.Location = New System.Drawing.Point(564, 507)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(138, 22)
        Me.dtpPayDate.TabIndex = 10
        Me.dtpPayDate.Value = New Date(2010, 8, 9, 0, 0, 0, 0)
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(317, 634)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(138, 23)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "&SAVE"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(564, 634)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(138, 23)
        Me.cmdClose.TabIndex = 23
        Me.cmdClose.Text = "&CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboBank)
        Me.GroupBox2.Controls.Add(Me.dtpDDDate)
        Me.GroupBox2.Controls.Add(Me.txtDDNo)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.optOthers)
        Me.GroupBox2.Controls.Add(Me.optCheque)
        Me.GroupBox2.Controls.Add(Me.optDD)
        Me.GroupBox2.Controls.Add(Me.optCash)
        Me.GroupBox2.Location = New System.Drawing.Point(724, 490)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 167)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'cboBank
        '
        Me.cboBank.FormattingEnabled = True
        Me.cboBank.Location = New System.Drawing.Point(84, 135)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(187, 23)
        Me.cboBank.TabIndex = 21
        '
        'dtpDDDate
        '
        Me.dtpDDDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDDDate.Location = New System.Drawing.Point(84, 100)
        Me.dtpDDDate.Name = "dtpDDDate"
        Me.dtpDDDate.Size = New System.Drawing.Size(188, 22)
        Me.dtpDDDate.TabIndex = 20
        Me.dtpDDDate.Value = New Date(2010, 8, 9, 0, 0, 0, 0)
        '
        'txtDDNo
        '
        Me.txtDDNo.Location = New System.Drawing.Point(84, 61)
        Me.txtDDNo.Name = "txtDDNo"
        Me.txtDDNo.Size = New System.Drawing.Size(187, 22)
        Me.txtDDNo.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(7, 138)
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
        Me.Label21.Location = New System.Drawing.Point(7, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 15)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "DATE :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(7, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 15)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "DD No :"
        '
        'optOthers
        '
        Me.optOthers.AutoSize = True
        Me.optOthers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOthers.ForeColor = System.Drawing.Color.Navy
        Me.optOthers.Location = New System.Drawing.Point(208, 18)
        Me.optOthers.Name = "optOthers"
        Me.optOthers.Size = New System.Drawing.Size(64, 19)
        Me.optOthers.TabIndex = 18
        Me.optOthers.TabStop = True
        Me.optOthers.Text = "Others"
        Me.optOthers.UseVisualStyleBackColor = True
        '
        'optCheque
        '
        Me.optCheque.AutoSize = True
        Me.optCheque.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCheque.ForeColor = System.Drawing.Color.Navy
        Me.optCheque.Location = New System.Drawing.Point(128, 18)
        Me.optCheque.Name = "optCheque"
        Me.optCheque.Size = New System.Drawing.Size(66, 19)
        Me.optCheque.TabIndex = 17
        Me.optCheque.TabStop = True
        Me.optCheque.Text = "Cheque"
        Me.optCheque.UseVisualStyleBackColor = True
        '
        'optDD
        '
        Me.optDD.AutoSize = True
        Me.optDD.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDD.ForeColor = System.Drawing.Color.Navy
        Me.optDD.Location = New System.Drawing.Point(84, 18)
        Me.optDD.Name = "optDD"
        Me.optDD.Size = New System.Drawing.Size(43, 19)
        Me.optDD.TabIndex = 16
        Me.optDD.TabStop = True
        Me.optDD.Text = "DD"
        Me.optDD.UseVisualStyleBackColor = True
        '
        'optCash
        '
        Me.optCash.AutoSize = True
        Me.optCash.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCash.ForeColor = System.Drawing.Color.Navy
        Me.optCash.Location = New System.Drawing.Point(3, 18)
        Me.optCash.Name = "optCash"
        Me.optCash.Size = New System.Drawing.Size(60, 19)
        Me.optCash.TabIndex = 15
        Me.optCash.TabStop = True
        Me.optCash.Text = "CASH"
        Me.optCash.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(551, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(239, 26)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1006, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'frmIPBillPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1163, 746)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.dtpPayDate)
        Me.Controls.Add(Me.txtBalAdv)
        Me.Controls.Add(Me.txtBalAmt)
        Me.Controls.Add(Me.txtBillStatus)
        Me.Controls.Add(Me.txtCustomerAdv)
        Me.Controls.Add(Me.txtPayingAmt)
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
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNetValue)
        Me.Controls.Add(Me.txtBillItems)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtBillTerms)
        Me.Controls.Add(Me.txtBillAmt)
        Me.Controls.Add(Me.txtBillDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboBillNo)
        Me.Controls.Add(Me.cboCustName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "frmIPBillPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In Patient Bill Payments"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCustName As System.Windows.Forms.ComboBox
    Friend WithEvents cboBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBillAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBillTerms As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtBillItems As System.Windows.Forms.TextBox
    Friend WithEvents txtNetValue As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
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
    Friend WithEvents txtPayingAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerAdv As System.Windows.Forms.TextBox
    Friend WithEvents txtBillStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtBalAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBalAdv As System.Windows.Forms.TextBox
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents optOthers As System.Windows.Forms.RadioButton
    Friend WithEvents optCheque As System.Windows.Forms.RadioButton
    Friend WithEvents optDD As System.Windows.Forms.RadioButton
    Friend WithEvents optCash As System.Windows.Forms.RadioButton
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDDNo As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
