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
    public partial class billingreport : Form
    {
        public billingreport()
        {
            InitializeComponent();
        }

        private void billingreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.bill_table1' table. You can move, or remove it, as needed.
            this.bill_table1TableAdapter.Fill(this.Database1DataSet.bill_table1);

            this.reportViewer1.RefreshReport();
        }
    }
}
