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
    public partial class frmReportDesignationWise : Form
    {
        connectionClass obj = new connectionClass();
        public frmReportDesignationWise()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportDesignationWise_Load(object sender, EventArgs e)
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select Designation from tblJobDetails group by Designation";
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer frv = new frmReportViewer();
            frv.reportDesignationWise(comboBox1.Text);
            frv.Show();
        }
    }
}
