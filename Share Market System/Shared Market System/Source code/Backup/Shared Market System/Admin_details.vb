
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Shared_Market_System
	Public Partial Class frmadmin_details
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private cmd1 As SqlCommand = Nothing
		Private rdr As SqlDataReader = Nothing
		Private conadmin As New connstring()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnsave_Click(sender As Object, e As EventArgs)
			Try
				If txtadmin_name.Text = "" Then
					txtadmin_name.Focus()
					MessageBox.Show("Please Enter the admin name")
				ElseIf cboadmin_type.Text = "" Then
					cboadmin_type.Focus()
					MessageBox.Show("Please Enter the admin type")
				ElseIf txtshares.Text = "" Then
					txtshares.Focus()
					MessageBox.Show("Please Enter number of shares")
				Else
					If Microsoft.VisualBasic.Information.IsNumeric(txtadmin_name.Text) = True Then
						txtadmin_name.Text = ""

						MessageBox.Show("Please enter character only")

						txtadmin_name.Focus()

					ElseIf Microsoft.VisualBasic.Information.IsNumeric(txtshares.Text) = False Then
						txtshares.Text = ""

						MessageBox.Show("Please enter numeric values only")

						txtshares.Focus()
					Else
						conadmin.con.Open()

						Dim x As Integer = 0
						cmd1 = New SqlCommand("select * from admin_details", conadmin.con)
						rdr = cmd1.ExecuteReader()

						'rdr.Read();
						If Not rdr.HasRows Then
							x = 1
						Else
							While rdr.Read()
								x = Integer.Parse(rdr("ADMIN_ID").ToString())
								x = x + 1

							End While
						End If
						rdr.Close()


						cmd = New SqlCommand("insert into ADMIN_DETAILS(ADMIN_ID,ADMIN_NAME,ADMIN_TYPE,SHARES,COMPANY_NAME) values('" + x + "','" + txtadmin_name.Text + "', '" + cboadmin_type.Text + "','" + txtshares.Text + "','" + cboCompany_name.Text + "')", conadmin.con)

						cmd.ExecuteNonQuery()

						cmd1 = New SqlCommand("insert into share_DETAILS(ADMIN_ID,ADMIN_NAME,ADMIN_TYPE,SHARES,COMPANY_NAME) values('" + x + "','" + txtadmin_name.Text + "','" + cboadmin_type.Text + "','" + txtshares.Text + "','" + cboCompany_name.Text + "')", conadmin.con)
						cmd1.ExecuteNonQuery()


						conadmin.con.Close()
						MessageBox.Show("Record Saved Successfully")
						clear()

						txtadmin_name.Focus()
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conadmin.con.Close()
			End Try


		End Sub

		Public Sub clear()
			txtadmin_name.Clear()
			txtshares.Clear()
			cboadmin_type.Text = ""
			cboCompany_name.Text = ""
		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		'private void drvadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
		'{

		'}

		Private Sub client_names_SelectedIndexChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub frmadmin_details_Load(sender As Object, e As EventArgs)

			Try
				conadmin.con.Open()
				cmd = New SqlCommand("select distinct COMPANY_NAME from company_details", conadmin.con)
				rdr = cmd.ExecuteReader()
				If Not rdr.HasRows Then
				Else

					While rdr.Read()

						cboCompany_name.Items.Add(rdr("COMPANY_NAME").ToString())
					End While
					rdr.Close()

				End If
			Catch ex As Exception
			Finally
				conadmin.con.Close()
			End Try
		End Sub

		Private Sub cboadmin_type_SelectedIndexChanged(sender As Object, e As EventArgs)
			'conadmin.con.Open();
			'''/cboadmin_type.Text = "";
			'''/cboadmin_type.Enabled = true;

			'''/SqlDataReader rdr1 = null;

			'try
			'{
			'    SqlCommand cmd1 = new SqlCommand("select distinct CLIENT_NAME  from CLIENT_DETAILS WHERE ADMIN_TYPE='"+cboadmin_type.Text+"'", conadmin.con);

			'    //SqlCommand cmd2 = new SqlCommand("");

			'    //cboadmin_type.Items.Clear();

			'    if (cboadmin_type.SelectedIndex == 0)
			'    {
			'        lstclient_names.Items.Clear();
			'        rdr = cmd1.ExecuteReader();
			'        while (rdr.Read())
			'        {
			'            lstclient_names.Items.Add(rdr["CLIENT_NAME"]);
			'        }
			'        if (rdr != null)
			'            rdr.Close();

			'    }



			'    if (cboadmin_type.SelectedIndex == 1)
			'    {
			'        lstclient_names.Items.Clear();
			'        rdr = cmd1.ExecuteReader();
			'        while (rdr.Read())
			'        {
			'            lstclient_names.Items.Add(rdr["CLIENT_NAME"]);
			'        }
			'        if (rdr != null)
			'            rdr.Close();

			'    }

			'}
			'catch (Exception ex)
			'{
			'    MessageBox.Show(ex.Message);

			'}
			'finally
			'{
			'    conadmin.con.Close();
			'}


		End Sub


	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
