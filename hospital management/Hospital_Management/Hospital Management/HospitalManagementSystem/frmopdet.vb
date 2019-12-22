Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmopdet
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand


    Private Sub frmopdet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection()
        ' con = New SqlConnection(constr)
        con.Open()
        Me.WindowState = FormWindowState.Maximized
        cmd.Connection = con
        cmd.CommandText = "SELECT PCODE FROM INPATIENTS order by pcode"
        rd = cmd.ExecuteReader
        txtcode.Items.Clear()
        While rd.Read
            txtcode.Items.Add(rd("PCODE"))
        End While
        rd.Close()
    End Sub

    Private Sub cboDCode_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDCode.DropDown
        cmd.Connection = con
        cmd.CommandText = "SELECT DOCCODE from DOCTORS"
        rd = cmd.ExecuteReader
        While rd.Read
            cboDCode.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cboDCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDCode.LostFocus
        cmd.Connection = con
        cmd.CommandText = "SELECT DOCNAME from DOCTORS where DOCCODE='" & cboDCode.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read
            cmbdname.Text = rd(0)
        End While
        rd.Close()
    End Sub

    Private Sub cmddiag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddiag.Click
        'OPDiag.Show()
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        'If cmdnew.Text = "&NEW" Then
        '    cmd.Connection = con
        '    cmd.CommandText = "SELECT PCODE FROM OPDET order by pcode"
        '    rd = cmd.ExecuteReader
        '    txtcode.Text = 1
        '    While rd.Read
        '        txtcode.Text = rd(0) + 1
        '    End While
        '    rd.Close()
        '    cmdnew.Text = "&NEW"
        'ElseIf cmdnew.Text = "&SAVE" Then
        cmd.Connection = con
        cmd1.Connection = con

        If (txtcode.Text <> "") Then

            cmd1.CommandText = "select * from OPDET where pcode='" & txtcode.Text & "'"
            rd = cmd1.ExecuteReader()

            If (rd.HasRows) Then
                MsgBox("This record already exists")
            Else
                rd.Close()
                cmd.CommandText = "insert into OPDET values('" & txtcode.Text & "','" & txtName.Text & "','" & txtAdd.Text & "','" & dtpDOB.Value.Date & "','" & cmbCaste.Text & "','" & cmbGndr.Text & "','" & txtage.Text & "', '" & txtTelNo.Text & "','" & cmbMarStat.Text & "','" & txtbld.Text & "','" & cboDCode.Text & "','" & cmbdname.Text & "','" & txtDiag.Text & "','" & dttrmnt.Value.Date & "')"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Saved")
                'cmdnew.Text = "&NEW"
                Call ClearAll()

            End If

            
        Else
            MsgBox("Please enter Patient code")
        End If
        rd.Close()

    End Sub

    Private Sub ClearAll()
        'On Error Resume Next
        txtcode.Text = ""
        txtName.Text = ""
        txtAdd.Text = ""
        txtage.Text = ""
        txtbld.Text = ""
        txtDiag.Text = ""
        txtTelNo.Text = ""
        cboDCode.Text = ""
        cmbGndr.Text = ""
        cmbCaste.Text = ""
        cmbdname.Text = ""
        cmbMarStat.Text = ""
        ''
        ''pcinc.Refresh
        ''pcinc.Recordset.MoveLast
    End Sub

    Private Sub dtpDOB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpDOB.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbGndr.Focus()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'txttme.Text = Format$(Now, "hh:mm:ss AM/PM") & Space(2)
    End Sub

    Private Sub txtAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdd.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    dtpDOB.Focus()
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

    Private Sub txtage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    cmbGndr.Focus()
        'End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    txtAdd.Focus()
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

    
    Private Sub cmdEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXIT.Click
        Me.Close()
    End Sub

    Private Sub txtTelNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelNo.LostFocus
        If Not IsNumeric(txtTelNo.Text) Then
            MessageBox.Show("Please enter a numeric value for telephone")
            txtTelNo.Text = ""
        End If
    End Sub

    Private Sub cmbCaste_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCaste.KeyPress
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


    Private Sub cmbdname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdname.KeyPress
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

    Private Sub txtDiag_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiag.KeyPress
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

    Private Sub txtTelNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                      Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcode_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcode.LostFocus
     
    End Sub

    Private Sub txtcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcode.SelectedIndexChanged
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM INPATIENTS where pcode='" & txtcode.Text & "' "
        rd = cmd.ExecuteReader
        While rd.Read
            'txtcode.Items.Add(rd("PCODE"))
            'txtcode.Text = rd("")
            txtName.Text = rd("PNAME")
            txtAdd.Text = rd("ADDRESS")
            txtage.Text = rd("AGE")
            txtbld.Text = rd("BLOODGROUP")
            txtDiag.Text = rd("DIAGNOSIS")
            txtTelNo.Text = rd("TELNO")
            cboDCode.Text = rd("DOCCODE")
            cmbGndr.Text = rd("SEX")
            cmbCaste.Text = rd("CASTE")
            cmbdname.Text = rd("DOCEXAMINED")
            cmbMarStat.Text = rd("MARITALSTATUS")
            dtpDOB.Value = rd("DOB")
            dttrmnt.Value = rd("TREATMENTDATE")
        End While
        rd.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

    End Sub
End Class