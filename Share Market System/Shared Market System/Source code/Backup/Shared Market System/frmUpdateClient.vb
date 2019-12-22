
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Shared_Market_System
	Public Partial Class frmUpdateClient_Details
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private cmd1 As SqlCommand = Nothing
		Private reader As SqlDataReader = Nothing
		Private conupdateclient_details As New connstring()

		Private Sub frmUpdateClient_Details_Load(sender As Object, e As EventArgs)
			Try

				conupdateclient_details.con.Open()
				cmd = New SqlCommand("select * from client_details", conupdateclient_details.con)
				reader = cmd.ExecuteReader()


				If Not reader.HasRows Then
				Else
					While reader.Read()

						cboClient_name.Items.Add(reader("CLIENT_NAME").ToString())
					End While
					reader.Close()





				End If
			Catch ex As Exception
			Finally
				conupdateclient_details.con.Close()
			End Try
		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub cboClient_name_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try

				conupdateclient_details.con.Open()
				cmd = New SqlCommand("select * from client_details where client_name='" + cboClient_name.Text + "'", conupdateclient_details.con)
				reader = cmd.ExecuteReader()
				If Not reader.HasRows Then
				Else

					While reader.Read()

						txtAddress.Text = reader("ADDRESS").ToString()


						txtContact_no.Text = reader("CONATCT_NO").ToString()
					End While


					reader.Close()

				End If
			Catch ex As Exception
			Finally
				conupdateclient_details.con.Close()
			End Try
		End Sub

		Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
			Try


				conupdateclient_details.con.Open()


				cmd = New SqlCommand("select * from client_details where client_name='" + cboClient_name.Text + "'", conupdateclient_details.con)
				reader = cmd.ExecuteReader()

				reader.Read()

				Dim x As Integer = Int32.Parse(reader("CLIENT_ID").ToString())

				reader.Close()

				cmd1 = New SqlCommand("update client_details set CLIENT_NAME='" + cboClient_name.Text + "',ADDRESS='" + txtAddress.Text + "',CONATCT_NO='" + txtContact_no.Text + "' where CLIENT_ID='" + x + "' ", conupdateclient_details.con)

				cmd1.ExecuteNonQuery()



				MessageBox.Show("Record Updated Successfully")



				Me.Close()

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conupdateclient_details.con.Close()
			End Try
		End Sub

		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Try


				conupdateclient_details.con.Open()



				cmd = New SqlCommand("select * from client_details where client_name='" + cboClient_name.Text + "'", conupdateclient_details.con)
				reader = cmd.ExecuteReader()

				reader.Read()
				Dim x As Integer = Int32.Parse(reader("client_id").ToString())
				reader.Close()

				cmd1 = New SqlCommand("delete from client_details where client_id='" + x + "'", conupdateclient_details.con)
				cmd1.ExecuteNonQuery()




				MessageBox.Show("Record Deleted")
					' clear();


				Me.Close()

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conupdateclient_details.con.Close()
			End Try
		End Sub

		Private Sub txtContact_no_KeyPress(sender As Object, e As KeyPressEventArgs)
			If (e.KeyChar >= 48 AndAlso e.KeyChar <= 57) OrElse e.KeyChar = 8 OrElse e.KeyChar = 40 OrElse e.KeyChar = 41 OrElse e.KeyChar = 45 Then
				e.KeyChar = e.KeyChar
			Else
				e.KeyChar = Convert.ToChar(0)
				MessageBox.Show("Please enter numeric values")
			End If
		End Sub
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
