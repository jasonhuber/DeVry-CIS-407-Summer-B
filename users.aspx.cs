using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class users : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        //http://pietschsoft.com/post/2005/12/28/ASPNET-20-How-to-get-a-specific-ConnectionString-from-the-WebConfig-by-name.aspx
        var conString = System.Configuration.ConfigurationManager.ConnectionStrings["DeVryRemotedb"];
        conn.ConnectionString = conString.ConnectionString;

        conn.Open();

        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand();
        comm.Connection = conn;
        comm.CommandText = "select *  from Huber_Logon";

        System.Data.SqlClient.SqlDataAdapter DA = new System.Data.SqlClient.SqlDataAdapter();
        System.Data.DataSet DS = new System.Data.DataSet();

        DA.SelectCommand = comm;
        DA.Fill(DS);

        rptUsers.DataSource = DS;
        rptUsers.DataBind();

        conn.Close();
        conn.Dispose();
    }

    protected void rptUsers_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }
}