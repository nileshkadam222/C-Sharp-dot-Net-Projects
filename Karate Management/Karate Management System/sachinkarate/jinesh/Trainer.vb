Imports System.Data.OleDb

Public Class Trainer
    Dim t As New trainerClass
    Dim ds As New Data.DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim db As New OleDb.OleDbCommandBuilder(da)
    Dim cmd As New OleDbCommand
    Dim dt As DataTable
    Dim c2 As New projClass1
    Dim con As New OleDb.OleDbConnection(c2.connect)
    Dim dr As Data.DataRow
    Dim dv As DataView
    Dim comd As New OleDb.OleDbCommand
    Dim i As Integer = -1

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub



    Private Sub btnfrst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrst.Click
        t.movefirst()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        t.movenext()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        t.moveprevious()
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        t.movelast()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtname.Text = "" Or txtadd.Text = "" Or txtage.Text = "" Or txtjoin.Text = "" Or txtphno.Text = "" Or txtexp.Text = "" Or cbgender.Text = "" Or cbkt.Text = "" Or cbbatch.Text = "" Then
            MessageBox.Show("please enter correct values")
        Else

            If (txtphno.Text.Length) > 10 Or (txtphno.Text.Length) < 10 Then
                MessageBox.Show("please enter proper phone number")
                txtphno.Text = ""
                txtphno.Focus()

            Else
                If (txtage.Text.Length) > 35 And (txtage.Text.Length) < 21 Then
                    MessageBox.Show("please enter proper age")
                    txtage.Text = ""
                    txtage.Focus()
                Else
                    Try


                        Dim t1 As String = txtname.Text
                        Dim t2 As String = txtadd.Text
                        Dim t3 As Double = Convert.ToDouble(txtphno.Text)
                        Dim t4 As Long = Convert.ToInt64(txtage.Text)
                        Dim t5 As String = cbgender.SelectedItem
                        Dim t6 As Date = Convert.ToDateTime(txtjoin.Text)
                        Dim t7 As String = txtexp.Text
                        Dim t8 As String = cbkt.SelectedItem

                        Dim t9 As String = cbbatch.SelectedValue

                        da.SelectCommand = New OleDb.OleDbCommand("select * from Ttrainer ", con)
                        da.SelectCommand.Connection = con
                        con.Open()
                        da.Fill(ds, "Ttrainer")
                        dt = ds.Tables("Ttrainer")
                        dr = dt.NewRow
                        dr("tr_name") = t1
                        dr("tr_address") = t2
                        dr("tr_phoneno") = t3
                        dr("tr_age") = t4
                        dr("tr_gender") = t5
                        dr("tr_joindate") = t6
                        dr("tr_exp") = t7
                        dr("tr_karatetype") = t8
                        dr("tr_batch") = t9
                        dt.Rows.Add(dr)
                        da.Fill(ds, "Ttrainer")
                        da.Update(ds, "Ttrainer")

                        con.Close()
                        ds = New DataSet
                        MessageBox.Show("data added sucessfully")
                    Catch ea As Exception
                        MessageBox.Show(ea.Message)
                        con.Close()
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
       
        Dim id As Integer = Convert.ToInt32(txttrainid.Text)
        Try

            comd = New OleDb.OleDbCommand("delete * from Ttrainer where ID=" & id & "", con)
            con.Open()

            comd.ExecuteNonQuery()
            da.Fill(ds, "Ttrainer")
            da.Update(ds, "Ttrainer")
            con.Close()
            ds = New DataSet
            i = -1
            trainerClass.loadData()
        Catch ex As Exception
            con.Close()

        End Try
        MessageBox.Show("record deleted sucessfully")
        txtname.Clear()
        txtadd.Clear()
        txtphno.Clear()
        txtage.Clear()
        cbgender.Text = ""
        txtjoin.ResetText()

        txtexp.Clear()
        cbkt.Text = ""
        cbbatch.Text = ""
         

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        txtname.Text = ""
        txtadd.Text = ""
        txtphno.Text = ""
        txtage.Text = ""
        cbgender.Text = ""
        txtjoin.ResetText()

        txtexp.Text = ""
        cbkt.Text = ""
        cbbatch.Text = ""

    End Sub


    Private Sub Trainer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate1DataSet3.batch' table. You can move, or remove it, as needed.
        Me.BatchTableAdapter.Fill(Me.Karate1DataSet3.batch)

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Try
            con.Open()

            cmd = New OleDbCommand("update Ttrainer set tr_name='" & txtname.Text & "',tr_address='" & txtadd.Text & "',tr_phoneno=" & txtphno.Text & ",tr_age=" & txtage.Text & ",tr_gender='" & cbgender.SelectedItem & "',tr_joindate='" & Convert.ToDateTime(txtjoin.Text) & "',tr_exp='" & txtexp.Text & "',tr_karatetype='" & cbkt.SelectedItem & "',tr_batch='" & cbbatch.SelectedValue & "' where ID=" & txttrainid.Text, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Records updated successfully")
            con.Close()
            trainerClass.loadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        e.KeyChar = Chr(chkChar(Asc(e.KeyChar)))
    End Sub

    Private Sub txtphno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphno.KeyPress
        e.KeyChar = Chr(chkInt(Asc(e.KeyChar)))
    End Sub

    Private Sub txtage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        e.KeyChar = Chr(chkInt(Asc(e.KeyChar)))
    End Sub



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class