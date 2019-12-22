
Imports System.Data.SqlClient
Public Class productsearch
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from ProductInfo where prdid='" & ComboBox1.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            TextBox2.Text = dr.GetString(1)
            TextBox3.Text = dr.GetString(2)
            TextBox4.Text = dr.GetString(3)
            TextBox5.Text = dr.GetString(4)
            TextBox6.Text = dr.GetString(5)
            TextBox7.Text = dr.GetString(6)
        End While
        dr.Close()
        con.Close()
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
    Private Sub productsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from ProductInfo  ORDER BY Prdid", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "ProductInfo")
        dv = New DataView(ds.Tables(0))

        'Clear binding
        '
        ComboBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        '
        'data binding 
        '
        con.Close()
        ComboBox1.DataBindings.Add("text", dv, "Prdid")
        TextBox2.DataBindings.Add("text", dv, "Prdname")
        TextBox3.DataBindings.Add("text", dv, "Prdqty")
        TextBox6.DataBindings.Add("text", dv, "Qtyonhand")
        TextBox5.DataBindings.Add("text", dv, "Reordrlevel")
        TextBox7.DataBindings.Add("text", dv, "Price")
        TextBox4.DataBindings.Add("text", dv, "Prddescription")

        ComboBox1.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class