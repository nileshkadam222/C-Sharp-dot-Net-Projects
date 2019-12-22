Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmbill
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            DateTimePicker1.Text = ""
            txtname.Text = ""
            txtsrno.Text = ""
            txtingredients.Text = ""
            txtquantity.Text = ""
            txtrate.Text = ""
            txtamount.Text = ""
            txtgrossamt.Text = ""
            txtadvance.Text = ""
            txtbalance.Text = ""
            Dim rec As New SqlCommand("select * from Cash_Memo", cn)
            cn.Open()
            Dim drcash As SqlDataReader = rec.ExecuteReader
            While drcash.Read
                txtordno.Text = drcash.GetString(0)
            End While
            txtordno.Text = Val(txtordno.Text) + 1
            drcash.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cboorderno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboorderno.SelectedIndexChanged

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim cmd As New SqlCommand("select * from Cash_Memo where Order_no='" & cboorderno.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                txtsrno.Text = dr.GetString(1)
                txtingredients.Text = dr.GetString(2)
                txtquantity.Text = dr.GetString(3)
                txtrate.Text = dr.GetString(4)
                txtamount.Text = dr.GetString(5)
                txttotalamt.Text = dr.GetString(6)
                txtgrossamt.Text = dr.GetString(7)
                txtname.Text = dr.GetString(9)
                txtadvance.Text = dr.GetString(10)
                txtbalance.Text = dr.GetString(11)
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

    Private Sub frmbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from Cash_Memo", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboorderno.Items.Add(dr(0))
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
            Dim i As Integer
            For i = 0 To lstsrno.Items.Count - 1
                Dim cmds As New SqlCommand("insert into Cash_Memo values('" & txtordno.Text & "','" & lstsrno.Items.Item(i) & "','" & lstparticular.Items.Item(i) & "','" & lstqty.Items.Item(i) & "','" & lstrate.Items.Item(i) & "','" & lstamt.Items.Item(i) & "','" & txttotalamt.Text & "','" & txtgrossamt.Text & "','" & DateTimePicker1.Value & "','" & txtname.Text & "','" & txtadvance.Text & "','" & txtbalance.Text & "')", cn)
                cn.Open()
                cmds.ExecuteNonQuery()
                cn.Close()
            Next
            MsgBox("Record are saved...!", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "saved")
            cboorderno.Items.Clear()
            Dim cmd As New SqlCommand("select * from Cash_Memo", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboorderno.Items.Add(dr(0))
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

    

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Try
            DateTimePicker1.Text = ""
            cboorderno.Text = ""
            txtname.Text = ""
            txtsrno.Text = ""
            txtingredients.Text = ""
            txtquantity.Text = ""
            txtrate.Text = ""
            txtamount.Text = ""
            txtgrossamt.Text = ""
            txtadvance.Text = ""
            txtbalance.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Hide()
        frmmdiparent.Show()
    End Sub

    Private Sub txtgrossamt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgrossamt.GotFocus
        Try
            txtgrossamt.Text = Val(txttotalamt.Text) + Val(txttotalamt.Text * 10 / 100)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

   
    Private Sub txtamount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamount.LostFocus
        Try
            lstsrno.Items.Add(txtsrno.Text)
            lstparticular.Items.Add(txtingredients.Text)
            lstqty.Items.Add(txtquantity.Text)
            lstrate.Items.Add(txtrate.Text)
            lstamt.Items.Add(txtamount.Text)
            Dim cmdamt As New SqlCommand("insert into ADDITION values(" & txtamount.Text & ")", cn)
            cn.Open()
            cmdamt.ExecuteNonQuery()
            cn.Close()
            txtingredients.Text = ""
            txtquantity.Text = ""
            txtrate.Text = ""
            txtamount.Text = ""
            txtcustid.Text = ""
            txtname.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub
    Private Sub txtquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquantity.TextChanged
        Try
            txtamount.Text = Val(txtquantity.Text) * Val(txtrate.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txttotalamt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttotalamt.GotFocus

        Try
            Dim cmdadd As New SqlCommand("select sum(SUM1) from ADDITION", cn)
            cn.Open()
            Dim dradd As SqlDataReader = cmdadd.ExecuteReader
            While dradd.Read
                txttotalamt.Text = dradd(0)
            End While
            dradd.Close()
            cn.Close()

            Dim cmddel As New SqlCommand("delete from ADDITION", cn)
            cn.Open()
            cmddel.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtbalance_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbalance.GotFocus
        Try
            txtbalance.Text = Val(txtgrossamt.Text) - Val(txtadvance.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub txtcustid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcustid.LostFocus
        Try
            Dim cmdid As New SqlCommand("select * from Customer_Purchessing where Cust_id='" & txtcustid.Text & "'", cn)
            cn.Open()
            Dim drid As SqlDataReader = cmdid.ExecuteReader
            While drid.Read
                txtname.Text = drid.GetString(1)
                txtingredients.Text = drid.GetString(3)
                txtrate.Text = drid.GetString(4)
            End While
            drid.Close()
            cn.Close()
            txtquantity.Focus()
            txtsrno.Text = Val(txtsrno.Text) + 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Me.Hide()
        'Bill_Report.Show()
    End Sub
End Class