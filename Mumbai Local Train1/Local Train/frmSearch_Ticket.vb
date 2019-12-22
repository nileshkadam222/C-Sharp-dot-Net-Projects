Public Class frmSearch_Ticket

    Private Sub frmSearch_Ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()

        cbstation.Visible = False
        optbyticketnumber.Checked = True
        dgTicket.Columns.Add("ticketno", "TicketNo")
        dgTicket.Columns.Add("source", "Source")
        dgTicket.Columns.Add("destination", "Destination")
        dgTicket.Columns.Add("date", "Date")
        dgTicket.Columns.Add("time", "Time")
        dgTicket.Columns.Add("distance", "Distance")
        dgTicket.Columns.Add("duration", "Duration")
        dgTicket.Columns.Add("adult", "Adult")
        dgTicket.Columns.Add("child", "Child")
        dgTicket.Columns.Add("class", "Class")
        dgTicket.Columns.Add("return", "Return")
        dgTicket.Columns.Add("adultprice", "Adult Price")
        dgTicket.Columns.Add("childprice", "Child Price")
        dgTicket.Columns.Add("totalprice", "Total Price")
        dgTicket.Columns.Add("site_ticket", "Site_Ticket")

        cbSites.Text = "WESTERN"
    End Sub

    Private Sub cbstation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbstation.Click
        cbstation.Items.Clear()
        cbstations.Items.Clear()
        cbstation.Text = ""
        cbstations.Text = ""

        Select Case cbSites.Text
            Case "WESTERN"
                s = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(s, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 13
                For i = 0 To ctr
                    cbstation.Items.Add(ds.Tables(0).Rows(i).Item(4))
                Next

            Case "CENTRAL"
                cbstations.Text = ""
                s = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(s, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 1
                For i = 0 To ctr
                    cbstation.Items.Add(ds.Tables(0).Rows(i).Item(1))
                Next
                cbstation.Text = ""
                s = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(s, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 6
                For i = 0 To ctr
                    cbstations.Items.Add(ds.Tables(0).Rows(i).Item(3))
                Next
            Case "HARBOUR"
                s = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(s, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 9
                For i = 0 To ctr
                    cbstation.Items.Add(ds.Tables(0).Rows(i).Item(0))
                Next
        End Select

    End Sub
    Private Sub optbyticketnumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optbyticketnumber.Click
        If optbyticketnumber.Checked = True Then
            cbstation.Visible = False
            cbstations.Visible = False
            txtticketno.Visible = True
            txtticketno.Text = ""
        End If
    End Sub
    Private Sub optbysource_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optbysource.Click
        If optbysource.Checked = True Then
            cbstation.Visible = True
            txtticketno.Visible = False
            cbstation.Text = ""
        End If
        If cbSites.Text = "CENTRAL" Then
            cbstation.Visible = True
            cbstations.Visible = True
            txtticketno.Visible = False
            txtticketno.Text = ""
        End If
    End Sub
    Private Sub optbydestinaion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optbydestinaion.Click
        If optbydestinaion.Checked = True Then
            cbstation.Visible = True
            txtticketno.Visible = False
            cbstation.Text = ""
        End If
        If cbSites.Text = "CENTRAL" Then
            cbstation.Visible = True
            cbstations.Visible = True
            txtticketno.Visible = False
            txtticketno.Text = ""
        End If
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        dgTicket.Rows.Clear()
        s = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        Select Case cbSites.Text
            Case "WESTERN"

                If optbyticketnumber.Checked = True Then
                    If txtticketno.Text = "" Then
                        MsgBox("Please Enter the Ticket Number")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If txtticketno.Text = ds.Tables("Ticket").Rows(i).Item(0) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If
                If optbysource.Checked = True Then
                    If cbstation.Text = "" Then
                        MsgBox("Please Select the station")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If cbstation.Text = ds.Tables("Ticket").Rows(i).Item(1) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If
                If optbydestinaion.Checked = True Then
                    If cbstation.Text = "" Then
                        MsgBox("Please Select the station")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If cbstation.Text = ds.Tables("Ticket").Rows(i).Item(2) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If

            Case "CENTRAL"
                If optbyticketnumber.Checked = True Then
                    If txtticketno.Text = "" Then
                        MsgBox("Please Enter the Ticket Number")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If txtticketno.Text = ds.Tables("Ticket").Rows(i).Item(0) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12))
                        End If
                    Next
                End If
                If optbysource.Checked = True Then
                    If cbstation.Text = "" And cbstations.Text = "" Then
                        MsgBox("Please Select the station")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If cbstation.Text = ds.Tables("Ticket").Rows(i).Item(1) Or cbstations.Text = ds.Tables("Ticket").Rows(i).Item(1) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If
                If optbydestinaion.Checked = True Then
                    If cbstation.Text = "" And cbstations.Text = "" Then
                        MsgBox("Please Select the station")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If cbstation.Text = ds.Tables("Ticket").Rows(i).Item(2) Or cbstations.Text = ds.Tables("Ticket").Rows(i).Item(2) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If

            Case "HARBOUR"

                If optbyticketnumber.Checked = True Then
                    If txtticketno.Text = "" Then
                        MsgBox("Please Enter the Ticket Number")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If txtticketno.Text = ds.Tables("Ticket").Rows(i).Item(0) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If
                If optbysource.Checked = True Then
                    If cbstation.Text = "" Then
                        MsgBox("Please Select the station")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If cbstation.Text = ds.Tables("Ticket").Rows(i).Item(1) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If
                If optbydestinaion.Checked = True Then
                    If cbstation.Text = "" Then
                        MsgBox("Please Select the station")
                        Exit Sub
                    End If
                    For i = 0 To ctr
                        If cbstation.Text = ds.Tables("Ticket").Rows(i).Item(2) Then
                            dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                            ds.Tables(0).Rows(i).Item(1), _
                            ds.Tables(0).Rows(i).Item(2), _
                            ds.Tables(0).Rows(i).Item(3), _
                            ds.Tables(0).Rows(i).Item(4), _
                            ds.Tables(0).Rows(i).Item(5), _
                            ds.Tables(0).Rows(i).Item(6), _
                            ds.Tables(0).Rows(i).Item(7), _
                            ds.Tables(0).Rows(i).Item(8), _
                            ds.Tables(0).Rows(i).Item(9), _
                            ds.Tables(0).Rows(i).Item(10), _
                            ds.Tables(0).Rows(i).Item(11), _
                            ds.Tables(0).Rows(i).Item(12), _
                            ds.Tables(0).Rows(i).Item(13), _
                            ds.Tables(0).Rows(i).Item(14))
                        End If
                    Next
                End If
        End Select
        j = dgTicket.Rows.Count - 1
        If j > 0 Then
            MsgBox("No of Record " & j & " found so far")
        Else
            MsgBox("Sorry ! No Record found")
        End If
    End Sub

    Private Sub cmdshowall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowall.Click
        If cbSites.Text = "" Then
            MsgBox("Please select the Site first")
            Exit Sub
        End If
        dgTicket.Rows.Clear()
        s = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        Select Case cbSites.Text
            Case "WESTERN"
                cbstation.Enabled = True
                cbstations.Enabled = True
                For i = 0 To ctr
                    If ds.Tables(0).Rows(i).Item(14) = "WESTERN" Then
                        dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                              ds.Tables(0).Rows(i).Item(1), _
                              ds.Tables(0).Rows(i).Item(2), _
                              ds.Tables(0).Rows(i).Item(3), _
                              ds.Tables(0).Rows(i).Item(4), _
                              ds.Tables(0).Rows(i).Item(5), _
                              ds.Tables(0).Rows(i).Item(6), _
                              ds.Tables(0).Rows(i).Item(7), _
                              ds.Tables(0).Rows(i).Item(8), _
                              ds.Tables(0).Rows(i).Item(9), _
                              ds.Tables(0).Rows(i).Item(10), _
                              ds.Tables(0).Rows(i).Item(11), _
                              ds.Tables(0).Rows(i).Item(12), _
                              ds.Tables(0).Rows(i).Item(13), _
                              ds.Tables(0).Rows(i).Item(14))
                    End If
                Next

            Case "CENTRAL"
                cbstation.Enabled = True
                cbstations.Enabled = True
                For i = 0 To ctr
                    If ds.Tables(0).Rows(i).Item(14) = "CENTRAL" Then
                        dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                        ds.Tables(0).Rows(i).Item(1), _
                        ds.Tables(0).Rows(i).Item(2), _
                        ds.Tables(0).Rows(i).Item(3), _
                        ds.Tables(0).Rows(i).Item(4), _
                        ds.Tables(0).Rows(i).Item(5), _
                        ds.Tables(0).Rows(i).Item(6), _
                        ds.Tables(0).Rows(i).Item(7), _
                        ds.Tables(0).Rows(i).Item(8), _
                        ds.Tables(0).Rows(i).Item(9), _
                        ds.Tables(0).Rows(i).Item(10), _
                        ds.Tables(0).Rows(i).Item(11), _
                        ds.Tables(0).Rows(i).Item(12), _
                        ds.Tables(0).Rows(i).Item(13), _
                        ds.Tables(0).Rows(i).Item(14))
                    End If
                Next

            Case "HARBOUR"
                cbstation.Enabled = True
                cbstations.Enabled = True
                For i = 0 To ctr
                    If ds.Tables(0).Rows(i).Item(14) = "HARBOUR" Then
                        dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                                   ds.Tables(0).Rows(i).Item(1), _
                                   ds.Tables(0).Rows(i).Item(2), _
                                   ds.Tables(0).Rows(i).Item(3), _
                                   ds.Tables(0).Rows(i).Item(4), _
                                   ds.Tables(0).Rows(i).Item(5), _
                                   ds.Tables(0).Rows(i).Item(6), _
                                   ds.Tables(0).Rows(i).Item(7), _
                                   ds.Tables(0).Rows(i).Item(8), _
                                   ds.Tables(0).Rows(i).Item(9), _
                                   ds.Tables(0).Rows(i).Item(10), _
                                   ds.Tables(0).Rows(i).Item(11), _
                                   ds.Tables(0).Rows(i).Item(12), _
                                   ds.Tables(0).Rows(i).Item(13), _
                                   ds.Tables(0).Rows(i).Item(14))
                    End If
                Next
            Case "ALL"
                cbstation.Enabled = False
                cbstations.Enabled = False
                For i = 0 To ctr
                    dgTicket.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
                                   ds.Tables(0).Rows(i).Item(1), _
                                   ds.Tables(0).Rows(i).Item(2), _
                                   ds.Tables(0).Rows(i).Item(3), _
                                   ds.Tables(0).Rows(i).Item(4), _
                                   ds.Tables(0).Rows(i).Item(5), _
                                   ds.Tables(0).Rows(i).Item(6), _
                                   ds.Tables(0).Rows(i).Item(7), _
                                   ds.Tables(0).Rows(i).Item(8), _
                                   ds.Tables(0).Rows(i).Item(9), _
                                   ds.Tables(0).Rows(i).Item(10), _
                                   ds.Tables(0).Rows(i).Item(11), _
                                   ds.Tables(0).Rows(i).Item(12), _
                                   ds.Tables(0).Rows(i).Item(13), _
                                   ds.Tables(0).Rows(i).Item(14))
                Next
        End Select
    End Sub

    Private Sub cbSites_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSites.Click
        cbSites.Items.Clear()
        optbyticketnumber.Checked = True
        cbstation.Visible = False
        cbstations.Visible = False
        cbstation.Enabled = True
        cbstations.Enabled = True
        txtticketno.Visible = True
        cmdsearch.Enabled = True
        cbSites.Items.Add("WESTERN")
        cbSites.Items.Add("CENTRAL")
        cbSites.Items.Add("HARBOUR")
        cbSites.Items.Add("ALL")
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End
    End Sub

    Private Sub lblback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblback.Click
        Me.Hide()
    End Sub
    Private Sub cbSites_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSites.SelectedIndexChanged
        If cbSites.Text = "ALL" Then
            cmdsearch.Enabled = False
            cbstation.Enabled = False
            cbstations.Enabled = False
        End If
    End Sub
End Class