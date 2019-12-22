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


namespace ComputerManagmentSystem
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
			// Close all chi ld forms of the parent.
			foreach (Form ChildForm in this.MdiChildren)
			{
				ChildForm.Close();
			}
		}
		
		private int m_ChildFormNumber;
		
		public void frmHome_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void AddStudentToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
		}
		
		public void AddFacultyToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
		}
		
		public void FeesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
		}
		
		public void AddCourseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			
			
			
		}
		
		public void ReportsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
            frmSearch f = new frmSearch();
            f.ShowDialog();
			
		}
		
		public void FessDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_Fee", "Fees");
			obj.ShowDialog();
		}
		
		public void StudentDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_Student", "Student");
			obj.ShowDialog();
		}
		
		public void FacultyDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_Staff", "Faculty");
			obj.ShowDialog();
		}
		
		public void CourseDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_Course", "Course");
			obj.ShowDialog();
		}
		
		public void ToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void PurchasesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
            frmPurchases f = new frmPurchases();
            f.Show();
			
		}
		
		public void UpdatePurchasesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
            frmUpdatePurchases f = new frmUpdatePurchases();
            f.ShowDialog();
			
		}
		
		public void AddCourseToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
            addCourse f = new addCourse();
            f.ShowDialog();
		}
		
		public void AddFeesDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
            FeesTranscation f = new FeesTranscation();
            f.ShowDialog();
		}
		
		public void AddStudentToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
            StudentDetails f = new StudentDetails();
            f.ShowDialog();
		}
		
		public void AddFacultyToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
            StaffDetail f = new StaffDetail();
            f.ShowDialog();
		}
		
		public void PurchaseDetailsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmViewReport obj = new frmViewReport();
			obj.View_Report("select * from tbl_Purchases", "Purchase");
			obj.ShowDialog();
		}
		
		public void LogoutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
	}
	
}
