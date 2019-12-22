Imports System.Data
Imports System.Data.SqlClient
Public Class frmdesignation


    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtdepartmentname.Text = ""
        cbodesignationname.Text = ""
        txtgrosssalary.Text = ""
        txtpayleaves.Text = ""
        txtotpershift.Text = ""
        txtdeductionperextraleaves.Text = ""
        txtPF.Text = ""
        txtHRA.Text = ""
        txtDA.Text = ""
        txtTA.Text = ""

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click

        Try
            Dim cmd As New SqlCommand("select * from Designation", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cbodesignationname.Items.Add(dr(0))

            End While
            'txtdeductionperextraleaves.Text = ""
            'txtdepartmentname.Text = ""
            'txtgrosssalary.Text = ""
            txtdepartmentname.Text = ""
            cbodesignationname.Text = ""
            txtgrosssalary.Text = ""
            txtpayleaves.Text = ""
            txtotpershift.Text = ""
            txtdeductionperextraleaves.Text = ""
            txtPF.Text = ""
            txtHRA.Text = ""
            txtDA.Text = ""
            txtTA.Text = ""


            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cbodesignationname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodesignationname.SelectedIndexChanged
        Try




            Dim cmd As New SqlCommand("select * from Designation where Designation ='" & cbodesignationname.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                txtdepartmentname.Text = dr(0)
                txtgrosssalary.Text = dr(2)
                txtpayleaves.Text = dr(3)
                txtotpershift.Text = dr(4)
                txtdeductionperextraleaves.Text = dr(5)
                txtPF.Text = dr(6)
                txtHRA.Text = dr(7)
                txtDA.Text = dr(8)
                txtTA.Text = dr(9)
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

  
    Private Sub frmdesignation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from Designation", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cbodesignationname.Items.Add(dr(1))

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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into Designation values ('" & txtdepartmentname.Text & "','" & cbodesignationname.Text & "','" & txtgrosssalary.Text & "','" & txtpayleaves.Text & "','" & txtotpershift.Text & "','" & txtdeductionperextraleaves.Text & "','" & txtPF.Text & "','" & txtHRA.Text & "','" & txtDA.Text & "','" & txtTA.Text & "')", cn)
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


    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub
    Private Sub txtdepartmentname_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdepartmentname.KeyPress

        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtgrosssalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrosssalary.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtpayleaves_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayleaves.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtotpershift_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtotpershift.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtdeductionperextraleaves_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdeductionperextraleaves.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPF.KeyPress
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

End Class