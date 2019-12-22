Public Class frmadduser

    Private Sub frmadduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Call Connection()
        MsgBox("Welcome for Add a New User")
        Timer1.Enabled = True
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If txtname.Text = "" Or txtpassword.Text = "" Or txtconfirmpassword.Text = "" Then
            MsgBox("Please fill all records", MsgBoxStyle.Information)
        Else
            ss = "select * from Login"
            adp = New SqlClient.SqlDataAdapter(ss, cn)
            ds = New DataSet
            adp.Fill(ds, "Login")
            ctr = ds.Tables(0).Rows.Count - 1
            For i = 0 To ctr
                If txtpassword.Text = ds.Tables(0).Rows(i).Item(1) Then
                    MsgBox("Password is Already exist")
                    Exit Sub
                End If
            Next
            If txtconfirmpassword.Text = "" Then
                MsgBox("Confirm your password")
                Exit Sub
            End If
            If txtpassword.Text = txtconfirmpassword.Text Then
                s = "insert into Login Values('" & txtname.Text & "','" & txtpassword.Text & "','" & Convert.ToDateTime(txtdatetime.Text) & "')"
                Dim cm As New SqlClient.SqlCommand(s, cn)
                'txtpassword.Text = s
                cm.ExecuteNonQuery()
                MsgBox("New User Created")
                clear()
            Else
                MsgBox("Password Mismatch")
            End If
        End If
    End Sub
    Sub clear()
        txtname.Text = ""
        txtpassword.Text = ""
        txtconfirmpassword.Text = ""
        txtname.Focus()
    End Sub


    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        clear()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        End
    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.Click
        Dim f As New frmlogin
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtdatetime.Text = Now
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        e.KeyChar = onlyalphabet(e.KeyChar)
    End Sub
End Class
