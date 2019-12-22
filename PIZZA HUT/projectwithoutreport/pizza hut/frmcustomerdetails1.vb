Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmcustomerdetails1
    Dim i As String
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cboid.Text = ""
        cboname.Text = ""
        txtadd.Text = ""
        txtstate.Text = ""
        txtcity.Text = ""
        txttel.Text = ""
        txtemail.Text = ""
        txtname.Text = ""
        txtid.Text = ""

    End Sub


    Private Sub btnveiw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveiw.Click
        Try

            Dim da As New SqlDataAdapter("select * from Customer_details", cn)

            Dim ds As New DataSet
            da.Fill(ds, "Customer_details")
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim cmd As New SqlCommand("insert into Customer_details values( '" & txtid.Text & " ','" & txtname.Text & "','" & txtadd.Text & "','" & txtstate.Text & "','" & txtcity.Text & "','" & txttel.Text & "','" & txtemail.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        txtid.Visible = True
        cboname.Enabled = True
        cn.Close()
        cboid.Items.Clear()
        Dim cmds As New SqlCommand("select * from Customer_details", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmds.ExecuteReader
        While dr.Read
            cboid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        cn.Close()

        Dim da As New SqlDataAdapter("select * from Customer_details", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Customer_details")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub cboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboname.SelectedIndexChanged
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        Dim cmd As New SqlCommand("select * from Customer_details where Cust_Name='" & cboname.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            txtid.Visible = True
            cboid.Visible = False
            txtname.Visible = False
            ' cboid.Text = dr.GetString(0)
            txtid.Text = dr.GetString(0)
            'cboname.Text = dr.GetString(1)
            txtadd.Text = dr.GetString(2)
            txtstate.Text = dr.GetString(3)
            txtcity.Text = dr.GetString(4)
            txttel.Text = dr.GetString(5)
            txtemail.Text = dr.GetString(6)
        End While
        dr.Close()
        cn.Close()

        'Dim cmd1 As New SqlCommand("insert into Customer_details values( '" & cboid.Text & " ','" & cboname.Text & "','" & txtadd.Text & "','" & txtstate.Text & "','" & txtcity.Text & "','" & txttel.Text & "','" & txtemail.Text & "')", cn)
        'cn.Open()
        'cmd1.ExecuteNonQuery()
        'MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        'cn.Close()
    End Sub

    Private Sub cboid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboid.SelectedIndexChanged
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Dim cmd As New SqlCommand("select * from Customer_details where Cust_id='" & cboid.Text & "'", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            ' cboid.Text = dr.GetString(0)
            txtid.Visible = False
            cboid.Visible = True
            txtname.Visible = True
            cboname.Visible = False
            txtname.Text = dr.GetString(1)
            txtadd.Text = dr.GetString(2)
            txtstate.Text = dr.GetString(3)
            txtcity.Text = dr.GetString(4)
            txttel.Text = dr.GetString(5)
            txtemail.Text = dr.GetString(6)
        End While
        dr.Close()
        cn.Close()

        'Dim cmd2 As New SqlCommand("insert into Customer_details values( '" & cboid.Text & " ','" & cboname.Text & "','" & txtadd.Text & "','" & txtstate.Text & "','" & txtcity.Text & "','" & txttel.Text & "','" & txtemail.Text & "')", cn)
        'cn.Open()
        'cmd2.ExecuteNonQuery()
        'MsgBox("Record are successfully.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        'cn.Close()

    End Sub

    Private Sub frmcustomerdetails1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from Customer_details", cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cboid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        cn.Close()

        Dim cmd1 As New SqlCommand("select * from Customer_details", cn)
        cn.Open()
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        While dr1.Read
            cboname.Items.Add(dr1.GetString(1))
        End While
        dr1.Close()
        cn.Close()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim cmd As New SqlCommand("update Customer_details set Cust_Name='" & DataGridView1.CurrentRow.Cells.Item(1).Value & "',Address='" & DataGridView1.CurrentRow.Cells.Item(2).Value & "',State='" & DataGridView1.CurrentRow.Cells.Item(3).Value & "',Telephon_No='" & DataGridView1.CurrentRow.Cells.Item(4).Value & "',Email_id='" & DataGridView1.CurrentRow.Cells.Item(5).Value & "' where Cust_id='" & i & "'", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record are updated successfully......")
        cn.Close()


        Dim da As New SqlDataAdapter("select * from Customer_details", cn)
        Dim ds As New DataSet
        da.Fill(ds, "List_of_Ingredients_entry")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        i = InputBox("please enter the name of the product")
        Dim da As New SqlDataAdapter("select * from Customer_details where name='" & i & "'", cn)
        Dim ds As New DataSet
        da.Fill(ds, "Customer_details")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim rec As New SqlCommand("select * from Customer_details", cn)
        cn.Open()
        Dim dr As SqlDataReader = rec.ExecuteReader
        While dr.Read
            txtid.Text = dr(0)
        End While
        txtid.Text = Val(txtid.Text) + 1
        dr.Close()
        cn.Close()
        txtid.Visible = True
        txtid.Enabled = False
        txtname.Visible = True
        cboid.Text = ""
        cboname.Text = ""
        txtadd.Text = ""
        txtstate.Text = ""
        txtcity.Text = ""
        txttel.Text = ""
        txtemail.Text = ""
        txtname.Text = ""

    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Customer_details where Cust_id='" & cboid.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            txtname.Text = ""
            txtadd.Text = ""
            txtcity.Text = ""
            txtemail.Text = ""
            txtid.Text = ""
            txttel.Text = ""
            cboid.Items.Clear()
            Dim cmd1 As New SqlCommand("select * from Customer_details", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd1.ExecuteReader
            While dr.Read
                cboid.Items.Add(dr.GetString(0))
            End While
            dr.Close()
            cn.Close()
            Dim da As New SqlDataAdapter("select * from Customer_details", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Customer_details")
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmMdiParent.Show()

    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged

    End Sub
End Class