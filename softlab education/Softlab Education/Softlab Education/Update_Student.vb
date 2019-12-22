Imports System.Data
Imports System.Data.SqlClient

Public Class Update_Student
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
   
    Public Sub EnaableScheduleField()
        txtstud_id.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_mname.Enabled = True
        txtstud_lname.Enabled = True
        txtstud_add.Enabled = True
        studdtp_dob.Enabled = True
        cbo_gen.Enabled = True
        txtstud_age.Enabled = True
        studdtp_register.Enabled = True
        txtemail.Enabled = True
        txtstud_con.Enabled = True
    End Sub
    Public Sub disablefields()
        txtstud_id.Enabled = False
        txtstud_fname.Enabled = False
        txtstud_mname.Enabled = False
        txtstud_lname.Enabled = False
        txtstud_add.Enabled = False
        studdtp_dob.Enabled = False
        cbo_gen.Enabled = False
        txtstud_age.Enabled = False
        studdtp_register.Enabled = False
        txtemail.Enabled = False
        txtstud_con.Enabled = False

    End Sub
#End Region

    Public Sub clearfields()
        txtstud_fname.Text = ""
        txtstud_mname.Text = ""
        txtstud_lname.Text = ""
        txtstud_add.Text = ""
        studdtp_dob.Text = ""
        cbo_gen.Text = ""
        txtstud_age.Text = ""
        studdtp_register.Text = ""
        txtemail.Text = ""
        txtstud_con.Text = ""
    End Sub
    Private Sub Update_Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet

        If (Search_Student.cmb_search_by.Text = "Student_Name") Then
            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)

            str1 = "select * from Resgistration_details where stud_lname='" & Search_Student.cmb_stud_name.Text & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Resgistration_details")
            con.Open()
            Dim dt1 As New DataTable
            da.Fill(dt1)
            con.Close()
            For Each row As DataRow In ds.Tables("Resgistration_details").Rows
                If row(3).ToString = Search_Student.cmb_stud_name.Text Then
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_add.Text = row("stud_add").ToString()
                    studdtp_dob.Text = row("stud_dob").ToString()
                    cbo_gen.Text = row("stud_gen").ToString()
                    txtstud_age.Text = row("stud_age").ToString()
                    studdtp_register.Text = row("stud_resdate").ToString()
                    txtemail.Text = row("stud_email").ToString()
                    txtstud_con.Text = row("stud_con").ToString()
                    Exit For
                End If
            Next
        Else

            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)

            str1 = "select * from Resgistration_details where stud_id=" & Search_Student.cmb_stud_id.Text & ""
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Resgistration_details")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Resgistration_details").Rows
                If row(0).ToString = Search_Student.cmb_stud_id.Text Then
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_add.Text = row("stud_add").ToString()
                    studdtp_dob.Text = row("stud_dob").ToString()
                    cbo_gen.Text = row("stud_gen").ToString()
                    txtstud_age.Text = row("stud_age").ToString()
                    studdtp_register.Text = row("stud_resdate").ToString()
                    txtemail.Text = row("stud_email").ToString()
                    txtstud_con.Text = row("stud_con").ToString()
                    Exit For
                End If

            Next
        End If
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "&Edit" Then
            Call EnaableScheduleField()
            btnedit.Text = "&Update"
        Else
            If txtstud_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtstud_id, "Enter the Stud Id ")
                MessageBox.Show("Enter the Stud Id !!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtstud_id.Focus()
            Else
                If txtstud_lname.Text = "" Then
                    ErrorProvider1.SetError(txtstud_lname, "Enter the Last Name of the Faculty ")
                    MessageBox.Show("Enter the last Name of the  Faculty ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtstud_lname.Focus()

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
                                        If studdtp_register.Text = "" Then
                                            ErrorProvider1.SetError(studdtp_register, "Enter the Register Date")
                                            MessageBox.Show("Enter the Register Date", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            studdtp_register.Focus()
                                        Else

                                            If txtstud_con.Text = "" Then
                                                ErrorProvider1.SetError(txtstud_con, "Enter the Contact details")
                                                MessageBox.Show("Enter the Contact details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txtstud_con.Focus()

                                            Else
                                                str = "update Resgistration_details set stud_id=" & txtstud_id.Text & ", stud_lname='" & txtstud_lname.Text & "',stud_fname='" & txtstud_fname.Text & "',stud_mname='" & txtstud_mname.Text & "',stud_add='" & txtstud_add.Text & "',stud_dob='" & CDate(studdtp_dob.Text) & "',stud_gen='" & cbo_gen.Text & "',stud_age=" & txtstud_age.Text & ",stud_resdate='" & CDate(studdtp_register.Text) & "',stud_email='" & txtemail.Text & "',stud_con=" & txtstud_con.Text & " where stud_id=" & txtstud_id.Text & ""
                                                con.Open()
                                                cmd = New SqlCommand(str, con)
                                                cmd.ExecuteNonQuery()
                                                con.Close()
                                                MessageBox.Show("Record updated successfully")

                                                btnedit.Text = "&Edit"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        str = "Delete from Resgistration_details where stud_id=" & txtstud_id.Text & ""
        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted successfully ")
        Call clearfields()
        con.Close()
        Call clearfields()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
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

    Private Sub txtstud_con_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstud_con.Leave
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

    Private Sub txtstud_con_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstud_con.TextChanged

    End Sub
End Class