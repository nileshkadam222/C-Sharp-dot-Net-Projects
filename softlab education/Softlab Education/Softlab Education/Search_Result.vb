Imports System.Data
Imports System.Data.SqlClient

Public Class Search_Result
    'Dim da As New SqlDataAdapter
    'Dim cmd As New SqlCommand
    'Dim con As New SqlConnection
    'Dim str, str1 As String
    'Dim dt As New DataTable
    'Dim ds As New DataSet
    'Dim dv As New DataView
    'Dim dr As SqlDataReader
    'Dim i As Integer
    Private Sub Search_Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_id.Visible = False
        cmb_name.Visible = False
        lbl_id.Visible = False
        lbl_name.Visible = False
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        str1 = "select * from Result_details "
        Try

            da = New SqlDataAdapter(str1, con)
            da.Fill(ds)
            con.Close()
            dgvstud.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmb_search_by_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_search_by.SelectedIndexChanged
        If cmb_search_by.Text = "Stream_Name" Then
            cmb_name.Visible = True
            cmb_id.Visible = False
            lbl_name.Visible = True
            lbl_id.Visible = False
            con.Open()
            str = "select stream_name from Result_details "
            cmd = New SqlCommand(str, con)
            dr = cmd.ExecuteReader
            cmb_name.Items.Clear()
            Do While dr.Read
                cmb_name.Items.Add(dr("stream_name").ToString)
            Loop
            dr.Close()
            con.Close()
            i = 0
        End If
        If cmb_search_by.Text = "Test_Id" Then
            cmb_name.Visible = False
            cmb_id.Visible = True
            cmb_id.Items.Clear()
            lbl_id.Visible = True
            lbl_name.Visible = False
            con.Open()
            str = "select test_id from Result_details"
            cmd = New SqlCommand(str, con)
            dr = cmd.ExecuteReader
            cmb_id.Items.Clear()
            Do While dr.Read
                cmb_id.Items.Add(dr("test_id"))
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
            da = New SqlDataAdapter("select * from Result_details where stream_name='" & cmb_name.Text & "' ", con)
            da.Fill(dt)
            dgvstud.DataSource = dt
            con.Close()
        ElseIf i = 1 Then
            con.Open()
            da = New SqlDataAdapter("select * from Result_details where test_id=" & cmb_id.Text & " ", con)
            da.Fill(dt)
            dgvstud.DataSource = dt
            con.Close()
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        str1 = "select * from Result_details order by test_id asc"
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
        Update_Result.Show()

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        resultrpt.Show()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class