<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbill
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtingredients = New System.Windows.Forms.TextBox
        Me.txtsrno = New System.Windows.Forms.TextBox
        Me.txtquantity = New System.Windows.Forms.TextBox
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtgrossamt = New System.Windows.Forms.TextBox
        Me.txttotalamt = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lstsrno = New System.Windows.Forms.ListBox
        Me.lstparticular = New System.Windows.Forms.ListBox
        Me.lstqty = New System.Windows.Forms.ListBox
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.lstrate = New System.Windows.Forms.ListBox
        Me.lstamt = New System.Windows.Forms.ListBox
        Me.txtadvance = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cboorderno = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnclear = New System.Windows.Forms.Button
        Me.txtordno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcustid = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.27586!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.72414!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtingredients, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsrno, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtquantity, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtrate, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtamount, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtgrossamt, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txttotalamt, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lstsrno, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lstparticular, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lstqty, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbalance, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lstrate, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lstamt, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtadvance, 4, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 145)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(405, 284)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ingredients"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(174, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(240, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Rate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(307, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sr no."
        '
        'txtingredients
        '
        Me.txtingredients.Location = New System.Drawing.Point(51, 31)
        Me.txtingredients.Name = "txtingredients"
        Me.txtingredients.Size = New System.Drawing.Size(117, 20)
        Me.txtingredients.TabIndex = 6
        '
        'txtsrno
        '
        Me.txtsrno.Location = New System.Drawing.Point(3, 31)
        Me.txtsrno.Name = "txtsrno"
        Me.txtsrno.Size = New System.Drawing.Size(35, 20)
        Me.txtsrno.TabIndex = 5
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(174, 31)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(60, 20)
        Me.txtquantity.TabIndex = 7
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(240, 31)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(59, 20)
        Me.txtrate.TabIndex = 8
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(307, 31)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(76, 20)
        Me.txtamount.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(240, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 30)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Gross" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total:"
        '
        'txtgrossamt
        '
        Me.txtgrossamt.Location = New System.Drawing.Point(307, 247)
        Me.txtgrossamt.Name = "txtgrossamt"
        Me.txtgrossamt.Size = New System.Drawing.Size(76, 20)
        Me.txtgrossamt.TabIndex = 18
        '
        'txttotalamt
        '
        Me.txttotalamt.Location = New System.Drawing.Point(307, 217)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.Size = New System.Drawing.Size(76, 20)
        Me.txttotalamt.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(240, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 30)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Total Amt:-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(240, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 30)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Balance:-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(240, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 30)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Advance:-"
        '
        'lstsrno
        '
        Me.lstsrno.FormattingEnabled = True
        Me.lstsrno.Location = New System.Drawing.Point(3, 61)
        Me.lstsrno.Name = "lstsrno"
        Me.lstsrno.Size = New System.Drawing.Size(35, 82)
        Me.lstsrno.TabIndex = 10
        '
        'lstparticular
        '
        Me.lstparticular.FormattingEnabled = True
        Me.lstparticular.Location = New System.Drawing.Point(51, 61)
        Me.lstparticular.Name = "lstparticular"
        Me.lstparticular.Size = New System.Drawing.Size(116, 82)
        Me.lstparticular.TabIndex = 11
        '
        'lstqty
        '
        Me.lstqty.FormattingEnabled = True
        Me.lstqty.Location = New System.Drawing.Point(174, 61)
        Me.lstqty.Name = "lstqty"
        Me.lstqty.Size = New System.Drawing.Size(60, 82)
        Me.lstqty.TabIndex = 12
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(307, 185)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(76, 20)
        Me.txtbalance.TabIndex = 16
        '
        'lstrate
        '
        Me.lstrate.FormattingEnabled = True
        Me.lstrate.Location = New System.Drawing.Point(240, 61)
        Me.lstrate.Name = "lstrate"
        Me.lstrate.Size = New System.Drawing.Size(59, 82)
        Me.lstrate.TabIndex = 13
        '
        'lstamt
        '
        Me.lstamt.FormattingEnabled = True
        Me.lstamt.Location = New System.Drawing.Point(307, 61)
        Me.lstamt.Name = "lstamt"
        Me.lstamt.Size = New System.Drawing.Size(84, 82)
        Me.lstamt.TabIndex = 14
        '
        'txtadvance
        '
        Me.txtadvance.Location = New System.Drawing.Point(307, 155)
        Me.txtadvance.Name = "txtadvance"
        Me.txtadvance.Size = New System.Drawing.Size(76, 20)
        Me.txtadvance.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pizza Hut"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cash Memo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Order no:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(219, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Name:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(278, 119)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(160, 20)
        Me.txtname.TabIndex = 4
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Transparent
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(421, 154)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(83, 27)
        Me.btnadd.TabIndex = 19
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(423, 199)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(82, 26)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Transparent
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(421, 240)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(83, 28)
        Me.btnprint.TabIndex = 22
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(422, 330)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(83, 28)
        Me.btncancel.TabIndex = 24
        Me.btncancel.Text = "Back"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(421, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'cboorderno
        '
        Me.cboorderno.FormattingEnabled = True
        Me.cboorderno.Location = New System.Drawing.Point(421, 79)
        Me.cboorderno.Name = "cboorderno"
        Me.cboorderno.Size = New System.Drawing.Size(98, 21)
        Me.cboorderno.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 62)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(421, 283)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(83, 27)
        Me.btnclear.TabIndex = 23
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'txtordno
        '
        Me.txtordno.Location = New System.Drawing.Point(421, 56)
        Me.txtordno.Name = "txtordno"
        Me.txtordno.Size = New System.Drawing.Size(97, 20)
        Me.txtordno.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cust id:"
        '
        'txtcustid
        '
        Me.txtcustid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustid.Location = New System.Drawing.Point(72, 118)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(130, 20)
        Me.txtcustid.TabIndex = 27
        '
        'frmbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(531, 441)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtordno)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.cboorderno)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmbill"
        Me.Text = "frmbill"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboorderno As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtingredients As System.Windows.Forms.TextBox
    Friend WithEvents txtsrno As System.Windows.Forms.TextBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtgrossamt As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtadvance As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txttotalamt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lstsrno As System.Windows.Forms.ListBox
    Friend WithEvents lstparticular As System.Windows.Forms.ListBox
    Friend WithEvents lstqty As System.Windows.Forms.ListBox
    Friend WithEvents lstrate As System.Windows.Forms.ListBox
    Friend WithEvents lstamt As System.Windows.Forms.ListBox
    Friend WithEvents txtordno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
End Class
