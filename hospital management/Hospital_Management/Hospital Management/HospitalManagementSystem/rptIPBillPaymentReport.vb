Imports System
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class rptIPBillPaymentReport
    Dim con As SqlConnection
    Dim ds As DataSet
    Dim ad As SqlDataAdapter
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New rptIPBillPaymentReport
        connection()
        con = New SqlConnection(constr)
        con.Open()
        Dim a As String
        a = frmIPBillPaymentReport.cboBillNo.Text
        ad = New SqlDataAdapter("select * from main M,Details D where D.Hostname= M.HostName and M.Hostname=' " & a & "'", con)
        ds = New DataSet
        ad.Fill(ds, "Main,Details")


        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class