Imports System.Data
Imports System.Data.SqlClient
Module source
    Public con As SqlConnection = New SqlConnection("Data Source=USER-PC\SQLEXPRESS08;Initial Catalog=Softlab Education;Integrated Security=True")
    Public cmd As New SqlCommand
    'Public str As String
    Public adp1, adp2, adp3 As New SqlDataAdapter
    Public ds1, ds2, ds3 As New DataSet
    Public da As New SqlDataAdapter
    Public str1 As String
    Public dt, dt1, dt2 As New DataTable
    Public ds As New DataSet
    Public dv As New DataView
    Public dr As SqlDataReader
    Public i As Integer
    Public report As String
    Public connectionString As String = "Data Source=USER-PC\SQLEXPRESS08;Initial Catalog=Softlab Education;Integrated Security=True"
    Public str As String = "Data Source=USER-PC\SQLEXPRESS08;Initial Catalog=Softlab Education;Integrated Security=True"

End Module
