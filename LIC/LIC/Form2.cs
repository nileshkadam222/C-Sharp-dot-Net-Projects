using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIC
{
    public partial class Form2 : Form
    {
         OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        //public void openConnection()
        //{

        //    con = new OleDbConnection();
        //    String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
        //    con.ConnectionString = str;
        //    con.Open();
        //}

        //private void Form2_Load(object sender, EventArgs e)
        //{
            
        //    openConnection();


        //    String str = "Select Policy_No from C_PolicyDetails";
        //    cmd = new OleDbCommand(str, con);
        //    da = new OleDbDataAdapter(cmd);
        //    ds = new DataSet();
        //    da.Fill(ds);
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        cbo_polno.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
        //    }

        //}
            
            
            
            
            
            
            
           



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LICDataSet2.T_PaymentDetails' table. You can move, or remove it, as needed.
            this.T_PaymentDetailsTableAdapter.Fill(this.LICDataSet2.T_PaymentDetails);

            this.reportViewer1.RefreshReport();
        }
    }
}
