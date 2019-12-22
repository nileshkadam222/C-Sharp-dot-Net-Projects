Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmpurchesitem
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpost.Click
        MsgBox("Are you sure to post a previous form", MsgBoxStyle.Information)
        frminventorydetails.Show()
        Me.Hide()
    End Sub

    Private Sub cbosuppiler_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosuppiler.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from Supplier where Supplier_name='" & cbosuppiler.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cbosuppiler.Text = dr.GetString(1)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub frmitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As New SqlDataAdapter("select * from purchaseitem", cn)
        Dim ds As New DataSet
        da.Fill(ds, "purchaseitem")
        DataGridView1.DataSource = ds.Tables("purchaseitem")

        Dim cmd As New SqlCommand("select * from Supplier", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cbosuppiler.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        cn.Close()

        Dim cmdsr As New SqlCommand("Select * from  selling_price_entry ", cn)
        cn.Open()
        Dim drsr As SqlDataReader = cmdsr.ExecuteReader
        While drsr.Read
            cboname.Items.Add(drsr.GetString(0))
        End While
        drsr.Close()
        cn.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtrrno.Text = "" Then
            MsgBox(" Do not accept empty feiled ")
        End If
        Dim da As New SqlDataAdapter("select * from purchaseitem", cn)
        If txtrrno.Text = "" Or cbosuppiler.Text = "" Or cboname.Text = "" Or txtunit.Text = "" Or txtqty.Text = "" Then
            MsgBox("The R.R. No. is not accpt empty feild!")
        End If
        Dim cmd As New SqlCommand("insert into purchaseitem values('" & txtrrno.Text & " ','" & cbosuppiler.Text & "','" & DateTimePicker1.Value & "','" & cboname.Text & "','" & txtunit.Text & "','" & txtqty.Text & "','" & txttotal.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        cn.Close()
        Dim da1 As New SqlDataAdapter("select * from purchaseitem", cn)
        Dim ds As New DataSet
        da1.Fill(ds, "purchaseitem")
        DataGridView1.DataSource = ds.Tables("purchaseitem")
        
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from selling_price_entry where name='" & cboname.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboname.Text = dr.GetString(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Try
            Dim cmd As New SqlCommand("Delete from purchaseitem where Supplier='" & cbosuppiler.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtrrno.Text = ""
            cbosuppiler.Text = ""
            DateTimePicker1.Value = Now
            cboname.Text = ""
            txtunit.Text = ""
            txtqty.Text = ""
            txttotal.Text = ""
            Dim da As New SqlDataAdapter("select * from purchaseitem", cn)
            Dim ds As New DataSet
            da.Fill(ds, "purchaseitem")
            DataGridView1.DataSource = ds.Tables("purchaseitem")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class