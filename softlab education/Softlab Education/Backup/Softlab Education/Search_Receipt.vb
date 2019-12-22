﻿Imports System.Data
Imports System.Data.SqlClient


Public Class Search_Receipt
    'Dim da As New SqlDataAdapter
    'Dim cmd As New SqlCommand
    'Dim con As New SqlConnection
    'Dim str, str1 As String
    'Dim dt As New DataTable
    'Dim ds As New DataSet
    'Dim dv As New DataView
    'Dim dr As SqlDataReader
    'Dim i As Integer
    Private Sub Search_Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_stud_id.Visible = False
        cmb_stud_name.Visible = False
        lblstud_id.Visible = False
        lblstud_name.Visible = False
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        str1 = "select * from Receipt_datails "
        Try
            con.Open()
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds)
            con.Close()
            dgvstud.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmb_search_by_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_search_by.SelectedIndexChanged
        If cmb_search_by.Text = "Student_Name" Then
            cmb_stud_name.Visible = True
            cmb_stud_id.Visible = False
            lblstud_name.Visible = True
            lblstud_id.Visible = False
            con.Open()
            str = "select stud_lname from Receipt_datails"
            cmd = New SqlCommand(str, con)
            dr = cmd.ExecuteReader
            cmb_stud_name.Items.Clear()
            Do While dr.Read
                cmb_stud_name.Items.Add(dr("stud_lname").ToString)
            Loop
            dr.Close()
            con.Close()
            i = 0
        End If
        If cmb_search_by.Text = "Student_Id" Then
            cmb_stud_name.Visible = False
            cmb_stud_id.Visible = True
            cmb_stud_id.Items.Clear()
            lblstud_id.Visible = True
            lblstud_name.Visible = False
            con.Open()
            str = "select stud_id from Receipt_datails"
            cmd = New SqlCommand(str, con)
            dr = cmd.ExecuteReader
            cmb_stud_id.Items.Clear()
            Do While dr.Read
                cmb_stud_id.Items.Add(dr("stud_id"))
            Loop
            dr.Close()
            con.Close()
            i = 1
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        dt = New DataTable
        If i = 0 Then
            con.Open()
            da = New SqlDataAdapter("select * from  Receipt_datails where stud_lname='" & cmb_stud_name.Text & "' ", con)
            da.Fill(dt)
            dgvstud.DataSource = dt
            con.Close()
        ElseIf i = 1 Then
            con.Open()
            da = New SqlDataAdapter("select * from  Receipt_datails where stud_id=" & cmb_stud_id.Text & " ", con)
            da.Fill(dt)
            dgvstud.DataSource = dt
            con.Close()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        str1 = "select * from  Receipt_datails order by stud_id asc"
        Try
            con.Open()
            da = New SqlDataAdapter(str1, con)
            ds = New DataSet
            da.Fill(ds)
            con.Close()
            dgvstud.DataSource = ds.Tables(0)
            dgvstud.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Update_Receipt.Show()

    End Sub

    
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        receiptrpt.Show()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class