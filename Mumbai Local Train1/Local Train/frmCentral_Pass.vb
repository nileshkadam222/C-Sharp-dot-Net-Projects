Public Class frmCentral_Pass
    Private Sub frmpasscentralup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Call Connection()
        MsgBox("WELCOME TO CENTRAL")
        cbsource.Enabled = False
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
            txtPassnum.Text = ds.Tables("Pass").Rows(i).Item(0)
        Next
        txtPassnum.Text = Val(txtPassnum.Text) + 1
        Timer1.Enabled = True
    End Sub

    Private Sub cbdestination_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdestination.Click
        m = cbsource_destination.Text
        cbdestination.Text = ""
        Select Case m
            Case "Khapoli to Mumbai CST"
                cbdestination.Items.Clear()
                cbroutes.Items.Clear()
                ss = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(ss, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 1
                For i = 0 To ctr
                    cbdestination.Items.Add(ds.Tables(0).Rows(i).Item(1))
                Next

            Case "Kasara to Mumbai CST"
                cbdestination.Items.Clear()
                cbroutes.Items.Clear()
                ss = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(ss, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 6
                For i = 0 To ctr
                    cbdestination.Items.Add(ds.Tables(0).Rows(i).Item(3))
                Next
        End Select
        cbroutes.Enabled = True
        s = cbsource.SelectedItem
        cbdestination.Items.Remove(s)
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
                        If (txtdistance.Text >= 66 And txtdistance.Text <= 70) Then txttotalprice.Text = 890
                        If (txtdistance.Text >= 71 And txtdistance.Text <= 75) Then txttotalprice.Text = 950
                        If (txtdistance.Text >= 76 And txtdistance.Text <= 80) Then txttotalprice.Text = 1010
                        If (txtdistance.Text >= 81 And txtdistance.Text <= 85) Then txttotalprice.Text = 1070
                        If (txtdistance.Text >= 86 And txtdistance.Text <= 90) Then txttotalprice.Text = 1130
                        If (txtdistance.Text >= 91 And txtdistance.Text <= 95) Then txttotalprice.Text = 1190
                        If (txtdistance.Text >= 96 And txtdistance.Text <= 100) Then txttotalprice.Text = 1260
                        If (txtdistance.Text >= 101 And txtdistance.Text <= 105) Then txttotalprice.Text = 1320
                        If (txtdistance.Text >= 106 And txtdistance.Text <= 110) Then txttotalprice.Text = 1380
                        If (txtdistance.Text >= 111 And txtdistance.Text <= 115) Then txttotalprice.Text = 1440
                        If (txtdistance.Text >= 116 And txtdistance.Text <= 125) Then txttotalprice.Text = 1500
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
                        If (txtdistance.Text >= 66 And txtdistance.Text <= 70) Then txttotalprice.Text = 235
                        If (txtdistance.Text >= 71 And txtdistance.Text <= 75) Then txttotalprice.Text = 250
                        If (txtdistance.Text >= 76 And txtdistance.Text <= 80) Then txttotalprice.Text = 265
                        If (txtdistance.Text >= 81 And txtdistance.Text <= 85) Then txttotalprice.Text = 280
                        If (txtdistance.Text >= 86 And txtdistance.Text <= 90) Then txttotalprice.Text = 295
                        If (txtdistance.Text >= 91 And txtdistance.Text <= 95) Then txttotalprice.Text = 310
                        If (txtdistance.Text >= 96 And txtdistance.Text <= 100) Then txttotalprice.Text = 330
                        If (txtdistance.Text >= 101 And txtdistance.Text <= 105) Then txttotalprice.Text = 345
                        If (txtdistance.Text >= 106 And txtdistance.Text <= 110) Then txttotalprice.Text = 360
                        If (txtdistance.Text >= 111 And txtdistance.Text <= 115) Then txttotalprice.Text = 375
                        If (txtdistance.Text >= 116 And txtdistance.Text <= 125) Then txttotalprice.Text = 390
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
                        If (txtdistance.Text >= 66 And txtdistance.Text <= 70) Then txttotalprice.Text = 2420
                        If (txtdistance.Text >= 71 And txtdistance.Text <= 75) Then txttotalprice.Text = 2580
                        If (txtdistance.Text >= 76 And txtdistance.Text <= 80) Then txttotalprice.Text = 2745
                        If (txtdistance.Text >= 81 And txtdistance.Text <= 85) Then txttotalprice.Text = 2905
                        If (txtdistance.Text >= 86 And txtdistance.Text <= 90) Then txttotalprice.Text = 3070
                        If (txtdistance.Text >= 91 And txtdistance.Text <= 95) Then txttotalprice.Text = 3230
                        If (txtdistance.Text >= 96 And txtdistance.Text <= 100) Then txttotalprice.Text = 3230
                        If (txtdistance.Text >= 101 And txtdistance.Text <= 105) Then txttotalprice.Text = 3420
                        If (txtdistance.Text >= 106 And txtdistance.Text <= 110) Then txttotalprice.Text = 3585
                        If (txtdistance.Text >= 111 And txtdistance.Text <= 115) Then txttotalprice.Text = 3745
                        If (txtdistance.Text >= 116 And txtdistance.Text <= 125) Then txttotalprice.Text = 3905
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
                        If (txtdistance.Text >= 66 And txtdistance.Text <= 70) Then txttotalprice.Text = 645
                        If (txtdistance.Text >= 71 And txtdistance.Text <= 75) Then txttotalprice.Text = 685
                        If (txtdistance.Text >= 76 And txtdistance.Text <= 80) Then txttotalprice.Text = 725
                        If (txtdistance.Text >= 81 And txtdistance.Text <= 85) Then txttotalprice.Text = 765
                        If (txtdistance.Text >= 86 And txtdistance.Text <= 90) Then txttotalprice.Text = 805
                        If (txtdistance.Text >= 91 And txtdistance.Text <= 95) Then txttotalprice.Text = 845
                        If (txtdistance.Text >= 96 And txtdistance.Text <= 100) Then txttotalprice.Text = 900
                        If (txtdistance.Text >= 101 And txtdistance.Text <= 105) Then txttotalprice.Text = 945
                        If (txtdistance.Text >= 106 And txtdistance.Text <= 110) Then txttotalprice.Text = 990
                        If (txtdistance.Text >= 111 And txtdistance.Text <= 115) Then txttotalprice.Text = 1035
                        If (txtdistance.Text >= 116 And txtdistance.Text <= 125) Then txttotalprice.Text = 1080
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
        cbsource_destination.Text = ""
        cbsource.Enabled = False
        cbdestination.Enabled = False
        cbroutes.Enabled = False
    End Sub

    Private Sub cmdpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpass.Click
        Dim cc As Control
        For Each cc In Me.Controls
            Dim ans As String
            ans = Convert.ToString(c.GetType)
            ans = "Systems.Windows.Forms.textbox"
            If txtPassnum.Text = "" Or cbsource.Text = "" Or cbdestination.Text = "" Or cbpasstype.Text = "" Or txtdate.Text = "" Or txttime.Text = "" Or txtdistance.Text = "" Or txtduration.Text = "" Or cbclass.Text = "" Or txttotalprice.Text = "" Or txtmonths.Text = "" Or txtExpiryDate.Text = "" Then
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
            If txtPassnum.Text = ds.Tables("Pass").Rows(i).Item(0) Then
                MsgBox("This Pass Number is not Valid", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        Site_Pass = "CENTRAL"
        sss = "insert into Pass Values('" + txtPassnum.Text + "','" + cbsource.Text + "','" + cbdestination.Text + "','" + txtdate.Text + "','" + txttime.Text + "','" + txtdistance.Text + "','" + txtduration.Text + "','" + cbpasstype.Text + "','" + txtmonths.Text + "','" + cbclass.Text + "','" + txtExpiryDate.Text + "','" + txttotalprice.Text + "','" + Site_Pass + "')"
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
        n = txtPassnum.Text
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

    Private Sub txtticketnum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassnum.KeyPress
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

    Private Sub txttotalprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub

    Private Sub txtExpiryDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExpiryDate.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub

    Private Sub cbsource_destination_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsource_destination.Click
        cbsource.Items.Clear()
        cbdestination.Items.Clear()
        cbroutes.Items.Clear()
        cbsource_destination.Items.Clear()
        cbsource_destination.Items.Add("Khapoli to Mumbai CST")
        cbsource_destination.Items.Add("Kasara to Mumbai CST")
        cbsource.Text = ""
        cbdestination.Text = ""
        cbroutes.Text = ""
        txtdistance.Text = ""
        txtduration.Text = ""
        cbpasstype.Text = ""
        txtmonths.Text = ""
        cbclass.Text = ""
        txtExpiryDate.Text = ""
        txttotalprice.Text = ""
        cbsource.Enabled = True
        cbdestination.Enabled = False
        cbroutes.Enabled = False
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
        m = cbsource_destination.Text
        cbdestination.Text = ""
        Select Case m
            Case "Khapoli to Mumbai CST"
                cbsource.Items.Clear()
                cbdestination.Items.Clear()
                ss = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(ss, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 1
                For i = 0 To ctr
                    cbsource.Items.Add(ds.Tables(0).Rows(i).Item(1))
                Next
            Case "Kasara to Mumbai CST"
                cbsource.Items.Clear()
                cbdestination.Items.Clear()
                ss = "select * from stations"
                adp = New SqlClient.SqlDataAdapter(ss, cn)
                ds = New DataSet
                adp.Fill(ds, "stations")
                ctr = ds.Tables(0).Rows.Count - 6
                For i = 0 To ctr
                    cbsource.Items.Add(ds.Tables(0).Rows(i).Item(3))
                Next
        End Select
        cbdestination.Enabled = True
        cbroutes.Enabled = False
    End Sub
    Private Sub cbroutes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbroutes.Click
        m = cbsource_destination.Text
        If cbsource.SelectedIndex < cbdestination.SelectedIndex Then
            Select Case m
                Case "Khapoli to Mumbai CST"
                    cbroutes.Items.Clear()
                    a = cbsource.SelectedIndex
                    ss = "select * from stations"
                    adp = New SqlClient.SqlDataAdapter(ss, cn)
                    ds = New DataSet
                    adp.Fill(ds, "stations")
                    ctr = cbdestination.SelectedIndex
                    For i = a + 1 To ctr
                        cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(1))
                    Next
                Case "Kasara to Mumbai CST"
                    cbroutes.Items.Clear()
                    a = cbsource.SelectedIndex
                    ss = "select * from stations"
                    adp = New SqlClient.SqlDataAdapter(ss, cn)
                    ds = New DataSet
                    adp.Fill(ds, "stations")
                    ctr = cbdestination.SelectedIndex
                    For i = a + 1 To ctr
                        cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(3))
                    Next
            End Select
        ElseIf cbsource.SelectedIndex > cbdestination.SelectedIndex Then
            Select Case m
                Case "Khapoli to Mumbai CST"
                    cbroutes.Items.Clear()
                    a = cbdestination.SelectedIndex
                    ss = "select * from stations"
                    adp = New SqlClient.SqlDataAdapter(ss, cn)
                    ds = New DataSet
                    adp.Fill(ds, "stations")
                    ctr = cbsource.SelectedIndex - 1
                    For i = a + 1 To ctr
                        cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(1))
                    Next
                Case "Kasara to Mumbai CST"
                    a = cbdestination.SelectedIndex
                    cbroutes.Items.Clear()
                    ss = "select * from stations"
                    adp = New SqlClient.SqlDataAdapter(ss, cn)
                    ds = New DataSet
                    adp.Fill(ds, "stations")
                    ctr = cbsource.SelectedIndex - 1
                    For i = a + 1 To ctr
                        cbroutes.Items.Add(ds.Tables(0).Rows(i).Item(3))
                    Next
            End Select
        End If
    End Sub

    Private Sub cbdestination_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdestination.GotFocus
        If cbsource.Text = "" Then
            cbdestination.Enabled = False
        End If
    End Sub
    Private Sub cbdestination_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbdestination.SelectedIndexChanged
        'Duration
        Select Case cbsource_destination.Text
            Case "Khapoli to Mumbai CST"
                If cbsource.SelectedItem = "Khapoli             " Then b = 0
                If cbsource.SelectedItem = "Lawjee              " Then b = 6
                If cbsource.SelectedItem = "Dolavli             " Then b = 10
                If cbsource.SelectedItem = "Kalavli             " Then b = 13
                If cbsource.SelectedItem = "Palasdhari          " Then b = 20
                If cbsource.SelectedItem = "Karjat              " Then b = 25
                If cbsource.SelectedItem = "Bhivpuri Road       " Then b = 36
                If cbsource.SelectedItem = "Neral               " Then b = 44
                If cbsource.SelectedItem = "Shelu               " Then b = 49
                If cbsource.SelectedItem = "Vangani             " Then b = 54
                If cbsource.SelectedItem = "Badlapur            " Then b = 65
                If cbsource.SelectedItem = "Ambernath           " Then b = 74
                If cbsource.SelectedItem = "Ulhas Nagar         " Then b = 79
                If cbsource.SelectedItem = "Vithalwadi          " Then b = 82
                If cbsource.SelectedItem = "Kalyan              " Then b = 86
                If cbsource.SelectedItem = "Thakurti            " Then b = 92
                If cbsource.SelectedItem = "Dombivli            " Then b = 95
                If cbsource.SelectedItem = "Kopar               " Then b = 98
                If cbsource.SelectedItem = "Diva                " Then b = 103
                If cbsource.SelectedItem = "Mumbra              " Then b = 107
                If cbsource.SelectedItem = "Kalva               " Then b = 113
                If cbsource.SelectedItem = "Thane               " Then b = 117
                If cbsource.SelectedItem = "Mulund              " Then b = 122
                If cbsource.SelectedItem = "Nahur               " Then b = 125
                If cbsource.SelectedItem = "Bhandup             " Then b = 128
                If cbsource.SelectedItem = "Kanjur Marg         " Then b = 130
                If cbsource.SelectedItem = "Vikhroli            " Then b = 133
                If cbsource.SelectedItem = "Ghatkopar           " Then b = 138
                If cbsource.SelectedItem = "Vidyavihar          " Then b = 141
                If cbsource.SelectedItem = "Kurla               " Then b = 144
                If cbsource.SelectedItem = "Sion                " Then b = 148
                If cbsource.SelectedItem = "Matunga             " Then b = 152
                If cbsource.SelectedItem = "Dadar               " Then b = 155
                If cbsource.SelectedItem = "Parel               " Then b = 157
                If cbsource.SelectedItem = "Currey Road         " Then b = 160
                If cbsource.SelectedItem = "Chinchpokli         " Then b = 162
                If cbsource.SelectedItem = "Byculla             " Then b = 164
                If cbsource.SelectedItem = "Sandhust Road       " Then b = 166
                If cbsource.SelectedItem = "Masjid              " Then b = 168
                If cbsource.SelectedItem = "Mumbai CST          " Then b = 172

                If cbdestination.SelectedItem = "Khapoli             " Then c = 0
                If cbdestination.SelectedItem = "Lawjee              " Then c = 6
                If cbdestination.SelectedItem = "Dolavli             " Then c = 10
                If cbdestination.SelectedItem = "Kalavli             " Then c = 13
                If cbdestination.SelectedItem = "Palasdhari          " Then c = 20
                If cbdestination.SelectedItem = "Karjat              " Then c = 25
                If cbdestination.SelectedItem = "Bhivpuri Road       " Then c = 36
                If cbdestination.SelectedItem = "Neral               " Then c = 44
                If cbdestination.SelectedItem = "Shelu               " Then c = 49
                If cbdestination.SelectedItem = "Vangani             " Then c = 54
                If cbdestination.SelectedItem = "Badlapur            " Then c = 65
                If cbdestination.SelectedItem = "Ambernath           " Then c = 74
                If cbdestination.SelectedItem = "Ulhas Nagar         " Then c = 79
                If cbdestination.SelectedItem = "Vithalwadi          " Then c = 82
                If cbdestination.SelectedItem = "Kalyan              " Then c = 86
                If cbdestination.SelectedItem = "Thakurti            " Then c = 92
                If cbdestination.SelectedItem = "Dombivli            " Then c = 95
                If cbdestination.SelectedItem = "Kopar               " Then c = 98
                If cbdestination.SelectedItem = "Diva                " Then c = 103
                If cbdestination.SelectedItem = "Mumbra              " Then c = 107
                If cbdestination.SelectedItem = "Kalva               " Then c = 113
                If cbdestination.SelectedItem = "Thane               " Then c = 117
                If cbdestination.SelectedItem = "Mulund              " Then c = 122
                If cbdestination.SelectedItem = "Nahur               " Then c = 125
                If cbdestination.SelectedItem = "Bhandup             " Then c = 128
                If cbdestination.SelectedItem = "Kanjur Marg         " Then c = 130
                If cbdestination.SelectedItem = "Vikhroli            " Then c = 133
                If cbdestination.SelectedItem = "Ghatkopar           " Then c = 138
                If cbdestination.SelectedItem = "Vidyavihar          " Then c = 141
                If cbdestination.SelectedItem = "Kurla               " Then c = 144
                If cbdestination.SelectedItem = "Sion                " Then c = 148
                If cbdestination.SelectedItem = "Matunga             " Then c = 152
                If cbdestination.SelectedItem = "Dadar               " Then c = 155
                If cbdestination.SelectedItem = "Parel               " Then c = 157
                If cbdestination.SelectedItem = "Currey Road         " Then c = 160
                If cbdestination.SelectedItem = "Chinchpokli         " Then c = 162
                If cbdestination.SelectedItem = "Byculla             " Then c = 164
                If cbdestination.SelectedItem = "Sandhust Road       " Then c = 166
                If cbdestination.SelectedItem = "Masjid              " Then c = 168
                If cbdestination.SelectedItem = "Mumbai CST          " Then c = 172
                If c > b Then
                    txtduration.Text = c - b
                Else
                    txtduration.Text = b - c

                End If
            Case "Kasara to Mumbai CST"
                If cbsource.SelectedItem = "Kasara              " Then b = 0
                If cbsource.SelectedItem = "Khardi              " Then b = 18
                If cbsource.SelectedItem = "Algaon              " Then b = 30
                If cbsource.SelectedItem = "AsanGaon            " Then b = 39
                If cbsource.SelectedItem = "Vasind              " Then b = 45
                If cbsource.SelectedItem = "Khadavli            " Then b = 53
                If cbsource.SelectedItem = "Titwala             " Then b = 61
                If cbsource.SelectedItem = "Ambivli             " Then b = 68
                If cbsource.SelectedItem = "Shahad              " Then b = 72
                If cbsource.SelectedItem = "Kalyan              " Then b = 76
                If cbsource.SelectedItem = "Thakurti            " Then b = 82
                If cbsource.SelectedItem = "Dombivli            " Then b = 85
                If cbsource.SelectedItem = "Kopar               " Then b = 88
                If cbsource.SelectedItem = "Diva                " Then b = 93
                If cbsource.SelectedItem = "Mumbra              " Then b = 97
                If cbsource.SelectedItem = "Kalva               " Then b = 103
                If cbsource.SelectedItem = "Thane               " Then b = 107
                If cbsource.SelectedItem = "Mulund              " Then b = 112
                If cbsource.SelectedItem = "Nahur               " Then b = 115
                If cbsource.SelectedItem = "Bhandup             " Then b = 118
                If cbsource.SelectedItem = "Kanjur Marg         " Then b = 120
                If cbsource.SelectedItem = "Vikhroli            " Then b = 123
                If cbsource.SelectedItem = "Ghatkopar           " Then b = 128
                If cbsource.SelectedItem = "Vidyavihar          " Then b = 131
                If cbsource.SelectedItem = "Kurla               " Then b = 134
                If cbsource.SelectedItem = "Sion                " Then b = 138
                If cbsource.SelectedItem = "Matunga             " Then b = 142
                If cbsource.SelectedItem = "Dadar               " Then b = 145
                If cbsource.SelectedItem = "Parel               " Then b = 147
                If cbsource.SelectedItem = "Currey Road         " Then b = 150
                If cbsource.SelectedItem = "Chinchpokli         " Then b = 152
                If cbsource.SelectedItem = "Byculla             " Then b = 154
                If cbsource.SelectedItem = "Sandhust Road       " Then b = 156
                If cbsource.SelectedItem = "Masjid              " Then b = 158
                If cbsource.SelectedItem = "Mumbai CST          " Then b = 162


                If cbdestination.SelectedItem = "Kasara              " Then c = 0
                If cbdestination.SelectedItem = "Khardi              " Then c = 18
                If cbdestination.SelectedItem = "Algaon              " Then c = 30
                If cbdestination.SelectedItem = "AsanGaon            " Then c = 39
                If cbdestination.SelectedItem = "Vasind              " Then c = 45
                If cbdestination.SelectedItem = "Khadavli            " Then c = 53
                If cbdestination.SelectedItem = "Titwala             " Then c = 61
                If cbdestination.SelectedItem = "Ambivli             " Then c = 68
                If cbdestination.SelectedItem = "Shahad              " Then c = 72
                If cbdestination.SelectedItem = "Kalyan              " Then c = 76
                If cbdestination.SelectedItem = "Thakurti            " Then c = 82
                If cbdestination.SelectedItem = "Dombivli            " Then c = 85
                If cbdestination.SelectedItem = "Kopar               " Then c = 88
                If cbdestination.SelectedItem = "Diva                " Then c = 93
                If cbdestination.SelectedItem = "Mumbra              " Then c = 97
                If cbdestination.SelectedItem = "Kalva               " Then c = 103
                If cbdestination.SelectedItem = "Thane               " Then c = 107
                If cbdestination.SelectedItem = "Mulund              " Then c = 112
                If cbdestination.SelectedItem = "Nahur               " Then c = 115
                If cbdestination.SelectedItem = "Bhandup             " Then c = 118
                If cbdestination.SelectedItem = "Kanjur Marg         " Then c = 120
                If cbdestination.SelectedItem = "Vikhroli            " Then c = 123
                If cbdestination.SelectedItem = "Ghatkopar           " Then c = 128
                If cbdestination.SelectedItem = "Vidyavihar          " Then c = 131
                If cbdestination.SelectedItem = "Kurla               " Then c = 134
                If cbdestination.SelectedItem = "Sion                " Then c = 138
                If cbdestination.SelectedItem = "Matunga             " Then c = 142
                If cbdestination.SelectedItem = "Dadar               " Then c = 145
                If cbdestination.SelectedItem = "Parel               " Then c = 147
                If cbdestination.SelectedItem = "Currey Road         " Then c = 150
                If cbdestination.SelectedItem = "Chinchpokli         " Then c = 152
                If cbdestination.SelectedItem = "Byculla             " Then c = 154
                If cbdestination.SelectedItem = "Sandhust Road       " Then c = 156
                If cbdestination.SelectedItem = "Masjid              " Then c = 158
                If cbdestination.SelectedItem = "Mumbai CST          " Then c = 162

                If c > b Then
                    txtduration.Text = c - b
                Else
                    txtduration.Text = b - c
                End If
                txtduration.Refresh()
        End Select
        'Distance
        Select Case cbsource_destination.Text
            Case "Khapoli to Mumbai CST"
                If cbsource.SelectedItem = "Khapoli             " Then d = 0
                If cbsource.SelectedItem = "Lawjee              " Then d = 3
                If cbsource.SelectedItem = "Dolavli             " Then d = 6
                If cbsource.SelectedItem = "Kalavli             " Then d = 8
                If cbsource.SelectedItem = "Palasdhari          " Then d = 13
                If cbsource.SelectedItem = "Karjat              " Then d = 17
                If cbsource.SelectedItem = "Bhivpuri Road       " Then d = 24
                If cbsource.SelectedItem = "Neral               " Then d = 30
                If cbsource.SelectedItem = "Shelu               " Then d = 34
                If cbsource.SelectedItem = "Vangani             " Then d = 38
                If cbsource.SelectedItem = "Badlapur            " Then d = 49
                If cbsource.SelectedItem = "Ambernath           " Then d = 57
                If cbsource.SelectedItem = "Ulhas Nagar         " Then d = 60
                If cbsource.SelectedItem = "Vithalwadi          " Then d = 62
                If cbsource.SelectedItem = "Kalyan              " Then d = 64
                If cbsource.SelectedItem = "Thakurti            " Then d = 68
                If cbsource.SelectedItem = "Dombivli            " Then d = 70
                If cbsource.SelectedItem = "Kopar               " Then d = 72
                If cbsource.SelectedItem = "Diva                " Then d = 76
                If cbsource.SelectedItem = "Mumbra              " Then d = 79
                If cbsource.SelectedItem = "Kalva               " Then d = 83
                If cbsource.SelectedItem = "Thane               " Then d = 86
                If cbsource.SelectedItem = "Mulund              " Then d = 89
                If cbsource.SelectedItem = "Nahur               " Then d = 91
                If cbsource.SelectedItem = "Bhandup             " Then d = 93
                If cbsource.SelectedItem = "Kanjur Marg         " Then d = 95
                If cbsource.SelectedItem = "Vikhroli            " Then d = 97
                If cbsource.SelectedItem = "Ghatkopar           " Then d = 100
                If cbsource.SelectedItem = "Vidyavihar          " Then d = 102
                If cbsource.SelectedItem = "Kurla               " Then d = 104
                If cbsource.SelectedItem = "Sion                " Then d = 107
                If cbsource.SelectedItem = "Matunga             " Then d = 110
                If cbsource.SelectedItem = "Dadar               " Then d = 111
                If cbsource.SelectedItem = "Parel               " Then d = 112
                If cbsource.SelectedItem = "Currey Road         " Then d = 114
                If cbsource.SelectedItem = "Chinchpokli         " Then d = 115
                If cbsource.SelectedItem = "Byculla             " Then d = 117
                If cbsource.SelectedItem = "Sandhust Road       " Then d = 118
                If cbsource.SelectedItem = "Masjid              " Then d = 119
                If cbsource.SelectedItem = "Mumbai CST          " Then d = 120

                If cbdestination.SelectedItem = "Khapoli             " Then d1 = 0
                If cbdestination.SelectedItem = "Lawjee              " Then d1 = 3
                If cbdestination.SelectedItem = "Dolavli             " Then d1 = 6
                If cbdestination.SelectedItem = "Kalavli             " Then d1 = 8
                If cbdestination.SelectedItem = "Palasdhari          " Then d1 = 13
                If cbdestination.SelectedItem = "Karjat              " Then d1 = 17
                If cbdestination.SelectedItem = "Bhivpuri Road       " Then d1 = 24
                If cbdestination.SelectedItem = "Neral               " Then d1 = 30
                If cbdestination.SelectedItem = "Shelu               " Then d1 = 34
                If cbdestination.SelectedItem = "Vangani             " Then d1 = 38
                If cbdestination.SelectedItem = "Badlapur            " Then d1 = 49
                If cbdestination.SelectedItem = "Ambernath           " Then d1 = 57
                If cbdestination.SelectedItem = "Ulhas Nagar         " Then d1 = 60
                If cbdestination.SelectedItem = "Vithalwadi          " Then d1 = 62
                If cbdestination.SelectedItem = "Kalyan              " Then d1 = 64
                If cbdestination.SelectedItem = "Thakurti            " Then d1 = 68
                If cbdestination.SelectedItem = "Dombivli            " Then d1 = 70
                If cbdestination.SelectedItem = "Kopar               " Then d1 = 72
                If cbdestination.SelectedItem = "Diva                " Then d1 = 76
                If cbdestination.SelectedItem = "Mumbra              " Then d1 = 79
                If cbdestination.SelectedItem = "Kalva               " Then d1 = 83
                If cbdestination.SelectedItem = "Thane               " Then d1 = 86
                If cbdestination.SelectedItem = "Mulund              " Then d1 = 89
                If cbdestination.SelectedItem = "Nahur               " Then d1 = 91
                If cbdestination.SelectedItem = "Bhandup             " Then d1 = 93
                If cbdestination.SelectedItem = "Kanjur Marg         " Then d1 = 95
                If cbdestination.SelectedItem = "Vikhroli            " Then d1 = 97
                If cbdestination.SelectedItem = "Ghatkopar           " Then d1 = 100
                If cbdestination.SelectedItem = "Vidyavihar          " Then d1 = 102
                If cbdestination.SelectedItem = "Kurla               " Then d1 = 104
                If cbdestination.SelectedItem = "Sion                " Then d1 = 107
                If cbdestination.SelectedItem = "Matunga             " Then d1 = 110
                If cbdestination.SelectedItem = "Dadar               " Then d1 = 111
                If cbdestination.SelectedItem = "Parel               " Then d1 = 112
                If cbdestination.SelectedItem = "Currey Road         " Then d1 = 114
                If cbdestination.SelectedItem = "Chinchpokli         " Then d1 = 115
                If cbdestination.SelectedItem = "Byculla             " Then d1 = 117
                If cbdestination.SelectedItem = "Sandhust Road       " Then d1 = 118
                If cbdestination.SelectedItem = "Masjid              " Then d1 = 119
                If cbdestination.SelectedItem = "Mumbai CST          " Then d1 = 120

                If d1 > d Then
                    txtdistance.Text = d1 - d
                Else
                    txtdistance.Text = d - d1
                End If
            Case "Kasara to Mumbai CST"
                If cbsource.SelectedItem = "Kasara              " Then d = 0
                If cbsource.SelectedItem = "Khardi              " Then d = 13
                If cbsource.SelectedItem = "Algaon              " Then d = 25
                If cbsource.SelectedItem = "AsanGaon            " Then d = 34
                If cbsource.SelectedItem = "Vasind              " Then d = 40
                If cbsource.SelectedItem = "Khadavli            " Then d = 48
                If cbsource.SelectedItem = "Titwala             " Then d = 55
                If cbsource.SelectedItem = "Ambivli             " Then d = 61
                If cbsource.SelectedItem = "Shahad              " Then d = 63
                If cbsource.SelectedItem = "Kalyan              " Then d = 66
                If cbsource.SelectedItem = "Thakurti            " Then d = 70
                If cbsource.SelectedItem = "Dombivli            " Then d = 72
                If cbsource.SelectedItem = "Kopar               " Then d = 74
                If cbsource.SelectedItem = "Diva                " Then d = 78
                If cbsource.SelectedItem = "Mumbra              " Then d = 81
                If cbsource.SelectedItem = "Kalva               " Then d = 85
                If cbsource.SelectedItem = "Thane               " Then d = 88
                If cbsource.SelectedItem = "Mulund              " Then d = 91
                If cbsource.SelectedItem = "Nahur               " Then d = 94
                If cbsource.SelectedItem = "Bhandup             " Then d = 96
                If cbsource.SelectedItem = "Kanjur Marg         " Then d = 98
                If cbsource.SelectedItem = "Vikhroli            " Then d = 100
                If cbsource.SelectedItem = "Ghatkopar           " Then d = 103
                If cbsource.SelectedItem = "Vidyavihar          " Then d = 105
                If cbsource.SelectedItem = "Kurla               " Then d = 107
                If cbsource.SelectedItem = "Sion                " Then d = 110
                If cbsource.SelectedItem = "Matunga             " Then d = 113
                If cbsource.SelectedItem = "Dadar               " Then d = 114
                If cbsource.SelectedItem = "Parel               " Then d = 115
                If cbsource.SelectedItem = "Currey Road         " Then d = 117
                If cbsource.SelectedItem = "Chinchpokli         " Then d = 118
                If cbsource.SelectedItem = "Byculla             " Then d = 120
                If cbsource.SelectedItem = "Sandhust Road       " Then d = 121
                If cbsource.SelectedItem = "Masjid              " Then d = 122
                If cbsource.SelectedItem = "Mumbai CST          " Then d = 123



                If cbdestination.SelectedItem = "Kasara              " Then d1 = 0
                If cbdestination.SelectedItem = "Khardi              " Then d1 = 13
                If cbdestination.SelectedItem = "Algaon              " Then d1 = 25
                If cbdestination.SelectedItem = "AsanGaon            " Then d1 = 34
                If cbdestination.SelectedItem = "Vasind              " Then d1 = 40
                If cbdestination.SelectedItem = "Khadavli            " Then d1 = 48
                If cbdestination.SelectedItem = "Titwala             " Then d1 = 55
                If cbdestination.SelectedItem = "Ambivli             " Then d1 = 61
                If cbdestination.SelectedItem = "Shahad              " Then d1 = 63
                If cbdestination.SelectedItem = "Kalyan              " Then d1 = 66
                If cbdestination.SelectedItem = "Thakurti            " Then d1 = 70
                If cbdestination.SelectedItem = "Dombivli            " Then d1 = 72
                If cbdestination.SelectedItem = "Kopar               " Then d1 = 74
                If cbdestination.SelectedItem = "Diva                " Then d1 = 78
                If cbdestination.SelectedItem = "Mumbra              " Then d1 = 81
                If cbdestination.SelectedItem = "Kalva               " Then d1 = 85
                If cbdestination.SelectedItem = "Thane               " Then d1 = 88
                If cbdestination.SelectedItem = "Mulund              " Then d1 = 91
                If cbdestination.SelectedItem = "Nahur               " Then d1 = 94
                If cbdestination.SelectedItem = "Bhandup             " Then d1 = 96
                If cbdestination.SelectedItem = "Kanjur Marg         " Then d1 = 98
                If cbdestination.SelectedItem = "Vikhroli            " Then d1 = 100
                If cbdestination.SelectedItem = "Ghatkopar           " Then d1 = 103
                If cbdestination.SelectedItem = "Vidyavihar          " Then d1 = 105
                If cbdestination.SelectedItem = "Kurla               " Then d1 = 107
                If cbdestination.SelectedItem = "Sion                " Then d1 = 110
                If cbdestination.SelectedItem = "Matunga             " Then d1 = 113
                If cbdestination.SelectedItem = "Dadar               " Then d1 = 114
                If cbdestination.SelectedItem = "Parel               " Then d1 = 115
                If cbdestination.SelectedItem = "Currey Road         " Then d1 = 117
                If cbdestination.SelectedItem = "Chinchpokli         " Then d1 = 118
                If cbdestination.SelectedItem = "Byculla             " Then d1 = 120
                If cbdestination.SelectedItem = "Sandhust Road       " Then d1 = 121
                If cbdestination.SelectedItem = "Masjid              " Then d1 = 122
                If cbdestination.SelectedItem = "Mumbai CST          " Then d1 = 123

                If d1 > d Then
                    txtdistance.Text = d1 - d
                Else
                    txtdistance.Text = d - d1
                End If
        End Select
        txtdistance.Refresh()
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        ss = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        If txtPassnum.Text > ds.Tables("Pass").Rows.Count Then
            MsgBox("Please Enter Valid Ticket Number For Printing", MsgBoxStyle.Information)
            Exit Sub
        End If
        passno = txtPassnum.Text
        Dim f As New frmPass_Viewer
        f.Show()
        Me.Hide()
    End Sub

    Private Sub txtPassnum_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassnum.Leave
        If txtPassnum.Text = "" Then
            ep.SetError(txtPassnum, "Please Enter Ticket Number First")
            txtPassnum.Focus()
        End If
    End Sub

    Private Sub txtPassnum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassnum.LostFocus
        If txtPassnum.Text = "" Then
            Exit Sub
        End If
        ss = "select * from Pass"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Pass")
        ctr = ds.Tables(0).Rows.Count - 1
        If ctr = -1 Then
            txtPassnum.Text = 1
            Exit Sub
        End If
        For i = 0 To ctr
            If txtPassnum.Text = ds.Tables("Pass").Rows(i).Item(0) Then
                Exit Sub
            End If
        Next

        For i = 0 To ctr
            txtPassnum.Text = ds.Tables("Pass").Rows(i).Item(0)
            txtPassnum.Text = Val(txtPassnum.Text) + 1
        Next
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtdate.Text = Format(Now, "dd - MM - yyyy")
        txttime.Text = Format(Now, "hh : mm  : ss")
    End Sub
End Class