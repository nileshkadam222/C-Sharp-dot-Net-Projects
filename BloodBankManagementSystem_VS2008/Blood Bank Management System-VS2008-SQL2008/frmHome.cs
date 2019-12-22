using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;


namespace Blood_Bank_Management_System
{
	public partial class frmHome
	{
		public frmHome()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmHome defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmHome Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmHome();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
		private void ShowNewForm(object sender, EventArgs e)
		{
			// Create a new instance of the child form.
			System.Windows.Forms.Form ChildForm = new System.Windows.Forms.Form();
			// Make it a child of this MDI form before showing it.
			ChildForm.MdiParent = this;
			
			m_ChildFormNumber++;
			ChildForm.Text = (string) ("Window " + m_ChildFormNumber);
			
			ChildForm.Show();
		}
		
		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog OpenFileDialog = new OpenFileDialog();
			OpenFileDialog.InitialDirectory = (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.SpecialDirectories.MyDocuments;
			OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (OpenFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				string FileName = OpenFileDialog.FileName;
				// TODO: Add code here to open the file.
			}
		}
		
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog SaveFileDialog = new SaveFileDialog();
			SaveFileDialog.InitialDirectory = (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.SpecialDirectories.MyDocuments;
			SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			
			if (SaveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				string FileName = SaveFileDialog.FileName;
				// TODO: Add code here to save the current contents of the form to a file.
			}
		}
		
		
		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Use My.Computer.Clipboard to insert the selected text or images into the clipboard
		}
		
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Use My.Computer.Clipboard to insert the selected text or images into the clipboard
		}
		
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
		}
		
		//Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		//    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
		//End Sub
		
		//Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		//    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
		//End Sub
		
		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		
		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		
		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		
		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
		}
		
		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Close all child forms of the parent.
			foreach (Form ChildForm in this.MdiChildren)
			{
				ChildForm.Close();
			}
		}
		
		private int m_ChildFormNumber;
		
		private void FileMenu_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void RecToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
		}
		
		public void DonorDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
			
			
			
		}
		
		public void PurchasesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
			
		}
		
		public void SalesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
			
		}
		
		public void frmHome_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void ReportsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmSearch.Default.ShowDialog();
			
		}
		
		public void ToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			
			
		}
		
		public void AddProductToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
            frmAddProduct f = new frmAddProduct();
            f.ShowDialog();
//			frmAddProduct.Default.ShowDialog();
		}
		
		public void AddDonorToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{

			frmDonor.Default.ShowDialog();
		}
		
		public void AddRecipientToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			//frmPatient.Default.ShowDialog();
            frmPatient f = new frmPatient();
            f.ShowDialog();
		}
		
		public void AddPurchasesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmPurchases.Default.ShowDialog();
		}
		
		public void AddSalesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			frmSales.Default.ShowDialog();
			
		}
		
		public void UpdateProductToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			frmUpdateProduct.Default.ShowDialog();
			
		}
		
		public void AddSalesToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			frmProductSales.Default.ShowDialog();
			
		}
		
		public void SalesToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			
			
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_Sales", "BloodSales");
			obj.ShowDialog();
			
			
		}
		
		public void ToolStripMenuItem3_Click(System.Object sender, System.EventArgs e)
		{
			
			
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_ProductSales", "ProductSales");
			obj.ShowDialog();
			
			
		}
		
		public void PurchasesToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_Purchases", "Purchase");
			obj.ShowDialog();
		}
		
		public void DonorsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_DonorDetails", "Donor");
			obj.ShowDialog();
		}
		
		public void RecipientsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_RecipientDetails", "Recipient");
			obj.ShowDialog();
		}
		
		public void LogoutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
	}
	
}
