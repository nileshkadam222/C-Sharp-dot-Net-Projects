<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuppiler
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
        Me.lblsuppilerid = New System.Windows.Forms.Label
        Me.txtsuppilerid = New System.Windows.Forms.TextBox
        Me.dgvsuppiler = New System.Windows.Forms.DataGridView
        Me.btnok = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.txtsuppliername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.cboid = New System.Windows.Forms.ComboBox
        Me.btndelete = New System.Windows.Forms.Button
        CType(Me.dgvsuppiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblsuppilerid
        '
        Me.lblsuppilerid.AutoSize = True
        Me.lblsuppilerid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppilerid.Location = New System.Drawing.Point(27, 9)
        Me.lblsuppilerid.Name = "lblsuppilerid"
        Me.lblsuppilerid.Size = New System.Drawing.Size(70, 16)
        Me.lblsuppilerid.TabIndex = 0
        Me.lblsuppilerid.Text = "Suppiler:"
        '
        'txtsuppilerid
        '
        Me.txtsuppilerid.Location = New System.Drawing.Point(129, 31)
        Me.txtsuppilerid.Name = "txtsuppilerid"
        Me.txtsuppilerid.Size = New System.Drawing.Size(123, 20)
        Me.txtsuppilerid.TabIndex = 1
        '
        'dgvsuppiler
        '
        Me.dgvsuppiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsuppiler.Location = New System.Drawing.Point(15, 105)
        Me.dgvsuppiler.Name = "dgvsuppiler"
        Me.dgvsuppiler.Size = New System.Drawing.Size(349, 217)
        Me.dgvsuppiler.TabIndex = 2
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(15, 370)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(82, 33)
        Me.btnok.TabIndex = 3
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(103, 370)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(82, 33)
        Me.btnupdate.TabIndex = 4
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(191, 370)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(70, 33)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(267, 371)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 31)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtsuppliername
        '
        Me.txtsuppliername.Location = New System.Drawing.Point(129, 61)
        Me.txtsuppliername.Name = "txtsuppliername"
        Me.txtsuppliername.Size = New System.Drawing.Size(123, 20)
        Me.txtsuppliername.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Supplier Name"
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(355, 372)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(81, 31)
        Me.btnadd.TabIndex = 9
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cboid
        '
        Me.cboid.FormattingEnabled = True
        Me.cboid.Location = New System.Drawing.Point(129, 4)
        Me.cboid.Name = "cboid"
        Me.cboid.Size = New System.Drawing.Size(95, 21)
        Me.cboid.TabIndex = 10
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(442, 372)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(69, 31)
        Me.btndelete.TabIndex = 11
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmsuppiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(535, 467)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cboid)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsuppliername)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.dgvsuppiler)
        Me.Controls.Add(Me.txtsuppilerid)
        Me.Controls.Add(Me.lblsuppilerid)
        Me.Name = "frmsuppiler"
        Me.Text = "Supplier"
        CType(Me.dgvsuppiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsuppilerid As System.Windows.Forms.Label
    Friend WithEvents txtsuppilerid As System.Windows.Forms.TextBox
    Friend WithEvents dgvsuppiler As System.Windows.Forms.DataGridView
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtsuppliername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents cboid As System.Windows.Forms.ComboBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
