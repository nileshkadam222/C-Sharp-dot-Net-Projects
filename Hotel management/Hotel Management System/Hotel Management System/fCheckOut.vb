Imports System.Data.OleDb
Public Class fCheckOut

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'ShowForm(fOption, Main)
        fOption.ShowDialog()
    End Sub

    Private Sub btnCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckOut.Click
        If txtCusName.Text <> "" Then
            If CInt(txtTotal.Text) = CInt(txtPrepaid.Text) Then
                'Insert Data Into tblCheckOut
                Dim CheckID As Integer
                CheckID = Getid("tblCheckOut", "CheckOutNo")
                Com.CommandText = "Insert into tblCheckOut Values(?,?,?,?,?,?,?)"
                With Com.Parameters
                    .Add("@ChID", OleDbType.Integer).Value = CheckID
                    .Add("@DIn", OleDbType.Date).Value = txtCheckIn.Text
                    .Add("@DOut", OleDbType.Date).Value = txtCheckOut.Text
                    .Add("@CID", OleDbType.VarChar).Value = txtCusID.Text
                    .Add("@RNo", OleDbType.Integer).Value = txtRNum.Text
                    .Add("@Prepaid", OleDbType.Currency).Value = txtPrepaid.Text
                    .Add("@Staying", OleDbType.Integer).Value = txtStaying.Text
                End With
                Com.ExecuteNonQuery()
                Com.Parameters.Clear()
                Message("Success.")

                ' Delete Data from tblCheckIn
                Com.CommandText = "Delete from tblCheckIn where CusID='" & txtCusID.Text & "'"
                Com.ExecuteNonQuery()

                'Clear Value from Textbox
                ClearAll()
                btnSearch.Focus()
            Else
                Message("Customer's Payment is not in Balance." & vbCrLf & "Customer's Check Out Not Success." & vbCrLf & "Please Check Prepaid Again.")
                txtPrepaid.Focus()
                txtPrepaid.SelectAll()
            End If
        Else
            Message("Complete All Information to Check Out Customer.")
            btnSearch.Focus()
        End If
    End Sub

    Sub ClearAll()
        txtCusID.Clear()
        txtCusName.Clear()
        txtGender.Clear()
        txtAddress.Clear()
        txtPassNo.Clear()
        txtCardNo.Clear()
        txtCheckIn.Clear()
        txtStaying.Clear()
        txtCheckOut.Clear()
        txtRType.Clear()
        txtRNum.Clear()
        txtFloor.Clear()
        txtAmount.Clear()
        txtTotal.Clear()
        txtPrepaid.Clear()
        txtRemain.Clear()
    End Sub


    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
