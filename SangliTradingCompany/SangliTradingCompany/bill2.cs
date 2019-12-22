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
    public partial class bill2 : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public bill2()
        {
             con = new SqlConnection(c);
            InitializeComponent();
        }
      

        private void bill2_Load(object sender, EventArgs e)
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
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Bill_Number),0) from bill_table1", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                bill_number.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
          
        }

     

       

        private void Save_btn_Click(object sender, EventArgs e)
        {
          
            con.Open();
            string cmd = "insert into bill_table1 values('" + Firstname_combo.Text + "','" + lastname_combo.Text + "', '" + comp_combo.Text + "','" + add_txt.Text + "','" + bill_number.Text + "','" + dateTimePicker1.Value + "','" + proname1_combo.Text + "','" + q1_txt.Text + "','" + netkg1_txt.Text + "','" + price1_txt.Text + "' ,'" + amount1_txt.Text + "')";
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
           
            q1_txt.Clear();
           
            netkg1_txt.Clear();
         
            price1_txt.Clear();
        
            amount1_txt.Clear();
            
 
        }

        private void new_btn_Click_1(object sender, EventArgs e)
        {
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Bill_Number),0) from bill_table1", con))
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


        private void amount_Click(object sender, EventArgs e)
        {
           amount1_txt.Text=(Convert.ToDecimal(netkg1_txt.Text) * Convert.ToDecimal(price1_txt.Text)).ToString();
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

      
       
        }
    }

