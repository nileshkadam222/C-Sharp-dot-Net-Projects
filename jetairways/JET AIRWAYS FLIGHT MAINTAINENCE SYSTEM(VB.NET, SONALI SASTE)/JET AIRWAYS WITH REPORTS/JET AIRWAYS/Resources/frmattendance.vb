Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmattendance
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

    End Sub

    Private Sub frmattendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now.Date
        Dim cmdemp As New SqlCommand("select * from Employee_entry", cn)
        cn.Open()
        Dim dremp As SqlDataReader = cmdemp.ExecuteReader
        While dremp.Read
            cboempid.Items.Add(dremp.GetString(0))
        End While
        dremp.Close()
        cn.Close()
    End Sub

    Private Sub cboempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempid.SelectedIndexChanged
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
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
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
    End Sub
End Class