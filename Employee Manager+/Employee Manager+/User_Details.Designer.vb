<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Details))
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.GroupBox_Photo = New System.Windows.Forms.GroupBox()
        Me.Empl_Photo = New System.Windows.Forms.PictureBox()
        Me.Text_Email_Address = New System.Windows.Forms.Label()
        Me.Label_Email_Address = New System.Windows.Forms.Label()
        Me.Link_ChangePassword = New System.Windows.Forms.LinkLabel()
        Me.Link_ChangeDetails = New System.Windows.Forms.LinkLabel()
        Me.Text_Address = New System.Windows.Forms.Label()
        Me.Text_Date_of_Birth = New System.Windows.Forms.Label()
        Me.Text_Name = New System.Windows.Forms.Label()
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.Label_Date_of_Birth = New System.Windows.Forms.Label()
        Me.GroupBox_Photo.SuspendLayout()
        CType(Me.Empl_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(59, 45)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(49, 18)
        Me.Label_Name.TabIndex = 112
        Me.Label_Name.Text = "Name:"
        '
        'GroupBox_Photo
        '
        Me.GroupBox_Photo.Controls.Add(Me.Empl_Photo)
        Me.GroupBox_Photo.Location = New System.Drawing.Point(341, 11)
        Me.GroupBox_Photo.Name = "GroupBox_Photo"
        Me.GroupBox_Photo.Size = New System.Drawing.Size(189, 202)
        Me.GroupBox_Photo.TabIndex = 111
        Me.GroupBox_Photo.TabStop = False
        '
        'Empl_Photo
        '
        Me.Empl_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Empl_Photo.Location = New System.Drawing.Point(6, 13)
        Me.Empl_Photo.Name = "Empl_Photo"
        Me.Empl_Photo.Size = New System.Drawing.Size(177, 181)
        Me.Empl_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Empl_Photo.TabIndex = 11
        Me.Empl_Photo.TabStop = False
        '
        'Text_Email_Address
        '
        Me.Text_Email_Address.AutoSize = True
        Me.Text_Email_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Email_Address.ForeColor = System.Drawing.Color.Black
        Me.Text_Email_Address.Location = New System.Drawing.Point(114, 135)
        Me.Text_Email_Address.Name = "Text_Email_Address"
        Me.Text_Email_Address.Size = New System.Drawing.Size(0, 18)
        Me.Text_Email_Address.TabIndex = 121
        '
        'Label_Email_Address
        '
        Me.Label_Email_Address.AutoSize = True
        Me.Label_Email_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Email_Address.Location = New System.Drawing.Point(9, 135)
        Me.Label_Email_Address.Name = "Label_Email_Address"
        Me.Label_Email_Address.Size = New System.Drawing.Size(99, 18)
        Me.Label_Email_Address.TabIndex = 120
        Me.Label_Email_Address.Text = "Email Address:"
        '
        'Link_ChangePassword
        '
        Me.Link_ChangePassword.ActiveLinkColor = System.Drawing.Color.Navy
        Me.Link_ChangePassword.AutoSize = True
        Me.Link_ChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.Link_ChangePassword.DisabledLinkColor = System.Drawing.Color.Black
        Me.Link_ChangePassword.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link_ChangePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Link_ChangePassword.LinkColor = System.Drawing.Color.MediumVioletRed
        Me.Link_ChangePassword.Location = New System.Drawing.Point(12, 205)
        Me.Link_ChangePassword.Name = "Link_ChangePassword"
        Me.Link_ChangePassword.Size = New System.Drawing.Size(102, 14)
        Me.Link_ChangePassword.TabIndex = 119
        Me.Link_ChangePassword.TabStop = True
        Me.Link_ChangePassword.Text = "Change Password"
        Me.Link_ChangePassword.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'Link_ChangeDetails
        '
        Me.Link_ChangeDetails.ActiveLinkColor = System.Drawing.Color.Navy
        Me.Link_ChangeDetails.AutoSize = True
        Me.Link_ChangeDetails.BackColor = System.Drawing.Color.White
        Me.Link_ChangeDetails.DisabledLinkColor = System.Drawing.Color.Black
        Me.Link_ChangeDetails.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link_ChangeDetails.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Link_ChangeDetails.LinkColor = System.Drawing.Color.MediumVioletRed
        Me.Link_ChangeDetails.Location = New System.Drawing.Point(12, 188)
        Me.Link_ChangeDetails.Name = "Link_ChangeDetails"
        Me.Link_ChangeDetails.Size = New System.Drawing.Size(90, 14)
        Me.Link_ChangeDetails.TabIndex = 118
        Me.Link_ChangeDetails.TabStop = True
        Me.Link_ChangeDetails.Text = "Change Details"
        Me.Link_ChangeDetails.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'Text_Address
        '
        Me.Text_Address.AutoSize = True
        Me.Text_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Address.ForeColor = System.Drawing.Color.Black
        Me.Text_Address.Location = New System.Drawing.Point(114, 105)
        Me.Text_Address.Name = "Text_Address"
        Me.Text_Address.Size = New System.Drawing.Size(0, 18)
        Me.Text_Address.TabIndex = 117
        '
        'Text_Date_of_Birth
        '
        Me.Text_Date_of_Birth.AutoSize = True
        Me.Text_Date_of_Birth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Date_of_Birth.ForeColor = System.Drawing.Color.Black
        Me.Text_Date_of_Birth.Location = New System.Drawing.Point(114, 75)
        Me.Text_Date_of_Birth.Name = "Text_Date_of_Birth"
        Me.Text_Date_of_Birth.Size = New System.Drawing.Size(0, 18)
        Me.Text_Date_of_Birth.TabIndex = 116
        '
        'Text_Name
        '
        Me.Text_Name.AutoSize = True
        Me.Text_Name.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Name.ForeColor = System.Drawing.Color.Black
        Me.Text_Name.Location = New System.Drawing.Point(114, 45)
        Me.Text_Name.Name = "Text_Name"
        Me.Text_Name.Size = New System.Drawing.Size(0, 18)
        Me.Text_Name.TabIndex = 115
        '
        'Label_Address
        '
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Address.Location = New System.Drawing.Point(46, 105)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(62, 18)
        Me.Label_Address.TabIndex = 114
        Me.Label_Address.Text = "Address:"
        '
        'Label_Date_of_Birth
        '
        Me.Label_Date_of_Birth.AutoSize = True
        Me.Label_Date_of_Birth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Date_of_Birth.Location = New System.Drawing.Point(18, 75)
        Me.Label_Date_of_Birth.Name = "Label_Date_of_Birth"
        Me.Label_Date_of_Birth.Size = New System.Drawing.Size(90, 18)
        Me.Label_Date_of_Birth.TabIndex = 113
        Me.Label_Date_of_Birth.Text = "Date of Birth:"
        '
        'User_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(540, 231)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.GroupBox_Photo)
        Me.Controls.Add(Me.Text_Email_Address)
        Me.Controls.Add(Me.Label_Email_Address)
        Me.Controls.Add(Me.Link_ChangePassword)
        Me.Controls.Add(Me.Link_ChangeDetails)
        Me.Controls.Add(Me.Text_Address)
        Me.Controls.Add(Me.Text_Date_of_Birth)
        Me.Controls.Add(Me.Text_Name)
        Me.Controls.Add(Me.Label_Address)
        Me.Controls.Add(Me.Label_Date_of_Birth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Manager+ | user details"
        Me.GroupBox_Photo.ResumeLayout(False)
        CType(Me.Empl_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label_Name As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Photo As System.Windows.Forms.GroupBox
    Friend WithEvents Empl_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Text_Email_Address As System.Windows.Forms.Label
    Private WithEvents Label_Email_Address As System.Windows.Forms.Label
    Private WithEvents Link_ChangePassword As System.Windows.Forms.LinkLabel
    Private WithEvents Link_ChangeDetails As System.Windows.Forms.LinkLabel
    Friend WithEvents Text_Address As System.Windows.Forms.Label
    Friend WithEvents Text_Date_of_Birth As System.Windows.Forms.Label
    Friend WithEvents Text_Name As System.Windows.Forms.Label
    Private WithEvents Label_Address As System.Windows.Forms.Label
    Private WithEvents Label_Date_of_Birth As System.Windows.Forms.Label
End Class
