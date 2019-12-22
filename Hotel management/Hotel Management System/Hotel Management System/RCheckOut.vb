Imports System.Data.OleDb
Public Class RCheckOut
    Dim Da As New OleDbDataAdapter
    Dim Dt As New DataTable
    Dim Report As New RptCheckOut

    Private Sub RCheckOut_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cnn.Close()
    End Sub

    Private Sub RCheckOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        If fRptCheckOut.OptToday.Checked = True Then
            Com.CommandText = "Select * from QCheckOut where CheckOutDate=#" & fRptCheckOut.txtToday.Text & "# "
            Da.SelectCommand = Com
            Da.Fill(Dt)
            Report.SetDataSource(Dt)
            CRV.ReportSource = Report
            CRV.Show()
        Else
            Com.CommandText = "Select * from QCheckOut where CheckOutDate between #" & fRptCheckOut.DTFrom.Text & "#  and #" & fRptCheckOut.DTto.Text & "#"
            Da.SelectCommand = Com
            Da.Fill(Dt)
            Report.SetDataSource(Dt)
            CRV.ReportSource = Report
            CRV.Show()
        End If
    End Sub
End Class