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
    public partial class frmAddFaculty : Form
    {
        connectionClass obj = new connectionClass();
        public frmAddFaculty()
        {
            InitializeComponent();
        }

        private void frmAddFaculty_Load(object sender, EventArgs e)
        {
            fillid();
            fillDepartment();
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
                    cboDept.Items.Add(obj.dr[0].ToString());
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtExperience.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            txtName.Focus();
        }

        public static bool IsNumeric(string text)
        {
            return string.IsNullOrEmpty(text) ? false :
                    Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtExperience.Text == "" || txtId.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtSalary.Text == "" || cboDept.Text == "" || cboGender.Text == "")
            {
                MessageBox.Show("Incomlete Infomation !!");
                txtName.Focus();
            }
            else if (IsNumeric(txtPhone.Text) == false)
            {
                MessageBox.Show("Invalid Contact number !!");
                txtPhone.Focus();
            }
            else if (IsNumeric(txtSalary.Text) == false)
            {
                MessageBox.Show("Enter valid amount !");
                txtSalary.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblFaculty values('" + txtId.Text + "','" + txtName.Text + "','" + cboGender.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + cboDept.Text + "','" + txtExperience.Text + "','" + txtSalary.Text + "')";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully !!");
                }
                catch
                {
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

        public void fillid()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select count(FacultyId) from tblFaculty";
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

    }
}
