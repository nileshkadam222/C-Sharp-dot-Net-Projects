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
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        txt_mobile.Attributes.Add("onkeypress", "Validate();");
        txt_zip.Attributes.Add("onkeypress", "Validate();");
        txt_phone.Attributes.Add("onkeypress", "Validate();");
        txt_fax.Attributes.Add("onkeypress", "Validate();");
        txt_ful.Attributes.Add("onkeypress", "Validate1();");
        //txt_n.Attributes.Add("onkeypress", "Validate1();");
        txtdob.Attributes.Add("onblur", "checkDate('" + txtdob.ClientID + "');");
  
    }
    protected void btnreg_Click1(object sender, EventArgs e)
    {
        String uname = txt_user.Text;
        String passwd = txt_pass.Text;
        String ful = txt_ful.Text;
        String gen = drop_gen.SelectedItem.Value;
        String dob = txtdob.Text;
        String mari = drop_mari.SelectedItem.Value;
        String mail = txt_email.Text;
        String street = txt_street.Text;
        String state = drop_state.SelectedItem.Value;
        String zip = txt_zip.Text;
        String fax = txt_fax.Text;
        String city = drop_city.SelectedItem.Value;
        String country = drop_country.SelectedItem.Value;
        String phone = txt_phone.Text;
        String mobile = txt_mobile.Text;
        cmd.CommandText = "insert into TnT_ksrtcsignup values('" + uname + "','" + passwd + "','" + ful + "','" + drop_gen.SelectedItem.Value + "','" + txtdob.Text +
            "','" + mari + "','" + mail + "','" + street + "','" +
            state + "','" + zip + "','" + fax + "','" +
            city + "','" + country + "','" + phone + "','" + mobile + "')";
        int x = cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Response.Redirect("TnT_kiosksecond.aspx");

        }
        else
        {
            lblmsg.Text = "Registration failed";
            lblmsg.Visible = true;

        }
    }
    
    protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
    {
        txtdob.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = false;
    }
    protected void btnreset_Click1(object sender, EventArgs e)
    {
        txt_user.Text = "";
        txt_pass.Text = "";
        txt_confrm.Text = "";
        txt_email.Text = "";
        txt_fax.Text = "";
        txt_ful.Text = "";
        txt_mobile.Text = "";
        txt_pass.Text = "";
        txt_phone.Text = "";
        txt_street.Text = "";
        txt_user.Text = "";
        txt_zip.Text = "";
        txtdob.Text = "";
        lblmsg.Visible = false;

    }
    
}

