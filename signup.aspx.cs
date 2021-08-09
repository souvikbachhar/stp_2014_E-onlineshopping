using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class signup : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter sda;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b_newlog_Click(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Rohan Bose\Desktop\New Folder (19)\bal\App_Data\data.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        string q = "insert into kkk values('" + rb_reg_gender.SelectedItem.Text + "','" +TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedItem.Text + "','" + TextBox6.Text + "')";
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        rb_reg_gender.SelectedIndex = -1;
        Response.Redirect("login2.aspx");
    }
}