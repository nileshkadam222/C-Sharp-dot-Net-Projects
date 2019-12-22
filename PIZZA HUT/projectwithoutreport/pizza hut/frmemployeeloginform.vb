Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmemployeeloginform
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim cmd As New SqlCommand("select * from Login where Name='" & txtemployeename.Text & "' and Password='" & txtpassword.Text & "'", cn)
        cn.Open()
        
        If txtemployeename.Text = "Employee" Then
            frmMDIParent.mnuemployeelogin.Enabled = False

            MsgBox("Login Success...!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "LOGIN")
            Me.Hide()
            frmemployeeAttendence.Show()
            'MDIParentform.mnuEmployeeAttendenceToolStripMenuItem.Enabled = True
            frmMDIParent.mnuaddnewingredient.Enabled = False
            frmMDIParent.mnuchangepassword.Enabled = False
            frmMDIParent.mnuaddpackagingmaterial.Enabled = False
            frmMDIParent.mnucustomer.Enabled = False
            frmMDIParent.mnucustomerdetails.Enabled = False
            frmMDIParent.mnuemployeedetails.Enabled = False
            frmMDIParent.mnuemployeepay.Enabled = False
            frmMDIParent.mnusoldproduct.Enabled = False
            frmMDIParent.Mnusellingprice.Enabled = False
            frmMDIParent.mnustockroominventory.Enabled = False
            frmMDIParent.mnusupplier.Enabled = False
            

        Else
            MsgBox("Login fails...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
        
        cn.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub
End Class