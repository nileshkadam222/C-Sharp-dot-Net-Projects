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
    public partial class EmployeeSalary : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public EmployeeSalary()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void cheqradio_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (cheqradio_btn.Checked == true)
            {
                cheqno_txt.Show();
            }
           
        }

        private void Cashradio_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Cashradio_btn.Checked == true)
            {
                cheqno_txt.Hide();
               
            }
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

        private void EmployeeSalary_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select Employee_ID, First_Name,Last_Name,Designation,Registration_no,Group_no from Employee_Table";
            //addcon = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            empID_combo.DataSource = ds.Tables[0];
              Firstname_combo.DataSource = ds.Tables[0];
           Last_combo.DataSource = ds.Tables[0];
            desig_combo.DataSource=ds.Tables[0];
            reg_combo.DataSource=ds.Tables[0];
            group_combo.DataSource=ds.Tables[0];

            empID_combo.DisplayMember="Employee_ID";
            Firstname_combo.DisplayMember = "First_Name";
            Last_combo.DisplayMember = "Last_Name";
            desig_combo.DisplayMember = "Designation";
            reg_combo.DisplayMember = "Registration_no";
            group_combo.DisplayMember = "Group_no";
            con.Close();
            
        }

        private void Totalsal_btn_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(oneday_txt.Text);
            b = Convert.ToDouble(preday_txt.Text);
            totalsal_txt.Text = (a * b).ToString();
        }

        private void desig_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (desig_combo.SelectedItem.ToString() == "Manager")
            {
                oneday_txt.Text = "5000";
            }
            else if (desig_combo.SelectedItem.ToString() == "Accountant")
            {
                oneday_txt.Text = "3000";
            }
            else if (desig_combo.SelectedItem.ToString() == "Worker")
            {
                oneday_txt.Text = "500";
            }
            else
            {
                oneday_txt.Text = "";
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string payment_det;

            if (Cashradio_btn.Checked == true)
            {
                payment_det = "Cash Delivery";
            }
            else
            {
                payment_det = "Cheque Delivery";
            }
            string cmd = "insert into EmployeeSalary_Table values('" + empID_combo.Text + "','" + Firstname_combo.Text + "', '" + Last_combo.Text + "','" + desig_combo.Text + "','" + reg_combo.Text + "','" + group_combo.Text + "','" + oneday_txt.Text + "','"+ Tworkday_txt.Text+"','"+preday_txt.Text+"','" + totalsal_txt.Text + "','" + dateTimePicker1.Value + "', '" + payment_det + "','" + cheqno_txt.Text + "','" + paygiven_txt.Text + "')";
            SqlCommand insert = new SqlCommand(cmd, con);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Employee"+Firstname_combo.Text+"...Salary Details are registered successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            empID_combo.Text = "";
            Firstname_combo.Text = "";
            Last_combo.Text = "";
            desig_combo.Text = "";
            reg_combo.Text = "";
            group_combo.Text = "";
            oneday_txt.Clear();
            Tworkday_txt.Clear();
            preday_txt.Clear();
            totalsal_txt.Clear();
            paygiven_txt.Clear();
            cheqno_txt.Text = "";

           
        }

       
    }
}
