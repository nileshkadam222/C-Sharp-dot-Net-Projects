Public Class SplashScreenForm

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Enabled = False
        End If
        If (ProgressBar1.Step > 600) Then
            Timer1.Stop()
            ProgressBar1.Step = "10"
            Me.Dispose(False)
            Loginform.Show()
        End If
        If (ProgressBar1.Step < 200) Then
            lblload.Text = "Checking System.........."
        End If
        If (ProgressBar1.Step > 200 And ProgressBar1.Step < 300) Then
            lblload.Text = "Loding Database.........."
        End If
        If (ProgressBar1.Step > 300 And ProgressBar1.Step < 400) Then
            lblload.Text = "Copying System Files.........."
        End If
        If (ProgressBar1.Step > 400 And ProgressBar1.Step < 500) Then
            lblload.Text = "Checking Security System.........."
        End If
        If (ProgressBar1.Step > 500 And ProgressBar1.Step < 600) Then
            lblload.Text = "Starting System.........."
        End If

        ProgressBar1.Step = ProgressBar1.Step + 70

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub SplashScreenForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 500
        ProgressBar1.Step = 10
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Loginform.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

