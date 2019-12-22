Public Class SplashScreen1
    Inherits System.Windows.Forms.Form
    Dim i As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PictureBox1.Width >= 520 Then
            Timer1.Stop()

            PictureBox1.Width = "15"
            Dim LoginObj As Login = New Login
            LoginObj.Show()
            Me.Dispose(False)
        End If
        If (PictureBox1.Width < 100) Then
            Label1.Text = "Loading."
        End If
        If (PictureBox1.Width > 100 And PictureBox1.Width < 200) Then
            Label1.Text = "Loading Details..."
        End If
        If (PictureBox1.Width > 200 And PictureBox1.Width < 300) Then
            Label1.Text = "Loading database...."
        End If
        If (PictureBox1.Width > 300 And PictureBox1.Width < 400) Then
            Label1.Text = "Loading reports....."
        End If
        If (PictureBox1.Width > 400 And PictureBox1.Width < 500) Then
            Label1.Text = "Loading forms......."
        End If
        PictureBox1.Width = PictureBox1.Width + 15
    End Sub



    Private Sub SplashScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 80
        Timer1.Enabled = True
        Label1.Visible = True
    End Sub
End Class
