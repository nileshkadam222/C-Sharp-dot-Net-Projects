Imports System.Data.OleDb

Public Class Main


    Private Sub TimerTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Time_Status.Text = Now.ToLongTimeString.ToString()
    End Sub

    Private Sub MainClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Login.ComboBox_Login.Text = "" Then
            Me.Dispose()
            Login.Show()
            Login.TextBox_Admin_Username.Text = ""
            Login.TextBox_Admin_Password.Text = ""
            Login.TextBox_Empl_Username.Text = ""
            Login.TextBox_Empl_Password.Text = ""
            Return
        End If

        Try
            Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
            Connection.Open()

            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand

            If Login.ComboBox_Login.Text = "Employees" Then
                Command.CommandText = "select [Username],[Name] from Employees where Username ='" & Login.TextBox_Empl_Username.Text & "'"
                Command.Connection = Connection

                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    Dim intResponse As Integer
                    intResponse = MessageBox.Show("Do you want to logout ?", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If intResponse = MsgBoxResult.No Then
                        e.Cancel = True
                        ' Exit Sub
                    Else
                        MsgBox("Thank You - " & (DataReader("Name")).ToString() & "" & vbNewLine)
                        Connection.Close()
                        Me.Dispose()
                        Login.Show()
                        Login.TextBox_Admin_Username.Text = ""
                        Login.TextBox_Admin_Password.Text = ""
                        Login.TextBox_Empl_Username.Text = ""
                        Login.TextBox_Empl_Password.Text = ""

                    End If

                End If
            Else
                If Login.ComboBox_Login.Text = "Administrator" Then
                    Dim intResponse As Integer
                    intResponse = MessageBox.Show("Do you want to logout? ", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If intResponse = MsgBoxResult.No Then
                        e.Cancel = True
                        ' Exit Sub
                    Else
                        MsgBox("Thank You - Administrator")
                        Connection.Close()
                        Me.Dispose()
                        Login.Show()
                        Login.TextBox_Admin_Username.Text = ""
                        Login.TextBox_Admin_Password.Text = ""
                        Login.TextBox_Empl_Username.Text = ""
                        Login.TextBox_Empl_Password.Text = ""

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error.")
        End Try

    End Sub

    Private Sub MainLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        StatusBar_Username_Label.Text = "Name -"
        StatusBar_Date_Label.Text = "Date -"
        Date_Status.Text = Format(Now, "dd/MM/yyyy")
        StatusBar_Time_Label.Text = "Time -"
        Try
            If Login.ComboBox_Login.Text = "Employees" Then
                Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")
                If Connection.State = ConnectionState.Open Then
                    Connection.Close()
                End If
                Connection.Open()
                Dim DataReader As OleDbDataReader
                Dim Command As New OleDbCommand
                Command.CommandText = "select [Username],[Name] from Employees where Username = @UName"

                ' UserName
                Dim Username As OleDbParameter = New OleDbParameter("@UName", OleDbType.VarWChar, 30)
                Username.Value = UCase(Login.TextBox_Empl_Username.Text.ToString())
                Command.Parameters.Add(Username)
                Command.Connection = Connection

                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    Username_Status.Text = (DataReader("Name").ToString())
                    ToolBox_Register.Visible = False
                    ToolBox_Separator_1.Visible = False
                    Connection.Close()
                    Return
                End If
            Else
                Username_Status.Text = "Administrator"
                ToolBox_Register.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error.")
        End Try

    End Sub

    Private Sub ToolBoxManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBox_Register.Click
        Me.Dispose()
        Manage_Employees.Show()
    End Sub

    Private Sub ToolBoxUserDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBox_UserDetails.Click
        Me.Dispose()
        User_Details.Show()
    End Sub

    Private Sub ToolBoxLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBox_Logout.Click
        Me.Close()
    End Sub
End Class