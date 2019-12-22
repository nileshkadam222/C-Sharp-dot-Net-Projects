Public Class frmHarbour_Pass
    Private Sub frmpassharbourup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()
        MsgBox("WELCOME TO HARBOUR LINE")
        cbdestination.Enabled = False
        cbclass.Items.Add("FIRST")
        cbclass.Items.Add("SECOND")
        cbpasstype.Items.Add("Monthly")
        cbpasstype.Items.Add("Quarterly")
        cbdestination.Enabled = False
        cbroutes.Enabled = False
        ss = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            txtpassnum.Text = ds.Tables("Pass").Rows(i).Item(0)
        Next
        txtpassnum.Text = Val(txtpassnum.Text) + 1
        Timer1.Enabled = True
    End Sub

    Private Sub cbdestination_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdestination.Click
        s = cbsource.SelectedItem
        If cbsource.Text = "" Then Exit Sub
        cbdestination.Items.Clear()
        ss = "select * from stations"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "stations")
        ctr = ds.Tables(0).Rows.Count - 9
        For i = 0 To ctr
            cbdestination.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        cbdestination.Items.Remove(s)
        cbroutes.Enabled = True
    End Sub

    Private Sub cbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
        Select Case cbpasstype.Text
            Case "Monthly"
                n = cbclass.Text
                Select Case n
                    Case "FIRST"
                        If (txtdistance.Text >= 1 And txtdistance.Text <= 10) Then txttotalprice.Text = 260
                        If (txtdistance.Text >= 11 And txtdistance.Text <= 15) Then txttotalprice.Text = 340
                        If (txtdistance.Text >= 16 And txtdistance.Text <= 20) Then txttotalprice.Text = 400
                        If (txtdistance.Text >= 21 And txtdistance.Text <= 30) Then txttotalprice.Text = 460
                        If (txtdistance.Text >= 31 And txtdistance.Text <= 35) Then txttotalprice.Text = 520
                        If (txtdistance.Text >= 36 And txtdistance.Text <= 40) Then txttotalprice.Text = 580
                        If (txtdistance.Text >= 41 And txtdistance.Text <= 45) Then txttotalprice.Text = 640
                        If (txtdistance.Text >= 46 And txtdistance.Text <= 50) Then txttotalprice.Text = 700
                        If (txtdistance.Text >= 51 And txtdistance.Text <= 55) Then txttotalprice.Text = 770
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 60) Then txttotalprice.Text = 830
                        If (txtdistance.Text >= 61 And txtdistance.Text <= 70) Then txttotalprice.Text = 890
                    Case "SECOND"
                        If (txtdistance.Text >= 1 And txtdistance.Text <= 10) Then txttotalprice.Text = 70
                        If (txtdistance.Text >= 11 And txtdistance.Text <= 15) Then txttotalprice.Text = 95
                        If (txtdistance.Text >= 16 And txtdistance.Text <= 20) Then txttotalprice.Text = 110
                        If (txtdistance.Text >= 21 And txtdistance.Text <= 30) Then txttotalprice.Text = 125
                        If (txtdistance.Text >= 31 And txtdistance.Text <= 35) Then txttotalprice.Text = 140
                        If (txtdistance.Text >= 36 And txtdistance.Text <= 40) Then txttotalprice.Text = 155
                        If (txtdistance.Text >= 41 And txtdistance.Text <= 45) Then txttotalprice.Text = 170
                        If (txtdistance.Text >= 46 And txtdistance.Text <= 50) Then txttotalprice.Text = 185
                        If (txtdistance.Text >= 51 And txtdistance.Text <= 55) Then txttotalprice.Text = 205
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 60) Then txttotalprice.Text = 220
                        If (txtdistance.Text >= 61 And txtdistance.Text <= 70) Then txttotalprice.Text = 235
                End Select
            Case "Quarterly"
                n = cbclass.Text
                Select Case n
                    Case "FIRST"
                        If (txtdistance.Text >= 1 And txtdistance.Text <= 10) Then txttotalprice.Text = 710
                        If (txtdistance.Text >= 11 And txtdistance.Text <= 15) Then txttotalprice.Text = 930
                        If (txtdistance.Text >= 16 And txtdistance.Text <= 20) Then txttotalprice.Text = 1095
                        If (txtdistance.Text >= 21 And txtdistance.Text <= 30) Then txttotalprice.Text = 1255
                        If (txtdistance.Text >= 31 And txtdistance.Text <= 35) Then txttotalprice.Text = 1420
                        If (txtdistance.Text >= 36 And txtdistance.Text <= 40) Then txttotalprice.Text = 1580
                        If (txtdistance.Text >= 41 And txtdistance.Text <= 45) Then txttotalprice.Text = 1740
                        If (txtdistance.Text >= 46 And txtdistance.Text <= 50) Then txttotalprice.Text = 1905
                        If (txtdistance.Text >= 51 And txtdistance.Text <= 55) Then txttotalprice.Text = 2095
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 60) Then txttotalprice.Text = 2260
                        If (txtdistance.Text >= 61 And txtdistance.Text <= 70) Then txttotalprice.Text = 2420
                    Case "SECOND"
                        If (txtdistance.Text >= 1 And txtdistance.Text <= 10) Then txttotalprice.Text = 195
                        If (txtdistance.Text >= 11 And txtdistance.Text <= 15) Then txttotalprice.Text = 265
                        If (txtdistance.Text >= 16 And txtdistance.Text <= 20) Then txttotalprice.Text = 305
                        If (txtdistance.Text >= 21 And txtdistance.Text <= 30) Then txttotalprice.Text = 345
                        If (txtdistance.Text >= 31 And txtdistance.Text <= 35) Then txttotalprice.Text = 385
                        If (txtdistance.Text >= 36 And txtdistance.Text <= 40) Then txttotalprice.Text = 425
                        If (txtdistance.Text >= 41 And txtdistance.Text <= 45) Then txttotalprice.Text = 465
                        If (txtdistance.Text >= 46 And txtdistance.Text <= 50) Then txttotalprice.Text = 510
                        If (txtdistance.Text >= 51 And txtdistance.Text <= 55) Then txttotalprice.Text = 565
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 60) Then txttotalprice.Text = 605
                        If (txtdistance.Text >= 61 And txtdistance.Text <= 70) Then txttotalprice.Text = 645
                End Select
        End Select
    End Sub
    Sub clear()
        txtdistance.Text = ""
        txtduration.Text = ""
        cbpasstype.Text = ""
        txtmonths.Text = ""
        cbclass.Text = ""
        txtExpiryDate.Text = ""
        cbdestination.Enabled = False
        cbroutes.Enabled = False
        cbroutes.Text = ""
        txttotalprice.Text = ""
        cbsource.Text = ""
        cbdestination.Text = ""
    End Sub

    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Me.Hide()
    End Sub

    Private Sub cmdpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpass.Click
        Dim cc As Control
        For Each cc In Me.Controls
            Dim ans As String
            ans = Convert.ToString(c.GetType)
            ans = "Systems.Windows.Forms.textbox"
            If txtpassnum.Text = "" Or cbsource.Text = "" Or cbdestination.Text = "" Or txtdate.Text = "" Or txttime.Text = "" Or txtdistance.Text = "" Or txtduration.Text = "" Or cbclass.Text = "" Or cbpasstype.Text = "" Or txttotalprice.Text = "" Or txtmonths.Text = "" Or txtExpiryDate.Text = "" Then
                MsgBox("Please Fill all the Records in the TextBox Properly", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        ss = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            If txtpassnum.Text = ds.Tables("Pass").Rows(i).Item(0) Then
                MsgBox("This Ticket Number is not Valid", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        Site_Pass = "HARBOUR"
        sss = "insert into Pass Values('" + txtpassnum.Text + "','" + cbsource.Text + "','" + cbdestination.Text + "','" + txtdate.Text + "','" + txttime.Text + "','" + txtdistance.Text + "','" + txtduration.Text + "','" + cbpasstype.Text + "','" + txtmonths.Text + "','" + cbclass.Text + "','" + txtExpiryDate.Text + "','" + txttotalprice.Text + "','" + Site_Pass + "')"
        cm = New SqlClient.SqlCommand(sss, cn)
        cm.ExecuteNonQuery()
        MsgBox("Pass is inserted")
        clear()
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        clear()
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        clear()
        ss = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        ctr = ds.Tables(0).Rows.Count - 1
        n = txtpassnum.Text
        For i = 0 To ctr
            If n = ds.Tables("Pass").Rows(i).Item(0) Then
                cbsource.Text = ds.Tables("Pass").Rows(i).Item(1)
                cbdestination.Text = ds.Tables("Pass").Rows(i).Item(2)
                txtdate.Text = ds.Tables("Pass").Rows(i).Item(3)
                txttime.Text = ds.Tables("Pass").Rows(i).Item(4)
                txtdistance.Text = ds.Tables("Pass").Rows(i).Item(5)
                txtduration.Text = ds.Tables("Pass").Rows(i).Item(6)
                cbpasstype.Text = ds.Tables("Pass").Rows(i).Item(7)
                txtmonths.Text = ds.Tables("Pass").Rows(i).Item(8)
                cbclass.Text = ds.Tables("Pass").Rows(i).Item(9)
                txtExpiryDate.Text = ds.Tables("Pass").Rows(i).Item(10)
                txttotalprice.Text = ds.Tables("Pass").Rows(i).Item(11)
                MsgBox("Searching is Completed")
                Exit Sub
            End If
        Next
        MsgBox("Sorry! No Result Found...", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        End
    End Sub

    Private Sub txtticketnum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassnum.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtdistance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdistance.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtduration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtduration.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtmonths_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonths.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtExpiryDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExpiryDate.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txttotalprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub

    Private Sub cbpasstype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbpasstype.SelectedIndexChanged
        If cbpasstype.Text = "Monthly" Then txtmonths.Text = "1"
        If cbpasstype.Text = "Quarterly" Then txtmonths.Text = "3"
        p = Format(Now, "dd")
        q = Format(Now, "MM")
        r = Format(Now, "yyyy")
        p = p - 1
        q = q + Val(txtmonths.Text)
        If Val(q) > 12 Then
            r = r + 1
            q = q - 12
        End If
        If Val(q) = 1 Then
            r = r - 1
        End If
        Select Case Val(q) - 1
            Case 1, 3, 5, 7, 8, 10, 0
                If Val(p) = 0 Then
                    p = 31
                    q = q - 1
                    If Val(q) = 0 Then
                        q = 12
                    End If
                End If

            Case 4, 6, 9, 11
                If Val(p) = 0 Then
                    p = 30
                    q = q - 1
                    If Val(q) = 0 Then
                        q = 12
                    End If
                End If
            Case 2
                If Val(p) = 0 Then
                    p = 28
                    q = q - 1
                    If Val(q) = 0 Then
                        q = 12
                    End If
                End If
        End Select
        txtExpiryDate.Text = p.ToString + "-" + q.ToString + "-" + r.ToString
    End Sub

    Private Sub cbsource_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsource.Click
        cbsource.Items.Clear()
        cbdestination.Text = ""
        ss = "select * from stations"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "stations")
        ctr = ds.Tables(0).Rows.Count - 9
        For i = 0 To ctr
            cbsource.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        cbdestination.Enabled = True
        cbroutes.Enabled = False
        txtdistance.Text = ""
        txtduration.Text = ""
        cbpasstype.Text = ""
        txtmonths.Text = ""
        cbclass.Text = ""
        txtExpiryDate.Text = ""
        txttotalprice.Text = ""
    End Sub
    Private Sub cbroutes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbroutes.Click
        a = cbsource.SelectedIndex
        If cbsource.SelectedIndex < cbdestination.SelectedIndex Then
            a = cbsource.SelectedIndex
            cbroutes.Items.Clear()
            ss = "select * from stations"
            adp = New SqlClient.SqlDataAdapter(ss, cn)
            ds = New DataSet
            adp.Fill(ds, "stations")
            ctr = cbdestination.SelectedIndex
            For i = a + 1 To ctr
                cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(0))
            Next
        ElseIf cbsource.SelectedIndex > cbdestination.SelectedIndex Then
            a = cbdestination.SelectedIndex
            cbroutes.Items.Clear()
            ss = "select * from stations"
            adp = New SqlClient.SqlDataAdapter(ss, cn)
            ds = New DataSet
            adp.Fill(ds, "stations")
            ctr = cbsource.SelectedIndex - 1
            For i = a + 1 To ctr
                cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(0))
            Next
        End If
    End Sub

    Private Sub cbdestination_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdestination.GotFocus
        If cbsource.Text = "" Then
            cbdestination.Enabled = False
        End If
    End Sub

    Private Sub cbdestination_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbdestination.SelectedIndexChanged
        'Duration
        If cbsource.SelectedItem = "Panvel              " Then b = 0
        If cbsource.SelectedItem = "Khandeshwar         " Then b = 4
        If cbsource.SelectedItem = "Manarover           " Then b = 7
        If cbsource.SelectedItem = "Kharghar            " Then b = 10
        If cbsource.SelectedItem = "Belapur CBD         " Then b = 14
        If cbsource.SelectedItem = "Seawood Darave      " Then b = 18
        If cbsource.SelectedItem = "Nerul               " Then b = 21
        If cbsource.SelectedItem = "Juinagar            " Then b = 24
        If cbsource.SelectedItem = "Sanpada             " Then b = 27
        If cbsource.SelectedItem = "Vashi               " Then b = 29
        If cbsource.SelectedItem = "Mankhurd            " Then b = 37
        If cbsource.SelectedItem = "Govandi             " Then b = 40
        If cbsource.SelectedItem = "Chembur             " Then b = 42
        If cbsource.SelectedItem = "Tilak nagar         " Then b = 45
        If cbsource.SelectedItem = "Kurla               " Then b = 48
        If cbsource.SelectedItem = "Chunabahtti         " Then b = 51
        If cbsource.SelectedItem = "GTB Nagar           " Then b = 54
        If cbsource.SelectedItem = "Andheri             " Then b = 56
        If cbsource.SelectedItem = "VileParle           " Then b = 60
        If cbsource.SelectedItem = "Santacruz           " Then b = 63
        If cbsource.SelectedItem = "Khar Road           " Then b = 66
        If cbsource.SelectedItem = "Bandra              " Then b = 70
        If cbsource.SelectedItem = "Mahim JN            " Then b = 73
        If cbsource.SelectedItem = "King's Circle       " Then b = 76
        If cbsource.SelectedItem = "Vadala Road         " Then b = 80
        If cbsource.SelectedItem = "Sewri               " Then b = 83
        If cbsource.SelectedItem = "Cotton Green        " Then b = 86
        If cbsource.SelectedItem = "Reay Road           " Then b = 88
        If cbsource.SelectedItem = "Dockyard Road       " Then b = 91
        If cbsource.SelectedItem = "Sandhust Road       " Then b = 93
        If cbsource.SelectedItem = "Masjid              " Then b = 95
        If cbsource.SelectedItem = "Mum CST             " Then b = 98

        If cbdestination.SelectedItem = "Panvel              " Then c = 0
        If cbdestination.SelectedItem = "Khandeshwar         " Then c = 4
        If cbdestination.SelectedItem = "Manarover           " Then c = 7
        If cbdestination.SelectedItem = "Kharghar            " Then c = 10
        If cbdestination.SelectedItem = "Belapur CBD         " Then c = 14
        If cbdestination.SelectedItem = "Seawood Darave      " Then c = 18
        If cbdestination.SelectedItem = "Nerul               " Then c = 21
        If cbdestination.SelectedItem = "Juinagar            " Then c = 24
        If cbdestination.SelectedItem = "Sanpada             " Then c = 27
        If cbdestination.SelectedItem = "Vashi               " Then c = 29
        If cbdestination.SelectedItem = "Mankhurd            " Then c = 37
        If cbdestination.SelectedItem = "Govandi             " Then c = 40
        If cbdestination.SelectedItem = "Chembur             " Then c = 42
        If cbdestination.SelectedItem = "Tilak nagar         " Then c = 45
        If cbdestination.SelectedItem = "Kurla               " Then c = 48
        If cbdestination.SelectedItem = "Chunabahtti         " Then c = 51
        If cbdestination.SelectedItem = "GTB Nagar           " Then c = 54
        If cbdestination.SelectedItem = "Andheri             " Then c = 56
        If cbdestination.SelectedItem = "VileParle           " Then c = 60
        If cbdestination.SelectedItem = "Santacruz           " Then c = 63
        If cbdestination.SelectedItem = "Khar Road           " Then c = 66
        If cbdestination.SelectedItem = "Bandra              " Then c = 70
        If cbdestination.SelectedItem = "Mahim JN            " Then c = 73
        If cbdestination.SelectedItem = "King's Circle       " Then c = 76
        If cbdestination.SelectedItem = "Vadala Road         " Then c = 80
        If cbdestination.SelectedItem = "Sewri               " Then c = 83
        If cbdestination.SelectedItem = "Cotton Green        " Then c = 86
        If cbdestination.SelectedItem = "Reay Road           " Then c = 88
        If cbdestination.SelectedItem = "Dockyard Road       " Then c = 91
        If cbdestination.SelectedItem = "Sandhust Road       " Then c = 93
        If cbdestination.SelectedItem = "Masjid              " Then c = 95
        If cbdestination.SelectedItem = "Mum CST             " Then c = 98

        If cbsource.SelectedIndex < cbdestination.SelectedIndex Then
            txtduration.Text = c - b
        Else
            txtduration.Text = b - c
        End If

        'Distance
        If cbsource.SelectedItem = "Panvel              " Then d = 0
        If cbsource.SelectedItem = "Khandeshwar         " Then d = 3
        If cbsource.SelectedItem = "Manarover           " Then d = 5
        If cbsource.SelectedItem = "Kharghar            " Then d = 8
        If cbsource.SelectedItem = "Belapur CBD         " Then d = 10
        If cbsource.SelectedItem = "Seawood Darave      " Then d = 13
        If cbsource.SelectedItem = "Nerul               " Then d = 15
        If cbsource.SelectedItem = "Juinagar            " Then d = 18
        If cbsource.SelectedItem = "Sanpada             " Then d = 22
        If cbsource.SelectedItem = "Vashi               " Then d = 24
        If cbsource.SelectedItem = "Mankhurd            " Then d = 31
        If cbsource.SelectedItem = "Govandi             " Then d = 34
        If cbsource.SelectedItem = "Chembur             " Then d = 36
        If cbsource.SelectedItem = "Tilak nagar         " Then d = 38
        If cbsource.SelectedItem = "Kurla               " Then d = 39
        If cbsource.SelectedItem = "Chunabahtti         " Then d = 42
        If cbsource.SelectedItem = "GTB Nagar           " Then d = 44
        If cbsource.SelectedItem = "Andheri             " Then d = 46
        If cbsource.SelectedItem = "VileParle           " Then d = 48
        If cbsource.SelectedItem = "Santacruz           " Then d = 51
        If cbsource.SelectedItem = "Khar Road           " Then d = 52
        If cbsource.SelectedItem = "Bandra              " Then d = 54
        If cbsource.SelectedItem = "Mahim JN            " Then d = 56
        If cbsource.SelectedItem = "King's Circle       " Then d = 58
        If cbsource.SelectedItem = "Vadala Road         " Then d = 60
        If cbsource.SelectedItem = "Sewri               " Then d = 62
        If cbsource.SelectedItem = "Cotton Green        " Then d = 64
        If cbsource.SelectedItem = "Reay Road           " Then d = 65
        If cbsource.SelectedItem = "Dockyard Road       " Then d = 66
        If cbsource.SelectedItem = "Sandhust Road       " Then d = 67
        If cbsource.SelectedItem = "Masjid              " Then d = 68
        If cbsource.SelectedItem = "Mum CST             " Then d = 69


        If cbdestination.SelectedItem = "Panvel              " Then d1 = 0
        If cbdestination.SelectedItem = "Khandeshwar         " Then d1 = 3
        If cbdestination.SelectedItem = "Manarover           " Then d1 = 5
        If cbdestination.SelectedItem = "Kharghar            " Then d1 = 8
        If cbdestination.SelectedItem = "Belapur CBD         " Then d1 = 10
        If cbdestination.SelectedItem = "Seawood Darave      " Then d1 = 13
        If cbdestination.SelectedItem = "Nerul               " Then d1 = 15
        If cbdestination.SelectedItem = "Juinagar            " Then d1 = 18
        If cbdestination.SelectedItem = "Sanpada             " Then d1 = 22
        If cbdestination.SelectedItem = "Vashi               " Then d1 = 24
        If cbdestination.SelectedItem = "Mankhurd            " Then d1 = 31
        If cbdestination.SelectedItem = "Govandi             " Then d1 = 34
        If cbdestination.SelectedItem = "Chembur             " Then d1 = 36
        If cbdestination.SelectedItem = "Tilak nagar         " Then d1 = 38
        If cbdestination.SelectedItem = "Kurla               " Then d1 = 39
        If cbdestination.SelectedItem = "Chunabahtti         " Then d1 = 42
        If cbdestination.SelectedItem = "GTB Nagar           " Then d1 = 44
        If cbdestination.SelectedItem = "Andheri             " Then d1 = 46
        If cbdestination.SelectedItem = "VileParle           " Then d1 = 48
        If cbdestination.SelectedItem = "Santacruz           " Then d1 = 51
        If cbdestination.SelectedItem = "Khar Road           " Then d1 = 52
        If cbdestination.SelectedItem = "Bandra              " Then d1 = 54
        If cbdestination.SelectedItem = "Mahim JN            " Then d1 = 56
        If cbdestination.SelectedItem = "King's Circle       " Then d1 = 58
        If cbdestination.SelectedItem = "Vadala Road         " Then d1 = 60
        If cbdestination.SelectedItem = "Sewri               " Then d1 = 62
        If cbdestination.SelectedItem = "Cotton Green        " Then d1 = 64
        If cbdestination.SelectedItem = "Reay Road           " Then d1 = 65
        If cbdestination.SelectedItem = "Dockyard Road       " Then d1 = 66
        If cbdestination.SelectedItem = "Sandhust Road       " Then d1 = 67
        If cbdestination.SelectedItem = "Masjid              " Then d1 = 68
        If cbdestination.SelectedItem = "Mum CST             " Then d1 = 69

        If cbsource.SelectedIndex < cbdestination.SelectedIndex Then
            txtdistance.Text = d1 - d
        Else
            txtdistance.Text = d - d1
        End If
    End Sub
    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        ss = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        If txtpassnum.Text > ds.Tables("Pass").Rows.Count Then
            MsgBox("Please Enter Valid Ticket Number For Printing", MsgBoxStyle.Information)
            Exit Sub
        End If
        passno = txtpassnum.Text
        Dim f As New frmPass_Viewer
        f.Show()
        Me.Hide()
    End Sub

    Private Sub txtpassnum_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassnum.Leave
        If txtpassnum.Text = "" Then
            ep.SetError(txtpassnum, "Please Enter Ticket Number First")
            txtpassnum.Focus()
        End If
    End Sub

    Private Sub txtpassnum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassnum.LostFocus
        If txtpassnum.Text = "" Then
            Exit Sub
        End If
        ss = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        ctr = ds.Tables(0).Rows.Count - 1
        If ctr = -1 Then
            txtpassnum.Text = 1
            Exit Sub
        End If
        For i = 0 To ctr
            If txtpassnum.Text = ds.Tables("Pass").Rows(i).Item(0) Then
                Exit Sub
            End If
        Next
        For i = 0 To ctr
            txtpassnum.Text = ds.Tables("Pass").Rows(i).Item(0)
            txtpassnum.Text = Val(txtpassnum.Text) + 1
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtdate.Text = Format(Now, "dd - MM - yyyy")
        txttime.Text = Format(Now, "hh : mm  : ss")
    End Sub
End Class