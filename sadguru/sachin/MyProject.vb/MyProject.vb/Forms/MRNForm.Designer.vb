<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRNForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtquetotal = New System.Windows.Forms.TextBox
        Me.txtqureject = New System.Windows.Forms.TextBox
        Me.txtmrnquntrec = New System.Windows.Forms.TextBox
        Me.dtpmrn = New System.Windows.Forms.DateTimePicker
        Me.txtmrnpname = New System.Windows.Forms.TextBox
        Me.txtmrnpid = New System.Windows.Forms.TextBox
        Me.txtmssupp = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btndel = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnadd = New System.Windows.Forms.Button
        Me.dgvpat = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbmrnid = New System.Windows.Forms.ComboBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        CType(Me.dgvpat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MRN Information"
        '
        'txtquetotal
        '
        Me.txtquetotal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquetotal.Location = New System.Drawing.Point(595, 311)
        Me.txtquetotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtquetotal.Name = "txtquetotal"
        Me.txtquetotal.Size = New System.Drawing.Size(143, 25)
        Me.txtquetotal.TabIndex = 19
        '
        'txtqureject
        '
        Me.txtqureject.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqureject.Location = New System.Drawing.Point(595, 253)
        Me.txtqureject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtqureject.Name = "txtqureject"
        Me.txtqureject.Size = New System.Drawing.Size(143, 25)
        Me.txtqureject.TabIndex = 18
        '
        'txtmrnquntrec
        '
        Me.txtmrnquntrec.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmrnquntrec.Location = New System.Drawing.Point(595, 207)
        Me.txtmrnquntrec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmrnquntrec.Name = "txtmrnquntrec"
        Me.txtmrnquntrec.Size = New System.Drawing.Size(143, 25)
        Me.txtmrnquntrec.TabIndex = 17
        '
        'dtpmrn
        '
        Me.dtpmrn.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpmrn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpmrn.Location = New System.Drawing.Point(595, 167)
        Me.dtpmrn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpmrn.Name = "dtpmrn"
        Me.dtpmrn.Size = New System.Drawing.Size(143, 25)
        Me.dtpmrn.TabIndex = 16
        '
        'txtmrnpname
        '
        Me.txtmrnpname.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmrnpname.Location = New System.Drawing.Point(254, 320)
        Me.txtmrnpname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmrnpname.Name = "txtmrnpname"
        Me.txtmrnpname.Size = New System.Drawing.Size(143, 25)
        Me.txtmrnpname.TabIndex = 11
        '
        'txtmrnpid
        '
        Me.txtmrnpid.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmrnpid.Location = New System.Drawing.Point(254, 268)
        Me.txtmrnpid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmrnpid.Name = "txtmrnpid"
        Me.txtmrnpid.Size = New System.Drawing.Size(143, 25)
        Me.txtmrnpid.TabIndex = 10
        '
        'txtmssupp
        '
        Me.txtmssupp.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmssupp.Location = New System.Drawing.Point(254, 219)
        Me.txtmssupp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmssupp.Name = "txtmssupp"
        Me.txtmssupp.Size = New System.Drawing.Size(143, 25)
        Me.txtmssupp.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(432, 317)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(432, 259)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Quantity Reject"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(432, 210)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Quantity Received"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(114, 328)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Product Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 276)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Product ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 227)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "M/S Suppliers"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 173)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "MRN Number"
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Location = New System.Drawing.Point(455, 498)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(109, 35)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Image = Global.WindowsApplication1.My.Resources.Resources.delete_icon
        Me.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndel.Location = New System.Drawing.Point(324, 498)
        Me.btndel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(110, 35)
        Me.btndel.TabIndex = 2
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pencil_icon
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnupdate.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(205, 498)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(111, 35)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_list_add_icon
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(100, 497)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(97, 36)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'dgvpat
        '
        Me.dgvpat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpat.Location = New System.Drawing.Point(91, 376)
        Me.dgvpat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvpat.Name = "dgvpat"
        Me.dgvpat.Size = New System.Drawing.Size(742, 110)
        Me.dgvpat.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(222, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SHREE SADGURU ENTERPRIZES"
        '
        'cmbmrnid
        '
        Me.cmbmrnid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmrnid.FormattingEnabled = True
        Me.cmbmrnid.Location = New System.Drawing.Point(254, 174)
        Me.cmbmrnid.Name = "cmbmrnid"
        Me.cmbmrnid.Size = New System.Drawing.Size(143, 28)
        Me.cmbmrnid.TabIndex = 20
        '
        'btnsearch
        '
        Me.btnsearch.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Search_icon1
        Me.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsearch.Location = New System.Drawing.Point(701, 499)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(96, 34)
        Me.btnsearch.TabIndex = 21
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.login_icon
        Me.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclear.Location = New System.Drawing.Point(581, 499)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(101, 34)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'MRNForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.red_line_background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(901, 618)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.cmbmrnid)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.txtquetotal)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtqureject)
        Me.Controls.Add(Me.dgvpat)
        Me.Controls.Add(Me.txtmrnquntrec)
        Me.Controls.Add(Me.dtpmrn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtmrnpname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmrnpid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmssupp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MRNForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MRNForm1"
        CType(Me.dgvpat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtmrnpname As System.Windows.Forms.TextBox
    Friend WithEvents txtmrnpid As System.Windows.Forms.TextBox
    Friend WithEvents txtmssupp As System.Windows.Forms.TextBox
    Friend WithEvents txtquetotal As System.Windows.Forms.TextBox
    Friend WithEvents txtqureject As System.Windows.Forms.TextBox
    Friend WithEvents txtmrnquntrec As System.Windows.Forms.TextBox
    Friend WithEvents dtpmrn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvpat As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbmrnid As System.Windows.Forms.ComboBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
