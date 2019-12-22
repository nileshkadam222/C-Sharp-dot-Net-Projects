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
    public partial class ModifiedEmployeeDetail : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public ModifiedEmployeeDetail()
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

        private void ModifiedEmployeeDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employee_Table' table. You can move, or remove it, as needed.
            this.employee_TableTableAdapter.Fill(this.database1DataSet.Employee_Table);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Employee_Table", con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.SelectCommand = cmd;
            DataTable datatb = new DataTable();
            adpt.Fill(datatb);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatb;
            dataGridView1.DataSource = bind;
            adpt.Update(datatb);
            con.Close();

        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            int i;
            
            i = dataGridView1.SelectedCells[0].RowIndex;
            empid_txt.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            empfirstname_txt.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            Fathername_txt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            lastname_txt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Male")
            {
                maleradio_btn.Checked = true;

            }
            else
            {
                Femaleradio_btn.Checked = true;
            }
            
            Dob_datetimepicker.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value);
            age_txt.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            Add_txt.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            mobno_txt.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            Designationcombo_box.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            DojdateTimePicker.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[10].Value);

            Regno_txt.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            Groupno_txt.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
            
            con.Close();

        }

        private void Update_btn_Click(object sender, EventArgs e)
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


            string cmd = "Update Employee_Table set Employee_ID ='" + empid_txt.Text + "',First_Name ='" + empfirstname_txt.Text + "',Fathers_Name='" + Fathername_txt.Text + "',Last_Name= '" + lastname_txt.Text + "',Gender='" + gender + "',Date_of_Birth='" + Dob_datetimepicker.Value + "',Age='" + age_txt.Text + "',Address='" + Add_txt.Text + "',Mobile_no='" + mobno_txt.Text + "',Designation= '" + Designationcombo_box.Text + "',Date_of_Joining='" + DojdateTimePicker.Value + "',Registration_no='"+Regno_txt.Text+"',Group_no='"+Groupno_txt.Text+"' where(Employee_ID ='" + empid_txt.Text + "')";
            SqlCommand update = new SqlCommand(cmd, con);
            update.ExecuteNonQuery();

            try
            {

                MessageBox.Show("Employee info is updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            update = new SqlCommand("Select * from Employee_Table", con);
            SqlDataAdapter adpt = new SqlDataAdapter(update);
            adpt.SelectCommand = update;
            DataTable datatb = new DataTable();
            adpt.Fill(datatb);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatb;
            dataGridView1.DataSource = bind;
            adpt.Update(datatb);
            con.Close();

           
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("delete from  Employee_Table where Employee_ID ='" + empid_txt.Text + "'", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted..");
                cmd = new SqlCommand("Select * from Employee_Table", con);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.SelectCommand = cmd;
                DataTable datatb = new DataTable();
                adpt.Fill(datatb);
                BindingSource bind = new BindingSource();
                bind.DataSource = datatb;
                dataGridView1.DataSource = bind;
                adpt.Update(datatb);
                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      

       
    }
}
