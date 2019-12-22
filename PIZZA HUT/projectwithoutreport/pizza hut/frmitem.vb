Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmitem
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim cmd As New SqlCommand("insert into Price_List_Item_Entry values( '" & cboprodid.Text & " ','" & txtname.Text & "','" & txtunit.Text & "','" & txtprice.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        cn.Close()
    End Sub


    Private Sub cboprodname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboprodid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from Price_List_Item_Entry where prod_id='" & cboprodid.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtname.Text = dr.GetString(0)
            txtunit.Text = dr.GetString(2)
            txtprice.Text = dr.GetString(3)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub frmitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from Price_List_Item_Entry", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboprodid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        cn.Close()
    End Sub
    Private Sub Btnveiwall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveiwall.Click
        Try

            Dim da As New SqlDataAdapter("select * from Price_List_Item_Entry", cn)
            cn.Open()
            Dim ds As New DataSet
            da.Fill(ds, "Price_List_Item_Entry")
            datagridview.DataSource = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        
    End Sub
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Price_List_Item_Entry where Prod_id='" & cboprodid.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtname.Text = ""
            txtunit.Text = ""
            txtprice.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim cmd1 As New SqlCommand("update Price_List_Item_Entry set Name='" & txtname.Text & "',unit='" & txtunit.Text & "',price='" & txtprice.Text & "' where prod_id='" & cboprodid.Text & "'", cn)
        cn.Open()
        cmd1.ExecuteNonQuery()
        MsgBox("record is updated")
        cn.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click, btnadd.Click
        Dim rec As New SqlCommand("select * from Price_List_Item_Entry", cn)
        cn.Open()
        Dim dr As SqlDataReader = rec.ExecuteReader
        While dr.Read
            txtprodid.Text = dr(0)
        End While
        txtprodid.Text = "00" & Val(txtprodid.Text) + 1
        dr.Close()
        cn.Close()
        txtprodid.Enabled = False
    End Sub

   
   
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub
End Class


