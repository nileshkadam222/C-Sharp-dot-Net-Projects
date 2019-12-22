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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (RadioButton1.Checked == true)
        {
            GridView1.Visible = true;
            GridView2.Visible = false;
            lbl_date.Text = DateTime.Now.ToShortDateString();
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        GridView2.Visible = false;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        GridView2.Visible = true;
    }
}
