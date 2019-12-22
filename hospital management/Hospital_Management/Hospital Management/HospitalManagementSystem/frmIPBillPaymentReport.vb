Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmIPBillPaymentReport
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub cboCustName_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCustName.DropDown
        cmd.Connection = con
        cmd.CommandText = "SELECT PCODE FROM INPATIENTS"
        rd = cmd.ExecuteReader
        cboCustName.Items.Clear()
        While rd.Read()
            cboCustName.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub frmIPBillPaymentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  connection()
        ' con = New SqlConnection(constr)
        con.Open()
    End Sub

    Private Sub cboCustName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCustName.LostFocus
        'On Error Resume Next
        If cboCustName.Text = "" Then

        Else
            cmd.Connection = con
            cmd.CommandText = "Select BillId,BillNo from Bill where PCODE ='" & cboCustName.Text & "'"
            rd = cmd.ExecuteReader
            cboBillNo.Items.Clear()
            While rd.Read()
                cboBillNo.Items.Add(rd(1))
                cboBillNo.Items(i) = rd(0)
                'cboBillNo.SelectedIt(i) = rd(0)
            End While
            rd.Close()
        End If
        

    End Sub

    Private Sub cboBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBillNo.SelectedIndexChanged

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        frmIPBillReport.MdiParent = MDIHospitalManagement
        frmIPBillReport.Show()
    End Sub
    Private Sub Txt_Clear()
        cboCustName.Items.Clear()
        cboBillNo.Items.Clear()
    End Sub

    Private Sub cboCustName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustName.SelectedIndexChanged
        cboBillNo.Text = ""
    End Sub
End Class