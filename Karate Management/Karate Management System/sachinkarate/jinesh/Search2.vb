Public Class Search2
    Dim ds As New Data.DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim db As New OleDb.OleDbCommandBuilder(da)
    Dim dt As DataTable
    Dim c2 As New projClass1
    Dim con As New OleDb.OleDbConnection(c2.connect)
    Dim dr As Data.DataRow
    Dim dv As DataView
    Dim comd As New OleDb.OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Visible = True
        ds = New DataSet
        da.SelectCommand = New OleDb.OleDbCommand("select * from stageshow where ss_name like '%" & cbsssearch.SelectedValue & "%';", con)


        da.SelectCommand.Connection = con
        da.Fill(ds, "stageshow")
        dt = ds.Tables("stageshow")
        con.Open()

        DataGridView1.DataSource = ds.Tables(0)

        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView2.Visible = True
        ds = New DataSet
        da.SelectCommand = New OleDb.OleDbCommand("select * from assignbatch where ab_batch like '%" & cbabsearch.SelectedValue & "%';", con)


        da.SelectCommand.Connection = con
        da.Fill(ds, "assignbatch")
        dt = ds.Tables("assignbatch")
        con.Open()

        DataGridView2.DataSource = ds.Tables(0)

        con.Close()
    End Sub

    Private Sub Search2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate1DataSet12.assignbatch' table. You can move, or remove it, as needed.
        Me.AssignbatchTableAdapter.Fill(Me.Karate1DataSet12.assignbatch)
        'TODO: This line of code loads data into the 'Karate1DataSet11.stageshow' table. You can move, or remove it, as needed.
        Me.StageshowTableAdapter.Fill(Me.Karate1DataSet11.stageshow)
        'TODO: This line of code loads data into the 'Karate1DataSet12.assignbatch' table. You can move, or remove it, as needed.
        Me.AssignbatchTableAdapter.Fill(Me.Karate1DataSet12.assignbatch)
        'TODO: This line of code loads data into the 'Karate1DataSet11.stageshow' table. You can move, or remove it, as needed.
        Me.StageshowTableAdapter.Fill(Me.Karate1DataSet11.stageshow)

    End Sub
End Class