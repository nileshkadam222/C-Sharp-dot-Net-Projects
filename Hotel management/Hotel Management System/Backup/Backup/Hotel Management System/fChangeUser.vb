'Imports System.Data.OleDb
Public Class fChangeUser
    Dim Li As ListViewItem
    Dim ind As Int32

    Private Sub fChangeUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        Com.CommandText = "Select UserName from tblUser"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            LstUser.Items.Add(Decrypt(Dr(0)), 2)
        Loop
        Dr.Close()
        btnClose.Enabled = True
    End Sub

    Private Sub LstUser_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstUser.DoubleClick
        Dim Sl As ListView.SelectedListViewItemCollection = LstUser.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        Com.CommandText = "Select * from tblUser where UserName='" & Encrypt(Li.Text) & "'"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            GroupBox1.Enabled = True
            UserID = Dr(0)
            txtFName.Text = Dr(1)
            txtLName.Text = Dr(2)
            If Li.Text = "Admin" Then
                txtUName.Enabled = False
            Else
                txtUName.Enabled = True
            End If
            txtUName.Text = Decrypt(Dr(3))
            txtPass.Text = Decrypt(Dr(4))
            txtConPass.Text = txtPass.Text
            cboPermission.Text = Dr(5)
            ind = Li.Index
        End If
        Dr.Close()
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
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
                Com.CommandText = "Update tblUser Set FName=?,LName=?,UserName=?,Pass=?,Permission=? where ID=?"
                Com.Parameters.Add("@FN", OleDb.OleDbType.VarChar).Value = txtFName.Text
                Com.Parameters.Add("@LN", OleDb.OleDbType.VarChar).Value = txtLName.Text
                Com.Parameters.Add("@UN", OleDb.OleDbType.VarChar).Value = Encrypt(txtUName.Text)
                Com.Parameters.Add("@Pass", OleDb.OleDbType.VarChar).Value = Encrypt(txtPass.Text)
                Com.Parameters.Add("@Per", OleDb.OleDbType.VarChar).Value = cboPermission.Text
                Com.Parameters.Add("@ID", OleDb.OleDbType.Integer).Value = UserID
                Com.ExecuteNonQuery()
                Com.Parameters.Clear()
                Message("Success.")
                Li = LstUser.Items(ind)
                Li.Text = txtUName.Text
                ClearEnable()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Mess As String
        Mess = MsgBox("Do you to delete this User.", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Hotel Management System")
        If Mess = vbOK Then
            Dim Sl As ListView.SelectedListViewItemCollection = LstUser.SelectedItems
            For Each Li In Sl
                Exit For
            Next
            If Li.Text <> "Admin" Then
                Com.CommandText = "Delete from tblUser where ID=" & UserID & ""
                Com.ExecuteNonQuery()
                Message("Success.")
                LstUser.Items.Remove(Li)
                ClearEnable()
            Else
                Message("Cannot Delete System User.")
            End If
        End If
    End Sub

    Sub ClearEnable()
        txtFName.Clear()
        txtLName.Clear()
        txtUName.Clear()
        txtPass.Clear()
        txtConPass.Clear()
        GroupBox1.Enabled = False
        cboPermission.SelectedIndex = -1
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class