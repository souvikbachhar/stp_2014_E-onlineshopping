using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class login2 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter sda;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (MultiView1.ActiveViewIndex == -1)
        {

            MultiView1.ActiveViewIndex = 0;
        }
        if (!IsPostBack)
        {
            Label12.Text = Session["x"].ToString();
            Label13.Text ="Rs"+ Session["y"].ToString();
            Label14.Text = Session["z"].ToString();
            Image7.ImageUrl = Session["w"].ToString();
        }
        if (MultiView1.ActiveViewIndex == 2)
        {
        }
    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {
       
        


    }
  
    protected void b_login_Click(object sender, EventArgs e)
    {
        int c=0;
        string s = "select * from kkk where e='"+TextBox1.Text+"'";
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        sda = new SqlDataAdapter(s, con);
        sda.Fill(ds, "t");
        c = ds.Tables["t"].Rows.Count;
       
        con.Close();
        if (c == 0)
        {
            Error.Text = "You are not a registered user.Sign Up first and then login again";
        }
        else
        {string p=ds.Tables["t"].Rows[0][2].ToString();
            if (TextBox2.Text !=p )
            {
                Error.Text = "EmailID and password does not match";
            }
            else
            {
                lll = 1;
                MultiView1.ActiveViewIndex = 1;
            }
        }
        
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        
    }
    static int lll = 0;
    protected void Button1_Click(object sender, EventArgs e)
    {
        lll = 0;
        TextBox1.Text = "";
        TextBox2.Text = "";
        //Label11.Text = "You have been logged out successfully";
        // Button2.CommandName = "SwitchViewByID";
        //Button2.CommandArgument = "View1";
        MultiView1.ActiveViewIndex = 0;
    }
    protected void MultiView1_ActiveViewChanged1(object sender, EventArgs e)
    {
        if (lll == 1)
        {
            MultiView1.ActiveViewIndex = 1;
        }
    }
    protected void LinkButton7_Click1(object sender, EventArgs e)
    {
        ImageButton1.Visible = false;

        Label11.Visible = true;
        Label12.Visible = false;
        Label13.Visible = false;
        Label14.Visible = false;
        Image7.Visible = false;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        lll = 3;
        ImageButton1.CommandName = "SwitchViewByID";
        ImageButton1.CommandArgument = "View3";
        Image8.ImageUrl = Image7.ImageUrl;
        Label15.Text = Label12.Text;
        Label16.Text = Label13.Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button2.CommandName = "SwitchViewByID";
        Button2.CommandArgument = "View2";
        Label11.Visible = true;
        Label11.Text = "Your product will reach to you in 3 days";
        Label12.Visible = false;
        Label13.Visible = false;
        Label14.Visible = false;
        Image7.Visible = false;
        ImageButton1.Visible = false;
        string d="undelivered";
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "insert into orders values('" + TextBox1.Text + "','" + Label15.Text + "','" + Label16.Text + "','" + TextBox3.Text + "','"+d+"')";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        con.Close();
        
   

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}