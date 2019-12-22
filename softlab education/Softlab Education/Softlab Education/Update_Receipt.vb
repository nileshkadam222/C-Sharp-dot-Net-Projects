
Imports System.Data
Imports System.Data.SqlClient
Public Class Update_Receipt
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
        txtamt_pay.Text = ""
        End Sub
    Public Sub EnaableScheduleField()
        txtstud_id.Enabled = True
        txtstud_lname.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_mname.Enabled = True
        txtc_id.Enabled = True
        txtc_name.Enabled = True
        txtamt_pay.Enabled = True

    End Sub
    Public Sub disablefields()
        txtstud_id.Enabled = False
        txtstud_lname.Enabled = False
        txtstud_fname.Enabled = False
        txtstud_mname.Enabled = False
        txtc_id.Enabled = False
        txtc_name.Enabled = False
        txtamt_pay.Enabled = False
        

    End Sub


#End Region
    Private Sub Update_Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Search_Receipt.cmb_search_by.Text = "Student_Name") Then
            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from Receipt_datails where stud_lname='" & Search_Receipt.cmb_stud_name.Text & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Receipt_datails")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Receipt_datails").Rows
                If row(1).ToString = Search_Receipt.cmb_stud_name.Text Then
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtc_id.Text = row("c_id").ToString()
                    txtc_name.Text = row("c_name").ToString()
                    txtamt_pay.Text = row("amt_pay").ToString()
                    Exit For
                End If
            Next
        Else
            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from Receipt_datails where stud_id=" & Search_Receipt.cmb_stud_id.Text & ""
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Receipt_datails")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Receipt_datails").Rows
                If row(0).ToString = Search_Receipt.cmb_stud_id.Text Then
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtc_id.Text = row("c_id").ToString()
                    txtc_name.Text = row("c_name").ToString()
                    txtamt_pay.Text = row("amt_pay").ToString()
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
                ErrorProvider1.SetError(txtstud_id, "Enter the Student Id")
                MessageBox.Show("Enter the the Student Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtstud_id.Focus()
            Else
                If txtstud_fname.Text = "" Then
                    ErrorProvider1.SetError(txtstud_fname, "Enter the Frist Name of the Student ")
                    MessageBox.Show("Enter the Frist Name of the Student!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtstud_fname.Focus()
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
                                    If txtamt_pay.Text = "" Then
                                        ErrorProvider1.SetError(txtc_name, "Enter the amount details")
                                        MessageBox.Show("Enter the amount details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtamt_pay.Focus()
                                    Else

                                        str = "update Receipt_datails set stud_id=" & txtstud_id.Text & ",stud_lname='" & txtstud_lname.Text & "',stud_fname='" & txtstud_fname.Text & "',stud_mname='" & txtstud_mname.Text & "',c_id=" & txtc_id.Text & ",c_name='" & txtc_name.Text & "',amt_pay=" & txtamt_pay.Text & " where stud_id=" & txtstud_id.Text & ""
                                        con.Open()
                                        cmd = New SqlCommand(str, con)
                                        cmd.ExecuteNonQuery()
                                        MessageBox.Show("Record addedd successfully")
                                        con.Close()
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
        str = "Delete from Receipt_datails where stud_id=" & txtstud_id.Text & ""
        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted successfully ")
        con.Close()
        Call clearfields()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub txtamt_pay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt_pay.KeyPress
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
End Class