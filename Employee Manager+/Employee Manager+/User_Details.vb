Imports System.Data.OleDb
Imports System.IO

Public Class User_Details

    Private Sub UserDetailsClose(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Main.Show()
    End Sub

    Private Sub LinkDetails_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_ChangeDetails.LinkClicked
        Me.Dispose()
        Change_Details.Show()
    End Sub

    Private Sub LinkPassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_ChangePassword.LinkClicked
        Me.Dispose()
        Change_Password.Show()
    End Sub

    Private Sub UserInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
            Connection.Open()

            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand

            If Login.ComboBox_Login.Text = "Employees" Then
                Command.CommandText = "select [Username],[Name],[Date_of_Birth],[Address],[Email_Address],[Photo] from Employees where Username = '" & Login.TextBox_Empl_Username.Text & "'"
                Command.Connection = Connection
                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    Text_Name.Text = "" & (DataReader(1)).ToString() & ""
                    Text_Date_of_Birth.Text = "" & (DataReader(2)).ToString() & ""
                    Text_Address.Text = "" & (DataReader(3)).ToString() & ""
                    Text_Email_Address.Text = "" & (DataReader(4)).ToString() & ""
                    Dim x As Byte() = DataReader("Photo")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    Empl_Photo.Image = Image.FromStream(ms)
                End If
                Connection.Close()
                DataReader.Close()
                Return
            End If
            If Login.ComboBox_Login.Text = "Administrator" Then

                Command.CommandText = "select [Username],[Name],[Date_of_Birth],[Address],[Email_Address],[Photo] from Administrator where Username = '" & Login.TextBox_Admin_Username.Text & "'"
                Command.Connection = Connection
                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    Text_Name.Text = "" & (DataReader(1)).ToString() & ""
                    Text_Date_of_Birth.Text = "" & (DataReader(2)).ToString() & ""
                    Text_Address.Text = "" & (DataReader(3)).ToString() & ""
                    Text_Email_Address.Text = "" & (DataReader(4)).ToString() & ""
                    Dim x As Byte() = DataReader("Photo")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    Empl_Photo.Image = Image.FromStream(ms)
                End If
                Connection.Close()
                DataReader.Close()
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub
End Class