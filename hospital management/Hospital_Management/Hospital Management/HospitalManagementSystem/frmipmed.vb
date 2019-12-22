Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmipmed
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ID, bllinc As Integer
    Dim txt1, txt As String
    Dim dt As New DataTable
    Dim ds As DataSet
    Dim dv As DataView
    Dim dr As DataRow
    Dim tot As Integer
    Private Sub frmipmed_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Call MFGVALUES()
        cmd.Connection = con
        cmd.CommandText = "SELECT BILLNO FROM BILL"
        rd = cmd.ExecuteReader
        txtbill.Text = 1
        While rd.Read
            txtbill.Text = Val(rd(0)) + 1
        End While
        rd.Close()
    End Sub
    Private Sub frmipmed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' connection()
        ' con = New SqlConnection(constr)

        con.Open()
    End Sub

    Private Sub cboCrdt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCrdt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            dtpIssu.Focus()
        End If
    End Sub

    Private Sub cboPCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.DropDown

        cboPCode.Items.Clear()
        'On Error Resume Next
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
            cboMedID.Focus()
        End If
    End Sub


    Private Sub cboPCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.LostFocus
     
    End Sub

    Private Sub cboMedID_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMedID.DropDown
        'On Error Resume Next
        cmd.Connection = con
        cmd.CommandText = "SELECT MEDID,MEDICINENAME from MEDICINE"
        rd = cmd.ExecuteReader
        While rd.Read
            cboMedID.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboMedID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMedID.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cboMedType.Focus()
        End If
    End Sub

    Private Sub cboMedID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMedID.LostFocus
        
    End Sub

    Private Sub cmdADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'On Error Resume Next
        cmd.Connection = con

        If cboPCode.Text <> "" And cboMedID.Text <> "" Then
            cmd.CommandText = "insert into IPMEDICINE values('" & cboPCode.Text & "','" & txtPName.Text & "','" & txtmedname.Text & "','" & cboMedType.Text & "','" & dtpIssu.Value & "','" & txtqty.Text & "','" & txtrpu.Text & "','" & txtamt.Text & "','" & txtdis.Text & "','" & txttotamt.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record saved!!!")
            Call Clear_medicine_details()

        Else
            MsgBox("Please select Patient code and Medicine ID")
        End If



        Dim i As Integer
        'Dim r As Integer
        Dim j As Integer
        'Dim str As String
        'r = DGV.CurrentRow.Index

        'str = DGV.Item(i, r).Value
        'If DGV.RowCount > 2 Then
        '    'If dt.Rows.Count > 2 Then
        '    For i = 1 To DGV.RowCount - 3 Step 1
        '        If DGV.Item(i, 1).Value = txtmedname.Text Then
        '            MsgBox("Medicine Already Exist In The List Cannot Add Same Medicine Again.....", vbCritical + vbOKOnly)
        '            Exit Sub
        '        End If
        '    Next i
        'End If
        ID = ID + Val(txttotamt.Text) + Val(txtgrndtot.Text)
        'DGV.RowCount = DGV.RowCount + 1
        'j = DGV.RowCount
        'i = DGV.RowCount - 2
        'dr = dt.NewRow
        'dr(0) = txtmedname.Text
        'dr(1) = cboMedType.Text
        'dr(2) = dtpIssu.Value
        'dr(3) = txtqty.Text
        'dr(4) = txtrpu.Text
        'dr(5) = txtdis.Text
        'dr(6) = txttotamt.Text
        ''dr(7) = rd(9)
        ''tot = tot + Val(rd(9))
        'dt.Rows.Add(dr)
        'DGV.DataSource = dt
        txtgrndtot.Text = ID

    End Sub

    Private Sub cmdBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBill.Click
        'On Error Resume Next
        cmd.Connection = con
        If cboPCode.Text <> "" Then
            cmd.CommandText = "insert into Bill values('" & txtbill.Text & "','" & txtbill.Text & "','" & dtpBilldt.Value & "','" & cboPCode.Text & "','" & cboCrdt.Text & "','" & txtgrndtot.Text & "','" & txtdisgvn.Text & "','" & txtpayable.Text & "')"

            cmd.ExecuteNonQuery()
        Else
            MsgBox("Please select Patient Code")
        End If

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtdis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdis.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cmdADD.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtdis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdis.LostFocus
        If txtdis.Text = "" Then
            txtdis.Text = 0
        End If
        txttotamt.Text = Val(txtamt.Text) - Val(txtdis.Text)
    End Sub

    Private Sub txtdisgvn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdisgvn.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtdisgvn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdisgvn.LostFocus
        If txtdisgvn.Text = "" Then
            txtdisgvn.Text = 0
        End If
        txtpayable.Text = Val(txtgrndtot.Text) - Val(txtdisgvn.Text)
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    txtrpu.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtqty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.LostFocus

        If txtqty.Text = "" Then
            txtqty.Text = 0
        End If
    End Sub

    Private Sub txtrpu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrpu.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    txtdis.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
        End If


        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtrpu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrpu.LostFocus
        If txtrpu.Text = "" Then
            txtrpu.Text = 0
        End If
        txtamt.Text = Val(txtqty.Text) * Val(txtrpu.Text)
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

    Private Sub cboPCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPCode.SelectedIndexChanged
        'On Error Resume Next



        txt = cboPCode.Text
        cmd.Connection = con
        cmd.CommandText = "SELECT PNAME,DOA,DOCEXAMINED,TREATMENTDATE from INPATIENTS where pcode='" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read
            txtPName.Text = rd(0)
            txtAddDate.Text = rd(1)
            txtDName.Text = rd(2)
            txtTDate.Text = rd(3)
        End While
        rd.Close()

        



        cboPCode.Text = txt
        cmd.Connection = con
        cmd.CommandText = "SELECT GRANDTOTAL from BILL where PCODE = '" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        txtgrndtot.Text = 0
        While rd.Read
            txtgrndtot.Text = rd(0)
        End While
        rd.Close()
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

    Private Sub txtmedname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmedname.KeyPress
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

    Private Sub txtbill_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbill.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
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
    End Sub

    Private Sub txttotamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotamt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
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
    End Sub

    Private Sub txtgrndtot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrndtot.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtdisgvn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdisgvn.TextChanged

    End Sub

    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged

    End Sub

    Private Sub dtpIssu_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpIssu.ValueChanged

    End Sub

    Private Sub cboMedID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedID.SelectedIndexChanged
        'On Error Resume Next
        cmd.Connection = con
        cmd.CommandText = "SELECT MEDICINENAME from MEDICINE where medid='" & cboMedID.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read
            txtmedname.Text = rd(0)
        End While
        rd.Close()
        'ID = Val(cboMedID.Text)
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        cmd.Connection = con
        cboPCode.Items.Clear()
        ds = New DataSet
        ad = New SqlDataAdapter("SELECT [MEDICINE NAME]= MEDICINENAME from IPMEDICINE", con)
        ad.Fill(ds, "IPMEDICINE")
        Dim dt As New DataTable
        dt.Columns.Add("MEDICINE NAME")
        dt.Columns.Add("MEDICINE TYPE")
        dt.Columns.Add("DATE OF ISSUE")
        dt.Columns.Add("QUANTITY")
        dt.Columns.Add("RATE PER UNIT")
        dt.Columns.Add("AMOUNT")
        dt.Columns.Add("DISCOUNT")
        dt.Columns.Add("TOTAL AMOUNT")

        cmd.Connection = con
        cmd.CommandText = "SELECT * from IPMEDICINE where pcode ='" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        While (rd.Read)
            dr = dt.NewRow
            dr(0) = rd(2)
            dr(1) = rd(3)
            dr(2) = rd(4)
            dr(3) = rd(5)
            dr(4) = rd(6)
            dr(5) = rd(7)
            dr(6) = rd(8)
            dr(7) = rd(9)
            tot = tot + Val(rd(9))
            dt.Rows.Add(dr)
        End While
        rd.Close()
        DGV.DataSource = dt
    End Sub

    Private Sub txtrpu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrpu.TextChanged

    End Sub

    Private Sub txtgrndtot_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgrndtot.RightToLeftChanged

    End Sub

    Private Sub txtgrndtot_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgrndtot.TabIndexChanged

    End Sub

    Private Sub txtgrndtot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgrndtot.TextChanged

    End Sub

    Private Sub txttotamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotamt.TextChanged

    End Sub

    Private Sub txtpayable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpayable.TextChanged

    End Sub

    Public Sub Clear_medicine_details()
        cboMedID.Text = ""
        txtmedname.Text = ""
        cboMedType.Text = ""
        txtqty.Text = ""
        txtrpu.Text = ""
        txtamt.Text = ""
        txtdis.Text = ""
        txttotamt.Text = ""
        dtpIssu.Text = ""


    End Sub

    Private Sub txtdis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdis.TextChanged

    End Sub
End Class
