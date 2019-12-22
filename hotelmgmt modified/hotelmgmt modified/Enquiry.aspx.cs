using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Enquiry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        clear();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=C:\\USERS\\MARUTI\\DOCUMENTS\\VISUAL STUDIO 2010\\PROJECTS\\HOTELMGMT\\HOTELMGMT\\APP_DATA\\DATABASE.MDF;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        da.InsertCommand = new SqlCommand("INSERT INTO cust_info VALUES(@ENQUIRY_ABOUT, @NAME, @ADDRESS, @STATE, @CITY)",con);
        da.InsertCommand.Parameters.Add("@Enquiry_about", SqlDbType.VarChar).Value = DropDownList1.Text;
        da.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = TextBox1.Text;
        da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = TextBox2.Text;
        da.InsertCommand.Parameters.Add("@State", SqlDbType.VarChar).Value = statedrop.Text;
        da.InsertCommand.Parameters.Add("@City", SqlDbType.VarChar).Value = citydrop.Text;
        con.Open();
        da.InsertCommand.ExecuteNonQuery();
        Response.Redirect("Default2.aspx");
        //mbox="success";
        con.Close();
        clear();
       

    }

    //private string mbox()
    //{
    //    return "success";
    //}

       protected void Button3_Click(object sender, EventArgs e)
    {
       
    }
    public void clear()
    {
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        DropDownList1.ClearSelection();
        statedrop.ClearSelection();
        citydrop.ClearSelection();
    }
}