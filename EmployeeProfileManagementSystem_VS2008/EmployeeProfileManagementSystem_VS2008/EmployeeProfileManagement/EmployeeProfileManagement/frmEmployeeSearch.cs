using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace EmployeeProfileManagement
{
    public partial class frmEmployeeSearch : Form
    {
        connectionClass obj = new connectionClass();
        public frmEmployeeSearch()
        {
            InitializeComponent();
        }

        private void frmEmployeeSearch_Load(object sender, EventArgs e)
        {
            showAll();
        }
        public void showAll()
        {
            try
            {
                obj.connect();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select [tblPersonalDetails].EmployeeId as [Employee Id],[tblPersonalDetails].EmployeeName as [Name],[tblJobDetails].Department,[tblJobDetails].Designation,[tblJobDetails].BasicSalary as [Salary] from tblPersonalDetails,tblJobDetails where tblPersonalDetails.EmployeeId=tblJobDetails.EmployeeId", obj.con);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
            }
            catch
            {
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select Department from tblJobDetails group by Department";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        comboBox2.Items.Add(obj.dr[0].ToString());
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

            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select Designation from tblJobDetails group by Designation";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        comboBox2.Items.Add(obj.dr[0].ToString());
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

            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select EmployeeId from tblJobDetails group by EmployeeId";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        comboBox2.Items.Add(obj.dr[0].ToString());
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
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    obj.connect();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    ds.Tables.Add(dt);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da = new SqlDataAdapter("select [tblPersonalDetails].EmployeeId as [Employee Id],[tblPersonalDetails].EmployeeName as [Name],[tblJobDetails].Department,[tblJobDetails].Designation,[tblJobDetails].BasicSalary as [Salary] from tblPersonalDetails,tblJobDetails where tblPersonalDetails.EmployeeId=tblJobDetails.EmployeeId and tblJobDetails.Department='"+comboBox2.Text+"'", obj.con);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    obj.connect();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    ds.Tables.Add(dt);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da = new SqlDataAdapter("select [tblPersonalDetails].EmployeeId as [Employee Id],[tblPersonalDetails].EmployeeName as [Name],[tblJobDetails].Department,[tblJobDetails].Designation,[tblJobDetails].BasicSalary as [Salary] from tblPersonalDetails,tblJobDetails where tblPersonalDetails.EmployeeId=tblJobDetails.EmployeeId and tblJobDetails.Designation='" + comboBox2.Text + "'", obj.con);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    obj.connect();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    ds.Tables.Add(dt);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da = new SqlDataAdapter("select [tblPersonalDetails].EmployeeId as [Employee Id],[tblPersonalDetails].EmployeeName as [Name],[tblJobDetails].Department,[tblJobDetails].Designation,[tblJobDetails].BasicSalary as [Salary] from tblPersonalDetails,tblJobDetails where tblPersonalDetails.EmployeeId=tblJobDetails.EmployeeId and tblJobDetails.EmployeeId='" + comboBox2.Text + "'", obj.con);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt.DefaultView;
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
            Excel.Application xlapp = null;
            Excel.Workbook xlworkbook;
            Excel.Worksheet xlworksheet;




            object misvalue = System.Reflection.Missing.Value;
            xlapp = new Excel.Application();
            xlworkbook = xlapp.Workbooks.Add(misvalue);
            xlworksheet = (Excel.Worksheet)xlworkbook.Worksheets.get_Item(1);

            int i = 0;
            int j = 0;
            int ColumnIndex = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                xlworksheet.Cells[3, ColumnIndex + 1] = column.HeaderText;
                ColumnIndex++;
            }
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {


                    DataGridViewCell cell = dataGridView1[j, i];


                    xlworksheet.Cells[i + 5, j + 1] = cell.Value;


                }
            }


            xlworksheet.Cells[1, 3] = "";
            xlworksheet.Cells[2, 3] = "Employee List";



            xlworksheet.get_Range("A3", "EA3").Font.Bold = true;
            xlworksheet.Cells.EntireColumn.ColumnWidth = 20;
            xlworksheet.Columns.AutoFit();

            xlworksheet.Columns.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlapp.Visible = true;
            xlapp.UserControl = true;
        }
    }
}
