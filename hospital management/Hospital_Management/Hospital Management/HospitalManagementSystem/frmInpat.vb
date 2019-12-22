Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmInpat
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim txt As String
     Dim counti = 0

    Private Sub frmInpat_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtname.Focus()
        'connection()
        'con = New SqlConnection(constr)
        con.Open()
        Call DisplayName()
    End Sub

    'Private Sub cboAnes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        cboLBr.Focus()

    '    End If

    'End Sub


    'Private Sub cboCast_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        cboSex.Focus()
    '    End If
    'End Sub

    Private Sub cboCast_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboDCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDCode.DropDown
        'On Error Resume Next
        cmd.Connection = con
        cmd.CommandText = "SELECT DOCCODE from DOCTORS"
        rd = cmd.ExecuteReader
        cboDCode.Items.Clear()
        While rd.Read()
            cboDCode.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboDCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDCode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cboWrd.Focus()
        End If
    End Sub

    Private Sub cboDCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDCode.LostFocus
        'On Error Resume Next
        cmd.Connection = con
        cmd.CommandText = "SELECT DOCNAME from DOCTORS where DOCCODE='" & cboDCode.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read()
            txtDName.Text = rd(0)
        End While
        rd.Close()
    End Sub

    Private Sub txtDName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDName.KeyPress
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
    'Private Sub cboLBr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        cbolbrCse.Focus()
    '    End If
    'End Sub
    'Private Sub cbolbrCse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        cboSrgry.Focus()
    '    End If
    'End Sub

    Private Sub cboMarSts_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMarSts.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cboDCode.Focus()
        End If
    End Sub

    Private Sub cboRType_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRType.DropDown
        cmd.Connection = con
        cmd.CommandText = "SELECT distinct(ROOMTYPE) FROM ROOM_MAST"
        rd.Close()
        rd = cmd.ExecuteReader
        cboRType.Items.Clear()
        While rd.Read
            cboRType.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboRType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRType.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtBDNo.Focus()
        End If
    End Sub

    Private Sub cboSex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSex.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cbobld.Focus()
        End If
    End Sub

    'Private Sub cboSrgry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        txtDiag.Focus()
    '    End If
    'End Sub

    Private Sub cboWrd_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboWrd.DropDown
        cmd.Connection = con
        cmd.CommandText = "SELECT distinct(WARDNAME) FROM ROOM_MAST"
        rd = cmd.ExecuteReader
        cboWrd.Items.Clear()
        While rd.Read
            cboWrd.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboWrd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboWrd.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cboRType.Focus()
        'End If
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
    Private Sub cmdClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClr.Click
        Call ClearAll()
    End Sub
    Public Sub ClearAll()
        txtcode.Text = ""
        txtname.Text = ""
        txtadd.Text = ""
        txtage.Text = ""
        txttel.Text = ""
        cboDCode.Text = ""
        txtDName.Text = ""
        cboWrd.Text = ""
        cboRType.Text = ""
        txtbdno.Text = ""
        txtdiag.Text = ""
        txtRMRent.Text = ""
        cboAnes.Text = ""
        cboLBr.Text = ""
        cbolbrCse.Text = ""
        cboSrgry.Text = ""
        cbobld.Text = ""
        cboCast.Text = ""

    End Sub
    Public Sub Enableds()
        'txtcode.Enabled = True
        txtname.Enabled = True
        txtadd.Enabled = True
        txtage.Enabled = True
        txttel.Enabled = True
        cboDCode.Enabled = True
        txtDName.Enabled = True
        cboWrd.Enabled = True
        cboRType.Enabled = True
        txtBDNo.Enabled = True
        txtDiag.Enabled = True
        txtRMRent.Enabled = True
        cboAnes.Enabled = True
        cboLBr.Enabled = True
        cbolbrCse.Enabled = True
        cboSrgry.Enabled = True
        cboCast.Enabled = True
    End Sub
    Public Sub Disableds()
        txtcode.Enabled = False
        txtname.Enabled = False
        txtadd.Enabled = False
        txtage.Enabled = False
        txttel.Enabled = False
        cboDCode.Enabled = False
        txtDName.Enabled = False
        cboWrd.Enabled = False
        cboRType.Enabled = False
        txtBDNo.Enabled = False
        txtDiag.Enabled = False
        txtRMRent.Enabled = False
        cboAnes.Enabled = False
        cboLBr.Enabled = False
        cbolbrCse.Enabled = False
        cboSrgry.Enabled = False
        cboCast.Enabled = False
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        'On Error Resume Next
        cmdUpdate.Text = "&Edit"
        If cmdNew.Text = "&NEW" Then
            Call Enableds()
            Call ClearAll()
            cmd.Connection = con
            cmd.CommandText = "SELECT PCODE FROM INPATIENTS order by pcode"
            rd = cmd.ExecuteReader
            txtcode.Text = 1
            While rd.Read
                txtcode.Text = Val(rd(0)) + 1
            End While
            rd.Close()
            cmdNew.Text = "&SAVE"

        ElseIf cmdNew.Text = "&SAVE" Then

            If txtcode.Text = "" Then
                MsgBox("Please enter patient code", vbInformation + vbOKOnly)
                txtcode.Focus()

            ElseIf txtname.Text = "" Then
                MsgBox("Please enter patient name", vbInformation + vbOKOnly)
                txtname.Focus()
            Else

                cmd.Connection = con
                cmd.CommandText = "insert into INPATIENTS (pcode,DOA,PName,Address,DOB,age,caste,SEX,BLOODGROUP,telno,MARITALSTATUS,DOCCODE,DOCEXAMINED,WARDJOINED,ROOMTYPE,bedno,ROOMRENT,DIAGNOSIS,TREATMENTDATE,ANESTYPE,LABOURROOM,LABOURCASE,SURGERYTYPE,Billstatus) values('" & txtcode.Text & "','" & dtpDOA.Value.Date & "','" & txtname.Text & "','" & txtadd.Text & "','" & dtpDOB.Value.Date & "','" & txtage.Text & "','" & cboCast.Text & "','" & cboSex.Text & "','" & cbobld.Text & "','" & txttel.Text & "','" & cboMarSts.Text & "','" & cboDCode.Text & "','" & txtDName.Text & "','" & cboWrd.Text & "','" & cboRType.Text & "','" & txtBDNo.Text & "','" & txtRMRent.Text & "','" & txtDiag.Text & "','" & dtpTrmnt.Value.Date & "','" & cboAnes.Text & "','" & cboLBr.Text & "','" & cbolbrCse.Text & "','" & cboSrgry.Text & "','UnPaid')"
                cmd.ExecuteNonQuery()

                cmd.Connection = con
                cmd.CommandText = "insert into ROOM (pcode,Name,wardname,RTYPE,bedno,rent) values('" & txtcode.Text & "','" & txtname.Text & "','" & cboWrd.Text & "','" & cboRType.Text & "','" & txtBDNo.Text & "','" & txtRMRent.Text & "')"
                cmd.ExecuteNonQuery()
                txtname.Focus()
                lstname.Items.Add(txtname.Text)
                MsgBox("Records Saved", vbInformation + vbOKOnly)
                cmdNew.Text = "&NEW"
                Call Disableds()
                Call ClearAll()
                
            End If
       
        End If
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        'On Error Resume Next
        cmdSave.Text = "&Add New"
        If cmdUpdate.Text = "&EDIT" Then
            Call Enableds()
            cmdUpdate.Text = "&UPDATE"
        ElseIf cmdUpdate.Text = "&UPDATE" Then
            cmd.Connection = con
            cmd.CommandText = "Update INPATIENTS set DOA = '" & dtpDOA.Value.Date & "', PNAME ='" & txtname.Text & "',ADDRESS = '" & txtadd.Text & "',DOB='" & dtpDOB.Value.Date & "',AGE='" & txtage.Text & "' ,CASTE= '" & cboCast.Text & "',SEX='" & cboSex.Text & "' ,BLOODGROUP='" & cbobld.Text & "' ,TELNO= '" & txttel.Text & "', MARITALSTATUS= '" & cboMarSts.Text & "',DOCCODE= '" & cboDCode.Text & "',DOCEXAMINED= '" & txtDName.Text & "',WARDJOINED='" & cboWrd.Text & "',ROOMTYPE='" & cboRType.Text & "',BEDNO='" & txtBDNo.Text & "',ROOMRENT='" & txtRMRent.Text & "',DIAGNOSIS='" & txtDiag.Text & "',ANESTYPE='" & cboAnes.Text & "',LABOURROOM='" & cboLBr.Text & "',LABOURCASE='" & cbolbrCse.Text & "',SURGERYTYPE='" & cboSrgry.Text & "',TREATMENT_DATE='" & dtpTrmnt.Text & "' where PCODE ='" & txtcode.Text & "'"
            cmd.ExecuteNonQuery()
            Call DisplayName()
            MsgBox("Details Updated.....", vbInformation + vbOKOnly)
            txtname.Focus()
            Call Disableds()
            Call ClearAll()
            cmdUpdate.Text = "&EDIT"
        End If
    End Sub
    Public Sub DisplayName()
        'On Error Resume Next
        cmd.Connection = con
        cmd.CommandText = "Select Pname from INPATIENTS"
        rd = cmd.ExecuteReader()
        lstname.Items.Clear()
        While rd.Read
            lstname.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub lstname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstname.Click
        On Error Resume Next
        'If lstname.SelCount = 0 Then
        '    Exit Sub
        'End If
        cmdNew.Text = "&NEW"
        cmdUpdate.Text = "&EDIT"

        cmd.Connection = con
        cmd.CommandText = "Select * from INPATIENTS where PNAME ='" & lstname.Text & "'"
        rd = cmd.ExecuteReader()
        While rd.Read
            txtcode.Text = rd("PCODE")
            dtpDOA.Value = rd("DOA")
            txtname.Text = rd("PNAME")
            txtadd.Text = rd("ADDRESS")
            dtpDOB.Value = rd("DOB")
            txtage.Text = rd("AGE")
            cboCast.Text = rd("CASTE")
            cboSex.Text = rd("SEX")
            cbobld.Text = rd("BLOODGROUP")
            txttel.Text = rd("TELNO")
            cboMarSts.Text = rd("MARITALSTATUS")
            cboDCode.Text = rd("DOCCODE")
            txtDName.Text = rd("DOCEXAMINED")
            cboRType.Text = rd("ROOMTYPE")
            txtRMRent.Text = rd("ROOMRENT")
            cboAnes.Text = rd("ANESTYPE")
            cboLBr.Text = rd("LABOURROOM")
            cboWrd.Text = rd("WARDJOINED")
            txtBDNo.Text = rd("BEDNO")
            txtDiag.Text = rd("DIAGNOSIS")
            cboLBr.Text = rd("LABOURROOM")
            cbolbrCse.Text = rd("LABOURCASE")
            cboSrgry.Text = rd("SURGERYTYPE")
        End While
        rd.Close()
        Call Disableds()
    End Sub

    Private Sub txtage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cboCast.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtBDNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBDNo.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cboAnes.Focus()
        'End If
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cboCast.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtBDNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBDNo.LostFocus
        'On Error Resume Next
        If txtBDNo.Text = "" Then
            Exit Sub
        End If
        cmd.Connection = con
        cmd.CommandText = "SELECT BEDNO from ROOM"
        rd = cmd.ExecuteReader()
        While rd.Read
            If rd(0) = txtBDNo.Text Then
                MsgBox("Sorry !!!! Bed is Occupied", , "Accepting Bed NO")
                txtBDNo.Text = ""
                txtBDNo.Focus()
            End If
        End While
        rd.Close()
    End Sub

    Private Sub cbobld_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbobld.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txttel.Focus()
        End If
    End Sub

    Private Sub txtDiag_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiag.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    txtRMRent.Focus()
        'End If
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

    Private Sub dtpDOB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpDOB.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtage.Focus()
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    txtadd.Focus()
        'End If
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

    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress
        'Dim str As String
        'str = "-0123456789NA"
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cboMarSts.Focus()
        'End If
        'If InStr(str, Chr(AscW(e.KeyChar))) = 0 And AscW(e.KeyChar) <> 8 Then
        '    e.KeyChar = ChrW(0)
        'End If
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cboCast.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub



    Private Sub frmInpat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Disableds()
        'cmd.Connection = con
        'cmd.CommandText = "SELECT DOCCODE from DOCTORS"
        'rd = cmd.ExecuteReader
        'While rd.Read()
        '    cboDCode.Items.Add(rd(0))
        'End While
        'rd.Close()
    End Sub

    Private Sub txtadd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd.KeyPress
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

    Private Sub cboCast_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCast.KeyPress
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

    Private Sub txtRMRent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRMRent.KeyPress

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

    Private Sub cboAnes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboAnes.KeyPress
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

    Private Sub cboLBr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboLBr.KeyPress
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

    Private Sub cbolbrCse_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbolbrCse.KeyPress
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

    Private Sub cboSrgry_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSrgry.KeyPress
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

    Private Sub txtRMRent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRMRent.TextChanged

    End Sub

    Private Sub txttel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttel.TextChanged

    End Sub

    Private Sub lstname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstname.SelectedIndexChanged

    End Sub
End Class