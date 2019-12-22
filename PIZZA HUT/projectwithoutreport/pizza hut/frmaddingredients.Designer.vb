<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddingredients
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
        Me.gbingredie = New System.Windows.Forms.GroupBox
        Me.cboname = New System.Windows.Forms.ComboBox
        Me.txtunit = New System.Windows.Forms.TextBox
        Me.txtpackingweigth = New System.Windows.Forms.TextBox
        Me.txtpacking = New System.Windows.Forms.TextBox
        Me.lblpackingweight = New System.Windows.Forms.Label
        Me.lblunit = New System.Windows.Forms.Label
        Me.lblpacking = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnveiw = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.gbingredie.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbingredie
        '
        Me.gbingredie.Controls.Add(Me.cboname)
        Me.gbingredie.Controls.Add(Me.txtunit)
        Me.gbingredie.Controls.Add(Me.txtpackingweigth)
        Me.gbingredie.Controls.Add(Me.txtpacking)
        Me.gbingredie.Controls.Add(Me.lblpackingweight)
        Me.gbingredie.Controls.Add(Me.lblunit)
        Me.gbingredie.Controls.Add(Me.lblpacking)
        Me.gbingredie.Controls.Add(Me.lblname)
        Me.gbingredie.Location = New System.Drawing.Point(12, 12)
        Me.gbingredie.Name = "gbingredie"
        Me.gbingredie.Size = New System.Drawing.Size(504, 122)
        Me.gbingredie.TabIndex = 0
        Me.gbingredie.TabStop = False
        Me.gbingredie.Text = "Ingredie"
        '
        'cboname
        '
        Me.cboname.FormattingEnabled = True
        Me.cboname.Location = New System.Drawing.Point(79, 30)
        Me.cboname.Name = "cboname"
        Me.cboname.Size = New System.Drawing.Size(124, 21)
        Me.cboname.TabIndex = 4
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(135, 64)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(85, 20)
        Me.txtunit.TabIndex = 1
        '
        'txtpackingweigth
        '
        Me.txtpackingweigth.Location = New System.Drawing.Point(403, 67)
        Me.txtpackingweigth.Name = "txtpackingweigth"
        Me.txtpackingweigth.Size = New System.Drawing.Size(85, 20)
        Me.txtpackingweigth.TabIndex = 3
        '
        'txtpacking
        '
        Me.txtpacking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpacking.Location = New System.Drawing.Point(360, 35)
        Me.txtpacking.Name = "txtpacking"
        Me.txtpacking.Size = New System.Drawing.Size(128, 22)
        Me.txtpacking.TabIndex = 2
        '
        'lblpackingweight
        '
        Me.lblpackingweight.AutoSize = True
        Me.lblpackingweight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpackingweight.Location = New System.Drawing.Point(264, 67)
        Me.lblpackingweight.Name = "lblpackingweight"
        Me.lblpackingweight.Size = New System.Drawing.Size(120, 16)
        Me.lblpackingweight.TabIndex = 3
        Me.lblpackingweight.Text = "Packing Weight:"
        '
        'lblunit
        '
        Me.lblunit.AutoSize = True
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(75, 67)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(39, 16)
        Me.lblunit.TabIndex = 2
        Me.lblunit.Text = "Unit:"
        '
        'lblpacking
        '
        Me.lblpacking.AutoSize = True
        Me.lblpacking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpacking.Location = New System.Drawing.Point(264, 35)
        Me.lblpacking.Name = "lblpacking"
        Me.lblpacking.Size = New System.Drawing.Size(68, 16)
        Me.lblpacking.TabIndex = 1
        Me.lblpacking.Text = "Packing:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(20, 31)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(53, 16)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name:"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 140)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(466, 233)
        Me.dgv.TabIndex = 5
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(172, 402)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(74, 28)
        Me.cmdsave.TabIndex = 4
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(252, 402)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(74, 28)
        Me.cmdupdate.TabIndex = 6
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(332, 402)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(74, 28)
        Me.cmdclose.TabIndex = 7
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(91, 402)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 28)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnveiw
        '
        Me.btnveiw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnveiw.Location = New System.Drawing.Point(7, 402)
        Me.btnveiw.Name = "btnveiw"
        Me.btnveiw.Size = New System.Drawing.Size(78, 27)
        Me.btnveiw.TabIndex = 9
        Me.btnveiw.Text = "Veiw"
        Me.btnveiw.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(415, 402)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(85, 31)
        Me.btnback.TabIndex = 10
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'frmaddingredients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(554, 504)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnveiw)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.gbingredie)
        Me.Name = "frmaddingredients"
        Me.Text = "Add Ingerdients"
        Me.gbingredie.ResumeLayout(False)
        Me.gbingredie.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbingredie As System.Windows.Forms.GroupBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtpackingweigth As System.Windows.Forms.TextBox
    Friend WithEvents txtpacking As System.Windows.Forms.TextBox
    Friend WithEvents lblpackingweight As System.Windows.Forms.Label
    Friend WithEvents lblunit As System.Windows.Forms.Label
    Friend WithEvents lblpacking As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnveiw As System.Windows.Forms.Button
    Friend WithEvents cboname As System.Windows.Forms.ComboBox
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
