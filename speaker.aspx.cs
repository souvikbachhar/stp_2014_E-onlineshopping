using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class speaker : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter sda;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    static int aaa = 0;
    static string p = "", q = "", r = "", s1 = "", s2 = "", s3 = "";
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (CheckBoxList1.SelectedItem == null)
        {
            //Label1.Text = "win";
            string s = "select * from Speaker";
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            sda = new SqlDataAdapter(s, con);
            sda.Fill(ds, "t");
            li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
            li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
            li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
            li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
            li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
            li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
            li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
            li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
            li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
            li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
            li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
            li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
            li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
            li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
            li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();
            li15.ImageUrl = "" + ds.Tables["t"].Rows[15][8].ToString();
            ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
            ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
            ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
            ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
            ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
            ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
            ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
            ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
            ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
            ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
            ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
            ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
            ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
            ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
            ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();
            ll16.Text = "" + ds.Tables["t"].Rows[15][1].ToString();

            li1.Visible = true;
            li2.Visible = true;
            li3.Visible = true;
            li4.Visible = true;
            li5.Visible = true;
            li6.Visible = true;
            li7.Visible = true;
            li8.Visible = true;

            ll1.Visible = true;
            ll2.Visible = true;
            ll3.Visible = true;
            ll4.Visible = true;
            ll5.Visible = true;
            ll6.Visible = true;
            ll7.Visible = true;
            ll8.Visible = true;
            li9.Visible = true;
            li10.Visible = true;
            li11.Visible = true;
            li12.Visible = true;
            ll9.Visible = true;
            ll10.Visible = true;
            ll11.Visible = true;
            ll12.Visible = true;
            li13.Visible = true;
            li14.Visible = true;
            li15.Visible = true;
            li16.Visible = true;
            ll13.Visible = true;
            ll14.Visible = true;
            ll15.Visible = true;
            ll16.Visible = true;


        }
        foreach (ListItem li in CheckBoxList1.Items)
        {
            int c = 0;


            if (li.Selected == true)
            {
                q = li.Text;
                string s = "select * from Speaker where Brand='" + q + "'";
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                sda = new SqlDataAdapter(s, con);
                sda.Fill(ds, "t");
                c = ds.Tables["t"].Rows.Count;
                // Label1.Text = "" + a;
                con.Close();
            }
            if (c == 1)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.Visible = false;
                li3.Visible = false;
                li4.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Visible = false;
                ll3.Visible = false;
                ll4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 2)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li2.Visible = true;
                li3.Visible = false;
                li4.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Visible = false;
                ll2.Visible = true;
                ll4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 4)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                ll1.Visible = true;
                ll3.Visible = true;
                ll2.Visible = true;
                ll4.Visible = true;

                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 5)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();

                ll5.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;

                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;


            }
            if (c == 3)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;

                li4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll4.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;


            }
            if (c == 7)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 6)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();

                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = false;
                li8.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;

                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }

            if (c == 8)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;

                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }

            if (c == 10)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();

                li11.Visible = false;
                li12.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                ll11.Visible = false;
                ll12.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 9)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.Visible = false;

                li11.Visible = false;
                li12.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                ll11.Visible = false;
                ll12.Visible = false;


                li10.Visible = true;


                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 11)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 12)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[10][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;

                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 16)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
                li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();
                li15.ImageUrl = "" + ds.Tables["t"].Rows[15][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
                ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();
                ll16.Text = "" + ds.Tables["t"].Rows[15][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;
                li15.Visible = true;
                li16.Visible = true;

                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;
                ll15.Visible = true;
                ll16.Visible = true;

            }
            if (c == 13)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();

                li14.Visible = false;
                li16.Visible = false;
                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;

            }
            if (c == 14)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();


                li16.Visible = false;
                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();

                ll15.Visible = false;
                ll16.Visible = false;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;



            }
            if (c == 15)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
                li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();


                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
                ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();

                ll16.Visible = false;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;

                li16.Visible = true;

                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;
                ll15.Visible = true;


            }






        }
    }
    public void work()
    {



        Label2.Text = ds.Tables["t"].Rows[0][1].ToString();
        Label3.Text = ds.Tables["t"].Rows[0][3].ToString();
        Label4.Text = ds.Tables["t"].Rows[0][2].ToString();
        Label5.Text = ds.Tables["t"].Rows[0][4].ToString();
        Label6.Text = ds.Tables["t"].Rows[0][5].ToString();
        Label7.Text = ds.Tables["t"].Rows[0][6].ToString();
        Label8.Text = ds.Tables["t"].Rows[0][7].ToString();
        Image2.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
        ImageButton1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
        ImageButton3.ImageUrl = "" + ds.Tables["t"].Rows[0][9].ToString();
        ImageButton4.ImageUrl = "" + ds.Tables["t"].Rows[0][10].ToString();
        ImageButton5.ImageUrl = "" + ds.Tables["t"].Rows[0][11].ToString();

        if (ImageButton5.ImageUrl == "")
        {
            ImageButton5.Visible = false;
        }
        if (ImageButton4.ImageUrl == "")
        {
            ImageButton4.Visible = false;
        }
        if (ImageButton3.ImageUrl == "")
        {
            ImageButton3.Visible = false;
        }

    }
    protected void ll1_Click(object sender, EventArgs e)
    {
        string a = ll1.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll1.CommandName = "SwitchViewByID";
        ll1.CommandArgument = "View2";

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Image2.ImageUrl = ImageButton1.ImageUrl;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Image2.ImageUrl = ImageButton3.ImageUrl;
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Image2.ImageUrl = ImageButton4.ImageUrl;
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {


        Image2.ImageUrl = ImageButton5.ImageUrl;

    }
    protected void ll3_Click(object sender, EventArgs e)
    {
        string a = ll3.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll3.CommandName = "SwitchViewByID";
        ll3.CommandArgument = "View2";

    }
    protected void ll2_Click(object sender, EventArgs e)
    {
        string a = ll2.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll2.CommandName = "SwitchViewByID";
        ll2.CommandArgument = "View2";
    }
    protected void ll4_Click(object sender, EventArgs e)
    {
        string a = ll4.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll4.CommandName = "SwitchViewByID";
        ll4.CommandArgument = "View2";
    }
    protected void ll5_Click(object sender, EventArgs e)
    {
        string a = ll5.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll5.CommandName = "SwitchViewByID";
        ll5.CommandArgument = "View2";
    }
    protected void ll6_Click(object sender, EventArgs e)
    {
        string a = ll6.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll6.CommandName = "SwitchViewByID";
        ll6.CommandArgument = "View2";
    }
    protected void ll7_Click(object sender, EventArgs e)
    {
        string a = ll7.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll7.CommandName = "SwitchViewByID";
        ll7.CommandArgument = "View2";
    }
    protected void ll8_Click(object sender, EventArgs e)
    {
        string a = ll8.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll8.CommandName = "SwitchViewByID";
        ll8.CommandArgument = "View2";
    }
    protected void ll9_Click(object sender, EventArgs e)
    {
        string a = ll9.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll9.CommandName = "SwitchViewByID";
        ll9.CommandArgument = "View2";
    }
    protected void ll10_Click(object sender, EventArgs e)
    {
        string a = ll10.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll10.CommandName = "SwitchViewByID";
        ll10.CommandArgument = "View2";
    }
    protected void ll11_Click(object sender, EventArgs e)
    {
        string a = ll11.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll11.CommandName = "SwitchViewByID";
        ll11.CommandArgument = "View2";
    }
    protected void ll12_Click(object sender, EventArgs e)
    {
        string a = ll12.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll12.CommandName = "SwitchViewByID";
        ll12.CommandArgument = "View2";
    }
    protected void ll13_Click(object sender, EventArgs e)
    {
        string a = ll13.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll13.CommandName = "SwitchViewByID";
        ll13.CommandArgument = "View2";
    }
    protected void ll14_Click(object sender, EventArgs e)
    {
        string a = ll14.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll14.CommandName = "SwitchViewByID";
        ll14.CommandArgument = "View2";
    }
    protected void ll15_Click(object sender, EventArgs e)
    {
        string a = ll15.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll15.CommandName = "SwitchViewByID";
        ll15.CommandArgument = "View2";
    }
    protected void ll16_Click(object sender, EventArgs e)
    {
        string a = ll16.Text;
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string l = "select * from Speaker where Name='" + a + "'";
        sda = new SqlDataAdapter(l, con);
        sda.Fill(ds, "t");
        work();
        ll16.CommandName = "SwitchViewByID";
        ll16.CommandArgument = "View2";

    }
    protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (CheckBoxList2.SelectedItem == null)
        {
            //Label1.Text = "win";
            string s = "select * from Speaker";
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            sda = new SqlDataAdapter(s, con);
            sda.Fill(ds, "t");
            li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
            li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
            li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
            li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
            li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
            li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
            li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
            li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
            li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
            li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
            li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
            li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
            li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
            li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
            li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();
            li15.ImageUrl = "" + ds.Tables["t"].Rows[15][8].ToString();
            ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
            ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
            ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
            ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
            ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
            ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
            ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
            ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
            ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
            ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
            ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
            ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
            ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
            ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
            ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();
            ll16.Text = "" + ds.Tables["t"].Rows[15][1].ToString();

            li1.Visible = true;
            li2.Visible = true;
            li3.Visible = true;
            li4.Visible = true;
            li5.Visible = true;
            li6.Visible = true;
            li7.Visible = true;
            li8.Visible = true;

            ll1.Visible = true;
            ll2.Visible = true;
            ll3.Visible = true;
            ll4.Visible = true;
            ll5.Visible = true;
            ll6.Visible = true;
            ll7.Visible = true;
            ll8.Visible = true;
            li9.Visible = true;
            li10.Visible = true;
            li11.Visible = true;
            li12.Visible = true;
            ll9.Visible = true;
            ll10.Visible = true;
            ll11.Visible = true;
            ll12.Visible = true;
            li13.Visible = true;
            li14.Visible = true;
            li15.Visible = true;
            li16.Visible = true;
            ll13.Visible = true;
            ll14.Visible = true;
            ll15.Visible = true;
            ll16.Visible = true;


        }
        foreach (ListItem lip in CheckBoxList2.Items)
        {
            int c = 0;


            if (lip.Selected == true)
            {
                s1 = lip.Value;
                string s = "select * from Speaker where hell='" + s1 + "'";
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                sda = new SqlDataAdapter(s, con);
                sda.Fill(ds, "t");
                c = ds.Tables["t"].Rows.Count;
                // Label1.Text = "" + a;
                con.Close();
            }
            if (c == 1)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.Visible = false;
                li3.Visible = false;
                li4.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Visible = false;
                ll3.Visible = false;
                ll4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 2)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li2.Visible = true;
                li3.Visible = false;
                li4.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Visible = false;
                ll2.Visible = true;
                ll4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 4)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                ll1.Visible = true;
                ll3.Visible = true;
                ll2.Visible = true;
                ll4.Visible = true;

                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 5)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();

                ll5.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;

                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;


            }
            if (c == 3)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;

                li4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll4.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;


            }
            if (c == 7)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 6)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();

                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = false;
                li8.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;

                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }

            if (c == 8)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;

                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }

            if (c == 10)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();

                li11.Visible = false;
                li12.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                ll11.Visible = false;
                ll12.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 9)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.Visible = false;

                li11.Visible = false;
                li12.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                ll11.Visible = false;
                ll12.Visible = false;


                li10.Visible = true;


                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 11)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 12)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[10][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;

                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 16)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
                li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();
                li15.ImageUrl = "" + ds.Tables["t"].Rows[15][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
                ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();
                ll16.Text = "" + ds.Tables["t"].Rows[15][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;
                li15.Visible = true;
                li16.Visible = true;

                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;
                ll15.Visible = true;
                ll16.Visible = true;

            }
            if (c == 13)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();

                li14.Visible = false;
                li16.Visible = false;
                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;

            }
            if (c == 14)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();


                li16.Visible = false;
                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();

                ll15.Visible = false;
                ll16.Visible = false;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;



            }
            if (c == 15)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
                li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();


                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
                ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();

                ll16.Visible = false;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;

                li16.Visible = true;

                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;
                ll15.Visible = true;


            }

        }
    }
    static int i99 = 0;
    protected void Timer11_Tick(object sender, EventArgs e)
    {
        string[] s = { "~/img1/1.jpg", "~/img1/2.jpg", "~/img1/3.jpg", "~/img1/4.jpg" };
        if (i99 < s.Length)
        {
            Image38.ImageUrl = s[i99];
            i99++;
        }
        else
        {
            i99 = 0;
        }
    }

    protected void CheckBoxList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (CheckBoxList4.SelectedItem == null)
        {
            //Label1.Text = "win";
            string s = "select * from Speaker";
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            sda = new SqlDataAdapter(s, con);
            sda.Fill(ds, "t");
            li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
            li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
            li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
            li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
            li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
            li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
            li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
            li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
            li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
            li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
            li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
            li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
            li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
            li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
            li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();
            li15.ImageUrl = "" + ds.Tables["t"].Rows[15][8].ToString();
            ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
            ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
            ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
            ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
            ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
            ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
            ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
            ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
            ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
            ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
            ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
            ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
            ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
            ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
            ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();
            ll16.Text = "" + ds.Tables["t"].Rows[15][1].ToString();

            li1.Visible = true;
            li2.Visible = true;
            li3.Visible = true;
            li4.Visible = true;
            li5.Visible = true;
            li6.Visible = true;
            li7.Visible = true;
            li8.Visible = true;

            ll1.Visible = true;
            ll2.Visible = true;
            ll3.Visible = true;
            ll4.Visible = true;
            ll5.Visible = true;
            ll6.Visible = true;
            ll7.Visible = true;
            ll8.Visible = true;
            li9.Visible = true;
            li10.Visible = true;
            li11.Visible = true;
            li12.Visible = true;
            ll9.Visible = true;
            ll10.Visible = true;
            ll11.Visible = true;
            ll12.Visible = true;
            li13.Visible = true;
            li14.Visible = true;
            li15.Visible = true;
            li16.Visible = true;
            ll13.Visible = true;
            ll14.Visible = true;
            ll15.Visible = true;
            ll16.Visible = true;


        }
        foreach (ListItem lit in CheckBoxList4.Items)
        {
            int c = 0;


            if (lit.Selected == true)
            {
                s2 = lit.Text;
                string s = "select * from Speaker where Type='" + s2 + "'";
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                sda = new SqlDataAdapter(s, con);
                sda.Fill(ds, "t");
                c = ds.Tables["t"].Rows.Count;
                // Label1.Text = "" + a;
                con.Close();
            }
            if (c == 1)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.Visible = false;
                li3.Visible = false;
                li4.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Visible = false;
                ll3.Visible = false;
                ll4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 2)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li2.Visible = true;
                li3.Visible = false;
                li4.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Visible = false;
                ll2.Visible = true;
                ll4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 4)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                ll1.Visible = true;
                ll3.Visible = true;
                ll2.Visible = true;
                ll4.Visible = true;

                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 5)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();

                ll5.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;

                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;


            }
            if (c == 3)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;

                li4.Visible = false;
                li5.Visible = false;
                li6.Visible = false;
                li7.Visible = false;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;
                ll4.Visible = false;
                ll5.Visible = false;
                ll6.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;


            }
            if (c == 7)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                li8.Visible = false;
                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll8.Visible = false;
                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 6)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();

                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = false;
                li8.Visible = false;
                ll7.Visible = false;
                ll8.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;

                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }

            if (c == 8)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;

                li9.Visible = false;
                li10.Visible = false;
                li11.Visible = false;
                li12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll9.Visible = false;
                ll10.Visible = false;
                ll11.Visible = false;
                ll12.Visible = false;
                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }

            if (c == 10)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();

                li11.Visible = false;
                li12.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                ll11.Visible = false;
                ll12.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 9)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.Visible = false;

                li11.Visible = false;
                li12.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Visible = false;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                ll11.Visible = false;
                ll12.Visible = false;


                li10.Visible = true;


                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 11)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = false;
                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 12)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();

                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[10][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;

                li13.Visible = false;
                li14.Visible = false;
                li15.Visible = false;
                li16.Visible = false;


                ll13.Visible = false;
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

            }
            if (c == 16)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
                li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();
                li15.ImageUrl = "" + ds.Tables["t"].Rows[15][8].ToString();
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
                ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();
                ll16.Text = "" + ds.Tables["t"].Rows[15][1].ToString();

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;
                li15.Visible = true;
                li16.Visible = true;

                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;
                ll15.Visible = true;
                ll16.Visible = true;

            }
            if (c == 13)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();

                li14.Visible = false;
                li16.Visible = false;
                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Visible = false;
                ll15.Visible = false;
                ll16.Visible = false;

                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;

            }
            if (c == 14)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();


                li16.Visible = false;
                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();

                ll15.Visible = false;
                ll16.Visible = false;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;
                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;



            }
            if (c == 15)
            {
                li1.ImageUrl = "" + ds.Tables["t"].Rows[0][8].ToString();
                li2.ImageUrl = "" + ds.Tables["t"].Rows[1][8].ToString();
                li3.ImageUrl = "" + ds.Tables["t"].Rows[2][8].ToString();
                li4.ImageUrl = "" + ds.Tables["t"].Rows[3][8].ToString();
                li5.ImageUrl = "" + ds.Tables["t"].Rows[4][8].ToString();
                li6.ImageUrl = "" + ds.Tables["t"].Rows[5][8].ToString();
                li7.ImageUrl = "" + ds.Tables["t"].Rows[6][8].ToString();
                li8.ImageUrl = "" + ds.Tables["t"].Rows[7][8].ToString();
                li9.ImageUrl = "" + ds.Tables["t"].Rows[8][8].ToString();
                li10.ImageUrl = "" + ds.Tables["t"].Rows[9][8].ToString();
                li11.ImageUrl = "" + ds.Tables["t"].Rows[10][8].ToString();
                li12.ImageUrl = "" + ds.Tables["t"].Rows[11][8].ToString();
                li13.ImageUrl = "" + ds.Tables["t"].Rows[12][8].ToString();
                li14.ImageUrl = "" + ds.Tables["t"].Rows[13][8].ToString();
                li16.ImageUrl = "" + ds.Tables["t"].Rows[14][8].ToString();


                li15.Visible = false;
                ll1.Text = "" + ds.Tables["t"].Rows[0][1].ToString();
                ll2.Text = "" + ds.Tables["t"].Rows[1][1].ToString();
                ll3.Text = "" + ds.Tables["t"].Rows[2][1].ToString();
                ll4.Text = "" + ds.Tables["t"].Rows[3][1].ToString();
                ll5.Text = "" + ds.Tables["t"].Rows[4][1].ToString();
                ll6.Text = "" + ds.Tables["t"].Rows[5][1].ToString();
                ll7.Text = "" + ds.Tables["t"].Rows[6][1].ToString();
                ll8.Text = "" + ds.Tables["t"].Rows[7][1].ToString();
                ll9.Text = "" + ds.Tables["t"].Rows[8][1].ToString();
                ll10.Text = "" + ds.Tables["t"].Rows[9][1].ToString();
                ll11.Text = "" + ds.Tables["t"].Rows[10][1].ToString();
                ll12.Text = "" + ds.Tables["t"].Rows[11][1].ToString();
                ll13.Text = "" + ds.Tables["t"].Rows[12][1].ToString();
                ll14.Text = "" + ds.Tables["t"].Rows[13][1].ToString();
                ll15.Text = "" + ds.Tables["t"].Rows[14][1].ToString();

                ll16.Visible = false;
                li1.Visible = true;
                li2.Visible = true;
                li3.Visible = true;
                li4.Visible = true;
                li5.Visible = true;
                li6.Visible = true;
                li7.Visible = true;
                li8.Visible = true;
                li9.Visible = true;
                li10.Visible = true;
                li11.Visible = true;
                li12.Visible = true;
                li13.Visible = true;
                li14.Visible = true;

                li16.Visible = true;

                ll1.Visible = true;
                ll2.Visible = true;
                ll3.Visible = true;
                ll4.Visible = true;
                ll5.Visible = true;
                ll6.Visible = true;
                ll7.Visible = true;
                ll8.Visible = true;
                ll9.Visible = true;
                ll10.Visible = true;
                ll11.Visible = true;
                ll12.Visible = true;
                ll13.Visible = true;
                ll14.Visible = true;
                ll15.Visible = true;


            }


        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.CommandArgument = "View1";
        Button1.CommandName = "SwitchViewByID";
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Session["x"] = Label2.Text;
        Session["y"] = Label4.Text;
        Session["z"] = Label3.Text;
        Session["w"] = Image2.ImageUrl.ToString();
        Response.Redirect("login2.aspx");
    }
}