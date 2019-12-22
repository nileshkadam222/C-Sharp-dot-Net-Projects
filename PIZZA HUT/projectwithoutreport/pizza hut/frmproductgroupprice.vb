Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmproductgroupprice

    Private Sub cbocategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocategory.SelectedIndexChanged
        Try
            If cbocategory.Text = "Coffee" Then
                Dim an As New SqlDataAdapter("select * from Coffee", cn)
                Dim ac As New DataSet
                an.Fill(ac, "Coffee")
                DataGridView1.DataSource = ac.Tables("Coffee")
            ElseIf cbocategory.Text = "Burger" Then
                Dim an As New SqlDataAdapter("select * from Burger", cn)
                Dim ac As New DataSet
                an.Fill(ac, "Burger")
                DataGridView1.DataSource = ac.Tables("Burger")
            ElseIf cbocategory.Text = "Pizza_Perfect" Then
                Dim an As New SqlDataAdapter("select * from Pizza_Perfect", cn)
                Dim ac As New DataSet
                an.Fill(ac, "Pizza_Perfect")
                DataGridView1.DataSource = ac.Tables("Pizza_Perfect")
            ElseIf cbocategory.Text = "Shakes" Then
                Dim an As New SqlDataAdapter("select * from Shakes", cn)
                Dim ac As New DataSet
                an.Fill(ac, "Shakes")
                DataGridView1.DataSource = ac.Tables("Shakes")
            ElseIf cbocategory.Text = "Pasta" Then
                Dim an As New SqlDataAdapter("select * from Pasta", cn)
                Dim ac As New DataSet
                an.Fill(ac, "Pasta")
                DataGridView1.DataSource = ac.Tables("Pasta")

            End If
            txtname.Text = DataGridView1.CurrentRow.Cells.Item(0).Value
            txtsmall.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
            txtmedium.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
            txtlarge.Text = DataGridView1.CurrentRow.Cells.Item(3).Value
            txtfamily.Text = DataGridView1.CurrentRow.Cells.Item(4).Value
            txtstuffedcrust.Text = DataGridView1.CurrentRow.Cells.Item(5).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try




    End Sub

    Private Sub fmproductgroupprice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Visible = True
        btnsave.Visible = False
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into Product_Group_Price values( '" & cbocategory.Text & " ','" & txtname.Text & "','" & txtsmall.Text & "','" & txtmedium.Text & "','" & txtlarge.Text & "','" & txtfamily.Text & "','" & txtstuffedcrust.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            cn.Close()

            Dim da As New SqlDataAdapter("select * from Product_Group_Price", cn)
            cn.Open()
            Dim ds As New DataSet
            da.Fill(ds, "Product_Group_Price")
            DataGridView1.DataSource = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        btnsave.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Product_Group_Price where Category='" & cbocategory.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtname.Text = ""
            txtsmall.Text = ""
            txtmedium.Text = ""
            txtlarge.Text = ""
            txtfamily.Text = ""
            txtstuffedcrust.Text = ""

            Dim da As New SqlDataAdapter("select * from Product_Group_Price", cn)
            cn.Open()
            Dim ds As New DataSet
            da.Fill(ds, "Product_Group_Price")
            DataGridView1.DataSource = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMDIParent.Show()

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim cmd1 As New SqlCommand("update Product_Group_Price set Name='" & txtname.Text & "',Small='" & txtsmall.Text & "',Medium='" & txtmedium.Text & "',Large='" & txtlarge.Text & "',Family='" & txtfamily.Text & "',Stuffed_Crust='" & txtstuffedcrust.Text & "' where Category='" & cbocategory.Text & "'", cn)
            cn.Open()
            cmd1.ExecuteNonQuery()
            MsgBox("record is updated")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtname.Text = DataGridView1.CurrentRow.Cells.Item(0).Value
        txtsmall.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
        txtmedium.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
        txtlarge.Text = DataGridView1.CurrentRow.Cells.Item(3).Value
        txtfamily.Text = DataGridView1.CurrentRow.Cells.Item(4).Value
        txtstuffedcrust.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
        btnsave.Visible = True
        Button1.Visible = False
    End Sub
End Class