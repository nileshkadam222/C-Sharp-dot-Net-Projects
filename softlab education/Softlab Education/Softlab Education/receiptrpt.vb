Imports System.Data.SqlClient
Public Class receiptrpt
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str, str1 As String
    'Dim adp1 As New SqlDataAdapter
    'Dim ds1 As New DataSet
    'Public report As String
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)
        str1 = "select * from Receipt_datails"
        cmd = New SqlCommand(str1, con)
        adp1 = New SqlDataAdapter(str1, con)
        adp1.Fill(ds1, "ds")
        Dim rpt As New rpt
        rpt.SetDataSource(ds1.Tables("ds"))
        CrystalReportViewer1.ReportSource = rpt
        con.Close()
    End Sub
End Class