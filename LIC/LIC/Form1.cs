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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LICDataSet1.C_PersonalDetails' table. You can move, or remove it, as needed.
            this.C_PersonalDetailsTableAdapter.Fill(this.LICDataSet1.C_PersonalDetails);

            this.reportViewer1.RefreshReport();
        }
    }
}
