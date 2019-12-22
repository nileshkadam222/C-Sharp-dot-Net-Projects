
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient



Namespace Shared_Market_System
	Public Partial Class frmbroker_shares
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private cmd1 As SqlCommand = Nothing
		Private cmd4 As SqlCommand = Nothing
		Private comm As SqlCommand = Nothing


		Private ds As New DataSet()
		Private rdr As SqlDataReader = Nothing

		Private ds1 As New DataSet()
		Private conBroker_shares As New connstring()


		Private cboclientcode As New DataGridViewComboBoxColumn()


		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub lblsell_client_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub btnsave_Click(sender As Object, e As EventArgs)
			Try
				If cbobroker.Text = "" Then
					cbobroker.Focus()

					MessageBox.Show("Please enter Broker Name")
				Else



					conBroker_shares.con.Open()
					'cmd = new SqlCommand("insert into BROKER_DETAILS(BROKER_NAME) values('" + cbobroker.Text + "')", conBroker_shares.con);
					'cmd.ExecuteNonQuery();

					'for (int i = 0; i < drv_broker1.Rows.Count - 1; i++)
					'{
					'    //if (drv_broker2.Rows[i].Cells["BROKER_NAME"].Value != null)
					'    //{
					'    SqlCommand cmd1 = new SqlCommand("insert into BROKER_SHARE_DETAILS(BROKER_NAME,COMPANY_NAME,SHARES,BUY_RATE,CURRENT_RATE,DATE) values('" + cbobroker.Text + "','" + drv_broker2.Rows[i].Cells[1].Value + "','" + drv_broker2.Rows[i].Cells[2].Value + "','" + drv_broker2.Rows[i].Cells[3].Value + "','" + drv_broker2.Rows[i].Cells[4].Value + "','" + drv_broker2.Rows[i].Cells[5].Value + "')", conBroker_shares.con);
					'    cmd1.ExecuteNonQuery();
					'    //}                      
					'}




					For i As Integer = 0 To drv_broker2.Rows.Count - 2
						'if (drv_broker2.Rows[i].Cells["BROKER_NAME"].Value != null)
						'{
						Dim cmd2 As New SqlCommand("insert into BROKER_SELL_CLIENT(BROKER_NAME,COMPANY_NAME,SHARES,CURRENT_RATE,BUY_RATE,DATE,CLIENT_NAME,COMMISSION,SELLING_RATE) values('" + cbobroker.Text + "','" + drv_broker2.Rows(i).Cells(1).Value + "','" + drv_broker2.Rows(i).Cells(2).Value + "','" + drv_broker2.Rows(i).Cells(3).Value + "','" + drv_broker2.Rows(i).Cells(4).Value + "','" + drv_broker2.Rows(i).Cells(5).Value + "','" + drv_broker2.Rows(i).Cells(6).Value + "','" + drv_broker2.Rows(i).Cells(7).Value + "','" + drv_broker2.Rows(i).Cells(8).Value + "')", conBroker_shares.con)
							'}                      
						cmd2.ExecuteNonQuery()
					Next
					conBroker_shares.con.Close()
					MessageBox.Show("Record Saved Successfully")
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conBroker_shares.con.Close()
			End Try
		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub


		Private Sub frmbroker_Load(sender As Object, e As EventArgs)
			conBroker_shares.con.Open()


			Try
				cbobroker.Items.Clear()

				cmd1 = New SqlCommand("Select DISTINCT BROKER_NAME from BROKER_DETAILS", conBroker_shares.con)



				rdr = cmd1.ExecuteReader()

				While rdr.Read()

					cbobroker.Items.Add(rdr("BROKER_NAME"))
				End While
				If rdr IsNot Nothing Then
					rdr.Close()
				End If

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conBroker_shares.con.Close()
			End Try

		End Sub

		Private Sub cbobroker_SelectedIndexChanged(sender As Object, e As EventArgs)
			conBroker_shares.con.Open()
			'drv_broker1.Columns.Clear();
			drv_broker2.Columns.Clear()
			cbocompany_name.Items.Clear()
			Dim ds2 As New DataSet()
			ds2.Clear()
			ds1.Clear()

			Try


				' 
				'SqlDataAdapter adp1 = new SqlDataAdapter("select [COMPANY NAME]=COMPANY_NAME,SHARES,[BUY RATE]=OPENING_RATE,[CURRENT RATE]=CURRENT_RATE,DATE from SHARE_DETAILS where BROKER_NAME='" + cbobroker.Text + "'", conBroker_shares.con);
				Dim adp1 As New SqlDataAdapter("select [COMPANY NAME]=COMPANY_NAME,SHARES,[BUY RATE]=OPENING_RATE,[CURRENT RATE]=CURRENT_RATE,DATE from BROKER_DETAILS where BROKER_NAME='" + cbobroker.Text + "'", conBroker_shares.con)
				adp1.Fill(ds1)

				drv_broker1.DataSource = ds1.Tables(0)

				ds1.Dispose()
				'2nd grid- broker sells shares to client

				Dim cmd As New SqlCommand("select distinct company_name from share_details where BROKER_NAME='" + cbobroker.Text + "'", conBroker_shares.con)

				rdr = cmd.ExecuteReader()

				While rdr.Read()

					cbocompany_name.Items.Add(rdr("company_name").ToString())
				End While
				rdr.Close()







				For i As Integer = 0 To drv_broker2.Columns.Count - 1
					Me.drv_broker2.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable


				Next
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			Finally
				conBroker_shares.con.Close()
			End Try
		End Sub

		Private Sub drv_broker1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

		End Sub

		Private Sub drv_broker2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
			conBroker_shares.con.Open()
			If drv_broker2.Columns(e.ColumnIndex).Name = "sell_broker2" Then



				If drv_broker2.CurrentRow.Cells(3).Value Is Nothing Then
					'drvadmin.CurrentCell.Value = "";
					MessageBox.Show("Please enter client Name")
					SendKeys.Send("{LEFT}")
				ElseIf drv_broker2.CurrentRow.Cells("SHARES").Value Is Nothing OrElse Int32.Parse(drv_broker2.CurrentRow.Cells("SHARES").Value.ToString()) = 0 Then
					'drvadmin.CurrentCell.Value = "";
					MessageBox.Show("Please enter Valid Shares")
					SendKeys.Send("{left}")
					SendKeys.Send("{left}")
					SendKeys.Send("{left}")
				ElseIf drv_broker2.CurrentRow.Cells(2).Value Is Nothing Then
					'drvadmin.CurrentCell.Value = "";
					MessageBox.Show("Please enter buy rate")
					SendKeys.Send("{left}")
					SendKeys.Send("{left}")
				ElseIf drv_broker2.CurrentRow.Cells(1).Value Is Nothing Then
					'drvadmin.CurrentCell.Value = "";
					MessageBox.Show("Please enter Current rate")
						' SendKeys.Send("{left}");
					SendKeys.Send("{left}")

				ElseIf drv_broker2.CurrentRow.Cells(6).Value Is Nothing Then
					'drvadmin.CurrentCell.Value = "";
					MessageBox.Show("Please enter Client ID")
						' SendKeys.Send("{left}");
					SendKeys.Send("{left}")
				Else



					'cmd = new SqlCommand("update CLIENT_SHARES set SHARES= SHARES+'" +drv_broker2.CurrentRow.Cells["SHARES"].Value.ToString() + "', BUY_RATE = '" + drv_broker2.CurrentRow.Cells["BUY RATE"].Value + "', CURRENT_RATE = '" + drv_broker2.CurrentRow.Cells["CURRENT RATE"].Value + "',company_name='" + cbocompany_name.Text + "' where client_name='" + drv_broker2.CurrentRow.Cells["clientname"].Value + "' and client_id='" + drv_broker2.CurrentRow.Cells[6].Value + "'", conBroker_shares.con);
					'cmd.ExecuteNonQuery();

					cmd = New SqlCommand("update CLIENT_DETAILS set SHARES=SHARES+ '" + drv_broker2.CurrentRow.Cells("SHARES").Value.ToString() + "',company_name='" + cbocompany_name.Text + "',OPENING_RATE = '" + drv_broker2.CurrentRow.Cells("BUY RATE").Value + "',CURRENT_RATE = '" + drv_broker2.CurrentRow.Cells("CURRENT RATE").Value + "' where client_name='" + drv_broker2.CurrentRow.Cells("clientname").Value + "' and client_id='" + drv_broker2.CurrentRow.Cells(6).Value + "'", conBroker_shares.con)
					cmd.ExecuteNonQuery()


					cmd1 = New SqlCommand("update BROKER_DETAILS set SHARES= SHARES -'" + drv_broker2.CurrentRow.Cells("SHARES").Value + "',DATE='" + dtpDate.Value + "' where OPENING_RATE = '" + drv_broker2.CurrentRow.Cells("BUY RATE").Value + "' and CURRENT_RATE = '" + drv_broker2.CurrentRow.Cells("CURRENT RATE").Value + "' and company_name='" + cbocompany_name.Text + "'", conBroker_shares.con)
					cmd1.ExecuteNonQuery()



					Dim mycmd As New SqlCommand("select BROKER_CODE from BROKER_DETAILS where BROKER_NAME='" + cbobroker.Text + "' and company_name='" + cbocompany_name.Text + "' ", conBroker_shares.con)
					rdr = mycmd.ExecuteReader()

					If Not rdr.HasRows Then
					Else
						rdr.Read()
						Dim broker_code As Integer = Int32.Parse(rdr("BROKER_CODE").ToString())
						rdr.Close()

						Dim cmd3 As New SqlCommand("update BROKER_SELL_CLIENT set SHARES=SHARES - '" + drv_broker2.CurrentRow.Cells("SHARES").Value + "', BUY_RATE = '" + drv_broker2.CurrentRow.Cells("BUY RATE").Value + "', CURRENT_RATE = '" + drv_broker2.CurrentRow.Cells("CURRENT RATE").Value + "' where BROKER_CODE='" + broker_code + "'", conBroker_shares.con)

							'SqlCommand cmd1 = new SqlCommand("update CLIENT_DETAILS set SHARES= SHARES +'" + drv_broker2.CurrentRow.Cells["SHARES"].Value + "'  where CLIENT_NAME='" + drv_broker2.CurrentRow.Cells[6].Value + "'", conBroker_shares.con);
							'cmd1.ExecuteNonQuery();

							'SqlCommand cmd2 = new SqlCommand("update BROKER_DETAILS set SHARES= SHARES -'" + drv_broker2.CurrentRow.Cells["SHARES"].Value + "', OPENING_RATE = '" + drv_broker2.CurrentRow.Cells["BUY RATE"].Value + "', CURRENT_RATE = '" + drv_broker2.CurrentRow.Cells["CURRENT RATE"].Value + "' where BROKER_NAME='" + cbobroker.Text + "'", conBroker_shares.con);
							'cmd2.ExecuteNonQuery();

						cmd3.ExecuteNonQuery()
					End If




					'comm = new SqlCommand("select * from broker_sell_client where broker_name='" + cbobroker.Text + "' and client_name='" + drv_broker2.CurrentRow.Cells[3].Value + "'and company_name='" + cbocompany_name.Text + "' and current_rate='" + drv_broker2.CurrentRow.Cells["CURRENT RATE"].Value + "'and buy_rate='" + drv_broker2.CurrentRow.Cells["BUY RATE"].Value + "' ", conBroker_shares.con);
					'rdr = comm.ExecuteReader();


					'if (!rdr.HasRows)
					'{
					'    rdr.Close();
					'    for (int i = 0; i < drv_broker2.Rows.Count - 1; i++)
					'    {
					'        //if (drv_broker2.Rows[i].Cells["BROKER_NAME"].Value != null)
					'        //{
					'        SqlCommand cmd2 = new SqlCommand("insert into BROKER_SELL_CLIENT(BROKER_NAME,COMPANY_NAME,SHARES,CURRENT_RATE,BUY_RATE,DATE,CLIENT_NAME,COMMISSION,SELLING_RATE) values('" + cbobroker.Text + "','" + cbocompany_name.Text + "','" + drv_broker2.Rows[i].Cells["shares"].Value + "','" + drv_broker2.Rows[i].Cells["CURRENT RATE"].Value + "','" + drv_broker2.Rows[i].Cells["BUY RATE"].Value + "','" + dtpDate.Value + "','" + drv_broker2.Rows[i].Cells[3].Value + "','" + drv_broker2.Rows[i].Cells[4].Value + "','" + drv_broker2.Rows[i].Cells[5].Value + "')", conBroker_shares.con);
					'        cmd2.ExecuteNonQuery();
					'        //}                      
					'    }
					'}
					'else
					'{
					'    rdr.Close();

					'    //while (rdr.Read())

					'    {
					'        SqlCommand cmd3 = new SqlCommand("update BROKER_SELL_CLIENT set SHARES= '" + drv_broker2.CurrentRow.Cells["SHARES"].Value + "', BUY_RATE = '" + drv_broker2.CurrentRow.Cells["BUY RATE"].Value + "', CURRENT_RATE = '" + drv_broker2.CurrentRow.Cells["CURRENT RATE"].Value + "' where BROKER_NAME='" + cbobroker.Text + "'", conBroker_shares.con);
					'        cmd3.ExecuteNonQuery();
					'    }


					'}
					'rdr.Close();

					'updating shares in broker share details.......

					'SqlCommand newcomm = new SqlCommand("select * from broker_share_details where broker_name='" + cbobroker.Text + "' and company_name='" + cbocompany_name.Text + "' ", conBroker_shares.con);
					'rdr = comm.ExecuteReader();

					'if (!rdr.HasRows)
					'{
					'    rdr.Close();
					'    for (int i = 0; i < drv_broker2.Rows.Count - 1; i++)
					'    {
					'        //if (drv_broker2.Rows[i].Cells["BROKER_NAME"].Value != null)
					'        //{
					'         cmd4 = new SqlCommand("insert into broker_share_details(BROKER_NAME,COMPANY_NAME,SHARES)values('" + cbobroker.Text + "','" + cbocompany_name.Text + "','" + drv_broker2.Rows[i].Cells["shares"].Value + "')", conBroker_shares.con);
					'         cmd4.ExecuteNonQuery();
					'        //}                      
					'    }
					'}
					'else
					'{
					'    //rdr.Read();
					'    while (rdr.Read())
					'    {

					'        cmd4 = new SqlCommand("update BROKER_SHARE_DETAILS set SHARES= SHARES -'" + drv_broker2.CurrentRow.Cells["SHARES"].Value + "' where BROKER_NAME='" + cbobroker.Text + "' and company_name='"+cbocompany_name.Text+"' ", conBroker_shares.con);
					'        cmd4.ExecuteNonQuery();

					'    }


					'}
					'rdr.Close();


					MessageBox.Show("Data is updated")


						'for (int i = 0; i < drv_broker2.Rows.Count; i++)
						'{
						'    SqlCommand cmd2 = new SqlCommand("insert into BROKER_SELL_CLIENT(BROKER_NAME,SHARES,DATE,CURRENT_RATE,BUY_RATE,CLIENT_NAME,COMMISSION,SELLING_RATE) values('" + cbobroker.Text + "','" + drv_broker2.Rows[i].Cells["Shares"].Value + "','" + drv_broker2.Rows[i].Cells["Date"].Value + "','" + drv_broker2.Rows[i].Cells["Current_rate"].Value + "','" + drv_broker2.Rows[i].Cells["Buy_rate"].Value + "','" + drv_broker2.Rows[i].Cells["CLIENT_NAME"].Value + "','" + drv_broker2.Rows[i].Cells["COMMISSION"].Value + "','" + drv_broker2.Rows[i].Cells["SELLING_RATE"].Value + "')", conBroker_shares.con);
						'    cmd2.ExecuteNonQuery();
						'    MessageBox.Show("Record Saved Successfully");
						'}
					Me.Close()

				End If
			End If
			conBroker_shares.con.Close()

		End Sub
		Private Sub btnviewall_Click(sender As Object, e As EventArgs)


			Dim adp As SqlDataAdapter = Nothing
			Dim ds1 As New DataSet()

			cbobroker.SelectedIndex = -1


			Try


				adp = New SqlDataAdapter("select [BROKER NAME]=[BROKER_NAME],[COMPANY NAME]=COMPANY_NAME,SHARES,[BUY RATE]=OPENING_RATE,[CURRENT RATE]=CURRENT_RATE,DATE from BROKER_DETAILS", conBroker_shares.con)
				adp.Fill(ds1)
				conBroker_shares.con.Open()




				drv_broker1.DataSource = ds1.Tables(0)
			Catch ex As Exception
				' Print error message
				MessageBox.Show(ex.Message)
			Finally
				conBroker_shares.con.Close()
			End Try
		End Sub

		Private Sub drv_broker2_CellLeave(sender As Object, e As DataGridViewCellEventArgs)

		End Sub

		Private Sub drv_broker2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
			For i As Integer = 0 To drv_broker2.Rows.Count - 2
				If drv_broker2.Rows(i).Cells("CURRENT RATE").Value IsNot Nothing AndAlso drv_broker2.Rows(i).Cells("commission").Value IsNot Nothing Then
					Dim current_rate As Double = Double.Parse(drv_broker2.Rows(i).Cells("CURRENT RATE").Value.ToString())
					Dim commission As Double = Double.Parse(drv_broker2.Rows(i).Cells("commission").Value.ToString())
					Dim ans As Double = (current_rate * commission) / 100

					drv_broker2.Rows(i).Cells("selling_rate").Value = ans.ToString()
				Else

					If drv_broker2.Rows(i).Cells("CURRENT RATE").Value Is Nothing Then
						drv_broker2.Rows(i).Cells("CURRENT RATE").Value = 0
						drv_broker2.Rows(i).Cells("selling_rate").Value = 0
					End If
					If drv_broker2.Rows(i).Cells("commission").Value Is Nothing Then
						drv_broker2.Rows(i).Cells("commission").Value = 0
						drv_broker2.Rows(i).Cells("selling_rate").Value = 0
					End If
				End If
			Next


		End Sub

		Private Sub drv_broker2_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
			'if (drv_broker2.Columns[e.ColumnIndex].Name.Equals("DATE"))
			'{
			'    dtpdate.Visible = true;
			'}
		End Sub

		Private Sub dtpdate_ValueChanged(sender As Object, e As EventArgs)
			'drv_broker2.CurrentRow.Cells["DATE"].Value = dtpdate.Text;
		End Sub

		Private Sub dtpdate1_ValueChanged(sender As Object, e As EventArgs)
			Try

				If True Then
					drv_broker1.CurrentRow.Cells("DATE").Value = dtpdate1.Text
				End If

			Catch ex As Exception
				MessageBox.Show("Please select the date")
			End Try

		End Sub

		Private Sub drv_broker1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
			If drv_broker1.Columns(e.ColumnIndex).Name.Equals("DATE") Then
				dtpdate1.Visible = True
			End If
		End Sub

		Private Sub btnsave1_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub drv_broker2_SelectionChanged(sender As Object, e As EventArgs)

		End Sub

		Private Sub cbocompany_name_SelectedIndexChanged(sender As Object, e As EventArgs)

			drv_broker2.Columns.Clear()
			Try
				conBroker_shares.con.Open()
				Dim adp2 As New SqlDataAdapter("select [SHARES],[CURRENT RATE]=[CURRENT_RATE],[BUY RATE]=[Opening_RATE] from BROKER_DETAILS where BROKER_NAME='" + cbobroker.Text + "' and company_name='" + cbocompany_name.Text + "'", conBroker_shares.con)
				Dim ds2 As New DataSet()
				adp2.Fill(ds2)

				drv_broker2.DataSource = ds2.Tables(0)
				ds2.Dispose()


				Dim adp3 As New SqlDataAdapter("select distinct CLIENT_NAME from LIST_ITEMS where BROKER_NAME='" + cbobroker.Text + "'", conBroker_shares.con)
				Dim ds3 As New DataSet()
				adp3.Fill(ds3)
				ds3.Dispose()

				Dim cboclientname As New DataGridViewComboBoxColumn()
				cboclientname.Name = "clientname"
				cboclientname.DataSource = ds3.Tables(0)

				cboclientname.DisplayMember = "CLIENT_NAME"
				cboclientname.HeaderText = "CLIENT NAME"
				cboclientname.Width = 90

				drv_broker2.Columns.Add(cboclientname)


				Dim txtcommission As New DataGridViewTextBoxColumn()
				txtcommission.Name = "Commission"
				txtcommission.HeaderText = "COMMISSION"
				txtcommission.Width = 90
				drv_broker2.Columns.Add(txtcommission)

				Dim txtselling_rate As New DataGridViewTextBoxColumn()
				txtselling_rate.Name = "Selling_rate"
				txtselling_rate.HeaderText = "SELLING RATE"
				txtselling_rate.Width = 90
				drv_broker2.Columns.Add(txtselling_rate)


				cboclientcode.Name = "clientcode"
				' cbobroker_code.DataSource = ds4.Tables[0];

				'cbobroker_code.DisplayMember = "broker_code";
				cboclientcode.HeaderText = "CLIENT ID"
				cboclientcode.Width = 120

				drv_broker2.Columns.Add(cboclientcode)

				Dim btnsell As New DataGridViewButtonColumn()
				btnsell.Name = "sell_broker2"
				btnsell.HeaderText = "Sell"
				btnsell.Text = "Sell"
				btnsell.Width = 50
				btnsell.UseColumnTextForButtonValue = True
				drv_broker2.Columns.Add(btnsell)



				For i As Integer = 0 To drv_broker1.Columns.Count - 1
					Me.drv_broker1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
				Next
				For i As Integer = 0 To drv_broker2.Columns.Count - 1
					Me.drv_broker2.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable

				Next
			Catch ex As Exception
				MessageBox.Show("error" + ex)
			Finally
				conBroker_shares.con.Close()
			End Try
		End Sub

		Private Sub drv_broker2_CellClick(sender As Object, e As DataGridViewCellEventArgs)


			Dim adp4 As New SqlDataAdapter("select CLIENT_ID from CLIENT_details where CLIENT_NAME='" + drv_broker2.CurrentRow.Cells(3).Value + "'", conBroker_shares.con)
			Dim ds4 As New DataSet()
			adp4.Fill(ds4)
			ds4.Dispose()



			cboclientcode.DataSource = ds4.Tables(0)

			cboclientcode.DisplayMember = "CLIENT_ID"

		End Sub

		Private Sub drv_broker2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

		End Sub

		Private Sub drv_broker1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)

		End Sub

		'private void btnsave1_Click(object sender, EventArgs e)
		'{

		'        conBroker_shares.con.Open();


		'        for (int i = 0; i < drv_broker1.Rows.Count-1; i++)
		'        {
		'            //if (drv_broker2.Rows[i].Cells["BROKER_NAME"].Value == null)
		'            //{
		'            SqlCommand cmd1 = new SqlCommand("insert into BROKER_SHARE_DETAILS(BROKER_NAME,COMPANY_NAME,SHARES,BUY_RATE,CURRENT_RATE,DATE) values('" + drv_broker2.Rows[i].Cells[0].Value + "','" + drv_broker2.Rows[i].Cells[1].Value + "','" + drv_broker2.Rows[i].Cells[2].Value + "','" + drv_broker2.Rows[i].Cells[3].Value + "','" + drv_broker2.Rows[i].Cells[4].Value + "','" + drv_broker2.Rows[i].Cells[5].Value + "')", conBroker_shares.con);
		'            cmd1.ExecuteNonQuery();
		'        //}                      
		'        }
		'        conBroker_shares.con.Close();

		'}




	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
