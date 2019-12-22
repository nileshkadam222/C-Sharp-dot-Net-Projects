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
    public partial class TodaysAttendence : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        String p, s;
        public TodaysAttendence()
        {
            con = new SqlConnection(c);
           
            InitializeComponent();
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
          
            if (rbnyes.Checked)
            {
                p = "yes";
                if (rbnon.Checked)
                {
                    s = "--";


                }
                else
                {
                    s = Convert.ToString(lbltime.Text);
                }

            }
            else if (rbnno.Checked)
            {
                p = "no";
                s = "";

            }

            SqlCommand addcon = new SqlCommand("insert into Attendence values('" + Convert.ToInt32(cbid.Text) + "','" + cbname.Text + "','"+lastname_comb.Text +"','" + dtpdate.Value + "','" + p + "','" + lbltime.Text + "','" + s + "')", con);
            con.Open();
            addcon.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully!!");
            rbnyes.Checked = false;
            rbnno.Checked = false;
            rbnon.Checked = false;
            rbnouttime.Checked = false;
            gbstatus.Enabled = true;
            lbltime.Text = DateTime.Now.TimeOfDay.ToString();

        }
       

      

        private void TodaysAttendence_Load(object sender, EventArgs e)
        {
            string query = "select Employee_ID, First_Name,Last_Name from Employee_Table";
            //addcon = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            cbid.DataSource = ds.Tables[0];
            cbname.DataSource = ds.Tables[0];
            lastname_comb.DataSource=ds.Tables[0];

            cbid.DisplayMember = "Employee_ID";

            cbname.DisplayMember = "First_Name";
            lastname_comb.DisplayMember = "Last_Name";
            con.Close();
            //cbempid.Text = "";
            //cmbname.Text = "";
            dtpdate.Value = DateTime.Now.Date;

            lbltime.Text = DateTime.Now.TimeOfDay.ToString();

        
        }
       

     


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (rbnyes.Checked)
            {
                p = "yes";
                if (rbnon.Checked)
                {
                    s = "--";

                }
                else
                {
                    s = Convert.ToString(lbltime.Text);
                }

            }
            else if (rbnno.Checked)
            {
                p = "no";
                s = "";

            }
            con.Open();
            SqlCommand addcon = new SqlCommand("update Attendence set Timeout ='" + s + "',Present='" + p + "',Ontime='" + lbltime.Text + "' where Employee_Id='" + Convert.ToInt32(cbid.Text) + "' and Date='" + dtpdate.Value + "'", con);

            addcon.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Records Updated Successfully!!");
            rbnyes.Checked = false;
            rbnno.Checked = false;
            rbnon.Checked = false;
            rbnouttime.Checked = false;
            gbstatus.Enabled = true;
            lbltime.Text = DateTime.Now.TimeOfDay.ToString();


        

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Attendence where Employee_ID='" + cbid.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                SqlCommand addcon = new SqlCommand("delete from Attendence where Employee_ID='" + cbid.Text + "'", con);
                addcon.ExecuteNonQuery();
                MessageBox.Show("Records deleted from Database");
            }
            else
            {
                MessageBox.Show("No records found???");
            }
            con.Close();

            rbnyes.Checked = false;
            rbnno.Checked = false;
            rbnon.Checked = false;
            rbnouttime.Checked = false;
            gbstatus.Enabled = true;
            lbltime.Text = DateTime.Now.TimeOfDay.ToString();

        
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rbnno_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbnno.Checked)
            {
                lbltime.Text = "On Leave";
                gbstatus.Enabled = false;

            }

        }

        private void rbnyes_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbnyes.Checked)
            {
                lbltime.Text = DateTime.Now.TimeOfDay.ToString();
                gbstatus.Enabled = true;

            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            AttendenceRecord r = new AttendenceRecord();
          
            r.Show();
        }

       

       
    }
}
