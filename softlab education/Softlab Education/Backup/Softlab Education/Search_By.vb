Public Class Search_By
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If cmbsearch.Text = "Search_Student" Then
            Search_Student.Show()

        End If
        
        If cmbsearch.Text = "Search_addmission" Then
            Search_addmission.Show()

        End If

        If cmbsearch.Text = "Search_Installment" Then
            Search_Installment.Show()
        End If
        If cmbsearch.Text = "Search_Batch" Then
            Search_Batch.Show()
        End If
        If cmbsearch.Text = "Search_Faculty" Then
            Search_Faculty.Show()
        End If
        If cmbsearch.Text = "Search_Receipt" Then
            Search_Receipt.Show()
        End If
        If cmbsearch.Text = "Search_Result" Then
            Search_Result.Show()
        End If

    End Sub

   
    Private Sub Search_By_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class