
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class suppsearch
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub suppsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from SupplierInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "SupplierInfo")
        dv = New DataView(ds.Tables(0))
        'Clear binding
        '
        cmbsid.DataBindings.Clear()
        txtsname.DataBindings.Clear()
        txtsphno.DataBindings.Clear()
        txtsadd.DataBindings.Clear()
        txtspin.DataBindings.Clear()
        txtemail.DataBindings.Clear()
        txtproductname.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmbsid.DataBindings.Add("text", dv, "Supid")
        txtsname.DataBindings.Add("text", dv, "Supname")
        txtsphno.DataBindings.Add("text", dv, "Phno")
        txtemail.DataBindings.Add("text", dv, "EMID")
        txtspin.DataBindings.Add("text", dv, "Pincode")
        txtproductname.DataBindings.Add("text", dv, "Prodname")
        txtsadd.DataBindings.Add("text", dv, "Address")
        cmbsid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbsid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub cmbsid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from SupplierInfo where Supid='" & cmbsid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtsname.Text = dr.GetString(1)
            txtsphno.Text = dr.GetString(2)
            txtsadd.Text = dr.GetString(3)
            txtspin.Text = dr.GetString(4)
            txtemail.Text = dr.GetString(5)
            txtproductname.Text = dr.GetString(6)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class