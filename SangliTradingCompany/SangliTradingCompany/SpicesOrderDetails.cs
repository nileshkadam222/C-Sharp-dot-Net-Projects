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
    public partial class SpicesOrderDetails : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public SpicesOrderDetails()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }
        private void validTextChar(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {
                //Not Allowing Numbers
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3', 
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }
        private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
        {
            for (int i = 0; i < UnallowedCharacters.Length; i++)
                if (T.Contains(UnallowedCharacters[i]))
                    return true;

            return false;
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void serno_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsDigit(e.KeyChar)
                     )
            {
                e.Handled = true;
            }

        }
        private void validTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }
        private void SpicesOrderDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ProductID,ProductName from SpicesTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            proid_combo.DataSource = ds.Tables[0];
            proname_combo.DataSource = ds.Tables[0];

            proid_combo.DisplayMember = "ProductID";
            proname_combo.DisplayMember = "ProductName";
            con.Close();

            con.Open();
            string query1 = "select SupplierID,Supplier_First_Name from Supplier_Table";
            SqlDataAdapter da1 = new SqlDataAdapter(query1, con);
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            da1.Fill(ds1);
            da1.Fill(dt1);

            suppid_combo.DataSource = ds1.Tables[0];
            suppname_combo.DataSource = ds1.Tables[0];

            suppid_combo.DisplayMember = "SupplierID";
            suppname_combo.DisplayMember = "Supplier_First_Name";
            con.Close();

        }

        private void total_amount_Click(object sender, EventArgs e)
        {
            decimal a, b;
            a = Convert.ToDecimal(weight_txt.Text);
            b = Convert.ToDecimal(unitprice_txt.Text);
            total_txt.Text = (a * b).ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "insert into SpicesOrderDetails_Table1 values('" + proid_combo.Text + "','" + proname_combo.Text + "', '" + quantity_txt.Text + "','" + boxes_txt.Text + "','" + weight_txt.Text + "','" + unitprice_txt.Text + "','" + suppid_combo.Text + "','" + suppname_combo.Text + "','" + dateTimePicker1.Value + "','" + total_txt.Text + "' )";
            SqlCommand insert = new SqlCommand(cmd, con);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Purches Order Details are registered successfully...............");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            quantity_txt.Clear();
            boxes_txt.Clear();
            weight_txt.Clear();
            unitprice_txt.Clear();
            total_txt.Clear();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
