Imports System.Data.OleDb
Public Class RCheckIn
    Dim Da As New OleDbDataAdapter
    Dim Dt As New DataTable
    Dim Report As New RptCheckIn

    Private Sub RCheckIn_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cnn.Close()
    End Sub

    Private Sub RCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        If fRptCheckIn.OptToday.Checked = True Then
            Com.CommandText = "Select * from QCheckin where CheckInDate=#" & CDate(fRptCheckIn.txtToday.Text) & "#"
            Da.SelectCommand = Com
            Da.Fill(Dt)
            Report.SetDataSource(Dt)
            CRV.ReportSource = Report
            CRV.Show()
        Else
            Com.CommandText = "Select * from QCheckin where CheckInDate Between #" & fRptCheckIn.DTFrom.Text & "# and #" & fRptCheckIn.DTto.Text & "#"
            Da.SelectCommand = Com
            Da.Fill(Dt)
            Report.SetDataSource(Dt)
            CRV.ReportSource = Report
            CRV.Show()
        End If
    End Sub
End Class