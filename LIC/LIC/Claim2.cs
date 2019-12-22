using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LIC
{
    public partial class Claim2 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbConnection con;
        OleDbDataReader dr;

        public Claim2()
        {
            InitializeComponent();
        }
        public void openConnection()
        {
            con = new OleDbConnection();
            String str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
            con.ConnectionString = str;
            con.Open();
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    home h = new home();
        //    h.Show();
        //    this.Hide();
        //}



        private void Claim2_Load(object sender, EventArgs e)
        {
            openConnection();


            String str = "Select Policy_No from C_PolicyDetails order by Policy_No";
            cmd = new OleDbCommand(str, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo_polno.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
            }
            button1.Enabled = false;
          //  button2.Enabled = false;
        
        }

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{

        //    if (c_nature.Text == "")
        //    {
        //        errorProvider1.SetError(c_nature, "Please select nature of Claimant");
        //    }
        //    else
        //    {
        //        errorProvider1.Clear();
        //    }
        //}



      
       
       



       

        private void txt_cname_TextChanged_1(object sender, EventArgs e)
        {
            if (c_nature.Text == "")
            {
                errorProvider1.SetError(c_nature, "Please enter the nature of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void c_age_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_cname.Text == "")
            {
                errorProvider1.SetError(txt_cname, "Please enter the name of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void c_mobno_TextChanged_1(object sender, EventArgs e)
        {
            if (c_age.Text == "")
            {
                errorProvider1.SetError(c_age, "Please enter the age of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }


        }

       

        private void c_relation_TextChanged_1(object sender, EventArgs e)
        {
            if (rtb_address.Text == "")
            {
                errorProvider1.SetError(rtb_address, "Please enter the address of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

       

        private void dtp_dtofdeath_ValueChanged(object sender, EventArgs e)
        {
            if (txt_plceofdth.Text == "")
            {
                errorProvider1.SetError(txt_plceofdth, "Please enter the place of death of deceased life");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                openConnection();
                String stm = "select N_Dob from C_PersonalDetails where N_Name=@s1";
                cmd = new OleDbCommand(stm, con);
                cmd.Parameters.Add("@s1", OleDbType.Char);
                cmd.Parameters["@s1"].Value = txt_nname.Text;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DateTime s = DateTime.Parse(dr[0].ToString());
                    DateTime s1 =DateTime.Parse(dtp_dtofdeath.Text);
                    int age = s1.Year - s.Year;
                    txt_dage.Text = age.ToString();
                    txt_dage.Enabled = false;

                 
                  
                }
                //else
                //{
                //    MessageBox.Show("Error");

                //}
            }
            catch (Exception) { }
        }

       

        private void txt_cause_TextChanged(object sender, EventArgs e)
        {
            if (txt_dage.Text == "")
            {
                errorProvider1.SetError(txt_dage, "Select Date of Death from the given Calender");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cbo_polno.Text != "" && c_nature.Text != "" && txt_cname.Text != "" && c_age.Text != "" && c_mobno.Text != "" && rtb_address.Text != "" && c_relation.Text != "" && txt_plceofdth.Text != "" && txt_dage.Text != "" && txt_cause.Text != "")
            {
                button1.Enabled = true;
              //  button2.Enabled = true;
            }
            else
            {
               
             //   button2.Enabled = false;
                button1.Enabled = false;
            }
        }

      

       

       

       
        private void txt_plceofdth_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("INVALID INPUT");
                e.Handled = true;
            }
        }

        private void txt_cause_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("INVALID INPUT");
                e.Handled = true;
            }
        }

        private void cbo_polno_SelectedValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
            openConnection();
            String str = "Select P_SumAssured,N_Name,N_Name,P_DtofComm,Policy_Name from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
            cmd = new OleDbCommand(str, con);
            cmd.Parameters.Add("@s1", OleDbType.Integer);
            cmd.Parameters["@s1"].Value = cbo_polno.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_sumass.Text = dr[0].ToString();
                txt_nname.Text = dr[1].ToString();
                txt_deceasedname.Text = dr[2].ToString();
                dtp_doc.Text = dr[3].ToString();
                label7.Text = dr[4].ToString();
                
            }
            else
            {
                MessageBox.Show("Error");

            }
            dtp_dtofdeath.MaxDate = DateTime.Now;
            cbo_polno.Enabled = false;
        }
        public void clear()
        {
            cbo_polno.Text = "";
            cbo_polno.Enabled = true;
            txt_sumass.Text = "";
            txt_nname.Text = "";
            txt_deceasedname.Text = "";
            c_nature.Text = "";
            txt_cname.Text = "";
            c_age.Text = "";
            c_mobno.Text = "";
            rtb_address.Text = "";
            c_relation.Text = "";
            lbl_clmnt.Text = "";
            txt_plceofdth.Text = "";
            txt_dage.Text = "";
            txt_cause.Text= "";
            dtp_doc.Text = "";
        }


        private void c_nature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_polno.Text == "")
            {
               
                errorProvider1.SetError(cbo_polno, "Please select Policy No.");
               
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                if (c_nature.Text == "Proposer")
                {
                    openConnection();
                    String stm = "select C_Name,Address,N_Relationship,C_Dob from C_PolicyDetails c1,C_PersonalDetails c2 where c1.Cust_id=c2.Cust_id AND Policy_No=@s1";
                    cmd = new OleDbCommand(stm, con);
                    cmd.Parameters.Add("@s1", OleDbType.Integer);
                    cmd.Parameters["@s1"].Value = cbo_polno.Text;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txt_cname.Text = dr[0].ToString();
                        rtb_address.Text = dr[1].ToString();
                        c_relation.Text = dr[2].ToString();
                        String dob = dr[3].ToString();
                        DateTime dt = DateTime.Parse(dob);
                        int age = Convert.ToInt32(DateTime.Now.Year - dt.Year);
                        c_age.Text = age.ToString();
                        lbl_clmnt.Text = txt_cname.Text;
                        txt_cname.Enabled = false;
                        rtb_address.Enabled = false;
                        c_relation.Enabled = false;
                        c_age.Enabled = false;


                    }
                    else
                    {
                        MessageBox.Show("Error");

                    }


                }
                else
                {
                   // cbo_polno.Enabled = false;
                    txt_cname.Enabled = true;
                    lbl_clmnt.Text = txt_cname.Text;
                    rtb_address.Enabled = true;
                    c_relation.Enabled = true;
                    c_age.Enabled = true;
                    txt_cname.Text = "";
                    rtb_address.Text = "";
                    c_age.Text = "";
                    c_relation.Text = "";
                    lbl_clmnt.Text = "";

                }

                

            }
            catch (Exception)
            {
              //  MessageBox.Show(""+ex.Message);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\LIC\\LIC.mdb; Persist Security Info=false";
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into DeathClaim(Policy_No,P_SumAssured,N_Name,Deased_Name,Claimant_Nature,Claimant_Name,Claimant_Age,Claimant_Mobile,Claimant_Address,Claimant_Relationship,D_PlaceofDeath,D_DateofDeath,D_Age,D_CauseofDeath,DtofComm) Values('" + cbo_polno.Text + "','" + txt_sumass.Text + "','" + txt_nname.Text + "','" + txt_deceasedname.Text + "','" + c_nature.Text + "','" + txt_cname.Text + "','" + c_age.Text + "','" + c_mobno.Text + "','" + rtb_address.Text + "','" + c_relation.Text + "','" + txt_plceofdth.Text + "','" + dtp_dtofdeath.Text + "','" + txt_dage.Text + "','" + txt_cause.Text + "','" + dtp_doc.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();


                if (cbo_polno.Text == "" || c_nature.Text == "" || txt_cname.Text == "" || c_age.Text == "" || c_mobno.Text == "" || rtb_address.Text == "" || c_relation.Text == "" || txt_plceofdth.Text == "" || txt_dage.Text == "" || txt_cause.Text == "")
                {
                    MessageBox.Show("Please fill valid required fields");
                }
                else
                {
                    MessageBox.Show("Print an Acknowlegement Slip!!!");
                    AcknowledgementSlip2 c = new AcknowledgementSlip2();
                    c.Show();
                    this.Hide();
                    con.Close();
                    c.txt_polno.Text = cbo_polno.Text;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                clear();
                errorProvider1.Clear();
 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            errorProvider1.Clear();
           
        }

       
           

      

        private void txt_cname_TextChanged(object sender, EventArgs e)
        {
            if (c_nature.Text == "")
            {

                errorProvider1.SetError(c_nature, "Please select Nature of Claimant.");
            }
            else
            {
                errorProvider1.Clear();
            }
            lbl_clmnt.Text = txt_cname.Text;
        }

        private void txt_cname_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Invalid Input");
                e.Handled = true;
            }
        }

        private void c_relation_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("INVALID INPUT");
                e.Handled = true;
            }
        }

        private void c_age_TextChanged(object sender, EventArgs e)
        {
            if (txt_cname.Text == "")
            {

                errorProvider1.SetError(txt_cname, "Please enter claimant name.");
            }
            else
            {
                errorProvider1.Clear();
            }
            
            try
            {
                long age = Convert.ToInt64(c_age.Text);
            }
            catch (FormatException)
            {
                if (c_age.Text.Length != 0)
                {
                    MessageBox.Show("PLEASE ENTER THE NUMERIC VALUE");
                    c_age.SelectAll();
                }

            }
        }

        private void rtb_address_TextChanged(object sender, EventArgs e)
        {

            if (c_mobno.Text == "")
            {
                errorProvider1.SetError(c_mobno, "Please enter the mobile number of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void c_relation_TextChanged(object sender, EventArgs e)
        {

            if (rtb_address.Text == "")
            {
                errorProvider1.SetError(rtb_address, "Please enter the mobile number of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_plceofdth_TextChanged(object sender, EventArgs e)
        {
            if (c_mobno.Text == "")
            {
                errorProvider1.SetError(c_mobno, "Please enter the mobile number of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }
            
            if (c_relation.Text == "")
            {
                errorProvider1.SetError(c_relation, "Please enter the relation of Claimant");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void c_mobno_TextChanged(object sender, EventArgs e)
        {
            if (c_age.Text == "")
            {

                errorProvider1.SetError(c_age, "Please claimant age.");
            }
            else
            {
                errorProvider1.Clear();
            }

            try
            {
                long income = Convert.ToInt64(c_mobno.Text);
                if (c_mobno.Text.Length > 10)
                {
                    MessageBox.Show("PLEASE ENTER 10 DIGIT VALUR FOR MOBILE NUMBER");
                    c_mobno.SelectAll();
                }
            }
            catch (FormatException)
            {
                if (c_mobno.Text.Length != 0)
                {
                    MessageBox.Show("PLEASE ENTER THE NUMERIC VALUE");
                    c_mobno.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("'Mobile number exceeding 10 digit.'");
                c_mobno.SelectAll();

            }

        }

        private void c_mobno_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                long income = Convert.ToInt64(c_mobno.Text);
                if (c_mobno.Text.Length < 10)
                {
                    MessageBox.Show("PLEASE ENTER 10 DIGIT VALUR FOR MOBILE NUMBER");
                    c_mobno.SelectAll();
                    c_mobno.Focus();
                }
            }
            catch (FormatException)
            {
                if (c_mobno.Text.Length != 0)
                {
                    MessageBox.Show("PLEASE ENTER THE NUMERIC VALUE");
                    c_mobno.SelectAll();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("'Mobile number exceeding 10 digit.'      " + ex.Message);
                c_mobno.SelectAll();

            } 


        }
        

        
       
       

             
        
         //    try
        //    {
        //        long mob = Convert.ToInt64(c_mobno.Text);
        //        if (c_mobno.Text.Length > 10)
        //        {
        //            MessageBox.Show("PLEASE ENTER 10 DIGIT VALUR FOR MOBILE NUMBER");
        //            c_mobno.SelectAll();
        //            c_mobno.Focus();
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show("PLEASE ENTER THE NUMERIC VALUE");
        //        c_mobno.SelectAll();
        //        c_mobno.Focus();
        //    }
        }

      
      //  private void c_mobno_KeyPress(object sender, KeyPressEventArgs e)
     //   {
           
        //}



        //    try
        //    {
        //        int digit;
        //        int mob = Convert.ToInt32(c_mobno.Text); ;
        //        int res = mob;
        //        while (res != 0)
        //        {
        //            digit = res % 10;
        //            res /= 10;

        //        }
        //        if (res == 0)
        //        {
        //            MessageBox.Show("Invalid Number");
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("" + ex.Message);
        //    }
        //}


        //private void c_mobno_Validating(object sender, CancelEventArgs e)
        //{
    //    //if (String.IsNullOrWhiteSpace(c_mobno.Text, 0))
    //    //{

    //    //}

    //    //System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex("[1-9]^[0-9]{8}");
    //    //if (re.IsMatch(c_mobno.Text.Trim()) == false || c_mobno.Text.Length > 10)
    //    //{
    //    //    MessageBox.Show("INVALID MOBILE NUMBER");
    //    //    c_mobno.Focus();
    //    //}


    //    try
    //    {
    //        long mob = Convert.ToInt64(c_mobno.Text);
    //        if (c_mobno.Text.Length > 10)
    //        {
    //            MessageBox.Show("PLEASE ENTER 10 DIGIT VALUR FOR MOBILE NUMBER");
    //            c_mobno.SelectAll();
    //            c_mobno.Focus();
    //        }
    //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show("PLEASE ENTER THE NUMERIC VALUE");
        //        c_mobno.SelectAll();
        //        c_mobno.Focus();
        //    }
        //}
       

       

       

       
        
      

      

        

    }


       

       

       
      
    

