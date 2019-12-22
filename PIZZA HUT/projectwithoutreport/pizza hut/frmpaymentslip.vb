Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmPaymentSlip
    Private Sub PaymentSlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DateTimePicker1.Value = Now
            Dim cmdretrive As New SqlCommand("select * from Employee_Details ", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmdretrive.ExecuteReader
            While dr.Read
                cboemp.Items.Add(dr.GetString(0))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub
    Private Sub cboemp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboemp.SelectedIndexChanged
        Try
            Dim cmdadd As New SqlCommand("select * from Employee_Details where Emp_ID='" & cboemp.Text & "'", cn)
            cn.Open()
            Dim dr1 As SqlDataReader = cmdadd.ExecuteReader
            While dr1.Read
                txtdept.Text = dr1.GetString(0)
                txtdesignation.Text = dr1.GetString(10)
                txtfname.Text = dr1.GetString(1)
                txtmname.Text = dr1.GetString(2)
                txtlname.Text = dr1.GetString(3)
                txtgrossSalary.Text = dr1.GetString(13)
            End While
            dr1.Close()
            cn.Close()

            Dim cmdre As New SqlCommand("select * from  Salarydeducted where Emp_ID='" & cboemp.Text & "'", cn)
            cn.Open()
            Dim drsal As SqlDataReader = cmdre.ExecuteReader
            While drsal.Read()
                txthra.Text = drsal(1)
                txtda.Text = drsal(2)
                txtta.Text = drsal(3)
                txtpf.Text = drsal(4)
                txtpt.Text = drsal(5)
            End While
            drsal.Close()
            cn.Close()


            Dim x As String = "A"
            Dim cmd2 As New SqlCommand("select count(*) from EmployeeAttendance where Emp_Attendance_Status='" & x & "' and  Month(CurrentDate)=" & DatePart(DateInterval.Month, DateTimePicker1.Value) & "  and Emp_ID='" & cboemp.Text & "'", cn)
            cn.Open()
            Dim counta As Integer = cmd2.ExecuteScalar
            txtdeductedsalary.Text = counta
            txtdeductedsalary.Text = Val(txtdeductedsalary.Text) * ((Val(txtgrossSalary.Text) / 30))
            cn.Close()
            txttotal.Text = Val(txthra.Text) + Val(txtda.Text) + Val(txtta.Text) + Val(txtsalovertime.Text)

            Dim annualsalary As Double = 0.0
            annualsalary = Val(txtgrossSalary.Text) * 12
            If (annualsalary >= 200000) Then
                txttax.Text = Val(txtgrossSalary.Text) * Val(10 / 100)
                txttax.Text = Val(txttax.Text / 12)
            Else
                If (annualsalary > 300000 & annualsalary < 500000) Then
                    txttax.Text = Val(txtgrossSalary.Text) * Val(12 / 100)
                    txttax.Text = Val(txttax.Text / 12)
                Else
                    txttax.Text = Val(txtgrossSalary.Text) * Val(15 / 100)
                    txttax.Text = Val(txttax.Text / 12)

                End If
                txttotal2.Text = Val(txtpf.Text) + Val(txtpt.Text) + Val(txttax.Text) + Val(txtdeductedsalary.Text)

            End If
            txttotal2.Text = Val(txtpf.Text) + Val(txtpt.Text) + Val(txttax.Text) + Val(txtdeductedsalary.Text)
            txtsalary.Text = Val(txtgrossSalary.Text) + Val(txttotal.Text) - Val(txttotal2.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmdsave As New SqlCommand("insert into paymentSlip values('" & txtdept.Text & "','" & cboemp.Text & "','" & DateTimePicker1.Value & "','" & txtcheq.Text & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & txtdesignation.Text & "','" & txtgrossSalary.Text & "','" & txthra.Text & "','" & txtda.Text & "','" & txtta.Text & "','" & txtsalovertime.Text & "','" & txtpf.Text & "','" & txtpt.Text & "','" & txtdeductedsalary.Text & "', '" & txttax.Text & "' ,'" & txtnetsalary.Text & "' )", cn)
            cn.Open()
            cmdsave.ExecuteNonQuery()
            MsgBox("Record Saved Successfully....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Saved")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub txtnetsalary_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnetsalary.GotFocus
        txtnetsalary.Text = Val(txtsalary.Text) + Val(txtincrement.Text)
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMDIParent.Show()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub txtincrement_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtincrement.GotFocus
        If txtincrement.Text = "" Then
            txtincrement.Text = "0.00"
        End If

    End Sub


    Private Sub txttotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttotal.GotFocus
        txttotal.Text = Val(txthra.Text) + Val(txtda.Text) + Val(txtta.Text) + Val(txtsalovertime.Text)
    End Sub

    Private Sub txttotal2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttotal2.GotFocus
        txttotal2.Text = Val(txtpf.Text) + Val(txtpt.Text) + Val(txtdeductedsalary.Text) + Val(txttax.Text)
    End Sub
End Class