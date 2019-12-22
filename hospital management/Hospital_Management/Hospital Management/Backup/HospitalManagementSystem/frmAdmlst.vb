Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmAdmlst
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim ds As DataSet
    Dim dv As DataView


    Private Sub btnClickTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClickTo.Click
        'con.Open()
        ds = New DataSet
        ad = New SqlDataAdapter("Select * from INPATIENTS", con)
        ad.Fill(ds, "INPATIENTS")
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("Patient Name")
        dt.Columns.Add("Doctor Examnied")
        dt.Columns.Add("Ward Joined")
        dt.Columns.Add("Room Type")
        dt.Columns.Add("Bed No")
        Dim cmd As New SqlCommand
        cmd.Connection = con
        Dim dat As String
        dat = dtpDOA.Value.Date
        cmd.CommandText = "Select * from INPATIENTS where DOA='" & dat & "'"
        'rd.Close()
        rd = cmd.ExecuteReader
        While (rd.Read)
            dr = dt.NewRow
            dr(0) = rd("PNAME")
            dr(1) = rd("DOCEXAMINED")
            dr(2) = rd("WARDJOINED")
            dr(3) = rd("ROOMTYPE")
            dr(4) = rd("BEDNO")
            dt.Rows.Add(dr)
        End While
        rd.Close()
        DGV1.DataSource = dt
       
    End Sub

    Private Sub frmAdmlst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        con = New SqlConnection(constr)
        con.Open()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim res As String
        res = MessageBox.Show("Do you want to exit", "Confirmation", MessageBoxButtons.YesNo)
        If res = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
