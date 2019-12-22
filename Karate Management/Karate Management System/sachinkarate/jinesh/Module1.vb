Module validmodule
    Public Function chkChar(ByVal a As Integer) As Integer
        If a >= 97 And a <= 123 Or a >= 65 And a <= 90 Or a = 32 Or a = 8 Then
            Return a
        Else
            Return 0
        End If
    End Function

    Public Function chkInt(ByVal a As Integer) As Integer
        If a >= 48 And a <= 57 Or a = 8 Then
            Return a
        Else
            Return 0
        End If
    End Function


End Module
