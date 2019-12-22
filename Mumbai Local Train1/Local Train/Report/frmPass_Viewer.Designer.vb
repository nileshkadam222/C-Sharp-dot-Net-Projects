<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPass_Viewer
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
        Me.Pass_Viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Pass_Report1 = New Local_Train.Pass_Report
        Me.SuspendLayout()
        '
        'Pass_Viewer
        '
        Me.Pass_Viewer.ActiveViewIndex = 0
        Me.Pass_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pass_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pass_Viewer.Location = New System.Drawing.Point(0, 0)
        Me.Pass_Viewer.Name = "Pass_Viewer"
        Me.Pass_Viewer.ReportSource = Me.Pass_Report1
        Me.Pass_Viewer.Size = New System.Drawing.Size(748, 467)
        Me.Pass_Viewer.TabIndex = 0
        '
        'frmPass_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 467)
        Me.Controls.Add(Me.Pass_Viewer)
        Me.Name = "frmPass_Viewer"
        Me.Text = "frmPass_Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pass_Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Pass_Report1 As Local_Train.Pass_Report
End Class
