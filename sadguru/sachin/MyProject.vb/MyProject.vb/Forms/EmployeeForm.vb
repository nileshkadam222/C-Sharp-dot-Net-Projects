Imports System.Data.SqlClient
Public Class EmployeeForm
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub EmployeeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from EmployeeInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "EmployeeInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv

        'Clear binding
        '
        cmbempid.DataBindings.Clear()
        txtempname.DataBindings.Clear()
        txtempphno.DataBindings.Clear()
        txtempadd.DataBindings.Clear()
        txtempemail.DataBindings.Clear()
        cmbempgen.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        txtempdesig.DataBindings.Clear()
        DateTimePicker2.DataBindings.Clear()
        txtempsal.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmbempid.DataBindings.Add("text", dv, "Empid")
        txtempname.DataBindings.Add("text", dv, "Empname")
        txtempphno.DataBindings.Add("text", dv, "Phno")
        txtempadd.DataBindings.Add("text", dv, "Address")
        txtempemail.DataBindings.Add("text", dv, "EMail")
        cmbempgen.DataBindings.Add("text", dv, "Gender")
        DateTimePicker1.DataBindings.Add("text", dv, "Birthdate")
        txtempdesig.DataBindings.Add("text", dv, "Designation")
        DateTimePicker2.DataBindings.Add("text", dv, "Joindate")
        txtempsal.DataBindings.Add("text", dv, "Salary")

        cmbempid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbempid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "ADD" Then
            btnadd.Text = "SAVE"
            cmbempid.Text = ""
            txtempname.Text = ""
            txtempphno.Text = ""
            txtempadd.Text = ""
            txtempemail.Text = ""
            cmbempgen.Text = ""
            DateTimePicker1.Text = ""
            txtempdesig.Text = ""
            DateTimePicker2.Text = ""
            txtempsal.Text = "Rs"

            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Empid) from EmployeeInfo", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "EmployeeInfo")
            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                cmbempid.Text = "E000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                cmbempid.Text = "E00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                cmbempid.Text = "E0" & id
            ElseIf (id > 999) Then
                id = id + 1
                cmbempid.Text = "E" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else

            If (txtempname.Text = "" Or txtempphno.Text = "" Or txtempadd.Text = "" Or txtempemail.Text = "" Or cmbempgen.Text = "" Or DateTimePicker1.Text = "" Or txtempdesig.Text = "" Or DateTimePicker2.Text = "" Or txtempsal.Text = "Rs") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)
            Else
                h.AMD("Insert into EmployeeInfo values('" + cmbempid.Text + "','" + txtempname.Text + "','" + txtempphno.Text + "','" + txtempadd.Text + "','" + txtempemail.Text + "','" + cmbempgen.Text + "','" + DateTimePicker1.Text + "','" + txtempdesig.Text + "','" + DateTimePicker2.Text + "','" + txtempsal.Text + "')", "Record Inserted Succesfully")
                btnadd.Text = "ADD"
                EmployeeForm_Load(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "UPDATE" Then
            btnupdate.Text = "MODIFY"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from EmployeeInfo where Empid='" + cmbempid.Text + "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
        Else
            h.AMD("Update  EmployeeInfo set Empname='" + txtempname.Text + "',Phno='" + txtempphno.Text + "',Address='" + txtempadd.Text + "',EMail='" + txtempemail.Text + "',Gender='" + cmbempgen.Text + "',Birthdate='" + DateTimePicker1.Text + "',Designation='" + txtempdesig.Text + "',Joindate='" + DateTimePicker2.Text + "',Salary='" + txtempsal.Text + "'WHERE Empid='" + cmbempid.Text + "'", "Record Updated Succesfully")
            btnupdate.Text = "UPDATE"
            con.Close()
            EmployeeForm_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from EmployeeInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "EmployeeInfo")
        h.AMD("Delete From EmployeeInfo where Empid='" + cmbempid.Text + "' ", "Record Deleted Succesfully")
        con.Close()
        EmployeeForm_Load(Nothing, Nothing)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempphno.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempdesig.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempsal.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempemail.KeyPress
        
    End Sub



    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempemail.TextChanged
        
    End Sub

    Private Sub dgvpat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpat.CellContentClick

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtempphno.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged

        Dim cmd As New SqlCommand("select * from EmployeeInfo where Empid='" & cmbempid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtempname.Text = dr.GetString(1)
            txtempphno.Text = dr.GetString(2)
            txtempadd.Text = dr.GetString(3)
            txtempemail.Text = dr.GetString(4)
            cmbempgen.Text = dr.GetString(5)
            txtempdesig.Text = dr.GetString(7)
            txtempsal.Text = dr.GetString(9)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        empsearch.Show()
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtempname.Text = ""
        txtempphno.Text = ""
        txtempadd.Text = ""
        txtempemail.Text = ""
        cmbempgen.Text = ""
        DateTimePicker1.Text = ""
        txtempdesig.Text = ""
        DateTimePicker2.Text = ""
        txtempsal.Text = "Rs"
    End Sub

    Private Sub txtempemail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtempemail.Validated
        If EmailAddressCheck(txtempemail.Text) = True Then
            MsgBox("Valid Email")
        Else
            MsgBox("InValid Email")
            txtempemail.Focus()
        End If
    End Sub

    Private Sub txtempphno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtempphno.Validating
        
    End Sub
End Class