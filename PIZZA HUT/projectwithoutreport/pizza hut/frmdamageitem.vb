Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmdamageitem

    Private Sub btnpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpost.Click
        MsgBox("Are you sure to post a previous form", MsgBoxStyle.Information)
        frminventorydetails.Show()
        Me.Hide()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Delete_item where Item_name='" & cboname.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            DateTimePicker1.Value = Now
            cboname.Text = ""
            txtqty.Text = "" 
            txtremark.Text = ""
            Dim da As New SqlDataAdapter("select * from Delete_item", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Delete_item")
            DataGridView1.DataSource = ds.Tables("Delete_item")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    
    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        ''Dim da As New SqlDataAdapter("select * from Delete_item", cn)
        ''Dim ds As New DataSet
        ''da.Fill(ds, "Delete_item")
        ''DataGridView1.DataSource = ds.Tables("Delete_item")


        Dim cmd As New SqlCommand("select * from Meat_Lovers where Ingredients='" & cboname.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboname.Text = dr.GetString(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub frmdamageitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As New SqlDataAdapter("select * from Delete_item", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Delete_item")
        DataGridView1.DataSource = ds.Tables("Delete_item")

        Dim cmdsr As New SqlCommand("Select * from  Meat_Lovers ", cn)
        cn.Open()
        Dim drsr As SqlDataReader = cmdsr.ExecuteReader
        While drsr.Read
            cboname.Items.Add(drsr.GetString(0))
        End While
        drsr.Close()
        cn.Close()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        If cboname.Text = "" Or txtqty.Text = "" Or txtremark.Text = "" Then
            MsgBox("Enter the feild properly", MsgBoxStyle.Information)
        Else
            Dim cmds As New SqlCommand("insert into Delete_item values('" & DateTimePicker1.Value & "','" & cboname.Text & "','" & txtqty.Text & "','" & txtremark.Text & "')", cn)
            cn.Open()
            cmds.ExecuteNonQuery()
            MsgBox("record are succesfully added......", MsgBoxStyle.Information)
            cn.Close()


            Dim da As New SqlDataAdapter("select * from Delete_item", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Delete_item")
            DataGridView1.DataSource = ds.Tables("Delete_item")

            DateTimePicker1.Value = Now
            cboname.Text = ""
            txtqty.Text = ""
            txtremark.Text = ""

        End If

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub
End Class