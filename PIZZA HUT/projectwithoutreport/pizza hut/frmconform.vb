Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmconform


    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            Dim cmd As New SqlCommand("update login_id set passward='" & txtconform.Text & "' where Username='" & txtname.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Password Updated Successfully...!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "UPDATE")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancle.Click
        End
    End Sub

   
End Class