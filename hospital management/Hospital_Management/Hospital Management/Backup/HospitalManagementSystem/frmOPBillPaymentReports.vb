Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmOPBillPaymentReports
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New rptOPBillPaymentReport
        connection()
        'If con.State = ConnectionState.Closed Then

        con = New SqlConnection(constr)
        con.Open()
        'End If
        'Dim a As String
        'a = Form3.TextBox1.Text
        ad = New SqlDataAdapter("select * from OPBill B,OPBillPayments BP,Opdet OP where B.BillID=BP.BillID and BP.PCODE=OP.PCODE and BP.PCODE='" & frmOPBillPaymentReport.cboPCode.Text & "'", con)
        ds = New DataSet
        ad.Fill(ds, "OPBill,OPBillPayments,Opdet")
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class