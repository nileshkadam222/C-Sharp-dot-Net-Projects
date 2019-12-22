Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class SupplierForm
    Dim h As helper = New helper
    Dim dv As DataView

    Private Sub SupplierForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from SupplierInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "SupplierInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv

        'Clear binding
        '
        cmbsid.DataBindings.Clear()
        txtsname.DataBindings.Clear()
        txtsphno.DataBindings.Clear()
        txtsadd.DataBindings.Clear()
        txtspin.DataBindings.Clear()
        txtemail.DataBindings.Clear()
        txtproductname.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmbsid.DataBindings.Add("text", dv, "Supid")
        txtsname.DataBindings.Add("text", dv, "Supname")
        txtsphno.DataBindings.Add("text", dv, "Phno")
        txtemail.DataBindings.Add("text", dv, "EMID")
        txtspin.DataBindings.Add("text", dv, "Pincode")
        txtproductname.DataBindings.Add("text", dv, "Prodname")
        txtsadd.DataBindings.Add("text", dv, "Address")
        cmbsid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbsid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "ADD" Then
            Button1.Text = "SAVE"
            cmbsid.Text = ""
            txtsname.Text = ""
            txtsphno.Text = ""
            txtsadd.Text = ""
            txtspin.Text = ""
            txtemail.Text = ""
            txtproductname.Text = ""
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Supid) from SupplierInfo", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "SupplierInfo")
            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                cmbsid.Text = "S000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                cmbsid.Text = "S00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                cmbsid.Text = "S0" & id
            ElseIf (id > 999) Then
                id = id + 1
                cmbsid.Text = "S" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else
            If (txtsname.Text = "" Or txtsphno.Text = "" Or txtsadd.Text = "" Or txtspin.Text = "" Or txtemail.Text = "" Or txtproductname.Text = "") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)
            Else
                h.AMD("Insert into SupplierInfo values('" + cmbsid.Text + "','" + txtsname.Text + "','" + txtsphno.Text + "','" + txtsadd.Text + "','" + txtspin.Text + "','" + txtemail.Text + "','" + txtproductname.Text + "')", "Record Inserted Succesfully")
                Button1.Text = "ADD"
                SupplierForm_Load(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "UPDATE" Then
            Button2.Text = "MODIFY"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from SupplierInfo where Supid='" + cmbsid.Text + "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
        Else
            h.AMD("Update  SupplierInfo set Supname='" + txtsname.Text + "',Phno='" + txtsphno.Text + "',Address='" + txtsadd.Text + "',Pincode='" + txtspin.Text + "',EMID='" + txtemail.Text + "',Prodname='" + txtproductname.Text + "'WHERE Supid='" + cmbsid.Text + "'", "Record Updated Succesfully")
            Button2.Text = "UPDATE"
            con.Close()
            SupplierForm_Load(Nothing, Nothing)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from SupplierInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "SupplierInfo")
        h.AMD("Delete From SupplierInfo where Supid='" + cmbsid.Text + "' ", "Record Deleted Succesfully")
        con.Close()
        SupplierForm_Load(Nothing, Nothing)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsphno.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtspin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtproductname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub
    Private Sub cmbsid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from SupplierInfo where Supid='" & cmbsid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtsname.Text = dr.GetString(1)
            txtsphno.Text = dr.GetString(2)
            txtsadd.Text = dr.GetString(3)
            txtspin.Text = dr.GetString(4)
            txtemail.Text = dr.GetString(5)
            txtproductname.Text = dr.GetString(6)
        End While
        dr.Close()
        con.Close()
    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        suppsearch.Show()
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtsname.Text = ""
        txtsphno.Text = ""
        txtsadd.Text = ""
        txtspin.Text = ""
        txtemail.Text = ""
        txtproductname.Text = ""
    End Sub
    Private Sub txtemail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Validated
        If EmailAddressCheck(txtemail.Text) = True Then
            MsgBox("Valid Email")
        Else
            MsgBox("InValid Email")
            txtemail.Focus()
        End If
    End Sub
End Class