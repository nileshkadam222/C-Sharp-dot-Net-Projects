using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace SangliTradingCompany
{
    public partial class Print : Form
    {
        String c = Properties.Settings.Default.Database1ConnectionString;
        SqlConnection con;
        int ID;
        public Print()
        {
            con = new SqlConnection(c);
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }


        private void Print_Load(object sender, EventArgs e)
        {

            con.Open();
            String str = "select Max(Bill_Number) from bill_table1";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ID = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();

            String sql = "select Customer_Name,Company_Name,Bill_Number,Date,Product1_Name,Product1_Quantity,Product1_NetKg,Product1_Unit_Price,Product1_Total_Amount from bill_table1 where Bill_Number='" + ID + "'";
            SqlCommand selectcon = new SqlCommand(sql, con);
            SqlDataReader dr1 = selectcon.ExecuteReader();
            if (dr1.Read())
            {
               label9.Text = dr1[0].ToString();
               label10.Text = dr1[1].ToString();
               label11.Text = dr1[2].ToString();
               label12.Text = dr1[3].ToString();
               label13.Text = dr1[4].ToString();
               label14.Text = dr1[5].ToString();
               label15.Text = dr1[6].ToString();
               label16.Text = dr1[7].ToString();
               label18.Text = dr1[8].ToString();
            }
            dr1.Close();
            con.Close();
        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.ShowDialog();
           
            

        }
       
        private void printDocument1_PrintPage(object sender,System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    

    }
}
