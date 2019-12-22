Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmaddingredients
    Dim i As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from List_of_Ingredients_entry", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboname.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        cn.Close()
    End Sub


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If cboname.Text = "" Or txtunit.Text = "" Or txtpacking.Text = "" Or txtpackingweigth.Text = "" Then
            MsgBox("Enter the feild properly", MsgBoxStyle.Information)
        Else

            Dim cmd As New SqlCommand("insert into List_of_Ingredients_entry values('" & cboname.Text & "','" & txtunit.Text & "','" & txtpacking.Text & "','" & txtpackingweigth.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("RECORD SAVED", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SAVED")
            Dim da As New SqlDataAdapter("select * from List_of_Ingredients_entry", cn)
            Dim ds As New DataSet
            da.Fill(ds, "List_of_Ingredients_entry")
            dgv.DataSource = ds.Tables(0)
            cboname.Text = ""
            txtunit.Text = ""
            txtpacking.Text = ""
            txtpackingweigth.Text = ""
            cboname.Focus()
        End If
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        Dim cmd As New SqlCommand("update List_of_Ingredients_entry set Unit='" & dgv.CurrentRow.Cells.Item(1).Value & "',Packing='" & dgv.CurrentRow.Cells.Item(2).Value & "',Packing_WT='" & dgv.CurrentRow.Cells.Item(3).Value & "' where Name='" & i & "'", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record are updated successfully......")
        cn.Close()
        Dim da As New SqlDataAdapter("select * from List_of_Ingredients_entry", cn)
        Dim ds As New DataSet
        da.Fill(ds, "List_of_Ingredients_entry")
        dgv.DataSource = ds.Tables(0)
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from List_of_Ingredients_entry where name='" & cboname.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()

            Dim da As New SqlDataAdapter("select * from List_of_Ingredients_entry", cn)
            Dim ds As New DataSet
            da.Fill(ds, "List_of_Ingredients_entry")
            dgv.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        End

    End Sub

    Private Sub btnveiw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveiw.Click
        Dim da As New SqlDataAdapter("select * from List_of_Ingredients_entry", cn)
        Dim ds As New DataSet
        da.Fill(ds, "List_of_Ingredients_entry")
        dgv.DataSource = ds.Tables(0)
    End Sub

    Private Sub dgv_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.ColumnHeaderMouseClick
        i = InputBox("please enter the name of the product")
        Dim da As New SqlDataAdapter("select * from List_of_Ingredients_entry where name='" & i & "'", cn)
        Dim ds As New DataSet
        da.Fill(ds, "List_of_Ingredients_entry")
        dgv.DataSource = ds.Tables(0)
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from List_of_Ingredients_entry where name='" & cboname.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboname.Text = dr.GetString(0)
            txtunit.Text = dr.GetString(1)
            txtpacking.Text = dr.GetString(2)
            txtpackingweigth.Text = dr.GetString(3)
        End While
        dr.Close()
        cn.Close()

        Dim da As New SqlDataAdapter("select * from List_of_Ingredients_entry", cn)
        Dim ds As New DataSet
        da.Fill(ds, "List_of_Ingredients_entry")
        dgv.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()
    End Sub
End Class