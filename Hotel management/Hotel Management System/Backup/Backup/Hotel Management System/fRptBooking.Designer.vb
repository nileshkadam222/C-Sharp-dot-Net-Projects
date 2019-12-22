<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRptBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fRptBooking))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPreview = New System.Windows.Forms.Button
        Me.DTto = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTFrom = New System.Windows.Forms.DateTimePicker
        Me.OptFrom = New System.Windows.Forms.RadioButton
        Me.OptToday = New System.Windows.Forms.RadioButton
        Me.txtToday = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.btnPreview.Location = New System.Drawing.Point(177, 121)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 41
        Me.btnPreview.Text = "    Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'DTto
        '
        Me.DTto.CustomFormat = "dd-MMM-yyyy"
        Me.DTto.Enabled = False
        Me.DTto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTto.Location = New System.Drawing.Point(338, 94)
        Me.DTto.Name = "DTto"
        Me.DTto.Size = New System.Drawing.Size(113, 22)
        Me.DTto.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "To"
        '
        'DTFrom
        '
        Me.DTFrom.CustomFormat = "dd-MMM-yyyy"
        Me.DTFrom.Enabled = False
        Me.DTFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFrom.Location = New System.Drawing.Point(177, 93)
        Me.DTFrom.Name = "DTFrom"
        Me.DTFrom.Size = New System.Drawing.Size(113, 22)
        Me.DTFrom.TabIndex = 45
        '
        'OptFrom
        '
        Me.OptFrom.AutoSize = True
        Me.OptFrom.BackColor = System.Drawing.Color.Transparent
        Me.OptFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFrom.Location = New System.Drawing.Point(42, 95)
        Me.OptFrom.Name = "OptFrom"
        Me.OptFrom.Size = New System.Drawing.Size(110, 20)
        Me.OptFrom.TabIndex = 44
        Me.OptFrom.TabStop = True
        Me.OptFrom.Text = "Booking From"
        Me.OptFrom.UseVisualStyleBackColor = False
        '
        'OptToday
        '
        Me.OptToday.AutoSize = True
        Me.OptToday.BackColor = System.Drawing.Color.Transparent
        Me.OptToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptToday.Location = New System.Drawing.Point(42, 51)
        Me.OptToday.Name = "OptToday"
        Me.OptToday.Size = New System.Drawing.Size(119, 20)
        Me.OptToday.TabIndex = 43
        Me.OptToday.TabStop = True
        Me.OptToday.Text = "Booking Today"
        Me.OptToday.UseVisualStyleBackColor = False
        '
        'txtToday
        '
        Me.txtToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToday.Location = New System.Drawing.Point(177, 49)
        Me.txtToday.Name = "txtToday"
        Me.txtToday.ReadOnly = True
        Me.txtToday.Size = New System.Drawing.Size(274, 22)
        Me.txtToday.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 151)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose One Option to Print Preview"
        '
        'fRptBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Management_System.My.Resources.Resources.BackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(479, 174)
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
        Me.Name = "fRptBooking"
        Me.Text = "Booking Preview"
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
End Class
