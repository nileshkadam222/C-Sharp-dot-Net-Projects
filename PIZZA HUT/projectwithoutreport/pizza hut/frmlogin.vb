Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmlogin

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim btnok As New SqlCommand("select * from Login where Name='" & txtname.Text & "' and Password='" & txtpass.Text & "'", cn)
        cn.Open()
        Dim drok As SqlDataReader = btnok.ExecuteReader
        If drok.Read Then
            MsgBox("Login Successfull....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "WELCOME ")
            Me.Hide()
            frmMdiParent.Show()
            frmMdiParent.Text = txtname.Text
        Else
            MsgBox("Pls Check Username or Password", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ACCESS DENIED")
            txtname.Text = ""
            txtpass.Text = ""
        End If
        drok.Close()
        cn.Close()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        End
    End Sub
End Class