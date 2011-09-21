using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Logon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdLogon_Click(object sender, EventArgs e)
    {
       /* if (System.Web.Security.FormsAuthentication.Authenticate(txtUsername.Text, txtPassword.Text))

         {
             System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
         }
        */

        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["DeVryRemotedb"];
        conn.ConnectionString = conString.ConnectionString;

        conn.Open();

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        comm.CommandText = "select firstname from Huber_Logon where userid = @userid and [password] = @pass";
        comm.Parameters.AddWithValue("@userid", txtUsername.Text);
        comm.Parameters.AddWithValue("@pass", txtPassword.Text);

        System.Data.SqlClient.SqlDataReader DR ;
        DR = comm.ExecuteReader();

        if (DR.HasRows)
        {
            //good
            System.Web.Security.FormsAuthentication.SetAuthCookie(txtUsername.Text, false);
            Response.Redirect("Default.aspx");
            lblError.Visible = false;
        }
        else 
        { 
            //bad
            lblError.Text = "Either your username or password was incorrect!";
            lblError.Visible = true;
        }

        conn.Close();
        conn.Dispose();

    }
}