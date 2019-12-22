Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmsearchflightentry
    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Try
            Dim am As New SqlDataAdapter("select * from Flightschedule where Flight_date='" & txtdate.Text & "'", cn)
            Dim dr As New DataSet
            am.Fill(dr, "Flightschedule")
            DataGridView1.DataSource = dr.Tables(0)
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
End Class