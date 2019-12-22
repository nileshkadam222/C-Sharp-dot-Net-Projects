
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient



Namespace Shared_Market_System
	Public Partial Class frmShare_details
		Inherits Form
		Private con As SqlConnection = Nothing
		Private cmd As SqlCommand = Nothing
		Private adp As SqlDataAdapter = Nothing
		Private ds1 As New DataSet()
		Private reader As SqlDataReader = Nothing
		Private reader1 As SqlDataReader = Nothing
		Private rdr As SqlDataReader = Nothing
		Private conshare As New connstring()

		Private cmd1 As New SqlCommand()

		Private cbobroker_code As New DataGridViewComboBoxColumn()

		Private y As Integer = 0
		Public Sub New()
				'this.drvadmin.Dock = DockStyle.Fill;
				'this.Controls.Add(drvadmin);
				'this.Load += new EventHandler(frmShare_details);
				'this.Text = "drvadmin validation demo (disallows empty CompanyName)";
			InitializeComponent()
		End Sub

		Private Sub drvadmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)





		End Sub

		Private Sub btnsave_Click(sender As Object, e As EventArgs)
			Try


				'if (txtadmin_name.Text == "")
				'{
				'    txtadmin_name.Focus();
				'    MessageBox.Show("Please Enter Admin Name");
				'}

				'else
				'{

				conshare.con.Open()

				For i As Integer = 0 To drvadmin.Rows.Count - 2

					If drvadmin.Rows(i).Cells(5).Value IsNot Nothing Then
						'SqlCommand cmd1 = new SqlCommand("insert into SHARE_DETAILS(ADMIN_NAME, COMPANY_NAME, SHARES, OPENING_RATE, CURRENT_RATE) values('" + txtadmin_name.Text + "','" + drvadmin.Rows[i].Cells["Company_name"].Value + "', '" + drvadmin.Rows[i].Cells["Shares"].Value + "', '" + drvadmin.Rows[i].Cells["Opening_rate"].Value + "', '" + drvadmin.Rows[i].Cells["Current_rate"].Value + "')", conshare.con);
						Dim cmd1 As New SqlCommand("update SHARE_DETAILS set ADMIN_NAME='" + drvadmin.Rows(i).Cells("ADMIN NAME").Value + "',SHARES='" + drvadmin.Rows(i).Cells("SHARES").Value + "',OPENING_RATE='" + drvadmin.Rows(i).Cells("OPENING RATE").Value + "',CURRENT_RATE='" + drvadmin.Rows(i).Cells("CURRENT RATE").Value + "',BROKER_NAME='" + drvadmin.Rows(i).Cells(6).Value + "' where COMPANY_NAME ='" + drvadmin.Rows(i).Cells(5).Value + "'", conshare.con)
						cmd1.ExecuteNonQuery()
						MessageBox.Show("Record Updated Successfully")

					End If
				Next

					' }


				conshare.con.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				conshare.con.Close()
			End Try


		End Sub
		Private Sub drvadmin_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)
			'if (drvadmin.Columns[0].Name.Equals("Company_name"))
			'{
			'    if (drvadmin.CurrentCell == null || drvadmin.CurrentCell.Value == null)
			'    {
			'        drvadmin.CurrentCell.Value = "";
			'        MessageBox.Show("Please enter Company Name");
			'        SendKeys.Send("{Left}");
			'    }
			'    else
			'    {

			'    }
			'}


			'catch (Exception ex)
			'{
			'    MessageBox.Show(ex.Message);
			'}


		End Sub



		Private Sub btnexit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub drvadmin_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
			Try
				conshare.con.Open()
				If drvadmin.Columns(e.ColumnIndex).Name.Equals("sell_admin") Then
					If drvadmin.CurrentRow.Cells(4).Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter broker Name")
						SendKeys.Send("{LEFT}")

					ElseIf drvadmin.CurrentRow.Cells(5).Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter broker code")
						SendKeys.Send("{LEFT}")
					ElseIf drvadmin.CurrentRow.Cells("SHARES").Value Is Nothing OrElse Int32.Parse(drvadmin.CurrentRow.Cells("SHARES").Value.ToString()) = 0 Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter Valid Shares")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
					ElseIf drvadmin.CurrentRow.Cells("BUY RATE").Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter buy rate")
						SendKeys.Send("{left}")
						SendKeys.Send("{left}")
					ElseIf drvadmin.CurrentRow.Cells("CURRENT RATE").Value Is Nothing Then
						'drvadmin.CurrentCell.Value = "";
						MessageBox.Show("Please enter Current rate")
							' SendKeys.Send("{left}");
						SendKeys.Send("{left}")
					Else





						Dim cmd3 As New SqlCommand("update COMPANY_DETAILS SET SHARES= SHARES-'" + drvadmin.CurrentRow.Cells("SHARES").Value + "' WHERE COMPANY_NAME='" + cbocompany_name.Text + "'", conshare.con)

						' SqlCommand cmd4 = new SqlCommand("update share_DETAILS SET SHARES= SHARES-'" + drvadmin.CurrentRow.Cells["SHARES"].Value + "' WHERE admin_name='"+cboadmin_name.Text+"' and COMPANY_NAME='" + cbocompany_name.Text + "'", conshare.con);


								'if (drvadmin.Rows[i].Cells["shares"].Value != null)
								'{

								'    SqlCommand cmd5 = new SqlCommand("update SHARE_DETAILS set ADMIN_NAME='" + cboadmin_name.Text + "',SHARES='" + drvadmin.Rows[i].Cells["SHARES"].Value + "',OPENING_RATE='" + drvadmin.Rows[i].Cells["BUY RATE"].Value + "',CURRENT_RATE='" + drvadmin.Rows[i].Cells["CURRENT RATE"].Value + "',BROKER_NAME='" + drvadmin.Rows[i].Cells[3].Value + "' where COMPANY_NAME ='" + cbocompany_name.Text+ "'", conshare.con);
								'    cmd5.ExecuteNonQuery();

								'}

						For i As Integer = 0 To drvadmin.Rows.Count - 2
						Next

						'SqlCommand cmd2 = new SqlCommand("update CLIENT_SHARES set CURRENT_RATE = '" + drvadmin.Rows[i].Cells["Current rate"].Value + "'  where COMPANY_NAME ='" + drvadmin.Rows[i].Cells["Company name"].Value + "'", conshare.con);
						Dim cmd2 As New SqlCommand("update ADMIN_DETAILS set SHARES = SHARES-'" + drvadmin.CurrentRow.Cells("SHARES").Value + "' where ADMIN_NAME='" + cboadmin_name.Text + "' and company_name='" + cbocompany_name.Text + "' ", conshare.con)


						' cmd1.ExecuteNonQuery();

						cmd2.ExecuteNonQuery()
						cmd3.ExecuteNonQuery()
						'cmd4.ExecuteNonQuery();




						'}


						'SqlCommand mycmd = new SqlCommand("select * from share_details where admin_name='" + cboadmin_name.Text + "' and company_name='" + cbocompany_name.Text + "' and broker_name='" + drvadmin.CurrentRow.Cells[3].Value + "' and opening_rate='" + drvadmin.CurrentRow.Cells[2].Value + "' and current_rate='" + drvadmin.CurrentRow.Cells[1].Value + "'", conshare.con);

						Dim mycmd As New SqlCommand("select admin_id from share_details where admin_name='" + cboadmin_name.Text + "' and company_name='" + cbocompany_name.Text + "' and admin_type='" + drvadmin.CurrentRow.Cells(3).Value + "' ", conshare.con)
						rdr = mycmd.ExecuteReader()
						rdr.Read()

						'if (!rdr.HasRows)
						'{
						'    rdr.Close();
						'    //insert 

						'    //for (int i = 0; i < drvadmin.Rows.Count - 1; i++)
						'    {
						'        cmd1 = new SqlCommand("select * from share_details ", conshare.con);
						'        reader = cmd1.ExecuteReader();

						'        // string sr_no=reader["sr_no"].ToString();

						'        if (!reader.HasRows)
						'        {
						'            y = 1;
						'        }
						'        else
						'        {
						'            while (reader.Read())
						'            {
						'                y = int.Parse(reader["ADMIN_ID"].ToString());
						'                y = y + 1;
						'            }
						'        }

						'        reader.Close();
						'        SqlCommand newcomm = new SqlCommand("INSERT INTO [share_details]([ADMIN_ID],[ADMIN_NAME],[SHARES],[DATE],[OPENING_RATE],[CURRENT_RATE],[COMPANY_NAME],[BROKER_NAME])VALUES("+y+",'" + cboadmin_name.Text + "','" + drvadmin.CurrentRow.Cells["shares"].Value + "','" + dtpdate.Value + "','" + drvadmin.CurrentRow.Cells[2].Value + "','" + drvadmin.CurrentRow.Cells[1].Value + "','" + cbocompany_name.Text + "','" + drvadmin.CurrentRow.Cells[3].Value + "') ", conshare.con);
						'        newcomm.ExecuteNonQuery();
						'    }
						'}
						'else
						If True Then
							Dim admin_id As Integer = Int32.Parse(rdr("admin_id").ToString())
							rdr.Close()
							'update
							'while (rdr.Read())
							If True Then

								'SqlCommand newcomm1 = new SqlCommand("update share_details set SHARES=SHARES- '" + drvadmin.CurrentRow.Cells["SHARES"].Value + "' where admin_name='" + cboadmin_name.Text + "' and company_name='" + cbocompany_name.Text + "' and opening_rate='" + drvadmin.CurrentRow.Cells["BUY RATE"].Value + "' and current_rate='" + drvadmin.CurrentRow.Cells["CURRENT RATE"].Value + "'and broker_name='" + drvadmin.CurrentRow.Cells[3].Value + "'", conshare.con);

								Dim newcomm1 As New SqlCommand("update share_details set SHARES=SHARES- '" + drvadmin.CurrentRow.Cells("SHARES").Value + "',date='" + dtpdate.Value + "',OPENING_RATE='" + drvadmin.CurrentRow.Cells(2).Value + "',CURRENT_RATE='" + drvadmin.CurrentRow.Cells(1).Value + "',BROKER_NAME= '" + drvadmin.CurrentRow.Cells(4).Value + "' where admin_id='" + admin_id + "'", conshare.con)


								Dim newcomm2 As New SqlCommand("update BROKER_DETAILS set SHARES=SHARES+ '" + drvadmin.CurrentRow.Cells("SHARES").Value + "',date='" + dtpdate.Value + "',OPENING_RATE='" + drvadmin.CurrentRow.Cells(2).Value + "',CURRENT_RATE='" + drvadmin.CurrentRow.Cells(1).Value + "',company_name='" + cbocompany_name.Text + "' where BROKER_NAME= '" + drvadmin.CurrentRow.Cells(4).Value + "' and broker_code='" + drvadmin.CurrentRow.Cells(5).Value + "'", conshare.con)




								'SqlCommand cmd4 = new SqlCommand("select * from share_details where admin_id='" + admin_id + "'", conshare.con);
								'rdr = cmd4.ExecuteNonQuery();
								'rdr.Read();
								'int broker_shares=Int32.Parse(rdr["shares"].ToString());
								'string company_name = rdr["company_name"].ToString();
								'string opening_rate = rdr["OPENING_RATE"].ToString();
								'string current_rate = rdr["CURRENT_RATE"].ToString();



								newcomm1.ExecuteNonQuery()
								newcomm2.ExecuteNonQuery()
							End If


						End If


						MessageBox.Show("Shares are sold to selected broker")
						Me.Close()



					End If
				End If




			'if (drvadmin.CurrentRow.Cells[e.RowIndex].Value != null)
			'{
			'if (drvadmin.Columns[e.ColumnIndex].Name == "Sell_admin")
			'{
			'    //for (int i = 0; i < drvadmin.Rows.Count-1; i++)
			'    //{
			'    conshare.con.Open();
			'    cmd = new SqlCommand("update BROKER_SHARE_DETAILS set SHARES= SHARES +'" + drvadmin.CurrentRow.Cells["SHARES"].Value + "' ,BUY_RATE = '" + drvadmin.CurrentRow.Cells["Opening rate"].Value + "', CURRENT_RATE = '" + drvadmin.CurrentRow.Cells["Current rate"].Value + "' WHERE BROKER_NAME='" + drvadmin.CurrentRow.Cells[6].Value + "'", conshare.con);

			'    SqlCommand cmd1 = new SqlCommand("update BROKER_DETAILS set SHARES= SHARES+'" + drvadmin.CurrentRow.Cells["SHARES"].Value + "' ,CURRENT_RATE = '" + drvadmin.CurrentRow.Cells["Current rate"].Value + "',DATE= '" + drvadmin.CurrentRow.Cells["DATE"].Value + "'", conshare.con);


			'    for (int i = 0; i < drvadmin.Rows.Count; i++)
			'    {

			'        if (drvadmin.Rows[i].Cells[5].Value != null)
			'        {
			'            //SqlCommand cmd1 = new SqlCommand("insert into SHARE_DETAILS(ADMIN_NAME, COMPANY_NAME, SHARES, OPENING_RATE, CURRENT_RATE) values('" + txtadmin_name.Text + "','" + drvadmin.Rows[i].Cells["Company_name"].Value + "', '" + drvadmin.Rows[i].Cells["Shares"].Value + "', '" + drvadmin.Rows[i].Cells["Opening_rate"].Value + "', '" + drvadmin.Rows[i].Cells["Current_rate"].Value + "')", conshare.con);
			'            //SqlCommand cmd4 = new SqlCommand("update SHARE_DETAILS set ADMIN_NAME='" + drvadmin.Rows[i].Cells["ADMIN NAME"].Value + "',SHARES='" + drvadmin.Rows[i].Cells["SHARES"].Value + "',OPENING_RATE='" + drvadmin.Rows[i].Cells["OPENING RATE"].Value + "',CURRENT_RATE='" + drvadmin.Rows[i].Cells["CURRENT RATE"].Value + "' where COMPANY_NAME ='" + drvadmin.Rows[i].Cells["COMPANY NAME"].Value + "'", conshare.con);
			'            SqlCommand cmd4 = new SqlCommand("insert into SHARE_DETAILS(ADMIN_NAME,  SHARES, DATE, OPENING_RATE, CURRENT_RATE, COMPANY_NAME,BROKER_NAME) values('" + drvadmin.Rows[i].Cells[0].Value + "','" + drvadmin.Rows[i].Cells[1].Value + "', '" + drvadmin.Rows[i].Cells[2].Value + "', '" + drvadmin.Rows[i].Cells[3].Value + "', '" + drvadmin.Rows[i].Cells[4].Value + "', '" + drvadmin.Rows[i].Cells[5].Value + "' , '" + drvadmin.Rows[i].Cells[6].Value + "') ", conshare.con);
			'            cmd4.ExecuteNonQuery();
			'        }

			'    }

			'    //SqlCommand cmd2 = new SqlCommand("update CLIENT_SHARES set CURRENT_RATE = '" + drvadmin.Rows[i].Cells["Current rate"].Value + "'  where COMPANY_NAME ='" + drvadmin.Rows[i].Cells["Company name"].Value + "'", conshare.con);
			'    SqlCommand cmd2 = new SqlCommand("update ADMIN_DETAILS set SHARES = SHARES-'" + drvadmin.CurrentRow.Cells["SHARES"].Value + "' where ADMIN_NAME='"+cboadmin_name.Text+"'  ", conshare.con);

			'    cmd.ExecuteNonQuery();

			'   cmd2.ExecuteNonQuery();




			'    //}
			'    MessageBox.Show("Shares are sold to selected broker");
			'}
			'}

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			Finally
				conshare.con.Close()
			End Try





		End Sub



		Private Sub drvadmin_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim adp4 As New SqlDataAdapter("select broker_code from broker_details where broker_name='" + drvadmin.CurrentRow.Cells(4).Value + "'", conshare.con)
			Dim ds4 As New DataSet()
			adp4.Fill(ds4)
			ds4.Dispose()



			cbobroker_code.DataSource = ds4.Tables(0)

			cbobroker_code.DisplayMember = "broker_code"



		End Sub

		Private Sub drvadmin_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
			Try
				'if (drvadmin.Columns[0].Name == "Company_name")
				'{
				'    if (drvadmin.CurrentCell == null || drvadmin.CurrentCell.Value == null)
				'    {
				'        drvadmin.CurrentCell.Value = "";
				'        MessageBox.Show("Please enter Company Name");
				'        SendKeys.Send("{Left}");
				'    }
				'    else
				'    {
				'        //drvadmin.CurrentCell.Value = "";
				'        //MessageBox.Show("Please enter Company Name");
				'        //SendKeys.Send("{Left}");
				'    }
				'}
				If drvadmin.Columns("SHARES").Name = "Shares" Then

					If Microsoft.VisualBasic.Information.IsNumeric(drvadmin.CurrentCell.Value) Then
					Else
						drvadmin.CurrentCell.Value = ""
						MessageBox.Show("Please enter numeric values")
						SendKeys.Send("{Left}")
					End If
				End If
				If drvadmin.Columns(e.ColumnIndex).Name = "Opening_rate" Then

					If Microsoft.VisualBasic.Information.IsNumeric(drvadmin.CurrentCell.Value) Then
					Else
						drvadmin.CurrentCell.Value = ""
						MessageBox.Show("Please enter numeric values")
						SendKeys.Send("{Left}")
					End If
				End If


				If drvadmin.Columns(e.ColumnIndex).Name = "Current_rate" Then

					If Microsoft.VisualBasic.Information.IsNumeric(drvadmin.CurrentCell.Value) Then
					Else
						drvadmin.CurrentCell.Value = ""
						MessageBox.Show("Please enter numeric values")
						SendKeys.Send("{Left}")
					End If

				End If

			Catch ex As Exception

				MessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub drvadmin_RowLeave(sender As Object, e As DataGridViewCellEventArgs)

			'if (drvadmin.Columns[0].Name == "Company_name")
			'{
			'    if (drvadmin.CurrentCell == null || drvadmin.CurrentCell.Value == null)
			'    {
			'        drvadmin.CurrentCell.Value = "";
			'        MessageBox.Show("Please enter Company Name");
			'        //SendKeys.Send("{Enter}");
			'    }
			'    else
			'    {

			'    }
			'}
		End Sub

		Private Sub frmShare_details_Load(sender As Object, e As EventArgs)

		End Sub

		Private Sub frmShare_details_Load_1(sender As Object, e As EventArgs)

			conshare.con.Open()
			Dim ds As New DataSet()

			'adp = new SqlDataAdapter("Select [ADMIN NAME]=[ADMIN_NAME],[COMPANY NAME]=[COMPANY_NAME],[SHARES],[OPENING RATE]=[OPENING_RATE],[CURRENT RATE]=[CURRENT_RATE] from SHARE_DETAILS ", conshare.con);

			'for loading values in combobox

			cmd = New SqlCommand("select distinct admin_name from admin_details", conshare.con)

			reader = cmd.ExecuteReader()
			While reader.Read()
				cboadmin_name.Items.Add(reader("admin_name"))
			End While

			If reader IsNot Nothing Then
				reader.Close()
			End If

			'adp.Fill(ds);
			'SqlCommand cmd2 = new SqlCommand("select broker_name from broker_details", conshare.con);

			'reader1 = cmd2.ExecuteReader();



			'''/drvadmin.DataSource = ds.Tables[0];
			'while (reader1.Read())
			'{
			'    // cbobroker_name.Columns.Add(reader1["broker_name"]);
			'    // this.drvadmin.Columns["BROKER NAME"].DataPropertyName = "broker_name";

			'}

			'if (reader1 != null)
			'    reader1.Close();

			reader.Close()

			conshare.con.Close()
			'MessageBox.Show("Record Saved Successfully");



		End Sub

		Private Sub cboadmin_name_SelectedIndexChanged(sender As Object, e As EventArgs)


			drvadmin.Columns.Clear()
			cbocompany_name.Items.Clear()


			Try
				conshare.con.Open()

				'SqlCommand cmd1 = new SqlCommand("Select [CLIENT NAME]=[CLIENT_NAME],[COMPANY NAME]=[COMPANY_NAME],[SHARES],[date]=[DATE],[BUY RATE]=[SELLING_RATE],[CURRENT_RATE] from BROKER_SELL_CLIENT where CLIENT_NAME='" + cboclient_name.Text + "'", conclient_shares.con);
				'SqlDataReader dr1 = cmd1.ExecuteReader();
				'DataTable dt1 = new DataTable();
				'dt1.Load(dr1);
				'drvclient.DataSource = dt1;
				'dr1.Close();

				'SqlCommand cmd1 = new SqlCommand("select [SHARES],DATE,[OPENING RATE]=[OPENING_RATE],[CURRENT RATE]=[CURRENT_RATE] from SHARE_DETAILS where ADMIN_NAME='" + cboadmin_name.Text + "'", conshare.con);
				'SqlDataReader dr1 = cmd1.ExecuteReader();
				'DataTable dt1 = new DataTable();
				'dt1.Load(dr1);
				'drvadmin.DataSource = dt1;
				'dr1.Close();


				'''/adp1.Fill(ds1);

				'''/drvadmin.DataSource = ds1.Tables[0];
				'''/ds1.Dispose();



				'SqlDataAdapter adp2 = new SqlDataAdapter("select distinct broker_name from broker_details", conshare.con);
				'DataSet ds2 = new DataSet();
				'adp2.Fill(ds2);
				'ds2.Dispose();

				'SqlDataAdapter adp3 = new SqlDataAdapter("select distinct company_name from company_details", conshare.con);
				'DataSet ds3 = new DataSet();
				'adp3.Fill(ds3);
				'ds3.Dispose();




				'DataGridViewComboBoxColumn cbocompanyname = new DataGridViewComboBoxColumn();
				'cbocompanyname.Name = "Companyname";
				'cbocompanyname.DataSource = ds3.Tables[0];
				'cbocompanyname.DisplayMember = "Company_name";
				'cbocompanyname.HeaderText = "Company Name";
				'cbocompanyname.Width = 90;

				'drvadmin.Columns.Add(cbocompanyname);

				'DataGridViewComboBoxColumn cbobrokername = new DataGridViewComboBoxColumn();
				'cbobrokername.Name = "Brokername";
				'cbobrokername.DataSource = ds2.Tables[0];
				'cbobrokername.DisplayMember = "broker_name";
				'cbobrokername.HeaderText = "Broker Name";
				'cbobrokername.Width = 90;

				'drvadmin.Columns.Add(cbobrokername);

				'drvadmin.Columns[7].DataPropertyName = "BROKER_NAME";
				'}

				'SqlDataAdapter adp1 = new SqlDataAdapter("select [COMPANY NAME]=COMPANY_NAME,SHARES,[BUY RATE]=OPENING_RATE,[CURRENT RATE]=CURRENT_RATE,DATE from SHARE_DETAILS where ADMIN_NAME='" + cboadmin_name.Text + "'", conshare.con);
				'adp1.Fill(ds1);

				'drvadmin.DataSource = ds1.Tables[0];

				'ds1.Dispose();
				'2nd grid- broker sells shares to client

				Dim cmd As New SqlCommand("select distinct company_name from admin_details where admin_NAME='" + cboadmin_name.Text + "'", conshare.con)

				rdr = cmd.ExecuteReader()

				While rdr.Read()

					cbocompany_name.Items.Add(rdr("company_name").ToString())
				End While
				rdr.Close()


				conshare.con.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			Finally
				conshare.con.Close()
			End Try

			'DataGridViewComboBoxColumn cbobrokername = new DataGridViewComboBoxColumn();
			'cbobroker_name.Name = "Broker_name";
			'cbobroker_name.HeaderText = "broker Name";
			'cbobroker_name.Width = 90;
			'drvadmin.Columns.Add(cbobroker_name);

			'DataGridViewButtonColumn btnsell = new DataGridViewButtonColumn();
			'btnsell.Name = "Sell_admin";
			'btnsell.HeaderText = "Sell";
			'btnsell.Text = "Sell";

			'btnsell.Width = 50;
			'btnsell.UseColumnTextForButtonValue = true;
			'drvadmin.Columns.Add(btnsell);

		End Sub

		Private Sub drvadmin_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
			If drvadmin.Columns(e.ColumnIndex).Name.Equals("DATE") Then
					'dateTimePicker1.Visible = true;
				dtpdate.Visible = True
			End If
		End Sub

		Private Sub dtpdate_ValueChanged(sender As Object, e As EventArgs)
			'try
			'{

			'    {
			Dim str As String = dtpdate.Text

			drvadmin.CurrentRow.Cells(2).Value = str

			'drvadmin.CurrentRow.Cells["DATE"].Value

			'}
			'}
			'catch (Exception ex)
			'{
			'    MessageBox.Show(ex.Message);
			'}

		End Sub

		Private Sub cbocompany_name_SelectedIndexChanged(sender As Object, e As EventArgs)

			drvadmin.Columns.Clear()
			conshare.con.Open()
			Dim adp2 As New SqlDataAdapter("select [SHARES],[CURRENT RATE]=[CURRENT_RATE],[BUY RATE]=[OPENING_RATE] from SHARE_DETAILS where admin_NAME='" + cboadmin_name.Text + "' and company_name='" + cbocompany_name.Text + "'", conshare.con)
			Dim ds2 As New DataSet()
			adp2.Fill(ds2)

			drvadmin.DataSource = ds2.Tables(0)
			ds2.Dispose()


			Dim adp5 As New SqlDataAdapter("select DISTINCT ADMIN_TYPE from SHARE_DETAILS WHERE ADMIN_NAME='" + cboadmin_name.Text + "' AND COMPANY_NAME='" + cbocompany_name.Text + "'", conshare.con)
			Dim ds5 As New DataSet()
			adp5.Fill(ds5)
			ds5.Dispose()

			Dim cboadmin_type As New DataGridViewComboBoxColumn()
			cboadmin_type.Name = "admintype"
			cboadmin_type.DataSource = ds5.Tables(0)

			cboadmin_type.DisplayMember = "ADMIN_TYPE"
			cboadmin_type.HeaderText = "ADMIN TYPE"
			cboadmin_type.Width = 120

			drvadmin.Columns.Add(cboadmin_type)

			Dim adp3 As New SqlDataAdapter("select DISTINCT broker_name from broker_details", conshare.con)
			Dim ds3 As New DataSet()
			adp3.Fill(ds3)
			ds3.Dispose()

			Dim cboclientname As New DataGridViewComboBoxColumn()
			cboclientname.Name = "brokername"
			cboclientname.DataSource = ds3.Tables(0)

			cboclientname.DisplayMember = "broker_name"
			cboclientname.HeaderText = "BROKER NAME"
			cboclientname.Width = 120

			drvadmin.Columns.Add(cboclientname)

			'SqlDataAdapter adp4 = new SqlDataAdapter("select broker_code from broker_details where broker_name='"+ drvadmin.CurrentRow.Cells[3].Value+"'", conshare.con);
			'DataSet ds4 = new DataSet();
			'adp4.Fill(ds4);
			'ds4.Dispose();


			cbobroker_code.Name = "brokercode"
			' cbobroker_code.DataSource = ds4.Tables[0];

			'cbobroker_code.DisplayMember = "broker_code";
			cbobroker_code.HeaderText = "BROKER CODE"
			cbobroker_code.Width = 120

			drvadmin.Columns.Add(cbobroker_code)



			Dim btnsell As New DataGridViewButtonColumn()
			btnsell.Name = "sell_admin"
			btnsell.HeaderText = "Sell"
			btnsell.Text = "Sell"
			btnsell.Width = 50
			btnsell.UseColumnTextForButtonValue = True
			drvadmin.Columns.Add(btnsell)



			For i As Integer = 0 To drvadmin.Columns.Count - 1
				Me.drvadmin.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
			Next
			For i As Integer = 0 To drvadmin.Columns.Count - 1
				Me.drvadmin.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
			Next
			conshare.con.Close()
		End Sub


		Private Sub brokername_SelectedIndexChanged(sender As Object, e As EventArgs)
			conshare.con.Open()
			If drvadmin.CurrentRow.Cells(3).Value IsNot Nothing Then
				cmd1 = New SqlCommand("select broker_code from broker_details where broker_name='" + drvadmin.CurrentRow.Cells("brokername").Value.ToString() + "' ", conshare.con)
				rdr = cmd1.ExecuteReader()
				While rdr.Read()
					MessageBox.Show(rdr("broker_code").ToString())
				End While
				rdr.Close()
			Else
			End If
			conshare.con.Close()



		End Sub

		Private Sub drvadmin_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)

		End Sub

	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
