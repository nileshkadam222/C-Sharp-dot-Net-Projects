using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections ;
namespace GymManagementCSharp
{
    public partial class Attendance : Form
    {
        int f = 0;
    SqlDataAdapter adapter = new SqlDataAdapter();
    DataSet ds;
    
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
        Button1.Enabled = true;
        Button2.Enabled = true;
        Button4.Enabled = true;
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        Button1.Enabled = false;
        Button2.Enabled = false;
        Button4.Enabled = true;
        DataConnection dc = new DataConnection ();
        
        dc.cmd.CommandText = "Select * from m_attendance where date ='" + DateTime.Now.Date + "' and flag='e'";
        
        dc.reader = dc.cmd.ExecuteReader();
        if (dc.reader.HasRows)
        {
           DialogResult response = MessageBox.Show("Data entry already done/checked. Want to modify?....", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if( response == DialogResult.Yes)
            {
                dc.reader.Close();
                goto ten;
            }
            
        }
        else
        {
            dc.reader.Close();
            dc.cmd.CommandText = "select id from new_record";
            dc.reader = dc.cmd.ExecuteReader();
            dc.cmd.Dispose();
            SqlCommand cmd1 = new SqlCommand ();
            cmd1.Connection = dc.conn;
            ArrayList id1= new ArrayList();
            int  i = 0;
            while( dc.reader.Read())

                id1.Add(dc.reader["id"]);
            
            dc.reader.Close();
            int c = id1.Count;
            while( i < c)
            {
                cmd1.CommandText = "Insert into m_attendance values ('" + id1[i] + "','','" + DateTime.Now.Date + "','e')";
                int n  = cmd1.ExecuteNonQuery();
                i = i + 1;
            }
            cmd1.Dispose();
        //    DataConnection dc1 = new DataConnection ();
            dc.reader.Close();
        }    
        ten:String str = "Select * from m_attendance where date ='" + DateTime.Now.Date + "'";
            dc.reader.Close();
            
            adapter = new SqlDataAdapter(str, dc.conn);
            
            ds = new DataSet();
            adapter.Fill(ds, "abc");
            DataGridView1.DataSource = ds.Tables["abc"];
            DataGridView1.Columns["id"].ReadOnly = true;
            f = 1;
            
        //}
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        Button4.Enabled = false;
        SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
        DataConnection dc = new DataConnection ();
//        if (f==1)

    //        adapter.Update(ds.Tables[0]);
  //      else
            adapter.Update(ds.Tables[0]);
        
        dc.cmd.CommandText = "update m_attendance set flag = 'e' where date = '" + DateTime.Now.Date + "' and attendance <> ''";
        int n = dc.cmd.ExecuteNonQuery();
        Button1.Enabled = true;
        Button2.Enabled = true;
    
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        Button2.Enabled = false;
        Button1.Enabled = false;
        Button4.Enabled = true;
        String str = "Select * from m_attendance where date ='" + DateTime.Now.Date + "'";
        DataConnection dc = new DataConnection ();
        
        adapter = new SqlDataAdapter(str, dc.conn);
        ds = new DataSet();
        adapter.Fill(ds, "abc");
        DataGridView1.DataSource = ds.Tables["abc"];
        DataGridView1.Columns["id"].ReadOnly = true;
        f = 0;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( ((int)(e.KeyChar) == 97) || ((int)(e.KeyChar) == 112) || ((int)(e.KeyChar) == 8))
            e.Handled = false;
        else
            e.Handled = true;
        
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);

        }
        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)(e.KeyChar) == 97) || ((int)(e.KeyChar) == 112) || ((int)(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;


            if (e.KeyChar == (char)Keys.A)
            {

                e.Handled = true;

                return;

            }




        }

        private void DataGridView1_Leave(object sender, EventArgs e)
        {

        }


    }
}
