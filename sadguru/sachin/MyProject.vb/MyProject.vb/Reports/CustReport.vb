Public Class CustReport

    Private Sub CustReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New CustReport1 'this is our report name
        
        con.Open()

        Dim da As New SqlClient.SqlDataAdapter("SELECT Custid,Custname,Phno,Address,Pincode,Gender,EMail " & _
                                             " FROM CustomerInfo ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        rpt.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
        con.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class