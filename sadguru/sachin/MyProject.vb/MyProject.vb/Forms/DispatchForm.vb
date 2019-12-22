Imports System.Data.SqlClient
Public Class DispatchForm
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub DispatchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from DispatchInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "DispatchInfo")
        dv = New DataView(ds.Tables(0))
        dgvpat.DataSource = dv

        'Clear binding
        '
        cmbdisid.DataBindings.Clear()
        txtdisto.DataBindings.Clear()
        txtquesend.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
        txtdisfrom.DataBindings.Clear()
        txtamt.DataBindings.Clear()

        '
        'data binding 
        '
        con.Close()
        cmbdisid.DataBindings.Add("text", dv, "Dispno")
        txtdisto.DataBindings.Add("text", dv, "Dispto")
        txtquesend.DataBindings.Add("text", dv, "Qtysend")
        DateTimePicker1.DataBindings.Add("text", dv, "Date")
        txtdisfrom.DataBindings.Add("text", dv, "Dispfrm")
        txtamt.DataBindings.Add("Text", dv, "Amount")
        con.Close()
        cmbdisid.Items.Clear()
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbdisid.Items.Add(dr.GetString(0))

        End While
        dr.Close()
        con.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "ADD" Then
            Button1.Text = "SAVE"
            cmbdisid.Text = ""
            txtdisto.Text = ""
            txtquesend.Text = "kg"
            DateTimePicker1.Text = ""
            txtdisfrom.Text = ""
            txtamt.Text = "Rs"




            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select max(Dispno) from DispatchInfo", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
            da1.Fill(ds1, "DispatchInfo")
            Dim str, code As String
            Dim id As Integer
            str = ds1.Tables(0).Rows(0).Item(0).ToString()
            code = str.Substring(1, 4)
            id = CUInt(code)
            If (id >= 0 And id < 9) Then
                id = id + 1
                cmbdisid.Text = "D000" & id
            ElseIf (id >= 9 And id < 99) Then
                id = id + 1
                cmbdisid.Text = "D00" & id
            ElseIf (id >= 99 And id < 999) Then
                id = id + 1
                cmbdisid.Text = "D0" & id
            ElseIf (id > 999) Then
                id = id + 1
                cmbdisid.Text = "D" & id
            End If
            cmd1.ExecuteNonQuery()
            con.Close()
        Else

            If (DateTimePicker1.Text = "" Or txtdisto.Text = "" Or txtquesend.Text = "kg" Or txtdisfrom.Text = "" Or txtamt.Text = "Rs") Then
                MsgBox("Please Fill The Blank Field(s) !!", MsgBoxStyle.OkOnly)


            Else
                h.AMD("Insert into DispatchInfo values('" + cmbdisid.Text + "','" + txtdisto.Text + "','" + txtdisfrom.Text + "','" + DateTimePicker1.Text + "','" + txtquesend.Text + "','" + txtamt.Text + "')", "Record Inserted Succesfully")
                Button1.Text = "ADD"
                DispatchForm_Load(Nothing, Nothing)

            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "UPDATE" Then
            Button2.Text = "MODIFY"




            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from DispatchInfo where Dispno='" + cmbdisid.Text + "'", con)
            Dim ds1 As DataSet = New DataSet()
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            con.Open()
        Else
            h.AMD("Update DispatchInfo set Dispto='" + txtdisto.Text + "',Qtysend='" + txtquesend.Text + "',Dispfrm='" + txtdisfrom.Text + "',Amount='" + txtamt.Text + "'WHERE Dispno='" + cmbdisid.Text + "'", "Record Updated Succesfully")
            Button2.Text = "UPDATE"
            con.Close()
            DispatchForm_Load(Nothing, Nothing)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from DispatchInfo", con)
        Dim ds1 As DataSet = New DataSet()
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
        con.Open()
        da1.Fill(ds1, "DispatchInfo")
        h.AMD("Delete From DispatchInfo where Dispno='" + cmbdisid.Text + "' ", "Record Deleted Succesfully")
        con.Close()
        DispatchForm_Load(Nothing, Nothing)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim s As String
        s = MsgBox("Do You Want To EXIT", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        Else


        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdisto.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquesend.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")

        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdisfrom.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter Only Letters")

        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            MsgBox("Enter Only Numbers")
        End If
    End Sub


    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmbfind_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdisid.SelectedIndexChanged

        Dim cmd As New SqlCommand("select * from DispatchInfo  where Dispno='" & cmbdisid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtdisto.Text = dr.GetString(1)
            txtdisfrom.Text = dr.GetString(2)
            txtquesend.Text = dr.GetString(4)
            txtamt.Text = dr.GetString(5)
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdisto.TextChanged

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        dispatchsearch.Show()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtdisto.Text = ""
        txtquesend.Text = "kg"
        DateTimePicker1.Text = ""
        txtdisfrom.Text = ""
        txtamt.Text = "Rs"

    End Sub
End Class