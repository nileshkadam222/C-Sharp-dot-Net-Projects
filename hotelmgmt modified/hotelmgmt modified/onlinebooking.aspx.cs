using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class onlinebooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Clear();
    }

    private void Clear()
    {
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
        TextBox4.Text = " ";
        TextBox5.Text = " ";
        TextBox6.Text = " ";
        TextBox7.Text = " ";
        TextBox8.Text = " ";
        DropDownList1.ClearSelection();
        DropDownList2.ClearSelection();
    }
   

    protected void bt_submit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=C:\\USERS\\MARUTI\\DOCUMENTS\\VISUAL STUDIO 2010\\PROJECTS\\HOTELMGMT\\HOTELMGMT\\APP_DATA\\DATABASE.MDF;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        da.InsertCommand = new SqlCommand("INSERT INTO booking VALUES(@Total_persons, @total_rooms, @arriving_date, @departure_date, @any_requirements, @your_name, @email_id, @phone_no, @street_address, @state, @city)");
        da.InsertCommand.Parameters.Add("@Total_persons", SqlDbType.VarChar).Value = TextBox1.Text;
        da.InsertCommand.Parameters.Add("@total_rooms", SqlDbType.VarChar).Value = TextBox2.Text;
        da.InsertCommand.Parameters.Add("@arriving_date", SqlDbType.VarChar).Value = TextBox3.Text;
        da.InsertCommand.Parameters.Add("@departure_date", SqlDbType.VarChar).Value = TextBox4.Text;
        da.InsertCommand.Parameters.Add("@any_requirements", SqlDbType.VarChar).Value = TextBox9.Text;
        da.InsertCommand.Parameters.Add("@your_name", SqlDbType.VarChar).Value = TextBox5.Text;
        da.InsertCommand.Parameters.Add("@email_id", SqlDbType.VarChar).Value = TextBox6.Text;
        da.InsertCommand.Parameters.Add("@phone_no", SqlDbType.VarChar).Value = TextBox7.Text;
        da.InsertCommand.Parameters.Add("@street_address", SqlDbType.VarChar).Value = TextBox8.Text;
        da.InsertCommand.Parameters.Add("@state", SqlDbType.VarChar).Value = DropDownList1.Text;
        da.InsertCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = DropDownList2.Text;
        con.Open(); 
        da.InsertCommand.ExecuteNonQuery();
        Response.Redirect("Default2.aspx ");
        con.Close();
        Clear();
       
    }
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
        TextBox4.Text = " ";
        TextBox5.Text = " ";
        TextBox6.Text = " ";
        TextBox7.Text = " ";
        TextBox8.Text = " ";
        DropDownList1.ClearSelection();
        DropDownList2.ClearSelection();
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        
    }
}