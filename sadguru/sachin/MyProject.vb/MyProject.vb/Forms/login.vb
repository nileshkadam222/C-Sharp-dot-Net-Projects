Imports System.Data
Imports System.Data.SqlClient
Public Class Loginform

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str2 As String
        Dim str3 As String
        str2 = TextBox1.Text
        str3 = TextBox2.Text
        Dim con As New SqlConnection("Data Source=ANONYMOUS\SQLEXPRESS;Initial Catalog=sachin;Integrated Security=True")
        con.Open()
        Dim cmd2 As New SqlCommand("select * from Login_Table", con)
        Dim reader As SqlDataReader
        reader = cmd2.ExecuteReader
        While reader.Read
            Dim login_name As String
            Dim pas As String
            login_name = reader(0)
            pas = reader(1)
            Dim i As Integer
            Dim j As Integer

            If (i = String.Compare(login_name, str2)) And (j = String.Compare(pas, str3)) Then
                Me.Close()
                MDIForm.Show()
            Else
                MsgBox("Login Unsuccess")
            End If
        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FontDialog1_Apply(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class