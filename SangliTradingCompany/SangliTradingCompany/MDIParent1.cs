using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SangliTradingCompany
{
    public partial class MDIParent1 : Form
    {
        

        public MDIParent1()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void addDryFruitDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDryFruit d = new AddDryFruit();
            d.MdiParent = this;
            d.Show();
        }

        private void searchDryFruitDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDryFruit g = new SearchDryFruit();
            g.MdiParent = this;
            g.Show();
        }

        private void updateDryFruitDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDryFruit d = new UpdateDryFruit();
            d.MdiParent = this;
            d.Show();
        }

        private void viewDryFruitDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewDryFruitDetails d = new ViewDryFruitDetails();
            d.MdiParent = this;
            d.Show();
        }

        private void addSpicesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpices s = new AddSpices();
            s.MdiParent = this;
            s.Show();
        }

        private void searchSpicesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSpices s1 = new SearchSpices();
            s1.MdiParent = this;
            s1.Show();
        }

        private void updateSpicesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSpices u = new UpdateSpices();
            u.MdiParent = this;
            u.Show();
        }

        private void deleteSpicesRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSpices g = new DeleteSpices();
            g.MdiParent = this;
            g.Show();
        }

        private void viewSpicesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSpicesRecord d = new ShowSpicesRecord();
            d.MdiParent = this;
            d.Show();
        }

       

        private void viewDryFruitDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDryfruit d = new DeleteDryfruit();
            d.MdiParent = this;
            d.Show();
        }

      

        private void saveSalaryRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalary e3 = new EmployeeSalary();
            e3.MdiParent = this;
            e3.Show();
        }

        private void searchAndModifieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSalaryRecords g = new SearchSalaryRecords();
            g.MdiParent = this;
            g.Show();
        }

        private void modifyRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifySalaryRecords j = new ModifySalaryRecords();
            j.MdiParent = this;
            j.Show();
        }

        private void viewOfAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSalaryRecords a = new ViewSalaryRecords();
            a.MdiParent = this;
            a.Show();
        }

      
      

      

        private void dryfruitOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetailsDryfruit1 m = new OrderDetailsDryfruit1();
            m.MdiParent = this;
            m.Show();
        }

        private void spicesOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpicesOrderDetails f = new SpicesOrderDetails();
            f.MdiParent = this;
            f.Show();
        }

        private void dryFruitOrderDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerDFOrder v = new CustomerDFOrder();
            v.MdiParent = this;
            v.Show();
        }

        private void spicesOrderDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerSpicesOrder x = new CustomerSpicesOrder();
            x.MdiParent = this;
            x.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit  ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dryFruitReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DryFruitReport n = new DryFruitReport();
            n.MdiParent = this;
            n.Show();
        }

        private void spicesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpicesReports f = new SpicesReports();
            f.MdiParent = this;
            f.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReports j = new EmployeeReports();
            j.MdiParent = this;
            j.Show();
        }

        private void emploeeSalaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmplyeeSalaryReports m = new EmplyeeSalaryReports();
            m.MdiParent = this;
            m.Show();
        }

        private void employeeAttendenceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAttendenceReports h = new EmployeeAttendenceReports();
            h.MdiParent = this;
            h.Show();
        }

   
    

        private void pRODUCTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerregToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationOfCustomer d = new RegistrationOfCustomer();
            d.MdiParent = this;
            d.Show();
        }

        private void SupplierregToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationOfSupplier g = new RegistrationOfSupplier();
            g.MdiParent = this;
            g.Show();
        }

        private void modempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifiedEmployeeDetail d = new ModifiedEmployeeDetail();
            d.MdiParent = this;
            d.Show();
        }

        private void todaysAttendenceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TodaysAttendence c = new TodaysAttendence();
            c.MdiParent = this;
            c.Show();
        }

        private void attendenceRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendenceRecord p = new AttendenceRecord();
            p.MdiParent = this;
            p.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalary l = new EmployeeSalary();
            l.MdiParent = this;
            l.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSalaryRecords h = new SearchSalaryRecords();
            h.MdiParent = this;
            h.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifySalaryRecords j = new ModifySalaryRecords();
            j.MdiParent = this;
            j.Show();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSalaryRecords t = new ViewSalaryRecords();
            t.MdiParent = this;
            t.Show();

        }

        private void customerDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dryfruitOrderDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrderDetailsDryfruit1 r = new OrderDetailsDryfruit1();
            r.MdiParent = this;
            r.Show();
        }

        private void spicesOrderDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SpicesOrderDetails f = new SpicesOrderDetails();
            f.MdiParent = this;
            f.Show();
        }

        private void dryFruitOrderDetailsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CustomerDFOrder h = new CustomerDFOrder();
            h.MdiParent = this;
            h.Show();
        }

        private void spicesOrderDetailsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CustomerSpicesOrder m = new CustomerSpicesOrder();
            m.MdiParent = this;
            m.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bill2 h = new bill2();
            h.MdiParent = this;
            h.Show();
        }

        private void dryFruitReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DryFruitReport b = new DryFruitReport();
            b.MdiParent = this;
            b.Show();
        }

        private void spicesReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SpicesReports f = new SpicesReports();
            f.MdiParent = this;
            f.Show();

        }

        private void employeeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeReports d = new EmployeeReports();
            d.MdiParent = this;
            d.Show();

        }

        private void emploeeSalaryReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmplyeeSalaryReports o = new EmplyeeSalaryReports();
            o.MdiParent = this;
            o.Show();
        }

        private void employeeAttendenceReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeAttendenceReports g = new EmployeeAttendenceReports();
            g.MdiParent = this;
            g.Show();
        }

        private void customerReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerReports u = new CustomerReports();
            u.MdiParent = this;
            u.Show();
        }

        private void supplierReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupplierRecords f = new SupplierRecords();
            f.MdiParent = this;
            f.Show();
        }

       

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void employeeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterEmployee f = new RegisterEmployee();
            f.MdiParent = this;
            f.Show();
        }

        private void modifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyCustomerRegist y = new ModifyCustomerRegist();
            y.MdiParent = this;
            y.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifySupplierRecords v = new ModifySupplierRecords();
            v.MdiParent = this;
            v.Show();
        }

        private void recordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCustomerRecords h = new ViewCustomerRecords();
            h.MdiParent = this;
            h.Show();
        }

        private void viewOfRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSupplierRecords k = new ViewSupplierRecords();
            k.MdiParent = this;
            k.Show();
        }

        private void billReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            billingreport h = new billingreport();
            h.MdiParent = this;
            h.Show();
        }

       
       

       

       

       
    }
}
