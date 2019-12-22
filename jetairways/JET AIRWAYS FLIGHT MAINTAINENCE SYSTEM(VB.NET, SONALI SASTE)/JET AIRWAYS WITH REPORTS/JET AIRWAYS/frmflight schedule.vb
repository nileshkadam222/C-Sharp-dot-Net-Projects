Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmflightshedule


    Private Sub frmflightshedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.Open()
            Dim cmdview As New SqlCommand("select * from Flightschedule", cn)

            Dim drview As SqlDataReader = cmdview.ExecuteReader
            While drview.Read
                cboflightnumber.Items.Add(drview.GetString(0))
            End While
            drview.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cndsave As New SqlCommand("insert into Flightschedule values('" & cboflightnumber.Text & "','" & DateTimePicker2.Value & "','" & cboregno.Text & "','" & cbobayno.Text & "','" & txtleg.Text & "','" & cboaircrafttype.Text & "','" & cboflighttype.Text & "','" & cbodi.Text & "','" & cbofrom1.Text & "','" & GroupBox2.Text & "','" & txtstd1.Text & "','" & txtstd2.Text & "','" & txtsta1.Text & "','" & txtsta2.Text & "','" & txtcaptainname.Text & "','" & txtfirstofficername.Text & "','" & txtairhostessname.Text & "','" & cbodeptarr.Text & "')", cn)
            cn.Open()
            cndsave.ExecuteNonQuery()
            MsgBox("Record saved successfully")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

   

    Private Sub cboflightnumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboflightnumber.SelectedIndexChanged
        Try
            Dim cmd As New SqlCommand("select * from Flightschedule where Flight_no='" & cboflightnumber.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                DateTimePicker2.Text = dr.GetString(1)
                cboregno.Text = dr.GetString(2)
                cbobayno.Text = dr.GetString(3)
                txtleg.Text = dr.GetString(4)
                cboaircrafttype.Text = dr.GetString(5)
                cboflighttype.Text = dr.GetString(6)
                cbodi.Text = dr.GetString(7)
                cbofrom1.Text = dr.GetString(8)
                cboto1.Text = dr.GetString(9)
                txtstd1.Text = dr.GetString(10)
                txtstd2.Text = dr.GetString(11)
                txtsta1.Text = dr.GetString(12)
                txtsta2.Text = dr.GetString(13)
                txtcaptainname.Text = dr.GetString(14)
                txtfirstofficername.Text = dr.GetString(15)
                txtairhostessname.Text = dr.GetString(16)
                cbodeptarr.Text = dr.GetString(17)

            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cboflightnumber.Text = ""
        DateTimePicker1.Value = "3/12/2011"
        cboregno.Items.Clear()
        cbobayno.Items.Clear()
        txtleg.Text = ""
        cboaircrafttype.Text = ""
        cboflighttype.Text = ""
        cbodi.Text = ""
        cbofrom1.Text = ""
        cboto1.Text = ""
        txtstd1.Text = ""
        txtstd2.Text = ""
        txtsta1.Text = ""
        txtsta2.Text = ""
        txtcaptainname.Text = ""
        txtfirstofficername.Text = ""
        txtairhostessname.Text = ""
        cbodeptarr.Text = ""

    End Sub



    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim md As New SqlCommand("update Flightschedule set Flight_date='" & DateTimePicker2.Value & "',Reg_no='" & cboregno.Text & "',Bay_no='" & cbobayno.Text & "',Leg_no='" & txtleg.Text & "',Aircraft_type='" & cboaircrafttype.Text & "', Flight_type='" & cboflighttype.Text & "', DI='" & cbodi.Text & "',From1='" & cbofrom1.Text & "',To1='" & cboto1.Text & "',STD_IST='" & txtstd1.Text & "',STD_UTC='" & txtstd2.Text & "',STA_IST='" & txtsta1.Text & "',STA_UTC='" & txtsta2.Text & "',Captain_name='" & txtcaptainname.Text & "',First_off_name='" & txtfirstofficername.Text & "',Airhostess_name='" & txtairhostessname.Text & "',Dep_Arr='" & cbodeptarr.Text & "' where Flight_no='" & cboflightnumber.Text & "'", cn)
            cn.Open()
            md.ExecuteNonQuery()
            MsgBox("Record updated successfully")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Flightschedule where Flight_no = '" & cboflightnumber.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record deleted successfully")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        frmsearchflightentry.Show()
        Me.Hide()
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()
        Me.Hide()

    End Sub

    Private Sub txtstd1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstd1.TextChanged
        Try
            Dim hour, minute As Integer
            Dim cmd As New SqlCommand("select * from Flightschedule", cn)
            If txtstd1.Text = "" Then
                txtstd2.Text = ""
            Else
                hour = Val(Mid(txtstd1.Text, 1, 2))
                minute = Val(Mid(txtstd1.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60
                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour
                End If
                txtstd2.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtsta1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsta1.TextChanged
        Try
            Dim hour, minute As Integer
            Dim cmd As New SqlCommand("select * from Flightschedule", cn)
            If txtsta1.Text = "" Then
                txtsta2.Text = ""
            Else
                hour = Val(Mid(txtsta1.Text, 1, 2))
                minute = Val(Mid(txtsta1.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60
                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour
                End If
                txtsta2.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            Dim cmd As New SqlCommand("select * from Flightschedule where Flight_no='" & cboflightnumber.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                DateTimePicker2.Text = dr.GetString(1)
                cboregno.Text = dr.GetString(2)
                cbobayno.Text = dr.GetString(3)
                txtleg.Text = dr.GetString(4)
                cboaircrafttype.Text = dr.GetString(5)
                cboflighttype.Text = dr.GetString(6)
                cbodi.Text = dr.GetString(7)
                cbofrom1.Text = dr.GetString(8)
                cboto1.Text = dr.GetString(9)
                txtstd1.Text = dr.GetString(10)
                txtstd2.Text = dr.GetString(11)
                txtsta1.Text = dr.GetString(12)
                txtsta2.Text = dr.GetString(13)
                txtcaptainname.Text = dr.GetString(14)
                txtfirstofficername.Text = dr.GetString(15)
                txtairhostessname.Text = dr.GetString(16)
                cbodeptarr.Text = dr.GetString(17)

            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub cboregno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboregno.KeyPress
        Try
            If funValidate_Text(Asc(e.KeyChar)) = False Then
                e.Handled = True
                MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtcaptainname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcaptainname.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtfirstofficername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirstofficername.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtairhostessname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtairhostessname.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtleg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtleg.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    
End Class