Public Class frmHarbour_Ticket
    Private Sub frmpassharbourup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()
        MsgBox("WELCOME TO HARBOUR LINE")
        cbclass.Items.Add("FIRST")
        cbclass.Items.Add("SECOND")
        cbdestination.Enabled = False
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
        clear()
        cbdestination.Enabled = True
        cbroutes.Enabled = False
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

    Private Sub cbclass_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
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
            Case "SECOND"
                If (txtdistance.Text >= 1 And txtdistance.Text <= 10) Then
                    txtadultprice.Text = 4
                    txtchildprice.Text = 4
                End If
                If (txtdistance.Text >= 11 And txtdistance.Text <= 20) Then
                    txtadultprice.Text = 6
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 20 And txtdistance.Text <= 25) Then
                    txtadultprice.Text = 7
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 26 And txtdistance.Text <= 30) Then
                    txtadultprice.Text = 8
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 31 And txtdistance.Text <= 35) Then
                    txtadultprice.Text = 9
                    txtchildprice.Text = 6
                End If
                If (txtdistance.Text >= 36 And txtdistance.Text <= 40) Then
                    txtadultprice.Text = 10
                    txtchildprice.Text = 6
                End If
                If (txtdistance.Text >= 41 And txtdistance.Text <= 45) Then
                    txtadultprice.Text = 11
                    txtchildprice.Text = 7
                End If
                If (txtdistance.Text >= 46 And txtdistance.Text <= 50) Then
                    txtadultprice.Text = 12
                    txtchildprice.Text = 7
                End If
                If (txtdistance.Text >= 51 And txtdistance.Text <= 60) Then
                    txtadultprice.Text = 14
                    txtchildprice.Text = 8
                End If
                If (txtdistance.Text >= 61 And txtdistance.Text <= 65) Then
                    txtadultprice.Text = 15
                    txtchildprice.Text = 9
                End If
                If (txtdistance.Text >= 66 And txtdistance.Text <= 70) Then
                    txtadultprice.Text = 16
                    txtchildprice.Text = 9
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


    Private Sub cmdticket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdticket.Click
        Dim cc As Control
        For Each cc In Me.Controls
            Dim ans As String
            ans = Convert.ToString(c.GetType)
            ans = "Systems.Windows.Forms.textbox"
            If cbsource.Text = "" Or cbdestination.Text = "" Or txtdate.Text = "" Or txttime.Text = "" Or txtdistance.Text = "" Or txtduration.Text = "" Or txtadult.Text = "" Or txtchild.Text = "" Or cbclass.Text = "" Or temp.Text = "" Or txtadultprice.Text = "" Or txttotalprice.Text = "" Then
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
        Site_Ticket = "HARBOUR"
        sss = "insert into Ticket Values('" + txtticketnum.Text + "','" + cbsource.Text + "','" + cbdestination.Text + "','" + txtdate.Text + "','" + txttime.Text + "','" + txtdistance.Text + "','" + txtduration.Text + "','" + txtadult.Text + "','" + txtchild.Text + "','" + cbclass.Text + "','" + temp.Text + "','" + txtadultprice.Text + "','" + txtchildprice.Text + "','" + txttotalprice.Text + "','" + Site_Ticket + "')"
        cm = New SqlClient.SqlCommand(sss, cn)
        cm.ExecuteNonQuery()
        MsgBox("Ticket is inserted")
        clear()
    End Sub
    Sub clear()
        txtadult.Text = ""
        txtchild.Text = 0
        txtdistance.Text = ""
        txtduration.Text = ""
        cbclass.Text = ""
        chkreturn.Checked = False
        cbdestination.Enabled = False
        txtadultprice.Text = ""
        txttotalprice.Text = ""
        cbsource.Text = ""
        cbdestination.Text = ""
        txtadultprice.Text = ""
        txtchildprice.Text = ""
    End Sub

    Private Sub txtchild_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtchild.GotFocus
        txtchild.Text = ""
    End Sub

    Private Sub txtchild_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchild.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
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
                cbdestination.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(2)
                txtdate.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(3)
                txttime.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(4)
                txtdistance.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(5)
                txtduration.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(6)
                txtadult.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(7)
                txtchild.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(8)
                cbclass.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(9)
                temp.Text = ds.Tables("Harbour_Ticket").Rows(i).Item(10)
                txtadultprice.Text = ds.Tables("Ticket").Rows(i).Item(11)
                txtchildprice.Text = ds.Tables("Ticket").Rows(i).Item(12)
                txttotalprice.Text = ds.Tables("Ticket").Rows(i).Item(13)
                MsgBox("Searching is Completed")
                Exit Sub
            End If
        Next
        MsgBox("Sorry! No Result Found...", MsgBoxStyle.Exclamation)
        clear()
    End Sub
    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        End
    End Sub
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Me.Hide()
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
    Private Sub txtticket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub

    Private Sub chkreturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkreturn.Click
        If chkreturn.Checked = True Then
            txttotalprice.Text = Val(txttotalprice.Text) * 2
        Else
            txttotalprice.Text = Val(txttotalprice.Text) / 2
        End If
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
    Private Sub txtchildprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchildprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub

    Private Sub txtadultprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadultprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
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
        txttime.Text = Format(Now, "hh : mm  : ss")
        txtdate.Text = Format(Now, "dd - MM - yyyy")
    End Sub
End Class