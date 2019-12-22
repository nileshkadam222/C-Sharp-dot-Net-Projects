Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmattendance
    

    Private Sub frmattendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DateTimePicker1.Value = Now.Date
            Dim cmdemp As New SqlCommand("select * from Employee_entry", cn)
            cn.Open()
            Dim dremp As SqlDataReader = cmdemp.ExecuteReader
            While dremp.Read
                cboempid.Items.Add(dremp.GetString(0))
            End While
            dremp.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cboempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempid.SelectedIndexChanged
        Try
            Dim cmddept As New SqlCommand("select * from Employee_entry where Employee_id='" & cboempid.Text & "'", cn)
            cn.Open()
            Dim drdept As SqlDataReader = cmddept.ExecuteReader
            While drdept.Read
                txtdeptname.Text = drdept.GetString(15)
                txtlastname.Text = drdept.GetString(1)
                txtmiddlename.Text = drdept.GetString(3)
                txtfirstname.Text = drdept.GetString(2)
                txtdesignation.Text = drdept.GetString(14)
            End While
            drdept.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            If chkTimeOut.Checked = True And rbtnpresent.Checked = True Then
                Dim cmdedit As New SqlCommand("select * from Attendance where EmpId='" & cboempid.Text & "'", cn)
                cn.Open()
                Dim dredit As SqlDataReader = cmdedit.ExecuteReader
                If Not dredit.Read Then
                    MsgBox("First select Time in.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                Else
                    frmeditattendance.Show()
                End If
                dredit.Close()
                cn.Close()
            Else
                frmeditattendance.Show()
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

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class