<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminventorydetails
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
        Me.btnpurchased = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optpurchased = New System.Windows.Forms.RadioButton
        Me.optreleaseditem = New System.Windows.Forms.RadioButton
        Me.optdamageitem = New System.Windows.Forms.RadioButton
        Me.btnback = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Orchid
        Me.GroupBox1.Controls.Add(Me.btnback)
        Me.GroupBox1.Controls.Add(Me.btnpurchased)
        Me.GroupBox1.Controls.Add(Me.cmdclose)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 394)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Details"
        '
        'btnpurchased
        '
        Me.btnpurchased.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurchased.Location = New System.Drawing.Point(12, 340)
        Me.btnpurchased.Name = "btnpurchased"
        Me.btnpurchased.Size = New System.Drawing.Size(178, 32)
        Me.btnpurchased.TabIndex = 5
        Me.btnpurchased.Text = "Purchased"
        Me.btnpurchased.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(196, 340)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(102, 32)
        Me.cmdclose.TabIndex = 4
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 97)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(356, 223)
        Me.dgv.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optpurchased)
        Me.GroupBox2.Controls.Add(Me.optreleaseditem)
        Me.GroupBox2.Controls.Add(Me.optdamageitem)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 72)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option"
        '
        'optpurchased
        '
        Me.optpurchased.AutoSize = True
        Me.optpurchased.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optpurchased.Location = New System.Drawing.Point(6, 33)
        Me.optpurchased.Name = "optpurchased"
        Me.optpurchased.Size = New System.Drawing.Size(100, 20)
        Me.optpurchased.TabIndex = 2
        Me.optpurchased.TabStop = True
        Me.optpurchased.Text = "Purchased"
        Me.optpurchased.UseVisualStyleBackColor = True
        '
        'optreleaseditem
        '
        Me.optreleaseditem.AutoSize = True
        Me.optreleaseditem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optreleaseditem.Location = New System.Drawing.Point(112, 33)
        Me.optreleaseditem.Name = "optreleaseditem"
        Me.optreleaseditem.Size = New System.Drawing.Size(127, 20)
        Me.optreleaseditem.TabIndex = 1
        Me.optreleaseditem.TabStop = True
        Me.optreleaseditem.Text = "Released Item"
        Me.optreleaseditem.UseVisualStyleBackColor = True
        '
        'optdamageitem
        '
        Me.optdamageitem.AutoSize = True
        Me.optdamageitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optdamageitem.Location = New System.Drawing.Point(260, 33)
        Me.optdamageitem.Name = "optdamageitem"
        Me.optdamageitem.Size = New System.Drawing.Size(118, 20)
        Me.optdamageitem.TabIndex = 0
        Me.optdamageitem.TabStop = True
        Me.optdamageitem.Text = "Damage Item"
        Me.optdamageitem.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(322, 341)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(79, 30)
        Me.btnback.TabIndex = 6
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'frminventorydetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(437, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminventorydetails"
        Me.Text = "inventory Details"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optpurchased As System.Windows.Forms.RadioButton
    Friend WithEvents optreleaseditem As System.Windows.Forms.RadioButton
    Friend WithEvents optdamageitem As System.Windows.Forms.RadioButton
    Friend WithEvents btnpurchased As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
