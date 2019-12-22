Imports System.Data.OleDb

Public Class Change_Password

    Private Function RequiredEntry() As Boolean
        If TextBox_oldPassword.Text = "" Or TextBox_newPassword.Text = "" Or TextBox_confirmPassword.Text = "" Then
            MsgBox("Please enter all the Details", MsgBoxStyle.Critical, "Attention...")
            Me.TextBox_oldPassword.Focus()
            Return True
            Exit Function
        End If
    End Function
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Clear.Click
        TextBox_oldPassword.Clear()
        TextBox_newPassword.Clear()
        TextBox_confirmPassword.Clear()
        TextBox_oldPassword.Focus()
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Update.Click
        If RequiredEntry() = True Then
            Return
        End If
        Try
            Dim CN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")

            Dim DR1 As OleDbDataReader
            Dim COM As New OleDbCommand

            If Login.ComboBox_Login.Text = "Employees" Then
                If CN.State = ConnectionState.Open Then
                    CN.Close()
                End If
                CN.Open()

                COM.CommandText = "select [Username],[Password] from UserInfo where userid = '" & Login.TextBox_Empl_Username.Text & "'"
                COM.Connection = CN
                DR1 = COM.ExecuteReader

                If DR1.Read Then
                    If UCase(DR1("Password")) = UCase(TextBox_oldPassword.Text) Then

                        If TextBox_newPassword.Text = TextBox_confirmPassword.Text Then

                            Dim CMD1 As New OleDb.OleDbCommand("Update Employees Set Password=@Pass Where Username='" & Login.TextBox_Empl_Username.Text & "' ", CN)

                            'Password
                            Dim Password As OleDbParameter = New OleDbParameter("@Pass", OleDbType.VarWChar, 8)
                            Password.Value = TextBox_newPassword.Text.ToString()
                            CMD1.Parameters.Add(Password)


                            If CMD1.ExecuteNonQuery() Then
                                CN.Close()
                                MsgBox("Your password update successfully...", MsgBoxStyle.Information, "Password Updated")
                                Button_Clear.PerformClick()
                            Else
                                MsgBox("Password updation failed ", MsgBoxStyle.Critical, "Updation Failed")
                            End If

                        Else
                            MessageBox.Show("Password & Confirm password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    Else
                        MsgBox("Old password is Wrong!!!", MsgBoxStyle.Critical, "Password Wrong")
                    End If
                End If

                Return
            End If

            If Login.ComboBox_Login.Text = "Administrator" Then
                If Connection.State = ConnectionState.Open Then
                    Connection.Close()
                End If
                Connection.Open()

                Command.CommandText = "select [Username],[Password] from Administrator where Username = '" & Login.TextBox_Admin_Username.Text & "'"
                Command.Connection = Connection
                DataReader = Command.ExecuteReader()

                If DataReader.Read Then
                    If (DataReader("Password")) = (TextBox_oldPassword.Text) Then

                        If TextBox_newPassword.Text = TextBox_confirmPassword.Text Then

                            Dim newCommand As New OleDb.OleDbCommand("Update Administrator Set Password=@Password Where Username='" & Login.TextBox_Empl_Username.Text & "' ", Connection)

                            'Password
                            Dim Password As OleDbParameter = New OleDbParameter("@Password", OleDbType.VarWChar, 8)
                            Password.Value = TextBox_newPassword.Text.ToString()
                            Command.Parameters.Add(Password)


                            If Command.ExecuteNonQuery() Then
                                Connection.Close()
                                MsgBox("Password update successfully", MsgBoxStyle.Information, "Password Updated")
                                Button_Clear.PerformClick()
                            Else
                                MsgBox("Password updation failed", MsgBoxStyle.Critical, "Updation Failed")
                            End If

                        Else
                            MessageBox.Show("Password & Confirm Password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    Else
                        MsgBox("Old Password is Wrong!!!", MsgBoxStyle.Critical, "Password Wrong")
                    End If
                End If
                Return

            End If
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Exit Sub
        End Try

    End Sub

    Private Sub ChangePassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        User_Details.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub newPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_newPassword.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub OldPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_oldPassword.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConfirmPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_confirmPassword.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub
End Class