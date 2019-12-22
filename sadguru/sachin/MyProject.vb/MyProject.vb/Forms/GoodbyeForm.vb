Public Class GoodbyeForm

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value <= 100) Then
            ProgressBar1.Value = ProgressBar1.Value + 5
            Label2.Text = ProgressBar1.Value & "%"
        End If
        If (ProgressBar1.Value = 100) Then
            Timer1.Enabled = False
            Me.Close()
            MDIForm.Close()
            SplashScreenForm.Close()

        End If

    End Sub

    Private Sub GoodbyeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class