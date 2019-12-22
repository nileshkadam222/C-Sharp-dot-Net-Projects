
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Namespace Shared_Market_System
	Public Class connstring
		Public s As String
		Public Shared username As String
		Public Shared pass As String
		Public Shared role As String
		Public Shared serverName As String
		'public string conn = (@"Data Source=" + serverName + ";initial Catalog=SMS;user id=sa;password=greentea;");
		'public static string conn = (@"Data Source=ibi2\sqlexpress1;initial Catalog=SMS;user id=sa;password=greentea;");

		'public SqlConnection con = new SqlConnection("Data Source=ibi2\\SQLEXPRESS1;initial Catalog=SMS;user id=sa;password=greentea;");
		Public con As SqlConnection
		Public Sub New()
			'con = new SqlConnection("Data Source=.\\sqlExpress;AttachDBFilename=|DataDirectory|SHIPPINGNCARGO_Data.MDF;integrated security=true;");

			'Attaching Database directly
			' string strCon = "Data Source=.\\SQLExpress;AttachDBFilename=|DataDirectory|db_LMS.mdf;integrated security=true;";


			Dim myFile As StreamReader = New System.IO.StreamReader("c:\cont")
			Dim myString As String = myFile.ReadToEnd()
			Dim str As String() = myString.Split(New Char() {";"C})
			connstring.serverName = myString
			myFile.Close()



			con = New SqlConnection("Data Source=" + str(0) + ";initial Catalog=SMS;user id=" + str(1) + ";password=" + str(2) + "")
		End Sub
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
