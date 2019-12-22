Public Class Login_form

    Private Sub Login_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        count = 0
    End Sub
    Dim count As Integer

    
    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If (txtpass.Text = "" And txtu_name.Text = "") Then
            MessageBox.Show("Enter user and pasword")
        ElseIf (txtu_name.Text = "") Then
            MessageBox.Show("Enter user name")
        ElseIf (txtpass.Text = "") Then
            MessageBox.Show("Enter password")
        ElseIf (txtu_name.Text = "mahesh" And txtpass.Text = "mane") Then
            MessageBox.Show("Welcome! Have A Nice Day.")
            Me.Hide()
            Main.Show()
        Else
            MessageBox.Show("Invalid password")
        End If
        If (count = 3) Then
            MessageBox.Show("Your Chance Is Over")
            End
        End If
        count = count + 1

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub txtu_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtu_name.TextChanged

    End Sub
End Class