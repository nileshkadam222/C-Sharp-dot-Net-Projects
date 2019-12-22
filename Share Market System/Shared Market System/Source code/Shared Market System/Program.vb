
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace Shared_Market_System
	NotInheritable Class Program
		Private Sub New()
		End Sub
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Private Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Dim login As New frmLogin()
			If login.ShowDialog() <> DialogResult.OK Then

				login.Dispose()
			End If
			Application.Run(New frmmaster())

		End Sub
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
