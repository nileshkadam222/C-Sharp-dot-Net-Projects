Module Validation
    Public b, c, d, d1, p, q, r As Integer
    Public n, m, s, ss, sss, Site_Ticket, Site_Pass As String
    Public ctr, ptr, i, j, a, ticketno, passno As Integer
    Public cn As New SqlClient.SqlConnection
    Public adp As New SqlClient.SqlDataAdapter
    Public cm As New SqlClient.SqlCommand()
    Public ds As New DataSet
    Public Sub Connection()
        s = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\visual stdio\Mumbai Local Train1\Local Train\Local Train_Data.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True"
        cn = New SqlClient.SqlConnection(s)
        cn.Open()
    End Sub
    Public Function onlyalphabet(ByVal keyascii As Char) As Char
        If Char.IsLetter(keyascii) Or keyascii = ChrW(8) Then
            Return keyascii
        Else
            keyascii = ChrW(0)
        End If
    End Function
    Public Function onlynumber(ByVal keyascii As Char) As Char
        If Char.IsNumber(keyascii) Or keyascii = ChrW(8) Then
            Return keyascii
        Else
            keyascii = ChrW(0)
        End If
    End Function
End Module
