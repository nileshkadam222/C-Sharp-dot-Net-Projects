<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangepassword
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
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtdatetime = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdchangepassword = New System.Windows.Forms.Button
        Me.lblBack = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbldateandtime = New System.Windows.Forms.Label
        Me.lblchangepassword = New System.Windows.Forms.Label
        Me.lblpassword = New System.Windows.Forms.Label
        Me.lblusername = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdatetime
        '
        Me.txtdatetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatetime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdatetime.Location = New System.Drawing.Point(182, 56)
        Me.txtdatetime.Name = "txtdatetime"
        Me.txtdatetime.Size = New System.Drawing.Size(140, 20)
        Me.txtdatetime.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtdatetime, "Current Date and Time")
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(182, 96)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(140, 20)
        Me.txtname.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtname, "Enter your name")
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(182, 137)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(140, 20)
        Me.txtpassword.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtpassword, "Enter password")
        '
        'cmdexit
        '
        Me.cmdexit.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(233, 17)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(89, 33)
        Me.cmdexit.TabIndex = 5
        Me.cmdexit.Text = "E&XIT"
        Me.ToolTip1.SetToolTip(Me.cmdexit, "Exit")
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'cmdclear
        '
        Me.cmdclear.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.Location = New System.Drawing.Point(123, 17)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(89, 33)
        Me.cmdclear.TabIndex = 4
        Me.cmdclear.Text = "&CLEAR"
        Me.ToolTip1.SetToolTip(Me.cmdclear, "Clear")
        Me.cmdclear.UseVisualStyleBackColor = True
        '
        'cmdchangepassword
        '
        Me.cmdchangepassword.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdchangepassword.Location = New System.Drawing.Point(14, 17)
        Me.cmdchangepassword.Name = "cmdchangepassword"
        Me.cmdchangepassword.Size = New System.Drawing.Size(89, 33)
        Me.cmdchangepassword.TabIndex = 0
        Me.cmdchangepassword.Text = "&Change"
        Me.ToolTip1.SetToolTip(Me.cmdchangepassword, "Change Password")
        Me.cmdchangepassword.UseVisualStyleBackColor = True
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBack.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.Yellow
        Me.lblBack.Location = New System.Drawing.Point(122, 274)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(85, 23)
        Me.lblBack.TabIndex = 19
        Me.lblBack.Text = "<<BACK"
        Me.ToolTip1.SetToolTip(Me.lblBack, "Back")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbldateandtime)
        Me.Panel2.Controls.Add(Me.txtdatetime)
        Me.Panel2.Controls.Add(Me.lblchangepassword)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.lblpassword)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.lblusername)
        Me.Panel2.Location = New System.Drawing.Point(3, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 179)
        Me.Panel2.TabIndex = 18
        '
        'lbldateandtime
        '
        Me.lbldateandtime.AutoSize = True
        Me.lbldateandtime.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateandtime.ForeColor = System.Drawing.Color.Yellow
        Me.lbldateandtime.Location = New System.Drawing.Point(3, 58)
        Me.lbldateandtime.Name = "lbldateandtime"
        Me.lbldateandtime.Size = New System.Drawing.Size(137, 18)
        Me.lbldateandtime.TabIndex = 11
        Me.lbldateandtime.Text = "DATE AND TIME"
        '
        'lblchangepassword
        '
        Me.lblchangepassword.AutoSize = True
        Me.lblchangepassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblchangepassword.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchangepassword.ForeColor = System.Drawing.Color.Yellow
        Me.lblchangepassword.Location = New System.Drawing.Point(24, 10)
        Me.lblchangepassword.Name = "lblchangepassword"
        Me.lblchangepassword.Size = New System.Drawing.Size(268, 35)
        Me.lblchangepassword.TabIndex = 4
        Me.lblchangepassword.Text = "CHANGE PASSWORD"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.Yellow
        Me.lblpassword.Location = New System.Drawing.Point(3, 139)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(93, 18)
        Me.lblpassword.TabIndex = 6
        Me.lblpassword.Text = "PASSWORD"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.Yellow
        Me.lblusername.Location = New System.Drawing.Point(3, 96)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(104, 18)
        Me.lblusername.TabIndex = 5
        Me.lblusername.Text = "USER NAME"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdexit)
        Me.Panel1.Controls.Add(Me.cmdclear)
        Me.Panel1.Controls.Add(Me.cmdchangepassword)
        Me.Panel1.Location = New System.Drawing.Point(3, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 65)
        Me.Panel1.TabIndex = 17
        '
        'Timer1
        '
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     Login.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Login"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=""Local Train"";Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Login] ([Name], [Password], [Current Time]) VALUES (@Name, @Password" & _
            ", @Current_Time)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.[Char], 0, "Name"), New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.Text, 0, "Password"), New System.Data.SqlClient.SqlParameter("@Current_Time", System.Data.SqlDbType.DateTime, 0, "Current Time")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Current Time", "Current Time")})})
        '
        'frmChangepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(345, 309)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmChangepassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangepassword"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtdatetime As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmdchangepassword As System.Windows.Forms.Button
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbldateandtime As System.Windows.Forms.Label
    Friend WithEvents lblchangepassword As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
End Class
