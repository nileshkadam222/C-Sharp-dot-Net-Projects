Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmnewuser


    Private Sub frmnewuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpassword.Enabled = False
        txtconfirmpassword.Enabled = False
        Dim cmdid As New SqlCommand("select * from Employee_entry", cn)
        cn.Open()
        Dim drid As SqlDataReader = cmdid.ExecuteReader
        While drid.Read
            cbouserid.Items.Add(drid.GetString(0))
        End While
        drid.Close()
        cn.Close()
    End Sub

    Private Sub cbouserid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbouserid.SelectedIndexChanged
        Dim i As Integer
        Dim a As String
        Dim cmdfill As New SqlCommand("select * from Employee_entry where Employee_id='" & cbouserid.Text & "'", cn)
        cn.Open()
        Dim drfill As SqlDataReader = cmdfill.ExecuteReader
        While drfill.Read
            txtdepartment.Text = drfill.GetString(15)
            txtdesignation.Text = drfill.GetString(14)
        End While
        drfill.Close()
        cn.Close()

        Dim cmduser As New SqlCommand("select * from Logintable where User_id='" & cbouserid.Text & "'", cn)
        cn.Open()
        Dim druser As SqlDataReader = cmduser.ExecuteReader
        If druser.Read Then
            MsgBox("The selected user is already assigned a password...!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "PASSWORD")
            i = MsgBox("Do you want to change the password?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "PASSWORD")
            If i = MsgBoxResult.No Then
                MsgBox("Please select another user...!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "USER")
                cbouserid.Text = ""
                txtdepartment.Text = ""
                txtdesignation.Text = ""
            Else
                txtoldpass.Text = druser.GetString(1)
                a = InputBox("Please enter old password")
                If a = txtoldpass.Text Then
                    txtpassword.Enabled = True
                    txtconfirmpassword.Enabled = True
                Else
                    MsgBox("Please cheack the old password...!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                    cbouserid.Text = ""
                    txtdepartment.Text = ""
                    txtdesignation.Text = ""
                End If
            End If
        End If
        druser.Close()
        cn.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click

        Dim cmdchk As New SqlCommand("select * from Logintable", cn)
        cn.Open()
        Dim drchk As SqlDataReader = cmdchk.ExecuteReader
        If drchk.Read Then
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Dim cmduplogin As New SqlCommand("update Logintable set Password='" & txtconfirmpassword.Text & "' where User_id='" & cbouserid.Text & "'", cn)
            cn.Open()
            cmduplogin.ExecuteNonQuery()
            MsgBox("Record Saved successfully")
            cn.Close()
        Else
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Dim cmdsave As New SqlCommand("insert into Logintable values('" & cbouserid.Text & "','" & txtconfirmpassword.Text & "','" & txtdepartment.Text & "','" & txtdesignation.Text & "')", cn)
            cn.Open()
            cmdsave.ExecuteNonQuery()
            MsgBox("Record Saved successfully")
            cn.Close()
        End If
        drchk.Close()
        cn.Close()



        Dim cmdup As New SqlCommand("update Employee_entry set Password='" & txtconfirmpassword.Text & "' where Employee_id='" & cbouserid.Text & "'", cn)
        cn.Open()
        cmdup.ExecuteNonQuery()
        cn.Close()
    End Sub

    

    Private Sub txtconfirmpassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtconfirmpassword.LostFocus
        If txtconfirmpassword.Text <> txtpassword.Text Then
            MsgBox("Pls enter same password as above....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
            txtconfirmpassword.Text = ""
            txtconfirmpassword.Focus()
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        MDIParent1.Show()
        Me.Hide()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()
        Me.Hide()

    End Sub

    
End Class