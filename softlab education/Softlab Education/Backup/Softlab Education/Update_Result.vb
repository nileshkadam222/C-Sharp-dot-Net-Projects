Imports System.Data
Imports System.Data.SqlClient

Public Class Update_Result
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
        txtt_id.Text = ""
        cbo_str.Text = ""
        txtstud_id.Text = ""
        txtstud_lname.Text = ""
        txtstud_fname.Text = ""
        txtstud_mname.Text = ""
        txtsub_name.Text = ""
        txt_mark.Text = ""

    End Sub
    Public Sub EnaableScheduleField()
        txtt_id.Enabled = True
        cbo_str.Enabled = True
        txtstud_id.Enabled = True
        txtstud_lname.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_mname.Enabled = True
        txtsub_name.Enabled = True
        txt_mark.Enabled = True

    End Sub
    Public Sub disablefields()
        txtt_id.Enabled = False
        cbo_str.Enabled = False
        txtstud_id.Enabled = False
        txtstud_lname.Enabled = False
        txtstud_fname.Enabled = False
        txtstud_mname.Enabled = False
        txtsub_name.Enabled = False
        txt_mark.Enabled = False

    End Sub


#End Region

    Private Sub Update_Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Search_Result.cmb_search_by.Text = "Stream_Name") Then

            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds1 As New DataSet
            str1 = "select * from Result_details where stream_name='" & Search_Result.cmb_name.Text & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds1, "Result_details")
            con.Open()
            Dim dt1 As New DataTable
            da.Fill(dt1)
            con.Close()
            For Each row As DataRow In ds1.Tables("Result_details").Rows
                If row(1).ToString = Search_Result.cmb_name.Text Then
                    txtt_id.Text = row("test_id").ToString()
                    cbo_str.Text = row("stream_name").ToString()
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtsub_name.Text = row("sub_name").ToString()
                    txt_mark.Text = row("stud_marks").ToString()
                    Exit For
                End If
            Next
        End If

        If (Search_Result.cmb_search_by.Text = "Test_Id") Then

            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from Result_details where test_id=" & Search_Result.cmb_id.Text & ""
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "Result_details")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("Result_details").Rows
                If row(0).ToString = Search_Result.cmb_id.Text Then
                    txtt_id.Text = row("test_id").ToString()
                    cbo_str.Text = row("stream_name").ToString()
                    txtstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtsub_name.Text = row("sub_name").ToString()
                    txt_mark.Text = row("stud_marks").ToString()
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
            If txtt_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtt_id, "Enter the Test details ")
                MessageBox.Show("Enter the Test details!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtt_id.Focus()

            Else
                If cbo_str.Text = "" Then
                    ErrorProvider1.SetError(cbo_str, "Enter the stream details ")
                    MessageBox.Show("Enter the stream details!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbo_str.Focus()
                Else

                    If txtstud_id.Text.Length = 0 Then
                        ErrorProvider1.SetError(txtstud_id, "Enter the Student Id")
                        MessageBox.Show("Enter the the Student Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstud_id.Focus()
                    Else
                        If txtstud_lname.Text.Length = 0 Then
                            ErrorProvider1.SetError(txtstud_fname, "Enter the Last Name of the Student ")
                            MessageBox.Show("Enter the Last Name of the Student!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtstud_lname.Focus()
                        Else
                            If txtstud_fname.Text = "" Then
                                ErrorProvider1.SetError(txtstud_mname, "Enter the First Name of the Student")
                                MessageBox.Show("Enter the First Name of the Student", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtstud_fname.Focus()
                            Else
                                If txtstud_mname.Text = "" Then
                                    ErrorProvider1.SetError(txtstud_mname, "Enter the Middle Name of the Student ")
                                    MessageBox.Show("Enter the last Name of the Student ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtstud_mname.Focus()
                                Else
                                    If txtsub_name.Text = "" Then
                                        ErrorProvider1.SetError(txtsub_name, "Enter the subject details")
                                        MessageBox.Show("Enter the subject details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtsub_name.Focus()
                                    Else
                                        If txt_mark.Text = "" Then
                                            ErrorProvider1.SetError(txt_mark, "Enter the mark details")
                                            MessageBox.Show("Enter the mark details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txt_mark.Focus()
                                        Else
                                            str = "update Result_details set test_id=" & txtt_id.Text & ",stream_name='" & cbo_str.Text & "',stud_id=" & txtstud_id.Text & ",stud_lname='" & txtstud_lname.Text & "',stud_fname='" & txtstud_fname.Text & "',stud_mname='" & txtstud_mname.Text & "',sub_name='" & txtsub_name.Text & "',stud_marks=" & txt_mark.Text & " where test_id=" & txtt_id.Text & ""
                                            con.Open()
                                            cmd = New SqlCommand(str, con)
                                            cmd.ExecuteNonQuery()
                                            con.Close()
                                            MessageBox.Show("Record addedd successfully")
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
        str = "Delete from Result_details where test_id=" & txtt_id.Text & ""
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

    
    Private Sub txtt_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtt_id.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If

    End Sub



    Private Sub txt_mark_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mark.KeyPress
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

    Private Sub txtsub_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsub_name.KeyPress
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