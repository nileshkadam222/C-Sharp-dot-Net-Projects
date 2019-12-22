Imports System.Data
Imports System.Data.SqlClient
Public Class Update_Installment
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
        txtstud_id.Text = ""
        txtstud_lname.Text = ""
        txtstud_mname.Text = ""
        txtstud_lname.Text = ""
        txtc_id.Text = ""
        txtc_name.Text = ""
        txttotal_fee.Text = ""
        txtamt_pay.Text = ""
        txt_remaning.Text = ""
        txt_amount.Text = ""
        txt_install.Text = ""
        txttotal_amt.Text = ""
        txt_bal.Text = ""
    End Sub
    Public Sub EnaableScheduleField()
        txtstud_id.Enabled = True
        txtstud_lname.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_mname.Enabled = True
        txtc_id.Enabled = True
        txtc_name.Enabled = True
        txttotal_fee.Enabled = True
        txtamt_pay.Enabled = True
        txt_remaning.Enabled = True
        txt_amount.Enabled = True
        txt_install.Enabled = True
        txttotal_amt.Enabled = True
        txt_bal.Enabled = True

    End Sub
    Public Sub disablefields()
        txtstud_id.Enabled = False
        txtstud_lname.Enabled = False
        txtstud_fname.Enabled = False
        txtstud_mname.Enabled = False
        txtc_id.Enabled = False
        txtc_name.Enabled = False
        txttotal_fee.Enabled = False
        txtamt_pay.Enabled = False
        txt_remaning.Enabled = False
        txt_amount.Enabled = False
        txt_install.Enabled = False
        txttotal_amt.Enabled = False
        txt_bal.Enabled = False

    End Sub


#End Region

    Private Sub Update_Installment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Search_Installment.cmb_search_by.Text = "Student_Name") Then
            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from Installment_details where stud_lname='" & Search_Installment.cmb_stud_name.Text & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Installment_details")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Installment_details").Rows
                If row(1).ToString = Search_Installment.cmb_stud_name.Text Then
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtc_id.Text = row("c_id").ToString()
                    txtc_name.Text = row("c_name").ToString()
                    txttotal_fee.Text = row("total_fee").ToString()
                    txtamt_pay.Text = row("amt_paid").ToString()
                    txt_remaning.Text = row("remaining_amt").ToString()
                    txt_amount.Text = row("amount").ToString()
                    txt_install.Text = row("installment").ToString()
                    txttotal_amt.Text = row("total_amt").ToString()
                    txt_bal.Text = row("balance").ToString()
                    Exit For
                End If
            Next
        Else


            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from Installment_details where stud_id=" & Search_Installment.cmb_stud_id.Text & ""
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Installment_details")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Installment_details").Rows
                If row(0).ToString = Search_Installment.cmb_stud_id.Text Then
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtc_id.Text = row("c_id").ToString()
                    txtc_name.Text = row("c_name").ToString()
                    txttotal_fee.Text = row("total_fee").ToString()
                    txtamt_pay.Text = row("amt_paid").ToString()
                    txt_remaning.Text = row("remaining_amt").ToString()
                    txt_amount.Text = row("amount").ToString()
                    txt_install.Text = row("installment").ToString()
                    txttotal_amt.Text = row("total_amt").ToString()
                    txt_bal.Text = row("balance").ToString()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "&Edit" Then
            Call EnaableScheduleField()
            btnedit.Text = "&Update"
        Else
            If txtstud_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtstud_id, "Enter Student id")
                MessageBox.Show("Enetr Student Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtstud_id.Focus()
            Else
                If txtstud_lname.Text.Length = 0 Then
                    ErrorProvider1.SetError(txtstud_lname, "Enter student last name")
                    MessageBox.Show("Enter Stdent last name ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtstud_lname.Focus()
                Else
                    If txtstud_fname.Text.Length = 0 Then
                        ErrorProvider1.SetError(txtstud_fname, "Enter student First name")
                        MessageBox.Show("Enter Stdent First name ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstud_fname.Focus()
                    Else
                        If txtstud_mname.Text.Length = 0 Then
                            ErrorProvider1.SetError(txtstud_mname, "Enter student middle name")
                            MessageBox.Show("Enter Stdent middle name ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtstud_mname.Focus()
                        Else
                            If txtc_id.Text = "" Then
                                ErrorProvider1.SetError(txtc_id, "Enter Course id`")
                                MessageBox.Show("Enetr Course id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtc_id.Focus()
                            Else
                                If txtc_name.Text = "" Then
                                    ErrorProvider1.SetError(txtc_name, "Enter Course name`")
                                    MessageBox.Show("Enetr Course name!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtc_name.Focus()
                                Else
                                    If txttotal_fee.Text = "" Then
                                        ErrorProvider1.SetError(txttotal_fee, "Enter Total feee")
                                        MessageBox.Show("Enetr NewsPaper Quantity!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txttotal_fee.Focus()
                                    Else
                                        If txtamt_pay.Text = "" Then
                                            ErrorProvider1.SetError(txtamt_pay, "Enter paid amount ")
                                            MessageBox.Show("Enetr paid amount!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtamt_pay.Focus()
                                        Else
                                            If txt_remaning.Text = "" Then
                                                ErrorProvider1.SetError(txt_remaning, "Enter remaining amount")
                                                MessageBox.Show("Enetr remaining amount!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txt_remaning.Focus()
                                            Else
                                                If txt_install.Text = "" Then
                                                    ErrorProvider1.SetError(txt_install, "Enter `Installment")
                                                    MessageBox.Show("Enetr Installment!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    txt_install.Focus()
                                                Else
                                                    If txt_amount.Text = "" Then
                                                        ErrorProvider1.SetError(txt_amount, "Enter Total amount`")
                                                        MessageBox.Show("Enetr Total amount!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        txt_amount.Focus()
                                                    Else
                                                        If txt_bal.Text = "" Then
                                                            ErrorProvider1.SetError(txt_bal, "Enter balance`")
                                                            MessageBox.Show("Enetr balance!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            txt_bal.Focus()
                                                        Else
                                                            str = "update Installment_details set stud_id=" & txtstud_id.Text & ",stud_lname='" & txtstud_lname.Text & "',stud_fname='" & txtstud_fname.Text & "',stud_mname='" & txtstud_mname.Text & "',c_id=" & txtc_id.Text & ",c_name='" & txtc_name.Text & "',total_fee=" & txttotal_fee.Text & ",amt_paid=" & txtamt_pay.Text & ",remaining_amt=" & txt_remaning.Text & ",amount=" & txt_amount.Text & ",installment=" & txt_install.Text & ",total_amt=" & txt_amount.Text & ",balance=" & txt_bal.Text & " where stud_id=" & txtstud_id.Text & ""
                                                            con.Open()
                                                            cmd = New SqlCommand(str, con)
                                                            cmd.ExecuteNonQuery()
                                                            MessageBox.Show("Record Updated successfully ")
                                                            con.Close()
                                                            'Call clearfields()
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

    
    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        str = "Delete from Installment_details where stud_id=" & txtstud_id.Text & ""
        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted successfully ")
        con.Close()
        Call clearfields()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub txt_amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
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

    Private Sub txt_install_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_install.KeyPress
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
End Class