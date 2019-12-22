using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeInstituteManagementSystem
{
    public partial class frmReprintJuniorReceipt : Form
    {
        connectionClass obj = new connectionClass();
        public frmReprintJuniorReceipt()
        {
            InitializeComponent();
        }

        private void frmReprintJuniorReceipt_Load(object sender, EventArgs e)
        {
            fillId();
        }

        public void fillId()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select StudentId from tblJuniorStudent";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    cboId.Items.Add(obj.dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboId.Text == "")
            {
                MessageBox.Show("Select Student ID !");
            }
            else
            {
                frmReportViewer frv = new frmReportViewer();
                frv.receiptJunior(cboId.Text);
                frv.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
