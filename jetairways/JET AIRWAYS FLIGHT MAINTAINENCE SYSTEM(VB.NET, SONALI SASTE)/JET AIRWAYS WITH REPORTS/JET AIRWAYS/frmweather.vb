Imports System.Data
Imports System.Data.SqlClient

Public Class frmweather

    Private Sub frmweather_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboflightno.Items.Add(dr.GetString(0))

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


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Try
            txtwind.Text = ""
            txtdewpoint.Text = ""
            txthumidity.Text = ""
            txtvisibility.Text = ""
            txtpressure.Text = ""
            txttype.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim sd As New SqlCommand("update DBrief set  Wind='" & txtwind.Text & "' ,Humidity='" & txthumidity.Text & "' , Pressure='" & txtpressure.Text & "' ,Dew ='" & txtdewpoint.Text & "' , Visibility='" & txtvisibility.Text & "' , Type='" & txttype.Text & "'  where Flight_no= '" & cboflightno.Text & "'", cn)
            cn.Open()
            sd.ExecuteNonQuery()

            MsgBox("Records are succeessfully Updated")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

   
    

    
End Class