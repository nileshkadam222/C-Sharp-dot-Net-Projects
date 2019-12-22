
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Shared_Market_System
	Public Partial Class frmmaster
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub companyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmcompany()

			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()

		End Sub

		Private Sub brokerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			'Form frm = new frmbroker();

			'frm.MdiParent = this;
			'frm.StartPosition = FormStartPosition.CenterScreen;
			'frm.Show();
		End Sub

		Private Sub clientToolStripMenuItem_Click(sender As Object, e As EventArgs)
			'Form frm = new frmclient();

			'frm.MdiParent = this;
			'frm.StartPosition = FormStartPosition.CenterScreen;
			'frm.Show();
		End Sub

		Private Sub adminToolStripMenuItem_Click(sender As Object, e As EventArgs)
			'Form frm = new frmadmin_details();
			'frm.MdiParent = this;
			'frm.StartPosition = FormStartPosition.CenterScreen;
			'frm.Show();
		End Sub

		Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub frmmaster_Load(sender As Object, e As EventArgs)

		End Sub

		Private Sub sharesToolStripMenuItem_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub shareToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmShare_details()
			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub clientdetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub clientsharesToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmclient_shares()

			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub brokerdetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub brokersharesToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmbroker_shares()

			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub brokerUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs)

		End Sub

		Private Sub newToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmadmin_details()
			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub updateToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmUpdate_Admin_Details()
			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub newToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmclient_details()

			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub updateToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmUpdateClient_Details()

			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub newToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmbroker_details()

			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub

		Private Sub updateToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim frm As Form = New frmbroker_update()

			frm.MdiParent = Me
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.Show()
		End Sub
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
