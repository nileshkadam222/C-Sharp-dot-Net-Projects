Imports System.Data
Imports System.Data.SqlClient

Public Class Result_details
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String

    Public Sub GenerateId()
        Dim cmd As New SqlCommand("Select * from Result_details", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtt_id.Text = dr(0)
        End While
        txtt_id.Text = Val(txtt_id.Text) + 1
        dr.Close()
        con.Close()
    End Sub
    Public Sub EnaableScheduleField()
        txtt_id.Enabled = True
        cbo_str.Enabled = True
        'txtstud_id.Enabled = True
        txtstud_lname.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_lname.Enabled = True
        txtsub_name.Enabled = True
        txt_mark.Enabled = True
        
    End Sub



    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (btn_add.Text = "&Add") Then
            Call GenerateId()
            Call EnaableScheduleField()
            btn_add.Text = "&Save"
        Else
            If txtt_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtt_id, "Enter the Test details ")
                MessageBox.Show("Enter the Test details!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtt_id.Focus()

            Else
                If cbo_str.Text.Length = 0 Then
                    ErrorProvider1.SetError(cbo_str, "Enter the stream details ")
                    MessageBox.Show("Enter the stream details!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbo_str.Focus()
                Else

                    If std_id.Text = "" Then
                        ErrorProvider1.SetError(std_id, "Select the Student Id")
                        MessageBox.Show("Select the the Student Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        std_id.Focus()
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
                                            str = "insert into Result_details values(" & txtt_id.Text & ",'" & cbo_str.Text & "'," & std_id.Text & ",'" & txtstud_lname.Text & "','" & txtstud_fname.Text & "','" & txtstud_mname.Text & "','" & txtsub_name.Text & "'," & txt_mark.Text & ");"
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

    Private Sub Result_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        adp1 = New SqlDataAdapter("select * from Resgistration_details", con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim dt As DataRow
        For Each dt In ds1.Tables(0).Rows()
            std_id.Items.Add(dt.Item("stud_id"))
        Next

        adp3 = New SqlDataAdapter("select * from Course_Details ", con)
        ds3 = New DataSet
        adp3.Fill(ds3)
        Dim dt2 As DataRow
        For Each dt2 In ds3.Tables(0).Rows()
            cbo_str.Items.Add(dt2.Item("Course_Name"))
        Next
    End Sub


    Public Sub clearField()

        cbo_str.Text = ""
        std_id.Text = ""
        txtstud_mname.Text = ""
        txtstud_fname.Text = ""
        txtstud_lname.Text = ""
        txtsub_name.Text = ""
        txt_mark.Text = ""
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

    Private Sub std_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles std_id.SelectedIndexChanged
        str = "select * from Resgistration_details  where stud_id='" & std_id.Text & "'"
        adp1 = New SqlDataAdapter(str, con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim s As String
        s = std_id.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows()
            If s = dr.Item("stud_id").ToString Then
                txtstud_fname.Text = dr.Item("stud_fname")
                txtstud_lname.Text = dr.Item("stud_lname")
                txtstud_mname.Text = dr.Item("stud_mname")
            End If
        Next
    End Sub

    Private Sub cbo_str_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_str.SelectedIndexChanged
        str = "select * from Course_Details  where Course_Name='" & cbo_str.Text & "'"
        adp3 = New SqlDataAdapter(str, con)
        ds3 = New DataSet
        adp3.Fill(ds3)
        Dim s As String
        s = cbo_str.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds3.Tables(0).Rows()
            If s = dr.Item("Course_Name").ToString Then
                txtsub_name.Text = dr.Item("Sub_Name")
            End If
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clearField()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class