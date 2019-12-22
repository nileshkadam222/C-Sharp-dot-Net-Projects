Public Class splashscreen
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <> 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 2
            Label2.Text = Val(ProgressBar1.Value) & "%"
        End If
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            frmlogin.Show()
        End If
    End Sub
End Class