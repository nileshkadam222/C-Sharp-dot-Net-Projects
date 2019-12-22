
Imports System.Data
Imports System.Data.SqlClient


Public Class batch_details
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim str As String

    Public Sub GenerateId()
        Dim cmd As New SqlCommand("Select * from batch_details", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtb_id.Text = dr(0)
        End While
        txtb_id.Text = Val(txtb_id.Text) + 1
        dr.Close()
        con.Close()
    End Sub
    Public Sub EnaableScheduleField()
        'txtb_id.Enabled = True
        txtb_name.Enabled = True
        cbob_capacity.Enabled = True
        dtp.Enabled = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (btn_add.Text = "&Add") Then
            Call GenerateId()
            Call EnaableScheduleField()
            btn_add.Text = "&Save"
        Else
            If txtb_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtb_id, "Enter the Batch Id")
                MessageBox.Show("Enter the the Batch Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtb_id.Focus()
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
                            str = "insert into batch_details values(" & txtb_id.Text & ",'" & txtb_name.Text & "'," & cbob_capacity.Text & ",'" & CDate(dtp.Text) & "');"
                            con.Open()
                            cmd = New SqlCommand(str, con)
                            cmd.ExecuteNonQuery()
                            con.Close()
                            MessageBox.Show("Record addedd successfully")
                            Call clearfield()
                            btn_add.Text = "&Add"
                        End If
                    End If
                    End If
                End If
            End If
    End Sub
    Private Sub batch_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)
        con.Close()
    End Sub
    Public Sub clearfield()
        txtb_name.Text = ""
        cbob_capacity.Text = ""
        dtp.Text = ""
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click

        Call clearfield()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

   
    Private Sub txtb_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtb_name.KeyPress
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