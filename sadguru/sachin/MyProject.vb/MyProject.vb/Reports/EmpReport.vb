Public Class EmpReport

    Private Sub EmpReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt = New EmpReport1  'this is our report name
        con.Open()

        Dim da As New SqlClient.SqlDataAdapter("SELECT Empid,Empname,Phno,Address,EMail,Gender,Birthdate,Designation,Joindate,Salary " & _
                                             " FROM EmployeeInfo ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        rpt.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
        con.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class