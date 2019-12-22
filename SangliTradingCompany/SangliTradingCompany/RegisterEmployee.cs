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
using System.Threading;
namespace SangliTradingCompany
{
    public partial class RegisterEmployee : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public RegisterEmployee()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }
        
        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Employee_ID),0) from Employee_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                empid_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Registration_no),0) from Employee_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                Regno_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Group_no),0) from Employee_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                Groupno_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
           
        }

        private void age_txt_KeyPress(object sender, KeyPressEventArgs e)
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
            con.Open();
            string gender;
        
            if (maleradio_btn.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string cmd = "insert into Employee_Table values('" + empid_txt.Text + "','" + empfirstname_txt.Text + "', '" + Fathername_txt.Text + "','" + lastname_txt.Text + "','" + gender + "','" + Dob_datetimepicker.Value + "','" + age_txt.Text + "','" + Add_txt.Text + "','" + mobno_txt.Text + "', '" + Designationcombo_box.Text + "','" + DojdateTimePicker.Value + "','" + Regno_txt.Text + "','" + Groupno_txt.Text + "')";
            SqlCommand insert = new SqlCommand(cmd, con);
            try
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Employee Details are registered successfully");
                age_txt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            empid_txt.Clear();
            empfirstname_txt.Clear();
            Fathername_txt.Clear();
            lastname_txt.Clear();
            age_txt.Clear();
            Add_txt.Clear();
            mobno_txt.Clear();
            Designationcombo_box.Text = "";
            Regno_txt.Clear();
            Groupno_txt.Clear();

            
        
        }

        private void Newentry_btn_Click(object sender, EventArgs e)
        {
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Employee_ID),0) from Employee_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                empid_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Registration_no),0) from Employee_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                Regno_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
            using (SqlCommand comd = new SqlCommand("Select isnull(max(Group_no),0) from Employee_Table", con))
            {
                con.Open();
                object result = comd.ExecuteScalar();
                con.Close();
                Groupno_txt.Text = (int.Parse(result.ToString()) + 1).ToString();
            }
            empfirstname_txt.Clear();
            Fathername_txt.Clear();
            lastname_txt.Clear();
            age_txt.Text = "";
            mobno_txt.Clear();
            Add_txt.Clear();
            Designationcombo_box.Text = "";
           
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void age_txt_TextChanged(object sender, EventArgs e)
        {
            DateTime curdate = DateTime.Now;
            DateTime setdate = Dob_datetimepicker.Value;
            int curyear = curdate.Year;
            int setyear = setdate.Year;
            age_txt.Text = (curyear - setyear).ToString();

        }

        private void mobno_txt_TextChanged(object sender, EventArgs e)
        {
            Regex re = new Regex("^9[0-9]{9}");

            if ( mobno_txt.Text.Length < 10 && mobno_txt.Text.Length>10)
            {
                MessageBox.Show("Invalid Indian Mobile Number !!");
                mobno_txt.Focus();
            }


        }

        private void Designationcombo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mobno_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        }

       
    }
