Imports System.Data.SqlClient

Public Class custsearch
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub Custid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from customerInfo where Custid ='" & Custid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtcustname.Text = dr.GetString(1)
            txtcustnumber.Text = dr.GetString(2)
            txtcustadd.Text = dr.GetString(3)
            txtcustphone.Text = dr.GetString(4)
            cmbcustgen.Text = dr.GetString(5)
            txtcustemail.Text = dr.GetString(6)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub custsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from customerInfo ", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "customerInfo")
        dv = New DataView(ds.Tables(0))
        'Clear binding
        '
        Custid.DataBindings.Clear()
        txtcustname.DataBindings.Clear()
        txtcustnumber.DataBindings.Clear()
        txtcustadd.DataBindings.Clear()
        txtcustphone.DataBindings.Clear()
        cmbcustgen.DataBindings.Clear()
        txtcustemail.DataBindings.Clear()


        '
        'data binding 
        '
        con.Close()
        Custid.DataBindings.Add("text", dv, "Custid")
        txtcustname.DataBindings.Add("text", dv, "Custname")
        txtcustnumber.DataBindings.Add("text", dv, "Phno")
        txtcustadd.DataBindings.Add("text", dv, "Address")
        txtcustphone.DataBindings.Add("text", dv, "Pincode")
        cmbcustgen.DataBindings.Add("Text", dv, "Gender")
        txtcustemail.DataBindings.Add("text", dv, "EMail")
        Custid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            Custid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class