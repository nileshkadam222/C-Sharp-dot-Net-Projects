''Imports System
''Imports System.IO
''Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmopmeds
    Dim c As New connection
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim ds As DataSet
    Dim dv As DataView
    Dim ID, bllinc As Integer
    Dim txt1, txt As String
    Dim counti = 0
    Dim countj = 0
    Dim countk = 0
    Dim countl = 0
    Dim countm = 0
    Dim countn = 0
    Dim counto = 0

    Private Sub frmopmeds_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Call MFGVALUES()
        cmd.Connection = con
        cmd.CommandText = "SELECT BILLNO from OPBILL"
        rd = cmd.ExecuteReader
        txtbill.Text = 1
        While rd.Read
            txtbill.Text = rd(0) + 1
        End While
        'MFG.TextMatrix(i, 10) = txtGivenFree.Text
        'MFG.TextMatrix(i, 11) = MedStockId
    End Sub
    Private Sub frmopmeds_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection()
        'con = New SqlConnection(constr)
        'con.Open()
    End Sub

    Private Sub cboPCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.DropDown
        ID = 0
        cmd.Connection = con
        cmd.CommandText = "SELECT PCODE FROM OPDET"
        rd = cmd.ExecuteReader
        While rd.Read
            cboPCode.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboPCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPCode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            dtpIssu.Focus()
        End If
    End Sub

    Private Sub cboPCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.LostFocus
        'On Error Resume Next
        txt = cboPCode.Text
        cmd.Connection = con
        cmd.CommandText = "SELECT PNAME,DOCNAME,TRETMNTDT from OPdet where pcode='" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read
            txtPName.Text = rd(0)
            txtDName.Text = rd(1)
            txtTDate.Text = rd(2)
        End While
        rd.Read()

        ds = New DataSet
        ad = New SqlDataAdapter("SELECT * from OPMEDICINE", con)
        ad.Fill(ds, "OPMEDICINE")
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("MEDICINE NAME")
        dt.Columns.Add("MEDICINE TYPE")
        dt.Columns.Add("DATE OF ISSUE")
        dt.Columns.Add("QUANTITY")
        dt.Columns.Add("RATE PER UNIT")
        dt.Columns.Add("AMOUNT")
        dt.Columns.Add("DISCOUNT")
        dt.Columns.Add("TOTAL AMOUNT")

        cmd.Connection = con
        cmd.CommandText = "SELECT * from OPMEDICINE where pcode ='" & cboPCode.Text & "'"
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
            dt.Rows.Add(dr)
        End While
        MFG.DataSource = dt
        rd.Close()
        cboPCode.Items.Clear()
        cboPCode.Text = txt
        cmd.Connection = con
        cmd.CommandText = "SELECT GRANDTOTAL from OPBILL where PCODE = '" & cboPCode.Text & "'"
        rd = cmd.ExecuteReader
        txtgrndtot.Text = 0
        While rd.Read
            txtgrndtot.Text = rd(0)
        End While
    End Sub

    Private Sub cboMedID_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMedID.DropDown
        cmd.Connection = con
        cmd.CommandText = "SELECT MEDID,MEDICINENAME from MEDICINE"
        rd = cmd.ExecuteReader
        While rd.Read
            cboMedID.Items.Add(rd(0))
        End While
    End Sub

    Private Sub cboMedID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMedID.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cbomedtype.Focus()
        End If
    End Sub

    Private Sub cboMedID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMedID.LostFocus
        cmd.Connection = con
        cmd.CommandText = "SELECT MEDICINENAME from MEDICINE where medid='" & cboMedID.Text & "'"
        rd = cmd.ExecuteReader
        txtmedname.Text = rd(0)
        rd.Close()
        'ID = Val(cboMedID.Text)
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        c.conn.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into OPMEDICINE values('" & cboPCode.Text & "','" & txtPName.Text & "','" & txtmedname.Text & "','" & cbomedtype.Text & "','" & dtpIssu.Value & "','" & txtQty.Text & "','" & txtrpu.Text & "','" & txtamt.Text & "','" & txtdisgvn.Text & "','" & txtTotAmt.Text & "')"
        cmd.ExecuteNonQuery()
        'If MFG.RowCount > 2 Then
        '    For i = 1 To MFG.RowCount - 2 Step 1
        '        If MFG.(i, 1) = txtmedname.Text Then
        '            MsgBox("Medicine Already Exist In The List Cannot Add Same Medicine Again.....", vbCritical + vbOKOnly)
        '            Exit Sub
        '        End If
        '    Next i
        'End If
        ID = ID + Val(txtTotAmt.Text) + Val(txtgrndtot.Text)
        'MFG.Rows = MFG.Rows + 1
        'j = MFG.Rows
        'i = MFG.Rows - 2

        'MFG.TextMatrix(i, 0) = i
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("MEDICINE NAME")
        dt.Columns.Add("MEDICINE TYPE")
        dt.Columns.Add("DATE OF ISSUE")
        dt.Columns.Add("QUANTITY")
        dt.Columns.Add("RATE PER UNIT")
        dt.Columns.Add("AMOUNT")
        dt.Columns.Add("DISCOUNT")
        dt.Columns.Add("TOTAL AMOUNT")
        dr = dt.NewRow
        dr(0) = txtmedname.Text
        dr(1) = cbomedtype.Text
        dr(2) = dtpIssu.Value
        dr(3) = txtQty.Text
        dr(4) = txtrpu.Text
        dr(5) = txtamt.Text
        dr(6) = txtdis.Text
        dr(7) = txtTotAmt.Text
        dt.Rows.Add(dr)
        MFG.DataSource = dt
        'MFG.TextMatrix(i, 1) = txtmedname.Text
        'MFG.TextMatrix(i, 2) = cmbmedtype.Text
        'MFG.TextMatrix(i, 3) = dtissu.Value
        'MFG.TextMatrix(i, 4) = txtQty.Text
        'MFG.TextMatrix(i, 5) = txtrpu.Text
        'MFG.TextMatrix(i, 6) = txtamt.Text
        'MFG.TextMatrix(i, 7) = txtdis.Text
        'MFG.TextMatrix(i, 8) = txtTotAmt.Text
        'MFG.TextMatrix(i, 9) = txtTotalPrice.Text
        'MFG.TextMatrix(i, 10) = txtGivenFree.Text
        'MFG.TextMatrix(i, 11) = MedStockId
        ''Set rs = con.Execute("Select ExpDate from MedicineStock where MedicineStockId=" & MedStockId)
        ''MFG.TextMatrix(i, 12) = Format(rs(0), "dd-MMM-yyyy")
        ''Call Txt_Clear
        ''Call Calc_TotAmt
        ''cmbMedicine.SetFocus
        'medrs.Close()
        txtgrndtot.Text = ID
    End Sub

    Private Sub cmdBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBill.Click
        cmd.Connection = con
        cmd.CommandText = "insert into OPBill values('" & txtbill.Text & "','" & txtbill.Text & "','" & dtpbilldt.Value & "','" & cboPCode.Text & "','" & cboCrdt.Text & "','" & txtgrndtot.Text & "','" & txtdisgvn.Text & "','" & txtpayable.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Command6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub txtdis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdis.KeyPress
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

    Private Sub txtdis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdis.LostFocus
        If txtdis.Text = "" Then
            txtdis.Text = 0
        End If
        txtTotAmt.Text = Val(txtamt.Text) - Val(txtdis.Text)
    End Sub

    Private Sub txtdisgvn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdisgvn.LostFocus
        If txtdisgvn.Text = "" Then
            txtdisgvn.Text = 0
        End If
        txtpayable.Text = Val(txtgrndtot.Text) - Val(txtdisgvn.Text)
    End Sub
    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtrpu.Focus()
        End If
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        If txtQty.Text = "" Then
            txtQty.Text = 0
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

    Private Sub txtrpu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrpu.LostFocus
        If txtrpu.Text = "" Then
            txtrpu.Text = 0
        End If
        txtamt.Text = Val(txtQty.Text) * Val(txtrpu.Text)
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

    End Sub

    Private Sub Command4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command4.Click

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
        If countj = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countj = 1
            End If
        End If

    End Sub

    Private Sub txtTotAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotAmt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
               Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        'Dim counti = 0
        If countl = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countl = 1
            End If
        End If

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
        If countm = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countm = 1
            End If
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
        If countn = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countn = 1
            End If
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
        If counto = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                counto = 1
            End If
        End If

    End Sub

    Private Sub cboPCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPCode.SelectedIndexChanged

    End Sub

    Private Sub cboPCode_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPCode.SizeChanged

    End Sub
End Class