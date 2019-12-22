
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Shared_Market_System
	Public Partial Class frmbroker_update
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private cmdpro As SqlCommand = Nothing
		Private cmd1 As SqlCommand = Nothing
		Private cmd2 As SqlCommand = Nothing
		Private conborker_details As New connstring()
		Private reader As SqlDataReader = Nothing
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnupdate_Click(sender As Object, e As EventArgs)
			conborker_details.con.Open()
			cmd = New SqlCommand("update BROKER_DETAILS set BROKER_NAME='" + txtbroker_name.Text + "',BROKER_CODE='" + txtbroker_code.Text + "',PAN_NO='" + txtpan_no.Text + "',ADDRESS='" + txtadd.Text + "',SHARES='" + txtshares.Text + "',OPENING_RATE='" + txtopening_rate.Text + "',CURRENT_RATE='" + txtcurrent_rate.Text + "',DATE='" + dateTimePicker1.Text + "' where broker_code='" + txtbroker_code.Text + "'", conborker_details.con)
			cmd.ExecuteNonQuery()

			Dim j As Integer = 0

			While j < listBox1.Items.Count

				For i As Integer = 0 To lstclient_select.Items.Count - 1

					If i < listBox1.Items.Count Then
						cmd1 = New SqlCommand("update list_items set CLIENT_NAME='" + lstclient_select.Items(i) + "',BROKER_NAME='" + txtbroker_name.Text + "' where broker_name='" + cbobroker.Text + "' and sr_no='" + listBox1.Items(j) + "'", conborker_details.con)
							'MessageBox.Show("Data is upadted");
						cmd1.ExecuteNonQuery()
					End If
					j += 1
					If i >= listBox1.Items.Count Then
						Dim x As Integer = 0
						cmd1 = New SqlCommand("select sr_no=max(sr_no) from list_items ", conborker_details.con)
						reader = cmd1.ExecuteReader()


						' string sr_no=reader["sr_no"].ToString();

						If Not reader.HasRows Then
							x = 1
						Else
							While reader.Read()
								x = Integer.Parse(reader("sr_no").ToString())
								x = x + 1
							End While
						End If

						reader.Close()



						cmd2 = New SqlCommand("insert into list_items(sr_no,broker_name,client_name)values('" + x + "','" + txtbroker_name.Text + "','" + lstclient_select.Items(i) + "')", conborker_details.con)

						cmd2.ExecuteNonQuery()






					End If

				Next
			End While

			If listBox1.Items.Count = 0 Then

				For i As Integer = 0 To lstclient_select.Items.Count - 1
					Dim x As Integer = 0
					cmd1 = New SqlCommand("select sr_no=max(sr_no) from list_items ", conborker_details.con)
					reader = cmd1.ExecuteReader()


					' string sr_no=reader["sr_no"].ToString();

					If Not reader.HasRows Then
						x = 1
					Else
						While reader.Read()
							x = Integer.Parse(reader("sr_no").ToString())
							x = x + 1
						End While
					End If

					reader.Close()



					cmd2 = New SqlCommand("insert into list_items(sr_no,broker_name,client_name)values(" + x + ",'" + txtbroker_name.Text + "','" + lstclient_select.Items(i) + "')", conborker_details.con)
						' MessageBox.Show("Data is upadted");
					cmd2.ExecuteNonQuery()
				Next
			End If


			conborker_details.con.Close()
			MessageBox.Show("Data is upadted")

			Me.Close()

			'for clearing ......


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
			cbobroker.ResetText()



		End Sub

		Private Sub frmbroker_update_Load(sender As Object, e As EventArgs)

			listBox1.Hide()
			conborker_details.con.Open()
			Dim rdr As SqlDataReader = Nothing
			Dim rdr1 As SqlDataReader = Nothing
			'cboclient_name.Items.Clear();


			Try
				Dim cmd As New SqlCommand("Select distinct BROKER_NAME from BROKER_DETAILS", conborker_details.con)
				'cmd1.ExecuteNonQuery();



				rdr1 = cmd.ExecuteReader()

				While rdr1.Read()

					cbobroker.Items.Add(rdr1("BROKER_NAME"))
				End While
				If rdr1 IsNot Nothing Then
					rdr1.Close()
				End If




				Dim cmd1 As New SqlCommand("Select distinct CLIENT_NAME from CLIENT_DETAILS", conborker_details.con)
				'cmd1.ExecuteNonQuery();



				rdr = cmd1.ExecuteReader()

				While rdr.Read()

					cboclient_name.Items.Add(rdr("CLIENT_NAME"))
				End While
				If rdr IsNot Nothing Then
					rdr.Close()






				End If

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conborker_details.con.Close()
			End Try
		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub cbobroker_SelectedIndexChanged(sender As Object, e As EventArgs)
			lstclient_select.Items.Clear()
			Try
				conborker_details.con.Open()
				cmd = New SqlCommand("select * from broker_details where BROKER_NAME='" + cbobroker.Text + "'", conborker_details.con)
				reader = cmd.ExecuteReader()

				While reader.Read()
					txtbroker_name.Text = reader("BROKER_NAME").ToString()
					txtbroker_code.Text = reader("BROKER_CODE").ToString()
					txtpan_no.Text = reader("PAN_NO").ToString()
					txtadd.Text = reader("ADDRESS").ToString()
				End While

				reader.Close()
				conborker_details.con.Close()

				conborker_details.con.Open()
				cmd1 = New SqlCommand("select distinct client_name,sr_no from list_items where BROKER_NAME='" + cbobroker.Text + "'", conborker_details.con)
				Dim rdr As SqlDataReader = cmd1.ExecuteReader()

				While rdr.Read()
					listBox1.Items.Add(rdr("sr_no").ToString())
					listBox1.Hide()


					lstclient_select.Items.Add(rdr("client_name").ToString())
				End While
				rdr.Close()
				conborker_details.con.Close()
			Catch ex As Exception
				MessageBox.Show("" + ex)
			Finally
				conborker_details.con.Close()
			End Try

		End Sub

		Private Sub btnadd_Click(sender As Object, e As EventArgs)
			Dim name As String = cboclient_name.SelectedItem.ToString()
			lstclient_all.Items.Add(name)
		End Sub

		Private Sub btnright_Click(sender As Object, e As EventArgs)
			If lstclient_all.Text <> "" Then
				Dim client_name As String = lstclient_all.SelectedItem.ToString()
				lstclient_select.Items.Add(client_name)
				While lstclient_all.SelectedItems.Count > 0


					lstclient_all.Items.Remove(lstclient_all.SelectedItems(0))
				End While
			Else
				MessageBox.Show("Please select client name to add")
			End If
		End Sub

		Private Sub btnleft_Click(sender As Object, e As EventArgs)

			If lstclient_select.Text <> "" Then

				Dim client_name As String = lstclient_select.SelectedItem.ToString()
				lstclient_all.Items.Add(client_name)


				While lstclient_select.SelectedItems.Count > 0

					lstclient_select.Items.Remove(lstclient_select.SelectedItems(0))
					conborker_details.con.Open()
					cmd = New SqlCommand("delete from list_items where client_name='" + client_name + "'", conborker_details.con)
					cmd.ExecuteNonQuery()

					conborker_details.con.Close()
				End While
			Else
				MessageBox.Show("Please select client name to add")
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
