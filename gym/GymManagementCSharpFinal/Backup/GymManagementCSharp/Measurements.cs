using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient ;
namespace GymManagementCSharp
{
    public partial class Measurements : Form
    {
        DataConnection dc= new DataConnection ();
        public Measurements()
        {
            InitializeComponent();
        }

        private void Measurements_Load(object sender, EventArgs e)
        {
            TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
        TextBox6.Enabled = false;
        TextBox7.Enabled = false;
        TextBox8.Enabled = false;
        TextBox9.Enabled = false;
        TextBox10.Enabled = false;
        TextBox11.Enabled = false;
        TextBox12.Enabled = false;
        Button6.Enabled = false;
        Button1.Enabled = false;
        Button4.Enabled = false;
        Button2.Enabled = false;
        Button5.Enabled = false;
    
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dc.conn.Close();
            Button4.Enabled = true;
        Button2.Enabled = true;
        
        dc.cmd.Parameters.Clear();
        dc.cmd.CommandText = "select * from measurements where Id=@id";
        dc.cmd.Parameters.AddWithValue("@id", ComboBox2.Text);
        dc.conn.Open();
        dc.reader = dc.cmd.ExecuteReader();


        if(dc.reader.Read())
        {
            TextBox1.Text = dc.reader["height"].ToString ();
            TextBox7.Text = dc.reader["weight"].ToString ();

            TextBox2.Text = dc.reader["neck"].ToString ();
            TextBox8.Text = dc.reader["biceps"].ToString ();
            TextBox3.Text = dc.reader["forearms"].ToString ();
            TextBox9.Text = dc.reader["wrist"].ToString ();
            TextBox4.Text = dc.reader["waist"].ToString ();
            TextBox10.Text = dc.reader["chest"].ToString ();
            TextBox5.Text = dc.reader["hips"].ToString ();
            TextBox11.Text = dc.reader["thigh"].ToString ();
            TextBox6.Text = dc.reader["calves"].ToString ();
            TextBox12.Text = dc.reader["BMI"].ToString ();
        }
        else
        {
            MessageBox.Show("no reocrd, please add the entries");
            Button2.Enabled = false;
            Button6.Enabled = false;
            Button1.Enabled = false;
            Button5.Enabled = true;
        }
       dc. cmd.Parameters.Clear();
       dc.conn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button2.Enabled = false;
        Button4.Enabled = false;
        Button5.Enabled = false;
        Button1.Enabled = false;
        TextBox1.Enabled = true;
        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        TextBox5.Enabled = true;
        TextBox6.Enabled = true;
        TextBox7.Enabled = true;
        TextBox8.Enabled = true;
        TextBox9.Enabled = true;
        TextBox10.Enabled = true;
        TextBox11.Enabled = true;
        TextBox12.Enabled = true;
        Button6.Enabled = true;
        Button4_Click(null, null);
    
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
        Button6.Enabled = false;
        dc.conn.Close();
        dc.cmd.CommandText = "Update measurements set height=@height,weight=@weight,neck=@neck,biceps=@biceps,forearms=@forearms,wrist=@wrist,waist=@waist,chest=@chest,hips=@hips,thigh=@thigh,calves=@calves,bmi=@bmi where id=@id";
        dc.cmd.Parameters.AddWithValue("@height", TextBox1.Text);
        dc.cmd.Parameters.AddWithValue("@weight", TextBox7.Text);
        dc.cmd.Parameters.AddWithValue("@neck", TextBox2.Text);
        dc.cmd.Parameters.AddWithValue("@biceps", TextBox8.Text);
        dc.cmd.Parameters.AddWithValue("@forearms", TextBox3.Text);
        dc.cmd.Parameters.AddWithValue("@wrist", TextBox9.Text);
        dc.cmd.Parameters.AddWithValue("@waist", TextBox4.Text);
        dc.cmd.Parameters.AddWithValue("@chest", TextBox10.Text);

        dc.cmd.Parameters.AddWithValue("@hips", TextBox5.Text);
        dc.cmd.Parameters.AddWithValue("@thigh", TextBox11.Text);
        dc.cmd.Parameters.AddWithValue("@Calves", TextBox6.Text);
        dc.cmd.Parameters.AddWithValue("@bmi", TextBox12.Text);
        dc.cmd.Parameters.AddWithValue("@id", ComboBox2.Text);
        dc.conn.Open();
        int a = dc.cmd.ExecuteNonQuery();
        MessageBox.Show("Record updated");
        TextBox1.Clear();
        TextBox2.Clear();
        TextBox3.Clear();
        TextBox4.Clear();
        TextBox5.Clear();
        TextBox6.Clear();
        TextBox7.Clear();
        TextBox8.Clear();
        TextBox9.Clear();
        TextBox10.Clear();
        TextBox11.Clear();
        TextBox12.Clear();
        dc.conn.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Enabled = true;
        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        TextBox5.Enabled = true;
        TextBox6.Enabled = true;
        TextBox7.Enabled = true;
        TextBox8.Enabled = true;
        TextBox9.Enabled = true;
        TextBox10.Enabled = true;
        TextBox11.Enabled = true;
        TextBox12.Enabled = true;

        Button2.Enabled = false;
        Button4.Enabled = false;
        Button5.Enabled = false;
        Button1.Enabled = true;
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dc.conn.Close();
            Button1.Enabled = false;
        Button2.Enabled = true;
        Button4.Enabled = true;
        Button5.Enabled = true;
        
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "" || TextBox10.Text == "" || TextBox11.Text == "" || TextBox12.Text == "")
        {
            MessageBox.Show("enter all the details");
            TextBox1.Focus();
            return;
        }
       else
            {
            Button1.Enabled = true;
            dc.cmd.CommandText = "Insert into Measurements values('" + ComboBox2.Text + "','" + TextBox1.Text + "','" + TextBox7.Text + "','" + TextBox2.Text + "','" + TextBox8.Text + "','" + TextBox3.Text + "','" + TextBox9.Text + "','" + TextBox4.Text + "','" + TextBox10.Text + "','" + TextBox5.Text + "','" + TextBox11.Text + "','" + TextBox6.Text + "','" + TextBox12.Text + "')";
            dc.conn.Open();
            int i = dc.cmd.ExecuteNonQuery();
            MessageBox .Show ("Record is Updated");
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
            TextBox6.Clear();
            TextBox7.Clear();
            TextBox8.Clear();
            TextBox9.Clear();
            TextBox10.Clear();
            TextBox11.Clear();
            TextBox12.Clear();
            Button2.Enabled = false;
            Button5.Enabled = false;
            Button1.Enabled = false;


        }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dc.conn.Close();
            clear1();
        Button4.Enabled = true;
        Button2.Enabled = false;
        Button5.Enabled = false;
        Button6.Enabled = false;
        
