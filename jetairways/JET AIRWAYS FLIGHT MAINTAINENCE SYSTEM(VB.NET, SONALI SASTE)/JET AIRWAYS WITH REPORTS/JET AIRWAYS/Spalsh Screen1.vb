Public Class Form1

   
    

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pb1.Value <> 100 Then
            pb1.Value = pb1.Value + 2
        End If
        If pb1.Value = 100 Then

            Me.Hide()
            Form2.Show()
        End If
        
    End Sub
End Class
