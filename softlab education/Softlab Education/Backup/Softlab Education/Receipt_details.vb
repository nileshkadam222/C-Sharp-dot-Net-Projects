
Imports System.Data
Imports System.Data.SqlClient
Public Class Receipt_details
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String
    'Dim adp1 As New SqlDataAdapter
    'Dim ds1 As New DataSet

    'Public Sub GenerateId()
    '    Dim cmd As New SqlCommand("Select * from Receipt_datails", con)
    '    con.Open()
    '    Dim dr As SqlDataReader = cmd.ExecuteReader
    '    While dr.Read
    '        cbo_studid.Text = dr(0)
    '    End While
    '    cbo_studid.Text = Val(cbo_studid.Text) + 1
    '    dr.Close()
    '    con.Close()
    'End Sub
    Public Sub EnaableScheduleField()
        cbo_studid.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_mname.Enabled = True
        txtstud_lname.Enabled = True
        txtc_id.Enabled = True
        txtc_name.Enabled = True
        txtamt_pay.Enabled = True
        txtbalence.Enabled = True
        txttotle.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (btn_add.Text = "&Add") Then
            'Call GenerateId()
            Call EnaableScheduleField()
            btn_add.Text = "&Save"
        Else
            If cbo_studid.Text = "" Then
                ErrorProvider1.SetError(cbo_studid, "Enter the Student Id")
                MessageBox.Show("Enter the the Student Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbo_studid.Focus()
            Else
                If txtstud_fname.Text.Length = 0 Then
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
                                        If txtbalence.Text = "" Then
                                            ErrorProvider1.SetError(txtbalence, "Enter the balence details")
                                            MessageBox.Show("Enter the balence details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtbalence.Focus()
                                        Else


                                            str = "insert into Receipt_datails values(" & cbo_studid.Text & ",'" & txtstud_lname.Text & "','" & txtstud_fname.Text & "','" & txtstud_mname.Text & "'," & txtc_id.Text & ",'" & txtc_name.Text & "'," & txtamt_pay.Text & "," & txtbalence.Text & "," & txttotle.Text & ");"
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


    End Sub

    Private Sub Recipt_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)

        con.Close()

    End Sub

    Private Sub cbo_studid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_studid.SelectedIndexChanged
        str = "select * from Installment_details where stud_id='" & cbo_studid.Text & "'"
        adp1 = New SqlDataAdapter(str, con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim s As String
        s = cbo_studid.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows()
            If s = dr.Item("stud_id").ToString Then
                txtstud_lname.Text = dr.Item("stud_lname")
                txtstud_fname.Text = dr.Item("stud_fname")
                txtstud_mname.Text = dr.Item("stud_mname")
                txtc_id.Text = dr.Item("c_id")
                txtc_name.Text = dr.Item("c_name")
                txtamt_pay.Text = dr.Item("amount")
                txtbalence.Text = dr.Item("balance")
                txttotle.Text = dr.Item("total_fee")

            End If
        Next
    End Sub

    Public Sub clearField()
        txtstud_fname.Text = ""
        txtstud_mname.Text = ""
        txtstud_lname.Text = ""
        txtc_id.Text = ""
        txtc_name.Text = ""
        txtamt_pay.Text = ""
        txtbalence.Text = ""
        txttotle.Text = ""
    End Sub
    Private Sub btn_clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clr.Click

        
        Call clearField()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
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

    Private Sub txtbalence_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbalence.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    
    Private Sub txttotle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotle.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub
End Class