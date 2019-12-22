Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmcustomerpurchessing
    Dim i As String
    Private Sub cbocustid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocustid.SelectedIndexChanged
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim cmd As New SqlCommand("select * from Customer_Purchessing where Cust_id='" & cbocustid.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                txtcustname.Text = dr.GetString(1)
                txtproductid.Text = dr.GetString(2)
                txtpizzaname.Text = dr.GetString(3)
                txtprice.Text = dr.GetString(4)
                txtqty.Text = dr.GetString(5)
                txtproductid.Visible = True
                cboproductid.Visible = False
                txtcustid.Visible = False
            End While
            dr.Close()
            cn.Close()
            cbocustid.Items.Clear()
            Dim cmd1 As New SqlCommand("select * from Customer_Purchessing ", cn)
            cn.Open()
            Dim dr1 As SqlDataReader = cmd1.ExecuteReader
            While dr1.Read
                cbocustid.Items.Add(dr1.GetString(0))
                ' cboproductid.Items.Add(dr.GetString(2))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cboproductid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboproductid.SelectedIndexChanged
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim cmd As New SqlCommand("select * from Customer_Purchessing where Product_id='" & cboproductid.Text & "'", cn)
            cn.Open()
            Dim dr2 As SqlDataReader = cmd.ExecuteReader
            While dr2.Read
                txtcustid.Text = dr2.GetString(0)
                txtcustname.Text = dr2.GetString(1)
                txtpizzaname.Text = dr2.GetString(3)
                txtprice.Text = dr2.GetString(4)
                txtqty.Text = dr2.GetString(5)
                txtcustid.Visible = True
                cbocustid.Visible = False
                cboproductid.Items.Clear()

                Dim cmd1 As New SqlCommand("select * from Customer_Purchessing ", cn)
                cn.Open()
                Dim dr As SqlDataReader = cmd1.ExecuteReader
                While dr.Read
                    'cbocustid.Items.Add(dr.GetString(0))
                    cboproductid.Items.Add(dr.GetString(2))
                End While
                dr.Close()
                cn.Close()
            End While
            dr2.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try



    End Sub

    Private Sub frmcustomerpurchessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from Customer_Purchessing ", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cbocustid.Items.Add(dr.GetString(0))
                cboproductid.Items.Add(dr.GetString(2))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into Customer_Purchessing values( '" & txtcustid.Text & " ','" & txtcustname.Text & "','" & txtproductid.Text & "','" & txtpizzaname.Text & "','" & txtprice.Text & "','" & txtqty.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            cn.Close()

            Dim da As New SqlDataAdapter("select * from Customer_Purchessing", cn)
            cn.Open()
            Dim ds As New DataSet
            da.Fill(ds, "Customer_Purchessing")
            DataGridView1.DataSource = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            Dim rec As New SqlCommand("select * from Customer_Purchessing", cn)
            cn.Open()
            Dim dr As SqlDataReader = rec.ExecuteReader
            While dr.Read
                txtcustid.Text = dr.GetString(0)
            End While
            txtcustid.Text = "00" & Val(txtcustid.Text) + 1
            dr.Close()
            cn.Close()
            txtcustid.Enabled = False
            txtproductid.Visible = True
            txtcustid.Visible = True
            cbocustid.Visible = False
            cboproductid.Visible = False
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

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Customer_Purchessing where Cust_id='" & cbocustid.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtcustid.Text = ""
            txtpizzaname.Text = ""
            txtprice.Text = ""
            cboproductid.Text = ""
            txtcustname.Text = ""
            txtqty.Text = ""

            Dim da As New SqlDataAdapter("select * from Customer_Purchessing", cn)
            cn.Open()
            Dim ds As New DataSet
            da.Fill(ds, "Customer_Purchessing")
            DataGridView1.DataSource = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim cmd1 As New SqlCommand("update Customer_Purchessing set Cust_name='" & DataGridView1.CurrentRow.Cells.Item(1).Value & "',Product_id='" & DataGridView1.CurrentRow.Cells.Item(2).Value & "',Pizza_name='" & DataGridView1.CurrentRow.Cells.Item(3).Value & "',Price='" & DataGridView1.CurrentRow.Cells.Item(4).Value & "',Qty='" & DataGridView1.CurrentRow.Cells.Item(5).Value & "' where Cust_id='" & i & "'", cn)
            cn.Open()
            cmd1.ExecuteNonQuery()
            MsgBox("Record are updated successfully......")
            cn.Close()

            Dim da As New SqlDataAdapter("select * from Customer_Purchessing", cn)
            cn.Open()
            Dim ds As New DataSet
            da.Fill(ds, "Customer_Purchessing")
            DataGridView1.DataSource = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            i = InputBox("please enter the name of the product")
            Dim da As New SqlDataAdapter("select * from Customer_Purchessing where cust_name='" & i & "'", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Customer_Purchessing")
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        'txtcustid.Text = ""
        txtproductid.Text = ""
        txtpizzaname.Text = ""
        txtprice.Text = ""
        cboproductid.Text = ""
        txtcustname.Text = ""
        txtqty.Text = ""
    End Sub
End Class