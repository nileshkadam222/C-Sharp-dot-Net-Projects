Public Class SplashScreen

    
    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Visible = True
        Timer1.Interval = 500
        ProgressBar1.Step = 10
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Enabled = False
        End If
        If (ProgressBar1.Step > 600) Then
            Timer1.Stop()
            ProgressBar1.Step = "10"
            Me.Dispose(False)
            Login_form.Show()
        End If
        If (ProgressBar1.Step < 200) Then
            Label2.Text = "Checking System.........."
        End If
        If (ProgressBar1.Step > 200 And ProgressBar1.Step < 300) Then
            Label2.Text = "Loding Database.........."
        End If
        If (ProgressBar1.Step > 300 And ProgressBar1.Step < 400) Then
            Label2.Text = "Copying System Files.........."
        End If
        If (ProgressBar1.Step > 400 And ProgressBar1.Step < 500) Then
            Label2.Text = "Checking Security System.........."
        End If
        If (ProgressBar1.Step > 500 And ProgressBar1.Step < 600) Then
            Label2.Text = "Starting System.........."
        End If

        ProgressBar1.Step = ProgressBar1.Step + 70

    End Sub
End Class
