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
    public partial class frmUpdateStudentSenior : Form
    {
        connectionClass obj = new connectionClass();
        public frmUpdateStudentSenior()
        {
            InitializeComponent();
        }
        public static bool IsNumeric(string text)
        {
            return string.IsNullOrEmpty(text) ? false :
                    Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$");
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

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblSeniorStudent where StudentId='"+txtId.Text+"'";
                    obj.dr = obj.com.ExecuteReader();
                    if (obj.dr.Read())
                    {
                        txtName.Text = obj.dr[1].ToString();
                        txtFather.Text = obj.dr[2].ToString();
                        txtMother.Text = obj.dr[3].ToString();
                        txtAddress.Text = obj.dr[4].ToString();
                        txtPhone.Text = obj.dr[5].ToString();
                        txtEmail.Text = obj.dr[6].ToString();
                        cboDepartment.Text = obj.dr[7].ToString();
                        cboClass.Text = obj.dr[8].ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student Id");
                        txtId.Clear();
                        txtId.Focus();
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
                        DataSet ds = new DataSet();
                        DataTable dt = new DataTable();
                        ds.Tables.Add(dt);
                        SqlDataAdapter da = new SqlDataAdapter();
                        da = new SqlDataAdapter("select [Class] as [Class],[University] as [University],[Marks] as [Marks(%)] from tblSeniorStudentDetails where StudentId='" + txtId.Text + "'", obj.con);
                        
                        
                        da.Fill(dt);
                        dataGridView1.DataSource = dt.DefaultView;
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
                    obj.com.CommandText = "select * from tblSeniorPayment where StudentId='" + txtId.Text + "'";
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

        private void frmUpdateStudentSenior_Load(object sender, EventArgs e)
        {
            fillClass();
            fillDepartment();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            clear();
            txtId.Focus();
        }

        public void clear()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFather.Clear();
            
            txtMother.Clear();
            txtName.Clear();
            txtPhone.Clear();
            
            txtFees.Clear();
            txtBank.Clear();
            txtCheqNo.Clear();
            txtId.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtFather.Text == "" || txtMother.Text == "" || txtName.Text == ""
                || txtPhone.Text == "")
            {
                MessageBox.Show("Incomplete Information !");
            }
            else if (IsNumeric(txtPhone.Text) == false)
            {
                MessageBox.Show("Enter valid phone no.");
                txtPhone.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblSeniorStudent set StudentName='" + txtName.Text + "',FatherName='" + txtFather.Text + "',MotherName='" + txtMother.Text + "',Address='" + txtAddress.Text + "',Phone='" + txtPhone.Text + "',Email='" + txtEmail.Text + "',Department='" + cboDepartment.Text + "',Class='" + cboClass.Text + "' where StudentId='" + txtId.Text + "'";
                    obj.com.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                }


                //delete records from senior student details table
                try
                {
                    obj.connect();
                    obj.com.CommandText = "delete from tblSeniorStudentDetails where StudentId='" + txtId.Text + "'";
                    obj.com.ExecuteNonQuery();

                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }

                //inserting the qualification record back in the database
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblSeniorStudentDetails values(@sid,@sname,@class,@uni,@marks)";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            obj.com.Parameters.AddWithValue("@sid", txtId.Text);
                            obj.com.Parameters.AddWithValue("@sname", txtName.Text);
                            obj.com.Parameters.AddWithValue("@class", row.Cells[0].Value);
                            obj.com.Parameters.AddWithValue("@uni", row.Cells[1].Value);
                            obj.com.Parameters.AddWithValue("@marks", row.Cells[2].Value);
                            obj.com.ExecuteNonQuery();
                            obj.com.Parameters.Clear();
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }

                //updating the payment details
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblSeniorPayment set StudentId='" + txtId.Text + "',StudentName='" + txtName.Text + "',TotalFees='" + txtFees.Text + "',PaidBy='" + cboPaidBy.Text + "',NameOfBank='" + txtBank.Text + "',ChqNo='" + txtCheqNo.Text + "',Date=@date where StudentId='" + txtId.Text + "'";
                    obj.com.Parameters.AddWithValue("@date", dtpDate.Value);
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully !!");
                    DialogResult dr = MessageBox.Show("Do You Want to Print Receipt ?", "College Management System", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        frmReportViewer fpv = new frmReportViewer();
                        fpv.receiptSenior(txtId.Text);
                        fpv.Show();
                    }
                    clear();
                    txtId.Focus();
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
             DialogResult dr = MessageBox.Show("Are You Sure ?", "College Management System", MessageBoxButtons.YesNo);
             if (dr == DialogResult.Yes)
             {
                 try
                 {
                     obj.connect();
                     obj.com.CommandText = "delete from tblSeniorStudent where StudentId='"+txtId.Text+"'";
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
                     obj.com.CommandText = "delete from tblSeniorPayment where StudentId='" + txtId.Text + "'";
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
                     obj.com.CommandText = "delete from tblSeniorStudentDetails where StudentId='" + txtId.Text + "'";
                     obj.com.ExecuteNonQuery();
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
    }
}
