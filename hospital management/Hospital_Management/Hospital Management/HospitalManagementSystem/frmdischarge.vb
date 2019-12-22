Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmdischarge
    Dim nod As Object 'variant
    Dim tot, tot1, inpchrgs As Integer
    Dim con As SqlConnection
    Dim rd As SqlDataReader
    Dim ad As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim ds As DataSet
    Dim dv As DataView
    Dim counti = 0
    Dim countj = 0
    Private Sub frmdischarge_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'con = New SqlConnection("Data Source=.;Initial Catalog=HospitalManagement;Integrated Security=True")
        'con.Open()
        'connection()
        ' con = New SqlConnection(constr)
        con.Open()
        'Call MFGVALUES()
        Call patientcode_load()
    End Sub
    Public Sub patientcode_load()
        cmd.Connection = con

        cmd.CommandText = "SELECT PCODE FROM INPATIENTS"
        rd = cmd.ExecuteReader
        lstPCODE.Items.Clear()
        While (rd.Read)
            lstPCODE.Items.Add(rd(0))
        End While
        rd.Close()
    End Sub
    'Private Sub MFGVALUES()
    '    dt.Columns.Add("MEDICINE NAME")
    '    dt.Columns.Add("MEDICINE TYPE")
    '    dt.Columns.Add("DATE OF ISSUE")
    '    dt.Columns.Add("QUANTITY")
    '    dt.Columns.Add("RATE PER UNIT")
    '    dt.Columns.Add("AMOUNT")
    '    dt.Columns.Add("DISCOUNT")
    '    dt.Columns.Add("TOTAL AMOUNT")
    '    dt.Columns.Add("EXAM TYPE")
    '    dt.Columns.Add("EXAM DATE")
    '    dt.Columns.Add("EXAM DETAILS")
    '    dt.Columns.Add("TOTAL AMOUNT")
    'End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cmd1 As New SqlCommand
        cmd1.Connection = con
        cmd.CommandText = "select * from DISCHARGE where pcode='" & lstPCODE.Text & "' "
        rd = cmd.ExecuteReader()
        If (rd.HasRows) Then
            MsgBox("This record already exists")
            rd.Close()
        Else
            rd.Close()
            cmd1.CommandText = "insert into DISCHARGE values('" & lstPCODE.Text & "','" & txtPNAME.Text & "','" & txtDOA.Text & "','" & dtpDOD.Value & "','" & txtDOCNAME.Text & "','" & txtROOMTYPE.Text & "','" & txtWARDNAME.Text & "','" & txtBEDNO.Text & "','" & txtROOMRENT.Text & "','" & txtDIAGNOSIS.Text & "','" & txtTOTALAMT.Text & "','" & txtTOTALAMT.Text & "')"
            cmd1.ExecuteNonQuery()
            MessageBox.Show("Record Added Sucessfully")
            Call Clear()

        End If


       
    End Sub

    Private Sub cmdDischarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDischarge.Click
        Dim cmd2 As New SqlCommand
        cmd2.Connection = con
        cmd2.CommandText = "DELETE  FROM INPATIENTS where PCODE='" & lstPCODE.Text & "'"
        cmd2.ExecuteNonQuery()
        Dim cmd3 As New SqlCommand
        cmd3.Connection = con
        cmd3.CommandText = "DELETE  FROM BILL where PCODE='" & lstPCODE.Text & "'"
        cmd3.ExecuteNonQuery()
        Dim cmd4 As New SqlCommand
        cmd4.Connection = con
        cmd4.CommandText = "DELETE FROM BillPayments where PCODE='" & lstPCODE.Text & "'"
        cmd4.ExecuteNonQuery()

        Dim cmd5 As New SqlCommand
        cmd5.Connection = con
        cmd5.CommandText = "DELETE FROM BillDetails where PCODE='" & lstPCODE.Text & "'"
        cmd5.ExecuteNonQuery()
        Dim cmd6 As New SqlCommand
        cmd6.Connection = con
        cmd6.CommandText = "DELETE FROM IPEXAMS where PCODE='" & lstPCODE.Text & "'"
        cmd6.ExecuteNonQuery()
        Dim cmd7 As New SqlCommand
        cmd7.Connection = con
        cmd7.CommandText = "DELETE FROM IPMEDICINE where PCODE='" & lstPCODE.Text & "'"
        cmd7.ExecuteNonQuery()
        Dim cmd8 As New SqlCommand
        cmd8.Connection = con
        cmd8.CommandText = "DELETE FROM IPSURGERY where PCODE='" & lstPCODE.Text & "'"
        cmd8.ExecuteNonQuery()
        Dim cmd9 As New SqlCommand
        cmd9.Connection = con
        cmd9.CommandText = "DELETE FROM CustomerAdvance where PCODE='" & lstPCODE.Text & "'"
        cmd9.ExecuteNonQuery()
        Dim cmd10 As New SqlCommand
        cmd10.Connection = con
        cmd10.CommandText = "DELETE  FROM Room where PCODE='" & lstPCODE.Text & "'"
        cmd10.ExecuteNonQuery()
        Dim cmd11 As New SqlCommand
        cmd11.Connection = con
        cmd11.CommandText = "DELETE  FROM CustomerDue where PCODE='" & lstPCODE.Text & "'"
        cmd11.ExecuteNonQuery()
        Dim cmd12 As New SqlCommand
        cmd12.Connection = con
        cmd12.CommandText = "DELETE FROM CustomerNetValue where PCODE='" & lstPCODE.Text & "'"
        cmd12.ExecuteNonQuery()
        MessageBox.Show("Patient Discharged Sucessfully")
        Call Clear()
        Call patientcode_load()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        frmdischargeReport.Show()
    End Sub

    Private Sub cmdCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalc.Click
        txtTOTALAMT.Text = Val(tot) + Val(tot1) + Val(txtROOMRENT.Text) + Val(inpchrgs)
    End Sub

    Private Sub lstPCODE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPCODE.Click
        tot = 0
        tot1 = 0
        inpchrgs = 0
        Dim cmd13 As New SqlCommand
        cmd13.Connection = con
        cmd13.CommandText = "SELECT * from INPATIENTS where PCODE='" & lstPCODE.Text & "'"
        rd = cmd13.ExecuteReader
        While (rd.Read)
            txtPNAME.Text = rd(2)
            txtDOA.Text = rd(1)
            txtDOCNAME.Text = rd(12)
            txtDIAGNOSIS.Text = rd(17)
            txtWARDNAME.Text = rd(13)
            txtROOMTYPE.Text = rd(14)
            txtBEDNO.Text = rd(15)
            txtROOMRENT.Text = rd(16)
            txtDAYSINHOS.Text = DateDiff("d", Format(DateValue(txtDOA.Text)), Format(dtpDOD.Value))
            inpchrgs = Val(rd(16)) * Val(txtDAYSINHOS.Text)
        End While
        rd.Close()
        ds = New DataSet
        ad = New SqlDataAdapter("SELECT * from IPMEDICINE", con)
        ad.Fill(ds, "IPMEDICINE")
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("MEDICINE NAME")
        dt.Columns.Add("MEDICINE TYPE")
        dt.Columns.Add("DATE OF ISSUE")
        dt.Columns.Add("QUANTITY")
        dt.Columns.Add("RATE PER UNIT")
        dt.Columns.Add("AMOUNT")
        dt.Columns.Add("DISCOUNT")
        dt.Columns.Add("TOTAL AMOUNT")
        Dim cmd14 As New SqlCommand
        cmd14.Connection = con
        cmd14.CommandText = "SELECT * from IPMEDICINE where pcode ='" & lstPCODE.Text & "'"
        rd = cmd14.ExecuteReader
        While (rd.Read)
            dr = dt.NewRow
            dr(0) = rd(2)
            dr(1) = rd(3)
            dr(2) = rd(4)
            dr(3) = rd(5)
            dr(4) = rd(6)
            dr(5) = rd(7)
            dr(6) = rd(8)
            dr(7) = rd(9)
            tot = tot + Val(rd(9))
            dt.Rows.Add(dr)
        End While
        rd.Close()
        MFG.DataSource = dt
        Dim ds1 As New DataSet
        Dim ad1 As New SqlDataAdapter
        ds1 = New DataSet
        ad1 = New SqlDataAdapter("SELECT * from IPMEDICINE", con)
        ad.Fill(ds1, "IPMEDICINE")
        Dim dt1 As New DataTable
        Dim dr1 As DataRow
        dt1.Columns.Add("EXAM TYPE")
        dt1.Columns.Add("EXAM DATE")
        dt1.Columns.Add("EXAM DETAILS")
        dt1.Columns.Add("TOTAL AMOUNT")
        Dim cmd15 As New SqlCommand
        cmd15.Connection = con
        cmd15.CommandText = "SELECT * FROM IPEXAMS WHERE PCODE ='" & lstPCODE.Text & "'"
        rd = cmd15.ExecuteReader
        While (rd.Read)
            dr1 = dt1.NewRow
            dr1(0) = rd(3)
            dr1(1) = rd(4)
            dr1(2) = rd(5)
            dr1(3) = rd(8)
            tot1 = tot1 + Val(rd(8))
            dt1.Rows.Add(dr1)
        End While
        rd.Close()
        MFG1.DataSource = dt1
        Dim cmd16 As New SqlCommand
        cmd16.Connection = con
        cmd16.CommandText = "SELECT * from BILL where PCODE ='" & lstPCODE.Text & "'"
        rd = cmd16.ExecuteReader
        While (rd.Read)
            txtTOTALAMT.Text = rd(5)
        End While
        rd.Close()
    End Sub

    Private Sub frmdischarge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim res As String
        'res = MessageBox.Show("Do You Want To Exit")
        Me.Close()
    End Sub

    Private Sub Clear()
        txtPNAME.Text = ""
        txtDOA.Text = ""
        txtDOCNAME.Text = ""
        txtDIAGNOSIS.Text = ""
        txtWARDNAME.Text = ""
        txtROOMTYPE.Text = ""
        txtBEDNO.Text = ""
        txtROOMRENT.Text = ""
        txtDAYSINHOS.Text = ""
        txtTOTALAMT.Text = ""
        dt.Rows.Clear()
        inpchrgs = 0
    End Sub

    Private Sub txtBEDNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBEDNO.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtROOMRENT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtROOMRENT.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        If countj = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                countj = 1
            End If
        End If
    End Sub

    Private Sub txtDAYSINHOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDAYSINHOS.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtTOTALAMT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTOTALAMT.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                      Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        If counti = 0 Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
                e.Handled = False
                counti = 1
            End If
        End If
    End Sub

    Private Sub txtPNAME_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPNAME.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
                    Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
                    And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
                    Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtDOCNAME_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDOCNAME.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtDIAGNOSIS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDIAGNOSIS.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtWARDNAME_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWARDNAME.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            'Allowed space
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        ' Allowed backspace
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub Enableds()
        txtPNAME.ReadOnly = False
        txtDOA.ReadOnly = False
        txtDOCNAME.ReadOnly = False
        txtDIAGNOSIS.ReadOnly = False
        txtWARDNAME.ReadOnly = False
        txtROOMTYPE.ReadOnly = False
        txtBEDNO.ReadOnly = False
        txtROOMRENT.ReadOnly = False
        txtDAYSINHOS.ReadOnly = False
    End Sub
    Private Sub disableds()
        txtPNAME.ReadOnly = True
        txtDOA.ReadOnly = True
        txtDOCNAME.ReadOnly = True
        txtDIAGNOSIS.ReadOnly = True
        txtWARDNAME.ReadOnly = True
        txtROOMTYPE.ReadOnly = True
        txtBEDNO.ReadOnly = True
        txtROOMRENT.ReadOnly = True
        txtDAYSINHOS.ReadOnly = True
    End Sub

    Private Sub lstPCODE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPCODE.SelectedIndexChanged

    End Sub
End Class