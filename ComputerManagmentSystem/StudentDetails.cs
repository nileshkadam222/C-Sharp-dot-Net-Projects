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
	public partial class StudentDetails
	{
		public StudentDetails()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static StudentDetails defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static StudentDetails Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new StudentDetails();
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
		SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=D:\\READY PROJECTS\\COMPUTERMANAGMENTSYSTEM\\DB_CIMS.MDF;Integrated Security=True");
		
		
		public void GroupBox1_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void Label3_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void GroupBox2_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
		public void clear()
		{
			
			txtRollNo.Clear();
			dtpDate.ResetText();
			txtStudentName.Clear();
			dtpDob.ResetText();
			cboCourseName.ResetText();
			cboGender.ResetText();
			txtEmail.Clear();
			txtPhoneNo.Clear();
			txtTotalfee.Clear();
			txtAddress.Clear();
			
			txtFee.Clear();
			txtDicountAmount.Clear();
			txtDiscountPercentage.Clear();
			txtTotalfee.Clear();
			
			txtAmountPaid.Clear();
			txtReceiptNo.Clear();
			
			cboPaymentMode.ResetText();
			txtNameOfBank.Clear();
			txtChequeNo.Clear();
			
			txtFatherName.Clear();
			txtMotherName.Clear();
			txtHusbandName.Clear();
			cboQualification.ResetText();
			cboOccupation.ResetText();
			txtKnowledge.Clear();
			
		}
		public void loadStudent()
		{
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select Student_NAME from tbl_Student", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboStudent.Items.Add(rd[0]);
				
			}
			con.Close();
			
			
		}
		
		
		
		public void StudentDetails_Load(System.Object sender, System.EventArgs e)
		{
			txtNameOfBank.Enabled = false;
			txtChequeNo.Enabled = false;
			
			
			loadStudent();
			
			btnUpdate.Visible = false;
			btnDelete.Visible = false;
			pnlSearch.Visible = false;
			
			
			SqlDataAdapter adapter = new SqlDataAdapter("select [Roll Number]=Student_ROLLNO,[Name]=Student_NAME,[Address]=Student_ADDRESS,[Contact Number]=Student_PHONE from tbl_Student", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			
			
			
			
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select COURSE_NAME from tbl_Course", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				cboCourseName.Items.Add(rd[0]);
				
			}
			con.Close();
			
		}
		
		public void btnNextScreen_Click(System.Object sender, System.EventArgs e)
		{
			
			
			TabControl1.SelectedTab = TabPage2;
			
			
			
			
		}
		
		public void btnPreviousScreen_Click(System.Object sender, System.EventArgs e)
		{
			
			TabControl1.SelectedTab = TabPage1;
			
			
		}
		
		public void btnNextScreen2_Click(System.Object sender, System.EventArgs e)
		{
			
			TabControl1.SelectedTab = TabPage3;
			
		}
		
		public void btnPreviousScreen3_Click(System.Object sender, System.EventArgs e)
		{
			
			TabControl1.SelectedTab = TabPage2;
			
		}
		
		public void btnClear_Click(System.Object sender, System.EventArgs e)
		{
			txtRollNo.Clear();
			dtpDate.ResetText();
			txtStudentName.Clear();
			dtpDob.ResetText();
			cboCourseName.ResetText();
			cboGender.ResetText();
			txtEmail.Clear();
			txtPhoneNo.Clear();
			txtTotalfee.Clear();
			txtAddress.Clear();
			
		}
		
		public void btnClear2_Click(System.Object sender, System.EventArgs e)
		{
			
			txtFee.Clear();
			txtDicountAmount.Clear();
			txtDiscountPercentage.Clear();
			txtTotalfee.Clear();
			
			txtAmountPaid.Clear();
			txtReceiptNo.Clear();
			
			cboPaymentMode.ResetText();
			txtNameOfBank.Clear();
			txtChequeNo.Clear();
			
			
			
			
		}
		
		public void BtnClear3_Click(System.Object sender, System.EventArgs e)
		{
			txtFatherName.Clear();
			txtMotherName.Clear();
			txtHusbandName.Clear();
			cboQualification.ResetText();
			cboOccupation.ResetText();
			txtKnowledge.Clear();
			
		}
		
		public void btnSave1_Click(System.Object sender, System.EventArgs e)
		{
			
			
			if (txtRollNo.Text == "" || cboPaymentMode.Text == "")
			{
				
				Interaction.MsgBox("Details are Incomplete", MsgBoxStyle.Exclamation, null);
				
			}
			else
			{
				
				con.Open();
				string s = "Insert into tbl_Student(Student_ROLLNO,Student_NAME,Student_FNAME,Student_MNAME,Student_HNAME,Student_ADDRESS,Student_PHONE,Student_QUALIFICATION,Student_GENDER,Student_DOB,Student_EMAIL,Student_OCCUPATION,Student_CNAME,Student_KNOWLEDGE,Student_TOTALFEES) values(\'" + txtRollNo.Text + "\',\'" + txtStudentName.Text + "\',\'" + txtFatherName.Text + "\',\'" + txtMotherName.Text + "\',\'" + txtHusbandName.Text + "\',\'" + txtAddress.Text + "\',\'" + txtPhoneNo.Text + "\',\'" + cboQualification.Text + "\',\'" + cboGender.Text + "\',\'" + dtpDob.Value.ToString() + "\',\'" + txtEmail.Text + "\',\'" + cboOccupation.Text + "\',\'" + cboCourseName.Text + "\',\'" + txtKnowledge.Text + "\',\'" + txtAmountPaid.Text + "\')";
				
				SqlCommand cmd1 = new SqlCommand(s, con);
				cmd1.ExecuteNonQuery();
				
				
				con.Close();
				
				
				con.Open();
				string s1 = "Insert into tbl_Fee(Fee_ROLLNO,Fee_RECEIPTNO,Fee_Date,Fee_BasicFees,Fee_DiscountPercentage,Fee_DiscountAmount,Fee_TotalFees,Fee_AMOUNT,Fee_ModeOfPayment,Fee_BANKNAME,Fee_CHEQUENO) values(\'" + txtRollNo.Text + "\',\'" + txtReceiptNo.Text + "\',\'" + dtpDate.Value.ToString() + "\',\'" + txtFee.Text + "\',\'" + txtDiscountPercentage.Text + "\',\'" + txtDicountAmount.Text + "\',\'" + txtTotalfee.Text + "\',\'" + txtAmountPaid.Text + "\',\'" + cboPaymentMode.Text + "\',\'" + txtNameOfBank.Text + "\',\'" + txtChequeNo.Text + "\')";
				
				SqlCommand cmd2 = new SqlCommand(s1, con);
				cmd2.ExecuteNonQuery();
				
				
				con.Close();
				
				
				MessageBox.Show("Record Inserted");
				clear();
				
				
				
				
			}
			
			
		}
		
		public void cboCourseName_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			con.Open();
			SqlCommand cmd = new SqlCommand("select COURSE_FEES from tbl_Course where COURSE_NAME=\'" + cboCourseName.Text + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				
				txtTotalFees.Text = (string) (rd[0].ToString());
				txtFee.Text = (string) (rd[0].ToString());
			}
			con.Close();
			
			
			
		}
		
		public void txtDiscountPercentage_Leave(System.Object sender, System.EventArgs e)
		{
			
			decimal fees;
			decimal DisPercentage;
			decimal DiscAmt;
			decimal totFees;
			decimal tax;
			decimal taxAmt;
			decimal netAmt;
			
			
			tax = 12.04M;
			
			if (txtFee.Text == "" || txtDiscountPercentage.Text == "")
			{
				
				
				
			}
			else
			{
				
				fees = decimal.Parse(txtFee.Text);
				DisPercentage = decimal.Parse(txtDiscountPercentage.Text);
				
				DiscAmt = fees * DisPercentage / 100;
				
				txtDicountAmount.Text = DiscAmt.ToString();
				
				
				totFees = fees - DiscAmt;
				
				txtTotalfee.Text = totFees.ToString();
				
				taxAmt =  (decimal) ((double) totFees * 12.04 / 100);
				
				netAmt = totFees + taxAmt;
				txtAmountPaid.Text = netAmt.ToString();
				
				
				
				
			}
			
			
			
			
			
			
			
			
			
			//rate = Decimal.Parse(txtRate.Text)
			//qty = Decimal.Parse(txtQuantity.Text)
			//amt = rate * qty
			//lblAmount.Text = amt.ToString
			
			
			
		}
		
		public void BtnUpdateSearch_Click(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = true;
			btnUpdate.Visible = true;
			btnDelete.Visible = true;
			btnSave.Visible = false;
			BtnClear3.Visible = false;
			TabControl1.Visible = false;
			
			
		}
		
		public void cboStudent_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			
			dgvSearch.Columns.Clear();
			
			con.Open();
			SqlDataAdapter adapter = new SqlDataAdapter("select [Roll Number]=Student_ROLLNO,[Name]=Student_NAME,[Address]=Student_ADDRESS,[Contact Number]=Student_PHONE from tbl_Student where Student_NAME=\'" + cboStudent.Text + "\'", con);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgvSearch.DataSource = ds.Tables[0];
			con.Close();
			
			
			
			
			
		}
		
		public void dgvSearch_CellContentClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
		}
		
		public void dgvSearch_CellMouseDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			TabControl1.Visible = true;
			
			con.Open();
			
			string str = dgvSearch.CurrentRow.Cells["Roll Number"].Value.ToString();
			
			SqlCommand cmd = new SqlCommand("select * from tbl_Student where Student_ROLLNO=\'" + str + "\'", con);
			SqlDataReader rd;
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				txtRollNo.Text = (string) (rd["Student_ROLLNO"].ToString());
				txtStudentName.Text = (string) (rd["Student_NAME"].ToString());
				txtFatherName.Text = (string) (rd["Student_FNAME"].ToString());
				txtMotherName.Text = (string) (rd["Student_MNAME"].ToString());
				txtHusbandName.Text = (string) (rd["Student_HNAME"].ToString());
				txtAddress.Text = (string) (rd["Student_ADDRESS"].ToString());
				txtPhoneNo.Text = (string) (rd["Student_PHONE"].ToString());
				cboQualification.SelectedText = (string) (rd["Student_QUALIFICATION"].ToString());
				cboGender.SelectedText = (string) (rd["Student_GENDER"].ToString());
				dtpDob.Text = (string) (rd["Student_DOB"].ToString());
				txtEmail.Text = (string) (rd["Student_EMAIL"].ToString());
				cboOccupation.SelectedText = (string) (rd["Student_OCCUPATION"].ToString());
				cboCourseName.SelectedText = (string) (rd["Student_CNAME"].ToString());
				txtKnowledge.Text = (string) (rd["Student_KNOWLEDGE"].ToString());
				txtAmountPaid.Text = (string) (rd["Student_TOTALFEES"].ToString());
				
				
				
			}
			rd.Close();
			con.Close();
			con.Open();
			
			SqlCommand cmd1 = new SqlCommand("select * from tbl_Fee where Fee_ROLLNO=\'" + str + "\'", con);
			SqlDataReader rd1;
			rd1 = cmd1.ExecuteReader();
			while (rd1.Read())
			{
				txtReceiptNo.Text = (string) (rd1["Fee_RECEIPTNO"].ToString());
				dtpDate.Text = (string) (rd1["Fee_Date"].ToString());
				txtFee.Text = (string) (rd1["Fee_BasicFees"].ToString());
				txtDiscountPercentage.Text = (string) (rd1["Fee_DiscountPercentage"].ToString());
				txtDicountAmount.Text = (string) (rd1["Fee_DiscountAmount"].ToString());
				txtTotalfee.Text = (string) (rd1["Fee_TotalFees"].ToString());
				txtAmountPaid.Text = (string) (rd1["Fee_AMOUNT"].ToString());
				cboPaymentMode.SelectedText = (string) (rd1["Fee_ModeOfPayment"].ToString());
				txtNameOfBank.Text = (string) (rd1["Fee_BANKNAME"].ToString());
				txtChequeNo.Text = (string) (rd1["Fee_CHEQUENO"].ToString());
				
				
			}
			rd1.Close();
			
			con.Close();
			
			
			pnlSearch.Visible = false;
			TabControl1.Visible = true;
			
			
			
			
			
		}
		
		public void btnUpdate_Click(System.Object sender, System.EventArgs e)
		{
			
			con.Open();
			
			string s = "update tbl_Student set Student_NAME=\'" + txtStudentName.Text + "\',Student_FNAME=\'" + txtFatherName.Text + "\',Student_MNAME=\'" + txtMotherName.Text + "\',Student_HNAME=\'" + txtHusbandName.Text + "\',Student_ADDRESS=\'" + txtAddress.Text + "\',Student_PHONE=\'" + txtPhoneNo.Text + "\',Student_QUALIFICATION=\'" + cboQualification.Text + "\',Student_GENDER=\'" + cboGender.Text + "\',Student_DOB=\'" + dtpDob.Text + "\',Student_EMAIL=\'" + txtEmail.Text + "\',Student_OCCUPATION=\'" + cboOccupation.Text + "\',Student_CNAME=\'" + cboCourseName.Text + "\',Student_KNOWLEDGE=\'" + txtKnowledge.Text + "\',Student_TOTALFEES=\'" + txtAmountPaid.Text + "\' where Student_ROLLNO=\'" + txtRollNo.Text + "\'";
			SqlCommand cmd1 = new SqlCommand(s, con);
			cmd1.ExecuteNonQuery();
			
			con.Close();
			
			
			con.Open();
			
			string s1 = "update tbl_Fee set Fee_RECEIPTNO=\'" + txtReceiptNo.Text + "\',Fee_Date=\'" + dtpDate.Value.ToString() + "\',Fee_BasicFees=\'" + txtFee.Text + "\',Fee_DiscountPercentage=\'" + txtDiscountPercentage.Text + "\',Fee_DiscountAmount=\'" + txtDicountAmount.Text + "\',Fee_TotalFees=\'" + txtTotalfee.Text + "\',Fee_AMOUNT=\'" + txtAmountPaid.Text + "\',Fee_ModeOfPayment=\'" + cboPaymentMode.Text + "\',Fee_BANKNAME=\'" + txtNameOfBank.Text + "\',Fee_CHEQUENO=\'" + txtChequeNo.Text + "\' where Fee_ROLLNO=\'" + txtRollNo.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s1, con);
			cmd2.ExecuteNonQuery();
			MessageBox.Show("Record Updated");
			con.Close();
			
			this.Close();
			
			
			
			
		}
		
		public void btnDelete_Click(System.Object sender, System.EventArgs e)
		{
			con.Open();
			
			string s = "delete from tbl_Student where Student_ROLLNO=\'" + txtRollNo.Text + "\'";
			SqlCommand cmd2 = new SqlCommand(s, con);
			cmd2.ExecuteNonQuery();
			
			//Else
			con.Close();
			
			
			con.Open();
			
			string s3 = "delete from tbl_Fee where Fee_ROLLNO=\'" + txtRollNo.Text + "\'";
			SqlCommand cmd3 = new SqlCommand(s3, con);
			cmd3.ExecuteNonQuery();
			//Else
			con.Close();
			MessageBox.Show("Record Deleted");
			
			
			this.Close();
		}
		
		public void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			pnlSearch.Visible = false;
			TabControl1.Visible = true;
			
		}
		
		public void btnExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void cboPaymentMode_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (cboPaymentMode.SelectedIndex != 0)
			{
				
				txtNameOfBank.Enabled = true;
				txtChequeNo.Enabled = true;
				
				
			}
			if (cboPaymentMode.SelectedIndex == 0)
			{
				
				txtNameOfBank.Enabled = false;
				txtChequeNo.Enabled = false;
				
				
			}
		}
		
		public void txtPhoneNo_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtDiscountPercentage_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		
		public void txtTotalfee_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
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
