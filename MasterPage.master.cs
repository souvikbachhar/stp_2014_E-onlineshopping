using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    static int i = 0;
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        string[] s = { "~/img/1.jpg", "~/img/2.jpg", "~/img/3.jpg", "~/img/4.jpg", "~/img/5.jpg", "~/img/6.jpg", "~/img/7.jpg", "~/img/8.jpg", "~/img/9.jpg", "~/img/10.jpg", "~/img/11.jpg"};
        if (i < s.Length)
        {
            Image1.ImageUrl = s[i];
            i++;
        }
        else
        {
            i = 0;
        }
        

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }

    protected void b_admin_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("camera.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("mobile.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("tv2.aspx");
    }
    protected void b_login_Click(object sender, EventArgs e)
    {
        Response.Redirect("login2.aspx");
    }
    protected void b_register_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx"); 
    }
}
