using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    static int i1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("laptop.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("music.aspx");
    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {

        string[] s = { "~/img1/1.jpg", "~/img1/2.jpg", "~/img1/3.jpg", "~/img1/4.jpg"};
        if (i1 < s.Length)
        {
            Image2.ImageUrl = s[i1];
            i1++;
        }
        else
        {
            i1 = 0;
        }
        
    }
}