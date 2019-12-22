
Imports System.Data
Imports System.Data.SqlClient


Public Class arrenge_shedule
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String
    'Dim adp1 As New SqlDataAdapter
    'Dim ds1 As New DataSet
    Public Sub GenerateId()
        'Dim cmd As New SqlCommand("Select * from batch_details", con)
        'con.Open()
        'Dim dr As SqlDataReader = cmd.ExecuteReader
        'While dr.Read
        '    txtb_id.Text = dr(0)
        'End While
        'txtb_id.Text = Val(txtb_id.Text) + 1
        'dr.Close()
        'con.Close()
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
        cbob_capacity.Enabled = True
        dtp.Enabled = True

    End Sub
    Public Sub DisableScheduleField()
        cmbfac_id.Enabled = False
        txtfname.Enabled = False
        txtmname.Enabled = False
        txtlname.Enabled = False
        cmbgender.Enabled = False
        txtno.Enabled = False
        cmbbatch_id.Enabled = False
        txtb_name.Enabled = False
        cbob_capacity.Enabled = False
        dtp.Enabled = False

    End Sub
   

    
    Private Sub cmbfac_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfac_id.SelectedIndexChanged

        Dim s As String
        s = cmbfac_id.SelectedItem.ToString
        Dim dt As DataRow
        For Each dt In ds1.Tables(0).Rows()
            If s = dt.Item("f_id").ToString Then
                txtlname.Text = dt.Item("l_name")
                txtfname.Text = dt.Item("f_name")
                txtmname.Text = dt.Item("m_name")
                cmbgender.Text = dt.Item("f_gen")
                txtno.Text = dt.Item("f_contact")
            End If
        Next
    End Sub

    Private Sub cmbbatch_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbatch_id.SelectedIndexChanged
        Dim s As String
        s = cmbbatch_id.SelectedItem.ToString
        Dim dt As DataRow
        For Each dt In ds2.Tables(0).Rows()
            If s = dt.Item("batch_id").ToString Then
                txtb_name.Text = dt.Item("batch_name")
                cbob_capacity.Text = dt.Item("batch_capacity")
                dtp.Text = dt.Item("batch_time")

            End If
        Next
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (btn_add.Text = "&Add") Then
            Call GenerateId()
            Call EnaableScheduleField()
            btn_add.Text = "&Save"
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
                                                    str = "insert into arrenge_shedule values(" & cmbbatch_id.Text & ",'" & txtb_name.Text & "'," & cbob_capacity.Text & ",'" & CDate(dtp.Text) & "'," & cmbfac_id.Text & ",'" & txtlname.Text & "','" & txtfname.Text & "','" & txtmname.Text & "','" & cmbgender.Text & "'," & txtno.Text & ")"
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
End Sub

    
   
   
    Private Sub arrenge_shedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)

        con.Open()
        cmd = New SqlCommand(str, con)
        'MessageBox.Show("connection successfull")
        con.Close()
        'Call DisableScheduleField()
        adp1 = New SqlDataAdapter("select * from Faculty_details", con)
        ds1 = New DataSet
        adp1.Fill(ds1)
        Dim dt1 As DataRow
        For Each dt1 In ds1.Tables(0).Rows()
            cmbfac_id.Items.Add(dt1.Item("f_id"))
        Next

        adp2 = New SqlDataAdapter("select * from batch_details", con)
        ds2 = New DataSet
        adp2.Fill(ds2)
        Dim dt2 As DataRow
        For Each dt2 In ds2.Tables(0).Rows()
            cmbbatch_id.Items.Add(dt2.Item("batch_id"))
        Next
    End Sub

    Public Sub clearField()
        txtfname.Text = ""
        txtmname.Text = ""
        txtlname.Text = ""
        cmbgender.Text = ""
        txtno.Text = ""
        cmbbatch_id.Text = ""
        txtb_name.Text = ""
        cbob_capacity.Text = ""
        dtp.Text = ""
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click

        Call clearField()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class