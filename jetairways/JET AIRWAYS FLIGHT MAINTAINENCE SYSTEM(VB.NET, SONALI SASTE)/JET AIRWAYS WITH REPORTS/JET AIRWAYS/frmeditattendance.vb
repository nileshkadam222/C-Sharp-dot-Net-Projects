Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmeditattendance


    Private Sub frmeditattendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txttype.Text = "PRESENT"
            DateTimePicker1.Value = frmattendance.DateTimePicker1.Value
            txtempid.Text = frmattendance.cboempid.Text
            txttimein.Text = TimeOfDay
            txttimeout.Text = DatePart(DateInterval.Hour, TimeOfDay) + 8 & ":" & DatePart(DateInterval.Minute, TimeOfDay) & ":" & DatePart(DateInterval.Second, TimeOfDay)
            If frmattendance.chkTimeIn.Checked = True And frmattendance.rbtnpresent.Checked = True Then
                txtot.Text = "N/A"
            Else
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                Dim cmdedit As New SqlCommand("select * from Attendance where EmpId='" & txtempid.Text & "'", cn)
                cn.Open()
                Dim dredit As SqlDataReader = cmdedit.ExecuteReader

                While dredit.Read
                    txttimein.Text = dredit(2)
                    txttimeout.Text = dredit(3)
                    DateTimePicker2.Value = dredit.GetDateTime(3)

                    'TextBox1.Text = dredit(3)
                End While
                dredit.Close()
                cn.Close()
                txtot.Text = DateDiff(DateInterval.Hour, TimeOfDay, DateTimePicker2.Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Try
            If frmattendance.chkTimeIn.Checked = True And frmattendance.rbtnpresent.Checked = True Then
                'txtot.Text = "N/A"
                Dim cmdpresent As New SqlCommand("insert into Attendance values('" & txtempid.Text & "','" & DateTimePicker1.Value & "','" & txttimein.Text & "','" & txttimeout.Text & "','" & txtot.Text & "','" & txttype.Text & "')", cn)
                cn.Open()
                cmdpresent.ExecuteNonQuery()
                MsgBox("Attendance marked successfully...!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ATTENDANCE")
                cn.Close()

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()
        Me.Hide()

    End Sub

    
End Class