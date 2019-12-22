Imports System.Data.OleDb
Module Module1
    Public Cnn As New OleDbConnection
    Public Com As New OleDbCommand
    Public Dr As OleDbDataReader
    Public CusSearch As String 'Search Customer

    Public Sub OpenConnect()
        Try
            Cnn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" & _
            "Data Source=" & Application.StartupPath & "\DB.mdb"
            Cnn.Open()
            Com.Connection = Cnn
            Com.CommandType = CommandType.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Message(ByVal Mess As String)
        MsgBox(Mess, MsgBoxStyle.Information, "Hotel Management System")
    End Sub


    Public Function Getid(ByVal tablename As String, ByVal fieldname As String, Optional ByVal cond As String = "") As Double
        Try
            Dim com1 As New OleDbCommand
            Dim dr1 As OleDbDataReader
            com1.Connection = Cnn
            com.CommandText = "select top 1 " & fieldname & " from " & tablename & IIf(cond <> "", " where " & cond, "") & " order by 1 desc"
            dr1 = Com.ExecuteReader
            If dr1.Read = True Then
                Getid = dr1(0) + 1
            Else
                Getid = 1
            End If
            dr1.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function

    Public Sub ClearAll(ByVal frm As Form)
        Dim Crt As Control
        For Each Crt In frm.Controls
            If TypeOf Crt Is TextBox Then
                Crt.Text = ""
            End If
        Next
    End Sub

    Public Sub AddDataToLvw(ByVal Lvw As ListView, ByVal ParamArray Data() As Object)
        Dim LItem As ListViewItem
        LItem = Lvw.Items.Add(Data(0), 0)
        Dim i As Int16
        For i = 1 To UBound(Data)
            LItem.SubItems.Add(i).Text = Data(i)
        Next
    End Sub

    Public Sub ShowForm(ByVal frm As Form, ByVal frm1 As Form)
        Dim L, M As Int32
        L = (frm1.Width - frm.Width) / 2
        M = (frm1.ClientSize.Height - frm.Height) / 2

        frm.MdiParent = frm1
        If frm.IsHandleCreated = True Then
            frm.BringToFront()
        Else
            frm.Show()
            frm.SetBounds(L, M, frm.Width, frm.Height)
        End If
    End Sub

    Function AutoID(ByVal Tablename As String, ByVal Fieldname As String) As Int32
        Dim cmd As New OleDbCommand
        Dim dr1 As OleDbDataReader
        cmd.Connection = Cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select top 1 " & Fieldname & " from " & Tablename & " Order by 1 Desc "
        dr1 = cmd.ExecuteReader
        If dr1.Read = True Then
            AutoID = Microsoft.VisualBasic.Right(dr1(0), 4) + 1
        Else
            AutoID = 1
        End If
        dr1.Close()
    End Function
End Module
