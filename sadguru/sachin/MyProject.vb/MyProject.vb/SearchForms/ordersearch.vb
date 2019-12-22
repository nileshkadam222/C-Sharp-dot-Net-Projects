
Imports System.Data.SqlClient
Public Class ordersearch
    Dim h As helper = New helper
    Dim dv As DataView

    Private Sub ordersearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from OrderInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "OrderInfo")
        dv = New DataView(ds.Tables(0))


        'Clear binding
        '
        cmborid.DataBindings.Clear()
        txtorcuname.DataBindings.Clear()
        txtorprono.DataBindings.Clear()
        txtorprname.DataBindings.Clear()
        txtdate.DataBindings.Clear()
        txtorque.DataBindings.Clear()
        txtorrate.DataBindings.Clear()
        txtoramt.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmborid.DataBindings.Add("text", dv, "Ordid")
        txtorcuname.DataBindings.Add("text", dv, "Custname")
        txtorprono.DataBindings.Add("text", dv, "Prdnum")
        txtorprname.DataBindings.Add("text", dv, "Prdname")
        txtdate.DataBindings.Add("text", dv, "Date")
        txtorque.DataBindings.Add("text", dv, "Quty")
        txtorrate.DataBindings.Add("text", dv, "Rate")
        txtoramt.DataBindings.Add("text", dv, "Amt")
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmborid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub cmborid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from OrderInfo where Ordid ='" & cmborid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtorcuname.Text = dr.GetString(1)
            txtorprono.Text = dr.GetString(2)
            txtorprname.Text = dr.GetString(3)
            txtdate.Text = dr.GetString(4)
            txtorque.Text = dr.GetString(5)
            txtorrate.Text = dr.GetString(6)
            txtoramt.Text = dr.GetString(7)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class