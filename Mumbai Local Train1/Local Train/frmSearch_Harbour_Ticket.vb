Public Class frmSearch_Harbour_Ticket
    Private Sub frmsearchhrabouup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
          Call Connection()
        MsgBox("WELCOME TO HARBOUR LINE")

        cbstation.Visible = False
        optbyticketnumber.Checked = True
        dgharbour.Columns.Add("ticketno", "TicketNo")
        dgharbour.Columns.Add("source", "Source")
        dgharbour.Columns.Add("destination", "Destination")
        dgharbour.Columns.Add("date", "Date")
        dgharbour.Columns.Add("time", "Time")
        dgharbour.Columns.Add("distance", "Distance")
        dgharbour.Columns.Add("duration", "Duration")
        dgharbour.Columns.Add("adult", "Adult")
        dgharbour.Columns.Add("child", "Child")
        dgharbour.Columns.Add("class", "Class")
        dgharbour.Columns.Add("return", "Return")
        dgharbour.Columns.Add("adultprice", "Adult Price")
        dgharbour.Columns.Add("childprice", "Child Price")
        dgharbour.Columns.Add("totalprice", "Total Price")
        dgharbour.Columns.Add("site_ticket", "Site_Ticket")
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        dgharbour.Rows.Clear()
        s = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        If optbyticketnumber.Checked = True Then
            If txtticketno.Text = "" Then
                MsgBox("Please Enter the Ticket Number")
                Exit Sub
            End If
            For i = 0 To ctr
                If txtticketno.Text = ds.Tables("Ticket").Rows(i).Item(0) Then
                    dgharbour.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
                    dgharbour.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
                    dgharbour.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
        j = dgharbour.Rows.Count - 1
        If j > 0 Then
            MsgBox("No of Record " & j & " found so far")
        Else
            MsgBox("Sorry ! No Record found")
        End If
    End Sub



    Private Sub optbyticketnumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optbyticketnumber.Click
        If optbyticketnumber.Checked = True Then
            cbstation.Visible = False
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
    End Sub
    Private Sub optbydestinaion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optbydestinaion.Click
        If optbydestinaion.Checked = True Then
            cbstation.Visible = True
            txtticketno.Visible = False
            cbstation.Text = ""
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End
    End Sub

    Private Sub lblback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblback.Click
        Me.Hide()
    End Sub

    Private Sub cbstation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbstation.Click
        cbstation.Items.Clear()
        s = "select * from stations"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "stations")
        ctr = ds.Tables(0).Rows.Count - 9
        For i = 0 To ctr
            cbstation.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
    End Sub

    Private Sub cmdshowall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowall.Click
        dgharbour.Rows.Clear()
        s = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            If ds.Tables(0).Rows(i).Item(14) = "HARBOUR" Then
                dgharbour.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
    End Sub
End Class