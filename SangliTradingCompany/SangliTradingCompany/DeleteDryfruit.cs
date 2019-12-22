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
    public partial class DeleteDryfruit : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
       
        public DeleteDryfruit()
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


        private void DeleteDryfruit_Load(object sender, EventArgs e)
        {
            prodIDcombo2.Text = "";
            pronamecomb2.Text = "";
            con.Open();
            string query = "select ProductID,ProductName from DryFruitTable";
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
            SqlCommand cmd = new SqlCommand("select * from DryFruitTable where ProductName='" + pronamecomb2.Text + "'", con);
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from DryFruitTable where ProductName='" + Proname_cmbo.Text + "'";
            try
            {
                con.Open();//establishes phy link between App and DB
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted..");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
