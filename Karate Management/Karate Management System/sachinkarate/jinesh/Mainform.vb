Public Class Mainform

    Private Sub TRAINERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRAINERToolStripMenuItem.Click
        Trainer.Show()

    End Sub

    Private Sub EXIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXIToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub APPLICANTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APPLICANTToolStripMenuItem1.Click
        Applicant.Show()

    End Sub

    Private Sub COURSEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COURSEToolStripMenuItem1.Click
        Courses.Show()

    End Sub

    Private Sub BATCHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BATCHToolStripMenuItem.Click
        Batch.Show()

    End Sub

    Private Sub STAGESHOWDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAGESHOWDETAILSToolStripMenuItem.Click
        Stage_show_details.Show()

    End Sub

    Private Sub ASSIGNAPPLICANTTOSTAGESHOWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASSIGNAPPLICANTTOSTAGESHOWToolStripMenuItem.Click
        Assign_batch.Show()

    End Sub

    Private Sub ApplicanTlistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicanTlistToolStripMenuItem.Click
        applist.Show()

    End Sub

    Private Sub TrainerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainerListToolStripMenuItem.Click
        trainer_list.Show()
    End Sub

    Private Sub CourseListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseListToolStripMenuItem.Click
        courselist.Show()
    End Sub

    Private Sub BatchListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchListToolStripMenuItem.Click
        batchlist.Show()
    End Sub

    Private Sub StageShowListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StageShowListToolStripMenuItem.Click
        stageshowlist.Show()

    End Sub

    Private Sub AssignBatchListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignBatchListToolStripMenuItem.Click
        assignbatchlist.Show()

    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHToolStripMenuItem.Click
        Search.Show()
    End Sub

    Private Sub SEARCHToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHToolStripMenuItem1.Click
        SEARCH1.Show()
    End Sub

    Private Sub SEARCHToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHToolStripMenuItem2.Click
        Search2.Show()
    End Sub

    
    Private Sub ABOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class