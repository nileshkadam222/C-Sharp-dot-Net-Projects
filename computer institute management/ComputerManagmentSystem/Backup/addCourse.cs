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
using System.Data.SqlClient;



namespace ComputerManagmentSystem
{
	public partial class addCourse
	{
		public addCourse()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
            //if (defaultInstance == null)
            //    defaultInstance = this;
        }

        //#region Default Instance

        //private static addCourse defaultInstance;
		
        ///// <summary>
        ///// Added by the VB.Net to C# Converter to support default instance behavour in C#
        ///// </summary>
        //public static addCourse Default
        //{
        //    get
        //    {
        //        if (defaultInstance == null)
        //        {
        //            defaultInstance = new addCourse();
        //            defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
        //        }
				
        //        return defaultInstance;
        //    }
        //}
		
//        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            defaultInstance = null;
//        }
		
//#endregion
		SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=True;database=db_CIMS");
		public void loadCourse()
		{
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select COURSE_NAME from tbl_Course", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboCourse.Items.Add(rd[0]);
				
			}
			con.Close();
			
			
		}
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			string s = "update tbl_Course set COURSE_NAME=\'" + txtCourseName.Text + "\',COURSE_DURATION=\'" + txtDuration.Text + "\',COURSE_FEES=\'" + txtFees.Text + "\',COURSE_BATCHTIMING=\'" + txtBatchTiming.Text + "\',COURSE_FACULTY=\'" + cboFaculty.Text + "\' where COURSE_No=\'" + txtCourseNo.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			MessageBox.Show("Record Updated");
			con.Close();
			this.Close();
			
			
			
		}
		
		public void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			string s = "delete from tbl_Course where COURSE_No=\'" + txtCourseNo.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s, con);
			cmd2.ExecuteNonQuery();
			//Else
			MessageBox.Show("Record Deleted");
			this.Close();
			
			con.Close();
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void btnSearchUpdate_Click(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = true;
			btnUpdate.Visible = true;
			btnDelete.Visible = true;
			btnSave.Visible = false;
			btnClear.Visible = false;
			pnlCourse.Visible = false;
			
		}
		
		public void addCourse_Load(System.Object sender, System.EventArgs e)
		{
			
			
			
			loadCourse();
			btnUpdate.Visible = false;
			btnDelete.Visible = false;
			pnlSearch.Visible = false;
			
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [ID]=COURSE_No,[Name]=COURSE_NAME,[Fees]=COURSE_FEES,[Timing]=COURSE_BATCHTIMING from tbl_Course", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			
			increment();
			
			
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select Staff_NAME from tbl_Staff", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboFaculty.Items.Add(rd[0]);
				
			}
			con.Close();
			
			
			
			
			
		}
		public void clear()
		{
			
			txtCourseName.Clear();
			txtDuration.Clear();
			txtFees.Clear();
			cboFaculty.ResetText();
			
			txtBatchTiming.Clear();
			
		}
		
		public void increment()
		{
			
			int id1 = 0;
			con.Close();
			
			con.Open();
			
			SqlCommand cmd = new SqlCommand("select COURSE_No from tbl_Course", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				id1 =  (int.Parse(rd[0].ToString()));
			}
			con.Close();
			id1++;
			txtCourseNo.Text = id1.ToString();
			con.Close();
			
		}
		
		
		public void cboCourse_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			dgvSearch.Columns.Clear();
			
			con.Open();
			
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [ID]=COURSE_No,[Name]=COURSE_NAME,[Fees]=COURSE_FEES,[Timing]=COURSE_BATCHTIMING from tbl_Course where COURSE_NAME=\'" + cboCourse.Text + "\'", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			con.Close();
			
		}
		
		public void dgvSearch_CellMouseDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			pnlCourse.Visible = true;
			con.Open();
			
			string str = dgvSearch.CurrentRow.Cells["ID"].Value.ToString();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_Course where COURSE_No=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				txtCourseNo.Text = (string) (rd["COURSE_No"].ToString());
				txtCourseName.Text = (string) (rd["COURSE_NAME"].ToString());
				txtDuration.Text = (string) (rd["COURSE_DURATION"].ToString());
				txtFees.Text = (string) (rd["COURSE_FEES"].ToString());
				txtBatchTiming.Text = (string) (rd["COURSE_BATCHTIMING"].ToString());
				cboFaculty.SelectedText = (string) (rd["COURSE_FACULTY"].ToString());
				
				
				
			}
			rd.Close();
			con.Close();
			
			
			
			pnlSearch.Visible = false;
			pnlCourse.Visible = true;
		}
		
		public void btnSave_Click(System.Object sender, System.EventArgs e)
		{
			if (txtCourseName.Text == "" || txtFees.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_Course(COURSE_No,COURSE_NAME,COURSE_DURATION,COURSE_FEES,COURSE_BATCHTIMING,COURSE_FACULTY) values(\'" + txtCourseNo.Text + "\',\'" + txtCourseName.Text + "\',\'" + txtDuration.Text + "\',\'" + txtFees.Text + "\',\'" + txtBatchTiming.Text + "\',\'" + cboFaculty.Text + "\')";
				
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				MessageBox.Show("Record Inserted");
				clear();
				
				increment();
				
				
			}
		}
		
		public void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			clear();
			
		}
		
		public void btnClose1_Click(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = false;
			pnlCourse.Visible = true;
		}
		
		public void txtFees_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 48) || (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 57))
			{
				e.Handled = true;
			}
			if (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) == 8)
			{
				e.Handled = false;
			}
		}
	}
}
