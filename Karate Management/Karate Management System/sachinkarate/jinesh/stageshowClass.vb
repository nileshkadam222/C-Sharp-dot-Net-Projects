Public Class stageshowClass
    Shared ds As New Data.DataSet
    Shared da As New OleDb.OleDbDataAdapter
    Dim db As New OleDb.OleDbCommandBuilder(da)
    Shared dt As DataTable
    Shared c2 As New projClass1
    Shared con As New OleDb.OleDbConnection(c2.connect)
    Dim dr As Data.DataRow
    Dim comd As New OleDb.OleDbCommand
    Dim i As Integer = -1

    Public Shared Function loadData()
        da.SelectCommand = New OleDb.OleDbCommand("select * from stageshow")
        da.SelectCommand.Connection = con
        da.Fill(ds, "stageshow")
        dt = ds.Tables("stageshow")
        Return 1
    End Function

    Function movefirst()

        Try
            i = 0
            loadData()
            con.Open()
            Stage_show_details.txtname.Text = ds.Tables(0).Rows(i).Item(0)
            Stage_show_details.txtorg.Text = ds.Tables(0).Rows(i).Item(1)
            Stage_show_details.txtphno.Text = ds.Tables(0).Rows(i).Item(2)
            Stage_show_details.cbkt.Text = ds.Tables(0).Rows(i).Item(3)
            Stage_show_details.txtdate.Text = ds.Tables(0).Rows(i).Item(4)
            Stage_show_details.cbreq.Text = ds.Tables(0).Rows(i).Item(5)
            Stage_show_details.txtlocation.Text = ds.Tables(0).Rows(i).Item(6)
            Stage_show_details.TextBox1.Text = ds.Tables(0).Rows(i).Item(7)



        Catch e As Exception
            MessageBox.Show("end of data")
            i = 0
            con.Close()
        End Try
        con.Close()

        Return 1
    End Function
    Function movenext()

        Try
            i = i + 1
            loadData()
            con.Open()
            Stage_show_details.txtname.Text = ds.Tables(0).Rows(i).Item(0)
            Stage_show_details.txtorg.Text = ds.Tables(0).Rows(i).Item(1)
            Stage_show_details.txtphno.Text = ds.Tables(0).Rows(i).Item(2)
            Stage_show_details.cbkt.Text = ds.Tables(0).Rows(i).Item(3)
            Stage_show_details.txtdate.Text = ds.Tables(0).Rows(i).Item(4)
            Stage_show_details.cbreq.Text = ds.Tables(0).Rows(i).Item(5)
            Stage_show_details.txtlocation.Text = ds.Tables(0).Rows(i).Item(6)
            Stage_show_details.TextBox1.Text = ds.Tables(0).Rows(i).Item(7)


        Catch e As Exception
            MessageBox.Show("last record")
            i = 0
            con.Close()
        End Try
        con.Close()

        Return 1
    End Function
    Function moveprevious()

        Try

            i = i - 1
            loadData()
            con.Open()
            Stage_show_details.txtname.Text = ds.Tables(0).Rows(i).Item(0)
            Stage_show_details.txtorg.Text = ds.Tables(0).Rows(i).Item(1)
            Stage_show_details.txtphno.Text = ds.Tables(0).Rows(i).Item(2)
            Stage_show_details.cbkt.Text = ds.Tables(0).Rows(i).Item(3)
            Stage_show_details.txtdate.Text = ds.Tables(0).Rows(i).Item(4)
            Stage_show_details.cbreq.Text = ds.Tables(0).Rows(i).Item(5)
            Stage_show_details.txtlocation.Text = ds.Tables(0).Rows(i).Item(6)

            Stage_show_details.TextBox1.Text = ds.Tables(0).Rows(i).Item(7)

        Catch e As Exception
            MessageBox.Show("first record" + e.Message)
            i = 0
            con.Close()
        End Try
        con.Close()

        Return 1
    End Function
    Function movelast()

        Try

            loadData()
            con.Open()
            Dim i20 As Integer = dt.Rows.Count
            i = i20
            Stage_show_details.txtname.Text = ds.Tables(0).Rows(i - 1).Item(0)
            Stage_show_details.txtorg.Text = ds.Tables(0).Rows(i - 1).Item(1)
            Stage_show_details.txtphno.Text = ds.Tables(0).Rows(i - 1).Item(2)
            Stage_show_details.cbkt.Text = ds.Tables(0).Rows(i - 1).Item(3)
            Stage_show_details.txtdate.Text = ds.Tables(0).Rows(i - 1).Item(4)
            Stage_show_details.cbreq.Text = ds.Tables(0).Rows(i - 1).Item(5)
            Stage_show_details.txtlocation.Text = ds.Tables(0).Rows(i - 1).Item(6)
            Stage_show_details.TextBox1.Text = ds.Tables(0).Rows(i - 1).Item(7)



        Catch e As Exception
            MessageBox.Show("end of data")
            i = 0
            con.Close()
        End Try
        con.Close()

        Return 1
    End Function
End Class
