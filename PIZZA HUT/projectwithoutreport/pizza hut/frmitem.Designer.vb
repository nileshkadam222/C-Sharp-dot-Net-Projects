<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmitem
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
        Me.lblcategory = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.lblunit = New System.Windows.Forms.Label
        Me.lblprice = New System.Windows.Forms.Label
        Me.cboprodid = New System.Windows.Forms.ComboBox
        Me.txtunit = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.datagridview = New System.Windows.Forms.DataGridView
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnveiwall = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.txtprodid = New System.Windows.Forms.TextBox
        Me.btnback = New System.Windows.Forms.Button
        CType(Me.datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.Location = New System.Drawing.Point(31, 15)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(62, 16)
        Me.lblcategory.TabIndex = 0
        Me.lblcategory.Text = "Prod_id"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(44, 91)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(49, 16)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Name"
        '
        'lblunit
        '
        Me.lblunit.AutoSize = True
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(246, 94)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(35, 16)
        Me.lblunit.TabIndex = 2
        Me.lblunit.Text = "Unit"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(428, 87)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(44, 16)
        Me.lblprice.TabIndex = 3
        Me.lblprice.Text = "Price"
        '
        'cboprodid
        '
        Me.cboprodid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboprodid.FormattingEnabled = True
        Me.cboprodid.Location = New System.Drawing.Point(137, 12)
        Me.cboprodid.Name = "cboprodid"
        Me.cboprodid.Size = New System.Drawing.Size(118, 24)
        Me.cboprodid.TabIndex = 4
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(288, 90)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(121, 20)
        Me.txtunit.TabIndex = 6
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(103, 90)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(121, 20)
        Me.txtname.TabIndex = 7
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(483, 87)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(121, 20)
        Me.txtprice.TabIndex = 8
        '
        'datagridview
        '
        Me.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview.Location = New System.Drawing.Point(81, 137)
        Me.datagridview.Name = "datagridview"
        Me.datagridview.Size = New System.Drawing.Size(415, 185)
        Me.datagridview.TabIndex = 9
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(14, 395)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(79, 35)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(176, 395)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(79, 35)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(261, 395)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(79, 35)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(346, 395)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(79, 35)
        Me.btnclose.TabIndex = 13
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnveiwall
        '
        Me.btnveiwall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnveiwall.Location = New System.Drawing.Point(103, 395)
        Me.btnveiwall.Name = "btnveiwall"
        Me.btnveiwall.Size = New System.Drawing.Size(67, 35)
        Me.btnveiwall.TabIndex = 14
        Me.btnveiwall.Text = "Veiw All"
        Me.btnveiwall.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(431, 395)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(82, 35)
        Me.btnadd.TabIndex = 15
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtprodid
        '
        Me.txtprodid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprodid.Location = New System.Drawing.Point(137, 42)
        Me.txtprodid.Name = "txtprodid"
        Me.txtprodid.Size = New System.Drawing.Size(118, 22)
        Me.txtprodid.TabIndex = 17
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(525, 398)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(72, 31)
        Me.btnback.TabIndex = 18
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'frmitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(616, 457)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.txtprodid)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnveiwall)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.datagridview)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.cboprodid)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblunit)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblcategory)
        Me.Name = "frmitem"
        Me.Text = "Item"
        CType(Me.datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblunit As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents cboprodid As System.Windows.Forms.ComboBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents datagridview As System.Windows.Forms.DataGridView
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnveiwall As System.Windows.Forms.Button
    Private WithEvents txtprodid As System.Windows.Forms.TextBox
    Public WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
