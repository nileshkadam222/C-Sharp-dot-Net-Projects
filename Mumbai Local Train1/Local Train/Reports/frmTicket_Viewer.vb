Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmTicket_Viewer

    Private Sub Ticket_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cryRpt As New ReportDocument
        cryRpt.Load("G:\F Drive\Mumbai Local Train\Local Train\Reports\Ticket_Report.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = CStr(ticketno)
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item(0)
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        Ticket_Viewer.ReportSource = cryRpt
        Ticket_Viewer.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ticket_Viewer.Load

    End Sub
End Class