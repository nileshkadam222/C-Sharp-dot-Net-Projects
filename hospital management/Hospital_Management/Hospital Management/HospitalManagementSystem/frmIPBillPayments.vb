Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmIPBillPayments
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim RowNo As Integer
    Dim dt As New DataTable
    Dim ds As DataSet
    Dim dv As DataView
    Dim counti = 0
    Dim countj = 0
    Dim countk = 0
    Dim countl = 0
    Dim countm = 0
    Dim countn = 0
    Dim counto = 0
    Dim countp = 0
    Dim countq = 0
    Private Sub frmIPBillPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If con.State Then con.Close()
        ' connection()
        ' con = New SqlConnection(constr)
        con.Open()

        Call Refresh_Data()
        Call Pcode()

        cmd.CommandText = "SELECT PCODE from INPATIENTS"
        rd = cmd.ExecuteReader

        While rd.Read
            cboCustName.Items.Add(rd(0))
        End While
        rd.Close()



        dtpDDDate.Value = Now
        dtpPayDate.Value = Now
        'txtDDNo.Locked = True
        'cmbBank.Locked = True
        dtpDDDate.Enabled = False
    End Sub
    Private Sub Pcode()
        cboCustName.Items.Clear()
        cmd.Connection = con
        cmd.CommandText = "Select PName,pcode from INPATIENTS where pcode in (Select Distinct pcode from Bill where Billstatus='UnPaid')"
        rd = cmd.ExecuteReader

        cboCustName.Items.Clear()
        While rd.Read
            cboCustName.Items.Add(rd(1))
        End While
        rd.Close()
    End Sub
    Private Sub Refresh_Data()


        ds = New DataSet
        ad = New SqlDataAdapter("Select * from INPATIENTS", con)
        ad.Fill(ds, "INPATIENTS")
        Dim dt As New DataTable

        dt.Columns.Add("AMOUNT PAID")
        dt.Columns.Add("PAID DATE")
        dt.Columns.Add("PAY TYPE")
        dt.Columns.Add("DD/CHEQUE NO")
        dt.Columns.Add("DD DATE")
        dt.Columns.Add("BANK")

    End Sub
    Private Sub cboCustName_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCustName.DropDown

        
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String
        Dim BillPayId As Double
        If txtPayingAmt.Text = "" Then
            MsgBox("Paying Amount Not Found...", vbCritical + vbOKOnly)
            txtPayingAmt.Focus()
            Exit Sub
        End If

        cmd.Connection = con
        cmd.CommandText = "Select BillPaymentId from BillPayments" ' where billstatus=Un-Paid"
        'rd.Close()
        rd = cmd.ExecuteReader
        BillPayId = 1
        While rd.Read
            BillPayId = rd(0) + 1
        End While
        rd.Close()
        If optCash.Checked = True Then
            str = "CASH"
        ElseIf optDD.Checked = True Then
            str = "DD"
        ElseIf optCheque.Checked = True Then
            str = "Cheque"
        Else
            str = "Others"
        End If
        If MsgBox("Confirm To Save Bill Information ?", vbQuestion + vbYesNo) = vbYes Then
            'con.BeginTrans()
            If optCash.Checked = True Then
                cmd.Connection = con
                cmd.CommandText = "Insert into BillPayments values('" & cboCustName.Text & "','" & BillPayId & "','" & cboBillNo.Text & "','" & Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text)) & "','" & dtpPayDate.Value.Date & "','" & str & "',Null,Null,Null)"
                'rd.Close()
                cmd.ExecuteNonQuery()
                cmd.Connection = con
                cmd.CommandText = "Update INPATIENTS Set Billstatus=" & Val(txtBillStatus.Text) & " where pcode ='" & cboCustName.Text & "'"
                cmd.ExecuteNonQuery()
                Dim dt1 As New DataTable
                Dim dr As DataRow
                dt1.Columns.Add("Paying Amount")
                dt1.Columns.Add("Payment DATE")
                dt1.Columns.Add("Payment Mode")
                dr = dt1.NewRow
                dr(0) = Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text))
                dr(1) = Format(dtpPayDate.Value, "dd-MMM-yyyy")
                dr(2) = str
                'dr(3) = rd("DDNo")
                'dr(3) = rd("DDDate")
                'dr(3) = rd("Bank")
                dt1.Rows.Add(dr)
                DGV1.DataSource = dt1
                Txt_Clear()
                'MFG.TextMatrix(RowNo, 0) = RowNo
                'MFG.TextMatrix(RowNo, 1) = Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text))
                'MFG.TextMatrix(RowNo, 2) = Format(dtpPayDate.Value, "dd-MMM-yyyy")
                'MFG.TextMatrix(RowNo, 3) = str
                'RowNo = RowNo + 1
                'MFG.Rows = MFG.Rows + 1
            Else
                If txtDDNo.Text = "" Or cboBank.Text = "" Then
                    MsgBox("DD Number or Bank Name Not Found...", vbCritical + vbOKOnly)
                    txtDDNo.Focus()
                    Exit Sub
                End If
                cmd.Connection = con
                cmd.CommandText = "Insert into BillPayments values('" & cboCustName.Text & "'," & BillPayId & "," & cboBillNo.Text & "," & Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text)) & ",'" & Format(dtpPayDate.Value, "mm/dd/yy") & "','" & str & "','" & txtDDNo.Text & "','" & Format(dtpDDDate.Value, "mm/dd/yy") & "','" & cboBank.Text & "','" & txtBillStatus.Text & "')"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Update INPATIENTS Set Billstatus=" & Val(txtBillStatus.Text) & " where pcode ='" & cboCustName.Text & "'"
                cmd.ExecuteNonQuery()
                Dim dr As DataRow
                dr = dt.NewRow
                dr(0) = Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text))
                dr(1) = Format(dtpPayDate.Value, "dd-MMM-yyyy")
                dr(2) = str
                dr(3) = txtDDNo.Text
                dr(3) = Format(dtpDDDate.Value, "dd-MMM-yyyy")
                dr(3) = cboBank.Text
                dt.Rows.Add(dr)
                DGV1.DataSource = dt
                Txt_Clear()
                'MFG.TextMatrix(RowNo, 0) = RowNo
                'MFG.TextMatrix(RowNo, 1) = Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text))
                'MFG.TextMatrix(RowNo, 2) = Format(dtpPayDate.Value, "dd-MMM-yyyy")
                'MFG.TextMatrix(RowNo, 3) = str
                'MFG.TextMatrix(RowNo, 4) = txtDDNo.Text
                'MFG.TextMatrix(RowNo, 5) = Format(dtpDDDate.Value, "dd-MMM-yyyy")
                'MFG.TextMatrix(RowNo, 6) = cmbBank.Text
                'RowNo = RowNo + 1
                'MFG.Rows = MFG.Rows + 1
            End If
            cmd.Connection = con
            cmd.CommandText = "Update CustomerAdvance Set CustomerAmt=" & Val(txtBalAdv.Text) & " where pcode ='" & cboCustName.Text & "'"
            cmd.ExecuteNonQuery()
            Call Txt_Clear()
            txtPayingAmt.Focus()
            Call Pcode()
        End If

    End Sub
    Private Sub Txt_Clear()
        'Dim i As Integer
        Dim s As Double
        s = 0
        txtPayingAmt.Text = ""
        txtBalAmt.Text = ""
        txtBalAdv.Text = ""
        txtBillStatus.Text = ""
        txtDDNo.Text = ""
        cmd.Connection = con
        cmd.CommandText = "Select CustomerAmt from CustomerAdvance where pcode ='" & cboCustName.Text & "'"
        rd = cmd.ExecuteReader
        If rd.Read = False Then
            rd.Close()
            txtCustomerAdv.Text = "0"
        Else
            txtCustomerAdv.Text = rd(0)
            rd.Close()
        End If
        'For i = 1 To DGV1.RowCount - 2 Step 1
        '    s = s + DGV1.SelectedRows("i")
        'Next i
        txtPaidAmt.Text = s
        txtBalAmt.Text = Math.Round(Val(txtBillAmt.Text) - Val(txtPaidAmt.Text), 2)
        txtBal.Text = Math.Round(Val(txtBillAmt.Text) - Val(txtPaidAmt.Text), 2)
    End Sub

    Private Sub optCash_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCash.Click
        If optCash.Checked = True Then
            txtDDNo.Text = ""
            txtDDNo.Enabled = False
            cboBank.Enabled = False
            dtpDDDate.Enabled = False
        Else
            txtDDNo.Enabled = False
            cboBank.Enabled = False
            dtpDDDate.Enabled = True
        End If
    End Sub

    Private Sub optCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCash.CheckedChanged

    End Sub

    Private Sub optCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCheque.CheckedChanged
        If optCheque.Checked = True Then
            txtDDNo.Enabled = False
            cboBank.Enabled = False
            dtpDDDate.Enabled = True
        Else
            txtDDNo.Text = ""
            txtDDNo.Enabled = True
            cboBank.Enabled = True
            dtpDDDate.Enabled = False
        End If
    End Sub

    Private Sub optDD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDD.CheckedChanged
        If optDD.Checked = True Then
            txtDDNo.Enabled = False
            cboBank.Enabled = False
            dtpDDDate.Enabled = True
        Else
            txtDDNo.Text = ""
            txtDDNo.Enabled = True
            cboBank.Enabled = True
            dtpDDDate.Enabled = False
        End If
    End Sub

    Private Sub optOthers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOthers.CheckedChanged
        If optOthers.Checked = True Then
            txtDDNo.Enabled = False
            cboBank.Enabled = False
            dtpDDDate.Enabled = True
        Else
            txtDDNo.Text = ""
            txtDDNo.Enabled = True
            cboBank.Enabled = True
            dtpDDDate.Enabled = False
        End If
    End Sub

    Private Sub txtDDNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDDNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                      Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        Dim str As String
        str = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-/abcdefghijklmnopqrstuvwxyz"
        If e.KeyChar = ChrW(Keys.Enter) And txtPayingAmt.Text <> "" Then

        End If
        If InStr(str, Chr(AscW(e.KeyChar))) = 0 And AscW(e.KeyChar) <> 8 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtPayingAmt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayingAmt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                      Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim countn = 0

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
        
        End If
        'Dim str As String5
        'str = "0123456789."
        'If e.KeyChar = ChrW(Keys.Enter) And txtPayingAmt.Text <> "" Then
        '    cmdSave.Focus()
        'End If
        'If InStr(str, Chr(AscW(e.KeyChar))) = 0 And AscW(e.KeyChar) = 8 Then
        '    e.KeyChar = ChrW(0)
        'End If
    End Sub

    Private Sub txtPayingAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPayingAmt.LostFocus
        If txtPayingAmt.Text <> "" Then
            If Val(txtPayingAmt.Text) = 0 Then
                MsgBox("Paying Amount Cannot Be Zero...", vbInformation + vbOKOnly)
                txtPayingAmt.Focus()
                Exit Sub
            End If
            If Val(txtPayingAmt.Text) > Val(txtBal.Text) Then
                MsgBox("Paying Amount Cannot Be Greater Than Balance Amount...", vbCritical + vbOKOnly)
                txtPayingAmt.Text = ""
                txtPayingAmt.Focus()
                Exit Sub
            End If
            txtBalAmt.Text = Math.Round((Val(txtBal.Text) - Val(txtPayingAmt.Text)), 2)
            If Val(txtCustomerAdv.Text) <> 0 Then
                If Val(txtCustomerAdv.Text) > Val(txtBalAmt.Text) Then
                    'txtCustomerAdv.Text = Val(txtCustomerAdv.Text) - Val(txtBalAmt.Text)
                    txtBalAdv.Text = Val(txtCustomerAdv.Text) - Val(txtBalAmt.Text)
                    txtBalAmt.Text = "0"
                Else
                    txtBalAmt.Text = Math.Round(Val(txtBalAmt.Text) - Val(txtCustomerAdv.Text), 2)
                    txtCustomerAdv.Text = "0"
                    txtBalAdv.Text = "0"
                End If
            Else
                txtBalAdv.Text = "0"
            End If
            If Val(txtBalAmt.Text) = 0 Then
                txtBillStatus.Text = "Paid"
            Else
                txtBillStatus.Text = "UnPaid"
            End If
        End If
    End Sub

    Private Sub cboCustName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustName.SelectedIndexChanged


        Dim i As Integer
        i = 0
        If cboCustName.Text = "" Then
            Exit Sub
        End If
        cboBillNo.Items.Clear()
        cmd.Connection = con
        cmd.CommandText = "Select BillNo,BillId from Bill where pcode ='" & cboCustName.Text & "'"
        rd = cmd.ExecuteReader
        'If rd.Read = False Then
        '    rd.Close()
        'Else
        While rd.Read()
            cboBillNo.Items.Add(rd(0))
            'cboBillNo.SelectedItem(i) = rd(1)
            i = i + 1
        End While
        rd.Close()
        'End If
    End Sub

    Private Sub cboCustName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCustName.SelectedValueChanged
        'Dim i As Integer
        'i = 0
        'If cboCustName.Text = "" Then
        '    Exit Sub
        'End If
        'cboBillNo.Items.Clear()
        'cmd.Connection = con
        'cmd.CommandText = "Select BillNo,BillId from Bill where pcode ='" & cboCustName.Text & "'"
        'rd = cmd.ExecuteReader
        ''If rd.Read = False Then
        ''    rd.Close()
        ''Else
        'While rd.Read()
        '    cboBillNo.Items.Add(rd(0))
        '    'cboBillNo.SelectedItem(i) = rd(1)
        '    i = i + 1
        'End While
        'rd.Close()
        ''End If
    End Sub

    Private Sub cboBillNo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBillNo.SelectedValueChanged
        'Dim rs1 As New ADODB.Recordset
        'Dim i As Integer
        Dim s As Double
        If cboBillNo.Text = "" Then
            Exit Sub
        End If

        cmd.Connection = con
        cmd.CommandText = "Select * from Bill where BillId='" & cboBillNo.Text & "'"
        'cmd.CommandText = "Select * from Bill where BillId='" & cboBillNo..text & "'"
        rd = cmd.ExecuteReader
        While rd.Read()
            txtBillDate.Text = Format(rd("BillDate")) ', "dd-MMM-yyyy")
            txtBillTerms.Text = rd("CreditYN")
            txtBillAmt.Text = rd("GrandTotal")
            txtDiscount.Text = rd("Discount")
            txtNetValue.Text = rd("NetValue")
        End While
        rd.Close()
        cmd.Connection = con
        cmd.CommandText = "Select count(*) from BillDetails where BillId='" & cboBillNo.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read()
            txtBillItems.Text = rd(0)
        End While
        rd.Close()

        cmd.Connection = con
        cmd.CommandText = "Select * from BillPayments where BillId='" & cboBillNo.Text & "'"
        rd = cmd.ExecuteReader
        'rd.Close()
        If rd.Read = False Then
            rd.Close()
            txtPaidAmt.Text = "0"
            txtBal.Text = txtBillAmt.Text
        Else
            'Dim cmd As New SqlCommand
            Dim dr As DataRow
            cmd.Connection = con
            cmd.CommandText = "Select * from INPATIENTS where DOA='" & dtpPayDate.Value.Date & "'"
            rd.Close()
            rd = cmd.ExecuteReader
            Dim dt1 As New DataTable
            dt1.Columns.Add("Amount Paid")
            dt1.Columns.Add("Paid Date")
            dt1.Columns.Add("Pay Type")
            dt1.Columns.Add("DD No")
            dt1.Columns.Add("DD Date")
            dt1.Columns.Add("Bank")
            'dt1.Columns.Add("Pay Type")
            'dt1.Columns.Add("DD No")
            While (rd.Read)
                dr = dt1.NewRow
                dr(0) = rd("AmountPaid")
                dr(1) = rd("PaidDate")
                dr(2) = rd("PayType")
                If Trim(rd("DDNo")) = "" Then
                    dr(3) = rd("DDNo")
                End If
                If Trim(rd("DDDate")) = "" Then
                    dr(3) = rd("DDDate")
                End If
                If Trim(rd("Bank")) = "" Then
                    dr(3) = rd("Bank")
                End If
                s = s + Val(rd("AmountPaid"))
                dt.Rows.Add(dr)
            End While
            rd.Close()
            DGV1.DataSource = dt

            txtPaidAmt.Text = s
            txtBal.Text = Math.Round(Val(txtBillAmt.Text) - Val(txtPaidAmt.Text), 2)
        End If
        'RowNo = MFG.Rows - 1
        cmd.Connection = con
        cmd.CommandText = "Select CustomerAmt from CustomerAdvance where pcode ='" & cboCustName.Text & "'"
        rd = cmd.ExecuteReader
        txtCustomerAdv.Text = "0"
        While rd.Read
            txtCustomerAdv.Text = rd(0)
        End While
        rd.Close()
        txtPayingAmt.Focus()
    End Sub

    Private Sub cboBillNo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBillNo.SelectionChangeCommitted
  
    End Sub

    Private Sub txtBillAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillAmt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                      Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counti = 0
        If counti = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                counti = 1
            End If
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim countj = 0
        If countj = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countj = 1
            End If
        End If
    End Sub

    Private Sub txtNetValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNetValue.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim countk = 0

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
            
        End If
    End Sub

    Private Sub txtCustomerAdv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerAdv.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counto = 0

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
           
        End If
    End Sub

    Private Sub txtBalAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalAmt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counti = 0

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
            
        End If
    End Sub

    Private Sub txtBalAdv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalAdv.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counti = 0

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
           
        End If
    End Sub

    Private Sub txtPaidAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaidAmt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                      Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim countl = 0

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
            
        End If
    End Sub

    Private Sub txtBal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBal.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim countm = 0

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
        
        End If
    End Sub

    Private Sub txtBalAdv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBalAdv.TextChanged

    End Sub

    Private Sub txtBillItems_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillItems.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtBillTerms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillTerms.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtBillStatus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillStatus.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
                    Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
                    And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
                    Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

 
    Private Sub txtPaidAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaidAmt.TextChanged

    End Sub

    Private Sub cboBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBillNo.SelectedIndexChanged

    End Sub

    Private Sub DGV1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub txtNetValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNetValue.TextChanged

    End Sub

    Private Sub txtPayingAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayingAmt.TextChanged

    End Sub
End Class