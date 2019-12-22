Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmOPBillPayments
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim rd1 As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim ds As DataSet
    Dim dv As DataView
    Dim RowNo As Integer
    Dim tot As Integer
    Private Sub frmOPBillPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' connection()
        ' con = New SqlConnection(constr)
        con.Open()
        Call Refresh_Data()
        dtpDDDate.Value = Now.Date
        dtpPayDate.Value = Now.Date

        'txtDDNo.Locked = True
        'cmbBank.Locked = True
        dtpDDDate.Enabled = False
    End Sub
    Private Sub cboPCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.DropDown
        cmd.Connection = con
        cmd.CommandText = "SELECT PCODE from OPDET"
        If rd.IsClosed = False Then
            rd.Close()
        End If
        rd = cmd.ExecuteReader
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
        cmd.CommandText = "Select Max(BillPaymentId) from OPBillPayments"
        rd = cmd.ExecuteReader
        BillPayId = 0
        While rd.Read
            BillPayId = rd(0) + 1
        End While
        rd.Close()
        If optCASH.Checked = True Then
            str = "CASH"
        ElseIf optDD.Checked = True Then
            str = "DD"
        ElseIf optCHEQUE.Checked = True Then
            str = "Cheque"
        Else
            str = "Others"
        End If
        If MsgBox("Confirm To Save Bill Information ?", vbQuestion + vbYesNo) = vbYes Then
            If optCASH.Checked = True Then
                cmd.Connection = con
                cmd.CommandText = "Insert into OPBillPayments values('" & cboPCode.Text & "','" & BillPayId & "','" & cboBillNo.Text & "','" & Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text)) & "','" & Format(dtpPayDate.Value.Date) & "','" & str & "',Null,Null,Null)"
                cmd.ExecuteNonQuery()

                ds = New DataSet
                ad = New SqlDataAdapter("SELECT * from OPBillPayments", con)
                'ad.Fill(ds, "OPBillPayments")
                'Dim dt As New DataTable
                'Dim dr As DataRow
                'dt.Columns.Add("Amount Paid")
                'dt.Columns.Add("Paid Date")
                'dt.Columns.Add("DD No")
                'dt.Columns.Add("DD Date")
                'dt.Columns.Add("Bank")

                'MFG.TextMatrix(RowNo, 0) = RowNo
                'MFG.TextMatrix(RowNo, 1) = Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text))
                'MFG.TextMatrix(RowNo, 2) = Format(dtpPayDate.Value, "dd-MMM-yyyy")
                'MFG.TextMatrix(RowNo, 3) = str
                'RowNo = RowNo + 1
                'MFG.Rows = MFG.Rows + 1
            Else
                If txtDDNo.Text = "" Or cmbBank.Text = "" Then
                    MsgBox("DD Number or Bank Name Not Found...", vbCritical + vbOKOnly)
                    txtDDNo.Focus()
                    Exit Sub
                End If
                cmd.Connection = con
                cmd.CommandText = "Insert into OPBillPayments values('" & cboPCode.Text & "','" & BillPayId & "','" & cboBillNo.SelectedValue(cboBillNo.SelectedIndex) & "','" & Val(txtPayingAmt.Text) + (Val(txtCustomerAdv.Text) - Val(txtBalAdv.Text)) & "','" & Format(dtpPayDate.Value, "mm/dd/yy") & "','" & str & "','" & txtDDNo.Text & "','" & Format(dtpDDDate.Value, "mm/dd/yy") & "','" & cmbBank.Text & "')"
                cmd.ExecuteNonQuery()
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
            cmd.CommandText = "Update OPCustomerAdvance Set CustomerAmt=" & Val(txtBalAdv.Text) & " where pcode ='" & cboPCode.Text & "'"
            cmd.ExecuteNonQuery()
            Call Txt_Clear()
            txtPayingAmt.Focus()
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
        cmd.CommandText = "Select CustomerAmt from OPCustomerAdvance where pcode ='" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader()
        txtCustomerAdv.Text = "0"
        While rd.Read
            txtCustomerAdv.Text = rd(0)
        End While
        rd.Close()
        'For i = 1 To MFG.Rows - 2 Step 1
        '    s = s + MFG.TextMatrix(i, 1)
        'Next i
        txtPaidAmt.Text = s
        txtBalAmt.Text = Math.Round(Val(txtBillAmt.Text) - Val(txtPaidAmt.Text), 2)
        txtBal.Text = Math.Round(Val(txtBillAmt.Text) - Val(txtPaidAmt.Text), 2)
    End Sub

    Private Sub Refresh_Data()
        Dim i As Integer
        i = 0
        cboPCode.Items.Clear()
        cmd.Connection = con
        cmd.CommandText = "Select PName,PCODE from OPDET where pcode in (Select Distinct pcode from OPBill)"
        rd = cmd.ExecuteReader()
        While rd.Read
            cboPCode.Items.Add(rd(1))
            'cboPCode.SelectedValue(i) = rd(1)
            i = i + 1
        End While
        rd.Close()
        'MFG.Clear()
        'MFG.ColWidth(0) = 1000
        'MFG.ColAlignment(0) = 4
        'For i = 1 To 6 Step 1
        '    MFG.ColWidth(i) = 2000
        '    MFG.ColAlignment(i) = 4
        'Next i
        'MFG.TextMatrix(0, 0) = "SL NO"
        'MFG.TextMatrix(0, 1) = "AMOUNT PAID"
        'MFG.TextMatrix(0, 2) = "PAID DATE"
        'MFG.TextMatrix(0, 3) = "PAY TYPE"
        'MFG.TextMatrix(0, 4) = "DD/CHEQUE NO"
        'MFG.TextMatrix(0, 5) = "DD DATE"
        'MFG.TextMatrix(0, 6) = "BANK"
    End Sub

    Private Sub optCASH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCASH.CheckedChanged

    End Sub

    Private Sub optCASH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCASH.Click
        If optCASH.Checked = True Then
            txtDDNo.Text = ""
            txtDDNo.ReadOnly = True
            cmbBank.Enabled = True
            dtpDDDate.Enabled = False
        Else
            txtDDNo.ReadOnly = False
            cmbBank.Enabled = False
            dtpDDDate.Enabled = True
        End If
    End Sub

    Private Sub optCHEQUE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCHEQUE.Click
        If optCHEQUE.Checked = True Then
            txtDDNo.ReadOnly = False
            cmbBank.Enabled = False
            dtpDDDate.Enabled = True
        Else
            txtDDNo.Text = ""
            txtDDNo.ReadOnly = True
            cmbBank.Enabled = True
            dtpDDDate.Enabled = False
        End If
    End Sub

    Private Sub optDD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optDD.Click
        If optDD.Checked = True Then
            txtDDNo.ReadOnly = False
            cmbBank.Enabled = False
            dtpDDDate.Enabled = True
        Else
            txtDDNo.Text = ""
            txtDDNo.ReadOnly = True
            cmbBank.Enabled = True
            dtpDDDate.Enabled = False
        End If
    End Sub
    Private Sub optOTHERS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optOTHERS.Click
        If optOTHERS.Checked = True Then
            txtDDNo.ReadOnly = False
            cmbBank.Enabled = False
            dtpDDDate.Enabled = True
        Else
            txtDDNo.Text = ""
            txtDDNo.ReadOnly = True
            cmbBank.Enabled = True
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
        Dim str As String
        str = "0123456789."
        If e.KeyChar = ChrW(Keys.Enter) And txtPayingAmt.Text <> "" Then
            cmdSave.Focus()
        End If
        If InStr(str, Chr(AscW(e.KeyChar))) = 0 And AscW(e.KeyChar) <> 8 Then
            e.KeyChar = ChrW(0)
        End If
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
                txtBillStatus.Text = "Un-Paid"
            End If
        End If
    End Sub

    Private Sub cboPCode_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.SelectedValueChanged
        Dim i As Integer
        i = 0
        If cboPCode.Text = "" Then
            Exit Sub
        End If
        cboBillNo.Items.Clear()
        cmd.Connection = con
        cmd.CommandText = "Select BillNo,BillId from OPBill where pcode ='" & cboPCode.Text & "'"
        If rd.IsClosed = False Then
            rd.Close()
        End If
        rd = cmd.ExecuteReader
        While rd.Read()
            cboBillNo.Items.Add(rd(0))
            'cboBillNo.SelectedValue(i) = rd(1)
            i = i + 1
        End While
        rd.Close()
    End Sub

    Private Sub cboBillNo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBillNo.SelectedValueChanged
        Dim i As Integer
        Dim s As Double
        If cboBillNo.Text = "" Then
            Exit Sub
        End If
        cmd.Connection = con
        cmd.CommandText = "Select * from OPBill where BillId='" & cboBillNo.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read()
            txtBillDate.Text = Format(rd("BillDate"), "dd-MMM-yyyy")
            txtBillTerms.Text = rd("CreditYN")
            txtBillAmt.Text = rd("GrandTotal")
            txtDiscount.Text = rd("Discount")
            txtNetValue.Text = rd("NetValue")
            
        End While
        rd.Close()
        Dim cmd1 As New SqlCommand
        cmd1.Connection = con
        cmd1.CommandText = "Select * from OPBillPayments where BillId='" & cboBillNo.Text & "'"
        rd1 = cmd.ExecuteReader
        While rd1.Read
            txtBillItems.Text = rd1(0)
        End While
        rd1.Close()
        ds = New DataSet
        ad = New SqlDataAdapter("SELECT * from OPBillPayments", con)
        ad.Fill(ds, "OPBillPayments")
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("Amount Paid")
        dt.Columns.Add("Paid Date")
        dt.Columns.Add("DD No")
        dt.Columns.Add("DD Date")
        dt.Columns.Add("Bank")

        cmd.Connection = con
        cmd.CommandText = "Select * from OPBillPayments where BillId='" & cboBillNo.Text & "'"
        rd = cmd.ExecuteReader
        txtPaidAmt.Text = "0"
        txtBal.Text = txtBillAmt.Text
        i = 1
        s = 0
        While (rd.Read)
            dr = dt.NewRow
            dr(0) = rd("AmountPaid")
            dr(1) = rd("PaidDate")
            'If Trim(rd("DDNo")) <> "" Then
            dr(2) = rd("DDNo")
            'End If
            'If Trim(rd("DDDate")) = "" Then
            dr(3) = rd("DDDate")
            'End If
            'If Trim(rd("Bank")) = "" Then
            dr(4) = rd("Bank")
            'End If
            tot = tot + Val(rd("AmountPaid"))
            dt.Rows.Add(dr)
        End While
        rd.Close()
        MFG.DataSource = dt
        txtPaidAmt.Text = s
        txtBal.Text = Math.Round(Val(txtBillAmt.Text) - Val(txtPaidAmt.Text), 2)
        'RowNo = MFG.Rows - 1
        cmd.Connection = con
        cmd.CommandText = "Select CustomerAmt from OPCustomerAdvance where pcode ='" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        txtCustomerAdv.Text = "0"
        While rd.Read
            txtCustomerAdv.Text = rd(0)
        End While
        rd.Close()
        txtPayingAmt.Focus()
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

    Private Sub txtBillAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillAmt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
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

    Private Sub txtNetValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNetValue.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
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
    End Sub

    Private Sub txtBal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBal.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
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
    End Sub

    Private Sub txtBalAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalAmt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
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
    End Sub

    Private Sub cboPCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPCode.SelectedIndexChanged

    End Sub

    Private Sub cboBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBillNo.SelectedIndexChanged

    End Sub
End Class