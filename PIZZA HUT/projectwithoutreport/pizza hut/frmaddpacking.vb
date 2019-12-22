Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmadd
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmdsave As New SqlCommand("insert into add_packing_materials values('" & txtmaterial.Text & "','" & txtunit.Text & "')", cn)
            cn.Open()
            cmdsave.ExecuteNonQuery()
            MsgBox("Records are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveiwall.Click
        Try
            Dim da As New SqlDataAdapter("select * from add_packing_materials", cn)
            Dim ds As New DataSet
            da.Fill(ds, "add_packing_materials")
            DataGridView1.DataSource = ds.Tables(0)

         Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        
    End Sub
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub


    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim cmd As New SqlDataAdapter("select * from add_packing_materials where Material_Name='" & txtsearch.Text & "'", cn)
        Dim ds1 As New DataSet
        cmd.Fill(ds1, "add_packing_materials")
        DataGridView1.DataSource = ds1.Tables("add_packing_materials")
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub
End Class