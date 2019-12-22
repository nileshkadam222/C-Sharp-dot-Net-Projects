using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
public partial class TnT_Cancel : System.Web.UI.Page
{
    //SqlConnection con = null;
    //SqlCommand cmd = null;
    //SqlDataReader dr;
    //connection cs = new connection();




    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["user"].ToString();
    }




    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        MessageBox.Show("Reservation Canceled Successfully!!!");

        Response.Redirect("TnT_airlinesindex.aspx");
    }
}
