Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub EditAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmeditattendance.Show()
    End Sub

    

    Private Sub FrmfuelmanagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmfuelmanagementToolStripMenuItem.Click
        frmfuelmanagement.Show()
        Me.Hide()

    End Sub

    Private Sub FrmaircraftdataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmaircraftdataToolStripMenuItem.Click
        frmaircraftdata.Show()
        Me.Hide()

    End Sub

    Private Sub FrmdespatchBriefingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmdespatchBriefingToolStripMenuItem.Click
        frmdispatchbriefing.Show()
        Me.Hide()

    End Sub

    Private Sub FrmflightscheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmflightscheduleToolStripMenuItem.Click
        frmflightshedule.Show()
        Me.Hide()

    End Sub

    Private Sub FrmsearchflightentryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmsearchflightentryToolStripMenuItem.Click
        frmsearchflightentry.Show()
        Me.Hide()

    End Sub

    Private Sub FrmdesignationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmdesignationToolStripMenuItem.Click
        frmdesignation.Show()
        Me.Hide()

    End Sub

    Private Sub FrmnewempentryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmnewempentryToolStripMenuItem.Click
        frmnewemployeeentry.Show()
        Me.Hide()

    End Sub

    Private Sub FrmnewuserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmnewuserToolStripMenuItem.Click
        frmnewuser.Show()
        Me.Hide()

    End Sub

    Private Sub FrmjetairwayseventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmjetairwayseventToolStripMenuItem.Click
        frmjetairwaysevents.Show()
        Me.Hide()

    End Sub

    Private Sub FrmweatherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmweatherToolStripMenuItem.Click
        frmweather.Show()
        Me.Hide()

    End Sub

    Private Sub FempaymentslipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FempaymentslipToolStripMenuItem.Click
        frmpaymentslip.Show()
        Me.Hide()

    End Sub

    
    Private Sub DispatchbriefingreportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchbriefingreportToolStripMenuItem.Click
        dispatchbriefing_report.Show()
        Me.Hide()

    End Sub

    Private Sub WeatherreportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeatherreportToolStripMenuItem.Click
        weather_report.Show()
        Me.Hide()


    End Sub

    Private Sub PayslipreportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayslipreportToolStripMenuItem.Click
        payslip_report.Show()
        Me.Hide()

    End Sub

    Private Sub FuelManagementreportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuelManagementreportToolStripMenuItem.Click
        fuelmanagement_report.Show()
        Me.Hide()

    End Sub

    

    Private Sub frmeditattendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmeditattendanceToolStripMenuItem.Click
        frmeditattendance.Show()
        Me.Hide()


    End Sub

    Private Sub FlightscedulereportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlightscedulereportToolStripMenuItem.Click
        flightscedule_report.Show()
        Me.Hide()

    End Sub
   

    
    Private Sub frmattendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmattendanceToolStripMenuItem.Click
        Me.Hide()
        frmattendance.Show()
    End Sub

    
End Class
