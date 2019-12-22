Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frminventorydetails
    Private Sub optpurchesed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optpurchased.CheckedChanged
        btnpurchased.Text = "purchesed"
    End Sub

    Private Sub optreleaseditem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optreleaseditem.CheckedChanged
        btnpurchased.Text = "Relesed Item"
    End Sub

    Private Sub optdamageitem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optdamageitem.CheckedChanged
        btnpurchased.Text = "Deleted Item"
    End Sub

    Private Sub btnpurchased_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpurchased.Click
        If btnpurchased.Text = "purchesed" Then
            frmpurchesitem.Show()
        ElseIf btnpurchased.Text = "Relesed Item" Then
            frmreleseditem.Show()
        ElseIf btnpurchased.Text = "Deleted Item" Then
            frmdamageitem.Show()
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End
    End Sub
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMDIParent.Show()
    End Sub
End Class