<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproductprice
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
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtcategory = New System.Windows.Forms.TextBox
        Me.chknonveg = New System.Windows.Forms.CheckBox
        Me.chkveg = New System.Windows.Forms.CheckBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboname = New System.Windows.Forms.ComboBox
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.lblname = New System.Windows.Forms.Label
        Me.lblcategory = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbstuffed = New System.Windows.Forms.RadioButton
        Me.rdbfamily = New System.Windows.Forms.RadioButton
        Me.rdblarge = New System.Windows.Forms.RadioButton
        Me.rdbmedium = New System.Windows.Forms.RadioButton
        Me.rdbsmall = New System.Windows.Forms.RadioButton
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbono = New System.Windows.Forms.ComboBox
        Me.txtno = New System.Windows.Forms.TextBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnok = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtcategory)
        Me.GroupBox1.Controls.Add(Me.chknonveg)
        Me.GroupBox1.Controls.Add(Me.chkveg)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboname)
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Controls.Add(Me.lblname)
        Me.GroupBox1.Controls.Add(Me.lblcategory)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 99)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(753, 363)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(602, 25)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(117, 22)
        Me.txtname.TabIndex = 15
        '
        'txtcategory
        '
        Me.txtcategory.Location = New System.Drawing.Point(205, 45)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(73, 22)
        Me.txtcategory.TabIndex = 14
        '
        'chknonveg
        '
        Me.chknonveg.AutoSize = True
        Me.chknonveg.Location = New System.Drawing.Point(108, 57)
        Me.chknonveg.Name = "chknonveg"
        Me.chknonveg.Size = New System.Drawing.Size(88, 20)
        Me.chknonveg.TabIndex = 13
        Me.chknonveg.Text = "Non-Veg"
        Me.chknonveg.UseVisualStyleBackColor = True
        '
        'chkveg
        '
        Me.chkveg.AutoSize = True
        Me.chkveg.Location = New System.Drawing.Point(108, 31)
        Me.chkveg.Name = "chkveg"
        Me.chkveg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkveg.Size = New System.Drawing.Size(55, 20)
        Me.chkveg.TabIndex = 12
        Me.chkveg.Text = "Veg"
        Me.chkveg.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(612, 168)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(120, 22)
        Me.txtamount.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total_Amount:"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(152, 165)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(104, 22)
        Me.txtqty.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Quantity:"
        '
        'cboname
        '
        Me.cboname.FormattingEnabled = True
        Me.cboname.Location = New System.Drawing.Point(464, 24)
        Me.cboname.Margin = New System.Windows.Forms.Padding(4)
        Me.cboname.Name = "cboname"
        Me.cboname.Size = New System.Drawing.Size(131, 24)
        Me.cboname.TabIndex = 7
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(8, 210)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(724, 145)
        Me.dgv1.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(382, 32)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(53, 16)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "Name:"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcategory.Location = New System.Drawing.Point(18, 31)
        Me.lblcategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(75, 16)
        Me.lblcategory.TabIndex = 2
        Me.lblcategory.Text = "Category:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbstuffed)
        Me.GroupBox2.Controls.Add(Me.rdbfamily)
        Me.GroupBox2.Controls.Add(Me.rdblarge)
        Me.GroupBox2.Controls.Add(Me.rdbmedium)
        Me.GroupBox2.Controls.Add(Me.rdbsmall)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 84)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(645, 63)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price List"
        '
        'rdbstuffed
        '
        Me.rdbstuffed.AutoSize = True
        Me.rdbstuffed.Location = New System.Drawing.Point(435, 23)
        Me.rdbstuffed.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbstuffed.Name = "rdbstuffed"
        Me.rdbstuffed.Size = New System.Drawing.Size(113, 20)
        Me.rdbstuffed.TabIndex = 13
        Me.rdbstuffed.TabStop = True
        Me.rdbstuffed.Text = "Stuffed Curst"
        Me.rdbstuffed.UseVisualStyleBackColor = True
        '
        'rdbfamily
        '
        Me.rdbfamily.AutoSize = True
        Me.rdbfamily.Location = New System.Drawing.Point(319, 23)
        Me.rdbfamily.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbfamily.Name = "rdbfamily"
        Me.rdbfamily.Size = New System.Drawing.Size(72, 20)
        Me.rdbfamily.TabIndex = 12
        Me.rdbfamily.TabStop = True
        Me.rdbfamily.Text = "Family"
        Me.rdbfamily.UseVisualStyleBackColor = True
        '
        'rdblarge
        '
        Me.rdblarge.AutoSize = True
        Me.rdblarge.Location = New System.Drawing.Point(224, 23)
        Me.rdblarge.Margin = New System.Windows.Forms.Padding(4)
        Me.rdblarge.Name = "rdblarge"
        Me.rdblarge.Size = New System.Drawing.Size(66, 20)
        Me.rdblarge.TabIndex = 11
        Me.rdblarge.TabStop = True
        Me.rdblarge.Text = "Large"
        Me.rdblarge.UseVisualStyleBackColor = True
        '
        'rdbmedium
        '
        Me.rdbmedium.AutoSize = True
        Me.rdbmedium.Location = New System.Drawing.Point(117, 23)
        Me.rdbmedium.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbmedium.Name = "rdbmedium"
        Me.rdbmedium.Size = New System.Drawing.Size(80, 20)
        Me.rdbmedium.TabIndex = 10
        Me.rdbmedium.TabStop = True
        Me.rdbmedium.Text = "Medium"
        Me.rdbmedium.UseVisualStyleBackColor = True
        '
        'rdbsmall
        '
        Me.rdbsmall.AutoSize = True
        Me.rdbsmall.Location = New System.Drawing.Point(16, 23)
        Me.rdbsmall.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbsmall.Name = "rdbsmall"
        Me.rdbsmall.Size = New System.Drawing.Size(65, 20)
        Me.rdbsmall.TabIndex = 9
        Me.rdbsmall.TabStop = True
        Me.rdbsmall.Text = "Small"
        Me.rdbsmall.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(13, 489)
        Me.cmddelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(98, 32)
        Me.cmddelete.TabIndex = 1
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(119, 490)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(85, 31)
        Me.cmdsave.TabIndex = 2
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(217, 490)
        Me.cmdupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(94, 31)
        Me.cmdupdate.TabIndex = 3
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(333, 489)
        Me.cmdclose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(88, 31)
        Me.cmdclose.TabIndex = 4
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(429, 489)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(93, 31)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Order_no"
        '
        'cbono
        '
        Me.cbono.FormattingEnabled = True
        Me.cbono.Location = New System.Drawing.Point(164, 69)
        Me.cbono.Margin = New System.Windows.Forms.Padding(4)
        Me.cbono.Name = "cbono"
        Me.cbono.Size = New System.Drawing.Size(110, 24)
        Me.cbono.TabIndex = 7
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(290, 69)
        Me.txtno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(120, 22)
        Me.txtno.TabIndex = 8
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(529, 489)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(93, 31)
        Me.btnadd.TabIndex = 9
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(638, 490)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(80, 29)
        Me.btnok.TabIndex = 10
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Price:"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(353, 165)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(111, 22)
        Me.txtprice.TabIndex = 17
        '
        'frmproductprice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(818, 607)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.cbono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmproductprice"
        Me.Text = "Product Price"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents rdbsmall As System.Windows.Forms.RadioButton
    Friend WithEvents rdbmedium As System.Windows.Forms.RadioButton
    Friend WithEvents rdbstuffed As System.Windows.Forms.RadioButton
    Friend WithEvents rdbfamily As System.Windows.Forms.RadioButton
    Friend WithEvents rdblarge As System.Windows.Forms.RadioButton
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboname As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbono As System.Windows.Forms.ComboBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents chknonveg As System.Windows.Forms.CheckBox
    Friend WithEvents chkveg As System.Windows.Forms.CheckBox
    Friend WithEvents txtcategory As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
