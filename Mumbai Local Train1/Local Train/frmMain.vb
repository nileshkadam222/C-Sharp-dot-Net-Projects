Imports System.Windows.Forms

Public Class frmMain
    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub mnuOSK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOSK.Click
        System.Diagnostics.Process.Start("osk.exe")
    End Sub

    Private Sub mnuCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalculator.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub mnuNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotepad.Click
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub

    Private Sub mnuWordPad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWordPad.Click
        System.Diagnostics.Process.Start("wordpad.exe")
    End Sub

    Private Sub CascadeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub ToolBarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        Dim f As New frmSearch_Ticket
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ExitToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem4.Click
        End
    End Sub
    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        Dim f As New frmadduser
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim f As New frmChangepassword
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Dim f As New frmdeleteuser
        f.MdiParent = Me
        f.Show()
    End Sub
  
    Private Sub ExitToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem6.Click
        End
    End Sub

   
    Private Sub HarbourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HarbourToolStripMenuItem.Click
        Dim f As New frmHarbour_Ticket
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CreateTicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateTicketToolStripMenuItem.Click
        Dim f As New frmWestern_Ticket
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim f As New frmCentral_Ticket
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub HarbourToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HarbourToolStripMenuItem1.Click
        Dim f As New frmHarbour_Pass
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CreatePassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePassToolStripMenuItem.Click
        Dim f As New frmWestern_Pass
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ExitToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem3.Click
        Dim f As New frmCentral_Pass
        f.MdiParent = Me
        f.Show()
    End Sub
    Private Sub MapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapToolStripMenuItem.Click
        Dim f As New frmMap
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim f As New frmAboutSoft
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PassToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassToolStripMenuItem2.Click
        Dim f As New frmSearch_Pass
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
