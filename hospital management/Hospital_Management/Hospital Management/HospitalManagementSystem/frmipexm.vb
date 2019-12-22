Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmipexm
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand
    Dim ID, bllinc As Double
    Dim txt1, txt As String
    Dim i As Integer
    Dim counti = 0
    Dim countj = 0
    Dim countk = 0
    Dim countl = 0
    Dim countm = 0
    Dim countn = 0

    Private Sub frmipexm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' connection()
        'con = New SqlConnection(constr)
        con.Open()
        'Call MFGVALUES
        cmd.Connection = con
        cmd.CommandText = "SELECT BILLNO from BILL"
        rd = cmd.ExecuteReader
        txtbill.Text = 1
        While (rd.Read)
            txtbill.Text = rd("BILLNO") + 1
        End While
        rd.Close()
        'MFG.TextMatrix(i, 10) = txtGivenFree.Text
        'MFG.TextMatrix(i, 11) = MedStockId
    End Sub
    Private Sub frmipexm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboPCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.DropDown

        cboPCode.Items.Clear()
        On Error Resume Next
        ID = 0
        cmd.Connection = con
        cmd.CommandText = "SELECT PCODE FROM INPATIENTS"
        rd = cmd.ExecuteReader
        While rd.Read
            cboPCode.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboPCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPCode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cboPCode.Focus()
        End If
    End Sub

    Private Sub cboPCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.LostFocus
     
    End Sub

    Private Sub cboTestCond_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTestCond.DropDown
        'On Error Resume Next
        cboTestCond.Items.Clear()
        cmd.Connection = con
        cmd.CommandText = "SELECT EXAMNAME from LABEXAMS"
        rd = cmd.ExecuteReader
        While rd.Read
            cboTestCond.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboTestCond_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTestCond.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            dtpTstDate.Focus()
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        'On Error Resume Next
        cmd.Connection = con
        If (cboPCode.Text <> "") Then
            cmd.CommandText = "insert into IPEXAMS (PCODE,NAME,EXAMTYPE,EXAMDATE,EXAMDETAILS,EXAMCOST,DISCOUNTGIVEN,TOTALAMOUNT)values('" & cboPCode.Text & "','" & txtPName.Text & "','" & cboTestCond.Text & "','" & dtpTstDate.Value & "','" & txtResult.Text & "','" & txtamt.Text & "','" & txtdis.Text & "','" & txttotamt.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Added Sucessfully")


            ID = ID + Val(txttotamt.Text) + Val(txtgrndtot.Text)
            txtgrndtot.Text = ID


        Else
            MsgBox("Please select Patient code")

        End If
       


    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        'On Error Resume Next
        If i = 1 Then
            MessageBox.Show("Bill Already Created ")
            Exit Sub
        End If
        cmd.Connection = con

        If (cboPCode.Text <> "") Then

            'cmd1.CommandText = "select * from bill where pcode='" & cboPCode.Text & "' "
            'rd = cmd1.ExecuteReader()
            'If (rd.HasRows) Then


            'End If


            cmd.CommandText = "insert into Bill (BillId,BillNo,BillDate,pcode,CreditYN,GrandTotal,Discount,NetValue)values('" & txtbill.Text & "','" & txtbill.Text & "','" & DTPBillDt.Value & "','" & cboPCode.Text & "','" & cboTerms.Text & "','" & txtgrndtot.Text & "','" & txtdisgvn.Text & "','" & txtpayable.Text & "')"
            cmd.ExecuteNonQuery()
            i = 1
            MessageBox.Show("Bill Created Sucessfully!!!")
        Else
            MsgBox("Please select patient code")
        End If

    End Sub

    Private Sub dtpTstDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTstDate.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtamt.Focus()
        End If
    End Sub

    Private Sub txtamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    txtdis.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counti = 0
        'If counti = 0 Then
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
            'counti = 1
        End If
        'End If
    End Sub

    Private Sub txtdis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdis.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    txtResult.Focus()
        'End If
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

    Private Sub txtdis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdis.LostFocus
        If txtdis.Text = "" Then
            txtdis.Text = 0
        End If
        txttotamt.Text = Val(txtamt.Text) - Val(txtdis.Text)
    End Sub

    Private Sub txtdisgvn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdisgvn.LostFocus
        If txtdisgvn.Text = "" Then
            txtdisgvn.Text = 0
        End If
        txtpayable.Text = Val(txtgrndtot.Text) - Val(txtdisgvn.Text)
    End Sub
    'Public Sub MFGVALUES()
    '    MFG.TextMatrix(0, 1) = "MEDICINE NAME"
    '    MFG.TextMatrix(0, 2) = "MEDICINE TYPE"
    '    MFG.TextMatrix(0, 3) = "DATE OF ISSUE"
    '    MFG.TextMatrix(0, 4) = "QUANTITY"
    '    MFG.TextMatrix(0, 5) = "RATE PER UNIT "
    '    MFG.TextMatrix(0, 6) = "AMOUNT"
    '    MFG.TextMatrix(0, 7) = "DISCOUNT"
    '    MFG.TextMatrix(0, 8) = "TOTAL AMOUNT"
    'End Sub


    Private Sub Command2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command2.Click
        Call clear()

    End Sub

    Private Sub Command4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command4.Click
        Me.Close()
    End Sub

    Private Sub txtbill_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbill.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txttotamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotamt.KeyPress
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
    Public Sub clear()
        txtAdDate.Text = ""
        txtamt.Text = ""
        'txtbill.Text = ""
        txtdis.Text = ""
        txtdisgvn.Text = ""
        txtDName.Text = ""
        txtgrndtot.Text = ""
        txtpayable.Text = ""
        txtPName.Text = ""
        txtResult.Text = ""
        txttotamt.Text = ""
        txtTreateDate.Text = ""
        cboPCode.Text = ""
        cboTerms.Text = ""
        cboTestCond.Text = ""
    End Sub

    Private Sub txtgrndtot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrndtot.KeyPress
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

 
    Private Sub txtdisgvn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdisgvn.KeyPress
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

    Private Sub txtpayable_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayable.KeyPress
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

    Private Sub txtPName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPName.KeyPress
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

    Private Sub txtDName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDName.KeyPress
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

    Private Sub txtResult_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResult.KeyPress
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

    Private Sub cboPCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPCode.SelectedIndexChanged

        On Error Resume Next

        txt = cboPCode.Text
        cmd.Connection = con
        cmd.CommandText = "SELECT PNAME,DOA,DOCEXAMINED,TREATMENTDATE from INPATIENTS where pcode='" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read()
            txtPName.Text = rd(0)
            txtAdDate.Text = rd(1)
            txtDName.Text = rd(2)
            txtTreateDate.Text = rd(3)
        End While
        rd.Close()

        cboPCode.Text = txt
        cmd.Connection = con
        cmd.CommandText = "SELECT GRANDTOTAL from BILL where PCODE = '" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        txtgrndtot.Text = 0
        While rd.Read()
            txtgrndtot.Text = rd(0)
        End While
        rd.Close()
        i = 0

    End Sub

    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged

    End Sub

    Private Sub txtdis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdis.TextChanged

    End Sub
End Class