Public Class frmCentral_Ticket
    Private Sub frmpasscentralup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()
        MsgBox("WELCOME TO CENTRAL RAILWAY")
        cbdestination.Enabled = False
        cbroutes.Enabled = False
        cbclass.Items.Add("FIRST")
        cbclass.Items.Add("SECOND")
        txtchild.Text = 0
        temp.Text = "NO"
        ss = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            txtticketnum.Text = ds.Tables("Ticket").Rows(i).Item(0)
        Next
        txtticketnum.Text = Val(txtticketnum.Text) + 1
        Timer1.Enabled = True
    End Sub
    Sub clear()
        txtadult.Text = ""
        txtchild.Text = 0
        txtdistance.Text = ""
        txtduration.Text = ""
        cbclass.Text = ""
        chkreturn.Checked = False
        txtadultprice.Text = ""
        txtchildprice.Text = ""
        txttotalprice.Text = ""
        cbsource.Text = ""
        cbdestination.Text = ""
        cbsource_destination.Text = ""
        cbsource.Enabled = False
        cbdestination.Enabled = False
        cbroutes.Enabled = False
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
    Private Sub cbsource_destination_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsource_destination.Click
        cbsource.Items.Clear()
        cbdestination.Items.Clear()
        cbroutes.Items.Clear()
        cbsource_destination.Items.Clear()
        cbsource_destination.Items.Add("Khapoli to Mumbai CST")
        cbsource_destination.Items.Add("Kasara to Mumbai CST")
        txtadult.Text = ""
        txtchild.Text = 0
        txtdistance.Text = ""
        txtduration.Text = ""
        cbclass.Text = ""
        chkreturn.Checked = False
        txtadultprice.Text = ""
        txtchildprice.Text = ""
        txttotalprice.Text = ""
        cbsource.Text = ""
        cbdestination.Text = ""
        cbroutes.Text = ""
        cbsource.Enabled = True
        cbdestination.Enabled = False
        cbroutes.Enabled = False
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
        txtadult.Text = ""
        txtchild.Text = 0
        txtdistance.Text = ""
        txtduration.Text = ""
        cbclass.Text = ""
        chkreturn.Checked = False
        txtadultprice.Text = ""
        txtchildprice.Text = ""
        txttotalprice.Text = ""
        cbdestination.Text = ""
        cbroutes.Text = ""
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

    Private Sub cmdticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdticket.Click
        Dim cc As Control
        For Each cc In Me.Controls
            Dim ans As String
            ans = Convert.ToString(c.GetType)
            ans = "Systems.Windows.Forms.textbox"
            If cbsource.Text = "" Or cbdestination.Text = "" Or txtdate.Text = "" Or txttime.Text = "" Or txtdistance.Text = "" Or txtduration.Text = "" Or txtadult.Text = "" Or txtchild.Text = "" Or cbclass.Text = "" Or temp.Text = "" Or txtadultprice.Text = "" Or txtchildprice.Text = "" Or txttotalprice.Text = "" Then
                MsgBox("Please Fill all the Records in the TextBox Properly", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        If chkreturn.Checked = True Then
            temp.Text = "YES"
        Else
            temp.Text = "NO"
        End If
        ss = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            If txtticketnum.Text = ds.Tables("Ticket").Rows(i).Item(0) Then
                MsgBox("This Ticket Number is not Valid", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next
        Site_Ticket = "CENTRAL"
        sss = "insert into Ticket Values('" + txtticketnum.Text + "','" + cbsource.Text + "','" + cbdestination.Text + "','" + txtdate.Text + "','" + txttime.Text + "','" + txtdistance.Text + "','" + txtduration.Text + "','" + txtadult.Text + "','" + txtchild.Text + "','" + cbclass.Text + "','" + temp.Text + "','" + txtadultprice.Text + "','" + txtchildprice.Text + "','" + txttotalprice.Text + "','" + Site_Ticket + "')"
        cm = New SqlClient.SqlCommand(sss, cn)
        cm.ExecuteNonQuery()
        MsgBox("Ticket is inserted")
        clear()
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        clear()
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        ss = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        n = txtticketnum.Text
        For i = 0 To ctr
            If n = ds.Tables("Ticket").Rows(i).Item(0) Then
                cbsource.Text = ds.Tables("Ticket").Rows(i).Item(1)
                cbdestination.Text = ds.Tables("Ticket").Rows(i).Item(2)
                txtdate.Text = ds.Tables("Ticket").Rows(i).Item(3)
                txttime.Text = ds.Tables("Ticket").Rows(i).Item(4)
                txtdistance.Text = ds.Tables("Ticket").Rows(i).Item(5)
                txtduration.Text = ds.Tables("Ticket").Rows(i).Item(6)
                txtadult.Text = ds.Tables("Ticket").Rows(i).Item(7)
                txtchild.Text = ds.Tables("Ticket").Rows(i).Item(8)
                cbclass.Text = ds.Tables("Ticket").Rows(i).Item(9)
                temp.Text = ds.Tables("Ticket").Rows(i).Item(10)
                txtadultprice.Text = ds.Tables("Ticket").Rows(i).Item(11)
                txtchildprice.Text = ds.Tables("Ticket").Rows(i).Item(12)
                txttotalprice.Text = ds.Tables("Ticket").Rows(i).Item(13)
                MsgBox("Searching is Completed")
                Exit Sub
            End If
        Next
        MsgBox("Sorry! No Result Found...", MsgBoxStyle.Exclamation)

    End Sub
    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        End
    End Sub
    Private Sub cbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
        If txtadult.Text = "" Then
            MsgBox("Please Enter the Quantity of Adult")
            Exit Sub
        End If
        If txtchild.Text = "" Then
            MsgBox("Please Enter the Quantity of Child")
            Exit Sub
        End If
        If txtdistance.Text = "" Then
            MsgBox("Please select the source and destination currectly")
            Exit Sub
        End If
        n = cbclass.Text
        Select Case n


            Case "FIRST"
                If (txtdistance.Text >= 1 And txtdistance.Text <= 10) Then
                    txtadultprice.Text = 41
                    txtchildprice.Text = 41
                End If
                If (txtdistance.Text >= 11 And txtdistance.Text <= 15) Then
                    txtadultprice.Text = 52
                    txtchildprice.Text = 43
                End If
                If (txtdistance.Text >= 16 And txtdistance.Text <= 25) Then
                    txtadultprice.Text = 78
                    txtchildprice.Text = 50
                End If
                If (txtdistance.Text >= 26 And txtdistance.Text <= 35) Then
                    txtadultprice.Text = 104
                    txtchildprice.Text = 63
                End If
                If (txtdistance.Text >= 36 And txtdistance.Text <= 45) Then
                    txtadultprice.Text = 110
                    txtchildprice.Text = 66
                End If
                If (txtdistance.Text >= 46 And txtdistance.Text <= 50) Then
                    txtadultprice.Text = 119
                    txtchildprice.Text = 71
                End If
                If (txtdistance.Text >= 51 And txtdistance.Text <= 55) Then
                    txtadultprice.Text = 122
                    txtchildprice.Text = 72
                End If
                If (txtdistance.Text >= 56 And txtdistance.Text <= 65) Then
                    txtadultprice.Text = 126
                    txtchildprice.Text = 74
                End If
                If (txtdistance.Text >= 66 And txtdistance.Text <= 70) Then
                    txtadultprice.Text = 136
                    txtchildprice.Text = 79
                End If
                If (txtdistance.Text >= 71 And txtdistance.Text <= 75) Then
                    txtadultprice.Text = 145
                    txtchildprice.Text = 84
                End If
                If (txtdistance.Text >= 76 And txtdistance.Text <= 80) Then
                    txtadultprice.Text = 153
                    txtchildprice.Text = 88
                End If
                If (txtdistance.Text >= 81 And txtdistance.Text <= 85) Then
                    txtadultprice.Text = 155
                    txtchildprice.Text = 89
                End If
                If (txtdistance.Text >= 86 And txtdistance.Text <= 95) Then
                    txtadultprice.Text = 166
                    txtchildprice.Text = 94
                End If
                If (txtdistance.Text >= 96 And txtdistance.Text <= 100) Then
                    txtadultprice.Text = 168
                    txtchildprice.Text = 95
                End If
                If (txtdistance.Text >= 101 And txtdistance.Text <= 105) Then
                    txtadultprice.Text = 176
                    txtchildprice.Text = 99
                End If
                If (txtdistance.Text >= 106 And txtdistance.Text <= 115) Then
                    txtadultprice.Text = 180
                    txtchildprice.Text = 100
                End If
                If (txtdistance.Text >= 116 And txtdistance.Text <= 125) Then
                    txtadultprice.Text = 186
                    txtchildprice.Text = 104
                End If
                If (txtdistance.Text >= 126 And txtdistance.Text <= 130) Then
                    txtadultprice.Text = 190
                    txtchildprice.Text = 110
                End If
            Case "SECOND"
                If (txtdistance.Text >= 1 And txtdistance.Text <= 15) Then
                    txtadultprice.Text = 4
                    txtchildprice.Text = 4
                End If
                If (txtdistance.Text >= 16 And txtdistance.Text <= 30) Then
                    txtadultprice.Text = 6
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 31 And txtdistance.Text <= 35) Then
                    txtadultprice.Text = 7
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 36 And txtdistance.Text <= 40) Then
                    txtadultprice.Text = 8
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 41 And txtdistance.Text <= 45) Then
                    txtadultprice.Text = 9
                    txtchildprice.Text = 6
                End If
                If (txtdistance.Text >= 46 And txtdistance.Text <= 50) Then
                    txtadultprice.Text = 10
                    txtchildprice.Text = 6
                End If
                If (txtdistance.Text >= 51 And txtdistance.Text <= 55) Then
                    txtadultprice.Text = 11
                    txtchildprice.Text = 7
                End If
                If (txtdistance.Text >= 56 And txtdistance.Text <= 65) Then
                    txtadultprice.Text = 12
                    txtchildprice.Text = 7
                End If
                If (txtdistance.Text >= 66 And txtdistance.Text <= 70) Then
                    txtadultprice.Text = 13
                    txtchildprice.Text = 8
                End If
                If (txtdistance.Text >= 71 And txtdistance.Text <= 75) Then
                    txtadultprice.Text = 14
                    txtchildprice.Text = 8
                End If
                If (txtdistance.Text >= 76 And txtdistance.Text <= 80) Then
                    txtadultprice.Text = 15
                    txtchildprice.Text = 9
                End If
                If (txtdistance.Text >= 81 And txtdistance.Text <= 85) Then
                    txtadultprice.Text = 16
                    txtchildprice.Text = 9
                End If
                If (txtdistance.Text >= 86 And txtdistance.Text <= 95) Then
                    txtadultprice.Text = 17
                    txtchildprice.Text = 10
                End If
                If (txtdistance.Text >= 96 And txtdistance.Text <= 100) Then
                    txtadultprice.Text = 18
                    txtchildprice.Text = 10
                End If
                If (txtdistance.Text >= 101 And txtdistance.Text <= 110) Then
                    txtadultprice.Text = 19
                    txtchildprice.Text = 11
                End If
                If (txtdistance.Text >= 111 And txtdistance.Text <= 115) Then
                    txtadultprice.Text = 20
                    txtchildprice.Text = 11
                End If
                If (txtdistance.Text >= 116 And txtdistance.Text <= 125) Then
                    txtadultprice.Text = 21
                    txtchildprice.Text = 12
                End If
                If (txtdistance.Text >= 126 And txtdistance.Text <= 135) Then
                    txtadultprice.Text = 22
                    txtchildprice.Text = 12
                End If
        End Select
        If txtadult.Text = "" And txtchild.Text = "" Then
            Exit Sub
        End If
        txttotalprice.Text = Val(txtadultprice.Text) * Val(txtadult.Text) + Val(txtchildprice.Text) * Val(txtchild.Text)
        If chkreturn.Checked = True Then
            txttotalprice.Text = Val(txttotalprice.Text) * 2
        End If
        txtadultprice.Refresh()
        txtchildprice.Refresh()
        txttotalprice.Refresh()
    End Sub

    Private Sub txtchild_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtchild.Click
        txtchild.Text = ""
    End Sub

    Private Sub txtchild_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchild.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtticketnum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtticketnum.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub

    Private Sub txtticketnum_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtticketnum.Leave
        If txtticketnum.Text = "" Then
            ep.SetError(txtticketnum, "Please Enter Ticket Number First")
            txtticketnum.Focus()
        End If
    End Sub
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Me.Hide()
    End Sub
    Private Sub txtdistance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdistance.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtduration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtduration.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtadult_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadult.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txttotalprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub chkreturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkreturn.Click
        If chkreturn.Checked = True Then
            txttotalprice.Text = Val(txttotalprice.Text) * 2
        Else
            txttotalprice.Text = Val(txttotalprice.Text) / 2
        End If
    End Sub
    Private Sub txtadultprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadultprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtchildprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchildprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub

    Private Sub cbsource_destination_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsource_destination.SelectedIndexChanged

    End Sub

    Private Sub cbsource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsource.SelectedIndexChanged

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        ss = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        If txtticketnum.Text > ds.Tables("Ticket").Rows.Count Then
            MsgBox("Please Enter Valid Ticket Number For Printing", MsgBoxStyle.Information)
            Exit Sub
        End If
        ticketno = txtticketnum.Text
        Dim f As New frmTicket_Viewer
        f.Show()
        Me.Hide()
    End Sub

    Private Sub txtticketnum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtticketnum.LostFocus

        If txtticketnum.Text = "" Then
            Exit Sub
        End If
        ss = "select * from Ticket"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Ticket")
        ctr = ds.Tables(0).Rows.Count - 1
        If ctr = -1 Then
            txtticketnum.Text = 1
            Exit Sub
        End If
        For i = 0 To ctr
            If txtticketnum.Text = ds.Tables("Ticket").Rows(i).Item(0) Then
                Exit Sub
            End If
        Next
        For i = 0 To ctr
            txtticketnum.Text = ds.Tables("Ticket").Rows(i).Item(0)
            txtticketnum.Text = Val(txtticketnum.Text) + 1
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtdate.Text = Format(Now, "dd - MM - yyyy")
        txttime.Text = Format(Now, "hh : mm  : ss")
    End Sub
End Class