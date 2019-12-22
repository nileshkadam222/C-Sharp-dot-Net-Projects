Imports System.Data.OleDb

Public Class getDatabase
    Dim Connection As New System.Data.OleDb.OleDbConnection
    Dim Command As System.Data.OleDb.OleDbCommand
    Dim DataAdapter As System.Data.OleDb.OleDbDataAdapter
    Dim DataSet As System.Data.DataSet

    Sub DataSetFill()
        Try
            Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;"
            If Connection.State - System.Data.ConnectionState.Closed Then
                Connection.Open()
            End If
            Command = New System.Data.OleDb.OleDbCommand("SELECT (Name)as [Name],(Date_of_Birth)as [Date of Birth],(Address) as [Address],(Email_Address)as [Email Address], (Username) as [Username], (Password)as [Password] FROM Employees ", Connection)
            DataAdapter = New System.Data.OleDb.OleDbDataAdapter(Command)
            DataSet = New System.Data.DataSet
            DataAdapter.Fill(DataSet, "Employees")
            Database_View.DataSource = DataSet.Tables("Employees").DefaultView
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FrmRegistrationDetails_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Manage_Employees.Show()
    End Sub

    Private Sub FrmRegistrationDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DataSetFill()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Delete.Click
        Try
            If MessageBox.Show("Do you really want to delete the record?", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Database\main_database.Accdb;Persist Security Info=False;")
                If Connection.State = ConnectionState.Open Then
                    Connection.Close()
                End If
                Connection.Open()
                Dim Temp As Integer = 0
                Dim Delete As String = "delete from Employees where Username=@Delete1;"

                Command = New OleDbCommand(Delete)
                Command.Connection = Connection

                Command.Parameters.Add(New OleDbParameter("@Delete1", System.Data.OleDb.OleDbType.VarChar, 8, "Username"))
                Command.Parameters("@Delete1").Value = Database_View.SelectedCells(4).Value.ToString()

                temp = Command.ExecuteNonQuery()
                If temp > 0 Then
                    Connection.Close()
                    Call DataSetFill()
                    MessageBox.Show("Deleted Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Call DataSetFill()
                    MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class