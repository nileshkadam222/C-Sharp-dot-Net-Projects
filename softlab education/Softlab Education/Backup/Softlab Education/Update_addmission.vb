Imports System.Data
Imports System.Data.SqlClient
Public Class Update_addmission
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
        cmbstud_id.Text = ""
        txtstud_fname.Text = ""
        txtstud_mname.Text = ""
        txtstud_lname.Text = ""
        txttotal_fee.Text = ""
        cbofee_detail.Text = ""
        txtadvance.Text = ""
        txtbalance.Text = ""
        cmbc_id.Text = ""
        txtc_name.Text = ""
        cmbb_id.Text = ""
        txtb_name.Text = ""
        txtstud_age.Text = ""
        dtp.Text = ""
    End Sub

    Public Sub EnaableScheduleField()
        cmbstud_id.Enabled = True
        txtstud_fname.Enabled = True
        txtstud_age.Enabled = True
        txtstud_mname.Enabled = True
        txtstud_lname.Enabled = True
        txttotal_fee.Enabled = True
        cbofee_detail.Enabled = True
        txtadvance.Enabled = True
        txtbalance.Enabled = True
        cmbc_id.Enabled = True
        txtc_name.Enabled = True
        cmbb_id.Enabled = True
        txtb_name.Enabled = True
        dtp.Enabled = True

    End Sub
    Public Sub disablefields()
        cmbstud_id.Enabled = False
        txtstud_fname.Enabled = False
        txtstud_age.Enabled = False
        txtstud_mname.Enabled = False
        txtstud_lname.Enabled = False
        txttotal_fee.Enabled = False
        cbofee_detail.Enabled = False
        txtadvance.Enabled = False
        txtbalance.Enabled = False
        txtc_name.Enabled = False
        cmbb_id.Enabled = False
        txtb_name.Enabled = False
        dtp.Enabled = False

    End Sub


