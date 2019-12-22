Imports CrystalDecisions.CrystalReports.Engine
Public Class applist

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim crypt As New ReportDocument
        crypt.Load("C:\Documents and Settings\Administrator\Desktop\New Folder\nainakarate\jinesh\CrystalReportapp.rpt")
        CrystalReportViewer1.ReportSource = crypt
        CrystalReportViewer1.Refresh()


    End Sub
End Class