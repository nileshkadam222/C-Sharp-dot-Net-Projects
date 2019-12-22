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

namespace CollegeInstituteManagementSystem
{
    public partial class frmSeniorStudentReport : Form
    {
        connectionClass obj = new connectionClass();
        public frmSeniorStudentReport()
        {
            InitializeComponent();
        }

        private void frmSeniorStudentReport_Load(object sender, EventArgs e)
        {
            showAll();
            fillDepartment();
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
                da = new SqlDataAdapter("select [StudentId] as [Student ID],[StudentName] as [Student Name],[Department] as [Department],[Class] as [Class],[Address] as [Address],[Phone] as [Phone],[Email] as [Email] from tblSeniorStudent", obj.con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            showAll();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboDepartment.Text == "")
            {
                MessageBox.Show("Please, Select a Department !!");
            }
            else if (cboClass.Text == "")
            {
                MessageBox.Show("Select Class");
            }
            else
            {
                try
                {
                    obj.connect();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    ds.Tables.Add(dt);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da = new SqlDataAdapter("select [StudentId] as [Student ID],[StudentName] as [Student Name],[Department] as [Department],[Class] as [Class],[Address] as [Address],[Phone] as [Phone],[Email] as [Email] from tblSeniorStudent where Department='" + cboDepartment.Text + "' and Class='" + cboClass.Text + "'", obj.con);
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

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
            xlworksheet.Cells[2, 3] = "Student List";



            xlworksheet.get_Range("A3", "EA3").Font.Bold = true;
            xlworksheet.Cells.EntireColumn.ColumnWidth = 20;
            xlworksheet.Columns.AutoFit();

            xlworksheet.Columns.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlapp.Visible = true;
            xlapp.UserControl = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmReportViewer obj = new frmReportViewer();
            obj.SeniorList(cboClass.Text);
            obj.Show();
        }

    }
}
