﻿Imports CrystalDecisions.CrystalReports.Engine
Public Class assignbatchlist

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim crypt As New ReportDocument
        crypt.Load("C:\nainakarate\jinesh\CrystalReportassignbatch.rpt")
        CrystalReportViewer1.ReportSource = crypt
        CrystalReportViewer1.Refresh()

    End Sub
End Class