Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmaircraftdata





    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            Dim da As New SqlDataAdapter("select * from Fleet", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Fleet")
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If


        End Try
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cndsave As New SqlCommand("insert into Fleet values('" & txtaircraftname.Text & "','" & txtnoofaircraft.Text & "','" & txteginetype.Text & "','" & txtaircraftlength.Text & "','" & txtcruisespeed.Text & "','" & txtwingspan.Text & "','" & txtfirst.Text & "','" & txtpremier.Text & "','" & txteconomy.Text & "')", cn)
            cn.Open()
            cndsave.ExecuteNonQuery()
            MsgBox("Records saved successfully")
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim cmd As New SqlCommand("Delete from Fleet where Aircraft_name='" & txtaircraftname.Text & "'", cn)
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

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub frmfleet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cn.Open()
        'Dim da As New SqlDataAdapter("select * from Fleet", cn)
        'Dim ds As New DataSet
        'da.Fill(ds, "Fleet")
        'DataGridView1.DataSource = ds.Tables(0)
        Try

            Dim cmd As New SqlCommand("select * from Fleet", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                cboaircraftname.Items.Add(dr(0))
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

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim sd As New SqlCommand("update Fleet set No_Of_Aircraft='" & txtnoofaircraft.Text & "' Engine_type='" & txteginetype.Text & "' Cruise_speed='" & txtcruisespeed.Text & "' & A/C length='" & txtaircraftlength.Text & "' & Wing_span='" & txtwingspan.Text & "' & First_class='" & txtfirst.Text & "' & Premier_class='" & txtpremier.Text & "' & Economy_class='" & txteconomy.Text & "' where Aircraft_name= '" & txtaircraftname.Text & "' )", cn)
            cn.Open()
            MsgBox("Records are succeessfully Updated")
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub cboaircraftname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboaircraftname.SelectedIndexChanged
        Try
            Dim cmd As New SqlCommand("select *  from Fleet where Aircraft_name='" & cboaircraftname.Text & "'", cn)
            cn.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                txtaircraftname.Text = dr.GetString(0)
                cboaircraftname.Text = dr.GetString(0)
                txtnoofaircraft.Text = dr.GetString(1)
                txteginetype.Text = dr.GetString(2)
                txtcruisespeed.Text = dr.GetString(3)
                txtaircraftlength.Text = dr.GetString(4)
                txtwingspan.Text = dr.GetString(5)
                txtfirst.Text = dr.GetString(6)
                txtpremier.Text = dr.GetString(7)
                txteconomy.Text = dr.GetString(8)
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

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtaircraftname.Text = ""
        cboaircraftname.Text = ""
        txtaircraftlength.Text = ""
        txtcruisespeed.Text = ""
        txteconomy.Text = ""
        txteginetype.Text = ""
        txtfirst.Text = ""
        txtnoofaircraft.Text = ""
        txtpremier.Text = ""
        txtwingspan.Text = ""
    End Sub

    Private Sub txtnoofaircraft_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnoofaircraft.KeyPress
        Try
            If funValidate_Number(Asc(e.KeyChar)) = False Then
                e.Handled = True
                MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
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