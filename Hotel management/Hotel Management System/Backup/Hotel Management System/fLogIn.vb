Public Class fLogIn

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "" Then
            Message("Enter User Name.")
            txtUserName.Focus()
        ElseIf txtPassword.Text = "" Then
            Message("Enter Password.")
            txtPassword.Focus()
        Else
            Com.CommandText = "Select UserName,Pass,Permission from tblUser where UserName='" & Encrypt(txtUserName.Text) & "' And Pass='" & Encrypt(txtPassword.Text) & "'"
            Dr = Com.ExecuteReader
            If Dr.Read = True Then
                Me.Hide()
                Main.TUser.Text = txtUserName.Text
                If Dr(2) = "Admin" Then
                    Main.SetRoomPriceToolStripMenuItem.Enabled = True
                    Main.RoomInformationToolStripMenuItem2.Enabled = True
                    Main.SetUpUserToolStripMenuItem1.Enabled = True
                    Main.ChangeUserNamePasswordToolStripMenuItem1.Enabled = True
                    Main.ToolStripButton5.Enabled = True
                Else
                    Main.SetRoomPriceToolStripMenuItem.Enabled = False
                    Main.RoomInformationToolStripMenuItem2.Enabled = False
                    Main.SetUpUserToolStripMenuItem1.Enabled = False
                    Main.ChangeUserNamePasswordToolStripMenuItem1.Enabled = False
                    Main.ToolStripButton5.Enabled = False
                End If

                Dim L As Boolean = False
                Dim L1 As Boolean = False
                Dr.Close()
                fExpire.lstCheckInExpire.Items.Clear()
                Com.CommandText = "Select * from QCheckIn where CheckOutDate<=#" & DateAdd(DateInterval.Day, 1, Today) & "#"
                Dr = Com.ExecuteReader
                Do While Dr.Read = True
                    AddDataToLvw(fExpire.lstCheckInExpire, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd," & _
                    "yyyy"), Dr(8), Format(Dr(7), "dddd, MMMM dd,yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Curren" & _
                    "cy"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "currency"))
                    L = True
                Loop
                Dr.Close()

                'Load Data For Booking Expire
                fExpire.lstBookingExpire.Items.Clear()
                Com.CommandText = "Select * from QBooking where CheckInDate<=#" & DateAdd(DateInterval.Day, 1, Today) & "#"
                Dr = Com.ExecuteReader
                Do While Dr.Read = True
                    AddDataToLvw(fExpire.lstBookingExpire, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Format(Dr(6), "dddd, MMMM dd,yyy" & _
                    "y"), Dr(7), Format(Dr(8), "dddd, MMMM dd,yyyy"), Dr(9), Dr(10), Dr(11), Format(Dr(12), "Currenc" & _
                    "y"), Format(Dr(13), "Currency"), Format(Dr(14), "Currency"), Format(Dr(15), "currency"))
                    L1 = True
                Loop
                Dr.Close()

                If L = True Or L1 = True Then
                    ShowForm(fExpire, Main)
                End If

            Else
                Message("User Name Or Password are invalid.")
                txtUserName.Focus()
                txtUserName.SelectAll()
            End If
            Dr.Close()
            End If
    End Sub

    Private Sub fLogIn_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUserName.Focus()
    End Sub

    Private Sub fLogIn_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogIn_Click(sender, e)
        End If
    End Sub
End Class