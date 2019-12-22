<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ChkCustName = New System.Windows.Forms.CheckBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.txtCustName = New System.Windows.Forms.TextBox
        Me.txtCustID = New System.Windows.Forms.TextBox
        Me.ChkCustID = New System.Windows.Forms.CheckBox
        Me.ChkCountry = New System.Windows.Forms.CheckBox
        Me.ChkPassNo = New System.Windows.Forms.CheckBox
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.LstCustomer = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtPassNo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address"
        Me.ColumnHeader5.Width = 153
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "City"
        Me.ColumnHeader6.Width = 89
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "State"
        Me.ColumnHeader7.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cust Name"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Gender"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DOB"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Card No"
        Me.ColumnHeader11.Width = 100
        '
        'ChkCustName
        '
        Me.ChkCustName.AutoSize = True
        Me.ChkCustName.BackColor = System.Drawing.Color.Transparent
        Me.ChkCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCustName.Location = New System.Drawing.Point(17, 53)
        Me.ChkCustName.Name = "ChkCustName"
        Me.ChkCustName.Size = New System.Drawing.Size(128, 21)
        Me.ChkCustName.TabIndex = 1
        Me.ChkCustName.Text = "Customer Name"
        Me.ChkCustName.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelect.ImageKey = "My Cursors XP.ico"
        Me.btnSelect.ImageList = Me.ImageList1
        Me.btnSelect.Location = New System.Drawing.Point(93, 161)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 33
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "search2.ico")
        Me.ImageList1.Images.SetKeyName(1, "edit.ico")
        Me.ImageList1.Images.SetKeyName(2, "My Cursors XP.ico")
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Country"
        Me.ColumnHeader8.Width = 85
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nationality"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Passport No"
        Me.ColumnHeader10.Width = 100
        '
        'txtCustName
        '
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(191, 65)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(345, 22)
        Me.txtCustName.TabIndex = 27
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(191, 37)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(345, 22)
        Me.txtCustID.TabIndex = 26
        '
        'ChkCustID
        '
        Me.ChkCustID.AutoSize = True
        Me.ChkCustID.BackColor = System.Drawing.Color.Transparent
        Me.ChkCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCustID.Location = New System.Drawing.Point(17, 25)
        Me.ChkCustID.Name = "ChkCustID"
        Me.ChkCustID.Size = New System.Drawing.Size(104, 21)
        Me.ChkCustID.TabIndex = 0
        Me.ChkCustID.Text = "Customer ID"
        Me.ChkCustID.UseVisualStyleBackColor = False
        '
        'ChkCountry
        '
        Me.ChkCountry.AutoSize = True
        Me.ChkCountry.BackColor = System.Drawing.Color.Transparent
        Me.ChkCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCountry.Location = New System.Drawing.Point(17, 81)
        Me.ChkCountry.Name = "ChkCountry"
        Me.ChkCountry.Size = New System.Drawing.Size(76, 21)
        Me.ChkCountry.TabIndex = 3
        Me.ChkCountry.Text = "Country"
        Me.ChkCountry.UseVisualStyleBackColor = False
        '
        'ChkPassNo
        '
        Me.ChkPassNo.AutoSize = True
        Me.ChkPassNo.BackColor = System.Drawing.Color.Transparent
        Me.ChkPassNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPassNo.Location = New System.Drawing.Point(17, 109)
        Me.ChkPassNo.Name = "ChkPassNo"
        Me.ChkPassNo.Size = New System.Drawing.Size(105, 21)
        Me.ChkPassNo.TabIndex = 5
        Me.ChkPassNo.Text = "Passport No"
        Me.ChkPassNo.UseVisualStyleBackColor = False
        '
        'txtCountry
        '
        Me.txtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(191, 93)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(345, 22)
        Me.txtCountry.TabIndex = 28
        '
        'btnSearch
        '
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageKey = "search2.ico"
        Me.btnSearch.ImageList = Me.ImageList1
        Me.btnSearch.Location = New System.Drawing.Point(12, 161)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'LstCustomer
        '
        Me.LstCustomer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.LstCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstCustomer.FullRowSelect = True
        Me.LstCustomer.GridLines = True
        Me.LstCustomer.Location = New System.Drawing.Point(12, 190)
        Me.LstCustomer.MultiSelect = False
        Me.LstCustomer.Name = "LstCustomer"
        Me.LstCustomer.Size = New System.Drawing.Size(530, 237)
        Me.LstCustomer.SmallImageList = Me.ImageList2
        Me.LstCustomer.TabIndex = 32
        Me.LstCustomer.UseCompatibleStateImageBehavior = False
        Me.LstCustomer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cust ID"
        Me.ColumnHeader1.Width = 100
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Customer.ico")
        '
        'txtPassNo
        '
        Me.txtPassNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassNo.Location = New System.Drawing.Point(191, 121)
        Me.txtPassNo.Name = "txtPassNo"
        Me.txtPassNo.Size = New System.Drawing.Size(345, 22)
        Me.txtPassNo.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChkCustName)
        Me.GroupBox1.Controls.Add(Me.ChkCustID)
        Me.GroupBox1.Controls.Add(Me.ChkCountry)
        Me.GroupBox1.Controls.Add(Me.ChkPassNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 143)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Customer"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hotel_Management_System.My.Resources.Resources.BackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 439)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.LstCustomer)
        Me.Controls.Add(Me.txtPassNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Search Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkCustName As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents ChkCustID As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCountry As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPassNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents LstCustomer As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPassNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
End Class
