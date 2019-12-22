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
    public partial class UpdateSpices : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public UpdateSpices()
        {
            InitializeComponent();
             con = new SqlConnection(c);
        }

       
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private void UpdateSpices_Load(object sender, EventArgs e)
        {
         

            con.Open();
            string query = "select ProductID,ProductName from SpicesTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            prodIDcombo2.DataSource = ds.Tables[0];
            pronamecomb2.DataSource = ds.Tables[0];

            prodIDcombo2.DisplayMember = "ProductID";
            pronamecomb2.DisplayMember = "ProductName";
            con.Close();
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            bool temp = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from SpicesTable where ProductName='" + pronamecomb2.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                serno_txt.Text = dr.GetInt32(0).ToString();
                proid_txt.Text = dr.GetString(1);
                Proname_cmbo.Text = dr.GetString(2);
                quan_txt.Text = dr.GetInt32(3).ToString();
                Box_txt.Text = dr.GetInt32(4).ToString();
                weight_txt.Text = dr.GetDouble(5).ToString();
                price_txt.Text = dr.GetDecimal(6).ToString();
                dateTimePicker1.Value = dr.GetDateTime(7);
                dateTimePicker2.Value = dr.GetDateTime(8);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();


        }


        private void Update_btn_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand cmd = new SqlCommand("Update  SpicesTable set SerialNumber='" + serno_txt.Text + "',ProductID='" + proid_txt.Text + "',ProductName='" + Proname_cmbo.Text + "',Quantity='" + quan_txt.Text + "',PacketsORBoxes='" + Box_txt.Text + "',Weight='" + weight_txt.Text + "',Price='" + price_txt.Text + "',OrderDate='" + dateTimePicker1.Value + "',ExpiredDate='" + dateTimePicker2.Value + "' Where (ProductName='" + Proname_cmbo.Text + "') ", con);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Record is updated......");
            serno_txt.Text = "";
            proid_txt.Clear();
            quan_txt.Clear();
            Box_txt.Clear();
            price_txt.Clear();
            weight_txt.Clear();
            Proname_cmbo.Text = "";
            pronamecomb2.Text = "";
            prodIDcombo2.Text = "";

   

        }

       

    }
}
