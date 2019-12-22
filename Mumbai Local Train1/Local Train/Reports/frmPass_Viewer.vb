Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPass_Viewer

    Private Sub Pass_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cryRpt As New ReportDocument
        cryRpt.Load("G:\F Drive\Mumbai Local Train\Local Train\Reports\Pass_Report.rpt")

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

        Pass_Viewer.ReportSource = cryRpt
        Pass_Viewer.Refresh()
    End Sub
End Class