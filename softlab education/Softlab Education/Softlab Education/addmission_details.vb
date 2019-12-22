Imports System.Data
Imports System.Data.SqlClient
Public Class addmission_details
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String
    'Dim adp1 As New SqlDataAdapter
    'Dim ds1 As New DataSet

    Public Sub GenerateId()
        'Dim cmd As New SqlCommand("Select * from cou_details", con)
        'con.Open()
        'Dim dr As SqlDataReader = cmd.ExecuteReader
        'While dr.Read
        '    _id.Text = dr(0)
        'End While
        'txtstud_id.Text = Val(txtstud_id.Text) + 1
        'dr.Close()
        'con.Close()
    End Sub
    Public Sub EnaableScheduleField()
        cmbstud_id.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_mname.Enabled = True
        txtstud_lname.Enabled = True
        cbo_gen.Enabled = True
        txtstud_age.Enabled = True
        txttotal_fee.Enabled = True
        cbofee_detail.Enabled = True
        txtadvance.Enabled = True
        txtbalance.Enabled = True
        cmbc_id.Enabled = True
        txtb_name.Enabled = True
        dtp.Enabled = True
        cmbc_id.Enabled = True
        txtc_name.Enabled = True
        txttotal_fee.Enabled = True
        cbofee_detail.Enabled = True
    End Sub
    Public Sub DisableScheduleField()
        cmbstud_id.Enabled = False
        txtstud_fname.Enabled = False
        txtstud_mname.Enabled = False
        txtstud_lname.Enabled = False
        cbo_gen.Enabled = False
        txtstud_age.Enabled = False
        txttotal_fee.Enabled = False
        cbofee_detail.Enabled = False
        txtadvance.Enabled = False
        txtbalance.Enabled = False
        cmbc_id.Enabled = False
        txtb_name.Enabled = False
        dtp.Enabled = False
        cmbc_id.Enabled = False
        txtc_name.Enabled = False
        txttotal_fee.Enabled = False
        cbofee_detail.Enabled = False
    End Sub
   
    Public Sub clearField()
        cmbstud_id.Text = ""
        txtstud_fname.Text = ""
        txtstud_mname.Text = ""
        txtstud_lname.Text = ""
        cmbc_id.Text = ""
        txtc_name.Text = ""
        txttotal_fee.Text = ""
        cbofee_detail.Text = ""
        txtadvance.Text = ""
        txtbalance.Text = ""
        cmbb_id.Text = ""
        txtb_name.Text = ""
        txtstud_age.Text = ""
        cbo_gen.Text = ""
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If (btnadd.Text = "&Add") Then
            Call GenerateId()
            Call EnaableScheduleField()
            btnadd.Text = "&Save"
        Else
            If cmbstud_id.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbstud_id, "Enter the Student Id")
                MessageBox.Show("Enter the the Student Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbstud_id.Focus()
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
                            If txtstud_age.Text = "" Then
                                ErrorProvider1.SetError(txtstud_age, "Enter the age ` of the Student ")
                                MessageBox.Show("Enter the age of the Student ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtstud_age.Focus()
                            Else
                                If cbo_gen.Text = "" Then
                                    ErrorProvider1.SetError(cbo_gen, "Enter the gender of the Student ")
                                    MessageBox.Show("Enter the gender of the Student ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    cbo_gen.Focus()
                                Else
                                    If txttotal_fee.Text = "" Then
                                        ErrorProvider1.SetError(txttotal_fee, "Enter the total fee of the Student ")
                                        MessageBox.Show("Enter the Total fee of the Student ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        cbo_gen.Focus()
                                    Else
                                        If cbofee_detail.Text = "" Then
                                            ErrorProvider1.SetError(cbofee_detail, "Enter the payment of the fees ")
                                            MessageBox.Show("Enter the payment of the fees ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            cbofee_detail.Focus()
                                        Else
                                            If txtadvance.Text = "" Then
                                                ErrorProvider1.SetError(txtadvance, "Enter the advannce ")
                                                MessageBox.Show("Enter the advance ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txtadvance.Focus()
                                            Else
                                                If txtbalance.Text = "" Then
                                                    ErrorProvider1.SetError(txtbalance, "Enter the balance")
                                                    MessageBox.Show("Enter the balance", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    txtbalance.Focus()
                                                Else
                                                    If cmbb_id.Text = "" Then
                                                        ErrorProvider1.SetError(cmbb_id, "Enter the batch id ")
                                                        MessageBox.Show("Enter the batch id", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        cmbb_id.Focus()
                                                    Else
                                                        If txtb_name.Text = "" Then
                                                            ErrorProvider1.SetError(txtb_name, "Enter the batch name ")
                                                            MessageBox.Show("Enter the batch name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            txtb_name.Focus()
                                                        Else
                                                            If dtp.Text = "" Then
                                                                ErrorProvider1.SetError(dtp, "Enter the batch time ")
                                                                MessageBox.Show("Enter the batch time", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                dtp.Focus()
                                                            Else
                                                                If cmbc_id.Text = "" Then
                                                                    ErrorProvider1.SetError(cmbc_id, "Enter the course id ")
                                                                    MessageBox.Show("Enter the course id", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                    cmbc_id.Focus()
                                                                Else
                                                                    If txtc_name.Text = "" Then
                                                                        ErrorProvider1.SetError(txtc_name, "Enter the course name` ")
                                                                        MessageBox.Show("Enter the course name ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                        txtc_name.Focus()
                                                                    Else
                                                                        str = "insert into addmission values(" & cmbstud_id.Text & ",'" & txtstud_fname.Text & "','" & txtstud_mname.Text & "','" & txtstud_lname.Text & "'," & txtstud_age.Text & ",'" & cbo_gen.Text & "'," & txttotal_fee.Text & ",'" & cbofee_detail.Text & "'," & txtadvance.Text & "," & txtbalance.Text & "," & cmbb_id.Text & ",'" & txtb_name.Text & "','" & CDate(dtp.Text) & "'," & cmbc_id.Text & ",'" & txtc_name.Text & "')"
                                                                        con.Open()
                                                                        cmd = New SqlCommand(str, con)
                                                                        cmd.ExecuteNonQuery()
                                                                        con.Close()
                                                                        MessageBox.Show("Record addedd successfully")
                                                                        Call clearField()
                                                                        btnadd.Text = "&Add"
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
            End If
        End If
        

    End Sub

    Private Sub addmission_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)
        'MessageBox.Show("connection successfull")
        con.Close()
        adp1 = New SqlDataAdapter("select * from Resgistration_details", con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim dt As DataRow
        For Each dt In ds1.Tables(0).Rows()
            cmbstud_id.Items.Add(dt.Item("stud_id"))
        Next

        adp2 = New SqlDataAdapter("select * from batch_details", con)
        ds2 = New DataSet
        adp2.Fill(ds2)
        Dim dt1 As DataRow
        For Each dt1 In ds2.Tables(0).Rows()
            cmbb_id.Items.Add(dt1.Item("batch_id"))
        Next

        adp3 = New SqlDataAdapter("select * from Course_Details ", con)
        ds3 = New DataSet
        adp3.Fill(ds3)
        Dim dt2 As DataRow
        For Each dt2 In ds3.Tables(0).Rows()
            cmbc_id.Items.Add(dt2.Item("Course_ID"))
        Next
        Call DisableScheduleField()
    End Sub
    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        Call clearField()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
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

    

    Private Sub txttotal_fee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotal_fee.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
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

    
    Private Sub txtc_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtc_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    
    Private Sub txtadvance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadvance.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbalance_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbalance.GotFocus
        txtbalance.Text = Val(txttotal_fee.Text) - Val(txtadvance.Text)
    End Sub

    Private Sub txtbalance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbalance.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MessageBox.Show("Please enter only digits")
                e.Handled = True
            End If
        End If
    End Sub
    

   

    Private Sub cmbstud_id_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstud_id.SelectedIndexChanged
        str = "select * from Resgistration_details  where stud_id='" & cmbstud_id.Text & "'"
        adp1 = New SqlDataAdapter(str, con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim s As String
        s = cmbstud_id.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows()
            If s = dr.Item("stud_id").ToString Then
                txtstud_fname.Text = dr.Item("stud_fname")
                txtstud_lname.Text = dr.Item("stud_lname")
                txtstud_mname.Text = dr.Item("stud_mname")
                cbo_gen.Text = dr.Item("stud_gen")
                txtstud_age.Text = dr.Item("stud_age")
                cbo_gen.Text = dr.Item("stud_gen")
            End If
        Next
    End Sub

    Private Sub txttotal_fee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal_fee.TextChanged

    End Sub

    Private Sub txtbalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbalance.TextChanged

    End Sub

    Private Sub cbofee_detail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofee_detail.SelectedIndexChanged
        If cbofee_detail.Text = "Full" Then
            txtadvance.Enabled = False
            txtbalance.Enabled = False
        Else
            txtadvance.Enabled = True
            txtbalance.Enabled = True
        End If
    End Sub

    Private Sub cmbb_id_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbb_id.SelectedIndexChanged
        str = "select * from batch_details  where batch_id='" & cmbb_id.Text & "'"
        adp2 = New SqlDataAdapter(str, con)
        ds2 = New DataSet
        adp2.Fill(ds2)
        Dim s As String
        s = cmbb_id.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds2.Tables(0).Rows()
            If s = dr.Item("batch_id").ToString Then
                txtb_name.Text = dr.Item("batch_name")
                dtp.Text = dr.Item("batch_time")
            End If
        Next
    End Sub

    Private Sub cmbc_id_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbc_id.SelectedIndexChanged
        str = "select * from Course_Details  where Course_ID='" & cmbc_id.Text & "'"
        adp3 = New SqlDataAdapter(str, con)
        ds3 = New DataSet
        adp3.Fill(ds3)
        Dim s As String
        s = cmbc_id.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds3.Tables(0).Rows()
            If s = dr.Item("Course_ID").ToString Then
                txtc_name.Text = dr.Item("Course_Name")
                txttotal_fee.Text = dr.Item("Total_Fees")
            End If
        Next
    End Sub

    
End Class