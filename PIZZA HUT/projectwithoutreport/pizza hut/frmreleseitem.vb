Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmreleseditem
    Private Sub cbodes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodes.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from Destination where Destination_name='" & cbodes.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cbodes.Text = dr.GetString(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub frmreleseditem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As New SqlDataAdapter("select * from Relesed_item", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Relesed_item")
        DataGridView1.DataSource = ds.Tables("Relesed_item")

        Dim cmd As New SqlCommand("select * from Destination", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cbodes.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        cn.Close()

        Dim cmdsr As New SqlCommand("Select * from  Meat_Lovers ", cn)
        cn.Open()
        Dim drsr As SqlDataReader = cmdsr.ExecuteReader
        While drsr.Read
            cboname.Items.Add(drsr.GetString(0))
        End While
        drsr.Close()
        cn.Close()
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from Meat_Lovers where Ingredients='" & cboname.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboname.Text = dr.GetString(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtmt.Text = "" Or cbodes.Text = "" Or cboname.Text = "" Or txtunit.Text = "" Or txtstock.Text = "" Or txtstore.Text = "" Or txtremark.Text = "" Then
            MsgBox("Enter the feild properly", MsgBoxStyle.Information)
        Else
            Dim cmds As New SqlCommand("insert into Relesed_item values('" & txtmt.Text & "','" & cbodes.Text & "','" & DateTimePicker1.Value & "','" & cboname.Text & "','" & txtunit.Text & "','" & txtstock.Text & "','" & txtstore.Text & "','" & txtremark.Text & "')", cn)
            cn.Open()
            cmds.ExecuteNonQuery()
            MsgBox("record are succesfully added......", MsgBoxStyle.Information)
            cn.Close()
            Dim da As New SqlDataAdapter("select * from Relesed_item", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Relesed_item")
            DataGridView1.DataSource = ds.Tables("Relesed_item")
            txtmt.Text = ""
            cbodes.Text = ""
            DateTimePicker1.Value = Now
            cboname.Text = ""
            txtunit.Text = ""
            txtstock.Text = ""
            txtstore.Text = ""
            txtremark.Text = ""

        End If

    End Sub


    Private Sub btndetete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndetete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Relesed_item where Destination='" & cbodes.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtmt.Text = ""
            cbodes.Text = ""
            DateTimePicker1.Value = Now
            cboname.Text = ""
            txtunit.Text = ""
            txtstock.Text = ""
            txtstore.Text = ""
            txtremark.Text = ""
            Dim da As New SqlDataAdapter("select * from Relesed_item", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Relesed_item")
            DataGridView1.DataSource = ds.Tables("Relesed_item")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpost.Click
        MsgBox("Are you sure to post a previous form", MsgBoxStyle.Information)
        frminventorydetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

End Class