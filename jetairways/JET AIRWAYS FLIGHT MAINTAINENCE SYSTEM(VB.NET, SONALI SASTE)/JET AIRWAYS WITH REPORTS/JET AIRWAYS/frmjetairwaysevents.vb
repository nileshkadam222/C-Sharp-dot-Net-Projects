Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmjetairwaysevents

    
    

    'Private Sub frmjetairwaysevents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim da As New SqlDataAdapter("select * from Event", cn)
    '    Dim ds As New DataSet
    '    da.Fill(ds, "Event")
    '    DataGridVie1.DatwaSource = ds.Tables("Event")
    'End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        txteventname.Text = ""
        txteventdate.Text = ""
        txtplace.Text = ""
        txttimeofevent.Text = ""
        txtnoofevent.Text = ""
        txtorganisedby.Text = ""
        txtdescrition.Text = ""

    End Sub

    
    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            Dim da As New SqlDataAdapter("select * from Event", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Event")
            DataGridView1.DataSource = ds.Tables("Event")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim cmd As New SqlCommand("insert into Event values ('" & txteventname.Text & "','" & txteventdate.Text & "','" & txtplace.Text & "','" & txttimeofevent.Text & "','" & txtnoofevent.Text & "','" & txtorganisedby.Text & "','" & txtdescrition.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox(" Record Saved Successfully", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "saves")
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

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim cnd As New SqlCommand("update Event set Event_name='" & txteventname.Text & "',Date='" & txteventdate.Text & "',Place='" & txtplace.Text & "' , Time='" & txttimeofevent.Text & "',Day='" & txtnoofevent.Text & "', Org='" & txtorganisedby.Text & "', Description='" & txtdescrition.Text & "' where Event_name='" & txteventname.Text & "' )", cn)
            cn.Open()
            cnd.ExecuteNonQuery()

            MsgBox(" Record Updated Successfully", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Update")
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
            Dim cmd As New SqlCommand("delete from Event where Event_name='" & txteventname.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()

            MsgBox(" Record Deleted Successfully", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Delete")
            cn.Close()
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

    Private Sub txteventname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txteventname.KeyPress
        If funValidate_Text(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Text....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub txtnoofevent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnoofevent.KeyPress
        If funValidate_Number(Asc(e.KeyChar)) = False Then
            e.Handled = True
            MsgBox("Please Enter Only Numbers....!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

End Class