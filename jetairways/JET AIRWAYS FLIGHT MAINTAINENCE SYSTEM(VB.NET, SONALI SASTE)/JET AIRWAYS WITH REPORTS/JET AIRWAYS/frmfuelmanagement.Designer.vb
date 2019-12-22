<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfuelmanagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbodate = New System.Windows.Forms.ComboBox
        Me.cboflightno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtarrtimeUTC = New System.Windows.Forms.TextBox
        Me.txtdeptimeUTC = New System.Windows.Forms.TextBox
        Me.txtburnoff = New System.Windows.Forms.TextBox
        Me.txtdepfuel = New System.Windows.Forms.TextBox
        Me.txtarrtimeIST = New System.Windows.Forms.TextBox
        Me.txtdeptimeIST = New System.Windows.Forms.TextBox
        Me.txtflightno = New System.Windows.Forms.TextBox
        Me.cboto1 = New System.Windows.Forms.ComboBox
        Me.cbofrom1 = New System.Windows.Forms.ComboBox
        Me.cbooilcompany = New System.Windows.Forms.ComboBox
        Me.cbobayno = New System.Windows.Forms.ComboBox
        Me.cboregno = New System.Windows.Forms.ComboBox
        Me.cboflightdate = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnback = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.btndetails = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbodate)
        Me.GroupBox1.Controls.Add(Me.cboflightno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search "
        '
        'cbodate
        '
        Me.cbodate.FormattingEnabled = True
        Me.cbodate.Location = New System.Drawing.Point(117, 40)
        Me.cbodate.Name = "cbodate"
        Me.cbodate.Size = New System.Drawing.Size(112, 21)
        Me.cbodate.TabIndex = 4
        '
        'cboflightno
        '
        Me.cboflightno.FormattingEnabled = True
        Me.cboflightno.Location = New System.Drawing.Point(456, 40)
        Me.cboflightno.Name = "cboflightno"
        Me.cboflightno.Size = New System.Drawing.Size(121, 21)
        Me.cboflightno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Flight No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtarrtimeUTC)
        Me.GroupBox2.Controls.Add(Me.txtdeptimeUTC)
        Me.GroupBox2.Controls.Add(Me.txtburnoff)
        Me.GroupBox2.Controls.Add(Me.txtdepfuel)
        Me.GroupBox2.Controls.Add(Me.txtarrtimeIST)
        Me.GroupBox2.Controls.Add(Me.txtdeptimeIST)
        Me.GroupBox2.Controls.Add(Me.txtflightno)
        Me.GroupBox2.Controls.Add(Me.cboto1)
        Me.GroupBox2.Controls.Add(Me.cbofrom1)
        Me.GroupBox2.Controls.Add(Me.cbooilcompany)
        Me.GroupBox2.Controls.Add(Me.cbobayno)
        Me.GroupBox2.Controls.Add(Me.cboregno)
        Me.GroupBox2.Controls.Add(Me.cboflightdate)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 257)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fuel Data"
        '
        'txtarrtimeUTC
        '
        Me.txtarrtimeUTC.Location = New System.Drawing.Point(456, 133)
        Me.txtarrtimeUTC.Name = "txtarrtimeUTC"
        Me.txtarrtimeUTC.Size = New System.Drawing.Size(121, 20)
        Me.txtarrtimeUTC.TabIndex = 22
        '
        'txtdeptimeUTC
        '
        Me.txtdeptimeUTC.Location = New System.Drawing.Point(456, 90)
        Me.txtdeptimeUTC.Name = "txtdeptimeUTC"
        Me.txtdeptimeUTC.Size = New System.Drawing.Size(121, 20)
        Me.txtdeptimeUTC.TabIndex = 21
        '
        'txtburnoff
        '
        Me.txtburnoff.Location = New System.Drawing.Point(324, 212)
        Me.txtburnoff.Name = "txtburnoff"
        Me.txtburnoff.Size = New System.Drawing.Size(253, 20)
        Me.txtburnoff.TabIndex = 20
        '
        'txtdepfuel
        '
        Me.txtdepfuel.Location = New System.Drawing.Point(324, 168)
        Me.txtdepfuel.Name = "txtdepfuel"
        Me.txtdepfuel.Size = New System.Drawing.Size(253, 20)
        Me.txtdepfuel.TabIndex = 19
        '
        'txtarrtimeIST
        '
        Me.txtarrtimeIST.Location = New System.Drawing.Point(324, 133)
        Me.txtarrtimeIST.Name = "txtarrtimeIST"
        Me.txtarrtimeIST.Size = New System.Drawing.Size(121, 20)
        Me.txtarrtimeIST.TabIndex = 18
        '
        'txtdeptimeIST
        '
        Me.txtdeptimeIST.Location = New System.Drawing.Point(324, 90)
        Me.txtdeptimeIST.Name = "txtdeptimeIST"
        Me.txtdeptimeIST.Size = New System.Drawing.Size(121, 20)
        Me.txtdeptimeIST.TabIndex = 17
        '
        'txtflightno
        '
        Me.txtflightno.Location = New System.Drawing.Point(99, 83)
        Me.txtflightno.Name = "txtflightno"
        Me.txtflightno.Size = New System.Drawing.Size(121, 20)
        Me.txtflightno.TabIndex = 16
        '
        'cboto1
        '
        Me.cboto1.FormattingEnabled = True
        Me.cboto1.Items.AddRange(New Object() {"AGR", "USA", "PUNE", "AUS", "BLR", "DEL", "IDR"})
        Me.cboto1.Location = New System.Drawing.Point(456, 39)
        Me.cboto1.Name = "cboto1"
        Me.cboto1.Size = New System.Drawing.Size(121, 21)
        Me.cboto1.TabIndex = 15
        '
        'cbofrom1
        '
        Me.cbofrom1.FormattingEnabled = True
        Me.cbofrom1.Items.AddRange(New Object() {"BOM", "BOM", "BOM", "BOM"})
        Me.cbofrom1.Location = New System.Drawing.Point(324, 39)
        Me.cbofrom1.Name = "cbofrom1"
        Me.cbofrom1.Size = New System.Drawing.Size(121, 21)
        Me.cbofrom1.TabIndex = 14
        '
        'cbooilcompany
        '
        Me.cbooilcompany.FormattingEnabled = True
        Me.cbooilcompany.Items.AddRange(New Object() {"HP", "Castrol"})
        Me.cbooilcompany.Location = New System.Drawing.Point(99, 212)
        Me.cbooilcompany.Name = "cbooilcompany"
        Me.cbooilcompany.Size = New System.Drawing.Size(121, 21)
        Me.cbooilcompany.TabIndex = 13
        '
        'cbobayno
        '
        Me.cbobayno.FormattingEnabled = True
        Me.cbobayno.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbobayno.Location = New System.Drawing.Point(99, 163)
        Me.cbobayno.Name = "cbobayno"
        Me.cbobayno.Size = New System.Drawing.Size(121, 21)
        Me.cbobayno.TabIndex = 12
        '
        'cboregno
        '
        Me.cboregno.FormattingEnabled = True
        Me.cboregno.Items.AddRange(New Object() {"JBC", "JGT", "JEG", "SIJ"})
        Me.cboregno.Location = New System.Drawing.Point(99, 125)
        Me.cboregno.Name = "cboregno"
        Me.cboregno.Size = New System.Drawing.Size(121, 21)
        Me.cboregno.TabIndex = 11
        '
        'cboflightdate
        '
        Me.cboflightdate.FormattingEnabled = True
        Me.cboflightdate.Location = New System.Drawing.Point(99, 42)
        Me.cboflightdate.Name = "cboflightdate"
        Me.cboflightdate.Size = New System.Drawing.Size(121, 21)
        Me.cboflightdate.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(264, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Burn Off :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(252, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Dep Fuel :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "STA :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(264, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "STD :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Sector :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Oil Company :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Bay No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Reg No :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Flight No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Flight Date :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnexit)
        Me.GroupBox3.Controls.Add(Me.btnprint)
        Me.GroupBox3.Controls.Add(Me.btnback)
        Me.GroupBox3.Controls.Add(Me.btnsearch)
        Me.GroupBox3.Controls.Add(Me.btndetails)
        Me.GroupBox3.Controls.Add(Me.btndelete)
        Me.GroupBox3.Controls.Add(Me.btnreset)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 452)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(747, 81)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(482, 20)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(76, 39)
        Me.btnprint.TabIndex = 7
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(576, 20)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 41)
        Me.btnback.TabIndex = 6
        Me.btnback.Text = "&Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(666, 20)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 41)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(390, 19)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 41)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "&Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btndetails
        '
        Me.btndetails.Location = New System.Drawing.Point(297, 19)
        Me.btndetails.Name = "btndetails"
        Me.btndetails.Size = New System.Drawing.Size(75, 41)
        Me.btndetails.TabIndex = 3
        Me.btndetails.Text = "&Details"
        Me.btndetails.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(206, 19)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 41)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(117, 19)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 41)
        Me.btnreset.TabIndex = 1
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(17, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 41)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JET_AIRWAYS.My.Resources.Resources.Jet_Airways_Banner_1_1
        Me.PictureBox1.Location = New System.Drawing.Point(-19, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(824, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmfuelmanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 578)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmfuelmanagement"
        Me.Text = "Fuelmanagement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboflightno As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtarrtimeUTC As System.Windows.Forms.TextBox
    Friend WithEvents txtdeptimeUTC As System.Windows.Forms.TextBox
    Friend WithEvents txtburnoff As System.Windows.Forms.TextBox
    Friend WithEvents txtdepfuel As System.Windows.Forms.TextBox
    Friend WithEvents txtarrtimeIST As System.Windows.Forms.TextBox
    Friend WithEvents txtdeptimeIST As System.Windows.Forms.TextBox
    Friend WithEvents txtflightno As System.Windows.Forms.TextBox
    Friend WithEvents cboto1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbofrom1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbooilcompany As System.Windows.Forms.ComboBox
    Friend WithEvents cbobayno As System.Windows.Forms.ComboBox
    Friend WithEvents cboregno As System.Windows.Forms.ComboBox
    Friend WithEvents cboflightdate As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btndetails As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cbodate As System.Windows.Forms.ComboBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
