Imports System.Data.OleDb

Public Class Login
    Dim Command As OleDbCommand = Nothing

    Private Sub Button_Admin_LoginClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Admin_Login.Click

        If Len(Trim(TextBox_Admin_Username.Text)) = 0 Then
            MessageBox.Show("Please enter a Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox_Admin_Username.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox_Admin_Password.Text)) = 0 Then
            MessageBox.Show("Please enter a Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox_Admin_Password.Focus()
            Exit Sub
        End If

        Try
            Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
            Connection.Open()
            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand
            Command.CommandText = "select [Username],[Password] from Administrator where Username = @UName"

            ' UserName
            Dim Username As OleDbParameter = New OleDbParameter("@UName", OleDbType.VarWChar, 20)
            Username.Value = (TextBox_Admin_Username.Text.ToString())
            Command.Parameters.Add(Username)
            Command.Connection = Connection

            DataReader = Command.ExecuteReader
            If DataReader.Read Then
                If (DataReader("Password")) = (TextBox_Admin_Password.Text) Then
                    Connection.Close()
                    ComboBox_Login.SelectedItem = "Administrator"

                    Dim obj As New Main
                    Me.Hide()
                    obj.Show()

                Else
                    MessageBox.Show("Password is incorrect", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Connection.Close()
                    TextBox_Empl_Password.Focus()
                    Return
                End If
            Else
                MessageBox.Show("Username is incorrect", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Connection.Close()
                TextBox_Empl_Username.Focus()
                Return
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_Empl_LoginClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Empl_Login.Click
        If Len(Trim(TextBox_Empl_Username.Text)) = 0 Then
            MessageBox.Show("Please enter a Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox_Empl_Username.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox_Empl_Password.Text)) = 0 Then
            MessageBox.Show("Please enter a Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox_Empl_Password.Focus()
            Exit Sub
        End If

        Try
            Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
            Connection.Open()

            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand
            Command.CommandText = "select [Username],[Password] from Employees where Username = @UName"

            ' UserName
            Dim Username As OleDbParameter = New OleDbParameter("@UName", OleDbType.VarWChar, 30)
            Username.Value = (TextBox_Empl_Username.Text.ToString())
            Command.Parameters.Add(Username)

            Command.Connection = Connection
            DataReader = Command.ExecuteReader

            If DataReader.Read Then

                If (DataReader("Password")) = (TextBox_Empl_Password.Text) Then

                    Connection.Close()
                    ComboBox_Login.SelectedItem = "Employees"
                    Dim obj As New Main
                    Me.Hide()
                    obj.Show()

                Else
                    MessageBox.Show("Password is incorrect", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Connection.Close()
                    TextBox_Empl_Password.Focus()
                    Return
                End If

            Else
                MessageBox.Show("Username is incorrect", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Connection.Close()
                TextBox_Empl_Username.Focus()
                Return
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_Empl_CancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Empl_Cancel.Click
        End
    End Sub

    Private Sub Button_Admin_CancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Admin_Cancel.Click
        End
    End Sub

    Private Sub TextBox_Admin_UsernameKeys(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Admin_Username.KeyPress
        Dim notAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If notAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_Admin_PasswordKeys(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Admin_Password.KeyPress
        Dim notAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If notAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_Empl_UsernameKeys(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Empl_Username.KeyPress
        Dim notAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If notAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_Empl_PasswordKeys(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Empl_Password.KeyPress
        Dim notAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If notAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LoginClose(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub TabsLogin(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabs_Login.Click
        TextBox_Admin_Username.Text = ""
        TextBox_Admin_Password.Text = ""
        TextBox_Empl_Username.Text = ""
        TextBox_Empl_Password.Text = ""
    End Sub
End Class
