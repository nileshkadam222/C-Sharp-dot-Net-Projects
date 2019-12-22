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
    //SqlDataReader dr;


    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        txt_name.Attributes.Add("onkeypress", "Validate1();");
        txt_mobile.Attributes.Add("onkeypress", "Validate();");
        txt_zip.Attributes.Add("onkeypress", "Validate();");
        txt_phone.Attributes.Add("onkeypress", "Validate();");
        txt_fax.Attributes.Add("onkeypress", "Validate();");
        txt_ful.Attributes.Add("onkeypress", "Validate1();");
        //txt_n.Attributes.Add("onkeypress", "Validate1();");
        txtDOB.Attributes.Add("onblur", "checkDate('" + txtDOB.ClientID + "');");
  
    }
    
    protected void btnreg_Click(object sender, EventArgs e)
    {
        String name = txt_name.Text;
        String passwd = txt_pas.Text;
        String ful = txt_ful.Text;
        String gen = drop_gen.SelectedItem.Value;
        String dob = Request.Form.Get("txtDOB");
        String mari = drop_mari.SelectedItem.Value;
        String mail = txt_mail.Text;
        String street = txt_street.Text;
        String state = drop_state.SelectedItem.Value;
        String zip = txt_zip.Text;
        String fax = txt_fax.Text;
        String city = drop_city.SelectedItem.Value;
        String country = drop_country.SelectedItem.Value;
        String phone = txt_phone.Text;
        String mobile = txt_mobile.Text;
        cmd.CommandText = "insert into TnT_ksrtcsignup values('" + name + "','" + passwd + "','" + ful + "','" + gen + "','" + dob +
            "','" + mari + "','" + mail + "','" + street + "','" +
            state + "','" + zip + "','" + fax + "','" +
            city + "','" + country + "','" + phone + "','" + mobile + "')";
        cmd.ExecuteNonQuery();
        cmd.CommandText = "insert into TnT_ksrtclogin values('" + name + "','" + passwd + "')";
        int x=cmd.ExecuteNonQuery();
        if (x > 0)
        {
            Response.Write(txt_pas.Text);
            Response.Redirect("TnT_knewlogin.aspx");

        }
        else
        {
            lblmsg.Text = "Registration failed";
            lblmsg.Visible = true;

        }
    }
    protected void  btnreset_Click(object sender, EventArgs e)
        {
         txt_name.Text = "";
        txt_pas.Text = "";
        txt_conf.Text = "";
        txt_mail.Text = "";
        txt_fax.Text = "";
        txt_ful.Text = "";
        txt_mobile.Text = "";
        txt_pas.Text = "";
        txt_phone.Text = "";
        txt_street.Text = "";
       // txt_user.Text = "";
        txt_zip.Text = "";
        txtDOB.Text = "";
        lblmsg.Visible = false;
        }
 
 
    protected void txt_name_TextChanged(object sender, EventArgs e)
    {

    }
}

