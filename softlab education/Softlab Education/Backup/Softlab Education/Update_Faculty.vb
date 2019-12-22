Imports System.Data
Imports System.Data.SqlClient
Public Class Update_Faculty
    'Dim da As New SqlDataAdapter
    'Dim cmd As New SqlCommand
    'Dim con As New SqlConnection
    'Dim str, str1 As String
    'Dim dt As New DataTable
    'Dim ds As New DataSet
    'Dim dv As New DataView
    'Dim dr As SqlDataReader
    'Dim i As Integer
#Region "FUNCTION"
    Public Sub clearfields()
        txtfid.Text = ""
        txtfname.Text = ""
        txtmname.Text = ""
        txtlname.Text = ""
        cmbgender.Text = ""
        txtspe_sub.Text = ""
        txtqu.Text = ""
        txtex.Text = ""
        txtno.Text = ""
        dtpdob.Text = ""
        txtemail.Text = ""
        dtpdoj.Text = ""
        txtsal.Text = ""
        txtadd.Text = ""
    End Sub
    Public Sub enablefields()
        txtfid.Enabled = True
        txtfname.Enabled = True
        txtmname.Enabled = True
        txtlname.Enabled = True
        cmbgender.Enabled = True
        txtspe_sub.Enabled = True
        txtqu.Enabled = True
        txtex.Enabled = True
        txtno.Enabled = True
        dtpdob.Enabled = True
        txtemail.Enabled = True
        dtpdoj.Enabled = True
        txtsal.Enabled = True
        txtadd.Enabled = True
    End Sub
    Public Sub disablefields()
        txtfid.Enabled = False
        txtfname.Enabled = False
        txtmname.Enabled = False
        txtlname.Enabled = False
        cmbgender.Enabled = False
        txtspe_sub.Enabled = False
        txtqu.Enabled = False
        txtex.Enabled = False
        txtno.Enabled = False
        dtpdob.Enabled = False
        txtemail.Enabled = False
        dtpdoj.Enabled = False
        txtsal.Enabled = False
        txtadd.Enabled = False
    End Sub

