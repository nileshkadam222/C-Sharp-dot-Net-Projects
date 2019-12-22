Public Class frmWestern_Pass
    Private Sub frmpasswesternup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()
        MsgBox("WELCOME TO WESTERN)")
        cbsource.Enabled = True
        cbdestination.Enabled = False
        cbroutes.Enabled = False
        cbclass.Items.Add("FIRST")
        cbclass.Items.Add("SECOND")
        cbpasstype.Items.Add("Monthly")
        cbpasstype.Items.Add("Quarterly")
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
        cbdestination.Items.Clear()
        cbroutes.Items.Clear()
        ss = "select * from stations"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "stations")
        ctr = ds.Tables(0).Rows.Count - 13
        For i = 0 To ctr
            cbdestination.Items.Add(ds.Tables(0).Rows(i).Item(4))
        Next
        s = cbsource.SelectedItem
        cbdestination.Items.Remove(s)
        cbroutes.Enabled = True
    End Sub
    Private Sub cbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
        If txtdistance.Text = "" Then Exit Sub
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
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 65) Then txttotalprice.Text = 830
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
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 65) Then txttotalprice.Text = 220
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
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 65) Then txttotalprice.Text = 2260
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
                        If (txtdistance.Text >= 56 And txtdistance.Text <= 65) Then txttotalprice.Text = 605
                End Select
        End Select
    End Sub
    Sub clear()
        txtdistance.Text = ""
        txtduration.Text = ""
        txtmonths.Text = ""
        cbclass.Text = ""
        txtExpiryDate.Text = ""
        txttotalprice.Text = ""
        cbsource.Text = ""
        cbdestination.Text = ""
        cbroutes.Text = ""
        cbpasstype.Text = ""
        cbsource.Enabled = True
        cbdestination.Enabled = False
        cbroutes.Enabled = False
    End Sub

    Private Sub cmdpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpass.Click
        Dim cc As Control
        For Each cc In Me.Controls
            Dim ans As String
            ans = Convert.ToString(c.GetType)
            ans = "Systems.Windows.Forms.textbox"
            If txtpassnum.Text = "" Or cbsource.Text = "" Or cbdestination.Text = "" Or cbpasstype.Text = "" Or txtdate.Text = "" Or txttime.Text = "" Or txtdistance.Text = "" Or txtduration.Text = "" Or cbclass.Text = "" Or txttotalprice.Text = "" Or txtmonths.Text = "" Or txtExpiryDate.Text = "" Then
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
                MsgBox("This Pass Number is not Valid", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        Site_Pass = "WESTERN"
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
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Me.Hide()
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

    Private Sub cbdestination_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdestination.GotFocus
        If cbsource.Text = "" Then
            cbdestination.Enabled = False
        End If
    End Sub
    Private Sub cbdestination_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbdestination.SelectedIndexChanged
        'Duration
        If cbsource.SelectedItem = "Virar               " Then b = 0
        If cbsource.SelectedItem = "Nalla Sopara        " Then b = 6
        If cbsource.SelectedItem = "Vasai Road          " Then b = 11
        If cbsource.SelectedItem = "NaiGaon             " Then b = 15
        If cbsource.SelectedItem = "Bhayander           " Then b = 21
        If cbsource.SelectedItem = "Mira Road           " Then b = 26
        If cbsource.SelectedItem = "Dahisar             " Then b = 30
        If cbsource.SelectedItem = "Borivali            " Then b = 34
        If cbsource.SelectedItem = "Kandivali           " Then b = 38
        If cbsource.SelectedItem = "Malad               " Then b = 41
        If cbsource.SelectedItem = "Goregaon            " Then b = 44
        If cbsource.SelectedItem = "Jogeshwari          " Then b = 47
        If cbsource.SelectedItem = "Andheri             " Then b = 52
        If cbsource.SelectedItem = "Vile Parle          " Then b = 55
        If cbsource.SelectedItem = "Santacruz           " Then b = 58
        If cbsource.SelectedItem = "Khar Road           " Then b = 61
        If cbsource.SelectedItem = "Bandra              " Then b = 65
        If cbsource.SelectedItem = "Mahim JN            " Then b = 68
        If cbsource.SelectedItem = "Matunga Road        " Then b = 71
        If cbsource.SelectedItem = "Dadar               " Then b = 75
        If cbsource.SelectedItem = "Elphinstone Road    " Then b = 77
        If cbsource.SelectedItem = "Lower Parel         " Then b = 80
        If cbsource.SelectedItem = "MahaLakshmi         " Then b = 83
        If cbsource.SelectedItem = "Mumbai Central      " Then b = 86
        If cbsource.SelectedItem = "Grant Road          " Then b = 88
        If cbsource.SelectedItem = "Charni Road         " Then b = 90
        If cbsource.SelectedItem = "Marine Line         " Then b = 95
        If cbsource.SelectedItem = "ChurchGate          " Then b = 98

        If cbdestination.SelectedItem = "Virar               " Then c = 0
        If cbdestination.SelectedItem = "Nalla Sopara        " Then c = 6
        If cbdestination.SelectedItem = "Vasai Road          " Then c = 11
        If cbdestination.SelectedItem = "NaiGaon             " Then c = 15
        If cbdestination.SelectedItem = "Bhayander           " Then c = 21
        If cbdestination.SelectedItem = "Mira Road           " Then c = 26
        If cbdestination.SelectedItem = "Dahisar             " Then c = 30
        If cbdestination.SelectedItem = "Borivali            " Then c = 34
        If cbdestination.SelectedItem = "Kandivali           " Then c = 38
        If cbdestination.SelectedItem = "Malad               " Then c = 41
        If cbdestination.SelectedItem = "Goregaon            " Then c = 44
        If cbdestination.SelectedItem = "Jogeshwari          " Then c = 47
        If cbdestination.SelectedItem = "Andheri             " Then c = 52
        If cbdestination.SelectedItem = "Vile Parle          " Then c = 55
        If cbdestination.SelectedItem = "Santacruz           " Then c = 58
        If cbdestination.SelectedItem = "Khar Road           " Then c = 61
        If cbdestination.SelectedItem = "Bandra              " Then c = 65
        If cbdestination.SelectedItem = "Mahim JN            " Then c = 68
        If cbdestination.SelectedItem = "Matunga Road        " Then c = 71
        If cbdestination.SelectedItem = "Dadar               " Then c = 75
        If cbdestination.SelectedItem = "Elphinstone Road    " Then c = 77
        If cbdestination.SelectedItem = "Lower Parel         " Then c = 80
        If cbdestination.SelectedItem = "MahaLakshmi         " Then c = 83
        If cbdestination.SelectedItem = "Mumbai Central      " Then c = 86
        If cbdestination.SelectedItem = "Grant Road          " Then c = 88
        If cbdestination.SelectedItem = "Charni Road         " Then c = 90
        If cbdestination.SelectedItem = "Marine Line         " Then c = 95
        If cbdestination.SelectedItem = "ChurchGate          " Then c = 98

        If c > b Then
            txtduration.Text = c - b
        Else
            txtduration.Text = b - c
        End If
        'Distance
        If cbsource.SelectedItem = "Virar               " Then d = 0
        If cbsource.SelectedItem = "Nalla Sopara        " Then d = 4
        If cbsource.SelectedItem = "Vasai Road          " Then d = 8
        If cbsource.SelectedItem = "NaiGaon             " Then d = 12
        If cbsource.SelectedItem = "Bhayander           " Then d = 16
        If cbsource.SelectedItem = "Mira Road           " Then d = 20
        If cbsource.SelectedItem = "Dahisar             " Then d = 23
        If cbsource.SelectedItem = "Borivali            " Then d = 26
        If cbsource.SelectedItem = "Kandivali           " Then d = 28
        If cbsource.SelectedItem = "Malad               " Then d = 30
        If cbsource.SelectedItem = "Goregaon            " Then d = 33
        If cbsource.SelectedItem = "Jogeshwari          " Then d = 36
        If cbsource.SelectedItem = "Andheri             " Then d = 38
        If cbsource.SelectedItem = "Vile Parle          " Then d = 40
        If cbsource.SelectedItem = "Santacruz           " Then d = 42
        If cbsource.SelectedItem = "Khar Road           " Then d = 43
        If cbsource.SelectedItem = "Bandra              " Then d = 45
        If cbsource.SelectedItem = "Mahim JN            " Then d = 47
        If cbsource.SelectedItem = "Matunga Road        " Then d = 48
        If cbsource.SelectedItem = "Dadar               " Then d = 49
        If cbsource.SelectedItem = "Elphinstone Road    " Then d = 51
        If cbsource.SelectedItem = "Lower Parel         " Then d = 52
        If cbsource.SelectedItem = "MahaLakshmi         " Then d = 54
        If cbsource.SelectedItem = "Mumbai Central      " Then d = 55
        If cbsource.SelectedItem = "Grant Road          " Then d = 56
        If cbsource.SelectedItem = "Charni Road         " Then d = 57
        If cbsource.SelectedItem = "Marine Line         " Then d = 58
        If cbsource.SelectedItem = "ChurchGate          " Then d = 61

        If cbdestination.SelectedItem = "Virar               " Then d1 = 0
        If cbdestination.SelectedItem = "Nalla Sopara        " Then d1 = 4
        If cbdestination.SelectedItem = "Vasai Road          " Then d1 = 8
        If cbdestination.SelectedItem = "NaiGaon             " Then d1 = 12
        If cbdestination.SelectedItem = "Bhayander           " Then d1 = 16
        If cbdestination.SelectedItem = "Mira Road           " Then d1 = 20
        If cbdestination.SelectedItem = "Dahisar             " Then d1 = 23
        If cbdestination.SelectedItem = "Borivali            " Then d1 = 26
        If cbdestination.SelectedItem = "Kandivali           " Then d1 = 28
        If cbdestination.SelectedItem = "Malad               " Then d1 = 30
        If cbdestination.SelectedItem = "Goregaon            " Then d1 = 33
        If cbdestination.SelectedItem = "Jogeshwari          " Then d1 = 36
        If cbdestination.SelectedItem = "Andheri             " Then d1 = 38
        If cbdestination.SelectedItem = "Vile Parle          " Then d1 = 40
        If cbdestination.SelectedItem = "Santacruz           " Then d1 = 42
        If cbdestination.SelectedItem = "Khar Road           " Then d1 = 43
        If cbdestination.SelectedItem = "Bandra              " Then d1 = 45
        If cbdestination.SelectedItem = "Mahim JN            " Then d1 = 47
        If cbdestination.SelectedItem = "Matunga Road        " Then d1 = 48
        If cbdestination.SelectedItem = "Dadar               " Then d1 = 49
        If cbdestination.SelectedItem = "Elphinstone Road    " Then d1 = 51
        If cbdestination.SelectedItem = "Lower Parel         " Then d1 = 52
        If cbdestination.SelectedItem = "MahaLakshmi         " Then d1 = 54
        If cbdestination.SelectedItem = "Mumbai Central      " Then d1 = 55
        If cbdestination.SelectedItem = "Grant Road          " Then d1 = 56
        If cbdestination.SelectedItem = "Charni Road         " Then d1 = 57
        If cbdestination.SelectedItem = "Marine Line         " Then d1 = 58
        If cbdestination.SelectedItem = "ChurchGate          " Then d1 = 61

        If d1 > d Then
            txtdistance.Text = d1 - d
        Else
            txtdistance.Text = d - d1
        End If
    End Sub

    Private Sub cbsource_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsource.Click
        cbdestination.Text = ""
        cbsource.Items.Clear()
        cbdestination.Items.Clear()
        ss = "select * from stations"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "stations")
        ctr = ds.Tables(0).Rows.Count - 13
        For i = 0 To ctr
            cbsource.Items.Add(ds.Tables(0).Rows(i).Item(4))
        Next
        cbdestination.Enabled = True
        txtdistance.Text = ""
        txtduration.Text = ""
        cbpasstype.Text = ""
        txtmonths.Text = ""
        cbclass.Text = ""
        txtExpiryDate.Text = ""
        txttotalprice.Text = ""
    End Sub
    Private Sub cbroutes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbroutes.Click
        If cbsource.SelectedIndex < cbdestination.SelectedIndex Then
            cbroutes.Items.Clear()
            a = cbsource.SelectedIndex
            ss = "select * from stations"
            adp = New SqlClient.SqlDataAdapter(ss, cn)
            ds = New DataSet
            adp.Fill(ds, "stations")
            ctr = cbdestination.SelectedIndex
            For i = a + 1 To ctr
                cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(4))
            Next
        End If
        If cbsource.SelectedIndex > cbdestination.SelectedIndex Then
            a = cbdestination.SelectedIndex
            cbroutes.Items.Clear()
            ss = "select * from stations"
            adp = New SqlClient.SqlDataAdapter(ss, cn)
            ds = New DataSet
            adp.Fill(ds, "stations")
            ctr = cbsource.SelectedIndex - 1
            For i = a + 1 To ctr
                cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(4))
            Next
        End If
    End Sub

    Private Sub cbpasstype_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbpasstype.Click

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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class