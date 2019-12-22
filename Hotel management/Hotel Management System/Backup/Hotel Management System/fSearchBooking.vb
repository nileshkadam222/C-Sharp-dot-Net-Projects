Public Class fSearchBooking
    Dim Li As ListViewItem
    'Public i As Int16
    Private Sub fSearchBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        ChkCustID.Checked = True
        DTBooking.Enabled = False
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        lstBooking.Items.Clear()
        Com.CommandText = "Select * from QBooking"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(lstBooking, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd,yyy" & _
            "y"), Dr(7), Format(Dr(8), "dddd, MMMM dd,yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Currenc" & _
            "y"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "currency"))
        Loop
        Dr.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        lstBooking.Items.Clear()
        If ChkCustID.Checked = True And ChkBooking.Checked = True Then
            SQLSearch("CusName='" & txtCustID.Text & "' and BookingDate=#" & CDate(DTBooking.Text) & "#")
        ElseIf ChkCustID.Checked = True Then
            SQLSearch("CusName='" & txtCustID.Text & "'")
        ElseIf ChkBooking.Checked = True Then
            SQLSearch("BookingDate=#" & CDate(DTBooking.Text) & "#")
        Else
            Message("Choose One Option.")
        End If
    End Sub

    Sub SQLSearch(ByVal Str As String)
        Dim L As Boolean = False
        Com.CommandText = "Select * from QBooking where " & Str
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(lstBooking, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd, yyyy"), Dr(7), Format(Dr(8), "dddd, MMMM dd, yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Currency"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "Currency"))
            L = True
        Loop
        If L = False Then
            Message("Record Was Not Found.")
        End If
        Dr.Close()
    End Sub

    Private Sub ChkCustID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCustID.CheckedChanged
        If ChkCustID.Checked = True Then
            txtCustID.Enabled = True
            txtCustID.Focus()
        Else
            txtCustID.Enabled = False
        End If
    End Sub

    Private Sub ChkBooking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBooking.CheckedChanged
        If ChkBooking.Checked = True Then
            DTBooking.Enabled = True
        Else
            DTBooking.Enabled = False
        End If
    End Sub


    Private Sub MCheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCheckIn.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstBooking.SelectedItems
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
        Me.Close()
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

    Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEdit.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstBooking.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Com.CommandText = "Select ID from tblBooking where CusID='" & Li.Text & "'"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            BID = Dr(0)
        End If
        Dr.Close()

        Me.Close()
        'fEditBooking.Show()
        ShowForm(fEditBooking, Main)
        With fEditBooking
            .txtCusID.Text = Li.Text
            .cboCusName.Text = Li.SubItems(1).Text
            .txtGender.Text = Li.SubItems(2).Text
            .txtAddress.Text = Li.SubItems(3).Text
            .txtPassNo.Text = Li.SubItems(4).Text
            .txtCardNo.Text = Li.SubItems(5).Text
            .DTBooking.Text = Li.SubItems(6).Text
            .txtStaying.Text = Li.SubItems(7).Text
            .DTCheckIn.Text = Li.SubItems(8).Text
            .cboRType.Text = Li.SubItems(9).Text
            .cboRNum.Text = Li.SubItems(10).Text
            .txtFloor.Text = Li.SubItems(11).Text
            .txtAmount.Text = Li.SubItems(12).Text
            .txtPrepaid.Text = Li.SubItems(14).Text
        End With
    End Sub

    Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDelete.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstBooking.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Dim Mess As String
        Mess = MsgBox("Do you want to Delete this Record.", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Hotel Management System")
        If Mess = vbOK Then
            Com.CommandText = "Delete from tblBooking where CusID='" & Li.Text & "'"
            Com.ExecuteNonQuery()
            Message("Success.")
            lstBooking.Items.Remove(Li)
        End If
    End Sub
End Class