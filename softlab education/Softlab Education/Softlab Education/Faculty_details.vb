
Imports System.Data
Imports System.Data.SqlClient

Public Class Faculty_details
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String

    Public Sub GenerateId()
        Dim cmd As New SqlCommand("Select * from Faculty_details", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtfid.Text = dr(0)
        End While
        txtfid.Text = Val(txtfid.Text) + 1
        dr.Close()
        con.Close()
    End Sub
    Public Sub EnaableFaculty_detailsField()
        ' txtfid.Enabled = True
        txtfname.Enabled = True
        txtmname.Enabled = True
        txtlname.Enabled = True
        cmbgender.Enabled = True
        txtspe_sub.Enabled = True
        txtqu.Enabled = True
        txtex.Enabled = True
        txtno.Enabled = True
        dtpdob.Enabled = True
        dtpdoj.Enabled = True
        txtsal.Enabled = True
        txtadd.Enabled = True

    End Sub
    Public Sub clearField()
        txtfname.Text = ""
        txtmname.Text = ""
        txtlname.Text = ""
        cmbgender.Text = ""
        txtspe_sub.Text = ""
        txtqu.Text = ""
        txtex.Text = ""
        txtno.Text = ""
        dtpdob.Text = ""
        dtpdoj.Text = ""
        txtsal.Text = ""
        txt_email.Text = ""
        ErrorProvider1.Clear()
        txtadd.Text = ""
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (btn_add.Text = "&Add") Then
            Call GenerateId()
            Call EnaableFaculty_detailsField()
            btn_add.Text = "&Save"
        Else
            If txtfid.Text.Length = 0 Then
                ErrorProvider1.SetError(txtfid, "Enter the Id of the Faculty")
                MessageBox.Show("Enter the Id  of the Faculty!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtfid.Focus()
            Else
                If txtlname.Text = "" Then
                    ErrorProvider1.SetError(txtlname, "Enter the Last Name of the Faculty ")
                    MessageBox.Show("Enter the last Name of the  Faculty ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtlname.Focus()
                    
                Else
                    If txtfname.Text.Length = 0 Then
                        ErrorProvider1.SetError(txtfname, "Enter the Frist Name of the Faculty ")
                        MessageBox.Show("Enter the Frist Name of the Faculty!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtfname.Focus()
                    Else
                        If txtmname.Text = "" Then
                            ErrorProvider1.SetError(txtmname, "Enter the Middle Name of the Faculty")
                            MessageBox.Show("Enter the Middle Name of the  Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtmname.Focus()
                        Else
                            If cmbgender.Text = "" Then
                                ErrorProvider1.SetError(cmbgender, "Select the Gender")
                                MessageBox.Show("Select the Gender", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                cmbgender.Focus()

                            Else
                                If txtspe_sub.Text = "" Then
                                    ErrorProvider1.SetError(txtadd, "Enter the Subject_details")
                                    MessageBox.Show("Enter the Subject_details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtadd.Focus()
                                Else
                                    If txtqu.Text = "" Then
                                        ErrorProvider1.SetError(txtqu, "Enter the Qualification of the Faculty")
                                        MessageBox.Show("Enter the  Qualification of the  Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtqu.Focus()
                                    Else
                                        If txtex.Text = "" Then
                                            ErrorProvider1.SetError(txtex, "Enter the Experiance of the Faculty")
                                            MessageBox.Show("Enter the Experiance of the Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtex.Focus()
                                        Else
                                            If txtno.Text = "" Then
                                                ErrorProvider1.SetError(txtno, "Enter the Contact Number of the Faculty")
                                                MessageBox.Show("Enter the Contact Number of the  Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txtno.Focus()
                                            Else

                                                If dtpdob.Text = "" Then
                                                    ErrorProvider1.SetError(dtpdob, "Enter the Birth Date of the  Faculty")
                                                    MessageBox.Show("Enter the Birth Date of the  Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    dtpdob.Focus()
                                                Else
                                                    'If Email1.Text = "" Then
                                                    '    ErrorProvider1.SetError(Email1, "Enter the Email of the Employee")
                                                    '    MessageBox.Show("Enter the Email of the Employee", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    '    Email1.Focus()
                                                    'Else
                                                    If dtpdoj.Text = "" Then
                                                        ErrorProvider1.SetError(dtpdoj, "Enter the Date of Joining of the  Faculty")
                                                        MessageBox.Show("Enter the Date of Joining of the  Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        dtpdoj.Focus()
                                                    Else
                                                        If txtsal.Text = "" Then
                                                            ErrorProvider1.SetError(txtsal, "Enter the Salary of the Faculty")
                                                            MessageBox.Show("Enter the Salary of the Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            txtsal.Focus()
                                                        Else
                                                            If txtadd.Text = "" Then
                                                                ErrorProvider1.SetError(txtadd, "Enter the Address of the Faculty")
                                                                MessageBox.Show("Enter the Address of the Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                txtadd.Focus()
                                                            Else



                                                                str = " insert into Faculty_details values(" & txtfid.Text & ",'" & txtlname.Text & "','" & txtfname.Text & "','" & txtmname.Text & "','" & cmbgender.Text & "','" & txtspe_sub.Text & "','" & txtqu.Text & "','" & txtex.Text & "'," & txtno.Text & ",'" & CDate(dtpdob.Text) & "','" & txt_email.Text & "','" & CDate(dtpdoj.Text) & "'," & txtsal.Text & ",'" & txtadd.Text & "')"
                                                                con.Open()
                                                                cmd = New SqlCommand(str, con)
                                                                cmd.ExecuteNonQuery()
                                                                con.Close()
                                                                MessageBox.Show("Record addedd successfully")
                                                                Call clearField()
                                                                btn_add.Text = "&Add"
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
    End Sub


    Private Sub Faculty_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)
        'MessageBox.Show("connection successfull")
        con.Close()
        'Call DisableScheduleField()
    End Sub


    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        Call clearField()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
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


    Private Sub txt_email_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_email.LostFocus
        Dim at As Integer = 0
        Dim dot As Integer = 0
        Dim str1 As String = ""
        Dim str2 As String = ""
        Try
            For Each Chr As Char In txt_email.Text.ToCharArray
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
                txt_email.Text = ""
                txt_email.Focus()
                Exit Sub
            End If
            If txt_email.Text.IndexOf("@") <> -1 Then
                str1 = txt_email.Text.Substring(0, txt_email.Text.IndexOf("@"))
                If str1.Trim.Length() = 0 Then
                    MsgBox("enter valid email with @")
                    txt_email.Text = ""
                    txt_email.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("enter valid email with @")
                txt_email.Text = ""
                txt_email.Focus()
                Exit Sub
            End If
            If dot <> 0 Then
                str2 = txt_email.Text.Substring(txt_email.Text.IndexOf("@") + 1, txt_email.Text.LastIndexOf(".") - txt_email.Text.IndexOf("@") - 1)
                If str2.Trim.Length() = 0 Then
                    MsgBox("valid email with .")
                    txt_email.Text = ""
                    txt_email.Focus()
                End If
            Else
                MsgBox("enter valid email with dot")
                txt_email.Text = ""
                txt_email.Focus()
                Exit Sub
            End If
            If txt_email.Text.Length = 0 Then
                ErrorProvider1.SetError(txt_email, "Please Enter Address...")
                MsgBox("Please Enter Address", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_email.Focus()
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

    
End Class