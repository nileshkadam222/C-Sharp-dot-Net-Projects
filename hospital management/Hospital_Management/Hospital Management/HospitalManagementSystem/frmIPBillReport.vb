Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmIPBillReport
    Dim con As SqlConnection
    Dim dr As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim rd As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New rptIPBillReport
        Dim crtableLogoninfos As New TableLogOnInfos()
        Dim crtableLogoninfo As New TableLogOnInfo()
        Dim crConnectionInfo As New CrystalDecisions.Shared.ConnectionInfo()
        Dim CrTables As Tables
        Dim CrTable As Table
        Dim reppath As String
        Dim path As String
        Dim substring As String

        'Dim myFile As New System.IO.StreamReader("c:\\cont")
        'Dim str1 As String = myFile.ReadToEnd()
        'Dim str As String() = str1.Split(New Char() {";"})

        'myFile.Close()

        'connection()
        ' con = New SqlConnection(constr)
        con.Open()
        cmd = New SqlCommand("select * from Bill B,BillPayments BP,INPATIENTS IP where B.BillID=BP.BillID and BP.PCODE=IP.PCODE and BP.PCODE='" & frmIPBillPaymentReport.cboCustName.Text & "'", con)
        dr = cmd.ExecuteReader()
        dt = New DataTable()
        dt.Load(dr)
        dr.Close()
        rd = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        path = Application.StartupPath.ToString()
        substring = path.Substring(path.IndexOf("\") - 2, path.IndexOf("bin") - 1)
        reppath = substring & "\" & "rptIPBillReport.rpt"
        rd.Load(reppath)
        With crConnectionInfo
            .ServerName = ".\SQLExpress"
            .DatabaseName = "HospitalManagement.mdf"
            .IntegratedSecurity = True
        End With

        rd.SetDataSource(dt)
        CrTables = rd.Database.Tables

        'Loop through each table in the report and apply the LogonInfo information
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)

        Next

        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.ReportSource = rd


    End Sub
End Class