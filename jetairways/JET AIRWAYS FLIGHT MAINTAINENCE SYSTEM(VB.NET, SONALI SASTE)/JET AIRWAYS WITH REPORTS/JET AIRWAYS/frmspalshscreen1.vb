Public Class frmsplashscreen1




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If pb1.Value <> 100 Then
        '    pb1.Value = pb1.Value + 2
        'End If
        'If pb1.Value = 100 Then

        '    Me.Hide()
        '    frmsplashscreen2.Show()
        'End If

    End Sub

    Private Sub frmsplashscreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fsplsh2 As New frmsplashscreen2()
        fsplsh2.Show()
        Me.Hide()
    End Sub
End Class
