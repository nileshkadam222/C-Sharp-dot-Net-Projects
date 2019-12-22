using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LICDataSet3.T_CommissionData' table. You can move, or remove it, as needed.
            this.T_CommissionDataTableAdapter.Fill(this.LICDataSet3.T_CommissionData);

            this.reportViewer1.RefreshReport();
        }
    }
}
