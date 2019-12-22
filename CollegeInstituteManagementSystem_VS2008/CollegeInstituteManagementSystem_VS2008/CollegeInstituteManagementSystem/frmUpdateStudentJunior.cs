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
    public partial class frmUpdateStudentJunior : Form
    {
        connectionClass obj = new connectionClass();
        public frmUpdateStudentJunior()
        {
            InitializeComponent();
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

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblJuniorStudent where StudentId='"+txtId.Text+"'";
                    obj.dr = obj.com.ExecuteReader();
                    if (obj.dr.Read())
                    {
                        txtName.Text = obj.dr[1].ToString();
                        txtFather.Text = obj.dr[2].ToString();
                        txtMother.Text = obj.dr[3].ToString();
                        cboGender.Text = obj.dr[4].ToString();
                        txtAddress.Text = obj.dr[5].ToString();
                        txtPhone.Text = obj.dr[6].ToString();
                        txtEmail.Text = obj.dr[7].ToString();
                        cboDepartment.Text = obj.dr[8].ToString();
                        cboClass.Text = obj.dr[9].ToString();
                        txtPrevious.Text = obj.dr[10].ToString();
                        cboPreviousClass.Text = obj.dr[11].ToString();
                        txtMarks.Text = obj.dr[12].ToString();
                        dtpDate.Text = obj.dr[13].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Student ID !!!");
                    }
                }
                catch(Exception ex)
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
                    obj.com.CommandText = "select * from tblJuniorPayment where StudentId='" + txtId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    if (obj.dr.Read())
                    {
                        txtFees.Text = obj.dr[2].ToString();
                        cboPaidBy.Text = obj.dr[3].ToString();
                        txtBank.Text = obj.dr[4].ToString();
                        txtCheqNo.Text = obj.dr[5].ToString();
                        dtpDate.Text = obj.dr[6].ToString();
                    }
                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }


            }
        }

        private void frmUpdateStudentJunior_Load(object sender, EventArgs e)
        {
            fillDepartment();
            fillClass();
            
        }

        //private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    cboClass.Items.Clear();
        //    try
        //    {
               
        //        obj.connect();
        //        obj.com.CommandText = "select ClassName from tblClass where Department='" + cboDepartment.Text + "'";
        //        obj.dr = obj.com.ExecuteReader();
        //        while (obj.dr.Read())
        //        {
        //            cboClass.Items.Add(obj.dr[0].ToString());

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        obj.con.Close();
        //    }
        //}
        public void fillClass()
        {
            cboClass.Items.Clear();
            try
            {
                obj.connect();
                obj.com.CommandText = "select ClassName from tblClass";
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
            txtId.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();   
        }

        public static bool IsNumeric(string text)
        {
            return string.IsNullOrEmpty(text) ? false :
                    Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Enter ID to Update the Record !!");
            }
            else if (txtName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtFather.Text == "" || txtId.Text == "" || txtMarks.Text == "" || txtMother.Text == "" || txtName.Text == "" ||
                    txtPhone.Text == "" || txtPrevious.Text == "" || cboClass.Text == "" || cboDepartment.Text == "" ||
                    cboPreviousClass.Text == "" || txtFees.Text == "" || cboPaidBy.Text == "")
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
                MessageBox.Show("Enter valid phone no. !!");
                txtPhone.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblJuniorStudent set StudentName='"+txtName.Text+"',FatherName='"+txtFather.Text+"',MotherName='"+txtMother.Text+"',Gender='"+cboGender.Text+"',Address='"+txtAddress.Text+"',Phone='"+txtPhone.Text+"',Email='"+txtEmail.Text+"',Department='"+cboDepartment.Text+"',Class='"+cboClass.Text+"',PreviousCollege='"+txtPrevious.Text+"',PreviousClass='"+cboPreviousClass.Text+"',Marks='"+txtMarks.Text+"',Date=@date where StudentId='"+txtId.Text+"'";
                    obj.com.Parameters.AddWithValue("@date", dtpDate.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                }
                catch(Exception ex)
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
                    obj.com.CommandText = "update tblJuniorPayment set StudentName='"+txtName.Text+"',TotalFees='"+txtFees.Text+"',PaidBy='"+cboPaidBy.Text+"',NameOfBank='"+txtBank.Text+"',ChqNo='"+txtCheqNo.Text+"',Date=@date";
                    obj.com.Parameters.AddWithValue("@date", dtpDate.Value);
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    DialogResult dr = MessageBox.Show("Do You Want to Print Receipt ?", "College Management System", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        frmReportViewer fpv = new frmReportViewer();
                        fpv.receiptJunior(txtId.Text);
                        fpv.Show();
                    }
                    clear();
                    txtId.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure ?", "College Management System", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                try
                {

                    obj.connect();
                    obj.com.CommandText = "delete from tblJuniorStudent where StudentId='" + txtId.Text + "'";
                    obj.com.ExecuteNonQuery();

                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }
                
                try
                {
                    obj.connect();
                    obj.com.CommandText = "delete from tblJuniorPayment where StudentId='" + txtId.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully !");
                    clear();
                    txtId.Focus();
                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cboClass.Items.Clear();
        //    try
        //    {
        //        obj.connect();
        //        obj.com.CommandText = "select ClassName from tblClass where Department='" + cboDepartment.Text + "'";
        //        obj.dr = obj.com.ExecuteReader();
        //        while (obj.dr.Read())
        //        {
        //            cboClass.Items.Add(obj.dr[0].ToString());

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        obj.con.Close();
        //    }
        //}
    }
}
