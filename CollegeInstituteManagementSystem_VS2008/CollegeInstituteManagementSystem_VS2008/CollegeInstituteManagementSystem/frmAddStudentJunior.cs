using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CollegeInstituteManagementSystem
{
    public partial class frmAddStudentJunior : Form
    {
        connectionClass obj = new connectionClass();
        public frmAddStudentJunior()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            txtName.Focus();
        }

        public void fillid()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select count(StudentId) from tblJuniorStudent";
                int maxrow = (int)obj.com.ExecuteScalar();
                maxrow = maxrow + 1;
                txtId.Text = maxrow.ToString();
                obj.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        public void fillDepartment()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select DepartmentName from tblDepartment";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    cboDepartment.Items.Add(obj.dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
        }

        public void clear()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFather.Clear();
            txtMarks.Clear();
            txtMother.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtPrevious.Clear();
            txtFees.Clear();
            txtBank.Clear();
            txtCheqNo.Clear();

        }

        public static bool IsNumeric(string text)
        {
            return string.IsNullOrEmpty(text) ? false :
                    Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtFather.Text == "" || txtId.Text == "" || txtMarks.Text == "" || txtMother.Text == "" || txtName.Text == "" ||
                    txtPhone.Text == "" || txtPrevious.Text == "" || cboClass.Text == "" || cboDepartment.Text == "" ||
                    cboPreviousClass.Text == "" || txtFees.Text=="" || cboPaidBy.Text=="")
            {
                MessageBox.Show("Incomplete Information !!");
            }
            else if (IsNumeric(txtPhone.Text) == false)
            {
                MessageBox.Show("Enter valid phone no. !!");
                txtPhone.Focus();
            }
            else if (IsNumeric(txtMarks.Text) == false)
            {
                MessageBox.Show("Enter valid Marks !!");
                txtMarks.Focus();
            }


            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblJuniorStudent values(@id,@name,@fname,@mname,@gender,@addr,@phone,@email,@dept,@class,@pschool,@pclass,@marks,@date)";
                    obj.com.Parameters.AddWithValue("@id", txtId.Text);
                    obj.com.Parameters.AddWithValue("@name", txtName.Text);
                    obj.com.Parameters.AddWithValue("@fname", txtFather.Text);
                    obj.com.Parameters.AddWithValue("@mname", txtMother.Text);
                    obj.com.Parameters.AddWithValue("@gender", cboGender.Text);
                    obj.com.Parameters.AddWithValue("@addr", txtAddress.Text);
                    obj.com.Parameters.AddWithValue("@phone", txtPhone.Text);
                    obj.com.Parameters.AddWithValue("@email", txtEmail.Text);
                    obj.com.Parameters.AddWithValue("@dept", cboDepartment.Text);
                    obj.com.Parameters.AddWithValue("@class", cboClass.Text);
                    obj.com.Parameters.AddWithValue("@pschool", txtPrevious.Text);
                    obj.com.Parameters.AddWithValue("@pclass", cboPreviousClass.Text);
                    obj.com.Parameters.AddWithValue("@marks", txtMarks.Text);
                    obj.com.Parameters.AddWithValue("@date", dtpDate.Value);

                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                }

                try
                {

                    obj.connect();
                    obj.com.CommandText = "insert into tblJuniorPayment values(@id,@name,@fees,@paidby,@bank,@cno,@date)";
                    obj.com.Parameters.AddWithValue("@id", txtId.Text);
                    obj.com.Parameters.AddWithValue("@name", txtName.Text);
                    obj.com.Parameters.AddWithValue("@fees", txtFees.Text);
                    obj.com.Parameters.AddWithValue("@paidby", cboPaidBy.Text);
                    obj.com.Parameters.AddWithValue("@bank", txtBank.Text);
                    obj.com.Parameters.AddWithValue("@cno", txtCheqNo.Text);
                    obj.com.Parameters.AddWithValue("@date", dtpDate.Value);

                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Record Saved Successfully !!");

                    DialogResult dr = MessageBox.Show("Do You Want to Print Receipt ?", "College Management System", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        frmReportViewer fpv = new frmReportViewer();
                        fpv.receiptJunior(txtId.Text);
                        fpv.Show();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                    clear();
                    fillid();
                    txtName.Focus();
                }
            }
        }

        private void frmAddStudentJunior_Load(object sender, EventArgs e)
        {
            fillid();
            fillDepartment();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboClass.Items.Clear();
            try
            {
                obj.connect();
                obj.com.CommandText = "select ClassName from tblClass where Department='" + cboDepartment.Text + "'";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    cboClass.Items.Add(obj.dr[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            try
            {
                obj.connect();
                obj.com.CommandText = "select Fees from tblClass where ClassName='" + cboClass.Text + "'";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                   
                    txtFees.Text = obj.dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
        }
    }
}
