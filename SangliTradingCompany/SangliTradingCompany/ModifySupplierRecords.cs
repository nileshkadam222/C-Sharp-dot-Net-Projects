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
    public partial class ModifySupplierRecords : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        public ModifySupplierRecords()
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

        private void ModifySupplierRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Supplier_Table' table. You can move, or remove it, as needed.
            this.supplier_TableTableAdapter.Fill(this.database1DataSet.Supplier_Table);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Supplier_Table", con);
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
            supplierid_txt.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            suppfirstname_txt.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            suppLastname_txt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            compname_txt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            Address.Text= dataGridView1.Rows[i].Cells[4].Value.ToString();
            Mobile_no.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            Tel_no.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            EmailID.Text= dataGridView1.Rows[i].Cells[7].Value.ToString();
        
            con.Close();


        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "Update Supplier_Table set  SupplierID='" + supplierid_txt.Text + "',Supplier_First_Name ='" + suppfirstname_txt.Text + "',Supplier_Last_Name='" + suppLastname_txt.Text + "',Company_Name='" + compname_txt.Text + "',Address= '" + Address.Text + "',Mobile_Number='" + Mobile_no.Text + "',Tel_Number= '" + Tel_no.Text + "',EmailID='" + EmailID.Text + "' where(SupplierID ='" + supplierid_txt.Text + "')";
            SqlCommand update = new SqlCommand(cmd, con);
            update.ExecuteNonQuery();

            try
            {

                MessageBox.Show("Supplier info is updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            update = new SqlCommand("Select * from Supplier_Table", con);
            SqlDataAdapter adpt = new SqlDataAdapter(update);
            adpt.SelectCommand = update;
            DataTable datatb = new DataTable();
            adpt.Fill(datatb);
            BindingSource bind = new BindingSource();
            bind.DataSource = datatb;
            dataGridView1.DataSource = bind;
            adpt.Update(datatb);
            con.Close();
            supplierid_txt.Clear();
            suppfirstname_txt.Clear();
            suppLastname_txt.Clear();
            compname_txt.Clear();
            Address.Clear();
            Mobile_no.Clear();
            Tel_no.Clear();
            EmailID.Clear();
           
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Supplier_Table where SupplierID ='" + supplierid_txt.Text+ "'", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted..");
                cmd = new SqlCommand("Select * from Supplier_Table", con);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.SelectCommand = cmd;
                DataTable datatb = new DataTable();
                adpt.Fill(datatb);
                BindingSource bind = new BindingSource();
                bind.DataSource = datatb;
                dataGridView1.DataSource = bind;
                adpt.Update(datatb);
                con.Close();
                supplierid_txt.Clear();
                suppfirstname_txt.Clear();
                suppLastname_txt.Clear();
                compname_txt.Clear();
                Address.Clear();
                Mobile_no.Clear();
                Tel_no.Clear();
                EmailID.Clear();
              

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
