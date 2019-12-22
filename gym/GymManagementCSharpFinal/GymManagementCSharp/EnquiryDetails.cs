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
    public partial class EnquiryDetails : Form
    {
         int i;
         String n;
        public EnquiryDetails()
        {
            InitializeComponent();
        }

        private void EnquiryDetails_Load(object sender, EventArgs e)
        {
        DataConnection dc = new DataConnection ();
        String str = "Select * from new_enquiry";
        SqlDataAdapter ad = new SqlDataAdapter(str, dc.conn) ;
        DataSet ds = new DataSet ();
        ad.Fill(ds, "abc");
        DataGridView1.DataSource = ds.Tables["abc"];
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        i = DataGridView1.CurrentRow.Index;
        n = DataGridView1.Rows[i].Cells[0].Value.ToString ();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        DataConnection dc = new DataConnection ();
        dc.cmd.CommandText = "delete from new_enquiry where name='" + n + "'";
        int i1 = dc.cmd.ExecuteNonQuery();
        MessageBox.Show(i1 + "deleted");
        EnquiryDetails_Load(null,null);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
