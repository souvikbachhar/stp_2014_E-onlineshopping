using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class admin : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter sda;
    DataSet ds = new DataSet();
    SqlCommand cmd;
    void show()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "select * from laptop";
        sda = new SqlDataAdapter(q, con);
        sda.Fill(ds, "t");
        GridView2.DataSource = ds.Tables["t"];
        GridView2.DataBind();
        con.Close();
        
    }
    void show1()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q1 = "select * from Speaker";
        sda = new SqlDataAdapter(q1, con);
        sda.Fill(ds, "t1");
        GridView3.DataSource = ds.Tables["t1"];
        GridView3.DataBind();
        con.Close();

    }
    void show2()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q3 = "select * from headphone";
        sda = new SqlDataAdapter(q3, con);
        sda.Fill(ds, "t3");
        GridView4.DataSource = ds.Tables["t3"];
        GridView4.DataBind();
        con.Close();

    }

    void show3()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q3 = "select * from mobile";
        sda = new SqlDataAdapter(q3, con);
        sda.Fill(ds, "t4");
        GridView5.DataSource = ds.Tables["t4"];
        GridView5.DataBind();
        con.Close();

    }
    void show4()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q3 = "select * from Camera";
        sda = new SqlDataAdapter(q3, con);
        sda.Fill(ds, "t5");
        GridView6.DataSource = ds.Tables["t5"];
        GridView6.DataBind();
        con.Close();

    }
    void show5()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q3 = "select * from tv";
        sda = new SqlDataAdapter(q3, con);
        sda.Fill(ds, "t6");
        GridView7.DataSource = ds.Tables["t6"];
        GridView7.DataBind();
        con.Close();

    }
    void show6()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q3 = "select * from kkk";
        sda = new SqlDataAdapter(q3, con);
        sda.Fill(ds, "t7");
        GridView8.DataSource = ds.Tables["t7"];
        GridView8.DataBind();
        con.Close();

    }
    /*void show7()
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q3 = "select * from orders";
        sda = new SqlDataAdapter(q3, con);
        sda.Fill(ds, "t7");
        GridView8.DataSource = ds.Tables["t7"];
        GridView8.DataBind();
        con.Close();

    }*/
    static int ll = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (MultiView1.ActiveViewIndex == -1)
        {
            
            MultiView1.ActiveViewIndex = 1;
        }
       
        if (!Page.IsPostBack)
        {
            GridView8.Visible = false;
            GridView2.Visible = false;
            GridView3.Visible = false;
            GridView4.Visible = false;
            GridView5.Visible = false;
            GridView7.Visible = false;
            GridView6.Visible = false;
            show3();
            show();
            show1();
            show2();
            show4();
            show5();
           // show6();
            //show7();
        }
       
       
    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {
        if (ll == 1)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "abhirup" && TextBox2.Text == "1234")
        {
            ll = 1;
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label1.Text = "";
           // Button1.CommandName = "SwitchViewByID";
            //Button1.CommandArgument = "View2";
            MultiView1.ActiveViewIndex = 0;
        }
        else
        {
            Label1.Text = "UserID and password does not match";
            Button1.CommandName = "SwitchViewByID";
            Button1.CommandArgument = "View1";
        }
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        GridView4.Visible = false;
        Label10.Visible = false;
        GridView2.Visible = true; GridView7.Visible = false;
        GridView3.Visible = false; GridView9.Visible = false;
        GridView5.Visible = false;
        GridView8.Visible = false;
        GridView6.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ll = 0;
        TextBox1.Text = "";
        TextBox2.Text = "";
        Label11.Text="You have been logged out successfully";
       // Button2.CommandName = "SwitchViewByID";
        //Button2.CommandArgument = "View1";
        MultiView1.ActiveViewIndex = 1;
        Label10.Visible = true;
        GridView2.Visible = false; GridView9.Visible = false;
        GridView3.Visible = false;
        GridView4.Visible = false;
        GridView5.Visible = false; GridView7.Visible = false;
        GridView8.Visible = false;
        GridView6.Visible = false;
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView2.EditIndex = e.NewEditIndex;
        show();
    }
    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView2.EditIndex = -1;
        show();
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        show();
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sn = ((Label)(GridView2.Rows[e.RowIndex].FindControl("Label3"))).Text;
        
        
            string s = "delete from laptop where Name='" + sn + "'";
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            show();
        
    }
    protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string p1 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox3"))).Text;
        string p2 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox4"))).Text;
        string p3 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox5"))).Text;
        string p4 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox6"))).Text;
        string p5 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox7"))).Text;
        string p6 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox8"))).Text;
        string p7 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox9"))).Text;
        string p8 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox10"))).Text;
        string p9 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox11"))).Text;
        string p10 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox12"))).Text;
        string p11 = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("Textbox13"))).Text;

        string p12 = ((Label)(GridView2.Rows[e.RowIndex].FindControl("Label2"))).Text;
    
        //   int ag = Convert.ToInt32(a);
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "update laptop set Name='" + p1 + "',Price='" + p2 + "',Brand='" + p3 + "',Processor='" + p4 + "',HDD='" + p5 + "',RAM='" + p6 + "',Graphics='" + p7 + "',img1='" + p8 + "',img2='" + p9 + "',img3='" + p10 + "',img4='" + p11 + "' where ID='" + p12 + "'";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        GridView2.EditIndex = -1;
        show();
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        GridView6.Visible = false; GridView9.Visible = false;
        GridView4.Visible = false;
        Label10.Visible = false;
        GridView2.Visible = false;
        GridView3.Visible = true; GridView7.Visible = false;
        GridView8.Visible = false;
        GridView5.Visible = false;

    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView3.EditIndex = e.NewEditIndex;
        show1();
    }
    protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView3.EditIndex = -1;
        show1();
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        show1();
    }
    protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sn = ((Label)(GridView3.Rows[e.RowIndex].FindControl("Label13"))).Text;


        string s = "delete from Speaker where Name='" + sn + "'";
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        show1();

    }
    protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string p1 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox14"))).Text;
        string p2 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox15"))).Text;
        string p3 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox16"))).Text;
        string p4 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox17"))).Text;
        string p5 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox18"))).Text;
        string p6 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox19"))).Text;
        string p7 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox20"))).Text;
        string p8 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox21"))).Text;
        string p9 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox22"))).Text;
        string p10 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox23"))).Text;
        string p11 = ((TextBox)(GridView3.Rows[e.RowIndex].FindControl("Textbox24"))).Text;

        string p12 = ((Label)(GridView3.Rows[e.RowIndex].FindControl("Label12"))).Text;

        //   int ag = Convert.ToInt32(a);
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "update Speaker set Name='" + p1 + "',Brand='" + p2 + "',Price='" + p3 + "',Type='" + p4 + "',s1='" + p5 + "',s2='" + p6 + "',s3='" + p7 + "',img1='" + p8 + "',img2='" + p9 + "',img3='" + p10 + "',img4='" + p11 + "' where ID='" + p12 + "'";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        GridView3.EditIndex = -1;
        show1();
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        GridView6.Visible = false;
        Label10.Visible = false;
        GridView4.Visible = true;
        GridView3.Visible = false; GridView9.Visible = false;
        GridView2.Visible = false; GridView7.Visible = false;
        GridView8.Visible = false;
        GridView5.Visible = false;
    }
    protected void GridView4_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView4.EditIndex = e.NewEditIndex;
        show2();
    }
    protected void GridView4_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView4.EditIndex = -1;
        show2();
    }
    protected void GridView4_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView4.PageIndex = e.NewPageIndex;
        show2();
    }
    protected void GridView4_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sn = ((Label)(GridView4.Rows[e.RowIndex].FindControl("Label20"))).Text;


        string s = "delete from headphone where Name='" + sn + "'";
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        show2();

    }
    protected void GridView4_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
       
        string p1 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox25"))).Text;
        string p2 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox26"))).Text;
        string p3 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox27"))).Text;
        string p4 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox28"))).Text;
        string p5 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox29"))).Text;
        string p6 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox30"))).Text;
        string p7 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox31"))).Text;
        string p8 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox32"))).Text;
        string p9 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox33"))).Text;
        string p10 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox34"))).Text;
        string p11 = ((TextBox)(GridView4.Rows[e.RowIndex].FindControl("Textbox35"))).Text;

        string p12 = ((Label)(GridView4.Rows[e.RowIndex].FindControl("Label20"))).Text;

        //   int ag = Convert.ToInt32(a);
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "update headphone set Name='" + p1 + "',Brand='" + p2 + "',Price='" + p3 + "',s1='" + p4 + "',s2='" + p5 + "',s3='" + p6 + "',s4='" + p7 + "',img1='" + p8 + "',img2='" + p9 + "',img3='" + p10 + "',img4='" + p11 + "' where ID='" + p12 + "'";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        GridView4.EditIndex = -1;
        show2();
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        GridView6.Visible = false;
        Label10.Visible = true; GridView9.Visible = false;
        GridView4.Visible = false;
        GridView3.Visible = false;
        GridView2.Visible = false;
        GridView5.Visible = false; GridView7.Visible = false;
        GridView8.Visible = false;
    }
    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView5_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView5.PageIndex = e.NewPageIndex;
        show3();

    }
    protected void GridView5_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView5.EditIndex = -1;
        show3();
    }
    protected void GridView5_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sn = ((Label)(GridView5.Rows[e.RowIndex].FindControl("Label28"))).Text;


        string s = "delete from mobile where Name='" + sn + "'";
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        show3();
    }
    protected void GridView5_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView5.EditIndex = e.NewEditIndex;
        show3();
    }
    protected void GridView5_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string p1 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox36"))).Text;
        string p2 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox37"))).Text;
        string p3 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox38"))).Text;
        string p4 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox39"))).Text;
        string p5 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox40"))).Text;
        string p6 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox41"))).Text;
        string p7 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox42"))).Text;
        string p8 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox43"))).Text;
        string p9 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox44"))).Text;
        string p10 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox45"))).Text;
        string p11 = ((TextBox)(GridView5.Rows[e.RowIndex].FindControl("Textbox46"))).Text;

        string p12 = ((Label)(GridView5.Rows[e.RowIndex].FindControl("Label28"))).Text;

        //   int ag = Convert.ToInt32(a);
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "update mobile set Name='" + p1 + "',Price='" + p2 + "',Brand='" + p3 + "',Processor='" + p4 + "',Type='" + p5 + "',RAM='" + p6 + "',OS='" + p7 + "',img1='" + p8 + "',img2='" + p9 + "',img3='" + p10 + "',img4='" + p11 + "' where ID='" + p12 + "'";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        GridView5.EditIndex = -1;
        show3();

    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        GridView4.Visible = false; GridView9.Visible = false;
        Label10.Visible = false;
        GridView2.Visible = false;
        GridView3.Visible = false ;
        GridView5.Visible = true;
        GridView6.Visible = false; GridView7.Visible = false;
        GridView8.Visible = false;

    }
    protected void GridView6_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView6.PageIndex = e.NewPageIndex;
        show4();
    }
    protected void GridView6_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView6.EditIndex = -1;
        show4();
    }
    protected void GridView6_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sn = ((Label)(GridView5.Rows[e.RowIndex].FindControl("Label36"))).Text;


        string s = "delete from Camerea where Name='" + sn + "'";
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        show4();

    }
    protected void GridView6_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView6.EditIndex = e.NewEditIndex;
        show4();

    }
    protected void GridView6_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string p1 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox47"))).Text;
        string p2 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox48"))).Text;
        string p3 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox49"))).Text;
        string p4 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox50"))).Text;
        string p5 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox51"))).Text;
        
        string p8 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox54"))).Text;
        string p9 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox55"))).Text;
        string p10 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox56"))).Text;
        string p11 = ((TextBox)(GridView6.Rows[e.RowIndex].FindControl("Textbox57"))).Text;

        string p12 = ((Label)(GridView6.Rows[e.RowIndex].FindControl("Label36"))).Text;

        //   int ag = Convert.ToInt32(a);
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "update Camera set Name='" + p1 + "',Price='" + p2 + "',Brand='" + p3 + "',Quality='" + p4 + "',Type='" + p5 + "',img1='" + p8 + "',img2='" + p9 + "',img3='" + p10 + "',img4='" + p11 + "' where ID='" + p12 + "'";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        GridView6.EditIndex = -1;
        show4();
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        GridView4.Visible = false;
        Label10.Visible = false; GridView9.Visible = false;
        GridView2.Visible = false;
        GridView3.Visible = false;
        GridView5.Visible = false ;
        GridView6.Visible = true;
        GridView7.Visible = false;
        GridView8.Visible = false;
    }
    protected void GridView7_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        GridView7.PageIndex = e.NewPageIndex;
        show5();
    }
    protected void GridView7_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView7.EditIndex = -1;
        show5();
    }
    protected void GridView7_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sn = ((Label)(GridView7.Rows[e.RowIndex].FindControl("Label42"))).Text;


        string s = "delete from tv where Name='" + sn + "'";
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        show5();

    }
    protected void GridView7_RowEditing(object sender, GridViewEditEventArgs e)
    {

        GridView7.EditIndex = e.NewEditIndex;
        show5();

    }
    protected void GridView7_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string p1 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox58"))).Text;
        string p2 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox59"))).Text;
        string p3 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox60"))).Text;
        string p4 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox61"))).Text;
        string p5 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox62"))).Text;
        string p6 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox63"))).Text;
        string p7 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox64"))).Text;
        string p8 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox69"))).Text;
        string p9 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox70"))).Text;
        string p10 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox71"))).Text;
        

        string p12 = ((Label)(GridView7.Rows[e.RowIndex].FindControl("Label42"))).Text;

        string p13 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox72"))).Text;
        string p14 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox65"))).Text;
        string p15 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox66"))).Text;
        string p16 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox67"))).Text;
        string p17 = ((TextBox)(GridView7.Rows[e.RowIndex].FindControl("Textbox68"))).Text;

        //   int ag = Convert.ToInt32(a);
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "update mobile set Name='" + p1 + "',Price='" + p2 + "',Brand='" + p3 + "',screen_type='" + p4 + "',display_size='" + p5 + "',hd_technology_resolution='" + p6 + "',3d='" + p7 + "',smart_tv='" + p8 + "',hdmi='" + p9 + "',usb='" + p10 + "',wifi='" + p13 + "',img1='" + p14 + "',img2='" + p15 + "',img3='" + p16 + "',img4='" + p17 + "' where ID='" + p12 + "'";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        GridView7.EditIndex = -1;
        show5();
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        GridView4.Visible = false;
        Label10.Visible = false;
        GridView2.Visible = false;
        GridView3.Visible = false;
        GridView5.Visible = false;
        GridView6.Visible = false;
        GridView7.Visible = true;
        GridView8.Visible = false; GridView9.Visible = false;
    }
    protected void GridView7_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView7_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GridView8_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView8.PageIndex = e.NewPageIndex;
     //   show6();

    }
}