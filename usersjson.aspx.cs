using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usersjson : System.Web.UI.Page
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
        comm.CommandText = "select userid, email  from Huber_Logon";

        System.Data.SqlClient.SqlDataAdapter DA = new System.Data.SqlClient.SqlDataAdapter();

        System.Data.SqlClient.SqlDataReader dr;
        dr = comm.ExecuteReader();

        Response.Write("{\"users\":[");
        string output = "";
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                output += "{\"userid\": \"" + dr.GetValue(0) + "\",\"email\": \"" + dr.GetValue(1) + "\"},";
            }
            output = output.Substring(0,output.Length-1);
            Response.Write(output);
        }

        Response.Write("]}");

        conn.Close();
        conn.Dispose();



        /*,
        {
            "userid": "Carol",
            "email": "carol@jas..com"
        }*/

    }
}