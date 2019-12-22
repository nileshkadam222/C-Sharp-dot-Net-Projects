Public Class Main

    Private Sub RegistrationdetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationdetailsToolStripMenuItem.Click
        Registration_details.Show()
    End Sub

    Private Sub AddmissiondetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddmissiondetailsToolStripMenuItem.Click
        addmission_details.Show()
    End Sub

    Private Sub FacultydetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultydetailsToolStripMenuItem.Click
        Faculty_details.Show()
    End Sub

    Private Sub BatchdetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchdetailsToolStripMenuItem.Click
        batch_details.Show()
    End Sub

    Private Sub ResultdetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultdetailsToolStripMenuItem.Click
        Result_details.Show()
    End Sub

    Private Sub InstallmentdetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallmentdetailsToolStripMenuItem.Click
        Installment_details.Show()
    End Sub

    Private Sub ReceiptdetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptdetailsToolStripMenuItem.Click
        Receipt_details.Show()
    End Sub

    Private Sub SearchbyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchbyToolStripMenuItem.Click
        Search_By.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Shell("notepad.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ArrangeScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrangeScheduleToolStripMenuItem.Click
        arrenge_shedule.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutuToolStripMenuItem.Click
        Aboutus.Show()
    End Sub

    Private Sub BatchReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchReportToolStripMenuItem.Click
        batrpt.Show()

    End Sub

    Private Sub ResultReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultReportToolStripMenuItem.Click
        resultrpt.Show()
    End Sub

    Private Sub ReceiptReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptReportToolStripMenuItem.Click
        receiptrpt.Show()
    End Sub
End Class