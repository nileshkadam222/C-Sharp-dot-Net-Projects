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
    public partial class Purchase_Details : Form
    {
        public Purchase_Details()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=SGT-PC;Initial Catalog=FitnessDb;Integrated Security=True;Pooling=False");
        SqlCommand query;
        SqlDataReader reader;
        ConnectionState state = new ConnectionState();
        private void panel3courseD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panl1courceD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labcourseDuration_Click(object sender, EventArgs e)
        {

        }

        private void labcourseno_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_Details_Load(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Prod", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                    cmbMachinid.Items.Add(reader[0].ToString());
                reader.Close();
                conn.Close();
            }
        }

        private void butnpurDexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMachinid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("Select * from tbl_Prod where M_Id=" + cmbMachinid.Text.Trim() + "", conn);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    txtmname.Text = reader[1].ToString();
                    txtqty.Text = reader[2].ToString();
                    dateTimePicker1.Text = reader[3].ToString();
                    txtprice.Text = reader[4].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }

        private void butnpurchaseRep_Click(object sender, EventArgs e)
        {
            int qty = Int32.Parse(txtreq.Text.Trim());
            double price=Double.Parse(txtprice.Text.Trim());
            double res = qty * price;
            txttamount.Text = res.ToString();
        }

        private void butnpurDreset_Click(object sender, EventArgs e)
        {
            cmbMachinid.Text = "Select Id";
            txtmname.Text = "";
            txtqty.Text = "";
            dateTimePicker1.Text = System.DateTime.Now.ToShortDateString();
            txtprice.Text = "";
            txtreq.Text = "";
            txttamount.Text = "";
            dateTimePicker2.Text = System.DateTime.Now.ToShortDateString();
        }

        private void butnpurDSave_Click(object sender, EventArgs e)
        {
            if (state == ConnectionState.Open)
                conn.Close();
            else
            {
                conn.Open();
                query = new SqlCommand("insert into tbl_Pur values(" + cmbMachinid.Text.Trim() + ",'" + txtmname.Text.Trim() + "'," + txtqty.Text.Trim() + "," + txtprice.Text.Trim() + ",'" + dateTimePicker1.Text.Trim() + "'," + txtreq.Text.Trim() + "," + txttamount.Text.Trim() + ",'" + dateTimePicker2.Text.Trim() + "')", conn);
                reader = query.ExecuteReader();
                MessageBox.Show("All the records has been submitted successfully into the database...");
                reader.Close();
                conn.Close();
            }
        }
    }
}
