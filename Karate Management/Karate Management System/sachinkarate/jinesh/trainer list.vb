Imports CrystalDecisions.CrystalReports.Engine
Public Class trainer_list

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim crypt As New ReportDocument
        crypt.Load("C:\nainakarate\jinesh\CrystalReporttrainer.rpt")
        CrystalReportViewer1.ReportSource = crypt
        CrystalReportViewer1.Refresh()

    End Sub
End Class