Imports System.Data
Imports System.Data.SqlClient
Public Class subject_details
    'Dim da As New SqlDataAdapter
    'Dim cmd As New SqlCommand
    'Dim con As New SqlConnection
    'Dim str, str1 As String
    'Dim dt As New DataTable
    'Dim ds As New DataSet
    'Dim dv As New DataView
    'Dim dr As SqlDataReader
    'Dim i As Integer
    Public Sub GenerateId()
        Dim cmd As New SqlCommand("Select * from cou_details", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtc_id.Text = dr(0)
        End While
        txtc_id.Text = Val(txtc_id.Text) + 1
        dr.Close()
        con.Close()
    End Sub
    Public Sub EnaableScheduleField()
        txtc_id.Enabled = True
        txtc_name.Enabled = True

        txtsub_name.Enabled = True
    End Sub
    Public Sub DisableScheduleField()
        txtc_id.Enabled = False
        txtc_name.Enabled = False

        txtsub_name.Enabled = False
    End Sub
   
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If (btnadd.Text = "&ADD") Then
            Call GenerateId()
            Call EnaableScheduleField()
            btnadd.Text = "&Save"
        Else
            If txtc_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtc_id, "Select the Id of the Course")
                MessageBox.Show("Enter the Id  of the Cource!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtc_id.Focus()
            Else
                If txtc_name.Text = "" Then
                    ErrorProvider1.SetError(txtc_name, "Enter the Stream ")
                    MessageBox.Show("Enter the Stream!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtc_name.Focus()
                Else
                    'If cmbyear.Text = "" Then
                    '    ErrorProvider1.SetError(cmbyear, "Select the Year")
                    '    MessageBox.Show("Enter the Middle Name of the Employee", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    cmbyear.Focus()


                    If txtsub_name.Text = "" Then
                        ErrorProvider1.SetError(txtsub_name, "Select the Name of the Subject")
                        MessageBox.Show("Select the Name of the Subject", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtsub_name.Focus()
                    Else
                        str = "insert into cou_details values(" & txtc_id.Text & ",' " & txtc_name.Text & " ',' " & txtsub_name.Text & " ')"
                        con.Open()
                        cmd = New SqlCommand(str, con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Record addedd successfully")
                        btnadd.Text = "&Add"
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub subject_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str = "Data Source=USER-PC\SQLEXPRESS08;Database=Softlab Education;Integrated Security=true;"
        'con = New SqlConnection(str)
        con.Open()
        cmd = New SqlCommand(str, con)
        'MessageBox.Show("connection successfull")
        con.Close()
        Call DisableScheduleField()

    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        txtc_id.Text = ""
        txtc_name.Text = ""
        'cmbyear.Text = ""
        txtsub_name.Text = ""
    End Sub

    
    'Private Sub txtsub_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsub_name.KeyPress
    '    If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
    '           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
    '           And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
    '           Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
    '        'Allowed space
    '        If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
    '            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
    '                MessageBox.Show("Please enter only Alphabets")
    '                e.Handled = True
    '            End If
    '        End If
    '    End If
    'End Sub

    
   
    Private Sub txtc_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtc_name.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
               Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
               And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
               Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                    MessageBox.Show("Please enter only Alphabets")
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtc_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtc_id.KeyPress

    End Sub

    Private Sub operation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles operation.Enter

    End Sub
End Class