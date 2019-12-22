using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;

namespace ServerNameSettings
{
    [RunInstaller(true)]
    public partial class InstallingOCL : Installer
    {
        public InstallingOCL()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary stateSaver)
        {



            base.Install(stateSaver);

            try
            {

                /* settings

                 * /orgName = "[EDITA1]"

                 *

                 */

                string OrgName = this.Context.Parameters["v"];

                ServerName f = new ServerName();

                f.OrgName = OrgName;

                f.ShowDialog();

            }

            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message.ToString());

            }

            //string OrgName = Context.Parameters["v"];
            //FileInfo fi = new FileInfo("cont.txt");
            //FileStream fstr = fi.Create();
            //fstr.Close();

            //System.IO.StreamWriter file = new System.IO.StreamWriter("cont.txt");
            //file.Write(OrgName);

            //file.Close();




        }
    }
}