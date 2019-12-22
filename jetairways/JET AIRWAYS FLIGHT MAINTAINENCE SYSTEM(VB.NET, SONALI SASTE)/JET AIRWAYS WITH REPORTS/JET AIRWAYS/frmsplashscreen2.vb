Public Class frmsplashscreen2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If pb1.Value <> 100 Then
        '    pb1.Value = pb1.Value + 2
        'End If
        'If pb1.Value = 100 Then
        '    Me.Hide()
        '    frmlogin.Show()
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim flogin As New frmlogin()
        flogin.Show()
        Me.Hide()
    End Sub
End Class