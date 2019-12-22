using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    txt_mobile.Attributes.Add("onkeypress", "Validate();");
    //    txt_zip.Attributes.Add("onkeypress", "Validate();");
    //    txt_phone.Attributes.Add("onkeypress", "Validate();");
    //    txt_fax.Attributes.Add("onkeypress", "Validate();");
    //    txt_ful.Attributes.Add("onkeypress", "Validate1();");
    //    //txt_n.Attributes.Add("onkeypress", "Validate1();");
    //    txtdob.Attributes.Add("onblur", "checkDate('" + txtdob.ClientID + "');");
    //}
    //protected void btnreg_Click1(object sender, EventArgs e)
    //{
    //    SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=C:\\USERS\\MARUTI\\DOCUMENTS\\VISUAL STUDIO 2010\\PROJECTS\\HOTELMGMT\\HOTELMGMT\\APP_DATA\\DATABASE.MDF;Integrated Security=True");
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    da.InsertCommand = new SqlCommand("insert into signup values(@user_id, @password, @fullname, @gender, @marital_status, @dob, @email,@street_add, @state, @city, @zip, @phno, @fax, @mob");
    //    da.InsertCommand.Parameters.Add("@user_id", SqlDbType.VarChar).Value = txt_user.Text;
    //    da.InsertCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = txt_pass.Text;
    //    da.InsertCommand.Parameters.Add("@fullname", SqlDbType.VarChar).Value = txt_ful.Text;
    //    da.InsertCommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = drop_gen.Text;
    //    da.InsertCommand.Parameters.Add("@marital_status", SqlDbType.VarChar).Value = drop_mari.Text;
    //    da.InsertCommand.Parameters.Add("@dob", SqlDbType.VarChar).Value = txtdob.Text;
    //    da.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
    //    da.InsertCommand.Parameters.Add("@street_add", SqlDbType.VarChar).Value = txt_street.Text;
    //    da.InsertCommand.Parameters.Add("@state", SqlDbType.VarChar).Value = drop_state.Text;
    //    da.InsertCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = drop_city.Text;
    //    da.InsertCommand.Parameters.Add("@zip", SqlDbType.VarChar).Value = txt_zip.Text;
    //    da.InsertCommand.Parameters.Add("@phno", SqlDbType.VarChar).Value = txt_phone.Text;
    //    da.InsertCommand.Parameters.Add("@fax", SqlDbType.VarChar).Value = txt_fax.Text;
    //    da.InsertCommand.Parameters.Add("@mob", SqlDbType.VarChar).Value = txt_mobile.Text;
    //    con.Open();
    //    int x = da.InsertCommand.ExecuteNonQuery();
    //    if (x > 0)
    //    {
    //        Response.Redirect("login.aspx");

    //    }
    //    else
    //    {
    //        lblmsg.Text = "Registration failed";
    //        lblmsg.Visible = true;

    //    }


    //}
    //protected void btnreset_Click1(object sender, EventArgs e)
    //{
    //    txt_user.Text = "";
    //    txt_pass.Text = "";
    //    txt_ful.Text = "";
    //    drop_gen.Text = "";
    //    drop_mari.Text = "";
    //    txtdob.Text = "";
    //    txt_email.Text = "";
    //    txt_street.Text = "";
    //    drop_state.Text = "";
    //    drop_city.Text = " ";
    //    txt_zip.Text = " ";
    //    txt_phone.Text = " ";
    //    txt_fax.Text = " ";
    //    txt_mobile.Text = " ";
    //    lblmsg.Visible = false;
    //}

    //protected void btnreset_Click(object sender, EventArgs e)
    //{

    //}
    //protected void btnreg_Click(object sender, EventArgs e)
    //{

    //}
    //protected void txt_name_TextChanged(object sender, EventArgs e)
    //{

    //}
}