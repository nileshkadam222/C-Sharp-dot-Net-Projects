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
    public partial class CustomerReports : Form
    {
        public CustomerReports()
        {
            InitializeComponent();
        }

        private void CustomerReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Customer_Table' table. You can move, or remove it, as needed.
            this.Customer_TableTableAdapter.Fill(this.Database1DataSet.Customer_Table);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
