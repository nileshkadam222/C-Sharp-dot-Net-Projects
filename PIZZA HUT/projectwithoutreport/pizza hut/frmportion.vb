Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmportion
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim cmdsave As New SqlCommand("insert into Portion values('" & cboingerdients.Text & "','" & txtunit.Text & "','" & cbosize.Text & "','" & txtqty.Text & "','" & txtremarks.Text & "')", cn)
        cn.Open()
        cmdsave.ExecuteNonQuery()
        MsgBox("RECORD SAVED", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SAVED")
        'Dim da As New SqlDataAdapter("select * from  Portion", cn)
        'Dim ds As New DataSet
        'da.Fill(ds, " Portion")
        'dgv.DataSource = ds.Tables(0)
    End Sub

    
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub

    
    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click

    End Sub
End Class