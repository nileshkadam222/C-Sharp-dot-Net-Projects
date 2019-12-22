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
        txt_dapature.Attributes.Add("onblur", "checkDate('" + txt_dapature.ClientID + "');");
        txt_arrival.Attributes.Add("onblur", "checkDate('" + txt_arrival.ClientID + "');");
        txt_noof.Attributes.Add("OnKeyPress", "Nums();");
        txt_noofpers.Attributes.Add("OnKeyPress", "Nums();");
        txt_cash.Attributes.Add("OnKeyPress", "Rupees();");
        txt_name.Attributes.Add("OnKeyPress", "Character();");
        txt_phone.Attributes.Add("OnKeyPress", "Validate();");
        txt_fax.Attributes.Add("OnKeyPress", "Validate();");
        txt_pincode.Attributes.Add("OnKeyPress", "Nums();");
        txt_city.Attributes.Add("OnkeyPress", "Character();");
        txt_country.Attributes.Add("OnKeyPress", "Character();");
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        if (!IsPostBack)
        {
            lbl_hotelname.Text = Request.QueryString["x"];
        }
    }
    protected void bt_submit_Click(object sender, EventArgs e)
    {
        String honame = lbl_hotelname.Text;
        String arrival = txt_arrival.Text;
        String depature = txt_dapature.Text;
        String noofr = txt_noofpers.Text;
        String noofp = txt_noof.Text;
        String cash = txt_cash.Text;
        String name = txt_name.Text;
        String email = txt_mail.Text;
        String phone = txt_phone.Text;
        String fax = txt_fax.Text;
        String address = txt_street.Text;
        String city = txt_city.Text;
        String pin = txt_pincode.Text;
        String coun = txt_country.Text;
        String other=txt_other.Text;
        if (txt_arrival.Text == "" || txt_dapature.Text == "" || txt_noofpers.Text == "" || txt_cash.Text == "" || txt_city.Text == "" || txt_country.Text == "" || txt_fax.Text == "" || txt_mail.Text == "" || txt_name.Text == "" || txt_noof.Text == "" || txt_other.Text == "" || txt_phone.Text == "" || txt_pincode.Text == "" || txt_street.Text == "")
        {
            Response.Write("Missing Field");
        }
        else
        {
            cmd.CommandText = "insert into TnT_hotelbooking values('" + honame + "','" + arrival + "','" + depature + "','" + noofp + "','" + noofr + "','" + cash + "','" + other + "','" + name + "','" + email + "','" + phone + "','" + fax + "','" + address + "','" + city + "','" + pin + "','" + con + "')";
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                Response.Write("Successfull");
                Response.Redirect("TnT_hotelmail.aspx");
            }
            else
            {
                Response.Write("Failed");
            }
        }
    }
}
