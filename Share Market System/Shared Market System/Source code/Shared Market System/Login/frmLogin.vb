
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO

Namespace VijayEnggs
	Public Partial Class frmLogin
		Inherits Form
		Private str As String = ""
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private dr As SqlDataReader
		Private conLogin As New ClassConnection()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub frmLogin_Load(sender As Object, e As EventArgs)
			'this.Hide();
			'frmSplash SplashScreen = new frmSplash();
			'SplashScreen.BringToFront();
			'SplashScreen.Show();
			'this.Show();
			Dim myFile As StreamReader = New System.IO.StreamReader("c:\cont")
			Dim myString As String = myFile.ReadToEnd()
			ClassConnection.serverName = myString
			myFile.Close()
			'str = myString;
			'MessageBox.Show(str);
		End Sub

		Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub btnLogIn_Click(sender As Object, e As EventArgs)
			'frmLogin login=new frmLogin();
			Try

				conLogin.con.Open()
				cmd = New SqlCommand("select * from tbl_Login where Username='" + txtUserName.Text + "' and Password='" + txtpassword.Text + "' ", conLogin.con)
				dr = cmd.ExecuteReader()
				If dr.HasRows Then
					While dr.Read()
						ClassConnection.role = dr("Role").ToString()
						ClassConnection.pass = "success"
						If txtUserName.Text = dr("Username").ToString() AndAlso txtpassword.Text = dr("Password").ToString() Then

							Me.Close()

						End If
					End While
				Else
					MessageBox.Show("Invalid Credentials")
					txtpassword.Clear()
					txtpassword.Focus()
				End If
				dr.Close()
				conLogin.con.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conLogin.con.Close()
			End Try
		End Sub

		Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs)

		End Sub

		Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				btnLogIn_Click(sender, e)
			End If
		End Sub

		Private Sub grbLogin_Enter(sender As Object, e As EventArgs)

		End Sub

		Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs)
			If ClassConnection.pass <> "success" Then
				Application.[Exit]()
			End If

		End Sub

		Private Sub lblPassword_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			txtpassword.Text = ""
			txtUserName.Text = ""
			txtUserName.Focus()
		End Sub


	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
