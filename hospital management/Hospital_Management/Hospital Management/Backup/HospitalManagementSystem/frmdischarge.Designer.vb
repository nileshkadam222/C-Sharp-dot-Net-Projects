<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdischarge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdischarge))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPNAME = New System.Windows.Forms.TextBox
        Me.txtDOCNAME = New System.Windows.Forms.TextBox
        Me.txtWARDNAME = New System.Windows.Forms.TextBox
        Me.txtROOMTYPE = New System.Windows.Forms.TextBox
        Me.dtpDOD = New System.Windows.Forms.DateTimePicker
        Me.txtDOA = New System.Windows.Forms.TextBox
        Me.txtDIAGNOSIS = New System.Windows.Forms.TextBox
        Me.txtBEDNO = New System.Windows.Forms.TextBox
        Me.txtROOMRENT = New System.Windows.Forms.TextBox
        Me.lstPCODE = New System.Windows.Forms.ListBox
        Me.MFG = New System.Windows.Forms.DataGridView
        Me.MFG1 = New System.Windows.Forms.DataGridView
        Me.txtDAYSINHOS = New System.Windows.Forms.TextBox
        Me.txtTOTALAMT = New System.Windows.Forms.TextBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdReport = New System.Windows.Forms.Button
        Me.cmdCalc = New System.Windows.Forms.Button
        Me.cmdDischarge = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.MFG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MFG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(209, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(209, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Doctor Examined:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(511, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discharge Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(211, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ward Joined :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(211, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Room Type :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(510, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date of Admission :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(510, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Diagnosis Details:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(513, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bed No :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(212, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Room Rent:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(515, 527)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Days in Hospital"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(515, 565)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Grand Total :"
        '
        'txtPNAME
        '
        Me.txtPNAME.Location = New System.Drawing.Point(331, 210)
        Me.txtPNAME.Name = "txtPNAME"
        Me.txtPNAME.ReadOnly = True
        Me.txtPNAME.Size = New System.Drawing.Size(168, 20)
        Me.txtPNAME.TabIndex = 0
        Me.txtPNAME.TabStop = False
        '
        'txtDOCNAME
        '
        Me.txtDOCNAME.Location = New System.Drawing.Point(331, 247)
        Me.txtDOCNAME.Name = "txtDOCNAME"
        Me.txtDOCNAME.ReadOnly = True
        Me.txtDOCNAME.Size = New System.Drawing.Size(168, 20)
        Me.txtDOCNAME.TabIndex = 1
        Me.txtDOCNAME.TabStop = False
        '
        'txtWARDNAME
        '
        Me.txtWARDNAME.Location = New System.Drawing.Point(331, 286)
        Me.txtWARDNAME.Name = "txtWARDNAME"
        Me.txtWARDNAME.ReadOnly = True
        Me.txtWARDNAME.Size = New System.Drawing.Size(168, 20)
        Me.txtWARDNAME.TabIndex = 3
        Me.txtWARDNAME.TabStop = False
        '
        'txtROOMTYPE
        '
        Me.txtROOMTYPE.Location = New System.Drawing.Point(331, 326)
        Me.txtROOMTYPE.Name = "txtROOMTYPE"
        Me.txtROOMTYPE.ReadOnly = True
        Me.txtROOMTYPE.Size = New System.Drawing.Size(168, 20)
        Me.txtROOMTYPE.TabIndex = 4
        Me.txtROOMTYPE.TabStop = False
        '
        'dtpDOD
        '
        Me.dtpDOD.CustomFormat = "dd/MM/yyyy"
        Me.dtpDOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOD.Location = New System.Drawing.Point(630, 331)
        Me.dtpDOD.Name = "dtpDOD"
        Me.dtpDOD.Size = New System.Drawing.Size(168, 20)
        Me.dtpDOD.TabIndex = 2
        '
        'txtDOA
        '
        Me.txtDOA.Location = New System.Drawing.Point(630, 290)
        Me.txtDOA.Name = "txtDOA"
        Me.txtDOA.ReadOnly = True
        Me.txtDOA.Size = New System.Drawing.Size(168, 20)
        Me.txtDOA.TabIndex = 5
        Me.txtDOA.TabStop = False
        '
        'txtDIAGNOSIS
        '
        Me.txtDIAGNOSIS.Location = New System.Drawing.Point(630, 215)
        Me.txtDIAGNOSIS.Name = "txtDIAGNOSIS"
        Me.txtDIAGNOSIS.ReadOnly = True
        Me.txtDIAGNOSIS.Size = New System.Drawing.Size(168, 20)
        Me.txtDIAGNOSIS.TabIndex = 6
        Me.txtDIAGNOSIS.TabStop = False
        '
        'txtBEDNO
        '
        Me.txtBEDNO.Location = New System.Drawing.Point(630, 252)
        Me.txtBEDNO.Name = "txtBEDNO"
        Me.txtBEDNO.ReadOnly = True
        Me.txtBEDNO.Size = New System.Drawing.Size(168, 20)
        Me.txtBEDNO.TabIndex = 7
        Me.txtBEDNO.TabStop = False
        '
        'txtROOMRENT
        '
        Me.txtROOMRENT.Location = New System.Drawing.Point(331, 360)
        Me.txtROOMRENT.Name = "txtROOMRENT"
        Me.txtROOMRENT.ReadOnly = True
        Me.txtROOMRENT.Size = New System.Drawing.Size(168, 20)
        Me.txtROOMRENT.TabIndex = 8
        Me.txtROOMRENT.TabStop = False
        '
        'lstPCODE
        '
        Me.lstPCODE.FormattingEnabled = True
        Me.lstPCODE.Location = New System.Drawing.Point(828, 210)
        Me.lstPCODE.Name = "lstPCODE"
        Me.lstPCODE.Size = New System.Drawing.Size(120, 160)
        Me.lstPCODE.TabIndex = 9
        '
        'MFG
        '
        Me.MFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MFG.Location = New System.Drawing.Point(212, 516)
        Me.MFG.Name = "MFG"
        Me.MFG.ReadOnly = True
        Me.MFG.Size = New System.Drawing.Size(303, 100)
        Me.MFG.TabIndex = 21
        Me.MFG.Visible = False
        '
        'MFG1
        '
        Me.MFG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MFG1.Location = New System.Drawing.Point(212, 393)
        Me.MFG1.Name = "MFG1"
        Me.MFG1.ReadOnly = True
        Me.MFG1.Size = New System.Drawing.Size(596, 117)
        Me.MFG1.TabIndex = 22
        '
        'txtDAYSINHOS
        '
        Me.txtDAYSINHOS.Location = New System.Drawing.Point(640, 524)
        Me.txtDAYSINHOS.Name = "txtDAYSINHOS"
        Me.txtDAYSINHOS.ReadOnly = True
        Me.txtDAYSINHOS.Size = New System.Drawing.Size(158, 20)
        Me.txtDAYSINHOS.TabIndex = 11
        Me.txtDAYSINHOS.TabStop = False
        '
        'txtTOTALAMT
        '
        Me.txtTOTALAMT.Location = New System.Drawing.Point(640, 565)
        Me.txtTOTALAMT.Name = "txtTOTALAMT"
        Me.txtTOTALAMT.ReadOnly = True
        Me.txtTOTALAMT.Size = New System.Drawing.Size(158, 20)
        Me.txtTOTALAMT.TabIndex = 12
        Me.txtTOTALAMT.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Navy
        Me.cmdSave.Location = New System.Drawing.Point(828, 410)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(138, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Location = New System.Drawing.Point(828, 524)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdReport
        '
        Me.cmdReport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReport.ForeColor = System.Drawing.Color.Navy
        Me.cmdReport.Location = New System.Drawing.Point(828, 565)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(138, 23)
        Me.cmdReport.TabIndex = 5
        Me.cmdReport.Text = "Report"
        Me.cmdReport.UseVisualStyleBackColor = True
        Me.cmdReport.Visible = False
        '
        'cmdCalc
        '
        Me.cmdCalc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalc.ForeColor = System.Drawing.Color.Navy
        Me.cmdCalc.Location = New System.Drawing.Point(828, 448)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(138, 23)
        Me.cmdCalc.TabIndex = 4
        Me.cmdCalc.Text = "Calculate"
        Me.cmdCalc.UseVisualStyleBackColor = True
        '
        'cmdDischarge
        '
        Me.cmdDischarge.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDischarge.ForeColor = System.Drawing.Color.Navy
        Me.cmdDischarge.Location = New System.Drawing.Point(828, 487)
        Me.cmdDischarge.Name = "cmdDischarge"
        Me.cmdDischarge.Size = New System.Drawing.Size(138, 23)
        Me.cmdDischarge.TabIndex = 6
        Me.cmdDischarge.Text = "Click to Discharge"
        Me.cmdDischarge.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(466, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(196, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "DISCHARGE DETAILS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(446, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(239, 26)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Hospital Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(993, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'frmdischarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdDischarge)
        Me.Controls.Add(Me.cmdCalc)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtTOTALAMT)
        Me.Controls.Add(Me.txtDAYSINHOS)
        Me.Controls.Add(Me.MFG1)
        Me.Controls.Add(Me.MFG)
        Me.Controls.Add(Me.lstPCODE)
        Me.Controls.Add(Me.txtROOMRENT)
        Me.Controls.Add(Me.txtBEDNO)
        Me.Controls.Add(Me.txtDIAGNOSIS)
        Me.Controls.Add(Me.txtDOA)
        Me.Controls.Add(Me.dtpDOD)
        Me.Controls.Add(Me.txtROOMTYPE)
        Me.Controls.Add(Me.txtWARDNAME)
        Me.Controls.Add(Me.txtDOCNAME)
        Me.Controls.Add(Me.txtPNAME)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmdischarge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discharge"
        CType(Me.MFG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MFG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtDOCNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtWARDNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtROOMTYPE As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDOA As System.Windows.Forms.TextBox
    Friend WithEvents txtDIAGNOSIS As System.Windows.Forms.TextBox
    Friend WithEvents txtBEDNO As System.Windows.Forms.TextBox
    Friend WithEvents txtROOMRENT As System.Windows.Forms.TextBox
    Friend WithEvents lstPCODE As System.Windows.Forms.ListBox
    Friend WithEvents MFG As System.Windows.Forms.DataGridView
    Friend WithEvents MFG1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtDAYSINHOS As System.Windows.Forms.TextBox
    Friend WithEvents txtTOTALAMT As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents cmdCalc As System.Windows.Forms.Button
    Friend WithEvents cmdDischarge As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
