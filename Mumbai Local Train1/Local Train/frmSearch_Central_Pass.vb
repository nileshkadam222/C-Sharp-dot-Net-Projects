Public Class frmSearch_Central_Pass
    Private Sub frmsearchpassCup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
          Call Connection()
        MsgBox("WELCOME TO CENTRAL RAILWAY")

        cbstation.Visible = False
        cbstations.Visible = False
        optbyticketnumber.Checked = True
        dgcentral.Columns.Add("passno", "PassNo")
        dgcentral.Columns.Add("source", "Source")
        dgcentral.Columns.Add("destination", "Destination")
        dgcentral.Columns.Add("date", "Date")
        dgcentral.Columns.Add("time", "Time")
        dgcentral.Columns.Add("distance", "Distance")
        dgcentral.Columns.Add("duration", "Duration")
        dgcentral.Columns.Add("passtype", "PassType")
        dgcentral.Columns.Add("months", "Months")
        dgcentral.Columns.Add("class", "Class")
        dgcentral.Columns.Add("expirydate", "ExpiryDate")
        dgcentral.Columns.Add("totalprice", "Total Price")
        dgcentral.Columns.Add("site_pass", "Site_Pass")
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        dgcentral.Rows.Clear()
        s = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        ctr = ds.Tables(0).Rows.Count - 1
        If optbyticketnumber.Checked = True Then
            If txtticketno.Text = "" Then
                MsgBox("Please Enter the Ticket Number")
                Exit Sub
            End If
            For i = 0 To ctr
                If txtticketno.Text = ds.Tables("Pass").Rows(i).Item(0) Then
                    dgcentral.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
                If cbstation.Text = ds.Tables("Pass").Rows(i).Item(1) Or cbstations.Text = ds.Tables("Pass").Rows(i).Item(1) Then
                    dgcentral.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
        If optbydestinaion.Checked = True Then
            If cbstation.Text = "" And cbstations.Text = "" Then
                MsgBox("Please Select the station")
                Exit Sub
            End If
            For i = 0 To ctr
                If cbstation.Text = ds.Tables("Pass").Rows(i).Item(2) Or cbstations.Text = ds.Tables("Pass").Rows(i).Item(2) Then
                    dgcentral.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
        j = dgcentral.Rows.Count - 1
        If j > 0 Then
            MsgBox("No of Record " & j & " found so far")
        Else
            MsgBox("Sorry ! No Record found")
        End If
    End Sub

    Private Sub cbstation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbstation.Click
        cbstation.Items.Clear()
        cbstations.Text = ""
        s = "select * from stations"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "stations")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            cbstation.Items.Add(ds.Tables(0).Rows(i).Item(1))
        Next
    End Sub
    Private Sub cbstations_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbstations.Click
        cbstations.Items.Clear()
        cbstation.Text = ""
        s = "select * from stations"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "stations")
        ctr = ds.Tables(0).Rows.Count - 6
        For i = 0 To ctr
            cbstations.Items.Add(ds.Tables(0).Rows(i).Item(3))
        Next
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
            cbstations.Visible = True
            txtticketno.Visible = False
            cbstation.Text = ""
            cbstations.Text = ""
        End If
    End Sub
    Private Sub optbydestinaion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optbydestinaion.Click
        If optbydestinaion.Checked = True Then
            cbstation.Visible = True
            cbstations.Visible = True
            txtticketno.Visible = False
            cbstation.Text = ""
            cbstations.Text = ""
        End If
    End Sub

    Private Sub lblback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblback.Click
        Me.Hide()
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End
    End Sub

    Private Sub cmdshowall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowall.Click
        dgcentral.Rows.Clear()
        s = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(s, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            If ds.Tables(0).Rows(i).Item(12) = "CENTRAL" Then
                dgcentral.Rows.Add(ds.Tables(0).Rows(i).Item(0), _
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
    End Sub
End Class