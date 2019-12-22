Module Validation

#Region "Function"



    Public Function funValidate_Email(ByVal mEmialID As String, Optional ByVal mFormName As String = "") As Boolean
        Dim m_Position As Integer

        Try
            m_Position = 0
            m_Position = InStr(mEmialID, "@")

            If m_Position <> 0 Then
                funValidate_Email = True
            Else
                MessageBox.Show("Please enter '@' sign at proper position." & vbCrLf & vbCrLf & "ex - abc@xyz.net", "Error In EmailID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                funValidate_Email = False
                Exit Function
            End If

            m_Position = 0
            m_Position = InStr(mEmialID, ".")

            If m_Position <> 0 Then
                funValidate_Email = True
            Else
                MessageBox.Show("Please enter '.' sign at proper position." & vbCrLf & vbCrLf & "ex - abc@xyz.net", "Error In EmailID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                funValidate_Email = False
                Exit Function
            End If

            m_Position = 0
            m_Position = InStr(mEmialID, " ")

            If m_Position = 0 Then
                funValidate_Email = True
            Else
                MessageBox.Show("Spaces are not allowed.Please enter valid email id." & vbCrLf & vbCrLf & "ex - abc@xyz.net", "Error In EmailID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                funValidate_Email = False
                Exit Function
            End If

        Catch ex As Exception
            MessageBox.Show("ModValidation    " & "funValidate_Email   " & vbCrLf & ex.Message)

        End Try
    End Function

#End Region

    Public Function funValidate_Text(ByVal mKeyAscii As Integer) As Boolean
        If (mKeyAscii < 65 Or mKeyAscii > 91) And _
           (mKeyAscii < 97 Or mKeyAscii > 122) And _
           (mKeyAscii <> 8 And mKeyAscii <> 32) Then

            funValidate_Text = False
        Else
            funValidate_Text = True
        End If
    End Function

    Public Sub funTabEnter(ByVal mKeyAscii As Integer, ByVal txt1 As TextBox, ByVal txt2 As TextBox)
        If (mKeyAscii = 13) Then
            txt2.Focus()
        Else
            txt1.Focus()

        End If

    End Sub


    Public Function funValidate_TextNumber(ByVal mKeyAscii As Integer) As Boolean
        If (mKeyAscii < 65 Or mKeyAscii > 90) And _
           (mKeyAscii < 97 Or mKeyAscii > 122) And _
           (mKeyAscii < 48 Or mKeyAscii > 57) And _
           (mKeyAscii <> 8 And mKeyAscii <> 32 And mKeyAscii <> 46) Then

            funValidate_TextNumber = False
        Else
            funValidate_TextNumber = True
        End If
    End Function


    Public Function funValidate_Number(ByVal mKeyAscii As Integer) As Boolean
        If (mKeyAscii < 48 Or mKeyAscii > 57) And (mKeyAscii <> 8) And (mKeyAscii <> 46) Then

            funValidate_Number = False
        Else
            funValidate_Number = True
        End If
    End Function


    Public Function funValidate_TelNumber(ByVal mKeyAscii As Integer) As Boolean
        If (mKeyAscii < 48 Or mKeyAscii > 57) And _
           (mKeyAscii <> 40) And (mKeyAscii <> 41) And (mKeyAscii <> 43) And _
           (mKeyAscii <> 8 And mKeyAscii <> 32 And mKeyAscii <> 445) Then

            funValidate_TelNumber = False
        Else
            funValidate_TelNumber = True
        End If
    End Function




End Module
