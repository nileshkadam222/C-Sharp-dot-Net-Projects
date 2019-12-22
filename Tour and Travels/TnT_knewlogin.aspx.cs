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
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["kioskDB"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dr;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "select * from TnT_ksrtclogin where userid='" + txt_user.Text + "' and password='" + txt_pass.Text + "' ";
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["user"] = txt_user.Text;
            Response.Write(Session["user"].ToString());
            Response.Redirect("TnT_kiosksecond.aspx");
            
        }
        else
        {
            lblmsg.Visible = true;
        }
    }

    protected void btnreset_Click(object sender, EventArgs e)
    {
        txt_user.Text = "";
        txt_pass.Text = "";
        lblmsg.Visible = false;
    }
}
