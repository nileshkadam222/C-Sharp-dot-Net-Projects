
Namespace Shared_Market_System
	Partial Class frmmaster
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.companyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.brokerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.brokerdetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.brokersharesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.clientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.clientdetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.updateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.clientsharesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.adminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.sharesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.updateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.shareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.updateToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.companyToolStripMenuItem, Me.brokerToolStripMenuItem, Me.clientToolStripMenuItem, Me.adminToolStripMenuItem, Me.exitToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(435, 24)
			Me.menuStrip1.TabIndex = 1
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' companyToolStripMenuItem
			' 
			Me.companyToolStripMenuItem.Name = "companyToolStripMenuItem"
			Me.companyToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
			Me.companyToolStripMenuItem.Text = "Company"
			Me.companyToolStripMenuItem.Click += New System.EventHandler(Me.companyToolStripMenuItem_Click)
			' 
			' brokerToolStripMenuItem
			' 
			Me.brokerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.brokerdetailsToolStripMenuItem, Me.brokersharesToolStripMenuItem})
			Me.brokerToolStripMenuItem.Name = "brokerToolStripMenuItem"
			Me.brokerToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
			Me.brokerToolStripMenuItem.Text = "Broker"
			Me.brokerToolStripMenuItem.Click += New System.EventHandler(Me.brokerToolStripMenuItem_Click)
			' 
			' brokerdetailsToolStripMenuItem
			' 
			Me.brokerdetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem2, Me.updateToolStripMenuItem2})
			Me.brokerdetailsToolStripMenuItem.Name = "brokerdetailsToolStripMenuItem"
			Me.brokerdetailsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.brokerdetailsToolStripMenuItem.Text = "Broker Details"
			Me.brokerdetailsToolStripMenuItem.Click += New System.EventHandler(Me.brokerdetailsToolStripMenuItem_Click)
			' 
			' brokersharesToolStripMenuItem
			' 
			Me.brokersharesToolStripMenuItem.Name = "brokersharesToolStripMenuItem"
			Me.brokersharesToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.brokersharesToolStripMenuItem.Text = "Broker Shares"
			Me.brokersharesToolStripMenuItem.Click += New System.EventHandler(Me.brokersharesToolStripMenuItem_Click)
			' 
			' clientToolStripMenuItem
			' 
			Me.clientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clientdetailsToolStripMenuItem, Me.clientsharesToolStripMenuItem})
			Me.clientToolStripMenuItem.Name = "clientToolStripMenuItem"
			Me.clientToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
			Me.clientToolStripMenuItem.Text = "Client"
			Me.clientToolStripMenuItem.Click += New System.EventHandler(Me.clientToolStripMenuItem_Click)
			' 
			' clientdetailsToolStripMenuItem
			' 
			Me.clientdetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem1, Me.updateToolStripMenuItem1})
			Me.clientdetailsToolStripMenuItem.Name = "clientdetailsToolStripMenuItem"
			Me.clientdetailsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
			Me.clientdetailsToolStripMenuItem.Text = "Client Details"
			Me.clientdetailsToolStripMenuItem.Click += New System.EventHandler(Me.clientdetailsToolStripMenuItem_Click)
			' 
			' newToolStripMenuItem1
			' 
			Me.newToolStripMenuItem1.Name = "newToolStripMenuItem1"
			Me.newToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
			Me.newToolStripMenuItem1.Text = "New"
			Me.newToolStripMenuItem1.Click += New System.EventHandler(Me.newToolStripMenuItem1_Click)
			' 
			' updateToolStripMenuItem1
			' 
			Me.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1"
			Me.updateToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
			Me.updateToolStripMenuItem1.Text = "Update"
			Me.updateToolStripMenuItem1.Click += New System.EventHandler(Me.updateToolStripMenuItem1_Click)
			' 
			' clientsharesToolStripMenuItem
			' 
			Me.clientsharesToolStripMenuItem.Name = "clientsharesToolStripMenuItem"
			Me.clientsharesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
			Me.clientsharesToolStripMenuItem.Text = "Client Shares"
			Me.clientsharesToolStripMenuItem.Click += New System.EventHandler(Me.clientsharesToolStripMenuItem_Click)
			' 
			' adminToolStripMenuItem
			' 
			Me.adminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sharesToolStripMenuItem, Me.shareToolStripMenuItem})
			Me.adminToolStripMenuItem.Name = "adminToolStripMenuItem"
			Me.adminToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
			Me.adminToolStripMenuItem.Text = "Admin"
			Me.adminToolStripMenuItem.Click += New System.EventHandler(Me.adminToolStripMenuItem_Click)
			' 
			' sharesToolStripMenuItem
			' 
			Me.sharesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.updateToolStripMenuItem})
			Me.sharesToolStripMenuItem.Name = "sharesToolStripMenuItem"
			Me.sharesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.sharesToolStripMenuItem.Text = "Admin Details"
			Me.sharesToolStripMenuItem.Click += New System.EventHandler(Me.sharesToolStripMenuItem_Click)
			' 
			' newToolStripMenuItem
			' 
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
			Me.newToolStripMenuItem.Text = "New "
			Me.newToolStripMenuItem.Click += New System.EventHandler(Me.newToolStripMenuItem_Click)
			' 
			' updateToolStripMenuItem
			' 
			Me.updateToolStripMenuItem.Name = "updateToolStripMenuItem"
			Me.updateToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
			Me.updateToolStripMenuItem.Text = "Update"
			Me.updateToolStripMenuItem.Click += New System.EventHandler(Me.updateToolStripMenuItem_Click)
			' 
			' shareToolStripMenuItem
			' 
			Me.shareToolStripMenuItem.Name = "shareToolStripMenuItem"
			Me.shareToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.shareToolStripMenuItem.Text = "Share Details"
			Me.shareToolStripMenuItem.Click += New System.EventHandler(Me.shareToolStripMenuItem_Click)
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
			Me.exitToolStripMenuItem.Text = "Exit"
			Me.exitToolStripMenuItem.Click += New System.EventHandler(Me.exitToolStripMenuItem_Click)
			' 
			' newToolStripMenuItem2
			' 
			Me.newToolStripMenuItem2.Name = "newToolStripMenuItem2"
			Me.newToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
			Me.newToolStripMenuItem2.Text = "New"
			Me.newToolStripMenuItem2.Click += New System.EventHandler(Me.newToolStripMenuItem2_Click)
			' 
			' updateToolStripMenuItem2
			' 
			Me.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2"
			Me.updateToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
			Me.updateToolStripMenuItem2.Text = "Update"
			Me.updateToolStripMenuItem2.Click += New System.EventHandler(Me.updateToolStripMenuItem2_Click)
			' 
			' frmmaster
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(435, 266)
			Me.Controls.Add(Me.menuStrip1)
			Me.IsMdiContainer = True
			Me.MainMenuStrip = Me.menuStrip1
			Me.Name = "frmmaster"
			Me.Text = "Master"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
			Me.Load += New System.EventHandler(Me.frmmaster_Load)
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private companyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private brokerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private clientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private adminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private sharesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private shareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private clientdetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private clientsharesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private brokerdetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private brokersharesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private updateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private newToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private updateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private newToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private updateToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
