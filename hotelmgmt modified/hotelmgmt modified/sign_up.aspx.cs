using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class sign_up : System.Web.UI.Page
{
   SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=C:\\USERS\\MARUTI\\DOCUMENTS\\VISUAL STUDIO 2010\\PROJECTS\\HOTELMGMT\\HOTELMGMT\\APP_DATA\\DATABASE.MDF;Integrated Security=True");
        
   SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {

    //    con.Open();
    //    txt_name.Attributes.Add("onkeypress", "Validate1();");
    //    txt_mobile.Attributes.Add("onkeypress", "Validate();");
    //    txt_zip.Attributes.Add("onkeypress", "Validate();");
    //    txt_phone.Attributes.Add("onkeypress", "Validate();");
    //    txt_fax.Attributes.Add("onkeypress", "Validate();");
    //    txt_ful.Attributes.Add("onkeypress", "Validate1();");
    //    //txt_n.Attributes.Add("onkeypress", "Validate1();");
    //    txtDOB.Attributes.Add("onblur", "checkDate('" + txtDOB.ClientID + "');");
    //}
    //protected void btnreg_Click(object sender, EventArgs e)
    //{


    //    //String name = txt_name.Text;
    //    //String passwd = txt_pas.Text;
    //    //String ful = txt_ful.Text;
    //    //String gen = drop_gen.SelectedItem.Value;
    //    //String dob = Request.Form.Get("txtDOB");
    //    //String mari = drop_mari.SelectedItem.Value;
    //    //String mail = txt_mail.Text;
    //    //String street = txt_street.Text;
    //    //String state = drop_state.SelectedItem.Value;
    //    //String zip = txt_zip.Text;
    //    //String fax = txt_fax.Text;
    //    //String city = drop_city.SelectedItem.Value;
    //    //String phone = txt_phone.Text;
    //    //String mobile = txt_mobile.Text;
    //    cmd.CommandText = "insert into signup values('" + txt_name.Text + "','" + txt_pas.Text + "','" + txt_ful.Text + "','" + drop_gen.SelectedItem.Value + "','" + drop_mari.SelectedItem.Value + "','" + Request.Form.Get("txtDOB") + "','" + txt_mail.Text + "','" + txt_street.Text + "','" +
    //        drop_state.SelectedItem.Value + "','" + drop_city.SelectedItem.Value + "','" + txt_zip.Text + "','" + txt_phone.Text + "','" + txt_fax.Text + "','" + txt_mobile.Text + "')";
    //    cmd.ExecuteNonQuery();
    //    cmd.CommandText = "insert into login values('" + txt_name.Text + "','" + txt_pas.Text + "')";
    //    int x = cmd.ExecuteNonQuery();
    //    if (x > 0)
    //    {
    //        Response.Write(txt_pas.Text);
    //        Response.Redirect("loginn.aspx");

    //    }
    //    else
    //    {
    //        lblmsg.Text = "Registration failed";
    //        lblmsg.Visible = true;

    //    }
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=C:\\USERS\\MARUTI\\DOCUMENTS\\VISUAL STUDIO 2010\\PROJECTS\\HOTELMGMT\\HOTELMGMT\\APP_DATA\\DATABASE.MDF;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        con.Open();
        da.InsertCommand = new SqlCommand("INSERT INTO signup VALUES(@user_id, @password, @fullname, @gender, @marital_status, @dob, @email, @street_add, @state, @city, @zip, @phno, @fax, @mob", con);
        da.InsertCommand.Parameters.Add("@user_id", SqlDbType.VarChar).Value = txt_name.Text;
        da.InsertCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = txt_pas.Text;
        da.InsertCommand.Parameters.Add("@fullname", SqlDbType.VarChar).Value = txt_ful.Text;
        da.InsertCommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = drop_gen.Text;
        da.InsertCommand.Parameters.Add("@marital_status", SqlDbType.VarChar).Value = drop_mari.Text;
        da.InsertCommand.Parameters.Add("@dob", SqlDbType.VarChar).Value = txtDOB.Text;
        da.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_mail.Text;
        da.InsertCommand.Parameters.Add("@street_add", SqlDbType.VarChar).Value = txt_street.Text;
        da.InsertCommand.Parameters.Add("@state", SqlDbType.VarChar).Value = drop_state.Text;
        da.InsertCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = drop_city.Text;
        da.InsertCommand.Parameters.Add("@zip", SqlDbType.VarChar).Value = txt_zip.Text;
        da.InsertCommand.Parameters.Add("@phno", SqlDbType.VarChar).Value = txt_phone.Text;
        da.InsertCommand.Parameters.Add("@fax", SqlDbType.VarChar).Value = txt_fax.Text;
        da.InsertCommand.Parameters.Add("@mob", SqlDbType.VarChar).Value = txt_mobile.Text;
        //da.InsertCommand.ExecuteNonQuery();
        da.InsertCommand = new SqlCommand("insert into login values(@username, @password",con);
        da.InsertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = txt_name.Text;
        da.InsertCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = txt_pas.Text;
        da.InsertCommand.ExecuteNonQuery();
        con.Close();
        //Response.Redirect("loginn.aspx");
        //if (x > 0)
        //{
        //    Response.Write(txt_pas.Text);
           // Response.Redirect("loginn.aspx");

        //}
        //else
        //{
        //    lblmsg.Text = "Registration failed";
        //    lblmsg.Visible = true;

        //}
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txt_name.Text = " ";
        txt_pas.Text = "";
        txt_ful.Text = "";
        drop_gen.Text = "";
        drop_mari.Text = "";
        txtDOB.Text = "";
        txt_mail.Text = "";
        txt_street.Text = "";
        drop_state.ClearSelection();
        drop_city.ClearSelection();
        txt_zip.Text = " ";
        txt_phone.Text = " ";
        txt_fax.Text = " ";
        txt_mobile.Text = " ";
        lblmsg.Visible = false;
    }
    protected void txt_name_TextChanged(object sender, EventArgs e)
    {

    }
}