Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmpaymentslip

    Private Sub cboempid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboempid.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub cboempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempid.SelectedIndexChanged
        Try
            cn.Open()
            Dim cnd As New SqlCommand("select * from Employee_entry  where Employee_id ='" & cboempid.Text & "'", cn)
            Dim dr As SqlDataReader = cnd.ExecuteReader
            While dr.Read
                cbodepartment.Text = dr.GetString(15)
                cboempid.Text = dr.GetString(0)
                txtlastname.Text = dr.GetString(1)
                txtfirstname.Text = dr.GetString(2)
                txtmiddlename.Text = dr.GetString(3)
                txtdesignation.Text = dr.GetString(14)
                txtgrosssalary.Text = dr.GetString(17)
                txtHRA.Text = dr.GetString(18)
                txtDA.Text = dr.GetString(19)
                txtTA.Text = dr.GetString(20)
                txtPF.Text = dr.GetString(21)
                txtPT.Text = dr.GetString(22)

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


    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Dim cmd As New SqlCommand("select * from Employee_entry", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboempid.Items.Add(dr(0))

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

    Private Sub txtallowancetotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtallowancetotal.GotFocus
        txtallowancetotal.Text = Val(txtHRA.Text) + Val(txtDA.Text) + Val(txtTA.Text) + Val(txtsalaryduringOT.Text)

    End Sub


    Private Sub txtsalarydeductedforleaves_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsalarydeductedforleaves.GotFocus
        Try
            Dim x As String = "PRESENT"
            Dim cmd1 As New SqlCommand("select count(Type) from Attendance where EmpId='" & cboempid.Text & "'and currentdate='" & DateTimePicker1.Value & "'and Type='" & x & "' and CurrentDate='" & FormatDateTime(DateTimePicker1.Value, DateFormat.ShortDate) & "'", cn)
            cn.Open()
            Dim counta As Integer = cmd1.ExecuteScalar
            'MsgBox(counta)
            txtsalarydeductedforleaves.Text = counta


            txtsalarydeductedforleaves.Text = Val(txtsalarydeductedforleaves.Text) * ((Val(txtgrosssalary.Text) / 30))
            cn.Close()
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

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub txtincometax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtincometax.GotFocus
        Try
            Dim annualsalary As Double = 0.0
            annualsalary = Val(txtgrosssalary.Text) * 12
            If (annualsalary >= 200000) Then
                txtincometax.Text = Val(txtgrosssalary.Text) * Val(10 / 100)
                txtincometax.Text = Val(txtincometax.Text) / 12
            Else
                If (annualsalary > 300000 & annualsalary < 500000) Then
                    txtincometax.Text = Val(txtgrosssalary.Text) * Val(12 / 100)
                    txtincometax.Text = Val(txtincometax.Text) / 12
                Else
                    txtincometax.Text = Val(txtgrosssalary.Text) * Val(15 / 100)
                    txtincometax.Text = Val(txtincometax.Text) / 12

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub txtdeductiontotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdeductiontotal.GotFocus
        txtdeductiontotal.Text = Val(txtPF.Text) + Val(txtPT.Text) + Val(txtsalarydeductedforleaves.Text) + Val(txtincometax.Text)

    End Sub

    Private Sub txtsalary_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsalary.GotFocus
        txtsalary.Text = (Val(txtgrosssalary.Text) + Val(txtallowancetotal.Text)) - Val(txtdeductiontotal.Text)

    End Sub


    Private Sub txtnetsalary_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnetsalary.GotFocus
        txtnetsalary.Text = Val(txtsalary.Text) + Val(txtincrement.Text)

    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into PaySlip values('" & cboempid.Text & "','" & DateTimePicker1.Value & "','" & txtchequeno.Text & "','" & cbodepartment.Text & "','" & txtHRA.Text & "','" & txtDA.Text & "','" & txtTA.Text & "','" & txtsalaryduringOT.Text & "','" & txtallowancetotal.Text & "','" & txtPF.Text & "','" & txtincrement.Text & "','" & txtsalarydeductedforleaves.Text & "','" & txtincometax.Text & "','" & txtdeductiontotal.Text & "','" & txtnetsalary.Text & "','" & txtPT.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox(" Record Saved Successfully", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "saves")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cbodepartment.Text = ""
        cboempid.Text = ""
        txtchequeno.Text = ""
        txtlastname.Text = ""
        txtfirstname.Text = ""
        txtmiddlename.Text = ""
        txtdesignation.Text = ""
        txtgrosssalary.Text = ""
        txtHRA.Text = ""
        txtDA.Text = ""
        txtTA.Text = ""
        txtsalaryduringOT.Text = ""
        txtallowancetotal.Text = ""
        txtPF.Text = ""
        txtPT.Text = ""
        txtsalarydeductedforleaves.Text = ""
        txtincometax.Text = ""
        txtdeductiontotal.Text = ""
        txtsalary.Text = ""
        txtincrement.Text = ""
        txtnetsalary.Text = ""

    End Sub


    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        payslip_report.Show()
        Me.Hide()

    End Sub

    Private Sub txtgrosssalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrosssalary.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtHRA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHRA.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtDA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDA.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtTA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTA.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtsalaryduringOT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalaryduringOT.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtincrement_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtincrement.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    
End Class