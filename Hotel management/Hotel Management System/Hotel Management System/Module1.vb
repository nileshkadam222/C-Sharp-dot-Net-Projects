Imports System.Data.OleDb
Module Module1
    Public Cnn As New OleDbConnection
    Public Com As New OleDbCommand
    Public Dr As OleDbDataReader
    Public CusSearch As String 'Search Customer
    Public App As String = "D:\UMFH12\16065\Hotel Management System\Hotel Management System\bin\Debug"

    Public CuID, CName, CGender, CAddress, CPNo, CCNo As String
    Public UserID As Int32 'Get ID from tblUser

    Public BID As Int32
    Public i As Int16
    Public M As Byte

    Dim Da As New OleDbDataAdapter
    Dim Dt, Dt1, Dt2 As New DataTable
    Public Sub OpenConnect()
        Try
            Cnn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;" & _
            "Data Source=" & App & "\DB.mdb"
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
    Public Sub onlyInteger(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Asc(e.KeyChar) = 8 Then
            If InStr("0123456789.", e.KeyChar) = 0 Then
                e.Handled = True
                MsgBox("Please enter numbers only")
            End If
        End If
    End Sub
    Public Sub onlyAlphabate(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Asc(e.KeyChar) = 8 Then
            If InStr("abcdefghijklmnopqrstuvwxyz .", e.KeyChar, CompareMethod.Text) = 0 Then
                e.Handled = True
                MsgBox("Enter Only Alphabate")
            End If
        End If
    End Sub
   

    Function Encrypt(ByVal SText As String) As String
        Dim S As String = ""
        Dim S1 As String = ""
        Dim i As Integer
        For i = 1 To Len(SText)
            S = S & Chr(Asc(Mid(SText, i, 1)) + 10)
        Next
        S = StrReverse(S)
        For i = 1 To Len(S)
            S1 = S1 & Mid(S, i, 1) & "@"
        Next
        Encrypt = S1
    End Function

    Function Decrypt(ByVal SText As String) As String
        Dim S As String = ""
        Dim S1 As String = ""
        Dim i As Integer
        For i = 1 To Len(SText)
            If Mid(SText, i, 1) <> "@" Then
                S1 = S1 & Mid(SText, i, 1)
            End If
        Next
        S1 = StrReverse(S1)
        For i = 1 To Len(S1)
            S = S & Chr(Asc(Mid(S1, i, 1)) - 10)
        Next
        Decrypt = S
    End Function

    Public Sub CheckInMenu()
        ShowForm(frmCheckIn, Main)
        frmCheckIn.btnBooking.Enabled = False
        frmCheckIn.btnCheckIn.Enabled = True
        frmCheckIn.lblCheckIn.Text = "CheckIn Date:"
        frmCheckIn.lblCheckOut.Text = "CheckOut Date:"
        frmCheckIn.DTCheckIn.SendToBack()
    End Sub

    Public Sub BookingMenu()
        ShowForm(frmCheckIn, Main)
        frmCheckIn.btnCheckIn.Enabled = False
        frmCheckIn.btnBooking.Enabled = True
        frmCheckIn.lblCheckIn.Text = "Booking Date:"
        frmCheckIn.lblCheckOut.Text = "   CheckIn Date:"
        frmCheckIn.txtCheckOut.SendToBack()
    End Sub

    Public Sub LoadRoomType(ByVal cbo As ComboBox)
        Dt1.Clear()
        ' Load Data into cboRoomType
        Com.CommandText = "Select ID,RoomType from tblPrice"
        Da.SelectCommand = Com
        Da.Fill(Dt1)
        Dt1.TableName = "Price"
        cbo.DataSource = Dt1
        cbo.ValueMember = Dt1.Columns(0).ToString
        cbo.DisplayMember = Dt1.Columns(1).ToString
    End Sub

    Public Sub LoadRoomNum(ByVal cbo As ComboBox, ByVal cbo1 As ComboBox, ByVal txt As TextBox, ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox)
        cbo.Items.Clear()
        Com.CommandText = "Select RoomNo,UnitPrice from QRoom where RoomType='" & cbo1.Text & "'"
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            cbo.Items.Add(Dr(0))
            txt.Text = Format(Dr(1), "Currency")
        Loop

        txt1.Clear()
        Dr.Close()

        'Calculate Total
        If txt2.Text <> "" Then
            txt3.Text = Val(txt2.Text) * Format(txt.Text, "currency")
            txt3.Text = Format(txt3.Text, "Currency")
        End If

    End Sub

    Public Sub SCustomer(ByVal cbo As ComboBox, ByVal txt As TextBox, ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox, ByVal txt4 As TextBox)
        If cbo.Text = "" Then
            Message("Complete Customer Name to Search.")
            cbo.Focus()
        Else
            Com.CommandText = "Select CusID,Gender,Address,PassportNo,CardNo from tblCustomer where " & _
            "CusName='" & cbo.Text & "'"
            Dr = Com.ExecuteReader
            If Dr.Read = True Then
                txt.Text = Dr(0)
                txt1.Text = Dr(1)
                txt2.Text = Dr(2)
                txt3.Text = Dr(3)
                txt4.Text = Dr(4)

                'Lock Text Box Read Only
                txt2.ReadOnly = True
                txt3.ReadOnly = True
                txt4.ReadOnly = True
                cbo.Focus()
            Else
                Message("Record was Not Found.")
                cbo.Focus()
            End If
            Dr.Close()
        End If
    End Sub

    Public Sub PrepaidLostFocus(ByVal txt As TextBox, ByVal txt1 As TextBox)
        txt.Text = Format(txt.Text, "Currency")
        If txt.Text <> "" Then
            If CInt(txt.Text) > CInt(txt1.Text) Then
                Message("Prepaid bigger than Total.")
                txt.Focus()
                txt.SelectAll()
            End If
        End If
    End Sub

    Public Sub LoadFloor(ByVal cbo As ComboBox, ByVal txt As TextBox)
        Com.CommandText = "Select Floor from QRoom where RoomNo=" & cbo.Text & ""
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            txt.Text = Dr(0)
        End If
        Dr.Close()
    End Sub
End Module
