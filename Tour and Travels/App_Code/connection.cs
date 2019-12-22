using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for connection
/// </summary>
public class connection
{
    public SqlConnection con = null;
    SqlCommand cmd = null;
    SqlDataReader dr;
    SqlDataAdapter da;
    SqlDataSource ds;







    public void TransData(string strQuery)
    {
        con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["kioskDB"].ConnectionString;
        con.Open();
        cmd = new SqlCommand(strQuery, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }


    public SqlDataReader RetrieveData(string strQuery)
    {
        con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["kioskDB"].ConnectionString;
        con.Open();
        cmd = new SqlCommand(strQuery, con);
        dr = cmd.ExecuteReader();
        return dr;


    }
	
}
