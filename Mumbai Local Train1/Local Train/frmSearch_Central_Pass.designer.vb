<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch_Central_Pass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch_Central_Pass))
        Me.dgcentral = New System.Windows.Forms.DataGridView
        Me.txtticketno = New System.Windows.Forms.TextBox
        Me.optbyticketnumber = New System.Windows.Forms.RadioButton
        Me.optbysource = New System.Windows.Forms.RadioButton
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.lblback = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdshowall = New System.Windows.Forms.Button
        Me.cbstation = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cbstations = New System.Windows.Forms.ComboBox
        Me.optbydestinaion = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.dgcentral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgcentral
        '
        Me.dgcentral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcentral.Location = New System.Drawing.Point(3, 3)
        Me.dgcentral.Name = "dgcentral"
        Me.dgcentral.Size = New System.Drawing.Size(519, 377)
        Me.dgcentral.TabIndex = 0
        '
        'txtticketno
        '
        Me.txtticketno.Location = New System.Drawing.Point(21, 151)
        Me.txtticketno.Name = "txtticketno"
        Me.txtticketno.Size = New System.Drawing.Size(121, 20)
        Me.txtticketno.TabIndex = 4
        '
        'optbyticketnumber
        '
        Me.optbyticketnumber.AutoSize = True
        Me.optbyticketnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optbyticketnumber.ForeColor = System.Drawing.Color.White
        Me.optbyticketnumber.Location = New System.Drawing.Point(32, 27)
        Me.optbyticketnumber.Name = "optbyticketnumber"
        Me.optbyticketnumber.Size = New System.Drawing.Size(126, 17)
        Me.optbyticketnumber.TabIndex = 1
        Me.optbyticketnumber.TabStop = True
        Me.optbyticketnumber.Text = "By Ticket Number"
        Me.optbyticketnumber.UseVisualStyleBackColor = True
        '
        'optbysource
        '
        Me.optbysource.AutoSize = True
        Me.optbysource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optbysource.ForeColor = System.Drawing.Color.White
        Me.optbysource.Location = New System.Drawing.Point(34, 66)
        Me.optbysource.Name = "optbysource"
        Me.optbysource.Size = New System.Drawing.Size(83, 17)
        Me.optbysource.TabIndex = 2
        Me.optbysource.TabStop = True
        Me.optbysource.Text = "By Source"
        Me.optbysource.UseVisualStyleBackColor = True
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(21, 89)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(121, 36)
        Me.cmdclose.TabIndex = 5
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(21, 3)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(121, 37)
        Me.cmdsearch.TabIndex = 4
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'lblback
        '
        Me.lblback.AutoSize = True
        Me.lblback.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblback.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblback.ForeColor = System.Drawing.Color.Yellow
        Me.lblback.Location = New System.Drawing.Point(48, 138)
        Me.lblback.Name = "lblback"
        Me.lblback.Size = New System.Drawing.Size(60, 22)
        Me.lblback.TabIndex = 6
        Me.lblback.Text = "BACK"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdshowall)
        Me.Panel3.Controls.Add(Me.lblback)
        Me.Panel3.Controls.Add(Me.cmdclose)
        Me.Panel3.Controls.Add(Me.cmdsearch)
        Me.Panel3.Location = New System.Drawing.Point(7, 232)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 163)
        Me.Panel3.TabIndex = 6
        '
        'cmdshowall
        '
        Me.cmdshowall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowall.Location = New System.Drawing.Point(21, 46)
        Me.cmdshowall.Name = "cmdshowall"
        Me.cmdshowall.Size = New System.Drawing.Size(121, 37)
        Me.cmdshowall.TabIndex = 7
        Me.cmdshowall.Text = "Show All"
        Me.cmdshowall.UseVisualStyleBackColor = True
        '
        'cbstation
        '
        Me.cbstation.DropDownHeight = 80
        Me.cbstation.FormattingEnabled = True
        Me.cbstation.IntegralHeight = False
        Me.cbstation.Location = New System.Drawing.Point(21, 151)
        Me.cbstation.Name = "cbstation"
        Me.cbstation.Size = New System.Drawing.Size(121, 21)
        Me.cbstation.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbstation)
        Me.Panel2.Controls.Add(Me.cbstations)
        Me.Panel2.Controls.Add(Me.txtticketno)
        Me.Panel2.Controls.Add(Me.optbyticketnumber)
        Me.Panel2.Controls.Add(Me.optbysource)
        Me.Panel2.Controls.Add(Me.optbydestinaion)
        Me.Panel2.Location = New System.Drawing.Point(7, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(164, 214)
        Me.Panel2.TabIndex = 5
        '
        'cbstations
        '
        Me.cbstations.DropDownHeight = 80
        Me.cbstations.FormattingEnabled = True
        Me.cbstations.IntegralHeight = False
        Me.cbstations.Location = New System.Drawing.Point(21, 178)
        Me.cbstations.Name = "cbstations"
        Me.cbstations.Size = New System.Drawing.Size(121, 21)
        Me.cbstations.TabIndex = 5
        '
        'optbydestinaion
        '
        Me.optbydestinaion.AutoSize = True
        Me.optbydestinaion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optbydestinaion.ForeColor = System.Drawing.Color.White
        Me.optbydestinaion.Location = New System.Drawing.Point(34, 106)
        Me.optbydestinaion.Name = "optbydestinaion"
        Me.optbydestinaion.Size = New System.Drawing.Size(107, 17)
        Me.optbydestinaion.TabIndex = 3
        Me.optbydestinaion.TabStop = True
        Me.optbydestinaion.Text = "By Destination"
        Me.optbydestinaion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgcentral)
        Me.Panel1.Location = New System.Drawing.Point(190, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 383)
        Me.Panel1.TabIndex = 4
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     passcentralup.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         passcentralup"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Central;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PassNo", System.Data.SqlDbType.Int, 0, "PassNo"), New System.Data.SqlClient.SqlParameter("@Source", System.Data.SqlDbType.Text, 0, "Source"), New System.Data.SqlClient.SqlParameter("@Destination", System.Data.SqlDbType.Text, 0, "Destination"), New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.Text, 0, "Date"), New System.Data.SqlClient.SqlParameter("@time", System.Data.SqlDbType.Text, 0, "time"), New System.Data.SqlClient.SqlParameter("@Coach", System.Data.SqlDbType.Int, 0, "Coach"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.[Char], 0, "Type"), New System.Data.SqlClient.SqlParameter("@Distance", System.Data.SqlDbType.Int, 0, "Distance"), New System.Data.SqlClient.SqlParameter("@Duration", System.Data.SqlDbType.Int, 0, "Duration"), New System.Data.SqlClient.SqlParameter("@PassType", System.Data.SqlDbType.Text, 0, "PassType"), New System.Data.SqlClient.SqlParameter("@Months", System.Data.SqlDbType.Text, 0, "Months"), New System.Data.SqlClient.SqlParameter("@Class", System.Data.SqlDbType.[Char], 0, "Class"), New System.Data.SqlClient.SqlParameter("@ExpiryDate", System.Data.SqlDbType.Text, 0, "ExpiryDate"), New System.Data.SqlClient.SqlParameter("@Price", System.Data.SqlDbType.Float, 0, "Price")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "passcentralup", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PassNo", "PassNo"), New System.Data.Common.DataColumnMapping("Source", "Source"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("time", "time"), New System.Data.Common.DataColumnMapping("Coach", "Coach"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Distance", "Distance"), New System.Data.Common.DataColumnMapping("Duration", "Duration"), New System.Data.Common.DataColumnMapping("PassType", "PassType"), New System.Data.Common.DataColumnMapping("Months", "Months"), New System.Data.Common.DataColumnMapping("Class", "Class"), New System.Data.Common.DataColumnMapping("ExpiryDate", "ExpiryDate"), New System.Data.Common.DataColumnMapping("Price", "Price")})})
        '
        'frmSearch_Central_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(723, 407)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSearch_Central_Pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Central Pass Search"
        CType(Me.dgcentral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgcentral As System.Windows.Forms.DataGridView
    Friend WithEvents txtticketno As System.Windows.Forms.TextBox
    Friend WithEvents optbyticketnumber As System.Windows.Forms.RadioButton
    Friend WithEvents optbysource As System.Windows.Forms.RadioButton
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents lblback As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbstation As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbstations As System.Windows.Forms.ComboBox
    Friend WithEvents optbydestinaion As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents cmdshowall As System.Windows.Forms.Button
End Class