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
    public partial class frmSalarySlip : Form
    {
        connectionClass obj = new connectionClass();
        double epf;
        public frmSalarySlip()
        {
            InitializeComponent();
        }

        private void frmSalarySlip_Load(object sender, EventArgs e)
        {
            fillCboId();
            fillNo();
        }
        public void clear()
        {
            lblAttendence.Text = "";
            lblBasic.Text = "";
            lblCalSal.Text = "";
            lblNetSalary.Text = "";
            
        }
        public void fillNo()
        {
              

            connectionClass obj = new connectionClass();
            obj.connect();
            obj.com.CommandText = "select COUNT (*) from tblSalarySlip";
            int maxrow = (int)obj.com.ExecuteScalar();
            maxrow = maxrow + 1;
            lblSlipNo.Text=maxrow.ToString();
            obj.con.Close();
        

        }
        public void fillCboId()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select * from tblPersonalDetails";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    cboId.Items.Add(obj.dr[0].ToString());
                }
            }
            catch
            {
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                obj.connect();
                obj.com.CommandText = "select BasicSalary from tblJobDetails where EmployeeId='"+cboId.Text+"'";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    lblBasic.Text = obj.dr[0].ToString();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
            //caculating Attendence
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                obj.connect();
                obj.com.CommandText = "select COUNT(*) from tblAttendence where Date between @fdate and @tdate and Status='present' and EmployeeId='"+cboId.Text+"'";
                DateTime dt = (DateTime)(dtpFromDate.Value.AddDays(-1));
                obj.com.Parameters.AddWithValue("@fdate", dt);
                obj.com.Parameters.AddWithValue("@tdate", dtpToDate.Value);
                obj.dr=obj.com.ExecuteReader();
                obj.com.Parameters.Clear();
                while (obj.dr.Read())
                {
                    lblAttendence.Text = obj.dr[0].ToString();
                }
                double perday = double.Parse(lblBasic.Text)/30;
                double calsal = double.Parse(lblAttendence.Text) * perday;
                lblCalSal.Text = calsal.ToString();
                double EpfPercent = double.Parse(textBox1.Text);
                epf = calsal / EpfPercent;
                int netsal = (int)(calsal - epf);
                lblNetSalary.Text = netsal.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblNetSalary.Text != "")
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblSalarySlip values('"+lblSlipNo.Text+"',@date,'"+cboId.Text+"',@fdate,@tdate,'"+lblBasic.Text+"','"+lblAttendence.Text+"','"+lblCalSal.Text+"','"+epf+"','"+lblNetSalary.Text+"')";
                    obj.com.Parameters.AddWithValue("@fdate", dtpFromDate.Value);
                    obj.com.Parameters.AddWithValue("@tdate", dtpToDate.Value);
                    obj.com.Parameters.AddWithValue("@date", dtpDate.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Record Added !!");

                    DialogResult dr = MessageBox.Show("You want to print the salary slip ?", "Employee Profile Management System", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        frmReportViewer frv = new frmReportViewer();
                        frv.salarySlip(lblSlipNo.Text);
                    }

                    clear();
                    fillNo();
                }
                catch(Exception ex)
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
}
