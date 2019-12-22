Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Deduction

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("Insert into Salarydeducted values('" & txtempid.Text & "','" & txthra.Text & "','" & txtDA.Text & "','" & txtTA.Text & "','" & txtPF.Text & "','" & txtPT.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Saved")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    Private Sub txtempid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtempid.Click

        Try

        
            Dim cmdcal As New SqlCommand("select * from EmployeeDetails", cn)
            cn.Open()
            Dim salary As Double = 0.0

            salary = frmemployeedetails.txtgross.Text
            txthra.Text = Val(salary * 20 / 100)
            txtDA.Text = Val(salary * 87.41 / 100)
            txtTA.Text = Val(salary * 35 / 100)
            txtPF.Text = Val(salary * 28.42 / 100)
            txtPT.Text = Val(salary * 3.47 / 100)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try




    End Sub

    
    Private Sub Deduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtempid.Text = frmemployeedetails.txtid.Text
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
        frmMDIParent.Show()
    End Sub
End Class