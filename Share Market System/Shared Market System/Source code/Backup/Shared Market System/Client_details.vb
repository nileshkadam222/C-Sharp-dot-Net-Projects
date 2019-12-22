
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Shared_Market_System
	Public Partial Class frmclient_details
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private reader As SqlDataReader = Nothing
		Private conclient_details As New connstring()

		Public Sub New()

			InitializeComponent()
		End Sub

		Private Sub btnsave_Click(sender As Object, e As EventArgs)

			Try
				If txtclient_name.Text = "" Then

					MessageBox.Show("Please Enter the Client Name")
					txtclient_name.Focus()
				Else



					conclient_details.con.Open()
					cmd = New SqlCommand("insert into CLIENT_DETAILS(CLIENT_ID,CLIENT_NAME,ADDRESS,CONATCT_NO,SHARES) values('" + txtClient_id.Text + "','" + txtclient_name.Text + "', '" + txtAddress.Text + "', '" + txtContact_no.Text + "',0)", conclient_details.con)
					cmd.ExecuteNonQuery()

					Dim cmd1 As New SqlCommand("insert into CLIENT_shares(CLIENT_ID,CLIENT_NAME,shares)values('" + txtClient_id.Text + "','" + txtclient_name.Text + "',0)", conclient_details.con)
					cmd1.ExecuteNonQuery()


					MessageBox.Show("Record Saved Successfully")
					clear()

					Dim x As Integer = Int32.Parse(txtClient_id.Text) + 1
					txtClient_id.Text = x.ToString()

					txtclient_name.Focus()
				End If

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conclient_details.con.Close()
			End Try

		End Sub

		Public Sub clear()
			txtclient_name.Clear()

			txtAddress.Clear()

			txtContact_no.Clear()

		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub cboadmin_type_SelectedIndexChanged(sender As Object, e As EventArgs)
			'conclient_details.con.Open();

		End Sub

		Private Sub frmclient_details_Load(sender As Object, e As EventArgs)
			Try
				Dim x As Integer = 0
				conclient_details.con.Open()
				cmd = New SqlCommand("select * from client_details", conclient_details.con)
				reader = cmd.ExecuteReader()

				If Not reader.HasRows Then

					x = 1
				Else
					While reader.Read()
						x = Int32.Parse(reader("CLIENT_ID").ToString())
						x = x + 1
					End While
					reader.Close()
				End If




				txtClient_id.Text = x.ToString()
			Catch ex As Exception
			Finally
				conclient_details.con.Close()
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
