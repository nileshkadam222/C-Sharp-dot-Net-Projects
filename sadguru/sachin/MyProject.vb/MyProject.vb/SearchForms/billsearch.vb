
Imports System.Data.SqlClient
Public Class billsearch
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub cmbbillno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbillno.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from  BillInfo where Bid='" & cmbbillno.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtbname.Text = dr.GetString(1)
            txtbpno.Text = dr.GetString(2)
            txtbpname.Text = dr.GetString(3)
            txtdate.Text = dr.GetString(4)
            txtbquentity.Text = dr.GetString(5)
            txtbrate.Text = dr.GetString(6)
            txtbamt.Text = dr.GetString(7)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub billsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from BillInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "BillInfo")
        dv = New DataView(ds.Tables(0))
        'dgvpat.DataSource = dv

        'Clear binding
        '
        con.Close()
        cmbbillno.DataBindings.Clear()
        txtbname.DataBindings.Clear()
        txtbpno.DataBindings.Clear()
        txtbpname.DataBindings.Clear()
        txtdate.DataBindings.Clear()
        txtbquentity.DataBindings.Clear()
        txtbrate.DataBindings.Clear()
        txtbamt.DataBindings.Clear()
        '
        'data binding 
        '
        cmbbillno.DataBindings.Add("text", dv, "Bid")
        txtbname.DataBindings.Add("text", dv, "Name")
        txtbpno.DataBindings.Add("text", dv, "Pid")
        txtbpname.DataBindings.Add("text", dv, "Prdname")
        txtdate.DataBindings.Add("text", dv, "Date")
        txtbquentity.DataBindings.Add("text", dv, "Qty")
        txtbrate.DataBindings.Add("text", dv, "Rate")
        txtbamt.DataBindings.Add("text", dv, "Amt")


        cmbbillno.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbbillno.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class