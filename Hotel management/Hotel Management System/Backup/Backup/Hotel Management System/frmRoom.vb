Imports System.Data.OleDb
Public Class frmRoom
    Dim Da As New OleDbDataAdapter
    Dim Dt As New DataTable
    Dim Li As ListViewItem
    Dim Ind As Int32
    Dim RID As Int32

    Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        Com.CommandText = "Select ID,RoomType from tblPrice"
        Da.SelectCommand = Com
        Dt.TableName = "Price"
        Da.Fill(Dt)
        cboRoomType.DataSource = Dt
        cboRoomType.ValueMember = Dt.Columns(0).ToString
        cboRoomType.DisplayMember = Dt.Columns(1).ToString
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtRoomNo.Text = "" Then
            Message("Complete Room No.")
            txtRoomNo.Focus()
        ElseIf cboFloor.Text = "" Then
            Message("Complete Floor.")
            cboFloor.Focus()
        Else
            Dim i As Int32
            Dim ID As Int32
            i = Getid("tblRooms", "ID", "RoomNo=" & txtRoomNo.Text & "") - 1
            If i = 0 Then
                ID = Getid("tblRooms", "ID")
                Com.CommandText = "Insert into tblRooms Values(?,?,?,?)"
                With Com.Parameters
                    .Add("@ID", OleDbType.Integer).Value = ID
                    .Add("@RNo", OleDbType.Integer).Value = txtRoomNo.Text
                    .Add("@PID", OleDbType.Integer).Value = cboRoomType.SelectedValue
                    .Add("@Floor", OleDbType.VarChar).Value = cboFloor.Text
                End With
                Com.ExecuteNonQuery()
                Com.Parameters.Clear()
                Message("Success.")
                AddDataToLvw(LstRoom, txtRoomNo.Text, cboRoomType.Text, cboFloor.Text)
                ClearAll(Me)
                txtRoomNo.Focus()
            Else
                Message("Room No Already Exists.")
                txtRoomNo.Focus()
                txtRoomNo.SelectAll()
            End If
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        LstRoom.Items.Clear()
        Com.CommandText = "Select * from QRoom Order by RoomNo"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(LstRoom, Dr(1), Dr(2), Dr(3))
        Loop
        Dr.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstRoom.SelectedItems
        If btnEdit.Text = "Edit" Then
            For Each Li In Sl
                Exit For
            Next
            txtRoomNo.Text = Li.Text
            cboRoomType.Text = Li.SubItems(1).Text
            cboFloor.Text = Li.SubItems(2).Text
            Ind = Li.Index
            Com.CommandText = "Select ID from tblRooms where RoomNo=" & Li.Text & ""
            Dr = Com.ExecuteReader
            If Dr.Read = True Then
                RID = Dr(0)
            End If
            Dr.Close()
            btnEdit.Text = "Update"
        Else
            Li = LstRoom.Items(Ind)
            Li.Text = txtRoomNo.Text
            Li.SubItems(1).Text = cboRoomType.Text
            Li.SubItems(2).Text = cboFloor.Text
            Com.CommandText = "Update tblRooms set RoomNo=?,PID=?,Floor=? where ID=?"
            With Com.Parameters
                .Add("@RNo", OleDbType.Integer).Value = txtRoomNo.Text
                .Add("@PID", OleDbType.Integer).Value = cboRoomType.SelectedValue
                .Add("@Floor", OleDbType.VarChar).Value = cboFloor.Text
                .Add("@ID", OleDbType.Integer).Value = RID
            End With
            Com.ExecuteNonQuery()
            Com.Parameters.Clear()
            Message("Success.")
            ClearAll(Me)
            cboFloor.SelectedIndex = -1
            txtRoomNo.Focus()
            btnEdit.Text = "Edit"
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstRoom.SelectedItems
        Dim Str As String
        Str = MsgBox("Do you want to Delete this Record?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Hotel Management System")
        If Str = vbOK Then
            For Each Li In Sl
                Exit For
            Next
            Com.CommandText = "Delete from tblRooms where RoomNo=" & Li.Text & ""
            Com.ExecuteNonQuery()
            LstRoom.Items.Remove(Li)
            Message("Success.")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearAll(Me)
        cboFloor.SelectedIndex = -1
        txtRoomNo.Focus()
        btnEdit.Text = "Edit"
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstRoom.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        txtRoomNo.Text = Li.Text
        cboRoomType.Text = Li.SubItems(1).Text
        cboFloor.Text = Li.SubItems(2).Text
        Ind = Li.Index
        Com.CommandText = "Select ID from tblRooms where RoomNo=" & Li.Text & ""
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            RID = Dr(0)
        End If
        Dr.Close()
        btnEdit.Text = "Update"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        btnDelete_Click(sender, e)
    End Sub
End Class