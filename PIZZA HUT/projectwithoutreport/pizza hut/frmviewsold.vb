Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmviewsold
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim cmd As New SqlCommand("Delete from view_sold_product where code_id='" & cbocodeno.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            cbocodeno.Text = ""
            txtcode.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            cbotransactiontype.Text = ""
            DateTimePicker1.Value = Now
            txtproduct.Text = ""
            txtunit.Text = ""
            cbosize.Text = ""
            txtqty.Text = ""
            txtpacking.Text = ""
            txtqtymaterials.Text = ""
            txtremarks.Text = ""


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub cbocodeno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocodeno.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from view_sold_product where code_id='" & cbocodeno.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtcode.Text = dr.GetString(0)
            TextBox1.Text = dr.GetString(1)
            TextBox2.Text = dr.GetString(2)
            DateTimePicker1.Value = dr.GetString(4)
            txtproduct.Text = dr.GetString(5)
            txtunit.Text = dr.GetString(6)
            txtqty.Text = dr.GetString(8)
            txtprice.Text = dr.GetString(9)
            txtamount.Text = dr.GetString(10)
            txtpacking.Text = dr.GetString(11)
            txtqtymaterials.Text = dr.GetString(12)
            txtremarks.Text = dr.GetString(13)
        End While
        dr.Close()
        cn.Close()
    End Sub
    Private Sub cbosize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosize.SelectedIndexChanged
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Dim cmd As New SqlCommand("select * from view_sold_product where size='" & cbosize.Text & "'", cn)
        cn.Open()
        Dim dr5 As SqlDataReader = cmd.ExecuteReader
        While dr5.Read
            txtcode.Text = dr5.GetString(0)
            TextBox1.Text = dr5.GetString(1)
            TextBox2.Text = dr5.GetString(2)
            DateTimePicker1.Value = dr5(4)
            txtproduct.Text = dr5.GetString(5)
            txtunit.Text = dr5.GetString(6)
            txtqty.Text = dr5(8)
            txtprice.Text = dr5.GetString(9)
            txtpacking.Text = dr5.GetString(11)
            txtqtymaterials.Text = dr5.GetString(12)
            txtremarks.Text = dr5.GetString(13)
        End While
        dr5.Close()
        cn.Close()
    End Sub

    Private Sub frmviewsold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from view_sold_product", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cbocodeno.Items.Add(dr.GetString(0))
            cbosize.Items.Add(dr.GetString(7))
            cbotransactiontype.Items.Add(dr.GetString(3))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub cbotransactiontype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotransactiontype.SelectedIndexChanged
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Dim cmd As New SqlCommand("select * from view_sold_product where Transaction_Type='" & cbotransactiontype.Text & "'", cn)
        cn.Open()
        Dim dr4 As SqlDataReader = cmd.ExecuteReader
        While dr4.Read
            txtcode.Text = dr4.GetString(0)
            TextBox1.Text = dr4.GetString(1)
            TextBox2.Text = dr4.GetString(2)
            DateTimePicker1.Value = dr4(4)
            txtproduct.Text = dr4.GetString(5)
            txtunit.Text = dr4.GetString(6)
            txtqty.Text = dr4.GetString(8)
            txtprice.Text = dr4.GetString(9)
            txtpacking.Text = dr4.GetString(11)
            txtqtymaterials.Text = dr4.GetString(12)
            txtremarks.Text = dr4.GetString(13)
        End While
        dr4.Close()
        cn.Close()
    End Sub
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMDIParent.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        searchveiwsold.Show()
    End Sub

    Private Sub txtamount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount.GotFocus
        txtamount.Text = Val(txtqty.Text) * Val(txtprice.Text)
    End Sub

    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmdsave As New SqlCommand("insert into view_sold_product values('" & txtcodeno.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & " ',' " & cbotransactiontype.Text & "','" & DateTimePicker1.Value & "','" & txtproduct.Text & "','" & txtunit.Text & "','" & cbosize.Text & "','" & txtqty.Text & "','" & txtprice.Text & "','" & txtamount.Text & "','" & txtpacking.Text & "','" & txtqtymaterials.Text & "','" & txtremarks.Text & "')", cn)
            cn.Open()
            cmdsave.ExecuteNonQuery()
            MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim da As New SqlDataAdapter("select * from view_sold_product where code_id='" & cbocodeno.Text & "'", cn)
        cn.Open()
        Dim ds As New DataSet
        da.Fill(ds, "view_sold_product")
        DataGridView1.DataSource = ds.Tables(0)
        cn.Close()

    End Sub

    Private Sub btnadditem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadditem.Click
        If txtpacking.Text = "" Or txtqtymaterials.Text = "" Then
            MsgBox("can not have empty feild..............")

        End If
    End Sub

    Private Sub btndelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from view_sold_product where Prod_id='" & cbocodeno.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtcode.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            cbotransactiontype.Text = ""
            DateTimePicker1.Value = Now
            txtproduct.Text = ""
            txtunit.Text = ""
            cbosize.Text = ""
            txtqty.Text = ""
            txtprice.Text = ""
            txtamount.Text = ""
            txtpacking.Text = ""
            txtqtymaterials.Text = ""
            txtremarks.Text = ""
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim rec As New SqlCommand("select * from view_sold_product", cn)
        cn.Open()
        Dim dr As SqlDataReader = rec.ExecuteReader
        While dr.Read
            txtcodeno.Text = dr(0)
        End While
        txtcodeno.Text = "00" & Val(txtcodeno.Text) + 1
        txtcode.Text = Val(txtcode.Text) + 1
        dr.Close()
        cn.Close()
        txtcodeno.Enabled = False
    End Sub
End Class