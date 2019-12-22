using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace shubhafinal
{
    public partial class upgrade : System.Web.UI.Page
    {
        static SqlConnection connection;
        SqlCommand command = new SqlCommand();
        SqlCommand command1 = new SqlCommand();
        SqlDataReader reader;
        DBConnection Objdbconn = new DBConnection();
        SqlCommand dataCommand = new SqlCommand();
        object objval;
        string queryString;
        string strapplid;
        int applid;

        string membership, fname, lname, address, phone, security, cardnumber,pin;
        Int32  cardtype, expmonth, expyear,  countryid, cityid, stateid;


        protected void Page_Load(object sender, EventArgs e)
        {
            strapplid = Request.QueryString["applid"];
            applid = Convert.ToInt32(strapplid);
            HyperLink1.NavigateUrl = "home.aspx?applid=" + Request.QueryString["applid"];
            HyperLink2.NavigateUrl = "personaldetails.aspx?applid=" + Request.QueryString["applid"];
            HyperLink3.NavigateUrl = "search.aspx?applid=" + Request.QueryString["applid"];
            HyperLink4.NavigateUrl = "upgrade.aspx?applid=" + Request.QueryString["applid"];
            HyperLink5.NavigateUrl = "message.aspx?applid=" + Request.QueryString["applid"];
            HyperLink6.NavigateUrl = "help.aspx?applid=" + Request.QueryString["applid"];
            if (!IsPostBack)
            {
                Objdbconn.ConnectionClose();
                connection = Objdbconn.GetConnectionInfo();
                connection.Open();
                lblerror.Visible = false;
                queryString = "SELECT * FROM tblexpyear";
                command.Connection = connection;
                command.CommandTimeout = 15;
                command.CommandType = CommandType.Text;
                command.CommandText = queryString;

                reader = command.ExecuteReader();
                cmbexpyear.DataSource = reader;
                cmbexpyear.DataValueField = "yearID";
                cmbexpyear.DataTextField = "yearDesc";
                cmbexpyear.DataBind();
                cmbexpyear.Items.Insert(0, "Select");
                reader.Close();

                queryString = "SELECT * FROM tblMonth";
                command.Connection = connection;
                command.CommandTimeout = 15;
                command.CommandType = CommandType.Text;
                command.CommandText = queryString;

                reader = command.ExecuteReader();
                cmbexpmonth.DataSource = reader;
                cmbexpmonth.DataValueField = "monthID";
                cmbexpmonth.DataTextField = "monthDesc";
                cmbexpmonth.DataBind();
                cmbexpmonth.Items.Insert(0, "Select");
                reader.Close();

                queryString = "SELECT * FROM tblcreditcardtype";
                command.Connection = connection;
                command.CommandTimeout = 15;
                command.CommandType = CommandType.Text;
                command.CommandText = queryString;

                reader = command.ExecuteReader();
                cmbcard.DataSource = reader;
                cmbcard.DataValueField = "creditcardtypeID";
                cmbcard.DataTextField = "carddesc";
                cmbcard.DataBind();
                cmbcard.Items.Insert(0, "Select");
                reader.Close();

                FillCountry();

            }

        }
        private void FillCountry()
        {

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = command.CommandText = "Select * from tblcountry ";
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = command;
            dAdapter.Fill(objDs);
            cmbcountry.DataSource = objDs.Tables[0];
            cmbcountry.DataValueField = "countryid";
            cmbcountry.DataTextField = "countryname";
            //cmbcountry.DataTextField = "Country";
            //cmbcountry.DataValueField = "CountryID";
            cmbcountry.DataBind();
            cmbcountry.Items.Insert(0, "Select");
            cmbstate.Enabled = true;


        }

        private void FillStates(int ApplicantCountryID)
        {

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from tblstate where countryid =@countryid";
            command.Parameters.AddWithValue("@countryid", countryid);

            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = command;
            dAdapter.Fill(objDs);
            cmbstate.DataSource = objDs.Tables[0];
            cmbstate.DataValueField = "stateid";
            cmbstate.DataTextField = "statedesc";
            //cmbstate.DataTextField = "State";
            //cmbstate.DataValueField = "StateID";
            cmbstate.DataBind();
            cmbstate.Items.Insert(0, "Select");
            cmbcity.Enabled = true;
        }

        private void FillCities(int stateid, int countryid)
        {

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from tblcity where stateid =" + stateid + " and  countryid=" + countryid;
            //command.Parameters.AddWithValue("@stateid", stateid);
            //command.Parameters.AddWithValue("@countryid", countryid);
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = command;

            dAdapter.Fill(objDs);


            cmbcity.DataSource = objDs.Tables[0];
            cmbcity.DataTextField = "citydesc";
            cmbcity.DataValueField = "cityid";
            cmbcity.DataBind();
            cmbcity.Items.Insert(0, "Select");


        }
        protected void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcountry.SelectedItem.Value == "Select")
            {
                cmbstate.Enabled = false;
                cmbcity.Enabled = false;
            }
            else
            {
                cmbstate.Enabled = true;
                cmbcity.Enabled = true;
                countryid = Convert.ToInt32(cmbcountry.SelectedItem.Value);
                FillStates(countryid);
                cmbcity.Items.Clear();
                cmbcity.Items.Insert(0, "Select");

            }
        }
        protected void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbstate.SelectedItem.Value == "Select")
            {
                cmbcity.Enabled = false;
            }
            else
            {
                cmbcity.Items.Clear();
                cmbcity.Items.Insert(0, "Select");
                cmbcity.Enabled = true;
                stateid = Convert.ToInt32(cmbstate.SelectedItem.Value);
                countryid = Convert.ToInt32(cmbcountry.SelectedItem.Value);
                FillCities(stateid, countryid);
            }
        }
        protected void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcity.SelectedItem.Value == "Select")
            { }
        }

   
        protected void cmddia3_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Diamond 3";

        }

        protected void cmddia6_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Diamond 6";
        
        }

        protected void cmddia9_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Diamond 9";
        
        }

        protected void cmdgold3_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Gold 3";
        
        }

        protected void cmdgold6_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Gold 6";
        
        }

        protected void cmdgold9_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Gold 9";
        
        }

        protected void cmdsilver3_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Silver 3";
        
        }

        protected void cmdsilver6_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Silver 6";
        
        }

        protected void cmdsilver9_Click(object sender, EventArgs e)
        {
            tbldetails.Visible = true;
            lblmembertype.Text = "Silver 9";
        
        }
        protected void cmdsubmit_Click(object sender, EventArgs e)
        {
            if (cmbcard.SelectedItem.Text == "Select" || txtfname.Text == "" || txtlname.Text == "" || txtcardno.Text == "" || cmbexpmonth.SelectedItem.Text == "Select" || cmbexpyear.SelectedItem.Text == "Select" || txtsec.Text == "" || txtpin.Text == "" || txtnumber.Text == "" || txtaddr1.Text == "" || cmbcountry.SelectedItem.Text == "Select" || cmbstate.SelectedItem.Text=="" || cmbstate.SelectedItem.Text=="Select" || cmbcity.SelectedItem.Text== "" || cmbcity.SelectedItem.Text=="Select" )
                lblerror.Visible = true;
            else
            {
                lblerror.Visible = false;
                membership = lblmembertype.Text.ToString();
                cardtype = Convert.ToInt32(cmbcard.SelectedItem.Value);
                cardnumber = Convert.ToString(txtcardno.Text);
                fname = Convert.ToString(txtfname.Text);
                lname = Convert.ToString(txtlname.Text);
                expmonth = Convert.ToInt32(cmbexpmonth.SelectedItem.Value);
                expyear = Convert.ToInt32(cmbexpyear.SelectedItem.Value);
                security = Convert.ToString(txtsec.Text);
                phone = Convert.ToString(txtnumber.Text);
                pin = Convert.ToString(txtpin.Text);
                address = Convert.ToString(txtaddr1.Text);
                countryid = Convert.ToInt32(cmbcountry.SelectedItem.Value);
                stateid = Convert.ToInt32(cmbstate.SelectedItem.Value);
                cityid = Convert.ToInt32(cmbcity.SelectedItem.Value);
                tbldetails.Visible = false;

                
                queryString = "update tblApplicantMembership set membershiptype='" + membership + "',creditcardtypeID=" + cardtype + ", fname='" + fname + "', lname= '" + lname + "',cardnumber= '" + cardnumber + "', expmonth=" + expmonth + " , expyear= " + expyear + " ,securitycode= '" + security + "' ,phonenumber= '" + phone + "',address='" + address + "',pin= '"+ pin +"',country=" + countryid + ",state=" + stateid + ",city="+ cityid + " WHERE  ApplicantID= " + applid + " ";
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = queryString;
                command.ExecuteNonQuery();



            }
        }

        protected void lnksignout_Click(object sender, EventArgs e)
        {
            queryString = "UPDATE tblApplicantAccesscode SET ApllicantLoginStatus=" + "0" + " WHERE ApplicantID=" + applid;
            command.Connection = connection;
            command.CommandTimeout = 15;
            command.CommandType = CommandType.Text;
            command.CommandText = queryString;
            command.ExecuteNonQuery();
            Server.Transfer("login.aspx", true);
        }
            
            


            

            
        
    }
}
