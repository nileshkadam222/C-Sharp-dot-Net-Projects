Public Class frmAboutSoft
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmMain
        f.Show()
        Me.Hide()
    End Sub

    Private Sub frmAboutSoft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class