#End Region

    Private Sub Update_addmission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Search_addmission.cmb_search_by.Text = "Student_Name") Then
            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds1 As New DataSet
            str1 = "select * from addmission where stud_lname='" & Search_addmission.cmb_stud_name.Text & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds1, "addmission")
            con.Open()
            Dim dt1 As New DataTable
            da.Fill(dt1)
            con.Close()
            For Each row As DataRow In ds1.Tables("addmission").Rows
                If row(3).ToString = Search_addmission.cmb_stud_name.Text Then
                    cmbstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtstud_age.Text = row("stud_age").ToString()
                    cbo_gen.Text = row("stud_gen").ToString()
                    txttotal_fee.Text = row("stud_tfee").ToString()
                    cbofee_detail.Text = row("stud_pfee").ToString()
                    txtadvance.Text = row("stud_advance").ToString()
                    txtbalance.Text = row("stud_bal").ToString()
                    cmbb_id.Text = row("batch_id").ToString()
                    txtb_name.Text = row("batch_name").ToString()
                    dtp.Text = row("batch_time").ToString()
                    cmbc_id.Text = row("cou_id").ToString()
                    txtc_name.Text = row("cou_name").ToString()
                End If
            Next
        Else

            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from addmission where stud_id=" & Search_addmission.cmb_stud_id.Text & ""
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "addmission")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("addmission").Rows
                If row(0).ToString = Search_addmission.cmb_stud_id.Text Then
                    cmbstud_id.Text = row("stud_id").ToString()
                    txtstud_lname.Text = row("stud_lname").ToString()
                    txtstud_fname.Text = row("stud_fname").ToString()
                    txtstud_mname.Text = row("stud_mname").ToString()
                    txtstud_age.Text = row("stud_age").ToString()
                    cbo_gen.Text = row("stud_gen").ToString()
                    txttotal_fee.Text = row("stud_tfee").ToString()
                    cbofee_detail.Text = row("stud_pfee").ToString()
                    txtadvance.Text = row("stud_advance").ToString()
                    txtbalance.Text = row("stud_bal").ToString()
                    cmbb_id.Text = row("batch_id").ToString()
                    txtb_name.Text = row("batch_name").ToString()
                    dtp.Text = row("batch_time").ToString()
                    cmbc_id.Text = row("cou_id").ToString()
                    txtc_name.Text = row("cou_name").ToString()
                End If
            Next
        End If
    End Sub

    
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If (btnedit.Text = "&Edit") Then
            Call EnaableScheduleField()
            btnedit.Text = "&Update"
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

                            If txttotal_fee.Text = "" Then
                                ErrorProvider1.SetError(txttotal_fee, "Enter the Totle Fee")
                                MessageBox.Show("Enter the Totle Fee", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txttotal_fee.Focus()
                            Else
                                If cbofee_detail.Text = "" Then
                                    ErrorProvider1.SetError(cbofee_detail, "Enter the Installment details")
                                    MessageBox.Show("Enter the Installment details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    cbofee_detail.Focus()

                                Else
                                    If txtadvance.Text = "" Then
                                        ErrorProvider1.SetError(txtadvance, "Enter the Advance details")
                                        MessageBox.Show("Enter the Advance details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtadvance.Focus()
                                    Else
                                        If txtbalance.Text = "" Then
                                            ErrorProvider1.SetError(txtbalance, "Enter the Balence details")
                                            MessageBox.Show("Enter the Balence details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtbalance.Focus()
                                        Else
                                            If cmbb_id.Text.Length = 0 Then
                                                ErrorProvider1.SetError(cmbb_id, "Enter Batch id")
                                                MessageBox.Show("Enetr batch Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                cmbb_id.Focus()
                                            Else
                                                If txtb_name.Text.Length = 0 Then
                                                    ErrorProvider1.SetError(txtb_name, "Enter batch name")
                                                    MessageBox.Show("Enter batch name ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    txtb_name.Focus()
                                                Else
                                                    If dtp.Text = "" Then
                                                        ErrorProvider1.SetError(dtp, "Enter batch time")
                                                        MessageBox.Show("Enetr batch time!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        dtp.Focus()
                                                    Else
                                                        If cmbc_id.Text = "" Then
                                                            ErrorProvider1.SetError(cmbc_id, "Enter the Course Id")
                                                            MessageBox.Show("Enter the Course Id", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            cmbc_id.Focus()
                                                        Else
                                                            If txtc_name.Text = "" Then
                                                                ErrorProvider1.SetError(txtc_name, "Enter the Course name")
                                                                MessageBox.Show("Enter the Course name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                txtc_name.Focus()
                                                            Else
                                                                str = "update addmission set stud_fname='" & txtstud_fname.Text & "',stud_mname='" & txtstud_mname.Text & "',stud_lname='" & txtstud_lname.Text & "',stud_age=" & txtstud_age.Text & ",stud_gen='" & cbo_gen.Text & "',stud_tfee=" & txttotal_fee.Text & ",stud_pfee='" & cbofee_detail.Text & "',stud_advance=" & txtadvance.Text & ",stud_bal=" & txtbalance.Text & ",batch_id=" & cmbb_id.Text & ",batch_name='" & txtb_name.Text & "',batch_time='" & CDate(dtp.Text) & "',cou_id=" & cmbc_id.Text & ",cou_name='" & txtc_name.Text & "' where stud_id=" & cmbstud_id.Text & ""
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
        End If
    End Sub

    Private Sub cmbb_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbb_id.SelectedIndexChanged
        str = "select * from batch_details  where batch_id='" & cmbb_id.Text & "'"
        adp1 = New SqlDataAdapter(str, con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim s As String
        s = cmbb_id.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows()
            If s = dr.Item("batch_id").ToString Then
                txtb_name.Text = dr.Item("batch_name")
                dtp.Text = dr.Item("batch_time")
            End If
        Next
    End Sub

    Private Sub cmbc_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbc_id.SelectedIndexChanged
        str = "select * from Course_Details  where Course_ID='" & cmbc_id.Text & "'"
        adp1 = New SqlDataAdapter(str, con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim s As String
        s = cmbc_id.SelectedItem.ToString
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows()
            If s = dr.Item("Course_ID").ToString Then
                txtc_name.Text = dr.Item("Course_Name")

            End If
        Next
    End Sub

    Private Sub batch_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batch_delete.Click
        str = "Delete from addmission where stud_id=" & cmbstud_id.Text & ""
        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted successfully ")
        con.Close()
        Call clearfields()
    End Sub

    Private Sub cmbstud_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstud_id.SelectedIndexChanged
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

    Private Sub cbofee_detail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofee_detail.SelectedIndexChanged
        If cbofee_detail.Text = "Full" Then
            txtadvance.Enabled = False
            txtbalance.Enabled = False
        Else
            txtadvance.Enabled = True
            txtbalance.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class