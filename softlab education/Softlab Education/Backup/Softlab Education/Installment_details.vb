
Imports System.Data
Imports System.Data.SqlClient
Public Class Installment_details
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String

    'Public Sub GenerateId()
    '    Dim cmd As New SqlCommand("Select * from Installment_details", con)
    '    con.Open()
    '    Dim dr As SqlDataReader = cmd.ExecuteReader
    '    While dr.Read
    '        txtstud_id.Text = dr(0)
    '    End While
    '    txtstud_id.Text = Val(txtstud_id.Text) + 1
    '    dr.Close()
    '    con.Close()
    'End Sub

    Public Sub EnaableScheduleField()
        txtstud_id.Enabled = True
        txtstud_lname.Enabled = True
        txtstud_mname.Enabled = True
        txtstud_lname.Enabled = True
        txtc_id.Enabled = True
        txtc_name.Enabled = True
        txttotal_fee.Enabled = True
        txtamt_pay.Enabled = True
        txt_remaning.Enabled = True
        txt_install.Enabled = True
        txttotal_amt.Enabled = True
        txt_bal.Enabled = True

    End Sub

    Public Sub clearField()

        txtstud_lname.Text = ""
        txtstud_mname.Text = ""
        txtstud_lname.Text = ""
        txtc_id.Text = ""
        txtc_name.Text = ""
        txttotal_fee.Text = ""
        txtamt_pay.Text = ""
        txt_remaning.Text = ""
        txt_install.Text = ""
        txttotal_amt.Text = ""
        txt_bal.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (btn_add.Text = "&Add") Then
            'Call GenerateId()
            Call EnaableScheduleField()
            btn_add.Text = "&Save"
        Else
            If txtstud_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtstud_id, "Enter the Student Id")
                MessageBox.Show("Enter the the Student Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtstud_id.Focus()
            Else
                If txtstud_fname.Text.Length = 0 Then
                    ErrorProvider1.SetError(txtstud_fname, "Enter the Frist Name of the Student ")
                    MessageBox.Show("Enter the Frist Name of the Student!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtstud_lname.Focus()
                Else
                    If txtstud_mname.Text = "" Then
                        ErrorProvider1.SetError(txtstud_mname, "Enter the Middle Name of the Student")
                        MessageBox.Show("Enter the Middle Name of the Student", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstud_mname.Focus()
                    Else
                        If txtstud_lname.Text = "" Then
                            ErrorProvider1.SetError(txtstud_lname, "Enter the Last Name of the Student ")
                            MessageBox.Show("Enter the last Name of the Student ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtstud_lname.Focus()
                        Else
                            If txtc_id.Text = "" Then
                                ErrorProvider1.SetError(txtc_id, "Enter the Course Id")
                                MessageBox.Show("Enter the Course Id", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtc_id.Focus()
                            Else
                                If txtc_name.Text = "" Then
                                    ErrorProvider1.SetError(txtc_name, "Enter the Course name")
                                    MessageBox.Show("Enter the Course name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtc_name.Focus()
                                Else
                                    If txttotal_fee.Text = "" Then
                                        ErrorProvider1.SetError(txttotal_fee, "Enter the Totle Fee")
                                        MessageBox.Show("Enter the Totle Fee", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txttotal_fee.Focus()
                                    Else
                                        If txtamt_pay.Text = "" Then
                                            ErrorProvider1.SetError(txtamt_pay, "Enter the amount paid details")
                                            MessageBox.Show("Enter the amount paid details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtamt_pay.Focus()

                                        Else
                                            If txt_remaning.Text = "" Then
                                                ErrorProvider1.SetError(txt_remaning, "Enter the remaning details")
                                                MessageBox.Show("Enter the remaning details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txt_remaning.Focus()
                                            Else
                                                'If txt_amount.Text = "" Then
                                                '    ErrorProvider1.SetError(txt_amount, "Enter the amount details")
                                                '    MessageBox.Show("Enter the amount details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                '    txt_amount.Focus()
                                                'Else
                                                If txt_install.Text = "" Then
                                                    ErrorProvider1.SetError(txt_install, "Enter the install details")
                                                    MessageBox.Show("Enter the install details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    txt_install.Focus()
                                                Else
                                                    If txttotal_amt.Text = "" Then
                                                        ErrorProvider1.SetError(txttotal_amt, "Enter the total amount pay details")
                                                        MessageBox.Show("Enter thetotal amount pay details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        txttotal_amt.Focus()
                                                    Else
                                                        If txt_bal.Text = "" Then
                                                            ErrorProvider1.SetError(txt_bal, "Enter the balence details")
                                                            MessageBox.Show("Enter the balence details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            txt_bal.Focus()
                                                        Else
                                                            str = "insert into Installment_details values(" & txtstud_id.Text & ",'" & txtstud_lname.Text & "','" & txtstud_fname.Text & "','" & txtstud_mname.Text & "'," & txtc_id.Text & ",'" & txtc_name.Text & "'," & txttotal_fee.Text & "," & txtamt_pay.Text & "," & txt_remaning.Text & "," & txt_install.Text & "," & txt_amnt.Text & ", " & txttotal_amt.Text & "," & txt_bal.Text & ");"
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


    End Sub

    Private Sub Installment_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)
        'MessageBox.Show("connection successfull")
        con.Close()
        'Call DisableScheduleField()

        con.Open()
        cmd = New SqlCommand(str, con)
        'MessageBox.Show("connection successfull")
        con.Close()
        adp1 = New SqlDataAdapter("select * from addmission", con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim dt As DataRow
        For Each dt In ds1.Tables(0).Rows()
            txtstud_id.Items.Add(dt.Item("stud_id"))
        Next
    End Sub

    Private Sub txt_amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txt_bal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_bal.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_install_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    
    Private Sub txtamt_pay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt_pay.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_remaning_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_remaning.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtc_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtc_id.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtc_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtc_name.KeyPress
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

    Private Sub txttotal_amt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotal_amt.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txttotal_fee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotal_fee.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtstud_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstud_id.SelectedIndexChanged
        str = "select * from addmission  where stud_id='" & txtstud_id.Text & "'"
        adp1 = New SqlDataAdapter(str, con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim s As String
        s = txtstud_id.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows()
            If s = dr.Item("stud_id").ToString Then
                txtstud_lname.Text = dr.Item("stud_lname")
                txtstud_fname.Text = dr.Item("stud_fname")
                txtstud_mname.Text = dr.Item("stud_mname")
                txtc_id.Text = dr.Item("cou_id")
                txtc_name.Text = dr.Item("cou_name")
                txttotal_fee.Text = dr.Item("stud_tfee")
                txtamt_pay.Text = dr.Item("stud_advance")
            End If
        Next
        txt_remaning.Text = txttotal_fee.Text - txtamt_pay.Text
        

    End Sub

    
    Private Sub txt_amnt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_amnt.Leave

        Dim a, b, c, d, f As Integer
        a = txtamt_pay.Text
        b = txt_amnt.Text
        d = txttotal_fee.Text
        c = a + b
        f = d - c
        txttotal_amt.Text = c
        txt_bal.Text = f
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clearField()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
