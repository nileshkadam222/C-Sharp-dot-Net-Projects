Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class frmextratoppinglist

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Try
            cn.Open()
            Dim da As New SqlDataAdapter("select * from Extra_topping_list", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Extra_topping_list")
            gdvitemname.DataSource = ds.Tables(0)
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
            Dim cmd As New SqlCommand("Delete from Extra_topping_list where Exp_id='" & cboitem.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()


            Dim da As New SqlDataAdapter("select * from Extra_topping_list", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Extra_topping_list")
            gdvitemname.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            txtitemname.Text = ""
            Dim rec As New SqlCommand("select * from Extra_topping_list", cn)
            cn.Open()
            Dim dr As SqlDataReader = rec.ExecuteReader
            While dr.Read
                txtid.Text = dr(0)
            End While
            txtid.Text = "00" & Val(txtid.Text) + 1
            dr.Close()
            cn.Close()
            txtid.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub

   

    Private Sub cboitem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboitem.SelectedIndexChanged
        Try
            Dim cmd As New SqlCommand("select * from Extra_topping_list where Exp_id='" & cboitem.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                ' txtid.Text = dr.GetString(0)
                txtitemname.Text = dr.GetString(1)
                txtsize.Text = dr.GetString(2)
                txtprice.Text = dr.GetString(3)
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

    Private Sub frmextratoppinglist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from Extra_topping_list", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboitem.Items.Add(dr.GetString(0))
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

  
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into Extra_topping_list values( '" & cboitem.Text & " ','" & txtitemname.Text & "','" & txtsize.Text & "','" & txtprice.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            cn.Close()
            txtitemname.Text = ""
            txtsize.Text = ""
            txtprice.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub
End Class