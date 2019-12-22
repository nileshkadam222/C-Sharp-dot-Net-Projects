Imports System.Data.SqlClient
Public Class ProductForm
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub ProductForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from ProductInfo  ORDER BY Prdid", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "ProductInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv
        'Clear binding
        '
        ComboBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox7.DataBindings.Clear()
        '
        'data binding 
        '
        con.Close()
        ComboBox1.DataBindings.Add("text", dv, "Prdid")
        TextBox2.DataBindings.Add("text", dv, "Prdname")
        TextBox3.DataBindings.Add("text", dv, "Prdqty")
        TextBox6.DataBindings.Add("text", dv, "Qtyonhand")
        TextBox5.DataBindings.Add("text", dv, "Reordrlevel")
        TextBox7.DataBindings.Add("text", dv, "Price")
        TextBox4.DataBindings.Add("text", dv, "Prddescription")
        
        ComboBox1.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "ADD" Then
            Button1.Text = "SAVE"
            ComboBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = "Kg"
            TextBox4.Text = ""
            TextBox5.Text = "Kg"
            TextBox6.Text = "Kg"
            TextBox7.Text = "Rs"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Prdid) from ProductInfo ", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "ProductInfo")
            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                ComboBox1.Text = "P000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                ComboBox1.Text = "P00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                ComboBox1.Text = "P0" & id
            ElseIf (id > 999) Then
                id = id + 1
                ComboBox1.Text = "P" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else

            If (TextBox2.Text = "" Or TextBox3.Text = "Kg" Or TextBox4.Text = "" Or TextBox5.Text = "Kg" Or TextBox6.Text = "Kg" Or TextBox7.Text = "Rs") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)
            Else
                h.AMD("Insert into ProductInfo values('" + ComboBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')", "Record Inserted Succesfully")
                Button1.Text = "ADD"
                ProductForm_Load(Nothing, Nothing)

            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "UPDATE" Then
            Button2.Text = "MODIFY"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from ProductInfo where Prdid='" + ComboBox1.Text + "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
        Else
            h.AMD("Update  ProductInfo set Prdid='" + ComboBox1.Text + "',Prdname='" + TextBox2.Text + "',Prdqty='" + TextBox3.Text + "',Prddescription='" + TextBox4.Text + "',Qtyonhand='" + TextBox6.Text + "',Price='" + TextBox7.Text + "',Reordrlevel='" + TextBox5.Text + "'WHERE Prdid='" + ComboBox1.Text + "'", "Record Updated Succesfully")
            Button2.Text = "UPDATE"
            con.Close()
            ProductForm_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from ProductInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "ProductInfo")
        h.AMD("Delete From ProductInfo where Prdid='" + ComboBox1.Text + "' ", "Record Deleted Succesfully")
        con.Close()
        ProductForm_Load(Nothing, Nothing)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub dgvpat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpat.CellContentClick
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        TextBox2.Text = ""
        TextBox3.Text = "Kg"
        TextBox4.Text = ""
        TextBox5.Text = "Kg"
        TextBox6.Text = "Kg"
        TextBox7.Text = "Rs"
    End Sub

  

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from ProductInfo where prdid='" & ComboBox1.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            TextBox2.Text = dr.GetString(1)
            TextBox3.Text = dr.GetString(2)
            TextBox4.Text = dr.GetString(3)
            TextBox5.Text = dr.GetString(4)
            TextBox6.Text = dr.GetString(5)
            TextBox7.Text = dr.GetString(6)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        productsearch.Show()
    End Sub
End Class