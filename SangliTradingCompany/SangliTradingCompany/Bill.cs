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
    public partial class Bill : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public Bill()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void amount1_txt_TextChanged(object sender, EventArgs e)
        {


            decimal a;
            a = Convert.ToDecimal(netkg1_txt.Text) * Convert.ToDecimal(price1_txt.Text);
            amount1_txt.Text = a.ToString();
        }

        private void amount2_txt_TextChanged(object sender, EventArgs e)
        {

            decimal a;
            a = Convert.ToDecimal(netkg2_txt.Text) * Convert.ToDecimal(price2_txt.Text);
            amount2_txt.Text = a.ToString();
        }

        private void amount4_txt_TextChanged(object sender, EventArgs e)
        {

            decimal a;
            a = Convert.ToDecimal(netkg4_txt.Text) * Convert.ToDecimal(price4_txt.Text);
            amount4_txt.Text = a.ToString();
        }

        private void total_btn_Click(object sender, EventArgs e)
        {
            decimal a, b, c, d,e2;
            a = Convert.ToDecimal(amount1_txt.Text);
            b = Convert.ToDecimal(amount2_txt.Text);
            c = Convert.ToDecimal(amount3_txt.Text);
            d = Convert.ToDecimal(amount4_txt.Text);
            e2 = Convert.ToDecimal(amount5_txt.Text);
            total_amount_txt.Text = (a+b+c+d+e2).ToString();
        }

        private void amount3_txt_TextChanged(object sender, EventArgs e)
        {

            decimal a;
            a = Convert.ToDecimal(netkg3_txt.Text) * Convert.ToDecimal(price3_txt.Text);
            amount3_txt.Text = a.ToString();
        }


        private void amount5_txt_TextChanged(object sender, EventArgs e)
        {
            decimal a;
            a = Convert.ToDecimal(netkg5_txt.Text) * Convert.ToDecimal(price5_txt.Text);
            amount5_txt.Text = a.ToString();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "insert into Bill_Table values('" + Firstname_combo.Text + "','" + lastname_combo.Text + "', '" + comp_combo.Text + "','" + add_txt.Text + "','" + bill_number.Text + "','" + dateTimePicker1.Value + "','" + proname1_combo.Text + "','" + q1_txt.Text + "','" + netkg1_txt.Text + "','" + price1_txt.Text + "' ,'" + amount1_txt.Text + "','" + proname2_combo.Text + "','" + q2_txt.Text + "','" + netkg2_txt.Text + "','" + price2_txt.Text + "','" + amount2_txt.Text + "','" + proname3_combo.Text + "','" + q3_txt.Text + "','" + netkg3_txt.Text + "','" + price3_txt.Text + "','" + amount3_txt.Text + "','" + proname4_combo.Text + "','" + q4_txt.Text + "','" + netkg4_txt.Text + "','" + price4_txt.Text + "','" + amount4_txt.Text + "','" + proname5_combo.Text + "','" + q5_txt.Text + "','" + netkg5_txt.Text + "','" + price5_txt.Text + "','" + amount5_txt.Text + "','"+total_amount_txt.Text+"')";
            SqlCommand insert = new SqlCommand(cmd, con);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Bill Record of Customer are registered successfully...............");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            add_txt.Clear();
            bill_number.Clear();
            proname1_combo.Text = "";
            proname2_combo.Text = "";
                proname3_combo.Text="";
            proname4_combo.Text="";
            proname5_combo.Text="";
            q1_txt.Clear();
            q2_txt.Clear();
            q3_txt.Clear();
            q4_txt.Clear();
            q5_txt.Clear();
            netkg1_txt.Clear();
            netkg2_txt.Clear();
            netkg3_txt.Clear();
            netkg4_txt.Clear();
            netkg5_txt.Clear();
            price1_txt.Clear();
            price2_txt.Clear();
            price3_txt.Clear();
            price4_txt.Clear();
            price5_txt.Clear();
            amount1_txt.Clear();
            amount2_txt.Clear();
            amount3_txt.Clear();
            amount4_txt.Clear();
            amount5_txt.Clear();
            total_amount_txt.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select Customer_First_Name,Customer_Last_Name,Company_Name from Customer_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            Firstname_combo.DataSource = ds.Tables[0];
            lastname_combo.DataSource = ds.Tables[0];
            comp_combo.DataSource = ds.Tables[0];
           

            Firstname_combo.DisplayMember = "Customer_First_Name";
            lastname_combo.DisplayMember = "Customer_Last_Name";
            comp_combo.DisplayMember = "Company_Name";
            con.Close();
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Bill_Number),0) from Bill_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                bill_number.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
          
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Bill_Number),0) from Bill_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                bill_number.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
          

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
