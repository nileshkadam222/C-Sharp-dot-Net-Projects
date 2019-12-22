using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CollegeInstituteManagementSystem
{
    public partial class frmUpdateFaculty : Form
    {
        connectionClass obj = new connectionClass();
        int i;
        public frmUpdateFaculty()
        {
            InitializeComponent();
        }

        private void frmUpdateFaculty_Load(object sender, EventArgs e)
        {
            fillgrid();
            fillDepartment();
        }

        protected void fillgrid()
        {
            try
            {
                obj.connect();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select [FacultyId] as [Id],[FacultyName] as [Name],[Department] as [Department],[Email] as [Email],[Phone] as [Phone] from tblFaculty", obj.con);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentRow.Index;
                obj.connect();
                string str = (string)dataGridView1[0, i].Value.ToString();
                obj.com.CommandText = "select * from tblfaculty where FacultyId='" + str + "'";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    txtId.Text = obj.dr[0].ToString();
                    txtName.Text = obj.dr[1].ToString();
                    cboGender.Text = obj.dr[2].ToString();
                    txtAddress.Text = obj.dr[3].ToString();
                    txtEmail.Text = obj.dr[4].ToString();
                    txtPhone.Text = obj.dr[5].ToString();
                    cboDept.Text = obj.dr[6].ToString();
                    txtExperience.Text=obj.dr[7].ToString();
                    txtSalary.Text = obj.dr[8].ToString();
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
        public static bool IsNumeric(string text)
        {
            return string.IsNullOrEmpty(text) ? false :
                    Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please , Select a Record to Update !");
            }
            else if (txtAddress.Text == "" || txtEmail.Text == "" || txtExperience.Text == "" || txtId.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtSalary.Text == "" || cboDept.Text == "" || cboGender.Text == "")
            {
                MessageBox.Show("Incomlete Infomation !!");
                txtName.Focus();
            }
            else if (IsNumeric(txtPhone.Text) == false)
            {
                MessageBox.Show("Enter valid phone no. !!");
                txtPhone.Focus();
            }
            else if (IsNumeric(txtSalary.Text) == false)
            {
                MessageBox.Show("Enter Valid Amount !");
                txtSalary.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblFaculty set FacultyName='" + txtName.Text + "',Department='" + cboDept.Text + "',Gender='" + cboGender.Text + "',Address='" + txtAddress.Text + "',Email='" + txtEmail.Text + "',Phone='" + txtPhone.Text + "',Experience='" + txtExperience.Text + "',Salary='" + txtSalary.Text + "' where FacultyId='" + txtId.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully !!");
                    clear();
                    fillgrid();
                    txtId.Focus();
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
        public void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtExperience.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are You Sure ?", "College Management System", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    obj.connect();
                    obj.com.CommandText = "delete from tblfaculty where FacultyId='" + txtId.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully");
                    clear();
                    fillgrid();
                    txtId.Focus();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            txtId.Focus();
        }
    }
}
