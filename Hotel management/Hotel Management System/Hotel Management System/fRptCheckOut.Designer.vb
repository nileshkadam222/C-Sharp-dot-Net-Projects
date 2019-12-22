<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRptCheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fRptCheckOut))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPreview = New System.Windows.Forms.Button
        Me.DTto = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTFrom = New System.Windows.Forms.DateTimePicker
        Me.OptFrom = New System.Windows.Forms.RadioButton
        Me.OptToday = New System.Windows.Forms.RadioButton
        Me.txtToday = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Close 2.ico")
        Me.ImageList1.Images.SetKeyName(1, "Report.ico")
        '
        'btnPreview
        '
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.ImageKey = "Report.ico"
        Me.btnPreview.ImageList = Me.ImageList1
        Me.btnPreview.Location = New System.Drawing.Point(181, 123)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 48
        Me.btnPreview.Text = "    Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'DTto
        '
        Me.DTto.CustomFormat = "dd-MMM-yyyy"
        Me.DTto.Enabled = False
        Me.DTto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTto.Location = New System.Drawing.Point(342, 96)
        Me.DTto.Name = "DTto"
        Me.DTto.Size = New System.Drawing.Size(113, 22)
        Me.DTto.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "To"
        '
        'DTFrom
        '
        Me.DTFrom.CustomFormat = "dd-MMM-yyyy"
        Me.DTFrom.Enabled = False
        Me.DTFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFrom.Location = New System.Drawing.Point(181, 95)
        Me.DTFrom.Name = "DTFrom"
        Me.DTFrom.Size = New System.Drawing.Size(113, 22)
        Me.DTFrom.TabIndex = 52
        '
        'OptFrom
        '
        Me.OptFrom.AutoSize = True
        Me.OptFrom.BackColor = System.Drawing.Color.Transparent
        Me.OptFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFrom.Location = New System.Drawing.Point(46, 97)
        Me.OptFrom.Name = "OptFrom"
        Me.OptFrom.Size = New System.Drawing.Size(121, 20)
        Me.OptFrom.TabIndex = 51
        Me.OptFrom.TabStop = True
        Me.OptFrom.Text = "Check Out From"
        Me.OptFrom.UseVisualStyleBackColor = False
        '
        'OptToday
        '
        Me.OptToday.AutoSize = True
        Me.OptToday.BackColor = System.Drawing.Color.Transparent
        Me.OptToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptToday.Location = New System.Drawing.Point(46, 53)
        Me.OptToday.Name = "OptToday"
        Me.OptToday.Size = New System.Drawing.Size(130, 20)
        Me.OptToday.TabIndex = 50
        Me.OptToday.TabStop = True
        Me.OptToday.Text = "Check Out Today"
        Me.OptToday.UseVisualStyleBackColor = False
        '
        'txtToday
        '
        Me.txtToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToday.Location = New System.Drawing.Point(181, 51)
        Me.txtToday.Name = "txtToday"
        Me.txtToday.ReadOnly = True
        Me.txtToday.Size = New System.Drawing.Size(274, 22)
        Me.txtToday.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 151)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose One Option to Print Preview"
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.ImageKey = "Close 2.ico"
        Me.btnClose.ImageList = Me.ImageList1
        Me.btnClose.Location = New System.Drawing.Point(329, 113)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(73, 23)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'fRptCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Management_System.My.Resources.Resources.BackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(483, 173)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.DTto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTFrom)
        Me.Controls.Add(Me.OptFrom)
        Me.Controls.Add(Me.OptToday)
        Me.Controls.Add(Me.txtToday)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fRptCheckOut"
        Me.Text = "Check Out Preview"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents DTto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents OptFrom As System.Windows.Forms.RadioButton
    Friend WithEvents OptToday As System.Windows.Forms.RadioButton
    Friend WithEvents txtToday As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
