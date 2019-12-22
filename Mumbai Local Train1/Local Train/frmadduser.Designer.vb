<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadduser
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
        Me.lblBack = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox
        Me.lbldateandtime = New System.Windows.Forms.Label
        Me.txtdatetime = New System.Windows.Forms.TextBox
        Me.lbladduser = New System.Windows.Forms.Label
        Me.lblconfirmpassword = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.lblpassword = New System.Windows.Forms.Label
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.lblusername = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBack.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.Yellow
        Me.lblBack.Location = New System.Drawing.Point(120, 288)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(72, 23)
        Me.lblBack.TabIndex = 19
        Me.lblBack.Text = "<<BACK"
        Me.ToolTip1.SetToolTip(Me.lblBack, "Back")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtconfirmpassword)
        Me.Panel2.Controls.Add(Me.lbldateandtime)
        Me.Panel2.Controls.Add(Me.txtdatetime)
        Me.Panel2.Controls.Add(Me.lbladduser)
        Me.Panel2.Controls.Add(Me.lblconfirmpassword)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.lblpassword)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.lblusername)
        Me.Panel2.Location = New System.Drawing.Point(1, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 199)
        Me.Panel2.TabIndex = 18
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Location = New System.Drawing.Point(182, 159)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(140, 20)
        Me.txtconfirmpassword.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtconfirmpassword, "Confirm password")
        '
        'lbldateandtime
        '
        Me.lbldateandtime.AutoSize = True
        Me.lbldateandtime.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateandtime.ForeColor = System.Drawing.Color.Yellow
        Me.lbldateandtime.Location = New System.Drawing.Point(3, 59)
        Me.lbldateandtime.Name = "lbldateandtime"
        Me.lbldateandtime.Size = New System.Drawing.Size(137, 18)
        Me.lbldateandtime.TabIndex = 11
        Me.lbldateandtime.Text = "DATE AND TIME"
        '
        'txtdatetime
        '
        Me.txtdatetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatetime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdatetime.Location = New System.Drawing.Point(182, 57)
        Me.txtdatetime.Name = "txtdatetime"
        Me.txtdatetime.Size = New System.Drawing.Size(140, 20)
        Me.txtdatetime.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtdatetime, "Current Date and Time")
        '
        'lbladduser
        '
        Me.lbladduser.AutoSize = True
        Me.lbladduser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbladduser.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladduser.ForeColor = System.Drawing.Color.Yellow
        Me.lbladduser.Location = New System.Drawing.Point(102, 0)
        Me.lbladduser.Name = "lbladduser"
        Me.lbladduser.Size = New System.Drawing.Size(142, 35)
        Me.lbladduser.TabIndex = 4
        Me.lbladduser.Text = "ADD USER"
        '
        'lblconfirmpassword
        '
        Me.lblconfirmpassword.AutoSize = True
        Me.lblconfirmpassword.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmpassword.ForeColor = System.Drawing.Color.Yellow
        Me.lblconfirmpassword.Location = New System.Drawing.Point(3, 161)
        Me.lblconfirmpassword.Name = "lblconfirmpassword"
        Me.lblconfirmpassword.Size = New System.Drawing.Size(176, 18)
        Me.lblconfirmpassword.TabIndex = 10
        Me.lblconfirmpassword.Text = "CONFERM PASSWORD"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(182, 90)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(140, 20)
        Me.txtname.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtname, "Enter your name")
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.Yellow
        Me.lblpassword.Location = New System.Drawing.Point(3, 125)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(93, 18)
        Me.lblpassword.TabIndex = 6
        Me.lblpassword.Text = "PASSWORD"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(182, 125)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(140, 20)
        Me.txtpassword.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtpassword, "Enter password")
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.Yellow
        Me.lblusername.Location = New System.Drawing.Point(3, 90)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(104, 18)
        Me.lblusername.TabIndex = 5
        Me.lblusername.Text = "USER NAME"
        '
        'cmdadd
        '
        Me.cmdadd.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.Location = New System.Drawing.Point(14, 17)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(89, 33)
        Me.cmdadd.TabIndex = 0
        Me.cmdadd.Text = "&ADD"
        Me.ToolTip1.SetToolTip(Me.cmdadd, "Add user")
        Me.cmdadd.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdexit)
        Me.Panel1.Controls.Add(Me.cmdclear)
        Me.Panel1.Controls.Add(Me.cmdadd)
        Me.Panel1.Location = New System.Drawing.Point(1, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 66)
        Me.Panel1.TabIndex = 17
        '
        'Timer1
        '
        '
        'frmadduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(335, 320)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmadduser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtconfirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents lbldateandtime As System.Windows.Forms.Label
    Friend WithEvents txtdatetime As System.Windows.Forms.TextBox
    Friend WithEvents lbladduser As System.Windows.Forms.Label
    Friend WithEvents lblconfirmpassword As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
