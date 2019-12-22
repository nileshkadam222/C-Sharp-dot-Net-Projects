Imports System.Data.SqlClient
Public Class empsearch
    Dim h As helper = New helper
    Dim dv As DataView
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjdate.TextChanged
       
    End Sub

    Private Sub empsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("select * from EmployeeInfo", con)
        Dim ds = New DataSet()
        con.Open()
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "EmployeeInfo")
        dv = New DataView(ds.Tables(0))
        'Clear binding
        '
        cmbempid.DataBindings.Clear()
        txtempname.DataBindings.Clear()
        txtempphno.DataBindings.Clear()
        txtempadd.DataBindings.Clear()
        txtempemail.DataBindings.Clear()
        cmbempgen.DataBindings.Clear()
        txtbdate.DataBindings.Clear()
        txtempdesig.DataBindings.Clear()
        txtjdate.DataBindings.Clear()
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
        txtbdate.DataBindings.Add("text", dv, "Birthdate")
        txtempdesig.DataBindings.Add("text", dv, "Designation")
        txtjdate.DataBindings.Add("text", dv, "Joindate")
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

    Private Sub cmbempid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempid.SelectedIndexChanged
        Dim cmd As New SqlCommand("select * from EmployeeInfo where Empid='" & cmbempid.Text & "'", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read()
            txtempname.Text = dr.GetString(1)
            txtempphno.Text = dr.GetString(2)
            txtempadd.Text = dr.GetString(3)
            txtempemail.Text = dr.GetString(4)
            cmbempgen.Text = dr.GetString(5)
            txtbdate.Text = dr.GetString(6)
            txtempdesig.Text = dr.GetString(7)
            txtjdate.Text = dr.GetString(8)
            txtempsal.Text = dr.GetString(9)

        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class