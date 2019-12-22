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
    public partial class frmAddEmployee : Form
    {
        connectionClass obj = new connectionClass();
        public frmAddEmployee()
        {
            InitializeComponent();
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
                    obj.com.CommandText = "insert into tblPersonalDetails values('"+txtEmpid.Text+"','"+txtEmpname.Text+"','"+cboGender.Text+"','"+txtPanno.Text+"',@date,'"+txtNatioanlity.Text+"','"+txtReligion.Text+"','"+cboBloodGroup.Text+"')";
                    obj.com.Parameters.AddWithValue("@date", dtpDOB.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Personal Info Added !");
                    grpPersonal.Visible = false;
                    grpContact.Visible = true;
                    txtAddress.Focus();
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
        private void fillId()
        {

            connectionClass obj = new connectionClass();
            obj.connect();
            obj.com.CommandText = "select COUNT (EmployeeId) from tblPersonalDetails";
            int maxrow = (int)obj.com.ExecuteScalar();
            maxrow = maxrow + 1;
            txtEmpid.Text = maxrow.ToString();
            txtEmpIdContct.Text = maxrow.ToString();
            txtIdQualication.Text = maxrow.ToString();
            txtEmpIdJob.Text = maxrow.ToString();
            obj.con.Close();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            fillId();
            
        }

        private void btnContactSubmit_Click(object sender, EventArgs e)
        {
          

        }

        private void btnQualificationSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnJobSubmit_Click(object sender, EventArgs e)
        {
           
        }
        public void clearAll()
        {
            txtAddress.Clear();
            txtBasicSalary.Clear();
            txtCity.Clear();
            txtContactNo.Clear();
            txtDegree.Clear();
            txtDepartment.Clear();
            txtDesignation.Clear();
            txtEmail.Clear();
            txtEmpid.Clear();
            txtEmpIdContct.Clear();
            txtEmpIdJob.Clear();
            txtEmpname.Clear();
            txtIdQualication.Clear();
            txtLeaves.Clear();
            txtNatioanlity.Clear();
            txtPanno.Clear();
            txtPassingYear.Clear();
            txtPercentage.Clear();
            txtReligion.Clear();
            txtState.Clear();
            txtUniversity.Clear();
            txtZipCode.Clear();

        }

        private void btnContactSubmit_Click_1(object sender, EventArgs e)
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
                    obj.com.CommandText = "insert into tblContactDetails values('" + txtEmpIdContct.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtZipCode.Text + "','" + txtContactNo.Text + "','" + txtEmail.Text + "')";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Contact Details Added !!");
                    grpContact.Visible = false;
                    grpQualification.Visible = true;
                    txtDegree.Focus();
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

        private void btnQualificationSubmit_Click_1(object sender, EventArgs e)
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
                    obj.com.CommandText = "insert into tblQualificationDetails values('" + txtIdQualication.Text + "','" + txtDegree.Text + "','" + txtUniversity.Text + "','" + txtPassingYear.Text + "','" + txtPercentage.Text + "')";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Qualification Details Added !!");
                    grpQualification.Visible = false;
                    grpJobDetails.Visible = true;
                    txtDesignation.Focus();
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

        private void btnJobSubmit_Click_1(object sender, EventArgs e)
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
                    obj.com.CommandText = "insert into tblJobDetails values('" + txtEmpIdJob.Text + "',@date,'" + txtDepartment.Text + "','" + txtDesignation.Text + "','" + txtLeaves.Text + "','" + txtBasicSalary.Text + "')";
                    obj.com.Parameters.AddWithValue("@date", dtpJoiningDate.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Job Details Added Successfully");
                    grpJobDetails.Visible = false;
                    grpPersonal.Visible = true;

                    clearAll();
                    txtEmpname.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                    fillId();
                }
            }
        }

        private void grpJobDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
