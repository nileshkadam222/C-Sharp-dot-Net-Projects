Imports System.Data.OleDb
Imports System.IO

Public Class Manage_Employees

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub ManageFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Main.Show()
    End Sub
    Sub Clear()
        TextBox_Name.Clear()
        dtp_DateofBirth.Value = Today
        TextBox_Address.Clear()
        TextBox_Email.Clear()
        TextBox_Username.Clear()
        TextBox_Password.Clear()
        TextBox_CPassword.Clear()
    End Sub
    Private Function RequiredEntry() As Boolean
        If TextBox_Name.Text = "" Or TextBox_Address.Text = "" Or TextBox_Email.Text = "" Or TextBox_Username.Text = "" Or TextBox_Password.Text = "" Or TextBox_CPassword.Text = "" Then
            MsgBox("Please enter all the Details.", MsgBoxStyle.Critical, "Attention")
            Return True
            Exit Function
        End If
    End Function

    Private Sub BrowseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Browse.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.Employee_Photo.Image = System.Drawing.Image.FromFile(.FileName)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub

    Private Sub RemoveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Remove.Click
        Me.Employee_Photo.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\default.jpg")
    End Sub

    Private Sub ButtonClearClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Clear.Click
        Call Clear()
    End Sub

    Private Sub ManageLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_DateofBirth.Value = Today
    End Sub

    Private Sub buttonAddClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Add.Click
        If RequiredEntry() = True Then
            Return
        End If
        Try

            Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
            Connection.Open()

            If TextBox_Password.Text = TextBox_CPassword.Text Then


                Dim SQLx As String = "INSERT INTO [Employees] (Username, [Password], Name, Date_of_Birth, Address, Email_Address, Photo) VALUES (@D1,@D2,@D3,@D4,@D5,@D6,@D7)"
                Dim Command As OleDbCommand = New OleDbCommand(SQLx, Connection)


                ' Username
                Dim Username As OleDbParameter = New OleDbParameter("@D1", OleDbType.VarWChar, 8)
                Username.Value = TextBox_Username.Text.ToString()
                Command.Parameters.Add(Username)

                ' Password
                Dim Password As OleDbParameter = New OleDbParameter("@D2", OleDbType.VarWChar, 8)
                Password.Value = TextBox_Password.Text.ToString()
                Command.Parameters.Add(Password)

                ' Name
                Dim Name As OleDbParameter = New OleDbParameter("@D3", OleDbType.VarWChar, 15)
                Name.Value = TextBox_Name.Text.ToString()
                Command.Parameters.Add(Name)

                ' Date Of Birth
                Dim Date_of_Birth As OleDbParameter = New OleDbParameter("@D4", OleDbType.Date, 15)
                Date_of_Birth.Value = dtp_DateofBirth.Text.ToString()
                Command.Parameters.Add(Date_of_Birth)

                ' Address
                Dim Address As OleDbParameter = New OleDbParameter("@D5", OleDbType.VarWChar, 25)
                Address.Value = TextBox_Address.Text.ToString()
                Command.Parameters.Add(Address)


                ' Email Address
                Dim Email_Address As OleDbParameter = New OleDbParameter("@D6", OleDbType.VarWChar, 25)
                Email_Address.Value = TextBox_Email.Text.ToString()
                Command.Parameters.Add(Email_Address)



                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()

                Me.Employee_Photo.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)


                ' Photo
                Dim Photo As OleDbParameter = New OleDbParameter("@D7", SqlDbType.Image)
                Photo.Value = DataPic_Update
                Command.Parameters.Add(Photo)


                If Command.ExecuteNonQuery() Then
                    Connection.Close()
                    MsgBox("Employee Registered Successfully.", MsgBoxStyle.Information, "Success")

                Else
                    MsgBox("Employee Registration Failed.", MsgBoxStyle.Critical, "Failed")
                    Return
                End If
            Else
                MessageBox.Show("Password & Confirm Password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub
        End Try
    End Sub

    Private Sub Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Name.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Address_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Address.KeyPress
        Dim NotAllowed As String = "~`@#$%^()_+={[}]:;'!><?|"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Username.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"
        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Password.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"
        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConfirmPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_CPassword.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"
        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub getDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_getDatabase.Click
        Me.Dispose()
        getDatabase.Show()
    End Sub

    Private Sub dtp_DateofBirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_DateofBirth.ValueChanged

    End Sub
End Class