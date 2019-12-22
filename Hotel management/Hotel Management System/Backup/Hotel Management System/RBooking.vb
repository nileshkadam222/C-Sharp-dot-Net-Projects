Imports System.Data.OleDb
Public Class RBooking
    Dim Da As New OleDbDataAdapter
    Dim Dt As New DataTable
    Dim Report As New RptBooking

    Private Sub RBooking_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cnn.Close()
    End Sub

    Private Sub RBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        If fRptBooking.OptToday.Checked = True Then
            Com.CommandText = "Select * from QBooking where BookingDate=#" & CDate(fRptBooking.txtToday.Text) & "#"
            Da.SelectCommand = Com
            Da.Fill(Dt)
            Report.SetDataSource(Dt)
            CRV.ReportSource = Report
            CRV.Show()
        Else
            Com.CommandText = "Select * from QBooking where BookingDate between #" & CDate(fRptBooking.DTFrom.Text) & "# and #" & CDate(fRptBooking.DTto.Text) & "#"
            Da.SelectCommand = Com
            Da.Fill(Dt)
            Report.SetDataSource(Dt)
            CRV.ReportSource = Report
            CRV.Show()
        End If
    End Sub
End Class