Imports System.Data.OleDb
Public Class Courses
    Dim c As New courseClass
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

    Private Sub btnfrst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrst.Click
        c.movefirst()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        c.movenext()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        c.moveprevious()
    End Sub

    Private Sub btnlst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlst.Click
        c.movelast()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtcourse.Text = "" Or txtfees.Text = "" Or cbduration.Text = "" Or cbkt.Text = "" Then
            MessageBox.Show("Enter proper values")
        Else


            Try


                Dim t1 As String = cbkt.Text
                Dim t2 As String = txtcourse.Text
                Dim t3 As Long = Convert.ToInt64(cbduration.Text)
                Dim t4 As Long = Convert.ToInt64(txtfees.Text)
                da.SelectCommand = New OleDb.OleDbCommand("select * from course ", con)
                da.SelectCommand.Connection = con
                con.Open()
                da.Fill(ds, "course")
                dt = ds.Tables("course")
                dr = dt.NewRow
                dr("cr_karatetype") = t1
                dr("cr_crsname") = t2
                dr("cr_duration") = t3
                dr("cr_fees") = t4
                dt.Rows.Add(dr)
                da.Fill(ds, "course")
                da.Update(ds, "course")
                con.Close()
                ds = New DataSet
                MessageBox.Show("data added sucessfully")
            Catch ea As Exception
                MessageBox.Show(ea.Message)
                con.Close()
            End Try
        End If

    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If txtcourse.Text = "" Or txtfees.Text = "" Or cbduration.Text = "" Or cbkt.Text = "" Then
            MessageBox.Show("Enter proper values")
        Else


            Dim id As Integer = Convert.ToInt32(TextBox1.Text)
            Try

                comd = New OleDb.OleDbCommand("delete * from course where CID=" & id & "", con)
                con.Open()

                comd.ExecuteNonQuery()
                da.Fill(ds, "course")
                da.Update(ds, "course")
                con.Close()
                ds = New DataSet
                i = -1
                courseClass.loadData()
            Catch ex As Exception
                con.Close()

            End Try
            MessageBox.Show("record deleted sucessfully")

            cbkt.Text = ""
            txtcourse.Text = ""
            cbduration.Text = ""
            txtfees.Clear()
        End If



    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        cbkt.Text = ""
        txtcourse.Text = ""
        cbduration.Text = ""
        txtfees.Clear()
    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            con.Open()
            cmd = New OleDbCommand("update course set cr_karatetype='" & cbkt.SelectedItem & "',cr_crsname='" & txtcourse.Text & "',cr_duration=" & cbduration.SelectedItem & ",cr_fees=" & txtfees.Text & "  where CID=" & TextBox1.Text, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Records updated successfully")
            courseClass.loadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

   

    Private Sub txtfees_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfees.KeyPress
        e.KeyChar = Chr(chkInt(Asc(e.KeyChar)))
    End Sub



   
End Class