<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDIParent
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDIParent))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.mnufile = New System.Windows.Forms.ToolStripMenuItem
        Me.Mnusellingprice = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuaddnewingredient = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuaddpackagingmaterial = New System.Windows.Forms.ToolStripMenuItem
        Me.mnustockroominventory = New System.Windows.Forms.ToolStripMenuItem
        Me.mnustoreinventory = New System.Windows.Forms.ToolStripMenuItem
        Me.mnutransaction = New System.Windows.Forms.ToolStripMenuItem
        Me.mnusoldproduct = New System.Windows.Forms.ToolStripMenuItem
        Me.mnucustomer = New System.Windows.Forms.ToolStripMenuItem
        Me.mnucustomerdetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnubill = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuemployee = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuemployeedetails = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuemployeelogin = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuemployeepay = New System.Windows.Forms.ToolStripMenuItem
        Me.mnusupplier = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnureport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnusecurity = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuchangepassword = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuutility = New System.Windows.Forms.ToolStripMenuItem
        Me.mnucalculator = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuinternetexplorer = New System.Windows.Forms.ToolStripMenuItem
        Me.mnunotepad = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuexit = New System.Windows.Forms.ToolStripMenuItem
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnufile, Me.mnutransaction, Me.mnucustomer, Me.mnuemployee, Me.mnusupplier, Me.mnureport, Me.mnusecurity, Me.mnuutility, Me.ToolStripMenuItem1, Me.mnuexit})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnufile
        '
        Me.mnufile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnusellingprice, Me.mnuaddnewingredient, Me.mnuaddpackagingmaterial, Me.mnustockroominventory, Me.mnustoreinventory})
        Me.mnufile.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnufile.Name = "mnufile"
        Me.mnufile.Size = New System.Drawing.Size(41, 20)
        Me.mnufile.Text = "File"
        '
        'Mnusellingprice
        '
        Me.Mnusellingprice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductPriceToolStripMenuItem, Me.IndividualToolStripMenuItem})
        Me.Mnusellingprice.Name = "Mnusellingprice"
        Me.Mnusellingprice.Size = New System.Drawing.Size(226, 22)
        Me.Mnusellingprice.Text = "Selling Price"
        '
        'ProductPriceToolStripMenuItem
        '
        Me.ProductPriceToolStripMenuItem.Name = "ProductPriceToolStripMenuItem"
        Me.ProductPriceToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ProductPriceToolStripMenuItem.Text = "Product Group Price"
        '
        'IndividualToolStripMenuItem
        '
        Me.IndividualToolStripMenuItem.Name = "IndividualToolStripMenuItem"
        Me.IndividualToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.IndividualToolStripMenuItem.Text = "Individual Item Price"
        '
        'mnuaddnewingredient
        '
        Me.mnuaddnewingredient.Name = "mnuaddnewingredient"
        Me.mnuaddnewingredient.Size = New System.Drawing.Size(226, 22)
        Me.mnuaddnewingredient.Text = "Add New Ingredient"
        '
        'mnuaddpackagingmaterial
        '
        Me.mnuaddpackagingmaterial.Name = "mnuaddpackagingmaterial"
        Me.mnuaddpackagingmaterial.Size = New System.Drawing.Size(226, 22)
        Me.mnuaddpackagingmaterial.Text = "Add Packaging Material"
        '
        'mnustockroominventory
        '
        Me.mnustockroominventory.Name = "mnustockroominventory"
        Me.mnustockroominventory.Size = New System.Drawing.Size(226, 22)
        Me.mnustockroominventory.Text = "Stock Room Inventory"
        '
        'mnustoreinventory
        '
        Me.mnustoreinventory.Name = "mnustoreinventory"
        Me.mnustoreinventory.Size = New System.Drawing.Size(226, 22)
        '
        'mnutransaction
        '
        Me.mnutransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusoldproduct})
        Me.mnutransaction.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnutransaction.Name = "mnutransaction"
        Me.mnutransaction.Size = New System.Drawing.Size(91, 20)
        Me.mnutransaction.Text = "Transaction"
        '
        'mnusoldproduct
        '
        Me.mnusoldproduct.Name = "mnusoldproduct"
        Me.mnusoldproduct.Size = New System.Drawing.Size(160, 22)
        Me.mnusoldproduct.Text = "Sold Product"
        '
        'mnucustomer
        '
        Me.mnucustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnucustomerdetails, Me.ToolStripMenuItem2, Me.mnubill})
        Me.mnucustomer.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnucustomer.Name = "mnucustomer"
        Me.mnucustomer.Size = New System.Drawing.Size(80, 20)
        Me.mnucustomer.Text = "Customer "
        '
        'mnucustomerdetails
        '
        Me.mnucustomerdetails.Name = "mnucustomerdetails"
        Me.mnucustomerdetails.Size = New System.Drawing.Size(218, 22)
        Me.mnucustomerdetails.Text = "Customer Details"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(218, 22)
        Me.ToolStripMenuItem2.Text = "Customer Purchassing"
        '
        'mnubill
        '
        Me.mnubill.Name = "mnubill"
        Me.mnubill.Size = New System.Drawing.Size(218, 22)
        Me.mnubill.Text = "Bill"
        '
        'mnuemployee
        '
        Me.mnuemployee.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuemployeedetails, Me.mnuemployeelogin, Me.mnuemployeepay})
        Me.mnuemployee.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuemployee.Name = "mnuemployee"
        Me.mnuemployee.Size = New System.Drawing.Size(79, 20)
        Me.mnuemployee.Text = "Employee"
        '
        'mnuemployeedetails
        '
        Me.mnuemployeedetails.Name = "mnuemployeedetails"
        Me.mnuemployeedetails.Size = New System.Drawing.Size(200, 22)
        Me.mnuemployeedetails.Text = "Employee Details"
        '
        'mnuemployeelogin
        '
        Me.mnuemployeelogin.Name = "mnuemployeelogin"
        Me.mnuemployeelogin.Size = New System.Drawing.Size(200, 22)
        Me.mnuemployeelogin.Text = "Employee Login"
        '
        'mnuemployeepay
        '
        Me.mnuemployeepay.Name = "mnuemployeepay"
        Me.mnuemployeepay.Size = New System.Drawing.Size(200, 22)
        Me.mnuemployeepay.Text = "Employee Payment"
        '
        'mnusupplier
        '
        Me.mnusupplier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierDetailsToolStripMenuItem})
        Me.mnusupplier.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnusupplier.Name = "mnusupplier"
        Me.mnusupplier.Size = New System.Drawing.Size(71, 20)
        Me.mnusupplier.Text = "Supplier"
        '
        'SupplierDetailsToolStripMenuItem
        '
        Me.SupplierDetailsToolStripMenuItem.Name = "SupplierDetailsToolStripMenuItem"
        Me.SupplierDetailsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SupplierDetailsToolStripMenuItem.Text = "Supplier Details"
        '
        'mnureport
        '
        Me.mnureport.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnureport.Name = "mnureport"
        Me.mnureport.Size = New System.Drawing.Size(61, 20)
        Me.mnureport.Text = "Report"
        '
        'mnusecurity
        '
        Me.mnusecurity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuchangepassword})
        Me.mnusecurity.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnusecurity.Name = "mnusecurity"
        Me.mnusecurity.Size = New System.Drawing.Size(69, 20)
        Me.mnusecurity.Text = "Security"
        '
        'mnuchangepassword
        '
        Me.mnuchangepassword.Name = "mnuchangepassword"
        Me.mnuchangepassword.Size = New System.Drawing.Size(188, 22)
        Me.mnuchangepassword.Text = "Change Password"
        '
        'mnuutility
        '
        Me.mnuutility.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnucalculator, Me.mnuinternetexplorer, Me.mnunotepad})
        Me.mnuutility.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuutility.Name = "mnuutility"
        Me.mnuutility.Size = New System.Drawing.Size(57, 20)
        Me.mnuutility.Text = "Utility"
        '
        'mnucalculator
        '
        Me.mnucalculator.Name = "mnucalculator"
        Me.mnucalculator.Size = New System.Drawing.Size(190, 22)
        Me.mnucalculator.Text = "Calculator"
        '
        'mnuinternetexplorer
        '
        Me.mnuinternetexplorer.Name = "mnuinternetexplorer"
        Me.mnuinternetexplorer.Size = New System.Drawing.Size(190, 22)
        Me.mnuinternetexplorer.Text = "Internet Explorer"
        '
        'mnunotepad
        '
        Me.mnunotepad.Name = "mnunotepad"
        Me.mnunotepad.Size = New System.Drawing.Size(190, 22)
        Me.mnunotepad.Text = "Notepad"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'mnuexit
        '
        Me.mnuexit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.mnuexit.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuexit.Name = "mnuexit"
        Me.mnuexit.Size = New System.Drawing.Size(43, 20)
        Me.mnuexit.Text = "Exit"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(632, 401)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmMDIParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMDIParent"
        Me.Text = "frmMDIParent"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnufile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnusellingprice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnutransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnucustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuemployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnureport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnusecurity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuutility As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductPriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndividualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuaddnewingredient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuaddpackagingmaterial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnustockroominventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnustoreinventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnusoldproduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnucustomerdetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuemployeedetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuchangepassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnucalculator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuinternetexplorer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnunotepad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnubill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuemployeelogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuemployeepay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnusupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SupplierDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
