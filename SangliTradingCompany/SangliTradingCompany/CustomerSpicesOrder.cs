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
    public partial class CustomerSpicesOrder : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public CustomerSpicesOrder()
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


        private void CustomerSpicesOrder_Load(object sender, EventArgs e)
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
            string query1 = "select Customer_First_Name,Company_Name from Customer_Table";
            SqlDataAdapter da1 = new SqlDataAdapter(query1, con);
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            da1.Fill(ds1);
            da1.Fill(dt1);

            Custname_combo.DataSource = ds1.Tables[0];
            compname_combo.DataSource = ds1.Tables[0];

            Custname_combo.DisplayMember = "Customer_First_Name";
            compname_combo.DisplayMember = "Company_Name";
            con.Close();

        }

        private void total_btn_Click(object sender, EventArgs e)
        {
            decimal a, b;
            a = Convert.ToDecimal(weight_txt.Text);
            b = Convert.ToDecimal(unitprice_txt.Text);
            totalamount_txt.Text = (a * b).ToString();
        }

        private void balance_btn_Click(object sender, EventArgs e)
        {
            decimal c, d;
            c = Convert.ToDecimal(totalamount_txt.Text);
            d = Convert.ToDecimal(paidamount_txt.Text);
            Balance_txt.Text = (c - d).ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string payment_det;

            if (cashradio_btn.Checked == true)
            {
                payment_det = "Cash Delivery";
            }
            else
            {
                payment_det = "Cheque Delivery";
            }
            string cmd = "insert into CustomerSpicesinvoice_Table values('" + Custname_combo.Text + "','" + compname_combo.Text + "', '" + Convert.ToInt32(proid_combo.Text) + "','" + proname_combo.Text + "','" + quantity_txt.Text + "','" + Boxes_txt.Text + "','" + weight_txt.Text + "','" + unitprice_txt.Text + "','" + totalamount_txt.Text + "','" + payment_det + "','" + chequeno_txt.Text + "', '" + dateTimePicker1.Value + "','" + paidamount_txt.Text + "','" + Balance_txt.Text + "')";
            SqlCommand insert = new SqlCommand(cmd, con);

            insert.ExecuteNonQuery();
            MessageBox.Show(" Details are Save successfully...................");


            con.Close();
            quantity_txt.Clear();
            Boxes_txt.Clear();
            weight_txt.Text = "";
            unitprice_txt.Clear();
            totalamount_txt.Clear();
            chequeno_txt.Clear();
            paidamount_txt.Clear();
            Balance_txt.Clear();
        }

        private void chequeradio_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (chequeradio_btn.Checked == true)
            {
                chequeno_txt.Show();
            }
        }

        private void cashradio_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (cashradio_btn.Checked == true)
            {
                chequeno_txt.Hide();
                chequeno_txt.Text = "-";

            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
