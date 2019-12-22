Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmnewemployeeentry


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cndsave As New SqlCommand("insert into Employee_entry values (" & txtempid.Text & ",'" & txtlastname.Text & "','" & txtfirstname.Text & "','" & txtmiddlename.Text & "','" & txtaddress.Text & "','" & txtresidentalno.Text & "','" & txtmobileno.Text & "','" & txtgender.Text & "','" & txtemailid.Text & "','" & cbobloodgroup.Text & "','" & txtqualification.Text & "','" & dtpbirth_date.Value.Date & "','" & dtpdat_of_joining.Value.Date & "','" & dtpdate_of_leaving.Value.Date & "','" & cbodesignation.Text & "','" & cbodepartment.Text & "','" & cbostatus.Text & "','" & txtgrosssalary.Text & "','" & txtHRA.Text & "','" & txtDA.Text & "','" & txtTA.Text & "','" & txtPF.Text & "','" & txtPT.Text & "','" & txtpassword.Text & "')", cn)
            cn.Open()
            cndsave.ExecuteNonQuery()
            MsgBox("Record saved", MsgBoxStyle.Information, "Saved")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub frmnewempentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmdauto As New SqlCommand("select * from Employee_entry ", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmdauto.ExecuteReader
            While dr.Read
                txtempid.Text = dr.GetString(0)
            End While
            txtempid.Text = Val(txtempid.Text + 1)

            cboempid.Enabled = False
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    
    Private Sub rbtnfemale_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnfemale.Click
        txtgender.Text = "Female"
    End Sub

    Private Sub rbtnmale_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnmale.Click
        txtgender.Text = "Male"
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim sd As New SqlCommand("update Employee_entry set  Employee_last_name='" & txtlastname.Text & "' ,Employee_first_name='" & txtfirstname.Text & "' , Employee_middle_name='" & txtmiddlename.Text & "' ,Address ='" & txtaddress.Text & "' , Residential_no='" & txtresidentalno.Text & "' , Mobile_no='" & txtmobileno.Text & "' , Gender='" & txtgender.Text & "', Email_id='" & txtemailid.Text & "' , Blood_group= '" & cbobloodgroup.Text & "' , Qualification='" & txtqualification.Text & "' , DOB='" & dtpbirth_date.Text & "', DOJ='" & dtpdat_of_joining.Text & "' ,DOL='" & dtpdate_of_leaving.Text & "', Designation='" & cbodesignation.Text & "',Department='" & cbodepartment.Text & "' , Status='" & cbostatus.Text & "' , Gross_salary='" & txtgrosssalary.Text & "' HRA='" & txtHRA.Text & "',DA='" & txtDA.Text & "',TA='" & txtTA.Text & "',PF='" & txtPF.Text & "',PT='" & txtPT.Text & "',Password='" & txtpassword.Text & "' where Employee_id= '" & cboempid.Text & "'", cn)
            cn.Open()
            sd.ExecuteNonQuery()

            MsgBox("Records are succeessfully Updated")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    

    Private Sub btndetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndetails.Click
        cboempid.Enabled = True
        Dim cmdfill As New SqlCommand("select * from Employee_entry", cn)
        cn.Open()
        Dim drfill As SqlDataReader = cmdfill.ExecuteReader
        While drfill.Read
            cboempid.Items.Add(drfill.GetString(0))
        End While
        drfill.Close()
        cn.Close()
        txtempid.Enabled = False
        cboempid.Visible = True
        MsgBox("Select approriate Employee_ID from combobox which you want", MsgBoxStyle.OkOnly + MsgBoxStyle.Question)
        cboempid.Enabled = True
        cboempid.Focus()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()

        Me.Hide()

    End Sub

   

    Private Sub cboempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempid.SelectedIndexChanged
        Try
            Dim cmd As New SqlCommand("select *  from Employee_entry where Employee_id='" & cboempid.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                txtempid.Text = dr.GetString(0)
                cboempid.Text = dr.GetString(0)
                txtlastname.Text = dr.GetString(1)
                txtfirstname.Text = dr.GetString(2)
                txtmiddlename.Text = dr.GetString(3)
                txtaddress.Text = dr.GetString(4)
                txtresidentalno.Text = dr.GetString(5)
                txtmobileno.Text = dr.GetString(6)
                txtgender.Text = dr.GetString(7)
                txtemailid.Text = dr.GetString(8)
                cbobloodgroup.Text = dr.GetString(9)
                txtqualification.Text = dr.GetString(10)
                dtpbirth_date.Value = dr(11)
                dtpdat_of_joining.Value = dr(12)
                dtpdate_of_leaving.Value = dr(13)
                cbodesignation.Text = dr.GetString(14)
                cbodepartment.Text = dr.GetString(15)
                cbostatus.Text = dr.GetString(16)
                txtgrosssalary.Text = dr.GetString(17)

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

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            cboempid.Visible = True

            Dim cmd As New SqlCommand("Delete from Employee_entry where Employee_id='" & cboempid.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record deleted successfully")
            cn.Close()

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

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtempid.Text = ""
        cboempid.Text = ""
        txtlastname.Text = ""
        txtfirstname.Text = ""
        txtmiddlename.Text = ""
        txtaddress.Text = ""
        txtresidentalno.Text = ""
        txtmobileno.Text = ""
        txtgender.Text = ""
        txtemailid.Text = ""
        cbobloodgroup.Text = ""
        txtqualification.Text = ""
        dtpbirth_date.Value = Now
        dtpdat_of_joining.Value = Now
        dtpdate_of_leaving.Value = Now
        cbodesignation.Text = ""
        cbodepartment.Text = ""
        cbostatus.Text = ""
        txtgrosssalary.Text = ""

    End Sub

    Private Sub txtresidentalno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtresidentalno.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    

    Private Sub txtgrosssalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgrosssalary.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtlastname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlastname.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If


    End Sub

    Private Sub txtfirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirstname.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If


    End Sub

    Private Sub txtmiddlename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmiddlename.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If


    End Sub

    Private Sub txtHRA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHRA.KeyPress
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

    Private Sub txtPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPF.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtPT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPT.KeyPress
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

    
End Class