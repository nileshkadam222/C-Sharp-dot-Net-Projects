Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class frmdispatchbriefing


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        cboflightno.Text = ""
        cboflightdate.Text = ""
        txtregno.Text = ""
        txtbayno.Text = ""
        txtaircrafttype.Text = ""
        txtengintype.Text = ""
        cbofrom1.Text = ""
        cboto1.Text = ""
        txtstd1.Text = ""
        txtstd11.Text = ""
        txtsta1.Text = ""
        txtsta11.Text = ""
        cbofrom2.Text = ""
        cboto2.Text = ""
        txtstd2.Text = ""
        txtstd22.Text = ""
        txtsta2.Text = ""
        txtsta22.Text = ""
        cbofrom3.Text = ""
        cboto3.Text = ""
        txtstd3.Text = ""
        txtstd33.Text = ""
        txtsta3.Text = ""
        txtsta33.Text = ""
        txtrecomendedfuel.Text = ""
        txtextra.Text = ""
        txtnameofcaptain.Text = ""
        txtfirstofficername.Text = ""
        txtadditionalcrew.Text = ""
        txtairhostessname.Text = ""
        txtalternatedestination.Text = ""
        txtmanagerno.Text = ""

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into DBrief values ('" & cboflightno.Text & "','" & cboflightdate.Text & "','" & txtregno.Text & "','" & txtbayno.Text & "','" & txtaircrafttype.Text & "','" & txtengintype.Text & "','" & cbofrom1.Text & "','" & cboto1.Text & "','" & txtstd1.Text & "','" & txtstd11.Text & "','" & txtsta1.Text & "','" & txtsta11.Text & "','" & cbofrom2.Text & "','" & cboto2.Text & "','" & txtstd2.Text & "','" & txtstd22.Text & "','" & txtsta2.Text & "','" & txtsta22.Text & "','" & cbofrom3.Text & "','" & cboto3.Text & "','" & txtstd3.Text & "','" & txtstd33.Text & "','" & txtstd33.Text & "','" & txtsta3.Text & "','" & txtsta33.Text & "','" & txtrecomendedfuel.Text & "','" & txtextra.Text & "','" & txtnameofcaptain.Text & "','" & txtfirstofficername.Text & "','" & txtadditionalcrew.Text & "','" & txtairhostessname.Text & "','" & txtalternatedestination.Text & "','" & txtmanagerno.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record saved successfully", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "saves")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        flightscedule_report.Show()
        Me.Hide()

    End Sub

    

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        MDIParent1.Show()
        Me.Hide()

    End Sub

    Private Sub txtstd1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstd1.TextChanged
        Try
            Dim hour, minute As Integer
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            If txtstd1.Text = "" Then
                txtstd11.Text = ""
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
                txtstd11.Text = hour & ":" & minute
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
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            If txtsta1.Text = "" Then
                txtsta11.Text = ""
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
                txtsta11.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtstd2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstd2.TextChanged
        Try
            Dim hour, minute As Integer
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            If txtstd2.Text = "" Then
                txtstd22.Text = ""
            Else
                hour = Val(Mid(txtstd2.Text, 1, 2))
                minute = Val(Mid(txtstd2.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60
                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour
                End If
                txtstd22.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub txtsta2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsta2.TextChanged
        Try
            Dim hour, minute As Integer
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            If txtsta2.Text = "" Then
                txtsta22.Text = ""
            Else
                hour = Val(Mid(txtsta2.Text, 1, 2))
                minute = Val(Mid(txtsta2.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60
                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour
                End If
                txtsta22.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtstd3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstd3.TextChanged
        Try
            Dim hour, minute As Integer
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            If txtstd3.Text = "" Then
                txtstd33.Text = ""
            Else
                hour = Val(Mid(txtstd3.Text, 1, 2))
                minute = Val(Mid(txtstd3.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60
                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour
                End If
                txtstd33.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtsta3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsta3.TextChanged
        Try
            Dim hour, minute As Integer
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            If txtsta3.Text = "" Then
                txtsta33.Text = ""
            Else
                hour = Val(Mid(txtsta3.Text, 1, 2))
                minute = Val(Mid(txtsta3.Text, 2, 2))
                minute = minute - 30
                If (minute < 0) Then
                    hour = hour - 1
                    minute = minute + 60
                End If
                hour = hour - 5
                If (hour < 0) Then
                    hour = 24 + hour
                End If
                txtsta33.Text = hour & ":" & minute
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cboflightno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboflightno.SelectedIndexChanged
        Try
            Dim cmd As New SqlCommand("select *  from DBrief where Flight_no='" & cboflightno.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboflightno.Text = dr.GetString(0)

                cboflightdate.Text = dr.GetString(1)
                txtregno.Text = dr.GetString(2)
                txtbayno.Text = dr.GetString(3)
                txtaircrafttype.Text = dr.GetString(4)
                txtengintype.Text = dr.GetString(5)
                cbofrom1.Text = dr.GetString(6)
                cboto1.Text = dr.GetString(7)
                txtstd1.Text = dr.GetString(8)
                txtstd11.Text = dr.GetString(9)
                txtsta1.Text = dr.GetString(10)
                txtsta11.Text = dr.GetString(11)
                cbofrom2.Text = dr.GetString(12)
                cboto2.Text = dr.GetString(13)
                txtstd2.Text = dr.GetString(14)
                txtstd22.Text = dr.GetString(15)
                txtsta2.Text = dr.GetString(16)
                txtsta22.Text = dr.GetString(17)
                cbofrom3.Text = dr.GetString(18)
                cboto3.Text = dr.GetString(19)
                txtstd3.Text = dr.GetString(20)
                txtstd33.Text = dr.GetString(21)
                txtsta3.Text = dr.GetString(22)
                txtsta33.Text = dr.GetString(23)
                txtrecomendedfuel.Text = dr.GetString(24)
                txtextra.Text = dr.GetString(25)
                txtnameofcaptain.Text = dr.GetString(26)
                txtfirstofficername.Text = dr.GetString(27)
                txtadditionalcrew.Text = dr.GetString(28)
                txtairhostessname.Text = dr.GetString(29)
                txtalternatedestination.Text = dr.GetString(30)
                txtmanagerno.Text = dr.GetString(32)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub frmdispatchbriefing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("select * from DBrief", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboflightno.Items.Add(dr.GetString(0))

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtregno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtregno.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtnameofcaptain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnameofcaptain.KeyPress
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

    Private Sub txtadditionalcrew_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadditionalcrew.KeyPress
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

    Private Sub txtalternatedestination_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalternatedestination.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

End Class