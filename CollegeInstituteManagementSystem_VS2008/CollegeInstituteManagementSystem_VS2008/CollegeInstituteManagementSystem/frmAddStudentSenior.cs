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
    public partial class frmAddStudentSenior : Form
    {
        connectionClass obj = new connectionClass();
        public frmAddStudentSenior()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtAddress.Clear();
            txtBank.Clear();
            txtCheqNo.Clear();
            txtClass.Clear();
            txtEmail.Clear();
            txtFather.Clear();
            txtFees.Clear();
            txtHscmarks.Clear();
            txtHscuni.Clear();
            txtMarks.Clear();
            txtMother.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtSscmarks.Clear();
            txtSsscuni.Clear();
            txtUniversity.Clear();
            dataGridView1.Rows.Clear();
            txtName.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtFather.Text == "" || txtHscmarks.Text == "" || txtHscuni.Text == "" || txtMother.Text == "" || txtName.Text == ""
                || txtPhone.Text == "" || txtSscmarks.Text == "" || txtSsscuni.Text == "")
            {
                MessageBox.Show("Incomplete Information !");
            }

            else if (IsNumeric(txtPhone.Text) == false)
            {
                MessageBox.Show("Enter valid phone no.");
                txtPhone.Focus();
            }
            else if (IsNumeric(txtSscmarks.Text) == false)
            {
                MessageBox.Show("Enter valid SSC Marks !");
                txtSscmarks.Focus();
            }
            else if (IsNumeric(txtHscmarks.Text) == false)
            {
                MessageBox.Show("Enter valid HSC Marks !");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblSeniorStudent values('" + txtId.Text + "','" + txtName.Text + "','" + txtFather.Text + "','" + txtMother.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + cboDepartment.Text + "','" + cboClass.Text + "')";
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

                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblSeniorStudentDetails values(@sid,@sname,@class,@uni,@marks)";

                    obj.com.Parameters.AddWithValue("@sid", txtId.Text);
                    obj.com.Parameters.AddWithValue("@sname", txtName.Text);
                    obj.com.Parameters.AddWithValue("@class", "SSC");
                    obj.com.Parameters.AddWithValue("@uni", txtSsscuni.Text);
                    obj.com.Parameters.AddWithValue("@marks", txtSscmarks.Text);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();

                    obj.com.Parameters.AddWithValue("@sid", txtId.Text);
                    obj.com.Parameters.AddWithValue("@sname", txtName.Text);
                    obj.com.Parameters.AddWithValue("@class", "HSC");
                    obj.com.Parameters.AddWithValue("@uni", txtHscuni.Text);
                    obj.com.Parameters.AddWithValue("@marks", txtHscmarks.Text);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();

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
                catch (Exception ex)
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
                    obj.com.CommandText = "insert into tblSeniorPayment values(@id,@name,@fees,@paidby,@bank,@cno,@date)";
                    obj.com.Parameters.AddWithValue("@id", txtId.Text);
                    obj.com.Parameters.AddWithValue("@name", txtName.Text);
                    obj.com.Parameters.AddWithValue("@fees", txtFees.Text);
                    obj.com.Parameters.AddWithValue("@paidby", cboPaidBy.Text);
                    obj.com.Parameters.AddWithValue("@bank", txtBank.Text);
                    obj.com.Parameters.AddWithValue("@cno", txtCheqNo.Text);
                    obj.com.Parameters.AddWithValue("@date", dtpDate.Value);

                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Record Saved Successfully !!");
                    DialogResult dr = MessageBox.Show("Do You Want to Print Receipt ?", "College Management System", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        frmReportViewer fpv = new frmReportViewer();
                        fpv.receiptSenior(txtId.Text);
                        fpv.Show();
                    }
                    clear();
                    fillid();
                    txtName.Focus();
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
        public void fillid()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select count(StudentId) from tblSeniorStudent";
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

        public static bool IsNumeric(string text)
        {
            return string.IsNullOrEmpty(text) ? false :
                    Regex.IsMatch(text, @"^\s*\-?\d+(\.\d+)?\s*$");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtClass.Text == "")
            {
                MessageBox.Show("Enter Class !!");
                txtClass.Focus();
            }
            else if (txtUniversity.Text == "")
            {
                MessageBox.Show("Enter University !!");
                txtUniversity.Focus();
            }
            else if (txtMarks.Text == "")
            {
                MessageBox.Show("Enter Marks !!");
                txtMarks.Focus();
            }
            else if (IsNumeric(txtMarks.Text) == false)
            {
                MessageBox.Show("ENter valid Marks !!");
                txtMarks.Focus();
            }
            else
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                DataGridViewCell dgvCell;
                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = txtClass.Text;
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = txtUniversity.Text;
                dgvRow.Cells.Add(dgvCell);

                dgvCell = new DataGridViewTextBoxCell();
                dgvCell.Value = txtMarks.Text;
                dgvRow.Cells.Add(dgvCell);

                dataGridView1.Rows.Add(dgvRow);

                txtClass.Clear();
                txtUniversity.Clear();
                txtMarks.Clear();
                txtClass.Focus();

            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboClass.Items.Clear();
            try
            {
                obj.connect();
                obj.com.CommandText = "select ClassName from tblClass where Department='" + cboDepartment.Text + "'";
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

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select Fees from tblClass where ClassName='" + cboClass.Text + "'";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {

                    txtFees.Text = obj.dr[0].ToString();
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

        private void frmAddStudentSenior_Load(object sender, EventArgs e)
        {
            fillid();
            fillDepartment();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

