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
    SqlDataAdapter da;
    DataSet ds;
    int y;
    String dt;
    String test;
    int count;
    

    protected void Page_Load(object sender, EventArgs e)
    {
       
        con.Open();
        cmd.Connection = con;
        y = Convert.ToInt32(Request.QueryString.Get("y"));
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

        

    }
    protected void but_date_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
        lbl_mis.Visible = false;
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txt_date.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
        DateTime  test = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        DateTime test1 = Convert.ToDateTime(txt_date.Text);
        
        if (test1 >= test)
        {   
           dt = txt_date.Text;
           check_1.Enabled = true;
           check_2.Enabled = true;
           check_3.Enabled = true;
           check_4.Enabled = true;


       }
        else
        {
            lbl_mis.Visible = true;
            lbl_mis.Text = "Please select correct date";
            txt_date.Text = "";
        }
        da = new SqlDataAdapter("SELECT * FROM TnT_KERALAPRIVATESEAT WHERE DATE='" + dt + "' and SNo=" + y + " ", con);
        ds = new DataSet();
        da.Fill(ds,"Result");
        DataTable dat=ds.Tables["Result"];
        int cnt = dat.Rows.Count;
       // Response.Write("<script>alert('" + test + "')</script>");
        if (cnt!=0)
        {
            string seatno;
            for (int w = 0; w < cnt; w++)
            {
                seatno = dat.Rows[w][2].ToString();
                foreach (ListItem li in check_1.Items)
                {
                    if (li.Text == seatno)
                    {
                        li.Selected = true;
                        li.Enabled = false;
                    }

                }

                foreach (ListItem li1 in check_2.Items)
                {
                    if (li1.Text == seatno)
                    {
                        li1.Selected = true;
                        li1.Enabled = false;
                    }

                }

                foreach (ListItem li2 in check_3.Items)
                {
                    if (li2.Text == seatno)
                    {
                        li2.Selected = true;
                        li2.Enabled = false;
                    }

                }

                foreach (ListItem li3 in check_4.Items)
                {
                    if (li3.Text == seatno)
                    {
                        li3.Selected = true;
                        li3.Enabled = false;
                    }

                }
            } 
        }
        else
        {
            foreach (ListItem li in check_1.Items)
            {
                
                    li.Selected = false;
                    li.Enabled = true;
                

            }

            foreach (ListItem li1 in check_2.Items)
            {
                
                    li1.Selected = false;
                    li1.Enabled = true;
                

            }

            foreach (ListItem li2 in check_3.Items)
            {
               
                    li2.Selected = false;
                    li2.Enabled = true;
                

            }

            foreach (ListItem li3 in check_4.Items)
            {
               
                    li3.Selected = false;
                    li3.Enabled = true;
               

            }
            
        }


    }
    protected void but_continue_Click(object sender, EventArgs e)
    {
        foreach (ListItem li in check_1.Items)
        {

            if (li.Selected == true && li.Enabled == true)
            {
                cmd.CommandText = "insert into TnT_keralaprivateseat values(" + y + ",'" + txt_date.Text + "','" + li.Text + "','fill')";
                cmd.ExecuteNonQuery();
                test += li.Text + ",";
                count++;
            }
        }

        foreach (ListItem li2 in check_2.Items)
        {

            if (li2.Selected == true && li2.Enabled == true)
            {
                cmd.CommandText = "insert into TnT_keralaprivateseat values(" + y + ",'" + txt_date.Text + "','" + li2.Text + "','fill')";
                cmd.ExecuteNonQuery();
                test += li2.Text + ",";
                count++;
            }
        }

        foreach (ListItem li3 in check_3.Items)
        {

            if (li3.Selected == true && li3.Enabled == true)
            {
                cmd.CommandText = "insert into TnT_keralaprivateseat values(" + y + ",'" + txt_date.Text + "','" + li3.Text + "','fill')";
                cmd.ExecuteNonQuery();
                test += li3.Text + ",";
                count++;
            }
        }

        foreach (ListItem li4 in check_4.Items)
        {

            if (li4.Selected == true && li4.Enabled == true)
            {
                cmd.CommandText = "insert into TnT_keralaprivateseat values(" + y + ",'" + txt_date.Text + "','" + li4.Text + "','fill')";
                cmd.ExecuteNonQuery();
                test += li4.Text + ",";
                count++;
            }
        }
       
        test = test.Substring(0, test.Length - 1);
        //lblmsg.Text = test;
        //lblmsg.Visible = true;
        Response.Redirect("TnT_ksrtcprivatethirdpage.aspx?y=" + y + "&test=" + test + "&count=" + count + "&date=" + txt_date.Text);
    }

    
protected void  chk_31_CheckedChanged(object sender, EventArgs e)
{

}
}
