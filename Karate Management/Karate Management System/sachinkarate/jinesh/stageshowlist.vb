﻿Imports CrystalDecisions.CrystalReports.Engine

Public Class stageshowlist

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim crypt As New ReportDocument
        crypt.Load("C:\nainakarate\jinesh\CrystalReportstageshow.rpt")
        CrystalReportViewer1.ReportSource = crypt
        CrystalReportViewer1.Refresh()

    End Sub
End Class