Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmOPDailyPayments
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Private Sub frmOPDailyPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' connection()
        ' con = New SqlConnection(constr)
        con.Open()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        'rptOptDailyBillingReport.Show()
        'Form1.Show()
    End Sub
End Class