        dc.cmd.CommandText = "select count(*) from new_record where sex='Male'";
        dc.conn.Open();
        int i = Convert.ToInt32 (dc.cmd.ExecuteScalar());
        if( i > 0)
        {
            String str = "Select Name, Id from new_record where sex='Male'";
            SqlDataAdapter ad = new SqlDataAdapter(str, dc.conn);
            DataSet ds =  new DataSet();
            ad.Fill(ds, "abc");
            ComboBox1.DataSource = ds.Tables["abc"];
            ComboBox1.DisplayMember = "Name";
            ComboBox2.DataSource = ds.Tables["abc"];
            ComboBox2.DisplayMember = "Id";
        }
        else
            MessageBox.Show("No records for Gender = Male");
        

        }

        private void clear1()
        {
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
        TextBox6.Enabled = false;
        TextBox7.Enabled = false;
        TextBox8.Enabled = false;
        TextBox9.Enabled = false;
        TextBox10.Enabled = false;
        TextBox11.Enabled = false;
        TextBox12.Enabled = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button4.Enabled = true;
        Button2.Enabled = false;
        Button6.Enabled = false;
        TextBox1.Clear();
        TextBox2.Clear();
        TextBox3.Clear();
        TextBox4.Clear();
        TextBox5.Clear();
        TextBox6.Clear();
        TextBox7.Clear();
        TextBox8.Clear();
        TextBox9.Clear();
        TextBox10.Clear();
        TextBox11.Clear();
        TextBox12.Clear();

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button4.Enabled = true;
        Button2.Enabled = false;
        Button6.Enabled = false;
        TextBox1.Clear();
        TextBox2.Clear();
        TextBox3.Clear();
        TextBox4.Clear();
        TextBox5.Clear();
        TextBox6.Clear();
        TextBox7.Clear();
        TextBox8.Clear();
        TextBox9.Clear();
        TextBox10.Clear();
        TextBox11.Clear();
        TextBox12.Clear();

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dc.conn.Close();
            clear1();
        Button4.Enabled = true;
        Button2.Enabled = false;
        Button5.Enabled = false;
        Button6.Enabled = false;
        
        dc.cmd.CommandText = "select count(*) from new_record where sex='Female'";
        dc.conn.Open();
        int i = Convert.ToInt32 (dc.cmd.ExecuteScalar());
       
        if (i > 0)
        {
            String str = "Select Name, Id from new_record where sex='Female'";
            SqlDataAdapter  ad= new SqlDataAdapter(str, dc.conn);
            DataSet ds  = new DataSet();
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

    }
}
