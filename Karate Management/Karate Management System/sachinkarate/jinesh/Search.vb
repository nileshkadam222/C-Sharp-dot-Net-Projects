Public Class Search
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
        da.SelectCommand = New OleDb.OleDbCommand("select * from applicant where ap_name like '%" & cbappsearch.SelectedValue & "%';", con)
        da.SelectCommand.Connection = con
        da.Fill(ds, "applicant")
        dt = ds.Tables("applicant")
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
        da.SelectCommand = New OleDb.OleDbCommand("select * from Ttrainer where tr_name like '%" & cbtrainsearch.SelectedValue & "%';", con)


        da.SelectCommand.Connection = con
        da.Fill(ds, "Ttrainer")
        dt = ds.Tables("Ttrainer")
        con.Open()

        DataGridView2.DataSource = ds.Tables(0)

        con.Close()
    End Sub

   
    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate1DataSet8.Ttrainer' table. You can move, or remove it, as needed.
        Me.TtrainerTableAdapter.Fill(Me.Karate1DataSet8.Ttrainer)
        'TODO: This line of code loads data into the 'Karate1DataSet7.applicant' table. You can move, or remove it, as needed.
        Me.ApplicantTableAdapter.Fill(Me.Karate1DataSet7.applicant)

    End Sub
End Class