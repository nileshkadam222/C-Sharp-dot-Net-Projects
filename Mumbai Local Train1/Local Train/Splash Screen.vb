Public Class frmsplashscreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pb.Value < 100 Then
            pb.Value = pb.Value + 2
            If pb.Value = 20 Then lblPleasewait.Visible = False
            If pb.Value = 40 Then lblPleasewait.Visible = True
            If pb.Value = 60 Then lblPleasewait.Visible = False
            If pb.Value = 80 Then lblPleasewait.Visible = True
        Else
            Timer1.Enabled = False
            frmlogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmsplashscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
