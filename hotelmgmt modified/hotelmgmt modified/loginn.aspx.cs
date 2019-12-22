using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class loginn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=C:\\USERS\\MARUTI\\DOCUMENTS\\VISUAL STUDIO 2010\\PROJECTS\\HOTELMGMT\\HOTELMGMT\\APP_DATA\\DATABASE.MDF;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        da.InsertCommand = new SqlCommand("select * from login where username='" + txt_user.Text + "'+ and password='" + txt_pass.Text + "'");
        con.Open();
        da.InsertCommand.ExecuteNonQuery();
        Response.Redirect("Home.aspx");
        con.Close();

        //if (txt_user.Text == "admin" && txt_pass.Text == "admin")
        //{
        //    Response.Redirect("Home.aspx");
        //}
        //else
        //    lblmsg.Visible = true;
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txt_user.Text = " ";
        txt_pass.Text = " ";
    }
}