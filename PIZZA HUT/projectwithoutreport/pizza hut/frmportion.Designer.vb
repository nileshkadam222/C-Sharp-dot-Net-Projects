<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmportion
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
        Me.cboitem = New System.Windows.Forms.ComboBox
        Me.lblitem = New System.Windows.Forms.Label
        Me.gbportionchartentry = New System.Windows.Forms.GroupBox
        Me.cboingerdients = New System.Windows.Forms.ComboBox
        Me.cbosize = New System.Windows.Forms.ComboBox
        Me.txtunit = New System.Windows.Forms.TextBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.lblremark = New System.Windows.Forms.Label
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblsize = New System.Windows.Forms.Label
        Me.lblunit = New System.Windows.Forms.Label
        Me.lblingredients = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.gbportionchartentry.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboitem)
        Me.GroupBox1.Controls.Add(Me.lblitem)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Slecet Item"
        '
        'cboitem
        '
        Me.cboitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboitem.FormattingEnabled = True
        Me.cboitem.Location = New System.Drawing.Point(87, 29)
        Me.cboitem.Name = "cboitem"
        Me.cboitem.Size = New System.Drawing.Size(86, 24)
        Me.cboitem.TabIndex = 1
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.Location = New System.Drawing.Point(20, 29)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(37, 16)
        Me.lblitem.TabIndex = 0
        Me.lblitem.Text = "Item"
        '
        'gbportionchartentry
        '
        Me.gbportionchartentry.Controls.Add(Me.cboingerdients)
        Me.gbportionchartentry.Controls.Add(Me.cbosize)
        Me.gbportionchartentry.Controls.Add(Me.txtunit)
        Me.gbportionchartentry.Controls.Add(Me.txtqty)
        Me.gbportionchartentry.Controls.Add(Me.txtremarks)
        Me.gbportionchartentry.Controls.Add(Me.lblremark)
        Me.gbportionchartentry.Controls.Add(Me.lblqty)
        Me.gbportionchartentry.Controls.Add(Me.lblsize)
        Me.gbportionchartentry.Controls.Add(Me.lblunit)
        Me.gbportionchartentry.Controls.Add(Me.lblingredients)
        Me.gbportionchartentry.Location = New System.Drawing.Point(4, 103)
        Me.gbportionchartentry.Name = "gbportionchartentry"
        Me.gbportionchartentry.Size = New System.Drawing.Size(522, 138)
        Me.gbportionchartentry.TabIndex = 1
        Me.gbportionchartentry.TabStop = False
        Me.gbportionchartentry.Text = "Portion Chart Entry"
        '
        'cboingerdients
        '
        Me.cboingerdients.FormattingEnabled = True
        Me.cboingerdients.Location = New System.Drawing.Point(11, 67)
        Me.cboingerdients.Name = "cboingerdients"
        Me.cboingerdients.Size = New System.Drawing.Size(87, 21)
        Me.cboingerdients.TabIndex = 9
        '
        'cbosize
        '
        Me.cbosize.FormattingEnabled = True
        Me.cbosize.Location = New System.Drawing.Point(217, 68)
        Me.cbosize.Name = "cbosize"
        Me.cbosize.Size = New System.Drawing.Size(65, 21)
        Me.cbosize.TabIndex = 8
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(104, 67)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(100, 20)
        Me.txtunit.TabIndex = 7
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(298, 68)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 6
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(414, 67)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(100, 20)
        Me.txtremarks.TabIndex = 5
        '
        'lblremark
        '
        Me.lblremark.AutoSize = True
        Me.lblremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremark.Location = New System.Drawing.Point(426, 38)
        Me.lblremark.Name = "lblremark"
        Me.lblremark.Size = New System.Drawing.Size(62, 16)
        Me.lblremark.TabIndex = 4
        Me.lblremark.Text = "Remark"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(314, 38)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(31, 16)
        Me.lblqty.TabIndex = 3
        Me.lblqty.Text = "Qty"
        '
        'lblsize
        '
        Me.lblsize.AutoSize = True
        Me.lblsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsize.Location = New System.Drawing.Point(229, 38)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(38, 16)
        Me.lblsize.TabIndex = 2
        Me.lblsize.Text = "Size"
        '
        'lblunit
        '
        Me.lblunit.AutoSize = True
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(138, 38)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(35, 16)
        Me.lblunit.TabIndex = 1
        Me.lblunit.Text = "Unit"
        '
        'lblingredients
        '
        Me.lblingredients.AutoSize = True
        Me.lblingredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblingredients.Location = New System.Drawing.Point(8, 38)
        Me.lblingredients.Name = "lblingredients"
        Me.lblingredients.Size = New System.Drawing.Size(85, 16)
        Me.lblingredients.TabIndex = 0
        Me.lblingredients.Text = "Ingredients"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(4, 247)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(503, 209)
        Me.dgv.TabIndex = 2
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(108, 473)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 26)
        Me.cmdsave.TabIndex = 10
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(189, 473)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 26)
        Me.cmdclose.TabIndex = 11
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(27, 473)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 26)
        Me.cmddelete.TabIndex = 12
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(284, 473)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 26)
        Me.btnback.TabIndex = 13
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'frmportion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(555, 524)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.gbportionchartentry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmportion"
        Me.Text = "Portion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbportionchartentry.ResumeLayout(False)
        Me.gbportionchartentry.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboitem As System.Windows.Forms.ComboBox
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents gbportionchartentry As System.Windows.Forms.GroupBox
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents lblremark As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblsize As System.Windows.Forms.Label
    Friend WithEvents lblunit As System.Windows.Forms.Label
    Friend WithEvents lblingredients As System.Windows.Forms.Label
    Friend WithEvents cboingerdients As System.Windows.Forms.ComboBox
    Friend WithEvents cbosize As System.Windows.Forms.ComboBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
