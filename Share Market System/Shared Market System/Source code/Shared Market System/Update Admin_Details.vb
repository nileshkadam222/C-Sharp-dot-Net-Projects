
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Shared_Market_System
	Public Partial Class frmUpdate_Admin_Details
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private cmd1 As SqlCommand = Nothing
		Private rdr As SqlDataReader = Nothing
		Private conupdate_admin As New connstring()
		Private Sub Update_Admin_Details_Load(sender As Object, e As EventArgs)
			Try
				conupdate_admin.con.Open()
				cmd = New SqlCommand("select distinct ADMIN_NAME from admin_details", conupdate_admin.con)
				rdr = cmd.ExecuteReader()
				If Not rdr.HasRows Then
				Else

					While rdr.Read()

						cboAdmin_name.Items.Add(rdr("ADMIN_NAME").ToString())
					End While
					rdr.Close()

				End If
			Catch ex As Exception
			Finally
				conupdate_admin.con.Close()
			End Try
		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub cboAdmin_name_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				conupdate_admin.con.Open()
				cboadmin_type.Items.Clear()
				cboadmin_type.Enabled = True

				cmd = New SqlCommand("select distinct admin_type from admin_details where admin_name='" + cboAdmin_name.Text + "' ", conupdate_admin.con)
				rdr = cmd.ExecuteReader()
				If Not rdr.HasRows Then
				Else

					While rdr.Read()

							'txtCompany_name.Text = rdr["COMPANY_NAME"].ToString();
							'txtshares.Text = rdr["SHARES"].ToString();

						cboadmin_type.Items.Add(rdr("ADMIN_TYPE").ToString())
					End While



					rdr.Close()

				End If
			Catch ex As Exception
			Finally
				conupdate_admin.con.Close()
			End Try
		End Sub

		Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
			Try


				conupdate_admin.con.Open()


				cmd1 = New SqlCommand("select * from admin_details where admin_name='" + cboAdmin_name.Text + "'", conupdate_admin.con)
				rdr = cmd1.ExecuteReader()

				rdr.Read()

				Dim x As Integer = Int32.Parse(rdr("ADMIN_ID").ToString())

				rdr.Close()

				cmd = New SqlCommand("update ADMIN_DETAILS set ADMIN_NAME='" + cboAdmin_name.Text + "',ADMIN_TYPE='" + cboadmin_type.Text + "',SHARES='" + txtshares.Text + "' where admin_id='" + x + "' and COMPANY_NAME='" + txtCompany_name.Text + "' and ADMIN_TYPE='" + cboadmin_type.Text + "' ", conupdate_admin.con)

				cmd1 = New SqlCommand("update SHARE_DETAILS set ADMIN_NAME='" + cboAdmin_name.Text + "',SHARES='" + txtshares.Text + "' where admin_id='" + x + "' and COMPANY_NAME='" + txtCompany_name.Text + "' and ADMIN_TYPE='" + cboadmin_type.Text + "' ", conupdate_admin.con)

				cmd.ExecuteNonQuery()
				cmd1.ExecuteNonQuery()





				conupdate_admin.con.Close()
				MessageBox.Show("Record Updated Successfully")



				Me.Close()

			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conupdate_admin.con.Close()
			End Try
		End Sub

		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Try


				conupdate_admin.con.Open()



				cmd = New SqlCommand("select * from admin_details where admin_name='" + cboAdmin_name.Text + "'", conupdate_admin.con)
				rdr = cmd.ExecuteReader()

				rdr.Read()
				Dim x As Integer = Int32.Parse(rdr("admin_id").ToString())
				rdr.Close()

				cmd1 = New SqlCommand("delete from admin_details where admin_id='" + x + "'", conupdate_admin.con)
				cmd1.ExecuteNonQuery()



				conupdate_admin.con.Close()
				MessageBox.Show("Record Deleted")
					' clear();


				Me.Close()

			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conupdate_admin.con.Close()
			End Try
		End Sub

		Private Sub txtshares_TextChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub txtshares_KeyPress(sender As Object, e As KeyPressEventArgs)
			If (e.KeyChar >= 48 AndAlso e.KeyChar <= 57) OrElse e.KeyChar = 8 Then
				e.KeyChar = e.KeyChar
			Else
				e.KeyChar = Convert.ToChar(0)
				MessageBox.Show("Please enter numeric values")
			End If
		End Sub

		Private Sub cboadmin_type_SelectedIndexChanged(sender As Object, e As EventArgs)

			Try
				conupdate_admin.con.Open()

				cmd = New SqlCommand("select * from admin_details where admin_name='" + cboAdmin_name.Text + "' and admin_type='" + cboadmin_type.Text + "'", conupdate_admin.con)
				rdr = cmd.ExecuteReader()
				If Not rdr.HasRows Then
				Else

					While rdr.Read()

						' cboadmin_type.Text = rdr["ADMIN_TYPE"].ToString();
						txtCompany_name.Text = rdr("COMPANY_NAME").ToString()

						txtshares.Text = rdr("SHARES").ToString()
					End While
					rdr.Close()




					cboadmin_type.Enabled = False

				End If
			Catch ex As Exception
			Finally
				conupdate_admin.con.Close()
			End Try
		End Sub
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
