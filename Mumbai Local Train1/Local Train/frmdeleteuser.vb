Public Class frmdeleteuser
    Dim qry, ss As String
    Dim cn As New SqlClient.SqlConnection(s)
    Dim cm As New SqlClient.SqlCommand
    Dim adp As New SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim ctr, i As Int16
    Private Sub frmdeleteuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Call Connection()
        MsgBox("Welcome for Remove the User")
        Timer1.Enabled = True
    End Sub

    Private Sub cmddelleteuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelleteuser.Click
        If MsgBox("Are you Sure to delete a User ?", MsgBoxStyle.YesNo, "Delete.....!") = MsgBoxResult.Yes Then
            qry = "Delete from Login where Name= '" + txtname.Text + "'"
            cn.Open()
            cm = New SqlClient.SqlCommand(qry, cn)
            cm.ExecuteNonQuery()
            MsgBox("User is Deleted Successfully", MsgBoxStyle.Information)
        End If
        txtname.Text = ""
        txtname.Focus()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtname.Text = ""
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