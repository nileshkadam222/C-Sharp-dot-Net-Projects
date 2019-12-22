Imports System.Data.OleDb


Public Class Applicant
    Dim a As New applicantClass
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



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrst.Click
        a.movefirst()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click

        a.movenext()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click

        a.moveprevious()
    End Sub

    Private Sub btnlst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlst.Click

        a.movelast()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtname.Text = "" Or txtadd.Text = "" Or txtage.Text = "" Or txtjoin.Text = "" Or txtphno.Text = "" Or cbgender.Text = "" Or cbkt.Text = "" Or cbbatch.Text = "" Then
            MessageBox.Show("please enter correct values")
        Else


            If (txtphno.Text.Length) > 10 Or (txtphno.Text.Length) < 10 Then
                MessageBox.Show("please enter proper phone number")
                txtphno.Text = ""
                txtphno.Focus()
            Else
                If (txtage.Text.Length) > 30 And (txtage.Text.Length) < 10 Then
                    MessageBox.Show("please enter proper age")
                    txtage.Text = ""
                    txtage.Focus()

                Else
                    Try
                        Dim ap1 As String = txtname.Text
                        Dim ap2 As String = txtadd.Text
                        Dim ap3 As Double = Convert.ToDouble(txtphno.Text)
                        Dim ap4 As Long = Convert.ToInt64(txtage.Text)
                        Dim ap5 As String = cbgender.SelectedItem
                        Dim ap6 As Date = Convert.ToDateTime(txtjoin.Text)
                        Dim ap7 As String = cbkt.SelectedItem
                        Dim ap8 As String = cbbatch.SelectedValue


                        da.SelectCommand = New OleDb.OleDbCommand("select * from applicant", con)
                        da.SelectCommand.Connection = con
                        con.Open()
                        da.Fill(ds, "applicant")
                        dt = ds.Tables("applicant")
                        dr = dt.NewRow
                        dr("ap_name") = ap1
                        dr("ap_address") = ap2
                        dr("ap_phoneno") = ap3
                        dr("ap_age") = ap4
                        dr("ap_gender") = ap5
                        dr("ap_joindate") = ap6
                        dr("ap_karatetype") = ap7
                        dr("ap_batch") = ap8
                        dt.Rows.Add(dr)
                        da.Fill(ds, "applicant")
                        da.Update(ds, "applicant")

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

        Dim id As Integer = Convert.ToInt32(txtappid.Text)
        Try

            comd = New OleDb.OleDbCommand("delete * from applicant where ID=" & id & "", con)
            con.Open()

            comd.ExecuteNonQuery()
            da.Fill(ds, "applicant")
            da.Update(ds, "applicant")
            con.Close()
            ds = New DataSet
            i = -1
            applicantClass.loadData()
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
        cbkt.Text = ""
        cbbatch.Text = ""
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            con.Open()
            cmd = New OleDbCommand("update applicant set ap_name='" & txtname.Text & "',ap_address='" & txtadd.Text & "',ap_phoneno=" & txtphno.Text & ",ap_age=" & txtage.Text & ",ap_gender='" & cbgender.SelectedItem & "',ap_joindate='" & Convert.ToDateTime(txtjoin.Text) & "',ap_karatetype='" & cbkt.SelectedItem & "',ap_batch='" & cbbatch.SelectedValue & "' where ID=" & txtappid.Text, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Records updated successfully")
            applicantClass.loadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub Applicant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate1DataSet2.batch' table. You can move, or remove it, as needed.
        Me.BatchTableAdapter.Fill(Me.Karate1DataSet2.batch)

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
