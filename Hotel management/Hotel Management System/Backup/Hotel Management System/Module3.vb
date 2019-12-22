Imports System.Data.OleDb
Module Module3
    Dim Da As New OleDbDataAdapter
    Dim Dt, Dt1, Dt2 As New DataTable
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
