Imports System.Data
Imports System.Data.SqlClient
Public Class Update_arrange
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
        cmbfac_id.Text = ""
        txtfname.Text = ""
        txtmname.Text = ""
        txtlname.Text = ""
        cmbgender.Text = ""
        txtno.Text = ""
        cmbbatch_id.Text = ""
        txtb_name.Text = ""
        dtp.Text = ""
    End Sub
    Public Sub EnaableScheduleField()
        cmbfac_id.Enabled = True
        txtfname.Enabled = True
        txtmname.Enabled = True
        txtlname.Enabled = True
        cmbgender.Enabled = True
        txtno.Enabled = True
        cmbbatch_id.Enabled = True
        txtb_name.Enabled = True
        dtp.Enabled = True
    End Sub
    Public Sub disablefields()
        cmbfac_id.Enabled = False
        txtfname.Enabled = False
        txtmname.Enabled = False
        txtlname.Enabled = False
        cmbgender.Enabled = False
        txtno.Enabled = False
        cmbbatch_id.Enabled = False
        txtb_name.Enabled = False
        dtp.Enabled = False
    End Sub
#End Region



    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        str = "Delete from arrenge_shedule where batch_id=" & cmbfac_id.Text & ""
        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted successfully ")
        con.Close()
        Call clearfields()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Update_arrange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Search_arrange.cmb_search_by.Text = "Student_Name") Then

        End If

        Call disablefields()
        'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
        'con = New SqlConnection(str)
        cmd = New SqlCommand(str, con)
        Dim ds As New DataSet
        str1 = "select * from arrenge_shedule where batch_id=" & Search_arrange.cmb_stud_id.Text & ""
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(str1, con)
        da.Fill(ds, "arrenge_shedule")
        con.Open()
        Dim dt As New DataTable
        da.Fill(dt)
        con.Close()
        For Each row As DataRow In ds.Tables("arrenge_shedule").Rows
            If row(0).ToString = Search_arrange.cmb_stud_id.Text Then
                cmbbatch_id.Text = row("batch_id").ToString()
                txtb_name.Text = row("batch_name").ToString()
                cbob_capacity.Text = row("batch_capacity").ToString()
                dtp.Text = row("batch_time").ToString()
                cmbfac_id.Text = row("f_id").ToString()
                txtlname.Text = row("l_name").ToString()
                txtfname.Text = row("f_name").ToString()
                txtmname.Text = row("m_name").ToString()
                cmbgender.Text = row("f_gen").ToString()
                txtno.Text = row("f_contact").ToString()
                Exit For
            End If
        Next

    End Sub


    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "&Edit" Then
            Call EnaableScheduleField()
            btnedit.Text = "&Update"
        Else
            If cmbfac_id.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbfac_id, "Enter the Id of the Faculty")
                MessageBox.Show("Enter the Id  of the Faculty!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbfac_id.Focus()
            Else
                If txtlname.Text = "" Then
                    ErrorProvider1.SetError(txtlname, "Enter the Last Name of the Faculty ")
                    MessageBox.Show("Enter the last Name of the  Faculty ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtlname.Focus()

                Else
                    If txtfname.Text.Length = 0 Then
                        ErrorProvider1.SetError(txtfname, "Enter the Frist Name of the Faculty ")
                        MessageBox.Show("Enter the Frist Name of the Faculty!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtfname.Focus()
                    Else
                        If txtmname.Text = "" Then
                            ErrorProvider1.SetError(txtmname, "Enter the Middle Name of the Faculty")
                            MessageBox.Show("Enter the Middle Name of the  Faculty", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtmname.Focus()
                        Else
                            If cmbgender.Text = "" Then
                                ErrorProvider1.SetError(cmbgender, "Select the Gender")
                                MessageBox.Show("Select the Gender", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                cmbgender.Focus()

                            Else
                                If txtno.Text = "" Then
                                    ErrorProvider1.SetError(txtno, "Select the Gender")
                                    MessageBox.Show("Select the Gender", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    txtno.Focus()

                                Else
                                    If cmbbatch_id.Text.Length = 0 Then
                                        ErrorProvider1.SetError(cmbbatch_id, "Enter the Batch Id")
                                        MessageBox.Show("Enter the the Batch Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        cmbbatch_id.Focus()
                                    Else
                                        If txtb_name.Text.Length = 0 Then
                                            ErrorProvider1.SetError(txtb_name, "Enter the Batch Name  ")
                                            MessageBox.Show("Enter the Batch Name!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            txtb_name.Focus()
                                        Else
                                            If cbob_capacity.Text = "" Then
                                                ErrorProvider1.SetError(cbob_capacity, "Enter the Capacity of the Batch")
                                                MessageBox.Show("Enter the Capacity of the Batch", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                cbob_capacity.Focus()
                                            Else
                                                If dtp.Text = "" Then
                                                    ErrorProvider1.SetError(dtp, "Enter the Timing Of The Batch")
                                                    MessageBox.Show("Enter the Timing Of The Batch", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    dtp.Focus()
                                                Else
                                                    str = " update arrenge_shedule set batch_id(" & cmbbatch_id.Text & ",'" & txtfname.Text & "'," & CDate(dtp.Text) & "," & cmbgender.Text & "," & txtno.Text & ")"
                                                    con.Open()
                                                    cmd = New SqlCommand(str, con)
                                                    cmd.ExecuteNonQuery()
                                                    con.Close()
                                                    MessageBox.Show("Record addedd successfully")
                                                    btnedit.Text = "&Add"
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

    Private Sub txtno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtno.TextChanged

    End Sub

    Private Sub txtno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtno.Validated
        Try
            If txtno.Text.Length = 0 Then
                txtno.Text = Nothing
            ElseIf txtno.Text.Length <> 10 Then
                ErrorProvider1.SetError(txtno, "Invalid Mobile No. Please Enter 10 Digits")
                txtno.Focus()
                txtno.SelectAll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class