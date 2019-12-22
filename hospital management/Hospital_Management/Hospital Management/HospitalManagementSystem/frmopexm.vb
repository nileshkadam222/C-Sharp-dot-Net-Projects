Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmOPExm
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ID, bllinc As Integer
    Dim txt1, txt As String
    Dim counti = 0
    Dim countj = 0
    Dim countk = 0
    Dim countl = 0
    Dim countm = 0
    Dim countn = 0

    Private Sub frmOPExm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ''Call MFGVALUES
        cmd.Connection = con
        cmd.CommandText = "SELECT BILLNO from OPBILL"
        rd = cmd.ExecuteReader
        txtbill.Text = 1
        While rd.Read
            txtbill.Text = rd(0) + 1
        End While
        rd.Close()
        'MFG.TextMatrix(i, 10) = txtGivenFree.Text
        'MFG.TextMatrix(i, 11) = MedStockId
    End Sub
    Private Sub frmOPExm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection()
        'con = New SqlConnection(constr)
        con.Open()
    End Sub

    Private Sub cboPCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.DropDown
        ID = 0
        cmd.Connection = con
        cmd.CommandText = "SELECT PCODE FROM OPDET"
        rd = cmd.ExecuteReader
        cboPCode.Items.Clear()
        While rd.Read
            cboPCode.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboPCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPCode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cboTerms.Focus()
        End If
    End Sub

    Private Sub cboPCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.LostFocus
     
    End Sub

    Private Sub cboPCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPCode.SelectedIndexChanged
        'On Error Resume Next
        txt = cboPCode.Text
        cmd.Connection = con
        cmd.CommandText = "SELECT PNAME,BDATE,DOCNAME,TRETMNTDT from OPdet where pcode='" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read()
            txtPName.Text = rd(0)
            txtAddDate.Text = rd(1)
            txtDName.Text = rd(2)
            txtTDate.Text = rd(3)
            'rd.Close()

            cboPCode.Text = txt
            cmd.Connection = con
        End While
        rd.Close()
        cmd.CommandText = "SELECT GRANDTOTAL from OPBILL where PCODE = '" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        txtGrndTot.Text = 0
        While rd.Read
            txtGrndTot.Text = rd(0)
        End While
        rd.Close()

    End Sub

    Private Sub cboTstCond_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTstCond.DropDown
        cmd.Connection = con
        cmd.CommandText = "SELECT EXAMNAME from LABEXAMS"
        rd = cmd.ExecuteReader
        While rd.Read
            cboTstCond.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        cmd.Connection = con
        If (cboPCode.Text <> "") Then
            cmd.CommandText = "insert into OPEXAMS (EXAMCODE,PCODE,PNAME,EXAMTYPE,EXAMDATE,EXAMDETAILS,EXAMCOST,DISCOUNTGIVEN,TOTALAMOUNT) values ('" & cboPCode.Text & "','" & cboPCode.Text & "','" & txtPName.Text & "','" & cboTstCond.Text & "','" & dtpExmDt.Value & "','" & txtTRes.Text & "','" & txtamt.Text & "','" & txtdis.Text & "','" & txttotamt.Text & "')"
            cmd.ExecuteNonQuery()
            ID = ID + Val(txttotamt.Text) + Val(txtGrndTot.Text)
            txtGrndTot.Text = ID
            MsgBox("Record is saved")
        Else
            MsgBox("Please select Patient Code")

        End If
        
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        cboTstCond.Items.Clear()
        dtpExmDt.Value = Now
        txtTRes.Text = ""
        txtamt.Text = 0
        txtdis.Text = 0
        txttotamt.Text = 0
    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        cmd.Connection = con
        If (cboPCode.Text <> "") Then
            cmd.CommandText = "insert into OPBill (billid,billno,BillDate,pcode,CreditYN,GrandTotal,Discount,NetValue) values ('" & txtbill.Text & "','" & txtbill.Text & "','" & dtpBilldt.Value & "','" & cboPCode.Text & "','" & cboTerms.Text & "','" & txtGrndTot.Text & "','" & txtDisgvn.Text & "','" & txtPayable.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Bill creaed Sucessfully!!!")
        Else
            MsgBox("Please select Patient Code")

        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtdis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdis.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cmdAdd.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
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

    Private Sub txtDisgvn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisgvn.LostFocus
        If txtDisgvn.Text = "" Then
            txtDisgvn.Text = 0
        End If
        txtPayable.Text = Val(txtGrndTot.Text) - Val(txtDisgvn.Text)
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

    Private Sub txtbill_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt.KeyPress
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

    Private Sub txttotamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotamt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counti = 0
        If countk = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countk = 1
            End If
        End If
    End Sub

    Private Sub txtGrndTot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrndTot.KeyPress
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

    Private Sub txtDisgvn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisgvn.KeyPress
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

    Private Sub txtPayable_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayable.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counti = 0
        If countn = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countn = 1
            End If
        End If
    End Sub

    Private Sub txtTRes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTRes.KeyPress
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

    Private Sub cboTstCond_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTstCond.SelectedIndexChanged

    End Sub

    Private Sub txtdis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdis.TextChanged

    End Sub

    Private Sub txtDisgvn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisgvn.TextChanged

    End Sub

    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged

    End Sub

    Private Sub txtGrndTot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrndTot.TextChanged

    End Sub
End Class