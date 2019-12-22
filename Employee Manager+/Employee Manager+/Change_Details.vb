Imports System.Data.OleDb
Imports System.IO

Public Class Change_Details

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub ChangeDetails_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        User_Details.Show()
    End Sub

    Private Function RequiredEntry() As Boolean
        If TextBox_Name.Text = "" Or TextBox_Address.Text = "" Or TextBox_Email_Address.Text = "" Then
            MsgBox("Please enter all the Details.", MsgBoxStyle.Critical, "Attention")
            Return True
            Exit Function
        End If
    End Function

    Private Sub Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim Connection As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")

            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand

            If Login.ComboBox_Login.Text = "Employees" Then
                If Connection.State = ConnectionState.Open Then
                    Connection.Close()
                End If
                Connection.Open()
                Command.CommandText = "select [Username],[Name],[Date_of_Birth],[Address],[Email_Address],[Photo] from Employees where Username = '" & Login.TextBox_Empl_Username.Text & "'"
                Command.Connection = Connection
                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    TextBox_Name.Text = (DataReader(1)).ToString()
                    dtp_Date_of_Birth.Value = (DataReader(2)).ToString()
                    TextBox_Address.Text = (DataReader(3)).ToString()
                    TextBox_Email_Address.Text = (DataReader(4)).ToString()
                    Dim x As Byte() = DataReader("Photo")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    Employee_Photo.Image = Image.FromStream(ms)
                End If
                Connection.Close()
                Return
            End If

            If Login.ComboBox_Login.Text = "Administrator" Then
                If Connection.State = ConnectionState.Open Then
                    Connection.Close()
                End If
                Connection.Open()
                Command.CommandText = "select [Username],[Name],[Date_of_Birth],[Address],[Email_Address],[Photo] from Administrator where Username = '" & Login.TextBox_Admin_Username.Text & "'"
                Command.Connection = Connection
                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    TextBox_Name.Text = (DataReader(1)).ToString()
                    dtp_Date_of_Birth.Text = (DataReader(2)).ToString()
                    TextBox_Address.Text = (DataReader(3)).ToString()
                    TextBox_Email_Address.Text = (DataReader(4)).ToString()
                    Dim x As Byte() = DataReader("Photo")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    Employee_Photo.Image = Image.FromStream(ms)
                End If
                Connection.Close()
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Clear.Click

        TextBox_Name.Clear()
        dtp_Date_of_Birth.Value = Today
        TextBox_Address.Clear()
        TextBox_Email_Address.Clear()

        Try
            Dim Connection As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")

            Dim DataReader As OleDbDataReader
            Dim Command As New OleDbCommand


            If Login.ComboBox_Login.Text = "Employees" Then
                If Connection.State = ConnectionState.Open Then
                    Connection.Close()
                End If
                Connection.Open()
                Command.CommandText = "select [Photo] from Employees where Username = '" & Login.TextBox_Empl_Username.Text & "'"
                Command.Connection = Connection
                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    Dim x As Byte() = DataReader("Photo")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    Employee_Photo.Image = Image.FromStream(ms)
                End If
                Connection.Close()
                Return
            End If


            If Login.ComboBox_Login.Text = "Administrator" Then
                If Connection.State = ConnectionState.Open Then
                    Connection.Close()
                End If
                Connection.Open()
                Command.CommandText = "select [Photo] from Administrator where Username = '" & Login.TextBox_Empl_Username.Text & "'"
                Command.Connection = Connection
                DataReader = Command.ExecuteReader
                If DataReader.Read Then
                    Dim x As Byte() = DataReader("Photo")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    Employee_Photo.Image = Image.FromStream(ms)
                End If
                Connection.Close()
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Browse.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.Employee_Photo.Image = System.Drawing.Image.FromFile(.FileName)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Remove.Click
        Me.Employee_Photo.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\default.jpg")
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Update.Click
        If RequiredEntry() = True Then
            Return
        End If
        Try
           
                Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")

                If Login.ComboBox_Login.Text = "Employees" Then
                    If Connection.State = ConnectionState.Open Then
                        Connection.Close()
                    End If
                    Connection.Open()

                    Dim Command As New OleDb.OleDbCommand("Update Employees Set Name=@Name,Date_of_Birth=@DOB,Address=@Add,Email_Address=@Email_Address,Photo=@Photo Where (Username='" & Login.TextBox_Empl_Username.Text & "') ", Connection)

                    ' Name
                    Dim Name As OleDbParameter = New OleDbParameter("@Name", OleDbType.VarWChar, 15)
                    Name.Value = TextBox_Name.Text.ToString()
                    Command.Parameters.Add(Name)

                    'Date of Birth
                    Dim Date_of_Birth As OleDbParameter = New OleDbParameter("@DOB", OleDbType.VarWChar, 15)
                    Date_of_Birth.Value = dtp_Date_of_Birth.Text.ToString()
                    Command.Parameters.Add(Date_of_Birth)

                    'Address
                    Dim Address As OleDbParameter = New OleDbParameter("@Address", OleDbType.VarWChar, 20)
                    Address.Value = TextBox_Address.Text.ToString()
                    Command.Parameters.Add(Address)

                    'Email Address
                    Dim Email_Address As OleDbParameter = New OleDbParameter("@Email_Address", OleDbType.VarWChar, 25)
                    Email_Address.Value = TextBox_Email_Address.Text.ToString()
                    Command.Parameters.Add(Email_Address)

                    Dim MemStream As New MemoryStream
                    Dim DataPic_Update As Byte()

                    Me.Employee_Photo.Image.Save(MemStream, Imaging.ImageFormat.Png)
                    DataPic_Update = MemStream.GetBuffer()
                    MemStream.Read(DataPic_Update, 0, MemStream.Length)

                    ' Photo 
                    Dim Photo As OleDbParameter = New OleDbParameter("@Photo", SqlDbType.Image)
                    Photo.Value = DataPic_Update
                    Command.Parameters.Add(Photo)


                    If Command.ExecuteNonQuery() Then
                        Connection.Close()
                        MsgBox("Details updated successfully.", MsgBoxStyle.Information, "Success")

                    Else
                        MsgBox("Details update failed", MsgBoxStyle.Critical, "Failed")
                        Return
                    End If
                End If



                If Login.ComboBox_Login.Text = "Administrator" Then
                    If Connection.State = ConnectionState.Open Then
                        Connection.Close()
                    End If
                    Connection.Open()

                    Dim Command As New OleDb.OleDbCommand("Update Administrator Set Name=@Name,Date_of_Birth=@DOB,Address=@Address,Email_Address=@Email_Address,Photo=@Photo Where (Username ='" & Login.TextBox_Admin_Username.Text & "') ", Connection)


                    'Name
                    Dim Name As OleDbParameter = New OleDbParameter("@Name", OleDbType.VarWChar, 50)
                    Name.Value = TextBox_Name.Text.ToString()
                    Command.Parameters.Add(Name)

                    'Date of Birth
                    Dim Date_of_Birth As OleDbParameter = New OleDbParameter("@DOB", OleDbType.VarWChar, 50)
                    Date_of_Birth.Value = dtp_Date_of_Birth.Text.ToString()
                    Command.Parameters.Add(Date_of_Birth)

                    'Address
                    Dim Address As OleDbParameter = New OleDbParameter("@Address", OleDbType.VarWChar, 50)
                    Address.Value = TextBox_Address.Text.ToString()
                    Command.Parameters.Add(Address)

                    'Email Address
                    Dim Email_Address As OleDbParameter = New OleDbParameter("@Email_Address", OleDbType.VarWChar, 50)
                    Email_Address.Value = TextBox_Email_Address.Text.ToString()
                    Command.Parameters.Add(Email_Address)


                    Dim MemStream As New MemoryStream
                    Dim DataPic_Update As Byte()

                    Me.Employee_Photo.Image.Save(MemStream, Imaging.ImageFormat.Png)
                    DataPic_Update = MemStream.GetBuffer()
                    MemStream.Read(DataPic_Update, 0, MemStream.Length)


                    'Photo
                    Dim Photo As OleDbParameter = New OleDbParameter("@Photo", SqlDbType.Image)
                    Photo.Value = DataPic_Update
                    Command.Parameters.Add(Photo)


                    If Command.ExecuteNonQuery() Then
                        Connection.Close()
                        MsgBox("Details updated successfully.", MsgBoxStyle.Information, "Success")

                    Else
                        MsgBox("Details update failed", MsgBoxStyle.Critical, "Failed")
                        Return
                    End If
                End If
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

    End Sub
End Class