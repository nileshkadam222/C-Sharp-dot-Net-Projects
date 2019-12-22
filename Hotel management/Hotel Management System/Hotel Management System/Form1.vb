Imports System.Data.OleDb
Public Class Form1
    Dim Ind As Integer
    Dim Li As ListViewItem
    Dim flag As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnEdit.Enabled = False
        txtAddress.Enabled = False
        txtCardNo.Enabled = False
        txtCity.Enabled = False
        txtCountry.Enabled = False
        txtCustID.Enabled = False
        txtCustName.Enabled = False
        txtNationality.Enabled = False
        txtPassNo.Enabled = False
        txtState.Enabled = False
        cboDOB.Enabled = False
        cboGender.Enabled = False
        txtCustID.Text = "Cust-" & Format(AutoID("tblCustomer", "CusID"), "0000")
        If CusSearch <> "" Then
            Dim Dr1 As OleDbDataReader
            Com.CommandText = CusSearch
            Dr1 = Com.ExecuteReader
            If Dr1.Read = True Then
                AddDataToLvw(LstCustomer, Dr1(0), Dr1(1), Dr1(2), Dr1(3), Dr1(4), Dr1(5), Dr1(6), Dr1(7), Dr1(8), Dr1(9), Dr1(10))
            End If
            Dr1.Close()
            CusSearch = ""
        End If

        ' Store Data from FrmCheckIn
        If CName <> "" Then
            txtCustName.Text = CName
            cboGender.Text = CGender
            txtAddress.Text = CAddress
            txtPassNo.Text = CPNo
            txtCardNo.Text = CCNo
            CuID = txtCustID.Text
        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If CName <> "" Then
            Me.Close()
            CheckInMenu()
        Else
            Me.Close()
        End If
    End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    '    If txtCustID.Text = "" Then
    '        Message("Complete Customer ID.")
    '        txtCustID.Focus()
    '    ElseIf txtCustName.Text = "" Then
    '        Message("Complete Customer Name.")
    '        txtCustName.Focus()
    '    ElseIf cboGender.Text = "" Then
    '        Message("Choose one Gender.")
    '        cboGender.Focus()
    '    ElseIf txtAddress.Text = "" Then
    '        Message("Complete Address.")
    '        txtAddress.Focus()
    '    ElseIf txtCity.Text = "" Then
    '        Message("Complete City.")
    '        txtCity.Focus()
    '    ElseIf txtState.Text = "" Then
    '        Message("Complete State.")
    '        txtState.Focus()
    '    ElseIf txtCountry.Text = "" Then
    '        Message("Complete Country.")
    '        txtCountry.Focus()
    '    ElseIf txtNationality.Text = "" Then
    '        Message("Complete Nationality.")
    '        txtNationality.Focus()
    '    ElseIf txtCardNo.Text = "" Then
    '        Message("Complete Card No.")
    '        txtCardNo.Focus()
    '    Else
    '        Com.CommandText = "Insert into tblCustomer Values(?,?,?,?,?,?,?,?,?,?,?)"
    '        With Com.Parameters
    '            .Add("@CID", OleDbType.VarChar).Value = txtCustID.Text
    '            .Add("@CName", OleDbType.VarChar).Value = txtCustName.Text
    '            .Add("@Gender", OleDbType.VarChar).Value = cboGender.Text
    '            .Add("@DOB", OleDbType.VarChar).Value = cboDOB.Text
    '            .Add("@Address", OleDbType.VarChar).Value = txtAddress.Text
    '            .Add("@City", OleDbType.VarChar).Value = txtCity.Text
    '            .Add("@State", OleDbType.VarChar).Value = txtState.Text
    '            .Add("@Country", OleDbType.VarChar).Value = txtCountry.Text
    '            .Add("@Nationality", OleDbType.VarChar).Value = txtNationality.Text
    '            .Add("@PassNo", OleDbType.VarChar).Value = txtPassNo.Text
    '            .Add("@CardNo", OleDbType.VarChar).Value = txtCardNo.Text
    '        End With
    '        Com.ExecuteNonQuery()
    '        Com.Parameters.Clear()
    '        AddDataToLvw(LstCustomer, txtCustID.Text, txtCustName.Text, cboGender.Text, cboDOB.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtCountry.Text, txtNationality.Text, txtPassNo.Text, txtCardNo.Text)
    '        ClearAll(Me)
    '        cboGender.SelectedIndex = -1
    '        txtCustName.Focus()
    '        txtCustID.Text = "Cust-" & Format(AutoID("tblCustomer", "CusID"), "0000")
    '        Message("Sucess.")
    '    End If
    'End Sub
 

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstCustomer.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Dim Str As String
        Str = MessageBox.Show("Do you want to Delete this Record?", "Hotel Management System", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If Str = vbOK Then
            Com.CommandText = "Delete from tblCustomer where CusID=?"
            Com.Parameters.Add("@CID", OleDbType.VarChar).Value = Li.Text
            Com.ExecuteNonQuery()
            Com.Parameters.Clear()
            LstCustomer.Items.Remove(Li)
            Message("Sucess.")
        End If
    End Sub


    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim li As ListViewItem
        If btnShow.Text = "Show All" Then
            LstCustomer.Items.Clear()
            Com.CommandText = "Select * from tblCustomer"
            Dr = Com.ExecuteReader
            Do While Dr.Read = True
                li = LstCustomer.Items.Add(Dr(0), 0)
                With li.SubItems
                    .Add(1).Text = Dr(1)
                    .Add(2).Text = Dr(2)
                    .Add(3).Text = Dr(3)
                    '.Add(3).Text = Dr(3)
                    .Add(4).Text = Dr(4)
                    .Add(5).Text = Dr(5)
                    .Add(6).Text = Dr(6)
                    .Add(7).Text = Dr(7)
                    .Add(8).Text = Dr(8)
                    .Add(9).Text = Dr(9)
                    .Add(10).Text = Dr(10)
                    'MsgBox(IsDBNull(Dr(9)))
                End With
            Loop
            Dr.Close()
            btnShow.Text = "Unshow"
        Else
            LstCustomer.Items.Clear()
            btnShow.Text = "Show All"
        End If
        flag = 1
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If flag = 0 Then
            If txtCustName.Text = "" Then

                MsgBox("Please Enter The Complet Customer Information ")
            Else
                MsgBox("Please Enter The Complet Customer Information ")
            End If
        Else
            'btnSave.Enabled = True
            txtAddress.Enabled = True
            txtCardNo.Enabled = True
            txtCity.Enabled = True
            txtCountry.Enabled = True
            txtCustID.Enabled = True
            txtCustName.Enabled = True
            txtNationality.Enabled = True
            txtPassNo.Enabled = True
            txtState.Enabled = True
            cboDOB.Enabled = True
            cboGender.Enabled = True

            Dim Sl As ListView.SelectedListViewItemCollection = LstCustomer.SelectedItems
            If btnEdit.Text = "Edit" Then
                For Each Li In Sl
                    Exit For
                Next
                txtCustID.Text = Li.Text
                txtCustName.Text = Li.SubItems(1).Text
                cboGender.Text = Li.SubItems(2).Text
                cboDOB.Text = IIf((Li.SubItems(3).Text) = " ", cboDOB.Text, Li.SubItems(3).Text)
                txtAddress.Text = Li.SubItems(4).Text
                txtCity.Text = Li.SubItems(5).Text
                txtState.Text = Li.SubItems(6).Text
                txtCountry.Text = Li.SubItems(7).Text
                txtNationality.Text = Li.SubItems(8).Text
                txtPassNo.Text = Li.SubItems(9).Text
                txtCardNo.Text = Li.SubItems(10).Text
                Ind = Li.Index
                btnEdit.Text = "Update"
            Else
                Li = LstCustomer.Items(Ind)
                Li.Text = txtCustID.Text
                Li.SubItems(1).Text = txtCustName.Text
                Li.SubItems(2).Text = cboGender.Text
                Li.SubItems(3).Text = cboDOB.Text
                Li.SubItems(4).Text = txtAddress.Text
                Li.SubItems(5).Text = txtCity.Text
                Li.SubItems(6).Text = txtState.Text
                Li.SubItems(7).Text = txtCountry.Text
                Li.SubItems(8).Text = txtNationality.Text
                Li.SubItems(9).Text = txtPassNo.Text
                Li.SubItems(10).Text = txtCardNo.Text
                Com.CommandText = "Update tblCustomer set CusName=?,Gender=?,DOB=?,Address=?,City=?" & _
                ",State=?,Country=?,Nationality=?,PassportNo=?,CardNo=? where CusID=?"
                With Com.Parameters
                    .Add("@CName", OleDbType.VarChar).Value = txtCustName.Text
                    .Add("@Gender", OleDbType.VarChar).Value = cboGender.Text
                    .Add("@DOB", OleDbType.VarChar).Value = cboDOB.Text
                    .Add("@Address", OleDbType.VarChar).Value = txtAddress.Text
                    .Add("@City", OleDbType.VarChar).Value = txtCity.Text
                    .Add("@State", OleDbType.VarChar).Value = txtState.Text
                    .Add("@Country", OleDbType.VarChar).Value = txtCountry.Text
                    .Add("@Nationality", OleDbType.VarChar).Value = txtNationality.Text
                    .Add("@PassNo", OleDbType.VarChar).Value = txtPassNo.Text
                    .Add("@CardNo", OleDbType.VarChar).Value = txtCardNo.Text
                    .Add("@CID", OleDbType.VarChar).Value = txtCustID.Text
                End With
                Com.ExecuteNonQuery()
                Com.Parameters.Clear()
                ClearAll(Me)
                cboGender.SelectedIndex = -1
                txtCustName.Focus()
                txtCustID.Text = "Cust-" & Format(AutoID("tblCustomer", "CusID"), "0000")
                Message("Success.")
                btnEdit.Text = "Edit"
            End If
        End If
    End Sub

    

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstCustomer.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        txtCustID.Text = Li.Text
        txtCustName.Text = Li.SubItems(1).Text
        cboGender.Text = Li.SubItems(2).Text
        cboDOB.Text = IIf((Li.SubItems(3).Text) = " ", cboDOB.Text, Li.SubItems(3).Text)
        txtAddress.Text = Li.SubItems(4).Text
        txtCity.Text = Li.SubItems(5).Text
        txtState.Text = Li.SubItems(6).Text
        txtCountry.Text = Li.SubItems(7).Text
        txtNationality.Text = Li.SubItems(8).Text
        txtPassNo.Text = Li.SubItems(9).Text
        txtCardNo.Text = Li.SubItems(10).Text
        Ind = Li.Index
        btnEdit.Text = "Update"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearAll(Me)
        txtCustName.Focus()
        cboGender.SelectedIndex = -1
        btnEdit.Text = "Edit"
        txtCustID.Text = "Cust-" & Format(AutoID("tblCustomer", "CusID"), "0000")
        btnEdit.Enabled = False

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        'Form2.Show()
        'ShowForm(Form2, Main)
    End Sub

    Private Sub CheckInToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem1.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstCustomer.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Me.Close()
        CheckInMenu()
        With frmCheckIn
            .txtCusID.Text = Li.Text
            .cboCusName.Text = Li.SubItems(1).Text
            .txtGender.Text = Li.SubItems(2).Text
            .txtAddress.Text = Li.SubItems(4).Text
            .txtPassNo.Text = Li.SubItems(9).Text
            .txtCardNo.Text = Li.SubItems(10).Text
            .txtStaying.Focus()
        End With
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstCustomer.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Me.Close()
        BookingMenu()
        With frmCheckIn
            .txtCusID.Text = Li.Text
            .cboCusName.Text = Li.SubItems(1).Text
            .txtGender.Text = Li.SubItems(2).Text
            .txtAddress.Text = Li.SubItems(4).Text
            .txtPassNo.Text = Li.SubItems(9).Text
            .txtCardNo.Text = Li.SubItems(10).Text
            .txtStaying.Focus()
        End With
    End Sub



    Private Sub txtCustName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustName.KeyPress
        onlyAlphabate(e)
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress
        onlyAlphabate(e)
    End Sub

    Private Sub txtState_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtState.KeyPress
        onlyAlphabate(e)
    End Sub

    Private Sub txtNationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNationality.KeyPress
        onlyAlphabate(e)
    End Sub

    Private Sub txtPassNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassNo.KeyPress
        onlyInteger(e)
    End Sub
    Private Sub txtCardNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardNo.KeyPress
        onlyInteger(e)
    End Sub


 
  
    Private Sub LstCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstCustomer.SelectedIndexChanged
        btnEdit.Enabled = True
    End Sub
End Class
