using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yours_Fitness_Center
{
    public partial class frmSplash_Screen : Form
    {
        public frmSplash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            { 
                timer1.Stop();
                this.Visible = false;
                Login ob = new Login();
                ob.Show();
            }
        }
    }
}
