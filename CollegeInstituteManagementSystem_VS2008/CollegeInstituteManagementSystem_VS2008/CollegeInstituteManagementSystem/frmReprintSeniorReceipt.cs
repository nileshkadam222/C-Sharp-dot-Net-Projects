using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeInstituteManagementSystem
{
    public partial class frmReprintSeniorReceipt : Form
    {
        connectionClass obj = new connectionClass();
        public frmReprintSeniorReceipt()
        {
            InitializeComponent();
        }

        private void frmReprintSeniorReceipt_Load(object sender, EventArgs e)
        {
            fillId();
        }

        public void fillId()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select StudentId from tblSeniorStudent";
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
                frv.receiptSenior(cboId.Text);
                frv.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
