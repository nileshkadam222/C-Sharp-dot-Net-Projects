Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPass_Viewer
    Private Sub Pass_Viewer_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pass_Viewer.Load
        Dim cryRpt As New ReportDocument
        '***************** This code is to make a application path to the code directory *************
        Dim orignalpath As String = Application.StartupPath
        Dim pathsplit() As String
        pathsplit = orignalpath.Split("\")
        Dim custompath As String = ""
        For i = 0 To pathsplit.Length - 3
            custompath &= pathsplit(i).ToString & "\"
        Next

        cryRpt.Load(custompath & "Report\Pass_Report.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = CStr(passno)
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