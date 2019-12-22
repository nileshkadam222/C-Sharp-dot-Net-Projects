Imports System.Data.SqlClient
Public Class MRNForm
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub MRNForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from MRNInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "MRNInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv

        'Clear binding
        '
        cmbmrnid.DataBindings.Clear()
        dtpmrn.DataBindings.Clear()
        txtmssupp.DataBindings.Clear()
        txtmrnpid.DataBindings.Clear()
        txtmrnpname.DataBindings.Clear()
        txtmrnquntrec.DataBindings.Clear()
        txtqureject.DataBindings.Clear()
        txtquetotal.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmbmrnid.DataBindings.Add("text", dv, "Mrnid")
        dtpmrn.DataBindings.Add("text", dv, "MDate")
        txtmssupp.DataBindings.Add("text", dv, "MSuppliers")
        txtmrnpid.DataBindings.Add("text", dv, "MProdid")
        txtmrnpname.DataBindings.Add("text", dv, "MProdname")
        txtmrnquntrec.DataBindings.Add("text", dv, "MQtyrecvd")
        txtqureject.DataBindings.Add("text", dv, "MQtyreject")
        txtquetotal.DataBindings.Add("text", dv, "MTotal")
        

        cmbmrnid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbmrnid.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "ADD" Then
            btnadd.Text = "SAVE"
            cmbmrnid.Text = ""
            dtpmrn.Text = ""
            txtmssupp.Text = ""
            txtmrnpid.Text = ""
            txtmrnpname.Text = ""
            txtmrnquntrec.Text = "Kg"
            txtqureject.Text = "Kg"
            txtquetotal.Text = "Kg"




            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Mrnid) from MRNInfo", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "MRNInfo")
            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                cmbmrnid.Text = "M000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                cmbmrnid.Text = "M00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                cmbmrnid.Text = "M0" & id
            ElseIf (id > 999) Then
                id = id + 1
                cmbmrnid.Text = "M" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else

            If (dtpmrn.Text = "" Or txtmssupp.Text = "" Or txtmrnpid.Text = "" Or txtmrnpname.Text = "" Or txtmrnquntrec.Text = "Kg" Or txtqureject.Text = "Kg" Or txtquetotal.Text = "Kg") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)


            Else
                h.AMD("Insert into MRNInfo values('" + cmbmrnid.Text + "','" + txtmssupp.Text + "','" + txtmrnpid.Text + "','" + txtmrnpname.Text + "', '" + dtpmrn.Text + "','" + txtmrnquntrec.Text + "','" + txtqureject.Text + "','" + txtquetotal.Text + "')", "Record Inserted Succesfully")
                btnadd.Text = "ADD"

                MRNForm_Load(Nothing, Nothing)

            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "UPDATE" Then
            btnupdate.Text = "MODIFY"




            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from MRNInfo where Mrnid='" + cmbmrnid.Text + "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()


        Else


            h.AMD("Update  MRNInfo set MDate='" + dtpmrn.Text + "',MSuppliers='" + txtmssupp.Text + "',MProdid='" + txtmrnpid.Text + "',MProdname='" + txtmrnpname.Text + "',MQtyrecvd='" + txtmrnquntrec.Text + "',MQtyreject='" + txtqureject.Text + "',MTotal='" + txtquetotal.Text + "' WHERE Mrnid='" + cmbmrnid.Text + "'", "Record Updated Succesfully")
            btnupdate.Text = "UPDATE"
            con.Close()
            MRNForm_Load(Nothing, Nothing)

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click

        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from MRNInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "MRNInfo")
        h.AMD("Delete From MRNInfo where Mrnid='" + cmbmrnid.Text + "'", "Record Deleted Succesfully")
        con.Close()
        MRNForm_Load(Nothing, Nothing)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else


        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmssupp.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmrnpname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmrnquntrec.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqureject.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquetotal.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmrnid.SelectedIndexChanged

        Dim cmd As New SqlCommand("select * from MRNInfo where Mrnid='" & cmbmrnid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtmssupp.Text = dr.GetString(1)
            txtmrnpid.Text = dr.GetString(2)
            txtmrnpname.Text = dr.GetString(3)

            txtmrnquntrec.Text = dr.GetString(5)
            txtqureject.Text = dr.GetString(6)
            txtquetotal.Text = dr.GetString(7)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        mrnsearch.Show()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        dtpmrn.Text = ""
        txtmssupp.Text = ""
        txtmrnpid.Text = ""
        txtmrnpname.Text = ""
        txtmrnquntrec.Text = "Kg"
        txtqureject.Text = "Kg"
        txtquetotal.Text = "Kg"

    End Sub
End Class