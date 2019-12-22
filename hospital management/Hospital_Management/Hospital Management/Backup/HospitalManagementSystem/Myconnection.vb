Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Myconnection
    Public constr As String
    Public con As SqlConnection
    'public serverName as static string
    Public Sub connection()
        ' Dim FILE_NAME As String = "C:\time.txt"
        'Dim myFile As New System.IO.StreamReader("c:\\cont")
        'Dim str1 As String = myFile.ReadToEnd()
        'Dim str As String() = str1.Split(New Char() {";"})

        'myFile.Close()
        'constr = "Data Source=" + str1 + ";Initial Catalog=HospitalManagement;Integrated Security=True"
        'constr = "Data Source=" + Str(0) + ";Initial Catalog=HospitalManagement;uid=" + Str(1) + ";pwd=" + Str(2)
        constr = "Data Source=.\SQLExpress;AttachDBFilename=|DataDirectory|HospitalManagement.mdf;integrated security=true;"
    End Sub

End Module
