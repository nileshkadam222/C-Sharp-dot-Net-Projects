using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace SangliTradingCompany
{
    public partial class RegistrationOfCustomer : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public RegistrationOfCustomer()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "insert into Customer_Table values('" + Customername_txt.Text + "','" + Customerlast_txt.Text + "', '" + CompanyName1.Text + "','" + Address.Text + "','" + City.Text + "','" + State.Text + "','" + Country.Text + "','" + Mobile_no.Text + "','" + Tel_no.Text + "', '" + EmailID.Text + "')";
            SqlCommand insert = new SqlCommand(cmd, con);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Customer Details are registered successfully...............");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            Customername_txt.Clear();
            Customerlast_txt.Clear();
            CompanyName1.Clear();
            Address.Clear();
            City.Text = "";
            State.Text = "";
            Country.Text = "";
            Mobile_no.Clear();
            Tel_no.Clear();
            EmailID.Clear();
            
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EmailID_TextChanged(object sender, EventArgs e)
        {
            string s = "[a-z0-9A-z]@[a-zA-z0-9 ]*[.]";
            string s1 = EmailID.Text.ToString();
            Match aa = Regex.Match(s1, s);
            if (aa.Success)
            {
                errorProvider1.SetError(EmailID, "");
            }
            else
            {
                errorProvider1.SetError(EmailID, "mail id not in correct format");
            }
        }

        
    }
}
