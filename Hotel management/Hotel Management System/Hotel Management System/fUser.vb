Public Class fUser

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If txtFName.Text = "" Then
            Message("Complete First Name.")
            txtFName.Focus()
        ElseIf txtLName.Text = "" Then
            Message("Complete Last Name.")
            txtLName.Focus()
        ElseIf txtUName.Text = "" Then
            Message("Complete User Name.")
            txtUName.Focus()
        ElseIf txtPass.Text = "" Then
            Message("Complete Password.")
            txtPass.Focus()
        ElseIf txtConPass.Text = "" Then
            Message("Complete Confirm Password.")
            txtConPass.Focus()
        ElseIf cboPermission.Text = "" Then
            Message("Choose One Permission.")
            cboPermission.Focus()
        Else
            If txtPass.Text <> txtConPass.Text Then
                Message("User Password and Confirm Password are not the same." & vbCrLf & "Please, Check Again.")
                txtConPass.Focus()
                txtConPass.SelectAll()
            Else
                Dim Check As Int32
                Check = Getid("tblUser", "ID", "UserName='" & Encrypt(txtUName.Text) & "'") - 1
                If Check = 0 Then
                    Dim ID As Int32
                    ID = Getid("tblUser", "ID")
                    Com.CommandText = "Insert into tblUser Values(?,?,?,?,?,?)"
                    Com.Parameters.Add("@ID", OleDb.OleDbType.Integer).Value = ID
                    Com.Parameters.Add("@FName", OleDb.OleDbType.VarChar).Value = txtFName.Text
                    Com.Parameters.Add("@LName", OleDb.OleDbType.VarChar).Value = txtLName.Text
                    Com.Parameters.Add("@UName", OleDb.OleDbType.VarChar).Value = Encrypt(txtUName.Text)
                    Com.Parameters.Add("@Pass", OleDb.OleDbType.VarChar).Value = Encrypt(txtPass.Text)
                    Com.Parameters.Add("@Pess", OleDb.OleDbType.VarChar).Value = cboPermission.Text
                    Com.ExecuteNonQuery()
                    Com.Parameters.Clear()
                    Message("Success.")
                    ClearAll(Me)
                    cboPermission.SelectedIndex = -1
                    txtFName.Focus()
                Else
                    Message("User Name has already.")
                    txtUName.Focus()
                    txtUName.SelectAll()
                End If
            End If
        End If
    End Sub

End Class