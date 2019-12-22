Public Class fSearchCheckIn
    Dim Li As ListViewItem
    Private Sub fSearchCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        DTCheckIn.Enabled = False
        ChkCustName.Checked = True
        txtCustName.Focus()
        DTCheckIn.Enabled = False
        btnCheckOut.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub ChkCustName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCustName.CheckedChanged
        If ChkCustName.Checked = True Then
            txtCustName.Enabled = True
            txtCustName.Focus()
        Else
            txtCustName.Enabled = False
        End If
    End Sub

    Private Sub ChkCheckIn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCheckIn.CheckedChanged
        If ChkCheckIn.Checked = True Then
            DTCheckIn.Enabled = True
        Else
            DTCheckIn.Enabled = False
        End If
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        lstCheckIn.Items.Clear()
        Com.CommandText = "Select * from QCheckIn"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(lstCheckIn, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd," & _
            "yyyy"), Dr(8), Format(Dr(7), "dddd, MMMM dd,yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Curren" & _
            "cy"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "currency"))
        Loop
        Dr.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        lstCheckIn.Items.Clear()
        If ChkCustName.Checked = True And ChkCheckIn.Checked = True Then
            SQLSearch("CusName='" & txtCustName.Text & "' and CheckInDate=#" & CDate(DTCheckIn.Text) & "#")
        ElseIf ChkCustName.Checked = True Then
            SQLSearch("CusName='" & txtCustName.Text & "'")
        ElseIf ChkCheckIn.Checked = True Then
            SQLSearch("CheckInDate=#" & CDate(DTCheckIn.Text) & "#")
        Else
            Message("Choose One Option.")
        End If
        btnCheckOut.Enabled = False
        btnEdit.Enabled = False
    End Sub


    Sub SQLSearch(ByVal Str As String)
        Dim L As Boolean = False
        Com.CommandText = "Select * from QCheckIn where " & Str
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(lstCheckIn, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd, yyyy"), Dr(8), Format(Dr(7), "dddd, MMMM dd, yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Currency"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "Currency"))
            L = True
        Loop
        If L = False Then
            Message("Record Was Not Found.")
        End If
        Dr.Close()
    End Sub

    Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEdit.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstCheckIn.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Com.CommandText = "Select CheckInNo from tblCheckIn where CusID='" & Li.Text & "'"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            BID = Dr(0)
        End If
        Dr.Close()

        Me.Close()
        ShowForm(fEditCheckIn, Main)
        With fEditCheckIn
            .txtCusID.Text = Li.Text
            .cboCusName.Text = Li.SubItems(1).Text
            .txtGender.Text = Li.SubItems(2).Text
            .txtAddress.Text = Li.SubItems(3).Text
            .txtPassNo.Text = Li.SubItems(4).Text
            .txtCardNo.Text = Li.SubItems(5).Text
            .DTCheckIn.Text = Li.SubItems(6).Text
            '.DTBooking.Text = Li.SubItems(6).Text
            .txtStaying.Text = Li.SubItems(7).Text
            .cboRType.Text = Li.SubItems(9).Text
            .cboRNum.Text = Li.SubItems(10).Text
            .txtFloor.Text = Li.SubItems(11).Text
            .txtAmount.Text = Li.SubItems(12).Text
            .txtPrepaid.Text = Li.SubItems(14).Text
        End With
    End Sub

    Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDelete.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstCheckIn.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Dim Mess As String
        Mess = MsgBox("Do you want to Delete this Record.", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Hotel Management System")
        If Mess = vbOK Then
            Com.CommandText = "Delete from tblCheckIn where CusID='" & Li.Text & "'"
            Com.ExecuteNonQuery()
            Message("Success.")
            lstCheckIn.Items.Remove(Li)
        End If
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutToolStripMenuItem.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstCheckIn.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Me.Close()
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

    Private Sub btnCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckOut.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstCheckIn.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Me.Close()
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim Sl As ListView.SelectedListViewItemCollection = lstCheckIn.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Com.CommandText = "Select CheckInNo from tblCheckIn where CusID='" & Li.Text & "'"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            BID = Dr(0)
        End If
        Dr.Close()

        Me.Close()
        ShowForm(fEditCheckIn, Main)
        With fEditCheckIn
            .txtCusID.Text = Li.Text
            .cboCusName.Text = Li.SubItems(1).Text
            .txtGender.Text = Li.SubItems(2).Text
            .txtAddress.Text = Li.SubItems(3).Text
            .txtPassNo.Text = Li.SubItems(4).Text
            .txtCardNo.Text = Li.SubItems(5).Text
            .DTCheckIn.Text = Li.SubItems(6).Text
            '.DTBooking.Text = Li.SubItems(6).Text
            .txtStaying.Text = Li.SubItems(7).Text
            .cboRType.Text = Li.SubItems(9).Text
            .cboRNum.Text = Li.SubItems(10).Text
            .txtFloor.Text = Li.SubItems(11).Text
            .txtAmount.Text = Li.SubItems(12).Text
            .txtPrepaid.Text = Li.SubItems(14).Text
        End With
    End Sub

    Private Sub lstCheckIn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCheckIn.SelectedIndexChanged
        btnCheckOut.Enabled = True
        btnEdit.Enabled = True
    End Sub
End Class