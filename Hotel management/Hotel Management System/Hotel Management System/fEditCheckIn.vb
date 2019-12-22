Imports System.Data.OleDb
Public Class fEditCheckIn

    Sub Clearcus()
        cboCusName.Text = ""
        txtCusID.Clear()
        txtGender.Clear()
        txtAddress.Clear()
        txtPassNo.Clear()
        txtCardNo.Clear()
    End Sub

    Private Sub fEditCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        LoadRoomType(cboRType)
        DTCheckIn.Enabled = False
    End Sub

    Private Sub btnSCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCustomer.Click
        SCustomer(cboCusName, txtCusID, txtGender, txtAddress, txtPassNo, txtCardNo)
    End Sub

    Private Sub cboCusName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCusName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSCustomer_Click(sender, e)
        End If
    End Sub

    Private Sub txtStaying_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStaying.KeyPress
        onlyInteger(e)
    End Sub

    Private Sub txtStaying_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaying.TextChanged
        txtCheckOut.Text = Format(DateAdd(DateInterval.Day, Val(txtStaying.Text), CDate(DTCheckIn.Text)), "dddd, MMMM dd, yyyy")
        txtTotal.Text = Val(txtStaying.Text) * Format(txtAmount.Text, "currency")
        txtTotal.Text = Format(txtTotal.Text, "Currency")
    End Sub

    Private Sub cboRType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRType.SelectedIndexChanged
        LoadRoomNum(cboRNum, cboRType, txtAmount, txtFloor, txtStaying, txtTotal)
    End Sub

    Private Sub cboRNum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRNum.SelectedIndexChanged
        LoadFloor(cboRNum, txtFloor)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtPrepaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrepaid.KeyPress
        onlyInteger(e)
    End Sub

    Private Sub txtPrepaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrepaid.LostFocus
        PrepaidLostFocus(txtPrepaid, txtTotal)
    End Sub

    Private Sub txtPrepaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrepaid.TextChanged
        If txtPrepaid.Text <> "" Then
            txtRemain.Text = Format(txtTotal.Text, "Currency") - Format(txtPrepaid.Text, "Currency")
            txtRemain.Text = Format(txtRemain.Text, "Currency")
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cboCusName.Text = "" Then
            Message("Choose one Customer to Booking.")
            cboCusName.Focus()
        ElseIf txtStaying.Text = "" Then
            Message("Complete Number of Staying.")
            txtStaying.Focus()
        ElseIf cboRNum.Text = "" Then
            Message("Choose One Room Number.")
            cboRNum.Focus()
        ElseIf txtPrepaid.Text = "" Then
            Message("Complete Prepaid.")
            txtPrepaid.Focus()
        Else
            Com.CommandText = "Update TblCheckIn set CheckInDate=?,CheckOutDate=?,CusID=?," & _
            "RoomNo=?,Prepaid=? where CheckInNo=?"
            With Com.Parameters
                .Add("@DIn", OleDbType.Date).Value = DTCheckIn.Text
                .Add("@DOut", OleDbType.Date).Value = txtCheckOut.Text
                .Add("@CID", OleDbType.VarChar).Value = txtCusID.Text
                .Add("@RNo", OleDbType.Integer).Value = cboRNum.Text
                .Add("@Prepaid", OleDbType.Currency).Value = txtPrepaid.Text
                .Add("@ID", OleDbType.Integer).Value = BID
            End With
            Com.ExecuteNonQuery()
            Com.Parameters.Clear()
            Message("Success.")
            Clearcus()
            txtStaying.Clear()
            txtAmount.Clear()
            txtTotal.Clear()
            txtPrepaid.Clear()
            txtRemain.Clear()
            cboCusName.Focus()
        End If
    End Sub

    Private Sub DTCheckIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTCheckIn.ValueChanged
        txtStaying_TextChanged(sender, e)
    End Sub

    Private Sub cboCusName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCusName.TextChanged
        If cboCusName.Text = "" Then
            Clearcus()
        End If
    End Sub
End Class