Public Class fExpire
    Dim Li As ListViewItem
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Pic2.Visible = Not Pic2.Visible
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim L As Boolean = False
        Dim L1 As Boolean = False
        Dr.Close()
        lstCheckInExpire.Items.Clear()
        Com.CommandText = "Select * from QCheckIn where CheckOutDate<=#" & DateAdd(DateInterval.Day, 1, Today) & "#"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(lstCheckInExpire, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd," & _
            "yyyy"), Dr(8), Format(Dr(7), "dddd, MMMM dd,yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Curren" & _
            "cy"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "currency"))
            L = True
        Loop
        Dr.Close()

        'Load Data For Booking Expire
        lstBookingExpire.Items.Clear()
        Com.CommandText = "Select * from QBooking where CheckInDate<=#" & DateAdd(DateInterval.Day, 1, Today) & "#"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(lstBookingExpire, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd,yyy" & _
            "y"), Dr(7), Format(Dr(8), "dddd, MMMM dd,yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Currenc" & _
            "y"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "currency"))
            L1 = True
        Loop
        Dr.Close()

        If L = True Or L1 = True Then
            ShowForm(Me, Main)
        End If
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        Timer2.Enabled = True
        Timer2.Interval = 100000
        Me.Hide()
    End Sub

    Private Sub fExpire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = False
    End Sub

    Private Sub CheckInToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem1.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstCheckInExpire.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Me.Hide()
        Timer2.Enabled = True
        Timer2.Interval = 100000
        ShowForm(fCheckOut, Main)
        With fCheckOut
            .txtCusID.Text = Li.Text
            .txtCusName.Text = Li.SubItems(1).Text
            .txtGender.Text = Li.SubItems(2).Text
            .txtAddress.Text = Li.SubItems(3).Text
            .txtPassNo.Text = Li.SubItems(4).Text
            .txtCardNo.Text = Li.SubItems(5).Text
            .txtCheckIn.Text = Li.SubItems(6).Text
            .txtCheckOut.Text = Format(Now, "dddd, MMMM dd,yyyy")
            .txtStaying.Text = Li.SubItems(7).Text
            .txtRType.Text = Li.SubItems(9).Text
            .txtRNum.Text = Li.SubItems(10).Text
            .txtFloor.Text = Li.SubItems(11).Text
            .txtAmount.Text = Li.SubItems(12).Text
            .txtTotal.Text = Li.SubItems(13).Text
            .txtPrepaid.Text = Li.SubItems(14).Text
        End With
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstBookingExpire.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Com.CommandText = "Select ID from tblBooking where CusID='" & Li.Text & "'"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            BID = Dr(0)
        End If
        Dr.Close()
        i = 1
        Me.Hide()
        Timer2.Enabled = True
        Timer2.Interval = 100000
        'frmCheckIn.Show()
        ShowForm(frmCheckIn, Main)
        frmCheckIn.btnBooking.Enabled = False
        frmCheckIn.DTCheckIn.SendToBack()
        With frmCheckIn
            .txtCusID.Text = Li.Text
            .cboCusName.Text = Li.SubItems(1).Text
            .txtGender.Text = Li.SubItems(2).Text
            .txtAddress.Text = Li.SubItems(3).Text
            .txtPassNo.Text = Li.SubItems(4).Text
            .txtCardNo.Text = Li.SubItems(5).Text
            .txtCheckIn.Text = Li.SubItems(8).Text
            .txtStaying.Text = Li.SubItems(7).Text
            .cboRType.Text = Li.SubItems(9).Text
            .cboRNum.Text = Li.SubItems(10).Text
            .txtFloor.Text = Li.SubItems(11).Text
            .txtAmount.Text = Li.SubItems(12).Text
            .txtPrepaid.Text = Li.SubItems(14).Text
        End With
    End Sub
End Class