#End Region
    Private Sub Update_Faculty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Search_Faculty.cmb_search_by.Text = "Faculty_Name") Then
            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from Faculty_details where l_name='" & Search_Faculty.cmb_faculty_name.Text & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Faculty_details")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Faculty_details").Rows
                If row(1).ToString = Search_Faculty.cmb_faculty_name.Text Then
                    txtfid.Text = row("f_id").ToString()
                    txtlname.Text = row("l_name").ToString()
                    txtfname.Text = row("f_name").ToString()
                    txtmname.Text = row("m_name").ToString()
                    cmbgender.Text = row("f_gen").ToString()
                    txtspe_sub.Text = row("f_sub").ToString()
                    txtqu.Text = row("f_qualification").ToString()
                    txtex.Text = row("f_exp").ToString()
                    txtno.Text = row("f_contact").ToString()
                    dtpdob.Text = row("f_dob").ToString()
                    txtemail.Text = row("f_email").ToString()
                    dtpdoj.Text = row("f_doj").ToString()
                    txtsal.Text = row("f_sal").ToString()
                    txtadd.Text = row("f_add").ToString()
                    Exit For
                End If
            Next
        Else

            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from Faculty_details where f_id=" & Search_Faculty.cmb_faculty_id.Text & ""
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Faculty_details")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Faculty_details").Rows
                If row(0).ToString = Search_Faculty.cmb_faculty_id.Text Then
                    txtfid.Text = row("f_id").ToString()
                    txtlname.Text = row("l_name").ToString()
                    txtfname.Text = row("f_name").ToString()
                    txtmname.Text = row("m_name").ToString()
                    cmbgender.Text = row("f_gen").ToString()
                    txtspe_sub.Text = row("f_sub").ToString()
                    txtqu.Text = row("f_qualification").ToString()
                    txtex.Text = row("f_exp").ToString()
                    txtno.Text = row("f_contact").ToString()
                    dtpdob.Text = row("f_dob").ToString()
                    txtemail.Text = row("f_email").ToString()
                    dtpdoj.Text = row("f_doj").ToString()
                    txtsal.Text = row("f_sal").ToString()
                    txtadd.Text = row("f_add").ToString()
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "&Edit" Then
            Call enablefields()
            btnedit.Text = "&Update"
        Else
            If txtfid.Text.Length = 0 Then
                ErrorProvider1.SetError(txtfid, "Enter Faculty id")
                MessageBox.Show("Enetr Faculty Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtfid.Focus()
            Else
                If txtlname.Text = "" Then
                    ErrorProvider1.SetError(txtlname, "Enter Last Name")
                    MessageBox.Show("Enter Last  name ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtlname.Focus()
                Else
                    If txtfname.Text.Length = 0 Then
                        ErrorProvider1.SetError(txtfname, "Enter First name")
                        MessageBox.Show("Enetr First name!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtfname.Focus()
                    Else
                        If txtmname.Text = "" Then
                            ErrorProvider1.SetError(txtmname, "Enter middle name")
                            MessageBox.Show("Enetr middle name!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtmname.Focus()
                        Else
                            If cmbgender.Text = "" Then
                                ErrorProvider1.SetError(cmbgender, "Enter Gender ")
                                MessageBox.Show("Enetr Gender!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                cmbgender.Focus()
                            Else
                                If txtspe_sub.Text = "" Then
                                    ErrorProvider1.SetError(txtadd, "Enter the Subject_details")
                                    MessageBox.Show("Enter the Subject_details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtadd.Focus()
                                Else
                                    If txtqu.Text = "" Then
                                        ErrorProvider1.SetError(txtqu, "Enter Qualification ")
                                        MessageBox.Show("Enetr Qualification!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtqu.Focus()
                                    Else
                                        If txtex.Text = "" Then
                                            ErrorProvider1.SetError(txtex, "Enter Experience ")
                                            MessageBox.Show("Enetr Experience!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtex.Focus()
                                        Else
                                            If txtno.Text = "" Then
                                                ErrorProvider1.SetError(txtno, "Enter Contact ")
                                                MessageBox.Show("Enetr contact!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txtno.Focus()
                                            Else
                                                If dtpdob.Text = "" Then
                                                    ErrorProvider1.SetError(dtpdob, "Enter Date of Birth ")
                                                    MessageBox.Show("Enetr Date of Birth!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    dtpdob.Focus()
                                                Else
                                                    If dtpdoj.Text = "" Then
                                                        ErrorProvider1.SetError(dtpdoj, "Enter Date of join ")
                                                        MessageBox.Show("Enter date of join!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        dtpdoj.Focus()
                                                    Else
                                                        If txtsal.Text = "" Then
                                                            ErrorProvider1.SetError(cmbgender, "Enter Salary")
                                                            MessageBox.Show("Enetr Salary!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            txtsal.Focus()
                                                        Else
                                                            If txtadd.Text = "" Then
                                                                ErrorProvider1.SetError(txtadd, "Enter Address ")
                                                                MessageBox.Show("Enetr Address!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                txtadd.Focus()
                                                            Else
                                                                str = " update  Faculty_details set f_id=" & txtfid.Text & ",l_name='" & txtlname.Text & "',f_name='" & txtfname.Text & "',m_name='" & txtmname.Text & "',f_gen='" & cmbgender.Text & "',f_sub='" & txtspe_sub.Text & "',f_qualification='" & txtqu.Text & "',f_exp='" & txtex.Text & "',f_contact=" & txtno.Text & ",f_dob='" & CDate(dtpdob.Text) & "',f_email='" & txtemail.Text & "',f_doj='" & CDate(dtpdoj.Text) & "',f_sal=" & txtsal.Text & ",f_add='" & txtadd.Text & "'"
                                                                con.Open()
                                                                cmd = New SqlCommand(str, con)
                                                                cmd.ExecuteNonQuery()
                                                                MessageBox.Show("Record Updated successfully ")
                                                                con.Close()
                                                                ' Call clearfields()
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                        End If
                    End If
                End If
            End If
            End If
        End If
        'Call clearfields()
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
                 And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                    MessageBox.Show("Please enter only Alphabets")
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtlname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlname.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
                 And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                    MessageBox.Show("Please enter only Alphabets")
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtmname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmname.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
                 And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                    MessageBox.Show("Please enter only Alphabets")
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtqu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqu.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
                 And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
                 Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                    MessageBox.Show("Please enter only Alphabets")
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtsal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsal.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub txtno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtno.TextChanged

    End Sub

    Private Sub txtno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtno.Validated
        Try
            If txtno.Text.Length = 0 Then
                txtno.Text = Nothing
            ElseIf txtno.Text.Length <> 10 Then
                ErrorProvider1.SetError(txtno, "Invalid Mobile No. Please Enter 10 Digits")
                txtno.Focus()
                txtno.SelectAll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtemail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.LostFocus
        Dim at As Integer = 0
        Dim dot As Integer = 0
        Dim str1 As String = ""
        Dim str2 As String = ""
        Try
            For Each Chr As Char In txtemail.Text.ToCharArray
                If ((Asc(Chr) >= 65 And Asc(Chr) <= 90) Or (Asc(Chr) >= 97 And Asc(Chr) <= 122) Or (Asc(Chr) >= 48 And Asc(Chr) <= 57) Or Asc(Chr) = 64 Or Asc(Chr) = 46 Or Asc(Chr) = 95) Then
                    If Chr = "@" Then
                        at = at + 1
                    ElseIf Chr = "." Then
                        dot = dot + 1
                    End If
                End If
            Next
            If at >= 2 Or dot > 2 Then
                MsgBox("enter valid email with @ and .")
                txtemail.Text = ""
                txtemail.Focus()
                Exit Sub
            End If
            If txtemail.Text.IndexOf("@") <> -1 Then
                str1 = txtemail.Text.Substring(0, txtemail.Text.IndexOf("@"))
                If str1.Trim.Length() = 0 Then
                    MsgBox("enter valid email with @")
                    txtemail.Text = ""
                    txtemail.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("enter valid email with @")
                txtemail.Text = ""
                txtemail.Focus()
                Exit Sub
            End If
            If dot <> 0 Then
                str2 = txtemail.Text.Substring(txtemail.Text.IndexOf("@") + 1, _txtemail.Text.LastIndexOf(".") - txtemail.Text.IndexOf("@") - 1)
                If str2.Trim.Length() = 0 Then
                    MsgBox("valid email with .")
                    txtemail.Text = ""
                    txtemail.Focus()
                End If
            Else
                MsgBox("enter valid email with dot")
                txtemail.Text = ""
                txtemail.Focus()
                Exit Sub
            End If
            If txtemail.Text.Length = 0 Then
                ErrorProvider1.SetError(txtemail, "Please Enter Address...")
                MsgBox("Please Enter Address", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtemail.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            at = Nothing
            dot = Nothing
            str1 = Nothing
            str2 = Nothing
        End Try
    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        str = "Delete from Faculty_details where f_id=" & txtfid.Text & ""
        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted successfully ")
        con.Close()
        Call clearfields()
    End Sub
End Class