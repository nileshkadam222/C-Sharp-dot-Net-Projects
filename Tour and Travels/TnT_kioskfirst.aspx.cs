using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Web.Configuration;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    StreamReader MyFile = new System.IO.StreamReader(Server.MapPath("Server.txt"));
        //    string str = MyFile.ReadToEnd().ToString();
        //    MyFile.Close();
        //    //string str = ".\\SQLExpress";
        //    Configuration Config1 = WebConfigurationManager.OpenWebConfiguration("~");
        //    ConnectionStringsSection conSetting = (ConnectionStringsSection)Config1.GetSection("connectionStrings");
        //    ConnectionStringSettings StringSettings = new ConnectionStringSettings("kioskDB", "Data Source='" + str + "';AttachDbFilename=|DataDirectory|kiosk.mdf;Integrated Security=True;");
        //    conSetting.ConnectionStrings.Remove(StringSettings);
        //    conSetting.ConnectionStrings.Add(StringSettings);
        //    Config1.Save();
        //    ConfigurationManager.RefreshSection("connectionStrings");
        //}
    }
}
