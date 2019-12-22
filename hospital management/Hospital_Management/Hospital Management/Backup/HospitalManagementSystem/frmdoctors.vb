Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmdoctors
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Private Sub frmdoctors_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        connection()
        con = New SqlConnection(constr)
        con.Open()
        Call list()
        cmdNEW.Focus()
    End Sub
    Private Sub list()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM DOCTORS"
        rd = cmd.ExecuteReader
        lstCODE.Items.Clear()
        While (rd.Read)
            lstCODE.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub

    Private Sub cmdNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNEW.Click
        Call clears()

        Dim x As Integer
        cmdUpdate.Text = "&Edit"
        'On Error Resume Next
      
        cmd.Connection = con
        cmd.CommandText = "SELECT code FROM DOCTORS "
        rd = cmd.ExecuteReader
        If Not (rd.HasRows) Then

            x = 1

        Else
            While (rd.Read())
                x = rd(0)
                x = x + 1
            End While
            rd.Close()
        End If
        txtDOCCODE.Text = x
        If cmdNEW.Text = "&NEW" Then
            clears()
            Call enableds()
            cmdNEW.Text = "&SAVE"
        ElseIf cmdNEW.Text = "&SAVE" Then
            cmd.Connection = con

            If (txtDOCNAME.Text <> "") Then
                cmd.CommandText = "INSERT INTO DOCTORS(CODE,DOCNAME,SPCLZATION,NATURE,QUALIFICATION) VALUES ('" & txtDOCCODE.Text & "', '" & txtDOCNAME.Text & "','" & txtSPCLZATION.Text & "','" & txtNATURE.Text & "','" & txtQUALIFICATION.Text & "')"
                'rd.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Added Successfuly")
                Call clears()
                txtDOCCODE.Text = ""
                cmdNEW.Text = "&NEW"
                'clears()
                Call enableds()
                Call list()
            Else
                MsgBox("Please enter doctor name")
            End If
        End If
    End Sub

    Private Sub cmdADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADD.Click

    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        On Error Resume Next
        cmdNEW.Text = "&NEW"
        If cmdEdit.Text = "&EDIT" Then
            enableds()
            cmdEdit.Text = "&UPDATE"
        ElseIf cmdEdit.Text = "&UPDATE" Then
            cmd.Connection = con
            cmd.CommandText = "UPDATE DOCTORS SET DOCNAME='" & txtDOCNAME.Text & "' ,SPCLZATION='" & txtSPCLZATION.Text & "',NATURE='" & txtNATURE.Text & "',QUALIFICATION='" & txtQUALIFICATION.Text & "' where code='" & txtDOCCODE.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Updated Sucessfully")
            Call list()
            cmdEdit.Text = "&EDIT"
            disableds()
        End If
    End Sub

    Private Sub lstCODE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCODE.Click
        cmdNEW.Text = "&NEW"
        cmdUpdate.Text = "&Edit"
        Call disableds()
        On Error Resume Next
        Dim x As Integer
        cmd.Connection = con
        'cmd.CommandText = "SELECT code FROM DOCTORS "
        'rd = cmd.ExecuteReader
        'If Not (rd.HasRows) Then

        '    x = 1

        'Else
        '    While (rd.Read())
        '        x = rd(0)
        '        x = x + 1
        '    End While
        '    rd.Close()
        'End If


        cmd.CommandText = "SELECT code,DOCNAME,SPCLZATION,NATURE,QUALIFICATION FROM DOCTORS where CODE='" & lstCODE.Text & "'"
        rd = cmd.ExecuteReader
        'Set rs = con.Execute("SELECT DOCCODE,DNAME  FROM DOCTORS where CODE=" & List1.Text)
        While rd.Read()
            txtDOCCODE.Text = rd(0)
            txtDOCNAME.Text = rd(1)
            txtSPCLZATION.Text = rd(2)
            txtNATURE.Text = rd(3)
            txtQUALIFICATION.Text = rd(4)
        End While
        rd.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstCODE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCODE.SelectedIndexChanged

    End Sub

    Private Sub txtDOCCODE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDOCCODE.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub clears()
        txtDOCNAME.Text = ""
        txtSPCLZATION.Text = ""
        txtNATURE.Text = ""
        txtQUALIFICATION.Text = ""
    End Sub
    Private Sub enableds()
        txtDOCNAME.Enabled = True
        txtSPCLZATION.Enabled = True
        txtNATURE.Enabled = True
        txtQUALIFICATION.Enabled = True
    End Sub
    Private Sub disableds()
        txtDOCNAME.Enabled = False
        txtSPCLZATION.Enabled = False
        txtNATURE.Enabled = False
        txtQUALIFICATION.Enabled = False
    End Sub

    Private Sub txtDOCNAME_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDOCNAME.KeyPress
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

    Private Sub txtSPCLZATION_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSPCLZATION.KeyPress
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

    Private Sub txtNATURE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNATURE.KeyPress
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

    Private Sub txtQUALIFICATION_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQUALIFICATION.KeyPress
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

    Private Sub frmdoctors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class