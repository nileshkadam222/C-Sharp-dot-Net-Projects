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

    int y;
    string test;
    int count;
    int fare;
    string date;
    int SNo;
    int x;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        cmd.Connection = con;
        txtname.Attributes.Add("onkeypress", "Validate1();");
        txtcity.Attributes.Add("onkeypress", "Validate1();");
        txtphone.Attributes.Add("onkeypress", "Validate();");
        y = Convert.ToInt32(Request.QueryString.Get("y"));
        test = Request.QueryString.Get("test");
        count=Convert.ToInt32(Request.QueryString.Get("count"));
        date = Request.QueryString.Get("date");
        cmd.CommandText = "SELECT * FROM TnT_KELARAPRIVATE WHERE SNO=" + y + "";
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            lbl_route.Text = dr[1].ToString();
            lbl_service.Text = dr[2].ToString();
            lbl_from.Text = dr[3].ToString();
            lbl_to.Text = dr[4].ToString();
            lbl_fare.Text = dr[7].ToString();
            dr.Close();
        }
        else
        {
            Response.Write("<script>alert('Not Found')</script>");
        }
        fare=Convert.ToInt32(lbl_fare.Text) * count;
        lblseatopted.Text=test;
        lbltotseat.Text=count.ToString();
        lblAmt.Text=fare.ToString();
        lblJrnydt.Text = date;
    }
    protected void btn_bookng_Click(object sender, EventArgs e)
    {
        if (txt_mail.Text == "" || txtaddr.Text == "" || txtcity.Text == "" || txtname.Text == "" || txtphone.Text == "")
        {
            lblmsg.Text = "Missing Fields! Please fill all mandatory fields";
            lblmsg.Visible = true;
        }
        else
        {
            cmd.CommandText = "select max(SNo) from TnT_KLPrivateBookConfirm";
            dr=cmd.ExecuteReader();
            if(dr.Read())
            {
                SNo=dr.GetInt32(0);
                SNo++;
            }
            dr.Close();
            cmd.CommandText = "INSERT INTO TnT_KLPrivateBookConfirm values(" + SNo + ",'" + lbl_route.Text +
                "','" + lbl_from.Text + "','" + lbl_to.Text + "','" + lbl_fare.Text +
                "','" + lbl_service.Text + "','" + lbltotseat.Text + "','" + lblseatopted.Text +
                "','" + lblAmt.Text + "','" + lblJrnydt.Text + "','" + txtname.Text +
                "','" + txtaddr.Text + "','" + txtcity.Text + "','" + txtphone.Text +
                "','" + txt_mail.Text + "','" + drop_paymnt.SelectedValue + "','"+ Session["user"]+"')";
            x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                lblmsg.Text = "Booking completed successfully";
                lblmsg.Visible = true;
            }
            else
            {
                lblmsg.Text = "Booking failed";
                lblmsg.Visible = true;
            }
            txt_mail.Text = "";
            txtaddr.Text = "";
            txtcity.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TnT_keralaprivatefirst.aspx");
    }
}
