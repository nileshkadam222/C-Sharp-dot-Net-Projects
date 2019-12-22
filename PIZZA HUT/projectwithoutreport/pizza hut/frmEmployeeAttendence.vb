Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmEmployeeAttendence
    Private Sub EmployeeAttendence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DateTimePicker1.Value = Now.Date
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Dim cmdemp As New SqlCommand("select * from Employee_Details order by Emp_ID", cn)
            cn.Open()
            Dim dremp As SqlDataReader = cmdemp.ExecuteReader
            While dremp.Read
                cboempid.Items.Add(dremp.GetString(0))
            End While
            dremp.Close()
            cn.Close()
            txtpre.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub cboempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempid.SelectedIndexChanged
        Try
            Dim cmdat As New SqlCommand("select * from Employee_Details where Emp_ID='" & cboempid.Text & "'", cn)
            cn.Open()
            Dim drat As SqlDataReader = cmdat.ExecuteReader
            While drat.Read
                txtempname.Text = drat.GetString(1) & " " & drat.GetString(2) & " " & drat.GetString(3)
                txtempmobno.Text = drat(9)
                txtgender.Text = drat.GetString(4)
                txtdesignation.Text = drat.GetString(10)
            End While
            drat.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        txtpre.Text = "P"
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If RadioButton1.Checked = True Then
                Dim cmdsave As New SqlCommand("Insert into EmployeeAttendance values('" & DateTimePicker1.Value & "','" & cboempid.Text & "','" & txtempname.Text & "','" & txtempmobno.Text & "','" & txtgender.Text & "','" & txtdesignation.Text & "','" & txtpre.Text & "')", cn)
                cn.Open()
                cmdsave.ExecuteNonQuery()
                MsgBox("Record Saved Successfully....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Saved")
                cn.Close()
            Else
                Dim cmdsave As New SqlCommand("Insert into EmployeeAttendance values('" & DateTimePicker1.Value & "','" & cboempid.Text & "','" & txtempname.Text & "','" & txtempmobno.Text & "','" & txtgender.Text & "','" & txtdesignation.Text & "', 'A' )", cn)
                cn.Open()
                cmdsave.ExecuteNonQuery()
                MsgBox("Record Saved Successfully....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Saved")
                cn.Close()
            End If

            Dim da As New SqlDataAdapter("select * from EmployeeAttendance ", cn)
            Dim ds As New DataSet
            da.Fill(ds, "EmployeeAttendance")
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub


    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Try
            txtdesignation.Text = ""
            txtempmobno.Text = ""
            txtgender.Text = ""
            txtempname.Text = ""
            txtpre.Text = ""
            RadioButton1.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub


    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMDIParent.Show()
    End Sub
End Class