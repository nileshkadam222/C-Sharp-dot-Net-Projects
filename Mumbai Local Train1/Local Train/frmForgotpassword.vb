Public Class frmforgotpassword
    Private Sub frmforgotpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Call Connection()
        MsgBox("Are you Forgot a Password ?...")
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        If txtname.Text = "" Then
            MsgBox("Please Enter your name")
            Exit Sub
        End If
        ss = "select * from Login"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Login")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            If txtname.Text = ds.Tables(0).Rows(i).Item(0) Then
                txtpassword.Text = ds.Tables(0).Rows(i).Item(1)
                Exit Sub
            End If
        Next
        txtpassword.Text = ""
        MsgBox("Sorry!..... No User of this Name")
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        End
    End Sub

    Private Sub lblback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblback.Click
        Dim f As New frmlogin
        f.Show()
        Me.Hide()
    End Sub
End Class