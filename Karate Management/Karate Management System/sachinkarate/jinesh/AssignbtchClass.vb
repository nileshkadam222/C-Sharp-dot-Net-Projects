Public Class AssignbtchClass
    Dim da As New OleDb.OleDbDataAdapter
    Dim db As New OleDb.OleDbCommandBuilder(da)
    Dim c2 As New projClass1
    Dim con As New OleDb.OleDbConnection(c2.connect)
    Dim comd As New OleDb.OleDbCommand

    Sub FillCourse()
        Dim dsCourse As New Data.DataSet

        Try
            con.Open()
            da.SelectCommand = New OleDb.OleDbCommand("SELECT CR_CRSNAME FROM COURSE")
            da.SelectCommand.Connection = con
            da.Fill(dsCourse, "COURSE")
            con.Close()
            If Assign_batch.cbcourse.Items.Count > 0 Then
                Assign_batch.cbcourse.Items.Clear()
            End If
            For i As Integer = 0 To dsCourse.Tables(0).Rows.Count - 1
                Assign_batch.cbcourse.Items.Add(dsCourse.Tables(0).Rows(i).Item(0))
            Next
            Assign_batch.cbcourse.SelectedIndex = 0
        Catch e As Exception
            MsgBox(e.Message)
        Finally
            If (con.State <> ConnectionState.Closed) Then con.Close()
        End Try
    End Sub

    Sub FillBatchBy(ByVal CID As String)
        Dim dsBatch As New Data.DataSet

        Try
            con.Open()
            da.SelectCommand = New OleDb.OleDbCommand("SELECT BT_BTCHNAME FROM BATCH WHERE CID=" & CID)
            da.SelectCommand.Connection = con
            da.Fill(dsBatch, "BATCH")
            con.Close()
            If Assign_batch.cbbatch.Items.Count > 0 Then
                Assign_batch.cbbatch.Items.Clear()
            End If
            For i As Integer = 0 To dsBatch.Tables(0).Rows.Count - 1
                Assign_batch.cbbatch.Items.Add(dsBatch.Tables(0).Rows(i).Item(0))
            Next
            Assign_batch.cbbatch.SelectedIndex = 0

        Catch e As Exception
            MsgBox(e.Message)
        Finally
            If (con.State <> ConnectionState.Closed) Then con.Close()
        End Try
    End Sub

    Function GetCIDBy(ByVal CName As String) As String
        Dim dsBatch As New Data.DataSet
        Dim strReturn As String = ""
        Try
            con.Open()
            da.SelectCommand = New OleDb.OleDbCommand("SELECT CID FROM COURSE WHERE CR_CRSNAME='" & CName & "'")
            da.SelectCommand.Connection = con
            da.Fill(dsBatch, "BATCH")
            con.Close()
            strReturn = dsBatch.Tables(0).Rows(0).Item(0).ToString()

        Catch e As Exception
            MsgBox(e.Message)
        Finally
            If (con.State <> ConnectionState.Closed) Then con.Close()
        End Try
        Return strReturn
    End Function
End Class