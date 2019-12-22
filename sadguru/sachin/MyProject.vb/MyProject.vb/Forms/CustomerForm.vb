Imports System.Data.SqlClient
Public Class CustomerForm
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub CustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from customerInfo ", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "customerInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv

        'Clear binding
        '
        Custid.DataBindings.Clear()
        txtcustname.DataBindings.Clear()
        txtcustnumber.DataBindings.Clear()
        txtcustadd.DataBindings.Clear()
        txtcustphone.DataBindings.Clear()
        cmbcustgen.DataBindings.Clear()
        txtcustemail.DataBindings.Clear()


        '
        'data binding 
        '
        con.Close()
        Custid.DataBindings.Add("text", dv, "Custid")
        txtcustname.DataBindings.Add("text", dv, "Custname")
        txtcustnumber.DataBindings.Add("text", dv, "Phno")
        txtcustadd.DataBindings.Add("text", dv, "Address")
        txtcustphone.DataBindings.Add("text", dv, "Pincode")
        cmbcustgen.DataBindings.Add("Text", dv, "Gender")
        txtcustemail.DataBindings.Add("text", dv, "EMail")
        Custid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            Custid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "ADD" Then
            btnadd.Text = "SAVE"
            Custid.Text = ""
            txtcustname.Text = ""
            txtcustnumber.Text = ""
            txtcustadd.Text = ""
            txtcustphone.Text = ""
            cmbcustgen.Text = ""
            txtcustemail.Text = ""



            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Custid) from customerInfo", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "customerInfo")
            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                Custid.Text = "C000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                Custid.Text = "C00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                Custid.Text = "C0" & id
            ElseIf (id > 999) Then
                id = id + 1
                Custid.Text = "C" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else
            If (txtcustname.Text = "" Or txtcustnumber.Text = "" Or txtcustadd.Text = "" Or txtcustphone.Text = "" Or cmbcustgen.Text = "" Or txtcustemail.Text = "") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)
            Else
                h.AMD("Insert into customerInfo values('" + Custid.Text + "','" + txtcustname.Text + "','" + txtcustnumber.Text + "','" + txtcustadd.Text + "','" + txtcustphone.Text + "','" + cmbcustgen.Text + "','" + txtcustemail.Text + "')", "Record Inserted Succesfully")
                btnadd.Text = "ADD"
                CustomerForm_Load(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "UPDATE" Then
            btnupdate.Text = "MODIFY"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from customerInfo where Custid='" + Custid.Text + "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
        Else
            h.AMD("Update  customerInfo set Custname='" + txtcustname.Text + "',Phno='" + txtcustnumber.Text + "',Address='" + txtcustadd.Text + "',Pincode='" + txtcustphone.Text + "',Gender='" + cmbcustgen.Text + "',EMail='" + txtcustemail.Text + "'WHERE Custid='" + Custid.Text + "'", "Record Updated Succesfully")
            btnupdate.Text = "UPDATE"
            con.Close()
            CustomerForm_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batndel.Click
        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from customerInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "customerInfo")
        h.AMD("Delete From customerInfo where custid='" + Custid.Text + "' ", "Record Deleted Succesfully")
        con.Close()
        CustomerForm_Load(Nothing, Nothing)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustnumber.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustphone.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustemail.KeyPress
    End Sub


    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustadd.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custid.SelectedIndexChanged

        Dim cmd As New SqlCommand("select * from customerInfo where Custid ='" & Custid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtcustname.Text = dr.GetString(1)
            txtcustnumber.Text = dr.GetString(2)
            txtcustadd.Text = dr.GetString(3)
            txtcustphone.Text = dr.GetString(4)
            cmbcustgen.Text = dr.GetString(5)
            txtcustemail.Text = dr.GetString(6)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcustgen.SelectedIndexChanged

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        custsearch.Show()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtcustname.Text = ""
        txtcustnumber.Text = ""
        txtcustadd.Text = ""
        txtcustphone.Text = ""
        cmbcustgen.Text = ""
        txtcustemail.Text = ""


    End Sub

    Private Sub txtcustemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustemail.TextChanged

    End Sub

    Private Sub txtcustemail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcustemail.Validated
        If EmailAddressCheck(txtcustemail.Text) = True Then
            MsgBox("Valid Email")

        Else
            MsgBox("InValid Email")
            txtcustemail.Focus()
        End If
    End Sub

    Private Sub txtcustphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustphone.TextChanged

    End Sub

    Private Sub txtcustnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustnumber.TextChanged

    End Sub
End Class