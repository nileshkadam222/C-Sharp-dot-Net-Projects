Public Class Form2
    Dim Li As ListViewItem
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkCustID.Checked = True
        SetTextBoxEnabled(True, False, False, False)
        txtCustID.Focus()
        'OpenConnect()
    End Sub

    Sub SetTextBoxEnabled(ByVal CID As Boolean, ByVal CName As Boolean, ByVal CCount As Boolean, ByVal CPass As Boolean)
        txtCustID.Enabled = CID
        txtCustName.Enabled = CName
        txtCountry.Enabled = CCount
        txtPassNo.Enabled = CPass
    End Sub

    Private Sub ChkCustID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCustID.CheckedChanged
        If ChkCustID.Checked = True Then
            txtCustID.Enabled = True
            txtCustID.Focus()
        Else
            txtCustID.Clear()
            txtCustID.Enabled = False
        End If
    End Sub

    Private Sub ChkCustName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCustName.CheckedChanged
        If ChkCustName.Checked = True Then
            txtCustName.Enabled = True
            txtCustName.Focus()
        Else
            txtCustName.Clear()
            txtCustName.Enabled = False
        End If
    End Sub

    Private Sub ChkCountry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCountry.CheckedChanged
        If ChkCountry.Checked = True Then
            txtCountry.Enabled = True
            txtCountry.Focus()
        Else
            txtCountry.Clear()
            txtCountry.Enabled = False
        End If
    End Sub

    Private Sub ChkPassNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPassNo.CheckedChanged
        If ChkPassNo.Checked = True Then
            txtPassNo.Enabled = True
            txtPassNo.Focus()
        Else
            txtPassNo.Clear()
            txtPassNo.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LstCustomer.Items.Clear()
        If ChkCustID.Checked = True And ChkCustName.Checked = True And ChkCountry.Checked = True And ChkPassNo.Checked = True Then
        ElseIf ChkCountry.Checked = True And ChkPassNo.Checked = True And ChkCustID.Checked = True Then
            SQLSearch("CusID='" & txtCustID.Text & "' And CusName='" & txtCustName.Text & "' And Country='" & txtCountry.Text & "' and PassportNo='" & txtPassNo.Text & "'")
        ElseIf ChkCustName.Checked = True And ChkCountry.Checked = True And ChkPassNo.Checked = True Then
            SQLSearch("CusName='" & txtCustName.Text & "' And Country='" & txtCountry.Text & "' and PassportNo='" & txtPassNo.Text & "'")
        ElseIf ChkCustID.Checked = True And ChkCustName.Checked = True And ChkPassNo.Checked = True Then
            SQLSearch("CusID='" & txtCustID.Text & "' and CusName='" & txtCustName.Text & "' And PassportNo='" & txtPassNo.Text & "'")
        ElseIf ChkCustID.Checked = True And ChkCustName.Checked = True And ChkCountry.Checked = True Then
            SQLSearch("CusID='" & txtCustID.Text & "' and CusName='" & txtCustName.Text & "' And Country='" & txtCountry.Text & "'")
        ElseIf ChkCountry.Checked = True And ChkPassNo.Checked = True Then
            SQLSearch("Country='" & txtCountry.Text & "' and PassportNo='" & txtPassNo.Text & "'")
        ElseIf ChkCustName.Checked = True And ChkPassNo.Checked = True Then
            SQLSearch("CusName='" & txtCustName.Text & "'and PassportNo='" & txtPassNo.Text & "'")
        ElseIf ChkCustName.Checked = True And ChkCountry.Checked = True Then
            SQLSearch("CusName='" & txtCustName.Text & "' and Country='" & txtCountry.Text & "'")
        ElseIf ChkCustID.Checked = True And ChkPassNo.Checked = True Then
            SQLSearch("CusID='" & txtCustID.Text & "' And PassportNo='" & txtPassNo.Text & "'")
        ElseIf ChkCustID.Checked = True And ChkCountry.Checked = True Then
            SQLSearch("CusID='" & txtCustID.Text & "' And Country='" & txtCountry.Text & "'")
        ElseIf ChkCustID.Checked = True And ChkCustName.Checked = True Then
            SQLSearch("CusID='" & txtCustID.Text & "' And CusName='" & txtCustName.Text & "'")
        ElseIf ChkPassNo.Checked = True Then
            SQLSearch("PassportNo='" & txtPassNo.Text & "'")
        ElseIf ChkCountry.Checked = True Then
            SQLSearch("Country='" & txtCountry.Text & "'")
        ElseIf ChkCustName.Checked = True Then
            SQLSearch("CusName='" & txtCustName.Text & "'")
        ElseIf ChkCustID.Checked = True Then
            SQLSearch("CusID='" & txtCustID.Text & "'")
        End If
    End Sub

    Sub SQLSearch(ByVal Str As String)
        Dim L As Boolean = False
        Com.CommandText = "Select * from tblCustomer where " & Str
        Dr = Com.ExecuteReader
        Do While Dr.Read = True
            AddDataToLvw(LstCustomer, Dr(0), Dr(1), Dr(2), Dr(3), Dr(4), Dr(5), Dr(6), Dr(7), Dr(8), Dr(9), Dr(10))
            L = True
        Loop
        If L = False Then
            Message("Record Was Not Found.")
        End If
        Dr.Close()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim Sl As ListView.SelectedListViewItemCollection = LstCustomer.SelectedItems
        For Each Li In Sl
            Exit For
        Next
        CusSearch = "Select * from TblCustomer where CusID='" & Li.Text & "'"
        Me.Close()
        ShowForm(Form1, Main)
    End Sub

End Class