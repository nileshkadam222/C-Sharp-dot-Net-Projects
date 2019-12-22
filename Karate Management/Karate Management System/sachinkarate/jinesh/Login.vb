
Public Class Login
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As OleDb.OleDbConnection
        Dim cmd As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim c2 As New projClass1
        cn = New OleDb.OleDbConnection(c2.connect)
        Try
            cn.Open()
        Catch a As Exception
            MsgBox(a.Message)
        End Try
        cmd = New OleDb.OleDbCommand("select username,password from login where username='" & txtusername.Text & "' AND password='" & txtpassword.Text & "'", cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            Mainform.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Login")
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        End If
        dr.Close()
        cn.Close()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
