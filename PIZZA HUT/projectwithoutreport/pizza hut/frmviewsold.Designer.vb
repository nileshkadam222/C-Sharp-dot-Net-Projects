<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewsold
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
        Me.gbentercodeno = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbotransactiontype = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.gbsoldproduct = New System.Windows.Forms.GroupBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtproduct = New System.Windows.Forms.TextBox
        Me.cbosize = New System.Windows.Forms.ComboBox
        Me.txtunit = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.lblsize = New System.Windows.Forms.Label
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblunit = New System.Windows.Forms.Label
        Me.lblproduct = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtqtymaterials = New System.Windows.Forms.TextBox
        Me.lblremarks = New System.Windows.Forms.Label
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.cbocodeno = New System.Windows.Forms.ComboBox
        Me.txtpacking = New System.Windows.Forms.TextBox
        Me.txtcodeno = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnback = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnok = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnadditem = New System.Windows.Forms.Button
        Me.gbentercodeno.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbsoldproduct.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbentercodeno
        '
        Me.gbentercodeno.Controls.Add(Me.TextBox2)
        Me.gbentercodeno.Controls.Add(Me.TextBox1)
        Me.gbentercodeno.Controls.Add(Me.RadioButton2)
        Me.gbentercodeno.Controls.Add(Me.RadioButton1)
        Me.gbentercodeno.Controls.Add(Me.txtcode)
        Me.gbentercodeno.Controls.Add(Me.Label1)
        Me.gbentercodeno.Location = New System.Drawing.Point(1, 39)
        Me.gbentercodeno.Name = "gbentercodeno"
        Me.gbentercodeno.Size = New System.Drawing.Size(510, 87)
        Me.gbentercodeno.TabIndex = 0
        Me.gbentercodeno.TabStop = False
        Me.gbentercodeno.Text = "Enter Code. Number"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(395, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(92, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(278, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(92, 20)
        Me.TextBox1.TabIndex = 4
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(382, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(114, 20)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "D.R. Number"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(263, 42)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(113, 20)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "O.S. Number"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtcode
        '
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(145, 44)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(110, 22)
        Me.txtcode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Code Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbotransactiontype)
        Me.GroupBox2.Location = New System.Drawing.Point(517, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(139, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction Type"
        '
        'cbotransactiontype
        '
        Me.cbotransactiontype.FormattingEnabled = True
        Me.cbotransactiontype.Location = New System.Drawing.Point(11, 26)
        Me.cbotransactiontype.Name = "cbotransactiontype"
        Me.cbotransactiontype.Size = New System.Drawing.Size(118, 21)
        Me.cbotransactiontype.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Location = New System.Drawing.Point(662, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(147, 57)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(139, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'gbsoldproduct
        '
        Me.gbsoldproduct.Controls.Add(Me.txtamount)
        Me.gbsoldproduct.Controls.Add(Me.txtprice)
        Me.gbsoldproduct.Controls.Add(Me.Label5)
        Me.gbsoldproduct.Controls.Add(Me.Label4)
        Me.gbsoldproduct.Controls.Add(Me.txtproduct)
        Me.gbsoldproduct.Controls.Add(Me.cbosize)
        Me.gbsoldproduct.Controls.Add(Me.txtunit)
        Me.gbsoldproduct.Controls.Add(Me.txtqty)
        Me.gbsoldproduct.Controls.Add(Me.lblsize)
        Me.gbsoldproduct.Controls.Add(Me.lblqty)
        Me.gbsoldproduct.Controls.Add(Me.lblunit)
        Me.gbsoldproduct.Controls.Add(Me.lblproduct)
        Me.gbsoldproduct.Location = New System.Drawing.Point(8, 132)
        Me.gbsoldproduct.Name = "gbsoldproduct"
        Me.gbsoldproduct.Size = New System.Drawing.Size(670, 89)
        Me.gbsoldproduct.TabIndex = 3
        Me.gbsoldproduct.TabStop = False
        Me.gbsoldproduct.Text = "Sold Product Entry"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(550, 53)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(67, 20)
        Me.txtamount.TabIndex = 13
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(442, 53)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(67, 20)
        Me.txtprice.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(551, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(450, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Price"
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(16, 47)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Size = New System.Drawing.Size(58, 20)
        Me.txtproduct.TabIndex = 9
        '
        'cbosize
        '
        Me.cbosize.FormattingEnabled = True
        Me.cbosize.Location = New System.Drawing.Point(217, 47)
        Me.cbosize.Name = "cbosize"
        Me.cbosize.Size = New System.Drawing.Size(74, 21)
        Me.cbosize.TabIndex = 7
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(105, 47)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(71, 20)
        Me.txtunit.TabIndex = 6
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(347, 47)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(71, 20)
        Me.txtqty.TabIndex = 5
        '
        'lblsize
        '
        Me.lblsize.AutoSize = True
        Me.lblsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsize.Location = New System.Drawing.Point(232, 26)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(38, 16)
        Me.lblsize.TabIndex = 3
        Me.lblsize.Text = "Size"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(359, 26)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(31, 16)
        Me.lblqty.TabIndex = 2
        Me.lblqty.Text = "Qty"
        '
        'lblunit
        '
        Me.lblunit.AutoSize = True
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(116, 26)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(35, 16)
        Me.lblunit.TabIndex = 1
        Me.lblunit.Text = "Unit"
        '
        'lblproduct
        '
        Me.lblproduct.AutoSize = True
        Me.lblproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproduct.Location = New System.Drawing.Point(13, 26)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(61, 16)
        Me.lblproduct.TabIndex = 0
        Me.lblproduct.Text = "Product"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 227)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(758, 124)
        Me.DataGridView1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Packing Materials:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Qty:"
        '
        'txtqtymaterials
        '
        Me.txtqtymaterials.Location = New System.Drawing.Point(302, 379)
        Me.txtqtymaterials.Name = "txtqtymaterials"
        Me.txtqtymaterials.Size = New System.Drawing.Size(96, 20)
        Me.txtqtymaterials.TabIndex = 10
        '
        'lblremarks
        '
        Me.lblremarks.AutoSize = True
        Me.lblremarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremarks.Location = New System.Drawing.Point(423, 387)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(74, 16)
        Me.lblremarks.TabIndex = 14
        Me.lblremarks.Text = "Remarks:"
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(517, 383)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(130, 20)
        Me.txtremarks.TabIndex = 15
        '
        'cbocodeno
        '
        Me.cbocodeno.FormattingEnabled = True
        Me.cbocodeno.Location = New System.Drawing.Point(127, 12)
        Me.cbocodeno.Name = "cbocodeno"
        Me.cbocodeno.Size = New System.Drawing.Size(122, 21)
        Me.cbocodeno.TabIndex = 20
        '
        'txtpacking
        '
        Me.txtpacking.Location = New System.Drawing.Point(146, 380)
        Me.txtpacking.Name = "txtpacking"
        Me.txtpacking.Size = New System.Drawing.Size(84, 20)
        Me.txtpacking.TabIndex = 22
        '
        'txtcodeno
        '
        Me.txtcodeno.Location = New System.Drawing.Point(273, 13)
        Me.txtcodeno.Name = "txtcodeno"
        Me.txtcodeno.Size = New System.Drawing.Size(116, 20)
        Me.txtcodeno.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnback)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnadditem)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 413)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 84)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(683, 26)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(92, 31)
        Me.btnback.TabIndex = 33
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(460, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 32)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "value meals"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(597, 26)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(82, 29)
        Me.btnadd.TabIndex = 31
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(251, 29)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(86, 29)
        Me.btnok.TabIndex = 30
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(177, 29)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(66, 29)
        Me.btnclose.TabIndex = 29
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(105, 29)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(66, 29)
        Me.btnsave.TabIndex = 28
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(6, 29)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(93, 29)
        Me.btndelete.TabIndex = 27
        Me.btndelete.Text = "Delete item"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnadditem
        '
        Me.btnadditem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadditem.Location = New System.Drawing.Point(343, 28)
        Me.btnadditem.Name = "btnadditem"
        Me.btnadditem.Size = New System.Drawing.Size(111, 30)
        Me.btnadditem.TabIndex = 26
        Me.btnadditem.Text = "ADD item"
        Me.btnadditem.UseVisualStyleBackColor = True
        '
        'frmviewsold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(813, 639)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtcodeno)
        Me.Controls.Add(Me.txtpacking)
        Me.Controls.Add(Me.cbocodeno)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.lblremarks)
        Me.Controls.Add(Me.txtqtymaterials)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbsoldproduct)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbentercodeno)
        Me.Name = "frmviewsold"
        Me.Text = "View Sold"
        Me.gbentercodeno.ResumeLayout(False)
        Me.gbentercodeno.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.gbsoldproduct.ResumeLayout(False)
        Me.gbsoldproduct.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbentercodeno As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents cbotransactiontype As System.Windows.Forms.ComboBox
    Friend WithEvents gbsoldproduct As System.Windows.Forms.GroupBox
    Friend WithEvents lblsize As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblunit As System.Windows.Forms.Label
    Friend WithEvents lblproduct As System.Windows.Forms.Label
    Friend WithEvents cbosize As System.Windows.Forms.ComboBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtqtymaterials As System.Windows.Forms.TextBox
    Friend WithEvents lblremarks As System.Windows.Forms.Label
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents cbocodeno As System.Windows.Forms.ComboBox
    Friend WithEvents txtproduct As System.Windows.Forms.TextBox
    Friend WithEvents txtpacking As System.Windows.Forms.TextBox
    Friend WithEvents txtcodeno As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnadditem As System.Windows.Forms.Button
End Class
