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

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["kioskDB"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    int xx;
    protected void Page_Load(object sender, EventArgs e)
    {
        txt_name.Attributes.Add("onkeypress", "Validate1();");
        txt_last.Attributes.Add("onkeypress", "Validate1();");
        txt_leaving.Attributes.Add("onkeypress", "Validate1();");
        txt_going.Attributes.Add("onkeypress", "Validate1();");
        txt_passname.Attributes.Add("onkeypress", "Validate1();");
        txt_phone.Attributes.Add("onkeypress", "Validate();");
        txt_passport.Attributes.Add("onkeypress", "Validate();");
        txt_nationality.Attributes.Add("onkeypress", "Validate1();");
        txtDDNo.Attributes.Add("onkeypress", "Validate();");
        txtCardNo.Attributes.Add("onkeypress", "Validate();");


        //txt_n.Attributes.Add("onkeypress", "Validate1();");
        txt_cal1.Attributes.Add("onblur", "checkDate('" + txt_cal1.ClientID + "');");
        txt_cal2.Attributes.Add("onblur", "checkDate('" + txt_cal2.ClientID + "');");
        txt_dob.Attributes.Add("onblur", "checkDate('" + txt_dob.ClientID + "');");
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        if (rdbcard.Checked == true)
        {
            lblCardNo.Enabled = true;
            lblmsgCardType.Enabled = true;
            drpCardType.Enabled = true;
            txtCardNo.Enabled = true;
            lblDD.Enabled = false;
            txtDDNo.Enabled = false;
        }
        else if (rdbDD.Checked == true)
        {
            lblDD.Enabled = true;
            txtDDNo.Enabled = true;
            lblCardNo.Enabled = false;
            lblmsgCardType.Enabled = false;
            drpCardType.Enabled = false;
            txtCardNo.Enabled = false;
        }
        else
        {
            lblDD.Enabled =false;
            txtDDNo.Enabled =false;
            lblCardNo.Enabled = false;
            lblmsgCardType.Enabled = false;
            drpCardType.Enabled = false;
            txtCardNo.Enabled = false;
        }
        
  
    }
   
    
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
    
    
    protected void but_regester_Click(object sender, EventArgs e)
    {
        String title = drop_tittle.SelectedItem.Value;
        String firstname = txt_name.Text;
        String lastname = txt_last.Text;
        String leaving = txt_leaving.Text;
        String going = txt_going.Text;
        String depature = txt_cal1.Text;
        String returndate =txt_cal2.Text;
        String classname = drop_class.SelectedItem.Value;
        String email = txt_email.Text;
        String phoneno = txt_phone.Text;
        String passenger = txt_passname.Text;
        String dob = txt_dob.Text;
        String nationality = txt_nationality.Text;
        String passportno = txt_passport.Text;
        //String payment = drop_payment.SelectedItem.Value;
        String comment = txt_comment.Text;
        String companyname = txt_company.Text;
        cmd.CommandText = "SELECT MAX(Jourid) from TnT_airlinereser";
        dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            xx = dr.GetInt32(0);
            xx = xx + 1;
        }
        dr.Close();

        if (txt_cal1.Text == "" || txt_cal2.Text== ""|| txt_dob.Text==""|| txt_email.Text==""|| txt_going.Text==""|| txt_last.Text==""|| txt_leaving.Text==""|| txt_name.Text==""|| txt_nationality.Text==""|| txt_passname.Text==""|| txt_passport.Text==""|| txt_phone.Text== "")
        {
            lblmsg.Text = "Missing Fields";
            lblmsg.Visible = true;
        }
        else
        {
            if (rdbcard.Checked == true)
            {
                if (drpCardType.SelectedIndex == 0)
                {
                    lblmsgCardType.Text = "Please select the Card Type";
                    lblmsgCardType.Visible = true;
                }
                else
                {
                    cmd.CommandText = "insert into TnT_airlinereser(userid,Jourid,title,firstname,lastname,leavingfrom,goingto,depaturedate,returndate,class,email,phoneno,passengername,dob,nationality,passportno,comment,companyname,cardnumber,cardtype) values('"+Session["user"]+"',"+ xx +",'" + title + "','" + firstname +
                        "','" + lastname + "','" + leaving + "','" + going + "','" + depature +
                        "','" + returndate + "','" + classname + "','" + email + "','" + phoneno +
                        "','" + passenger + "','" + dob + "','" + nationality + "','" + passportno +
                        "','" + comment + "','" + companyname + "','" + txtCardNo.Text + "','" + drpCardType.SelectedValue + "')";

                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        lblmsg.Text = "Registration Completed";
                        lblmsg.Visible = true;
                        Response.Redirect("TnT_airlinemail.aspx");

                    }
                    else
                    {
                        lblmsg.Text = "TnT_Registration failed";
                        lblmsg.Visible = true;

                    }
                }
            }
            else if (rdbDD.Checked == true)
            {
                if (txtDDNo.Text == "")
                {
                    lblmsgdd.Text = "Please enter the number";
                    lblmsgdd.Visible = true;
                }
                else
                {
                    cmd.CommandText = "insert into TnT_airlinereser(userid,Jourid,title,firstname,lastname,leavingfrom,goingto,depaturedate,returndate,class,email,phoneno,passengername,dob,nationality,passportno,comment,companyname,ddnumber) values('" + Session["user"] + "'," + xx + ",'" + title + "','" + firstname +
                        "','" + lastname + "','" + leaving + "','" + going + "','" + depature +
                        "','" + returndate + "','" + classname + "','" + email + "','" + phoneno +
                        "','" + passenger + "','" + dob + "','" + nationality + "','" + passportno +
                        "','" + comment + "','" + companyname + "','" + txtDDNo.Text + "')";

                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        //Response.Redirect("ksrtcsignin.aspx");
                        lblmsg.Text = "Registration Completed";
                        Clear();
                        lblmsg.Visible = true;

                    }
                    else
                    {
                        lblmsg.Text = "Registration failed";
                        lblmsg.Visible = true;

                    }
                }
            }
           
        }
        con.Close();
    }
    protected void but_reset_Click(object sender, EventArgs e)
    {
        Clear();
    }
    public void Clear()
    {
        txt_cal1.Text = "";
        txt_cal2.Text = "";
        txt_comment.Text = "";
        txt_company.Text = "";
        txt_dob.Text = "";
        txt_email.Text = "";
        txt_going.Text = "";
        txt_last.Text = "";
        txt_leaving.Text = "";
        txt_name.Text = "";
        txt_nationality.Text = "";
        txt_passname.Text = "";
        txt_passport.Text = "";
        txt_phone.Text = "";
        lblmsg.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       // Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //txt_cal1.Text = Calendar1.SelectedDate.ToShortDateString();
        //Calendar1.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       // Calendar2.Visible = true;
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        //txt_cal2.Text = Calendar2.SelectedDate.ToShortDateString();
        //Calendar2.Visible = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //Calendar3.Visible = true;

    }
    protected void Calendar3_SelectionChanged(object sender, EventArgs e)
    {
        //txt_dob.Text = Calendar3.SelectedDate.ToShortDateString();
        //Calendar3.Visible = false;

    }
    protected void btnreport_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/Airline_Reservation_Report.aspx");
    }
}
