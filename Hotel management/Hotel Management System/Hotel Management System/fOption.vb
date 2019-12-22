Public Class fOption

    Private Sub fOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OptRNum.Checked = True
        'OpenConnect()
    End Sub

    Private Sub OptRNum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptRNum.CheckedChanged
        If OptRNum.Checked = True Then
            txtRNum.Enabled = True
            txtRNum.Focus()
            txtCusName.Clear()
            txtCusName.Enabled = False
        Else
            txtRNum.Enabled = False
            txtCusName.Enabled = True
        End If
    End Sub

    Private Sub OptCusName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptCusName.CheckedChanged
        If OptCusName.Checked = True Then
            txtRNum.Enabled = False
            txtCusName.Enabled = True
            txtRNum.Clear()
            txtCusName.Focus()
        Else
            txtRNum.Enabled = True
            txtRNum.Clear()
            txtCusName.Enabled = False
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If OptRNum.Checked = True Then
            If txtRNum.Text = "" Then
                Message("Input Room No to Check Out.")
                txtRNum.Focus()
            Else
                ExcSQL(" RoomNo = " & txtRNum.Text & "", "This Room has not Customer.")
                txtRNum.Focus()
                txtRNum.SelectAll()
            End If
        Else
            If txtCusName.Text = "" Then
                Message("Input Customer Name to Check Out.")
                txtCusName.Focus()
            Else
                ExcSQL("CusName='" & txtCusName.Text & "'", "This Customer Name was not Found.")
                txtCusName.Focus()
                txtCusName.SelectAll()
            End If
        End If
    End Sub

    Sub ExcSQL(ByVal Cond As String, ByVal Mess As String)
        Com.CommandText = "Select * from QCheckIn where " & Cond
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            With fCheckOut
                .txtCusID.Text = Dr(0)
                .txtCusName.Text = Dr(1)
                .txtGender.Text = Dr(2)
                .txtAddress.Text = Dr(3)
                .txtPassNo.Text = Dr(4)
                .txtCardNo.Text = Dr(5)
                .txtCheckIn.Text = Format(Dr(6), "dddd, MMMM dd,yyyy")
                .txtCheckOut.Text = Format(Now, "dddd, MMMM dd,yyyy")
                .txtStaying.Text = Dr(8)
                .txtRType.Text = Dr(9)
                .txtRNum.Text = Dr(10)
                .txtFloor.Text = Dr(11)
                .txtAmount.Text = Format(Dr(12), "Currency")
                .txtTotal.Text = Format(Dr(13), "Currency")
                .txtPrepaid.Text = Format(Dr(14), "Currency")
            End With
        Else
            Message(Mess)
        End If
        Dr.Close()
    End Sub

    Private Sub txtRNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRNum.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnOK_Click(sender, e)

        End If
        onlyInteger(e)
    End Sub

    Private Sub txtCusName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCusName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnOK_Click(sender, e)

        End If
        onlyAlphabate(e)
    End Sub
  

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

  
End Class