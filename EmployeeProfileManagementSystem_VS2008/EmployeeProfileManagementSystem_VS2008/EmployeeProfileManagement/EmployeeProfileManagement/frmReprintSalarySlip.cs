using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeProfileManagement
{
    public partial class frmReprintSalarySlip : Form
    {
        connectionClass obj = new connectionClass();
        public frmReprintSalarySlip()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer fpv = new frmReportViewer();
            fpv.salarySlip(comboBox1.Text);
            fpv.Show();
        }

        private void frmReprintSalarySlip_Load(object sender, EventArgs e)
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select SlipNo from tblSalarySlip";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    comboBox1.Items.Add(obj.dr[0].ToString());
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

    }
}
