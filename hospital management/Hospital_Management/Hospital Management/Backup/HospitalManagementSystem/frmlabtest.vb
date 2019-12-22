Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmlabtest
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand

    Private Sub frmlabtest_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call labid()
    End Sub
    Private Sub labid()
        lstLExamID.Items.Clear()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM LABEXAMS order by LABEXMID"
        rd = cmd.ExecuteReader
        While rd.Read
            lstLExamID.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub
    Private Sub frmlabtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        con = New SqlConnection(constr)
        con.Open()
        txtTestID.ReadOnly = True
        txtTestName.ReadOnly = True
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        'On Error Resume Next

    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        'On Error Resume Next

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        'On Error Resume Next
        If cmdNew.Text = "&NEW" Then
            cmd.Connection = con
            cmd.CommandText = "SELECT LABEXMID FROM LABEXAMS order by LABEXMID"
            rd = cmd.ExecuteReader
            txtTestID.Text = 1
            While rd.Read
                txtTestID.Text = Val(rd(0)) + 1
            End While
            rd.Close()
            txtTestName.Enabled = True
            txtTestName.Text = ""
            txtTestName.ReadOnly = False
            cmdNew.Text = "&SAVE"
        ElseIf cmdNew.Text = "&SAVE" Then
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO LABEXAMS VALUES ('" & txtTestID.Text & "', '" & txtTestName.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record added successfully")
            txtTestID.Text = ""
            txtTestName.Text = ""
            txtTestName.ReadOnly = True
            lstLExamID.Items.Add(txtTestID.Text)
            cmdNew.Text = "&NEW"
            Call labid()
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If cmdEdit.Text = "&EDIT" Then
            txtTestName.Enabled = True
            cmdEdit.Text = "&UPDATE"
            txtTestName.ReadOnly = False
        ElseIf cmdEdit.Text = "&UPDATE" Then
            cmd.Connection = con
            cmd.CommandText = "UPDATE LABEXAMS SET EXAMNAME= '" & txtTestName.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Updated successfully")
            cmdEdit.Text = "&EDIT"
            txtTestID.Text = ""
            txtTestName.Text = ""
            txtTestName.ReadOnly = True
            Call labid()
        End If
    End Sub

    Private Sub lstLExamID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLExamID.SelectedIndexChanged
        'On Error Resume Next
        cmd.Connection = con
        cmd.CommandText = "SELECT LABEXMID,EXAMNAME FROM LABEXAMS where LABEXMID='" & lstLExamID.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read
            txtTestID.Text = rd(0)
            txtTestName.Text = rd(1)
        End While
        rd.Close()
    End Sub

    Private Sub txtTestName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTestName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class