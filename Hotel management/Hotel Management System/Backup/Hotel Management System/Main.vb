Public Class Main

    Private Sub ViewAllRoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllRoomToolStripMenuItem1.Click
        ShowForm(fViewRoom, Me)
    End Sub


    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        fLogIn.Close()
        SplashScreen.Close()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        OpenConnect()
        TUser.Text = "User Name"
        TDate.Text = Format(Now, "dd-MMM-yyyy HH:MM:ss")
        Timer1.Enabled = True
        Timer1.Interval = 1000
        'fUser.ShowDialog()
        fLogIn.ShowDialog()
    End Sub

    Private Sub CheckInToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem3.Click
        CheckInMenu()
    End Sub

    Private Sub BookingToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem3.Click
        BookingMenu()
    End Sub

    Private Sub CheckOutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutToolStripMenuItem2.Click
        ShowForm(fCheckOut, Me)
    End Sub

    Private Sub CheckInToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem4.Click
        ShowForm(fSearchCheckIn, Me)
    End Sub

    Private Sub BookingToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem4.Click
        ShowForm(fSearchBooking, Me)
    End Sub

    Private Sub CustomerInformationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerInformationToolStripMenuItem1.Click
        ShowForm(Form1, Me)
    End Sub

    Private Sub SetRoomPriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetRoomPriceToolStripMenuItem.Click
        ShowForm(Form3, Me)
    End Sub

    Private Sub RoomInformationToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomInformationToolStripMenuItem2.Click
        ShowForm(frmRoom, Me)
    End Sub

    Private Sub SetUpUserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetUpUserToolStripMenuItem1.Click
        ShowForm(fUser, Me)
    End Sub

    Private Sub ChangeUserNamePasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeUserNamePasswordToolStripMenuItem1.Click
        ShowForm(fChangeUser, Me)
    End Sub

    Private Sub CheckInToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem5.Click
        fRptBooking.Close()
        fRptCheckOut.Close()
        ShowForm(fRptCheckIn, Me)
    End Sub

    Private Sub BookingToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem5.Click
        fRptCheckIn.Close()
        fRptCheckOut.Close()
        ShowForm(fRptBooking, Me)
    End Sub

    Private Sub CheckOutToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutToolStripMenuItem3.Click
        fRptBooking.Close()
        fRptCheckIn.Close()
        ShowForm(fRptCheckOut, Me)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CheckInToolStripMenuItem3_Click(sender, e)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        BookingToolStripMenuItem3_Click(sender, e)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        CheckOutToolStripMenuItem2_Click(sender, e)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        ViewAllRoomToolStripMenuItem1_Click(sender, e)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        SetUpUserToolStripMenuItem1_Click(sender, e)
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click

        fLogIn.txtUserName.Clear()
        fLogIn.txtPassword.Clear()
        fLogIn.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        ExitToolStripMenuItem1_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim Mess As String
        Mess = MsgBox("Do you want to Exit?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Hotel Management System")
        If Mess = vbOK Then
            End
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TDate.Text = Format(Now, "dd-MMM-yyyy HH:MM:ss")
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        ToolStripButton6_Click(sender, e)
    End Sub
End Class