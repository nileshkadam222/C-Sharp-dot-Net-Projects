Public Class Assign_batch
    Dim ab As New AssignBatchClass
    Dim ds As New Data.DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim db As New OleDb.OleDbCommandBuilder(da)
    Dim dt As DataTable
    Dim c2 As New projClass1
    Dim con As New OleDb.OleDbConnection(c2.connect)
    Dim dr As Data.DataRow
    Dim comd As New OleDb.OleDbCommand
    Dim i As Integer = -1
    Dim objassignbtch As New AssignbtchClass()


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click

        Me.Close()
    End Sub

    Private Sub Assign_batch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate1DataSet5.stageshow' table. You can move, or remove it, as needed.
        Me.StageshowTableAdapter.Fill(Me.Karate1DataSet5.stageshow)

        objassignbtch.FillCourse()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcourse.SelectedIndexChanged
        objassignbtch.FillBatchBy(objassignbtch.GetCIDBy(cbcourse.SelectedItem))
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If cbbatch.Text = "" Or cbcourse.Text = "" Or cbstageshow.Text = "" Then
            MessageBox.Show("Enter proper values")
        Else

            
            Try


                Dim t1 As String = cbcourse.SelectedItem
                Dim t2 As String = cbbatch.SelectedItem
                Dim t3 As String = cbstageshow.SelectedValue

                da.SelectCommand = New OleDb.OleDbCommand("select * from assignbatch ", con)
                da.SelectCommand.Connection = con
                con.Open()
                da.Fill(ds, "assignbatch")
                dt = ds.Tables("assignbatch")
                dr = dt.NewRow
                dr("ab_course") = t1
                dr("ab_batch") = t2
                dr("ab_stageshow") = t3

                dt.Rows.Add(dr)
                da.Fill(ds, "assignbatch")
                da.Update(ds, "assignbatch")
                con.Close()
                ds = New DataSet
                MessageBox.Show("data added sucessfully")
            Catch ea As Exception
                MessageBox.Show(ea.Message)
                con.Close()
            End Try
        End If


    End Sub

    Private Sub btnfrst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrst.Click
        ab.movefirst()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        ab.movenext()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        ab.moveprevious()
    End Sub

    Private Sub btnlst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlst.Click
        ab.movelast()
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Dim id As String = TextBox1.Text
        Try

            comd = New OleDb.OleDbCommand("delete * from assignbatch where ID=" & id & "", con)
            con.Open()

            comd.ExecuteNonQuery()
            da.Fill(ds, "assignbatch")
            da.Update(ds, "assignbatch")
            con.Close()
            ds = New DataSet
            i = -1
            AssignBatchClass.loadData()
        Catch ex As Exception
            con.Close()

        End Try
        MessageBox.Show("record deleted sucessfully")

        cbstageshow.Text = ""
        cbcourse.Text = ""
        cbbatch.Text = ""

    End Sub
End Class