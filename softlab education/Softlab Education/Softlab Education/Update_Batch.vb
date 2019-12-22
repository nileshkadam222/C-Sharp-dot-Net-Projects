Imports System.Data
Imports System.Data.SqlClient
Public Class Update_Batch
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
        txtb_id.Text = ""
        txtb_name.Text = ""
        cbob_capacity.Text = ""
        dtp.Text = ""
    End Sub
    Public Sub enablefields()
        txtb_id.Enabled = True
        txtb_name.Enabled = True
        cbob_capacity.Enabled = True
        dtp.Enabled = True
    End Sub
    Public Sub disablefields()
        txtb_id.Enabled = False
        txtb_name.Enabled = False
        cbob_capacity.Enabled = False
        dtp.Enabled = False
    End Sub

#End Region

    Private Sub Update_Batch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Search_Batch.cmb_search_by.Text = "Batch_Name") Then
            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds1 As New DataSet
            str1 = "select * from batch_details where batch_name='" & Search_Batch.cmb_bat_name.Text & "'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds1, "batch_details")
            con.Open()
            Dim dt1 As New DataTable
            da.Fill(dt1)
            con.Close()
            For Each row As DataRow In ds1.Tables("batch_details").Rows
                If row(1).ToString = Search_Batch.cmb_bat_name.Text Then
                    txtb_id.Text = row("batch_id").ToString()
                    txtb_name.Text = row("batch_name").ToString()
                    cbob_capacity.Text = row("batch_capacity").ToString()
                    dtp.Text = row("batch_time").ToString()
                    Exit For
                End If
            Next
        Else

            Call disablefields()
            'str = "Data Source=USER-PC\SQLEXPRESS08;database=Softlab Education;integrated Security=true;"
            'con = New SqlConnection(str)
            cmd = New SqlCommand(str, con)
            Dim ds As New DataSet
            str1 = "select * from batch_details where batch_id=" & Search_Batch.cmb_bat_id.Text & ""
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(str1, con)
            da.Fill(ds, "batch_details")
            con.Open()
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            For Each row As DataRow In ds.Tables("batch_details").Rows
                If row(0).ToString = Search_Batch.cmb_bat_id.Text Then
                    txtb_id.Text = row("batch_id").ToString()
                    txtb_name.Text = row("batch_name").ToString()
                    cbob_capacity.Text = row("batch_capacity").ToString()
                    dtp.Text = row("batch_time").ToString()
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If btnedit.Text = "&Edit" Then
            Call enablefields()
            btnedit.Text = "&Update"
        Else
            If txtb_id.Text.Length = 0 Then
                ErrorProvider1.SetError(txtb_id, "Enter Batch id")
                MessageBox.Show("Enetr batch Id!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtb_id.Focus()
            Else
                If txtb_name.Text.Length = 0 Then
                    ErrorProvider1.SetError(txtb_name, "Enter batch name")
                    MessageBox.Show("Enter batch name ", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtb_name.Focus()
                Else
                    If cbob_capacity.Text = "" Then
                        ErrorProvider1.SetError(cbob_capacity, "Enter batch capacity")
                        MessageBox.Show("Enetr batch capacity!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cbob_capacity.Focus()
                    Else
                        If dtp.Text = "" Then
                            ErrorProvider1.SetError(dtp, "Enter batch time")
                            MessageBox.Show("Enetr batch time!!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            dtp.Focus()
                        Else
                            str = "update batch_details set batch_id=" & txtb_id.Text & ",batch_name='" & txtb_name.Text & "',batch_capacity='" & cbob_capacity.Text & "',batch_time='" & CDate(dtp.Text) & "' where batch_id=" & txtb_id.Text & ""
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
        'Call clearfields()

    End Sub

    Private Sub batch_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batch_delete.Click
        str = "Delete from batch_details where batch_id=" & txtb_id.Text & ""
        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted successfully ")
        con.Close()
        Call clearfields()
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class