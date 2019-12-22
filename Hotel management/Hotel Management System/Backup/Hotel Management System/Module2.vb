Module Module2
    Public CuID, CName, CGender, CAddress, CPNo, CCNo As String
    Public UserID As Int32 'Get ID from tblUser

    Public BID As Int32
    Public i As Int16
    Public M As Byte

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
End Module
