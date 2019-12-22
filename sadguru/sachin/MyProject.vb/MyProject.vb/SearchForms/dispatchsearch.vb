Imports System.Data.SqlClient
Public Class dispatchsearch
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub dispatchsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from DispatchInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "DispatchInfo")
        dv = New DataView(ds.Tables(0))
        'Clear binding
        '
        cmbdisid.DataBindings.Clear()
        txtdisto.DataBindings.Clear()
        txtquesend.DataBindings.Clear()
        disdate.DataBindings.Clear()
        txtdisfrom.DataBindings.Clear()
        txtamt.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmbdisid.DataBindings.Add("text", dv, "Dispno")
        txtdisto.DataBindings.Add("text", dv, "Dispto")
        txtquesend.DataBindings.Add("text", dv, "Qtysend")
        disdate.DataBindings.Add("text", dv, "Date")
        txtdisfrom.DataBindings.Add("text", dv, "Dispfrm")
        txtamt.DataBindings.Add("Text", dv, "Amount")
        con.Close()
        cmbdisid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbdisid.Items.Add(dr.GetString(0))

        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub cmbdisid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdisid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from DispatchInfo  where Dispno='" & cmbdisid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtdisto.Text = dr.GetString(1)
            txtdisfrom.Text = dr.GetString(2)
            disdate.Text = dr.GetString(3)
            txtquesend.Text = dr.GetString(4)
            txtamt.Text = dr.GetString(5)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class