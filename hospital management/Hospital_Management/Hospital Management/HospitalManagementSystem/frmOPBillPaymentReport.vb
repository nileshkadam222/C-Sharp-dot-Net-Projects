Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmOPBillPaymentReport
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Private Sub frmOPBillPaymentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection()
        ' con = New SqlConnection(constr)
        con.Open()
    End Sub

    Private Sub cboPCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.DropDown
        'con.BeginTrans()
        cmd.Connection = con
        cmd.CommandText = "SELECT PCODE FROM OPDET"
        rd = cmd.ExecuteReader
        cboPCode.Items.Clear()
        While rd.Read
            cboPCode.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboPCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.LostFocus

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        If cboPCode.Text = "" Then
            MsgBox("Sorry !!!!!!!! Please Select the Patient Code ", vbInformation)
        Else
            frmOPBillPaymentReports.Show()
        End If
    End Sub
    Private Sub Txt_Clear()
        cboPCode.Items.Clear()
    End Sub


  
End Class