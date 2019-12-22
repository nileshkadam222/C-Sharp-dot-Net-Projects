Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmselectcategory

    Private Sub cbocayegory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocayegory.SelectedIndexChanged
      
    End Sub


    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        cn.Open()
        Dim da As New SqlDataAdapter("select * from Meat_Lovers", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Meat_Lovers")
        DataGridView1.DataSource = ds.Tables(0)
        cn.Close()
    End Sub

    Private Sub cmddamageitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddamageitem.Click

    End Sub
End Class