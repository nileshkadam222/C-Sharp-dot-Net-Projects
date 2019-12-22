Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmfuelmanagement

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into FuelManagement values('" & txtflightno.Text & "','" & cboflightdate.Text & "','" & cboregno.Text & "','" & cbobayno.Text & "','" & cbofrom1.Text & "','" & cboto1.Text & "','" & cbooilcompany.Text & "','" & txtdeptimeIST.Text & "','" & txtdeptimeUTC.Text & "','" & txtdepfuel.Text & "','" & txtburnoff.Text & "','" & txtarrtimeIST.Text & "','" & txtarrtimeUTC.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record saved successfully", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "saves")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtflightno.Text = ""
        cboflightdate.Text = ""
        cboregno.Text = ""
        cbobayno.Text = ""
        cbofrom1.Text = ""
        cboto1.Text = ""
        cbooilcompany.Text = ""
        txtdeptimeIST.Text = ""
        txtdeptimeUTC.Text = ""
        txtdepfuel.Text = ""
        txtburnoff.Text = ""
        txtarrtimeIST.Text = ""
        txtarrtimeUTC.Text = ""

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from FuelManagement where Flight_date = '" & cboflightdate.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record deleted successfully")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btndetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndetails.Click
        Try
            Dim cmd1 As New SqlCommand("select * from FuelManagement where Flight_date='" & cbodate.Text & "' and Flight_no='" & cboflightno.Text & "'", cn)
            cn.Open()
            Dim dm As SqlDataReader = cmd1.ExecuteReader
            While dm.Read
                ' cboflightno.Text = dm.GetString(0)
                'cboflightdate.Text = dm.GetString(1)
                cboregno.Text = dm.GetString(2)
                cbobayno.Text = dm.GetString(3)
                cbofrom1.Text = dm.GetString(4)
                cboto1.Text = dm.GetString(5)
                cbooilcompany.Text = dm.GetString(6)
                txtdeptimeIST.Text = dm.GetString(7)
                txtdeptimeUTC.Text = dm.GetString(8)
                txtdepfuel.Text = dm.GetString(9)
                txtburnoff.Text = dm.GetString(10)
                txtarrtimeIST.Text = dm.GetString(11)
                txtarrtimeUTC.Text = dm.GetString(12)
            End While
            dm.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub



    Private Sub txtdeptimeIST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeptimeIST.TextChanged
        Try
            Dim hour, minute As Integer

            Dim cmd As New SqlCommand("select * from FuelMnagement", cn)
            If txtdeptimeIST.Text = "" Then
                txtdeptimeUTC.Text = ""
            Else
                hour = Val(Mid(txtdeptimeIST.Text, 1, 2))
                minute = Val(Mid(txtdeptimeIST.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60

                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour

                End If
                txtdeptimeUTC.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click

        cbodate.Enabled = True
        cboflightno.Enabled = True
        Dim am As New SqlCommand("select * from FuelManagement", cn)
        cn.Open()
        Dim dm1 As SqlDataReader = am.ExecuteReader
        While dm1.Read
            cbodate.Items.Add(dm1(1))
            cboflightno.Items.Add(0)
        End While
        dm1.Close()
        cn.Close()

        cboflightdate.Visible = False
        txtflightno.Visible = False



        'Dim cmd As New SqlCommand("select * from FuelManagement where Flight_date='" & cbodate.Text & "' and '" & cboflightno.Text & "'", cn)
        'cn.Open()
        'Dim dm As SqlDataReader = cmd.ExecuteReader
        'While dm.Read
        '    cboflightno.Text = dm.GetString(0)
        '    cboflightdate.Text = dm.GetString(1)
        '    cboregno.Text = dm.GetString(2)
        '    cbobayno.Text = dm.GetString(3)
        '    cbofrom1.Text = dm.GetString(4)
        '    cboto1.Text = dm.GetString(5)
        '    cbooilcompany.Text = dm.GetString(6)
        '    txtdeptimeIST.Text = dm.GetString(7)
        '    txtdeptimeUTC.Text = dm.GetString(8)
        '    txtdepfuel.Text = dm.GetString(9)
        '    txtburnoff.Text = dm.GetString(10)
        '    txtarrtimeIST.Text = dm.GetString(11)
        '    txtarrtimeUTC.Text = dm.GetString(12)
        'End While
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub cboflightdate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboflightdate.SelectedIndexChanged
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
            Dim am As New SqlCommand("select * from FuelManagement where Flight_date='" & cboflightdate.Text & "'", cn)
            cn.Open()
            Dim dm As SqlDataReader = am.ExecuteReader
            While dm.Read
                txtflightno.Text = dm.GetString(0)
                'cboflightdate.Text = dm.GetString(1)
                cboregno.Text = dm.GetString(2)
                cbobayno.Text = dm.GetString(3)
                cbofrom1.Text = dm.GetString(4)
                cboto1.Text = dm.GetString(5)
                cbooilcompany.Text = dm.GetString(6)
                txtdeptimeIST.Text = dm.GetString(7)
                txtdeptimeUTC.Text = dm.GetString(8)
                txtdepfuel.Text = dm.GetString(9)
                txtburnoff.Text = dm.GetString(10)
                txtarrtimeIST.Text = dm.GetString(11)
                txtarrtimeUTC.Text = dm.GetString(12)

            End While
            dm.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbodate.Enabled = False
            cboflightno.Enabled = False
            Dim am As New SqlCommand("select * from FuelManagement", cn)
            cn.Open()
            Dim dm As SqlDataReader = am.ExecuteReader
            While dm.Read
                cboflightno.Items.Add(dm(0))
                cboflightdate.Items.Add(dm(1))
            End While
            dm.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    Private Sub cbodate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodate.SelectedIndexChanged
       

        Try
            Dim cmd As New SqlCommand("select * from FuelManagement where Flight_date='" & cbodate.Text & "' and Flight_no= '" & cboflightno.Text & "'", cn)
            cn.Open()
            Dim dm As SqlDataReader = cmd.ExecuteReader

            While dm.Read
                cboflightno.Text = dm.GetString(0)
                cboflightdate.Text = dm.GetString(1)
                cboregno.Text = dm.GetString(2)
                cbobayno.Text = dm.GetString(3)
                cbofrom1.Text = dm.GetString(4)
                cboto1.Text = dm.GetString(5)
                cbooilcompany.Text = dm.GetString(6)
                txtdeptimeIST.Text = dm.GetString(7)
                txtdeptimeUTC.Text = dm.GetString(8)
                txtdepfuel.Text = dm.GetString(9)
                txtburnoff.Text = dm.GetString(10)
                txtarrtimeIST.Text = dm.GetString(11)
                txtarrtimeUTC.Text = dm.GetString(12)
            End While

            dm.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub txtarrtimeIST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtarrtimeIST.TextChanged
        Try
            Dim hour, minute As Integer

            Dim cmd As New SqlCommand("select * from FuelManagement", cn)
            If txtarrtimeIST.Text = "" Then
                txtarrtimeUTC.Text = ""
            Else
                hour = Val(Mid(txtarrtimeIST.Text, 1, 2))
                minute = Val(Mid(txtarrtimeIST.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60

                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour

                End If
                txtarrtimeUTC.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()
        Me.Hide()

    End Sub

    
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        fuelmanagement_report.Show()
        Me.Hide()

    End Sub
End Class