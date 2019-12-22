
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO

Namespace Shared_Market_System
	Public Partial Class frmLogin
		Inherits Form
		Private str As String = ""
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private dr As SqlDataReader
		Private conLogin As New connstring()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub frmLogin_Load(sender As Object, e As EventArgs)




			'this.Hide();
			'frmSplash SplashScreen = new frmSplash();
			'SplashScreen.BringToFront();
			'SplashScreen.Show();
			'this.Show();
			'StreamReader myFile = new System.IO.StreamReader("c:\\cont.txt");
			'string myString = myFile.ReadToEnd();
			'connstring.serverName = myString;
			'myFile.Close();
			'str = myString;
			'MessageBox.Show(str);
		End Sub

		Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub btnlogin_Click(sender As Object, e As EventArgs)
			'frmLogin login=new frmLogin();
			Try

				conLogin.con.Open()
				cmd = New SqlCommand("select * from LOGIN_DETAILS where userid='" + txtuserid.Text + "' and Password='" + txtpassword.Text + "' ", conLogin.con)
				dr = cmd.ExecuteReader()
				If dr.HasRows Then
					While dr.Read()
						connstring.role = dr("Role").ToString()
						connstring.pass = "success"
						If txtuserid.Text = dr("userid").ToString() AndAlso txtpassword.Text = dr("Password").ToString() Then
							Me.Close()
						Else
							MessageBox.Show("Invalid Login")
							txtuserid.Clear()
							txtpassword.Clear()
							txtuserid.Focus()

						End If

					End While
				Else
					MessageBox.Show("Invalid Login")
					txtuserid.Clear()

					txtpassword.Clear()
					txtuserid.Focus()
				End If
				dr.Close()
				conLogin.con.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conLogin.con.Close()
			End Try
		End Sub

		Private Sub txtuserid_TextChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs)

		End Sub

		Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				btnlogin_Click(sender, e)
			End If
		End Sub

		Private Sub grbLogin_Enter(sender As Object, e As EventArgs)

		End Sub

		Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs)


		End Sub

		Private Sub lblPassword_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			txtpassword.Text = ""
			txtuserid.Text = ""
			txtuserid.Focus()
		End Sub

		Private Sub btnreset_Click(sender As Object, e As EventArgs)
			txtuserid.Clear()
			txtpassword.Clear()
			txtuserid.Focus()
		End Sub

		Private Sub frmLogin_FormClosing_1(sender As Object, e As FormClosingEventArgs)
			If connstring.pass <> "success" Then
				Application.[Exit]()
			End If
		End Sub

		Private Sub txtpassword_KeyDown_1(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				btnlogin_Click(sender, e)
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
