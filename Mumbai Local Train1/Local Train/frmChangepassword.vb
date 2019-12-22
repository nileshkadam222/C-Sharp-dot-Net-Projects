Public Class frmChangepassword
    Dim s, ss As String
    Dim cn As New SqlClient.SqlConnection
    Dim cm As New SqlClient.SqlCommand
    Dim adp As New SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim ctr, i As Int16

    Private Sub frmChangepassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
          Call Connection()
        MsgBox("Welcome for Change the Password")
        Timer1.Enabled = True
    End Sub

    Private Sub cmdchangepassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdchangepassword.Click
        If txtname.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Password Can't be Update Please Fill All the record")
            Exit Sub
        End If
        ss = "Update Login set Password = '" + txtpassword.Text + "'where Name ='" + txtname.Text + "'"
        cm = New SqlClient.SqlCommand(ss, cn)
        cm.ExecuteNonQuery()
        MsgBox("Password is Updated Successfully", MsgBoxStyle.Information)
        txtname.Text = ""
        txtpassword.Text = ""
        txtname.Focus()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtname.Text = ""
        txtpassword.Text = ""
        txtname.Focus()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        End
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        e.KeyChar = onlyalphabet(e.KeyChar)
    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtdatetime.Text = Now
    End Sub
End Class