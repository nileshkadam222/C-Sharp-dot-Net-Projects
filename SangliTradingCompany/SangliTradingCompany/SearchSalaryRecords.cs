using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SangliTradingCompany
{
    public partial class SearchSalaryRecords : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public SearchSalaryRecords()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void SearchSalaryRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.EmployeeSalary_Table' table. You can move, or remove it, as needed.
            this.employeeSalary_TableTableAdapter.Fill(this.database1DataSet.EmployeeSalary_Table);
            con.Open();
            string query = "select Employee_Id, First_Name from Employee_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            empid_combo.DataSource = ds.Tables[0];
            firstname_combo.DataSource = ds.Tables[0];
            

            empid_combo.DisplayMember = "Employee_Id";
            firstname_combo.DisplayMember = "First_Name";
          
            con.Close();

           
             
            

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeSalary_Table where Date='" + dateTimePicker1.Value.ToString() + "'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.SelectCommand = cmd;
            DataTable datatab = new DataTable();
            adapt.Fill(datatab);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatab;
            dataGridView1.DataSource = bind;
            adapt.Update(datatab);
            con.Close();

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand two = new SqlCommand("SELECT *  FROM EmployeeSalary_Table", con);
            SqlDataAdapter adapt = new SqlDataAdapter(two);
            adapt.SelectCommand = two;
            DataTable datatab = new DataTable();
            adapt.Fill(datatab);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatab;
            dataGridView1.DataSource = bind;
            adapt.Update(datatab);
            con.Close();
        }

        private void search2_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeSalary_Table where EmployeeID='"+empid_combo.Text+"'", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.SelectCommand = cmd;
            DataTable datatab = new DataTable();
            adapt.Fill(datatab);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatab;
            dataGridView2.DataSource = bind;
            adapt.Update(datatab);
            con.Close();

        }

        private void Reset_btn_Click_1(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand two = new SqlCommand("SELECT *  FROM EmployeeSalary_Table", con);
            SqlDataAdapter adapt = new SqlDataAdapter(two);
            adapt.SelectCommand = two;
            DataTable datatab = new DataTable();
            adapt.Fill(datatab);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatab;
            dataGridView2.DataSource = bind;
            adapt.Update(datatab);
            con.Close();
        }


       
    }
}
