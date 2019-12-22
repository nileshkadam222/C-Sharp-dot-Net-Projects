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
    public partial class UpdateClass : Form
    {
        connectionClass obj = new connectionClass();
        int i;
        public UpdateClass()
        {
            InitializeComponent();
        }

        private void UpdateClass_Load(object sender, EventArgs e)
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
                da = new SqlDataAdapter("select [ClassId] as [Id],[ClassName] as [Class],[Department] as [Department],[Fees] as [Fees] from tblClass", obj.con);
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
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentRow.Index;
                obj.connect();
                string str = (string)dataGridView1[0, i].Value.ToString();
                obj.com.CommandText = "select * from tblClass where ClassId='" + str + "'";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    txtId.Text = obj.dr[0].ToString();
                    txtName.Text = obj.dr[1].ToString();
                    cboDept.Text = obj.dr[2].ToString();
                    txtFees.Text = obj.dr[3].ToString();
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
            clear();
        }

        public void clear()
        {
            txtFees.Clear();
            txtName.Clear();
            txtId.Clear();
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
                MessageBox.Show("Please the Record from List to Update !!");
            }
            else if (txtFees.Text == "")
            {
                MessageBox.Show("Fees Cannot be Blank !");
            }
            else if (cboDept.Text == "")
            {
                MessageBox.Show("Select Department !!");
            }
            else if (IsNumeric(txtFees.Text) == false)
            {
                MessageBox.Show("Enter valid amount !");
                txtFees.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblClass set ClassName='" + txtName.Text + "',Department='" + cboDept.Text + "',Fees='" + txtFees.Text + "' where ClassId='" + txtId.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully !!");
                    txtId.Clear();
                    txtName.Clear();
                    txtFees.Clear();

                }
                catch (Exception ex)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("Are You Sure ?", "College Management System", MessageBoxButtons.YesNo);
             if (dr == DialogResult.Yes)
             {
                 try
                 {
                     obj.connect();
                     obj.com.CommandText = "delete from tblClass where ClassId='"+txtId.Text+"'";
                     obj.com.ExecuteNonQuery();
                     MessageBox.Show("Record Deleted Successfully !!!");
                     txtId.Clear();
                     txtName.Clear();
                     txtFees.Clear();
                     
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
        
    }
}
