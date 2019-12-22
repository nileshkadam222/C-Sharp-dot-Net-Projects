Imports System.Data.OleDb
Public Class fViewRoom
    Dim Sin As String
    Private Sub fViewRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OpenConnect()
        ' All Room
        Dim k As Byte
        Com.CommandText = "Select Count(ID) from QRoom"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            TRoom.Nodes.Add("All Rooms" & Space(50) & Dr(0))
        End If
        Dr.Close()
        TRoom.Nodes(0).ForeColor = Color.Red
        TRoom.Nodes(0).Nodes.Add("Single Rooms" & Space(40) & ViewRoom("'Single Room'", "QRoom"))
        NumRoom("'Single Room'", 0, 0, "QRoom")
        TRoom.Nodes(0).Nodes.Add("Double Rooms" & Space(39) & ViewRoom("'Double Room'", "QRoom"))
        NumRoom("'Double Room'", 0, 1, "QRoom")
        TRoom.Nodes(0).Nodes.Add("Suit Rooms" & Space(44) & ViewRoom("'Suit Room'", "QRoom"))
        NumRoom("'Suit Room'", 0, 2, "QRoom")
        TRoom.Nodes(0).Nodes.Add("Delux Rooms" & Space(41) & ViewRoom("'Delux Room'", "QRoom"))
        NumRoom("'Delux Room'", 0, 3, "QRoom")
        For k = 0 To 3
            TRoom.Nodes(0).Nodes(k).ForeColor = Color.SaddleBrown
        Next

        'Put Line
        TRoom.Nodes.Add("=================================================")
        TRoom.Nodes(1).ForeColor = Color.YellowGreen

        ' Free Room
        Com.CommandText = "Select Count(ID) from QFree"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            TRoom.Nodes.Add("Available Rooms" & Space(40) & Dr(0))
        End If
        Dr.Close()
        TRoom.Nodes(2).ForeColor = Color.Red
        TRoom.Nodes(2).Nodes.Add("Single Rooms" & Space(40) & ViewRoom("'Single Room'", "QFree"))
        NumRoom("'Single Room'", 2, 0, "QFree")
        TRoom.Nodes(2).Nodes.Add("Double Rooms" & Space(39) & ViewRoom("'Double Room'", "QFree"))
        NumRoom("'Double Room'", 2, 1, "QFree")
        TRoom.Nodes(2).Nodes.Add("Suit Rooms" & Space(44) & ViewRoom("'Suit Room'", "QFree"))
        NumRoom("'Suit Room'", 2, 2, "QFree")
        TRoom.Nodes(2).Nodes.Add("Delux Rooms" & Space(41) & ViewRoom("'Delux Room'", "QFree"))
        NumRoom("'Delux Room'", 2, 3, "QFree")
        For k = 0 To 3
            TRoom.Nodes(2).Nodes(k).ForeColor = Color.SaddleBrown
        Next

        'Put Line
        TRoom.Nodes.Add("=================================================")
        TRoom.Nodes(3).ForeColor = Color.YellowGreen

        'Unavailable Room
        TRoom.Nodes.Add("Unavailable Rooms")
        TRoom.Nodes(4).ForeColor = Color.Red
        ' Check In Room
        TRoom.Nodes(4).Nodes.Add("Check In")
        TRoom.Nodes(4).Nodes(0).Nodes.Add("Single Rooms")
        NumRoomCheck("'Single Room'", 4, 0, 0, "QCheckIn")
        TRoom.Nodes(4).Nodes(0).Nodes.Add("Double Rooms")
        NumRoomCheck("'Double Room'", 4, 0, 1, "QCheckIn")
        TRoom.Nodes(4).Nodes(0).Nodes.Add("Suit Rooms")
        NumRoomCheck("'Suit Room'", 4, 0, 2, "QCheckIn")
        TRoom.Nodes(4).Nodes(0).Nodes.Add("Double Rooms")
        NumRoomCheck("'Delux Room'", 4, 0, 3, "QCheckIn")
        For k = 0 To 3
            TRoom.Nodes(4).Nodes(0).Nodes(k).ForeColor = Color.Fuchsia
        Next

        'Booking Room
        TRoom.Nodes(4).Nodes.Add("Booking")
        TRoom.Nodes(4).Nodes(1).Nodes.Add("Single Rooms")
        NumRoomCheck("'Single Room'", 4, 1, 0, "QBooking")
        TRoom.Nodes(4).Nodes(1).Nodes.Add("Double Rooms")
        NumRoomCheck("'Double Room'", 4, 1, 1, "QBooking")
        TRoom.Nodes(4).Nodes(1).Nodes.Add("Suit Rooms")
        NumRoomCheck("'Suit Room'", 4, 1, 2, "QBooking")
        TRoom.Nodes(4).Nodes(1).Nodes.Add("Double Rooms")
        NumRoomCheck("'Delux Room'", 4, 1, 3, "QBooking")
        For k = 0 To 1
            TRoom.Nodes(4).Nodes(k).ForeColor = Color.SaddleBrown
        Next
        For k = 0 To 3
            TRoom.Nodes(4).Nodes(1).Nodes(k).ForeColor = Color.Fuchsia
        Next
    End Sub

    Function ViewRoom(ByVal Cond As String, ByVal TableName As String) As String
        Dim S As String = ""
        Dim S1 As String = ""
        Com.CommandText = "Select Count(RoomType),UnitPrice from " & TableName & " where RoomType=" & Cond & " Group by UnitPrice"
        Dr = Com.ExecuteReader
        If Dr.Read = True Then
            S = Dr(0)
            S1 = Dr(1)
        End If
        Dr.Close()
        ViewRoom = S & Space(20) & Format(S1, "currency")
    End Function

    Function NumRoom(ByVal cond As String, ByVal X As Byte, ByVal X1 As Byte, ByVal TableName As String) As String
        Dim S As String = ""
        Com.CommandText = "Select RoomNo from " & TableName & " where RoomType=" & cond
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            TRoom.Nodes(X).Nodes(X1).Nodes.Add(Dr(0))
        Loop
        Dr.Close()
        NumRoom = S
    End Function

    Function NumRoomCheck(ByVal cond As String, ByVal X As Byte, ByVal X1 As Byte, ByVal X2 As Byte, ByVal TableName As String) As String
        Dim S As String = ""
        Com.CommandText = "Select RoomNo from " & TableName & " where RoomType=" & cond
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            'TRoom.Nodes(X).Nodes(X1).Nodes.Add(Dr(0))
            TRoom.Nodes(X).Nodes(X1).Nodes(X2).Nodes.Add(Dr(0))
        Loop
        Dr.Close()
        NumRoomCheck = S
    End Function


    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        TRoom.ExpandAll()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        TRoom.CollapseAll()
    End Sub
End Class