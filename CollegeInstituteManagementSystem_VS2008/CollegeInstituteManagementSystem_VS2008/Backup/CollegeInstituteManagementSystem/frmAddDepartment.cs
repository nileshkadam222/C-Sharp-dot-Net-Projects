using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeInstituteManagementSystem
{
    public partial class frmAddDepartment : Form
    {
        connectionClass obj = new connectionClass();
        public frmAddDepartment()
        {
            InitializeComponent();
        }

        public void fillId()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select count(DepartmentID) from tblDepartment";
                int maxrow = (int)obj.com.ExecuteScalar();
                maxrow = maxrow + 1;
                txtId.Text = maxrow.ToString();
                obj.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "insert into tblDepartment values('"+txtId.Text+"','"+txtName.Text+"')";
                obj.com.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully !!");
                
            }
            catch
            {
            }
            finally
            {
                obj.con.Close();
                txtName.Clear();
                fillId();
                txtName.Focus();
            }
        }

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {
            fillId();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
