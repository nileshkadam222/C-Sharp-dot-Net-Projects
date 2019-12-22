
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Shared_Market_System
	Public Partial Class frmbroker_details
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private cmd1 As SqlCommand = Nothing
		Private reader As SqlDataReader = Nothing
		Private conborker_details As New connstring()
		Private x As Integer = 0
		Public Sub New()
			InitializeComponent()
		End Sub



		Private Sub Broker_details_Load(sender As Object, e As EventArgs)
			conborker_details.con.Open()
			Dim rdr As SqlDataReader = Nothing
			'cboclient_name.Items.Clear();


			Try

				Dim cmd1 As New SqlCommand("Select distinct CLIENT_NAME from CLIENT_DETAILS", conborker_details.con)
				'cmd1.ExecuteNonQuery();



				rdr = cmd1.ExecuteReader()

				While rdr.Read()

					cboclient_name.Items.Add(rdr("CLIENT_NAME"))
				End While
				If rdr IsNot Nothing Then
					rdr.Close()
				End If


				cmd = New SqlCommand("select * from broker_details", conborker_details.con)
				rdr = cmd.ExecuteReader()

				If Not rdr.HasRows Then
					x = 1
				Else
					While rdr.Read()
						x = Int32.Parse(rdr("BROKER_CODE").ToString())
						x = x + 1
					End While
					rdr.Close()
				End If





				txtbroker_code.Text = x.ToString()

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conborker_details.con.Close()
			End Try

		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub btnsave_Click(sender As Object, e As EventArgs)
			Try

				Dim y As Integer = 0
				If txtbroker_name.Text = "" Then
					txtbroker_name.Focus()
					MessageBox.Show("Please Enter the broker name")
				ElseIf txtbroker_code.Text = "" Then
					txtbroker_code.Focus()
					MessageBox.Show("Please Enter the broker code")
				ElseIf txtpan_no.Text = "" Then
					txtpan_no.Focus()
					MessageBox.Show("Please Enter the pan numnber")
				ElseIf cboclient_name.Text = "" Then
					cboclient_name.Focus()
					MessageBox.Show("Please select the client name")
				Else
					conborker_details.con.Open()
					'for broker details
					cmd = New SqlCommand("insert into BROKER_DETAILS(BROKER_NAME,BROKER_CODE,PAN_NO,ADDRESS,SHARES,OPENING_RATE,CURRENT_RATE,DATE) values ('" + txtbroker_name.Text + "','" + txtbroker_code.Text + "','" + txtpan_no.Text + "','" + txtadd.Text + "','" + txtshares.Text + "','" + txtopening_rate.Text + "','" + txtcurrent_rate.Text + "','" + dateTimePicker1.Text + "')", conborker_details.con)
					'for broker share details
					Dim newcomm As New SqlCommand("insert into BROKER_SELL_CLIENT(BROKER_CODE,BROKER_NAME,SHARES)values ('" + txtbroker_code.Text + "','" + txtbroker_name.Text + "','" + txtshares.Text + "')", conborker_details.con)

					cmd.ExecuteNonQuery()
					newcomm.ExecuteNonQuery()



					For i As Integer = 0 To lstclient_select.Items.Count - 1

						cmd1 = New SqlCommand("select sr_no=sr_no from list_items ", conborker_details.con)
						reader = cmd1.ExecuteReader()

						' string sr_no=reader["sr_no"].ToString();

						If Not reader.HasRows Then
							y = 1
						Else
							While reader.Read()
								y = Integer.Parse(reader("sr_no").ToString())
								y = y + 1
							End While
						End If

						reader.Close()


						Dim cmd2 As New SqlCommand("insert into LIST_ITEMS(sr_no,BROKER_NAME,CLIENT_NAME)VALUES(" + y + ",'" + txtbroker_name.Text + "','" + lstclient_select.Items(i) + "')", conborker_details.con)


						cmd2.ExecuteNonQuery()
					Next




					'SqlCommand cmd4 = new SqlCommand("insert into BROKER_SHARE_DETAILS(sr_no,BROKER_NAME,SHARES,BUY_RATE,CURRENT_RATE,DATE)values( '" + txtbroker_name.Text + "','" + txtshares.Text + "','" + txtopening_rate.Text + "','" + txtcurrent_rate.Text + "','" + dateTimePicker1.Text + "')", conborker_details.con);
					'cmd4.ExecuteNonQuery();

					MessageBox.Show("Record Saved Successfully")
					x = Int32.Parse(txtbroker_code.Text) + 1

					txtbroker_name.Clear()
					txtbroker_code.Clear()
					txtpan_no.Clear()
					txtadd.Clear()
					txtshares.Clear()
					txtopening_rate.Clear()
					txtcurrent_rate.Clear()
					' cboclient_name.Items.Clear();
					lstclient_all.Items.Clear()
					lstclient_select.Items.Clear()
					cboclient_name.ResetText()


					txtbroker_code.Text = x.ToString()




					txtbroker_name.Focus()
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			Finally
				conborker_details.con.Close()
			End Try

		End Sub

		Private Sub cboclient_name_SelectedIndexChanged(sender As Object, e As EventArgs)
			'conborker_details.con.Open();
			'''/cboadmin_type.Text = "";
			'''/cboadmin_type.Enabled = true;
			'SqlDataReader rdr = null;
			'''/SqlDataReader rdr1 = null;

			'try
			'{
			'    SqlCommand cmd1 = new SqlCommand("select distinct CLIENT_NAME  from CLIENT_DETAILS ", conborker_details.con);

			'    //SqlCommand cmd2 = new SqlCommand("");

			'    //cboadmin_type.Items.Clear();

			'    if (cboclient_name.SelectedIndex == 0)
			'    {
			'        lstclient_all.Items.Clear();
			'        rdr = cmd1.ExecuteReader();
			'        while (rdr.Read())
			'        {
			'            lstclient_all.Items.Add(rdr["CLIENT_NAME"]);
			'        }
			'        if (rdr != null)
			'            rdr.Close();

			'    }



			'    //if (cboclient_name.SelectedIndex == 1)
			'    //{
			'    //    lstclient_all.Items.Clear();
			'    //    rdr = cmd1.ExecuteReader();
			'    //    while (rdr.Read())
			'    //    {
			'    //        lstclient_all.Items.Add(rdr["CLIENT_NAME"]);
			'    //    }
			'    //    if (rdr != null)
			'    //        rdr.Close();

			'    //}

			'}
			'catch (Exception ex)
			'{
			'    MessageBox.Show(ex.Message);

			'}
			'finally
			'{
			'    conborker_details.con.Close();
			'}
		End Sub

		Private Sub btnadd_Click(sender As Object, e As EventArgs)
			'conborker_details.con.Open();

			If cboclient_name.Text <> "" Then
				Dim name As String = cboclient_name.SelectedItem.ToString()
				lstclient_all.Items.Add(name)
			Else
				MessageBox.Show("Please select client name")
			End If



			'if (cboclient_name.SelectedIndex == 0)
			'{

			'    SqlCommand cmd2 = new SqlCommand("insert into BROKER_DETAILS(CLIENT_NAME)values('" + lstclient_all.Text + "'", conborker_details.con);
			'}
			'else
			'{
			'}
			'conborker_details.con.Close();
		End Sub

		Private Sub btnright_Click(sender As Object, e As EventArgs)
			If lstclient_all.Text <> "" Then
				Dim client_name As String = lstclient_all.SelectedItem.ToString()
				lstclient_select.Items.Add(client_name)
				While lstclient_all.SelectedItems.Count > 0


					lstclient_all.Items.Remove(lstclient_all.SelectedItems(0))
				End While
			Else
				MessageBox.Show("Please select client name")
			End If
		End Sub

		Private Sub btnleft_Click(sender As Object, e As EventArgs)

			If lstclient_select.Text <> "" Then
				Dim client_name As String = lstclient_select.SelectedItem.ToString()
				lstclient_all.Items.Add(client_name)
				While lstclient_select.SelectedItems.Count > 0


					lstclient_select.Items.Remove(lstclient_select.SelectedItems(0))
				End While
			Else
				MessageBox.Show("Please select client name")
			End If
		End Sub

		Private Sub frmbroker_details_DoubleClick(sender As Object, e As EventArgs)
			Dim frm As Form = New frmbroker_details()
			frm.Hide()

			Dim frm1 As Form = New frmbroker_update()
			frm1.StartPosition = FormStartPosition.CenterScreen
			frm1.Show()
		End Sub

	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
