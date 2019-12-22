Imports System.Data.OleDb
Public Class frmCheckIn
    Dim Da As New OleDbDataAdapter
    Dim Dt, Dt1, Dt2 As New DataTable
    Dim CID, CRoom As Int16 'Check Condition from tblCheckIn
    Dim BkID, BkRoom As Int16 'Check Conditon from tblBooking

    Private Sub frmCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        cboGender.SendToBack()
        txtCheckIn.Text = Format(Now, "dddd, MMMM dd, yyyy")
        ' Load Data into cboRoomType
        LoadRoomType(cboRType)

        If CName <> "" Then
            cboCusName.Text = CName
            txtCusID.Text = CuID
            txtAddress.Text = CAddress
            txtGender.Text = CGender
            txtPassNo.Text = CPNo
            txtCardNo.Text = CCNo
        End If

        ' Add Icon to Button New
        PIconButton(4)
    End Sub

    Private Sub cboRType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRType.SelectedIndexChanged
        LoadRoomNum(cboRNum, cboRType, txtAmount, txtFloor, txtStaying, txtTotal)
    End Sub

    Private Sub cboRNum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRNum.SelectedIndexChanged
        'Dim str As String
        'Dim dt As DataSet
        'str = "select case when count(FLAT_NO)=0 then 1 else (max(FLAT_NO)+1) end from Flat_master where LAND_NO= " & cmbLandNo.Text & "   "
        'Da = New OleDbDataAdapter(str, con)
        'dt = New DataSet
        'Da.Fill(dt)
        'If dt.Tables(0).Rows.Count > 0 Then
        '    cmbFlatNo.Text = dt.Tables(0).Rows(row).Item(0)
        'End If
        LoadFloor(cboRNum, txtFloor)
    End Sub
    Sub Clearcus()
        cboCusName.Text = ""
        txtCusID.Clear()
        txtGender.Clear()
        txtAddress.Clear()
        txtPassNo.Clear()
        txtCardNo.Clear()
    End Sub

    Private Sub cboCusName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCusName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSCustomer_Click(sender, e)
        End If
        onlyAlphabate(e)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        CuID = ""
        CName = ""
        CGender = ""
        CAddress = ""
        CPNo = ""
        CCNo = ""
    End Sub

    Private Sub txtStaying_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStaying.KeyPress
        onlyInteger(e)
    End Sub

    Private Sub txtStaying_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaying.TextChanged
        txtCheckOut.Text = Format(DateAdd(DateInterval.Day, Val(txtStaying.Text), CDate(txtCheckIn.Text)), "dddd, MMMM dd, yyyy")
        txtTotal.Text = Val(txtStaying.Text) * Format(txtAmount.Text, "currency")
        txtTotal.Text = Format(txtTotal.Text, "Currency")
    End Sub

    Private Sub txtPrepaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrepaid.GotFocus
        txtPrepaid.SelectAll()
    End Sub

    Private Sub txtPrepaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrepaid.KeyPress
        onlyInteger(e)
    End Sub

    Private Sub txtPrepaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrepaid.LostFocus
        PrepaidLostFocus(txtPrepaid, txtTotal)
    End Sub

    Private Sub txtPrepaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrepaid.TextChanged
        If txtPrepaid.Text <> "" Then
            txtRemain.Text = Format(txtTotal.Text, "Currency") - Format(txtPrepaid.Text, "Currency")
            txtRemain.Text = Format(txtRemain.Text, "Currency")
        End If
    End Sub

    Private Sub btnCheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckIn.Click
        If cboCusName.Text = "" Then
            Message("Choose one Customer to Check In.")
            cboCusName.Focus()
        ElseIf txtStaying.Text = "" Then
            Message("Complete Number of Staying.")
            txtStaying.Focus()
        ElseIf cboRNum.Text = "" Then
            Message("Choose One Room Number.")
            cboRNum.Focus()
        ElseIf txtPrepaid.Text = "" Then
            Message("Complete Prepaid.")
            txtPrepaid.Focus()
        Else
            CID = Getid("tblCheckIn", "CheckInNo", "CusID='" & txtCusID.Text & "'") - 1
            If CID = 0 Then
                CRoom = Getid("tblCheckIn", "CheckInNo", "RoomNo=" & cboRNum.Text & "") - 1
                If CRoom = 0 Then
                    If i = 1 Then
                        Com.CommandText = "Delete from tblBooking where CusID='" & txtCusID.Text & "'"
                        Com.ExecuteNonQuery()
                        CheckIn()
                    Else
                        BkID = Getid("tblBooking", "ID", "CusID='" & txtCusID.Text & "'") - 1
                        If BkID = 0 Then
                            BkRoom = Getid("tblBooking", "ID", "RoomNo=" & cboRNum.Text & "") - 1
                            If BkRoom = 0 Then
                                CheckIn()
                                i = 0
                            Else
                                Message("Room " & cboRNum.Text & " was Booked already.")
                            End If
                        Else
                            Message("This Customer was Booked already.")
                            cboCusName.Focus()
                            cboCusName.SelectAll()
                        End If
                    End If
                Else
                    Message("Room " & cboRNum.Text & " was not free.")
                    cboRNum.Focus()
                End If
            Else
                Message("This Customers are Staying.")
                cboCusName.Focus()
                cboCusName.SelectAll()
            End If
        End If
     
    End Sub

    Sub CheckIn()
        Dim CheckID As Integer
        CheckID = Getid("tblCheckIn", "CheckInNo")
        Com.CommandText = "Insert into tblCheckIn Values(?,?,?,?,?,?)"
        With Com.Parameters
            .Add("@ChID", OleDbType.Integer).Value = CheckID
            .Add("@DIn", OleDbType.Date).Value = txtCheckIn.Text
            .Add("@DOut", OleDbType.Date).Value = txtCheckOut.Text
            .Add("@CID", OleDbType.VarChar).Value = txtCusID.Text
            .Add("@RNo", OleDbType.Integer).Value = cboRNum.Text
            .Add("@Prepaid", OleDbType.Currency).Value = txtPrepaid.Text
        End With
        Com.ExecuteNonQuery()
        Com.Parameters.Clear()
        Message("Success.")
        Clearcus()
        txtStaying.Clear()
        txtCheckOut.Clear()
        'txtAmount.Clear()
        txtTotal.Clear()
        txtPrepaid.Clear()
        txtRemain.Clear()
        cboCusName.Focus()
    End Sub

    Sub PIconButton(ByVal Icon As Int16)
        btnNew.ImageList = ImageList1
        btnNew.ImageIndex = Icon
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If btnNew.Text = "     New" Then
            Clearcus()
            txtAddress.ReadOnly = False
            txtPassNo.ReadOnly = False
            txtGender.SendToBack()
            txtCardNo.ReadOnly = False
            cboCusName.Focus()
            txtCusID.Text = "Cust-" & Format(AutoID("tblCustomer", "CusID"), "0000")
            btnNew.Text = "     Save"
            PIconButton(0)
        Else
            If cboCusName.Text = "" Then
                Message("Complete Customer Name.")
                cboCusName.Focus()
            ElseIf cboGender.Text = "" Then
                Message("Choose One Gender.")
                cboGender.Focus()
            ElseIf txtAddress.Text = "" Then
                Message("Complete Address.")
                txtAddress.Focus()
            ElseIf txtCardNo.Text = "" Then
                Message("Complete Card No.")
                txtCardNo.Focus()
            Else
                Dim Mess As String
                Mess = MsgBox("Do you want to Quick Save?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Hotel Management System")
                If Mess = vbCancel Then
                    CName = cboCusName.Text
                    CGender = cboGender.Text
                    CAddress = txtAddress.Text
                    CPNo = txtPassNo.Text
                    CCNo = txtCardNo.Text
                    Me.Close()

                Else
                    Com.CommandText = "Insert into tblCustomer Values(?,?,?,?,?,?,?,?,?,?,?)"
                    With Com.Parameters
                        .Add("@CID", OleDbType.VarChar).Value = txtCusID.Text
                        .Add("@CName", OleDbType.VarChar).Value = cboCusName.Text
                        .Add("@Gender", OleDbType.VarChar).Value = cboGender.Text
                        .Add("@DOB", OleDbType.VarChar).Value = " "
                        .Add("@Address", OleDbType.VarChar).Value = txtAddress.Text
                        .Add("@City", OleDbType.VarChar).Value = " "
                        .Add("@State", OleDbType.VarChar).Value = " "
                        .Add("@Country", OleDbType.VarChar).Value = " "
                        .Add("@Nationality", OleDbType.VarChar).Value = " "
                        .Add("@PassNo", OleDbType.VarChar).Value = txtPassNo.Text
                        .Add("@CardNo", OleDbType.VarChar).Value = txtCardNo.Text
                    End With
                    Com.ExecuteNonQuery()
                    Com.Parameters.Clear()
                    Message("Success.")
                    cboGender.SendToBack()
                    txtAddress.ReadOnly = True
                    txtPassNo.ReadOnly = True
                    txtCardNo.ReadOnly = True
                    txtGender.Text = cboGender.Text
                    cboCusName.Focus()
                End If
                btnNew.Text = "     New"
                PIconButton(4)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clearcus()
        txtAddress.ReadOnly = True
        txtPassNo.ReadOnly = True
        cboGender.SendToBack()
        txtCardNo.ReadOnly = True
        cboCusName.Focus()
        btnNew.Text = "     New"
        PIconButton(4)
    End Sub

    Private Sub btnSCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCustomer.Click
        If cboCusName.Text = "" Then
            Message("Complete Customer Name to Search.")
            cboCusName.Focus()
        Else
            Com.CommandText = "Select CusID,Gender,Address,PassportNo,CardNo from tblCustomer where " & _
            "CusName='" & cboCusName.Text & "'"
            Dr = Com.ExecuteReader
            If Dr.Read = True Then
                txtCusID.Text = Dr(0)
                txtGender.Text = Dr(1)
                txtAddress.Text = Dr(2)
                txtPassNo.Text = Dr(3)
                txtCardNo.Text = Dr(4)

                'Lock Text Box Read Only
                txtAddress.ReadOnly = True
                txtPassNo.ReadOnly = True
                cboGender.SendToBack()
                txtCardNo.ReadOnly = True
                cboCusName.Focus()
                btnNew.Text = "     New"
                PIconButton(4)
            Else
                Message("Record was Not Found. Please Insert New Customer.")
                cboCusName.Focus()
            End If
            Dr.Close()
        End If
    End Sub

    Private Sub btnBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBooking.Click
        If cboCusName.Text = "" Then
            Message("Choose one Customer to Booking.")
            cboCusName.Focus()
        ElseIf txtStaying.Text = "" Then
            Message("Complete Number of Staying.")
            txtStaying.Focus()
        ElseIf cboRNum.Text = "" Then
            Message("Choose One Room Number.")
            cboRNum.Focus()
        ElseIf txtPrepaid.Text = "" Then
            Message("Complete Prepaid.")
            txtPrepaid.Focus()
        Else
            Dim CCus, CusRoom As Int32
            CCus = Getid("tblBooking", "ID", "CusID='" & txtCusID.Text & "'") - 1
            If CCus = 0 Then
                CusRoom = Getid("tblBooking", "ID", "RoomNo=" & cboRNum.Text & "") - 1
                If CRoom = 0 Then
                    CID = Getid("tblCheckIn", "CheckInNo", "CusID='" & txtCusID.Text & "'") - 1
                    If CID = 0 Then
                        CRoom = Getid("tblCheckIn", "CheckInNo", "RoomNo=" & cboRNum.Text & "") - 1
                        If CRoom = 0 Then
                            Dim CheckID As Integer
                            CheckID = Getid("tblBooking", "ID")
                            Com.CommandText = "Insert into tblBooking Values(?,?,?,?,?,?,?)"
                            With Com.Parameters
                                .Add("@ChID", OleDbType.Integer).Value = CheckID
                                .Add("@DIn", OleDbType.Date).Value = txtCheckIn.Text
                                .Add("@Staying", OleDbType.Integer).Value = txtStaying.Text
                                .Add("@DOut", OleDbType.Date).Value = DTCheckIn.Text
                                .Add("@CID", OleDbType.VarChar).Value = txtCusID.Text
                                .Add("@RNo", OleDbType.Integer).Value = cboRNum.Text
                                .Add("@Prepaid", OleDbType.Currency).Value = txtPrepaid.Text
                            End With
                            Com.ExecuteNonQuery()
                            Com.Parameters.Clear()
                            Message("Success.")
                            Clearcus()
                            txtStaying.Clear()
                            txtCheckOut.Clear()
                            'txtAmount.Clear()
                            txtTotal.Clear()
                            txtPrepaid.Clear()
                            txtRemain.Clear()
                            cboCusName.Focus()
                        Else
                            Message("Room " & cboRNum.Text & " was not free.")
                        End If
                    Else
                        Message("This Customer was staying.")
                        cboCusName.Focus()
                        cboCusName.SelectAll()
                    End If
                Else
                    Message("Room " & cboRNum.Text & " was Booked already.")
                    cboRNum.Focus()
                End If
            Else
                Message("This Customer's Name was Booking already.")
                cboCusName.Focus()
                cboCusName.SelectAll()
            End If
        End If
    End Sub

    Private Sub cboCusName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCusName.TextChanged
        If cboCusName.Text = "" Then
            Clearcus()
        End If
    End Sub

    Private Sub cboCusName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCusName.SelectedIndexChanged

    End Sub

    Private Sub txtPassNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassNo.KeyPress
        onlyInteger(e)

    End Sub

    Private Sub txtCardNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardNo.KeyPress
        onlyInteger(e)
    End Sub

   
  
    
End Class
'str = "select case when count(FLAT_NO)=0 then 1 else (max(FLAT_NO)+1) end from Flat_master where LAND_NO= " & cmbLandNo.Text & "   "