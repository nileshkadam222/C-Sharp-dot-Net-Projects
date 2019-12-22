Public Class frmlogin
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()
        MsgBox("Connection Opened Successfuly")
        l1.Text = 60
        l1.ForeColor = Color.White
        Timer1.Enabled = True
        pb1.Value = 60
        cn.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pb1.Value = pb1.Value - 1
        l1.Text = pb1.Value
        If pb1.Value = 0 Then
            Timer1.Enabled = False
            MsgBox("Sorry! Your Times is Up...", MsgBoxStyle.OkOnly, "Times Up")
            End
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        e.KeyChar = onlyalphabet(e.KeyChar)
    End Sub
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        If txtname.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Please first Enter Name and Password then Login", MsgBoxStyle.Information)
            Exit Sub
        End If
        ss = "select * from Login"
        adp = New SqlClient.SqlDataAdapter(ss, cn)
        ds = New DataSet
        adp.Fill(ds, "Login")
        ctr = ds.Tables(0).Rows.Count - 1
        For i = 0 To ctr
            If txtname.Text = ds.Tables(0).Rows(i).Item(0) Or txtpassword.Text = ds.Tables(0).Rows(i).Item(1) Then
                frmMain.Show()
                Me.Hide()
                Timer1.Enabled = False
                Exit Sub
            End If
        Next
        MsgBox("Sorry! Incorrect Password", MsgBoxStyle.Critical, "Sorry")
        If MsgBox("Pasowrd Forgot...?", MsgBoxStyle.YesNo, "Forgotted!") = MsgBoxResult.Yes Then
            Dim f As New frmforgotpassword
            f.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
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
    Private Sub txtname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtname.Leave
        If txtname.Text = "" Then
            ep.SetError(txtname, "Please Enter Name First")
            txtname.Focus()
        End If
    End Sub

    Private Sub ADDUSERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDUSERToolStripMenuItem.Click
        Dim f As New frmadduser
        f.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub

    Private Sub OSKeyboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSKeyboardToolStripMenuItem.Click
        System.Diagnostics.Process.Start("osk.exe")
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class