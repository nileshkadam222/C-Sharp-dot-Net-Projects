Public Class SEARCH1
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
        da.SelectCommand = New OleDb.OleDbCommand("select * from course where cr_crsname like '%" & cbcoursesearch.SelectedValue & "%';", con)


        da.SelectCommand.Connection = con
        da.Fill(ds, "course")
        dt = ds.Tables("course")
        con.Open()

        DataGridView1.DataSource = ds.Tables(0)

        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView2.Visible = True
        ds = New DataSet
        da.SelectCommand = New OleDb.OleDbCommand("select * from batch where bt_btchname like '%" & cbbatchsearch.SelectedValue & "%';", con)


        da.SelectCommand.Connection = con
        da.Fill(ds, "batch")
        dt = ds.Tables("batch")
        con.Open()

        DataGridView2.DataSource = ds.Tables(0)

        con.Close()
    End Sub

   
    Private Sub SEARCH1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate1DataSet10.batch' table. You can move, or remove it, as needed.
        Me.BatchTableAdapter.Fill(Me.Karate1DataSet10.batch)
        'TODO: This line of code loads data into the 'Karate1DataSet9.course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.Karate1DataSet9.course)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class