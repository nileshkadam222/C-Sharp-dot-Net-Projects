<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsplashscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsplashscreen))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPleasewait = New System.Windows.Forms.Label
        Me.lblLoading = New System.Windows.Forms.Label
        Me.lblwelcome = New System.Windows.Forms.Label
        Me.LocalTrainphoto = New System.Windows.Forms.PictureBox
        Me.pb = New System.Windows.Forms.ProgressBar
        CType(Me.LocalTrainphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblPleasewait
        '
        Me.lblPleasewait.AutoSize = True
        Me.lblPleasewait.BackColor = System.Drawing.Color.Peru
        Me.lblPleasewait.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasewait.ForeColor = System.Drawing.Color.Black
        Me.lblPleasewait.Location = New System.Drawing.Point(479, 353)
        Me.lblPleasewait.Name = "lblPleasewait"
        Me.lblPleasewait.Size = New System.Drawing.Size(107, 18)
        Me.lblPleasewait.TabIndex = 21
        Me.lblPleasewait.Text = "Please wait...."
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.Black
        Me.lblLoading.Location = New System.Drawing.Point(33, 337)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(182, 39)
        Me.lblLoading.TabIndex = 20
        Me.lblLoading.Text = "LOADING..."
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.BackColor = System.Drawing.Color.Peru
        Me.lblwelcome.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.Black
        Me.lblwelcome.Location = New System.Drawing.Point(2, 9)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(650, 76)
        Me.lblwelcome.TabIndex = 19
        Me.lblwelcome.Text = "WELCOME TO MUMBAI SUBURBAN RAILWAY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LocalTrainphoto
        '
        Me.LocalTrainphoto.Image = CType(resources.GetObject("LocalTrainphoto.Image"), System.Drawing.Image)
        Me.LocalTrainphoto.Location = New System.Drawing.Point(80, 76)
        Me.LocalTrainphoto.Name = "LocalTrainphoto"
        Me.LocalTrainphoto.Size = New System.Drawing.Size(488, 258)
        Me.LocalTrainphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LocalTrainphoto.TabIndex = 23
        Me.LocalTrainphoto.TabStop = False
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(27, 379)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(592, 23)
        Me.pb.TabIndex = 22
        '
        'frmsplashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(652, 405)
        Me.Controls.Add(Me.lblPleasewait)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.LocalTrainphoto)
        Me.Controls.Add(Me.pb)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "frmsplashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash Screen"
        CType(Me.LocalTrainphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblPleasewait As System.Windows.Forms.Label
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents LocalTrainphoto As System.Windows.Forms.PictureBox
    Friend WithEvents pb As System.Windows.Forms.ProgressBar

End Class
