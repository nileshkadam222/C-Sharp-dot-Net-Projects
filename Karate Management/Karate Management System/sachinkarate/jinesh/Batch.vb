Imports System.Data.OleDb

Public Class Batch
    Dim b1 As New batchClass
    Dim ds As New Data.DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim db As New OleDb.OleDbCommandBuilder(da)
    Dim dt As DataTable
    Dim c2 As New projClass1
    Dim con As New OleDb.OleDbConnection(c2.connect)
    Dim dr As Data.DataRow
    Dim dv As DataView
    Dim comd As New OleDb.OleDbCommand
    Dim cmd As New OleDbCommand
    Dim i As Integer = -1

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub




    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If cbcid.Text = "" Or cbcourse.Text = "" Or txtbtchname.Text = "" Or txtcapacity.Text = "" Or txtstartdate.Text = "" Or txtweek1.Text = "" Or txtweek2.Text = "" Then
            MessageBox.Show("Enter proper values")
        Else



            Try

                Dim t1 As String = cbcourse.SelectedValue
                Dim t2 As String = txtbtchname.Text
                Dim t3 As Date = Convert.ToDateTime(txtweek1.Text)
                Dim t4 As Date = Convert.ToDateTime(txtweek2.Text)
                Dim t5 As Date = Convert.ToDateTime(txtstartdate.Text)
                Dim t6 As Long = Convert.ToInt64(txtcapacity.Text)
                Dim t7 As Long = Convert.ToInt64(cbcid.SelectedValue)
                da.SelectCommand = New OleDb.OleDbCommand("select * from batch ", con)
                da.SelectCommand.Connection = con
                con.Open()
                'da.SelectCommand = New OleDb.OleDbCommand("insert into batch where ", con)
                'da.SelectCommand.Connection = con
                da.Fill(ds, "batch")
                dt = ds.Tables("batch")
                dr = dt.NewRow
                dr("bt_course") = t1
                dr("bt_btchname") = t2
                dr("bt_weekdy1") = t3
                dr("bt_weekdy2") = t4
                dr("bt_startdate") = t5
                dr("bt_capacity") = t6
                dr("CID") = t7
                dt.Rows.Add(dr)
                da.Fill(ds, "batch")
                da.Update(ds, "batch")
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
        b1.movefirst()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        b1.movenext()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        b1.moveprevious()
    End Sub

    Private Sub btnlst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlst.Click
        b1.movelast()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If cbcid.Text = "" Or cbcourse.Text = "" Or txtbtchname.Text = "" Or txtcapacity.Text = "" Or txtstartdate.Text = "" Or txtweek1.Text = "" Or txtweek2.Text = "" Then
            MessageBox.Show("Enter proper values")
        Else


            Dim id As Long = Convert.ToInt32(TextBox1.Text)
            Try

                comd = New OleDb.OleDbCommand("delete * from batch where ID=" & id & "", con)
                con.Open()

                comd.ExecuteNonQuery()
                da.Fill(ds, "batch")
                da.Update(ds, "batch")
                con.Close()
                ds = New DataSet
                i = -1
                batchClass.loadData()
            Catch ex As Exception
                con.Close()

            End Try
            MessageBox.Show("record deleted sucessfully")
            cbcid.Text = ""
            cbcourse.Text = ""
            txtbtchname.Text = ""
            txtweek1.ResetText()
            txtweek2.ResetText()
            txtstartdate.ResetText()
            txtcapacity.Text = ""
        End If

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        cbcourse.Text = ""
        txtbtchname.Text = ""
        txtweek1.ResetText()
        txtweek2.ResetText()
        txtstartdate.ResetText()
        txtcapacity.Text = ""
        cbcid.Text = ""
    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            con.Open()
            cmd = New OleDbCommand("update batch set CID=" & cbcid.SelectedValue & ",bt_course='" & cbcourse.SelectedValue & "',bt_btchname='" & txtbtchname.Text & "',bt_weekdy1='" & Convert.ToDateTime(txtweek1.Text) & "',bt_weekdy2='" & Convert.ToDateTime(txtweek2.Text) & "',bt_startdate='" & Convert.ToDateTime(txtstartdate.Text) & "',bt_capacity=" & txtcapacity.Text & " where ID=" & TextBox1.Text, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Records updated successfully")
            batchClass.loadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Batch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate1DataSet6.course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter1.Fill(Me.Karate1DataSet6.course)
        'TODO: This line of code loads data into the 'Karate1DataSet4.course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.Karate1DataSet4.course)

    End Sub

    Private Sub txtcapacity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcapacity.KeyPress
        e.KeyChar = Chr(chkInt(Asc(e.KeyChar)))
    End Sub



    Private Sub cbcourse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcourse.SelectedIndexChanged

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class