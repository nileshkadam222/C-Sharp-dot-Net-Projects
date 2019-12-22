Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class searchveiwsold
    Private Sub btnvaluemeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvaluemeal.Click
        cn.Open()
        Dim da As New SqlDataAdapter("select * from value_meal", cn)
        Dim ds As New DataSet
        da.Fill(ds, "value_meal")
        DataGridView1.DataSource = ds.Tables(0)
        cn.Close()
    End Sub

    Private Sub btnextratopping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnextratopping.Click

        cn.Open()
        Dim da As New SqlDataAdapter("select * from Extra_topping_list", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Extra_topping_list")
        DataGridView1.DataSource = ds.Tables(0)
        cn.Close()
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        frmviewsold.Show()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub
End Class