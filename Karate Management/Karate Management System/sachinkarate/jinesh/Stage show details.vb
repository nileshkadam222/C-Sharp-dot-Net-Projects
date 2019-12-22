Imports System.Data.OleDb

Public Class Stage_show_details
    Dim s1 As New stageshowClass
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

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub

    Private Sub btnaadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaadd.Click
        If txtdate.Text = "" Or txtlocation.Text = "" Or txtorg.Text = "" Or txtname.Text = "" Or txtphno.Text = "" Then
            MessageBox.Show("Enter proper values")
        Else

            If (txtphno.Text.Length) > 10 Or (txtphno.Text.Length) < 10 Then
                MessageBox.Show("Enter proper values")
            Else

                Try


                    Dim ss1 As String = txtname.Text
                    Dim ss2 As String = txtorg.Text
                    Dim ss3 As Double = Convert.ToDouble(txtphno.Text)
                    Dim ss4 As String = cbkt.Text
                    Dim ss5 As Date = Convert.ToDateTime(txtdate.Text)
                    Dim ss6 As Long = Convert.ToInt64(cbreq.Text)
                    Dim ss7 As String = txtlocation.Text


                    da.SelectCommand = New OleDb.OleDbCommand("select * from stageshow ", con)
                    da.SelectCommand.Connection = con
                    con.Open()
                    da.Fill(ds, "stageshow")
                    dt = ds.Tables("stageshow")
                    dr = dt.NewRow
                    dr("ss_name") = ss1
                    dr("ss_org") = ss2
                    dr("ss_phno") = ss3
                    dr("ss_karatetype") = ss4
                    dr("ss_date") = ss5
                    dr("ss_requirement") = ss6
                    dr("ss_location") = ss7
                    dt.Rows.Add(dr)
                    da.Fill(ds, "stageshow")
                    da.Update(ds, "stageshow")

                    con.Close()
                    ds = New DataSet
                    MessageBox.Show("data added sucessfully")
                Catch ea As Exception
                    MessageBox.Show(ea.Message)
                    con.Close()
                End Try
            End If
        End If

    End Sub

    Private Sub btnfrst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrst.Click
        s1.movefirst()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        s1.movenext()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        s1.moveprevious()
    End Sub

    Private Sub btnlst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlst.Click
        s1.movelast()
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If txtdate.Text = "" Or txtlocation.Text = "" Or txtorg.Text = "" Or txtname.Text = "" Or txtphno.Text = "" Then
            MessageBox.Show("Enter proper values")
        Else

          

            Dim id As Long = Convert.ToInt32(TextBox1.Text)
            Try

                comd = New OleDb.OleDbCommand("delete * from stageshow where ID=" & id & "", con)
                con.Open()

                comd.ExecuteNonQuery()
                da.Fill(ds, "stageshow")
                da.Update(ds, "stageshow")
                con.Close()
                ds = New DataSet
                i = -1
                stageshowClass.loadData()
            Catch ex As Exception
                con.Close()

            End Try
            MessageBox.Show("record deleted sucessfully")
            txtname.Clear()
            txtorg.Clear()
            txtphno.Clear()
            cbkt.Text = ""
            txtdate.ResetText()
            cbreq.Text = ""
            txtlocation.Clear()
        End If


    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        txtname.Text = ""
        txtorg.Text = ""
        txtphno.Text = ""
        cbkt.Text = ""
        txtdate.ResetText()
        cbreq.Text = ""
        txtlocation.Text = ""
    End Sub




    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            con.Open()
            cmd = New OleDbCommand("update stageshow set ss_name='" & txtname.Text & "',ss_org='" & txtorg.Text & "',ss_phno=" & txtphno.Text & ",ss_karatetype='" & cbkt.SelectedItem & "',ss_date='" & Convert.ToDateTime(txtdate.Text) & "',ss_requirement=" & cbreq.SelectedItem & ",ss_location='" & txtlocation.Text & "' where ID=" & TextBox1.Text, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Records updated successfully")
            stageshowClass.loadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        e.KeyChar = Chr(chkChar(Asc(e.KeyChar)))
    End Sub

    Private Sub txtorg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorg.KeyPress
        e.KeyChar = Chr(chkChar(Asc(e.KeyChar)))
    End Sub

    Private Sub txtlocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlocation.KeyPress
        e.KeyChar = Chr(chkChar(Asc(e.KeyChar)))
    End Sub

    Private Sub txtphno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphno.KeyPress
        e.KeyChar = Chr(chkInt(Asc(e.KeyChar)))
    End Sub




  
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Stage_show_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class