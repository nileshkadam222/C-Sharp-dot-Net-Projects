Public Class BillReport

    Private Sub BillReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New BillReport1 'this is our report name
        
        con.Open()

        Dim da As New SqlClient.SqlDataAdapter("SELECT Bid,Name,Pid,Prdname,Date,Qty,Rate,Amt " & _
                                             " FROM BillInfo ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        rpt.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
        con.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class