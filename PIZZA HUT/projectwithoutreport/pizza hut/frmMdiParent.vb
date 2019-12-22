Imports System.Windows.Forms

Public Class frmMDIParent
    Private Sub ProductPriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductPriceToolStripMenuItem.Click
        Me.Hide()
        frmproductgroupprice.Show()
    End Sub

    Private Sub IndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        Me.Hide()
        frmitem.Show()
    End Sub

    Private Sub mnuaddnewingredient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuaddnewingredient.Click
        Me.Hide()
        frmaddingredients.Show()
    End Sub

    Private Sub mnuaddpackagingmaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuaddpackagingmaterial.Click
        Me.Hide()
        frmadd.Show()
    End Sub

    Private Sub mnustockroominventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnustockroominventory.Click
        Me.Hide()
        frminventorydetails.Show()
    End Sub

    Private Sub mnusoldproduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusoldproduct.Click
        Me.Hide()
        frmviewsold.Show()
    End Sub

    Private Sub mnucustomerdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucustomerdetails.Click
        Me.Hide()
        frmcustomerdetails1.Show()
    End Sub

    Private Sub mnuemployeedetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuemployeedetails.Click
        Me.Hide()
        frmemployeedetails.Show()
    End Sub

    Private Sub mnuchangepassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuchangepassword.Click
        Me.Hide()
        frmconform.Show()
    End Sub

    Private Sub mnubacktologin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub mnuexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuexit.Click
        End
    End Sub

    Private Sub mnubill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnubill.Click
        Me.Hide()
        frmbill.Show()

    End Sub

    Private Sub mnuemployeelogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuemployeelogin.Click
        Me.Hide()
        frmemployeeloginform.Show()
    End Sub

    Private Sub mnuemployeepay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuemployeepay.Click
        Me.Hide()
        frmPaymentSlip.Show()
    End Sub

    Private Sub mnusupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnusupplier.Click
        Me.Hide()
        frmsuppiler.Show()
    End Sub

    Private Sub mnunotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnunotepad.Click
        Shell("notepad.exe")
    End Sub

    Private Sub mnuinternetexplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuinternetexplorer.Click
        Shell("C:\Program Files\Internet Explorer\IEXPLORE.exe")
    End Sub

    Private Sub mnucalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnucalculator.Click
        Shell("Calc.exe")
    End Sub

   
    Private Sub SupplierDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierDetailsToolStripMenuItem.Click
        Me.Hide()
        frmsuppiler.Show()
    End Sub
End Class
