Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmsuppiler
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Try
            End

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmdsave As New SqlCommand("insert into Suppiler values('" & txtsuppilerid.Text & " ','" & txtsuppliername.Text & "')", cn)
            cn.Open()
            cmdsave.ExecuteNonQuery()
            MsgBox("Record is successfully.......", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "saved")
            Dim da As New SqlDataAdapter("select * from Supplier", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Supplier")
            dgvsuppiler.DataSource = ds.Tables(0)
            cn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try

    End Sub

    Private Sub frmsuppiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from Supplier", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboid.Items.Add(dr.GetString(0))
            End While
            dr.Close()
            cn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim cmdsave As New SqlCommand("update Supplier set supplier_name='" & txtsuppliername.Text & "'where supplier_id='" & txtsuppilerid.Text & "'", cn)
            cn.Open()
            cmdsave.ExecuteNonQuery()
            MsgBox("record is updated")
            Dim da As New SqlDataAdapter("select * from Supplier", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Supplier")
            dgvsuppiler.DataSource = ds.Tables(0)
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            txtsuppliername.Text = ""
            Dim rec As New SqlCommand("select * from Supplier", cn)
            cn.Open()
            Dim dr As SqlDataReader = rec.ExecuteReader
            While dr.Read
                txtsuppilerid.Text = dr(0)
            End While
            txtsuppilerid.Text = "00" & Val(txtsuppilerid.Text) + 1
            dr.Close()
            cn.Close()
            txtsuppilerid.Enabled = False
            'txtsuppliername.Text = ""


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub
    Private Sub cboid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboid.SelectedIndexChanged
        Try
            Dim cmd As New SqlCommand("select * from Supplier where supplier_id='" & cboid.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                'txtsuppilerid.Text = dr.GetString(0)
                txtsuppliername.Text = dr.GetString(1)
            End While
            dr.Close()
            cn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Try
            cn.Open()
            Dim da As New SqlDataAdapter("select * from Supplier", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Supplier")
            dgvsuppiler.DataSource = ds.Tables(0)
            cn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Supplier where supplier_id='" & cboid.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtsuppilerid.Text = ""
            txtsuppliername.Text = ""
            Dim da As New SqlDataAdapter("select * from Supplier", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Supplier")
            dgvsuppiler.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class