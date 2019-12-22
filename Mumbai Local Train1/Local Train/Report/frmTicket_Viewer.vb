Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmTicket_Viewer

    Private Sub Ticket_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ticket_Viewer.Load
        '***************** This code is to make a application path to the code directory *************
        Dim orignalpath As String = Application.StartupPath
        Dim pathsplit() As String
        pathsplit = orignalpath.Split("\")
        Dim custompath As String = ""
        For i = 0 To pathsplit.Length - 3
            custompath &= pathsplit(i).ToString & "\"
        Next
        '***************** Code ends here ************************************************************


        Dim cryRpt As New ReportDocument
        cryRpt.Load(custompath & "report\Ticket_Report.rpt")

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
End Class