Public Class fRptCheckIn

    Private Sub fRptCheckIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OptToday.Checked = True
        txtToday.Text = Format(Now, "dd-MMM-yyyy")
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        RCheckIn.Show()
    End Sub

    Private Sub OptFrom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptFrom.CheckedChanged
        If OptFrom.Checked = True Then
            DTFrom.Enabled = True
            DTto.Enabled = True
        Else
            DTFrom.Enabled = False
            DTto.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class