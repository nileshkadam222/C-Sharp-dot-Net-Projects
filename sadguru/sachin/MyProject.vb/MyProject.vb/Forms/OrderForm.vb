Imports System.Data.SqlClient
Public Class OrderForm
    Dim h As helper = New helper
    Dim dv As DataView

    Private Sub OrderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from OrderInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "OrderInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv

        'Clear binding
        '
        cmborid.DataBindings.Clear()
        txtorcuname.DataBindings.Clear()
        txtorprono.DataBindings.Clear()
        txtorprname.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        txtorque.DataBindings.Clear()
        txtorrate.DataBindings.Clear()
        txtoramt.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmborid.DataBindings.Add("text", dv, "Ordid")
        txtorcuname.DataBindings.Add("text", dv, "Custname")
        txtorprono.DataBindings.Add("text", dv, "Prdnum")
        txtorprname.DataBindings.Add("text", dv, "Prdname")
        DateTimePicker1.DataBindings.Add("text", dv, "Date")
        txtorque.DataBindings.Add("text", dv, "Quty")
        txtorrate.DataBindings.Add("text", dv, "Rate")
        txtoramt.DataBindings.Add("text", dv, "Amt")
        con.Open()
        cmborid.Items.Clear()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmborid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "ADD" Then
            btnadd.Text = "SAVE"
            cmborid.Text = ""
            txtorcuname.Text = ""
            txtorprono.Text = ""
            txtorprname.Text = ""
            DateTimePicker1.Text = ""
            txtorque.Text = "Kg"
            txtorrate.Text = "Rs"
            txtoramt.Text = "Rs"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Ordid) from OrderInfo", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "OrderInfo")
            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                cmborid.Text = "R000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                cmborid.Text = "R00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                cmborid.Text = "R0" & id
            ElseIf (id > 999) Then
                id = id + 1
                cmborid.Text = "R" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else

            If (txtorcuname.Text = "" Or txtorprono.Text = "" Or txtorprname.Text = "" Or DateTimePicker1.Text = "" Or txtorque.Text = "Kg" Or txtorrate.Text = "Rs" Or txtoramt.Text = "Rs") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)


            Else
                h.AMD("Insert into OrderInfo values('" + cmborid.Text + "','" + txtorcuname.Text + "','" + txtorprono.Text + "','" + txtorprname.Text + "','" + DateTimePicker1.Text + "','" + txtorque.Text + "','" + txtorrate.Text + "','" + txtoramt.Text + "')", "Record Inserted Succesfully")
                btnadd.Text = "ADD"
                OrderForm_Load(Nothing, Nothing)

            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "UPDATE" Then
            btnupdate.Text = "MODIFY"




            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from OrderInfo where Ordid='" & cmborid.Text & "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()


        Else


            h.AMD("Update  OrderInfo set Custname='" + txtorcuname.Text + "',Prdnum='" + txtorprono.Text + "',Prdname='" + txtorprname.Text + "',Quty='" + txtorque.Text + "',Rate='" + txtorrate.Text + "',Amt='" + txtoramt.Text + "'WHERE Ordid='" + cmborid.Text + "'", "Record Updated Succesfully")
            btnupdate.Text = "UPDATE"
            con.Close()
            OrderForm_Load(Nothing, Nothing)

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from OrderInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "OrderInfo")




        h.AMD("Delete From OrderInfo where Ordid='" + cmborid.Text + "' ", "Record Deleted Succesfully")
        con.Close()
        OrderForm_Load(Nothing, Nothing)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else


        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorcuname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorprname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorque.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtorrate.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtoramt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub cmborid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from OrderInfo where Ordid ='" & cmborid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtorcuname.Text = dr.GetString(1)
            txtorprono.Text = dr.GetString(2)
            txtorprname.Text = dr.GetString(3)
            txtorque.Text = dr.GetString(5)
            txtorrate.Text = dr.GetString(6)
            txtoramt.Text = dr.GetString(7)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        ordersearch.Show()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtorcuname.Text = ""
        txtorprono.Text = ""
        txtorprname.Text = ""
        DateTimePicker1.Text = ""
        txtorque.Text = "Kg"
        txtorrate.Text = "Rs"
        txtoramt.Text = "Rs"
    End Sub
End Class