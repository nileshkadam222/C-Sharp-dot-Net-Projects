<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolBox = New System.Windows.Forms.ToolStrip()
        Me.ToolBox_Register = New System.Windows.Forms.ToolStripButton()
        Me.ToolBox_Separator_1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolBox_UserDetails = New System.Windows.Forms.ToolStripButton()
        Me.ToolBox_Separator_2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolBox_Message = New System.Windows.Forms.ToolStripButton()
        Me.ToolBox_Separator_3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolBox_Logout = New System.Windows.Forms.ToolStripButton()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBar_Username_Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Username_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar_Date_Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Date_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar_Time_Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Time_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolBox.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'ToolBox
        '
        Me.ToolBox.BackColor = System.Drawing.Color.Transparent
        Me.ToolBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolBox.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ToolBox.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBox.ImageScalingSize = New System.Drawing.Size(72, 72)
        Me.ToolBox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBox_Register, Me.ToolBox_Separator_1, Me.ToolBox_UserDetails, Me.ToolBox_Separator_2, Me.ToolBox_Message, Me.ToolBox_Separator_3, Me.ToolBox_Logout})
        Me.ToolBox.Location = New System.Drawing.Point(0, 29)
        Me.ToolBox.Name = "ToolBox"
        Me.ToolBox.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolBox.Size = New System.Drawing.Size(79, 347)
        Me.ToolBox.TabIndex = 20
        Me.ToolBox.Text = "ToolBox"
        '
        'ToolBox_Register
        '
        Me.ToolBox_Register.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBox_Register.Image = Global.Employee_Manager.My.Resources.Resources.add_user
        Me.ToolBox_Register.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolBox_Register.Name = "ToolBox_Register"
        Me.ToolBox_Register.Size = New System.Drawing.Size(76, 67)
        Me.ToolBox_Register.Text = "Manage"
        Me.ToolBox_Register.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolBox_Separator_1
        '
        Me.ToolBox_Separator_1.Name = "ToolBox_Separator_1"
        Me.ToolBox_Separator_1.Size = New System.Drawing.Size(76, 6)
        '
        'ToolBox_UserDetails
        '
        Me.ToolBox_UserDetails.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBox_UserDetails.Image = Global.Employee_Manager.My.Resources.Resources.user
        Me.ToolBox_UserDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolBox_UserDetails.Name = "ToolBox_UserDetails"
        Me.ToolBox_UserDetails.Size = New System.Drawing.Size(76, 67)
        Me.ToolBox_UserDetails.Text = "User Details"
        Me.ToolBox_UserDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolBox_Separator_2
        '
        Me.ToolBox_Separator_2.Name = "ToolBox_Separator_2"
        Me.ToolBox_Separator_2.Size = New System.Drawing.Size(76, 6)
        '
        'ToolBox_Message
        '
        Me.ToolBox_Message.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBox_Message.Image = Global.Employee_Manager.My.Resources.Resources.chat
        Me.ToolBox_Message.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolBox_Message.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolBox_Message.Name = "ToolBox_Message"
        Me.ToolBox_Message.Size = New System.Drawing.Size(76, 67)
        Me.ToolBox_Message.Text = "Message"
        Me.ToolBox_Message.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolBox_Separator_3
        '
        Me.ToolBox_Separator_3.Name = "ToolBox_Separator_3"
        Me.ToolBox_Separator_3.Size = New System.Drawing.Size(76, 6)
        '
        'ToolBox_Logout
        '
        Me.ToolBox_Logout.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBox_Logout.Image = Global.Employee_Manager.My.Resources.Resources.offline_user
        Me.ToolBox_Logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolBox_Logout.Name = "ToolBox_Logout"
        Me.ToolBox_Logout.Size = New System.Drawing.Size(76, 67)
        Me.ToolBox_Logout.Text = "Logout"
        Me.ToolBox_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.Color.Transparent
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusBar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBar_Username_Label, Me.Username_Status, Me.StatusBar_Date_Label, Me.Date_Status, Me.StatusBar_Time_Label, Me.Time_Status})
        Me.StatusBar.Location = New System.Drawing.Point(0, 0)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusBar.Size = New System.Drawing.Size(694, 29)
        Me.StatusBar.TabIndex = 18
        Me.StatusBar.Text = "StatusStrip"
        '
        'StatusBar_Username_Label
        '
        Me.StatusBar_Username_Label.BackColor = System.Drawing.Color.Transparent
        Me.StatusBar_Username_Label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar_Username_Label.Image = Global.Employee_Manager.My.Resources.Resources.user_statusbar
        Me.StatusBar_Username_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusBar_Username_Label.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StatusBar_Username_Label.Margin = New System.Windows.Forms.Padding(7, 3, 0, 2)
        Me.StatusBar_Username_Label.Name = "StatusBar_Username_Label"
        Me.StatusBar_Username_Label.Size = New System.Drawing.Size(86, 24)
        Me.StatusBar_Username_Label.Text = "Username"
        '
        'Username_Status
        '
        Me.Username_Status.BackColor = System.Drawing.SystemColors.Control
        Me.Username_Status.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_Status.Margin = New System.Windows.Forms.Padding(0, 3, 7, 2)
        Me.Username_Status.Name = "Username_Status"
        Me.Username_Status.Size = New System.Drawing.Size(0, 24)
        '
        'StatusBar_Date_Label
        '
        Me.StatusBar_Date_Label.BackColor = System.Drawing.Color.Transparent
        Me.StatusBar_Date_Label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar_Date_Label.Image = Global.Employee_Manager.My.Resources.Resources.date_icon
        Me.StatusBar_Date_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusBar_Date_Label.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StatusBar_Date_Label.Margin = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.StatusBar_Date_Label.Name = "StatusBar_Date_Label"
        Me.StatusBar_Date_Label.Size = New System.Drawing.Size(56, 24)
        Me.StatusBar_Date_Label.Text = "Date"
        '
        'Date_Status
        '
        Me.Date_Status.BackColor = System.Drawing.SystemColors.Control
        Me.Date_Status.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Status.Margin = New System.Windows.Forms.Padding(0, 3, 7, 2)
        Me.Date_Status.Name = "Date_Status"
        Me.Date_Status.Size = New System.Drawing.Size(0, 24)
        '
        'StatusBar_Time_Label
        '
        Me.StatusBar_Time_Label.BackColor = System.Drawing.Color.Transparent
        Me.StatusBar_Time_Label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar_Time_Label.Image = Global.Employee_Manager.My.Resources.Resources.time
        Me.StatusBar_Time_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusBar_Time_Label.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StatusBar_Time_Label.Margin = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.StatusBar_Time_Label.Name = "StatusBar_Time_Label"
        Me.StatusBar_Time_Label.Size = New System.Drawing.Size(57, 24)
        Me.StatusBar_Time_Label.Text = "Time"
        '
        'Time_Status
        '
        Me.Time_Status.BackColor = System.Drawing.SystemColors.Control
        Me.Time_Status.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Status.Margin = New System.Windows.Forms.Padding(0, 3, 3, 2)
        Me.Time_Status.Name = "Time_Status"
        Me.Time_Status.Size = New System.Drawing.Size(0, 24)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(694, 376)
        Me.Controls.Add(Me.ToolBox)
        Me.Controls.Add(Me.StatusBar)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Manager+ | main"
        Me.ToolBox.ResumeLayout(False)
        Me.ToolBox.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ToolBox As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolBox_Register As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolBox_Separator_1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolBox_UserDetails As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolBox_Separator_2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolBox_Logout As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolBox_Separator_3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusBar_Username_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Username_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBar_Date_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Date_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBar_Time_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Time_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolBox_Message As System.Windows.Forms.ToolStripButton
End Class
