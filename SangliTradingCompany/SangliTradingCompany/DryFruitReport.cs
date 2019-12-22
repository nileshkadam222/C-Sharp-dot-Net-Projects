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
    public partial class DryFruitReport : Form
    {
        public DryFruitReport()
        {
            InitializeComponent();
        }

        private void DryFruitReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.DryFruitTable' table. You can move, or remove it, as needed.
            this.DryFruitTableTableAdapter.Fill(this.Database1DataSet.DryFruitTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
