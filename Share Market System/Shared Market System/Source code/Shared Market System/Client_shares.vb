
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace Shared_Market_System

	Public Partial Class frmclient_shares
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private adp As SqlDataAdapter = Nothing
		Private ds As New DataSet()
		Private ds1 As New DataSet()
		Private reader As SqlDataReader = Nothing
		Private rdr As SqlDataReader = Nothing


		Private cboadmin_type As New DataGridViewComboBoxColumn()

		Private conclient_shares As New connstring()
		Public Sub New()
			InitializeComponent()
		End Sub

		'    private void btnsave_Click(object sender, EventArgs e)
'        {
'            try
'            {
'                if (cboclient_name.Text == "")
'                {
'                    cboclient_name.Focus();
'                    MessageBox.Show("Please Enter the Client Name");
'                }
'
'                else
'                {
'                    conclient_shares.con.Open();
'                    
'                    for (int i = 0; i < drvclient.Rows.Count-1; i++)
'                    {
'                        //if (drvclient.Rows[i].Cells["Company_name"].Value != null)
'                        //{
'                            //cmd = new SqlCommand("insert into CLIENT_SHARES(CLIENT_NAME,COMPANY_NAME,SHARES_CLIENT,DATE,BUY_RATE,CURRENT_RATE) values('" + cboclient_name.Text + "', '" + drvclient.Rows[i].Cells["Company_name"].Value + "', '" + drvclient.Rows[i].Cells["Shares"].Value + "', '" + drvclient.Rows[i].Cells["Date"].Value + "', '" + drvclient.Rows[i].Cells["Current_rate"].Value + "', '" + drvclient.Rows[i].Cells["Buy_rate"].Value + "')", conclient_shares.con);
'                            //cmd.ExecuteNonQuery();
'
'                        cmd = new SqlCommand("insert into CLIENT_SHARES(CLIENT_NAME,COMPANY_NAME,SHARES,DATE,[BUY_RATE],CURRENT_RATE,ADMIN_NAME) values('" + cboclient_name.Text + "', '" + drvclient.Rows[i].Cells[1].Value + "', '" + drvclient.Rows[i].Cells[2].Value + "', '" + drvclient.Rows[i].Cells[3].Value + "', '" + drvclient.Rows[i].Cells[4].Value + "', '" + drvclient.Rows[i].Cells[5].Value + "','" + drvclient.Rows[i].Cells[6].Value + "')", conclient_shares.con);
'                        cmd.ExecuteNonQuery();
'                        //}
'
'                    }
'                    conclient_shares.con.Close();
'                    MessageBox.Show("Record Saved Successfully");
'                    
'                    drvclient.Columns.Clear();
'                    cboclient_name.ResetText();
'                }
'            }
'            catch (Exception ex)
'            {
'                MessageBox.Show(ex.Message);
'                conclient_shares.con.Close();
'            }
'            finally
'            {
'                conclient_shares.con.Close();
'            }
'        }


		Private Sub cboclient_name_SelectedIndexChanged(sender As Object, e As EventArgs)
			drvclient.Columns.Clear()
			cboCompany_name.Items.Clear()

			conclient_shares.con.Open()
			'drvclient.Visible = true;



			' ds1.Tables.Clear();
			'SqlDataReader rdr1 = null;

			Try
				'SqlCommand cmd1 = new SqlCommand("Select * from CLIENT_DETAILS", conclient_shares.con);
				'adp = new SqlDataAdapter("Select CLIENT_NAME,[SHARES],[DATE],[OPENING_RATE],[CURRENT_RATE] from BROKER_DETAILS where CLIENT_NAME='" + cboclient_name.Text + "'", conclient_shares.con);
				' adp.Fill(ds);


				Dim cmd1 As New SqlCommand("Select distinct company_name from client_details where CLIENT_NAME='" + cboclient_name.Text + "'", conclient_shares.con)
				reader = cmd1.ExecuteReader()

				If Not reader.HasRows Then
				Else
					While reader.Read()
						cboCompany_name.Items.Add(reader("company_name").ToString())
					End While
				End If






					'adp = new SqlDataAdapter("Select [CLIENT NAME]=[CLIENT_NAME],[COMPANY NAME]=[COMPANY_NAME],[SHARES],[date]=[DATE],[BUY RATE]=[SELLING_RATE],[CURRENT_RATE] from BROKER_SELL_CLIENT where CLIENT_NAME='" + cboclient_name.Text + "'", conclient_shares.con);
					'adp.Fill(ds);
					'drvclient.DataSource=ds.Tables[0];
					'ds.Dispose();




				reader.Close()


			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conclient_shares.con.Close()
			End Try



		End Sub

		Public Sub headertext()
			drvclient.Columns(1).HeaderText = drvclient.Columns("Client_name").HeaderText
		End Sub




		Private Sub drvclient_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
			Try
				If drvclient.Columns(e.ColumnIndex).Name.Equals("Sell_client") Then
					'if (drvclient.CurrentRow.Cells["Company_Name"].Value == null)
					'{
					'    //drvadmin.CurrentCell.Value = "";
					'    MessageBox.Show("Please enter Company Name");
					'    SendKeys.Send("{Home}");
					'}
					If drvclient.CurrentRow.Cells(1).Value Is Nothing OrElse Int32.Parse(drvclient.CurrentRow.Cells(1).Value.ToString()) = 0 Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter Valid Shares")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
					ElseIf drvclient.CurrentRow.Cells(2).Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter buy rate")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
					ElseIf drvclient.CurrentRow.Cells(3).Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter Current rate")

						SendKeys.Send("{left}")
					ElseIf drvclient.CurrentRow.Cells(4).Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter Admin Name")

						SendKeys.Send("{left}")
					ElseIf drvclient.CurrentRow.Cells(5).Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter Admin Type")

						SendKeys.Send("{left}")
					Else
						conclient_shares.con.Open()
						For i As Integer = 0 To drvclient.Rows.Count - 2



							cmd = New SqlCommand("update ADMIN_DETAILS set SHARES=SHARES+ '" + drvclient.Rows(i).Cells("SHARES").Value + "'WHERE ADMIN_NAME='" + drvclient.CurrentRow.Cells(4).Value + "' and company_name='" + cboCompany_name.Text + "' and admin_type='" + drvclient.CurrentRow.Cells(5).Value + "' ", conclient_shares.con)
							cmd.ExecuteNonQuery()

							Dim cmd1 As New SqlCommand("update SHARE_DETAILS set SHARES=SHARES+ '" + drvclient.Rows(i).Cells("SHARES").Value + "'WHERE ADMIN_NAME='" + drvclient.CurrentRow.Cells(4).Value + "' and company_name='" + cboCompany_name.Text + "' ", conclient_shares.con)
							cmd1.ExecuteNonQuery()

							'SqlCommand cmd2 = new SqlCommand("update CLIENT_shares set SHARES= SHARES -'" + drvclient.CurrentRow.Cells["SHARES"].Value + "' where CLIENT_NAME='" + cboclient_name.Text + "' and company_name='"+ ", conclient_shares.con);
							'cmd2.ExecuteNonQuery();

							'SqlCommand cmd2 = new SqlCommand("select * from client_shares where client_name='" + cboclient_name.Text + "' and company_name='" + cboCompany_name.Text + "' and admin_name='" + drvclient.CurrentRow.Cells[5].Value + "' and buy_rate='" + drvclient.CurrentRow.Cells[3].Value + "' and current_rate='" + drvclient.CurrentRow.Cells[4].Value + "'", conclient_shares.con);
							'rdr=cmd2.ExecuteReader();



							Dim mycmd As New SqlCommand("select client_id from client_details where CLIENT_NAME='" + cboclient_name.Text + "' and company_name='" + cboCompany_name.Text + "' ", conclient_shares.con)
							rdr = mycmd.ExecuteReader()
							rdr.Read()


							If True Then
								Dim client_id As Integer = Int32.Parse(rdr("client_id").ToString())
								rdr.Close()
								'update
								'while (rdr.Read())
								If True Then

									'SqlCommand newcomm1 = new SqlCommand("update share_details set SHARES=SHARES- '" + drvadmin.CurrentRow.Cells["SHARES"].Value + "' where admin_name='" + cboadmin_name.Text + "' and company_name='" + cbocompany_name.Text + "' and opening_rate='" + drvadmin.CurrentRow.Cells["BUY RATE"].Value + "' and current_rate='" + drvadmin.CurrentRow.Cells["CURRENT RATE"].Value + "'and broker_name='" + drvadmin.CurrentRow.Cells[3].Value + "'", conshare.con);

									Dim newcomm1 As New SqlCommand("update client_shares set SHARES=SHARES- '" + drvclient.CurrentRow.Cells("SHARES").Value + "',BUY_RATE='" + drvclient.CurrentRow.Cells(2).Value + "',CURRENT_RATE='" + drvclient.CurrentRow.Cells(3).Value + "',ADMIN_NAME= '" + drvclient.CurrentRow.Cells(4).Value + "' where client_id='" + client_id + "'", conclient_shares.con)

									newcomm1.ExecuteNonQuery()

									Dim newcomm2 As New SqlCommand("update CLIENT_DETAILS set SHARES=SHARES- '" + drvclient.CurrentRow.Cells("SHARES").Value + "',OPENING_RATE='" + drvclient.CurrentRow.Cells(2).Value + "',CURRENT_RATE='" + drvclient.CurrentRow.Cells(3).Value + "',COMPANY_NAME='" + cboCompany_name.Text + "' where client_id='" + client_id + "'", conclient_shares.con)

									newcomm2.ExecuteNonQuery()

									MessageBox.Show("Data is Updated")
									Me.Close()



								End If
							End If





							'if (drvclient.Columns[e.ColumnIndex].Name == "Sell_client")
							'{
							'    for (int i = 0; i < drvclient.Rows.Count-1; i++)
							'    {

							'        //SqlCommand cmd2 = new SqlCommand("update ADMIN_DETAILS set SHARES= '" + drvclient.Rows[i].Cells["SHARES"].Value + "'",conclient_shares.con);
							'        //SqlCommand cmd3 = new SqlCommand("Select SHARES from ADMIN_DETAILS");
							'        //SqlDataReader rdr2 = cmd3.ExecuteReader(); 
							'        //string old_shares = rdr2(["txtshares.text"]);

							'        //cmd = new SqlCommand("update BROKER_SELL_CLIENT set CURRENT_RATE = '" + drvadmin.Rows[i].Cells["Current_rate"].Value + "'  where COMPANY_NAME2 ='" + drvadmin.Rows[i].Cells["Company_name"].Value + "'", conshare.con);
							'        //SqlCommand cmd1 = new SqlCommand("update CLIENT_DETAILS set CURRENT_RATE = '" + drvadmin.Rows[i].Cells["Current_rate"].Value + "'  where COMPANY_NAME ='" + drvadmin.Rows[i].Cells["Company_name"].Value + "'", conshare.con);
							'        ////SqlCommand cmd2 = new SqlCommand("update ADMIN_DETAILS set ='"+ drvadmin. +"'");
							'        //cmd.ExecuteNonQuery();
							'        //cmd1.ExecuteNonQuery();

							'        cmd = new SqlCommand("update ADMIN_DETAILS set SHARES=SHARES+ '" + drvclient.Rows[i].Cells["SHARES"].Value + "'WHERE ADMIN_NAME='"+drvclient.CurrentRow.Cells[6].Value+"'", conclient_shares.con);
							'        cmd.ExecuteNonQuery();

							'        SqlCommand cmd1 = new SqlCommand("update SHARE_DETAILS set SHARES=SHARES+ '" + drvclient.Rows[i].Cells["SHARES"].Value + "'", conclient_shares.con);
							'        cmd1.ExecuteNonQuery();

							'        SqlCommand cmd2 = new SqlCommand("update CLIENT_DETAILS set SHARES= SHARES -'" + drvclient.CurrentRow.Cells["SHARES"].Value + "' where CLIENT_NAME='" + cboclient_name.Text + "'", conclient_shares.con);
							'        cmd2.ExecuteNonQuery();

							'        MessageBox.Show("Data is Updated");



							'    }
							'    //Inputbox code
							'   // string str = Microsoft.VisualBasic.Interaction.InputBox("Enter the Shares", "SHARES", "SHARES", 500, 300);
							'}

						Next
					End If
				End If

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conclient_shares.con.Close()
			End Try

		End Sub

		Private Sub drvclient_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
			Try
				If drvclient.Columns(e.ColumnIndex).Name = "Shares" Then

					If Microsoft.VisualBasic.Information.IsNumeric(drvclient.CurrentCell.Value) Then
					Else
						drvclient.CurrentCell.Value = ""
						MessageBox.Show("Please enter numeric values")
						SendKeys.Send("{Left}")
					End If
				End If
				If drvclient.Columns(e.ColumnIndex).Name = "Buy_rate" Then

					If Microsoft.VisualBasic.Information.IsNumeric(drvclient.CurrentCell.Value) Then
					Else
						drvclient.CurrentCell.Value = ""
						MessageBox.Show("Please enter numeric values")
						SendKeys.Send("{Left}")
					End If
				End If


				If drvclient.Columns(e.ColumnIndex).Name = "Current_rate" Then

					If Microsoft.VisualBasic.Information.IsNumeric(drvclient.CurrentCell.Value) Then
					Else
						drvclient.CurrentCell.Value = ""
						MessageBox.Show("Please enter numeric values")
						SendKeys.Send("{Left}")
					End If

				End If

			Catch ex As Exception

				MessageBox.Show(ex.Message)

			Finally
			End Try

		End Sub

		Private Sub frmclient_shares_Load(sender As Object, e As EventArgs)
			conclient_shares.con.Open()

			'SqlDataReader rdr1 = null;
			Try
				Dim cmd1 As New SqlCommand("Select CLIENT_NAME from CLIENT_DETAILS", conclient_shares.con)
				'cmd1.ExecuteNonQuery();
				cboclient_name.Items.Clear()


				rdr = cmd1.ExecuteReader()

				While rdr.Read()

					cboclient_name.Items.Add(rdr("CLIENT_NAME"))
				End While
				If rdr IsNot Nothing Then
					rdr.Close()



					'if (drvclient.Columns[0].Name == "Sell_client")
					'{
					'    for (int i = 0; i < drvclient.Rows.Count; i++)
					'    {
					'        cmd = new SqlCommand("update ");
					'        //cmd = new SqlCommand("update BROKER_SELL_CLIENT set CURRENT_RATE = '" + drvadmin.Rows[i].Cells["Current_rate"].Value + "'  where COMPANY_NAME2 ='" + drvadmin.Rows[i].Cells["Company_name"].Value + "'", conshare.con);
					'        //SqlCommand cmd1 = new SqlCommand("update CLIENT_DETAILS set CURRENT_RATE = '" + drvadmin.Rows[i].Cells["Current_rate"].Value + "'  where COMPANY_NAME ='" + drvadmin.Rows[i].Cells["Company_name"].Value + "'", conshare.con);
					'        ////SqlCommand cmd2 = new SqlCommand("update ADMIN_DETAILS set ='"+ drvadmin. +"'");
					'        //cmd.ExecuteNonQuery();
					'        //cmd1.ExecuteNonQuery();

					'        MessageBox.Show("Data is Updated");
					'    }
					'}
				End If

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conclient_shares.con.Close()
			End Try

		End Sub

		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub drvclient_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
			If drvclient.Columns(e.ColumnIndex).Name.Equals("DATE") Then
				dtpdate.Visible = True
			End If
		End Sub


		Private Sub dtpdate_ValueChanged(sender As Object, e As EventArgs)
			drvclient.CurrentRow.Cells("DATE").Value = dtpdate.Text

		End Sub

		Private Sub btnsave_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub cboCompany_name_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim cboadminname As New DataGridViewComboBoxColumn()
			cboadminname.Name = "Adminname"
			Try
				conclient_shares.con.Open()
				Dim cmd1 As New SqlCommand("Select [CLIENT NAME]=[CLIENT_NAME],[SHARES],[BUY_RATE]=[OPENING_RATE],[CURRENT RATE]=[CURRENT_RATE] from client_DETAILS where CLIENT_NAME='" + cboclient_name.Text + "' and company_name='" + cboCompany_name.Text + "' ", conclient_shares.con)
				Dim dr1 As SqlDataReader = cmd1.ExecuteReader()
				Dim dt1 As New DataTable()
				dt1.Load(dr1)
				drvclient.DataSource = dt1
				dr1.Close()


				Dim adp2 As New SqlDataAdapter("select distinct admin_name from admin_details", conclient_shares.con)
				adp2.Fill(ds1)







				cboadminname.DataSource = ds1.Tables(0)
				cboadminname.DisplayMember = "ADMIN_NAME"
				cboadminname.HeaderText = "ADMIN NAME"
				cboadminname.Width = 90

				drvclient.Columns.Add(cboadminname)

				Dim adp4 As New SqlDataAdapter("select distinct ADMIN_TYPE from ADMIN_DETAILS where ADMIN_NAME='" + drvclient.CurrentRow.Cells(4).Value + "'", conclient_shares.con)
				Dim ds4 As New DataSet()
				adp4.Fill(ds4)
				ds4.Dispose()


				cboadmin_type.Name = "admintype"
				cboadmin_type.DataSource = ds4.Tables(0)

				cboadmin_type.DisplayMember = "ADMIN_TYPE"
				cboadmin_type.HeaderText = "TYPE"
				cboadmin_type.Width = 120

				drvclient.Columns.Add(cboadmin_type)



				Dim btnsell As New DataGridViewButtonColumn()
				btnsell.Name = "Sell_client"
				btnsell.HeaderText = "SELL"
				btnsell.Text = "SELL"
				btnsell.Width = 50
				btnsell.UseColumnTextForButtonValue = True
				drvclient.Columns.Add(btnsell)
				'drvclient.Visible = false;
				'headertext();



				For i As Integer = 0 To drvclient.Columns.Count - 1
					Me.drvclient.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable


				Next
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			Finally
				conclient_shares.con.Close()
			End Try
		End Sub

		Private Sub drvclient_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim adp4 As New SqlDataAdapter("select distinct ADMIN_TYPE from ADMIN_DETAILS where ADMIN_NAME='" + drvclient.CurrentRow.Cells(4).Value + "'", conclient_shares.con)
			Dim ds4 As New DataSet()
			adp4.Fill(ds4)
			ds4.Dispose()


			cboadmin_type.DataSource = ds4.Tables(0)

			cboadmin_type.DisplayMember = "ADMIN_TYPE"

		End Sub









	End Class
End Namespace


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
