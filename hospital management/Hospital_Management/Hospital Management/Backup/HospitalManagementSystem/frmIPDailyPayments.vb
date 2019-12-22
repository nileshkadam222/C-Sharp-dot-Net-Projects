Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmIPDailyPayments
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Private Sub frmIPDailyPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If con.State Then con.Close()
        connection()
        con = New SqlConnection(constr)
        con.Open()
        DTPPaidDate.Value = Date.Now
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        frmIPDailyPaymentsReport.MdiParent = MDIHospitalManagement
        frmIPDailyPaymentsReport.Show()
    End Sub

End Class