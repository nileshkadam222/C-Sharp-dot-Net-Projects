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
    public partial class AttendenceRecord : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public AttendenceRecord()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void AttendenceRecord_Load(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "select Employee_Id, First_Name,Last_Name from Employee_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            empid_combo.DataSource = ds.Tables[0];
            firstname_combo.DataSource = ds.Tables[0];
            last_combo.DataSource=ds.Tables[0];

            empid_combo.DisplayMember = "Employee_Id";
            firstname_combo.DisplayMember = "First_Name";
            last_combo.DisplayMember = "Last_Name";
            con.Close();

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Attendence where Employee_Id='" + empid_combo.Text + "'", con);
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

        private void SearchByDate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Attendence where Date='" + dateTimePicker1.Value.ToString() + "'", con);
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

        private void Reset_btn1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand two = new SqlCommand("SELECT *  FROM Attendence", con);
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

        private void reset_btn2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand two = new SqlCommand("SELECT *  FROM Attendence", con);
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
