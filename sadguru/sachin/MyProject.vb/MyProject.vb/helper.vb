Public Class helper
    Public Function AMD(ByVal str As String, ByVal msg As String)
        Try
            Dim con As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=ANONYMOUS\SQLEXPRESS;Initial Catalog=sachin;Integrated Security=True")
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(str, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

End Class
