using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeProfileManagement
{
    public partial class frmUpdateEmployee : Form
    {
        connectionClass obj = new connectionClass();
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            fillCboId();
        }

        public void fillCboId()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select * from tblPersonalDetails";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    cboId.Items.Add(obj.dr[0].ToString());
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

        private void btnPersonalView_Click(object sender, EventArgs e)
        {
            if (cboId.Text == "")
            {
                MessageBox.Show("Select Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblPersonalDetails where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtEmpid.Text = obj.dr[0].ToString();
                        txtEmpname.Text = obj.dr[1].ToString();
                        cboGender.Text = obj.dr[2].ToString();
                        txtPanno.Text = obj.dr[3].ToString();
                        dtpDOB.Text = obj.dr[4].ToString();
                        txtNatioanlity.Text = obj.dr[5].ToString();
                        txtReligion.Text = obj.dr[6].ToString();
                        cboBloodGroup.Text = obj.dr[7].ToString();
                    }
                    grpPersonal.Visible = true;
                    grpJobDetails.Visible = false;
                    grpContact.Visible = false;
                    grpQualification.Visible = false;
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

        private void btnPersonalSave_Click(object sender, EventArgs e)
        {
            if (txtEmpname.Text == "")
            {
                MessageBox.Show("Enter Employee name !");
                txtEmpname.Focus();
            }
            else if (txtNatioanlity.Text == "")
            {
                MessageBox.Show("Enter Employee Nationality !");
                txtNatioanlity.Focus();
            }
            else if (cboGender.Text == "")
            {
                MessageBox.Show("Select Gender !");
                cboGender.Focus();
            }
            else if (txtPanno.Text == "")
            {
                MessageBox.Show("Enter Employee PAN No. !");
                txtPanno.Focus();
            }
            else if (txtReligion.Text == "")
            {
                MessageBox.Show("Enter Employee Religion !");
                txtReligion.Focus();
            }
            else if (cboBloodGroup.Text == "")
            {
                MessageBox.Show("Enter Employee Blood Group !");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblPersonalDetails set EmployeeName='" + txtEmpname.Text + "',Gender='" + cboGender.Text + "',PanNo='" + txtPanno.Text + "',DOB=@date,Nationality='" + txtNatioanlity.Text + "',Religion='" + txtReligion.Text + "',BloodGroup='" + cboBloodGroup.Text + "' where EmployeeId='" + txtEmpid.Text + "'";
                    obj.com.Parameters.AddWithValue("@date", dtpDOB.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Personal Details Updated !!");
                    grpPersonal.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboId.Text == "")
            {
                MessageBox.Show("Select Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblContactDetails where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtEmpIdContct.Text = obj.dr[0].ToString();
                        txtAddress.Text = obj.dr[1].ToString();
                        txtCity.Text = obj.dr[2].ToString();
                        txtState.Text = obj.dr[3].ToString();
                        txtZipCode.Text = obj.dr[4].ToString();
                        txtContactNo.Text = obj.dr[5].ToString();
                        txtEmail.Text = obj.dr[6].ToString();
                    }
                    grpContact.Visible = true;
                    grpPersonal.Visible = false;
                    grpJobDetails.Visible = false;
                    grpQualification.Visible = false;
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

        private void btnContactSubmit_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter Address !!");
                txtAddress.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Enter City name !!");
                txtCity.Focus();
            }
            else if (txtContactNo.Text == "")
            {
                MessageBox.Show("Enter Contact Number !!");
                txtContactNo.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email Address !!");
                txtEmail.Focus();
            }
            else if (txtZipCode.Text == "")
            {
                MessageBox.Show("Enter Zipcode !!");
                txtZipCode.Focus();
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("Enter State !!");
                txtState.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblContactDetails set Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',State='" + txtCity.Text + "',ZipCode='" + txtZipCode.Text + "',ContactNo='" + txtContactNo.Text + "',Email='" + txtEmail.Text + "' where EmployeeId='" + txtEmpIdContct.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Contact Details Updated !!");
                    grpContact.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (cboId.Text == "")
            {
                MessageBox.Show("Select Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblQualificationDetails where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtIdQualication.Text = obj.dr[0].ToString();
                        txtDegree.Text = obj.dr[1].ToString();
                        txtUniversity.Text = obj.dr[2].ToString();
                        txtPassingYear.Text = obj.dr[3].ToString();
                        txtPercentage.Text = obj.dr[4].ToString();
                    }
                    grpQualification.Visible = true;
                    grpPersonal.Visible = false;
                    grpJobDetails.Visible = false;
                    grpContact.Visible = false;
                    
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

        private void btnQualificationSubmit_Click(object sender, EventArgs e)
        {
            if (txtDegree.Text == "")
            {
                MessageBox.Show("Enter Degree of a Employee !!");
                txtDegree.Focus();
            }
            else if (txtUniversity.Text == "")
            {
                MessageBox.Show("Enter University Name !!");
                txtUniversity.Focus();
            }
            else if (txtPercentage.Text == "")
            {
                MessageBox.Show("Enter Percentage !!");
                txtPercentage.Focus();
            }
            else if (txtPassingYear.Text == "")
            {
                MessageBox.Show("");
                txtPassingYear.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblQualificationDetails set Degree='" + txtDegree.Text + "',University='" + txtUniversity.Text + "',PassingYear='" + txtUniversity.Text + "',Percentage='" + txtPassingYear.Text + "' where EmployeeId='" + txtIdQualication.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Qualification Details Updated !!");
                    grpQualification.Visible = false;

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

        private void button3_Click(object sender, EventArgs e)
        {

            if (cboId.Text == "")
            {
                MessageBox.Show("Select Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblJobDetails where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtEmpIdJob.Text = obj.dr[0].ToString();
                        dtpDOB.Text = obj.dr[1].ToString();
                        txtDepartment.Text = obj.dr[2].ToString();
                        txtDesignation.Text = obj.dr[3].ToString();
                        txtLeaves.Text = obj.dr[4].ToString();
                        txtBasicSalary.Text = obj.dr[5].ToString();
                    }
                    grpJobDetails.Visible = true;
                    grpPersonal.Visible = false;
                    
                    grpContact.Visible = false;
                    grpQualification.Visible = false;
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

        private void btnJobSubmit_Click(object sender, EventArgs e)
        {
            if (txtDesignation.Text == "")
            {
                MessageBox.Show("Enter Designation of Employee");
                txtDesignation.Focus();
            }
            else if (txtLeaves.Text == "")
            {
                MessageBox.Show("Enter Leaves Allowed for Employee Per Month");
                txtLeaves.Focus();
            }
            else if (txtDepartment.Text == "")
            {
                MessageBox.Show("Enter Department !!");
                txtDepartment.Focus();
            }
            else if (txtBasicSalary.Text == "")
            {
                MessageBox.Show("Enter Basic Salary of an Employee !!");
                txtBasicSalary.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblJobDetails set DateOfJoin=@date,Department='" + txtDepartment.Text + "',Designation='" + txtDesignation.Text + "',AllowLeaves='" + txtLeaves.Text + "',BasicSalary='" + txtBasicSalary.Text + "' where EmployeeId='" + txtEmpIdJob.Text + "'";
                    obj.com.Parameters.AddWithValue("@date", dtpJoiningDate.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Job Details Updated !!");
                    grpJobDetails.Visible = false;
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
}
