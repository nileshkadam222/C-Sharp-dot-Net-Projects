<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.lblprogressoftime = New System.Windows.Forms.Label
        Me.pb1 = New System.Windows.Forms.ProgressBar
        Me.l1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.lblsecurityform = New System.Windows.Forms.Label
        Me.lblpassword = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdlogin = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADDUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OSKeyboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblprogressoftime
        '
        Me.lblprogressoftime.AutoSize = True
        Me.lblprogressoftime.BackColor = System.Drawing.Color.Maroon
        Me.lblprogressoftime.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogressoftime.ForeColor = System.Drawing.Color.Yellow
        Me.lblprogressoftime.Location = New System.Drawing.Point(4, 56)
        Me.lblprogressoftime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprogressoftime.Name = "lblprogressoftime"
        Me.lblprogressoftime.Size = New System.Drawing.Size(133, 18)
        Me.lblprogressoftime.TabIndex = 38
        Me.lblprogressoftime.Text = "Seconds Remaining" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.lblprogressoftime, "Progress of time...")
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(136, 58)
        Me.pb1.Margin = New System.Windows.Forms.Padding(4)
        Me.pb1.Maximum = 60
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(159, 18)
        Me.pb1.TabIndex = 36
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Black
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.l1.Location = New System.Drawing.Point(303, 58)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(0, 16)
        Me.l1.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.lblsecurityform)
        Me.Panel1.Controls.Add(Me.lblpassword)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 128)
        Me.Panel1.TabIndex = 36
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(124, 93)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(188, 20)
        Me.txtpassword.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.txtpassword, "Enter Your Password")
        '
        'lblsecurityform
        '
        Me.lblsecurityform.AutoSize = True
        Me.lblsecurityform.BackColor = System.Drawing.Color.Maroon
        Me.lblsecurityform.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecurityform.ForeColor = System.Drawing.Color.Yellow
        Me.lblsecurityform.Location = New System.Drawing.Point(54, -4)
        Me.lblsecurityform.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsecurityform.Name = "lblsecurityform"
        Me.lblsecurityform.Size = New System.Drawing.Size(249, 38)
        Me.lblsecurityform.TabIndex = 36
        Me.lblsecurityform.Text = "SECURITY FORM"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Maroon
        Me.lblpassword.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.Yellow
        Me.lblpassword.Location = New System.Drawing.Point(11, 93)
        Me.lblpassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(83, 22)
        Me.lblpassword.TabIndex = 35
        Me.lblpassword.Text = "Password"
        Me.ToolTip1.SetToolTip(Me.lblpassword, "Password")
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Maroon
        Me.lblname.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Yellow
        Me.lblname.Location = New System.Drawing.Point(9, 57)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(54, 22)
        Me.lblname.TabIndex = 32
        Me.lblname.Text = "Name"
        Me.ToolTip1.SetToolTip(Me.lblname, "Name")
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(124, 57)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(188, 20)
        Me.txtname.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.txtname, "Enter Your Name")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdclear)
        Me.Panel2.Controls.Add(Me.cmdexit)
        Me.Panel2.Controls.Add(Me.lblprogressoftime)
        Me.Panel2.Controls.Add(Me.pb1)
        Me.Panel2.Controls.Add(Me.l1)
        Me.Panel2.Controls.Add(Me.cmdlogin)
        Me.Panel2.Location = New System.Drawing.Point(0, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 83)
        Me.Panel2.TabIndex = 37
        '
        'cmdclear
        '
        Me.cmdclear.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdclear.Location = New System.Drawing.Point(136, 4)
        Me.cmdclear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(79, 37)
        Me.cmdclear.TabIndex = 34
        Me.cmdclear.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.cmdclear, "Clear")
        Me.cmdclear.UseVisualStyleBackColor = True
        '
        'cmdexit
        '
        Me.cmdexit.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdexit.Location = New System.Drawing.Point(245, 1)
        Me.cmdexit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(79, 37)
        Me.cmdexit.TabIndex = 35
        Me.cmdexit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.cmdexit, "Exit")
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'cmdlogin
        '
        Me.cmdlogin.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdlogin.Location = New System.Drawing.Point(25, 4)
        Me.cmdlogin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(79, 37)
        Me.cmdlogin.TabIndex = 33
        Me.cmdlogin.Text = "&Login"
        Me.ToolTip1.SetToolTip(Me.cmdlogin, "Login here...")
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 900
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(349, 24)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDUSERToolStripMenuItem, Me.OSKeyboardToolStripMenuItem})
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.USERToolStripMenuItem.Text = "&USER"
        '
        'ADDUSERToolStripMenuItem
        '
        Me.ADDUSERToolStripMenuItem.Name = "ADDUSERToolStripMenuItem"
        Me.ADDUSERToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ADDUSERToolStripMenuItem.Text = "&ADD USER"
        '
        'OSKeyboardToolStripMenuItem
        '
        Me.OSKeyboardToolStripMenuItem.Name = "OSKeyboardToolStripMenuItem"
        Me.OSKeyboardToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.OSKeyboardToolStripMenuItem.Text = "OS Keyboard"
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(349, 255)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblprogressoftime As System.Windows.Forms.Label
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblsecurityform As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDUSERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSKeyboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
