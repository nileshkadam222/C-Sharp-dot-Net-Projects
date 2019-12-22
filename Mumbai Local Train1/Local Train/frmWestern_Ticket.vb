Public Class frmWestern_Ticket
    Private Sub frmpasswesternup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Call Connection()
        MsgBox("WELCOME TO WESTERN RAILWAY")
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
        If cbsource.SelectedItem = "ChurchGate          " Then d = 60

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
        If cbdestination.SelectedItem = "ChurchGate          " Then d1 = 60

        If d1 > d Then
            txtdistance.Text = d1 - d
        Else
            txtdistance.Text = d - d1
        End If
    End Sub

    Private Sub cbsource_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsource.Click
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
        clear()
        cbdestination.Enabled = True
    End Sub
    Private Sub cbroutes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbroutes.Click
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
        txtchild.Text = 0
        cbsource.Enabled = True
        cbdestination.Enabled = False
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
                If (txtdistance.Text >= 56 And txtdistance.Text <= 60) Then
                    txtadultprice.Text = 126
                    txtchildprice.Text = 72
                End If
                If (txtdistance.Text >= 61 And txtdistance.Text <= 65) Then
                    txtadultprice.Text = 136
                    txtchildprice.Text = 79
                End If
            Case "SECOND"
                If (txtdistance.Text >= 1 And txtdistance.Text <= 10) Then
                    txtadultprice.Text = 4
                    txtchildprice.Text = 4
                End If
                If (txtdistance.Text >= 11 And txtdistance.Text <= 15) Then
                    txtadultprice.Text = 6
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 16 And txtdistance.Text <= 20) Then
                    txtadultprice.Text = 7
                    txtchildprice.Text = 5
                End If
                If (txtdistance.Text >= 21 And txtdistance.Text <= 30) Then
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
                If (txtdistance.Text >= 51 And txtdistance.Text <= 55) Then
                    txtadultprice.Text = 13
                    txtchildprice.Text = 8
                End If
                If (txtdistance.Text >= 56 And txtdistance.Text <= 60) Then
                    txtadultprice.Text = 14
                    txtchildprice.Text = 8
                End If
                If (txtdistance.Text >= 61 And txtdistance.Text <= 65) Then
                    txtadultprice.Text = 15
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
            If txtticketnum.Text = "" Or cbsource.Text = "" Or cbdestination.Text = "" Or txtdate.Text = "" Or txttime.Text = "" Or txtdistance.Text = "" Or txtduration.Text = "" Or txtadult.Text = "" Or txtchild.Text = "" Or cbclass.Text = "" Or temp.Text = "" Or txtadultprice.Text = "" Or txtchildprice.Text = "" Or txttotalprice.Text = "" Then
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
        Site_Ticket = "WESTERN"
        sss = "insert into Ticket Values('" + txtticketnum.Text + "','" + cbsource.Text + "','" + cbdestination.Text + "','" + txtdate.Text + "','" + txttime.Text + "','" + txtdistance.Text + "','" + txtduration.Text + "','" + txtadult.Text + "','" + txtchild.Text + "','" + cbclass.Text + "','" + temp.Text + "','" + txtadultprice.Text + "','" + txtchildprice.Text + "','" + txttotalprice.Text + "','" + Site_Ticket + "' )"
        cm = New SqlClient.SqlCommand(sss, cn)
        cm.ExecuteNonQuery()
        MsgBox("Ticket is inserted")
        clear()
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        clear()
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        ss = "select * from Ticket where site='western'"
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
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Me.Hide()
    End Sub

    Private Sub txtchild_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtchild.GotFocus
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

    Private Sub txtadultprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadultprice.KeyPress
        e.KeyChar = onlynumber(e.KeyChar)
    End Sub
    Private Sub txtchildprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchildprice.KeyPress
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
        txtdate.Text = Format(Now, "dd - MM - yyyy")
        txttime.Text = Format(Now, "hh : mm  : ss")
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class