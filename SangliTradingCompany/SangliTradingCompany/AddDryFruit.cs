using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SangliTradingCompany
{
    public partial class AddDryFruit : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public AddDryFruit()
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

 
        private void Save_btn_Click(object sender, EventArgs e)
        {

            if (serno_txt.Text != "" && proid_txt.Text != "" && Proname_cmbo.Text != "" && quan_txt.Text != "" && Box_txt.Text != "" && weight_txt.Text != "" && price_txt.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into DryFruitTable values(@SerialNumber,@ProductID,@ProductName,@Quantity,@Box,@Weight,@Price,@OrderDate,@ExpiredDate)", con);
                cmd.Parameters.AddWithValue("@SerialNumber", serno_txt.Text);
                cmd.Parameters.AddWithValue("@ProductID", proid_txt.Text);
                cmd.Parameters.AddWithValue("@ProductName", Proname_cmbo.Text);
                cmd.Parameters.AddWithValue("@Quantity", quan_txt.Text);
                cmd.Parameters.AddWithValue("@Box", Box_txt.Text);
                cmd.Parameters.AddWithValue("@Weight", weight_txt.Text);
                cmd.Parameters.AddWithValue("@Price", price_txt.Text);
                cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ExpiredDate", dateTimePicker2.Value);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record are saved sucessfully");

                con.Close();
                proid_txt.Clear();
                quan_txt.Clear();
                Box_txt.Clear();
                price_txt.Clear();
                weight_txt.Clear();
                Proname_cmbo.Text = "";
            }
            else
            { MessageBox.Show("Please enter the value"); }
        
         


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


       
        private void AddDryFruit_Load(object sender, EventArgs e)
        {
            MDIParent1 f = new MDIParent1();
            f.Hide();

            using (SqlCommand comd = new SqlCommand("Select isnull(max(SerialNumber),0) from DryFruitTable", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                serno_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
           
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Newentry_btn_Click(object sender, EventArgs e)
        {
            proid_txt.Clear();
            quan_txt.Clear();
            Box_txt.Clear();
            price_txt.Clear();
            weight_txt.Clear();
            Proname_cmbo.Text = "";

            using (SqlCommand comd = new SqlCommand("Select isnull(max(SerialNumber),0) from DryFruitTable", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                serno_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
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

        private void Proname_cmbo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Proname_cmbo.SelectedItem.ToString() == "Badam")
            {
                price_txt.Text = "390.50";
            }
            else if (Proname_cmbo.SelectedItem.ToString() == "Kaju")
            {
                price_txt.Text = "350";
            }
            else if (Proname_cmbo.SelectedItem.ToString() == "Khajoor")
            {
                price_txt.Text = "300.50";
            }
            else if (Proname_cmbo.SelectedItem.ToString() == "Pista")
            {
                price_txt.Text = "400.50";
            }
            else if (Proname_cmbo.SelectedItem.ToString() == "Kishmish")
            {
                price_txt.Text = "450";
            }
            else if (Proname_cmbo.SelectedItem.ToString() == "Akhrot")
            {
                price_txt.Text = "460.50";
            }
            else
            {
                price_txt.Text = "";
            }





        }

     
    }
}
