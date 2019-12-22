using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeInstituteManagementSystem
{
    public partial class UpdateDepartment : Form
    {
        connectionClass obj = new connectionClass();
        int i;
        public UpdateDepartment()
        {
            InitializeComponent();
        }

        private void UpdateDepartment_Load(object sender, EventArgs e)
        {
            fillgrid();
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
                da = new SqlDataAdapter("select [DepartmentId] as [Id],[DepartmentName] as [Department] from tblDepartment", obj.con);
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
                obj.com.CommandText = "select * from tblDepartment where DepartmentId='" + str + "'";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    txtId.Text = obj.dr[0].ToString();
                    txtName.Text = obj.dr[1].ToString();
                   
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Select a Record to Update !!");
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Name Cannot Be Empty !!");
                txtName.Focus();
            }
            else
            {
                obj.connect();
                obj.com.CommandText = "update tblDepartment set DepartmentName='" + txtName.Text + "' where DepartmentId='" + txtId.Text + "'";
                obj.com.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully !!");
                txtId.Clear();
                txtName.Clear();
                obj.con.Close();
                fillgrid();
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
                     obj.com.CommandText = "delete from tblDepartment where DepartmentId='"+txtId.Text+"'";
                     obj.com.ExecuteNonQuery();
                     MessageBox.Show("Record Deleted Successfully !!");
                     txtId.Clear();
                     txtName.Clear();

                   
                 }
                 catch(Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     obj.con.Close();
                     fillgrid();
                 }
             }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
