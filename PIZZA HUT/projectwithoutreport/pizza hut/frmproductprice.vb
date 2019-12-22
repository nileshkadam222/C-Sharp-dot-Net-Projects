Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmproductprice

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub

    
    Private Sub cbono_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbono.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from Product_price where Order_no='" & cbono.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cbono.Text = dr.GetString(0)
           txtcategory.Text=dr.GetString(1)
            txtname.Text = dr.GetString(2)
            txtqty.Text = dr.GetString(3)
            txtamount.Text = dr.GetString(4)
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub frmproductprice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmd As New SqlCommand("select * from Product_price ", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cbono.Items.Add(dr(0))

        End While
        dr.Close()
        cn.Close()
    End Sub



    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

        Dim cmdsave As New SqlCommand("insert into Product_price values('" & txtno.Text & "','" & txtcategory.Text & "','" & txtname.Text & "','" & txtqty.Text & "','" & txtamount.Text & "','" & txtprice.Text & "') ", cn)
        cn.Open()
        cmdsave.ExecuteNonQuery()
        MsgBox("Record are successfully saved")
        cn.Close()


        Dim da As New SqlDataAdapter("select * from Product_price", cn)
        cn.Open()
        Dim ds As New DataSet
        da.Fill(ds, "Product_price")
        dgv1.DataSource = ds.Tables(0)
        cn.Close()

    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        txtname.Text = cboname.Text

    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Product_price where Order_no='" & cbono.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtcategory.Text = ""
            txtqty.Text = ""
            txtamount.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        Dim da As New SqlDataAdapter("select * from Product_price", cn)
        cn.Open()
        Dim ds As New DataSet
        da.Fill(ds, "Product_price")
        dgv1.DataSource = ds.Tables(0)
        cn.Close()
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        If chkveg.Checked = True Then
            Dim cmd1 As New SqlCommand("update Product_price set Category='" & chkveg.Checked & "',Name='" & cboname.Text & "',Qty='" & txtqty.Text & "',Total_Amount='" & txtamount.Text & "' where Order_no='" & cbono.Text & "'", cn)
            cn.Open()
            cmd1.ExecuteNonQuery()
            MsgBox("record is updated")
            cn.Close()

        ElseIf chknonveg.Checked = True Then
            Dim cmd2 As New SqlCommand("update Product_price set Category='" & chknonveg.Checked & "',Name='" & cboname.Text & "',Qty='" & txtqty.Text & "',Total_Amount='" & txtamount.Text & "' where Order_no='" & cbono.Text & "'", cn)
            cn.Open()
            cmd2.ExecuteNonQuery()
            MsgBox("record is updated")
            cn.Close()
        End If

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim rec As New SqlCommand("select * from Product_price", cn)
        cn.Open()
        Dim dr As SqlDataReader = rec.ExecuteReader
        While dr.Read
            txtno.Text = dr(0)
        End While
        txtno.Text = "00" & Val(txtno.Text) + 1
        dr.Close()
        cn.Close()
        txtno.Enabled = False
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub




    Private Sub chknonveg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknonveg.CheckedChanged
        txtcategory.Text = chknonveg.Text
        If chknonveg.Checked = True Then
            Dim cmd2 As New SqlCommand("select * from Non_vegpizza ", cn)
            cn.Open()
            Dim dr2 As SqlDataReader = cmd2.ExecuteReader
            While dr2.Read
                cboname.Items.Add(dr2(0))
            End While
            dr2.Close()
            cn.Close()
        Else
            cboname.Items.Clear()
        End If

    End Sub

    Private Sub chkveg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkveg.CheckedChanged
        txtcategory.Text = chkveg.Text
        If chkveg.Checked = True Then
            Dim cmd1 As New SqlCommand("select * from Veg_Lovers ", cn)
            cn.Open()
            Dim dr1 As SqlDataReader = cmd1.ExecuteReader
            While dr1.Read
                cboname.Items.Add(dr1(0))
            End While
            dr1.Close()
            cn.Close()
        Else
            cboname.Items.Clear()
        End If

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim da As New SqlDataAdapter("select * from Product_price", cn)
        cn.Open()
        Dim ds As New DataSet
        da.Fill(ds, "Product_price")
        dgv1.DataSource = ds.Tables(0)
        cn.Close()
    End Sub

    Private Sub txtprice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtprice.GotFocus
        txtprice.Text = Val(txtqty.Text) * Val(txtamount.Text)
    End Sub
End Class
