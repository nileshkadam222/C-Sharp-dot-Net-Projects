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
    public partial class StaffDetails : Form
    {
        DataConnection dc = new DataConnection();
        int i;
        String strcon,g;
    String sqlq;
    String a, b, c;
    
        public StaffDetails()
        {
            InitializeComponent();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
         
        Button1.Enabled = false;
        Button5.Enabled = false;
        Button6.Enabled = false;
        TextBox1.Enabled = false;

        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
        textBox6.Enabled = false;
        TextBox7.Enabled = false;
        RadioButton1.Enabled = false;
        RadioButton2.Enabled = false;
        
   
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Enabled = true;

        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        TextBox5.Enabled = true;
        textBox6.Enabled = false;
        TextBox7.Enabled = true;
        RadioButton1.Enabled = true;
        RadioButton2.Enabled = true;
        Button4.Enabled = false;
        TextBox1.Clear();
        TextBox2.Clear();
        TextBox3.Clear();
        TextBox4.Clear();
        TextBox5.Clear();
        textBox6.Clear();
        TextBox7.Clear();
        textBox6.Focus();
        Button1.Enabled = true;
        Button3.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        int id;
        dc.cmd.CommandText = "select count(*) from new_sentry";
        int i = Convert.ToInt32 (dc.cmd.ExecuteScalar());
        if( i < 0)
            id = 1;
        else

            id = i + 1;
        textBox6 .Text = id.ToString ();
        Button1.Enabled = false;
        Button4.Enabled = true;
        Button3.Enabled = true;
        
        String q;
        //TextBox6.Text = id;
        if (textBox6.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || (RadioButton1.Checked == false && RadioButton2.Checked == false))
            MessageBox.Show  ("Please enter the valid values in each field");
        else
        {
            if( RadioButton1.Checked == true)
                g = "Male";
            else
                g = "Female";
           
            dc.cmd.CommandText = "Insert into New_SEntry values('" + id + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + g + "','" + TextBox7.Text + "')";
            textBox6.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        
        int i1 = dc.cmd.ExecuteNonQuery();
        MessageBox .Show ("Record is Updated");

        }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        textBox6.Enabled = false;
        Button4.Enabled = true;
        Button5.Enabled = true;
        
        String str = "select name, Id from new_sentry";
        SqlDataAdapter  ad =  new SqlDataAdapter(str, dc.conn);
        DataSet  ds = new DataSet();
        ad.Fill(ds, "abc");
        ComboBox1.DataSource = ds.Tables["abc"];
        ComboBox1.DisplayMember = "Name";
        
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button6.Enabled = true;
        Button5.Enabled = false;
        Button3.Enabled = false;
        Button4.Enabled = false;
        TextBox1.Enabled = true;

        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        TextBox5.Enabled = true;
        TextBox7.Enabled = true;

        dc.cmd.CommandText = "select * from new_sentry where Name=@name";
        
        dc.cmd.Parameters.AddWithValue("@name", ComboBox1.Text);

        dc.reader = dc.cmd.ExecuteReader();

        if(dc.reader.Read())
            {
            TextBox1.Text = dc.reader["Name"].ToString ();
            TextBox2.Text = dc.reader["Address"].ToString ();
            TextBox3.Text = dc.reader["Qualification"].ToString ();
            TextBox4.Text = dc.reader["Position"].ToString ();
            TextBox5.Text = dc.reader["Mob.no"].ToString ();
            textBox6.Text = dc.reader["id"].ToString ();
            TextBox7.Text = dc.reader["Salary"].ToString();
            if( dc.reader["gender"].ToString() == "Male")
                RadioButton1.Checked = true;
            else
                RadioButton1.Checked = false;
            }

   
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dc.conn.Close();
        Button4.Enabled = true;
        Button3.Enabled = true;
        Button6.Enabled = false;
        Button5.Enabled = false;
        

        dc.cmd.CommandText = "update new_sentry set address=@address, qualification=@qualification,position=@position,[mob.no]=@mob, salary=@salary where name=@name";
        
        dc.cmd.Parameters.AddWithValue("@address", TextBox2.Text);
        dc.cmd.Parameters.AddWithValue("@qualification", TextBox3.Text);
        dc.cmd.Parameters.AddWithValue("@position", TextBox4.Text);
        dc.cmd.Parameters.AddWithValue("@mob", TextBox5.Text);
        dc.cmd.Parameters.AddWithValue("@salary", TextBox7.Text);
        dc.conn.Open();
        int i = dc.cmd.ExecuteNonQuery();
        MessageBox.Show("Record Updated Successfully");
        dc.cmd.Dispose();
        dc.cmd.Parameters.Clear();

        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            int a = TextBox5.Text.Length;
            if (a < 10)
            {
                MessageBox.Show("10 digits");
                TextBox5.Focus();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
