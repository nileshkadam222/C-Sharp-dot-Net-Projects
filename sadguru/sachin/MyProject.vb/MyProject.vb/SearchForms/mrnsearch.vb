
Imports System.Data.SqlClient
Public Class mrnsearch
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub

    Private Sub mrnsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from MRNInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "MRNInfo")
        dv = New DataView(ds.Tables(0))


        'Clear binding
        '
        cmbmrnid.DataBindings.Clear()
        txtdate.DataBindings.Clear()
        txtmssupp.DataBindings.Clear()
        txtmrnpid.DataBindings.Clear()
        txtmrnpname.DataBindings.Clear()
        txtmrnquntrec.DataBindings.Clear()
        txtqureject.DataBindings.Clear()
        txtquetotal.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmbmrnid.DataBindings.Add("text", dv, "Mrnid")
        txtdate.DataBindings.Add("text", dv, "MDate")
        txtmssupp.DataBindings.Add("text", dv, "MSuppliers")
        txtmrnpid.DataBindings.Add("text", dv, "MProdid")
        txtmrnpname.DataBindings.Add("text", dv, "MProdname")
        txtmrnquntrec.DataBindings.Add("text", dv, "MQtyrecvd")
        txtqureject.DataBindings.Add("text", dv, "MQtyreject")
        txtquetotal.DataBindings.Add("text", dv, "MTotal")


        cmbmrnid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbmrnid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub cmbmrnid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmrnid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from MRNInfo where Mrnid='" & cmbmrnid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtmssupp.Text = dr.GetString(1)
            txtmrnpid.Text = dr.GetString(2)
            txtmrnpname.Text = dr.GetString(3)
            txtdate.Text = dr.GetString(4)
            txtmrnquntrec.Text = dr.GetString(5)
            txtqureject.Text = dr.GetString(6)
            txtquetotal.Text = dr.GetString(7)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub txtdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtmssupp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmssupp.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtmrnpid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmrnpid.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtmrnpname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmrnpname.TextChanged

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtmrnquntrec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmrnquntrec.TextChanged

    End Sub

    Private Sub txtqureject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqureject.TextChanged

    End Sub

    Private Sub txtquetotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquetotal.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class