Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmlogin


    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmdid As New SqlCommand("select * from Logintable", cn)
            cn.Open()
            Dim drid As SqlDataReader = cmdid.ExecuteReader
            While drid.Read
                cbouserid.Items.Add(drid.GetString(0))
            End While
            drid.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cbouserid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbouserid.SelectedIndexChanged
        Try
            Dim cmdfill As New SqlCommand("select * from Logintable where User_id='" & cbouserid.Text & "'", cn)
            cn.Open()
            Dim drfill As SqlDataReader = cmdfill.ExecuteReader
            While drfill.Read
                txtdepartment.Text = drfill.GetString(2)
                txtdesignation.Text = drfill.GetString(3)
            End While
            drfill.Close()
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
            Dim cmdok As New SqlCommand("select * from Logintable where User_id='" & cbouserid.Text & "' and Password='" & txtpassword.Text & "'", cn)
            cn.Open()
            Dim drok As SqlDataReader = cmdok.ExecuteReader
            If drok.Read Then
                Me.Hide()
                MsgBox("Login Succeded....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "WELCOME")
                MDIParent1.Show()
            Else
                MsgBox("ACCESS DENIED", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                txtpassword.Text = ""
                txtpassword.Focus()
            End If
            drok.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub
End Class