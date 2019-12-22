<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdoctors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdoctors))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDOCCODE = New System.Windows.Forms.TextBox
        Me.txtDOCNAME = New System.Windows.Forms.TextBox
        Me.txtSPCLZATION = New System.Windows.Forms.TextBox
        Me.txtNATURE = New System.Windows.Forms.TextBox
        Me.txtQUALIFICATION = New System.Windows.Forms.TextBox
        Me.lstCODE = New System.Windows.Forms.ListBox
        Me.cmdADD = New System.Windows.Forms.Button
        Me.cmdNEW = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnExit = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(47, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Doctor Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(47, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Doctor Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(47, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Specialization"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(47, 531)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Qualification"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(47, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nature"
        '
        'txtDOCCODE
        '
        Me.txtDOCCODE.Enabled = False
        Me.txtDOCCODE.Location = New System.Drawing.Point(155, 343)
        Me.txtDOCCODE.Name = "txtDOCCODE"
        Me.txtDOCCODE.ReadOnly = True
        Me.txtDOCCODE.Size = New System.Drawing.Size(153, 20)
        Me.txtDOCCODE.TabIndex = 1
        Me.txtDOCCODE.TabStop = False
        '
        'txtDOCNAME
        '
        Me.txtDOCNAME.Enabled = False
        Me.txtDOCNAME.Location = New System.Drawing.Point(155, 391)
        Me.txtDOCNAME.Name = "txtDOCNAME"
        Me.txtDOCNAME.Size = New System.Drawing.Size(153, 20)
        Me.txtDOCNAME.TabIndex = 2
        '
        'txtSPCLZATION
        '
        Me.txtSPCLZATION.Enabled = False
        Me.txtSPCLZATION.Location = New System.Drawing.Point(155, 437)
        Me.txtSPCLZATION.Name = "txtSPCLZATION"
        Me.txtSPCLZATION.Size = New System.Drawing.Size(153, 20)
        Me.txtSPCLZATION.TabIndex = 3
        '
        'txtNATURE
        '
        Me.txtNATURE.Enabled = False
        Me.txtNATURE.Location = New System.Drawing.Point(155, 484)
        Me.txtNATURE.Name = "txtNATURE"
        Me.txtNATURE.Size = New System.Drawing.Size(153, 20)
        Me.txtNATURE.TabIndex = 4
        '
        'txtQUALIFICATION
        '
        Me.txtQUALIFICATION.Enabled = False
        Me.txtQUALIFICATION.Location = New System.Drawing.Point(155, 527)
        Me.txtQUALIFICATION.Name = "txtQUALIFICATION"
        Me.txtQUALIFICATION.Size = New System.Drawing.Size(153, 20)
        Me.txtQUALIFICATION.TabIndex = 5
        '
        'lstCODE
        '
        Me.lstCODE.FormattingEnabled = True
        Me.lstCODE.Location = New System.Drawing.Point(314, 343)
        Me.lstCODE.Name = "lstCODE"
        Me.lstCODE.Size = New System.Drawing.Size(120, 212)
        Me.lstCODE.TabIndex = 0
        '
        'cmdADD
        '
        Me.cmdADD.Location = New System.Drawing.Point(508, 146)
        Me.cmdADD.Name = "cmdADD"
        Me.cmdADD.Size = New System.Drawing.Size(110, 23)
        Me.cmdADD.TabIndex = 12
        Me.cmdADD.Text = "&ADD"
        Me.cmdADD.UseVisualStyleBackColor = True
        Me.cmdADD.Visible = False
        '
        'cmdNEW
        '
        Me.cmdNEW.Location = New System.Drawing.Point(50, 580)
        Me.cmdNEW.Name = "cmdNEW"
        Me.cmdNEW.Size = New System.Drawing.Size(110, 23)
        Me.cmdNEW.TabIndex = 6
        Me.cmdNEW.Text = "&NEW"
        Me.cmdNEW.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(183, 580)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(110, 23)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "&EDIT"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(508, 189)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(110, 23)
        Me.cmdUpdate.TabIndex = 15
        Me.cmdUpdate.Text = "&UPDATE"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(151, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "DOCTORS DETAILS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(165, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 26)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(155, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(314, 580)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmdoctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 630)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdNEW)
        Me.Controls.Add(Me.cmdADD)
        Me.Controls.Add(Me.lstCODE)
        Me.Controls.Add(Me.txtQUALIFICATION)
        Me.Controls.Add(Me.txtNATURE)
        Me.Controls.Add(Me.txtSPCLZATION)
        Me.Controls.Add(Me.txtDOCNAME)
        Me.Controls.Add(Me.txtDOCCODE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmdoctors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctors Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDOCCODE As System.Windows.Forms.TextBox
    Friend WithEvents txtDOCNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtSPCLZATION As System.Windows.Forms.TextBox
    Friend WithEvents txtNATURE As System.Windows.Forms.TextBox
    Friend WithEvents txtQUALIFICATION As System.Windows.Forms.TextBox
    Friend WithEvents lstCODE As System.Windows.Forms.ListBox
    Friend WithEvents cmdADD As System.Windows.Forms.Button
    Friend WithEvents cmdNEW As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
