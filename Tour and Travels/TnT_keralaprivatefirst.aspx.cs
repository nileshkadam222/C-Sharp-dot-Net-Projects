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

    }
   
   
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int x;
        x = Convert.ToInt32(GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text);
        Response.Redirect("TnT_ksrtcprivatesecond.aspx?y=" + x );
        //Response.Write("<script>alert('" + x + "')</script>");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
