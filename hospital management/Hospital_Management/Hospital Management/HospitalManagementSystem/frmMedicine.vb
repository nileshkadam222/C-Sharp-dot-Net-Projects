Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMedicine
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand

    Private Sub frmMedicine_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call med()
    End Sub
    Private Sub med()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM MEDICINE order by MEDID"
        rd = cmd.ExecuteReader
        While rd.Read
            lstMedID.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub frmMedicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' connection()
        ' con = New SqlConnection(constr)
        con.Open()
        txtMedID.ReadOnly = True
        txtMedName.ReadOnly = True
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
            cmd.CommandText = "SELECT max(MEDID) FROM MEDICINE"
            rd = cmd.ExecuteReader
            txtMedID.Text = 1
            While rd.Read
                txtMedID.Text = Val(rd(0)) + 1
            End While
            rd.Close()
            txtMedName.Enabled = True

            'txtMedID.ReadOnly = True
            txtMedName.ReadOnly = False
            txtMedName.Text = ""
            cmdNew.Text = "&SAVE"
        ElseIf cmdNew.Text = "&SAVE" Then
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO MEDICINE VALUES ('" & txtMedID.Text & "', '" & txtMedName.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Added Sucessfuly")
            cmdNew.Text = "&NEW"
            txtMedID.Text = ""
            txtMedName.Text = ""
            txtMedName.ReadOnly = True
        End If
        Call med()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If cmdEdit.Text = "&EDIT" Then
            txtMedName.Enabled = True
            cmdEdit.Text = "&UPDATE"

            'txtMedID.ReadOnly = False
            txtMedName.ReadOnly = False
        ElseIf cmdEdit.Text = "&UPDATE" Then
            cmd.Connection = con
            cmd.CommandText = "UPDATE MEDICINE SET MEDICINENAME = '" & txtMedName.Text & "' where MEDID ='" & txtMedID.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Updated Sucessfuly")
            cmdEdit.Text = "&EDIT"
            txtMedID.Text = ""
            txtMedName.Text = ""

            'txtMedID.ReadOnly = True
            txtMedName.ReadOnly = True
        End If
        Call med()
    End Sub

    Private Sub lstMedID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMedID.SelectedIndexChanged
        'On Error Resume Next
        cmd.Connection = con
        cmd.CommandText = "SELECT MEDID,MEDICINENAME FROM MEDICINE where MEDID ='" & lstMedID.Text & "'"
        rd = cmd.ExecuteReader
        While rd.Read
            txtMedID.Text = rd(0)
            txtMedName.Text = rd(1)
        End While
        rd.Close()
    End Sub

    Private Sub txtMedName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMedName.KeyPress
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