Imports System.Data
Imports System.Data.SqlClient

Public Class Registration_details
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String

    Public Sub GenerateId()
        Dim cmd As New SqlCommand("Select * from Resgistration_details", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtstud_id.Text = dr(0)
        End While
        txtstud_id.Text = Val(txtstud_id.Text) + 1
        dr.Close()
        con.Close()
    End Sub
    Public Sub EnaableRegistration_detailsField()
        ' txtstud_id.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_mname.Enabled = True
        txtstud_lname.Enabled = True
        txtstud_add.Enabled = True
        studdtp_dob.Enabled = True
        cbo_gen.Enabled = True
        txtstud_age.Enabled = True
        studdtp_register.Enabled = True

    End Sub

    Public Sub clearFied()
        txtstud_fname.Text = ""
        txtstud_mname.Text = ""
        txtstud_lname.Text = ""
        txtstud_add.Text = ""
        studdtp_dob.Text = ""
        txtemail.Text = ""
        txtstud_con.Text = ""
        cbo_gen.Items.Clear()
        txtstud_age.Text = ""
        studdtp_register.Text = ""
        ErrorProvider1.Clear()
    End Sub
    

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (btn_add.Text = "&Add") Then
            Call GenerateId()
            Call EnaableRegistration_detailsField()
            btn_add.Text = "&Save"
        Else
            If txtstud_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtstud_id, "Enter the Stud Id ")
                MessageBox.Show("Enter the Stud Id !!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtstud_id.Focus()
            Else
                If txtstud_fname.Text.Length = 0 Then
                    ErrorProvider1.SetError(txtstud_fname, "Enter the Frist Name of the Faculty ")
                    MessageBox.Show("Enter the Frist Name of the Faculty!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtstud_fname.Focus()
                Else
                    If txtstud_mname.Text = "" Then
                        ErrorProvider1.SetError(txtstud_mname, "Enter the Middle Name of the Faculty")
                        MessageBox.Show("Enter the Middle Name of the  Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstud_mname.Focus()
                    Else
                        If txtstud_lname.Text = "" Then
                            ErrorProvider1.SetError(txtstud_lname, "Enter the Last Name of the Faculty ")
                            MessageBox.Show("Enter the last Name of the  Faculty ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtstud_lname.Focus()
                        Else
                            If txtstud_add.Text = "" Then
                                ErrorProvider1.SetError(txtstud_add, "Enter the Address details")
                                MessageBox.Show("Enter the Address details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtstud_add.Focus()

                            Else
                                If studdtp_dob.Text = "" Then
                                    ErrorProvider1.SetError(studdtp_dob, "Enter the Date Of birth")
                                    MessageBox.Show("Enter the   Date Of birth", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    studdtp_dob.Focus()
                                Else
                                    If cbo_gen.Text = "" Then
                                        ErrorProvider1.SetError(cbo_gen, "Enter the gender")
                                        MessageBox.Show("Enter the gender", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        cbo_gen.Focus()
                                    Else
                                        If txtstud_age.Text = "" Then
                                            ErrorProvider1.SetError(txtstud_age, "Enter the Age of student")
                                            MessageBox.Show("Enter the Age of student", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtstud_age.Focus()
                                        Else
                                            If studdtp_register.Text = "" Then
                                                ErrorProvider1.SetError(studdtp_register, "Enter the Register Date")
                                                MessageBox.Show("Enter the Register Date", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                studdtp_register.Focus()
                                            Else
                                                If txtemail.Text = "" Then
                                                    ErrorProvider1.SetError(txtemail, "Enter the email ")
                                                    MessageBox.Show("Enter the email", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    txtemail.Focus()
                                                Else
                                                    If txtstud_con.Text = "" Then
                                                        ErrorProvider1.SetError(txtstud_con, "Enter the Contact details")
                                                        MessageBox.Show("Enter the Contact details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        txtstud_con.Focus()

                                                    Else
                                                        str = " insert into Resgistration_details values(" & txtstud_id.Text & ",'" & txtstud_fname.Text & "','" & txtstud_mname.Text & "','" & txtstud_lname.Text & "','" & txtstud_add.Text & "','" & CDate(studdtp_dob.Text) & "','" & cbo_gen.Text & "'," & txtstud_age.Text & ",'" & CDate(studdtp_register.Text) & "','" & txtemail.Text & "'," & txtstud_con.Text & ")"
                                                        con.Open()
                                                        cmd = New SqlCommand(str, con)
                                                        cmd.ExecuteNonQuery()
                                                        con.Close()
                                                        MessageBox.Show("Record addedd successfully")
                                                        Call clearFied()
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





    End Sub

    Private Sub Registration_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)
        'MessageBox.Show("connection successfull")
        con.Close()
        'Call DisableScheduleField()
    End Sub


   
    Private Sub txtstud_age_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstud_age.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtstud_con_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstud_con.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtstud_fname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstud_fname.KeyPress
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

    Private Sub txtstud_lname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstud_lname.KeyPress
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

    Private Sub txtstud_mname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstud_mname.KeyPress
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call clearFied()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtstud_con_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstud_con.TextChanged

    End Sub

    Private Sub txtstud_con_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstud_con.Validated
        Try
            If txtstud_con.Text.Length = 0 Then
                txtstud_con.Text = Nothing
            ElseIf txtstud_con.Text.Length <> 10 Then
                ErrorProvider1.SetError(txtstud_con, "Invalid Mobile No. Please Enter 10 Digits")
                txtstud_con.Focus()
                txtstud_con.SelectAll()
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

    Private Sub txtemail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Validated

    End Sub
End Class