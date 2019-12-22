Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmemployeedetails
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim cmd As New SqlCommand("insert into Employee_Details values('" & cboid.Text & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & rbtnmale.Text & "','" & rbtnfemale.Text & "','" & txtadd.Text & "','" & txtstate.Text & "','" & txtqualification.Text & "','" & txttelephone.Text & "','" & txtdes.Text & "','" & txtdate.Text & "','" & txtstatu.Text & "','" & txtgross.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Records are successfully....", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        cn.Close()

        Dim da As New SqlDataAdapter("select * from Employee_Details", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Employee_Details")
        DataGridView1.DataSource = ds.Tables("Employee_Details")

    End Sub

    Private Sub btnveiw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveiw.Click
        Dim da As New SqlDataAdapter("select * from Employee_Details", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Employee_Details")
        DataGridView1.DataSource = ds.Tables("Employee_Details")

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim cmd As New SqlCommand("delete from Employee_Details where Emp_ID='" & cboid.Text & "'", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox(" Record are successfully deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        cn.Close()

        cboid.Text = ""
        txtadd.Text = ""
        txtdate.Text = ""
        txtdes.Text = ""
        txtemail.Text = ""
        txtfname.Text = ""
        txtgross.Text = ""
        txtid.Text = ""
        txtlname.Text = ""
        txtmname.Text = ""
        txtqualification.Text = ""
        txtstate.Text = ""
        txtstatu.Text = ""
        txttelephone.Text = ""

    End Sub

    Private Sub cboid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from Employee_Details where Emp_ID='" & cboid.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboid.Text = dr.GetString(0)
            txtfname.Text = dr.GetString(1)
            txtmname.Text = dr.GetString(2)
            txtlname.Text = dr.GetString(3)
            txtgender.Text = dr.GetString(4)
            If txtgender.Text = "Male" Then
                rbtnmale.Checked = True
                txtgender.Visible = False
            ElseIf txtgender.Text = "Female" Then
                rbtnfemale.Checked = True
                txtgender.Visible = False
            End If
            txtemail.Text = dr.GetString(5)
            txtstate.Text = dr.GetString(6)
            txtadd.Text = dr.GetString(7)
            txtqualification.Text = dr.GetString(8)
            txttelephone.Text = dr.GetString(9)
            txtdes.Text = dr.GetString(10)
            txtdate.Text = dr.GetString(11)
            txtstatu.Text = dr.GetString(12)
            txtgross.Text = dr.GetString(13)
        End While
        dr.Close()
        cn.Close()
    End Sub

   
    Private Sub frmemployeedetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmda As New SqlCommand("select * from Employee_Details", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmda.ExecuteReader
        While dr.Read
            cboid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        cn.Close()
    End Sub

    'Private Sub rbtnmale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnmale.CheckedChanged
    '    If rbtnmale.Text = "male" Then
    'End Sub

    Private Sub rbtnmale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnmale.CheckedChanged
        txtgender.Text = "Male"
    End Sub

    Private Sub rbtnfemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnfemale.CheckedChanged
        txtgender.Text = "Female"
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub

    Private Sub txtgender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgender.TextChanged

    End Sub

    Private Sub btndeduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeduct.Click
        Me.Hide()
        Deduction.Show()
    End Sub
End Class