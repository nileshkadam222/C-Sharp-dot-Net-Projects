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
    public partial class frmReportDepartmentWise : Form
    {
        connectionClass obj = new connectionClass();
        public frmReportDepartmentWise()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportDepartmentWise_Load(object sender, EventArgs e)
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select Department from tblJobDetails group by Department";
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
            frv.reportDepartmentWise(comboBox1.Text);
            frv.Show();
        }
    }
}
