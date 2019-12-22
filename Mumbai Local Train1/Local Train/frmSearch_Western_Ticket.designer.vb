<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch_Western_Ticket
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch_Western_Ticket))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdshowall = New System.Windows.Forms.Button
        Me.lblback = New System.Windows.Forms.Label
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.optbydestinaion = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cbstation = New System.Windows.Forms.ComboBox
        Me.txtticketno = New System.Windows.Forms.TextBox
        Me.optbyticketnumber = New System.Windows.Forms.RadioButton
        Me.optbysource = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgwestern = New System.Windows.Forms.DataGridView
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgwestern, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdshowall)
        Me.Panel3.Controls.Add(Me.lblback)
        Me.Panel3.Controls.Add(Me.cmdclose)
        Me.Panel3.Controls.Add(Me.cmdsearch)
        Me.Panel3.Location = New System.Drawing.Point(7, 232)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 160)
        Me.Panel3.TabIndex = 3
        '
        'cmdshowall
        '
        Me.cmdshowall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowall.Location = New System.Drawing.Point(21, 46)
        Me.cmdshowall.Name = "cmdshowall"
        Me.cmdshowall.Size = New System.Drawing.Size(121, 37)
        Me.cmdshowall.TabIndex = 10
        Me.cmdshowall.Text = "Show All"
        Me.cmdshowall.UseVisualStyleBackColor = True
        '
        'lblback
        '
        Me.lblback.AutoSize = True
        Me.lblback.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblback.ForeColor = System.Drawing.Color.Yellow
        Me.lblback.Location = New System.Drawing.Point(47, 127)
        Me.lblback.Name = "lblback"
        Me.lblback.Size = New System.Drawing.Size(60, 22)
        Me.lblback.TabIndex = 6
        Me.lblback.Text = "BACK"
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(22, 88)
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
        'optbydestinaion
        '
        Me.optbydestinaion.AutoSize = True
        Me.optbydestinaion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optbydestinaion.ForeColor = System.Drawing.Color.White
        Me.optbydestinaion.Location = New System.Drawing.Point(33, 106)
        Me.optbydestinaion.Name = "optbydestinaion"
        Me.optbydestinaion.Size = New System.Drawing.Size(107, 17)
        Me.optbydestinaion.TabIndex = 3
        Me.optbydestinaion.TabStop = True
        Me.optbydestinaion.Text = "By Destination"
        Me.optbydestinaion.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbstation)
        Me.Panel2.Controls.Add(Me.txtticketno)
        Me.Panel2.Controls.Add(Me.optbyticketnumber)
        Me.Panel2.Controls.Add(Me.optbysource)
        Me.Panel2.Controls.Add(Me.optbydestinaion)
        Me.Panel2.Location = New System.Drawing.Point(7, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 214)
        Me.Panel2.TabIndex = 2
        '
        'cbstation
        '
        Me.cbstation.DropDownHeight = 80
        Me.cbstation.FormattingEnabled = True
        Me.cbstation.IntegralHeight = False
        Me.cbstation.Location = New System.Drawing.Point(21, 164)
        Me.cbstation.Name = "cbstation"
        Me.cbstation.Size = New System.Drawing.Size(121, 21)
        Me.cbstation.TabIndex = 5
        '
        'txtticketno
        '
        Me.txtticketno.Location = New System.Drawing.Point(21, 165)
        Me.txtticketno.Name = "txtticketno"
        Me.txtticketno.Size = New System.Drawing.Size(121, 20)
        Me.txtticketno.TabIndex = 4
        '
        'optbyticketnumber
        '
        Me.optbyticketnumber.AutoSize = True
        Me.optbyticketnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optbyticketnumber.ForeColor = System.Drawing.Color.White
        Me.optbyticketnumber.Location = New System.Drawing.Point(33, 27)
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
        Me.optbysource.Location = New System.Drawing.Point(33, 66)
        Me.optbysource.Name = "optbysource"
        Me.optbysource.Size = New System.Drawing.Size(83, 17)
        Me.optbysource.TabIndex = 2
        Me.optbysource.TabStop = True
        Me.optbysource.Text = "By Source"
        Me.optbysource.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgwestern)
        Me.Panel1.Location = New System.Drawing.Point(189, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 383)
        Me.Panel1.TabIndex = 1
        '
        'dgwestern
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwestern.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwestern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwestern.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwestern.Location = New System.Drawing.Point(3, 3)
        Me.dgwestern.Name = "dgwestern"
        Me.dgwestern.Size = New System.Drawing.Size(519, 377)
        Me.dgwestern.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     Westernup.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Westernup"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Western;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TicketNo", System.Data.SqlDbType.Int, 0, "TicketNo"), New System.Data.SqlClient.SqlParameter("@Ticketqty", System.Data.SqlDbType.Int, 0, "Ticketqty"), New System.Data.SqlClient.SqlParameter("@Source", System.Data.SqlDbType.Text, 0, "Source"), New System.Data.SqlClient.SqlParameter("@Destination", System.Data.SqlDbType.Text, 0, "Destination"), New System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.Text, 0, "Date"), New System.Data.SqlClient.SqlParameter("@time", System.Data.SqlDbType.Text, 0, "time"), New System.Data.SqlClient.SqlParameter("@Coach", System.Data.SqlDbType.Int, 0, "Coach"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.[Char], 0, "Type"), New System.Data.SqlClient.SqlParameter("@Distance", System.Data.SqlDbType.Int, 0, "Distance"), New System.Data.SqlClient.SqlParameter("@Duration", System.Data.SqlDbType.Int, 0, "Duration"), New System.Data.SqlClient.SqlParameter("@Adult", System.Data.SqlDbType.Int, 0, "Adult"), New System.Data.SqlClient.SqlParameter("@Child", System.Data.SqlDbType.Int, 0, "Child"), New System.Data.SqlClient.SqlParameter("@Class", System.Data.SqlDbType.[Char], 0, "Class"), New System.Data.SqlClient.SqlParameter("@Return", System.Data.SqlDbType.Text, 0, "Return"), New System.Data.SqlClient.SqlParameter("@Price", System.Data.SqlDbType.Int, 0, "Price"), New System.Data.SqlClient.SqlParameter("@Totalprice", System.Data.SqlDbType.Float, 0, "Totalprice")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Westernup", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TicketNo", "TicketNo"), New System.Data.Common.DataColumnMapping("Ticketqty", "Ticketqty"), New System.Data.Common.DataColumnMapping("Source", "Source"), New System.Data.Common.DataColumnMapping("Destination", "Destination"), New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("time", "time"), New System.Data.Common.DataColumnMapping("Coach", "Coach"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Distance", "Distance"), New System.Data.Common.DataColumnMapping("Duration", "Duration"), New System.Data.Common.DataColumnMapping("Adult", "Adult"), New System.Data.Common.DataColumnMapping("Child", "Child"), New System.Data.Common.DataColumnMapping("Class", "Class"), New System.Data.Common.DataColumnMapping("Return", "Return"), New System.Data.Common.DataColumnMapping("Price", "Price"), New System.Data.Common.DataColumnMapping("Totalprice", "Totalprice")})})
        '
        'frmSearch_Western_Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(723, 407)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSearch_Western_Ticket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Western Ticket Search"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgwestern, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblback As System.Windows.Forms.Label
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents optbydestinaion As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbstation As System.Windows.Forms.ComboBox
    Friend WithEvents txtticketno As System.Windows.Forms.TextBox
    Friend WithEvents optbyticketnumber As System.Windows.Forms.RadioButton
    Friend WithEvents optbysource As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgwestern As System.Windows.Forms.DataGridView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents cmdshowall As System.Windows.Forms.Button
End Class
