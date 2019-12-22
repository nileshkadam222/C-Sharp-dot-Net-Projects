Public Class Form3
    Dim Ind As Int32
    Dim ID As Int16
    Dim Li As ListViewItem
    Dim flag As Integer = 0


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtRoomType.Text = "" Then
            Message("Complete Room Type.")
            txtRoomType.Focus()
        ElseIf txtUnitPrice.Text = "" Then
            Message("Complete Unit Price.")
            txtUnitPrice.Focus()
        Else
            Dim i As Int16
            Dim CID As Int16
            i = Getid("tblPrice", "ID", "RoomType='" & txtRoomType.Text & "'") - 1
            If i = 0 Then
                CID = Getid("tblPrice", "ID")
                Com.CommandText = "Insert into tblPrice values(?,?,?)"
                Com.Parameters.Add("@RID", OleDb.OleDbType.Integer).Value = CID
                Com.Parameters.Add("@RType", OleDb.OleDbType.VarChar).Value = txtRoomType.Text
                Com.Parameters.Add("@UnitPrice", OleDb.OleDbType.Currency).Value = txtUnitPrice.Text
                Com.ExecuteNonQuery()
                Com.Parameters.Clear()
                AddDataToLvw(LstPrice, txtRoomType.Text, txtUnitPrice.Text)
                ClearAll(Me)
                txtRoomType.Focus()
                Message("Success.")
            Else
                Message("Room Type already Exists.")
                txtRoomType.Focus()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        LstPrice.Items.Clear()
        Com.CommandText = "Select * from tblPrice"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(LstPrice, Dr(1), Dr(2), Dr(0))
        Loop
        Dr.Close()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If flag = 0 Then
            If txtRoomType.Text = "" Then
                If txtUnitPrice.Text = "" Then
                    MsgBox("Please Enter The RoomType And UnitPrice")
                Else
                    MsgBox("Please Enter The UnitPrice")
                End If
            End If

        Else
            txtRoomType.Enabled = True
            txtUnitPrice.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = True
            Dim Sl As ListView.SelectedListViewItemCollection = LstPrice.SelectedItems
            If btnEdit.Text = "Edit" Then
                For Each Li In Sl
                    Exit For
                Next
                txtRoomType.Text = Li.Text
                txtUnitPrice.Text = Li.SubItems(1).Text
                ID = Li.SubItems(2).Text
                Ind = Li.Index
                btnEdit.Text = "Update"
            Else
                Li = LstPrice.Items(Ind)
                Li.Text = txtRoomType.Text
                Li.SubItems(1).Text = txtUnitPrice.Text
                Com.CommandText = "Update tblPrice set RoomType=?,UnitPrice=? where ID=?"
                Com.Parameters.Add("@RType", OleDb.OleDbType.VarChar).Value = txtRoomType.Text
                Com.Parameters.Add("@UnitPrice", OleDb.OleDbType.Integer).Value = txtUnitPrice.Text
                Com.Parameters.Add("@ID", OleDb.OleDbType.Integer).Value = ID
                Com.ExecuteNonQuery()
                Com.Parameters.Clear()
                Message("Sucess.")
                ClearAll(Me)
                btnEdit.Text = "Edit"
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstPrice.SelectedItems
        Dim Str As String
        Str = MsgBox("Do you want to Delete this Record?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Hotel Management System")
        If Str = vbOK Then
            For Each Li In Sl
                Exit For
            Next
            Com.CommandText = "Delete from tblPrice Where RoomType='" & Li.Text & "'"
            Com.ExecuteNonQuery()
            Message("Sucess.")
            LstPrice.Items.Remove(Li)
            txtRoomType.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearAll(Me)
        txtRoomType.Focus()
        btnEdit.Text = "Edit"
        btnDelete.Enabled = False
        btnSave.Enabled = False

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstPrice.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        txtRoomType.Text = Li.Text
        txtUnitPrice.Text = Li.SubItems(1).Text
        ID = Li.SubItems(2).Text
        Ind = Li.Index
        btnEdit.Text = "Update"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        btnDelete_Click(sender, e)
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
        btnSave.Enabled = False
        txtRoomType.Enabled = False
        txtUnitPrice.Enabled = False
    End Sub

    Private Sub txtRoomType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoomType.KeyPress
        onlyAlphabate(e)
    End Sub

    Private Sub txtUnitPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        onlyInteger(e)
    End Sub

    Private Sub LstPrice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstPrice.SelectedIndexChanged
        flag = 1
    End Sub
End Class