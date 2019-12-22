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
    public partial class SpicesReports : Form
    {
        public SpicesReports()
        {
            InitializeComponent();
        }

        private void SpicesReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.SpicesTable' table. You can move, or remove it, as needed.
            this.SpicesTableTableAdapter.Fill(this.Database1DataSet.SpicesTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
