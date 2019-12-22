Imports System.Data.SqlClient
Public Class BillForm
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub BillForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from BillInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "BillInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv

        'cmbbillno.Enabled = False
        'DateTimePicker1.Enabled = False
        'txtbname.Enabled = False
        'txtbpno.Enabled = False
        'txtbpname.Enabled = False
        'txtbquentity.Enabled = False
        'txtbrate.Enabled = False
        'txtbamt.Enabled = False

        'Clear binding
        '
        con.Close()
        cmbbillno.DataBindings.Clear()
        txtbname.DataBindings.Clear()
        txtbpno.DataBindings.Clear()
        txtbpname.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        txtbquentity.DataBindings.Clear()
        txtbrate.DataBindings.Clear()
        txtbamt.DataBindings.Clear()
        '
        'data binding 
        '
        cmbbillno.DataBindings.Add("text", dv, "Bid")
        txtbname.DataBindings.Add("text", dv, "Name")
        txtbpno.DataBindings.Add("text", dv, "Pid")
        txtbpname.DataBindings.Add("text", dv, "Prdname")
        DateTimePicker1.DataBindings.Add("text", dv, "Date")
        txtbquentity.DataBindings.Add("text", dv, "Qty")
        txtbrate.DataBindings.Add("text", dv, "Rate")
        txtbamt.DataBindings.Add("text", dv, "Amt")


        cmbbillno.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbbillno.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmbbillno.Enabled = True
        'DateTimePicker1.Enabled = True
        'txtbname.Enabled = True
        'txtbpno.Enabled = True
        'txtbpname.Enabled = True
        'txtbquentity.Enabled = True
        'txtbrate.Enabled = True
        'txtbamt.Enabled = True

        If Button1.Text = "ADD" Then
            Button1.Text = "SAVE"
            cmbbillno.Text = ""
            DateTimePicker1.Text = ""
            txtbname.Text = ""
            txtbpno.Text = ""
            txtbpname.Text = ""
            txtbquentity.Text = "kg"
            txtbrate.Text = "Rs"
            txtbamt.Text = "Rs"

            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Bid) from BillInfo", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "BillInfo")

            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                cmbbillno.Text = "B000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                cmbbillno.Text = "B00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                cmbbillno.Text = "B0" & id
            ElseIf (id > 999) Then
                id = id + 1
                cmbbillno.Text = "B" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else

            If (DateTimePicker1.Text = "" Or txtbname.Text = "" Or txtbpno.Text = "" Or txtbpname.Text = "" Or txtbquentity.Text = "kg" Or txtbrate.Text = "Rs" Or txtbamt.Text = "Rs") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)


            Else
                h.AMD("Insert into BillInfo values('" + cmbbillno.Text + "','" + txtbname.Text + "','" + txtbpno.Text + "','" + txtbpname.Text + "','" + DateTimePicker1.Text + "','" + txtbquentity.Text + "','" + txtbrate.Text + "','" + txtbamt.Text + "')", "Record Inserted Succesfully")
                Button1.Text = "ADD"
                con.Close()
                BillForm_Load(Nothing, Nothing)

            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "UPDATE" Then
            Button2.Text = "MODIFY"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from BillInfo where Bid='" + cmbbillno.Text + "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
        Else
            h.AMD("Update  BillInfo Set Name='" + txtbname.Text + "',Pid='" + txtbpno.Text + "',Prdname='" + txtbpname.Text + "',Qty='" + txtbquentity.Text + "',Rate='" + txtbrate.Text + "',Amt='" + txtbamt.Text + "'WHERE Bid='" + cmbbillno.Text + "'", "Record Updated Succesfully")
            Button2.Text = "UPDATE"
            con.Close()
            BillForm_Load(Nothing, Nothing)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from BillInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "BillInfo")




        h.AMD("Delete From BillInfo where Bid='" + cmbbillno.Text + "' ", "Record Deleted Succesfully")
        con.Close()
        BillForm_Load(Nothing, Nothing)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else


        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbpname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbquentity.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbrate.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbamt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbillno.SelectedIndexChanged

        Dim cmd As New SqlCommand("select * from  BillInfo where Bid='" & cmbbillno.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtbname.Text = dr.GetString(1)
            txtbpno.Text = dr.GetString(2)
            txtbpname.Text = dr.GetString(3)
            txtbquentity.Text = dr.GetString(5)
            txtbrate.Text = dr.GetString(6)
            txtbamt.Text = dr.GetString(7)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub dgvpat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpat.CellContentClick

    End Sub

   
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        billsearch.Show()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DateTimePicker1.Text = ""
        txtbname.Text = ""
        txtbpno.Text = ""
        txtbpname.Text = ""
        txtbquentity.Text = "kg"
        txtbrate.Text = "Rs"
        txtbamt.Text = "Rs"

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtbquentity_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbquentity.SizeChanged

    End Sub

    Private Sub txtbquentity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbquentity.TextChanged

    End Sub

    Private Sub txtbpname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbpname.TextChanged

    End Sub
End Class