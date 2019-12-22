<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicket_Viewer
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
        Me.Ticket_Report1 = New Local_Train.Ticket_Report
        Me.Ticket_Viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Ticket_Report2 = New Local_Train.Ticket_Report
        Me.SuspendLayout()
        '
        'Ticket_Viewer
        '
        Me.Ticket_Viewer.ActiveViewIndex = 0
        Me.Ticket_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ticket_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ticket_Viewer.Location = New System.Drawing.Point(0, 0)
        Me.Ticket_Viewer.Name = "Ticket_Viewer"
        Me.Ticket_Viewer.ReportSource = Me.Ticket_Report2
        Me.Ticket_Viewer.Size = New System.Drawing.Size(725, 469)
        Me.Ticket_Viewer.TabIndex = 0
        '
        'frmTicket_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 469)
        Me.Controls.Add(Me.Ticket_Viewer)
        Me.Name = "frmTicket_Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTicket_Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ticket_Report1 As Local_Train.Ticket_Report
    Friend WithEvents Ticket_Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Ticket_Report2 As Local_Train.Ticket_Report
End Class
