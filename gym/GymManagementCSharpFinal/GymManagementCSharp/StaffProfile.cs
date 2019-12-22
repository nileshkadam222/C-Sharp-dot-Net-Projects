using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GymManagementCSharp
{
    public partial class StaffProfile : Form
    {
        DataConnection dc = new DataConnection ();
        public StaffProfile()
        {
            InitializeComponent();
        }

        private void StaffProfile_Load(object sender, EventArgs e)
        {
            TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        Button3.Enabled = false;
        Button1.Enabled = false;
        Button2.Enabled = false;
        Button5.Enabled = false;
        ComboBox1.SelectedIndex = -1;
    
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Button1.Enabled = true;
        Button2.Enabled = true;

        
        dc.cmd.CommandText = "select count(*) from new_sentry where gender='Female'";
        int i = Convert.ToInt32 (dc.cmd.ExecuteScalar());
        if( i > 0 )
        {
            String str = "Select Name, Id from new_sentry where gender='Female'";
             SqlDataAdapter ad =new SqlDataAdapter(str, dc.conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "abc");
            ComboBox1.DataSource = ds.Tables["abc"];
            ComboBox1.DisplayMember = "Name";
            ComboBox2.DataSource = ds.Tables["abc"];
            ComboBox2.DisplayMember = "Id";
        }
        else
            MessageBox.Show("No records for Gender = Female");
        
        dc.conn.Close();
    
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button2.Enabled = true;


            dc.cmd.CommandText = "select count(*) from new_sentry where gender='Male'";
            int i = Convert.ToInt32(dc.cmd.ExecuteScalar());
            if (i > 0)
            {
                String str = "Select Name, Id from new_sentry where gender='Male'";
                SqlDataAdapter ad = new SqlDataAdapter(str, dc.conn);
                DataSet ds = new DataSet();
                ad.Fill(ds, "abc");
                ComboBox1.DataSource = ds.Tables["abc"];
                ComboBox1.DisplayMember = "Name";
                ComboBox2.DataSource = ds.Tables["abc"];
                ComboBox2.DisplayMember = "Id";
            }
            else
                MessageBox.Show("No records for Gender = Male");

            dc.conn.Close();
    
       
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dc.conn.Close();
            Button3.Enabled = true;
        
        dc.cmd.CommandText = "select * from new_sentry where Name=@name or Id=@id";
        

        dc.cmd.Parameters.AddWithValue("@name", ComboBox1.Text);
        dc.cmd.Parameters.AddWithValue("@id", ComboBox2.Text);
        dc.conn.Open();
        dc.reader = dc.cmd.ExecuteReader();

        if (dc.reader.Read())
        {
            TextBox1.Text = dc.reader["Address"].ToString ();
            TextBox2.Text = dc.reader["Qualification"].ToString ();
            TextBox3.Text = dc.reader["Position"].ToString ();
            TextBox4.Text = dc.reader["Mob.no"].ToString ();


        }
        dc.cmd.Parameters.Clear();
    
        }

        private void Button5_Click(object sender, EventArgs e)
        {
        dc.reader.Close();
        Button1.Enabled = true;
        Button2.Enabled = true;
        Button5.Enabled = false;
        dc.cmd.CommandText = "update new_sentry set address=@address, qualification=@qualification,position=@position,[mob.no]=@mob where name=@name or Id=@id";
        dc.cmd.Parameters.AddWithValue("@name", ComboBox1.Text);
        dc.cmd.Parameters.AddWithValue("@id", ComboBox2.Text);

        dc.cmd.Parameters.AddWithValue("@address", TextBox1.Text);
        dc.cmd.Parameters.AddWithValue("@qualification", TextBox2.Text);
        dc.cmd.Parameters.AddWithValue("@position", TextBox3.Text);
        dc.cmd.Parameters.AddWithValue("@mob", TextBox4.Text);
        int i = dc.cmd.ExecuteNonQuery();
        MessageBox.Show("Record Updated Successfully");
        dc.cmd.Dispose();
        dc.cmd.Parameters.Clear();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        dc.cmd.CommandText = "Delete from new_sentry where id = '" + ComboBox2.Text + "'";
        dc.cmd.ExecuteNonQuery();
        MessageBox.Show("Record deleted");
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
    int a = TextBox4.Text.Length;
        if(a < 10)
        {
            MessageBox.Show("10 digits");
            TextBox4.Focus();
        }
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
      
        TextBox1.Enabled = true;
        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        Button1.Enabled = false;
        Button2.Enabled = false;
        Button5.Enabled = true;

        dc.reader.Close();
        Button2_Click(null,null);
      
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
