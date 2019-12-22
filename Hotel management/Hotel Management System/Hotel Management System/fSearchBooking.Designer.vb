<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSearchBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSearchBooking))
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.MEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.MDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.MCheckIn = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.DTBooking = New System.Windows.Forms.DateTimePicker
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChkBooking = New System.Windows.Forms.CheckBox
        Me.ChkCustID = New System.Windows.Forms.CheckBox
        Me.txtCustID = New System.Windows.Forms.TextBox
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.lstBooking = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCheckIn = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Room No"
        Me.ColumnHeader11.Width = 80
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Floor"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Amount"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Room Type"
        Me.ColumnHeader10.Width = 110
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Booking Date"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Staying"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "CheckIn Date"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Total"
        Me.ColumnHeader14.Width = 100
        '
        'MEdit
        '
        Me.MEdit.Image = Global.Hotel_Management_System.My.Resources.Resources.edit
        Me.MEdit.Name = "MEdit"
        Me.MEdit.Size = New System.Drawing.Size(149, 22)
        Me.MEdit.Text = "Edit"
        '
        'MDelete
        '
        Me.MDelete.Image = Global.Hotel_Management_System.My.Resources.Resources.Delete
        Me.MDelete.Name = "MDelete"
        Me.MDelete.Size = New System.Drawing.Size(149, 22)
        Me.MDelete.Text = "Delete"
        '
        'MCheckIn
        '
        Me.MCheckIn.Image = Global.Hotel_Management_System.My.Resources.Resources.Customer1
        Me.MCheckIn.Name = "MCheckIn"
        Me.MCheckIn.Size = New System.Drawing.Size(149, 22)
        Me.MCheckIn.Text = "Check In"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MEdit, Me.MDelete, Me.MCheckIn})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(150, 70)
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Prepaid"
        Me.ColumnHeader15.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Remain"
        Me.ColumnHeader16.Width = 100
        '
        'DTBooking
        '
        Me.DTBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTBooking.Location = New System.Drawing.Point(179, 52)
        Me.DTBooking.Name = "DTBooking"
        Me.DTBooking.Size = New System.Drawing.Size(345, 22)
        Me.DTBooking.TabIndex = 14
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Save.ico")
        Me.ImageList1.Images.SetKeyName(1, "Delete.ico")
        Me.ImageList1.Images.SetKeyName(2, "Switch User.ico")
        Me.ImageList1.Images.SetKeyName(3, "search2.ico")
        Me.ImageList1.Images.SetKeyName(4, "edit.ico")
        Me.ImageList1.Images.SetKeyName(5, "cancel.ico")
        Me.ImageList1.Images.SetKeyName(6, "Close 2.ico")
        Me.ImageList1.Images.SetKeyName(7, "System Search.ico")
        Me.ImageList1.Images.SetKeyName(8, "Blondi1.ico")
        '
        'btnShowAll
        '
        Me.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowAll.ImageIndex = 8
        Me.btnShowAll.ImageList = Me.ImageList1
        Me.btnShowAll.Location = New System.Drawing.Point(96, 111)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 23)
        Me.btnShowAll.TabIndex = 21
        Me.btnShowAll.Text = "    Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 3
        Me.btnSearch.ImageList = Me.ImageList1
        Me.btnSearch.Location = New System.Drawing.Point(15, 111)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "   Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DTBooking)
        Me.GroupBox1.Controls.Add(Me.ChkBooking)
        Me.GroupBox1.Controls.Add(Me.ChkCustID)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 92)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Customer's Booking"
        '
        'ChkBooking
        '
        Me.ChkBooking.AutoSize = True
        Me.ChkBooking.BackColor = System.Drawing.Color.Transparent
        Me.ChkBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBooking.Location = New System.Drawing.Point(17, 53)
        Me.ChkBooking.Name = "ChkBooking"
        Me.ChkBooking.Size = New System.Drawing.Size(112, 21)
        Me.ChkBooking.TabIndex = 1
        Me.ChkBooking.Text = "Booking Date"
        Me.ChkBooking.UseVisualStyleBackColor = False
        '
        'ChkCustID
        '
        Me.ChkCustID.AutoSize = True
        Me.ChkCustID.BackColor = System.Drawing.Color.Transparent
        Me.ChkCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCustID.Location = New System.Drawing.Point(17, 25)
        Me.ChkCustID.Name = "ChkCustID"
        Me.ChkCustID.Size = New System.Drawing.Size(128, 21)
        Me.ChkCustID.TabIndex = 0
        Me.ChkCustID.Text = "Customer Name"
        Me.ChkCustID.UseVisualStyleBackColor = False
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(194, 38)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(345, 22)
        Me.txtCustID.TabIndex = 18
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 171
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Passport No"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Card No"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Gender"
        '
        'lstBooking
        '
        Me.lstBooking.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lstBooking.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBooking.FullRowSelect = True
        Me.lstBooking.GridLines = True
        Me.lstBooking.Location = New System.Drawing.Point(14, 140)
        Me.lstBooking.Name = "lstBooking"
        Me.lstBooking.Size = New System.Drawing.Size(531, 328)
        Me.lstBooking.SmallImageList = Me.ImageList2
        Me.lstBooking.TabIndex = 23
        Me.lstBooking.UseCompatibleStateImageBehavior = False
        Me.lstBooking.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cust ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cust Name"
        Me.ColumnHeader2.Width = 173
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Customer.ico")
        '
        'btnCheckIn
        '
        Me.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckIn.Location = New System.Drawing.Point(177, 111)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckIn.TabIndex = 27
        Me.btnCheckIn.Text = "    Check In"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.ImageKey = "edit.ico"
        Me.btnEdit.ImageList = Me.ImageList1
        Me.btnEdit.Location = New System.Drawing.Point(258, 111)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 86
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'fSearchBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Management_System.My.Resources.Resources.BackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 480)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.lstBooking)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fSearchBooking"
        Me.Text = "Book Searching"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MCheckIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTBooking As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkBooking As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCustID As System.Windows.Forms.CheckBox
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstBooking As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents btnCheckIn As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
