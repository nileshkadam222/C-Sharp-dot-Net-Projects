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
    public partial class MemberEnroll : Form
    {
    DataConnection dc=new DataConnection ();
    String dura;
    String dura1;
    int flag = 0;
    int d;
    DateTime d1;
    
        public MemberEnroll()
        {
            InitializeComponent();
        }

        private void MemberEnroll_Load(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now.Date;
       
        
        dc.cmd.CommandText = "select * from new_record where duedate < '" + DateTime.Now + "'";
        //MessageBox.Show(dc.cmd.CommandText);
        dc.reader = dc.cmd.ExecuteReader();
        if( dc.reader.HasRows)
        {
            MessageBox.Show("yes");
            dc.reader.Close();
            dc.cmd.CommandText = "delete from new_record where duedate < '" + DateTime.Now + "'";
            dc.cmd.ExecuteNonQuery();
        }

        dc.reader.Close();
        TextBox1.Focus();
        Button1.Enabled = false;
        TextBox1.Enabled = false;
        Label20.Text = DateTime.Today.ToString ();
        String str = "Select pcode from package";
         SqlDataAdapter ad = new SqlDataAdapter (str, dc.conn);
        DataSet ds = new DataSet();
        ad.Fill(ds, "abc");
        ComboBox2.DataSource = ds.Tables["abc"];
        ComboBox2.DisplayMember = "PCode";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dc.reader.Close();
            dc.conn.Close();
            if (TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || (RadioButton1.Checked == false && RadioButton2.Checked == false)) 
            {
            MessageBox.Show("Enter all the details");
            TextBox1.Focus();
            return;
            }
        TextBox1.Enabled = false;
        
        dc.cmd.CommandText = "select count(*) from new_record";
        dc.conn.Open();
        int  i = Convert.ToInt32 (dc.cmd.ExecuteScalar ());
        int id = i + 1;
        TextBox1.Text = id.ToString ();
        String g;
        if(RadioButton1.Checked == true)
            g = "Male";
        else
            g = "Female";
        if(ComboBox2.Text.Length==3)

        dura = ComboBox2.Text.ToString().Substring(ComboBox2.Text.Length - 1, 1);
        else
            dura = ComboBox2.Text.ToString().Substring(ComboBox2.Text.Length - 2, 2);
        dura1 = dura + "Month";
        String ptr;
        if(CheckBox5.Checked == true)
            ptr = "Yes";
        else
            ptr = "No";
        

        dc.cmd.CommandText = "Insert into new_record values ('" + id + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + g + "','" + TextBox7.Text + "','" + TextBox4.Text + "','" + DateTime.Now.Date + "','" + ComboBox2.Text + "','" + dura1 + "'," + Label14.Text + ",'" + d1.Date + "'," + Label16.Text + ",'" + ptr + "')";
        int i1 = dc.cmd.ExecuteNonQuery();
        MessageBox.Show("Please inform the member his ID....." + id.ToString());
        dc.name1 = TextBox2.Text;
       // billreport.Show();
    
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dc.reader.Close();
        Button1.Enabled = true;
        dc.cmd.CommandText = "select charges from package where pcode='" + ComboBox2.Text + "'";
        dc.reader = dc.cmd.ExecuteReader();
        if(dc.reader.Read())
            Label14.Text = dc.reader["charges"].ToString ();
        
        dc.reader.Close();
        if(CheckBox5.Checked == true)
        {
            dc.cmd.CommandText = "select pTrainer from package where pcode='" + ComboBox2.Text + "'";
            dc.reader = dc.cmd.ExecuteReader();
            if(dc.reader.Read())
                Label19.Text = dc.reader["ptrainer"].ToString ();
            
        else
            Label19.Text = "0";
        }
        Label16.Text = (Convert.ToInt32 (Label14.Text) + Convert.ToInt32 (Label19.Text)).ToString ();
        int ln = ComboBox2.Text.Length;
        if(ln == 3)
            dura = ComboBox2.Text.ToString().Substring(ComboBox2.Text.Length - 1, 1);
        else if(ln == 4)
            dura = ComboBox2.Text.ToString().Substring(ComboBox2.Text.Length - 2, 2);
        
        dura1 = dura + "Month";

        d = Convert.ToInt32(dura);

        d1 = DateTime.Now.AddMonths(d);
        //TextBox8.Text = FormatDateTime(d1.Date, DateFormat.ShortDate)
        TextBox8.Text = d1.Date.ToShortDateString ();

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
               int a = TextBox3.Text.Length;
               if (a < 10)
               {
                   MessageBox.Show("10 digits");
                   TextBox3.Focus();
               }
    
        }

        private void TextBox5_Validated(object sender, EventArgs e)
        {
                int a = Convert.ToInt32 (TextBox5.Text);
        if (a < 18 || a > 65) 
        {
            MessageBox.Show("range = 18-65");
            TextBox5.Focus();
        }

        }

        private void TextBox6_Validated(object sender, EventArgs e)
        {
    int b = Convert.ToInt32 (TextBox6.Text);
        if (b < 30)
        {
            MessageBox.Show("Weight is very less, cant join Gym");
            TextBox6.Focus();
        }
        
    
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
