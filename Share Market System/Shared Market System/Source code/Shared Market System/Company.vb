
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient


Namespace Shared_Market_System

	Public Partial Class frmcompany
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private conComp As New connstring()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub frmcompany_Load(sender As Object, e As EventArgs)

		End Sub

		Private Sub btnsave_Click(sender As Object, e As EventArgs)
			Try
				If txtcompany_name.Text = "" Then
					txtcompany_name.Focus()


					MessageBox.Show("Please enter company name")

				ElseIf txtno_shares.Text = "" Then

					txtno_shares.Focus()


					MessageBox.Show("Please enter number of shares")
				Else
					'else if (txtrate.Text == "")

					'{
					'    txtrate.Focus();
					'    MessageBox.Show("Please enter rate");
					'}
					If Microsoft.VisualBasic.Information.IsNumeric(txtno_shares.Text) = False Then
						txtno_shares.Text = ""

						MessageBox.Show("Please enter shares in numeric values only")

						txtno_shares.Focus()
					Else
						'else if (Microsoft.VisualBasic.Information.IsNumeric(txtrate.Text) == false)
						'{
						'    txtrate.Text = "";
						'    MessageBox.Show("Please enter numeric values only");
						'    txtrate.Focus();
						'}
						conComp.con.Open()
						cmd = New SqlCommand("insert into COMPANY_DETAILS(COMPANY_NAME,SHARES,DATE,RATE) values('" + txtcompany_name.Text + "','" + txtno_shares.Text + "', '" + dtpCompany.Text + "', '" + txtrate.Text + "')", conComp.con)
						cmd.ExecuteNonQuery()
						conComp.con.Close()
						MessageBox.Show("Record saved successfully")
						txtcompany_name.Clear()
						txtno_shares.Clear()
						txtrate.Clear()

					End If

				End If

			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conComp.con.Close()
			End Try
			'btnsave.Click(sender, e);


		End Sub

		Private Sub dateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub txtcompany_name_TextChanged(sender As Object, e As EventArgs)

		End Sub

	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
