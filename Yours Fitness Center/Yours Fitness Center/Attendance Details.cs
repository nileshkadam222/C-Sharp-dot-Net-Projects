using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Yours_Fitness_Center
{
    public partial class Attendance_Details : Form
    {
        public Attendance_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataAdapter reader;
        SqlDataReader reader1;
        ConnectionState state = new ConnectionState();
        DataSet ds = new DataSet();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labcourseDuration_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_Details_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Staff", conn);
                reader = new SqlDataAdapter(query);
                reader.Fill(ds, "tbl_Staff");
                txtsid.DataSource = ds;
                txtsid.DataMember = "tbl_Staff";
                txtBattenstudTotalDays.DataBindings.Add("Text",ds,"tbl_Staff.S_Id");
            }
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtatt.Text = DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month).ToString();
        }

        private void butnattenDadd_Click(object sender, EventArgs e)
        {
             DateTimePicker ob=new DateTimePicker();
             String Month = dateTimePicker1.Value.Month.ToString();
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("Select * from tbl_Att where S_Id="+txtBattenstudTotalDays.Text.Trim()+"", conn);
                reader1=query.ExecuteReader();
                while(reader1.Read())
                 ob.Text=reader1[1].ToString();
                String Mont=ob.Value.Month.ToString();
                conn.Close();
                if (Month.Equals(Mont))
                {
                    MessageBox.Show("Your Attendance for this already take it...");
                    txtaatt.Text = "";
                    butnattenDadd.Enabled = false;
                }
                else
                {
                    butnattenDadd.Enabled = true;
                    if (state == ConnectionState.Open)
                        conn.Close();
                    else
                    {
                        conn.Close();
                        conn.Open();
                        query = new SqlCommand("insert into tbl_Att values(" + txtBattenstudTotalDays.Text.Trim() + ",'" + dateTimePicker1.Text.Trim() + "','" + txtatt.Text.Trim() + "','" + txtaatt.Text.Trim() + "')", conn);
                        reader1 = query.ExecuteReader();
                        MessageBox.Show("All the records has been submitted successfully into the database...");
                        reader1.Close();
                        conn.Close();
                    }
                }
            } conn.Close();
        }

        private void txtatt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaatt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butnattenDcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnattenDfirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "tbl_Staff"].Position = 0;
        }

        private void butnattenDprev_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "tbl_Staff"].Position --;
        }

        private void butnattenDnext_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "tbl_Staff"].Position ++;
        }

        private void butnattenDLast_Click(object sender, EventArgs e)
        {
           int n= this.BindingContext[ds, "tbl_Staff"].Count-1;
           this.BindingContext[ds, "tbl_Staff"].Position = n;
        }

        private void txtaatt_Leave(object sender, EventArgs e)
        {
            int v = Int32.Parse(txtatt.Text.Trim());
            int t = Int32.Parse(txtaatt.Text.Trim());
            if (t > v)
            {
                MessageBox.Show("Number of attendence can not be maximum than out of month days..");
                txtaatt.Text = "";
                txtaatt.Focus();
            }

        }
    }
}
