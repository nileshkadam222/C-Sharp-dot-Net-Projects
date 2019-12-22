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
    public partial class frmAddClass : Form
    {
        connectionClass obj = new connectionClass();
        public frmAddClass()
        {
            InitializeComponent();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            fillid();
            fillDepartment();
        }
        public void fillid()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select count(ClassId) from tblClass";
                int maxrow = (int)obj.com.ExecuteScalar();
                maxrow = maxrow + 1;
                txtId.Text = maxrow.ToString();
                obj.con.Close();
            }
            catch(Exception ex)
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
                    cboDept.Items.Add(obj.dr[0].ToString());
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
        }

        public static bool IsNumeric(string text)
        {
            return string.IsNullOrEmpty(text) ? false :
                    Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Class Name Cannot be Empty !!");
                txtName.Focus();
            }
            else if (cboDept.Text == "")
            {
                MessageBox.Show("");
                cboDept.Focus();
            }
            else if (txtFees.Text == "")
            {
                MessageBox.Show("Fees cannot be Empty !!");
                txtFees.Focus();
            }
            else if (IsNumeric(txtFees.Text) == false)
            {
                MessageBox.Show("Invalid Information !!");
                txtFees.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblClass values('"+txtId.Text+"','"+txtName.Text+"','"+cboDept.Text+"','"+txtFees.Text+"')";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully !!");
                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                    fillid();
                    clear();
                    txtName.Focus();
                }
            }

        }

       
        public void clear()
        {
            txtFees.Clear();
            txtName.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            txtName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
