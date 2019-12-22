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
    public partial class ModifySalaryRecords : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public ModifySalaryRecords()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            bool temp = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeSalary_Table where EmployeeId='" +empidcombo.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                empID_combo.Text = dr.GetInt32(0).ToString();
                Firstname_combo.Text = dr.GetString(1);
                Last_combo.Text = dr.GetString(2);
                desig_combo.Text = dr.GetString(3);
                reg_combo.Text = dr.GetInt32(4).ToString();
                group_combo.Text = dr.GetInt32(5).ToString();
                oneday_txt.Text = dr.GetDouble(6).ToString();
                Tworkday_txt.Text = dr.GetInt32(7).ToString();
                preday_txt.Text = dr.GetInt32(8).ToString();
                totalsal_txt.Text = dr.GetDouble(9).ToString();
                dateTimePicker1.Value = dr.GetDateTime(10);
                if (dr.GetString(11) == "Cheque Delivery")
                {
                 cheqradio_btn.Checked = true;
                }
                else
                {
                    Cashradio_btn.Checked = true;
                }
                
                cheqno_txt.Text = dr.GetInt32(12).ToString();
                paygiven_txt.Text = dr.GetString(13);
              
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();
           
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

        private void ModifySalaryRecords_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select Employee_Id, First_Name,Last_Name,Designation,Registration_no,Group_no from Employee_Table";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);

            empidcombo.DataSource = ds.Tables[0];
            firstnamecombo.DataSource = ds.Tables[0];
            empID_combo.DataSource=ds.Tables[0];
            Firstname_combo.DataSource=ds.Tables[0];
            Last_combo.DataSource = ds.Tables[0];
            desig_combo.DataSource=ds.Tables[0];
            reg_combo.DataSource=ds.Tables[0];
            group_combo.DataSource=ds.Tables[0];


            empidcombo.DisplayMember = "Employee_Id";
            firstnamecombo.DisplayMember = "First_Name";
            empID_combo.DisplayMember = "Employee_Id";
            Firstname_combo.DisplayMember = "First_Name";
            Last_combo.DisplayMember = "Last_Name";
            desig_combo.DisplayMember = "Designation";
            reg_combo.DisplayMember = "Registration_no";
            group_combo.DisplayMember = "Group_no";
            con.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
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
            if (Cashradio_btn.Checked == true)
            {
                cheqno_txt.Text = "0";
            }

            SqlCommand cmd = new SqlCommand("Update  EmployeeSalary_Table set EmployeeID='" + empID_combo.Text + "',First_Name='" + Firstname_combo.Text + "',Last_Name='" + Last_combo.Text + "',Designation='" + desig_combo.Text + "',Registration_Number='" + reg_combo.Text + "',Group_Number='" + group_combo.Text + "',One_Day_Salary='" + oneday_txt.Text + "',Total_Work_Day='" + Tworkday_txt.Text + "',Present_Day='" + preday_txt.Text + "',Total_Salary='" + totalsal_txt.Text + "',Date='" + dateTimePicker1.Value + "',Payment_Done_By='" + payment_det + "',Cheque_Number='" + cheqno_txt.Text + "',Payment_Given_By='" + paygiven_txt.Text + "' Where (EmployeeID='" + empID_combo.Text + "') ", con);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Record is updated......");
           
            oneday_txt.Clear();
            totalsal_txt.Clear();
            preday_txt.Clear();
            Tworkday_txt.Clear();
            totalsal_txt.Clear();
            paygiven_txt.Clear();
            cheqno_txt.Clear();
            
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from EmployeeSalary_Table where EmployeeID='" + empID_combo.Text + "'";
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
            oneday_txt.Clear();
            totalsal_txt.Clear();
            preday_txt.Clear();
            Tworkday_txt.Clear();
            totalsal_txt.Clear();
            paygiven_txt.Clear();
            cheqno_txt.Clear();
           
        }

        private void Totalsal_btn_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(oneday_txt.Text);
            b = Convert.ToDouble(preday_txt.Text);
            totalsal_txt.Text = (a * b).ToString();
        }
        
   

        private void cheqradio_btn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cheqradio_btn.Checked == true)
            {
                cheqno_txt.Show();
            }

        }

        private void Cashradio_btn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cashradio_btn.Checked == true)
            {
                cheqno_txt.Hide();

            }

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
